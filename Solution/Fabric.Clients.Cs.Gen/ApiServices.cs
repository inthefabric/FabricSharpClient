namespace Fabric.Clients.Cs.Gen {

	/*================================================================================================*/
	///<summary>
	///  TODO
	///</summary>
	///<remarks>
	///  <para>TODO</para>
	///</remarks>
	public interface ITraversalService : IService {

		///<summary>
		///  TODO
		///</summary>
		IGetActiveAppOperation GetActiveApp();

		///<summary>
		///  TODO
		///</summary>
		IGetActiveMemberOperation GetActiveMember();

		///<summary>
		///  TODO
		///</summary>
		IGetActiveUserOperation GetActiveUser();

		///<summary>
		///  The starting point for all traversal queries.
		///</summary>
		IGetRootOperation GetRoot();


	}

	/*================================================================================================*/
	///<summary>
	///  TODO
	///</summary>
	///<remarks>
	///  <para>TODO</para>
	///</remarks>
	public interface IOauthService : IService {

		///<summary>
		///  Get an OAuth access token using one of four 'flows'.
		///</summary>
		IAccessTokenOperation AccessToken();

		///<summary>
		///  This OAuth flow should be used immediately after obtaining an authorization code from the OAuth entry process.
		///</summary>
		IAccessTokenAuthCodeOperation AccessTokenAuthCode();

		///<summary>
		///  This OAuth flow should be used to begin an OAuth session for your Fabric App.
		///</summary>
		IAccessTokenClientCredentialsOperation AccessTokenClientCredentials();

		///<summary>
		///  This OAuth flow should be used to begin an OAuth session for your Fabric App's Data Provider User.
		///</summary>
		IAccessTokenClientDataProvOperation AccessTokenClientDataProv();

		///<summary>
		///  This OAuth flow should be used to refresh an expired access token.
		///</summary>
		IAccessTokenRefreshOperation AccessTokenRefresh();

		///<summary>
		///  This API request is unique -- it represents the entry point for Fabric's OAuth 2.0 authentication process.
		///</summary>
		ILoginOperation Login();

		///<summary>
		///  Terminates a particular OAuth session by invalidating the session's access token.
		///</summary>
		ILogoutOperation Logout();


	}

	/*================================================================================================*/
	///<summary>
	///  TODO
	///</summary>
	///<remarks>
	///  <para>TODO</para>
	///</remarks>
	public interface IModifyService : IService {

		///<summary>
		///  Create a new App.
		///</summary>
		IAddAppOperation AddApp();

		///<summary>
		///  Create a new Class.
		///</summary>
		IAddClassOperation AddClass();

		///<summary>
		///  Create a new Factor.
		///</summary>
		IAddFactorOperation AddFactor();

		///<summary>
		///  Create a new Instance.
		///</summary>
		IAddInstanceOperation AddInstance();

		///<summary>
		///  Create a new Url.
		///</summary>
		IAddUrlOperation AddUrl();

		///<summary>
		///  Create a new User.
		///</summary>
		IAddUserOperation AddUser();

		///<summary>
		///  Create a new Descriptor and attach it to the specified Factor.
		///</summary>
		IAttachDescriptorToFactorOperation AttachDescriptorToFactor();

		///<summary>
		///  Create a new Director and attach it to the specified Factor.
		///</summary>
		IAttachDirectorToFactorOperation AttachDirectorToFactor();

		///<summary>
		///  Create a new Eventor and attach it to the specified Factor.
		///</summary>
		IAttachEventorToFactorOperation AttachEventorToFactor();

		///<summary>
		///  Create a new Identor and attach it to the specified Factor.
		///</summary>
		IAttachIdentorToFactorOperation AttachIdentorToFactor();

		///<summary>
		///  Create a new Locator and attach it to the specified Factor.
		///</summary>
		IAttachLocatorToFactorOperation AttachLocatorToFactor();

		///<summary>
		///  Create a new Vector and attach it to the specified Factor.
		///</summary>
		IAttachVectorToFactorOperation AttachVectorToFactor();

		///<summary>
		///  Move a Factor from the 'incomplete' state to the 'complete' state.
		///</summary>
		ICompleteFactorOperation CompleteFactor();

		///<summary>
		///  Delete a Factor.
		///</summary>
		IDeleteFactorOperation DeleteFactor();


	}

	/*================================================================================================*/
	///<summary>
	///  TODO
	///</summary>
	///<remarks>
	///  <para>TODO</para>
	///</remarks>
	public interface ISpecService : IService {

		///<summary>
		///  The latest specification and documentation for all Fabric API services.
		///</summary>
		IDocumentOperation Document();


	}

}