// GENERATED CODE
// Changes made to this source file will be overwritten

using Fabric.Clients.Cs.Api;

namespace Fabric.Clients.Cs.Api {

	/*================================================================================================*/
	public partial interface ITraversalAppsGetOperation {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Begin a new traversal.
		/// </summary>
		IFabTravAppRootStep Traverse { get; }
		
	}
	

	/*================================================================================================*/
	internal partial class TraversalAppsGetOperation {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public IFabTravAppRootStep Traverse {
			get {
				var path = new TraversalPath(vContext, Uri);
				return new FabTravAppRootStep(path);
			}
		}
		
	}

	/*================================================================================================*/
	public partial interface ITraversalArtifactsGetOperation {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Begin a new traversal.
		/// </summary>
		IFabTravArtifactRootStep Traverse { get; }
		
	}
	

	/*================================================================================================*/
	internal partial class TraversalArtifactsGetOperation {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public IFabTravArtifactRootStep Traverse {
			get {
				var path = new TraversalPath(vContext, Uri);
				return new FabTravArtifactRootStep(path);
			}
		}
		
	}

	/*================================================================================================*/
	public partial interface ITraversalClassesGetOperation {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Begin a new traversal.
		/// </summary>
		IFabTravClassRootStep Traverse { get; }
		
	}
	

	/*================================================================================================*/
	internal partial class TraversalClassesGetOperation {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public IFabTravClassRootStep Traverse {
			get {
				var path = new TraversalPath(vContext, Uri);
				return new FabTravClassRootStep(path);
			}
		}
		
	}

	/*================================================================================================*/
	public partial interface ITraversalFactorsGetOperation {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Begin a new traversal.
		/// </summary>
		IFabTravFactorRootStep Traverse { get; }
		
	}
	

	/*================================================================================================*/
	internal partial class TraversalFactorsGetOperation {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public IFabTravFactorRootStep Traverse {
			get {
				var path = new TraversalPath(vContext, Uri);
				return new FabTravFactorRootStep(path);
			}
		}
		
	}

	/*================================================================================================*/
	public partial interface ITraversalInstancesGetOperation {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Begin a new traversal.
		/// </summary>
		IFabTravInstanceRootStep Traverse { get; }
		
	}
	

	/*================================================================================================*/
	internal partial class TraversalInstancesGetOperation {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public IFabTravInstanceRootStep Traverse {
			get {
				var path = new TraversalPath(vContext, Uri);
				return new FabTravInstanceRootStep(path);
			}
		}
		
	}

	/*================================================================================================*/
	public partial interface ITraversalMembersGetOperation {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Begin a new traversal.
		/// </summary>
		IFabTravMemberRootStep Traverse { get; }
		
	}
	

	/*================================================================================================*/
	internal partial class TraversalMembersGetOperation {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public IFabTravMemberRootStep Traverse {
			get {
				var path = new TraversalPath(vContext, Uri);
				return new FabTravMemberRootStep(path);
			}
		}
		
	}

	/*================================================================================================*/
	public partial interface ITraversalUrlsGetOperation {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Begin a new traversal.
		/// </summary>
		IFabTravUrlRootStep Traverse { get; }
		
	}
	

	/*================================================================================================*/
	internal partial class TraversalUrlsGetOperation {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public IFabTravUrlRootStep Traverse {
			get {
				var path = new TraversalPath(vContext, Uri);
				return new FabTravUrlRootStep(path);
			}
		}
		
	}

	/*================================================================================================*/
	public partial interface ITraversalUsersGetOperation {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Begin a new traversal.
		/// </summary>
		IFabTravUserRootStep Traverse { get; }
		
	}
	

	/*================================================================================================*/
	internal partial class TraversalUsersGetOperation {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public IFabTravUserRootStep Traverse {
			get {
				var path = new TraversalPath(vContext, Uri);
				return new FabTravUserRootStep(path);
			}
		}
		
	}

	/*================================================================================================*/
	public partial interface ITraversalVerticesGetOperation {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Begin a new traversal.
		/// </summary>
		IFabTravVertexRootStep Traverse { get; }
		
	}
	

	/*================================================================================================*/
	internal partial class TraversalVerticesGetOperation {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public IFabTravVertexRootStep Traverse {
			get {
				var path = new TraversalPath(vContext, Uri);
				return new FabTravVertexRootStep(path);
			}
		}
		
	}

}