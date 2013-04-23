using System;
using Fabric.Clients.Cs.Api;
using Fabric.Clients.Cs.Session;
using Fabric.Clients.Cs.Test.Common;
using Moq;
using Moq.Language.Flow;
using NUnit.Framework;

namespace Fabric.Clients.Cs.Test.Fixtures.Session {
	
	/*================================================================================================*/
	[TestFixture]
	public class TAppSession : TOauthSession {

		private AppSession AppSess { get { return (AppSession)OauthSess; } }

		private ThreadedTest vThreadedTest;


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public override void TearDown() {
			base.TearDown();
			vThreadedTest = null;
		}

		/*--------------------------------------------------------------------------------------------*/
		protected override IFabricSessionContainer FabricSessionContainerProvider(string pConfigKey) {
			if ( vThreadedTest != null ) {
				return vThreadedTest.GetSessionContainer();
			}

			return base.FabricSessionContainerProvider(pConfigKey);
		}

		/*--------------------------------------------------------------------------------------------*/
		internal override OauthSession NewOauthSess(FabricClientConfig pConfig, 
																		IOauthService pClientOauth) {
			return new AppSession(pConfig, pClientOauth);
		}

		/*--------------------------------------------------------------------------------------------*/
		protected void SetupMockAccessToken(FabOauthAccess pResult, Action pCallback=null) {
			IReturnsResult<IOauthService> rr = MockOauth
				.Setup(x => x.AccessTokenClientCredentials.Get(
					Config.AppId+"",
					Config.AppSecret,
					Config.AppOAuthRedirectUri
				))
				.Returns(pResult);

			if ( pCallback != null ) {
				rr.Callback(pCallback);
			}
		}


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		[Test]
		public void RequestAuthentication() {
			FabOauthAccess expectResult = NewFabOauthAccess();
			SetupMockAccessToken(expectResult);

			FabOauthAccess result = AppSess.RequestAuthentication();

			Assert.AreEqual(expectResult, result, "Incorrect result.");
			CheckSessionProperties(expectResult);
		}

		/*--------------------------------------------------------------------------------------------*/
		[TestCase(true, 1, false)]
		[TestCase(true, -1, true)]
		[TestCase(false, 1, true)]
		[TestCase(false, -1, true)]
		public void RefreshTokenIfNecessary(bool pHasBearer, int pAddSeconds, bool pExpectRefresh) {
			string bearer = (pHasBearer ? "OldBearerToken" : null);
			DateTime expiry = DateTime.Now.AddSeconds(pAddSeconds);
			AppSess.BearerToken = bearer;
			AppSess.Expiration = expiry;

			FabOauthAccess expectResult = NewFabOauthAccess();
			SetupMockAccessToken(expectResult);

			bool result = AppSess.RefreshTokenIfNecessary();

			Assert.AreEqual(pExpectRefresh, result, "Incorrect result.");

			if ( pExpectRefresh ) {
				CheckSessionProperties(expectResult);
			}
			else {
				Assert.AreEqual(bearer, AppSess.BearerToken, "Incorrect BearerToken.");
				CheckExpiration(expiry);
			}
		}


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		[Test]
		public void RequestAuthentication_ThreadSafe() {
			vThreadedTest = new ThreadedTest();
			SetupMockAccessToken(NewFabOauthAccess(), vThreadedTest.MockEntryCallback);
			vThreadedTest.RunTest(ThreadRequestAuth);

			MockOauth.Verify(x => x.AccessTokenClientCredentials.Get(
				It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>()), Times.Exactly(2));
		}

		/*--------------------------------------------------------------------------------------------*/
		[Test]
		public void RefreshTokenIfNecessary_ThreadSafe() {
			vThreadedTest = new ThreadedTest();
			SetupMockAccessToken(NewFabOauthAccess(), vThreadedTest.MockEntryCallback);
			vThreadedTest.RunTest(ThreadRefreshIfNecc);
			
			MockOauth.Verify(x => x.AccessTokenClientCredentials.Get(
				It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>()), Times.Once());
		}

		/*--------------------------------------------------------------------------------------------*/
		private void ThreadRequestAuth(object pTest) {
			vThreadedTest.SetThreadTest(pTest);
			AppSess.RequestAuthentication();
		}

		/*--------------------------------------------------------------------------------------------*/
		private void ThreadRefreshIfNecc(object pTest) {
			vThreadedTest.SetThreadTest(pTest);
			AppSess.RefreshTokenIfNecessary();
		}

	}

}