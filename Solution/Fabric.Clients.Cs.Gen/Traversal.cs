using System.Collections.Generic;
using System;

namespace Fabric.Clients.Cs.Gen {
	
	/*================================================================================================*/
	public class Traversal {
		
		private IList<ITraversalStep> vSteps;
		private FabRootStep vRoot;
		private string vUri;
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public Traversal() {
			vSteps = new List<ITraversalStep>();
			vUri = "/Trav/Root";
			
			vRoot = new FabRootStep(this);
			AddStep(vRoot);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public FabRootStep RootStep() {
			return vRoot;
		}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		internal void AddStep(ITraversalStep pStep) {
			vSteps.Add(pStep);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		internal void AppendToUri(string pPartialUri) {
			vUri += pPartialUri;
			Console.WriteLine("Traversal URI: "+vUri);
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
		public static FabRootStep Root {
			get {
				var t = new Traversal();
				return t.RootStep();
			}
		}
		
	}
	
}