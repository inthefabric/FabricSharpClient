using System.Collections.Generic;

namespace Fabric.Clients.Cs.Infrastructure.SpecDto {

	/*================================================================================================*/
	public class FabSpecTravFunc {

		public string Name { get; set; }
		public string Description { get; set; }
		public string Uri { get; set; }
		public List<FabSpecTravFuncParam> Parameters { get; set; }

	}

}