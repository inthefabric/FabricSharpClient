using System.Web;
using Fabric.Clients.Cs.Session;
using NUnit.Framework;

namespace Fabric.Clients.Cs.Test.Fixtures {
	
	/*================================================================================================*/
	[TestFixture]
	public class TFabricClientConfig {

		private string vKey;
		private string vApiPath;
		private int vAppId;
		private string vAppSecret;
		private string vAppOauthRedir;
		private FabricSessionContainer vSessContain;
		private FabricClientConfig.OauthRedirectUriProvider vRedirProv;
		private FabricClientConfig.SessionContainerProvider vContainProv;


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		[SetUp]
		public void SetUp() {
			vKey = "Test";
			vApiPath = "http://testFabric.com/api";
			vAppId = 1;
			vAppSecret = "MySecretCode";
			vAppOauthRedir = "http://testdomain.com/oauth";
			vSessContain = new FabricSessionContainer();
			vRedirProv = (k => vAppOauthRedir);
			vContainProv = (k => vSessContain);
		}

		/*--------------------------------------------------------------------------------------------*/
		[TearDown]
		public void TearDown() { }

		/*--------------------------------------------------------------------------------------------*/
		private FabricClientConfig GetConfig() {
			return new FabricClientConfig(vKey, vApiPath, vAppId, vAppSecret, vRedirProv, vContainProv);
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

			Assert.AreEqual(HttpUtility.UrlEncode(vAppOauthRedir), config.GetOauthRedirectUri(),
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
		public void InvalidRedirProv() {
			vRedirProv = null;

			try {
				GetConfig();
				Assert.Fail("Exception was not thrown.");
			}
			catch { }
		}

		/*--------------------------------------------------------------------------------------------*/
		[Test]
		public void InvalidContainerProv() {
			vContainProv = null;

			try {
				GetConfig();
				Assert.Fail("Exception was not thrown.");
			}
			catch {}
		}

	}

}