namespace Fabric.Clients.Cs.Gen {

	/*================================================================================================*/
	public interface IFabric : IService {

		///<summary>
		///  TODO
		///</summary>
		ITraversalService Traversal { get; }

		///<summary>
		///  TODO
		///</summary>
		IOauthService Oauth { get; }

		///<summary>
		///  TODO
		///</summary>
		IModifyService Modify { get; }

		///<summary>
		///  TODO
		///</summary>
		ISpecService Spec { get; }

	}

}