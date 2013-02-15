namespace Fabric.Clients.Cs.Api {

	/*================================================================================================*/
	/// <summary />
	public interface IOperation {

		/// <summary />
		string Method { get; }

		/// <summary />
		string RequiredAuth { get; }
		
	}
	
}