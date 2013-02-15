using System.Collections.Generic;

namespace Fabric.Clients.Cs.Api {

	/*================================================================================================*/
	/// <summary />
	public interface IFabResponse<T> : IFabResponse where T : IFabObject {

		/// <summary />
		new IList<T> Data { get; set; }
		
	}
	
}