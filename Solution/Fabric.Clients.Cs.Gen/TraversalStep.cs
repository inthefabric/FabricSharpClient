
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
		
	}
	
	
	/*================================================================================================*/
	public static class TraversalStepExt {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public static T As<T>(this T pCurrStep, string pAlias, out ITraversalStepAlias<T> pStepAlias)
																			where T : IFuncAs {
			pStepAlias = new TraversalStepAlias<T>(pAlias, pCurrStep);
			var funcs = new TraversalFuncs(pCurrStep.Trav);
			funcs.As(pAlias);
			return pCurrStep;
		}

		/*--------------------------------------------------------------------------------------------*/
		public static TAlias Back<T,TAlias>(this T pCurrStep, ITraversalStepAlias<TAlias> pStepAlias)
													where T : ITraversalStep where TAlias : IFuncBack {
			var funcs = new TraversalFuncs(pCurrStep.Trav);
			funcs.Back(pStepAlias.Alias);
			return pStepAlias.AsStep;
		}


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public static T Limit<T>(this T pCurrentStep, int pIndex, int pCount) where T : IFuncLimit {
			var funcs = new TraversalFuncs(pCurrentStep.Trav);
			funcs.Limit(pIndex, pCount);
			return pCurrentStep;
		}

		/*--------------------------------------------------------------------------------------------*/
		public static T WhereId<T>(this T pCurrentStep, long pId) where T : IFuncWhereId {
			var funcs = new TraversalFuncs(pCurrentStep.Trav);
			funcs.WhereId(pId);
			return pCurrentStep;
		}
		
	}
	
}