using System.Collections.Generic;

namespace Fabric.Clients.Cs.Spec.SpecDto {

	/*================================================================================================*/
	public class FabSpec {

		public string BuildVersion { get; set; }
		public int BuildYear { get; set; }
		public int BuildMonth { get; set; }
		public int BuildDay { get; set; }
		public List<FabSpecObject> Objects { get; set; }
		public List<FabSpecService> Services { get; set; }
		public List<FabSpecEnum> Enums { get; set; }

	}

}