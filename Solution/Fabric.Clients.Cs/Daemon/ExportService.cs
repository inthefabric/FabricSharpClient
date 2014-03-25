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
		private readonly IFabricClient vDataProvClient;


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		public ExportService(IExportServiceDelegate pDelegate) {
			vDelegate = pDelegate;
			vActiveUserClientMap = new ConcurrentDictionary<string, IFabricClient>();
			vDataProvClient = vDelegate.GetDataProvClient();
		}


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		public int StartNewExports() {
			IList<IFabricClient> userClients = vDelegate.GetUserClients();
			int n = 0;

			n += StartExport(vDataProvClient);

			foreach ( IFabricClient uc in userClients ) {
				n += StartExport(uc);
			}

			return n;
		}

		/*--------------------------------------------------------------------------------------------*/
		private int StartExport(IFabricClient pClient) {
			if ( !pClient.UseAppDataProvider && pClient.ActiveSession.Expiration <= DateTime.UtcNow ) {
				vDelegate.HandleExpiredUserClient(pClient);
				return 0;
			}

			if ( IsUserClientActive(pClient) ) {
				return 0;
			}

			AddActiveUserClient(pClient);

			var t = new Thread(esdObj => {
				try {
					var efc = vDelegate.GetExportForClient((IExportForClientDelegate)esdObj);
					efc.StartExport();
					RemoveActiveUserClient(efc.Client);
				}
				catch ( Exception e ) {
					LogError(pClient, e);
				}
			});

			t.Start(vDelegate.GetExportForClientDelegate(pClient));
			return 1;
		}


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		private static string GetMapKey(IFabricClient pClient) {
			return pClient.ActiveSession.SessionId;
		}
		
		/*--------------------------------------------------------------------------------------------*/
		private void AddActiveUserClient(IFabricClient pClient) {
			vActiveUserClientMap.GetOrAdd(GetMapKey(pClient), pClient);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		private bool IsUserClientActive(IFabricClient pClient) {
			return vActiveUserClientMap.ContainsKey(GetMapKey(pClient));
		}

		/*--------------------------------------------------------------------------------------------*/
		private void RemoveActiveUserClient(IFabricClient pClient) {
			IFabricClient rem;
			vActiveUserClientMap.TryRemove(GetMapKey(pClient), out rem);
		}


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		private static void LogError(IFabricClient pClient, Exception pEx) {
			string msg = pEx.Message+"\n"+pEx.StackTrace;

			if ( pClient == null || pClient.Config == null || pClient.Config.Logger == null ) {
				Console.WriteLine("Fabric ExportService Error: "+msg);
				return;
			}

			string sessId = (pClient.ActiveSession == null ? null : pClient.ActiveSession.SessionId);
			pClient.Config.Logger.Error(sessId, msg);
		}

	}

}