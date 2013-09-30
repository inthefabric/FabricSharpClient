using System.Collections.Generic;
using Fabric.Clients.Cs.Api;
using Fabric.Clients.Cs.Daemon.Data;
using ServiceStack.Text;

namespace Fabric.Clients.Cs.Daemon {

	/*================================================================================================*/
	/// <summary />
	public class ExportForClient : IExportForClient {

		/// <summary />
		public IFabricClient Client { get; private set; }

		private readonly IExportForClientDelegate vDelegate;


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		public ExportForClient(IExportForClientDelegate pDelegate) {
			vDelegate = pDelegate;
			Client = vDelegate.GetClient();

		}

		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		public void StartExport() {
			ExportClasses();
			ExportInstances();
			ExportUrls();
			ExportFactors();
		}


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		private void ExportClasses() {
			IList<IClassData> classes = vDelegate.GetNewClasses();

			foreach ( IClassData data in classes ) {
				if ( vDelegate.StopExporting() ) {
					return;
				}

				FabClass cla = Client.Services.Modify.AddClass
					.Post(data.Name, data.Disamb, data.Note).FirstDataItem();
				vDelegate.OnClassExport(data, cla);
			}
		}

		/*--------------------------------------------------------------------------------------------*/
		private void ExportInstances() {
			IList<IInstanceData> instances = vDelegate.GetNewInstances();

			foreach ( IInstanceData data in instances ) {
				if ( vDelegate.StopExporting() ) {
					return;
				}

				FabInstance inst = Client.Services.Modify.AddInstance
					.Post(data.Name, data.Disamb, data.Note).FirstDataItem();
				vDelegate.OnInstanceExport(data, inst);
			}
		}

		/*--------------------------------------------------------------------------------------------*/
		private void ExportUrls() {
			IList<IUrlData> urls = vDelegate.GetNewUrls();

			foreach ( IUrlData data in urls ) {
				if ( vDelegate.StopExporting() ) {
					return;
				}

				FabUrl url = Client.Services.Modify.AddUrl
					.Post(data.Path, data.Name).FirstDataItem();
				vDelegate.OnUrlExport(data, url);
			}
		}


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		private void ExportFactors() {
			IList<FabBatchNewFactor> factors = vDelegate.GetNewFactors();
			var batch = new List<FabBatchNewFactor>();

			foreach ( FabBatchNewFactor data in factors ) {
				if ( batch.Count < 20 ) {
					batch.Add(data);
					continue;
				}

				ExportFactorBatch(batch);
				batch = new List<FabBatchNewFactor>();
			}

			if ( batch.Count > 0 ) {
				ExportFactorBatch(batch);
			}
		}

		/*--------------------------------------------------------------------------------------------*/
		private void ExportFactorBatch(IList<FabBatchNewFactor> pBatch) {
			if ( vDelegate.StopExporting() ) {
				return;
			}

			IList<FabBatchResult> results = Client.Services.Modify.AddFactors
				.Post(pBatch.ToArray()).Data;

			foreach ( FabBatchResult r in results ) {
				vDelegate.OnFactorExport(r);
			}
		}
	
	}

}