// GENERATED CODE
// Changes made to this source file will be overwritten
// Generated on 4/6/2013 11:08:11 AM

namespace Fabric.Clients.Cs.Api {

	/*================================================================================================*/
	/// <summary />
	public interface IFabAppStep : ITraversalStep<FabApp> {
	
		
		////////////////////////////////////////////////////////////////////////////////////////////////
	}
	

	/*================================================================================================*/
	internal class FabAppStep : TraversalStep<FabApp>, IFabAppStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabAppStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabArtifactStep : ITraversalStep<FabArtifact> {
	
		
		////////////////////////////////////////////////////////////////////////////////////////////////
	}
	

	/*================================================================================================*/
	internal class FabArtifactStep : TraversalStep<FabArtifact>, IFabArtifactStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabArtifactStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabBatchNewClassStep : ITraversalStep<FabBatchNewClass> {
	
		
		////////////////////////////////////////////////////////////////////////////////////////////////
	}
	

	/*================================================================================================*/
	internal class FabBatchNewClassStep : TraversalStep<FabBatchNewClass>, IFabBatchNewClassStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabBatchNewClassStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabBatchNewObjectStep : ITraversalStep<FabBatchNewObject> {
	
		
		////////////////////////////////////////////////////////////////////////////////////////////////
	}
	

	/*================================================================================================*/
	internal class FabBatchNewObjectStep : TraversalStep<FabBatchNewObject>, IFabBatchNewObjectStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabBatchNewObjectStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabBatchResultStep : ITraversalStep<FabBatchResult> {
	
		
		////////////////////////////////////////////////////////////////////////////////////////////////
	}
	

	/*================================================================================================*/
	internal class FabBatchResultStep : TraversalStep<FabBatchResult>, IFabBatchResultStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabBatchResultStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabClassStep : ITraversalStep<FabClass>, IFuncAs, IFuncBack, IFuncLimit, IFuncWhereId {
	
		
		////////////////////////////////////////////////////////////////////////////////////////////////
	}
	

