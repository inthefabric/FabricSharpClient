namespace Fabric.Clients.Cs.Api {

	/*================================================================================================*/
	/// <summary />
	public interface ITraversalStepAlias<out T> where T : ITraversalStep {

		/// <summary />
		string Alias { get; }

		/// <summary />
		T AsStep { get; }

	}
	
}