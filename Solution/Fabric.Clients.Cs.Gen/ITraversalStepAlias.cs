namespace Fabric.Clients.Cs.Gen {
	
	/*================================================================================================*/
	public interface ITraversalStepAlias<T> where T : ITraversalStep {

		string Alias { get; }
		T AsStep { get; }

	}
	
}