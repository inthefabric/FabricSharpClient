// GENERATED CODE
// Changes made to this source file will be overwritten

using Fabric.Clients.Cs.Session;

namespace Fabric.Clients.Cs.Api {

	/*================================================================================================*/
	/// <summary>
	///   Load information about the API and its services.
	/// </summary>
	/// <remarks>
	///   <para>Load information about the API and its services.</para>
	/// </remarks>
	public interface IMetaService : IService {

		/// <summary>
		///   Get the latest specifications and documentation for all Fabric API services.
		/// </summary>
		IMetaSpecGetOperation Spec { get; }

		/// <summary>
		///   Get the current Fabric version.
		/// </summary>
		IMetaVersionGetOperation Version { get; }

		/// <summary>
		///   Get the current Fabric server time.
		/// </summary>
		IMetaTimeGetOperation Time { get; }

	}


	/*================================================================================================*/
	internal class MetaService : IMetaService {
	
		private readonly IClientContext vContext;

		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public MetaService(IClientContext pContext) {
			vContext = pContext;
		}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public IMetaSpecGetOperation Spec {
			get {
				return new MetaSpecGetOperation(vContext);
			}
		}

		/*--------------------------------------------------------------------------------------------*/
		public IMetaVersionGetOperation Version {
			get {
				return new MetaVersionGetOperation(vContext);
			}
		}

		/*--------------------------------------------------------------------------------------------*/
		public IMetaTimeGetOperation Time {
			get {
				return new MetaTimeGetOperation(vContext);
			}
		}

	}


	/*================================================================================================*/
	/// <summary>
	///   Update the Fabric graph with new items and modifications.
	/// </summary>
	/// <remarks>
	///   <para>Update the Fabric graph with new items and modifications.</para>
	/// </remarks>
	public interface IModifyService : IService {

		/// <summary>
		///   Create a new Class.
		/// </summary>
		IModifyClassesPostOperation Classes { get; }

		/// <summary>
		///   Create a new Factor.
		/// </summary>
		IModifyFactorsPostOperation Factors { get; }

		/// <summary>
		///   Create a new Instance.
		/// </summary>
		IModifyInstancesPostOperation Instances { get; }

		/// <summary>
		///   Create a new Member.
		/// </summary>
		IModifyMembersPostOperation Members { get; }

		/// <summary>
		///   Create a new Url.
		/// </summary>
		IModifyUrlsPostOperation Urls { get; }

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
		public IModifyClassesPostOperation Classes {
			get {
				return new ModifyClassesPostOperation(vContext);
			}
		}

		/*--------------------------------------------------------------------------------------------*/
		public IModifyFactorsPostOperation Factors {
			get {
				return new ModifyFactorsPostOperation(vContext);
			}
		}

		/*--------------------------------------------------------------------------------------------*/
		public IModifyInstancesPostOperation Instances {
			get {
				return new ModifyInstancesPostOperation(vContext);
			}
		}

		/*--------------------------------------------------------------------------------------------*/
		public IModifyMembersPostOperation Members {
			get {
				return new ModifyMembersPostOperation(vContext);
			}
		}

		/*--------------------------------------------------------------------------------------------*/
		public IModifyUrlsPostOperation Urls {
			get {
				return new ModifyUrlsPostOperation(vContext);
			}
		}

	}


	/*================================================================================================*/
	/// <summary>
	///   Authenticate Apps and/or Users using various flows based on the Oauth 2.0 specification.
	/// </summary>
	/// <remarks>
	///   <para>Authenticate Apps and/or Users using various flows based on the Oauth 2.0 specification.</para>
	/// </remarks>
	public interface IOauthService : IService {

		/// <summary>
		///   Get an OAuth access token using one of four 'flows'.
		/// </summary>
		IOauthAccessTokenGetOperation AccessToken { get; }

		/// <summary>
		///   This OAuth flow should be used immediately after obtaining an authorization code from the OAuth entry process.
		/// </summary>
		IOauthAccessTokenAuthCodeGetOperation AccessTokenAuthCode { get; }

		/// <summary>
		///   This OAuth flow should be used to refresh an expired access token.
		/// </summary>
		IOauthAccessTokenRefreshGetOperation AccessTokenRefresh { get; }

		/// <summary>
		///   This OAuth flow should be used to begin an OAuth session for your Fabric App.
		/// </summary>
		IOauthAccessTokenClientCredentialsGetOperation AccessTokenClientCredentials { get; }

		/// <summary>
		///   This API request is unique -- it represents the entry point for Fabric's 'sOAuth 2.0 authentication process.
		/// </summary>
		IOauthLoginGetOperation Login { get; }

		/// <summary>
		///   Terminates a particular OAuth session by invalidating the session's 'saccess token.
		/// </summary>
		IOauthLogoutGetOperation Logout { get; }

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
		public IOauthAccessTokenGetOperation AccessToken {
			get {
				return new OauthAccessTokenGetOperation(vContext);
			}
		}

