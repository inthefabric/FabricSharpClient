using System.Collections.Generic;
using System;

namespace Fabric.Clients.Cs.Gen {
	
	/*================================================================================================*/
	public abstract class TraversalStep : ITraversalStep {
	
		public Traversal Trav { get; private set; }
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		protected TraversalStep(Traversal pTrav) {
			Trav = pTrav;
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public FabResponse Response() {
			return Trav.Execute();
		}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public T Back<T>(T pStepAlias) where T : ITraversalStep {
			IList<ITraversalStep> steps = Trav.GetSteps();
			int count = steps.Count;
			int index = -1;
			
			for ( int i = count-1 ; i >= 0 ; --i ) {
				if ( steps[i] != (ITraversalStep)pStepAlias ) {
					continue;
				}
				
				index = i;
				break;
			}
			
			if ( index == -1 ) {
				throw new Exception("Alias not found: "+pStepAlias);
			}
			
			var funcs = new TraversalFuncs(Trav);
			funcs.Back(count-index);
			return pStepAlias;
		}
		
	}
	
	
	/*================================================================================================*/
	public static class TraversalStepExt {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public static T Alias<T>(this T pCurrentStep, out T pStepAlias) where T : ITraversalStep {
			return (pStepAlias = pCurrentStep);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public static T Limit<T>(this T pCurrentStep, int pIndex, int pCount) where T : TraversalStep {
			var funcs = new TraversalFuncs(pCurrentStep.Trav);
			funcs.Limit(pIndex, pCount);
			return pCurrentStep;
		}
		
	}
	
}