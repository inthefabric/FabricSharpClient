namespace Fabric.Clients.Cs.Api {

	/*================================================================================================*/
	public partial interface ITraversalService {

		/// <summary>
		///   TODO
		/// </summary>
		IFabRootStep GetRootStep { get; }

	}


	/*================================================================================================*/
	internal partial class TraversalService {


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public IFabRootStep GetRootStep {
			get {
				var t = new Traversal(vContext, GetRootOperation.Uri);
				return t.RootStep();
			}
		}

	}

}
