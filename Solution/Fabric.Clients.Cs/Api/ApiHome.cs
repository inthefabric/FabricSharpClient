﻿// GENERATED CODE
// Changes made to this source file will be overwritten
// Generated on 4/23/2013 12:20:52 AM

using Fabric.Clients.Cs.Session;

namespace Fabric.Clients.Cs.Api {

	/*================================================================================================*/
	/// <summary />
	public interface IFabricServices {
		
		/// <summary>
		///   The API version used to generate the Fabric client code.
		/// </summary>
		string ApiVersion { get; }

		/// <summary>
		///   TODO
		/// </summary>
		ITraversalService Traversal { get; }

		/// <summary>
		///   TODO
		/// </summary>
		IOauthService Oauth { get; }

		/// <summary>
		///   TODO
		/// </summary>
		IModifyService Modify { get; }

		/// <summary>
		///   TODO
		/// </summary>
		IMetaService Meta { get; }

	}

	
	/*================================================================================================*/
	internal class FabricServices : IFabricServices {
		
		private readonly IClientContext vContext;

		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabricServices(IClientContext pContext) {
			vContext = pContext;
		}

		/*--------------------------------------------------------------------------------------------*/
		public string ApiVersion { get { return "0.1.25.d956bb32cb56"; } }

		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public ITraversalService Traversal {
			get { return new TraversalService(vContext); }
		}

		/*--------------------------------------------------------------------------------------------*/
		public IOauthService Oauth {
			get { return new OauthService(vContext); }
		}

		/*--------------------------------------------------------------------------------------------*/
		public IModifyService Modify {
			get { return new ModifyService(vContext); }
		}

		/*--------------------------------------------------------------------------------------------*/
		public IMetaService Meta {
			get { return new MetaService(vContext); }
		}

	}

}