	/*================================================================================================*/
	internal class FabClassStep : TraversalStep<FabClass>, IFabClassStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabClassStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabDescriptorStep : ITraversalStep<FabDescriptor>, IFuncAs, IFuncBack, IFuncLimit, IFuncWhereId {
	
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a Factor to its Descriptor Element, which defines the relationship between the primary and related Artifact. (InFromOneOrMore FabFactor)
		/// </summary>
		/// <remarks>
		///   <para>Links a Factor to its Descriptor Element, which defines the relationship between the primary and related Artifact.</para>
		///   <para>Type: FactorUsesDescriptor</para>
		///   <para>Relation: Uses</para>
		///   <para>Connection: InFromOneOrMore</para>
		/// </remarks>
		IFabFactorStep InFactorListUses { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a Descriptor to a DescriptorType that specifies the type of relationship or connection. (OutToOne FabDescriptorType)
		/// </summary>
		/// <remarks>
		///   <para>Links a Descriptor to a DescriptorType that specifies the type of relationship or connection.</para>
		///   <para>Type: DescriptorUsesDescriptorType</para>
		///   <para>Relation: Uses</para>
		///   <para>Connection: OutToOne</para>
		/// </remarks>
		IFabDescriptorTypeStep UsesDescriptorType { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a Descriptor to an Artifact that specifies or clarifies a particular aspect of the Factor's primary Artifact. (OutToZeroOrOne FabArtifact)
		/// </summary>
		/// <remarks>
		///   <para>Links a Descriptor to an Artifact that specifies or clarifies a particular aspect of the Factor's primary Artifact.</para>
		///   <para>Type: DescriptorRefinesPrimaryWithArtifact</para>
		///   <para>Relation: RefinesPrimaryWith</para>
		///   <para>Connection: OutToZeroOrOne</para>
		/// </remarks>
		IFabArtifactStep RefinesPrimaryWithArtifact { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a Descriptor to an Artifact that specifies or clarifies a particular aspect of the Factor's related Artifact. (OutToZeroOrOne FabArtifact)
		/// </summary>
		/// <remarks>
		///   <para>Links a Descriptor to an Artifact that specifies or clarifies a particular aspect of the Factor's related Artifact.</para>
		///   <para>Type: DescriptorRefinesRelatedWithArtifact</para>
		///   <para>Relation: RefinesRelatedWith</para>
		///   <para>Connection: OutToZeroOrOne</para>
		/// </remarks>
		IFabArtifactStep RefinesRelatedWithArtifact { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a Descriptor to an Artifact that specifies or clarifies a particular aspect of the DescriptorType's meaning or purpose. (OutToZeroOrOne FabArtifact)
		/// </summary>
		/// <remarks>
		///   <para>Links a Descriptor to an Artifact that specifies or clarifies a particular aspect of the DescriptorType's meaning or purpose.</para>
		///   <para>Type: DescriptorRefinesTypeWithArtifact</para>
		///   <para>Relation: RefinesTypeWith</para>
		///   <para>Connection: OutToZeroOrOne</para>
		/// </remarks>
		IFabArtifactStep RefinesTypeWithArtifact { get; }
	
	}
	

	/*================================================================================================*/
	internal class FabDescriptorStep : TraversalStep<FabDescriptor>, IFabDescriptorStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabDescriptorStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public IFabFactorStep InFactorListUses {
			get {
				var s = new FabFactorStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/InFactorListUses");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabDescriptorTypeStep UsesDescriptorType {
			get {
				var s = new FabDescriptorTypeStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/UsesDescriptorType");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabArtifactStep RefinesPrimaryWithArtifact {
			get {
				var s = new FabArtifactStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/RefinesPrimaryWithArtifact");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabArtifactStep RefinesRelatedWithArtifact {
			get {
				var s = new FabArtifactStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/RefinesRelatedWithArtifact");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabArtifactStep RefinesTypeWithArtifact {
			get {
				var s = new FabArtifactStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/RefinesTypeWithArtifact");
				return s;
			}
		}
		
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabDescriptorTypeStep : ITraversalStep<FabDescriptorType>, IFuncAs, IFuncBack, IFuncLimit, IFuncWhereId {
	
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a Descriptor to a DescriptorType that specifies the type of relationship or connection. (InFromZeroOrMore FabDescriptor)
		/// </summary>
		/// <remarks>
		///   <para>Links a Descriptor to a DescriptorType that specifies the type of relationship or connection.</para>
		///   <para>Type: DescriptorUsesDescriptorType</para>
		///   <para>Relation: Uses</para>
		///   <para>Connection: InFromZeroOrMore</para>
		/// </remarks>
		IFabDescriptorStep InDescriptorListUses { get; }
	
	}
	

	/*================================================================================================*/
	internal class FabDescriptorTypeStep : TraversalStep<FabDescriptorType>, IFabDescriptorTypeStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabDescriptorTypeStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public IFabDescriptorStep InDescriptorListUses {
			get {
				var s = new FabDescriptorStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/InDescriptorListUses");
				return s;
			}
		}
		
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabDirectorStep : ITraversalStep<FabDirector>, IFuncAs, IFuncBack, IFuncLimit, IFuncWhereId {
	
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a Factor to its Director Element, which creates a directional pathway between the primary and related Artifacts. (InFromOneOrMore FabFactor)
		/// </summary>
		/// <remarks>
		///   <para>Links a Factor to its Director Element, which creates a directional pathway between the primary and related Artifacts.</para>
		///   <para>Type: FactorUsesDirector</para>
		///   <para>Relation: Uses</para>
		///   <para>Connection: InFromOneOrMore</para>
		/// </remarks>
		IFabFactorStep InFactorListUses { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a Director to a DirectorType that specifies the type and reason for the pathway. (OutToOne FabDirectorType)
		/// </summary>
		/// <remarks>
		///   <para>Links a Director to a DirectorType that specifies the type and reason for the pathway.</para>
		///   <para>Type: DirectorUsesDirectorType</para>
		///   <para>Relation: Uses</para>
		///   <para>Connection: OutToOne</para>
		/// </remarks>
		IFabDirectorTypeStep UsesDirectorType { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a Director to a DirectorAction that specifies the action to be performed on the Factor's primary Artifact. (OutToOne FabDirectorAction)
		/// </summary>
		/// <remarks>
		///   <para>Links a Director to a DirectorAction that specifies the action to be performed on the Factor's primary Artifact.</para>
		///   <para>Type: DirectorUsesPrimaryDirectorAction</para>
		///   <para>Relation: UsesPrimary</para>
		///   <para>Connection: OutToOne</para>
		/// </remarks>
		IFabDirectorActionStep UsesPrimaryDirectorAction { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a Director to a DirectorAction that specifies the action to be performed on the Factor's related Artifact. (OutToOne FabDirectorAction)
		/// </summary>
		/// <remarks>
		///   <para>Links a Director to a DirectorAction that specifies the action to be performed on the Factor's related Artifact.</para>
		///   <para>Type: DirectorUsesRelatedDirectorAction</para>
		///   <para>Relation: UsesRelated</para>
		///   <para>Connection: OutToOne</para>
		/// </remarks>
		IFabDirectorActionStep UsesRelatedDirectorAction { get; }
	
	}
	

	/*================================================================================================*/
	internal class FabDirectorStep : TraversalStep<FabDirector>, IFabDirectorStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabDirectorStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public IFabFactorStep InFactorListUses {
			get {
				var s = new FabFactorStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/InFactorListUses");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabDirectorTypeStep UsesDirectorType {
			get {
				var s = new FabDirectorTypeStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/UsesDirectorType");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabDirectorActionStep UsesPrimaryDirectorAction {
			get {
				var s = new FabDirectorActionStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/UsesPrimaryDirectorAction");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabDirectorActionStep UsesRelatedDirectorAction {
			get {
				var s = new FabDirectorActionStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/UsesRelatedDirectorAction");
				return s;
			}
		}
		
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabDirectorActionStep : ITraversalStep<FabDirectorAction>, IFuncAs, IFuncBack, IFuncLimit, IFuncWhereId {
	
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a Director to a DirectorAction that specifies the action to be performed on the Factor's primary Artifact. (InFromZeroOrMore FabDirector)
		/// </summary>
		/// <remarks>
		///   <para>Links a Director to a DirectorAction that specifies the action to be performed on the Factor's primary Artifact.</para>
		///   <para>Type: DirectorUsesPrimaryDirectorAction</para>
		///   <para>Relation: UsesPrimary</para>
		///   <para>Connection: InFromZeroOrMore</para>
		/// </remarks>
		IFabDirectorStep InDirectorListUsesPrimary { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a Director to a DirectorAction that specifies the action to be performed on the Factor's related Artifact. (InFromZeroOrMore FabDirector)
		/// </summary>
		/// <remarks>
		///   <para>Links a Director to a DirectorAction that specifies the action to be performed on the Factor's related Artifact.</para>
		///   <para>Type: DirectorUsesRelatedDirectorAction</para>
		///   <para>Relation: UsesRelated</para>
		///   <para>Connection: InFromZeroOrMore</para>
		/// </remarks>
		IFabDirectorStep InDirectorListUsesRelated { get; }
	
	}
	

	/*================================================================================================*/
	internal class FabDirectorActionStep : TraversalStep<FabDirectorAction>, IFabDirectorActionStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabDirectorActionStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public IFabDirectorStep InDirectorListUsesPrimary {
			get {
				var s = new FabDirectorStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/InDirectorListUsesPrimary");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabDirectorStep InDirectorListUsesRelated {
			get {
				var s = new FabDirectorStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/InDirectorListUsesRelated");
				return s;
			}
		}
		
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabDirectorTypeStep : ITraversalStep<FabDirectorType>, IFuncAs, IFuncBack, IFuncLimit, IFuncWhereId {
	
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a Director to a DirectorType that specifies the type and reason for the pathway. (InFromZeroOrMore FabDirector)
		/// </summary>
		/// <remarks>
		///   <para>Links a Director to a DirectorType that specifies the type and reason for the pathway.</para>
		///   <para>Type: DirectorUsesDirectorType</para>
		///   <para>Relation: Uses</para>
		///   <para>Connection: InFromZeroOrMore</para>
		/// </remarks>
		IFabDirectorStep InDirectorListUses { get; }
	
	}
	

	/*================================================================================================*/
	internal class FabDirectorTypeStep : TraversalStep<FabDirectorType>, IFabDirectorTypeStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabDirectorTypeStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public IFabDirectorStep InDirectorListUses {
			get {
				var s = new FabDirectorStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/InDirectorListUses");
				return s;
			}
		}
		
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabErrorStep : ITraversalStep<FabError> {
	
		
		////////////////////////////////////////////////////////////////////////////////////////////////
	}
	

	/*================================================================================================*/
	internal class FabErrorStep : TraversalStep<FabError>, IFabErrorStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabErrorStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabEventorStep : ITraversalStep<FabEventor>, IFuncAs, IFuncBack, IFuncLimit, IFuncWhereId {
	
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a Factor to its Eventor Element, which applies the concept of time. (InFromOneOrMore FabFactor)
		/// </summary>
		/// <remarks>
		///   <para>Links a Factor to its Eventor Element, which applies the concept of time.</para>
		///   <para>Type: FactorUsesEventor</para>
		///   <para>Relation: Uses</para>
		///   <para>Connection: InFromOneOrMore</para>
		/// </remarks>
		IFabFactorStep InFactorListUses { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links an Eventor to an EventorType that specifies the significance of this point in time. (OutToOne FabEventorType)
		/// </summary>
		/// <remarks>
		///   <para>Links an Eventor to an EventorType that specifies the significance of this point in time.</para>
		///   <para>Type: EventorUsesEventorType</para>
		///   <para>Relation: Uses</para>
		///   <para>Connection: OutToOne</para>
		/// </remarks>
		IFabEventorTypeStep UsesEventorType { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links an Eventor to an EventorPrecision that specifies the level of accuracy given to this point in time. (OutToOne FabEventorPrecision)
		/// </summary>
		/// <remarks>
		///   <para>Links an Eventor to an EventorPrecision that specifies the level of accuracy given to this point in time.</para>
		///   <para>Type: EventorUsesEventorPrecision</para>
		///   <para>Relation: Uses</para>
		///   <para>Connection: OutToOne</para>
		/// </remarks>
		IFabEventorPrecisionStep UsesEventorPrecision { get; }
	
	}
	

	/*================================================================================================*/
	internal class FabEventorStep : TraversalStep<FabEventor>, IFabEventorStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabEventorStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public IFabFactorStep InFactorListUses {
			get {
				var s = new FabFactorStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/InFactorListUses");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabEventorTypeStep UsesEventorType {
			get {
				var s = new FabEventorTypeStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/UsesEventorType");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabEventorPrecisionStep UsesEventorPrecision {
			get {
				var s = new FabEventorPrecisionStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/UsesEventorPrecision");
				return s;
			}
		}
		
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabEventorPrecisionStep : ITraversalStep<FabEventorPrecision>, IFuncAs, IFuncBack, IFuncLimit, IFuncWhereId {
	
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links an Eventor to an EventorPrecision that specifies the level of accuracy given to this point in time. (InFromZeroOrMore FabEventor)
		/// </summary>
		/// <remarks>
		///   <para>Links an Eventor to an EventorPrecision that specifies the level of accuracy given to this point in time.</para>
		///   <para>Type: EventorUsesEventorPrecision</para>
		///   <para>Relation: Uses</para>
		///   <para>Connection: InFromZeroOrMore</para>
		/// </remarks>
		IFabEventorStep InEventorListUses { get; }
	
	}
	

	/*================================================================================================*/
	internal class FabEventorPrecisionStep : TraversalStep<FabEventorPrecision>, IFabEventorPrecisionStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabEventorPrecisionStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public IFabEventorStep InEventorListUses {
			get {
				var s = new FabEventorStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/InEventorListUses");
				return s;
			}
		}
		
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabEventorTypeStep : ITraversalStep<FabEventorType>, IFuncAs, IFuncBack, IFuncLimit, IFuncWhereId {
	
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links an Eventor to an EventorType that specifies the significance of this point in time. (InFromZeroOrMore FabEventor)
		/// </summary>
		/// <remarks>
		///   <para>Links an Eventor to an EventorType that specifies the significance of this point in time.</para>
		///   <para>Type: EventorUsesEventorType</para>
		///   <para>Relation: Uses</para>
		///   <para>Connection: InFromZeroOrMore</para>
		/// </remarks>
		IFabEventorStep InEventorListUses { get; }
	
	}
	

	/*================================================================================================*/
	internal class FabEventorTypeStep : TraversalStep<FabEventorType>, IFabEventorTypeStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabEventorTypeStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public IFabEventorStep InEventorListUses {
			get {
				var s = new FabEventorStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/InEventorListUses");
				return s;
			}
		}
		
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabFactorStep : ITraversalStep<FabFactor>, IFuncAs, IFuncBack, IFuncLimit, IFuncWhereId {
	
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a Member to the Factor that it created. (InFromOne FabMember)
		/// </summary>
		/// <remarks>
		///   <para>Links a Member to the Factor that it created.</para>
		///   <para>Type: MemberCreatesFactor</para>
		///   <para>Relation: Creates</para>
		///   <para>Connection: InFromOne</para>
		/// </remarks>
		IFabMemberStep InMemberCreates { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a Factor to its primary Artifact, which represents the starting point of the Factor's directional Artifact relationship. (OutToOne FabArtifact)
		/// </summary>
		/// <remarks>
		///   <para>Links a Factor to its primary Artifact, which represents the starting point of the Factor's directional Artifact relationship.</para>
		///   <para>Type: FactorUsesPrimaryArtifact</para>
		///   <para>Relation: UsesPrimary</para>
		///   <para>Connection: OutToOne</para>
		/// </remarks>
		IFabArtifactStep UsesPrimaryArtifact { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a Factor to its related Artifact, which represents the ending point of the Factor's directional Artifact relationship. (OutToOne FabArtifact)
		/// </summary>
		/// <remarks>
		///   <para>Links a Factor to its related Artifact, which represents the ending point of the Factor's directional Artifact relationship.</para>
		///   <para>Type: FactorUsesRelatedArtifact</para>
		///   <para>Relation: UsesRelated</para>
		///   <para>Connection: OutToOne</para>
		/// </remarks>
		IFabArtifactStep UsesRelatedArtifact { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a Factor to a FactorAssertion that specifies the type of information and/or level of confidence. (OutToOne FabFactorAssertion)
		/// </summary>
		/// <remarks>
		///   <para>Links a Factor to a FactorAssertion that specifies the type of information and/or level of confidence.</para>
		///   <para>Type: FactorUsesFactorAssertion</para>
		///   <para>Relation: Uses</para>
		///   <para>Connection: OutToOne</para>
		/// </remarks>
		IFabFactorAssertionStep UsesFactorAssertion { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a new Factor to the Factor that it has replaced. (OutToZeroOrOne FabFactor)
		/// </summary>
		/// <remarks>
		///   <para>Links a new Factor to the Factor that it has replaced.</para>
		///   <para>Type: FactorReplacesFactor</para>
		///   <para>Relation: Replaces</para>
		///   <para>Connection: OutToZeroOrOne</para>
		/// </remarks>
		IFabFactorStep ReplacesFactor { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a Factor to its Descriptor Element, which defines the relationship between the primary and related Artifact. (OutToOne FabDescriptor)
		/// </summary>
		/// <remarks>
		///   <para>Links a Factor to its Descriptor Element, which defines the relationship between the primary and related Artifact.</para>
		///   <para>Type: FactorUsesDescriptor</para>
		///   <para>Relation: Uses</para>
		///   <para>Connection: OutToOne</para>
		/// </remarks>
		IFabDescriptorStep UsesDescriptor { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a Factor to its Director Element, which creates a directional pathway between the primary and related Artifacts. (OutToZeroOrOne FabDirector)
		/// </summary>
		/// <remarks>
		///   <para>Links a Factor to its Director Element, which creates a directional pathway between the primary and related Artifacts.</para>
		///   <para>Type: FactorUsesDirector</para>
		///   <para>Relation: Uses</para>
		///   <para>Connection: OutToZeroOrOne</para>
		/// </remarks>
		IFabDirectorStep UsesDirector { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a Factor to its Eventor Element, which applies the concept of time. (OutToZeroOrOne FabEventor)
		/// </summary>
		/// <remarks>
		///   <para>Links a Factor to its Eventor Element, which applies the concept of time.</para>
		///   <para>Type: FactorUsesEventor</para>
		///   <para>Relation: Uses</para>
		///   <para>Connection: OutToZeroOrOne</para>
		/// </remarks>
		IFabEventorStep UsesEventor { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a Factor to its Identor Element, which applies a name or identifier. (OutToZeroOrOne FabIdentor)
		/// </summary>
		/// <remarks>
		///   <para>Links a Factor to its Identor Element, which applies a name or identifier.</para>
		///   <para>Type: FactorUsesIdentor</para>
		///   <para>Relation: Uses</para>
		///   <para>Connection: OutToZeroOrOne</para>
		/// </remarks>
		IFabIdentorStep UsesIdentor { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a Factor to its Locator Element, which provides a geographical or relative position. (OutToZeroOrOne FabLocator)
		/// </summary>
		/// <remarks>
		///   <para>Links a Factor to its Locator Element, which provides a geographical or relative position.</para>
		///   <para>Type: FactorUsesLocator</para>
		///   <para>Relation: Uses</para>
		///   <para>Connection: OutToZeroOrOne</para>
		/// </remarks>
		IFabLocatorStep UsesLocator { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a Factor to its Vector Element, which applies a numeric axis and value. (OutToZeroOrOne FabVector)
		/// </summary>
		/// <remarks>
		///   <para>Links a Factor to its Vector Element, which applies a numeric axis and value.</para>
		///   <para>Type: FactorUsesVector</para>
		///   <para>Relation: Uses</para>
		///   <para>Connection: OutToZeroOrOne</para>
		/// </remarks>
		IFabVectorStep UsesVector { get; }
	
	}
	

	/*================================================================================================*/
	internal class FabFactorStep : TraversalStep<FabFactor>, IFabFactorStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabFactorStep(Traversal pTrav) : base(pTrav) {}
		
		
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
		public IFabArtifactStep UsesPrimaryArtifact {
			get {
				var s = new FabArtifactStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/UsesPrimaryArtifact");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabArtifactStep UsesRelatedArtifact {
			get {
				var s = new FabArtifactStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/UsesRelatedArtifact");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabFactorAssertionStep UsesFactorAssertion {
			get {
				var s = new FabFactorAssertionStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/UsesFactorAssertion");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabFactorStep ReplacesFactor {
			get {
				var s = new FabFactorStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/ReplacesFactor");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabDescriptorStep UsesDescriptor {
			get {
				var s = new FabDescriptorStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/UsesDescriptor");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabDirectorStep UsesDirector {
			get {
				var s = new FabDirectorStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/UsesDirector");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabEventorStep UsesEventor {
			get {
				var s = new FabEventorStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/UsesEventor");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabIdentorStep UsesIdentor {
			get {
				var s = new FabIdentorStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/UsesIdentor");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabLocatorStep UsesLocator {
			get {
				var s = new FabLocatorStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/UsesLocator");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabVectorStep UsesVector {
			get {
				var s = new FabVectorStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/UsesVector");
				return s;
			}
		}
		
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabFactorAssertionStep : ITraversalStep<FabFactorAssertion>, IFuncAs, IFuncBack, IFuncLimit, IFuncWhereId {
	
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a Factor to a FactorAssertion that specifies the type of information and/or level of confidence. (InFromZeroOrMore FabFactor)
		/// </summary>
		/// <remarks>
		///   <para>Links a Factor to a FactorAssertion that specifies the type of information and/or level of confidence.</para>
		///   <para>Type: FactorUsesFactorAssertion</para>
		///   <para>Relation: Uses</para>
		///   <para>Connection: InFromZeroOrMore</para>
		/// </remarks>
		IFabFactorStep InFactorListUses { get; }
	
	}
	

	/*================================================================================================*/
	internal class FabFactorAssertionStep : TraversalStep<FabFactorAssertion>, IFabFactorAssertionStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabFactorAssertionStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public IFabFactorStep InFactorListUses {
			get {
				var s = new FabFactorStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/InFactorListUses");
				return s;
			}
		}
		
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabFactorElementNodeStep : ITraversalStep<FabFactorElementNode>, IFuncAs, IFuncBack, IFuncLimit, IFuncWhereId {
	
		
		////////////////////////////////////////////////////////////////////////////////////////////////
	}
	

	/*================================================================================================*/
	internal class FabFactorElementNodeStep : TraversalStep<FabFactorElementNode>, IFabFactorElementNodeStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabFactorElementNodeStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabHomeStep : ITraversalStep<FabHome> {
	
		
		////////////////////////////////////////////////////////////////////////////////////////////////
	}
	

	/*================================================================================================*/
	internal class FabHomeStep : TraversalStep<FabHome>, IFabHomeStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabHomeStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabIdentorStep : ITraversalStep<FabIdentor>, IFuncAs, IFuncBack, IFuncLimit, IFuncWhereId {
	
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a Factor to its Identor Element, which applies a name or identifier. (InFromOneOrMore FabFactor)
		/// </summary>
		/// <remarks>
		///   <para>Links a Factor to its Identor Element, which applies a name or identifier.</para>
		///   <para>Type: FactorUsesIdentor</para>
		///   <para>Relation: Uses</para>
		///   <para>Connection: InFromOneOrMore</para>
		/// </remarks>
		IFabFactorStep InFactorListUses { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links an Identor to an IdentorType that specifies the value's purpose or intent. (OutToOne FabIdentorType)
		/// </summary>
		/// <remarks>
		///   <para>Links an Identor to an IdentorType that specifies the value's purpose or intent.</para>
		///   <para>Type: IdentorUsesIdentorType</para>
		///   <para>Relation: Uses</para>
		///   <para>Connection: OutToOne</para>
		/// </remarks>
		IFabIdentorTypeStep UsesIdentorType { get; }
	
	}
	

	/*================================================================================================*/
	internal class FabIdentorStep : TraversalStep<FabIdentor>, IFabIdentorStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabIdentorStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public IFabFactorStep InFactorListUses {
			get {
				var s = new FabFactorStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/InFactorListUses");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabIdentorTypeStep UsesIdentorType {
			get {
				var s = new FabIdentorTypeStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/UsesIdentorType");
				return s;
			}
		}
		
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabIdentorTypeStep : ITraversalStep<FabIdentorType>, IFuncAs, IFuncBack, IFuncLimit, IFuncWhereId {
	
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links an Identor to an IdentorType that specifies the value's purpose or intent. (InFromZeroOrMore FabIdentor)
		/// </summary>
		/// <remarks>
		///   <para>Links an Identor to an IdentorType that specifies the value's purpose or intent.</para>
		///   <para>Type: IdentorUsesIdentorType</para>
		///   <para>Relation: Uses</para>
		///   <para>Connection: InFromZeroOrMore</para>
		/// </remarks>
		IFabIdentorStep InIdentorListUses { get; }
	
	}
	

	/*================================================================================================*/
	internal class FabIdentorTypeStep : TraversalStep<FabIdentorType>, IFabIdentorTypeStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabIdentorTypeStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public IFabIdentorStep InIdentorListUses {
			get {
				var s = new FabIdentorStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/InIdentorListUses");
				return s;
			}
		}
		
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabInstanceStep : ITraversalStep<FabInstance>, IFuncAs, IFuncBack, IFuncLimit, IFuncWhereId {
	
		
		////////////////////////////////////////////////////////////////////////////////////////////////
	}
	

	/*================================================================================================*/
	internal class FabInstanceStep : TraversalStep<FabInstance>, IFabInstanceStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabInstanceStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabLocatorStep : ITraversalStep<FabLocator>, IFuncAs, IFuncBack, IFuncLimit, IFuncWhereId {
	
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a Factor to its Locator Element, which provides a geographical or relative position. (InFromOneOrMore FabFactor)
		/// </summary>
		/// <remarks>
		///   <para>Links a Factor to its Locator Element, which provides a geographical or relative position.</para>
		///   <para>Type: FactorUsesLocator</para>
		///   <para>Relation: Uses</para>
		///   <para>Connection: InFromOneOrMore</para>
		/// </remarks>
		IFabFactorStep InFactorListUses { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a Locator to a LocatorType that specifies the spatial context of the coordinate. (OutToOne FabLocatorType)
		/// </summary>
		/// <remarks>
		///   <para>Links a Locator to a LocatorType that specifies the spatial context of the coordinate.</para>
		///   <para>Type: LocatorUsesLocatorType</para>
		///   <para>Relation: Uses</para>
		///   <para>Connection: OutToOne</para>
		/// </remarks>
		IFabLocatorTypeStep UsesLocatorType { get; }
	
	}
	

	/*================================================================================================*/
	internal class FabLocatorStep : TraversalStep<FabLocator>, IFabLocatorStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabLocatorStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public IFabFactorStep InFactorListUses {
			get {
				var s = new FabFactorStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/InFactorListUses");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabLocatorTypeStep UsesLocatorType {
			get {
				var s = new FabLocatorTypeStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/UsesLocatorType");
				return s;
			}
		}
		
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabLocatorTypeStep : ITraversalStep<FabLocatorType>, IFuncAs, IFuncBack, IFuncLimit, IFuncWhereId {
	
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a Locator to a LocatorType that specifies the spatial context of the coordinate. (InFromZeroOrMore FabLocator)
		/// </summary>
		/// <remarks>
		///   <para>Links a Locator to a LocatorType that specifies the spatial context of the coordinate.</para>
		///   <para>Type: LocatorUsesLocatorType</para>
		///   <para>Relation: Uses</para>
		///   <para>Connection: InFromZeroOrMore</para>
		/// </remarks>
		IFabLocatorStep InLocatorListUses { get; }
	
	}
	

	/*================================================================================================*/
	internal class FabLocatorTypeStep : TraversalStep<FabLocatorType>, IFabLocatorTypeStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabLocatorTypeStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public IFabLocatorStep InLocatorListUses {
			get {
				var s = new FabLocatorStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/InLocatorListUses");
				return s;
			}
		}
		
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabMemberStep : ITraversalStep<FabMember>, IFuncAs, IFuncBack, IFuncLimit, IFuncWhereId {
	
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links an App to a particular Member. (InFromOne FabApp)
		/// </summary>
		/// <remarks>
		///   <para>Links an App to a particular Member.</para>
		///   <para>Type: AppDefinesMember</para>
		///   <para>Relation: Defines</para>
		///   <para>Connection: InFromOne</para>
		/// </remarks>
		IFabAppStep InAppDefines { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a Member to its active MemberTypeAssign. (OutToOne FabMemberTypeAssign)
		/// </summary>
		/// <remarks>
		///   <para>Links a Member to its active MemberTypeAssign.</para>
		///   <para>Type: MemberHasMemberTypeAssign</para>
		///   <para>Relation: Has</para>
		///   <para>Connection: OutToOne</para>
		/// </remarks>
		IFabMemberTypeAssignStep HasMemberTypeAssign { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a Member to a historical MemberTypeAssign. (OutToZeroOrMore FabMemberTypeAssign)
		/// </summary>
		/// <remarks>
		///   <para>Links a Member to a historical MemberTypeAssign.</para>
		///   <para>Type: MemberHasHistoricMemberTypeAssign</para>
		///   <para>Relation: HasHistoric</para>
		///   <para>Connection: OutToZeroOrMore</para>
		/// </remarks>
		IFabMemberTypeAssignStep HasHistoricMemberTypeAssignList { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a Member to the Artifact that it created. (OutToZeroOrMore FabArtifact)
		/// </summary>
		/// <remarks>
		///   <para>Links a Member to the Artifact that it created.</para>
		///   <para>Type: MemberCreatesArtifact</para>
		///   <para>Relation: Creates</para>
		///   <para>Connection: OutToZeroOrMore</para>
		/// </remarks>
		IFabArtifactStep CreatesArtifactList { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a Member to the MemberTypeAssign that it created. (OutToZeroOrMore FabMemberTypeAssign)
		/// </summary>
		/// <remarks>
		///   <para>Links a Member to the MemberTypeAssign that it created.</para>
		///   <para>Type: MemberCreatesMemberTypeAssign</para>
		///   <para>Relation: Creates</para>
		///   <para>Connection: OutToZeroOrMore</para>
		/// </remarks>
		IFabMemberTypeAssignStep CreatesMemberTypeAssignList { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a Member to the Factor that it created. (OutToZeroOrMore FabFactor)
		/// </summary>
		/// <remarks>
		///   <para>Links a Member to the Factor that it created.</para>
		///   <para>Type: MemberCreatesFactor</para>
		///   <para>Relation: Creates</para>
		///   <para>Connection: OutToZeroOrMore</para>
		/// </remarks>
		IFabFactorStep CreatesFactorList { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a User to a particular Member. (InFromOne FabUser)
		/// </summary>
		/// <remarks>
		///   <para>Links a User to a particular Member.</para>
		///   <para>Type: UserDefinesMember</para>
		///   <para>Relation: Defines</para>
		///   <para>Connection: InFromOne</para>
		/// </remarks>
		IFabUserStep InUserDefines { get; }
	
	}
	

	/*================================================================================================*/
	internal class FabMemberStep : TraversalStep<FabMember>, IFabMemberStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabMemberStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public IFabAppStep InAppDefines {
			get {
				var s = new FabAppStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/InAppDefines");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabMemberTypeAssignStep HasMemberTypeAssign {
			get {
				var s = new FabMemberTypeAssignStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/HasMemberTypeAssign");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabMemberTypeAssignStep HasHistoricMemberTypeAssignList {
			get {
				var s = new FabMemberTypeAssignStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/HasHistoricMemberTypeAssignList");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabArtifactStep CreatesArtifactList {
			get {
				var s = new FabArtifactStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/CreatesArtifactList");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabMemberTypeAssignStep CreatesMemberTypeAssignList {
			get {
				var s = new FabMemberTypeAssignStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/CreatesMemberTypeAssignList");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabFactorStep CreatesFactorList {
			get {
				var s = new FabFactorStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/CreatesFactorList");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabUserStep InUserDefines {
			get {
				var s = new FabUserStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/InUserDefines");
				return s;
			}
		}
		
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabMemberTypeStep : ITraversalStep<FabMemberType>, IFuncAs, IFuncBack, IFuncLimit, IFuncWhereId {
	
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a MemberTypeAssign to a MemberType that specifies the Member's state and/or access privileges. (InFromZeroOrMore FabMemberTypeAssign)
		/// </summary>
		/// <remarks>
		///   <para>Links a MemberTypeAssign to a MemberType that specifies the Member's state and/or access privileges.</para>
		///   <para>Type: MemberTypeAssignUsesMemberType</para>
		///   <para>Relation: Uses</para>
		///   <para>Connection: InFromZeroOrMore</para>
		/// </remarks>
		IFabMemberTypeAssignStep InMemberTypeAssignListUses { get; }
	
	}
	

	/*================================================================================================*/
	internal class FabMemberTypeStep : TraversalStep<FabMemberType>, IFabMemberTypeStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabMemberTypeStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public IFabMemberTypeAssignStep InMemberTypeAssignListUses {
			get {
				var s = new FabMemberTypeAssignStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/InMemberTypeAssignListUses");
				return s;
			}
		}
		
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabMemberTypeAssignStep : ITraversalStep<FabMemberTypeAssign>, IFuncAs, IFuncBack, IFuncLimit, IFuncWhereId {
	
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a Member to its active MemberTypeAssign. (InFromOne FabMember)
		/// </summary>
		/// <remarks>
		///   <para>Links a Member to its active MemberTypeAssign.</para>
		///   <para>Type: MemberHasMemberTypeAssign</para>
		///   <para>Relation: Has</para>
		///   <para>Connection: InFromOne</para>
		/// </remarks>
		IFabMemberStep InMemberHas { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a Member to a historical MemberTypeAssign. (InFromOne FabMember)
		/// </summary>
		/// <remarks>
		///   <para>Links a Member to a historical MemberTypeAssign.</para>
		///   <para>Type: MemberHasHistoricMemberTypeAssign</para>
		///   <para>Relation: HasHistoric</para>
		///   <para>Connection: InFromOne</para>
		/// </remarks>
		IFabMemberStep InMemberHasHistoric { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a Member to the MemberTypeAssign that it created. (InFromOne FabMember)
		/// </summary>
		/// <remarks>
		///   <para>Links a Member to the MemberTypeAssign that it created.</para>
		///   <para>Type: MemberCreatesMemberTypeAssign</para>
		///   <para>Relation: Creates</para>
		///   <para>Connection: InFromOne</para>
		/// </remarks>
		IFabMemberStep InMemberCreates { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a MemberTypeAssign to a MemberType that specifies the Member's state and/or access privileges. (OutToOne FabMemberType)
		/// </summary>
		/// <remarks>
		///   <para>Links a MemberTypeAssign to a MemberType that specifies the Member's state and/or access privileges.</para>
		///   <para>Type: MemberTypeAssignUsesMemberType</para>
		///   <para>Relation: Uses</para>
		///   <para>Connection: OutToOne</para>
		/// </remarks>
		IFabMemberTypeStep UsesMemberType { get; }
	
	}
	

	/*================================================================================================*/
	internal class FabMemberTypeAssignStep : TraversalStep<FabMemberTypeAssign>, IFabMemberTypeAssignStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabMemberTypeAssignStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public IFabMemberStep InMemberHas {
			get {
				var s = new FabMemberStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/InMemberHas");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabMemberStep InMemberHasHistoric {
			get {
				var s = new FabMemberStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/InMemberHasHistoric");
				return s;
			}
		}
		
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
		public IFabMemberTypeStep UsesMemberType {
			get {
				var s = new FabMemberTypeStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/UsesMemberType");
				return s;
			}
		}
		
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabMetaTimeStep : ITraversalStep<FabMetaTime> {
	
		
		////////////////////////////////////////////////////////////////////////////////////////////////
	}
	

	/*================================================================================================*/
	internal class FabMetaTimeStep : TraversalStep<FabMetaTime>, IFabMetaTimeStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabMetaTimeStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabMetaVersionStep : ITraversalStep<FabMetaVersion> {
	
		
		////////////////////////////////////////////////////////////////////////////////////////////////
	}
	

	/*================================================================================================*/
	internal class FabMetaVersionStep : TraversalStep<FabMetaVersion>, IFabMetaVersionStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabMetaVersionStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabNodeStep : ITraversalStep<FabNode> {
	
		
		////////////////////////////////////////////////////////////////////////////////////////////////
	}
	

	/*================================================================================================*/
	internal class FabNodeStep : TraversalStep<FabNode>, IFabNodeStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabNodeStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabNodeForActionStep : ITraversalStep<FabNodeForAction>, IFuncAs, IFuncBack, IFuncLimit, IFuncWhereId {
	
		
		////////////////////////////////////////////////////////////////////////////////////////////////
	}
	

	/*================================================================================================*/
	internal class FabNodeForActionStep : TraversalStep<FabNodeForAction>, IFabNodeForActionStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabNodeForActionStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabNodeForTypeStep : ITraversalStep<FabNodeForType>, IFuncAs, IFuncBack, IFuncLimit, IFuncWhereId {
	
		
		////////////////////////////////////////////////////////////////////////////////////////////////
	}
	

	/*================================================================================================*/
	internal class FabNodeForTypeStep : TraversalStep<FabNodeForType>, IFabNodeForTypeStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabNodeForTypeStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabOauthAccessStep : ITraversalStep<FabOauthAccess> {
	
		
		////////////////////////////////////////////////////////////////////////////////////////////////
	}
	

	/*================================================================================================*/
	internal class FabOauthAccessStep : TraversalStep<FabOauthAccess>, IFabOauthAccessStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabOauthAccessStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabOauthErrorStep : ITraversalStep<FabOauthError> {
	
		
		////////////////////////////////////////////////////////////////////////////////////////////////
	}
	

	/*================================================================================================*/
	internal class FabOauthErrorStep : TraversalStep<FabOauthError>, IFabOauthErrorStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabOauthErrorStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabOauthLoginStep : ITraversalStep<FabOauthLogin> {
	
		
		////////////////////////////////////////////////////////////////////////////////////////////////
	}
	

	/*================================================================================================*/
	internal class FabOauthLoginStep : TraversalStep<FabOauthLogin>, IFabOauthLoginStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabOauthLoginStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabOauthLogoutStep : ITraversalStep<FabOauthLogout> {
	
		
		////////////////////////////////////////////////////////////////////////////////////////////////
	}
	

	/*================================================================================================*/
	internal class FabOauthLogoutStep : TraversalStep<FabOauthLogout>, IFabOauthLogoutStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabOauthLogoutStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabObjectStep : ITraversalStep<FabObject> {
	
		
		////////////////////////////////////////////////////////////////////////////////////////////////
	}
	

	/*================================================================================================*/
	internal class FabObjectStep : TraversalStep<FabObject>, IFabObjectStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabObjectStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabRootStep : ITraversalStep<FabRoot> {
	
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links the Root node to an App. (InFromOne FabApp)
		/// </summary>
		/// <remarks>
		///   <para>Links the Root node to an App.</para>
		///   <para>Type: RootContainsApp</para>
		///   <para>Relation: Contains</para>
		///   <para>Connection: InFromOne</para>
		/// </remarks>
		IFabAppStep ContainsAppList { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links the Root node to a Class. (InFromOne FabClass)
		/// </summary>
		/// <remarks>
		///   <para>Links the Root node to a Class.</para>
		///   <para>Type: RootContainsClass</para>
		///   <para>Relation: Contains</para>
		///   <para>Connection: InFromOne</para>
		/// </remarks>
		IFabClassStep ContainsClassList { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links the Root node to an Instance. (InFromOne FabInstance)
		/// </summary>
		/// <remarks>
		///   <para>Links the Root node to an Instance.</para>
		///   <para>Type: RootContainsInstance</para>
		///   <para>Relation: Contains</para>
		///   <para>Connection: InFromOne</para>
		/// </remarks>
		IFabInstanceStep ContainsInstanceList { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links the Root node to a Member. (InFromOne FabMember)
		/// </summary>
		/// <remarks>
		///   <para>Links the Root node to a Member.</para>
		///   <para>Type: RootContainsMember</para>
		///   <para>Relation: Contains</para>
		///   <para>Connection: InFromOne</para>
		/// </remarks>
		IFabMemberStep ContainsMemberList { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links the Root node to a MemberType. (InFromOne FabMemberType)
		/// </summary>
		/// <remarks>
		///   <para>Links the Root node to a MemberType.</para>
		///   <para>Type: RootContainsMemberType</para>
		///   <para>Relation: Contains</para>
		///   <para>Connection: InFromOne</para>
		/// </remarks>
		IFabMemberTypeStep ContainsMemberTypeList { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links the Root node to a MemberTypeAssign. (InFromOne FabMemberTypeAssign)
		/// </summary>
		/// <remarks>
		///   <para>Links the Root node to a MemberTypeAssign.</para>
		///   <para>Type: RootContainsMemberTypeAssign</para>
		///   <para>Relation: Contains</para>
		///   <para>Connection: InFromOne</para>
		/// </remarks>
		IFabMemberTypeAssignStep ContainsMemberTypeAssignList { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links the Root node to a Url. (InFromOne FabUrl)
		/// </summary>
		/// <remarks>
		///   <para>Links the Root node to a Url.</para>
		///   <para>Type: RootContainsUrl</para>
		///   <para>Relation: Contains</para>
		///   <para>Connection: InFromOne</para>
		/// </remarks>
		IFabUrlStep ContainsUrlList { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links the Root node to a User. (InFromOne FabUser)
		/// </summary>
		/// <remarks>
		///   <para>Links the Root node to a User.</para>
		///   <para>Type: RootContainsUser</para>
		///   <para>Relation: Contains</para>
		///   <para>Connection: InFromOne</para>
		/// </remarks>
		IFabUserStep ContainsUserList { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links the Root node to a Factor. (InFromOne FabFactor)
		/// </summary>
		/// <remarks>
		///   <para>Links the Root node to a Factor.</para>
		///   <para>Type: RootContainsFactor</para>
		///   <para>Relation: Contains</para>
		///   <para>Connection: InFromOne</para>
		/// </remarks>
		IFabFactorStep ContainsFactorList { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links the Root node to a FactorAssertion. (InFromOne FabFactorAssertion)
		/// </summary>
		/// <remarks>
		///   <para>Links the Root node to a FactorAssertion.</para>
		///   <para>Type: RootContainsFactorAssertion</para>
		///   <para>Relation: Contains</para>
		///   <para>Connection: InFromOne</para>
		/// </remarks>
		IFabFactorAssertionStep ContainsFactorAssertionList { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links the Root node to a Descriptor. (InFromOne FabDescriptor)
		/// </summary>
		/// <remarks>
		///   <para>Links the Root node to a Descriptor.</para>
		///   <para>Type: RootContainsDescriptor</para>
		///   <para>Relation: Contains</para>
		///   <para>Connection: InFromOne</para>
		/// </remarks>
		IFabDescriptorStep ContainsDescriptorList { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links the Root node to a DescriptorType. (InFromOne FabDescriptorType)
		/// </summary>
		/// <remarks>
		///   <para>Links the Root node to a DescriptorType.</para>
		///   <para>Type: RootContainsDescriptorType</para>
		///   <para>Relation: Contains</para>
		///   <para>Connection: InFromOne</para>
		/// </remarks>
		IFabDescriptorTypeStep ContainsDescriptorTypeList { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links the Root node to a Director. (InFromOne FabDirector)
		/// </summary>
		/// <remarks>
		///   <para>Links the Root node to a Director.</para>
		///   <para>Type: RootContainsDirector</para>
		///   <para>Relation: Contains</para>
		///   <para>Connection: InFromOne</para>
		/// </remarks>
		IFabDirectorStep ContainsDirectorList { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links the Root node to a DirectorType. (InFromOne FabDirectorType)
		/// </summary>
		/// <remarks>
		///   <para>Links the Root node to a DirectorType.</para>
		///   <para>Type: RootContainsDirectorType</para>
		///   <para>Relation: Contains</para>
		///   <para>Connection: InFromOne</para>
		/// </remarks>
		IFabDirectorTypeStep ContainsDirectorTypeList { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links the Root node to a DirectorAction. (InFromOne FabDirectorAction)
		/// </summary>
		/// <remarks>
		///   <para>Links the Root node to a DirectorAction.</para>
		///   <para>Type: RootContainsDirectorAction</para>
		///   <para>Relation: Contains</para>
		///   <para>Connection: InFromOne</para>
		/// </remarks>
		IFabDirectorActionStep ContainsDirectorActionList { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links the Root node to an Eventor. (InFromOne FabEventor)
		/// </summary>
		/// <remarks>
		///   <para>Links the Root node to an Eventor.</para>
		///   <para>Type: RootContainsEventor</para>
		///   <para>Relation: Contains</para>
		///   <para>Connection: InFromOne</para>
		/// </remarks>
		IFabEventorStep ContainsEventorList { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links the Root node to an EventorType. (InFromOne FabEventorType)
		/// </summary>
		/// <remarks>
		///   <para>Links the Root node to an EventorType.</para>
		///   <para>Type: RootContainsEventorType</para>
		///   <para>Relation: Contains</para>
		///   <para>Connection: InFromOne</para>
		/// </remarks>
		IFabEventorTypeStep ContainsEventorTypeList { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links the Root node to an EventorPrecision. (InFromOne FabEventorPrecision)
		/// </summary>
		/// <remarks>
		///   <para>Links the Root node to an EventorPrecision.</para>
		///   <para>Type: RootContainsEventorPrecision</para>
		///   <para>Relation: Contains</para>
		///   <para>Connection: InFromOne</para>
		/// </remarks>
		IFabEventorPrecisionStep ContainsEventorPrecisionList { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links the Root node to an Identor. (InFromOne FabIdentor)
		/// </summary>
		/// <remarks>
		///   <para>Links the Root node to an Identor.</para>
		///   <para>Type: RootContainsIdentor</para>
		///   <para>Relation: Contains</para>
		///   <para>Connection: InFromOne</para>
		/// </remarks>
		IFabIdentorStep ContainsIdentorList { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links the Root node to an IdentorType. (InFromOne FabIdentorType)
		/// </summary>
		/// <remarks>
		///   <para>Links the Root node to an IdentorType.</para>
		///   <para>Type: RootContainsIdentorType</para>
		///   <para>Relation: Contains</para>
		///   <para>Connection: InFromOne</para>
		/// </remarks>
		IFabIdentorTypeStep ContainsIdentorTypeList { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links the Root node to a Locator. (InFromOne FabLocator)
		/// </summary>
		/// <remarks>
		///   <para>Links the Root node to a Locator.</para>
		///   <para>Type: RootContainsLocator</para>
		///   <para>Relation: Contains</para>
		///   <para>Connection: InFromOne</para>
		/// </remarks>
		IFabLocatorStep ContainsLocatorList { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links the Root node to a LocatorType. (InFromOne FabLocatorType)
		/// </summary>
		/// <remarks>
		///   <para>Links the Root node to a LocatorType.</para>
		///   <para>Type: RootContainsLocatorType</para>
		///   <para>Relation: Contains</para>
		///   <para>Connection: InFromOne</para>
		/// </remarks>
		IFabLocatorTypeStep ContainsLocatorTypeList { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links the Root node to a Vector. (InFromOne FabVector)
		/// </summary>
		/// <remarks>
		///   <para>Links the Root node to a Vector.</para>
		///   <para>Type: RootContainsVector</para>
		///   <para>Relation: Contains</para>
		///   <para>Connection: InFromOne</para>
		/// </remarks>
		IFabVectorStep ContainsVectorList { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links the Root node to a VectorType. (InFromOne FabVectorType)
		/// </summary>
		/// <remarks>
		///   <para>Links the Root node to a VectorType.</para>
		///   <para>Type: RootContainsVectorType</para>
		///   <para>Relation: Contains</para>
		///   <para>Connection: InFromOne</para>
		/// </remarks>
		IFabVectorTypeStep ContainsVectorTypeList { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links the Root node to a VectorRange. (InFromOne FabVectorRange)
		/// </summary>
		/// <remarks>
		///   <para>Links the Root node to a VectorRange.</para>
		///   <para>Type: RootContainsVectorRange</para>
		///   <para>Relation: Contains</para>
		///   <para>Connection: InFromOne</para>
		/// </remarks>
		IFabVectorRangeStep ContainsVectorRangeList { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links the Root node to a VectorRangeLevel. (InFromOne FabVectorRangeLevel)
		/// </summary>
		/// <remarks>
		///   <para>Links the Root node to a VectorRangeLevel.</para>
		///   <para>Type: RootContainsVectorRangeLevel</para>
		///   <para>Relation: Contains</para>
		///   <para>Connection: InFromOne</para>
		/// </remarks>
		IFabVectorRangeLevelStep ContainsVectorRangeLevelList { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links the Root node to a VectorUnit. (InFromOne FabVectorUnit)
		/// </summary>
		/// <remarks>
		///   <para>Links the Root node to a VectorUnit.</para>
		///   <para>Type: RootContainsVectorUnit</para>
		///   <para>Relation: Contains</para>
		///   <para>Connection: InFromOne</para>
		/// </remarks>
		IFabVectorUnitStep ContainsVectorUnitList { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links the Root node to a VectorUnitPrefix. (InFromOne FabVectorUnitPrefix)
		/// </summary>
		/// <remarks>
		///   <para>Links the Root node to a VectorUnitPrefix.</para>
		///   <para>Type: RootContainsVectorUnitPrefix</para>
		///   <para>Relation: Contains</para>
		///   <para>Connection: InFromOne</para>
		/// </remarks>
		IFabVectorUnitPrefixStep ContainsVectorUnitPrefixList { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links the Root node to a VectorUnitDerived. (InFromOne FabVectorUnitDerived)
		/// </summary>
		/// <remarks>
		///   <para>Links the Root node to a VectorUnitDerived.</para>
		///   <para>Type: RootContainsVectorUnitDerived</para>
		///   <para>Relation: Contains</para>
		///   <para>Connection: InFromOne</para>
		/// </remarks>
		IFabVectorUnitDerivedStep ContainsVectorUnitDerivedList { get; }
	
	}
	

	/*================================================================================================*/
	internal class FabRootStep : TraversalStep<FabRoot>, IFabRootStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabRootStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public IFabAppStep ContainsAppList {
			get {
				var s = new FabAppStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/ContainsAppList");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabClassStep ContainsClassList {
			get {
				var s = new FabClassStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/ContainsClassList");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabInstanceStep ContainsInstanceList {
			get {
				var s = new FabInstanceStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/ContainsInstanceList");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabMemberStep ContainsMemberList {
			get {
				var s = new FabMemberStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/ContainsMemberList");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabMemberTypeStep ContainsMemberTypeList {
			get {
				var s = new FabMemberTypeStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/ContainsMemberTypeList");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabMemberTypeAssignStep ContainsMemberTypeAssignList {
			get {
				var s = new FabMemberTypeAssignStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/ContainsMemberTypeAssignList");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabUrlStep ContainsUrlList {
			get {
				var s = new FabUrlStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/ContainsUrlList");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabUserStep ContainsUserList {
			get {
				var s = new FabUserStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/ContainsUserList");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabFactorStep ContainsFactorList {
			get {
				var s = new FabFactorStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/ContainsFactorList");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabFactorAssertionStep ContainsFactorAssertionList {
			get {
				var s = new FabFactorAssertionStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/ContainsFactorAssertionList");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabDescriptorStep ContainsDescriptorList {
			get {
				var s = new FabDescriptorStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/ContainsDescriptorList");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabDescriptorTypeStep ContainsDescriptorTypeList {
			get {
				var s = new FabDescriptorTypeStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/ContainsDescriptorTypeList");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabDirectorStep ContainsDirectorList {
			get {
				var s = new FabDirectorStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/ContainsDirectorList");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabDirectorTypeStep ContainsDirectorTypeList {
			get {
				var s = new FabDirectorTypeStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/ContainsDirectorTypeList");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabDirectorActionStep ContainsDirectorActionList {
			get {
				var s = new FabDirectorActionStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/ContainsDirectorActionList");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabEventorStep ContainsEventorList {
			get {
				var s = new FabEventorStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/ContainsEventorList");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabEventorTypeStep ContainsEventorTypeList {
			get {
				var s = new FabEventorTypeStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/ContainsEventorTypeList");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabEventorPrecisionStep ContainsEventorPrecisionList {
			get {
				var s = new FabEventorPrecisionStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/ContainsEventorPrecisionList");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabIdentorStep ContainsIdentorList {
			get {
				var s = new FabIdentorStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/ContainsIdentorList");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabIdentorTypeStep ContainsIdentorTypeList {
			get {
				var s = new FabIdentorTypeStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/ContainsIdentorTypeList");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabLocatorStep ContainsLocatorList {
			get {
				var s = new FabLocatorStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/ContainsLocatorList");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabLocatorTypeStep ContainsLocatorTypeList {
			get {
				var s = new FabLocatorTypeStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/ContainsLocatorTypeList");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabVectorStep ContainsVectorList {
			get {
				var s = new FabVectorStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/ContainsVectorList");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabVectorTypeStep ContainsVectorTypeList {
			get {
				var s = new FabVectorTypeStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/ContainsVectorTypeList");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabVectorRangeStep ContainsVectorRangeList {
			get {
				var s = new FabVectorRangeStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/ContainsVectorRangeList");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabVectorRangeLevelStep ContainsVectorRangeLevelList {
			get {
				var s = new FabVectorRangeLevelStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/ContainsVectorRangeLevelList");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabVectorUnitStep ContainsVectorUnitList {
			get {
				var s = new FabVectorUnitStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/ContainsVectorUnitList");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabVectorUnitPrefixStep ContainsVectorUnitPrefixList {
			get {
				var s = new FabVectorUnitPrefixStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/ContainsVectorUnitPrefixList");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabVectorUnitDerivedStep ContainsVectorUnitDerivedList {
			get {
				var s = new FabVectorUnitDerivedStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/ContainsVectorUnitDerivedList");
				return s;
			}
		}
		
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabServiceStep : ITraversalStep<FabService> {
	
		
		////////////////////////////////////////////////////////////////////////////////////////////////
	}
	

	/*================================================================================================*/
	internal class FabServiceStep : TraversalStep<FabService>, IFabServiceStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabServiceStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabServiceOperationStep : ITraversalStep<FabServiceOperation> {
	
		
		////////////////////////////////////////////////////////////////////////////////////////////////
	}
	

	/*================================================================================================*/
	internal class FabServiceOperationStep : TraversalStep<FabServiceOperation>, IFabServiceOperationStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabServiceOperationStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabStepLinkStep : ITraversalStep<FabStepLink> {
	
		
		////////////////////////////////////////////////////////////////////////////////////////////////
	}
	

	/*================================================================================================*/
	internal class FabStepLinkStep : TraversalStep<FabStepLink>, IFabStepLinkStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabStepLinkStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabUrlStep : ITraversalStep<FabUrl>, IFuncAs, IFuncBack, IFuncLimit, IFuncWhereId {
	
		
		////////////////////////////////////////////////////////////////////////////////////////////////
	}
	

	/*================================================================================================*/
	internal class FabUrlStep : TraversalStep<FabUrl>, IFabUrlStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabUrlStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabUserStep : ITraversalStep<FabUser>, IFuncAs, IFuncBack, IFuncLimit, IFuncWhereId {
	
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a User to a particular Member. (OutToOneOrMore FabMember)
		/// </summary>
		/// <remarks>
		///   <para>Links a User to a particular Member.</para>
		///   <para>Type: UserDefinesMember</para>
		///   <para>Relation: Defines</para>
		///   <para>Connection: OutToOneOrMore</para>
		/// </remarks>
		IFabMemberStep DefinesMemberList { get; }
	
	}
	

	/*================================================================================================*/
	internal class FabUserStep : TraversalStep<FabUser>, IFabUserStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabUserStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public IFabMemberStep DefinesMemberList {
			get {
				var s = new FabMemberStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/DefinesMemberList");
				return s;
			}
		}
		
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabVectorStep : ITraversalStep<FabVector>, IFuncAs, IFuncBack, IFuncLimit, IFuncWhereId {
	
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a Factor to its Vector Element, which applies a numeric axis and value. (InFromOneOrMore FabFactor)
		/// </summary>
		/// <remarks>
		///   <para>Links a Factor to its Vector Element, which applies a numeric axis and value.</para>
		///   <para>Type: FactorUsesVector</para>
		///   <para>Relation: Uses</para>
		///   <para>Connection: InFromOneOrMore</para>
		/// </remarks>
		IFabFactorStep InFactorListUses { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a Vector to an Artifact that 'labels' its value's axis. (OutToOne FabArtifact)
		/// </summary>
		/// <remarks>
		///   <para>Links a Vector to an Artifact that 'labels' its value's axis.</para>
		///   <para>Type: VectorUsesAxisArtifact</para>
		///   <para>Relation: UsesAxis</para>
		///   <para>Connection: OutToOne</para>
		/// </remarks>
		IFabArtifactStep UsesAxisArtifact { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a Vector to a VectorType that specifies its value's boundaries and context. (OutToOne FabVectorType)
		/// </summary>
		/// <remarks>
		///   <para>Links a Vector to a VectorType that specifies its value's boundaries and context.</para>
		///   <para>Type: VectorUsesVectorType</para>
		///   <para>Relation: Uses</para>
		///   <para>Connection: OutToOne</para>
		/// </remarks>
		IFabVectorTypeStep UsesVectorType { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a Vector to a VectorUnit that specifies its value's unit of measurement. (OutToOne FabVectorUnit)
		/// </summary>
		/// <remarks>
		///   <para>Links a Vector to a VectorUnit that specifies its value's unit of measurement.</para>
		///   <para>Type: VectorUsesVectorUnit</para>
		///   <para>Relation: Uses</para>
		///   <para>Connection: OutToOne</para>
		/// </remarks>
		IFabVectorUnitStep UsesVectorUnit { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a Vector to a VectorUnitPrefix that specifies its value's order of magnitude. (OutToOne FabVectorUnitPrefix)
		/// </summary>
		/// <remarks>
		///   <para>Links a Vector to a VectorUnitPrefix that specifies its value's order of magnitude.</para>
		///   <para>Type: VectorUsesVectorUnitPrefix</para>
		///   <para>Relation: Uses</para>
		///   <para>Connection: OutToOne</para>
		/// </remarks>
		IFabVectorUnitPrefixStep UsesVectorUnitPrefix { get; }
	
	}
	

	/*================================================================================================*/
	internal class FabVectorStep : TraversalStep<FabVector>, IFabVectorStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabVectorStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public IFabFactorStep InFactorListUses {
			get {
				var s = new FabFactorStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/InFactorListUses");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabArtifactStep UsesAxisArtifact {
			get {
				var s = new FabArtifactStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/UsesAxisArtifact");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabVectorTypeStep UsesVectorType {
			get {
				var s = new FabVectorTypeStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/UsesVectorType");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabVectorUnitStep UsesVectorUnit {
			get {
				var s = new FabVectorUnitStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/UsesVectorUnit");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabVectorUnitPrefixStep UsesVectorUnitPrefix {
			get {
				var s = new FabVectorUnitPrefixStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/UsesVectorUnitPrefix");
				return s;
			}
		}
		
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabVectorRangeStep : ITraversalStep<FabVectorRange>, IFuncAs, IFuncBack, IFuncLimit, IFuncWhereId {
	
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a VectorType to a VectorRange that specifies a meaningful points/labels mapped to the numerical range. (InFromZeroOrMore FabVectorType)
		/// </summary>
		/// <remarks>
		///   <para>Links a VectorType to a VectorRange that specifies a meaningful points/labels mapped to the numerical range.</para>
		///   <para>Type: VectorTypeUsesVectorRange</para>
		///   <para>Relation: Uses</para>
		///   <para>Connection: InFromZeroOrMore</para>
		/// </remarks>
		IFabVectorTypeStep InVectorTypeListUses { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a VectorRange to one of the VectorRangeLevels that help give it meaning. (OutToZeroOrMore FabVectorRangeLevel)
		/// </summary>
		/// <remarks>
		///   <para>Links a VectorRange to one of the VectorRangeLevels that help give it meaning.</para>
		///   <para>Type: VectorRangeUsesVectorRangeLevel</para>
		///   <para>Relation: Uses</para>
		///   <para>Connection: OutToZeroOrMore</para>
		/// </remarks>
		IFabVectorRangeLevelStep UsesVectorRangeLevelList { get; }
	
	}
	

	/*================================================================================================*/
	internal class FabVectorRangeStep : TraversalStep<FabVectorRange>, IFabVectorRangeStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabVectorRangeStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public IFabVectorTypeStep InVectorTypeListUses {
			get {
				var s = new FabVectorTypeStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/InVectorTypeListUses");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabVectorRangeLevelStep UsesVectorRangeLevelList {
			get {
				var s = new FabVectorRangeLevelStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/UsesVectorRangeLevelList");
				return s;
			}
		}
		
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabVectorRangeLevelStep : ITraversalStep<FabVectorRangeLevel>, IFuncAs, IFuncBack, IFuncLimit, IFuncWhereId {
	
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a VectorRange to one of the VectorRangeLevels that help give it meaning. (InFromZeroOrMore FabVectorRange)
		/// </summary>
		/// <remarks>
		///   <para>Links a VectorRange to one of the VectorRangeLevels that help give it meaning.</para>
		///   <para>Type: VectorRangeUsesVectorRangeLevel</para>
		///   <para>Relation: Uses</para>
		///   <para>Connection: InFromZeroOrMore</para>
		/// </remarks>
		IFabVectorRangeStep InVectorRangeListUses { get; }
	
	}
	

	/*================================================================================================*/
	internal class FabVectorRangeLevelStep : TraversalStep<FabVectorRangeLevel>, IFabVectorRangeLevelStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabVectorRangeLevelStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public IFabVectorRangeStep InVectorRangeListUses {
			get {
				var s = new FabVectorRangeStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/InVectorRangeListUses");
				return s;
			}
		}
		
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabVectorTypeStep : ITraversalStep<FabVectorType>, IFuncAs, IFuncBack, IFuncLimit, IFuncWhereId {
	
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a Vector to a VectorType that specifies its value's boundaries and context. (InFromZeroOrMore FabVector)
		/// </summary>
		/// <remarks>
		///   <para>Links a Vector to a VectorType that specifies its value's boundaries and context.</para>
		///   <para>Type: VectorUsesVectorType</para>
		///   <para>Relation: Uses</para>
		///   <para>Connection: InFromZeroOrMore</para>
		/// </remarks>
		IFabVectorStep InVectorListUses { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a VectorType to a VectorRange that specifies a meaningful points/labels mapped to the numerical range. (OutToOne FabVectorRange)
		/// </summary>
		/// <remarks>
		///   <para>Links a VectorType to a VectorRange that specifies a meaningful points/labels mapped to the numerical range.</para>
		///   <para>Type: VectorTypeUsesVectorRange</para>
		///   <para>Relation: Uses</para>
		///   <para>Connection: OutToOne</para>
		/// </remarks>
		IFabVectorRangeStep UsesVectorRange { get; }
	
	}
	

	/*================================================================================================*/
	internal class FabVectorTypeStep : TraversalStep<FabVectorType>, IFabVectorTypeStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabVectorTypeStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public IFabVectorStep InVectorListUses {
			get {
				var s = new FabVectorStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/InVectorListUses");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabVectorRangeStep UsesVectorRange {
			get {
				var s = new FabVectorRangeStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/UsesVectorRange");
				return s;
			}
		}
		
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabVectorUnitStep : ITraversalStep<FabVectorUnit>, IFuncAs, IFuncBack, IFuncLimit, IFuncWhereId {
	
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a Vector to a VectorUnit that specifies its value's unit of measurement. (InFromZeroOrMore FabVector)
		/// </summary>
		/// <remarks>
		///   <para>Links a Vector to a VectorUnit that specifies its value's unit of measurement.</para>
		///   <para>Type: VectorUsesVectorUnit</para>
		///   <para>Relation: Uses</para>
		///   <para>Connection: InFromZeroOrMore</para>
		/// </remarks>
		IFabVectorStep InVectorListUses { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   TODO (InFromZeroOrMore FabVectorUnitDerived)
		/// </summary>
		/// <remarks>
		///   <para>TODO</para>
		///   <para>Type: VectorUnitDerivedDefinesVectorUnit</para>
		///   <para>Relation: Defines</para>
		///   <para>Connection: InFromZeroOrMore</para>
		/// </remarks>
		IFabVectorUnitDerivedStep InVectorUnitDerivedListDefines { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   TODO (InFromZeroOrMore FabVectorUnitDerived)
		/// </summary>
		/// <remarks>
		///   <para>TODO</para>
		///   <para>Type: VectorUnitDerivedRaisesToExpVectorUnit</para>
		///   <para>Relation: RaisesToExp</para>
		///   <para>Connection: InFromZeroOrMore</para>
		/// </remarks>
		IFabVectorUnitDerivedStep InVectorUnitDerivedListRaisesToExp { get; }
	
	}
	

	/*================================================================================================*/
	internal class FabVectorUnitStep : TraversalStep<FabVectorUnit>, IFabVectorUnitStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabVectorUnitStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public IFabVectorStep InVectorListUses {
			get {
				var s = new FabVectorStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/InVectorListUses");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabVectorUnitDerivedStep InVectorUnitDerivedListDefines {
			get {
				var s = new FabVectorUnitDerivedStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/InVectorUnitDerivedListDefines");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabVectorUnitDerivedStep InVectorUnitDerivedListRaisesToExp {
			get {
				var s = new FabVectorUnitDerivedStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/InVectorUnitDerivedListRaisesToExp");
				return s;
			}
		}
		
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabVectorUnitDerivedStep : ITraversalStep<FabVectorUnitDerived>, IFuncAs, IFuncBack, IFuncLimit, IFuncWhereId {
	
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   TODO (OutToOne FabVectorUnit)
		/// </summary>
		/// <remarks>
		///   <para>TODO</para>
		///   <para>Type: VectorUnitDerivedDefinesVectorUnit</para>
		///   <para>Relation: Defines</para>
		///   <para>Connection: OutToOne</para>
		/// </remarks>
		IFabVectorUnitStep DefinesVectorUnit { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   TODO (OutToOne FabVectorUnit)
		/// </summary>
		/// <remarks>
		///   <para>TODO</para>
		///   <para>Type: VectorUnitDerivedRaisesToExpVectorUnit</para>
		///   <para>Relation: RaisesToExp</para>
		///   <para>Connection: OutToOne</para>
		/// </remarks>
		IFabVectorUnitStep RaisesToExpVectorUnit { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   TODO (OutToOne FabVectorUnitPrefix)
		/// </summary>
		/// <remarks>
		///   <para>TODO</para>
		///   <para>Type: VectorUnitDerivedUsesVectorUnitPrefix</para>
		///   <para>Relation: Uses</para>
		///   <para>Connection: OutToOne</para>
		/// </remarks>
		IFabVectorUnitPrefixStep UsesVectorUnitPrefix { get; }
	
	}
	

	/*================================================================================================*/
	internal class FabVectorUnitDerivedStep : TraversalStep<FabVectorUnitDerived>, IFabVectorUnitDerivedStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabVectorUnitDerivedStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public IFabVectorUnitStep DefinesVectorUnit {
			get {
				var s = new FabVectorUnitStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/DefinesVectorUnit");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabVectorUnitStep RaisesToExpVectorUnit {
			get {
				var s = new FabVectorUnitStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/RaisesToExpVectorUnit");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabVectorUnitPrefixStep UsesVectorUnitPrefix {
			get {
				var s = new FabVectorUnitPrefixStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/UsesVectorUnitPrefix");
				return s;
			}
		}
		
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabVectorUnitPrefixStep : ITraversalStep<FabVectorUnitPrefix>, IFuncAs, IFuncBack, IFuncLimit, IFuncWhereId {
	
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a Vector to a VectorUnitPrefix that specifies its value's order of magnitude. (InFromZeroOrMore FabVector)
		/// </summary>
		/// <remarks>
		///   <para>Links a Vector to a VectorUnitPrefix that specifies its value's order of magnitude.</para>
		///   <para>Type: VectorUsesVectorUnitPrefix</para>
		///   <para>Relation: Uses</para>
		///   <para>Connection: InFromZeroOrMore</para>
		/// </remarks>
		IFabVectorStep InVectorListUses { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   TODO (InFromZeroOrMore FabVectorUnitDerived)
		/// </summary>
		/// <remarks>
		///   <para>TODO</para>
		///   <para>Type: VectorUnitDerivedUsesVectorUnitPrefix</para>
		///   <para>Relation: Uses</para>
		///   <para>Connection: InFromZeroOrMore</para>
		/// </remarks>
		IFabVectorUnitDerivedStep InVectorUnitDerivedListUses { get; }
	
	}
	

	/*================================================================================================*/
	internal class FabVectorUnitPrefixStep : TraversalStep<FabVectorUnitPrefix>, IFabVectorUnitPrefixStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabVectorUnitPrefixStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public IFabVectorStep InVectorListUses {
			get {
				var s = new FabVectorStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/InVectorListUses");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabVectorUnitDerivedStep InVectorUnitDerivedListUses {
			get {
				var s = new FabVectorUnitDerivedStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/InVectorUnitDerivedListUses");
				return s;
			}
		}
		
	}
	
	
}
