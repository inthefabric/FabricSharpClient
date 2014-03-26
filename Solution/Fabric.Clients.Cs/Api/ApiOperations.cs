// GENERATED CODE
// Changes made to this source file will be overwritten

using Fabric.Clients.Cs.Session;
using Fabric.Clients.Cs.Web;
using ServiceStack.Text;

namespace Fabric.Clients.Cs.Api {

	// ReSharper disable InconsistentNaming
	// ReSharper disable RedundantArgumentDefaultValue

	/*================================================================================================*/
	/// <summary>
	///   Get the latest specifications and documentation for all Fabric API services.
	/// </summary>
	/// <remarks>
	///   <para>Get the latest specifications and documentation for all Fabric API services. This is useful for building Fabric API clients and reference documentation sites like the one you are viewing right now.</para>
	/// </remarks>
	public interface IMetaSpecGetOperation : IOperation {
		
		/// <summary>
		///   Perform the operation.
		/// </summary>
		FabResponse<FabSpec> Get();

	}
	

	/*================================================================================================*/
	internal class MetaSpecGetOperation : IMetaSpecGetOperation {

		public const string Uri = "/Meta/Spec";
		
		public string Method { get { return "GET"; } }
		public string RequiredAuth { get { return "None"; } }
		
		private readonly IClientContext vContext;
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public MetaSpecGetOperation(IClientContext pContext) {
			vContext = pContext;
		}

		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabricRequest<FabResponse<FabSpec>> Request() {
			return new FabricRequest<FabResponse<FabSpec>>("GET", Uri,
				null,
				null
			);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public FabResponse<FabSpec> Get() {
			return Request().Send(vContext);
		}

	}


	/*================================================================================================*/
	/// <summary>
	///   Get the current Fabric version.
	/// </summary>
	/// <remarks>
	///   <para>Get the current Fabric version.</para>
	/// </remarks>
	public interface IMetaVersionGetOperation : IOperation {
		
		/// <summary>
		///   Perform the operation.
		/// </summary>
		FabResponse<FabMetaVersion> Get();

	}
	

	/*================================================================================================*/
	internal class MetaVersionGetOperation : IMetaVersionGetOperation {

		public const string Uri = "/Meta/Version";
		
		public string Method { get { return "GET"; } }
		public string RequiredAuth { get { return "None"; } }
		
		private readonly IClientContext vContext;
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public MetaVersionGetOperation(IClientContext pContext) {
			vContext = pContext;
		}

		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabricRequest<FabResponse<FabMetaVersion>> Request() {
			return new FabricRequest<FabResponse<FabMetaVersion>>("GET", Uri,
				null,
				null
			);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public FabResponse<FabMetaVersion> Get() {
			return Request().Send(vContext);
		}

	}


	/*================================================================================================*/
	/// <summary>
	///   Get the current Fabric server time.
	/// </summary>
	/// <remarks>
	///   <para>Get the current Fabric server time.</para>
	/// </remarks>
	public interface IMetaTimeGetOperation : IOperation {
		
		/// <summary>
		///   Perform the operation.
		/// </summary>
		FabResponse<FabMetaTime> Get();

	}
	

	/*================================================================================================*/
	internal class MetaTimeGetOperation : IMetaTimeGetOperation {

		public const string Uri = "/Meta/Time";
		
		public string Method { get { return "GET"; } }
		public string RequiredAuth { get { return "None"; } }
		
		private readonly IClientContext vContext;
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public MetaTimeGetOperation(IClientContext pContext) {
			vContext = pContext;
		}

		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabricRequest<FabResponse<FabMetaTime>> Request() {
			return new FabricRequest<FabResponse<FabMetaTime>>("GET", Uri,
				null,
				null
			);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public FabResponse<FabMetaTime> Get() {
			return Request().Send(vContext);
		}

	}


	/*================================================================================================*/
	/// <summary>
	///   Create a new Class.
	/// </summary>
	/// <remarks>
	///   <para>Create a new Class. Attach Factors to this Class immediately after creation to give it meaning and relevance within Fabric.</para>
	/// </remarks>
	public interface IModifyClassesPostOperation : IOperation {
		
		/// <summary>
		///   Perform the operation.
		/// </summary>
		/// <param name="Data">
		///   The data (in JSON format) for the new Class.
		/// </param>
		FabResponse<FabClass> Post(CreateFabClass Data);

	}
	

	/*================================================================================================*/
	internal class ModifyClassesPostOperation : IModifyClassesPostOperation {

		public const string Uri = "/Mod/Classes";
		
		public string Method { get { return "POST"; } }
		public string RequiredAuth { get { return "Member"; } }
		
