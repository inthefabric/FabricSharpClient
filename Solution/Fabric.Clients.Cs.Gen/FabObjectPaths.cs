using System.Collections.Generic;

namespace Fabric.Clients.Cs.Infrastructure {

	/*================================================================================================*/
	public class FabAppPath {
	
		///<summary>
		///    Links an App to the Artifact that it owns.
		///</summary>
		///<remarks>
		///    Type: AppHasArtifact
		///    Relation: Has
		///    Connection: InFromZeroOrOne
		///</remarks>
		public FabArtifactPath HasArtifact { get; set; }
		
		///<summary>
		///    Links an App to a particular Member.
		///</summary>
		///<remarks>
		///    Type: AppDefinesMember
		///    Relation: Defines
		///    Connection: InFromOne
		///</remarks>
		public FabMemberPath DefinesMemberList { get; set; }
		
	}
	
	
	/*================================================================================================*/
	public class FabArtifactPath {
	
		///<summary>
		///    Links an App to the Artifact that it owns.
		///</summary>
		///<remarks>
		///    Type: AppHasArtifact
		///    Relation: Has
		///    Connection: OutToOne
		///</remarks>
		public FabAppPath InAppHas { get; set; }
		
		///<summary>
		///    Links an Artifact to an ArtifactType that describes the type of the associated ArtifactOwnerNode.
		///</summary>
		///<remarks>
		///    Type: ArtifactUsesArtifactType
		///    Relation: Uses
		///    Connection: InFromZeroOrMore
		///</remarks>
		public IList<FabArtifactTypePath> UsesArtifactType { get; set; }
		
		///<summary>
		///    Links an App to the Class that it owns.
		///</summary>
		///<remarks>
		///    Type: ClassHasArtifact
		///    Relation: Has
		///    Connection: OutToOne
		///</remarks>
		public FabClassPath InClassHas { get; set; }
		
		///<summary>
		///    Links an App to the Instance that it owns.
		///</summary>
		///<remarks>
		///    Type: InstanceHasArtifact
		///    Relation: Has
		///    Connection: OutToOne
		///</remarks>
		public FabInstancePath InInstanceHas { get; set; }
		
		///<summary>
		///    Links a Member to the Artifact that it created.
		///</summary>
		///<remarks>
		///    Type: MemberCreatesArtifact
		///    Relation: Creates
		///    Connection: OutToZeroOrMore
		///</remarks>
		public IList<FabMemberPath> InMemberCreates { get; set; }
		
		///<summary>
		///    Links a Url to the Artifact that it owns.
		///</summary>
		///<remarks>
		///    Type: UrlHasArtifact
		///    Relation: Has
		///    Connection: OutToOne
		///</remarks>
		public FabUrlPath InUrlHas { get; set; }
		
		///<summary>
		///    Links a User to the Artifact that it owns.
		///</summary>
		///<remarks>
		///    Type: UserHasArtifact
		///    Relation: Has
		///    Connection: OutToOne
		///</remarks>
		public FabUserPath InUserHas { get; set; }
		
		///<summary>
		///    Links a Factor to its primary Artifact, which represents the starting point of the Factor's directional Artifact relationship.
		///</summary>
		///<remarks>
		///    Type: FactorUsesPrimaryArtifact
		///    Relation: UsesPrimary
		///    Connection: OutToOne
		///</remarks>
		public FabFactorPath InFactorListUsesPrimary { get; set; }
		
		///<summary>
		///    Links a Factor to its related Artifact, which represents the ending point of the Factor's directional Artifact relationship.
		///</summary>
		///<remarks>
		///    Type: FactorUsesRelatedArtifact
		///    Relation: UsesRelated
		///    Connection: OutToOne
		///</remarks>
		public FabFactorPath InFactorListUsesRelated { get; set; }
		
		///<summary>
		///    Links a Descriptor to an Artifact that specifies or clarifies a particular aspect of the Factor's primary Artifact.
		///</summary>
		///<remarks>
		///    Type: DescriptorRefinesPrimaryWithArtifact
		///    Relation: RefinesPrimaryWith
		///    Connection: OutToZeroOrOne
		///</remarks>
		public FabDescriptorPath InDescriptorListRefinesPrimaryWith { get; set; }
		
		///<summary>
		///    Links a Descriptor to an Artifact that specifies or clarifies a particular aspect of the Factor's related Artifact.
		///</summary>
		///<remarks>
		///    Type: DescriptorRefinesRelatedWithArtifact
		///    Relation: RefinesRelatedWith
		///    Connection: OutToZeroOrOne
		///</remarks>
		public FabDescriptorPath InDescriptorListRefinesRelatedWith { get; set; }
		
		///<summary>
		///    Links a Descriptor to an Artifact that specifies or clarifies a particular aspect of the DescriptorType's meaning or purpose.
		///</summary>
		///<remarks>
		///    Type: DescriptorRefinesTypeWithArtifact
		///    Relation: RefinesTypeWith
		///    Connection: OutToZeroOrOne
		///</remarks>
		public FabDescriptorPath InDescriptorListRefinesTypeWith { get; set; }
		
