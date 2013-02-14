using System.Collections.Generic;

namespace Fabric.Clients.Cs.Gen {
	
	/*================================================================================================*/
	public interface ITraversalStep {

		Traversal Trav { get; }
		FabResponse Response();
		
	}
	
}