		private readonly IClientContext vContext;
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public ModifyClassesPostOperation(IClientContext pContext) {
			vContext = pContext;
		}

		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabricRequest<FabResponse<FabClass>> Request(CreateFabClass Data) {
			return new FabricRequest<FabResponse<FabClass>>("POST", Uri,
				null,
				"Data="+Data.ToJson()
			);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public FabResponse<FabClass> Post(CreateFabClass Data) {
			return Request(Data).Send(vContext);
		}

	}


	/*================================================================================================*/
	/// <summary>
	///   Create a new Factor.
	/// </summary>
	/// <remarks>
	///   <para>Create a new Factor. The Factor begins in the 'incomplete' state, with no FactorElements attached.</para>
	/// </remarks>
	public interface IModifyFactorsPostOperation : IOperation {
		
		/// <summary>
		///   Perform the operation.
		/// </summary>
		/// <param name="Data">
		///   The data (in JSON format) for the new Factor.
		/// </param>
		FabResponse<FabFactor> Post(CreateFabFactor Data);

	}
	

	/*================================================================================================*/
	internal class ModifyFactorsPostOperation : IModifyFactorsPostOperation {

		public const string Uri = "/Mod/Factors";
		
		public string Method { get { return "POST"; } }
		public string RequiredAuth { get { return "Member"; } }
		
		private readonly IClientContext vContext;
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public ModifyFactorsPostOperation(IClientContext pContext) {
			vContext = pContext;
		}

		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabricRequest<FabResponse<FabFactor>> Request(CreateFabFactor Data) {
			return new FabricRequest<FabResponse<FabFactor>>("POST", Uri,
				null,
				"Data="+Data.ToJson()
			);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public FabResponse<FabFactor> Post(CreateFabFactor Data) {
			return Request(Data).Send(vContext);
		}

	}


	/*================================================================================================*/
	/// <summary>
	///   Create a new Instance.
	/// </summary>
	/// <remarks>
	///   <para>Create a new Instance. Attach Factors to this Instance immediately after creation to give it meaning and relevance within Fabric.</para>
	/// </remarks>
	public interface IModifyInstancesPostOperation : IOperation {
		
		/// <summary>
		///   Perform the operation.
		/// </summary>
		/// <param name="Data">
		///   The data (in JSON format) for the new Instance.
		/// </param>
		FabResponse<FabInstance> Post(CreateFabInstance Data);

	}
	

	/*================================================================================================*/
	internal class ModifyInstancesPostOperation : IModifyInstancesPostOperation {

		public const string Uri = "/Mod/Instances";
		
		public string Method { get { return "POST"; } }
		public string RequiredAuth { get { return "Member"; } }
		
		private readonly IClientContext vContext;
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public ModifyInstancesPostOperation(IClientContext pContext) {
			vContext = pContext;
		}

		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabricRequest<FabResponse<FabInstance>> Request(CreateFabInstance Data) {
			return new FabricRequest<FabResponse<FabInstance>>("POST", Uri,
				null,
				"Data="+Data.ToJson()
			);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public FabResponse<FabInstance> Post(CreateFabInstance Data) {
			return Request(Data).Send(vContext);
		}

	}


	/*================================================================================================*/
	/// <summary>
	///   Create a new Member.
	/// </summary>
	/// <remarks>
	///   <para>Create a new Member.</para>
	/// </remarks>
	public interface IModifyMembersPostOperation : IOperation {
		
		/// <summary>
		///   Perform the operation.
		/// </summary>
		/// <param name="Data">
		///   The data (in JSON format) for the new Member.
		/// </param>
		FabResponse<FabMember> Post(CreateFabMember Data);

	}
	

	/*================================================================================================*/
	internal class ModifyMembersPostOperation : IModifyMembersPostOperation {

		public const string Uri = "/Mod/Members";
		
		public string Method { get { return "POST"; } }
		public string RequiredAuth { get { return "Member"; } }
		
		private readonly IClientContext vContext;
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public ModifyMembersPostOperation(IClientContext pContext) {
			vContext = pContext;
		}

		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabricRequest<FabResponse<FabMember>> Request(CreateFabMember Data) {
			return new FabricRequest<FabResponse<FabMember>>("POST", Uri,
				null,
				"Data="+Data.ToJson()
			);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public FabResponse<FabMember> Post(CreateFabMember Data) {
			return Request(Data).Send(vContext);
		}

	}


	/*================================================================================================*/
	/// <summary>
	///   Create a new Url.
	/// </summary>
	/// <remarks>
	///   <para>Create a new Url.</para>
	/// </remarks>
	public interface IModifyUrlsPostOperation : IOperation {
		