		///<summary>
		///    Links a Vector to an Artifact that 'labels' its value's axis.
		///</summary>
		///<remarks>
		///    Type: VectorUsesAxisArtifact
		///    Relation: UsesAxis
		///    Connection: OutToOne
		///</remarks>
		public FabVectorPath InVectorListUsesAxis { get; set; }
		
	}
	
	
	/*================================================================================================*/
	public class FabArtifactTypePath {
	
		///<summary>
		///    Links an Artifact to an ArtifactType that describes the type of the associated ArtifactOwnerNode.
		///</summary>
		///<remarks>
		///    Type: ArtifactUsesArtifactType
		///    Relation: Uses
		///    Connection: OutToOne
		///</remarks>
		public FabArtifactPath InArtifactListUses { get; set; }
		
	}
	
	
	/*================================================================================================*/
	public class FabClassPath {
	
		///<summary>
		///    Links an App to the Class that it owns.
		///</summary>
		///<remarks>
		///    Type: ClassHasArtifact
		///    Relation: Has
		///    Connection: InFromZeroOrOne
		///</remarks>
		public FabArtifactPath HasArtifact { get; set; }
		
	}
	
	
	/*================================================================================================*/
	public class FabDescriptorPath {
	
		///<summary>
		///    Links a Factor to its Descriptor Element, which defines the relationship between the primary and related Artifact.
		///</summary>
		///<remarks>
		///    Type: FactorUsesDescriptor
		///    Relation: Uses
		///    Connection: OutToOne
		///</remarks>
		public FabFactorPath InFactorListUses { get; set; }
		
		///<summary>
		///    Links a Descriptor to a DescriptorType that specifies the type of relationship or connection.
		///</summary>
		///<remarks>
		///    Type: DescriptorUsesDescriptorType
		///    Relation: Uses
		///    Connection: InFromZeroOrMore
		///</remarks>
		public IList<FabDescriptorTypePath> UsesDescriptorType { get; set; }
		
		///<summary>
		///    Links a Descriptor to an Artifact that specifies or clarifies a particular aspect of the Factor's primary Artifact.
		///</summary>
		///<remarks>
		///    Type: DescriptorRefinesPrimaryWithArtifact
		///    Relation: RefinesPrimaryWith
		///    Connection: InFromZeroOrMore
		///</remarks>
		public IList<FabArtifactPath> RefinesPrimaryWithArtifact { get; set; }
		
		///<summary>
		///    Links a Descriptor to an Artifact that specifies or clarifies a particular aspect of the Factor's related Artifact.
		///</summary>
		///<remarks>
		///    Type: DescriptorRefinesRelatedWithArtifact
		///    Relation: RefinesRelatedWith
		///    Connection: InFromZeroOrMore
		///</remarks>
		public IList<FabArtifactPath> RefinesRelatedWithArtifact { get; set; }
		
		///<summary>
		///    Links a Descriptor to an Artifact that specifies or clarifies a particular aspect of the DescriptorType's meaning or purpose.
		///</summary>
		///<remarks>
		///    Type: DescriptorRefinesTypeWithArtifact
		///    Relation: RefinesTypeWith
		///    Connection: InFromZeroOrMore
		///</remarks>
		public IList<FabArtifactPath> RefinesTypeWithArtifact { get; set; }
		
	}
	
	
	/*================================================================================================*/
	public class FabDescriptorTypePath {
	
		///<summary>
		///    Links a Descriptor to a DescriptorType that specifies the type of relationship or connection.
		///</summary>
		///<remarks>
		///    Type: DescriptorUsesDescriptorType
		///    Relation: Uses
		///    Connection: OutToOne
		///</remarks>
		public FabDescriptorPath InDescriptorListUses { get; set; }
		
	}
	
	
	/*================================================================================================*/
	public class FabDirectorPath {
	
		///<summary>
		///    Links a Factor to its Director Element, which creates a directional pathway between the primary and related Artifacts.
		///</summary>
		///<remarks>
		///    Type: FactorUsesDirector
		///    Relation: Uses
		///    Connection: OutToZeroOrOne
		///</remarks>
		public FabFactorPath InFactorListUses { get; set; }
		
		///<summary>
		///    Links a Director to a DirectorType that specifies the type and reason for the pathway.
		///</summary>
		///<remarks>
		///    Type: DirectorUsesDirectorType
		///    Relation: Uses
		///    Connection: InFromZeroOrMore
		///</remarks>
		public IList<FabDirectorTypePath> UsesDirectorType { get; set; }
		
		///<summary>
		///    Links a Director to a DirectorAction that specifies the action to be performed on the Factor's primary Artifact.
		///</summary>
		///<remarks>
		///    Type: DirectorUsesPrimaryDirectorAction
		///    Relation: UsesPrimary
		///    Connection: InFromZeroOrMore
		///</remarks>
		public IList<FabDirectorActionPath> UsesPrimaryDirectorAction { get; set; }
		
		///<summary>
		///    Links a Director to a DirectorAction that specifies the action to be performed on the Factor's related Artifact.
		///</summary>
		///<remarks>
		///    Type: DirectorUsesRelatedDirectorAction
		///    Relation: UsesRelated
		///    Connection: InFromZeroOrMore
		///</remarks>
		public IList<FabDirectorActionPath> UsesRelatedDirectorAction { get; set; }
		
	}
	
	
	/*================================================================================================*/
	public class FabDirectorActionPath {
	
