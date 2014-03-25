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
		private FabricSessionContainer vSessContain;
		private ClientContext vContext;
		private int vSessProvCounter;


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		[SetUp]
		public void SetUp() {
			vSessProvCounter = 0;

			vConfig = new FabricClientConfig("Test", "http://testFabric.com/api", 1,
				"MySecretCode", 1, (k => "http://testdomain.com/oauth"), SessionContainerProvider);
			vAppSess = new AppSession(vConfig, null);
			vSessContain = new FabricSessionContainer();
			vContext = new ClientContext(vConfig, vAppSess);

			FabricClient.InitOnce(vConfig);
		}

		/*--------------------------------------------------------------------------------------------*/
		[TearDown]
		public void TearDown() {
			FabricClient.ResetInitialization();
		}


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		private IFabricSessionContainer SessionContainerProvider(string pConfigKey) {
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
			Assert.NotNull(vContext.PersonSess, "PersonSess should be filled.");

			Assert.AreEqual(vConfig, vContext.Config, "Incorrect Config.");
			Assert.AreEqual(vAppSess, vContext.AppSess, "Incorrect Config.");
			Assert.False(vContext.UseAppDataProvider, "Incorrect UseDataProvPerson value.");

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
			Assert.False(vContext.UseAppDataProvider, "Incorrect UseDataProvPerson value.");
			IFabricOauthSession actSess = vContext.ActiveSess;
			Assert.AreNotEqual(vAppSess, actSess, "Incorrect PersonSess.");
			Assert.AreEqual(1, vSessProvCounter, "Incorrect Session Provider count.");

			vContext.UseAppDataProvider = true;
			Assert.True(vContext.UseAppDataProvider, "Incorrect UseDataProvPerson value.");
			Assert.AreEqual(vAppSess, vContext.PersonSess, "Incorrect PersonSess.");
			Assert.AreEqual(1, vSessProvCounter, "Incorrect Session Provider count.");

			vContext.UseAppDataProvider = false;
			Assert.False(vContext.UseAppDataProvider, "Incorrect UseDataProvPerson value.");
			IFabricPersonSession perSess2 = vContext.PersonSess;
			Assert.AreEqual(actSess, perSess2, "Incorrect PersonSess.");
			Assert.AreEqual(1, vSessProvCounter, "Incorrect Session Provider count.");
		}


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		[TestCase(false)]
		[TestCase(true)]
		public void Log(bool pUseDataProv) {
			var log = new Mock<IFabricLog>();
			vConfig.Logger = log.Object;

			vContext.UseAppDataProvider = pUseDataProv;
			string sessId = (pUseDataProv ? vAppSess.SessionId : null);

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