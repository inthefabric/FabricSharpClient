using System;

namespace Fabric.Clients.Cs.Api {

	/*================================================================================================*/
	internal class TraversalStep<T> : TraversalStep, ITraversalStep<T> where T : FabObject {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		protected TraversalStep(Traversal pTrav) : base(pTrav) {}

		/*--------------------------------------------------------------------------------------------*/
		public Type GetDataType() {
			return typeof(T);
		}

		/*--------------------------------------------------------------------------------------------*/
		public FabResponse<T> Get() {
			return Trav.Execute(this);
		}
		
	}
	
}