		/// <summary>
		///   Perform the operation.
		/// </summary>
		/// <param name="Data">
		///   The data (in JSON format) for the new Url.
		/// </param>
		FabResponse<FabUrl> Post(CreateFabUrl Data);

	}
	

	/*================================================================================================*/
	internal class ModifyUrlsPostOperation : IModifyUrlsPostOperation {

		public const string Uri = "/Mod/Urls";
		
		public string Method { get { return "POST"; } }
		public string RequiredAuth { get { return "Member"; } }
		
		private readonly IClientContext vContext;
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public ModifyUrlsPostOperation(IClientContext pContext) {
			vContext = pContext;
		}

		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabricRequest<FabResponse<FabUrl>> Request(CreateFabUrl Data) {
			return new FabricRequest<FabResponse<FabUrl>>("POST", Uri,
				null,
				"Data="+Data.ToJson()
			);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public FabResponse<FabUrl> Post(CreateFabUrl Data) {
			return Request(Data).Send(vContext);
		}

	}


	/*================================================================================================*/
	/// <summary>
	///   Get an OAuth access token using one of four 'flows'.
	/// </summary>
	/// <remarks>
	///   <para>Get an OAuth access token using one of four 'flows'.  Fabric offers separate requests for these access token flows, but also provides this generic request for compatibility with the OAuth 2.0 specification.  See the other access token flows (such as the 'Client Credentials' flow) for information about the available OAuth flows.</para>
	///   <para>An OAuth access token must be included with every Fabric API request (with the exception of the OAuth requests).  This token is the result of a successful login, an accepted App scope, a confirmed App secret code, and a confirmed authorization code.  Thus, each token is associated with a specific App, User, and successful OAuth process.  When included with an API request, Fabric obtains the relevant App and User ID values, and generates a response accordingly.</para>
	///   <para>See FabOauthAccess for information on how to include an OAuth access token with a Fabric API request.</para>
	/// </remarks>
	public interface IOauthAccessTokenGetOperation : IOperation {
		
		/// <summary>
		///   Perform the operation.
		/// </summary>
		/// <param name="grant_type">
		///   Defines the desired access token flow.  The three accepted (case-sensitive) values are 'authorization_code', 'refresh', and 'client_credentials'.
		/// </param>
		/// <param name="client_id">
		///   The App ID value (an integer) for the App making the request. This parameter is only used by the 'Client Credentials' flow.
		/// </param>
		/// <param name="client_secret">
		///   The alpha-numeric Secret for the App making the request. This verifies that the App itself is making the request, and not an imposter.  For this reason, the secret code should not be shared with anyone.
		/// </param>
		/// <param name="code">
		///   The authorization code obtained after a successful OAuth entry process. This parameter is only used by the 'Authorization Code' flow.
		/// </param>
		/// <param name="refresh_token">
		///   The refresh token obtained after a successful 'Authorization Code' access token flow.  A refresh token only applies to User-based OAuth sessions, not for App-based OAuth sessions.  This parameter is only used by the 'Refresh' flow.
		/// </param>
		/// <param name="redirect_uri">
		///   This value must be exactly the same as the redirect URI provided for the OAuth entry process.
		/// </param>
		FabOauthAccess Get(string grant_type, long client_id, string client_secret, string code, string refresh_token, string redirect_uri);

	}
	

	/*================================================================================================*/
	internal class OauthAccessTokenGetOperation : IOauthAccessTokenGetOperation {

		public const string Uri = "/Oauth/AccessToken";
		
		public string Method { get { return "GET"; } }
		public string RequiredAuth { get { return "None"; } }
		
		private readonly IClientContext vContext;
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public OauthAccessTokenGetOperation(IClientContext pContext) {
			vContext = pContext;
		}

		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabricRequest<FabOauthAccess> Request(string grant_type, long client_id, string client_secret, string code, string refresh_token, string redirect_uri) {
			return new FabricRequest<FabOauthAccess>("GET", Uri,
				"grant_type="+grant_type+"&client_id="+client_id+"&client_secret="+client_secret+"&code="+code+"&refresh_token="+refresh_token+"&redirect_uri="+redirect_uri,
				null
			);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public FabOauthAccess Get(string grant_type, long client_id, string client_secret, string code, string refresh_token, string redirect_uri) {
			return Request(grant_type, client_id, client_secret, code, refresh_token, redirect_uri).Send(vContext);
		}

	}