		///<summary>
		///    Links a Director to a DirectorAction that specifies the action to be performed on the Factor's primary Artifact.
		///</summary>
		///<remarks>
		///    Type: DirectorUsesPrimaryDirectorAction
		///    Relation: UsesPrimary
		///    Connection: OutToOne
		///</remarks>
		public FabDirectorPath InDirectorListUsesPrimary { get; set; }
		
		///<summary>
		///    Links a Director to a DirectorAction that specifies the action to be performed on the Factor's related Artifact.
		///</summary>
		///<remarks>
		///    Type: DirectorUsesRelatedDirectorAction
		///    Relation: UsesRelated
		///    Connection: OutToOne
		///</remarks>
		public FabDirectorPath InDirectorListUsesRelated { get; set; }
		
	}
	
	
	/*================================================================================================*/
	public class FabDirectorTypePath {
	
		///<summary>
		///    Links a Director to a DirectorType that specifies the type and reason for the pathway.
		///</summary>
		///<remarks>
		///    Type: DirectorUsesDirectorType
		///    Relation: Uses
		///    Connection: OutToOne
		///</remarks>
		public FabDirectorPath InDirectorListUses { get; set; }
		
	}
	
	
	/*================================================================================================*/
	public class FabEventorPath {
	
		///<summary>
		///    Links a Factor to its Eventor Element, which applies the concept of time.
		///</summary>
		///<remarks>
		///    Type: FactorUsesEventor
		///    Relation: Uses
		///    Connection: OutToZeroOrOne
		///</remarks>
		public FabFactorPath InFactorListUses { get; set; }
		
		///<summary>
		///    Links an Eventor to an EventorType that specifies the significance of this point in time.
		///</summary>
		///<remarks>
		///    Type: EventorUsesEventorType
		///    Relation: Uses
		///    Connection: InFromZeroOrMore
		///</remarks>
		public IList<FabEventorTypePath> UsesEventorType { get; set; }
		
		///<summary>
		///    Links an Eventor to an EventorPrecision that specifies the level of accuracy given to this point in time.
		///</summary>
		///<remarks>
		///    Type: EventorUsesEventorPrecision
		///    Relation: Uses
		///    Connection: InFromZeroOrMore
		///</remarks>
		public IList<FabEventorPrecisionPath> UsesEventorPrecision { get; set; }
		
	}
	
	
	/*================================================================================================*/
	public class FabEventorPrecisionPath {
	
		///<summary>
		///    Links an Eventor to an EventorPrecision that specifies the level of accuracy given to this point in time.
		///</summary>
		///<remarks>
		///    Type: EventorUsesEventorPrecision
		///    Relation: Uses
		///    Connection: OutToOne
		///</remarks>
		public FabEventorPath InEventorListUses { get; set; }
		
	}
	
	
	/*================================================================================================*/
	public class FabEventorTypePath {
	
		///<summary>
		///    Links an Eventor to an EventorType that specifies the significance of this point in time.
		///</summary>
		///<remarks>
		///    Type: EventorUsesEventorType
		///    Relation: Uses
		///    Connection: OutToOne
		///</remarks>
		public FabEventorPath InEventorListUses { get; set; }
		
	}
	
	
	/*================================================================================================*/
	public class FabFactorPath {
	
		///<summary>
		///    Links a Member to the Factor that it created.
		///</summary>
		///<remarks>
		///    Type: MemberCreatesFactor
		///    Relation: Creates
		///    Connection: OutToZeroOrMore
		///</remarks>
		public IList<FabMemberPath> InMemberCreates { get; set; }
		
		///<summary>
		///    Links a Factor to its primary Artifact, which represents the starting point of the Factor's directional Artifact relationship.
		///</summary>
		///<remarks>
		///    Type: FactorUsesPrimaryArtifact
		///    Relation: UsesPrimary
		///    Connection: InFromZeroOrMore
		///</remarks>
		public IList<FabArtifactPath> UsesPrimaryArtifact { get; set; }
		
		///<summary>
		///    Links a Factor to its related Artifact, which represents the ending point of the Factor's directional Artifact relationship.
		///</summary>
		///<remarks>
		///    Type: FactorUsesRelatedArtifact
		///    Relation: UsesRelated
		///    Connection: InFromZeroOrMore
		///</remarks>
		public IList<FabArtifactPath> UsesRelatedArtifact { get; set; }
		
		///<summary>
		///    Links a Factor to a FactorAssertion that specifies the type of information and/or level of confidence.
		///</summary>
		///<remarks>
		///    Type: FactorUsesFactorAssertion
		///    Relation: Uses
		///    Connection: InFromZeroOrMore
		///</remarks>
		public IList<FabFactorAssertionPath> UsesFactorAssertion { get; set; }
		
		///<summary>
		///    Links a new Factor to the Factor that it has replaced.
		///</summary>
		///<remarks>
		///    Type: FactorReplacesFactor
		///    Relation: Replaces
		///    Connection: InFromZeroOrOne
		///</remarks>
		public FabFactorPath ReplacesFactor { get; set; }
		
		///<summary>
		///    Links a Factor to its Descriptor Element, which defines the relationship between the primary and related Artifact.
		///</summary>
		///<remarks>
		///    Type: FactorUsesDescriptor
		///    Relation: Uses
		///    Connection: InFromOneOrMore
		///</remarks>
		public IList<FabDescriptorPath> UsesDescriptor { get; set; }
		
