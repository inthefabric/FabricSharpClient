using System.Collections.Generic;

namespace Fabric.Clients.Cs.Gen {
	
	/*================================================================================================*/
	public class TraversalStep<T> : TraversalStep, ITraversalStep<T> where T : FabObject {
		
		protected long? Id { get; private set; }
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		protected TraversalStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public IList<T> Get() {
			var data = Response().Data;
			return null;
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public T Get(long pId) {
			Id = pId;
			Trav.AppendToUri("("+Id+")");
			
			FabResponse r = Response();
			return null; //(r.Count == 0 ? null : (T)r.Data[0]);
		}
		
	}
	
}