	/*================================================================================================*/
	/// <summary>
	///   This OAuth flow should be used immediately after obtaining an authorization code from the OAuth entry process.
	/// </summary>
	/// <remarks>
	///   <para>This OAuth flow should be used immediately after obtaining an authorization code from the OAuth entry process. Fabric verifies the authorization code, determines the associated App and User IDs, and generates a new access token.</para>
	///   <para>See Access Token for general information about the OAuth process.</para>
	/// </remarks>
	public interface IOauthAccessTokenAuthCodeGetOperation : IOperation {
		
		/// <summary>
		///   Perform the operation.
		/// </summary>
		/// <param name="code">
		///   The authorization code obtained after a successful OAuth entry process. This parameter is only used by the 'Authorization Code' flow.
		/// </param>
		/// <param name="client_secret">
		///   The alpha-numeric Secret for the App making the request. This verifies that the App itself is making the request, and not an imposter.  For this reason, the secret code should not be shared with anyone.
		/// </param>
		/// <param name="redirect_uri">
		///   This value must be exactly the same as the redirect URI provided for the OAuth entry process.
		/// </param>
		FabOauthAccess Get(string code, string client_secret, string redirect_uri);

	}
	

	/*================================================================================================*/
	internal class OauthAccessTokenAuthCodeGetOperation : IOauthAccessTokenAuthCodeGetOperation {

		public const string Uri = "/Oauth/AccessTokenAuthCode";
		
		public string Method { get { return "GET"; } }
		public string RequiredAuth { get { return "None"; } }
		
		private readonly IClientContext vContext;
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public OauthAccessTokenAuthCodeGetOperation(IClientContext pContext) {
			vContext = pContext;
		}

		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabricRequest<FabOauthAccess> Request(string code, string client_secret, string redirect_uri) {
			return new FabricRequest<FabOauthAccess>("GET", Uri,
				"code="+code+"&client_secret="+client_secret+"&redirect_uri="+redirect_uri,
				null
			);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public FabOauthAccess Get(string code, string client_secret, string redirect_uri) {
			return Request(code, client_secret, redirect_uri).Send(vContext);
		}

	}


	/*================================================================================================*/
	/// <summary>
	///   This OAuth flow should be used to refresh an expired access token.
	/// </summary>
	/// <remarks>
	///   <para>This OAuth flow should be used to refresh an expired access token. If the refresh token is valid, Fabric generates new access and refresh tokens for the given OAuth session. This process also invalidates the original refresh token.</para>
	///   <para>App-only access tokens (obtained with the 'Client Credentials' flow) should not be refreshed; the App should simply request a new access token.</para>
	///   <para>See Access Token for general information about the OAuth process.</para>
	/// </remarks>
	public interface IOauthAccessTokenRefreshGetOperation : IOperation {
		
		/// <summary>
		///   Perform the operation.
		/// </summary>
		/// <param name="refresh_token">
		///   The refresh token obtained after a successful 'Authorization Code' access token flow.  A refresh token only applies to User-based OAuth sessions, not for App-based OAuth sessions.  This parameter is only used by the 'Refresh' flow.
		/// </param>
		/// <param name="client_secret">
		///   The alpha-numeric Secret for the App making the request. This verifies that the App itself is making the request, and not an imposter.  For this reason, the secret code should not be shared with anyone.
		/// </param>
		/// <param name="redirect_uri">
		///   This value must be exactly the same as the redirect URI provided for the OAuth entry process.
		/// </param>
		FabOauthAccess Get(string refresh_token, string client_secret, string redirect_uri);

	}
	

	/*================================================================================================*/
	internal class OauthAccessTokenRefreshGetOperation : IOauthAccessTokenRefreshGetOperation {

		public const string Uri = "/Oauth/AccessTokenRefresh";
		
		public string Method { get { return "GET"; } }
		public string RequiredAuth { get { return "None"; } }
		
		private readonly IClientContext vContext;
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public OauthAccessTokenRefreshGetOperation(IClientContext pContext) {
			vContext = pContext;
		}

		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabricRequest<FabOauthAccess> Request(string refresh_token, string client_secret, string redirect_uri) {
			return new FabricRequest<FabOauthAccess>("GET", Uri,
				"refresh_token="+refresh_token+"&client_secret="+client_secret+"&redirect_uri="+redirect_uri,
				null
			);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public FabOauthAccess Get(string refresh_token, string client_secret, string redirect_uri) {
			return Request(refresh_token, client_secret, redirect_uri).Send(vContext);
		}

	}


	/*================================================================================================*/
	/// <summary>
	///   This OAuth flow should be used to begin an OAuth session for your Fabric App.
	/// </summary>
	/// <remarks>
	///   <para>This OAuth flow should be used to begin an OAuth session for your Fabric App. This flow does not require an authorization code from the typical OAuth entry process.</para>
	///   <para>See Access Token or general information about the OAuth process.</para>
	/// </remarks>
	public interface IOauthAccessTokenClientCredentialsGetOperation : IOperation {
		
