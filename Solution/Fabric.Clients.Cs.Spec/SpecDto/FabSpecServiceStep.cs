using System.Collections.Generic;

namespace Fabric.Clients.Cs.Spec.SpecDto {

	/*================================================================================================*/
	public class FabSpecServiceStep {

		public string Name { get; set; }
		public string Description { get; set; }
		public List<FabSpecServiceParam> Parameters { get; set; }
		public List<FabSpecServiceStepRule> Rules { get; set; }

	}

}