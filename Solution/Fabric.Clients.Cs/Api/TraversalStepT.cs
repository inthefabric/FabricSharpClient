using System;
using System.Collections.Generic;

namespace Fabric.Clients.Cs.Api {
	
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
		public Type GetReturnType() {
			return typeof(T);
		}
		
	}
	
}