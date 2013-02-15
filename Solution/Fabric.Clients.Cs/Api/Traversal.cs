using System.Collections.Generic;
using Fabric.Clients.Cs.Session;
using Fabric.Clients.Cs.Web;

namespace Fabric.Clients.Cs.Api {
	
	/*================================================================================================*/
	/// <summary />
	public class Traversal {

		private readonly IClientContext vContext;
		private string vUri;
		private readonly IList<ITraversalStep> vSteps;
		private readonly FabRootStep vRoot;
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		internal Traversal(IClientContext pContext, string pBaseUri) {
			vContext = pContext;
			vUri = pBaseUri+"";
			vSteps = new List<ITraversalStep>();
			vRoot = new FabRootStep(this);

			AddStep(vRoot);
		}

		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		public string GetFullTraversalUri() {
			return vUri+"";
		}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		internal IFabRootStep RootStep() {
			return vRoot;
		}

		/*--------------------------------------------------------------------------------------------*/
		internal void AddStep(ITraversalStep pStep) {
			vSteps.Add(pStep);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		internal void AppendToUri(string pPartialUri) {
			vUri += pPartialUri;
		}
		
		/*--------------------------------------------------------------------------------------------*/
		internal IList<ITraversalStep> GetSteps() {
			return vSteps;
		}
		
		/*--------------------------------------------------------------------------------------------*/
		internal IFabResponse<T> Execute<T>(ITraversalStep<T> pStep) where T : IFabObject {
			return new FabricRequest<IFabResponse<T>, FabResponse<T>>("GET", vUri).Send(vContext);
		}
		
	}
	
}