		///<summary>
		///    Links a Factor to its Director Element, which creates a directional pathway between the primary and related Artifacts.
		///</summary>
		///<remarks>
		///    Type: FactorUsesDirector
		///    Relation: Uses
		///    Connection: InFromOneOrMore
		///</remarks>
		public IList<FabDirectorPath> UsesDirector { get; set; }
		
		///<summary>
		///    Links a Factor to its Eventor Element, which applies the concept of time.
		///</summary>
		///<remarks>
		///    Type: FactorUsesEventor
		///    Relation: Uses
		///    Connection: InFromOneOrMore
		///</remarks>
		public IList<FabEventorPath> UsesEventor { get; set; }
		
		///<summary>
		///    Links a Factor to its Identor Element, which applies a name or identifier.
		///</summary>
		///<remarks>
		///    Type: FactorUsesIdentor
		///    Relation: Uses
		///    Connection: InFromOneOrMore
		///</remarks>
		public IList<FabIdentorPath> UsesIdentor { get; set; }
		
		///<summary>
		///    Links a Factor to its Locator Element, which provides a geographical or relative position.
		///</summary>
		///<remarks>
		///    Type: FactorUsesLocator
		///    Relation: Uses
		///    Connection: InFromOneOrMore
		///</remarks>
		public IList<FabLocatorPath> UsesLocator { get; set; }
		
		///<summary>
		///    Links a Factor to its Vector Element, which applies a numeric axis and value.
		///</summary>
		///<remarks>
		///    Type: FactorUsesVector
		///    Relation: Uses
		///    Connection: InFromOneOrMore
		///</remarks>
		public IList<FabVectorPath> UsesVector { get; set; }
		
	}
	
	
	/*================================================================================================*/
	public class FabFactorAssertionPath {
	
		///<summary>
		///    Links a Factor to a FactorAssertion that specifies the type of information and/or level of confidence.
		///</summary>
		///<remarks>
		///    Type: FactorUsesFactorAssertion
		///    Relation: Uses
		///    Connection: OutToOne
		///</remarks>
		public FabFactorPath InFactorListUses { get; set; }
		
	}
	
	
	/*================================================================================================*/
	public class FabIdentorPath {
	
		///<summary>
		///    Links a Factor to its Identor Element, which applies a name or identifier.
		///</summary>
		///<remarks>
		///    Type: FactorUsesIdentor
		///    Relation: Uses
		///    Connection: OutToZeroOrOne
		///</remarks>
		public FabFactorPath InFactorListUses { get; set; }
		
		///<summary>
		///    Links an Identor to an IdentorType that specifies the value's purpose or intent.
		///</summary>
		///<remarks>
		///    Type: IdentorUsesIdentorType
		///    Relation: Uses
		///    Connection: InFromZeroOrMore
		///</remarks>
		public IList<FabIdentorTypePath> UsesIdentorType { get; set; }
		
	}
	
	
	/*================================================================================================*/
	public class FabIdentorTypePath {
	
		///<summary>
		///    Links an Identor to an IdentorType that specifies the value's purpose or intent.
		///</summary>
		///<remarks>
		///    Type: IdentorUsesIdentorType
		///    Relation: Uses
		///    Connection: OutToOne
		///</remarks>
		public FabIdentorPath InIdentorListUses { get; set; }
		
	}
	
	
	/*================================================================================================*/
	public class FabInstancePath {
	
		///<summary>
		///    Links an App to the Instance that it owns.
		///</summary>
		///<remarks>
		///    Type: InstanceHasArtifact
		///    Relation: Has
		///    Connection: InFromZeroOrOne
		///</remarks>
		public FabArtifactPath HasArtifact { get; set; }
		
	}
	
	
	/*================================================================================================*/
	public class FabLocatorPath {
	
		///<summary>
		///    Links a Factor to its Locator Element, which provides a geographical or relative position.
		///</summary>
		///<remarks>
		///    Type: FactorUsesLocator
		///    Relation: Uses
		///    Connection: OutToZeroOrOne
		///</remarks>
		public FabFactorPath InFactorListUses { get; set; }
		
		///<summary>
		///    Links a Locator to a LocatorType that specifies the spatial context of the coordinate.
		///</summary>
		///<remarks>
		///    Type: LocatorUsesLocatorType
		///    Relation: Uses
		///    Connection: InFromZeroOrMore
		///</remarks>
		public IList<FabLocatorTypePath> UsesLocatorType { get; set; }
		
	}
	
	
	/*================================================================================================*/
	public class FabLocatorTypePath {
	
		///<summary>
		///    Links a Locator to a LocatorType that specifies the spatial context of the coordinate.
		///</summary>
		///<remarks>
		///    Type: LocatorUsesLocatorType
		///    Relation: Uses
		///    Connection: OutToOne
		///</remarks>
		public FabLocatorPath InLocatorListUses { get; set; }
		
	}
	
	
	/*================================================================================================*/
	public class FabMemberPath {
	
		///<summary>
		///    Links an App to a particular Member.
		///</summary>
		///<remarks>
		///    Type: AppDefinesMember
		///    Relation: Defines
		///    Connection: OutToOneOrMore
		///</remarks>
		public IList<FabAppPath> InAppDefines { get; set; }
		
