namespace Fabric.Clients.Cs.Api {

	/*================================================================================================*/
	/// <summary />
	public interface ITraversalStep {

		/// <summary />
		Traversal Trav { get; }

		/// <summary />
		IFabResponse Response();
		
	}
	
}