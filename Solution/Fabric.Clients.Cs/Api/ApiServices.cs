// GENERATED CODE
// Changes made to this source file will be overwritten
// Generated on 2/14/2013 3:03:34 PM

namespace Fabric.Clients.Cs.Api {

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
		IGetActiveAppOperation GetActiveApp { get; }

		///<summary>
		///  TODO
		///</summary>
		IGetActiveMemberOperation GetActiveMember { get; }

		///<summary>
		///  TODO
		///</summary>
		IGetActiveUserOperation GetActiveUser { get; }

		///<summary>
		///  The starting point for all traversal queries.
		///</summary>
		IGetRootOperation GetRoot { get; }

	}


	/*================================================================================================*/
	public class TraversalService : ITraversalService {

		public IGetActiveAppOperation GetActiveApp { get; private set; }
		public IGetActiveMemberOperation GetActiveMember { get; private set; }
		public IGetActiveUserOperation GetActiveUser { get; private set; }
		public IGetRootOperation GetRoot { get; private set; }

		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public TraversalService() {
			GetActiveApp = new GetActiveAppOperation();
			GetActiveMember = new GetActiveMemberOperation();
			GetActiveUser = new GetActiveUserOperation();
			GetRoot = new GetRootOperation();
		}

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
		IAccessTokenOperation AccessToken { get; }

		///<summary>
		///  This OAuth flow should be used immediately after obtaining an authorization code from the OAuth entry process.
		///</summary>
		IAccessTokenAuthCodeOperation AccessTokenAuthCode { get; }

		///<summary>
		///  This OAuth flow should be used to begin an OAuth session for your Fabric App.
		///</summary>
		IAccessTokenClientCredentialsOperation AccessTokenClientCredentials { get; }

		///<summary>
		///  This OAuth flow should be used to begin an OAuth session for your Fabric App's Data Provider User.
		///</summary>
		IAccessTokenClientDataProvOperation AccessTokenClientDataProv { get; }

		///<summary>
		///  This OAuth flow should be used to refresh an expired access token.
		///</summary>
		IAccessTokenRefreshOperation AccessTokenRefresh { get; }

		///<summary>
		///  This API request is unique -- it represents the entry point for Fabric's OAuth 2.0 authentication process.
		///</summary>
		ILoginOperation Login { get; }

		///<summary>
		///  Terminates a particular OAuth session by invalidating the session's access token.
		///</summary>
		ILogoutOperation Logout { get; }

	}


	/*================================================================================================*/
	public class OauthService : IOauthService {

		public IAccessTokenOperation AccessToken { get; private set; }
		public IAccessTokenAuthCodeOperation AccessTokenAuthCode { get; private set; }
		public IAccessTokenClientCredentialsOperation AccessTokenClientCredentials { get; private set; }
		public IAccessTokenClientDataProvOperation AccessTokenClientDataProv { get; private set; }
		public IAccessTokenRefreshOperation AccessTokenRefresh { get; private set; }
		public ILoginOperation Login { get; private set; }
		public ILogoutOperation Logout { get; private set; }

		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public OauthService() {
			AccessToken = new AccessTokenOperation();
			AccessTokenAuthCode = new AccessTokenAuthCodeOperation();
			AccessTokenClientCredentials = new AccessTokenClientCredentialsOperation();
			AccessTokenClientDataProv = new AccessTokenClientDataProvOperation();
			AccessTokenRefresh = new AccessTokenRefreshOperation();
			Login = new LoginOperation();
			Logout = new LogoutOperation();
		}

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
		IAddAppOperation AddApp { get; }

		///<summary>
		///  Create a new Class.
		///</summary>
		IAddClassOperation AddClass { get; }

		///<summary>
		///  Create a new Factor.
		///</summary>
		IAddFactorOperation AddFactor { get; }

		///<summary>
		///  Create a new Instance.
		///</summary>
		IAddInstanceOperation AddInstance { get; }

		///<summary>
		///  Create a new Url.
		///</summary>
		IAddUrlOperation AddUrl { get; }

		///<summary>
		///  Create a new User.
		///</summary>
		IAddUserOperation AddUser { get; }

		///<summary>
		///  Create a new Descriptor and attach it to the specified Factor.
		///</summary>
		IAttachDescriptorToFactorOperation AttachDescriptorToFactor { get; }

		///<summary>
		///  Create a new Director and attach it to the specified Factor.
		///</summary>
		IAttachDirectorToFactorOperation AttachDirectorToFactor { get; }

		///<summary>
		///  Create a new Eventor and attach it to the specified Factor.
		///</summary>
		IAttachEventorToFactorOperation AttachEventorToFactor { get; }

		///<summary>
		///  Create a new Identor and attach it to the specified Factor.
		///</summary>
		IAttachIdentorToFactorOperation AttachIdentorToFactor { get; }

		///<summary>
		///  Create a new Locator and attach it to the specified Factor.
		///</summary>
		IAttachLocatorToFactorOperation AttachLocatorToFactor { get; }

		///<summary>
		///  Create a new Vector and attach it to the specified Factor.
		///</summary>
		IAttachVectorToFactorOperation AttachVectorToFactor { get; }

		///<summary>
		///  Move a Factor from the 'incomplete' state to the 'complete' state.
		///</summary>
		ICompleteFactorOperation CompleteFactor { get; }

		///<summary>
		///  Delete a Factor.
		///</summary>
		IDeleteFactorOperation DeleteFactor { get; }

	}


	/*================================================================================================*/
	public class ModifyService : IModifyService {

		public IAddAppOperation AddApp { get; private set; }
		public IAddClassOperation AddClass { get; private set; }
		public IAddFactorOperation AddFactor { get; private set; }
		public IAddInstanceOperation AddInstance { get; private set; }
		public IAddUrlOperation AddUrl { get; private set; }
		public IAddUserOperation AddUser { get; private set; }
		public IAttachDescriptorToFactorOperation AttachDescriptorToFactor { get; private set; }
		public IAttachDirectorToFactorOperation AttachDirectorToFactor { get; private set; }
		public IAttachEventorToFactorOperation AttachEventorToFactor { get; private set; }
		public IAttachIdentorToFactorOperation AttachIdentorToFactor { get; private set; }
		public IAttachLocatorToFactorOperation AttachLocatorToFactor { get; private set; }
		public IAttachVectorToFactorOperation AttachVectorToFactor { get; private set; }
		public ICompleteFactorOperation CompleteFactor { get; private set; }
		public IDeleteFactorOperation DeleteFactor { get; private set; }

		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public ModifyService() {
			AddApp = new AddAppOperation();
			AddClass = new AddClassOperation();
			AddFactor = new AddFactorOperation();
			AddInstance = new AddInstanceOperation();
			AddUrl = new AddUrlOperation();
			AddUser = new AddUserOperation();
			AttachDescriptorToFactor = new AttachDescriptorToFactorOperation();
			AttachDirectorToFactor = new AttachDirectorToFactorOperation();
			AttachEventorToFactor = new AttachEventorToFactorOperation();
			AttachIdentorToFactor = new AttachIdentorToFactorOperation();
			AttachLocatorToFactor = new AttachLocatorToFactorOperation();
			AttachVectorToFactor = new AttachVectorToFactorOperation();
			CompleteFactor = new CompleteFactorOperation();
			DeleteFactor = new DeleteFactorOperation();
		}

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
		IDocumentOperation Document { get; }

	}


	/*================================================================================================*/
	public class SpecService : ISpecService {

		public IDocumentOperation Document { get; private set; }

		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public SpecService() {
			Document = new DocumentOperation();
		}

	}


}