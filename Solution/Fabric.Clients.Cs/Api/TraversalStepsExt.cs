namespace Fabric.Clients.Cs.Api {

	/*================================================================================================*/
	/// <summary />
	public static class TraversalSteps {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		public static T As<T>(this T pPrevStep, string pAlias, out ITraversalStepAlias<T> pStepAlias)
																				where T : IHasAsStep {
			pStepAlias = new TraversalStepAlias<T>(pAlias, pPrevStep);
			(pPrevStep as TraversalStep).TravPath.AppendToUri("/As("+pAlias+")");
			return pPrevStep;
		}

		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		public static TAlias Back<T, TAlias>(this T pPrevStep, ITraversalStepAlias<TAlias> pStepAlias)
												where T : IHasBackStep where TAlias : IHasAsStep {
			(pPrevStep as TraversalStep).TravPath.AppendToUri("/Back("+pStepAlias.Alias+")");
			return pStepAlias.AsStep;
		}
		
	}
	
}