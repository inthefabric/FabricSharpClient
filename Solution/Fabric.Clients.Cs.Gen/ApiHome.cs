namespace Fabric.Clients.Cs.Gen {

	/*================================================================================================*/
	public interface IFabric : IService {

		IServiceTraversal Traversal { get; }
		IServiceOauth Oauth { get; }
		IServiceModify Modify { get; }
		IServiceSpec Spec { get; }
	}

}