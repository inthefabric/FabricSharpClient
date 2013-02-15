// GENERATED CODE
// Changes made to this source file will be overwritten
// Generated on 2/15/2013 5:12:28 PM

using Fabric.Clients.Cs.Session;
using Fabric.Clients.Cs.Web;

namespace Fabric.Clients.Cs.Api {

	// ReSharper disable InconsistentNaming
	// ReSharper disable RedundantArgumentDefaultValue

	/*================================================================================================*/
	/// <summary>
	///   TODO
	/// </summary>
	/// <remarks>
	///   <para>TODO</para>
	/// </remarks>
	public interface IGetActiveAppOperation : IOperation {
		
		/// <summary>
		///   Perform the operation.
		/// </summary>
		IFabApp Get();

	}
	

	/*================================================================================================*/
	internal class GetActiveAppOperation : IGetActiveAppOperation {
		
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
		public FabricRequest<IFabApp, FabApp> Request() {
			return new FabricRequest<IFabApp, FabApp>(
				"GET",
				"/Trav/ActiveApp", 
				null,
				null
			);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabApp Get() {
			return Request().Send(vContext);
		}

	}


	/*================================================================================================*/
	/// <summary>
	///   TODO
	/// </summary>
	/// <remarks>
	///   <para>TODO</para>
	/// </remarks>
	public interface IGetActiveMemberOperation : IOperation {
		
		/// <summary>
		///   Perform the operation.
		/// </summary>
		IFabMember Get();

	}
	

	/*================================================================================================*/
	internal class GetActiveMemberOperation : IGetActiveMemberOperation {
		
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
		public FabricRequest<IFabMember, FabMember> Request() {
			return new FabricRequest<IFabMember, FabMember>(
				"GET",
				"/Trav/ActiveMember", 
				null,
				null
			);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabMember Get() {
			return Request().Send(vContext);
		}

	}


	/*================================================================================================*/
	/// <summary>
	///   TODO
	/// </summary>
	/// <remarks>
	///   <para>TODO</para>
	/// </remarks>
	public interface IGetActiveUserOperation : IOperation {
		
		/// <summary>
		///   Perform the operation.
		/// </summary>
		IFabUser Get();

	}
	

