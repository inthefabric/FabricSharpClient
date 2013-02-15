using System.Collections.Generic;

namespace Fabric.Clients.Cs.Api {
	
	/*================================================================================================*/
	/// <summary />
	public class Traversal {
		
		private readonly IList<ITraversalStep> vSteps;
		private readonly FabRootStep vRoot;
		private string vUri;
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		public Traversal() {
			vSteps = new List<ITraversalStep>();
			vUri = "/Trav/Root";
			
			vRoot = new FabRootStep(this);
			AddStep(vRoot);
		}

		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		public IFabRootStep RootStep() {
			return vRoot;
		}

		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		public string GetTraversalUri() {
			return vUri+"";
		}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
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
		internal FabResponse Execute() {
			return null;
		}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		public static IFabRootStep Root {
			get {
				var t = new Traversal();
				return t.RootStep();
			}
		}
		
	}
	
}