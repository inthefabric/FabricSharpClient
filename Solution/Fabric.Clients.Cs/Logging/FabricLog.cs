namespace Fabric.Clients.Cs.Logging {

	/*================================================================================================*/
	internal class FabricLog : IFabricLog {

		public const string Empty32 = "                                ";


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public void Info(string pSessionId, string pText) { Out("Info", pSessionId, pText); }

		/*--------------------------------------------------------------------------------------------*/
		public void Debug(string pSessionId, string pText) { Out("Debug", pSessionId, pText);}

		/*--------------------------------------------------------------------------------------------*/
		public void Error(string pSessionId, string pText) { Out("Error", pSessionId, pText);}

		/*--------------------------------------------------------------------------------------------*/
		public void Fatal(string pSessionId, string pText) { Out("Fatal", pSessionId, pText);}

		/*--------------------------------------------------------------------------------------------*/
		public void Warn(string pSessionId, string pText) { Out("Warn", pSessionId, pText); }


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public void Out(string pType, string pSessionId, string pText) {
			string psId = (pSessionId ?? Empty32);
			System.Diagnostics.Debug.WriteLine("Fabric | "+pType.PadRight(5)+" | "+psId+" | "+pText);
		}

	}

}