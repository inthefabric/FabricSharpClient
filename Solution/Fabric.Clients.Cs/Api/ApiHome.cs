// GENERATED CODE
// Changes made to this source file will be overwritten

using Fabric.Clients.Cs.Session;

namespace Fabric.Clients.Cs.Api {

	/*================================================================================================*/
	/// <summary />
	public interface IFabricServices {
		
		/// <summary>
		///   The API version used to generate the Fabric client code.
		/// </summary>
		string ApiVersion { get; }

		/// <summary>
		///   Load information about the API and its services.
		/// </summary>
		IMetaService Meta { get; }

		/// <summary>
		///   Update the Fabric graph with new items and modifications.
		/// </summary>
		IModifyService Modify { get; }

		/// <summary>
		///   Authenticate Apps and/or Users using various flows based on the Oauth 2.0 specification.
		/// </summary>
		IOauthService Oauth { get; }

		/// <summary>
		///   Query the Fabric graph using predefined traversal steps and functions.
		/// </summary>
		ITraversalService Traversal { get; }

	}

	
	/*================================================================================================*/
	internal class FabricServices : IFabricServices {
		
		private readonly IClientContext vContext;

		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabricServices(IClientContext pContext) {
			vContext = pContext;
		}

		/*--------------------------------------------------------------------------------------------*/
		public string ApiVersion { get { return "0.3.0.3a1726f"; } }

		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public IMetaService Meta {
			get { return new MetaService(vContext); }
		}

		/*--------------------------------------------------------------------------------------------*/
		public IModifyService Modify {
			get { return new ModifyService(vContext); }
		}

		/*--------------------------------------------------------------------------------------------*/
		public IOauthService Oauth {
			get { return new OauthService(vContext); }
		}

		/*--------------------------------------------------------------------------------------------*/
		public ITraversalService Traversal {
			get { return new TraversalService(vContext); }
		}

	}

}