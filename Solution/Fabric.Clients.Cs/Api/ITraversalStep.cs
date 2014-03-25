using System;

namespace Fabric.Clients.Cs.Api {

	/*================================================================================================*/
	/// <summary />
	public interface ITraversalStep {

		//TraversalPath TravPath { get; }

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
		FabResponse<T> Get();

	}
	
}