		///<summary>
		///    Links a Member to its active MemberTypeAssign.
		///</summary>
		///<remarks>
		///    Type: MemberHasMemberTypeAssign
		///    Relation: Has
		///    Connection: InFromOne
		///</remarks>
		public FabMemberTypeAssignPath HasMemberTypeAssign { get; set; }
		
		///<summary>
		///    Links a Member to a historical MemberTypeAssign.
		///</summary>
		///<remarks>
		///    Type: MemberHasHistoricMemberTypeAssign
		///    Relation: HasHistoric
		///    Connection: InFromOne
		///</remarks>
		public FabMemberTypeAssignPath HasHistoricMemberTypeAssignList { get; set; }
		
		///<summary>
		///    Links a Member to the Artifact that it created.
		///</summary>
		///<remarks>
		///    Type: MemberCreatesArtifact
		///    Relation: Creates
		///    Connection: InFromOne
		///</remarks>
		public FabArtifactPath CreatesArtifactList { get; set; }
		
		///<summary>
		///    Links a Member to the MemberTypeAssign that it created.
		///</summary>
		///<remarks>
		///    Type: MemberCreatesMemberTypeAssign
		///    Relation: Creates
		///    Connection: InFromOne
		///</remarks>
		public FabMemberTypeAssignPath CreatesMemberTypeAssignList { get; set; }
		
		///<summary>
		///    Links a Member to the Factor that it created.
		///</summary>
		///<remarks>
		///    Type: MemberCreatesFactor
		///    Relation: Creates
		///    Connection: InFromOne
		///</remarks>
		public FabFactorPath CreatesFactorList { get; set; }
		
		///<summary>
		///    Links a User to a particular Member.
		///</summary>
		///<remarks>
		///    Type: UserDefinesMember
		///    Relation: Defines
		///    Connection: OutToOneOrMore
		///</remarks>
		public IList<FabUserPath> InUserDefines { get; set; }
		
	}
	
	
	/*================================================================================================*/
	public class FabMemberTypePath {
	
		///<summary>
		///    Links a MemberTypeAssign to a MemberType that specifies the Member's state and/or access privileges.
		///</summary>
		///<remarks>
		///    Type: MemberTypeAssignUsesMemberType
		///    Relation: Uses
		///    Connection: OutToOne
		///</remarks>
		public FabMemberTypeAssignPath InMemberTypeAssignListUses { get; set; }
		
	}
	
	
	/*================================================================================================*/
	public class FabMemberTypeAssignPath {
	
		///<summary>
		///    Links a Member to its active MemberTypeAssign.
		///</summary>
		///<remarks>
		///    Type: MemberHasMemberTypeAssign
		///    Relation: Has
		///    Connection: OutToOne
		///</remarks>
		public FabMemberPath InMemberHas { get; set; }
		
		///<summary>
		///    Links a Member to a historical MemberTypeAssign.
		///</summary>
		///<remarks>
		///    Type: MemberHasHistoricMemberTypeAssign
		///    Relation: HasHistoric
		///    Connection: OutToZeroOrMore
		///</remarks>
		public IList<FabMemberPath> InMemberHasHistoric { get; set; }
		
		///<summary>
		///    Links a Member to the MemberTypeAssign that it created.
		///</summary>
		///<remarks>
		///    Type: MemberCreatesMemberTypeAssign
		///    Relation: Creates
		///    Connection: OutToZeroOrMore
		///</remarks>
		public IList<FabMemberPath> InMemberCreates { get; set; }
		
		///<summary>
		///    Links a MemberTypeAssign to a MemberType that specifies the Member's state and/or access privileges.
		///</summary>
		///<remarks>
		///    Type: MemberTypeAssignUsesMemberType
		///    Relation: Uses
		///    Connection: InFromZeroOrMore
		///</remarks>
		public IList<FabMemberTypePath> UsesMemberType { get; set; }
		
	}
	
	
	/*================================================================================================*/
	public class FabRootPath {
	
		///<summary>
		///    Links the Root node to an App.
		///</summary>
		///<remarks>
		///    Type: RootContainsApp
		///    Relation: Contains
		///    Connection: InFromOne
		///</remarks>
		public FabAppPath ContainsAppList { get; set; }
		
		///<summary>
		///    Links the Root node to an Artifact.
		///</summary>
		///<remarks>
		///    Type: RootContainsArtifact
		///    Relation: Contains
		///    Connection: InFromOne
		///</remarks>
		public FabArtifactPath ContainsArtifactList { get; set; }
		
		///<summary>
		///    Links the Root node to an ArtifactType.
		///</summary>
		///<remarks>
		///    Type: RootContainsArtifactType
		///    Relation: Contains
		///    Connection: InFromOne
		///</remarks>
		public FabArtifactTypePath ContainsArtifactTypeList { get; set; }
		
		///<summary>
		///    Links the Root node to a Class.
		///</summary>
		///<remarks>
		///    Type: RootContainsClass
		///    Relation: Contains
		///    Connection: InFromOne
		///</remarks>
		public FabClassPath ContainsClassList { get; set; }
		
		///<summary>
		///    Links the Root node to an Instance.
		///</summary>
		///<remarks>
		///    Type: RootContainsInstance
		///    Relation: Contains
		///    Connection: InFromOne
		///</remarks>
		public FabInstancePath ContainsInstanceList { get; set; }
		
