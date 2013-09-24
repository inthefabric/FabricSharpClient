﻿namespace Fabric.Clients.Cs.Logging {

	/*================================================================================================*/
	/// <summary />
	public interface IFabricLog {


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		void Info(string sessionId, string text);

		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		void Debug(string sessionId, string text);

		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		void Error(string sessionId, string text);

		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		void Fatal(string sessionId, string text);

		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		void Warn(string sessionId, string text);

	}

}