namespace Fabric.Clients.Cs.Api {

	/*================================================================================================*/
	/// <summary />
	public static partial class TraversalFuncs {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		public static T As<T>(this T pPrevStep, string pAlias, out ITraversalStepAlias<T> pStepAlias)
																				where T : IHasFuncAs {
			pStepAlias = new TraversalStepAlias<T>(pAlias, pPrevStep);
			pPrevStep.As(pAlias);
			return pPrevStep;
		}

		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		public static TAlias Back<T, TAlias>(this T pPrevStep, ITraversalStepAlias<TAlias> pStepAlias)
												where T : IHasFuncBack where TAlias : IHasFuncAs {
			pPrevStep.Back(pStepAlias.Alias);
			return pStepAlias.AsStep;
		}
		
	}
	
}