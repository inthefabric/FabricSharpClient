using System.Collections.Generic;

namespace Fabric.Clients.Cs.Gen {

	/*================================================================================================*/
	public class FabAppStep : TraversalStep {
	
		///<summary>
		///    Links an App to the Artifact that it owns.
		///</summary>
		///<remarks>
		///    Type: AppHasArtifact
		///    Relation: Has
		///    Connection: InFromZeroOrOne
		///</remarks>
		public FabArtifactStep HasArtifact { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the HasArtifact step.
		///</summary>
		public FabArtifact HasArtifactGet() { return null; }
		
		///<summary>
		///    Links an App to a particular Member.
		///</summary>
		///<remarks>
		///    Type: AppDefinesMember
		///    Relation: Defines
		///    Connection: InFromOne
		///</remarks>
		public FabMemberStep DefinesMemberList { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the DefinesMemberList step.
		///</summary>
		public FabMember DefinesMemberListGet() { return null; }
		
	}
	
	
	/*================================================================================================*/
	public class FabArtifactStep : TraversalStep {
	
		///<summary>
		///    Links an App to the Artifact that it owns.
		///</summary>
		///<remarks>
		///    Type: AppHasArtifact
		///    Relation: Has
		///    Connection: OutToOne
		///</remarks>
		public FabAppStep InAppHas { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the InAppHas step.
		///</summary>
		public FabApp InAppHasGet() { return null; }
		
		///<summary>
		///    Links an Artifact to an ArtifactType that describes the type of the associated ArtifactOwnerNode.
		///</summary>
		///<remarks>
		///    Type: ArtifactUsesArtifactType
		///    Relation: Uses
		///    Connection: InFromZeroOrMore
		///</remarks>
		public FabArtifactTypeStep UsesArtifactType { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the UsesArtifactType step.
		///</summary>
		public IList<FabArtifactType> UsesArtifactTypeGet() { return null; }
		
		///<summary>
		///    Links an App to the Class that it owns.
		///</summary>
		///<remarks>
		///    Type: ClassHasArtifact
		///    Relation: Has
		///    Connection: OutToOne
		///</remarks>
		public FabClassStep InClassHas { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the InClassHas step.
		///</summary>
		public FabClass InClassHasGet() { return null; }
		
		///<summary>
		///    Links an App to the Instance that it owns.
		///</summary>
		///<remarks>
		///    Type: InstanceHasArtifact
		///    Relation: Has
		///    Connection: OutToOne
		///</remarks>
		public FabInstanceStep InInstanceHas { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the InInstanceHas step.
		///</summary>
		public FabInstance InInstanceHasGet() { return null; }
		
		///<summary>
		///    Links a Member to the Artifact that it created.
		///</summary>
		///<remarks>
		///    Type: MemberCreatesArtifact
		///    Relation: Creates
		///    Connection: OutToZeroOrMore
		///</remarks>
		public FabMemberStep InMemberCreates { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the InMemberCreates step.
		///</summary>
		public IList<FabMember> InMemberCreatesGet() { return null; }
		
		///<summary>
		///    Links a Url to the Artifact that it owns.
		///</summary>
		///<remarks>
		///    Type: UrlHasArtifact
		///    Relation: Has
		///    Connection: OutToOne
		///</remarks>
		public FabUrlStep InUrlHas { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the InUrlHas step.
		///</summary>
		public FabUrl InUrlHasGet() { return null; }
		
		///<summary>
		///    Links a User to the Artifact that it owns.
		///</summary>
		///<remarks>
		///    Type: UserHasArtifact
		///    Relation: Has
		///    Connection: OutToOne
		///</remarks>
		public FabUserStep InUserHas { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the InUserHas step.
		///</summary>
		public FabUser InUserHasGet() { return null; }
		
		///<summary>
		///    Links a Factor to its primary Artifact, which represents the starting point of the Factor's directional Artifact relationship.
		///</summary>
		///<remarks>
		///    Type: FactorUsesPrimaryArtifact
		///    Relation: UsesPrimary
		///    Connection: OutToOne
		///</remarks>
		public FabFactorStep InFactorListUsesPrimary { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the InFactorListUsesPrimary step.
		///</summary>
		public FabFactor InFactorListUsesPrimaryGet() { return null; }
		
		///<summary>
		///    Links a Factor to its related Artifact, which represents the ending point of the Factor's directional Artifact relationship.
		///</summary>
		///<remarks>
		///    Type: FactorUsesRelatedArtifact
		///    Relation: UsesRelated
		///    Connection: OutToOne
		///</remarks>
		public FabFactorStep InFactorListUsesRelated { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the InFactorListUsesRelated step.
		///</summary>
		public FabFactor InFactorListUsesRelatedGet() { return null; }
		
		///<summary>
		///    Links a Descriptor to an Artifact that specifies or clarifies a particular aspect of the Factor's primary Artifact.
		///</summary>
		///<remarks>
		///    Type: DescriptorRefinesPrimaryWithArtifact
		///    Relation: RefinesPrimaryWith
		///    Connection: OutToZeroOrOne
		///</remarks>
		public FabDescriptorStep InDescriptorListRefinesPrimaryWith { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the InDescriptorListRefinesPrimaryWith step.
		///</summary>
		public FabDescriptor InDescriptorListRefinesPrimaryWithGet() { return null; }
		
		///<summary>
		///    Links a Descriptor to an Artifact that specifies or clarifies a particular aspect of the Factor's related Artifact.
		///</summary>
		///<remarks>
		///    Type: DescriptorRefinesRelatedWithArtifact
		///    Relation: RefinesRelatedWith
		///    Connection: OutToZeroOrOne
		///</remarks>
		public FabDescriptorStep InDescriptorListRefinesRelatedWith { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the InDescriptorListRefinesRelatedWith step.
		///</summary>
		public FabDescriptor InDescriptorListRefinesRelatedWithGet() { return null; }
		
		///<summary>
		///    Links a Descriptor to an Artifact that specifies or clarifies a particular aspect of the DescriptorType's meaning or purpose.
		///</summary>
		///<remarks>
		///    Type: DescriptorRefinesTypeWithArtifact
		///    Relation: RefinesTypeWith
		///    Connection: OutToZeroOrOne
		///</remarks>
		public FabDescriptorStep InDescriptorListRefinesTypeWith { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the InDescriptorListRefinesTypeWith step.
		///</summary>
		public FabDescriptor InDescriptorListRefinesTypeWithGet() { return null; }
		
		///<summary>
		///    Links a Vector to an Artifact that 'labels' its value's axis.
		///</summary>
		///<remarks>
		///    Type: VectorUsesAxisArtifact
		///    Relation: UsesAxis
		///    Connection: OutToOne
		///</remarks>
		public FabVectorStep InVectorListUsesAxis { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the InVectorListUsesAxis step.
		///</summary>
		public FabVector InVectorListUsesAxisGet() { return null; }
		
	}
	
	
	/*================================================================================================*/
	public class FabArtifactTypeStep : TraversalStep {
	
		///<summary>
		///    Links an Artifact to an ArtifactType that describes the type of the associated ArtifactOwnerNode.
		///</summary>
		///<remarks>
		///    Type: ArtifactUsesArtifactType
		///    Relation: Uses
		///    Connection: OutToOne
		///</remarks>
		public FabArtifactStep InArtifactListUses { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the InArtifactListUses step.
		///</summary>
		public FabArtifact InArtifactListUsesGet() { return null; }
		
	}
	
	
	/*================================================================================================*/
	public class FabClassStep : TraversalStep {
	
		///<summary>
		///    Links an App to the Class that it owns.
		///</summary>
		///<remarks>
		///    Type: ClassHasArtifact
		///    Relation: Has
		///    Connection: InFromZeroOrOne
		///</remarks>
		public FabArtifactStep HasArtifact { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the HasArtifact step.
		///</summary>
		public FabArtifact HasArtifactGet() { return null; }
		
	}
	
	
	/*================================================================================================*/
	public class FabDescriptorStep : TraversalStep {
	
		///<summary>
		///    Links a Factor to its Descriptor Element, which defines the relationship between the primary and related Artifact.
		///</summary>
		///<remarks>
		///    Type: FactorUsesDescriptor
		///    Relation: Uses
		///    Connection: OutToOne
		///</remarks>
		public FabFactorStep InFactorListUses { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the InFactorListUses step.
		///</summary>
		public FabFactor InFactorListUsesGet() { return null; }
		
		///<summary>
		///    Links a Descriptor to a DescriptorType that specifies the type of relationship or connection.
		///</summary>
		///<remarks>
		///    Type: DescriptorUsesDescriptorType
		///    Relation: Uses
		///    Connection: InFromZeroOrMore
		///</remarks>
		public FabDescriptorTypeStep UsesDescriptorType { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the UsesDescriptorType step.
		///</summary>
		public IList<FabDescriptorType> UsesDescriptorTypeGet() { return null; }
		
		///<summary>
		///    Links a Descriptor to an Artifact that specifies or clarifies a particular aspect of the Factor's primary Artifact.
		///</summary>
		///<remarks>
		///    Type: DescriptorRefinesPrimaryWithArtifact
		///    Relation: RefinesPrimaryWith
		///    Connection: InFromZeroOrMore
		///</remarks>
		public FabArtifactStep RefinesPrimaryWithArtifact { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the RefinesPrimaryWithArtifact step.
		///</summary>
		public IList<FabArtifact> RefinesPrimaryWithArtifactGet() { return null; }
		
		///<summary>
		///    Links a Descriptor to an Artifact that specifies or clarifies a particular aspect of the Factor's related Artifact.
		///</summary>
		///<remarks>
		///    Type: DescriptorRefinesRelatedWithArtifact
		///    Relation: RefinesRelatedWith
		///    Connection: InFromZeroOrMore
		///</remarks>
		public FabArtifactStep RefinesRelatedWithArtifact { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the RefinesRelatedWithArtifact step.
		///</summary>
		public IList<FabArtifact> RefinesRelatedWithArtifactGet() { return null; }
		
		///<summary>
		///    Links a Descriptor to an Artifact that specifies or clarifies a particular aspect of the DescriptorType's meaning or purpose.
		///</summary>
		///<remarks>
		///    Type: DescriptorRefinesTypeWithArtifact
		///    Relation: RefinesTypeWith
		///    Connection: InFromZeroOrMore
		///</remarks>
		public FabArtifactStep RefinesTypeWithArtifact { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the RefinesTypeWithArtifact step.
		///</summary>
		public IList<FabArtifact> RefinesTypeWithArtifactGet() { return null; }
		
	}
	
	
	/*================================================================================================*/
	public class FabDescriptorTypeStep : TraversalStep {
	
		///<summary>
		///    Links a Descriptor to a DescriptorType that specifies the type of relationship or connection.
		///</summary>
		///<remarks>
		///    Type: DescriptorUsesDescriptorType
		///    Relation: Uses
		///    Connection: OutToOne
		///</remarks>
		public FabDescriptorStep InDescriptorListUses { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the InDescriptorListUses step.
		///</summary>
		public FabDescriptor InDescriptorListUsesGet() { return null; }
		
	}
	
	
	/*================================================================================================*/
	public class FabDirectorStep : TraversalStep {
	
		///<summary>
		///    Links a Factor to its Director Element, which creates a directional pathway between the primary and related Artifacts.
		///</summary>
		///<remarks>
		///    Type: FactorUsesDirector
		///    Relation: Uses
		///    Connection: OutToZeroOrOne
		///</remarks>
		public FabFactorStep InFactorListUses { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the InFactorListUses step.
		///</summary>
		public FabFactor InFactorListUsesGet() { return null; }
		
		///<summary>
		///    Links a Director to a DirectorType that specifies the type and reason for the pathway.
		///</summary>
		///<remarks>
		///    Type: DirectorUsesDirectorType
		///    Relation: Uses
		///    Connection: InFromZeroOrMore
		///</remarks>
		public FabDirectorTypeStep UsesDirectorType { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the UsesDirectorType step.
		///</summary>
		public IList<FabDirectorType> UsesDirectorTypeGet() { return null; }
		
		///<summary>
		///    Links a Director to a DirectorAction that specifies the action to be performed on the Factor's primary Artifact.
		///</summary>
		///<remarks>
		///    Type: DirectorUsesPrimaryDirectorAction
		///    Relation: UsesPrimary
		///    Connection: InFromZeroOrMore
		///</remarks>
		public FabDirectorActionStep UsesPrimaryDirectorAction { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the UsesPrimaryDirectorAction step.
		///</summary>
		public IList<FabDirectorAction> UsesPrimaryDirectorActionGet() { return null; }
		
		///<summary>
		///    Links a Director to a DirectorAction that specifies the action to be performed on the Factor's related Artifact.
		///</summary>
		///<remarks>
		///    Type: DirectorUsesRelatedDirectorAction
		///    Relation: UsesRelated
		///    Connection: InFromZeroOrMore
		///</remarks>
		public FabDirectorActionStep UsesRelatedDirectorAction { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the UsesRelatedDirectorAction step.
		///</summary>
		public IList<FabDirectorAction> UsesRelatedDirectorActionGet() { return null; }
		
	}
	
	
	/*================================================================================================*/
	public class FabDirectorActionStep : TraversalStep {
	
		///<summary>
		///    Links a Director to a DirectorAction that specifies the action to be performed on the Factor's primary Artifact.
		///</summary>
		///<remarks>
		///    Type: DirectorUsesPrimaryDirectorAction
		///    Relation: UsesPrimary
		///    Connection: OutToOne
		///</remarks>
		public FabDirectorStep InDirectorListUsesPrimary { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the InDirectorListUsesPrimary step.
		///</summary>
		public FabDirector InDirectorListUsesPrimaryGet() { return null; }
		
		///<summary>
		///    Links a Director to a DirectorAction that specifies the action to be performed on the Factor's related Artifact.
		///</summary>
		///<remarks>
		///    Type: DirectorUsesRelatedDirectorAction
		///    Relation: UsesRelated
		///    Connection: OutToOne
		///</remarks>
		public FabDirectorStep InDirectorListUsesRelated { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the InDirectorListUsesRelated step.
		///</summary>
		public FabDirector InDirectorListUsesRelatedGet() { return null; }
		
	}
	
	
	/*================================================================================================*/
	public class FabDirectorTypeStep : TraversalStep {
	
		///<summary>
		///    Links a Director to a DirectorType that specifies the type and reason for the pathway.
		///</summary>
		///<remarks>
		///    Type: DirectorUsesDirectorType
		///    Relation: Uses
		///    Connection: OutToOne
		///</remarks>
		public FabDirectorStep InDirectorListUses { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the InDirectorListUses step.
		///</summary>
		public FabDirector InDirectorListUsesGet() { return null; }
		
	}
	
	
	/*================================================================================================*/
	public class FabEventorStep : TraversalStep {
	
		///<summary>
		///    Links a Factor to its Eventor Element, which applies the concept of time.
		///</summary>
		///<remarks>
		///    Type: FactorUsesEventor
		///    Relation: Uses
		///    Connection: OutToZeroOrOne
		///</remarks>
		public FabFactorStep InFactorListUses { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the InFactorListUses step.
		///</summary>
		public FabFactor InFactorListUsesGet() { return null; }
		
		///<summary>
		///    Links an Eventor to an EventorType that specifies the significance of this point in time.
		///</summary>
		///<remarks>
		///    Type: EventorUsesEventorType
		///    Relation: Uses
		///    Connection: InFromZeroOrMore
		///</remarks>
		public FabEventorTypeStep UsesEventorType { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the UsesEventorType step.
		///</summary>
		public IList<FabEventorType> UsesEventorTypeGet() { return null; }
		
		///<summary>
		///    Links an Eventor to an EventorPrecision that specifies the level of accuracy given to this point in time.
		///</summary>
		///<remarks>
		///    Type: EventorUsesEventorPrecision
		///    Relation: Uses
		///    Connection: InFromZeroOrMore
		///</remarks>
		public FabEventorPrecisionStep UsesEventorPrecision { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the UsesEventorPrecision step.
		///</summary>
		public IList<FabEventorPrecision> UsesEventorPrecisionGet() { return null; }
		
	}
	
	
	/*================================================================================================*/
	public class FabEventorPrecisionStep : TraversalStep {
	
		///<summary>
		///    Links an Eventor to an EventorPrecision that specifies the level of accuracy given to this point in time.
		///</summary>
		///<remarks>
		///    Type: EventorUsesEventorPrecision
		///    Relation: Uses
		///    Connection: OutToOne
		///</remarks>
		public FabEventorStep InEventorListUses { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the InEventorListUses step.
		///</summary>
		public FabEventor InEventorListUsesGet() { return null; }
		
	}
	
	
	/*================================================================================================*/
	public class FabEventorTypeStep : TraversalStep {
	
		///<summary>
		///    Links an Eventor to an EventorType that specifies the significance of this point in time.
		///</summary>
		///<remarks>
		///    Type: EventorUsesEventorType
		///    Relation: Uses
		///    Connection: OutToOne
		///</remarks>
		public FabEventorStep InEventorListUses { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the InEventorListUses step.
		///</summary>
		public FabEventor InEventorListUsesGet() { return null; }
		
	}
	
	
	/*================================================================================================*/
	public class FabFactorStep : TraversalStep {
	
		///<summary>
		///    Links a Member to the Factor that it created.
		///</summary>
		///<remarks>
		///    Type: MemberCreatesFactor
		///    Relation: Creates
		///    Connection: OutToZeroOrMore
		///</remarks>
		public FabMemberStep InMemberCreates { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the InMemberCreates step.
		///</summary>
		public IList<FabMember> InMemberCreatesGet() { return null; }
		
		///<summary>
		///    Links a Factor to its primary Artifact, which represents the starting point of the Factor's directional Artifact relationship.
		///</summary>
		///<remarks>
		///    Type: FactorUsesPrimaryArtifact
		///    Relation: UsesPrimary
		///    Connection: InFromZeroOrMore
		///</remarks>
		public FabArtifactStep UsesPrimaryArtifact { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the UsesPrimaryArtifact step.
		///</summary>
		public IList<FabArtifact> UsesPrimaryArtifactGet() { return null; }
		
		///<summary>
		///    Links a Factor to its related Artifact, which represents the ending point of the Factor's directional Artifact relationship.
		///</summary>
		///<remarks>
		///    Type: FactorUsesRelatedArtifact
		///    Relation: UsesRelated
		///    Connection: InFromZeroOrMore
		///</remarks>
		public FabArtifactStep UsesRelatedArtifact { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the UsesRelatedArtifact step.
		///</summary>
		public IList<FabArtifact> UsesRelatedArtifactGet() { return null; }
		
		///<summary>
		///    Links a Factor to a FactorAssertion that specifies the type of information and/or level of confidence.
		///</summary>
		///<remarks>
		///    Type: FactorUsesFactorAssertion
		///    Relation: Uses
		///    Connection: InFromZeroOrMore
		///</remarks>
		public FabFactorAssertionStep UsesFactorAssertion { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the UsesFactorAssertion step.
		///</summary>
		public IList<FabFactorAssertion> UsesFactorAssertionGet() { return null; }
		
		///<summary>
		///    Links a new Factor to the Factor that it has replaced.
		///</summary>
		///<remarks>
		///    Type: FactorReplacesFactor
		///    Relation: Replaces
		///    Connection: InFromZeroOrOne
		///</remarks>
		public FabFactorStep ReplacesFactor { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the ReplacesFactor step.
		///</summary>
		public FabFactor ReplacesFactorGet() { return null; }
		
		///<summary>
		///    Links a Factor to its Descriptor Element, which defines the relationship between the primary and related Artifact.
		///</summary>
		///<remarks>
		///    Type: FactorUsesDescriptor
		///    Relation: Uses
		///    Connection: InFromOneOrMore
		///</remarks>
		public FabDescriptorStep UsesDescriptor { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the UsesDescriptor step.
		///</summary>
		public IList<FabDescriptor> UsesDescriptorGet() { return null; }
		
		///<summary>
		///    Links a Factor to its Director Element, which creates a directional pathway between the primary and related Artifacts.
		///</summary>
		///<remarks>
		///    Type: FactorUsesDirector
		///    Relation: Uses
		///    Connection: InFromOneOrMore
		///</remarks>
		public FabDirectorStep UsesDirector { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the UsesDirector step.
		///</summary>
		public IList<FabDirector> UsesDirectorGet() { return null; }
		
		///<summary>
		///    Links a Factor to its Eventor Element, which applies the concept of time.
		///</summary>
		///<remarks>
		///    Type: FactorUsesEventor
		///    Relation: Uses
		///    Connection: InFromOneOrMore
		///</remarks>
		public FabEventorStep UsesEventor { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the UsesEventor step.
		///</summary>
		public IList<FabEventor> UsesEventorGet() { return null; }
		
		///<summary>
		///    Links a Factor to its Identor Element, which applies a name or identifier.
		///</summary>
		///<remarks>
		///    Type: FactorUsesIdentor
		///    Relation: Uses
		///    Connection: InFromOneOrMore
		///</remarks>
		public FabIdentorStep UsesIdentor { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the UsesIdentor step.
		///</summary>
		public IList<FabIdentor> UsesIdentorGet() { return null; }
		
		///<summary>
		///    Links a Factor to its Locator Element, which provides a geographical or relative position.
		///</summary>
		///<remarks>
		///    Type: FactorUsesLocator
		///    Relation: Uses
		///    Connection: InFromOneOrMore
		///</remarks>
		public FabLocatorStep UsesLocator { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the UsesLocator step.
		///</summary>
		public IList<FabLocator> UsesLocatorGet() { return null; }
		
		///<summary>
		///    Links a Factor to its Vector Element, which applies a numeric axis and value.
		///</summary>
		///<remarks>
		///    Type: FactorUsesVector
		///    Relation: Uses
		///    Connection: InFromOneOrMore
		///</remarks>
		public FabVectorStep UsesVector { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the UsesVector step.
		///</summary>
		public IList<FabVector> UsesVectorGet() { return null; }
		
	}
	
	
	/*================================================================================================*/
	public class FabFactorAssertionStep : TraversalStep {
	
		///<summary>
		///    Links a Factor to a FactorAssertion that specifies the type of information and/or level of confidence.
		///</summary>
		///<remarks>
		///    Type: FactorUsesFactorAssertion
		///    Relation: Uses
		///    Connection: OutToOne
		///</remarks>
		public FabFactorStep InFactorListUses { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the InFactorListUses step.
		///</summary>
		public FabFactor InFactorListUsesGet() { return null; }
		
	}
	
	
	/*================================================================================================*/
	public class FabIdentorStep : TraversalStep {
	
		///<summary>
		///    Links a Factor to its Identor Element, which applies a name or identifier.
		///</summary>
		///<remarks>
		///    Type: FactorUsesIdentor
		///    Relation: Uses
		///    Connection: OutToZeroOrOne
		///</remarks>
		public FabFactorStep InFactorListUses { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the InFactorListUses step.
		///</summary>
		public FabFactor InFactorListUsesGet() { return null; }
		
		///<summary>
		///    Links an Identor to an IdentorType that specifies the value's purpose or intent.
		///</summary>
		///<remarks>
		///    Type: IdentorUsesIdentorType
		///    Relation: Uses
		///    Connection: InFromZeroOrMore
		///</remarks>
		public FabIdentorTypeStep UsesIdentorType { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the UsesIdentorType step.
		///</summary>
		public IList<FabIdentorType> UsesIdentorTypeGet() { return null; }
		
	}
	
	
	/*================================================================================================*/
	public class FabIdentorTypeStep : TraversalStep {
	
		///<summary>
		///    Links an Identor to an IdentorType that specifies the value's purpose or intent.
		///</summary>
		///<remarks>
		///    Type: IdentorUsesIdentorType
		///    Relation: Uses
		///    Connection: OutToOne
		///</remarks>
		public FabIdentorStep InIdentorListUses { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the InIdentorListUses step.
		///</summary>
		public FabIdentor InIdentorListUsesGet() { return null; }
		
	}
	
	
	/*================================================================================================*/
	public class FabInstanceStep : TraversalStep {
	
		///<summary>
		///    Links an App to the Instance that it owns.
		///</summary>
		///<remarks>
		///    Type: InstanceHasArtifact
		///    Relation: Has
		///    Connection: InFromZeroOrOne
		///</remarks>
		public FabArtifactStep HasArtifact { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the HasArtifact step.
		///</summary>
		public FabArtifact HasArtifactGet() { return null; }
		
	}
	
	
	/*================================================================================================*/
	public class FabLocatorStep : TraversalStep {
	
		///<summary>
		///    Links a Factor to its Locator Element, which provides a geographical or relative position.
		///</summary>
		///<remarks>
		///    Type: FactorUsesLocator
		///    Relation: Uses
		///    Connection: OutToZeroOrOne
		///</remarks>
		public FabFactorStep InFactorListUses { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the InFactorListUses step.
		///</summary>
		public FabFactor InFactorListUsesGet() { return null; }
		
		///<summary>
		///    Links a Locator to a LocatorType that specifies the spatial context of the coordinate.
		///</summary>
		///<remarks>
		///    Type: LocatorUsesLocatorType
		///    Relation: Uses
		///    Connection: InFromZeroOrMore
		///</remarks>
		public FabLocatorTypeStep UsesLocatorType { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the UsesLocatorType step.
		///</summary>
		public IList<FabLocatorType> UsesLocatorTypeGet() { return null; }
		
	}
	
	
	/*================================================================================================*/
	public class FabLocatorTypeStep : TraversalStep {
	
		///<summary>
		///    Links a Locator to a LocatorType that specifies the spatial context of the coordinate.
		///</summary>
		///<remarks>
		///    Type: LocatorUsesLocatorType
		///    Relation: Uses
		///    Connection: OutToOne
		///</remarks>
		public FabLocatorStep InLocatorListUses { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the InLocatorListUses step.
		///</summary>
		public FabLocator InLocatorListUsesGet() { return null; }
		
	}
	
	
	/*================================================================================================*/
	public class FabMemberStep : TraversalStep {
	
		///<summary>
		///    Links an App to a particular Member.
		///</summary>
		///<remarks>
		///    Type: AppDefinesMember
		///    Relation: Defines
		///    Connection: OutToOneOrMore
		///</remarks>
		public FabAppStep InAppDefines { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the InAppDefines step.
		///</summary>
		public IList<FabApp> InAppDefinesGet() { return null; }
		
		///<summary>
		///    Links a Member to its active MemberTypeAssign.
		///</summary>
		///<remarks>
		///    Type: MemberHasMemberTypeAssign
		///    Relation: Has
		///    Connection: InFromOne
		///</remarks>
		public FabMemberTypeAssignStep HasMemberTypeAssign { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the HasMemberTypeAssign step.
		///</summary>
		public FabMemberTypeAssign HasMemberTypeAssignGet() { return null; }
		
		///<summary>
		///    Links a Member to a historical MemberTypeAssign.
		///</summary>
		///<remarks>
		///    Type: MemberHasHistoricMemberTypeAssign
		///    Relation: HasHistoric
		///    Connection: InFromOne
		///</remarks>
		public FabMemberTypeAssignStep HasHistoricMemberTypeAssignList { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the HasHistoricMemberTypeAssignList step.
		///</summary>
		public FabMemberTypeAssign HasHistoricMemberTypeAssignListGet() { return null; }
		
		///<summary>
		///    Links a Member to the Artifact that it created.
		///</summary>
		///<remarks>
		///    Type: MemberCreatesArtifact
		///    Relation: Creates
		///    Connection: InFromOne
		///</remarks>
		public FabArtifactStep CreatesArtifactList { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the CreatesArtifactList step.
		///</summary>
		public FabArtifact CreatesArtifactListGet() { return null; }
		
		///<summary>
		///    Links a Member to the MemberTypeAssign that it created.
		///</summary>
		///<remarks>
		///    Type: MemberCreatesMemberTypeAssign
		///    Relation: Creates
		///    Connection: InFromOne
		///</remarks>
		public FabMemberTypeAssignStep CreatesMemberTypeAssignList { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the CreatesMemberTypeAssignList step.
		///</summary>
		public FabMemberTypeAssign CreatesMemberTypeAssignListGet() { return null; }
		
		///<summary>
		///    Links a Member to the Factor that it created.
		///</summary>
		///<remarks>
		///    Type: MemberCreatesFactor
		///    Relation: Creates
		///    Connection: InFromOne
		///</remarks>
		public FabFactorStep CreatesFactorList { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the CreatesFactorList step.
		///</summary>
		public FabFactor CreatesFactorListGet() { return null; }
		
		///<summary>
		///    Links a User to a particular Member.
		///</summary>
		///<remarks>
		///    Type: UserDefinesMember
		///    Relation: Defines
		///    Connection: OutToOneOrMore
		///</remarks>
		public FabUserStep InUserDefines { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the InUserDefines step.
		///</summary>
		public IList<FabUser> InUserDefinesGet() { return null; }
		
	}
	
	
	/*================================================================================================*/
	public class FabMemberTypeStep : TraversalStep {
	
		///<summary>
		///    Links a MemberTypeAssign to a MemberType that specifies the Member's state and/or access privileges.
		///</summary>
		///<remarks>
		///    Type: MemberTypeAssignUsesMemberType
		///    Relation: Uses
		///    Connection: OutToOne
		///</remarks>
		public FabMemberTypeAssignStep InMemberTypeAssignListUses { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the InMemberTypeAssignListUses step.
		///</summary>
		public FabMemberTypeAssign InMemberTypeAssignListUsesGet() { return null; }
		
	}
	
	
	/*================================================================================================*/
	public class FabMemberTypeAssignStep : TraversalStep {
	
		///<summary>
		///    Links a Member to its active MemberTypeAssign.
		///</summary>
		///<remarks>
		///    Type: MemberHasMemberTypeAssign
		///    Relation: Has
		///    Connection: OutToOne
		///</remarks>
		public FabMemberStep InMemberHas { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the InMemberHas step.
		///</summary>
		public FabMember InMemberHasGet() { return null; }
		
		///<summary>
		///    Links a Member to a historical MemberTypeAssign.
		///</summary>
		///<remarks>
		///    Type: MemberHasHistoricMemberTypeAssign
		///    Relation: HasHistoric
		///    Connection: OutToZeroOrMore
		///</remarks>
		public FabMemberStep InMemberHasHistoric { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the InMemberHasHistoric step.
		///</summary>
		public IList<FabMember> InMemberHasHistoricGet() { return null; }
		
		///<summary>
		///    Links a Member to the MemberTypeAssign that it created.
		///</summary>
		///<remarks>
		///    Type: MemberCreatesMemberTypeAssign
		///    Relation: Creates
		///    Connection: OutToZeroOrMore
		///</remarks>
		public FabMemberStep InMemberCreates { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the InMemberCreates step.
		///</summary>
		public IList<FabMember> InMemberCreatesGet() { return null; }
		
		///<summary>
		///    Links a MemberTypeAssign to a MemberType that specifies the Member's state and/or access privileges.
		///</summary>
		///<remarks>
		///    Type: MemberTypeAssignUsesMemberType
		///    Relation: Uses
		///    Connection: InFromZeroOrMore
		///</remarks>
		public FabMemberTypeStep UsesMemberType { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the UsesMemberType step.
		///</summary>
		public IList<FabMemberType> UsesMemberTypeGet() { return null; }
		
	}
	
	
	/*================================================================================================*/
	public class FabRootStep : TraversalStep {
	
		///<summary>
		///    Links the Root node to an App.
		///</summary>
		///<remarks>
		///    Type: RootContainsApp
		///    Relation: Contains
		///    Connection: InFromOne
		///</remarks>
		public FabAppStep ContainsAppList { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the ContainsAppList step.
		///</summary>
		public FabApp ContainsAppListGet() { return null; }
		
		///<summary>
		///    Links the Root node to an Artifact.
		///</summary>
		///<remarks>
		///    Type: RootContainsArtifact
		///    Relation: Contains
		///    Connection: InFromOne
		///</remarks>
		public FabArtifactStep ContainsArtifactList { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the ContainsArtifactList step.
		///</summary>
		public FabArtifact ContainsArtifactListGet() { return null; }
		
		///<summary>
		///    Links the Root node to an ArtifactType.
		///</summary>
		///<remarks>
		///    Type: RootContainsArtifactType
		///    Relation: Contains
		///    Connection: InFromOne
		///</remarks>
		public FabArtifactTypeStep ContainsArtifactTypeList { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the ContainsArtifactTypeList step.
		///</summary>
		public FabArtifactType ContainsArtifactTypeListGet() { return null; }
		
		///<summary>
		///    Links the Root node to a Class.
		///</summary>
		///<remarks>
		///    Type: RootContainsClass
		///    Relation: Contains
		///    Connection: InFromOne
		///</remarks>
		public FabClassStep ContainsClassList { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the ContainsClassList step.
		///</summary>
		public FabClass ContainsClassListGet() { return null; }
		
		///<summary>
		///    Links the Root node to an Instance.
		///</summary>
		///<remarks>
		///    Type: RootContainsInstance
		///    Relation: Contains
		///    Connection: InFromOne
		///</remarks>
		public FabInstanceStep ContainsInstanceList { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the ContainsInstanceList step.
		///</summary>
		public FabInstance ContainsInstanceListGet() { return null; }
		
		///<summary>
		///    Links the Root node to a Member.
		///</summary>
		///<remarks>
		///    Type: RootContainsMember
		///    Relation: Contains
		///    Connection: InFromOne
		///</remarks>
		public FabMemberStep ContainsMemberList { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the ContainsMemberList step.
		///</summary>
		public FabMember ContainsMemberListGet() { return null; }
		
		///<summary>
		///    Links the Root node to a MemberType.
		///</summary>
		///<remarks>
		///    Type: RootContainsMemberType
		///    Relation: Contains
		///    Connection: InFromOne
		///</remarks>
		public FabMemberTypeStep ContainsMemberTypeList { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the ContainsMemberTypeList step.
		///</summary>
		public FabMemberType ContainsMemberTypeListGet() { return null; }
		
		///<summary>
		///    Links the Root node to a MemberTypeAssign.
		///</summary>
		///<remarks>
		///    Type: RootContainsMemberTypeAssign
		///    Relation: Contains
		///    Connection: InFromOne
		///</remarks>
		public FabMemberTypeAssignStep ContainsMemberTypeAssignList { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the ContainsMemberTypeAssignList step.
		///</summary>
		public FabMemberTypeAssign ContainsMemberTypeAssignListGet() { return null; }
		
		///<summary>
		///    Links the Root node to a Url.
		///</summary>
		///<remarks>
		///    Type: RootContainsUrl
		///    Relation: Contains
		///    Connection: InFromOne
		///</remarks>
		public FabUrlStep ContainsUrlList { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the ContainsUrlList step.
		///</summary>
		public FabUrl ContainsUrlListGet() { return null; }
		
		///<summary>
		///    Links the Root node to a User.
		///</summary>
		///<remarks>
		///    Type: RootContainsUser
		///    Relation: Contains
		///    Connection: InFromOne
		///</remarks>
		public FabUserStep ContainsUserList { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the ContainsUserList step.
		///</summary>
		public FabUser ContainsUserListGet() { return null; }
		
		///<summary>
		///    Links the Root node to a Factor.
		///</summary>
		///<remarks>
		///    Type: RootContainsFactor
		///    Relation: Contains
		///    Connection: InFromOne
		///</remarks>
		public FabFactorStep ContainsFactorList { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the ContainsFactorList step.
		///</summary>
		public FabFactor ContainsFactorListGet() { return null; }
		
		///<summary>
		///    Links the Root node to a FactorAssertion.
		///</summary>
		///<remarks>
		///    Type: RootContainsFactorAssertion
		///    Relation: Contains
		///    Connection: InFromOne
		///</remarks>
		public FabFactorAssertionStep ContainsFactorAssertionList { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the ContainsFactorAssertionList step.
		///</summary>
		public FabFactorAssertion ContainsFactorAssertionListGet() { return null; }
		
		///<summary>
		///    Links the Root node to a Descriptor.
		///</summary>
		///<remarks>
		///    Type: RootContainsDescriptor
		///    Relation: Contains
		///    Connection: InFromOne
		///</remarks>
		public FabDescriptorStep ContainsDescriptorList { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the ContainsDescriptorList step.
		///</summary>
		public FabDescriptor ContainsDescriptorListGet() { return null; }
		
		///<summary>
		///    Links the Root node to a DescriptorType.
		///</summary>
		///<remarks>
		///    Type: RootContainsDescriptorType
		///    Relation: Contains
		///    Connection: InFromOne
		///</remarks>
		public FabDescriptorTypeStep ContainsDescriptorTypeList { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the ContainsDescriptorTypeList step.
		///</summary>
		public FabDescriptorType ContainsDescriptorTypeListGet() { return null; }
		
		///<summary>
		///    Links the Root node to a Director.
		///</summary>
		///<remarks>
		///    Type: RootContainsDirector
		///    Relation: Contains
		///    Connection: InFromOne
		///</remarks>
		public FabDirectorStep ContainsDirectorList { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the ContainsDirectorList step.
		///</summary>
		public FabDirector ContainsDirectorListGet() { return null; }
		
		///<summary>
		///    Links the Root node to a DirectorType.
		///</summary>
		///<remarks>
		///    Type: RootContainsDirectorType
		///    Relation: Contains
		///    Connection: InFromOne
		///</remarks>
		public FabDirectorTypeStep ContainsDirectorTypeList { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the ContainsDirectorTypeList step.
		///</summary>
		public FabDirectorType ContainsDirectorTypeListGet() { return null; }
		
		///<summary>
		///    Links the Root node to a DirectorAction.
		///</summary>
		///<remarks>
		///    Type: RootContainsDirectorAction
		///    Relation: Contains
		///    Connection: InFromOne
		///</remarks>
		public FabDirectorActionStep ContainsDirectorActionList { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the ContainsDirectorActionList step.
		///</summary>
		public FabDirectorAction ContainsDirectorActionListGet() { return null; }
		
		///<summary>
		///    Links the Root node to an Eventor.
		///</summary>
		///<remarks>
		///    Type: RootContainsEventor
		///    Relation: Contains
		///    Connection: InFromOne
		///</remarks>
		public FabEventorStep ContainsEventorList { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the ContainsEventorList step.
		///</summary>
		public FabEventor ContainsEventorListGet() { return null; }
		
		///<summary>
		///    Links the Root node to an EventorType.
		///</summary>
		///<remarks>
		///    Type: RootContainsEventorType
		///    Relation: Contains
		///    Connection: InFromOne
		///</remarks>
		public FabEventorTypeStep ContainsEventorTypeList { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the ContainsEventorTypeList step.
		///</summary>
		public FabEventorType ContainsEventorTypeListGet() { return null; }
		
		///<summary>
		///    Links the Root node to an EventorPrecision.
		///</summary>
		///<remarks>
		///    Type: RootContainsEventorPrecision
		///    Relation: Contains
		///    Connection: InFromOne
		///</remarks>
		public FabEventorPrecisionStep ContainsEventorPrecisionList { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the ContainsEventorPrecisionList step.
		///</summary>
		public FabEventorPrecision ContainsEventorPrecisionListGet() { return null; }
		
		///<summary>
		///    Links the Root node to an Identor.
		///</summary>
		///<remarks>
		///    Type: RootContainsIdentor
		///    Relation: Contains
		///    Connection: InFromOne
		///</remarks>
		public FabIdentorStep ContainsIdentorList { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the ContainsIdentorList step.
		///</summary>
		public FabIdentor ContainsIdentorListGet() { return null; }
		
		///<summary>
		///    Links the Root node to an IdentorType.
		///</summary>
		///<remarks>
		///    Type: RootContainsIdentorType
		///    Relation: Contains
		///    Connection: InFromOne
		///</remarks>
		public FabIdentorTypeStep ContainsIdentorTypeList { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the ContainsIdentorTypeList step.
		///</summary>
		public FabIdentorType ContainsIdentorTypeListGet() { return null; }
		
		///<summary>
		///    Links the Root node to a Locator.
		///</summary>
		///<remarks>
		///    Type: RootContainsLocator
		///    Relation: Contains
		///    Connection: InFromOne
		///</remarks>
		public FabLocatorStep ContainsLocatorList { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the ContainsLocatorList step.
		///</summary>
		public FabLocator ContainsLocatorListGet() { return null; }
		
		///<summary>
		///    Links the Root node to a LocatorType.
		///</summary>
		///<remarks>
		///    Type: RootContainsLocatorType
		///    Relation: Contains
		///    Connection: InFromOne
		///</remarks>
		public FabLocatorTypeStep ContainsLocatorTypeList { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the ContainsLocatorTypeList step.
		///</summary>
		public FabLocatorType ContainsLocatorTypeListGet() { return null; }
		
		///<summary>
		///    Links the Root node to a Vector.
		///</summary>
		///<remarks>
		///    Type: RootContainsVector
		///    Relation: Contains
		///    Connection: InFromOne
		///</remarks>
		public FabVectorStep ContainsVectorList { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the ContainsVectorList step.
		///</summary>
		public FabVector ContainsVectorListGet() { return null; }
		
		///<summary>
		///    Links the Root node to a VectorType.
		///</summary>
		///<remarks>
		///    Type: RootContainsVectorType
		///    Relation: Contains
		///    Connection: InFromOne
		///</remarks>
		public FabVectorTypeStep ContainsVectorTypeList { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the ContainsVectorTypeList step.
		///</summary>
		public FabVectorType ContainsVectorTypeListGet() { return null; }
		
		///<summary>
		///    Links the Root node to a VectorRange.
		///</summary>
		///<remarks>
		///    Type: RootContainsVectorRange
		///    Relation: Contains
		///    Connection: InFromOne
		///</remarks>
		public FabVectorRangeStep ContainsVectorRangeList { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the ContainsVectorRangeList step.
		///</summary>
		public FabVectorRange ContainsVectorRangeListGet() { return null; }
		
		///<summary>
		///    Links the Root node to a VectorRangeLevel.
		///</summary>
		///<remarks>
		///    Type: RootContainsVectorRangeLevel
		///    Relation: Contains
		///    Connection: InFromOne
		///</remarks>
		public FabVectorRangeLevelStep ContainsVectorRangeLevelList { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the ContainsVectorRangeLevelList step.
		///</summary>
		public FabVectorRangeLevel ContainsVectorRangeLevelListGet() { return null; }
		
		///<summary>
		///    Links the Root node to a VectorUnit.
		///</summary>
		///<remarks>
		///    Type: RootContainsVectorUnit
		///    Relation: Contains
		///    Connection: InFromOne
		///</remarks>
		public FabVectorUnitStep ContainsVectorUnitList { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the ContainsVectorUnitList step.
		///</summary>
		public FabVectorUnit ContainsVectorUnitListGet() { return null; }
		
		///<summary>
		///    Links the Root node to a VectorUnitPrefix.
		///</summary>
		///<remarks>
		///    Type: RootContainsVectorUnitPrefix
		///    Relation: Contains
		///    Connection: InFromOne
		///</remarks>
		public FabVectorUnitPrefixStep ContainsVectorUnitPrefixList { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the ContainsVectorUnitPrefixList step.
		///</summary>
		public FabVectorUnitPrefix ContainsVectorUnitPrefixListGet() { return null; }
		
		///<summary>
		///    Links the Root node to a VectorUnitDerived.
		///</summary>
		///<remarks>
		///    Type: RootContainsVectorUnitDerived
		///    Relation: Contains
		///    Connection: InFromOne
		///</remarks>
		public FabVectorUnitDerivedStep ContainsVectorUnitDerivedList { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the ContainsVectorUnitDerivedList step.
		///</summary>
		public FabVectorUnitDerived ContainsVectorUnitDerivedListGet() { return null; }
		
	}
	
	
	/*================================================================================================*/
	public class FabUrlStep : TraversalStep {
	
		///<summary>
		///    Links a Url to the Artifact that it owns.
		///</summary>
		///<remarks>
		///    Type: UrlHasArtifact
		///    Relation: Has
		///    Connection: InFromZeroOrOne
		///</remarks>
		public FabArtifactStep HasArtifact { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the HasArtifact step.
		///</summary>
		public FabArtifact HasArtifactGet() { return null; }
		
	}
	
	
	/*================================================================================================*/
	public class FabUserStep : TraversalStep {
	
		///<summary>
		///    Links a User to the Artifact that it owns.
		///</summary>
		///<remarks>
		///    Type: UserHasArtifact
		///    Relation: Has
		///    Connection: InFromZeroOrOne
		///</remarks>
		public FabArtifactStep HasArtifact { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the HasArtifact step.
		///</summary>
		public FabArtifact HasArtifactGet() { return null; }
		
		///<summary>
		///    Links a User to a particular Member.
		///</summary>
		///<remarks>
		///    Type: UserDefinesMember
		///    Relation: Defines
		///    Connection: InFromOne
		///</remarks>
		public FabMemberStep DefinesMemberList { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the DefinesMemberList step.
		///</summary>
		public FabMember DefinesMemberListGet() { return null; }
		
	}
	
	
	/*================================================================================================*/
	public class FabVectorStep : TraversalStep {
	
		///<summary>
		///    Links a Factor to its Vector Element, which applies a numeric axis and value.
		///</summary>
		///<remarks>
		///    Type: FactorUsesVector
		///    Relation: Uses
		///    Connection: OutToZeroOrOne
		///</remarks>
		public FabFactorStep InFactorListUses { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the InFactorListUses step.
		///</summary>
		public FabFactor InFactorListUsesGet() { return null; }
		
		///<summary>
		///    Links a Vector to an Artifact that 'labels' its value's axis.
		///</summary>
		///<remarks>
		///    Type: VectorUsesAxisArtifact
		///    Relation: UsesAxis
		///    Connection: InFromZeroOrMore
		///</remarks>
		public FabArtifactStep UsesAxisArtifact { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the UsesAxisArtifact step.
		///</summary>
		public IList<FabArtifact> UsesAxisArtifactGet() { return null; }
		
		///<summary>
		///    Links a Vector to a VectorType that specifies its value's boundaries and context.
		///</summary>
		///<remarks>
		///    Type: VectorUsesVectorType
		///    Relation: Uses
		///    Connection: InFromZeroOrMore
		///</remarks>
		public FabVectorTypeStep UsesVectorType { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the UsesVectorType step.
		///</summary>
		public IList<FabVectorType> UsesVectorTypeGet() { return null; }
		
		///<summary>
		///    Links a Vector to a VectorUnit that specifies its value's unit of measurement.
		///</summary>
		///<remarks>
		///    Type: VectorUsesVectorUnit
		///    Relation: Uses
		///    Connection: InFromZeroOrMore
		///</remarks>
		public FabVectorUnitStep UsesVectorUnit { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the UsesVectorUnit step.
		///</summary>
		public IList<FabVectorUnit> UsesVectorUnitGet() { return null; }
		
		///<summary>
		///    Links a Vector to a VectorUnitPrefix that specifies its value's order of magnitude.
		///</summary>
		///<remarks>
		///    Type: VectorUsesVectorUnitPrefix
		///    Relation: Uses
		///    Connection: InFromZeroOrMore
		///</remarks>
		public FabVectorUnitPrefixStep UsesVectorUnitPrefix { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the UsesVectorUnitPrefix step.
		///</summary>
		public IList<FabVectorUnitPrefix> UsesVectorUnitPrefixGet() { return null; }
		
	}
	
	
	/*================================================================================================*/
	public class FabVectorRangeStep : TraversalStep {
	
		///<summary>
		///    Links a VectorType to a VectorRange that specifies a meaningful points/labels mapped to the numerical range.
		///</summary>
		///<remarks>
		///    Type: VectorTypeUsesVectorRange
		///    Relation: Uses
		///    Connection: OutToOne
		///</remarks>
		public FabVectorTypeStep InVectorTypeListUses { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the InVectorTypeListUses step.
		///</summary>
		public FabVectorType InVectorTypeListUsesGet() { return null; }
		
		///<summary>
		///    Links a VectorRange to one of the VectorRangeLevels that help give it meaning.
		///</summary>
		///<remarks>
		///    Type: VectorRangeUsesVectorRangeLevel
		///    Relation: Uses
		///    Connection: InFromZeroOrMore
		///</remarks>
		public FabVectorRangeLevelStep UsesVectorRangeLevelList { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the UsesVectorRangeLevelList step.
		///</summary>
		public IList<FabVectorRangeLevel> UsesVectorRangeLevelListGet() { return null; }
		
	}
	
	
	/*================================================================================================*/
	public class FabVectorRangeLevelStep : TraversalStep {
	
		///<summary>
		///    Links a VectorRange to one of the VectorRangeLevels that help give it meaning.
		///</summary>
		///<remarks>
		///    Type: VectorRangeUsesVectorRangeLevel
		///    Relation: Uses
		///    Connection: OutToZeroOrMore
		///</remarks>
		public FabVectorRangeStep InVectorRangeListUses { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the InVectorRangeListUses step.
		///</summary>
		public IList<FabVectorRange> InVectorRangeListUsesGet() { return null; }
		
	}
	
	
	/*================================================================================================*/
	public class FabVectorTypeStep : TraversalStep {
	
		///<summary>
		///    Links a Vector to a VectorType that specifies its value's boundaries and context.
		///</summary>
		///<remarks>
		///    Type: VectorUsesVectorType
		///    Relation: Uses
		///    Connection: OutToOne
		///</remarks>
		public FabVectorStep InVectorListUses { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the InVectorListUses step.
		///</summary>
		public FabVector InVectorListUsesGet() { return null; }
		
		///<summary>
		///    Links a VectorType to a VectorRange that specifies a meaningful points/labels mapped to the numerical range.
		///</summary>
		///<remarks>
		///    Type: VectorTypeUsesVectorRange
		///    Relation: Uses
		///    Connection: InFromZeroOrMore
		///</remarks>
		public FabVectorRangeStep UsesVectorRange { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the UsesVectorRange step.
		///</summary>
		public IList<FabVectorRange> UsesVectorRangeGet() { return null; }
		
	}
	
	
	/*================================================================================================*/
	public class FabVectorUnitStep : TraversalStep {
	
		///<summary>
		///    Links a Vector to a VectorUnit that specifies its value's unit of measurement.
		///</summary>
		///<remarks>
		///    Type: VectorUsesVectorUnit
		///    Relation: Uses
		///    Connection: OutToOne
		///</remarks>
		public FabVectorStep InVectorListUses { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the InVectorListUses step.
		///</summary>
		public FabVector InVectorListUsesGet() { return null; }
		
		///<summary>
		///    TODO
		///</summary>
		///<remarks>
		///    Type: VectorUnitDerivedDefinesVectorUnit
		///    Relation: Defines
		///    Connection: OutToOne
		///</remarks>
		public FabVectorUnitDerivedStep InVectorUnitDerivedListDefines { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the InVectorUnitDerivedListDefines step.
		///</summary>
		public FabVectorUnitDerived InVectorUnitDerivedListDefinesGet() { return null; }
		
		///<summary>
		///    TODO
		///</summary>
		///<remarks>
		///    Type: VectorUnitDerivedRaisesToExpVectorUnit
		///    Relation: RaisesToExp
		///    Connection: OutToOne
		///</remarks>
		public FabVectorUnitDerivedStep InVectorUnitDerivedListRaisesToExp { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the InVectorUnitDerivedListRaisesToExp step.
		///</summary>
		public FabVectorUnitDerived InVectorUnitDerivedListRaisesToExpGet() { return null; }
		
	}
	
	
	/*================================================================================================*/
	public class FabVectorUnitDerivedStep : TraversalStep {
	
		///<summary>
		///    TODO
		///</summary>
		///<remarks>
		///    Type: VectorUnitDerivedDefinesVectorUnit
		///    Relation: Defines
		///    Connection: InFromZeroOrMore
		///</remarks>
		public FabVectorUnitStep DefinesVectorUnit { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the DefinesVectorUnit step.
		///</summary>
		public IList<FabVectorUnit> DefinesVectorUnitGet() { return null; }
		
		///<summary>
		///    TODO
		///</summary>
		///<remarks>
		///    Type: VectorUnitDerivedRaisesToExpVectorUnit
		///    Relation: RaisesToExp
		///    Connection: InFromZeroOrMore
		///</remarks>
		public FabVectorUnitStep RaisesToExpVectorUnit { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the RaisesToExpVectorUnit step.
		///</summary>
		public IList<FabVectorUnit> RaisesToExpVectorUnitGet() { return null; }
		
		///<summary>
		///    TODO
		///</summary>
		///<remarks>
		///    Type: VectorUnitDerivedUsesVectorUnitPrefix
		///    Relation: Uses
		///    Connection: InFromZeroOrMore
		///</remarks>
		public FabVectorUnitPrefixStep UsesVectorUnitPrefix { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the UsesVectorUnitPrefix step.
		///</summary>
		public IList<FabVectorUnitPrefix> UsesVectorUnitPrefixGet() { return null; }
		
	}
	
	
	/*================================================================================================*/
	public class FabVectorUnitPrefixStep : TraversalStep {
	
		///<summary>
		///    Links a Vector to a VectorUnitPrefix that specifies its value's order of magnitude.
		///</summary>
		///<remarks>
		///    Type: VectorUsesVectorUnitPrefix
		///    Relation: Uses
		///    Connection: OutToOne
		///</remarks>
		public FabVectorStep InVectorListUses { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the InVectorListUses step.
		///</summary>
		public FabVector InVectorListUsesGet() { return null; }
		
		///<summary>
		///    TODO
		///</summary>
		///<remarks>
		///    Type: VectorUnitDerivedUsesVectorUnitPrefix
		///    Relation: Uses
		///    Connection: OutToOne
		///</remarks>
		public FabVectorUnitDerivedStep InVectorUnitDerivedListUses { get; set; }
		
		///<summary>
		///    Complete the Traversal request with the InVectorUnitDerivedListUses step.
		///</summary>
		public FabVectorUnitDerived InVectorUnitDerivedListUsesGet() { return null; }
		
	}
	
	
}