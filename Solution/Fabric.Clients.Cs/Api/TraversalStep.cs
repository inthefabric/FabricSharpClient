namespace Fabric.Clients.Cs.Api {

	/*================================================================================================*/
	/// <summary />
	public abstract class TraversalStep : ITraversalStep {

		/// <summary />
		public Traversal Trav { get; private set; }
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		protected TraversalStep(Traversal pTrav) {
			Trav = pTrav;
		}

		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		public IFabResponse Response() {
			return Trav.Execute();
		}
		
	}


	/*================================================================================================*/
	/// <summary />
	public static class TraversalStepExt {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		public static T As<T>(this T pCurrStep, string pAlias, out ITraversalStepAlias<T> pStepAlias)
																			where T : IFuncAs {
			pStepAlias = new TraversalStepAlias<T>(pAlias, pCurrStep);
			var funcs = new TraversalFuncs(pCurrStep.Trav);
			funcs.As(pAlias);
			return pCurrStep;
		}

		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		public static TAlias Back<T,TAlias>(this T pCurrStep, ITraversalStepAlias<TAlias> pStepAlias)
													where T : ITraversalStep where TAlias : IFuncBack {
			var funcs = new TraversalFuncs(pCurrStep.Trav);
			funcs.Back(pStepAlias.Alias);
			return pStepAlias.AsStep;
		}


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		public static T Limit<T>(this T pCurrentStep, int pIndex, int pCount) where T : IFuncLimit {
			var funcs = new TraversalFuncs(pCurrentStep.Trav);
			funcs.Limit(pIndex, pCount);
			return pCurrentStep;
		}

		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		public static T WhereId<T>(this T pCurrentStep, long pId) where T : IFuncWhereId {
			var funcs = new TraversalFuncs(pCurrentStep.Trav);
			funcs.WhereId(pId);
			return pCurrentStep;
		}
		
	}
	
}