		/// <summary>
		///   Perform the operation.
		/// </summary>
		/// <param name="client_id">
		///   The App ID value (an integer) for the App making the request. This parameter is only used by the 'Client Credentials' flow.
		/// </param>
		/// <param name="client_secret">
		///   The alpha-numeric Secret for the App making the request. This verifies that the App itself is making the request, and not an imposter.  For this reason, the secret code should not be shared with anyone.
		/// </param>
		/// <param name="redirect_uri">
		///   This value must be exactly the same as the redirect URI provided for the OAuth entry process.
		/// </param>
		FabOauthAccess Get(long client_id, string client_secret, string redirect_uri);

	}
	

	/*================================================================================================*/
	internal class OauthAccessTokenClientCredentialsGetOperation : IOauthAccessTokenClientCredentialsGetOperation {

		public const string Uri = "/Oauth/AccessTokenClientCredentials";
		
		public string Method { get { return "GET"; } }
		public string RequiredAuth { get { return "None"; } }
		
		private readonly IClientContext vContext;
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public OauthAccessTokenClientCredentialsGetOperation(IClientContext pContext) {
			vContext = pContext;
		}

		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabricRequest<FabOauthAccess> Request(long client_id, string client_secret, string redirect_uri) {
			return new FabricRequest<FabOauthAccess>("GET", Uri,
				"client_id="+client_id+"&client_secret="+client_secret+"&redirect_uri="+redirect_uri,
				null
			);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public FabOauthAccess Get(long client_id, string client_secret, string redirect_uri) {
			return Request(client_id, client_secret, redirect_uri).Send(vContext);
		}

	}


	/*================================================================================================*/
	/// <summary>
	///   This API request is unique -- it represents the entry point for Fabric's 'sOAuth 2.0 authentication process.
	/// </summary>
	/// <remarks>
	///   <para>This API request is unique -- it represents the entry point for Fabric's 'sOAuth 2.0 authentication process.  Instead of making this API request directly from a Fabric App, the App should provide a link so that its users can load this request's 'sURL (including the required query-string parameters) in their browser.</para>
	///   <para>A web-based Fabric App would typically load this OAuth entry page as a browser popup window. Once the user completes the full OAuth process (or upon an error), Fabric will redirect the browser to the App's 'sspecified redirect URI.  This redirect includes query-string parameters that provide success or error information.</para>
	///   <para>For a user, this OAuth process includes two steps: login and 'scope' acceptance.</para>
	///   <para>The first step is login, where the user is prompted to enter their username and password. If a user has already logged into Fabric (i.e. has an active authentication cookie from Fabric) and the App has not requested 'switchMode', the login step is skipped.  Important note: login occurs on Fabric's 'sserver -- a Fabric App never receives or sends a Fabric user's 'slogin credentials.</para>
	///   <para>The second step is 'scope' acceptance.  The page tells the user that a particular Fabric App wants to connect to their Fabric account, and briefly explains what this means to the user and the App. The user must accept or deny access.  Upon acceptance, the page redirects to the App with a 'success' message.  Upon denial, Fabric performs an error redirect.</para>
	///   <para>Similar to the login step, if a user has already accepted 'scope' for a particular App, the second step is skipped.  Thus, in the case where a user is already authenticated with Fabric and has already allowed App access, the entire process results in a success redirect.</para>
	///   <para>See FabOauthLogin for the query string parameters that can be included in the success and error redirects.</para>
	/// </remarks>
	public interface IOauthLoginGetOperation : IOperation {
		
		/// <summary>
		///   Perform the operation.
		/// </summary>
		/// <param name="response_type">
		///   Describes which type of authentication should be performed. For now, this value should always be 'code'. Fabric may accept more response types in the future.
		/// </param>
		/// <param name="client_id">
		///   The ID of the Fabric App making the OAuth Login request.  The access code provided after a successful OAuth process will be associated with this App ID and the authenticated User's 'sID.
		/// </param>
		/// <param name="redirect_uri">
		///   The URL which will receive success/error redirects from the OAuth Login process.  This URL should handle the following query-string parameters: access_code, error, error_description, state.
		/// </param>
		/// <param name="scope">
		///   Describes the level of access the App will have to the User's 'saccount.  This value is required by the OAuth 2.0 specification, however, Fabric currently ignores it.  All OAuth requests currently receive the same level of access to the User's 'saccount.  Fabric may begin using this parameter in the future.
		/// </param>
		/// <param name="state">
		///   Provides a security function for a Fabric App.  All success/message redirect responses include a 'state' query-string parameter.  The App should check this value against the state value provided in the initial request.  The two values should always be equal. If the values are not equal, then the redirect did not come from the Fabric OAuth process (or from a different user's 'sprocess), and should be handled accordingly.
		/// </param>
		/// <param name="switchMode">
		///   Causes the login process to behave in different ways.  If a value of '1' is provided, the user will see the login page even if they are currently authenticated with Fabric.  This is useful shared-computer scenarios, where the most-recently authenticated user may be different from the user making the current request.
		/// </param>
		FabOauthLogin Get(string response_type, string client_id, string redirect_uri, string scope, string state, string switchMode);

	}
	

