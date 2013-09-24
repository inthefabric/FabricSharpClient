using Fabric.Clients.Cs.Session;
using NUnit.Framework;

namespace Fabric.Clients.Cs.Test.Fixtures {
	
	/*================================================================================================*/
	[TestFixture]
	public class TFabricClient {

		//TODO: test thread-safety of the InitOnce() and AddConfig()

		public const string TestConfigKey = "Test";

		private FabricSessionContainer vSessContain;


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		[SetUp]
		public void SetUp() {
			vSessContain = new FabricSessionContainer();
			FabricClient.InitOnce(GetConfig());
		}

		/*--------------------------------------------------------------------------------------------*/
		[TearDown]
		public void TearDown() {
			FabricClient.ResetInitialization();
		}


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		private FabricClientConfig GetConfig(string pName=TestConfigKey) {
			return new FabricClientConfig(pName, "http://testFabric.com/api", 1,
				"MySecretCode", 1, "http://testdomain.com/oauth", FabricSessionContainerProvider);
		}

		/*--------------------------------------------------------------------------------------------*/
		private IFabricSessionContainer FabricSessionContainerProvider(string pConfigKey) {
			return vSessContain;
		}


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		[Test]
		public void NewClient_SingleConfig_Default() {
			var fab = new FabricClient();
			checkClient(fab, TestConfigKey);
		}

		/*--------------------------------------------------------------------------------------------*/
		[Test]
		public void NewClient_TripleConfig_Default() {
			FabricClient.AddConfig(GetConfig("Second"));
			FabricClient.AddConfig(GetConfig("Third"));
			var fab = new FabricClient();
			checkClient(fab, TestConfigKey);
		}

		/*--------------------------------------------------------------------------------------------*/
		[TestCase(TestConfigKey)]
		[TestCase("Second")]
		[TestCase("Third")]
		public void NewClient_TripleConfig_Named(string pConfigKey) {
			FabricClient.AddConfig(GetConfig("Second"));
			FabricClient.AddConfig(GetConfig("Third"));
			var fab = new FabricClient(pConfigKey);
			checkClient(fab, pConfigKey);
		}


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		[Test]
		public void UseDataProvPerson() {
			var fab = new FabricClient();
			fab.UseDataProviderPerson = true;
			checkClient(fab, TestConfigKey);
			Assert.AreEqual(fab.Context.AppDataProvSess, fab.Context.PersonSess,
				"Incorrect PersonSess, expected the DataProv Person.");
		}


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		[Test]
		public void DoubleInitOnce() {
			FabricClient.ResetInitialization();
			FabricClient.InitOnce(GetConfig());

			try {
				FabricClient.InitOnce(GetConfig());
				Assert.Fail("Exception was not thrown.");
			}
			catch {}
		}

		/*--------------------------------------------------------------------------------------------*/
		[Test]
		public void AddConfigBeforeInitOnce() {
			FabricClient.ResetInitialization();

			try {
				FabricClient.AddConfig(GetConfig());
				Assert.Fail("Exception was not thrown.");
			}
			catch {}
		}

		/*--------------------------------------------------------------------------------------------*/
		[Test]
		public void NullConfigKey_InitOnce() {
			FabricClient.ResetInitialization();

			try {
				FabricClient.InitOnce(GetConfig(null));
				Assert.Fail("Exception was not thrown.");
			}
			catch {}
		}

		/*--------------------------------------------------------------------------------------------*/
		[Test]
		public void NullConfigKey_AddConfig() {
			FabricClient.ResetInitialization();
			FabricClient.InitOnce(GetConfig());

			try {
				FabricClient.AddConfig(GetConfig(null));
				Assert.Fail("Exception was not thrown.");
			}
			catch {}
		}

		/*--------------------------------------------------------------------------------------------*/
		[Test]
		public void DuplicateConfigKey_InitOnce() {
			FabricClient.ResetInitialization();

			try {
				FabricClient.InitOnce(GetConfig());
				Assert.Fail("Exception was not thrown.");
			}
			catch {}
		}

		/*--------------------------------------------------------------------------------------------*/
		[Test]
		public void DuplicateConfigKey_AddConfig() {
			FabricClient.ResetInitialization();
			FabricClient.InitOnce(GetConfig());

			try {
				FabricClient.AddConfig(GetConfig());
				Assert.Fail("Exception was not thrown.");
			}
			catch {}
		}

		/*--------------------------------------------------------------------------------------------*/
		[Test]
		public void NewClientBeforeInitOnce() {
			FabricClient.ResetInitialization();

			try {
				new FabricClient();
				Assert.Fail("Exception was not thrown.");
			}
			catch {}
		}

		/*--------------------------------------------------------------------------------------------*/
		[Test]
		public void NewClientWithUnknownConfigKey() {
			FabricClient.ResetInitialization();
			FabricClient.InitOnce(GetConfig());

			try {
				new FabricClient("uknown");
				Assert.Fail("Exception was not thrown.");
			}
			catch {}
		}


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		private void checkClient(FabricClient pFab, string pConfigName) {
			Assert.NotNull(pFab, "FabricClient should be filled.");

			Assert.NotNull(pFab.Config, "Config should be filled.");
			Assert.NotNull(pFab.PersonSession, "PersonSession should be filled.");
			Assert.NotNull(pFab.AppSession, "AppSession should be filled.");
			Assert.NotNull(pFab.AppDataProvSession, "AppDataProvSession should be filled.");

			Assert.NotNull(pFab.Services, "Services should be filled.");

			Assert.AreEqual(pConfigName, pFab.Config.ConfigKey, "Incorrect Config.ConfigKey.");

			Assert.NotNull(pFab.Context, "Context should be filled.");
			Assert.NotNull(pFab.Context.AppSess, "Context.AppSess should be filled.");
			Assert.NotNull(pFab.Context.AppDataProvSess, "Context.AppDataProvSess should be filled.");
			Assert.NotNull(pFab.Context.PersonSess, "Context.PersonSess should be filled.");

			Assert.AreEqual(pFab.UseDataProviderPerson, pFab.Context.UseDataProvPerson,
				"Incorrect Context.UseDataProvPerson.");
			Assert.AreEqual(pFab.Config, pFab.Context.Config, "Incorrect Context.Config.");
			Assert.AreEqual(pFab.AppSession, pFab.Context.AppSess, "Incorrect Context.AppSess.");
			Assert.AreEqual(pFab.AppDataProvSession, pFab.Context.AppDataProvSess,
				"Incorrect Context.AppDataProvSess.");
		}

	}

}