using Fabric.Clients.Cs.Logging;
using Fabric.Clients.Cs.Session;
using Moq;
using NUnit.Framework;

namespace Fabric.Clients.Cs.Test.Fixtures.Session {
	
	/*================================================================================================*/
	[TestFixture]
	public class TClientContext {

		private FabricClientConfig vConfig;
		private AppSession vAppSess;
		private AppDataProvSession vDpSess;
		private FabricSessionContainer vSessContain;
		private ClientContext vContext;
		private int vSessProvCounter;


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		[SetUp]
		public void SetUp() {
			vSessProvCounter = 0;

			vConfig = new FabricClientConfig("Test", "http://testFabric.com/api", 1,
				"MySecretCode", 1, "http://testdomain.com/oauth", FabricSessionContainerProvider);
			vAppSess = new AppSession(vConfig, null);
			vDpSess = new AppDataProvSession(vConfig, null, vAppSess);
			vSessContain = new FabricSessionContainer();
			vContext = new ClientContext(vConfig, vAppSess, vDpSess);

			FabricClient.InitOnce(vConfig);
		}

		/*--------------------------------------------------------------------------------------------*/
		[TearDown]
		public void TearDown() {
			FabricClient.ResetInitialization();
		}


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		private IFabricSessionContainer FabricSessionContainerProvider(string pConfigKey) {
			vSessProvCounter++;
			return vSessContain;
		}


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		[Test]
		public void ValidProperties() {
			Assert.NotNull(vContext, "Context should be filled.");
			Assert.NotNull(vContext.Config, "Config should be filled.");
			Assert.NotNull(vContext.AppSess, "AppSess should be filled.");
			Assert.NotNull(vContext.AppDataProvSess, "AppDataProvSess should be filled.");
			Assert.NotNull(vContext.PersonSess, "PersonSess should be filled.");

			Assert.AreEqual(vConfig, vContext.Config, "Incorrect Config.");
			Assert.AreEqual(vAppSess, vContext.AppSess, "Incorrect Config.");
			Assert.AreEqual(vDpSess, vContext.AppDataProvSess, "Incorrect Config.");
			Assert.False(vContext.UseDataProvPerson, "Incorrect UseDataProvPerson value.");

			Assert.AreEqual(1, vSessProvCounter, "Incorrect Session Provider count.");
		}

		/*--------------------------------------------------------------------------------------------*/
		[Test]
		public void PersonSess() {
			IFabricPersonSession ps0 = vContext.PersonSess;
			IFabricPersonSession ps1 = vContext.PersonSess;

			Assert.AreEqual(1, vSessProvCounter, "Incorrect Session Provider count.");
			Assert.AreEqual(ps0, ps1, "Expected the same provider object.");
		}
		
		/*--------------------------------------------------------------------------------------------*/
		[Test]
		public void UseDataProvPerson() {
			Assert.False(vContext.UseDataProvPerson, "Incorrect UseDataProvPerson value.");
			IFabricPersonSession perSess = vContext.PersonSess;
			Assert.AreNotEqual(vDpSess, perSess, "Incorrect PersonSess.");
			Assert.AreEqual(1, vSessProvCounter, "Incorrect Session Provider count.");

			vContext.UseDataProvPerson = true;
			Assert.True(vContext.UseDataProvPerson, "Incorrect UseDataProvPerson value.");
			Assert.AreEqual(vDpSess, vContext.PersonSess, "Incorrect PersonSess.");
			Assert.AreEqual(1, vSessProvCounter, "Incorrect Session Provider count.");

			vContext.UseDataProvPerson = false;
			Assert.False(vContext.UseDataProvPerson, "Incorrect UseDataProvPerson value.");
			IFabricPersonSession perSess2 = vContext.PersonSess;
			Assert.AreEqual(perSess, perSess2, "Incorrect PersonSess.");
			Assert.AreEqual(1, vSessProvCounter, "Incorrect Session Provider count.");
		}


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		[TestCase(false)]
		[TestCase(true)]
		public void Log(bool pUseDataProv) {
			var log = new Mock<IFabricLog>();
			vConfig.Logger = log.Object;

			vContext.UseDataProvPerson = pUseDataProv;
			string sessId = (pUseDataProv ? vDpSess.SessionId : null);

			vContext.LogInfo("info");
			log.Verify(x => x.Info(sessId, It.IsAny<string>()), Times.Once());
			log.Verify(x => x.Debug(sessId, It.IsAny<string>()), Times.Never());
			log.Verify(x => x.Error(sessId, It.IsAny<string>()), Times.Never());
			log.Verify(x => x.Fatal(sessId, It.IsAny<string>()), Times.Never());
			log.Verify(x => x.Warn(sessId, It.IsAny<string>()), Times.Never());

			vContext.LogDebug("debug");
			log.Verify(x => x.Debug(sessId, It.IsAny<string>()), Times.Once());

			vContext.LogError("error");
			log.Verify(x => x.Error(sessId, It.IsAny<string>()), Times.Once());

			vContext.LogFatal("fatal");
			log.Verify(x => x.Fatal(sessId, It.IsAny<string>()), Times.Once());

			vContext.LogWarn("warn");
			vContext.LogWarn("warn");
			vContext.LogWarn("warn");
			log.Verify(x => x.Warn(sessId, It.IsAny<string>()), Times.Exactly(3));

			Assert.AreEqual(0, vSessProvCounter, "Incorrect Session Provider count.");
		}

	}

}