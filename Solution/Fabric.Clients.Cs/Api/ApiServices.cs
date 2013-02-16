// GENERATED CODE
// Changes made to this source file will be overwritten
// Generated on 2/15/2013 7:39:06 PM

using Fabric.Clients.Cs.Session;

namespace Fabric.Clients.Cs.Api {

	/*================================================================================================*/
	/// <summary>
	///   TODO
	/// </summary>
	/// <remarks>
	///   <para>TODO</para>
	/// </remarks>
	public partial interface ITraversalService : IService {

		/// <summary>
		///   TODO
		/// </summary>
		IGetActiveAppOperation GetActiveApp { get; }

		/// <summary>
		///   TODO
		/// </summary>
		IGetActiveMemberOperation GetActiveMember { get; }

		/// <summary>
		///   TODO
		/// </summary>
		IGetActiveUserOperation GetActiveUser { get; }

		/// <summary>
		///   The starting point for all traversal queries.
		/// </summary>
		IGetRootOperation GetRoot { get; }

	}


	/*================================================================================================*/
	internal partial class TraversalService : ITraversalService {
	
		private readonly IClientContext vContext;

		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public TraversalService(IClientContext pContext) {
			vContext = pContext;
		}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public IGetActiveAppOperation GetActiveApp {
			get { return new GetActiveAppOperation(vContext); }
		}

		/*--------------------------------------------------------------------------------------------*/
		public IGetActiveMemberOperation GetActiveMember {
			get { return new GetActiveMemberOperation(vContext); }
		}

		/*--------------------------------------------------------------------------------------------*/
		public IGetActiveUserOperation GetActiveUser {
			get { return new GetActiveUserOperation(vContext); }
		}

		/*--------------------------------------------------------------------------------------------*/
		public IGetRootOperation GetRoot {
			get { return new GetRootOperation(vContext); }
		}

	}


	/*================================================================================================*/
	/// <summary>
	///   TODO
	/// </summary>
	/// <remarks>
	///   <para>TODO</para>
	/// </remarks>
	public interface IOauthService : IService {

		/// <summary>
		///   Get an OAuth access token using one of four 'flows'.
		/// </summary>
		IAccessTokenOperation AccessToken { get; }

		/// <summary>
		///   This OAuth flow should be used immediately after obtaining an authorization code from the OAuth entry process.
		/// </summary>
		IAccessTokenAuthCodeOperation AccessTokenAuthCode { get; }

		/// <summary>
		///   This OAuth flow should be used to begin an OAuth session for your Fabric App.
		/// </summary>
		IAccessTokenClientCredentialsOperation AccessTokenClientCredentials { get; }

		/// <summary>
		///   This OAuth flow should be used to begin an OAuth session for your Fabric App's Data Provider User.
		/// </summary>
		IAccessTokenClientDataProvOperation AccessTokenClientDataProv { get; }

		/// <summary>
		///   This OAuth flow should be used to refresh an expired access token.
		/// </summary>
		IAccessTokenRefreshOperation AccessTokenRefresh { get; }

		/// <summary>
		///   This API request is unique -- it represents the entry point for Fabric's OAuth 2.0 authentication process.
		/// </summary>
		ILoginOperation Login { get; }

		/// <summary>
		///   Terminates a particular OAuth session by invalidating the session's access token.
		/// </summary>
		ILogoutOperation Logout { get; }

	}


	/*================================================================================================*/
	internal class OauthService : IOauthService {
	
		private readonly IClientContext vContext;

		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public OauthService(IClientContext pContext) {
			vContext = pContext;
		}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public IAccessTokenOperation AccessToken {
			get { return new AccessTokenOperation(vContext); }
		}

		/*--------------------------------------------------------------------------------------------*/
		public IAccessTokenAuthCodeOperation AccessTokenAuthCode {
			get { return new AccessTokenAuthCodeOperation(vContext); }
		}

		/*--------------------------------------------------------------------------------------------*/
		public IAccessTokenClientCredentialsOperation AccessTokenClientCredentials {
			get { return new AccessTokenClientCredentialsOperation(vContext); }
		}

		/*--------------------------------------------------------------------------------------------*/
		public IAccessTokenClientDataProvOperation AccessTokenClientDataProv {
			get { return new AccessTokenClientDataProvOperation(vContext); }
		}

		/*--------------------------------------------------------------------------------------------*/
		public IAccessTokenRefreshOperation AccessTokenRefresh {
			get { return new AccessTokenRefreshOperation(vContext); }
		}

		/*--------------------------------------------------------------------------------------------*/
		public ILoginOperation Login {
			get { return new LoginOperation(vContext); }
		}

		/*--------------------------------------------------------------------------------------------*/
		public ILogoutOperation Logout {
			get { return new LogoutOperation(vContext); }
		}

	}


	/*================================================================================================*/
	/// <summary>
	///   TODO
	/// </summary>
	/// <remarks>
	///   <para>TODO</para>
	/// </remarks>
	public interface IModifyService : IService {

		/// <summary>
		///   Create a new App.
		/// </summary>
		IAddAppOperation AddApp { get; }

		/// <summary>
		///   Create a new Class.
		/// </summary>
		IAddClassOperation AddClass { get; }

