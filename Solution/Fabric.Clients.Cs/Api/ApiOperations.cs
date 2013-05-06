// GENERATED CODE
// Changes made to this source file will be overwritten
// Generated on 5/6/2013 3:35:43 PM

using Fabric.Clients.Cs.Session;
using Fabric.Clients.Cs.Web;
using ServiceStack.Text;

namespace Fabric.Clients.Cs.Api {

	// ReSharper disable InconsistentNaming
	// ReSharper disable RedundantArgumentDefaultValue

	/*================================================================================================*/
	/// <summary>
	///   Get the App that is associated with the currently authenticated Member.
	/// </summary>
	/// <remarks>
	///   <para>Get the App that is associated with the currently authenticated Member.</para>
	/// </remarks>
	public interface IGetActiveAppOperation : IOperation {
		
		/// <summary>
		///   Perform the operation.
		/// </summary>
		FabResponse<FabApp> Get();

	}
	

	/*================================================================================================*/
	internal class GetActiveAppOperation : IGetActiveAppOperation {

		public const string Uri = "/Trav/ActiveApp";
		
		public string Method { get { return "GET"; } }
		public string RequiredAuth { get { return "None"; } }
		
		private readonly IClientContext vContext;
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public GetActiveAppOperation(IClientContext pContext) {
			vContext = pContext;
		}

		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabricRequest<FabResponse<FabApp>> Request() {
			return new FabricRequest<FabResponse<FabApp>>("GET", Uri, 
				null,
				null
			);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public FabResponse<FabApp> Get() {
			return Request().Send(vContext);
		}

	}


	/*================================================================================================*/
	/// <summary>
	///   Get the the currently authenticated Member.
	/// </summary>
	/// <remarks>
	///   <para>Get the the currently authenticated Member.</para>
	/// </remarks>
	public interface IGetActiveMemberOperation : IOperation {
		
		/// <summary>
		///   Perform the operation.
		/// </summary>
		FabResponse<FabMember> Get();

	}
	

	/*================================================================================================*/
	internal class GetActiveMemberOperation : IGetActiveMemberOperation {

		public const string Uri = "/Trav/ActiveMember";
		
		public string Method { get { return "GET"; } }
		public string RequiredAuth { get { return "None"; } }
		
		private readonly IClientContext vContext;
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public GetActiveMemberOperation(IClientContext pContext) {
			vContext = pContext;
		}

		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabricRequest<FabResponse<FabMember>> Request() {
			return new FabricRequest<FabResponse<FabMember>>("GET", Uri, 
				null,
				null
			);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public FabResponse<FabMember> Get() {
			return Request().Send(vContext);
		}

	}


	/*================================================================================================*/
	/// <summary>
	///   Get the User that is associated with the currently authenticated Member.
	/// </summary>
	/// <remarks>
	///   <para>Get the User that is associated with the currently authenticated Member.</para>
	/// </remarks>
	public interface IGetActiveUserOperation : IOperation {
		
		/// <summary>
		///   Perform the operation.
		/// </summary>
		FabResponse<FabUser> Get();

	}
	

	/*================================================================================================*/
	internal class GetActiveUserOperation : IGetActiveUserOperation {

		public const string Uri = "/Trav/ActiveUser";
		
		public string Method { get { return "GET"; } }
		public string RequiredAuth { get { return "None"; } }
		
		private readonly IClientContext vContext;
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public GetActiveUserOperation(IClientContext pContext) {
			vContext = pContext;
		}

		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabricRequest<FabResponse<FabUser>> Request() {
			return new FabricRequest<FabResponse<FabUser>>("GET", Uri, 
				null,
				null
			);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public FabResponse<FabUser> Get() {
			return Request().Send(vContext);
		}

	}


	/*================================================================================================*/
	/// <summary>
	///   The starting point for all traversal queries.
	/// </summary>
	/// <remarks>
	///   <para>The starting point for all traversal queries. Use traversal links and traversal functions to navigate through Fabric's objects. These links and functions are capable of performing both simple and highly complex queries.</para>
	/// </remarks>
	public interface IGetRootOperation : IOperation {
		
		/// <summary>
		///   Perform the operation.
		/// </summary>
		FabResponse<FabRoot> Get();

	}
	

	/*================================================================================================*/
	internal class GetRootOperation : IGetRootOperation {

		public const string Uri = "/Trav/Root";
		
		public string Method { get { return "GET"; } }
		public string RequiredAuth { get { return "None"; } }
		
