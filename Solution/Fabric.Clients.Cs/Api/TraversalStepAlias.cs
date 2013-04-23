namespace Fabric.Clients.Cs.Api {

	/*================================================================================================*/
	internal class TraversalStepAlias<T> : ITraversalStepAlias<T> where T : ITraversalStep {

		public string Alias { get; private set; }
		public T AsStep { get; private set; }
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public TraversalStepAlias(string pAlias, T pAsStep) {
			Alias = pAlias;
			AsStep = pAsStep;
		}

	}
	
}