		/// <summary>
		///   Create a new Factor.
		/// </summary>
		IAddFactorOperation AddFactor { get; }

		/// <summary>
		///   Create a new Instance.
		/// </summary>
		IAddInstanceOperation AddInstance { get; }

		/// <summary>
		///   Create a new Url.
		/// </summary>
		IAddUrlOperation AddUrl { get; }

		/// <summary>
		///   Create a new User.
		/// </summary>
		IAddUserOperation AddUser { get; }

		/// <summary>
		///   Create a new Descriptor and attach it to the specified Factor.
		/// </summary>
		IAttachDescriptorToFactorOperation AttachDescriptorToFactor { get; }

		/// <summary>
		///   Create a new Director and attach it to the specified Factor.
		/// </summary>
		IAttachDirectorToFactorOperation AttachDirectorToFactor { get; }

		/// <summary>
		///   Create a new Eventor and attach it to the specified Factor.
		/// </summary>
		IAttachEventorToFactorOperation AttachEventorToFactor { get; }

		/// <summary>
		///   Create a new Identor and attach it to the specified Factor.
		/// </summary>
		IAttachIdentorToFactorOperation AttachIdentorToFactor { get; }

		/// <summary>
		///   Create a new Locator and attach it to the specified Factor.
		/// </summary>
		IAttachLocatorToFactorOperation AttachLocatorToFactor { get; }

		/// <summary>
		///   Create a new Vector and attach it to the specified Factor.
		/// </summary>
		IAttachVectorToFactorOperation AttachVectorToFactor { get; }

		/// <summary>
		///   Move a Factor from the 'incomplete' state to the 'complete' state.
		/// </summary>
		ICompleteFactorOperation CompleteFactor { get; }

		/// <summary>
		///   Delete a Factor.
		/// </summary>
		IDeleteFactorOperation DeleteFactor { get; }

	}


	/*================================================================================================*/
	internal class ModifyService : IModifyService {
	
		private readonly IClientContext vContext;

		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public ModifyService(IClientContext pContext) {
			vContext = pContext;
		}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public IAddAppOperation AddApp {
			get { return new AddAppOperation(vContext); }
		}

		/*--------------------------------------------------------------------------------------------*/
		public IAddClassOperation AddClass {
			get { return new AddClassOperation(vContext); }
		}

		/*--------------------------------------------------------------------------------------------*/
		public IAddFactorOperation AddFactor {
			get { return new AddFactorOperation(vContext); }
		}

		/*--------------------------------------------------------------------------------------------*/
		public IAddInstanceOperation AddInstance {
			get { return new AddInstanceOperation(vContext); }
		}

		/*--------------------------------------------------------------------------------------------*/
		public IAddUrlOperation AddUrl {
			get { return new AddUrlOperation(vContext); }
		}

		/*--------------------------------------------------------------------------------------------*/
		public IAddUserOperation AddUser {
			get { return new AddUserOperation(vContext); }
		}

		/*--------------------------------------------------------------------------------------------*/
		public IAttachDescriptorToFactorOperation AttachDescriptorToFactor {
			get { return new AttachDescriptorToFactorOperation(vContext); }
		}

		/*--------------------------------------------------------------------------------------------*/
		public IAttachDirectorToFactorOperation AttachDirectorToFactor {
			get { return new AttachDirectorToFactorOperation(vContext); }
		}

		/*--------------------------------------------------------------------------------------------*/
		public IAttachEventorToFactorOperation AttachEventorToFactor {
			get { return new AttachEventorToFactorOperation(vContext); }
		}

		/*--------------------------------------------------------------------------------------------*/
		public IAttachIdentorToFactorOperation AttachIdentorToFactor {
			get { return new AttachIdentorToFactorOperation(vContext); }
		}

		/*--------------------------------------------------------------------------------------------*/
		public IAttachLocatorToFactorOperation AttachLocatorToFactor {
			get { return new AttachLocatorToFactorOperation(vContext); }
		}

		/*--------------------------------------------------------------------------------------------*/
		public IAttachVectorToFactorOperation AttachVectorToFactor {
			get { return new AttachVectorToFactorOperation(vContext); }
		}

		/*--------------------------------------------------------------------------------------------*/
		public ICompleteFactorOperation CompleteFactor {
			get { return new CompleteFactorOperation(vContext); }
		}

		/*--------------------------------------------------------------------------------------------*/
		public IDeleteFactorOperation DeleteFactor {
			get { return new DeleteFactorOperation(vContext); }
		}

	}


	/*================================================================================================*/
	/// <summary>
	///   TODO
	/// </summary>
	/// <remarks>
	///   <para>TODO</para>
	/// </remarks>
	public interface ISpecService : IService {

		/// <summary>
		///   The latest specification and documentation for all Fabric API services.
		/// </summary>
		IDocumentOperation Document { get; }

	}


	/*================================================================================================*/
	internal class SpecService : ISpecService {
	
		private readonly IClientContext vContext;

		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public SpecService(IClientContext pContext) {
			vContext = pContext;
		}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public IDocumentOperation Document {
			get { return new DocumentOperation(vContext); }
		}

	}


}