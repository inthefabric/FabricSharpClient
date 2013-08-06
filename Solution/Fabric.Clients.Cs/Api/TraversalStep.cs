namespace Fabric.Clients.Cs.Api {

	/*================================================================================================*/
	internal abstract class TraversalStep : ITraversalStep {

		public Traversal Trav { get; private set; }
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		protected TraversalStep(Traversal pTrav) {
			Trav = pTrav;
		}
		
	}
	
}