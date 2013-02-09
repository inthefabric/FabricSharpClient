﻿using System.Collections.Generic;

namespace Fabric.Clients.Cs.Infrastructure.SpecDto {

	/*================================================================================================*/
	public class FabSpec {
		
		public string ApiVersion { get; set; }
		public List<FabSpecObject> Objects { get; set; }
		public List<FabSpecService> Services { get; set; }

	}

}