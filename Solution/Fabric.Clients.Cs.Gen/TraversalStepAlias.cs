namespace Fabric.Clients.Cs.Gen {
	
	/*================================================================================================*/
	public class TraversalStepAlias<T> : ITraversalStepAlias<T> where T : ITraversalStep {

		public string Alias { get; private set; }
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public TraversalStepAlias(string pAlias) {
			Alias = pAlias;
		}

	}
	
}