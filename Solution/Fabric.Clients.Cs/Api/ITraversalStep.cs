using System;
using Fabric.Clients.Cs.Session;

namespace Fabric.Clients.Cs.Api {

	/*================================================================================================*/
	/// <summary />
	public interface ITraversalStep {

	}


	/*================================================================================================*/
	/// <summary />
	public interface ITraversalStep<T> : ITraversalStep where T : FabObject {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		Type GetDataType();

		/*--------------------------------------------------------------------------------------------*/
		/// <summary />
		/// <param name="pSessionType">
		///   Specifies which session authentication to send with the Fabric API request.
		/// </param>
		FabResponse<T> Get(SessionType pSessionType=SessionType.Default);

	}
	
}