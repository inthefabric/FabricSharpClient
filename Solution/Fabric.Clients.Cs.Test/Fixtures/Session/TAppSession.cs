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
		protected override IFabricSessionContainer SessionContainerProvider(string pConfigKey) {
			if ( vThreadedTest != null ) {
				return vThreadedTest.GetSessionContainer();
			}

			return base.SessionContainerProvider(pConfigKey);
		}

		/*--------------------------------------------------------------------------------------------*/
		internal override OauthSession NewOauthSess(IFabricClientConfig pConfig, 
																		IOauthService pClientOauth) {
			return new AppSession(pConfig, pClientOauth);
		}

		/*--------------------------------------------------------------------------------------------*/
		protected void SetupMockAccessToken(FabOauthAccess pResult, Action pCallback=null) {
			IReturnsResult<IOauthService> rr = MockOauth
				.Setup(x => x.AccessTokenClientCredentials.Get(
					MockConfig.Object.AppId,
					MockConfig.Object.AppSecret,
					MockConfig.Object.GetOauthRedirectUri(),
					SessionType.App
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
		[TestCase(true, 1, null, false)]
		[TestCase(true, -1, null, true)]
		[TestCase(false, 1, null, true)]
		[TestCase(false, -1, null, true)]
		[TestCase(true, 1, OauthAccessTokenGetOperation.Uri, false)]
		[TestCase(true, -1, OauthAccessTokenGetOperation.Uri, false)]
		[TestCase(false, 1, OauthAccessTokenGetOperation.Uri, false)]
		[TestCase(false, -1, OauthAccessTokenGetOperation.Uri, false)]
		public void RefreshTokenIfNecessary(bool pHasBearer, int pAddSeconds, 
																string pApiPath, bool pExpectRefresh) {
			string bearer = (pHasBearer ? "OldBearerToken" : null);
			DateTime expiry = DateTime.UtcNow.AddSeconds(pAddSeconds);
			AppSess.BearerToken = bearer;
			AppSess.Expiration = expiry;

			FabOauthAccess expectResult = NewFabOauthAccess();
			SetupMockAccessToken(expectResult);

			bool result = AppSess.RefreshTokenIfNecessary(pApiPath);

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

			MockOauth.Verify(x => 
				x.AccessTokenClientCredentials.Get(
					It.IsAny<long>(),
					It.IsAny<string>(),
					It.IsAny<string>(),
					SessionType.App
				),
				Times.Exactly(2)
			);
		}

		/*--------------------------------------------------------------------------------------------*/
		[Test]
		public void RefreshTokenIfNecessary_ThreadSafe() {
			vThreadedTest = new ThreadedTest();
			SetupMockAccessToken(NewFabOauthAccess(), vThreadedTest.MockEntryCallback);
			vThreadedTest.RunTest(ThreadRefreshIfNecc);
			
			MockOauth.Verify(x => 
				x.AccessTokenClientCredentials.Get(
					It.IsAny<long>(),
					It.IsAny<string>(),
					It.IsAny<string>(),
					SessionType.App
				),
				Times.Once()
			);
		}

		/*--------------------------------------------------------------------------------------------*/
		private void ThreadRequestAuth(object pTest) {
			vThreadedTest.SetThreadTest(pTest);
			AppSess.RequestAuthentication();
		}

		/*--------------------------------------------------------------------------------------------*/
		private void ThreadRefreshIfNecc(object pTest) {
			vThreadedTest.SetThreadTest(pTest);
			AppSess.RefreshTokenIfNecessary(null);
		}

	}

}