	/*================================================================================================*/
	internal class GetActiveUserOperation : IGetActiveUserOperation {
		
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
		public FabricRequest<IFabUser, FabUser> Request() {
			return new FabricRequest<IFabUser, FabUser>(
				"GET",
				"/Trav/ActiveUser", 
				null,
				null
			);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabUser Get() {
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
		IFabRoot Get();

	}
	

	/*================================================================================================*/
	internal class GetRootOperation : IGetRootOperation {
		
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
		public FabricRequest<IFabRoot, FabRoot> Request() {
			return new FabricRequest<IFabRoot, FabRoot>(
				"GET",
				"/Trav/Root", 
				null,
				null
			);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabRoot Get() {
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
		/// <param name="client_id">
		///   The App ID value (an integer) for the App making the request. This parameter is only used by the 'Client Credentials' and 'Client Data Provider' flows.
		/// </param>
		/// <param name="client_secret">
		///   The alpha-numeric Secret for the App making the request. This verifies that the App itself is making the request, and not an imposter.  For this reason, the secret code should not be shared with anyone.
		/// </param>
		/// <param name="code">
		///   The authorization code obtained after a successful OAuth entry process. This parameter is only used by the 'Authorization Code' flow.
		/// </param>
		/// <param name="data_prov_userid">
		///   The User ID value (an integer) for the Data Provider of the App making the request. Upon App creation, Fabric creates a special 'Data Provider' User which the App uses for creating items in the Fabric system. This parameter is only used by the 'Client Data Provider' flow.
		/// </param>
		/// <param name="grant_type">
		///   Defines the desired access token flow.  The four accepted (case-sensitive) values are 'authorization_code', 'refresh', 'client_credentials', and 'client_data_provider'.
		/// </param>
		/// <param name="redirect_uri">
		///   This value must be exactly the same as the redirect URI provided for the OAuth entry process.
		/// </param>
		/// <param name="refresh_token">
		///   The refresh token obtained after a successful 'Authorization Code' access token flow.  A refresh token only applies to User-based OAuth sessions, not for App-based OAuth sessions.  This parameter is only used by the 'Refresh' flow.
		/// </param>
		IFabOauthAccess Get(string client_id, string client_secret, string code, string data_prov_userid, string grant_type, string redirect_uri, string refresh_token);

	}
	

	/*================================================================================================*/
	internal class AccessTokenOperation : IAccessTokenOperation {
		
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
		public FabricRequest<IFabOauthAccess, FabOauthAccess> Request(string client_id, string client_secret, string code, string data_prov_userid, string grant_type, string redirect_uri, string refresh_token) {
			return new FabricRequest<IFabOauthAccess, FabOauthAccess>(
				"GET",
				"/Oauth/AccessToken", 
				"client_id="+client_id+"&client_secret="+client_secret+"&code="+code+"&data_prov_userid="+data_prov_userid+"&grant_type="+grant_type+"&redirect_uri="+redirect_uri+"&refresh_token="+refresh_token,
				null
			);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabOauthAccess Get(string client_id, string client_secret, string code, string data_prov_userid, string grant_type, string redirect_uri, string refresh_token) {
			return Request(client_id, client_secret, code, data_prov_userid, grant_type, redirect_uri, refresh_token).Send(vContext);
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
		/// <param name="client_secret">
		///   The alpha-numeric Secret for the App making the request. This verifies that the App itself is making the request, and not an imposter.  For this reason, the secret code should not be shared with anyone.
		/// </param>
		/// <param name="code">
		///   The authorization code obtained after a successful OAuth entry process. This parameter is only used by the 'Authorization Code' flow.
		/// </param>
		/// <param name="redirect_uri">
		///   This value must be exactly the same as the redirect URI provided for the OAuth entry process.
		/// </param>
		IFabOauthAccess Get(string client_secret, string code, string redirect_uri);

	}
	

	/*================================================================================================*/
	internal class AccessTokenAuthCodeOperation : IAccessTokenAuthCodeOperation {
		
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
		public FabricRequest<IFabOauthAccess, FabOauthAccess> Request(string client_secret, string code, string redirect_uri) {
			return new FabricRequest<IFabOauthAccess, FabOauthAccess>(
				"GET",
				"/Oauth/AccessTokenAuthCode", 
				"client_secret="+client_secret+"&code="+code+"&redirect_uri="+redirect_uri,
				null
			);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabOauthAccess Get(string client_secret, string code, string redirect_uri) {
			return Request(client_secret, code, redirect_uri).Send(vContext);
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
		IFabOauthAccess Get(string client_id, string client_secret, string redirect_uri);

	}
	

	/*================================================================================================*/
	internal class AccessTokenClientCredentialsOperation : IAccessTokenClientCredentialsOperation {
		
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
		public FabricRequest<IFabOauthAccess, FabOauthAccess> Request(string client_id, string client_secret, string redirect_uri) {
			return new FabricRequest<IFabOauthAccess, FabOauthAccess>(
				"GET",
				"/Oauth/AccessTokenClientCredentials", 
				"client_id="+client_id+"&client_secret="+client_secret+"&redirect_uri="+redirect_uri,
				null
			);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabOauthAccess Get(string client_id, string client_secret, string redirect_uri) {
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
		/// <param name="data_prov_userid">
		///   The User ID value (an integer) for the Data Provider of the App making the request. Upon App creation, Fabric creates a special 'Data Provider' User which the App uses for creating items in the Fabric system. This parameter is only used by the 'Client Data Provider' flow.
		/// </param>
		/// <param name="redirect_uri">
		///   This value must be exactly the same as the redirect URI provided for the OAuth entry process.
		/// </param>
		IFabOauthAccess Get(string client_id, string client_secret, string data_prov_userid, string redirect_uri);

	}
	

	/*================================================================================================*/
	internal class AccessTokenClientDataProvOperation : IAccessTokenClientDataProvOperation {
		
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
		public FabricRequest<IFabOauthAccess, FabOauthAccess> Request(string client_id, string client_secret, string data_prov_userid, string redirect_uri) {
			return new FabricRequest<IFabOauthAccess, FabOauthAccess>(
				"GET",
				"/Oauth/AccessTokenClientDataProv", 
				"client_id="+client_id+"&client_secret="+client_secret+"&data_prov_userid="+data_prov_userid+"&redirect_uri="+redirect_uri,
				null
			);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabOauthAccess Get(string client_id, string client_secret, string data_prov_userid, string redirect_uri) {
			return Request(client_id, client_secret, data_prov_userid, redirect_uri).Send(vContext);
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
		/// <param name="client_secret">
		///   The alpha-numeric Secret for the App making the request. This verifies that the App itself is making the request, and not an imposter.  For this reason, the secret code should not be shared with anyone.
		/// </param>
		/// <param name="redirect_uri">
		///   This value must be exactly the same as the redirect URI provided for the OAuth entry process.
		/// </param>
		/// <param name="refresh_token">
		///   The refresh token obtained after a successful 'Authorization Code' access token flow.  A refresh token only applies to User-based OAuth sessions, not for App-based OAuth sessions.  This parameter is only used by the 'Refresh' flow.
		/// </param>
		IFabOauthAccess Get(string client_secret, string redirect_uri, string refresh_token);

	}
	

	/*================================================================================================*/
	internal class AccessTokenRefreshOperation : IAccessTokenRefreshOperation {
		
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
		public FabricRequest<IFabOauthAccess, FabOauthAccess> Request(string client_secret, string redirect_uri, string refresh_token) {
			return new FabricRequest<IFabOauthAccess, FabOauthAccess>(
				"GET",
				"/Oauth/AccessTokenRefresh", 
				"client_secret="+client_secret+"&redirect_uri="+redirect_uri+"&refresh_token="+refresh_token,
				null
			);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabOauthAccess Get(string client_secret, string redirect_uri, string refresh_token) {
			return Request(client_secret, redirect_uri, refresh_token).Send(vContext);
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
		/// <param name="client_id">
		///   The ID of the Fabric App making the OAuth Login request.  The access code provided after a successful OAuth process will be associated with this App ID and the authenticated User's ID.
		/// </param>
		/// <param name="redirect_uri">
		///   The URL which will receive success/error redirects from the OAuth Login process.  This URL should handle the following query-string parameters: access_code, error, error_description, state.
		/// </param>
		/// <param name="response_type">
		///   Describes which type of authentication should be performed. For now, this value should always be 'code'. Fabric may accept more response types in the future.
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
		IFabOauthLogin Get(string client_id, string redirect_uri, string response_type, string scope, string state, string switchMode);

	}
	

	/*================================================================================================*/
	internal class LoginOperation : ILoginOperation {
		
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
		public FabricRequest<IFabOauthLogin, FabOauthLogin> Request(string client_id, string redirect_uri, string response_type, string scope, string state, string switchMode) {
			return new FabricRequest<IFabOauthLogin, FabOauthLogin>(
				"GET",
				"/Oauth/Login", 
				"client_id="+client_id+"&redirect_uri="+redirect_uri+"&response_type="+response_type+"&scope="+scope+"&state="+state+"&switchMode="+switchMode,
				null
			);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabOauthLogin Get(string client_id, string redirect_uri, string response_type, string scope, string state, string switchMode) {
			return Request(client_id, redirect_uri, response_type, scope, state, switchMode).Send(vContext);
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
		IFabOauthLogout Get(string access_token);

	}
	

	/*================================================================================================*/
	internal class LogoutOperation : ILogoutOperation {
		
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
		public FabricRequest<IFabOauthLogout, FabOauthLogout> Request(string access_token) {
			return new FabricRequest<IFabOauthLogout, FabOauthLogout>(
				"GET",
				"/Oauth/Logout", 
				"access_token="+access_token,
				null
			);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabOauthLogout Get(string access_token) {
			return Request(access_token).Send(vContext);
		}

	}


	/*================================================================================================*/
	/// <summary>
	///   Create a new App.
	/// </summary>
	/// <remarks>
	///   <para>Create a new App.</para>
	/// </remarks>
	public interface IAddAppOperation : IOperation {
		
		/// <summary>
		///   Perform the operation.
		/// </summary>
		/// <param name="Name">
		///   The name of the new App.
		/// </param>
		/// <param name="UserId">
		///   Identifies the User that is creating the App. This User will receive the App's 'DataProvider' Member.
		/// </param>
		IFabApp Post(string Name, long UserId);

	}
	

	/*================================================================================================*/
	internal class AddAppOperation : IAddAppOperation {
		
		public string Method { get { return "POST"; } }
		public string RequiredAuth { get { return "Fabric"; } }
		
		private readonly IClientContext vContext;
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public AddAppOperation(IClientContext pContext) {
			vContext = pContext;
		}

		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabricRequest<IFabApp, FabApp> Request(string Name, long UserId) {
			return new FabricRequest<IFabApp, FabApp>(
				"POST",
				"/Mod/Apps", 
				null,
				"Name="+Name+"&UserId="+UserId
			);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabApp Post(string Name, long UserId) {
			return Request(Name, UserId).Send(vContext);
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
		/// <param name="Disamb">
		///   The disambiguation text for the new Class.  When provided, the disambiguation text permits the use of a non-unique name.
		/// </param>
		/// <param name="Name">
		///   The name of the new Class. It must be unique on its own, or be unique in combination with the disambiguation text.
		/// </param>
		/// <param name="Note">
		///   A brief description of the new Class. It can be useful for helping others understand the creator's intended purpose or meaning.
		/// </param>
		IFabClass Post(string Disamb, string Name, string Note);

	}
	

	/*================================================================================================*/
	internal class AddClassOperation : IAddClassOperation {
		
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
		public FabricRequest<IFabClass, FabClass> Request(string Disamb, string Name, string Note) {
			return new FabricRequest<IFabClass, FabClass>(
				"POST",
				"/Mod/Classes", 
				null,
				"Disamb="+Disamb+"&Name="+Name+"&Note="+Note
			);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabClass Post(string Disamb, string Name, string Note) {
			return Request(Disamb, Name, Note).Send(vContext);
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
		/// <param name="FactorAssertionId">
		///   Identifies the FactorAssertion for the new Factor. In cases where the assertion type is unclear or not known, please use the 'Undefined' FactorAssertion.
		/// </param>
		/// <param name="IsDefining">
		///   The IsDefining value for the new Factor.
		/// </param>
		/// <param name="Note">
		///   A sentence or short paragraph describing (in a human-readable format) the intended meaning of the new Factor. A descriptive note can help others understand the creator's intended purpose or meaning for the Factor.
		/// </param>
		/// <param name="PrimaryArtifactId">
		///   Identifies the primary Artifact for the new Factor.
		/// </param>
		/// <param name="RelatedArtifactId">
		///   Identifies the related Artifact for the new Factor. The related Artifact cannot be the same as the primary Artifact.
		/// </param>
		IFabFactor Post(long FactorAssertionId, bool IsDefining, string Note, long PrimaryArtifactId, long RelatedArtifactId);

	}
	

	/*================================================================================================*/
	internal class AddFactorOperation : IAddFactorOperation {
		
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
		public FabricRequest<IFabFactor, FabFactor> Request(long FactorAssertionId, bool IsDefining, string Note, long PrimaryArtifactId, long RelatedArtifactId) {
			return new FabricRequest<IFabFactor, FabFactor>(
				"POST",
				"/Mod/Factors", 
				null,
				"FactorAssertionId="+FactorAssertionId+"&IsDefining="+IsDefining+"&Note="+Note+"&PrimaryArtifactId="+PrimaryArtifactId+"&RelatedArtifactId="+RelatedArtifactId
			);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabFactor Post(long FactorAssertionId, bool IsDefining, string Note, long PrimaryArtifactId, long RelatedArtifactId) {
			return Request(FactorAssertionId, IsDefining, Note, PrimaryArtifactId, RelatedArtifactId).Send(vContext);
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
		/// <param name="Disamb">
		///   The disambiguation text for the new Instance. When provided, the disambiguation text permits the use of a non-unique name.
		/// </param>
		/// <param name="Name">
		///   The name of the new Instance. It does not need to be unique.
		/// </param>
		/// <param name="Note">
		///   A brief description of the new Instance.  It can be useful for helping others understand the creator's intended purpose or meaning.
		/// </param>
		IFabInstance Post(string Disamb, string Name, string Note);

	}
	

	/*================================================================================================*/
	internal class AddInstanceOperation : IAddInstanceOperation {
		
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
		public FabricRequest<IFabInstance, FabInstance> Request(string Disamb, string Name, string Note) {
			return new FabricRequest<IFabInstance, FabInstance>(
				"POST",
				"/Mod/Instances", 
				null,
				"Disamb="+Disamb+"&Name="+Name+"&Note="+Note
			);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabInstance Post(string Disamb, string Name, string Note) {
			return Request(Disamb, Name, Note).Send(vContext);
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
		IFabUrl Post(string AbsoluteUrl, string Name);

	}
	

	/*================================================================================================*/
	internal class AddUrlOperation : IAddUrlOperation {
		
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
		public FabricRequest<IFabUrl, FabUrl> Request(string AbsoluteUrl, string Name) {
			return new FabricRequest<IFabUrl, FabUrl>(
				"POST",
				"/Mod/Urls", 
				null,
				"AbsoluteUrl="+AbsoluteUrl+"&Name="+Name
			);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabUrl Post(string AbsoluteUrl, string Name) {
			return Request(AbsoluteUrl, Name).Send(vContext);
		}

	}


	/*================================================================================================*/
	/// <summary>
	///   Create a new User.
	/// </summary>
	/// <remarks>
	///   <para>Create a new User.</para>
	/// </remarks>
	public interface IAddUserOperation : IOperation {
		
		/// <summary>
		///   Perform the operation.
		/// </summary>
		/// <param name="Email">
		///   The email address for the new User.
		/// </param>
		/// <param name="Name">
		///   The username for the new User.
		/// </param>
		/// <param name="Password">
		///   The password for the new User.
		/// </param>
		IFabUser Post(string Email, string Name, string Password);

	}
	

	/*================================================================================================*/
	internal class AddUserOperation : IAddUserOperation {
		
		public string Method { get { return "POST"; } }
		public string RequiredAuth { get { return "Fabric"; } }
		
		private readonly IClientContext vContext;
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public AddUserOperation(IClientContext pContext) {
			vContext = pContext;
		}

		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabricRequest<IFabUser, FabUser> Request(string Email, string Name, string Password) {
			return new FabricRequest<IFabUser, FabUser>(
				"POST",
				"/Mod/Users", 
				null,
				"Email="+Email+"&Name="+Name+"&Password="+Password
			);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabUser Post(string Email, string Name, string Password) {
			return Request(Email, Name, Password).Send(vContext);
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
		/// <param name="DescriptorTypeId">
		///   Identifies the DescriptorType for the new Descriptor.
		/// </param>
		/// <param name="DescriptorTypeRefineId">
		///   Identifies the Artifact that refines the new Descriptor's DescriptorType.
		/// </param>
		/// <param name="FactorId">
		///   Identifies the incomplete Factor that will receive the Descriptor attachment.
		/// </param>
		/// <param name="PrimaryArtifactRefineId">
		///   Identifies the Artifact that refines the Factor's primary Artifact.
		/// </param>
		/// <param name="RelatedArtifactRefineId">
		///   Identifies the Artifact that refines the Factor's related Artifact.
		/// </param>
		IFabDescriptor Post(long DescriptorTypeId, long? DescriptorTypeRefineId, long FactorId, long? PrimaryArtifactRefineId, long? RelatedArtifactRefineId);

	}
	

	/*================================================================================================*/
	internal class AttachDescriptorToFactorOperation : IAttachDescriptorToFactorOperation {
		
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
		public FabricRequest<IFabDescriptor, FabDescriptor> Request(long DescriptorTypeId, long? DescriptorTypeRefineId, long FactorId, long? PrimaryArtifactRefineId, long? RelatedArtifactRefineId) {
			return new FabricRequest<IFabDescriptor, FabDescriptor>(
				"POST",
				"/Mod/Descriptors", 
				null,
				"DescriptorTypeId="+DescriptorTypeId+"&DescriptorTypeRefineId="+DescriptorTypeRefineId+"&FactorId="+FactorId+"&PrimaryArtifactRefineId="+PrimaryArtifactRefineId+"&RelatedArtifactRefineId="+RelatedArtifactRefineId
			);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabDescriptor Post(long DescriptorTypeId, long? DescriptorTypeRefineId, long FactorId, long? PrimaryArtifactRefineId, long? RelatedArtifactRefineId) {
			return Request(DescriptorTypeId, DescriptorTypeRefineId, FactorId, PrimaryArtifactRefineId, RelatedArtifactRefineId).Send(vContext);
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
		/// <param name="DirectorTypeId">
		///   Identifies the DirectorType for the new Director.
		/// </param>
		/// <param name="FactorId">
		///   Identifies the incomplete Factor that will receive the Director attachment.
		/// </param>
		/// <param name="PrimaryDirectorActionId">
		///   Identifies the DirectorAction associated with the Factor's primary Artifact.
		/// </param>
		/// <param name="RelatedDirectorActionId">
		///   Identifies the DirectorAction associated with the Factor's related Artifact.
		/// </param>
		IFabDirector Post(long DirectorTypeId, long FactorId, long PrimaryDirectorActionId, long RelatedDirectorActionId);

	}
	

	/*================================================================================================*/
	internal class AttachDirectorToFactorOperation : IAttachDirectorToFactorOperation {
		
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
		public FabricRequest<IFabDirector, FabDirector> Request(long DirectorTypeId, long FactorId, long PrimaryDirectorActionId, long RelatedDirectorActionId) {
			return new FabricRequest<IFabDirector, FabDirector>(
				"POST",
				"/Mod/Directors", 
				null,
				"DirectorTypeId="+DirectorTypeId+"&FactorId="+FactorId+"&PrimaryDirectorActionId="+PrimaryDirectorActionId+"&RelatedDirectorActionId="+RelatedDirectorActionId
			);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabDirector Post(long DirectorTypeId, long FactorId, long PrimaryDirectorActionId, long RelatedDirectorActionId) {
			return Request(DirectorTypeId, FactorId, PrimaryDirectorActionId, RelatedDirectorActionId).Send(vContext);
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
		/// <param name="DateTime">
		///   The date and time for the new Eventor. This value must be accurate to the level of precision defined by the specified EventorPrecision. Set unused month/day values to 1, and unused hour/minute values (and beyond) to 0.
		/// </param>
		/// <param name="EventorPrecisionId">
		///   Identifies the EventorPrecision for the new Eventor.
		/// </param>
		/// <param name="EventorTypeId">
		///   Identifies the EventorType for the new Eventor.
		/// </param>
		/// <param name="FactorId">
		///   Identifies the incomplete Factor that will receive the Eventor attachment.
		/// </param>
		IFabEventor Post(long DateTime, long EventorPrecisionId, long EventorTypeId, long FactorId);

	}
	

	/*================================================================================================*/
	internal class AttachEventorToFactorOperation : IAttachEventorToFactorOperation {
		
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
		public FabricRequest<IFabEventor, FabEventor> Request(long DateTime, long EventorPrecisionId, long EventorTypeId, long FactorId) {
			return new FabricRequest<IFabEventor, FabEventor>(
				"POST",
				"/Mod/Eventors", 
				null,
				"DateTime="+DateTime+"&EventorPrecisionId="+EventorPrecisionId+"&EventorTypeId="+EventorTypeId+"&FactorId="+FactorId
			);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabEventor Post(long DateTime, long EventorPrecisionId, long EventorTypeId, long FactorId) {
			return Request(DateTime, EventorPrecisionId, EventorTypeId, FactorId).Send(vContext);
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
		IFabIdentor Post(long FactorId, long IdentorTypeId, string Value);

	}
	

	/*================================================================================================*/
	internal class AttachIdentorToFactorOperation : IAttachIdentorToFactorOperation {
		
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
		public FabricRequest<IFabIdentor, FabIdentor> Request(long FactorId, long IdentorTypeId, string Value) {
			return new FabricRequest<IFabIdentor, FabIdentor>(
				"POST",
				"/Mod/Identors", 
				null,
				"FactorId="+FactorId+"&IdentorTypeId="+IdentorTypeId+"&Value="+Value
			);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabIdentor Post(long FactorId, long IdentorTypeId, string Value) {
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
		IFabLocator Post(long FactorId, long LocatorTypeId, double ValueX, double ValueY, double ValueZ);

	}
	

	/*================================================================================================*/
	internal class AttachLocatorToFactorOperation : IAttachLocatorToFactorOperation {
		
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
		public FabricRequest<IFabLocator, FabLocator> Request(long FactorId, long LocatorTypeId, double ValueX, double ValueY, double ValueZ) {
			return new FabricRequest<IFabLocator, FabLocator>(
				"POST",
				"/Mod/Locators", 
				null,
				"FactorId="+FactorId+"&LocatorTypeId="+LocatorTypeId+"&ValueX="+ValueX+"&ValueY="+ValueY+"&ValueZ="+ValueZ
			);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabLocator Post(long FactorId, long LocatorTypeId, double ValueX, double ValueY, double ValueZ) {
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
		/// <param name="AxisArtifactId">
		///   The Artifact which provides meaning for the new Vector.
		/// </param>
		/// <param name="FactorId">
		///   Identifies the incomplete Factor that will receive the Vector attachment.
		/// </param>
		/// <param name="Value">
		///   The value for the new Vector. This value must be within the range specified by the VectorType. Decimal values are not supported; if additional precision is required, use a VectorUnitPrefix such as Milli or Micro.
		/// </param>
		/// <param name="VectorTypeId">
		///   Identifies the VectorType for the new Vector.
		/// </param>
		/// <param name="VectorUnitId">
		///   Identifies the VectorUnit for the new Vector.
		/// </param>
		/// <param name="VectorUnitPrefixId">
		///   Identifies the VectorUnitPrefix for the new Vector.
		/// </param>
		IFabVector Post(long AxisArtifactId, long FactorId, long Value, long VectorTypeId, long VectorUnitId, long VectorUnitPrefixId);

	}
	

	/*================================================================================================*/
	internal class AttachVectorToFactorOperation : IAttachVectorToFactorOperation {
		
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
		public FabricRequest<IFabVector, FabVector> Request(long AxisArtifactId, long FactorId, long Value, long VectorTypeId, long VectorUnitId, long VectorUnitPrefixId) {
			return new FabricRequest<IFabVector, FabVector>(
				"POST",
				"/Mod/Vectors", 
				null,
				"AxisArtifactId="+AxisArtifactId+"&FactorId="+FactorId+"&Value="+Value+"&VectorTypeId="+VectorTypeId+"&VectorUnitId="+VectorUnitId+"&VectorUnitPrefixId="+VectorUnitPrefixId
			);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabVector Post(long AxisArtifactId, long FactorId, long Value, long VectorTypeId, long VectorUnitId, long VectorUnitPrefixId) {
			return Request(AxisArtifactId, FactorId, Value, VectorTypeId, VectorUnitId, VectorUnitPrefixId).Send(vContext);
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
		IFabFactor Put(long FactorId, bool IsCompleted);

	}
	

	/*================================================================================================*/
	internal class CompleteFactorOperation : ICompleteFactorOperation {
		
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
		public FabricRequest<IFabFactor, FabFactor> Request(long FactorId, bool IsCompleted) {
			return new FabricRequest<IFabFactor, FabFactor>(
				"PUT",
				"/Mod/Factors", 
				null,
				"FactorId="+FactorId+"&IsCompleted="+IsCompleted
			);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabFactor Put(long FactorId, bool IsCompleted) {
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
		IFabFactor Delete(long FactorId, bool IsDeleted);

	}
	

	/*================================================================================================*/
	internal class DeleteFactorOperation : IDeleteFactorOperation {
		
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
		public FabricRequest<IFabFactor, FabFactor> Request(long FactorId, bool IsDeleted) {
			return new FabricRequest<IFabFactor, FabFactor>(
				"DELETE",
				"/Mod/Factors", 
				null,
				"FactorId="+FactorId+"&IsDeleted="+IsDeleted
			);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabFactor Delete(long FactorId, bool IsDeleted) {
			return Request(FactorId, IsDeleted).Send(vContext);
		}

	}


	/*================================================================================================*/
	/// <summary>
	///   The latest specification and documentation for all Fabric API services.
	/// </summary>
	/// <remarks>
	///   <para>The latest specification and documentation for all Fabric API services. This is useful for building Fabric API clients and reference documentation sites like the one you are viewing right now.</para>
	/// </remarks>
	public interface IDocumentOperation : IOperation {
		
		/// <summary>
		///   Perform the operation.
		/// </summary>
		IFabSpec Get();

	}
	

	/*================================================================================================*/
	internal class DocumentOperation : IDocumentOperation {
		
		public string Method { get { return "GET"; } }
		public string RequiredAuth { get { return "None"; } }
		
		private readonly IClientContext vContext;
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public DocumentOperation(IClientContext pContext) {
			vContext = pContext;
		}

		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabricRequest<IFabSpec, FabSpec> Request() {
			return new FabricRequest<IFabSpec, FabSpec>(
				"GET",
				"/Spec/Doc", 
				null,
				null
			);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabSpec Get() {
			return Request().Send(vContext);
		}

	}


	// ReSharper restore InconsistentNaming
	// ReSharper restore RedundantArgumentDefaultValue

}