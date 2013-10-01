using System.Collections.Generic;
using Fabric.Clients.Cs.Api;
using Fabric.Clients.Cs.Daemon;
using Fabric.Clients.Cs.Daemon.Data;
using Moq;
using NUnit.Framework;

namespace Fabric.Clients.Cs.Test.Fixtures.Daemon {
	
	/*================================================================================================*/
	[TestFixture]
	public class TExportForClient {

		private MockExportForClientDelegate vMockDel;
		private Mock<IFabricClient> vMockClient;
		private Mock<IFabricServices> vMockServices;
		private Mock<IModifyService> vMockModify;
		private Mock<IAddClassOperation> vMockAddClass;
		private Mock<IAddInstanceOperation> vMockAddInstance;
		private Mock<IAddUrlOperation> vMockAddUrl;
		private Mock<IAddFactorsOperation> vMockAddFactors;


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		[SetUp]
		public void SetUp() {
			vMockAddClass = new Mock<IAddClassOperation>();
			vMockAddClass.Setup(x =>
				x.Post(
					It.IsAny<string>(),
					It.IsAny<string>(),
					It.IsAny<string>()
				))
				.Returns(NewFabResp<FabClass>());

			vMockAddInstance = new Mock<IAddInstanceOperation>();
			vMockAddInstance.Setup(x =>
				x.Post(
					It.IsAny<string>(),
					It.IsAny<string>(),
					It.IsAny<string>()
				))
				.Returns(NewFabResp<FabInstance>());

			vMockAddUrl = new Mock<IAddUrlOperation>();
			vMockAddUrl.Setup(x =>
				x.Post(
					It.IsAny<string>(),
					It.IsAny<string>()
				))
				.Returns(NewFabResp<FabUrl>());

			vMockAddFactors = new Mock<IAddFactorsOperation>();

			for ( int i = 0 ; i <= 20 ; ++i ) {
				int size = i;

				vMockAddFactors.Setup(x => x
					.Post(It.Is<FabBatchNewFactor[]>(nf => (nf.Length == size))))
					.Returns(NewFabRespList<FabBatchResult>(size));
			}

			vMockModify = new Mock<IModifyService>();
			vMockModify.SetupGet(x => x.AddClass).Returns(vMockAddClass.Object);
			vMockModify.SetupGet(x => x.AddInstance).Returns(vMockAddInstance.Object);
			vMockModify.SetupGet(x => x.AddUrl).Returns(vMockAddUrl.Object);
			vMockModify.SetupGet(x => x.AddFactors).Returns(vMockAddFactors.Object);

			vMockServices = new Mock<IFabricServices>();
			vMockServices.SetupGet(x => x.Modify).Returns(vMockModify.Object);

			vMockClient = new Mock<IFabricClient>();
			vMockClient.SetupGet(x => x.Services).Returns(vMockServices.Object);

			vMockDel = new MockExportForClientDelegate();
			vMockDel.Setup(x => x.GetClient()).Returns(vMockClient.Object);
			vMockDel.Setup(x => x.StopExporting()).Returns(false);
		}

		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabResponse<T> NewFabResp<T>() where T : new() {
			var fr = new FabResponse<T>();
			fr.Data = new List<T>();
			fr.Data.Add(new T());
			return fr;
		}

		/*--------------------------------------------------------------------------------------------*/
		public FabResponse<T> NewFabRespList<T>(int pCount) where T : new() {
			var fr = new FabResponse<T>();
			fr.Data = new List<T>();

			for ( int i = 0 ; i < pCount ; ++i ) {
				fr.Data.Add(new T());
			}

			return fr;
		}


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		[Test]
		public void New() {
			var efc = new ExportForClient(vMockDel.Object);
			Assert.AreEqual(vMockClient.Object, efc.Client, "Incorrect Client.");
		}

		/*--------------------------------------------------------------------------------------------*/
		[TestCase(0, 0, 0, 0, 0)]
		[TestCase(1, 1, 1, 1, 1)]
		[TestCase(20, 20, 20, 20, 2)]
		[TestCase(0, 10, 0, 21, 3)]
		[TestCase(5, 0, 5, 0, 0)]
		[TestCase(0, 0, 0, 50, 5)]
		public void StartExport(int pClasses, int pInstances, int pUrls, int pFactors, int pFacBatch) {
			vMockDel.SetCounts(pClasses, pInstances, pUrls, pFactors);

			var efc = new ExportForClient(vMockDel.Object);
			efc.StartExport();

			VerifyCounts(pClasses, pInstances, pUrls, pFactors, pFacBatch);
			vMockDel.Verify(x => x.OnExportComplete(), Times.Once);
		}

		/*--------------------------------------------------------------------------------------------*/
		[Test]
		public void StartExportStopExporting() {
			vMockDel.Setup(x => x.StopExporting()).Returns(true);
			vMockDel.SetCounts(20, 20, 20, 20);

			var efc = new ExportForClient(vMockDel.Object);
			efc.StartExport();

			VerifyCounts(0, 0, 0, 0, 0);
			vMockDel.Verify(x => x.OnExportComplete(), Times.Once);
		}


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		private void VerifyCounts(int pClasses, int pInstances, int pUrls, int pFactors, int pFacBatch){
			vMockAddClass.Verify(x =>
				x.Post(
					It.IsAny<string>(),
					It.IsAny<string>(),
					It.IsAny<string>()
				), Times.Exactly(pClasses));

			vMockAddInstance.Verify(x =>
				x.Post(
					It.IsAny<string>(),
					It.IsAny<string>(),
					It.IsAny<string>()
				), Times.Exactly(pInstances));

			vMockAddUrl.Verify(x =>
				x.Post(
					It.IsAny<string>(),
					It.IsAny<string>()
				), Times.Exactly(pUrls));

			vMockAddFactors.Verify(x =>
				x.Post(
					It.IsAny<FabBatchNewFactor[]>()
				), Times.Exactly(pFacBatch));

			vMockDel.Verify(x => x
				.OnClassExport(
					It.IsAny<ClassData>(),
					It.IsAny<FabClass>()
				), Times.Exactly(pClasses));

			vMockDel.Verify(x => x
				.OnInstanceExport(
					It.IsAny<InstanceData>(),
					It.IsAny<FabInstance>()
				), Times.Exactly(pInstances));

			vMockDel.Verify(x => x
				.OnUrlExport(
					It.IsAny<UrlData>(),
					It.IsAny<FabUrl>()
				), Times.Exactly(pUrls));

			vMockDel.Verify(x => x
				.OnFactorExport(
					It.IsAny<FabBatchResult>()
				), Times.Exactly(pFactors));
		}

	}

}