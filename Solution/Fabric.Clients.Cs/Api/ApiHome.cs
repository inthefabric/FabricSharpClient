// GENERATED CODE
// Changes made to this source file will be overwritten
// Generated on 2/14/2013 3:23:28 PM

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
	public class FabricServices : IFabricServices {

		public ITraversalService Traversal { get; private set; }
		public IOauthService Oauth { get; private set; }
		public IModifyService Modify { get; private set; }
		public ISpecService Spec { get; private set; }

		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabricServices() {
			Traversal = new TraversalService();
			Oauth = new OauthService();
			Modify = new ModifyService();
			Spec = new SpecService();
		}

	}

}