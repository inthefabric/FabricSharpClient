using System.Collections.Generic;

namespace Fabric.Clients.Cs.Spec.SpecDto {

	/*================================================================================================*/
	public class FabSpecTravFunc {

		public string Name { get; set; }
		public string Description { get; set; }
		public string Uri { get; set; }
		public bool ReturnsPreviousType { get; set; }
		public bool ReturnsAliasType { get; set; }
		public string ReturnsObjectType { get; set; }
		public List<FabSpecTravFuncParam> Parameters { get; set; }

	}

}