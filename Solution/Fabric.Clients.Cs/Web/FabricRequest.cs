using System;
using System.IO;
using System.Net;
using System.Text;
using Fabric.Clients.Cs.Session;
using ServiceStack.Text;
using FabError = Fabric.Clients.Cs.Api.FabError;
using FabOauthError = Fabric.Clients.Cs.Api.FabOauthError;

namespace Fabric.Clients.Cs.Web {
	
	/*================================================================================================*/
	internal class FabricRequest<T> {

		public string Method { get; private set; }
		public string Path { get; private set; }
		public string Query { get; private set; }
		public string Post { get; private set; }

		private FabricHttpProvider vWebReqProv;


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabricRequest(string pMethod, string pPath, string pQuery=null, string pPost=null) 
							: this(new FabricHttpProvider(), pMethod, pPath, pQuery, pPost) {
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public FabricRequest(FabricHttpProvider pProvider,
								string pMethod, string pPath, string pQuery=null, string pPost=null) {
			vWebReqProv = pProvider;
			Method = pMethod;
			Path = pPath;
			Query = pQuery;
			Post = pPost;
		}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public T Send(ClientContext pContext) {
			FabricResponse<T> resp = GetFabricResponse(pContext);

			if ( resp.Error != null ) {
				pContext.Config.LogError("Request Exception: "+
					resp.Error.Code+" / "+resp.Error.Name+" / "+resp.Error.Message);
				throw new FabricErrorException(resp.Error);
			}

			if ( resp.OauthError != null ) {
				pContext.Config.LogError("Request OAuth Exception: "+
					resp.OauthError.error+" / "+resp.OauthError.error_description);
				throw new FabricErrorException(resp.OauthError);
			}

			return resp.Data;
		}

		/*--------------------------------------------------------------------------------------------*/
		private FabricResponse<T> GetFabricResponse(ClientContext pContext) {
			string fullPath = pContext.Config.ApiPath+Path+(Query != null ? "?"+Query : "");
			pContext.Config.LogInfo("Request initiated...");

			////

			IFabricHttpResponse wr = null;
			
			try {
				wr = GetHttpWebResponse(pContext, fullPath);
				pContext.Config.LogInfo("Request Path: "+Method+" "+Path);
				pContext.Config.LogInfo("Request URL: "+fullPath);

				string data = StreamToString(wr.GetResponseStream());
				pContext.Config.LogDebug("Request Response: "+data);
				return new FabricResponse<T>(JsonSerializer.DeserializeFromString<T>(data));
				/*return new FabricResponse<T>(
					JsonSerializer.DeserializeFromStream<T>(wr.GetResponseStream()));*/
			}
			catch ( WebException we ) {
				if ( we.Response == null ) {
					throw new Exception("No Fabric response from "+Method+" "+fullPath);
				}

				string data = StreamToString(we.Response.GetResponseStream());
				bool isOauthErr = (data.Substring(0,9) == "{\"error\":");
				pContext.Config.LogDebug("Request Error: "+data+" (IsOauthError="+isOauthErr+")");

				if ( isOauthErr ) {
					FabOauthError oerr = JsonSerializer.DeserializeFromString<FabOauthError>(data);
					return new FabricResponse<T>(oerr);
				}
				else {
					FabError err = JsonSerializer.DeserializeFromString<FabError>(data);
					return new FabricResponse<T>(err);
				}
			}
		}

		/*--------------------------------------------------------------------------------------------*/
		private IFabricHttpResponse GetHttpWebResponse(ClientContext pContext, string pFullPath) {
			IFabricHttpRequest req = vWebReqProv.CreateRequest(pFullPath);
			req.Method = Method;
			req.Accept = "application/json";

			IFabricPersonSession auth = pContext.PersonSess;
			auth.RefreshTokenIfNecessary();
			string token = auth.BearerToken;

			if ( token == null && pContext.AppSess != null ) {
				IFabricAppSession appAuth = pContext.AppSess;
				appAuth.RefreshTokenIfNecessary();
				token = appAuth.BearerToken;
			}

			if ( token != null ) {
				req.Headers.Add("Authorization", "Bearer "+token);
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

		/*--------------------------------------------------------------------------------------------*/
		private string StreamToString(Stream pStream) {
			return new StreamReader(pStream).ReadToEnd();
		}

	}

}