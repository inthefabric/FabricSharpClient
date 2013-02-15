namespace Fabric.Clients.Cs.Api {

	/*================================================================================================*/
	/// <summary />
	public class TraversalStepAlias<T> : ITraversalStepAlias<T> where T : ITraversalStep {

		/// <summary />
		public string Alias { get; private set; }

		/// <summary />
		public T AsStep { get; private set; }
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		public TraversalStepAlias(string pAlias, T pAsStep) {
			Alias = pAlias;
			AsStep = pAsStep;
		}

	}
	
}