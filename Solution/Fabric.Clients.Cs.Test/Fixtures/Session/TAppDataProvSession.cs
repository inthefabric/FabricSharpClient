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
	public class TAppDataProvSession : TPersonSession {

		private AppDataProvSession DpSess { get { return (AppDataProvSession)OauthSess; } }
		private Mock<AppSession> MockAppSess { get; set; }

		private ThreadedTest vThreadedTest;


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public override void SetUp() {
			MockAppSess = new Mock<AppSession>(null, null);
			base.SetUp();
		}

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
			return new AppDataProvSession(pConfig, pClientOauth, MockAppSess.Object);
		}

		/*--------------------------------------------------------------------------------------------*/
		protected void SetupMockAccessToken(FabOauthAccess pResult, Action pCallback=null) {
			IReturnsResult<IOauthService> rr = MockOauth
				.Setup(x => x.AccessTokenClientDataProv.Get(
					Config.AppId+"",
					Config.AppSecret,
					Config.AppOAuthRedirectUri,
					Config.AppDataProvPersonId+""
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

			FabOauthAccess result = DpSess.RequestAuthentication();

			Assert.AreEqual(expectResult, result, "Incorrect result.");
			CheckSessionProperties(expectResult);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		[TestCase(true, 1, false)]
		[TestCase(true, -1, true)]
		[TestCase(false, 1, false)]
		[TestCase(false, -1, false)]
		public override void RefreshTokenIfNecessary(
											bool pHasRefresh, int pAddSeconds, bool pExpectRefresh) {
			DpSess.BearerToken = "BearerToken1234";
			base.RefreshTokenIfNecessary(pHasRefresh, pAddSeconds, pExpectRefresh);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		[Test]
		public void RefreshTokenNotAuthenticated() {
			DpSess.BearerToken = null;
			FabOauthAccess accessResult = NewFabOauthAccess();
			SetupMockAccessToken(accessResult);

			bool result = DpSess.RefreshTokenIfNecessary();

			Assert.True(result, "Incorrect result.");
			CheckSessionProperties(accessResult);
		}


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		[Test]
		public void RequestAuthentication_ThreadSafe() {
			vThreadedTest = new ThreadedTest();
			SetupMockAccessToken(NewFabOauthAccess(), vThreadedTest.MockEntryCallback);
			vThreadedTest.RunTest(ThreadRequestAuth);

			MockOauth.Verify(x => x.AccessTokenClientDataProv.Get(
				It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>()),
				Times.Exactly(2)
			);
		}

		/*--------------------------------------------------------------------------------------------*/
		[Test]
		public void RefreshTokenIfNecessary_ThreadSafe() {
			vThreadedTest = new ThreadedTest();
			SetupMockAccessToken(NewFabOauthAccess(), vThreadedTest.MockEntryCallback);
			vThreadedTest.RunTest(ThreadRefreshIfNecc);

			MockOauth.Verify(x => x.AccessTokenClientDataProv.Get(
				It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>()),
				Times.Once()
			);
		}

		/*--------------------------------------------------------------------------------------------*/
		private void ThreadRequestAuth(object pTest) {
			vThreadedTest.SetThreadTest(pTest);
			DpSess.RequestAuthentication();
		}

		/*--------------------------------------------------------------------------------------------*/
		private void ThreadRefreshIfNecc(object pTest) {
			vThreadedTest.SetThreadTest(pTest);
			DpSess.RefreshTokenIfNecessary();
		}


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		[TestCase(false)]
		public override void GetGrantCodeUrl(bool pSwitchUser) {
			try {
				DpSess.GetGrantCodeUrl(pSwitchUser);
				Assert.Fail("NotSupportedException expected.");
			}
			catch ( NotSupportedException ) {
			}
			catch ( Exception ) {
				Assert.Fail("NotSupportedException expected.");
			}
		}

		/*--------------------------------------------------------------------------------------------*/
		[TestCase(null)]
		public override void GetGrantWindowOpenScript(string pGrantCodeUrl) {
			try {
				DpSess.GetGrantWindowOpenScript(pGrantCodeUrl);
				Assert.Fail("NotSupportedException expected.");
			}
			catch ( NotSupportedException ) {
			}
			catch ( Exception ) {
				Assert.Fail("NotSupportedException expected.");
			}
		}

		/*--------------------------------------------------------------------------------------------*/
		[Test]
		public override void HandleGrantCodeRedirect() {
			try {
				DpSess.HandleGrantCodeRedirect(null);
				Assert.Fail("NotSupportedException expected.");
			}
			catch ( NotSupportedException ) {
			}
			catch ( Exception ) {
				Assert.Fail("NotSupportedException expected.");
			}
		}

	}

}