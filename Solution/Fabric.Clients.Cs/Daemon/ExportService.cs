using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;

namespace Fabric.Clients.Cs.Daemon {

	/*================================================================================================*/
	/// <summary />
	public class ExportService : IExportService {

		private readonly IExportServiceDelegate vDelegate;
		private readonly ConcurrentDictionary<string, IFabricClient> vActiveUserClientMap;

		private IFabricClient vDataProvClient;


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		public ExportService(IExportServiceDelegate pDelegate) {
			vDelegate = pDelegate;
			vActiveUserClientMap = new ConcurrentDictionary<string, IFabricClient>();
		}


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		public bool StartDataProvExport() {
			if ( vDataProvClient != null ) {
				return false;
			}

			vDataProvClient = vDelegate.GetDataProvClient();

			var t = new Thread(esdObj => {
				try {
					var efc = vDelegate.GetExportForClient((IExportForClientDelegate)esdObj);
					efc.StartExport();
				}
				catch ( Exception e ) {
					LogError(vDataProvClient, e);
				}
			});

			t.Start(vDelegate.GetExportForClientDelegate(vDataProvClient));
			return true;
		}

		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		public int StartNewUserExports() {
			IList<IFabricClient> userClients = vDelegate.GetUserClients();
			int n = 0;

			foreach ( IFabricClient userClient in userClients ) {
				if ( userClient.PersonSession.Expiration <= DateTime.UtcNow ) {
					vDelegate.HandleExpiredUserClient(userClient);
					continue;
				}

				if ( StartUserExport(userClient) ) {
					n++;
				}
			}

			return n;
		}


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		private bool StartUserExport(IFabricClient pUserClient) {
			if ( IsUserClientActive(pUserClient) ) {
				return false;
			}

			AddActiveUserClient(pUserClient);

			var t = new Thread(esdObj => {
				try {
					var efc = vDelegate.GetExportForClient((IExportForClientDelegate)esdObj);
					efc.StartExport();
					RemoveActiveUserClient(efc.Client);
				}
				catch ( Exception e ) {
					LogError(pUserClient, e);
				}
			});

			t.Start(vDelegate.GetExportForClientDelegate(pUserClient));
			return true;
		}


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		private static string GetMapKey(IFabricClient pUserClient) {
			return pUserClient.PersonSession.SessionId;
		}
		
		/*--------------------------------------------------------------------------------------------*/
		private void AddActiveUserClient(IFabricClient pUserClient) {
			vActiveUserClientMap.GetOrAdd(GetMapKey(pUserClient), pUserClient);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		private bool IsUserClientActive(IFabricClient pUserClient) {
			return vActiveUserClientMap.ContainsKey(GetMapKey(pUserClient));
		}

		/*--------------------------------------------------------------------------------------------*/
		private void RemoveActiveUserClient(IFabricClient pUserClient) {
			IFabricClient rem;
			vActiveUserClientMap.TryRemove(GetMapKey(pUserClient), out rem);
		}

		/*--------------------------------------------------------------------------------------------*/
		private static void LogError(IFabricClient pClient, Exception pEx) {
			string msg = pEx.Message+"\n"+pEx.StackTrace;

			if ( pClient == null || pClient.Config == null || pClient.Config.Logger == null ) {
				Console.WriteLine("Fabric ExportService Error: "+msg);
				return;
			}

			string sessId = (pClient.PersonSession == null ? null : pClient.PersonSession.SessionId);
			pClient.Config.Logger.Error(sessId, msg);
		}

	}

}