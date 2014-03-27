using Fabric.Clients.Cs.Session;
using Fabric.Clients.Cs.Web;

namespace Fabric.Clients.Cs.Api {
	
	/*================================================================================================*/
	/// <summary />
	internal class TraversalPath {

		private readonly IClientContext vContext;
		private string vUri;
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		internal TraversalPath(IClientContext pContext, string pBaseUri) {
			vContext = pContext;
			vUri = pBaseUri+"";
		}

		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		public string GetFullTraversalUri() {
			return vUri+"";
		}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		internal void AppendToUri(string pPartialUri) {
			vUri += pPartialUri;
		}
		
		/*--------------------------------------------------------------------------------------------*/
		internal FabResponse<T> Execute<T>(ITraversalStep<T> pStep, 
														SessionType pSessionType) where T : FabObject {
			return new FabricRequest<FabResponse<T>>("GET", vUri).Send(vContext, pSessionType);
		}
		
	}
	
}