		/*--------------------------------------------------------------------------------------------*/
		public IOauthAccessTokenAuthCodeGetOperation AccessTokenAuthCode {
			get {
				return new OauthAccessTokenAuthCodeGetOperation(vContext);
			}
		}

		/*--------------------------------------------------------------------------------------------*/
		public IOauthAccessTokenRefreshGetOperation AccessTokenRefresh {
			get {
				return new OauthAccessTokenRefreshGetOperation(vContext);
			}
		}

		/*--------------------------------------------------------------------------------------------*/
		public IOauthAccessTokenClientCredentialsGetOperation AccessTokenClientCredentials {
			get {
				return new OauthAccessTokenClientCredentialsGetOperation(vContext);
			}
		}

		/*--------------------------------------------------------------------------------------------*/
		public IOauthLoginGetOperation Login {
			get {
				return new OauthLoginGetOperation(vContext);
			}
		}

		/*--------------------------------------------------------------------------------------------*/
		public IOauthLogoutGetOperation Logout {
			get {
				return new OauthLogoutGetOperation(vContext);
			}
		}

	}


	/*================================================================================================*/
	/// <summary>
	///   Query the Fabric graph using predefined traversal steps and functions.
	/// </summary>
	/// <remarks>
	///   <para>Query the Fabric graph using predefined traversal steps and functions.</para>
	/// </remarks>
	public interface ITraversalService : IService {

		/// <summary>
		///   Begins a traversal with an App entry point.
		/// </summary>
		IFabTravAppRootStep Apps { get; }

		/// <summary>
		///   Begins a traversal with an Artifact entry point.
		/// </summary>
		IFabTravArtifactRootStep Artifacts { get; }

		/// <summary>
		///   Begins a traversal with an Class entry point.
		/// </summary>
		IFabTravClassRootStep Classes { get; }

		/// <summary>
		///   Begins a traversal with an Factor entry point.
		/// </summary>
		IFabTravFactorRootStep Factors { get; }

		/// <summary>
		///   Begins a traversal with an Instance entry point.
		/// </summary>
		IFabTravInstanceRootStep Instances { get; }

		/// <summary>
		///   Begins a traversal with an Member entry point.
		/// </summary>
		IFabTravMemberRootStep Members { get; }

		/// <summary>
		///   Begins a traversal with an Url entry point.
		/// </summary>
		IFabTravUrlRootStep Urls { get; }

		/// <summary>
		///   Begins a traversal with an User entry point.
		/// </summary>
		IFabTravUserRootStep Users { get; }

		/// <summary>
		///   Begins a traversal with an Vertex entry point.
		/// </summary>
		IFabTravVertexRootStep Vertices { get; }

	}


	/*================================================================================================*/
	internal class TraversalService : ITraversalService {
	
		private readonly IClientContext vContext;

		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public TraversalService(IClientContext pContext) {
			vContext = pContext;
		}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public IFabTravAppRootStep Apps {
			get {
				var path = new TraversalPath(vContext, "/Trav/Apps");
				return new FabTravAppRootStep(path);
			}
		}

		/*--------------------------------------------------------------------------------------------*/
		public IFabTravArtifactRootStep Artifacts {
			get {
				var path = new TraversalPath(vContext, "/Trav/Artifacts");
				return new FabTravArtifactRootStep(path);
			}
		}

		/*--------------------------------------------------------------------------------------------*/
		public IFabTravClassRootStep Classes {
			get {
				var path = new TraversalPath(vContext, "/Trav/Classes");
				return new FabTravClassRootStep(path);
			}
		}

		/*--------------------------------------------------------------------------------------------*/
		public IFabTravFactorRootStep Factors {
			get {
				var path = new TraversalPath(vContext, "/Trav/Factors");
				return new FabTravFactorRootStep(path);
			}
		}

		/*--------------------------------------------------------------------------------------------*/
		public IFabTravInstanceRootStep Instances {
			get {
				var path = new TraversalPath(vContext, "/Trav/Instances");
				return new FabTravInstanceRootStep(path);
			}
		}

		/*--------------------------------------------------------------------------------------------*/
		public IFabTravMemberRootStep Members {
			get {
				var path = new TraversalPath(vContext, "/Trav/Members");
				return new FabTravMemberRootStep(path);
			}
		}

		/*--------------------------------------------------------------------------------------------*/
		public IFabTravUrlRootStep Urls {
			get {
				var path = new TraversalPath(vContext, "/Trav/Urls");
				return new FabTravUrlRootStep(path);
			}
		}

		/*--------------------------------------------------------------------------------------------*/
		public IFabTravUserRootStep Users {
			get {
				var path = new TraversalPath(vContext, "/Trav/Users");
				return new FabTravUserRootStep(path);
			}
		}

		/*--------------------------------------------------------------------------------------------*/
		public IFabTravVertexRootStep Vertices {
			get {
				var path = new TraversalPath(vContext, "/Trav/Vertices");
				return new FabTravVertexRootStep(path);
			}
		}

	}


}