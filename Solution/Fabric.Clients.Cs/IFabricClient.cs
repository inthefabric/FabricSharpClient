﻿using Fabric.Clients.Cs.Api;
using Fabric.Clients.Cs.Session;

namespace Fabric.Clients.Cs {
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabricClient : IHideSystemIntellisense {

		/// <summary />
		IFabricClientConfig Config { get; }

		/// <summary />
		IFabricPersonSession PersonSession { get; }

		/// <summary />
		IFabricAppSession AppSession { get; }

		/// <summary />
		IFabricOauthSession ActiveSession { get; }

		/// <summary />
		IFabricServices Services { get; }

		/// <summary />
		bool UseAppDataProvider { get; set; }

	}

}
