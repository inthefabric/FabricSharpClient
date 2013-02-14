// GENERATED CODE
// Changes made to this source file will be overwritten
// Generated on 2/14/2013 4:15:02 PM

using Fabric.Clients.Cs.Session;

namespace Fabric.Clients.Cs.Api {

	/*================================================================================================*/
	public interface IFabricServices {

		///<summary>
		///  TODO
		///</summary>
		ITraversalService Traversal { get; }

		///<summary>
		///  TODO
		///</summary>
		IOauthService Oauth { get; }

		///<summary>
		///  TODO
		///</summary>
		IModifyService Modify { get; }

		///<summary>
		///  TODO
		///</summary>
		ISpecService Spec { get; }

	}

	
	/*================================================================================================*/
	internal class FabricServices : IFabricServices {
		
		private readonly IClientContext vContext;

		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabricServices(IClientContext pContext) {
			vContext = pContext;
		}

		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public ITraversalService Traversal {
			get { return new TraversalService(vContext); }
		}

		/*--------------------------------------------------------------------------------------------*/
		public IOauthService Oauth {
			get { return new OauthService(vContext); }
		}

		/*--------------------------------------------------------------------------------------------*/
		public IModifyService Modify {
			get { return new ModifyService(vContext); }
		}

		/*--------------------------------------------------------------------------------------------*/
		public ISpecService Spec {
			get { return new SpecService(vContext); }
		}

	}

}