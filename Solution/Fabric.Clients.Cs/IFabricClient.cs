using Fabric.Clients.Cs.Api;
using Fabric.Clients.Cs.Session;
using IFabricServices = Fabric.Clients.Cs.Api.IFabricServices;

namespace Fabric.Clients.Cs {
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabricClient : IHideSystemIntellisense {

		/// <summary />
		IFabricClientConfig Config { get; }
		/// <summary />
		IFabricPersonSession PersonSession { get; }
		/// <summary />
		IFabricAppSession AppSession { get; }
		/// <summary />
		IFabricAppDataProvSession AppDataProvSession { get; }

		/// <summary />
		IFabricServices Services { get; }

		/// <summary />
		bool UseDataProviderPerson { get; set; }

	}

}
