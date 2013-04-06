// GENERATED CODE
// Changes made to this source file will be overwritten
// Generated on 4/6/2013 2:00:14 PM

namespace Fabric.Clients.Cs.Api {
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabArtifactStep<T> : IFabNodeStep<T>, IFuncAs, IFuncBack, IFuncLimit, IFuncWhereId where T : FabObject {
		

		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a Member to the Artifact that it created. (InFromOne FabMember)
		/// </summary>
		/// <remarks>
		///   <para>Links a Member to the Artifact that it created.</para>
		///   <para>Type: MemberCreatesArtifact</para>
		///   <para>Relation: Creates</para>
		///   <para>Connection: InFromOne</para>
		/// </remarks>
		IFabMemberStep InMemberCreates { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a Factor to its primary Artifact, which represents the starting point of the Factor's directional Artifact relationship. (InFromZeroOrMore FabFactor)
		/// </summary>
		/// <remarks>
		///   <para>Links a Factor to its primary Artifact, which represents the starting point of the Factor's directional Artifact relationship.</para>
		///   <para>Type: FactorUsesPrimaryArtifact</para>
		///   <para>Relation: UsesPrimary</para>
		///   <para>Connection: InFromZeroOrMore</para>
		/// </remarks>
		IFabFactorStep InFactorListUsesPrimary { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a Factor to its related Artifact, which represents the ending point of the Factor's directional Artifact relationship. (InFromZeroOrMore FabFactor)
		/// </summary>
		/// <remarks>
		///   <para>Links a Factor to its related Artifact, which represents the ending point of the Factor's directional Artifact relationship.</para>
		///   <para>Type: FactorUsesRelatedArtifact</para>
		///   <para>Relation: UsesRelated</para>
		///   <para>Connection: InFromZeroOrMore</para>
		/// </remarks>
		IFabFactorStep InFactorListUsesRelated { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a Descriptor to an Artifact that specifies or clarifies a particular aspect of the Factor's primary Artifact. (InFromZeroOrMore FabDescriptor)
		/// </summary>
		/// <remarks>
		///   <para>Links a Descriptor to an Artifact that specifies or clarifies a particular aspect of the Factor's primary Artifact.</para>
		///   <para>Type: DescriptorRefinesPrimaryWithArtifact</para>
		///   <para>Relation: RefinesPrimaryWith</para>
		///   <para>Connection: InFromZeroOrMore</para>
		/// </remarks>
		IFabDescriptorStep InDescriptorListRefinesPrimaryWith { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a Descriptor to an Artifact that specifies or clarifies a particular aspect of the Factor's related Artifact. (InFromZeroOrMore FabDescriptor)
		/// </summary>
		/// <remarks>
		///   <para>Links a Descriptor to an Artifact that specifies or clarifies a particular aspect of the Factor's related Artifact.</para>
		///   <para>Type: DescriptorRefinesRelatedWithArtifact</para>
		///   <para>Relation: RefinesRelatedWith</para>
		///   <para>Connection: InFromZeroOrMore</para>
		/// </remarks>
		IFabDescriptorStep InDescriptorListRefinesRelatedWith { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a Descriptor to an Artifact that specifies or clarifies a particular aspect of the DescriptorType's meaning or purpose. (InFromZeroOrMore FabDescriptor)
		/// </summary>
		/// <remarks>
		///   <para>Links a Descriptor to an Artifact that specifies or clarifies a particular aspect of the DescriptorType's meaning or purpose.</para>
		///   <para>Type: DescriptorRefinesTypeWithArtifact</para>
		///   <para>Relation: RefinesTypeWith</para>
		///   <para>Connection: InFromZeroOrMore</para>
		/// </remarks>
		IFabDescriptorStep InDescriptorListRefinesTypeWith { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a Vector to an Artifact that 'labels' its value's axis. (InFromZeroOrMore FabVector)
		/// </summary>
		/// <remarks>
		///   <para>Links a Vector to an Artifact that 'labels' its value's axis.</para>
		///   <para>Type: VectorUsesAxisArtifact</para>
		///   <para>Relation: UsesAxis</para>
		///   <para>Connection: InFromZeroOrMore</para>
		/// </remarks>
		IFabVectorStep InVectorListUsesAxis { get; }
	
	}
	

	/*================================================================================================*/
	internal class FabArtifactStep<T> : FabNodeStep<T>, IFabArtifactStep<T> where T : FabObject {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabArtifactStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public IFabMemberStep InMemberCreates {
			get {
				var s = new FabMemberStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/InMemberCreates");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabFactorStep InFactorListUsesPrimary {
			get {
				var s = new FabFactorStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/InFactorListUsesPrimary");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabFactorStep InFactorListUsesRelated {
			get {
				var s = new FabFactorStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/InFactorListUsesRelated");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabDescriptorStep InDescriptorListRefinesPrimaryWith {
			get {
				var s = new FabDescriptorStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/InDescriptorListRefinesPrimaryWith");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabDescriptorStep InDescriptorListRefinesRelatedWith {
			get {
				var s = new FabDescriptorStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/InDescriptorListRefinesRelatedWith");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabDescriptorStep InDescriptorListRefinesTypeWith {
			get {
				var s = new FabDescriptorStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/InDescriptorListRefinesTypeWith");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabVectorStep InVectorListUsesAxis {
			get {
				var s = new FabVectorStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/InVectorListUsesAxis");
				return s;
			}
		}
		
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabArtifactStep : IFabArtifactStep<FabArtifact> {

	}

	
	/*================================================================================================*/
	internal class FabArtifactStep : FabArtifactStep<FabArtifact>, IFabArtifactStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabArtifactStep(Traversal pTrav) : base(pTrav) {}

	}
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabBatchNewObjectStep<T> : IFabObjectStep<T> where T : FabObject {
		

		////////////////////////////////////////////////////////////////////////////////////////////////
	}
	

	/*================================================================================================*/
	internal class FabBatchNewObjectStep<T> : FabObjectStep<T>, IFabBatchNewObjectStep<T> where T : FabObject {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabBatchNewObjectStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabBatchNewObjectStep : IFabBatchNewObjectStep<FabBatchNewObject> {

	}

	
	/*================================================================================================*/
	internal class FabBatchNewObjectStep : FabBatchNewObjectStep<FabBatchNewObject>, IFabBatchNewObjectStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabBatchNewObjectStep(Traversal pTrav) : base(pTrav) {}

	}
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabFactorElementNodeStep<T> : IFabNodeStep<T>, IFuncAs, IFuncBack, IFuncLimit, IFuncWhereId where T : FabObject {
		

		////////////////////////////////////////////////////////////////////////////////////////////////
	}
	

	/*================================================================================================*/
	internal class FabFactorElementNodeStep<T> : FabNodeStep<T>, IFabFactorElementNodeStep<T> where T : FabObject {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabFactorElementNodeStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabFactorElementNodeStep : IFabFactorElementNodeStep<FabFactorElementNode> {

	}

	
	/*================================================================================================*/
	internal class FabFactorElementNodeStep : FabFactorElementNodeStep<FabFactorElementNode>, IFabFactorElementNodeStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabFactorElementNodeStep(Traversal pTrav) : base(pTrav) {}

	}
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabNodeStep<T> : IFabObjectStep<T> where T : FabObject {
		

		////////////////////////////////////////////////////////////////////////////////////////////////
	}
	

	/*================================================================================================*/
	internal class FabNodeStep<T> : FabObjectStep<T>, IFabNodeStep<T> where T : FabObject {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabNodeStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabNodeStep : IFabNodeStep<FabNode> {

	}

	
	/*================================================================================================*/
	internal class FabNodeStep : FabNodeStep<FabNode>, IFabNodeStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabNodeStep(Traversal pTrav) : base(pTrav) {}

	}
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabNodeForActionStep<T> : IFabNodeStep<T>, IFuncAs, IFuncBack, IFuncLimit, IFuncWhereId where T : FabObject {
		

		////////////////////////////////////////////////////////////////////////////////////////////////
	}
	

	/*================================================================================================*/
	internal class FabNodeForActionStep<T> : FabNodeStep<T>, IFabNodeForActionStep<T> where T : FabObject {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabNodeForActionStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabNodeForActionStep : IFabNodeForActionStep<FabNodeForAction> {

	}

	
	/*================================================================================================*/
	internal class FabNodeForActionStep : FabNodeForActionStep<FabNodeForAction>, IFabNodeForActionStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabNodeForActionStep(Traversal pTrav) : base(pTrav) {}

	}
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabNodeForTypeStep<T> : IFabNodeStep<T>, IFuncAs, IFuncBack, IFuncLimit, IFuncWhereId where T : FabObject {
		

		////////////////////////////////////////////////////////////////////////////////////////////////
	}
	

	/*================================================================================================*/
	internal class FabNodeForTypeStep<T> : FabNodeStep<T>, IFabNodeForTypeStep<T> where T : FabObject {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabNodeForTypeStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabNodeForTypeStep : IFabNodeForTypeStep<FabNodeForType> {

	}

	
	/*================================================================================================*/
	internal class FabNodeForTypeStep : FabNodeForTypeStep<FabNodeForType>, IFabNodeForTypeStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabNodeForTypeStep(Traversal pTrav) : base(pTrav) {}

	}
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabObjectStep<T> : ITraversalStep<T> where T : FabObject {
		

		////////////////////////////////////////////////////////////////////////////////////////////////
	}
	

	/*================================================================================================*/
	internal class FabObjectStep<T> : TraversalStep<T>, IFabObjectStep<T> where T : FabObject {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabObjectStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabObjectStep : IFabObjectStep<FabObject> {

	}

	
	/*================================================================================================*/
	internal class FabObjectStep : FabObjectStep<FabObject>, IFabObjectStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabObjectStep(Traversal pTrav) : base(pTrav) {}

	}
	
}
