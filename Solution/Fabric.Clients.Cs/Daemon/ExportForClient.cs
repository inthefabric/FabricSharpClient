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
			while ( true ) {
				int n = 0;

				while ( ExportClasses() > 0 ) {
					++n;
				}

				while ( ExportInstances() > 0 ) {
					++n;
				}

				while ( ExportUrls() > 0 ) {
					++n;
				}

				while ( ExportFactors() > 0 ) {
					++n;
				}

				if ( n > 0 ) {
					continue;
				}

				vDelegate.OnExportComplete();
				return;
			}
		}


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		private int ExportClasses() {
			IList<ClassData> classes = vDelegate.GetNewClasses();
			int n = 0;

			foreach ( ClassData data in classes ) {
				if ( vDelegate.StopExporting() ) {
					return n;
				}

				FabClass cla = Client.Services.Modify.AddClass
					.Post(data.Name, data.Disamb, data.Note).FirstDataItem();
				vDelegate.OnClassExport(data, cla);
				++n;
			}

			return classes.Count;
		}

		/*--------------------------------------------------------------------------------------------*/
		private int ExportInstances() {
			IList<InstanceData> instances = vDelegate.GetNewInstances();
			int n = 0;

			foreach ( InstanceData data in instances ) {
				if ( vDelegate.StopExporting() ) {
					return n;
				}

				FabInstance inst = Client.Services.Modify.AddInstance
					.Post(data.Name, data.Disamb, data.Note).FirstDataItem();
				vDelegate.OnInstanceExport(data, inst);
				++n;
			}

			return instances.Count;
		}

		/*--------------------------------------------------------------------------------------------*/
		private int ExportUrls() {
			IList<UrlData> urls = vDelegate.GetNewUrls();
			int n = 0;

			foreach ( UrlData data in urls ) {
				if ( vDelegate.StopExporting() ) {
					return n;
				}

				FabUrl url = Client.Services.Modify.AddUrl
					.Post(data.Path, data.Name).FirstDataItem();
				vDelegate.OnUrlExport(data, url);
				++n;
			}

			return n;
		}


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		private int ExportFactors() {
			IList<FabBatchNewFactor> factors = vDelegate.GetNewFactors();
			var batch = new List<FabBatchNewFactor>();
			int n = 0;

			foreach ( FabBatchNewFactor data in factors ) {
				batch.Add(data);

				if ( batch.Count < 20 ) {
					continue;
				}

				n += ExportFactorBatch(batch);
				batch = new List<FabBatchNewFactor>();
			}

			if ( batch.Count > 0 ) {
				n += ExportFactorBatch(batch);
			}

			return n;
		}

		/*--------------------------------------------------------------------------------------------*/
		private int ExportFactorBatch(IList<FabBatchNewFactor> pBatch) {
			if ( vDelegate.StopExporting() ) {
				return 0;
			}

			IList<FabBatchResult> results = Client.Services.Modify.AddFactors
				.Post(pBatch.ToArray()).Data;

			foreach ( FabBatchResult r in results ) {
				vDelegate.OnFactorExport(r);
			}

			return results.Count;
		}
	
	}

}