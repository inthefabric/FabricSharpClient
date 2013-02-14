
namespace Fabric.Clients.Cs.Gen {

	/*================================================================================================*/
	public interface IFabAppStep : ITraversalStep<FabApp>, IFuncAs, IFuncBack, IFuncLimit, IFuncWhereId {
	
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links an App to the Artifact that it owns. (OutToOne FabArtifact)
		///</summary>
		///<remarks>
		///    Type: AppHasArtifact
		///    Relation: Has
		///    Connection: OutToOne
		///</remarks>
		IFabArtifactStep HasArtifact { get; }
		
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links an App to a particular Member. (OutToOneOrMore FabMember)
		///</summary>
		///<remarks>
		///    Type: AppDefinesMember
		///    Relation: Defines
		///    Connection: OutToOneOrMore
		///</remarks>
		IFabMemberStep DefinesMemberList { get; }
		
	}
	
	
	/*================================================================================================*/
	public interface IFabArtifactStep : ITraversalStep<FabArtifact>, IFuncAs, IFuncBack, IFuncLimit, IFuncWhereId {
	
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links an App to the Artifact that it owns. (InFromZeroOrOne FabApp)
		///</summary>
		///<remarks>
		///    Type: AppHasArtifact
		///    Relation: Has
		///    Connection: InFromZeroOrOne
		///</remarks>
		IFabAppStep InAppHas { get; }
		
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links an Artifact to an ArtifactType that describes the type of the associated ArtifactOwnerNode. (OutToOne FabArtifactType)
		///</summary>
		///<remarks>
		///    Type: ArtifactUsesArtifactType
		///    Relation: Uses
		///    Connection: OutToOne
		///</remarks>
		IFabArtifactTypeStep UsesArtifactType { get; }
		
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links an App to the Class that it owns. (InFromZeroOrOne FabClass)
		///</summary>
		///<remarks>
		///    Type: ClassHasArtifact
		///    Relation: Has
		///    Connection: InFromZeroOrOne
		///</remarks>
		IFabClassStep InClassHas { get; }
		
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links an App to the Instance that it owns. (InFromZeroOrOne FabInstance)
		///</summary>
		///<remarks>
		///    Type: InstanceHasArtifact
		///    Relation: Has
		///    Connection: InFromZeroOrOne
		///</remarks>
		IFabInstanceStep InInstanceHas { get; }
		
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links a Member to the Artifact that it created. (InFromOne FabMember)
		///</summary>
		///<remarks>
		///    Type: MemberCreatesArtifact
		///    Relation: Creates
		///    Connection: InFromOne
		///</remarks>
		IFabMemberStep InMemberCreates { get; }
		
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links a Url to the Artifact that it owns. (InFromZeroOrOne FabUrl)
		///</summary>
		///<remarks>
		///    Type: UrlHasArtifact
		///    Relation: Has
		///    Connection: InFromZeroOrOne
		///</remarks>
		IFabUrlStep InUrlHas { get; }
		
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links a User to the Artifact that it owns. (InFromZeroOrOne FabUser)
		///</summary>
		///<remarks>
		///    Type: UserHasArtifact
		///    Relation: Has
		///    Connection: InFromZeroOrOne
		///</remarks>
		IFabUserStep InUserHas { get; }
		
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links a Factor to its primary Artifact, which represents the starting point of the Factor's directional Artifact relationship. (InFromZeroOrMore FabFactor)
		///</summary>
		///<remarks>
		///    Type: FactorUsesPrimaryArtifact
		///    Relation: UsesPrimary
		///    Connection: InFromZeroOrMore
		///</remarks>
		IFabFactorStep InFactorListUsesPrimary { get; }
		
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links a Factor to its related Artifact, which represents the ending point of the Factor's directional Artifact relationship. (InFromZeroOrMore FabFactor)
		///</summary>
		///<remarks>
		///    Type: FactorUsesRelatedArtifact
		///    Relation: UsesRelated
		///    Connection: InFromZeroOrMore
		///</remarks>
		IFabFactorStep InFactorListUsesRelated { get; }
		
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links a Descriptor to an Artifact that specifies or clarifies a particular aspect of the Factor's primary Artifact. (InFromZeroOrMore FabDescriptor)
		///</summary>
		///<remarks>
		///    Type: DescriptorRefinesPrimaryWithArtifact
		///    Relation: RefinesPrimaryWith
		///    Connection: InFromZeroOrMore
		///</remarks>
		IFabDescriptorStep InDescriptorListRefinesPrimaryWith { get; }
		
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links a Descriptor to an Artifact that specifies or clarifies a particular aspect of the Factor's related Artifact. (InFromZeroOrMore FabDescriptor)
		///</summary>
		///<remarks>
		///    Type: DescriptorRefinesRelatedWithArtifact
		///    Relation: RefinesRelatedWith
		///    Connection: InFromZeroOrMore
		///</remarks>
		IFabDescriptorStep InDescriptorListRefinesRelatedWith { get; }
		
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links a Descriptor to an Artifact that specifies or clarifies a particular aspect of the DescriptorType's meaning or purpose. (InFromZeroOrMore FabDescriptor)
		///</summary>
		///<remarks>
		///    Type: DescriptorRefinesTypeWithArtifact
		///    Relation: RefinesTypeWith
		///    Connection: InFromZeroOrMore
		///</remarks>
		IFabDescriptorStep InDescriptorListRefinesTypeWith { get; }
		
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links a Vector to an Artifact that 'labels' its value's axis. (InFromZeroOrMore FabVector)
		///</summary>
		///<remarks>
		///    Type: VectorUsesAxisArtifact
		///    Relation: UsesAxis
		///    Connection: InFromZeroOrMore
		///</remarks>
		IFabVectorStep InVectorListUsesAxis { get; }
		
	}
	
	
	/*================================================================================================*/
	public interface IFabArtifactTypeStep : ITraversalStep<FabArtifactType>, IFuncAs, IFuncBack, IFuncLimit, IFuncWhereId {
	
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links an Artifact to an ArtifactType that describes the type of the associated ArtifactOwnerNode. (InFromZeroOrMore FabArtifact)
		///</summary>
		///<remarks>
		///    Type: ArtifactUsesArtifactType
		///    Relation: Uses
		///    Connection: InFromZeroOrMore
		///</remarks>
		IFabArtifactStep InArtifactListUses { get; }
		
	}
	
	
	/*================================================================================================*/
	public interface IFabClassStep : ITraversalStep<FabClass>, IFuncAs, IFuncBack, IFuncLimit, IFuncWhereId {
	
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links an App to the Class that it owns. (OutToOne FabArtifact)
		///</summary>
		///<remarks>
		///    Type: ClassHasArtifact
		///    Relation: Has
		///    Connection: OutToOne
		///</remarks>
		IFabArtifactStep HasArtifact { get; }
		
	}
	
	
	/*================================================================================================*/
	public interface IFabDescriptorStep : ITraversalStep<FabDescriptor>, IFuncAs, IFuncBack, IFuncLimit, IFuncWhereId {
	
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links a Factor to its Descriptor Element, which defines the relationship between the primary and related Artifact. (InFromOneOrMore FabFactor)
		///</summary>
		///<remarks>
		///    Type: FactorUsesDescriptor
		///    Relation: Uses
		///    Connection: InFromOneOrMore
		///</remarks>
		IFabFactorStep InFactorListUses { get; }
		
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links a Descriptor to a DescriptorType that specifies the type of relationship or connection. (OutToOne FabDescriptorType)
		///</summary>
		///<remarks>
		///    Type: DescriptorUsesDescriptorType
		///    Relation: Uses
		///    Connection: OutToOne
		///</remarks>
		IFabDescriptorTypeStep UsesDescriptorType { get; }
		
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links a Descriptor to an Artifact that specifies or clarifies a particular aspect of the Factor's primary Artifact. (OutToZeroOrOne FabArtifact)
		///</summary>
		///<remarks>
		///    Type: DescriptorRefinesPrimaryWithArtifact
		///    Relation: RefinesPrimaryWith
		///    Connection: OutToZeroOrOne
		///</remarks>
		IFabArtifactStep RefinesPrimaryWithArtifact { get; }
		
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links a Descriptor to an Artifact that specifies or clarifies a particular aspect of the Factor's related Artifact. (OutToZeroOrOne FabArtifact)
		///</summary>
		///<remarks>
		///    Type: DescriptorRefinesRelatedWithArtifact
		///    Relation: RefinesRelatedWith
		///    Connection: OutToZeroOrOne
		///</remarks>
		IFabArtifactStep RefinesRelatedWithArtifact { get; }
		
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links a Descriptor to an Artifact that specifies or clarifies a particular aspect of the DescriptorType's meaning or purpose. (OutToZeroOrOne FabArtifact)
		///</summary>
		///<remarks>
		///    Type: DescriptorRefinesTypeWithArtifact
		///    Relation: RefinesTypeWith
		///    Connection: OutToZeroOrOne
		///</remarks>
		IFabArtifactStep RefinesTypeWithArtifact { get; }
		
	}
	
	
	/*================================================================================================*/
	public interface IFabDescriptorTypeStep : ITraversalStep<FabDescriptorType>, IFuncAs, IFuncBack, IFuncLimit, IFuncWhereId {
	
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links a Descriptor to a DescriptorType that specifies the type of relationship or connection. (InFromZeroOrMore FabDescriptor)
		///</summary>
		///<remarks>
		///    Type: DescriptorUsesDescriptorType
		///    Relation: Uses
		///    Connection: InFromZeroOrMore
		///</remarks>
		IFabDescriptorStep InDescriptorListUses { get; }
		
	}
	
	
	/*================================================================================================*/
	public interface IFabDirectorStep : ITraversalStep<FabDirector>, IFuncAs, IFuncBack, IFuncLimit, IFuncWhereId {
	
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links a Factor to its Director Element, which creates a directional pathway between the primary and related Artifacts. (InFromOneOrMore FabFactor)
		///</summary>
		///<remarks>
		///    Type: FactorUsesDirector
		///    Relation: Uses
		///    Connection: InFromOneOrMore
		///</remarks>
		IFabFactorStep InFactorListUses { get; }
		
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links a Director to a DirectorType that specifies the type and reason for the pathway. (OutToOne FabDirectorType)
		///</summary>
		///<remarks>
		///    Type: DirectorUsesDirectorType
		///    Relation: Uses
		///    Connection: OutToOne
		///</remarks>
		IFabDirectorTypeStep UsesDirectorType { get; }
		
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links a Director to a DirectorAction that specifies the action to be performed on the Factor's primary Artifact. (OutToOne FabDirectorAction)
		///</summary>
		///<remarks>
		///    Type: DirectorUsesPrimaryDirectorAction
		///    Relation: UsesPrimary
		///    Connection: OutToOne
		///</remarks>
		IFabDirectorActionStep UsesPrimaryDirectorAction { get; }
		
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links a Director to a DirectorAction that specifies the action to be performed on the Factor's related Artifact. (OutToOne FabDirectorAction)
		///</summary>
		///<remarks>
		///    Type: DirectorUsesRelatedDirectorAction
		///    Relation: UsesRelated
		///    Connection: OutToOne
		///</remarks>
		IFabDirectorActionStep UsesRelatedDirectorAction { get; }
		
	}
	
	
	/*================================================================================================*/
	public interface IFabDirectorActionStep : ITraversalStep<FabDirectorAction>, IFuncAs, IFuncBack, IFuncLimit, IFuncWhereId {
	
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links a Director to a DirectorAction that specifies the action to be performed on the Factor's primary Artifact. (InFromZeroOrMore FabDirector)
		///</summary>
		///<remarks>
		///    Type: DirectorUsesPrimaryDirectorAction
		///    Relation: UsesPrimary
		///    Connection: InFromZeroOrMore
		///</remarks>
		IFabDirectorStep InDirectorListUsesPrimary { get; }
		
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links a Director to a DirectorAction that specifies the action to be performed on the Factor's related Artifact. (InFromZeroOrMore FabDirector)
		///</summary>
		///<remarks>
		///    Type: DirectorUsesRelatedDirectorAction
		///    Relation: UsesRelated
		///    Connection: InFromZeroOrMore
		///</remarks>
		IFabDirectorStep InDirectorListUsesRelated { get; }
		
	}
	
	
	/*================================================================================================*/
	public interface IFabDirectorTypeStep : ITraversalStep<FabDirectorType>, IFuncAs, IFuncBack, IFuncLimit, IFuncWhereId {
	
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links a Director to a DirectorType that specifies the type and reason for the pathway. (InFromZeroOrMore FabDirector)
		///</summary>
		///<remarks>
		///    Type: DirectorUsesDirectorType
		///    Relation: Uses
		///    Connection: InFromZeroOrMore
		///</remarks>
		IFabDirectorStep InDirectorListUses { get; }
		
	}
	
	
	/*================================================================================================*/
	public interface IFabEventorStep : ITraversalStep<FabEventor>, IFuncAs, IFuncBack, IFuncLimit, IFuncWhereId {
	
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links a Factor to its Eventor Element, which applies the concept of time. (InFromOneOrMore FabFactor)
		///</summary>
		///<remarks>
		///    Type: FactorUsesEventor
		///    Relation: Uses
		///    Connection: InFromOneOrMore
		///</remarks>
		IFabFactorStep InFactorListUses { get; }
		
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links an Eventor to an EventorType that specifies the significance of this point in time. (OutToOne FabEventorType)
		///</summary>
		///<remarks>
		///    Type: EventorUsesEventorType
		///    Relation: Uses
		///    Connection: OutToOne
		///</remarks>
		IFabEventorTypeStep UsesEventorType { get; }
		
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links an Eventor to an EventorPrecision that specifies the level of accuracy given to this point in time. (OutToOne FabEventorPrecision)
		///</summary>
		///<remarks>
		///    Type: EventorUsesEventorPrecision
		///    Relation: Uses
		///    Connection: OutToOne
		///</remarks>
		IFabEventorPrecisionStep UsesEventorPrecision { get; }
		
	}
	
	
	/*================================================================================================*/
	public interface IFabEventorPrecisionStep : ITraversalStep<FabEventorPrecision>, IFuncAs, IFuncBack, IFuncLimit, IFuncWhereId {
	
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links an Eventor to an EventorPrecision that specifies the level of accuracy given to this point in time. (InFromZeroOrMore FabEventor)
		///</summary>
		///<remarks>
		///    Type: EventorUsesEventorPrecision
		///    Relation: Uses
		///    Connection: InFromZeroOrMore
		///</remarks>
		IFabEventorStep InEventorListUses { get; }
		
	}
	
	
	/*================================================================================================*/
	public interface IFabEventorTypeStep : ITraversalStep<FabEventorType>, IFuncAs, IFuncBack, IFuncLimit, IFuncWhereId {
	
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links an Eventor to an EventorType that specifies the significance of this point in time. (InFromZeroOrMore FabEventor)
		///</summary>
		///<remarks>
		///    Type: EventorUsesEventorType
		///    Relation: Uses
		///    Connection: InFromZeroOrMore
		///</remarks>
		IFabEventorStep InEventorListUses { get; }
		
	}
	
	
	/*================================================================================================*/
	public interface IFabFactorStep : ITraversalStep<FabFactor>, IFuncAs, IFuncBack, IFuncLimit, IFuncWhereId {
	
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links a Member to the Factor that it created. (InFromOne FabMember)
		///</summary>
		///<remarks>
		///    Type: MemberCreatesFactor
		///    Relation: Creates
		///    Connection: InFromOne
		///</remarks>
		IFabMemberStep InMemberCreates { get; }
		
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links a Factor to its primary Artifact, which represents the starting point of the Factor's directional Artifact relationship. (OutToOne FabArtifact)
		///</summary>
		///<remarks>
		///    Type: FactorUsesPrimaryArtifact
		///    Relation: UsesPrimary
		///    Connection: OutToOne
		///</remarks>
		IFabArtifactStep UsesPrimaryArtifact { get; }
		
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links a Factor to its related Artifact, which represents the ending point of the Factor's directional Artifact relationship. (OutToOne FabArtifact)
		///</summary>
		///<remarks>
		///    Type: FactorUsesRelatedArtifact
		///    Relation: UsesRelated
		///    Connection: OutToOne
		///</remarks>
		IFabArtifactStep UsesRelatedArtifact { get; }
		
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links a Factor to a FactorAssertion that specifies the type of information and/or level of confidence. (OutToOne FabFactorAssertion)
		///</summary>
		///<remarks>
		///    Type: FactorUsesFactorAssertion
		///    Relation: Uses
		///    Connection: OutToOne
		///</remarks>
		IFabFactorAssertionStep UsesFactorAssertion { get; }
		
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links a new Factor to the Factor that it has replaced. (OutToZeroOrOne FabFactor)
		///</summary>
		///<remarks>
		///    Type: FactorReplacesFactor
		///    Relation: Replaces
		///    Connection: OutToZeroOrOne
		///</remarks>
		IFabFactorStep ReplacesFactor { get; }
		
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links a Factor to its Descriptor Element, which defines the relationship between the primary and related Artifact. (OutToOne FabDescriptor)
		///</summary>
		///<remarks>
		///    Type: FactorUsesDescriptor
		///    Relation: Uses
		///    Connection: OutToOne
		///</remarks>
		IFabDescriptorStep UsesDescriptor { get; }
		
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links a Factor to its Director Element, which creates a directional pathway between the primary and related Artifacts. (OutToZeroOrOne FabDirector)
		///</summary>
		///<remarks>
		///    Type: FactorUsesDirector
		///    Relation: Uses
		///    Connection: OutToZeroOrOne
		///</remarks>
		IFabDirectorStep UsesDirector { get; }
		
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links a Factor to its Eventor Element, which applies the concept of time. (OutToZeroOrOne FabEventor)
		///</summary>
		///<remarks>
		///    Type: FactorUsesEventor
		///    Relation: Uses
		///    Connection: OutToZeroOrOne
		///</remarks>
		IFabEventorStep UsesEventor { get; }
		
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links a Factor to its Identor Element, which applies a name or identifier. (OutToZeroOrOne FabIdentor)
		///</summary>
		///<remarks>
		///    Type: FactorUsesIdentor
		///    Relation: Uses
		///    Connection: OutToZeroOrOne
		///</remarks>
		IFabIdentorStep UsesIdentor { get; }
		
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links a Factor to its Locator Element, which provides a geographical or relative position. (OutToZeroOrOne FabLocator)
		///</summary>
		///<remarks>
		///    Type: FactorUsesLocator
		///    Relation: Uses
		///    Connection: OutToZeroOrOne
		///</remarks>
		IFabLocatorStep UsesLocator { get; }
		
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links a Factor to its Vector Element, which applies a numeric axis and value. (OutToZeroOrOne FabVector)
		///</summary>
		///<remarks>
		///    Type: FactorUsesVector
		///    Relation: Uses
		///    Connection: OutToZeroOrOne
		///</remarks>
		IFabVectorStep UsesVector { get; }
		
	}
	
	
	/*================================================================================================*/
	public interface IFabFactorAssertionStep : ITraversalStep<FabFactorAssertion>, IFuncAs, IFuncBack, IFuncLimit, IFuncWhereId {
	
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links a Factor to a FactorAssertion that specifies the type of information and/or level of confidence. (InFromZeroOrMore FabFactor)
		///</summary>
		///<remarks>
		///    Type: FactorUsesFactorAssertion
		///    Relation: Uses
		///    Connection: InFromZeroOrMore
		///</remarks>
		IFabFactorStep InFactorListUses { get; }
		
	}
	
	
	/*================================================================================================*/
	public interface IFabIdentorStep : ITraversalStep<FabIdentor>, IFuncAs, IFuncBack, IFuncLimit, IFuncWhereId {
	
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links a Factor to its Identor Element, which applies a name or identifier. (InFromOneOrMore FabFactor)
		///</summary>
		///<remarks>
		///    Type: FactorUsesIdentor
		///    Relation: Uses
		///    Connection: InFromOneOrMore
		///</remarks>
		IFabFactorStep InFactorListUses { get; }
		
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links an Identor to an IdentorType that specifies the value's purpose or intent. (OutToOne FabIdentorType)
		///</summary>
		///<remarks>
		///    Type: IdentorUsesIdentorType
		///    Relation: Uses
		///    Connection: OutToOne
		///</remarks>
		IFabIdentorTypeStep UsesIdentorType { get; }
		
	}
	
	
	/*================================================================================================*/
	public interface IFabIdentorTypeStep : ITraversalStep<FabIdentorType>, IFuncAs, IFuncBack, IFuncLimit, IFuncWhereId {
	
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links an Identor to an IdentorType that specifies the value's purpose or intent. (InFromZeroOrMore FabIdentor)
		///</summary>
		///<remarks>
		///    Type: IdentorUsesIdentorType
		///    Relation: Uses
		///    Connection: InFromZeroOrMore
		///</remarks>
		IFabIdentorStep InIdentorListUses { get; }
		
	}
	
	
	/*================================================================================================*/
	public interface IFabInstanceStep : ITraversalStep<FabInstance>, IFuncAs, IFuncBack, IFuncLimit, IFuncWhereId {
	
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links an App to the Instance that it owns. (OutToOne FabArtifact)
		///</summary>
		///<remarks>
		///    Type: InstanceHasArtifact
		///    Relation: Has
		///    Connection: OutToOne
		///</remarks>
		IFabArtifactStep HasArtifact { get; }
		
	}
	
	
	/*================================================================================================*/
	public interface IFabLocatorStep : ITraversalStep<FabLocator>, IFuncAs, IFuncBack, IFuncLimit, IFuncWhereId {
	
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links a Factor to its Locator Element, which provides a geographical or relative position. (InFromOneOrMore FabFactor)
		///</summary>
		///<remarks>
		///    Type: FactorUsesLocator
		///    Relation: Uses
		///    Connection: InFromOneOrMore
		///</remarks>
		IFabFactorStep InFactorListUses { get; }
		
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links a Locator to a LocatorType that specifies the spatial context of the coordinate. (OutToOne FabLocatorType)
		///</summary>
		///<remarks>
		///    Type: LocatorUsesLocatorType
		///    Relation: Uses
		///    Connection: OutToOne
		///</remarks>
		IFabLocatorTypeStep UsesLocatorType { get; }
		
	}
	
	
	/*================================================================================================*/
	public interface IFabLocatorTypeStep : ITraversalStep<FabLocatorType>, IFuncAs, IFuncBack, IFuncLimit, IFuncWhereId {
	
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links a Locator to a LocatorType that specifies the spatial context of the coordinate. (InFromZeroOrMore FabLocator)
		///</summary>
		///<remarks>
		///    Type: LocatorUsesLocatorType
		///    Relation: Uses
		///    Connection: InFromZeroOrMore
		///</remarks>
		IFabLocatorStep InLocatorListUses { get; }
		
	}
	
	
	/*================================================================================================*/
	public interface IFabMemberStep : ITraversalStep<FabMember>, IFuncAs, IFuncBack, IFuncLimit, IFuncWhereId {
	
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links an App to a particular Member. (InFromOne FabApp)
		///</summary>
		///<remarks>
		///    Type: AppDefinesMember
		///    Relation: Defines
		///    Connection: InFromOne
		///</remarks>
		IFabAppStep InAppDefines { get; }
		
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links a Member to its active MemberTypeAssign. (OutToOne FabMemberTypeAssign)
		///</summary>
		///<remarks>
		///    Type: MemberHasMemberTypeAssign
		///    Relation: Has
		///    Connection: OutToOne
		///</remarks>
		IFabMemberTypeAssignStep HasMemberTypeAssign { get; }
		
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links a Member to a historical MemberTypeAssign. (OutToZeroOrMore FabMemberTypeAssign)
		///</summary>
		///<remarks>
		///    Type: MemberHasHistoricMemberTypeAssign
		///    Relation: HasHistoric
		///    Connection: OutToZeroOrMore
		///</remarks>
		IFabMemberTypeAssignStep HasHistoricMemberTypeAssignList { get; }
		
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links a Member to the Artifact that it created. (OutToZeroOrMore FabArtifact)
		///</summary>
		///<remarks>
		///    Type: MemberCreatesArtifact
		///    Relation: Creates
		///    Connection: OutToZeroOrMore
		///</remarks>
		IFabArtifactStep CreatesArtifactList { get; }
		
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links a Member to the MemberTypeAssign that it created. (OutToZeroOrMore FabMemberTypeAssign)
		///</summary>
		///<remarks>
		///    Type: MemberCreatesMemberTypeAssign
		///    Relation: Creates
		///    Connection: OutToZeroOrMore
		///</remarks>
		IFabMemberTypeAssignStep CreatesMemberTypeAssignList { get; }
		
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links a Member to the Factor that it created. (OutToZeroOrMore FabFactor)
		///</summary>
		///<remarks>
		///    Type: MemberCreatesFactor
		///    Relation: Creates
		///    Connection: OutToZeroOrMore
		///</remarks>
		IFabFactorStep CreatesFactorList { get; }
		
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links a User to a particular Member. (InFromOne FabUser)
		///</summary>
		///<remarks>
		///    Type: UserDefinesMember
		///    Relation: Defines
		///    Connection: InFromOne
		///</remarks>
		IFabUserStep InUserDefines { get; }
		
	}
	
	
	/*================================================================================================*/
	public interface IFabMemberTypeStep : ITraversalStep<FabMemberType>, IFuncAs, IFuncBack, IFuncLimit, IFuncWhereId {
	
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links a MemberTypeAssign to a MemberType that specifies the Member's state and/or access privileges. (InFromZeroOrMore FabMemberTypeAssign)
		///</summary>
		///<remarks>
		///    Type: MemberTypeAssignUsesMemberType
		///    Relation: Uses
		///    Connection: InFromZeroOrMore
		///</remarks>
		IFabMemberTypeAssignStep InMemberTypeAssignListUses { get; }
		
	}
	
	
	/*================================================================================================*/
	public interface IFabMemberTypeAssignStep : ITraversalStep<FabMemberTypeAssign>, IFuncAs, IFuncBack, IFuncLimit, IFuncWhereId {
	
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links a Member to its active MemberTypeAssign. (InFromOne FabMember)
		///</summary>
		///<remarks>
		///    Type: MemberHasMemberTypeAssign
		///    Relation: Has
		///    Connection: InFromOne
		///</remarks>
		IFabMemberStep InMemberHas { get; }
		
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links a Member to a historical MemberTypeAssign. (InFromOne FabMember)
		///</summary>
		///<remarks>
		///    Type: MemberHasHistoricMemberTypeAssign
		///    Relation: HasHistoric
		///    Connection: InFromOne
		///</remarks>
		IFabMemberStep InMemberHasHistoric { get; }
		
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links a Member to the MemberTypeAssign that it created. (InFromOne FabMember)
		///</summary>
		///<remarks>
		///    Type: MemberCreatesMemberTypeAssign
		///    Relation: Creates
		///    Connection: InFromOne
		///</remarks>
		IFabMemberStep InMemberCreates { get; }
		
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links a MemberTypeAssign to a MemberType that specifies the Member's state and/or access privileges. (OutToOne FabMemberType)
		///</summary>
		///<remarks>
		///    Type: MemberTypeAssignUsesMemberType
		///    Relation: Uses
		///    Connection: OutToOne
		///</remarks>
		IFabMemberTypeStep UsesMemberType { get; }
		
	}
	
	
	/*================================================================================================*/
	public interface IFabRootStep : ITraversalStep<FabRoot>, IFuncAs {
	
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links the Root node to an App. (OutToZeroOrMore FabApp)
		///</summary>
		///<remarks>
		///    Type: RootContainsApp
		///    Relation: Contains
		///    Connection: OutToZeroOrMore
		///</remarks>
		IFabAppStep ContainsAppList { get; }
		
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links the Root node to an Artifact. (OutToZeroOrMore FabArtifact)
		///</summary>
		///<remarks>
		///    Type: RootContainsArtifact
		///    Relation: Contains
		///    Connection: OutToZeroOrMore
		///</remarks>
		IFabArtifactStep ContainsArtifactList { get; }
		
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links the Root node to an ArtifactType. (OutToZeroOrMore FabArtifactType)
		///</summary>
		///<remarks>
		///    Type: RootContainsArtifactType
		///    Relation: Contains
		///    Connection: OutToZeroOrMore
		///</remarks>
		IFabArtifactTypeStep ContainsArtifactTypeList { get; }
		
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links the Root node to a Class. (OutToZeroOrMore FabClass)
		///</summary>
		///<remarks>
		///    Type: RootContainsClass
		///    Relation: Contains
		///    Connection: OutToZeroOrMore
		///</remarks>
		IFabClassStep ContainsClassList { get; }
		
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links the Root node to an Instance. (OutToZeroOrMore FabInstance)
		///</summary>
		///<remarks>
		///    Type: RootContainsInstance
		///    Relation: Contains
		///    Connection: OutToZeroOrMore
		///</remarks>
		IFabInstanceStep ContainsInstanceList { get; }
		
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links the Root node to a Member. (OutToZeroOrMore FabMember)
		///</summary>
		///<remarks>
		///    Type: RootContainsMember
		///    Relation: Contains
		///    Connection: OutToZeroOrMore
		///</remarks>
		IFabMemberStep ContainsMemberList { get; }
		
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links the Root node to a MemberType. (OutToZeroOrMore FabMemberType)
		///</summary>
		///<remarks>
		///    Type: RootContainsMemberType
		///    Relation: Contains
		///    Connection: OutToZeroOrMore
		///</remarks>
		IFabMemberTypeStep ContainsMemberTypeList { get; }
		
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links the Root node to a MemberTypeAssign. (OutToZeroOrMore FabMemberTypeAssign)
		///</summary>
		///<remarks>
		///    Type: RootContainsMemberTypeAssign
		///    Relation: Contains
		///    Connection: OutToZeroOrMore
		///</remarks>
		IFabMemberTypeAssignStep ContainsMemberTypeAssignList { get; }
		
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links the Root node to a Url. (OutToZeroOrMore FabUrl)
		///</summary>
		///<remarks>
		///    Type: RootContainsUrl
		///    Relation: Contains
		///    Connection: OutToZeroOrMore
		///</remarks>
		IFabUrlStep ContainsUrlList { get; }
		
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links the Root node to a User. (OutToZeroOrMore FabUser)
		///</summary>
		///<remarks>
		///    Type: RootContainsUser
		///    Relation: Contains
		///    Connection: OutToZeroOrMore
		///</remarks>
		IFabUserStep ContainsUserList { get; }
		
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links the Root node to a Factor. (OutToZeroOrMore FabFactor)
		///</summary>
		///<remarks>
		///    Type: RootContainsFactor
		///    Relation: Contains
		///    Connection: OutToZeroOrMore
		///</remarks>
		IFabFactorStep ContainsFactorList { get; }
		
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links the Root node to a FactorAssertion. (OutToZeroOrMore FabFactorAssertion)
		///</summary>
		///<remarks>
		///    Type: RootContainsFactorAssertion
		///    Relation: Contains
		///    Connection: OutToZeroOrMore
		///</remarks>
		IFabFactorAssertionStep ContainsFactorAssertionList { get; }
		
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links the Root node to a Descriptor. (OutToZeroOrMore FabDescriptor)
		///</summary>
		///<remarks>
		///    Type: RootContainsDescriptor
		///    Relation: Contains
		///    Connection: OutToZeroOrMore
		///</remarks>
		IFabDescriptorStep ContainsDescriptorList { get; }
		
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links the Root node to a DescriptorType. (OutToZeroOrMore FabDescriptorType)
		///</summary>
		///<remarks>
		///    Type: RootContainsDescriptorType
		///    Relation: Contains
		///    Connection: OutToZeroOrMore
		///</remarks>
		IFabDescriptorTypeStep ContainsDescriptorTypeList { get; }
		
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links the Root node to a Director. (OutToZeroOrMore FabDirector)
		///</summary>
		///<remarks>
		///    Type: RootContainsDirector
		///    Relation: Contains
		///    Connection: OutToZeroOrMore
		///</remarks>
		IFabDirectorStep ContainsDirectorList { get; }
		
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links the Root node to a DirectorType. (OutToZeroOrMore FabDirectorType)
		///</summary>
		///<remarks>
		///    Type: RootContainsDirectorType
		///    Relation: Contains
		///    Connection: OutToZeroOrMore
		///</remarks>
		IFabDirectorTypeStep ContainsDirectorTypeList { get; }
		
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links the Root node to a DirectorAction. (OutToZeroOrMore FabDirectorAction)
		///</summary>
		///<remarks>
		///    Type: RootContainsDirectorAction
		///    Relation: Contains
		///    Connection: OutToZeroOrMore
		///</remarks>
		IFabDirectorActionStep ContainsDirectorActionList { get; }
		
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links the Root node to an Eventor. (OutToZeroOrMore FabEventor)
		///</summary>
		///<remarks>
		///    Type: RootContainsEventor
		///    Relation: Contains
		///    Connection: OutToZeroOrMore
		///</remarks>
		IFabEventorStep ContainsEventorList { get; }
		
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links the Root node to an EventorType. (OutToZeroOrMore FabEventorType)
		///</summary>
		///<remarks>
		///    Type: RootContainsEventorType
		///    Relation: Contains
		///    Connection: OutToZeroOrMore
		///</remarks>
		IFabEventorTypeStep ContainsEventorTypeList { get; }
		
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links the Root node to an EventorPrecision. (OutToZeroOrMore FabEventorPrecision)
		///</summary>
		///<remarks>
		///    Type: RootContainsEventorPrecision
		///    Relation: Contains
		///    Connection: OutToZeroOrMore
		///</remarks>
		IFabEventorPrecisionStep ContainsEventorPrecisionList { get; }
		
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links the Root node to an Identor. (OutToZeroOrMore FabIdentor)
		///</summary>
		///<remarks>
		///    Type: RootContainsIdentor
		///    Relation: Contains
		///    Connection: OutToZeroOrMore
		///</remarks>
		IFabIdentorStep ContainsIdentorList { get; }
		
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links the Root node to an IdentorType. (OutToZeroOrMore FabIdentorType)
		///</summary>
		///<remarks>
		///    Type: RootContainsIdentorType
		///    Relation: Contains
		///    Connection: OutToZeroOrMore
		///</remarks>
		IFabIdentorTypeStep ContainsIdentorTypeList { get; }
		
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links the Root node to a Locator. (OutToZeroOrMore FabLocator)
		///</summary>
		///<remarks>
		///    Type: RootContainsLocator
		///    Relation: Contains
		///    Connection: OutToZeroOrMore
		///</remarks>
		IFabLocatorStep ContainsLocatorList { get; }
		
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links the Root node to a LocatorType. (OutToZeroOrMore FabLocatorType)
		///</summary>
		///<remarks>
		///    Type: RootContainsLocatorType
		///    Relation: Contains
		///    Connection: OutToZeroOrMore
		///</remarks>
		IFabLocatorTypeStep ContainsLocatorTypeList { get; }
		
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links the Root node to a Vector. (OutToZeroOrMore FabVector)
		///</summary>
		///<remarks>
		///    Type: RootContainsVector
		///    Relation: Contains
		///    Connection: OutToZeroOrMore
		///</remarks>
		IFabVectorStep ContainsVectorList { get; }
		
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links the Root node to a VectorType. (OutToZeroOrMore FabVectorType)
		///</summary>
		///<remarks>
		///    Type: RootContainsVectorType
		///    Relation: Contains
		///    Connection: OutToZeroOrMore
		///</remarks>
		IFabVectorTypeStep ContainsVectorTypeList { get; }
		
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links the Root node to a VectorRange. (OutToZeroOrMore FabVectorRange)
		///</summary>
		///<remarks>
		///    Type: RootContainsVectorRange
		///    Relation: Contains
		///    Connection: OutToZeroOrMore
		///</remarks>
		IFabVectorRangeStep ContainsVectorRangeList { get; }
		
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links the Root node to a VectorRangeLevel. (OutToZeroOrMore FabVectorRangeLevel)
		///</summary>
		///<remarks>
		///    Type: RootContainsVectorRangeLevel
		///    Relation: Contains
		///    Connection: OutToZeroOrMore
		///</remarks>
		IFabVectorRangeLevelStep ContainsVectorRangeLevelList { get; }
		
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links the Root node to a VectorUnit. (OutToZeroOrMore FabVectorUnit)
		///</summary>
		///<remarks>
		///    Type: RootContainsVectorUnit
		///    Relation: Contains
		///    Connection: OutToZeroOrMore
		///</remarks>
		IFabVectorUnitStep ContainsVectorUnitList { get; }
		
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links the Root node to a VectorUnitPrefix. (OutToZeroOrMore FabVectorUnitPrefix)
		///</summary>
		///<remarks>
		///    Type: RootContainsVectorUnitPrefix
		///    Relation: Contains
		///    Connection: OutToZeroOrMore
		///</remarks>
		IFabVectorUnitPrefixStep ContainsVectorUnitPrefixList { get; }
		
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links the Root node to a VectorUnitDerived. (OutToZeroOrMore FabVectorUnitDerived)
		///</summary>
		///<remarks>
		///    Type: RootContainsVectorUnitDerived
		///    Relation: Contains
		///    Connection: OutToZeroOrMore
		///</remarks>
		IFabVectorUnitDerivedStep ContainsVectorUnitDerivedList { get; }
		
	}
	
	
	/*================================================================================================*/
	public interface IFabUrlStep : ITraversalStep<FabUrl>, IFuncAs, IFuncBack, IFuncLimit, IFuncWhereId {
	
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links a Url to the Artifact that it owns. (OutToOne FabArtifact)
		///</summary>
		///<remarks>
		///    Type: UrlHasArtifact
		///    Relation: Has
		///    Connection: OutToOne
		///</remarks>
		IFabArtifactStep HasArtifact { get; }
		
	}
	
	
	/*================================================================================================*/
	public interface IFabUserStep : ITraversalStep<FabUser>, IFuncAs, IFuncBack, IFuncLimit, IFuncWhereId {
	
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links a User to the Artifact that it owns. (OutToOne FabArtifact)
		///</summary>
		///<remarks>
		///    Type: UserHasArtifact
		///    Relation: Has
		///    Connection: OutToOne
		///</remarks>
		IFabArtifactStep HasArtifact { get; }
		
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links a User to a particular Member. (OutToOneOrMore FabMember)
		///</summary>
		///<remarks>
		///    Type: UserDefinesMember
		///    Relation: Defines
		///    Connection: OutToOneOrMore
		///</remarks>
		IFabMemberStep DefinesMemberList { get; }
		
	}
	
	
	/*================================================================================================*/
	public interface IFabVectorStep : ITraversalStep<FabVector>, IFuncAs, IFuncBack, IFuncLimit, IFuncWhereId {
	
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links a Factor to its Vector Element, which applies a numeric axis and value. (InFromOneOrMore FabFactor)
		///</summary>
		///<remarks>
		///    Type: FactorUsesVector
		///    Relation: Uses
		///    Connection: InFromOneOrMore
		///</remarks>
		IFabFactorStep InFactorListUses { get; }
		
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links a Vector to an Artifact that 'labels' its value's axis. (OutToOne FabArtifact)
		///</summary>
		///<remarks>
		///    Type: VectorUsesAxisArtifact
		///    Relation: UsesAxis
		///    Connection: OutToOne
		///</remarks>
		IFabArtifactStep UsesAxisArtifact { get; }
		
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links a Vector to a VectorType that specifies its value's boundaries and context. (OutToOne FabVectorType)
		///</summary>
		///<remarks>
		///    Type: VectorUsesVectorType
		///    Relation: Uses
		///    Connection: OutToOne
		///</remarks>
		IFabVectorTypeStep UsesVectorType { get; }
		
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links a Vector to a VectorUnit that specifies its value's unit of measurement. (OutToOne FabVectorUnit)
		///</summary>
		///<remarks>
		///    Type: VectorUsesVectorUnit
		///    Relation: Uses
		///    Connection: OutToOne
		///</remarks>
		IFabVectorUnitStep UsesVectorUnit { get; }
		
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links a Vector to a VectorUnitPrefix that specifies its value's order of magnitude. (OutToOne FabVectorUnitPrefix)
		///</summary>
		///<remarks>
		///    Type: VectorUsesVectorUnitPrefix
		///    Relation: Uses
		///    Connection: OutToOne
		///</remarks>
		IFabVectorUnitPrefixStep UsesVectorUnitPrefix { get; }
		
	}
	
	
	/*================================================================================================*/
	public interface IFabVectorRangeStep : ITraversalStep<FabVectorRange>, IFuncAs, IFuncBack, IFuncLimit, IFuncWhereId {
	
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links a VectorType to a VectorRange that specifies a meaningful points/labels mapped to the numerical range. (InFromZeroOrMore FabVectorType)
		///</summary>
		///<remarks>
		///    Type: VectorTypeUsesVectorRange
		///    Relation: Uses
		///    Connection: InFromZeroOrMore
		///</remarks>
		IFabVectorTypeStep InVectorTypeListUses { get; }
		
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links a VectorRange to one of the VectorRangeLevels that help give it meaning. (OutToZeroOrMore FabVectorRangeLevel)
		///</summary>
		///<remarks>
		///    Type: VectorRangeUsesVectorRangeLevel
		///    Relation: Uses
		///    Connection: OutToZeroOrMore
		///</remarks>
		IFabVectorRangeLevelStep UsesVectorRangeLevelList { get; }
		
	}
	
	
	/*================================================================================================*/
	public interface IFabVectorRangeLevelStep : ITraversalStep<FabVectorRangeLevel>, IFuncAs, IFuncBack, IFuncLimit, IFuncWhereId {
	
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links a VectorRange to one of the VectorRangeLevels that help give it meaning. (InFromZeroOrMore FabVectorRange)
		///</summary>
		///<remarks>
		///    Type: VectorRangeUsesVectorRangeLevel
		///    Relation: Uses
		///    Connection: InFromZeroOrMore
		///</remarks>
		IFabVectorRangeStep InVectorRangeListUses { get; }
		
	}
	
	
	/*================================================================================================*/
	public interface IFabVectorTypeStep : ITraversalStep<FabVectorType>, IFuncAs, IFuncBack, IFuncLimit, IFuncWhereId {
	
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links a Vector to a VectorType that specifies its value's boundaries and context. (InFromZeroOrMore FabVector)
		///</summary>
		///<remarks>
		///    Type: VectorUsesVectorType
		///    Relation: Uses
		///    Connection: InFromZeroOrMore
		///</remarks>
		IFabVectorStep InVectorListUses { get; }
		
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links a VectorType to a VectorRange that specifies a meaningful points/labels mapped to the numerical range. (OutToOne FabVectorRange)
		///</summary>
		///<remarks>
		///    Type: VectorTypeUsesVectorRange
		///    Relation: Uses
		///    Connection: OutToOne
		///</remarks>
		IFabVectorRangeStep UsesVectorRange { get; }
		
	}
	
	
	/*================================================================================================*/
	public interface IFabVectorUnitStep : ITraversalStep<FabVectorUnit>, IFuncAs, IFuncBack, IFuncLimit, IFuncWhereId {
	
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links a Vector to a VectorUnit that specifies its value's unit of measurement. (InFromZeroOrMore FabVector)
		///</summary>
		///<remarks>
		///    Type: VectorUsesVectorUnit
		///    Relation: Uses
		///    Connection: InFromZeroOrMore
		///</remarks>
		IFabVectorStep InVectorListUses { get; }
		
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    TODO (InFromZeroOrMore FabVectorUnitDerived)
		///</summary>
		///<remarks>
		///    Type: VectorUnitDerivedDefinesVectorUnit
		///    Relation: Defines
		///    Connection: InFromZeroOrMore
		///</remarks>
		IFabVectorUnitDerivedStep InVectorUnitDerivedListDefines { get; }
		
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    TODO (InFromZeroOrMore FabVectorUnitDerived)
		///</summary>
		///<remarks>
		///    Type: VectorUnitDerivedRaisesToExpVectorUnit
		///    Relation: RaisesToExp
		///    Connection: InFromZeroOrMore
		///</remarks>
		IFabVectorUnitDerivedStep InVectorUnitDerivedListRaisesToExp { get; }
		
	}
	
	
	/*================================================================================================*/
	public interface IFabVectorUnitDerivedStep : ITraversalStep<FabVectorUnitDerived>, IFuncAs, IFuncBack, IFuncLimit, IFuncWhereId {
	
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    TODO (OutToOne FabVectorUnit)
		///</summary>
		///<remarks>
		///    Type: VectorUnitDerivedDefinesVectorUnit
		///    Relation: Defines
		///    Connection: OutToOne
		///</remarks>
		IFabVectorUnitStep DefinesVectorUnit { get; }
		
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    TODO (OutToOne FabVectorUnit)
		///</summary>
		///<remarks>
		///    Type: VectorUnitDerivedRaisesToExpVectorUnit
		///    Relation: RaisesToExp
		///    Connection: OutToOne
		///</remarks>
		IFabVectorUnitStep RaisesToExpVectorUnit { get; }
		
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    TODO (OutToOne FabVectorUnitPrefix)
		///</summary>
		///<remarks>
		///    Type: VectorUnitDerivedUsesVectorUnitPrefix
		///    Relation: Uses
		///    Connection: OutToOne
		///</remarks>
		IFabVectorUnitPrefixStep UsesVectorUnitPrefix { get; }
		
	}
	
	
	/*================================================================================================*/
	public interface IFabVectorUnitPrefixStep : ITraversalStep<FabVectorUnitPrefix>, IFuncAs, IFuncBack, IFuncLimit, IFuncWhereId {
	
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    Links a Vector to a VectorUnitPrefix that specifies its value's order of magnitude. (InFromZeroOrMore FabVector)
		///</summary>
		///<remarks>
		///    Type: VectorUsesVectorUnitPrefix
		///    Relation: Uses
		///    Connection: InFromZeroOrMore
		///</remarks>
		IFabVectorStep InVectorListUses { get; }
		
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    TODO (InFromZeroOrMore FabVectorUnitDerived)
		///</summary>
		///<remarks>
		///    Type: VectorUnitDerivedUsesVectorUnitPrefix
		///    Relation: Uses
		///    Connection: InFromZeroOrMore
		///</remarks>
		IFabVectorUnitDerivedStep InVectorUnitDerivedListUses { get; }
		
	}
	
	
	/*================================================================================================*/
	public class FabAppStep : TraversalStep<FabApp>, IFabAppStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabAppStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public IFabArtifactStep HasArtifact {
			get {
				var s = new FabArtifactStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/HasArtifact");
				return s;
			}
		}
		
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
	public class FabArtifactStep : TraversalStep<FabArtifact>, IFabArtifactStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabArtifactStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public IFabAppStep InAppHas {
			get {
				var s = new FabAppStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/InAppHas");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabArtifactTypeStep UsesArtifactType {
			get {
				var s = new FabArtifactTypeStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/UsesArtifactType");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabClassStep InClassHas {
			get {
				var s = new FabClassStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/InClassHas");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabInstanceStep InInstanceHas {
			get {
				var s = new FabInstanceStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/InInstanceHas");
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
		public IFabUrlStep InUrlHas {
			get {
				var s = new FabUrlStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/InUrlHas");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabUserStep InUserHas {
			get {
				var s = new FabUserStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/InUserHas");
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
	public class FabArtifactTypeStep : TraversalStep<FabArtifactType>, IFabArtifactTypeStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabArtifactTypeStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public IFabArtifactStep InArtifactListUses {
			get {
				var s = new FabArtifactStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/InArtifactListUses");
				return s;
			}
		}
		
	}
	
	
	/*================================================================================================*/
	public class FabClassStep : TraversalStep<FabClass>, IFabClassStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabClassStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public IFabArtifactStep HasArtifact {
			get {
				var s = new FabArtifactStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/HasArtifact");
				return s;
			}
		}
		
	}
	
	
	/*================================================================================================*/
	public class FabDescriptorStep : TraversalStep<FabDescriptor>, IFabDescriptorStep {
		
		
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
	public class FabDescriptorTypeStep : TraversalStep<FabDescriptorType>, IFabDescriptorTypeStep {
		
		
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
	public class FabDirectorStep : TraversalStep<FabDirector>, IFabDirectorStep {
		
		
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
	public class FabDirectorActionStep : TraversalStep<FabDirectorAction>, IFabDirectorActionStep {
		
		
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
	public class FabDirectorTypeStep : TraversalStep<FabDirectorType>, IFabDirectorTypeStep {
		
		
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
	public class FabEventorStep : TraversalStep<FabEventor>, IFabEventorStep {
		
		
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
	public class FabEventorPrecisionStep : TraversalStep<FabEventorPrecision>, IFabEventorPrecisionStep {
		
		
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
	public class FabEventorTypeStep : TraversalStep<FabEventorType>, IFabEventorTypeStep {
		
		
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
	public class FabFactorStep : TraversalStep<FabFactor>, IFabFactorStep {
		
		
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
	public class FabFactorAssertionStep : TraversalStep<FabFactorAssertion>, IFabFactorAssertionStep {
		
		
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
	public class FabIdentorStep : TraversalStep<FabIdentor>, IFabIdentorStep {
		
		
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
	public class FabIdentorTypeStep : TraversalStep<FabIdentorType>, IFabIdentorTypeStep {
		
		
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
	public class FabInstanceStep : TraversalStep<FabInstance>, IFabInstanceStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabInstanceStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public IFabArtifactStep HasArtifact {
			get {
				var s = new FabArtifactStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/HasArtifact");
				return s;
			}
		}
		
	}
	
	
	/*================================================================================================*/
	public class FabLocatorStep : TraversalStep<FabLocator>, IFabLocatorStep {
		
		
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
	public class FabLocatorTypeStep : TraversalStep<FabLocatorType>, IFabLocatorTypeStep {
		
		
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
	public class FabMemberStep : TraversalStep<FabMember>, IFabMemberStep {
		
		
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
	public class FabMemberTypeStep : TraversalStep<FabMemberType>, IFabMemberTypeStep {
		
		
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
	public class FabMemberTypeAssignStep : TraversalStep<FabMemberTypeAssign>, IFabMemberTypeAssignStep {
		
		
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
	public class FabRootStep : TraversalStep<FabRoot>, IFabRootStep {
		
		
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
		public IFabArtifactStep ContainsArtifactList {
			get {
				var s = new FabArtifactStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/ContainsArtifactList");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabArtifactTypeStep ContainsArtifactTypeList {
			get {
				var s = new FabArtifactTypeStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/ContainsArtifactTypeList");
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
	public class FabUrlStep : TraversalStep<FabUrl>, IFabUrlStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabUrlStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public IFabArtifactStep HasArtifact {
			get {
				var s = new FabArtifactStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/HasArtifact");
				return s;
			}
		}
		
	}
	
	
	/*================================================================================================*/
	public class FabUserStep : TraversalStep<FabUser>, IFabUserStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabUserStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public IFabArtifactStep HasArtifact {
			get {
				var s = new FabArtifactStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/HasArtifact");
				return s;
			}
		}
		
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
	public class FabVectorStep : TraversalStep<FabVector>, IFabVectorStep {
		
		
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
	public class FabVectorRangeStep : TraversalStep<FabVectorRange>, IFabVectorRangeStep {
		
		
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
	public class FabVectorRangeLevelStep : TraversalStep<FabVectorRangeLevel>, IFabVectorRangeLevelStep {
		
		
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
	public class FabVectorTypeStep : TraversalStep<FabVectorType>, IFabVectorTypeStep {
		
		
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
	public class FabVectorUnitStep : TraversalStep<FabVectorUnit>, IFabVectorUnitStep {
		
		
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
	public class FabVectorUnitDerivedStep : TraversalStep<FabVectorUnitDerived>, IFabVectorUnitDerivedStep {
		
		
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
	public class FabVectorUnitPrefixStep : TraversalStep<FabVectorUnitPrefix>, IFabVectorUnitPrefixStep {
		
		
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