		///<summary>
		///    Links the Root node to a Member.
		///</summary>
		///<remarks>
		///    Type: RootContainsMember
		///    Relation: Contains
		///    Connection: InFromOne
		///</remarks>
		public FabMemberPath ContainsMemberList { get; set; }
		
		///<summary>
		///    Links the Root node to a MemberType.
		///</summary>
		///<remarks>
		///    Type: RootContainsMemberType
		///    Relation: Contains
		///    Connection: InFromOne
		///</remarks>
		public FabMemberTypePath ContainsMemberTypeList { get; set; }
		
		///<summary>
		///    Links the Root node to a MemberTypeAssign.
		///</summary>
		///<remarks>
		///    Type: RootContainsMemberTypeAssign
		///    Relation: Contains
		///    Connection: InFromOne
		///</remarks>
		public FabMemberTypeAssignPath ContainsMemberTypeAssignList { get; set; }
		
		///<summary>
		///    Links the Root node to a Url.
		///</summary>
		///<remarks>
		///    Type: RootContainsUrl
		///    Relation: Contains
		///    Connection: InFromOne
		///</remarks>
		public FabUrlPath ContainsUrlList { get; set; }
		
		///<summary>
		///    Links the Root node to a User.
		///</summary>
		///<remarks>
		///    Type: RootContainsUser
		///    Relation: Contains
		///    Connection: InFromOne
		///</remarks>
		public FabUserPath ContainsUserList { get; set; }
		
		///<summary>
		///    Links the Root node to a Factor.
		///</summary>
		///<remarks>
		///    Type: RootContainsFactor
		///    Relation: Contains
		///    Connection: InFromOne
		///</remarks>
		public FabFactorPath ContainsFactorList { get; set; }
		
		///<summary>
		///    Links the Root node to a FactorAssertion.
		///</summary>
		///<remarks>
		///    Type: RootContainsFactorAssertion
		///    Relation: Contains
		///    Connection: InFromOne
		///</remarks>
		public FabFactorAssertionPath ContainsFactorAssertionList { get; set; }
		
		///<summary>
		///    Links the Root node to a Descriptor.
		///</summary>
		///<remarks>
		///    Type: RootContainsDescriptor
		///    Relation: Contains
		///    Connection: InFromOne
		///</remarks>
		public FabDescriptorPath ContainsDescriptorList { get; set; }
		
		///<summary>
		///    Links the Root node to a DescriptorType.
		///</summary>
		///<remarks>
		///    Type: RootContainsDescriptorType
		///    Relation: Contains
		///    Connection: InFromOne
		///</remarks>
		public FabDescriptorTypePath ContainsDescriptorTypeList { get; set; }
		
		///<summary>
		///    Links the Root node to a Director.
		///</summary>
		///<remarks>
		///    Type: RootContainsDirector
		///    Relation: Contains
		///    Connection: InFromOne
		///</remarks>
		public FabDirectorPath ContainsDirectorList { get; set; }
		
		///<summary>
		///    Links the Root node to a DirectorType.
		///</summary>
		///<remarks>
		///    Type: RootContainsDirectorType
		///    Relation: Contains
		///    Connection: InFromOne
		///</remarks>
		public FabDirectorTypePath ContainsDirectorTypeList { get; set; }
		
		///<summary>
		///    Links the Root node to a DirectorAction.
		///</summary>
		///<remarks>
		///    Type: RootContainsDirectorAction
		///    Relation: Contains
		///    Connection: InFromOne
		///</remarks>
		public FabDirectorActionPath ContainsDirectorActionList { get; set; }
		
		///<summary>
		///    Links the Root node to an Eventor.
		///</summary>
		///<remarks>
		///    Type: RootContainsEventor
		///    Relation: Contains
		///    Connection: InFromOne
		///</remarks>
		public FabEventorPath ContainsEventorList { get; set; }
		
		///<summary>
		///    Links the Root node to an EventorType.
		///</summary>
		///<remarks>
		///    Type: RootContainsEventorType
		///    Relation: Contains
		///    Connection: InFromOne
		///</remarks>
		public FabEventorTypePath ContainsEventorTypeList { get; set; }
		
		///<summary>
		///    Links the Root node to an EventorPrecision.
		///</summary>
		///<remarks>
		///    Type: RootContainsEventorPrecision
		///    Relation: Contains
		///    Connection: InFromOne
		///</remarks>
		public FabEventorPrecisionPath ContainsEventorPrecisionList { get; set; }
		
		///<summary>
		///    Links the Root node to an Identor.
		///</summary>
		///<remarks>
		///    Type: RootContainsIdentor
		///    Relation: Contains
		///    Connection: InFromOne
		///</remarks>
		public FabIdentorPath ContainsIdentorList { get; set; }
		
		///<summary>
		///    Links the Root node to an IdentorType.
		///</summary>
		///<remarks>
		///    Type: RootContainsIdentorType
		///    Relation: Contains
		///    Connection: InFromOne
		///</remarks>
		public FabIdentorTypePath ContainsIdentorTypeList { get; set; }
		
		///<summary>
		///    Links the Root node to a Locator.
		///</summary>
		///<remarks>
		///    Type: RootContainsLocator
		///    Relation: Contains
		///    Connection: InFromOne
		///</remarks>
		public FabLocatorPath ContainsLocatorList { get; set; }
		
