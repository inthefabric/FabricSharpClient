namespace Fabric.Clients.Cs.Api {
	
	/*================================================================================================*/
	public interface ITraversalStep {

		Traversal Trav { get; }
		FabResponse Response();
		
	}
	
}