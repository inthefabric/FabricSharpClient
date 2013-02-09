using System.Collections.Generic;

namespace Fabric.Clients.Cs.Gen {
	
	/*================================================================================================*/
	public abstract class TraversalStep<T> : ITraversalStep<T> where T : FabObject {
		
		protected Traversal Trav { get; private set; }
		protected long? Id { get; private set; }
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		protected TraversalStep(Traversal pTrav) {
			Trav = pTrav;
		}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabResponse Response() {
			return Trav.Execute();
		}
		
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