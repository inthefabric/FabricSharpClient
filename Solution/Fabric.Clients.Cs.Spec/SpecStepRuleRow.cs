using Fabric.Clients.Cs.Spec.SpecDto;

namespace Fabric.Clients.Cs.Spec {
	
	/*================================================================================================*/
	public class SpecStepRuleRow {

		public FabSpecService Service { get; internal set; }
		public FabSpecServiceStep Step { get; internal set; }
		public FabSpecServiceStepRule Rule { get; internal set; }


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public SpecStepRuleRow(FabSpecService pService, FabSpecServiceStep pStep,
																		FabSpecServiceStepRule pRule) {
			Service = pService;
			Step = pStep;
			Rule = pRule;
		}

	}
	
}