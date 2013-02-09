using System.Collections.Generic;

namespace Fabric.Clients.Cs.Gen {
	
	/*================================================================================================*/
	public class TraversalStep : ITraversalStep {
		
		protected Traversal TraversalRef { get; private set; }
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public void AddToTraversal(Traversal pTrav) {
			TraversalRef = pTrav;
			TraversalRef.AddStep(this);
		}
		
	}
	
}