	/*================================================================================================*/
	internal class OauthLoginGetOperation : IOauthLoginGetOperation {

		public const string Uri = "/Oauth/Login";
		
		public string Method { get { return "GET"; } }
		public string RequiredAuth { get { return "None"; } }
		
		private readonly IClientContext vContext;
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public OauthLoginGetOperation(IClientContext pContext) {
			vContext = pContext;
		}

		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabricRequest<FabOauthLogin> Request(string response_type, string client_id, string redirect_uri, string scope, string state, string switchMode) {
			return new FabricRequest<FabOauthLogin>("GET", Uri,
				"response_type="+response_type+"&client_id="+client_id+"&redirect_uri="+redirect_uri+"&scope="+scope+"&state="+state+"&switchMode="+switchMode,
				null
			);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public FabOauthLogin Get(string response_type, string client_id, string redirect_uri, string scope, string state, string switchMode) {
			return Request(response_type, client_id, redirect_uri, scope, state, switchMode).Send(vContext);
		}

	}


	/*================================================================================================*/
	/// <summary>
	///   Terminates a particular OAuth session by invalidating the session's 'saccess token.
	/// </summary>
	/// <remarks>
	///   <para>Terminates a particular OAuth session by invalidating the session's 'saccess token. Any further OAuth requests made with this particular access token are rejected.</para>
	///   <para>Logging out of an OAuth session does not revoke the the App scope accepted by the User (during the first OAuth login process).  Furthermore, it does not end the User's 'sauthenticated session with Fabric.  Thus, a subsequent OAuth entry by the same user may actually require zero input from the user -- they could potentially bypass both OAuth entry steps (login and scope acceptance).  This allows a user to begin a new OAuth session seamlessly, even after logging out.</para>
	/// </remarks>
	public interface IOauthLogoutGetOperation : IOperation {
		
		/// <summary>
		///   Perform the operation.
		/// </summary>
		/// <param name="access_token">
		///   The access token for the desired OAuth session. This request will fail if the token has already been invalidated by a previous logout.
		/// </param>
		FabOauthLogout Get(string access_token);

	}
	

	/*================================================================================================*/
	internal class OauthLogoutGetOperation : IOauthLogoutGetOperation {

		public const string Uri = "/Oauth/Logout";
		
		public string Method { get { return "GET"; } }
		public string RequiredAuth { get { return "None"; } }
		
		private readonly IClientContext vContext;
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public OauthLogoutGetOperation(IClientContext pContext) {
			vContext = pContext;
		}

		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabricRequest<FabOauthLogout> Request(string access_token) {
			return new FabricRequest<FabOauthLogout>("GET", Uri,
				"access_token="+access_token,
				null
			);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public FabOauthLogout Get(string access_token) {
			return Request(access_token).Send(vContext);
		}

	}


	/*================================================================================================*/
	/// <summary>
	///   Begins a traversal with an App entry point.
	/// </summary>
	/// <remarks>
	///   <para>Begins a traversal with an App entry point.</para>
	/// </remarks>
	public partial interface ITraversalAppsGetOperation : IOperation {
		
		/// <summary>
		///   Perform the operation.
		/// </summary>
		FabResponse<FabTravAppRoot> Get();

	}
	

	/*================================================================================================*/
	internal partial class TraversalAppsGetOperation : ITraversalAppsGetOperation {

		public const string Uri = "/Trav/Apps";
		
		public string Method { get { return "GET"; } }
		public string RequiredAuth { get { return "None"; } }
		
		private readonly IClientContext vContext;
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public TraversalAppsGetOperation(IClientContext pContext) {
			vContext = pContext;
		}

		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabricRequest<FabResponse<FabTravAppRoot>> Request() {
			return new FabricRequest<FabResponse<FabTravAppRoot>>("GET", Uri,
				null,
				null
			);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public FabResponse<FabTravAppRoot> Get() {
			return Request().Send(vContext);
		}

	}


