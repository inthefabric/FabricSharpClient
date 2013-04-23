using Fabric.Clients.Cs.Session;
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


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		[SetUp]
		public void SetUp() {
			vConfig = new FabricClientConfig("Test", "http://testFabric.com/api/", 1,
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
		}
		
		/*--------------------------------------------------------------------------------------------*/
		[Test]
		public void UseDataProvPerson() {
			Assert.False(vContext.UseDataProvPerson, "Incorrect UseDataProvPerson value.");
			IFabricPersonSession perSess = vContext.PersonSess;
			Assert.AreNotEqual(vDpSess, perSess, "Incorrect PersonSess.");

			vContext.UseDataProvPerson = true;
			Assert.True(vContext.UseDataProvPerson, "Incorrect UseDataProvPerson value.");
			Assert.AreEqual(vDpSess, vContext.PersonSess, "Incorrect PersonSess.");

			vContext.UseDataProvPerson = false;
			Assert.False(vContext.UseDataProvPerson, "Incorrect UseDataProvPerson value.");
			IFabricPersonSession perSess2 = vContext.PersonSess;
			Assert.AreEqual(perSess, perSess2, "Incorrect PersonSess.");
		}

	}

}