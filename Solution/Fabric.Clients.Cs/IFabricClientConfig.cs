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
		int AppId { get; }

		/// <summary />
		string AppSecret { get; }

		/// <summary />
		int AppDataProvPersonId { get; }

		/// <summary />
		string AppOAuthRedirectUri { get; }

		/// <summary />
		IFabricLog Logger { get; set; }


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		IFabricSessionContainer GetSessionContainer();


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		void LogInfo(string text);

		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		void LogDebug(string text);

		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		void LogError(string text);

		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		void LogFatal(string text);

		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		void LogWarn(string text);

	}

}
