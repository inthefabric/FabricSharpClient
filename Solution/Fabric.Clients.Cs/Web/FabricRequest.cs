using System;
using System.IO;
using System.Net;
using System.Text;
using Fabric.Clients.Cs.Api;
using Fabric.Clients.Cs.Session;
using ServiceStack.Text;

namespace Fabric.Clients.Cs.Web {
	
	/*================================================================================================*/
	internal class FabricRequest<T> {

		public string Method { get; private set; }
		public string Path { get; private set; }
		public string Query { get; private set; }
		public string Post { get; private set; }

		private readonly FabricHttpProvider vWebReqProv;
		private IFabricOauthSession vSess;


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabricRequest(string pMethod, string pPath, string pQuery=null, string pPost=null) :
										this(new FabricHttpProvider(), pMethod, pPath, pQuery, pPost) {
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public FabricRequest(FabricHttpProvider pProvider, string pMethod, string pPath, 
																string pQuery=null, string pPost=null) {
			vWebReqProv = pProvider;
			Method = pMethod;
			Path = pPath;
			Query = pQuery;
			Post = pPost;
		}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public T Send(IClientContext pContext, SessionType pSessionType) {
			switch ( pSessionType ) {
				case SessionType.Default:
					vSess = pContext.ActiveSess;
					break;

				case SessionType.App:
					vSess = pContext.AppSess;
					break;

				case SessionType.Person:
					vSess = pContext.PersonSess;
					break;
			}

			pContext.LogDebug("SEND: "+pSessionType+" / "+vSess+" / "+pContext.AppSess);
			FabricResponse<T> resp = GetFabricResponse(pContext);

			if ( resp.RespError != null ) {
				pContext.LogError("Request Exception: "+resp.RespError.Error.Code+" / "+
					resp.RespError.Error.Name+" / "+resp.RespError.Error.Message);
				throw new FabricErrorException(resp.RespError);
			}

			if ( resp.OauthError != null ) {
				pContext.LogError("Request OAuth Exception: "+
					resp.OauthError.error+" / "+resp.OauthError.error_description);
				throw new FabricErrorException(resp.OauthError);
			}

			return resp.Data;
		}

		/*--------------------------------------------------------------------------------------------*/
		protected virtual FabricResponse<T> GetFabricResponse(IClientContext pContext) {
			string fullPath = pContext.Config.ApiPath+Path+(Query != null ? "?"+Query : "");
			pContext.LogInfo("Request initiated...");

			////

			try {
				pContext.LogInfo("Request Path: "+Method+" "+Path);
				pContext.LogInfo("Request URL: "+fullPath);

				IFabricHttpResponse wr = GetHttpWebResponse(fullPath);

				string data = StreamToString(wr.GetResponseStream());
				pContext.LogDebug("Request Response: "+data);
				return new FabricResponse<T>(JsonSerializer.DeserializeFromString<T>(data));
			}
			catch ( WebException we ) {
				if ( we.Response == null ) {
					throw new Exception("No Fabric response from "+Method+" "+fullPath);
				}

				string data = StreamToString(we.Response.GetResponseStream());
				bool isOauthErr = (data.Length > 9 && data.Substring(0, 9) == "{\"error\":");
				bool isRespErr = typeof(FabResponse).IsAssignableFrom(typeof(T));

				pContext.LogDebug("Request Error: "+data+
					" (IsError="+isRespErr+", IsOauthError="+isOauthErr+")");

				if ( isRespErr ) {
					FabResponse frErr = JsonSerializer.DeserializeFromString<FabResponse>(data);
					return new FabricResponse<T>(frErr, we);
				}

				if ( isOauthErr ) {
					FabOauthError oerr = JsonSerializer.DeserializeFromString<FabOauthError>(data);
					return new FabricResponse<T>(oerr, we);
				}

				throw;
			}
		}

		/*--------------------------------------------------------------------------------------------*/
		protected IFabricHttpResponse GetHttpWebResponse(string pFullPath) {
			IFabricHttpRequest req = vWebReqProv.CreateRequest(pFullPath);
			req.Method = Method;
			req.Accept = "application/json";

			vSess.RefreshTokenIfNecessary(Path);

			if ( vSess.BearerToken != null ) {
				req.Headers.Add("Authorization", "Bearer "+vSess.BearerToken);
			}

			if ( Method == "POST" && Post != null ) {
				req.ContentType = "application/x-www-form-urlencoded";

				byte [] bytes = Encoding.ASCII.GetBytes(Post);
				req.ContentLength = bytes.Length;

				Stream os = req.GetRequestStream();
				os.Write(bytes, 0, bytes.Length);
				os.Close();
			}

			return vWebReqProv.GetResponse(req);
		}


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		protected static string StreamToString(Stream pStream) {
			return new StreamReader(pStream).ReadToEnd();
		}

		/*--------------------------------------------------------------------------------------------*/
		protected static string GetErrorPayload(string pFabResponseJson) {
			int i0 = pFabResponseJson.IndexOf("\"Data\":\"");

			if ( i0 == -1 ) {
				return null;
			}

			i0 += 8;
			int count = 0;
			int n = pFabResponseJson.Length;
			int i1 = -1;

			for ( int i = i0 ; i < n ; ++i ) {
				char c = pFabResponseJson[i];
				if ( c == '{' ) { ++count; }
				if ( c == '}' ) { --count; }

				if ( count == 0 ) {
					i1 = i+1;
					break;
				}
			}

			return pFabResponseJson.Substring(i0, i1-i0);
		}

	}

}