using System.Collections.Generic;
using Fabric.Clients.Cs.Api;
using Fabric.Clients.Cs.Daemon;
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
		private Mock<IModifyClassesPostOperation> vMockAddClass;
		private Mock<IModifyInstancesPostOperation> vMockAddInstance;
		private Mock<IModifyUrlsPostOperation> vMockAddUrl;
		private Mock<IModifyFactorsPostOperation> vMockAddFactor;


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		[SetUp]
		public void SetUp() {
			vMockAddClass = new Mock<IModifyClassesPostOperation>();
			vMockAddClass.Setup(x => x
				.Post(It.IsAny<CreateFabClass>()))
				.Returns(NewFabResp<FabClass>()
			);

			vMockAddInstance = new Mock<IModifyInstancesPostOperation>();
			vMockAddInstance.Setup(x =>
				x.Post(It.IsAny<CreateFabInstance>()))
				.Returns(NewFabResp<FabInstance>()
			);

			vMockAddUrl = new Mock<IModifyUrlsPostOperation>();
			vMockAddUrl.Setup(x =>
				x.Post(It.IsAny<CreateFabUrl>()))
				.Returns(NewFabResp<FabUrl>()
			);

			vMockAddFactor = new Mock<IModifyFactorsPostOperation>();
			vMockAddFactor.Setup(x =>
				x.Post(It.IsAny<CreateFabFactor>()))
				.Returns(NewFabResp<FabFactor>()
			);

			vMockModify = new Mock<IModifyService>();
			vMockModify.SetupGet(x => x.Classes).Returns(vMockAddClass.Object);
			vMockModify.SetupGet(x => x.Instances).Returns(vMockAddInstance.Object);
			vMockModify.SetupGet(x => x.Urls).Returns(vMockAddUrl.Object);
			vMockModify.SetupGet(x => x.Factors).Returns(vMockAddFactor.Object);

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
		[TestCase(0, 0, 0, 0)]
		[TestCase(1, 1, 1, 1)]
		[TestCase(18, 17, 19, 20)]
		[TestCase(0, 10, 0, 21)]
		[TestCase(5, 0, 5, 0)]
		[TestCase(0, 0, 0, 50)]
		public void StartExport(int pClasses, int pInstances, int pUrls, int pFactors) {
			vMockDel.SetCounts(pClasses, pInstances, pUrls, pFactors);

			var efc = new ExportForClient(vMockDel.Object);
			efc.StartExport();

			VerifyFabricCounts(pClasses, pInstances, pUrls, pFactors);
			VerifyExportCounts(pClasses, pInstances, pUrls, pFactors);
			vMockDel.Verify(x => x.OnExportComplete(), Times.Once);
		}

		/*--------------------------------------------------------------------------------------------*/
		[Test]
		public void StartExportStopExporting() {
			vMockDel.Setup(x => x.StopExporting()).Returns(true);
			vMockDel.SetCounts(20, 20, 20, 20);

			var efc = new ExportForClient(vMockDel.Object);
			efc.StartExport();

			VerifyFabricCounts(0, 0, 0, 0);
			VerifyExportCounts(0, 0, 0, 0);
			vMockDel.Verify(x => x.OnExportComplete(), Times.Once);
		}

		/*--------------------------------------------------------------------------------------------*/
		[Test]
		public void StartExportFakeMode() {
			vMockDel.SetCounts(1, 2, 3, 4);
			vMockDel.Setup(x => x.FakeFabricRequestMode()).Returns(true);

			var efc = new ExportForClient(vMockDel.Object);
			efc.StartExport();

			VerifyFabricCounts(0, 0, 0, 0);
			VerifyExportCounts(1, 2, 3, 4);
		}


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		private void VerifyFabricCounts(int pClasses, int pInstances, int pUrls, int pFactors){
			vMockAddClass.Verify(x =>
				x.Post(It.IsAny<CreateFabClass>()), Times.Exactly(pClasses));

			vMockAddInstance.Verify(x =>
				x.Post(It.IsAny<CreateFabInstance>()), Times.Exactly(pInstances));

			vMockAddUrl.Verify(x =>
				x.Post(It.IsAny<CreateFabUrl>()), Times.Exactly(pUrls));

			vMockAddFactor.Verify(x =>
				x.Post(It.IsAny<CreateFabFactor>()), Times.Exactly(pFactors));
		}

		/*--------------------------------------------------------------------------------------------*/
		private void VerifyExportCounts(int pClasses, int pInstances, int pUrls, int pFactors) {
			vMockDel.Verify(x => x
				.OnClassExport(
					It.IsAny<CreateFabClass>(),
					It.IsAny<FabClass>()
				), Times.Exactly(pClasses));

			vMockDel.Verify(x => x
				.OnInstanceExport(
					It.IsAny<CreateFabInstance>(),
					It.IsAny<FabInstance>()
				), Times.Exactly(pInstances));

			vMockDel.Verify(x => x
				.OnUrlExport(
					It.IsAny<CreateFabUrl>(),
					It.IsAny<FabUrl>()
				), Times.Exactly(pUrls));

			vMockDel.Verify(x => x
				.OnFactorExport(
					It.IsAny<CreateFabFactor>(),
					It.IsAny<FabFactor>()
				), Times.Exactly(pFactors));
		}

	}

}