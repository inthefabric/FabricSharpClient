namespace Fabric.Clients.Cs.Api {
	
	/*================================================================================================*/
	public interface ITraversalStepAlias<T> where T : ITraversalStep {

		string Alias { get; }
		T AsStep { get; }

	}
	
}