		private readonly IClientContext vContext;
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public GetRootOperation(IClientContext pContext) {
			vContext = pContext;
		}

		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabricRequest<FabResponse<FabRoot>> Request() {
			return new FabricRequest<FabResponse<FabRoot>>("GET", Uri, 
				null,
				null
			);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public FabResponse<FabRoot> Get() {
			return Request().Send(vContext);
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
	public interface IAccessTokenOperation : IOperation {
		
		/// <summary>
		///   Perform the operation.
		/// </summary>
		/// <param name="grant_type">
		///   Defines the desired access token flow.  The four accepted (case-sensitive) values are 'authorization_code', 'refresh', 'client_credentials', and 'client_data_provider'.
		/// </param>
		/// <param name="client_id">
		///   The App ID value (an integer) for the App making the request. This parameter is only used by the 'Client Credentials' and 'Client Data Provider' flows.
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
		/// <param name="data_prov_userid">
		///   The User ID value (an integer) for the Data Provider of the App making the request. Upon App creation, Fabric creates a special 'Data Provider' User which the App uses for creating items in the Fabric system. This parameter is only used by the 'Client Data Provider' flow.
		/// </param>
		FabOauthAccess Get(string grant_type, string client_id, string client_secret, string code, string refresh_token, string redirect_uri, string data_prov_userid);

	}
	

	/*================================================================================================*/
	internal class AccessTokenOperation : IAccessTokenOperation {

		public const string Uri = "/Oauth/AccessToken";
		
		public string Method { get { return "GET"; } }
		public string RequiredAuth { get { return "None"; } }
		
		private readonly IClientContext vContext;
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public AccessTokenOperation(IClientContext pContext) {
			vContext = pContext;
		}

		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabricRequest<FabOauthAccess> Request(string grant_type, string client_id, string client_secret, string code, string refresh_token, string redirect_uri, string data_prov_userid) {
			return new FabricRequest<FabOauthAccess>("GET", Uri, 
				"grant_type="+grant_type+"&client_id="+client_id+"&client_secret="+client_secret+"&code="+code+"&refresh_token="+refresh_token+"&redirect_uri="+redirect_uri+"&data_prov_userid="+data_prov_userid,
				null
			);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public FabOauthAccess Get(string grant_type, string client_id, string client_secret, string code, string refresh_token, string redirect_uri, string data_prov_userid) {
			return Request(grant_type, client_id, client_secret, code, refresh_token, redirect_uri, data_prov_userid).Send(vContext);
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
	public interface IAccessTokenAuthCodeOperation : IOperation {
		
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
	internal class AccessTokenAuthCodeOperation : IAccessTokenAuthCodeOperation {

		public const string Uri = "/Oauth/AccessTokenAuthCode";
		
		public string Method { get { return "GET"; } }
		public string RequiredAuth { get { return "None"; } }
		
		private readonly IClientContext vContext;
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public AccessTokenAuthCodeOperation(IClientContext pContext) {
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
	///   This OAuth flow should be used to begin an OAuth session for your Fabric App.
	/// </summary>
	/// <remarks>
	///   <para>This OAuth flow should be used to begin an OAuth session for your Fabric App. This flow does not require an authorization code from the typical OAuth entry process.</para>
	///   <para>See Access Token or general information about the OAuth process.</para>
	/// </remarks>
	public interface IAccessTokenClientCredentialsOperation : IOperation {
		
		/// <summary>
		///   Perform the operation.
		/// </summary>
		/// <param name="client_id">
		///   The App ID value (an integer) for the App making the request. This parameter is only used by the 'Client Credentials' and 'Client Data Provider' flows.
		/// </param>
		/// <param name="client_secret">
		///   The alpha-numeric Secret for the App making the request. This verifies that the App itself is making the request, and not an imposter.  For this reason, the secret code should not be shared with anyone.
		/// </param>
		/// <param name="redirect_uri">
		///   This value must be exactly the same as the redirect URI provided for the OAuth entry process.
		/// </param>
		FabOauthAccess Get(string client_id, string client_secret, string redirect_uri);

	}
	

	/*================================================================================================*/
	internal class AccessTokenClientCredentialsOperation : IAccessTokenClientCredentialsOperation {

		public const string Uri = "/Oauth/AccessTokenClientCredentials";
		
		public string Method { get { return "GET"; } }
		public string RequiredAuth { get { return "None"; } }
		
		private readonly IClientContext vContext;
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public AccessTokenClientCredentialsOperation(IClientContext pContext) {
			vContext = pContext;
		}

		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabricRequest<FabOauthAccess> Request(string client_id, string client_secret, string redirect_uri) {
			return new FabricRequest<FabOauthAccess>("GET", Uri, 
				"client_id="+client_id+"&client_secret="+client_secret+"&redirect_uri="+redirect_uri,
				null
			);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public FabOauthAccess Get(string client_id, string client_secret, string redirect_uri) {
			return Request(client_id, client_secret, redirect_uri).Send(vContext);
		}

	}


	/*================================================================================================*/
	/// <summary>
	///   This OAuth flow should be used to begin an OAuth session for your Fabric App's Data Provider User.
	/// </summary>
	/// <remarks>
	///   <para>This OAuth flow should be used to begin an OAuth session for your Fabric App's Data Provider User. This flow does not require an authorization code from the typical OAuth entry process. Note: this flow is not defined by the OAuth 2.0 specification; it is specifically designed to meet a Fabric App's OAuth needs.</para>
	///   <para>See Access Token for general information about the OAuth process.</para>
	/// </remarks>
	public interface IAccessTokenClientDataProvOperation : IOperation {
		
		/// <summary>
		///   Perform the operation.
		/// </summary>
		/// <param name="client_id">
		///   The App ID value (an integer) for the App making the request. This parameter is only used by the 'Client Credentials' and 'Client Data Provider' flows.
		/// </param>
		/// <param name="client_secret">
		///   The alpha-numeric Secret for the App making the request. This verifies that the App itself is making the request, and not an imposter.  For this reason, the secret code should not be shared with anyone.
		/// </param>
		/// <param name="redirect_uri">
		///   This value must be exactly the same as the redirect URI provided for the OAuth entry process.
		/// </param>
		/// <param name="data_prov_userid">
		///   The User ID value (an integer) for the Data Provider of the App making the request. Upon App creation, Fabric creates a special 'Data Provider' User which the App uses for creating items in the Fabric system. This parameter is only used by the 'Client Data Provider' flow.
		/// </param>
		FabOauthAccess Get(string client_id, string client_secret, string redirect_uri, string data_prov_userid);

	}
	

	/*================================================================================================*/
	internal class AccessTokenClientDataProvOperation : IAccessTokenClientDataProvOperation {

		public const string Uri = "/Oauth/AccessTokenClientDataProv";
		
		public string Method { get { return "GET"; } }
		public string RequiredAuth { get { return "None"; } }
		
		private readonly IClientContext vContext;
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public AccessTokenClientDataProvOperation(IClientContext pContext) {
			vContext = pContext;
		}

		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabricRequest<FabOauthAccess> Request(string client_id, string client_secret, string redirect_uri, string data_prov_userid) {
			return new FabricRequest<FabOauthAccess>("GET", Uri, 
				"client_id="+client_id+"&client_secret="+client_secret+"&redirect_uri="+redirect_uri+"&data_prov_userid="+data_prov_userid,
				null
			);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public FabOauthAccess Get(string client_id, string client_secret, string redirect_uri, string data_prov_userid) {
			return Request(client_id, client_secret, redirect_uri, data_prov_userid).Send(vContext);
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
	public interface IAccessTokenRefreshOperation : IOperation {
		
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
	internal class AccessTokenRefreshOperation : IAccessTokenRefreshOperation {

		public const string Uri = "/Oauth/AccessTokenRefresh";
		
		public string Method { get { return "GET"; } }
		public string RequiredAuth { get { return "None"; } }
		
		private readonly IClientContext vContext;
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public AccessTokenRefreshOperation(IClientContext pContext) {
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
	///   This API request is unique -- it represents the entry point for Fabric's OAuth 2.0 authentication process.
	/// </summary>
	/// <remarks>
	///   <para>This API request is unique -- it represents the entry point for Fabric's OAuth 2.0 authentication process.  Instead of making this API request directly from a Fabric App, the App should provide a link so that its users can load this request's URL (including the required query-string parameters) in their browser.</para>
	///   <para>A web-based Fabric App would typically load this OAuth entry page as a browser popup window. Once the user completes the full OAuth process (or upon an error), Fabric will redirect the browser to the App's specified redirect URI.  This redirect includes query-string parameters that provide success or error information.</para>
	///   <para>	</para>
	///   <para>For a user, this OAuth process includes two steps: login and 'scope' acceptance.</para>
	///   <para>The first step is login, where the user is prompted to enter their username and password. If a user has already logged into Fabric (i.e. has an active authentication cookie from Fabric) and the App has not requested 'switchMode', the login step is skipped.  Important note: login occurs on Fabric's server -- a Fabric App never receives or sends a Fabric user's login credentials.</para>
	///   <para>The second step is 'scope' acceptance.  The page tells the user that a particular Fabric App wants to connect to their Fabric account, and briefly explains what this means to the user and the App. The user must accept or deny access.  Upon acceptance, the page redirects to the App with a 'success' message.  Upon denial, Fabric performs an error redirect.</para>
	///   <para>	</para>
	///   <para>Similar to the login step, if a user has already accepted 'scope' for a particular App, the second step is skipped.  Thus, in the case where a user is already authenticated with Fabric and has already allowed App access, the entire process results in a success redirect.</para>
	///   <para>	</para>
	///   <para>See FabOauthLogin for the query string parameters that can be included in the success and error redirects.</para>
	/// </remarks>
	public interface ILoginOperation : IOperation {
		
		/// <summary>
		///   Perform the operation.
		/// </summary>
		/// <param name="response_type">
		///   Describes which type of authentication should be performed. For now, this value should always be 'code'. Fabric may accept more response types in the future.
		/// </param>
		/// <param name="client_id">
		///   The ID of the Fabric App making the OAuth Login request.  The access code provided after a successful OAuth process will be associated with this App ID and the authenticated User's ID.
		/// </param>
		/// <param name="redirect_uri">
		///   The URL which will receive success/error redirects from the OAuth Login process.  This URL should handle the following query-string parameters: access_code, error, error_description, state.
		/// </param>
		/// <param name="scope">
		///   Describes the level of access the App will have to the User's account.  This value is required by the OAuth 2.0 specification, however, Fabric currently ignores it.  All OAuth requests currently receive the same level of access to the User's account.  Fabric may begin using this parameter in the future.
		/// </param>
		/// <param name="state">
		///   Provides a security function for a Fabric App.  All success/message redirect responses include a 'state' query-string parameter.  The App should check this value against the state value provided in the initial request.  The two values should always be equal. If the values are not equal, then the redirect did not come from the Fabric OAuth process (or from a different user's process), and should be handled accordingly.
		/// </param>
		/// <param name="switchMode">
		///   Causes the login process to behave in different ways.  If a value of '1' is provided, the user will see the login page even if they are currently authenticated with Fabric.  This is useful shared-computer scenarios, where the most-recently authenticated user may be different from the user making the current request.
		/// </param>
		FabOauthLogin Get(string response_type, string client_id, string redirect_uri, string scope, string state, string switchMode);

	}
	

	/*================================================================================================*/
	internal class LoginOperation : ILoginOperation {

		public const string Uri = "/Oauth/Login";
		
		public string Method { get { return "GET"; } }
		public string RequiredAuth { get { return "None"; } }
		
		private readonly IClientContext vContext;
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public LoginOperation(IClientContext pContext) {
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
	///   Terminates a particular OAuth session by invalidating the session's access token.
	/// </summary>
	/// <remarks>
	///   <para>Terminates a particular OAuth session by invalidating the session's access token. Any further OAuth requests made with this particular access token are rejected.</para>
	///   <para>Logging out of an OAuth session does not revoke the the App scope accepted by the User (during the first OAuth login process).  Furthermore, it does not end the User's authenticated session with Fabric.  Thus, a subsequent OAuth entry by the same user may actually require zero input from the user -- they could potentially bypass both OAuth entry steps (login and scope acceptance).  This allows a user to begin a new OAuth session seamlessly, even after logging out.</para>
	/// </remarks>
	public interface ILogoutOperation : IOperation {
		
		/// <summary>
		///   Perform the operation.
		/// </summary>
		/// <param name="access_token">
		///   The access token for the desired OAuth session. This request will fail if the token has already been invalidated by a previous logout.
		/// </param>
		FabOauthLogout Get(string access_token);

	}
	

	/*================================================================================================*/
	internal class LogoutOperation : ILogoutOperation {

		public const string Uri = "/Oauth/Logout";
		
		public string Method { get { return "GET"; } }
		public string RequiredAuth { get { return "None"; } }
		
		private readonly IClientContext vContext;
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public LogoutOperation(IClientContext pContext) {
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
	///   Create a new Class.
	/// </summary>
	/// <remarks>
	///   <para>Create a new Class. Attach Factors to this Class immediately after creation to give it meaning and relevance within Fabric.</para>
	/// </remarks>
	public interface IAddClassOperation : IOperation {
		
		/// <summary>
		///   Perform the operation.
		/// </summary>
		/// <param name="Name">
		///   The name of the new Class. It must be unique on its own, or be unique in combination with the disambiguation text.
		/// </param>
		/// <param name="Disamb">
		///   The disambiguation text for the new Class.  When provided, the disambiguation text permits the use of a non-unique name.
		/// </param>
		/// <param name="Note">
		///   A brief description of the new Class. It can be useful for helping others understand the creator's intended purpose or meaning.
		/// </param>
		FabResponse<FabClass> Post(string Name, string Disamb, string Note);

	}
	

	/*================================================================================================*/
	internal class AddClassOperation : IAddClassOperation {

		public const string Uri = "/Mod/Classes";
		
		public string Method { get { return "POST"; } }
		public string RequiredAuth { get { return "Member"; } }
		
		private readonly IClientContext vContext;
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public AddClassOperation(IClientContext pContext) {
			vContext = pContext;
		}

		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabricRequest<FabResponse<FabClass>> Request(string Name, string Disamb, string Note) {
			return new FabricRequest<FabResponse<FabClass>>("POST", Uri, 
				null,
				"Name="+Name+"&Disamb="+Disamb+"&Note="+Note
			);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public FabResponse<FabClass> Post(string Name, string Disamb, string Note) {
			return Request(Name, Disamb, Note).Send(vContext);
		}

	}


	/*================================================================================================*/
	/// <summary>
	///   TODO
	/// </summary>
	/// <remarks>
	///   <para>TODO</para>
	/// </remarks>
	public interface IAddClassesOperation : IOperation {
		
		/// <summary>
		///   Perform the operation.
		/// </summary>
		/// <param name="Classes">
		///   TODO
		/// </param>
		FabResponse<FabBatchResult> Post(FabBatchNewClass[] Classes);

	}
	

	/*================================================================================================*/
	internal class AddClassesOperation : IAddClassesOperation {

		public const string Uri = "/Mod/Classes/Batch";
		
		public string Method { get { return "POST"; } }
		public string RequiredAuth { get { return "Member"; } }
		
		private readonly IClientContext vContext;
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public AddClassesOperation(IClientContext pContext) {
			vContext = pContext;
		}

		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabricRequest<FabResponse<FabBatchResult>> Request(FabBatchNewClass[] Classes) {
			return new FabricRequest<FabResponse<FabBatchResult>>("POST", Uri, 
				null,
				"Classes="+Classes.ToJson()
			);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public FabResponse<FabBatchResult> Post(FabBatchNewClass[] Classes) {
			return Request(Classes).Send(vContext);
		}

	}


	/*================================================================================================*/
	/// <summary>
	///   Create a new Factor.
	/// </summary>
	/// <remarks>
	///   <para>Create a new Factor. The Factor begins in the 'incomplete' state, with no FactorElements attached.</para>
	/// </remarks>
	public interface IAddFactorOperation : IOperation {
		
		/// <summary>
		///   Perform the operation.
		/// </summary>
		/// <param name="PrimaryArtifactId">
		///   Identifies the primary Artifact for the new Factor.
		/// </param>
		/// <param name="RelatedArtifactId">
		///   Identifies the related Artifact for the new Factor. The related Artifact cannot be the same as the primary Artifact.
		/// </param>
		/// <param name="FactorAssertionId">
		///   Identifies the FactorAssertion for the new Factor. In cases where the assertion type is unclear or not known, please use the 'Undefined' FactorAssertion.
		/// </param>
		/// <param name="IsDefining">
		///   The IsDefining value for the new Factor.
		/// </param>
		/// <param name="Note">
		///   A sentence or short paragraph describing (in a human-readable format) the intended meaning of the new Factor. A descriptive note can help others understand the creator's intended purpose or meaning for the Factor.
		/// </param>
		FabResponse<FabFactor> Post(long PrimaryArtifactId, long RelatedArtifactId, byte FactorAssertionId, bool IsDefining, string Note);

	}
	

	/*================================================================================================*/
	internal class AddFactorOperation : IAddFactorOperation {

		public const string Uri = "/Mod/Factors";
		
		public string Method { get { return "POST"; } }
		public string RequiredAuth { get { return "Member"; } }
		
		private readonly IClientContext vContext;
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public AddFactorOperation(IClientContext pContext) {
			vContext = pContext;
		}

		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabricRequest<FabResponse<FabFactor>> Request(long PrimaryArtifactId, long RelatedArtifactId, byte FactorAssertionId, bool IsDefining, string Note) {
			return new FabricRequest<FabResponse<FabFactor>>("POST", Uri, 
				null,
				"PrimaryArtifactId="+PrimaryArtifactId+"&RelatedArtifactId="+RelatedArtifactId+"&FactorAssertionId="+FactorAssertionId+"&IsDefining="+IsDefining+"&Note="+Note
			);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public FabResponse<FabFactor> Post(long PrimaryArtifactId, long RelatedArtifactId, byte FactorAssertionId, bool IsDefining, string Note) {
			return Request(PrimaryArtifactId, RelatedArtifactId, FactorAssertionId, IsDefining, Note).Send(vContext);
		}

	}


	/*================================================================================================*/
	/// <summary>
	///   TODO
	/// </summary>
	/// <remarks>
	///   <para>TODO</para>
	/// </remarks>
	public interface IAddFactorsOperation : IOperation {
		
		/// <summary>
		///   Perform the operation.
		/// </summary>
		/// <param name="Factors">
		///   TODO
		/// </param>
		FabResponse<FabBatchResult> Post(FabBatchNewFactor[] Factors);

	}
	

	/*================================================================================================*/
	internal class AddFactorsOperation : IAddFactorsOperation {

		public const string Uri = "/Mod/Factors/Batch";
		
		public string Method { get { return "POST"; } }
		public string RequiredAuth { get { return "Member"; } }
		
		private readonly IClientContext vContext;
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public AddFactorsOperation(IClientContext pContext) {
			vContext = pContext;
		}

		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabricRequest<FabResponse<FabBatchResult>> Request(FabBatchNewFactor[] Factors) {
			return new FabricRequest<FabResponse<FabBatchResult>>("POST", Uri, 
				null,
				"Factors="+Factors.ToJson()
			);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public FabResponse<FabBatchResult> Post(FabBatchNewFactor[] Factors) {
			return Request(Factors).Send(vContext);
		}

	}


	/*================================================================================================*/
	/// <summary>
	///   Create a new Instance.
	/// </summary>
	/// <remarks>
	///   <para>Create a new Instance. Attach Factors to this Instance immediately after creation to give it meaning and relevance within Fabric.</para>
	/// </remarks>
	public interface IAddInstanceOperation : IOperation {
		
		/// <summary>
		///   Perform the operation.
		/// </summary>
		/// <param name="Name">
		///   The name of the new Instance. It does not need to be unique.
		/// </param>
		/// <param name="Disamb">
		///   The disambiguation text for the new Instance. When provided, the disambiguation text permits the use of a non-unique name.
		/// </param>
		/// <param name="Note">
		///   A brief description of the new Instance.  It can be useful for helping others understand the creator's intended purpose or meaning.
		/// </param>
		FabResponse<FabInstance> Post(string Name, string Disamb, string Note);

	}
	

	/*================================================================================================*/
	internal class AddInstanceOperation : IAddInstanceOperation {

		public const string Uri = "/Mod/Instances";
		
		public string Method { get { return "POST"; } }
		public string RequiredAuth { get { return "Member"; } }
		
		private readonly IClientContext vContext;
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public AddInstanceOperation(IClientContext pContext) {
			vContext = pContext;
		}

		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabricRequest<FabResponse<FabInstance>> Request(string Name, string Disamb, string Note) {
			return new FabricRequest<FabResponse<FabInstance>>("POST", Uri, 
				null,
				"Name="+Name+"&Disamb="+Disamb+"&Note="+Note
			);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public FabResponse<FabInstance> Post(string Name, string Disamb, string Note) {
			return Request(Name, Disamb, Note).Send(vContext);
		}

	}


	/*================================================================================================*/
	/// <summary>
	///   Create a new Url.
	/// </summary>
	/// <remarks>
	///   <para>Create a new Url.</para>
	/// </remarks>
	public interface IAddUrlOperation : IOperation {
		
		/// <summary>
		///   Perform the operation.
		/// </summary>
		/// <param name="AbsoluteUrl">
		///   The complete absolute URL for new Url object. It must include the URL's protocol (such as 'http://').
		/// </param>
		/// <param name="Name">
		///   The name of the new Url.
		/// </param>
		FabResponse<FabUrl> Post(string AbsoluteUrl, string Name);

	}
	

	/*================================================================================================*/
	internal class AddUrlOperation : IAddUrlOperation {

		public const string Uri = "/Mod/Urls";
		
		public string Method { get { return "POST"; } }
		public string RequiredAuth { get { return "Member"; } }
		
		private readonly IClientContext vContext;
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public AddUrlOperation(IClientContext pContext) {
			vContext = pContext;
		}

		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabricRequest<FabResponse<FabUrl>> Request(string AbsoluteUrl, string Name) {
			return new FabricRequest<FabResponse<FabUrl>>("POST", Uri, 
				null,
				"AbsoluteUrl="+AbsoluteUrl+"&Name="+Name
			);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public FabResponse<FabUrl> Post(string AbsoluteUrl, string Name) {
			return Request(AbsoluteUrl, Name).Send(vContext);
		}

	}


	/*================================================================================================*/
	/// <summary>
	///   Create a new Descriptor and attach it to the specified Factor.
	/// </summary>
	/// <remarks>
	///   <para>Create a new Descriptor and attach it to the specified Factor.</para>
	/// </remarks>
	public interface IAttachDescriptorToFactorOperation : IOperation {
		
		/// <summary>
		///   Perform the operation.
		/// </summary>
		/// <param name="FactorId">
		///   Identifies the incomplete Factor that will receive the Descriptor attachment.
		/// </param>
		/// <param name="DescriptorTypeId">
		///   Identifies the DescriptorType for the new Descriptor.
		/// </param>
		/// <param name="PrimaryArtifactRefineId">
		///   Identifies the Artifact that refines the Factor's primary Artifact.
		/// </param>
		/// <param name="RelatedArtifactRefineId">
		///   Identifies the Artifact that refines the Factor's related Artifact.
		/// </param>
		/// <param name="DescriptorTypeRefineId">
		///   Identifies the Artifact that refines the new Descriptor's DescriptorType.
		/// </param>
		FabResponse<bool> Post(long FactorId, byte DescriptorTypeId, long? PrimaryArtifactRefineId, long? RelatedArtifactRefineId, long? DescriptorTypeRefineId);

	}
	

	/*================================================================================================*/
	internal class AttachDescriptorToFactorOperation : IAttachDescriptorToFactorOperation {

		public const string Uri = "/Mod/Descriptors";
		
		public string Method { get { return "POST"; } }
		public string RequiredAuth { get { return "Member"; } }
		
		private readonly IClientContext vContext;
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public AttachDescriptorToFactorOperation(IClientContext pContext) {
			vContext = pContext;
		}

		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabricRequest<FabResponse<bool>> Request(long FactorId, byte DescriptorTypeId, long? PrimaryArtifactRefineId, long? RelatedArtifactRefineId, long? DescriptorTypeRefineId) {
			return new FabricRequest<FabResponse<bool>>("POST", Uri, 
				null,
				"FactorId="+FactorId+"&DescriptorTypeId="+DescriptorTypeId+"&PrimaryArtifactRefineId="+PrimaryArtifactRefineId+"&RelatedArtifactRefineId="+RelatedArtifactRefineId+"&DescriptorTypeRefineId="+DescriptorTypeRefineId
			);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public FabResponse<bool> Post(long FactorId, byte DescriptorTypeId, long? PrimaryArtifactRefineId, long? RelatedArtifactRefineId, long? DescriptorTypeRefineId) {
			return Request(FactorId, DescriptorTypeId, PrimaryArtifactRefineId, RelatedArtifactRefineId, DescriptorTypeRefineId).Send(vContext);
		}

	}


	/*================================================================================================*/
	/// <summary>
	///   Create a new Director and attach it to the specified Factor.
	/// </summary>
	/// <remarks>
	///   <para>Create a new Director and attach it to the specified Factor.</para>
	/// </remarks>
	public interface IAttachDirectorToFactorOperation : IOperation {
		
		/// <summary>
		///   Perform the operation.
		/// </summary>
		/// <param name="FactorId">
		///   Identifies the incomplete Factor that will receive the Director attachment.
		/// </param>
		/// <param name="DirectorTypeId">
		///   Identifies the DirectorType for the new Director.
		/// </param>
		/// <param name="PrimaryDirectorActionId">
		///   Identifies the DirectorAction associated with the Factor's primary Artifact.
		/// </param>
		/// <param name="RelatedDirectorActionId">
		///   Identifies the DirectorAction associated with the Factor's related Artifact.
		/// </param>
		FabResponse<bool> Post(long FactorId, byte DirectorTypeId, byte PrimaryDirectorActionId, byte RelatedDirectorActionId);

	}
	

	/*================================================================================================*/
	internal class AttachDirectorToFactorOperation : IAttachDirectorToFactorOperation {

		public const string Uri = "/Mod/Directors";
		
		public string Method { get { return "POST"; } }
		public string RequiredAuth { get { return "Member"; } }
		
		private readonly IClientContext vContext;
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public AttachDirectorToFactorOperation(IClientContext pContext) {
			vContext = pContext;
		}

		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabricRequest<FabResponse<bool>> Request(long FactorId, byte DirectorTypeId, byte PrimaryDirectorActionId, byte RelatedDirectorActionId) {
			return new FabricRequest<FabResponse<bool>>("POST", Uri, 
				null,
				"FactorId="+FactorId+"&DirectorTypeId="+DirectorTypeId+"&PrimaryDirectorActionId="+PrimaryDirectorActionId+"&RelatedDirectorActionId="+RelatedDirectorActionId
			);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public FabResponse<bool> Post(long FactorId, byte DirectorTypeId, byte PrimaryDirectorActionId, byte RelatedDirectorActionId) {
			return Request(FactorId, DirectorTypeId, PrimaryDirectorActionId, RelatedDirectorActionId).Send(vContext);
		}

	}


	/*================================================================================================*/
	/// <summary>
	///   Create a new Eventor and attach it to the specified Factor.
	/// </summary>
	/// <remarks>
	///   <para>Create a new Eventor and attach it to the specified Factor.</para>
	/// </remarks>
	public interface IAttachEventorToFactorOperation : IOperation {
		
		/// <summary>
		///   Perform the operation.
		/// </summary>
		/// <param name="FactorId">
		///   Identifies the incomplete Factor that will receive the Eventor attachment.
		/// </param>
		/// <param name="EventorTypeId">
		///   Identifies the EventorType for the new Eventor.
		/// </param>
		/// <param name="EventorPrecisionId">
		///   Identifies the EventorPrecision for the new Eventor.
		/// </param>
		/// <param name="DateTime">
		///   The date and time for the new Eventor. This value must be accurate to the level of precision defined by the specified EventorPrecision. Set unused month/day values to 1, and unused hour/minute values (and beyond) to 0.
		/// </param>
		FabResponse<bool> Post(long FactorId, byte EventorTypeId, byte EventorPrecisionId, long DateTime);

	}
	

	/*================================================================================================*/
	internal class AttachEventorToFactorOperation : IAttachEventorToFactorOperation {

		public const string Uri = "/Mod/Eventors";
		
		public string Method { get { return "POST"; } }
		public string RequiredAuth { get { return "Member"; } }
		
		private readonly IClientContext vContext;
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public AttachEventorToFactorOperation(IClientContext pContext) {
			vContext = pContext;
		}

		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabricRequest<FabResponse<bool>> Request(long FactorId, byte EventorTypeId, byte EventorPrecisionId, long DateTime) {
			return new FabricRequest<FabResponse<bool>>("POST", Uri, 
				null,
				"FactorId="+FactorId+"&EventorTypeId="+EventorTypeId+"&EventorPrecisionId="+EventorPrecisionId+"&DateTime="+DateTime
			);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public FabResponse<bool> Post(long FactorId, byte EventorTypeId, byte EventorPrecisionId, long DateTime) {
			return Request(FactorId, EventorTypeId, EventorPrecisionId, DateTime).Send(vContext);
		}

	}


	/*================================================================================================*/
	/// <summary>
	///   Create a new Identor and attach it to the specified Factor.
	/// </summary>
	/// <remarks>
	///   <para>Create a new Identor and attach it to the specified Factor.</para>
	/// </remarks>
	public interface IAttachIdentorToFactorOperation : IOperation {
		
		/// <summary>
		///   Perform the operation.
		/// </summary>
		/// <param name="FactorId">
		///   Identifies the incomplete Factor that will receive the Identor attachment.
		/// </param>
		/// <param name="IdentorTypeId">
		///   Identifies the IdentorType for the new Identor.
		/// </param>
		/// <param name="Value">
		///   The text-based value for the new Identor.
		/// </param>
		FabResponse<bool> Post(long FactorId, byte IdentorTypeId, string Value);

	}
	

	/*================================================================================================*/
	internal class AttachIdentorToFactorOperation : IAttachIdentorToFactorOperation {

		public const string Uri = "/Mod/Identors";
		
		public string Method { get { return "POST"; } }
		public string RequiredAuth { get { return "Member"; } }
		
		private readonly IClientContext vContext;
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public AttachIdentorToFactorOperation(IClientContext pContext) {
			vContext = pContext;
		}

		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabricRequest<FabResponse<bool>> Request(long FactorId, byte IdentorTypeId, string Value) {
			return new FabricRequest<FabResponse<bool>>("POST", Uri, 
				null,
				"FactorId="+FactorId+"&IdentorTypeId="+IdentorTypeId+"&Value="+Value
			);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public FabResponse<bool> Post(long FactorId, byte IdentorTypeId, string Value) {
			return Request(FactorId, IdentorTypeId, Value).Send(vContext);
		}

	}


	/*================================================================================================*/
	/// <summary>
	///   Create a new Locator and attach it to the specified Factor.
	/// </summary>
	/// <remarks>
	///   <para>Create a new Locator and attach it to the specified Factor.</para>
	/// </remarks>
	public interface IAttachLocatorToFactorOperation : IOperation {
		
		/// <summary>
		///   Perform the operation.
		/// </summary>
		/// <param name="FactorId">
		///   Identifies the incomplete Factor that will receive the Locator attachment.
		/// </param>
		/// <param name="LocatorTypeId">
		///   Identifies the LocatorType for the new Locator.
		/// </param>
		/// <param name="ValueX">
		///   The X value for the new Locator.
		/// </param>
		/// <param name="ValueY">
		///   The Y value for the new Locator.
		/// </param>
		/// <param name="ValueZ">
		///   The Z value for the new Locator.
		/// </param>
		FabResponse<bool> Post(long FactorId, byte LocatorTypeId, double ValueX, double ValueY, double ValueZ);

	}
	

	/*================================================================================================*/
	internal class AttachLocatorToFactorOperation : IAttachLocatorToFactorOperation {

		public const string Uri = "/Mod/Locators";
		
		public string Method { get { return "POST"; } }
		public string RequiredAuth { get { return "Member"; } }
		
		private readonly IClientContext vContext;
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public AttachLocatorToFactorOperation(IClientContext pContext) {
			vContext = pContext;
		}

		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabricRequest<FabResponse<bool>> Request(long FactorId, byte LocatorTypeId, double ValueX, double ValueY, double ValueZ) {
			return new FabricRequest<FabResponse<bool>>("POST", Uri, 
				null,
				"FactorId="+FactorId+"&LocatorTypeId="+LocatorTypeId+"&ValueX="+ValueX+"&ValueY="+ValueY+"&ValueZ="+ValueZ
			);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public FabResponse<bool> Post(long FactorId, byte LocatorTypeId, double ValueX, double ValueY, double ValueZ) {
			return Request(FactorId, LocatorTypeId, ValueX, ValueY, ValueZ).Send(vContext);
		}

	}


	/*================================================================================================*/
	/// <summary>
	///   Create a new Vector and attach it to the specified Factor.
	/// </summary>
	/// <remarks>
	///   <para>Create a new Vector and attach it to the specified Factor.</para>
	/// </remarks>
	public interface IAttachVectorToFactorOperation : IOperation {
		
		/// <summary>
		///   Perform the operation.
		/// </summary>
		/// <param name="FactorId">
		///   Identifies the incomplete Factor that will receive the Vector attachment.
		/// </param>
		/// <param name="VectorTypeId">
		///   Identifies the VectorType for the new Vector.
		/// </param>
		/// <param name="Value">
		///   The value for the new Vector. This value must be within the range specified by the VectorType. Decimal values are not supported; if additional precision is required, use a VectorUnitPrefix such as Milli or Micro.
		/// </param>
		/// <param name="AxisArtifactId">
		///   The Artifact which provides meaning for the new Vector.
		/// </param>
		/// <param name="VectorUnitId">
		///   Identifies the VectorUnit for the new Vector.
		/// </param>
		/// <param name="VectorUnitPrefixId">
		///   Identifies the VectorUnitPrefix for the new Vector.
		/// </param>
		FabResponse<bool> Post(long FactorId, byte VectorTypeId, long Value, long AxisArtifactId, byte VectorUnitId, byte VectorUnitPrefixId);

	}
	

	/*================================================================================================*/
	internal class AttachVectorToFactorOperation : IAttachVectorToFactorOperation {

		public const string Uri = "/Mod/Vectors";
		
		public string Method { get { return "POST"; } }
		public string RequiredAuth { get { return "Member"; } }
		
		private readonly IClientContext vContext;
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public AttachVectorToFactorOperation(IClientContext pContext) {
			vContext = pContext;
		}

		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabricRequest<FabResponse<bool>> Request(long FactorId, byte VectorTypeId, long Value, long AxisArtifactId, byte VectorUnitId, byte VectorUnitPrefixId) {
			return new FabricRequest<FabResponse<bool>>("POST", Uri, 
				null,
				"FactorId="+FactorId+"&VectorTypeId="+VectorTypeId+"&Value="+Value+"&AxisArtifactId="+AxisArtifactId+"&VectorUnitId="+VectorUnitId+"&VectorUnitPrefixId="+VectorUnitPrefixId
			);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public FabResponse<bool> Post(long FactorId, byte VectorTypeId, long Value, long AxisArtifactId, byte VectorUnitId, byte VectorUnitPrefixId) {
			return Request(FactorId, VectorTypeId, Value, AxisArtifactId, VectorUnitId, VectorUnitPrefixId).Send(vContext);
		}

	}


	/*================================================================================================*/
	/// <summary>
	///   Move a Factor from the 'incomplete' state to the 'complete' state.
	/// </summary>
	/// <remarks>
	///   <para>Move a Factor from the 'incomplete' state to the 'complete' state.  A Factor must have a Descriptor before it can be completed. Once a Factor is completed, it can only be deleted -- no further modifications are permitted.</para>
	/// </remarks>
	public interface ICompleteFactorOperation : IOperation {
		
		/// <summary>
		///   Perform the operation.
		/// </summary>
		/// <param name="FactorId">
		///   Identifies the incomplete Factor to be completed.
		/// </param>
		/// <param name="IsCompleted">
		///   The IsCompleted value must be 'true'.
		/// </param>
		FabResponse<FabFactor> Put(long FactorId, bool IsCompleted);

	}
	

	/*================================================================================================*/
	internal class CompleteFactorOperation : ICompleteFactorOperation {

		public const string Uri = "/Mod/Factors";
		
		public string Method { get { return "PUT"; } }
		public string RequiredAuth { get { return "Member"; } }
		
		private readonly IClientContext vContext;
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public CompleteFactorOperation(IClientContext pContext) {
			vContext = pContext;
		}

		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabricRequest<FabResponse<FabFactor>> Request(long FactorId, bool IsCompleted) {
			return new FabricRequest<FabResponse<FabFactor>>("PUT", Uri, 
				null,
				"FactorId="+FactorId+"&IsCompleted="+IsCompleted
			);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public FabResponse<FabFactor> Put(long FactorId, bool IsCompleted) {
			return Request(FactorId, IsCompleted).Send(vContext);
		}

	}


	/*================================================================================================*/
	/// <summary>
	///   Delete a Factor.
	/// </summary>
	/// <remarks>
	///   <para>Delete a Factor.</para>
	/// </remarks>
	public interface IDeleteFactorOperation : IOperation {
		
		/// <summary>
		///   Perform the operation.
		/// </summary>
		/// <param name="FactorId">
		///   Identifies the Factor to be deleted.
		/// </param>
		/// <param name="IsDeleted">
		///   The IsDeleted value must be 'true'.
		/// </param>
		FabResponse<FabFactor> Delete(long FactorId, bool IsDeleted);

	}
	

	/*================================================================================================*/
	internal class DeleteFactorOperation : IDeleteFactorOperation {

		public const string Uri = "/Mod/Factors";
		
		public string Method { get { return "DELETE"; } }
		public string RequiredAuth { get { return "Member"; } }
		
		private readonly IClientContext vContext;
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public DeleteFactorOperation(IClientContext pContext) {
			vContext = pContext;
		}

		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabricRequest<FabResponse<FabFactor>> Request(long FactorId, bool IsDeleted) {
			return new FabricRequest<FabResponse<FabFactor>>("DELETE", Uri, 
				null,
				"FactorId="+FactorId+"&IsDeleted="+IsDeleted
			);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public FabResponse<FabFactor> Delete(long FactorId, bool IsDeleted) {
			return Request(FactorId, IsDeleted).Send(vContext);
		}

	}


	/*================================================================================================*/
	/// <summary>
	///   Get the latest specifications and documentation for all Fabric API services.
	/// </summary>
	/// <remarks>
	///   <para>Get the latest specifications and documentation for all Fabric API services.</para>
	/// </remarks>
	public interface IGetSpecificationOperation : IOperation {
		
		/// <summary>
		///   Perform the operation.
		/// </summary>
		FabResponse<FabSpec> Get();

	}
	

	/*================================================================================================*/
	internal class GetSpecificationOperation : IGetSpecificationOperation {

		public const string Uri = "/Meta/Spec";
		
		public string Method { get { return "GET"; } }
		public string RequiredAuth { get { return "None"; } }
		
		private readonly IClientContext vContext;
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public GetSpecificationOperation(IClientContext pContext) {
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
	///   Get the current Fabric server time.
	/// </summary>
	/// <remarks>
	///   <para>Get the current Fabric server time.</para>
	/// </remarks>
	public interface IGetTimeOperation : IOperation {
		
		/// <summary>
		///   Perform the operation.
		/// </summary>
		FabResponse<FabMetaTime> Get();

	}
	

	/*================================================================================================*/
	internal class GetTimeOperation : IGetTimeOperation {

		public const string Uri = "/Meta/Time";
		
		public string Method { get { return "GET"; } }
		public string RequiredAuth { get { return "None"; } }
		
		private readonly IClientContext vContext;
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public GetTimeOperation(IClientContext pContext) {
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
	///   Get the current Fabric version.
	/// </summary>
	/// <remarks>
	///   <para>Get the current Fabric version.</para>
	/// </remarks>
	public interface IGetVersionOperation : IOperation {
		
		/// <summary>
		///   Perform the operation.
		/// </summary>
		FabResponse<FabMetaVersion> Get();

	}
	

	/*================================================================================================*/
	internal class GetVersionOperation : IGetVersionOperation {

		public const string Uri = "/Meta/Version";
		
		public string Method { get { return "GET"; } }
		public string RequiredAuth { get { return "None"; } }
		
		private readonly IClientContext vContext;
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public GetVersionOperation(IClientContext pContext) {
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


	// ReSharper restore InconsistentNaming
	// ReSharper restore RedundantArgumentDefaultValue

}