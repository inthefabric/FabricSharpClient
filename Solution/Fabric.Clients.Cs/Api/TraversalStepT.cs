using System;
using System.Collections.Generic;

namespace Fabric.Clients.Cs.Api {

	/*================================================================================================*/
	/// <summary />
	public class TraversalStep<T> : TraversalStep, ITraversalStep<T> where T : IFabObject {
		
		//protected long? Id { get; private set; }
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		protected TraversalStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		public IList<T> Get() {
			var data = Response().Data;
			return null;
		}

		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		public Type GetReturnType() {
			return typeof(T);
		}
		
	}
	
}