	/*================================================================================================*/
	/// <summary>
	///   Begins a traversal with an Artifact entry point.
	/// </summary>
	/// <remarks>
	///   <para>Begins a traversal with an Artifact entry point.</para>
	/// </remarks>
	public partial interface ITraversalArtifactsGetOperation : IOperation {
		
		/// <summary>
		///   Perform the operation.
		/// </summary>
		FabResponse<FabTravArtifactRoot> Get();

	}
	

	/*================================================================================================*/
	internal partial class TraversalArtifactsGetOperation : ITraversalArtifactsGetOperation {

		public const string Uri = "/Trav/Artifacts";
		
		public string Method { get { return "GET"; } }
		public string RequiredAuth { get { return "None"; } }
		
		private readonly IClientContext vContext;
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public TraversalArtifactsGetOperation(IClientContext pContext) {
			vContext = pContext;
		}

		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabricRequest<FabResponse<FabTravArtifactRoot>> Request() {
			return new FabricRequest<FabResponse<FabTravArtifactRoot>>("GET", Uri,
				null,
				null
			);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public FabResponse<FabTravArtifactRoot> Get() {
			return Request().Send(vContext);
		}

	}


	/*================================================================================================*/
	/// <summary>
	///   Begins a traversal with an Class entry point.
	/// </summary>
	/// <remarks>
	///   <para>Begins a traversal with an Class entry point.</para>
	/// </remarks>
	public partial interface ITraversalClassesGetOperation : IOperation {
		
		/// <summary>
		///   Perform the operation.
		/// </summary>
		FabResponse<FabTravClassRoot> Get();

	}
	

	/*================================================================================================*/
	internal partial class TraversalClassesGetOperation : ITraversalClassesGetOperation {

		public const string Uri = "/Trav/Classes";
		
		public string Method { get { return "GET"; } }
		public string RequiredAuth { get { return "None"; } }
		
		private readonly IClientContext vContext;
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public TraversalClassesGetOperation(IClientContext pContext) {
			vContext = pContext;
		}

		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabricRequest<FabResponse<FabTravClassRoot>> Request() {
			return new FabricRequest<FabResponse<FabTravClassRoot>>("GET", Uri,
				null,
				null
			);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public FabResponse<FabTravClassRoot> Get() {
			return Request().Send(vContext);
		}

	}


	/*================================================================================================*/
	/// <summary>
	///   Begins a traversal with an Factor entry point.
	/// </summary>
	/// <remarks>
	///   <para>Begins a traversal with an Factor entry point.</para>
	/// </remarks>
	public partial interface ITraversalFactorsGetOperation : IOperation {
		
		/// <summary>
		///   Perform the operation.
		/// </summary>
		FabResponse<FabTravFactorRoot> Get();

	}
	

	/*================================================================================================*/
	internal partial class TraversalFactorsGetOperation : ITraversalFactorsGetOperation {

		public const string Uri = "/Trav/Factors";
		
		public string Method { get { return "GET"; } }
		public string RequiredAuth { get { return "None"; } }
		
		private readonly IClientContext vContext;
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public TraversalFactorsGetOperation(IClientContext pContext) {
			vContext = pContext;
		}

		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabricRequest<FabResponse<FabTravFactorRoot>> Request() {
			return new FabricRequest<FabResponse<FabTravFactorRoot>>("GET", Uri,
				null,
				null
			);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public FabResponse<FabTravFactorRoot> Get() {
			return Request().Send(vContext);
		}

	}


	/*================================================================================================*/
	/// <summary>
	///   Begins a traversal with an Instance entry point.
	/// </summary>
	/// <remarks>
	///   <para>Begins a traversal with an Instance entry point.</para>
	/// </remarks>
	public partial interface ITraversalInstancesGetOperation : IOperation {
		
		/// <summary>
		///   Perform the operation.
		/// </summary>
		FabResponse<FabTravInstanceRoot> Get();

	}
	

	/*================================================================================================*/
	internal partial class TraversalInstancesGetOperation : ITraversalInstancesGetOperation {

		public const string Uri = "/Trav/Instances";
		
		public string Method { get { return "GET"; } }
		public string RequiredAuth { get { return "None"; } }
		
		private readonly IClientContext vContext;
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public TraversalInstancesGetOperation(IClientContext pContext) {
			vContext = pContext;
		}

		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabricRequest<FabResponse<FabTravInstanceRoot>> Request() {
			return new FabricRequest<FabResponse<FabTravInstanceRoot>>("GET", Uri,
				null,
				null
			);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public FabResponse<FabTravInstanceRoot> Get() {
			return Request().Send(vContext);
		}

	}


