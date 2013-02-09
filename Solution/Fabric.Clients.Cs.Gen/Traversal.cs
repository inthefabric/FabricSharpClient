using System.Collections.Generic;

namespace Fabric.Clients.Cs.Gen {
	
	/*================================================================================================*/
	public class Traversal {
		
		public IList<ITraversalStep> Steps { get; private set; }
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public Traversal() {
			Steps = new List<ITraversalStep>();
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public void AddStep(ITraversalStep pStep) {
			Steps.Add(pStep);
		}
		
	}
	
}