using System.Web;
using Fabric.Clients.Cs.Logging;
using Fabric.Clients.Cs.Session;
using Moq;
using NUnit.Framework;

namespace Fabric.Clients.Cs.Test.Fixtures {
	
	/*================================================================================================*/
	[TestFixture]
	public class TFabricClientConfig {

		private string vKey;
		private string vApiPath;
		private int vAppId;
		private string vAppSecret;
		private int vAppDpId;
		private string vAppOauthRedir;
		private FabricSessionContainer vSessContain;


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		[SetUp]
		public void SetUp() {
			vKey = "Test";
			vApiPath = "http://testFabric.com/api/";
			vAppId = 1;
			vAppSecret = "MySecretCode";
			vAppDpId = 4;
			vAppOauthRedir = "http://testdomain.com/oauth";
			vSessContain = new FabricSessionContainer();
		}

		/*--------------------------------------------------------------------------------------------*/
		[TearDown]
		public void TearDown() { }


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		private IFabricSessionContainer FabricSessionContainerProvider(string pConfigKey) {
			return vSessContain;
		}

		/*--------------------------------------------------------------------------------------------*/
		private FabricClientConfig GetConfig() {
			return new FabricClientConfig(vKey, vApiPath, vAppId, vAppSecret, vAppDpId,
				vAppOauthRedir, FabricSessionContainerProvider);
		}


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		[Test]
		public void NewConfig() {
			FabricClientConfig config = GetConfig();

			Assert.NotNull(config, "Config should be filled.");
			Assert.AreEqual(vKey, config.ConfigKey, "Incorrect ConfigKey.");
			Assert.AreEqual(vApiPath, config.ApiPath, "Incorrect ApiPath.");
			Assert.AreEqual(vAppId, config.AppId, "Incorrect AppId.");
			Assert.AreEqual(vAppSecret, config.AppSecret, "Incorrect AppSecret.");
			Assert.AreEqual(vAppDpId, config.AppDataProvPersonId, "Incorrect AppDataProvPersonId.");
			Assert.AreEqual(HttpUtility.UrlEncode(vAppOauthRedir), config.AppOAuthRedirectUri,
				"Incorrect AppOAuthRedirectUri.");

			Assert.AreEqual(vSessContain, config.GetSessionContainer(), "Incorrect SessionContainer.");
		}


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		[TestCase(null)]
		[TestCase("")]
		[TestCase(" ")]
		[TestCase("       ")]
		public void InvalidConfigKey(string pKey) {
			vKey = pKey;

			try {
				GetConfig();
				Assert.Fail("Exception was not thrown.");
			}
			catch {}
		}

		/*--------------------------------------------------------------------------------------------*/
		[TestCase(null)]
		[TestCase("")]
		[TestCase(" ")]
		[TestCase("       ")]
		public void InvalidApiPath(string pPath) {
			vApiPath = pPath;

			try {
				GetConfig();
				Assert.Fail("Exception was not thrown.");
			}
			catch {}
		}

		/*--------------------------------------------------------------------------------------------*/
		[TestCase(-1)]
		[TestCase(0)]
		public void InvalidAppId(int pId) {
			vAppId = pId;

			try {
				GetConfig();
				Assert.Fail("Exception was not thrown.");
			}
			catch {}
		}

		/*--------------------------------------------------------------------------------------------*/
		[TestCase(null)]
		[TestCase("")]
		[TestCase(" ")]
		[TestCase("       ")]
		public void InvalidAppSecret(string pSecret) {
			vAppSecret = pSecret;

			try {
				GetConfig();
				Assert.Fail("Exception was not thrown.");
			}
			catch {}
		}

		/*--------------------------------------------------------------------------------------------*/
		[TestCase(null)]
		[TestCase("")]
		[TestCase(" ")]
		[TestCase("       ")]
		public void InvalidOauthRedirect(string pRedir) {
			vAppOauthRedir = pRedir;

			try {
				GetConfig();
				Assert.Fail("Exception was not thrown.");
			}
			catch {}
		}

		/*--------------------------------------------------------------------------------------------*/
		[Test]
		public void InvalidContainerProv() {
			vSessContain = null;

			try {
				GetConfig();
				Assert.Fail("Exception was not thrown.");
			}
			catch {}
		}


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		[Test]
		public void Logger() {
			var log = new Mock<IFabricLog>();

			FabricClientConfig config = GetConfig();
			config.Logger = log.Object;

			config.LogInfo("info");
			log.Verify(x => x.Info(config, It.IsAny<string>()), Times.Once());
			log.Verify(x => x.Debug(config, It.IsAny<string>()), Times.Never());
			log.Verify(x => x.Error(config, It.IsAny<string>()), Times.Never());
			log.Verify(x => x.Fatal(config, It.IsAny<string>()), Times.Never());
			log.Verify(x => x.Warn(config, It.IsAny<string>()), Times.Never());

			config.LogDebug("debug");
			log.Verify(x => x.Debug(config, It.IsAny<string>()), Times.Once());

			config.LogError("error");
			log.Verify(x => x.Error(config, It.IsAny<string>()), Times.Once());

			config.LogFatal("fatal");
			log.Verify(x => x.Fatal(config, It.IsAny<string>()), Times.Once());

			config.LogWarn("warn");
			config.LogWarn("warn");
			config.LogWarn("warn");
			log.Verify(x => x.Warn(config, It.IsAny<string>()), Times.Exactly(3));
		}

	}

}