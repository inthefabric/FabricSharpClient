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
		private Mock<IExportForClientDelegate> vMockDpEfcDel;
		private Mock<IExportForClient> vMockDpEfc;

		private Mock<IExportServiceDelegate> vMockDel;

		private ExportService vExpSvc;
		private int vSvcThreadId;


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		[SetUp]
		public void SetUp() {
			vMockDpClient = new Mock<IFabricClient>();
			vMockDpEfcDel = new Mock<IExportForClientDelegate>();
			vMockDpEfc = new Mock<IExportForClient>();
			vSvcThreadId = -1;

			vMockDel = new Mock<IExportServiceDelegate>();

			vMockDel.Setup(x => x.GetDataProvClient()).Returns(vMockDpClient.Object);
			vMockDel.Setup(x => x.GetExportForClientDelegate(vMockDpClient.Object))
				.Returns(vMockDpEfcDel.Object);
			vMockDel.Setup(x => x.GetExportForClient(vMockDpEfcDel.Object)).Returns(vMockDpEfc.Object)
				.Callback(() => vSvcThreadId = Thread.CurrentThread.ManagedThreadId);

			vExpSvc = new ExportService(vMockDel.Object);
		}


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		[Test]
		public void StartDataProvExport() {
			bool result = vExpSvc.StartDataProvExport();

			Assert.True(result, "Incorrect result.");
			Assert.AreNotEqual(-1, vSvcThreadId, "Thread ID was not set.");
			Assert.AreNotEqual(Thread.CurrentThread.ManagedThreadId, vSvcThreadId,
				"ExportForClient should occur on a different thread.");

			vMockDel.Verify(x => x.GetDataProvClient(), Times.Once);
			vMockDel.Verify(x => x.GetExportForClientDelegate(vMockDpClient.Object), Times.Once);
			vMockDel.Verify(x => x.GetExportForClient(vMockDpEfcDel.Object), Times.Once);
		}

		/*--------------------------------------------------------------------------------------------*/
		[Test]
		public void StartDataProvExportTwice() {
			vExpSvc.StartDataProvExport();
			bool result = vExpSvc.StartDataProvExport();

			Assert.False(result, "Incorrect result.");
		}


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		[TestCase(0, 0)]
		[TestCase(1, 0)]
		[TestCase(1, 1)]
		[TestCase(9, 2)]
		[TestCase(9, 9)]
		public void StartNewUserExports(int pCount, int pDuplicates) {
			var clientList = new List<IFabricClient>();
			var threadMap = new ConcurrentDictionary<int, bool>();

			for ( int i = 0 ; i < pCount+pDuplicates ; ++i ) {
				var mockPs = new Mock<IFabricPersonSession>();
				mockPs.SetupGet(x => x.SessionId).Returns("sessId"+(i < pCount ? i : i-pCount));
				mockPs.SetupGet(x => x.Expiration).Returns(DateTime.UtcNow.AddMinutes(40));
				
				var mockFc = new Mock<IFabricClient>();
				mockFc.SetupGet(x => x.PersonSession).Returns(mockPs.Object);
				clientList.Add(mockFc.Object);

				if ( i >= pCount ) {
					continue;
				}

				var mockEfcDel = new Mock<IExportForClientDelegate>();
				
				var mockEfc = new Mock<IExportForClient>();
				mockEfc.SetupGet(x => x.Client).Returns(mockFc.Object);
				mockEfc.Setup(x => x.StartExport()).Callback(() => Thread.Sleep(100));

				vMockDel.Setup(x => x.GetExportForClientDelegate(mockFc.Object))
					.Returns(mockEfcDel.Object);

				vMockDel.Setup(x => x.GetExportForClient(mockEfcDel.Object)).Returns(mockEfc.Object)
					.Callback(() => {
						int tid = Thread.CurrentThread.ManagedThreadId;
						Assert.False(threadMap.ContainsKey(tid), "Already used thread ID "+tid+".");
						threadMap.TryAdd(tid, true);
					});
			}

			vMockDel.Setup(x => x.GetUserClients()).Returns(clientList);

			////

			int result = vExpSvc.StartNewUserExports();
			Thread.Sleep(500); //wait for threads to finish

			Assert.AreEqual(pCount, result, "Incorrect result.");
			Assert.AreEqual(pCount, threadMap.Count, "Incorrect thread count.");

			vMockDel.Verify(x => x.GetUserClients(), Times.Once());
			vMockDel.Verify(x => x.GetExportForClientDelegate(It.IsAny<IFabricClient>()),
				Times.Exactly(pCount));
			vMockDel.Verify(x => x.GetExportForClient(It.IsAny<IExportForClientDelegate>()),
				Times.Exactly(pCount));

			for ( int i = 0 ; i < pCount ; ++i ) {
				vMockDel.Verify(x => x.GetExportForClientDelegate(clientList[i]), Times.Once);
			}
		}

		/*--------------------------------------------------------------------------------------------*/
		[TestCase(1)]
		[TestCase(9)]
		public void StartNewUserExportsExpired(int pCount) {
			var clientList = new List<IFabricClient>();

			for ( int i = 0 ; i < pCount ; ++i ) {
				var mockPs = new Mock<IFabricPersonSession>();
				mockPs.SetupGet(x => x.SessionId).Returns("sessId"+i);
				mockPs.SetupGet(x => x.Expiration).Returns(DateTime.UtcNow.AddSeconds(-1));
				
				var mockFc = new Mock<IFabricClient>();
				mockFc.SetupGet(x => x.PersonSession).Returns(mockPs.Object);
				clientList.Add(mockFc.Object);
			}

			vMockDel.Setup(x => x.GetUserClients()).Returns(clientList);

			////

			int result = vExpSvc.StartNewUserExports();

			Assert.AreEqual(0, result, "Incorrect result.");

			vMockDel.Verify(x => x.GetUserClients(), Times.Once());
			vMockDel.Verify(x => x.GetExportForClientDelegate(It.IsAny<IFabricClient>()), Times.Never);
			vMockDel.Verify(x => x.GetExportForClient(It.IsAny<IExportForClientDelegate>()),
				Times.Never);
		}

	}

}