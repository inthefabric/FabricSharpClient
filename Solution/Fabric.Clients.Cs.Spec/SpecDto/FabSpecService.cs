using System.Collections.Generic;

namespace Fabric.Clients.Cs.Spec.SpecDto {

	/*================================================================================================*/
	public class FabSpecService {
		
		public string Name { get; set; }
		public string Uri { get; set; }
		public string Summary { get; set; }
		public string Description { get; set; }
		public List<FabSpecServiceOperation> Operations { get; set; }
		public List<FabSpecServiceStep> Steps { get; set; }

	}

}