		///<summary>
		///    Links the Root node to a LocatorType.
		///</summary>
		///<remarks>
		///    Type: RootContainsLocatorType
		///    Relation: Contains
		///    Connection: InFromOne
		///</remarks>
		public FabLocatorTypePath ContainsLocatorTypeList { get; set; }
		
		///<summary>
		///    Links the Root node to a Vector.
		///</summary>
		///<remarks>
		///    Type: RootContainsVector
		///    Relation: Contains
		///    Connection: InFromOne
		///</remarks>
		public FabVectorPath ContainsVectorList { get; set; }
		
		///<summary>
		///    Links the Root node to a VectorType.
		///</summary>
		///<remarks>
		///    Type: RootContainsVectorType
		///    Relation: Contains
		///    Connection: InFromOne
		///</remarks>
		public FabVectorTypePath ContainsVectorTypeList { get; set; }
		
		///<summary>
		///    Links the Root node to a VectorRange.
		///</summary>
		///<remarks>
		///    Type: RootContainsVectorRange
		///    Relation: Contains
		///    Connection: InFromOne
		///</remarks>
		public FabVectorRangePath ContainsVectorRangeList { get; set; }
		
		///<summary>
		///    Links the Root node to a VectorRangeLevel.
		///</summary>
		///<remarks>
		///    Type: RootContainsVectorRangeLevel
		///    Relation: Contains
		///    Connection: InFromOne
		///</remarks>
		public FabVectorRangeLevelPath ContainsVectorRangeLevelList { get; set; }
		
		///<summary>
		///    Links the Root node to a VectorUnit.
		///</summary>
		///<remarks>
		///    Type: RootContainsVectorUnit
		///    Relation: Contains
		///    Connection: InFromOne
		///</remarks>
		public FabVectorUnitPath ContainsVectorUnitList { get; set; }
		
		///<summary>
		///    Links the Root node to a VectorUnitPrefix.
		///</summary>
		///<remarks>
		///    Type: RootContainsVectorUnitPrefix
		///    Relation: Contains
		///    Connection: InFromOne
		///</remarks>
		public FabVectorUnitPrefixPath ContainsVectorUnitPrefixList { get; set; }
		
		///<summary>
		///    Links the Root node to a VectorUnitDerived.
		///</summary>
		///<remarks>
		///    Type: RootContainsVectorUnitDerived
		///    Relation: Contains
		///    Connection: InFromOne
		///</remarks>
		public FabVectorUnitDerivedPath ContainsVectorUnitDerivedList { get; set; }
		
	}
	
	
	/*================================================================================================*/
	public class FabUrlPath {
	
		///<summary>
		///    Links a Url to the Artifact that it owns.
		///</summary>
		///<remarks>
		///    Type: UrlHasArtifact
		///    Relation: Has
		///    Connection: InFromZeroOrOne
		///</remarks>
		public FabArtifactPath HasArtifact { get; set; }
		
	}
	
	
	/*================================================================================================*/
	public class FabUserPath {
	
		///<summary>
		///    Links a User to the Artifact that it owns.
		///</summary>
		///<remarks>
		///    Type: UserHasArtifact
		///    Relation: Has
		///    Connection: InFromZeroOrOne
		///</remarks>
		public FabArtifactPath HasArtifact { get; set; }
		
		///<summary>
		///    Links a User to a particular Member.
		///</summary>
		///<remarks>
		///    Type: UserDefinesMember
		///    Relation: Defines
		///    Connection: InFromOne
		///</remarks>
		public FabMemberPath DefinesMemberList { get; set; }
		
	}
	
	
	/*================================================================================================*/
	public class FabVectorPath {
	
		///<summary>
		///    Links a Factor to its Vector Element, which applies a numeric axis and value.
		///</summary>
		///<remarks>
		///    Type: FactorUsesVector
		///    Relation: Uses
		///    Connection: OutToZeroOrOne
		///</remarks>
		public FabFactorPath InFactorListUses { get; set; }
		
		///<summary>
		///    Links a Vector to an Artifact that 'labels' its value's axis.
		///</summary>
		///<remarks>
		///    Type: VectorUsesAxisArtifact
		///    Relation: UsesAxis
		///    Connection: InFromZeroOrMore
		///</remarks>
		public IList<FabArtifactPath> UsesAxisArtifact { get; set; }
		
		///<summary>
		///    Links a Vector to a VectorType that specifies its value's boundaries and context.
		///</summary>
		///<remarks>
		///    Type: VectorUsesVectorType
		///    Relation: Uses
		///    Connection: InFromZeroOrMore
		///</remarks>
		public IList<FabVectorTypePath> UsesVectorType { get; set; }
		
		///<summary>
		///    Links a Vector to a VectorUnit that specifies its value's unit of measurement.
		///</summary>
		///<remarks>
		///    Type: VectorUsesVectorUnit
		///    Relation: Uses
		///    Connection: InFromZeroOrMore
		///</remarks>
		public IList<FabVectorUnitPath> UsesVectorUnit { get; set; }
		
