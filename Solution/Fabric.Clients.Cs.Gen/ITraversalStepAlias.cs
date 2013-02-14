using System;

namespace Fabric.Clients.Cs.Gen {
	
	/*================================================================================================*/
	public interface ITraversalStepAlias<T> where T : ITraversalStep {

		String Alias { get; }

	}
	
}