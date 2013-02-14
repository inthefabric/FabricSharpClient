namespace Fabric.Clients.Cs.Gen {

	/*================================================================================================*/
	public interface IServiceTraversal : IService {

		IGetActiveApp GetActiveApp();
		IGetActiveMember GetActiveMember();
		IGetActiveUser GetActiveUser();
		IGetRoot GetRoot();

	}

	/*================================================================================================*/
	public interface IServiceOauth : IService {

		IAccessToken AccessToken();
		IAccessTokenAuthCode AccessTokenAuthCode();
		IAccessTokenClientCredentials AccessTokenClientCredentials();
		IAccessTokenClientDataProv AccessTokenClientDataProv();
		IAccessTokenRefresh AccessTokenRefresh();
		ILogin Login();
		ILogout Logout();

	}

	/*================================================================================================*/
	public interface IServiceModify : IService {

		IAddApp AddApp();
		IAddClass AddClass();
		IAddFactor AddFactor();
		IAddInstance AddInstance();
		IAddUrl AddUrl();
		IAddUser AddUser();
		IAttachDescriptorToFactor AttachDescriptorToFactor();
		IAttachDirectorToFactor AttachDirectorToFactor();
		IAttachEventorToFactor AttachEventorToFactor();
		IAttachIdentorToFactor AttachIdentorToFactor();
		IAttachLocatorToFactor AttachLocatorToFactor();
		IAttachVectorToFactor AttachVectorToFactor();
		ICompleteFactor CompleteFactor();
		IDeleteFactor DeleteFactor();

	}

	/*================================================================================================*/
	public interface IServiceSpec : IService {

		IDocument Document();

	}

