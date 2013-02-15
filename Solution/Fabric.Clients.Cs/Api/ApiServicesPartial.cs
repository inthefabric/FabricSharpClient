namespace Fabric.Clients.Cs.Api {

	/*================================================================================================*/
	public partial interface ITraversalService {

		/// <summary>
		///   TODO
		/// </summary>
		IFabRootStep GetRootStep();

	}


	/*================================================================================================*/
	internal partial class TraversalService {


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public IFabRootStep GetRootStep() {
			var t = new Traversal(vContext, GetRootOperation.Uri);
			return t.RootStep();
		}

	}

}