		///<summary>
		///    Links a Vector to a VectorUnitPrefix that specifies its value's order of magnitude.
		///</summary>
		///<remarks>
		///    Type: VectorUsesVectorUnitPrefix
		///    Relation: Uses
		///    Connection: InFromZeroOrMore
		///</remarks>
		public IList<FabVectorUnitPrefixPath> UsesVectorUnitPrefix { get; set; }
		
	}
	
	
	/*================================================================================================*/
	public class FabVectorRangePath {
	
		///<summary>
		///    Links a VectorType to a VectorRange that specifies a meaningful points/labels mapped to the numerical range.
		///</summary>
		///<remarks>
		///    Type: VectorTypeUsesVectorRange
		///    Relation: Uses
		///    Connection: OutToOne
		///</remarks>
		public FabVectorTypePath InVectorTypeListUses { get; set; }
		
		///<summary>
		///    Links a VectorRange to one of the VectorRangeLevels that help give it meaning.
		///</summary>
		///<remarks>
		///    Type: VectorRangeUsesVectorRangeLevel
		///    Relation: Uses
		///    Connection: InFromZeroOrMore
		///</remarks>
		public IList<FabVectorRangeLevelPath> UsesVectorRangeLevelList { get; set; }
		
	}
	
	
	/*================================================================================================*/
	public class FabVectorRangeLevelPath {
	
		///<summary>
		///    Links a VectorRange to one of the VectorRangeLevels that help give it meaning.
		///</summary>
		///<remarks>
		///    Type: VectorRangeUsesVectorRangeLevel
		///    Relation: Uses
		///    Connection: OutToZeroOrMore
		///</remarks>
		public IList<FabVectorRangePath> InVectorRangeListUses { get; set; }
		
	}
	
	
	/*================================================================================================*/
	public class FabVectorTypePath {
	
		///<summary>
		///    Links a Vector to a VectorType that specifies its value's boundaries and context.
		///</summary>
		///<remarks>
		///    Type: VectorUsesVectorType
		///    Relation: Uses
		///    Connection: OutToOne
		///</remarks>
		public FabVectorPath InVectorListUses { get; set; }
		
		///<summary>
		///    Links a VectorType to a VectorRange that specifies a meaningful points/labels mapped to the numerical range.
		///</summary>
		///<remarks>
		///    Type: VectorTypeUsesVectorRange
		///    Relation: Uses
		///    Connection: InFromZeroOrMore
		///</remarks>
		public IList<FabVectorRangePath> UsesVectorRange { get; set; }
		
	}
	
	
	/*================================================================================================*/
	public class FabVectorUnitPath {
	
		///<summary>
		///    Links a Vector to a VectorUnit that specifies its value's unit of measurement.
		///</summary>
		///<remarks>
		///    Type: VectorUsesVectorUnit
		///    Relation: Uses
		///    Connection: OutToOne
		///</remarks>
		public FabVectorPath InVectorListUses { get; set; }
		
		///<summary>
		///    TODO
		///</summary>
		///<remarks>
		///    Type: VectorUnitDerivedDefinesVectorUnit
		///    Relation: Defines
		///    Connection: OutToOne
		///</remarks>
		public FabVectorUnitDerivedPath InVectorUnitDerivedListDefines { get; set; }
		
		///<summary>
		///    TODO
		///</summary>
		///<remarks>
		///    Type: VectorUnitDerivedRaisesToExpVectorUnit
		///    Relation: RaisesToExp
		///    Connection: OutToOne
		///</remarks>
		public FabVectorUnitDerivedPath InVectorUnitDerivedListRaisesToExp { get; set; }
		
	}
	
	
	/*================================================================================================*/
	public class FabVectorUnitDerivedPath {
	
		///<summary>
		///    TODO
		///</summary>
		///<remarks>
		///    Type: VectorUnitDerivedDefinesVectorUnit
		///    Relation: Defines
		///    Connection: InFromZeroOrMore
		///</remarks>
		public IList<FabVectorUnitPath> DefinesVectorUnit { get; set; }
		
		///<summary>
		///    TODO
		///</summary>
		///<remarks>
		///    Type: VectorUnitDerivedRaisesToExpVectorUnit
		///    Relation: RaisesToExp
		///    Connection: InFromZeroOrMore
		///</remarks>
		public IList<FabVectorUnitPath> RaisesToExpVectorUnit { get; set; }
		
		///<summary>
		///    TODO
		///</summary>
		///<remarks>
		///    Type: VectorUnitDerivedUsesVectorUnitPrefix
		///    Relation: Uses
		///    Connection: InFromZeroOrMore
		///</remarks>
		public IList<FabVectorUnitPrefixPath> UsesVectorUnitPrefix { get; set; }
		
	}
	
	
	/*================================================================================================*/
	public class FabVectorUnitPrefixPath {
	
		///<summary>
		///    Links a Vector to a VectorUnitPrefix that specifies its value's order of magnitude.
		///</summary>
		///<remarks>
		///    Type: VectorUsesVectorUnitPrefix
		///    Relation: Uses
		///    Connection: OutToOne
		///</remarks>
		public FabVectorPath InVectorListUses { get; set; }
		
		///<summary>
		///    TODO
		///</summary>
		///<remarks>
		///    Type: VectorUnitDerivedUsesVectorUnitPrefix
		///    Relation: Uses
		///    Connection: OutToOne
		///</remarks>
		public FabVectorUnitDerivedPath InVectorUnitDerivedListUses { get; set; }
		
	}
	
	
}