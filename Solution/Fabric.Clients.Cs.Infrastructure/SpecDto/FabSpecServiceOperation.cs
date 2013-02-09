using System.Collections.Generic;

namespace Fabric.Clients.Cs.Infrastructure.SpecDto {

	/*================================================================================================*/
	public class FabSpecServiceOperation {

		public string Name { get; set; }
		public string Uri { get; set; }
		public string Method { get; set; }
		public string ReturnType { get; set; }
		public string Description { get; set; }

		public string RequiredAuth { get; set; }
		public string AuthMemberOwns { get; set; }
		public List<FabSpecServiceOperationParam> Parameters { get; set; }

	}

}