using System.Collections.Generic;

namespace Fabric.Clients.Cs.Spec.SpecDto {

	/*================================================================================================*/
	public class FabSpecObject {

		public string Name { get; set; }
		public string Extends { get; set; }
		public string Description { get; set; }
		public List<FabSpecObjectProp> Properties { get; set; }

	}

}