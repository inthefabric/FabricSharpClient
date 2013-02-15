using System.Collections.Generic;

namespace Fabric.Clients.Cs.Api {

	/*================================================================================================*/
	internal class FabResponse<T> : FabResponse, IFabResponse<T> where T : IFabObject {

		public new IList<T> Data { get; set; }
		
	}
	
}