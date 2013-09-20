using Fabric.Clients.Cs.Logging;
using Fabric.Clients.Cs.Session;

namespace Fabric.Clients.Cs {
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabricClientConfig {

		/// <summary />
		string ConfigKey { get; }

		/// <summary />
		string ApiPath { get; }

		/// <summary />
		long AppId { get; }

		/// <summary />
		string AppSecret { get; }

		/// <summary />
		long AppDataProvPersonId { get; }

		/// <summary />
		string AppOAuthRedirectUri { get; }

		/// <summary />
		IFabricLog Logger { get; set; }


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		IFabricSessionContainer GetSessionContainer();

	}

}
