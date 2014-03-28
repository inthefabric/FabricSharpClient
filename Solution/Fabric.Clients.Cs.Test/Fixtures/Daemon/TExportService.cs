using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;
using Fabric.Clients.Cs.Daemon;
using Fabric.Clients.Cs.Session;
using Moq;
using NUnit.Framework;

namespace Fabric.Clients.Cs.Test.Fixtures.Daemon {
	
	/*================================================================================================*/
	[TestFixture]
	public class TExportService {

		private Mock<IFabricClient> vMockDpClient;
		private Mock<IExportServiceDelegate> vMockDel;

		private ExportService vExpSvc;


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		[SetUp]
		public void SetUp() {
			vMockDpClient = NewMockClient("DpSess", 1000);
			vMockDpClient.SetupGet(x => x.UseAppDataProvider).Returns(true);

			vMockDel = new Mock<IExportServiceDelegate>(MockBehavior.Strict);
			vMockDel.Setup(x => x.GetDataProvClient()).Returns(vMockDpClient.Object);
			vMockDel.Setup(x => x.GetExportForClientDelegate(It.IsAny<IFabricClient>()))
				.Returns((IExportForClientDelegate)null);
			vMockDel.Setup(x => x.HandleExpiredUserClient(It.IsAny<IFabricClient>()));

			vExpSvc = new ExportService(vMockDel.Object);
		}

		/*--------------------------------------------------------------------------------------------*/
		private Mock<IFabricClient> NewMockClient(string pSessId, int pAddSeconds) {
			var mockPs = new Mock<IFabricPersonSession>(MockBehavior.Strict);
			mockPs.SetupGet(x => x.SessionId).Returns(pSessId);
			mockPs.SetupGet(x => x.Expiration).Returns(DateTime.UtcNow.AddSeconds(pAddSeconds));

			var mockFc = new Mock<IFabricClient>(MockBehavior.Strict);
			mockFc.SetupGet(x => x.ActiveSession).Returns(mockPs.Object);
			mockFc.SetupGet(x => x.UseAppDataProvider).Returns(false);
			return mockFc;
		}


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		[TestCase(0, 0)]
		[TestCase(1, 0)]
		[TestCase(1, 1)]
		[TestCase(9, 2)]
		[TestCase(9, 9)]
		public void StartNewExports(int pCount, int pDuplicates) {
			var userClients = new List<IFabricClient>();
			var threadMap = new ConcurrentDictionary<int, bool>();

			var clientsToExport = new List<Mock<IFabricClient>>();
			clientsToExport.Add(vMockDpClient);

			for ( int i = 0 ; i < pCount+pDuplicates ; ++i ) {
				string sessId = "sessId"+(i < pCount ? i : i-pCount);
				var mockFc = NewMockClient(sessId, 1000);
				userClients.Add(mockFc.Object);

				if ( i < pCount ) {
					clientsToExport.Add(mockFc);
				}
			}

			foreach ( Mock<IFabricClient> mockFc in clientsToExport ) {
				IFabricClient fc = mockFc.Object;
				var mockEfcDel = new Mock<IExportForClientDelegate>(MockBehavior.Strict);

				var mockEfc = new Mock<IExportForClient>(MockBehavior.Strict);
				mockEfc.SetupGet(x => x.Client).Returns(fc);
				mockEfc.Setup(x => x.StartExport()).Callback(() => Thread.Sleep(100));

				vMockDel.Setup(x => x.GetExportForClientDelegate(fc))
					.Returns(mockEfcDel.Object);

				vMockDel.Setup(x => x.GetExportForClient(mockEfcDel.Object)).Returns(mockEfc.Object)
					.Callback(() => {
						int tid = Thread.CurrentThread.ManagedThreadId;
						Assert.False(threadMap.ContainsKey(tid), "Already used thread ID "+tid+".");
						threadMap.TryAdd(tid, true);
					});
			}

			vMockDel.Setup(x => x.GetUserClients()).Returns(userClients);

			////

			int result = vExpSvc.StartNewExports();
			Thread.Sleep(400); //wait for threads to finish

			int countWithDp = pCount+1;
			Assert.AreEqual(countWithDp, result, "Incorrect result.");
			Assert.AreEqual(countWithDp, threadMap.Count, "Incorrect thread count.");

			vMockDel.Verify(x => x.GetDataProvClient(), Times.Once());
			vMockDel.Verify(x => x.GetUserClients(), Times.Once());
			vMockDel.Verify(x => x.GetExportForClientDelegate(It.IsAny<IFabricClient>()),
				Times.Exactly(countWithDp));
			vMockDel.Verify(x => x.GetExportForClient(It.IsAny<IExportForClientDelegate>()),
				Times.Exactly(countWithDp));

			for ( int i = 0 ; i < countWithDp ; ++i ) {
				IFabricClient fc = clientsToExport[i].Object;
				vMockDel.Verify(x => x.GetExportForClientDelegate(fc), Times.Once);
			}
		}

		/*--------------------------------------------------------------------------------------------*/
		[TestCase(1)]
		[TestCase(9)]
		public void StartNewExportsExpired(int pCount) {
			var clientList = new List<IFabricClient>();

			for ( int i = 0 ; i < pCount ; ++i ) {
				var mockFc = NewMockClient("sessId"+i, -1);
				clientList.Add(mockFc.Object);
			}

			vMockDel.Setup(x => x.GetUserClients()).Returns(clientList);

			////

			int result = vExpSvc.StartNewExports();

			Assert.AreEqual(1, result, "Incorrect result."); //only the Data Prov client

			vMockDel.Verify(x => x.GetDataProvClient(), Times.Once);
			vMockDel.Verify(x => x.GetUserClients(), Times.Once);
			vMockDel.Verify(x => x.GetExportForClientDelegate(It.IsAny<IFabricClient>()), Times.Once);
			vMockDel.Verify(x => x.GetExportForClient(It.IsAny<IExportForClientDelegate>()),Times.Once);
			vMockDel.Verify(x => x.HandleExpiredUserClient(It.IsAny<IFabricClient>()),
				Times.Exactly(pCount));
		}

	}

}