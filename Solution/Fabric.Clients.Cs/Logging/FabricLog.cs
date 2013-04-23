using Fabric.Clients.Cs.Session;

namespace Fabric.Clients.Cs.Logging {

	/*================================================================================================*/
	internal class FabricLog : IFabricLog {

		public const string Empty32 = "                                ";


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public void Info(IFabricClientConfig pConfig, string pText) { Out("Info", pConfig, pText); }

		/*--------------------------------------------------------------------------------------------*/
		public void Debug(IFabricClientConfig pConfig, string pText) { Out("Debug", pConfig, pText); }

		/*--------------------------------------------------------------------------------------------*/
		public void Error(IFabricClientConfig pConfig, string pText) { Out("Error", pConfig, pText); }

		/*--------------------------------------------------------------------------------------------*/
		public void Fatal(IFabricClientConfig pConfig, string pText) { Out("Fatal", pConfig, pText); }

		/*--------------------------------------------------------------------------------------------*/
		public void Warn(IFabricClientConfig pConfig, string pText) { Out("Warn", pConfig, pText); }


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public void Out(string pType, IFabricClientConfig pConfig, string pText) {
			IFabricSessionContainer sc = pConfig.GetSessionContainer();
			IFabricPersonSession p = (sc != null ? sc.Person : null);
			string psId = (p == null ? Empty32 : p.SessionId);
			System.Diagnostics.Debug.WriteLine("Fabric | "+pType.PadRight(5)+" | "+psId+" | "+pText);
		}

	}

}