using System;
using System.Collections.Generic;

namespace Fabric.Clients.Cs.Api {
	
	/*================================================================================================*/
	public interface ITraversalStep<T> : ITraversalStep where T : FabObject {


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		IList<T> Get();
		Type GetReturnType();
		
	}
	
}