	/*================================================================================================*/
	/// <summary>
	///   Begins a traversal with an Member entry point.
	/// </summary>
	/// <remarks>
	///   <para>Begins a traversal with an Member entry point.</para>
	/// </remarks>
	public partial interface ITraversalMembersGetOperation : IOperation {
		
		/// <summary>
		///   Perform the operation.
		/// </summary>
		FabResponse<FabTravMemberRoot> Get();

	}
	

	/*================================================================================================*/
	internal partial class TraversalMembersGetOperation : ITraversalMembersGetOperation {

		public const string Uri = "/Trav/Members";
		
		public string Method { get { return "GET"; } }
		public string RequiredAuth { get { return "None"; } }
		
		private readonly IClientContext vContext;
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public TraversalMembersGetOperation(IClientContext pContext) {
			vContext = pContext;
		}

		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabricRequest<FabResponse<FabTravMemberRoot>> Request() {
			return new FabricRequest<FabResponse<FabTravMemberRoot>>("GET", Uri,
				null,
				null
			);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public FabResponse<FabTravMemberRoot> Get() {
			return Request().Send(vContext);
		}

	}


	/*================================================================================================*/
	/// <summary>
	///   Begins a traversal with an Url entry point.
	/// </summary>
	/// <remarks>
	///   <para>Begins a traversal with an Url entry point.</para>
	/// </remarks>
	public partial interface ITraversalUrlsGetOperation : IOperation {
		
		/// <summary>
		///   Perform the operation.
		/// </summary>
		FabResponse<FabTravUrlRoot> Get();

	}
	

	/*================================================================================================*/
	internal partial class TraversalUrlsGetOperation : ITraversalUrlsGetOperation {

		public const string Uri = "/Trav/Urls";
		
		public string Method { get { return "GET"; } }
		public string RequiredAuth { get { return "None"; } }
		
		private readonly IClientContext vContext;
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public TraversalUrlsGetOperation(IClientContext pContext) {
			vContext = pContext;
		}

		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabricRequest<FabResponse<FabTravUrlRoot>> Request() {
			return new FabricRequest<FabResponse<FabTravUrlRoot>>("GET", Uri,
				null,
				null
			);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public FabResponse<FabTravUrlRoot> Get() {
			return Request().Send(vContext);
		}

	}


	/*================================================================================================*/
	/// <summary>
	///   Begins a traversal with an User entry point.
	/// </summary>
	/// <remarks>
	///   <para>Begins a traversal with an User entry point.</para>
	/// </remarks>
	public partial interface ITraversalUsersGetOperation : IOperation {
		
		/// <summary>
		///   Perform the operation.
		/// </summary>
		FabResponse<FabTravUserRoot> Get();

	}
	

	/*================================================================================================*/
	internal partial class TraversalUsersGetOperation : ITraversalUsersGetOperation {

		public const string Uri = "/Trav/Users";
		
		public string Method { get { return "GET"; } }
		public string RequiredAuth { get { return "None"; } }
		
		private readonly IClientContext vContext;
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public TraversalUsersGetOperation(IClientContext pContext) {
			vContext = pContext;
		}

		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabricRequest<FabResponse<FabTravUserRoot>> Request() {
			return new FabricRequest<FabResponse<FabTravUserRoot>>("GET", Uri,
				null,
				null
			);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public FabResponse<FabTravUserRoot> Get() {
			return Request().Send(vContext);
		}

	}


	/*================================================================================================*/
	/// <summary>
	///   Begins a traversal with an Vertex entry point.
	/// </summary>
	/// <remarks>
	///   <para>Begins a traversal with an Vertex entry point.</para>
	/// </remarks>
	public partial interface ITraversalVerticesGetOperation : IOperation {
		
		/// <summary>
		///   Perform the operation.
		/// </summary>
		FabResponse<FabTravVertexRoot> Get();

	}
	

	/*================================================================================================*/
	internal partial class TraversalVerticesGetOperation : ITraversalVerticesGetOperation {

		public const string Uri = "/Trav/Vertices";
		
		public string Method { get { return "GET"; } }
		public string RequiredAuth { get { return "None"; } }
		
		private readonly IClientContext vContext;
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public TraversalVerticesGetOperation(IClientContext pContext) {
			vContext = pContext;
		}

		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabricRequest<FabResponse<FabTravVertexRoot>> Request() {
			return new FabricRequest<FabResponse<FabTravVertexRoot>>("GET", Uri,
				null,
				null
			);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public FabResponse<FabTravVertexRoot> Get() {
			return Request().Send(vContext);
		}

	}


	// ReSharper restore InconsistentNaming
	// ReSharper restore RedundantArgumentDefaultValue

}