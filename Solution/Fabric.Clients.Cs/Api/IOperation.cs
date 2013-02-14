namespace Fabric.Clients.Cs.Api {
	
	/*================================================================================================*/
	public interface IOperation {

		string Method { get; }
		string RequiredAuth { get; }
		
	}
	
}