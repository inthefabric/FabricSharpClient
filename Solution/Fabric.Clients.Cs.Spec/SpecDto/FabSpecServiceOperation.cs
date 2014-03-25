using System.Collections.Generic;

namespace Fabric.Clients.Cs.Spec.SpecDto {

	/*================================================================================================*/
	public class FabSpecServiceOperation {

		public string Name { get; set; }
		public string Uri { get; set; }
		public string Method { get; set; }
		public string Return { get; set; }
		public string Description { get; set; }
		public string Auth { get; set; }
		public List<FabSpecServiceParam> Parameters { get; set; }

	}

}