using System.Collections.Generic;

namespace Fabric.Clients.Cs.Gen {
	
	/*================================================================================================*/
	public interface ITraversalStep {
	
		FabResponse Response();
		
	}
	
	
	/*================================================================================================*/
	public interface ITraversalStep<T> : ITraversalStep where T : FabObject {
		
		IList<T> Get();
		T Get(long pId);
		
	}
	
}