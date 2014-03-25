using System.Collections.Generic;
using Fabric.Clients.Cs.Api;

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
			IList<CreateFabClass> classes = vDelegate.GetNewClasses();
			int n = 0;

			foreach ( CreateFabClass data in classes ) {
				if ( vDelegate.StopExporting() ) {
					return n;
				}

				FabClass cla;

				if ( vDelegate.FakeFabricRequestMode() ) {
					cla = new FabClass { Id = 1000000 };
				}
				else {
					var cc = new CreateFabClass {
						Name = data.Name,
						Disamb = data.Disamb,
						Note = data.Note
					};

					cla = Client.Services.Modify.Classes.Post(cc).FirstDataItem();
				}

				vDelegate.OnClassExport(data, cla);
				++n;
			}

			return classes.Count;
		}

		/*--------------------------------------------------------------------------------------------*/
		private int ExportInstances() {
			IList<CreateFabInstance> instances = vDelegate.GetNewInstances();
			int n = 0;

			foreach ( CreateFabInstance data in instances ) {
				if ( vDelegate.StopExporting() ) {
					return n;
				}

				FabInstance inst;
				
				if ( vDelegate.FakeFabricRequestMode() ) {
					inst = new FabInstance { Id = 1000000 };
				}
				else {
					inst = Client.Services.Modify.Instances.Post(data).FirstDataItem();
				}

				vDelegate.OnInstanceExport(data, inst);
				++n;
			}

			return instances.Count;
		}

		/*--------------------------------------------------------------------------------------------*/
		private int ExportUrls() {
			IList<CreateFabUrl> urls = vDelegate.GetNewUrls();
			int n = 0;

			foreach ( CreateFabUrl data in urls ) {
				if ( vDelegate.StopExporting() ) {
					return n;
				}

				FabUrl url;

				if ( vDelegate.FakeFabricRequestMode() ) {
					url = new FabUrl { Id = 1000000 };
				}
				else {
					url = Client.Services.Modify.Urls.Post(data).FirstDataItem();
				}

				vDelegate.OnUrlExport(data, url);
				++n;
			}

			return n;
		}

		/*--------------------------------------------------------------------------------------------*/
		private int ExportFactors() {
			IList<CreateFabFactor> factors = vDelegate.GetNewFactors();
			int n = 0;

			foreach ( CreateFabFactor data in factors ) {
				if ( vDelegate.StopExporting() ) {
					return n;
				}

				FabFactor factor;

				if ( vDelegate.FakeFabricRequestMode() ) {
					factor = new FabFactor { Id = 1000000 };
				}
				else {
					factor = Client.Services.Modify.Factors.Post(data).FirstDataItem();
				}

				vDelegate.OnFactorExport(data, factor);
				++n;
			}

			return n;
		}
	
	}

}