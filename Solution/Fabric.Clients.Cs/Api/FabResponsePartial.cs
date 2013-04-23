using System.Collections.Generic;

namespace Fabric.Clients.Cs.Api {

	/*================================================================================================*/
	/// <summary />
	public partial class FabResponse {

	}


	/*================================================================================================*/
	/// <summary />
	public class FabResponse<T> : FabResponse {

		/// <summary />
		public IList<T> Data { get; set; }


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		public T FirstDataItem() {
			if ( Data == null || Data.Count == 0 ) {
				return default(T);
			}

			return Data[0];
		}
		
	}
	
}