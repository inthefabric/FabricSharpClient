using System;

namespace Fabric.Clients.Cs.Api {

	/*================================================================================================*/
	/// <summary/>
	internal abstract class TraversalStep : ITraversalStep {

		internal TraversalPath TravPath { get; private set; }

		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		protected TraversalStep(TraversalPath pTravPath) {
			TravPath = pTravPath;
		}
		
	}


	/*================================================================================================*/
	/// <summary/>
	internal class TraversalStep<T> : TraversalStep, ITraversalStep<T> where T : FabObject {


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		internal TraversalStep(TraversalPath pTravPath) : base(pTravPath) {}


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public Type GetDataType() {
			return typeof(T);
		}

		/*--------------------------------------------------------------------------------------------*/
		public FabResponse<T> Get() {
			return TravPath.Execute(this);
		}

	}
	
}