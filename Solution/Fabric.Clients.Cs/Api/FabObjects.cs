// GENERATED CODE
// Changes made to this source file will be overwritten

using System;

namespace Fabric.Clients.Cs.Api {

	/*================================================================================================*/
	/// <summary>
	///   The response wrapper for most API requests.
	/// </summary>
	/// <remarks>
	///   <para>The response wrapper for most API requests. It contains a data payload, error information, and/or other metadata.</para>
	/// </remarks>
	public partial class FabResponse {
	
		/// <summary>
		///   The time (in milliseconds) that it took the server(s) to complete this request.
		/// </summary>
		public double TotalMs { get; set; }
		
		/// <summary>
		///   If an error occurred, this contains information about the problem.
		/// </summary>
		public FabError Error { get; set; }
		
		/// <summary>
		///   Contains the result of the request as a list of zero or more Objects.
		/// </summary>
		public virtual object DataString { get; set; }
		
	}

	
	/*================================================================================================*/
	/// <summary>
	///   The base class for the creation of Artifacts.
	/// </summary>
	/// <remarks>
	///   <para>The base class for the creation of Artifacts.</para>
	/// </remarks>
	public class CreateFabArtifact : CreateFabVertex {
	
	}

	
	/*================================================================================================*/
	/// <summary>
	///   Contains the data needed to create a new Class.
	/// </summary>
	/// <remarks>
	///   <para>Contains the data needed to create a new Class.</para>
	/// </remarks>
	public class CreateFabClass : CreateFabArtifact {
	
		/// <summary>
		///   The name of the new Class.
		/// </summary>
		public string Name { get; set; }
		
		/// <summary>
		///   The disambiguation text for the new Class.
		/// </summary>
		public string Disamb { get; set; }
		
		/// <summary>
		///   A brief description of the new Class.
		/// </summary>
		public string Note { get; set; }
		
	}

	
	/*================================================================================================*/
	/// <summary>
	///   Contains the data needed to create a new Descriptor.
	/// </summary>
	/// <remarks>
	///   <para>Contains the data needed to create a new Descriptor.</para>
	/// </remarks>
	public class CreateFabDescriptor : CreateFabObject {
	
		/// <summary>
		///   Identifies the DescriptorType for the new Descriptor.
		/// </summary>
		public byte Type { get; set; }
		
		/// <summary>
		///   Identifies the Artifact that refines the Factor's 'sprimary Artifact.
		/// </summary>
		public long? RefinesPrimaryWithArtifactId { get; set; }
		
		/// <summary>
		///   Identifies the Artifact that refines the Factor's 'srelated Artifact.
		/// </summary>
		public long? RefinesRelatedWithArtifactId { get; set; }
		
		/// <summary>
		///   Identifies the Artifact that refines the new Descriptor's 'sDescriptorType.
		/// </summary>
		public long? RefinesTypeWithArtifactId { get; set; }
		

		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Get the static DescriptorType data that is associated with this object's Type value.
		/// </summary>
		public DescriptorType GetTypeData() {
			return FabEnumsData.GetDescriptorType(Type);
		}
		
	}

	
	/*================================================================================================*/
	/// <summary>
	///   Contains the data needed to create a new Director.
	/// </summary>
	/// <remarks>
	///   <para>Contains the data needed to create a new Director.</para>
	/// </remarks>
	public class CreateFabDirector : CreateFabObject {
	
		/// <summary>
		///   Identifies the DirectorType for the new Director.
		/// </summary>
		public byte Type { get; set; }
		
		/// <summary>
		///   Identifies the DirectorAction associated with the Factor's 'sprimary Artifact.
		/// </summary>
		public byte PrimaryAction { get; set; }
		
		/// <summary>
		///   Identifies the DirectorAction associated with the Factor's 'srelated Artifact.
		/// </summary>
		public byte RelatedAction { get; set; }
		

		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Get the static DirectorType data that is associated with this object's Type value.
		/// </summary>
		public DirectorType GetTypeData() {
			return FabEnumsData.GetDirectorType(Type);
		}
		

		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Get the static DirectorAction data that is associated with this object's PrimaryAction value.
		/// </summary>
		public DirectorAction GetPrimaryActionData() {
			return FabEnumsData.GetDirectorAction(PrimaryAction);
		}
		

		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Get the static DirectorAction data that is associated with this object's RelatedAction value.
		/// </summary>
		public DirectorAction GetRelatedActionData() {
			return FabEnumsData.GetDirectorAction(RelatedAction);
		}
		
	}

	
	/*================================================================================================*/
	/// <summary>
	///   The base class for the creation of Elements.
	/// </summary>
	/// <remarks>
	///   <para>The base class for the creation of Elements.</para>
	/// </remarks>
	public class CreateFabElement : CreateFabObject {
	
	}

	
	/*================================================================================================*/
	/// <summary>
	///   Contains the data needed to create a new Eventor.
	/// </summary>
	/// <remarks>
	///   <para>Contains the data needed to create a new Eventor.</para>
	/// </remarks>
	public class CreateFabEventor : CreateFabObject {
	
		/// <summary>
		///   Identifies the EventorType for the new Eventor.
		/// </summary>
		public byte Type { get; set; }
		
		/// <summary>
		///   The year value for the new Eventor.
		/// </summary>
		public long Year { get; set; }
		
		/// <summary>
		///   The month value for the new Eventor.
		/// </summary>
		public byte? Month { get; set; }
		
		/// <summary>
		///   The day value for the new Eventor.
		/// </summary>
		public byte? Day { get; set; }
		
		/// <summary>
		///   The hour value for the new Eventor.
		/// </summary>
		public byte? Hour { get; set; }
		
		/// <summary>
		///   The minute value for the new Eventor.
		/// </summary>
		public byte? Minute { get; set; }
		
		/// <summary>
		///   The second value for the new Eventor.
		/// </summary>
		public byte? Second { get; set; }
		

		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Get the static EventorType data that is associated with this object's Type value.
		/// </summary>
		public EventorType GetTypeData() {
			return FabEnumsData.GetEventorType(Type);
		}
		
	}

	
	/*================================================================================================*/
	/// <summary>
	///   Contains the data needed to create a new Factor.
	/// </summary>
	/// <remarks>
	///   <para>Contains the data needed to create a new Factor.</para>
	/// </remarks>
	public class CreateFabFactor : CreateFabVertex {
	
		/// <summary>
		///   Identifies the FactorAssertion for the new Factor.
		/// </summary>
		public byte AssertionType { get; set; }
		
		/// <summary>
		///   The IsDefining value for the new Factor.
		/// </summary>
		public bool IsDefining { get; set; }
		
		/// <summary>
		///   A sentence or short paragraph describing (in a human-readable format) the intended meaning of the new Factor.
		/// </summary>
		public string Note { get; set; }
		
		/// <summary>
		///   Identifies the primary Artifact for the new Factor.
		/// </summary>
		public long UsesPrimaryArtifactId { get; set; }
		
		/// <summary>
		///   Identifies the related Artifact for the new Factor.
		/// </summary>
		public long UsesRelatedArtifactId { get; set; }
		
		/// <summary>
		///   Provides Descriptor data for the new Factor.
		/// </summary>
		public CreateFabDescriptor Descriptor { get; set; }
		
		/// <summary>
		///   Provides Director data for the new Factor.
		/// </summary>
		public CreateFabDirector Director { get; set; }
		
		/// <summary>
		///   Provides Eventor data for the new Factor.
		/// </summary>
		public CreateFabEventor Eventor { get; set; }
		
		/// <summary>
		///   Provides Identor data for the new Factor.
		/// </summary>
		public CreateFabIdentor Identor { get; set; }
		
		/// <summary>
		///   Provides Locator data for the new Factor.
		/// </summary>
		public CreateFabLocator Locator { get; set; }
		
		/// <summary>
		///   Provides Vector data for the new Factor.
		/// </summary>
		public CreateFabVector Vector { get; set; }
		

		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Get the static FactorAssertion data that is associated with this object's AssertionType value.
		/// </summary>
		public FactorAssertion GetAssertionTypeData() {
			return FabEnumsData.GetFactorAssertion(AssertionType);
		}
		
	}

	
	/*================================================================================================*/
	/// <summary>
	///   Contains the data needed to create a new Identor.
	/// </summary>
	/// <remarks>
	///   <para>Contains the data needed to create a new Identor.</para>
	/// </remarks>
	public class CreateFabIdentor : CreateFabObject {
	
		/// <summary>
		///   Identifies the IdentorType for the new Identor.
		/// </summary>
		public byte Type { get; set; }
		
		/// <summary>
		///   The text-based value for the new Identor.
		/// </summary>
		public string Value { get; set; }
		

		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Get the static IdentorType data that is associated with this object's Type value.
		/// </summary>
		public IdentorType GetTypeData() {
			return FabEnumsData.GetIdentorType(Type);
		}
		
	}

	
	/*================================================================================================*/
	/// <summary>
	///   Contains the data needed to create a new Instance.
	/// </summary>
	/// <remarks>
	///   <para>Contains the data needed to create a new Instance.</para>
	/// </remarks>
	public class CreateFabInstance : CreateFabArtifact {
	
		/// <summary>
		///   The name of the new Instance.
		/// </summary>
		public string Name { get; set; }
		
		/// <summary>
		///   The disambiguation text for the new Instance.
		/// </summary>
		public string Disamb { get; set; }
		
		/// <summary>
		///   A brief description of the new Instance.
		/// </summary>
		public string Note { get; set; }
		
	}

	
	/*================================================================================================*/
	/// <summary>
	///   Contains the data needed to create a new Locator.
	/// </summary>
	/// <remarks>
	///   <para>Contains the data needed to create a new Locator.</para>
	/// </remarks>
	public class CreateFabLocator : CreateFabObject {
	
		/// <summary>
		///   Identifies the LocatorType for the new Locator.
		/// </summary>
		public byte Type { get; set; }
		
		/// <summary>
		///   The X value for the new Locator.
		/// </summary>
		public double ValueX { get; set; }
		
		/// <summary>
		///   The Y value for the new Locator.
		/// </summary>
		public double ValueY { get; set; }
		
		/// <summary>
		///   The Z value for the new Locator.
		/// </summary>
		public double ValueZ { get; set; }
		

		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Get the static LocatorType data that is associated with this object's Type value.
		/// </summary>
		public LocatorType GetTypeData() {
			return FabEnumsData.GetLocatorType(Type);
		}
		
	}

	
	/*================================================================================================*/
	/// <summary>
	///   Contains the data needed to create a new Member.
	/// </summary>
	/// <remarks>
	///   <para>Contains the data needed to create a new Member.</para>
	/// </remarks>
	public class CreateFabMember : CreateFabVertex {
	
		/// <summary>
		///   Identifies the MemberType for the new Member.
		/// </summary>
		public byte Type { get; set; }
		
		/// <summary>
		///   Identifies the App that defines the new Member.
		/// </summary>
		public long DefinedByAppId { get; set; }
		
		/// <summary>
		///   Identifies the User that defines the new Member.
		/// </summary>
		public long DefinedByUserId { get; set; }
		

		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Get the static MemberType data that is associated with this object's Type value.
		/// </summary>
		public MemberType GetTypeData() {
			return FabEnumsData.GetMemberType(Type);
		}
		
	}

	
	/*================================================================================================*/
	/// <summary>
	///   The base class for the creation of Objects.
	/// </summary>
	/// <remarks>
	///   <para>The base class for the creation of Objects.</para>
	/// </remarks>
	public class CreateFabObject : FabObject {
	
	}

	
	/*================================================================================================*/
	/// <summary>
	///   Contains the data needed to create a new Url.
	/// </summary>
	/// <remarks>
	///   <para>Contains the data needed to create a new Url.</para>
	/// </remarks>
	public class CreateFabUrl : CreateFabArtifact {
	
		/// <summary>
		///   The name of the new Url.
		/// </summary>
		public string Name { get; set; }
		
		/// <summary>
		///   The complete absolute URL for new Url object.
		/// </summary>
		public string FullPath { get; set; }
		
	}

	
	/*================================================================================================*/
	/// <summary>
	///   Contains the data needed to create a new Vector.
	/// </summary>
	/// <remarks>
	///   <para>Contains the data needed to create a new Vector.</para>
	/// </remarks>
	public class CreateFabVector : CreateFabObject {
	
		/// <summary>
		///   Identifies the VectorType for the new Vector.
		/// </summary>
		public byte Type { get; set; }
		
		/// <summary>
		///   Identifies the VectorUnit for the new Vector.
		/// </summary>
		public byte Unit { get; set; }
		
		/// <summary>
		///   Identifies the VectorUnitPrefix for the new Vector.
		/// </summary>
		public byte UnitPrefix { get; set; }
		
		/// <summary>
		///   The value for the new Vector.
		/// </summary>
		public long Value { get; set; }
		
		/// <summary>
		///   The Artifact which provides meaning for the new Vector.
		/// </summary>
		public long? UsesAxisArtifactId { get; set; }
		

		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Get the static VectorType data that is associated with this object's Type value.
		/// </summary>
		public VectorType GetTypeData() {
			return FabEnumsData.GetVectorType(Type);
		}
		

		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Get the static VectorUnit data that is associated with this object's Unit value.
		/// </summary>
		public VectorUnit GetUnitData() {
			return FabEnumsData.GetVectorUnit(Unit);
		}
		

		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Get the static VectorUnitPrefix data that is associated with this object's UnitPrefix value.
		/// </summary>
		public VectorUnitPrefix GetUnitPrefixData() {
			return FabEnumsData.GetVectorUnitPrefix(UnitPrefix);
		}
		
	}

	
	/*================================================================================================*/
	/// <summary>
	///   The base class for the creation of Vertices.
	/// </summary>
	/// <remarks>
	///   <para>The base class for the creation of Vertices.</para>
	/// </remarks>
	public class CreateFabVertex : CreateFabElement {
	
	}

	
	/*================================================================================================*/
	/// <summary>
	///   A registered project, application, or business that has direct access to the Fabric API. An App's 'sprimary purpose is to facilitate User interaction with Fabric.
	/// </summary>
	/// <remarks>
	///   <para>A registered project, application, or business that has direct access to the Fabric API.</para>
	///   <para>An App's 'sprimary purpose is to facilitate User interaction with Fabric. To accomplish this, an App typically creates an interface for its Users. This interface hides the complex details of the Fabric API, and instead provides intuitive features like custom inputs, searches, summaries, and visualizations. </para>
	///   <para>When a User becomes a Member of an App, they are granting that App permission to perform various actions on their behalf (via the App's 'sinterface). It is vital for an App to provide each User with a positive experience and do nothing to violate the User's 'strust.</para>
	///   <para>Every App has a special 'Data Provider' Member, which is typically controlled by that App's 'sadministrator. The 'Data Provider' allows the App to interact with Fabric as itself (rather than on behalf of a particular User).</para>
	///   <para>Every item added to Fabric is associated with (via Member) a User and and an App. Thus, Fabric can determine which App is responsible for any particular item, enforce applicable access rights, analyze the data for a particular App or Member, etc.</para>
	/// </remarks>
	public class FabApp : FabArtifact {
	
		/// <summary>
		///   A unique title or identifier.
		/// </summary>
		public string Name { get; set; }
		
	}

	
	/*================================================================================================*/
	/// <summary>
	///   Connects an App to all of its Members.
	/// </summary>
	/// <remarks>
	///   <para>Connects an App to all of its Members.</para>
	/// </remarks>
	public class FabAppDefinesMember : FabLink {
	
	}

	
	/*================================================================================================*/
	/// <summary>
	///   An object which is able to (via Factor connections) accumulate meaning, context, user sentiment, and relationships.
	/// </summary>
	/// <remarks>
	///   <para>An object which is able to (via Factor connections) accumulate meaning, context, user sentiment, and relationships.  Artifacts and Factors are the central components of the Fabric architecture.</para>
	///   <para>There are no restrictions on what an Artifact can represent.  Fabric encourages the generous use of Factors to identify and describe each new Artifact. Ideally, the Factor connections will distinguish an Artifact from all others.</para>
	/// </remarks>
	public class FabArtifact : FabVertex {
	
	}

	
	/*================================================================================================*/
	/// <summary>
	///   Connects an Artifact to all of the Factors using it as the primary Artifact.
	/// </summary>
	/// <remarks>
	///   <para>Connects an Artifact to all of the Factors using it as the primary Artifact.</para>
	/// </remarks>
	public class FabArtifactUsedAsPrimaryByFactor : FabLink {
	
	}

	
	/*================================================================================================*/
	/// <summary>
	///   Connects an Artifact to all of the Factors using it as the related Artifact.
	/// </summary>
	/// <remarks>
	///   <para>Connects an Artifact to all of the Factors using it as the related Artifact.</para>
	/// </remarks>
	public class FabArtifactUsedAsRelatedByFactor : FabLink {
	
	}

	
	/*================================================================================================*/
	/// <summary>
	///   Represents any item (real, imaginary, virtual, conceptual, or otherwise) that an App or User can define and/or use to generate meaning.
	/// </summary>
	/// <remarks>
	///   <para>Represents any item (real, imaginary, virtual, conceptual, or otherwise) that an App or User can define and/or use to generate meaning. Classes and Instances are closely related, and are the primary method for generating new Artifacts.</para>
	///   <para>A Class represents a particular group, type, set, or category of items. Each Class must uniquely identifiable (via name and disambiguation) amongst all other Classes.</para>
	/// </remarks>
	public class FabClass : FabArtifact {
	
		/// <summary>
		///   A descriptive name or title.
		/// </summary>
		public string Name { get; set; }
		
		/// <summary>
		///   A secondary label or identifier, used to resolve unique-name conflicts.
		/// </summary>
		public string Disamb { get; set; }
		
		/// <summary>
		///   A summary of the Class's 'sintended meaning or purpose.
		/// </summary>
		public string Note { get; set; }
		
	}

	
	/*================================================================================================*/
	/// <summary>
	///   A Factor component that describes and refines the relationship between the Factor's 'stwo Artifacts.
	/// </summary>
	/// <remarks>
	///   <para>A Factor component that describes and refines the relationship between the Factor's 'stwo Artifacts. Descriptors are the only required Factor component.</para>
	///   <para>First, the DescriptorType provides semantic meaning to the relationship, such as: a A "is a" B, or C "sounds like" D. Since this relationship is directional (flowing from the Factor's 'sprimary Artifact and to the related Artifact), the DescriptorType must coordinate correctly with the relationship's 'sdirection.</para>
	///   <para>Descriptors also offer optional (but powerful) refinement capabilities, which allow a Descriptor to be very specific. Using any Artifact, a Descriptor may refine the DescriptorType, the Factor's 'sprimary Artifact, and/or the Factor's 'srelated Artifact. Note: while these Artifact links are discussed here in the context of a Descriptor, the actual traversal links exist with the Factor.</para>
	/// </remarks>
	public class FabDescriptor : FabObject {
	
		/// <summary>
		///   Specifies the type of relationship or connection.
		/// </summary>
		public byte Type { get; set; }
		

		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Get the static DescriptorType data that is associated with this object's Type value.
		/// </summary>
		public DescriptorType GetTypeData() {
			return FabEnumsData.GetDescriptorType(Type);
		}
		
	}

	
	/*================================================================================================*/
	/// <summary>
	///   A Factor component that creates a directional, action-based flow between the Factor's 'stwo Artifacts. The nature of a Director's 'spathway depends on its DirectorType.
	/// </summary>
	/// <remarks>
	///   <para>A Factor component that creates a directional, action-based flow between the Factor's 'stwo Artifacts.</para>
	///   <para>The nature of a Director's 'spathway depends on its DirectorType. The Director can  represent a factual, well-defined path, a virtual link, a suggested flow, etc.</para>
	///   <para>A Director specifies a DirectorAction for each of the Factor's 'sArtifacts, which give additional meaning to the Director's 'spathway. The primary action is meant to be performed on the primary Artifact before the pathway begins. The related action is meant to be performed on the related Artifact after the pathway ends.</para>
	/// </remarks>
	public class FabDirector : FabObject {
	
		/// <summary>
		///   Specifies the type and reason for the pathway.
		/// </summary>
		public byte Type { get; set; }
		
		/// <summary>
		///   Specifies the action to be performed on the Factor's 'sprimary Artifact.
		/// </summary>
		public byte PrimaryAction { get; set; }
		
		/// <summary>
		///   Specifies the action to be performed on the Factor's 'srelated Artifact.
		/// </summary>
		public byte RelatedAction { get; set; }
		

		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Get the static DirectorType data that is associated with this object's Type value.
		/// </summary>
		public DirectorType GetTypeData() {
			return FabEnumsData.GetDirectorType(Type);
		}
		

		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Get the static DirectorAction data that is associated with this object's PrimaryAction value.
		/// </summary>
		public DirectorAction GetPrimaryActionData() {
			return FabEnumsData.GetDirectorAction(PrimaryAction);
		}
		

		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Get the static DirectorAction data that is associated with this object's RelatedAction value.
		/// </summary>
		public DirectorAction GetRelatedActionData() {
			return FabEnumsData.GetDirectorAction(RelatedAction);
		}
		
	}

	
	/*================================================================================================*/
	/// <summary>
	///   An item (Vertex or Link) in Fabric's 'sgraph structure.
	/// </summary>
	/// <remarks>
	///   <para>An item (Vertex or Link) in Fabric's 'sgraph structure.</para>
	/// </remarks>
	public class FabElement : FabObject {
	
	}

	
	/*================================================================================================*/
	/// <summary>
	///   When a fault or error occurs, a FabError is included in the response data.
	/// </summary>
	/// <remarks>
	///   <para>When a fault or error occurs, a FabError is included in the response data. The information it provides should help determine what caused the issue for the given request.</para>
	/// </remarks>
	public class FabError : FabObject {
	
		/// <summary>
		///   A numeric value which identifies the specific error type.
		/// </summary>
		public int Code { get; set; }
		
		/// <summary>
		///   A descriptive name that is associated with the error code.
		/// </summary>
		public string Name { get; set; }
		
		/// <summary>
		///   A sentence or paragraph providing details about the error.
		/// </summary>
		public string Message { get; set; }
		
	}

	
	/*================================================================================================*/
	/// <summary>
	///   A Factor component that applies the concept of time to a particular Factor. An Eventor places a Factor at a specific point in time and describes why it is significant to the Factor.
	/// </summary>
	/// <remarks>
	///   <para>A Factor component that applies the concept of time to a particular Factor.</para>
	///   <para>An Eventor places a Factor at a specific point in time and describes why it is significant to the Factor. The EventorType provides this significance, establishing that this particular point in time is when the Factor started, occurred, is expected, etc.</para>
	///   <para>Each Eventor represents one particular point in time, however, the precision of that point in time can vary. The optional time values allow a point in time to provide a level of precision ranging from one second to one year.</para>
	///   <para>Note: every Factor recieves a timestamp upon creation. This timestamp is not related to the Eventor.</para>
	/// </remarks>
	public class FabEventor : FabObject {
	
		/// <summary>
		///   Specifies the significance of this point in time.
		/// </summary>
		public byte Type { get; set; }
		
		/// <summary>
		///   Specifies the year value (UTC).
		/// </summary>
		public long Year { get; set; }
		
		/// <summary>
		///   Specifies the month value (UTC).
		/// </summary>
		public byte? Month { get; set; }
		
		/// <summary>
		///   Specifies the day value (UTC).
		/// </summary>
		public byte? Day { get; set; }
		
		/// <summary>
		///   Specifies the hour value in 24-hour format (UTC).
		/// </summary>
		public byte? Hour { get; set; }
		
		/// <summary>
		///   Specifies the minute value (UTC).
		/// </summary>
		public byte? Minute { get; set; }
		
		/// <summary>
		///   Specifies the second value (UTC).
		/// </summary>
		public byte? Second { get; set; }
		

		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Get the static EventorType data that is associated with this object's Type value.
		/// </summary>
		public EventorType GetTypeData() {
			return FabEnumsData.GetEventorType(Type);
		}
		
	}

	
	/*================================================================================================*/
	/// <summary>
	///   Provides a specific piece of information, knowledge, or opinion about a pair of Artifacts.
	/// </summary>
	/// <remarks>
	///   <para>Provides a specific piece of information, knowledge, or opinion about a pair of Artifacts. Factors and Artifacts are the central components of the Fabric architecture.</para>
	///   <para>A Factor forms a directional relationship from its primary Artifact to its related Artifact. It contains one or more components, called Factor components. Each Element has a specific ability to refine, describe, and/or supplement this Artifact relationship in a meaningful way.</para>
	///   <para>There are six Factor components: Descriptor, Director, Eventor, Identor, Locator, and Vector. The Descriptor is the only required Element; the rest are optional. A Factor typically uses one or two Elements, but (in very complex cases) could potentially use four or more.</para>
	///   <para>Just as there are no restrictions on what a particular Artifact can represent, there are no restrictions on the type of meaning or information a Factors can provide. A FactorAssertion allows a Factor to specify that it represents (among other things) a fact or an opinion. This level of confidence for a particular Factor allows Users and Apps to more effectively find the type of information they desire.</para>
	/// </remarks>
	public class FabFactor : FabVertex {
	
		/// <summary>
		///   Describes the type of information (and/or level of confidence) provided by a particular Factor.
		/// </summary>
		public byte AssertionType { get; set; }
		
		/// <summary>
		///   Specifies whether this Factor helps to directly and uniquely define the primary Artifact.
		/// </summary>
		public bool IsDefining { get; set; }
		
		/// <summary>
		///   A summary of the Factor's 'sintended meaning or purpose.
		/// </summary>
		public string Note { get; set; }
		
		/// <summary>
		///   This component defines the relationship between the primary and related Artifact.
		/// </summary>
		public FabDescriptor Descriptor { get; set; }
		
		/// <summary>
		///   This component creates a directional pathway between the primary and related Artifacts.
		/// </summary>
		public FabDirector Director { get; set; }
		
		/// <summary>
		///   This component applies the concept of time.
		/// </summary>
		public FabEventor Eventor { get; set; }
		
		/// <summary>
		///   This component applies a name or identifier.
		/// </summary>
		public FabIdentor Identor { get; set; }
		
		/// <summary>
		///   This component provides a geographical or relative position.
		/// </summary>
		public FabLocator Locator { get; set; }
		
		/// <summary>
		///   This component applies a numeric axis and value.
		/// </summary>
		public FabVector Vector { get; set; }
		

		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Get the static FactorAssertion data that is associated with this object's AssertionType value.
		/// </summary>
		public FactorAssertion GetAssertionTypeData() {
			return FabEnumsData.GetFactorAssertion(AssertionType);
		}
		
	}

	
	/*================================================================================================*/
	/// <summary>
	///   The complete collection of Fabric API services.
	/// </summary>
	/// <remarks>
	///   <para>The complete collection of Fabric API services.</para>
	/// </remarks>
	public class FabHome : FabObject {
	
		/// <summary>
		///   The name of this API.
		/// </summary>
		public string Name { get; set; }
		
		/// <summary>
		///   The relative URI for this API level.
		/// </summary>
		public string Uri { get; set; }
		
		/// <summary>
		///   The complete list of services.
		/// </summary>
		public FabService[] Services { get; set; }
		
	}

	
	/*================================================================================================*/
	/// <summary>
	///   A Factor component that applies a name or identifier to a particular Factor. An Identor attaches a text-based value to a Factor.
	/// </summary>
	/// <remarks>
	///   <para>A Factor component that applies a name or identifier to a particular Factor.</para>
	///   <para>An Identor attaches a text-based value to a Factor. This value can represent a a full name, a nickname, a globally-unique identifier, a reference key to some other system, etc.</para>
	///   <para>The IdentorType hints at the purpose or intent of the Identor. A "Text" IdentorType is typically meant to provide enhanced search capabilities (like finding a person by an alternate name) or some other organizational use.  A "Key" IdentorType is typically meant to associate a Factor with some external system (like a Product ID from an online store) or to provide an App with a "reverse lookup" for their own internal IDs.</para>
	/// </remarks>
	public class FabIdentor : FabObject {
	
		/// <summary>
		///   Specifies the value's 'spurpose or intent.
		/// </summary>
		public byte Type { get; set; }
		
		/// <summary>
		///   A text-based value that can represent names, numbers, IDs, GUIDs, etc.
		/// </summary>
		public string Value { get; set; }
		

		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Get the static IdentorType data that is associated with this object's Type value.
		/// </summary>
		public IdentorType GetTypeData() {
			return FabEnumsData.GetIdentorType(Type);
		}
		
	}

	
	/*================================================================================================*/
	/// <summary>
	///   Represents any item (real, imaginary, virtual, conceptual, or otherwise) that an App or User can define and/or use to generate meaning.
	/// </summary>
	/// <remarks>
	///   <para>Represents any item (real, imaginary, virtual, conceptual, or otherwise) that an App or User can define and/or use to generate meaning. Classes and Instances are closely related, and are the primary method for generating new Artifacts.</para>
	///   <para>An Instance represents a singular, unique item. It may have a specific name, however, the name is not required to be unique. Instead, the creator should apply Factors to make the Instance as specific and meaningful as possible.</para>
	/// </remarks>
	public class FabInstance : FabArtifact {
	
		/// <summary>
		///   A descriptive name or title.
		/// </summary>
		public string Name { get; set; }
		
		/// <summary>
		///   A secondary label or identifier, used to resolve unique-name conflicts.
		/// </summary>
		public string Disamb { get; set; }
		
		/// <summary>
		///   A summary of the Instance's 'sintended meaning or purpose.
		/// </summary>
		public string Note { get; set; }
		
	}

	
	/*================================================================================================*/
	/// <summary>
	///   A connection between one Vertex and another.
	/// </summary>
	/// <remarks>
	///   <para>A connection between one Vertex and another.</para>
	/// </remarks>
	public class FabLink : FabElement {
	
		/// <summary>
		///   The Vertex type at the "outgoing" end of this Link.
		/// </summary>
		public string FromType { get; set; }
		
		/// <summary>
		///   The Vertex type at the "incoming" end of this Link.
		/// </summary>
		public string ToType { get; set; }
		
	}

	
	/*================================================================================================*/
	/// <summary>
	///   A Factor component that positions a Factor using geographic or relative coordinates. A Locator attaches a three-dimensional coordinate to a Factor.
	/// </summary>
	/// <remarks>
	///   <para>A Factor component that positions a Factor using geographic or relative coordinates.</para>
	///   <para>A Locator attaches a three-dimensional coordinate to a Factor. The LocatorType defines the spatial context of the coordinate, supporting both geographic and relative positioning.</para>
	///   <para>Geographic coordinates represent a position on a sphere, like Earth.  They use X for longitude, Y for latitude, and Z for elevation (in metres above sea level). Use zero for elevation if it is not known or specified.</para>
	///   <para>Relative coordinates represent a position relative to the origin and size/bounds of the Factor's 'sprimary Artifact. There are LocatorTypes for one, two, and three-dimensional relative coordinates. For coordinates which have</para>
	///   <para>- One dimension, use X for time or progress, and leave Y and Z equal to zero</para>
	///   <para>- Two dimensions, use X for width, Y for height, and leave Z equal to zero</para>
	///   <para>- Three dimensions, use X, Y, and Z values which correspond to the Artifact's 'sX, Y, and Z values. If these axes are undefined, use X for width (or breadth), Y for length (or depth), and Z for height (or elevation).</para>
	/// </remarks>
	public class FabLocator : FabObject {
	
		/// <summary>
		///   Specifies the spatial context of the coordinate.
		/// </summary>
		public byte Type { get; set; }
		
		/// <summary>
		///   A value representing longitude, time/progress, width, or a particular three-dimensional axis.
		/// </summary>
		public double ValueX { get; set; }
		
		/// <summary>
		///   A value representing latitude, height, or a particular three-dimensional axis.
		/// </summary>
		public double ValueY { get; set; }
		
		/// <summary>
		///   A value representing elevation or a particular three-dimensional axis.
		/// </summary>
		public double ValueZ { get; set; }
		

		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Get the static LocatorType data that is associated with this object's Type value.
		/// </summary>
		public LocatorType GetTypeData() {
			return FabEnumsData.GetLocatorType(Type);
		}
		
	}

	
	/*================================================================================================*/
	/// <summary>
	///   An association between a User and an App.
	/// </summary>
	/// <remarks>
	///   <para>An association between a User and an App. The App administrator(s) can grant various access privileges to a Member by creating a MemberTypeAssign that uses a different MemberType.</para>
	///   <para>Every item added to Fabric is associated with a particular Member. This enables Fabric to determine which App or User is responsible for any particular item, enforce applicable access rights, analyze the data for a particular App and/or User, etc.</para>
	/// </remarks>
	public class FabMember : FabVertex {
	
		/// <summary>
		///   Specifies the Member's 'sstate and/or access privileges.
		/// </summary>
		public byte Type { get; set; }
		

		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Get the static MemberType data that is associated with this object's Type value.
		/// </summary>
		public MemberType GetTypeData() {
			return FabEnumsData.GetMemberType(Type);
		}
		
	}

	
	/*================================================================================================*/
	/// <summary>
	///   Connects a Member to all the Artifacts it has created.
	/// </summary>
	/// <remarks>
	///   <para>Connects a Member to all the Artifacts it has created.</para>
	/// </remarks>
	public class FabMemberCreatesArtifact : FabLink {
	
	}

	
	/*================================================================================================*/
	/// <summary>
	///   Connects a Member to all the Factors it has created.
	/// </summary>
	/// <remarks>
	///   <para>Connects a Member to all the Factors it has created.</para>
	/// </remarks>
	public class FabMemberCreatesFactor : FabLink {
	
	}

	
	/*================================================================================================*/
	/// <summary>
	///   Contains the current Fabric system time.
	/// </summary>
	/// <remarks>
	///   <para>Contains the current Fabric system time. Fabric uses the UTC timezone for all dates, times, and timestamps.</para>
	/// </remarks>
	public class FabMetaTime : FabObject {
	
		/// <summary>
		///   The current year.
		/// </summary>
		public int Year { get; set; }
		
		/// <summary>
		///   The current month.
		/// </summary>
		public int Month { get; set; }
		
		/// <summary>
		///   The current day of the month.
		/// </summary>
		public int Day { get; set; }
		
		/// <summary>
		///   The current hour (using 24-hour time).
		/// </summary>
		public int Hour { get; set; }
		
		/// <summary>
		///   The current minute.
		/// </summary>
		public int Minute { get; set; }
		
		/// <summary>
		///   The current second.
		/// </summary>
		public int Second { get; set; }
		
		/// <summary>
		///   The current millisecond.
		/// </summary>
		public double Millisecond { get; set; }
		
		/// <summary>
		///   A Unix timestamp value (in milliseconds).
		/// </summary>
		public long Timestamp { get; set; }
		
		/// <summary>
		///   The timezone used by the time metrics.
		/// </summary>
		public string Timezone { get; set; }
		
	}

	
	/*================================================================================================*/
	/// <summary>
	///   Contains the current Fabric version information.
	/// </summary>
	/// <remarks>
	///   <para>Contains the current Fabric version information. Fabric uses semantic versioning.</para>
	/// </remarks>
	public class FabMetaVersion : FabObject {
	
		/// <summary>
		///   This build's 'sfull version string, in the format: "Major.Minor.Patch.Revision".
		/// </summary>
		public string Version { get; set; }
		
		/// <summary>
		///   The major revision number for this build.
		/// </summary>
		public int Major { get; set; }
		
		/// <summary>
		///   The minor revision number for this build.
		/// </summary>
		public int Minor { get; set; }
		
		/// <summary>
		///   The patch revision number for this build.
		/// </summary>
		public int Patch { get; set; }
		
		/// <summary>
		///   The revision text is derived from internal build information.
		/// </summary>
		public string Revision { get; set; }
		
		/// <summary>
		///   The year that this build was released.
		/// </summary>
		public int Year { get; set; }
		
		/// <summary>
		///   The month that this build was released.
		/// </summary>
		public int Month { get; set; }
		
		/// <summary>
		///   The day of the month that this build was released.
		/// </summary>
		public int Day { get; set; }
		
	}

	
	/*================================================================================================*/
	/// <summary>
	///   Provides an OAuth access token and other related information.
	/// </summary>
	/// <remarks>
	///   <para>Provides an OAuth access token and other related information. Every Fabric API request requires an access token. To include an OAuth access token with a FabricAPI request, add an "Authorization" header to the HTTP request with a value of "Bearer=[your OAuth access code here]".</para>
	/// </remarks>
	public class FabOauthAccess : FabObject {
	
		/// <summary>
		///   A code that maps to various authentication information.
		/// </summary>
		public string access_token { get; set; }
		
		/// <summary>
		///   For the current Fabric OAuth implementation, this value is always equal to "bearer".
		/// </summary>
		public string token_type { get; set; }
		
		/// <summary>
		///   A code that refreshes the authentication session for an expired OAuth access token.
		/// </summary>
		public string refresh_token { get; set; }
		
		/// <summary>
		///   The number of seconds until the access token expires.
		/// </summary>
		public int expires_in { get; set; }
		
	}

	
	/*================================================================================================*/
	/// <summary>
	///   To comply with the OAuth 2.0 specification, all Fabric OAuth requests return a FabOauthError (instead of FabFault or FabError) when errors occur.
	/// </summary>
	/// <remarks>
	///   <para>To comply with the OAuth 2.0 specification, all Fabric OAuth requests return a FabOauthError (instead of FabFault or FabError) when errors occur.</para>
	/// </remarks>
	public class FabOauthError : FabObject {
	
		/// <summary>
		///   An error code as defined by the OAuth 2.0 specification.
		/// </summary>
		public string error { get; set; }
		
		/// <summary>
		///   Provides specific details about the error.
		/// </summary>
		public string error_description { get; set; }
		
	}

	
	/*================================================================================================*/
	/// <summary>
	///   This object is unique -- the API never returns this object directly.
	/// </summary>
	/// <remarks>
	///   <para>This object is unique -- the API never returns this object directly. Instead, the properties shown below are included as query-string parameters for a redirect URI. This URI is provided by an App, and the App is responsible for accepting (and reacting to) the incoming redirect.</para>
	///   <para>This redirect is used in one particular scenario: the OAuth login process. After the user completes this process, Fabric performs a redirect with success or failure information.  The success redirect includes the 'code' and 'state' parameters. The failure redirect includes the 'error', 'error_description', and 'state' parameters.</para>
	/// </remarks>
	public class FabOauthLogin : FabObject {
	
		/// <summary>
		///   Use this code (also called the 'authorization code') to generate a new OAuth access token.
		/// </summary>
		public string code { get; set; }
		
		/// <summary>
		///   Returns the 'state' value that the App provided in the original Oauth request.
		/// </summary>
		public string state { get; set; }
		
		/// <summary>
		///   An error code as defined by the OAuth 2.0 specification.
		/// </summary>
		public string error { get; set; }
		
		/// <summary>
		///   Provides specific details about the error.
		/// </summary>
		public string error_description { get; set; }
		
	}

	
	/*================================================================================================*/
	/// <summary>
	///   The result of an OAuth logout.
	/// </summary>
	/// <remarks>
	///   <para>The result of an OAuth logout.</para>
	/// </remarks>
	public class FabOauthLogout : FabObject {
	
		/// <summary>
		///   Describes the result of the logout attempt.
		/// </summary>
		public int success { get; set; }
		
		/// <summary>
		///   Identifies a particular OAuth session.
		/// </summary>
		public string access_token { get; set; }
		
	}

	
	/*================================================================================================*/
	/// <summary>
	///   The base class for all Objects returned by Fabric's 'sservices.
	/// </summary>
	/// <remarks>
	///   <para>The base class for all Objects returned by Fabric's 'sservices.</para>
	/// </remarks>
	public class FabObject {
	
		/// <summary>
		///   The data type of this object.
		/// </summary>
		public string Obj { get; set; }
		
	}

	
	/*================================================================================================*/
	/// <summary>
	///   A collection of ServiceOperations which all share a similar purpose.
	/// </summary>
	/// <remarks>
	///   <para>A collection of ServiceOperations which all share a similar purpose.</para>
	/// </remarks>
	public class FabService : FabObject {
	
		/// <summary>
		///   The service name.
		/// </summary>
		public string Name { get; set; }
		
		/// <summary>
		///   Append this path to the current URI to obtain details about this service.
		/// </summary>
		public string Uri { get; set; }
		
		/// <summary>
		///   The complete list of operations for this service.
		/// </summary>
		public FabServiceOperation[] Operations { get; set; }
		
	}

	
	/*================================================================================================*/
	/// <summary>
	///   A task, query, or operation that belongs to a Service.
	/// </summary>
	/// <remarks>
	///   <para>A task, query, or operation that belongs to a Service.</para>
	/// </remarks>
	public class FabServiceOperation : FabObject {
	
		/// <summary>
		///   A descriptive name for this operation.
		/// </summary>
		public string Name { get; set; }
		
		/// <summary>
		///   Append this value to the current URI (and use the correct HTTP method) to invoke this operation.
		/// </summary>
		public string Uri { get; set; }
		
		/// <summary>
		///   The required HTTP method.
		/// </summary>
		public string Method { get; set; }
		
		/// <summary>
		///   The type of Object returned by this operation.
		/// </summary>
		public string Return { get; set; }
		
	}

	
	/*================================================================================================*/
	/// <summary>
	///   
	/// </summary>
	/// <remarks>
	///   
	/// </remarks>
	public class FabSpec : FabObject {
	
		/// <summary>
		///   
		/// </summary>
		public string BuildVersion { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public int BuildYear { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public int BuildMonth { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public int BuildDay { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public FabSpecObject[] Objects { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public FabSpecService[] Services { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public FabSpecEnum[] Enums { get; set; }
		
	}

	
	/*================================================================================================*/
	/// <summary>
	///   
	/// </summary>
	/// <remarks>
	///   
	/// </remarks>
	public class FabSpecEnum : FabSpecObject {
	
		/// <summary>
		///   
		/// </summary>
		public object[] Items { get; set; }
		
	}

	
	/*================================================================================================*/
	/// <summary>
	///   
	/// </summary>
	/// <remarks>
	///   
	/// </remarks>
	public class FabSpecObject : FabObject {
	
		/// <summary>
		///   
		/// </summary>
		public string Name { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public string Extends { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public string Description { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public FabSpecObjectProp[] Properties { get; set; }
		
	}

	
	/*================================================================================================*/
	/// <summary>
	///   
	/// </summary>
	/// <remarks>
	///   
	/// </remarks>
	public class FabSpecObjectProp : FabSpecValue {
	
		/// <summary>
		///   
		/// </summary>
		public string Enum { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public bool? ToLowerCase { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public bool? IsUnique { get; set; }
		
	}

	
	/*================================================================================================*/
	/// <summary>
	///   
	/// </summary>
	/// <remarks>
	///   
	/// </remarks>
	public class FabSpecService : FabObject {
	
		/// <summary>
		///   
		/// </summary>
		public string Name { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public string Uri { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public string Summary { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public string Description { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public FabSpecServiceOperation[] Operations { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public FabSpecServiceStep[] Steps { get; set; }
		
	}

	
	/*================================================================================================*/
	/// <summary>
	///   
	/// </summary>
	/// <remarks>
	///   
	/// </remarks>
	public class FabSpecServiceOperation : FabObject {
	
		/// <summary>
		///   
		/// </summary>
		public string Name { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public string Uri { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public string Method { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public string Return { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public string Description { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public string Auth { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public FabSpecServiceParam[] Parameters { get; set; }
		
	}

	
	/*================================================================================================*/
	/// <summary>
	///   
	/// </summary>
	/// <remarks>
	///   
	/// </remarks>
	public class FabSpecServiceParam : FabSpecValue {
	
		/// <summary>
		///   
		/// </summary>
		public int Index { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public string[] AcceptedStrings { get; set; }
		
	}

	
	/*================================================================================================*/
	/// <summary>
	///   
	/// </summary>
	/// <remarks>
	///   
	/// </remarks>
	public class FabSpecServiceStep : FabObject {
	
		/// <summary>
		///   
		/// </summary>
		public string Name { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public string Description { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public FabSpecServiceParam[] Parameters { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public FabSpecServiceStepRule[] Rules { get; set; }
		
	}

	
	/*================================================================================================*/
	/// <summary>
	///   
	/// </summary>
	/// <remarks>
	///   
	/// </remarks>
	public class FabSpecServiceStepRule : FabObject {
	
		/// <summary>
		///   
		/// </summary>
		public string Name { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public string Uri { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public string T { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public string Entry { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public string Return { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public bool? ReturnsAliasType { get; set; }
		
	}

	
	/*================================================================================================*/
	/// <summary>
	///   
	/// </summary>
	/// <remarks>
	///   
	/// </remarks>
	public class FabSpecValue : FabObject {
	
		/// <summary>
		///   
		/// </summary>
		public string Name { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public string Type { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public string Description { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public bool? IsOptional { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public long? Min { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public long? Max { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public int? LenMin { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public int? LenMax { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public string ValidRegex { get; set; }
		
	}

	
	/*================================================================================================*/
	/// <summary>
	///   Provides an App traversal entry point.
	/// </summary>
	/// <remarks>
	///   <para>Provides an App traversal entry point.</para>
	/// </remarks>
	public class FabTravAppRoot : FabTravArtifactRoot {
	
	}

	
	/*================================================================================================*/
	/// <summary>
	///   Provides an Artifact traversal entry point.
	/// </summary>
	/// <remarks>
	///   <para>Provides an Artifact traversal entry point.</para>
	/// </remarks>
	public class FabTravArtifactRoot : FabTravVertexRoot {
	
	}

	
	/*================================================================================================*/
	/// <summary>
	///   Provides a Class traversal entry point.
	/// </summary>
	/// <remarks>
	///   <para>Provides a Class traversal entry point.</para>
	/// </remarks>
	public class FabTravClassRoot : FabTravArtifactRoot {
	
	}

	
	/*================================================================================================*/
	/// <summary>
	///   Provides a Factor traversal entry point.
	/// </summary>
	/// <remarks>
	///   <para>Provides a Factor traversal entry point.</para>
	/// </remarks>
	public class FabTravFactorRoot : FabTravVertexRoot {
	
	}

	
	/*================================================================================================*/
	/// <summary>
	///   Provides an Instance traversal entry point.
	/// </summary>
	/// <remarks>
	///   <para>Provides an Instance traversal entry point.</para>
	/// </remarks>
	public class FabTravInstanceRoot : FabTravArtifactRoot {
	
	}

	
	/*================================================================================================*/
	/// <summary>
	///   Provides a Member traversal entry point.
	/// </summary>
	/// <remarks>
	///   <para>Provides a Member traversal entry point.</para>
	/// </remarks>
	public class FabTravMemberRoot : FabTravVertexRoot {
	
	}

	
	/*================================================================================================*/
	/// <summary>
	///   Represents the root, or starting point, of all Traversal Service queries.
	/// </summary>
	/// <remarks>
	///   <para>Represents the root, or starting point, of all Traversal Service queries. The Root provides traversal links to all other available objects.</para>
	/// </remarks>
	public class FabTravRoot : FabObject {
	
	}

	
	/*================================================================================================*/
	/// <summary>
	///   Provides information about an available traversal step.
	/// </summary>
	/// <remarks>
	///   <para>Provides information about an available traversal step.</para>
	/// </remarks>
	public class FabTravStep : FabObject {
	
		/// <summary>
		///   The name of this traversal step.
		/// </summary>
		public string Name { get; set; }
		
		/// <summary>
		///   The URI to append in order to execute this traversal step.
		/// </summary>
		public string Uri { get; set; }
		
		/// <summary>
		///   The return type.
		/// </summary>
		public string Return { get; set; }
		
	}

	
	/*================================================================================================*/
	/// <summary>
	///   The base class for all traversal entry points.
	/// </summary>
	/// <remarks>
	///   <para>The base class for all traversal entry points.</para>
	/// </remarks>
	public class FabTravTypedRoot : FabObject {
	
	}

	
	/*================================================================================================*/
	/// <summary>
	///   Provides a Url traversal entry point.
	/// </summary>
	/// <remarks>
	///   <para>Provides a Url traversal entry point.</para>
	/// </remarks>
	public class FabTravUrlRoot : FabTravArtifactRoot {
	
	}

	
	/*================================================================================================*/
	/// <summary>
	///   Provides a User traversal entry point.
	/// </summary>
	/// <remarks>
	///   <para>Provides a User traversal entry point.</para>
	/// </remarks>
	public class FabTravUserRoot : FabTravArtifactRoot {
	
	}

	
	/*================================================================================================*/
	/// <summary>
	///   Provides a Vertex traversal entry point.
	/// </summary>
	/// <remarks>
	///   <para>Provides a Vertex traversal entry point.</para>
	/// </remarks>
	public class FabTravVertexRoot : FabTravTypedRoot {
	
	}

	
	/*================================================================================================*/
	/// <summary>
	///   A hyperlink or path (uniform resource locator) to some web page, a file, or some other type of content. While a Url is a type of Artifact, it should be used with certain constraints.
	/// </summary>
	/// <remarks>
	///   <para>A hyperlink or path (uniform resource locator) to some web page, a file, or some other type of content.</para>
	///   <para>While a Url is a type of Artifact, it should be used with certain constraints. Consider an scenario where a Url leads to web page with a news article and a photo. The proper prodedure is to create a new Instance for both the news article and photo. With this method</para>
	///   <para>- The news article and photo Instances can receive Factors independently</para>
	///   <para>- The Url should only receive Factors related to the actual web page, its design, etc</para>
	///   <para>- Every Url that displays this particular news article can refer the same news article Instance.</para>
	/// </remarks>
	public class FabUrl : FabArtifact {
	
		/// <summary>
		///   A descriptive name or title.
		/// </summary>
		public string Name { get; set; }
		
		/// <summary>
		///   A unique, valid absolute URL.
		/// </summary>
		public string FullPath { get; set; }
		
	}

	
	/*================================================================================================*/
	/// <summary>
	///   A registered Fabric account that has indirect access (via Apps) to the Fabric API.
	/// </summary>
	/// <remarks>
	///   <para>A registered Fabric account that has indirect access (via Apps) to the Fabric API. A User can become a Member of an App, and then use the App's 'sinterface to interact with Fabric. An App's 'sinterface hides the complex details of the Fabric API, and instead provides intuitive features like custom inputs, searches, summaries, and visualizations. </para>
	///   <para>Users control their private account data and preferences using the Fabric website.</para>
	///   <para>Every item added to Fabric is associated with (via Member) a User and and an App. Thus, Fabric can determine which User is responsible for any particular item, enforce applicable access rights, analyze the data for a particular User or Member, etc.</para>
	/// </remarks>
	public class FabUser : FabArtifact {
	
		/// <summary>
		///   A unique username.
		/// </summary>
		public string Name { get; set; }
		
	}

	
	/*================================================================================================*/
	/// <summary>
	///   Connects a User to all of its Members.
	/// </summary>
	/// <remarks>
	///   <para>Connects a User to all of its Members.</para>
	/// </remarks>
	public class FabUserDefinesMember : FabLink {
	
	}

	
	/*================================================================================================*/
	/// <summary>
	///   A Factor component that applies a meaningful numeric axis and value to a particular Factor. A Vector attaches a numeric value to a Factor, using an arbitrary Artifact to define its "axis".
	/// </summary>
	/// <remarks>
	///   <para>A Factor component that applies a meaningful numeric axis and value to a particular Factor.</para>
	///   <para>A Vector attaches a numeric value to a Factor, using an arbitrary Artifact to define its "axis". This axis depends entiedgey upon the Vector's 'spurpose. For example, a factual Vector might use an Artifact like "Height" or "Shutter Speed". A Vector that provides an opinion might use an Artifact like "Quality" or "Excitement". While the choice of an axis Artififact is not restricted, it can be beneficial to use Artifacts which are other Apps or Users are already using as Vector axes. Note: while the axis Artifact link is discussed here in the context of a Vector, the actual traversal link exists with the Factor.</para>
	///   <para>The VectorType provides boundaries and context for the Vector's 'svalue. It can identify the value as a percentage, a level of agreement or disagreement, an opinion-based rating, or simply a plain numeric value. Each VectorType provides additional information, such as a VectorRange, to provide further meaning for the levels within the the allowed value boundaries.</para>
	///   <para>A Vector's 'snumeric value often reflects a measurement or a has a specific unit. Furthermore, a Vector can use VectorUnitPrefix to specify an order of magnitude for the value. A Vector's 'svalue is a long integer, so the prefix is especially useful when fractional values are involved, or when the desired number is larger than a long integer.</para>
	/// </remarks>
	public class FabVector : FabObject {
	
		/// <summary>
		///   Specifies its value's 'sboundaries and context.
		/// </summary>
		public byte Type { get; set; }
		
		/// <summary>
		///   Specifies its value's 'sunit of measurement.
		/// </summary>
		public byte Unit { get; set; }
		
		/// <summary>
		///   Specifies its value's 'sorder of magnitude.
		/// </summary>
		public byte UnitPrefix { get; set; }
		
		/// <summary>
		///   An integral value which is to be plotted along the specified axis.
		/// </summary>
		public long Value { get; set; }
		

		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Get the static VectorType data that is associated with this object's Type value.
		/// </summary>
		public VectorType GetTypeData() {
			return FabEnumsData.GetVectorType(Type);
		}
		

		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Get the static VectorUnit data that is associated with this object's Unit value.
		/// </summary>
		public VectorUnit GetUnitData() {
			return FabEnumsData.GetVectorUnit(Unit);
		}
		

		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Get the static VectorUnitPrefix data that is associated with this object's UnitPrefix value.
		/// </summary>
		public VectorUnitPrefix GetUnitPrefixData() {
			return FabEnumsData.GetVectorUnitPrefix(UnitPrefix);
		}
		
	}

	
	/*================================================================================================*/
	/// <summary>
	///   The base class for all vertices present in the Fabric "graph".
	/// </summary>
	/// <remarks>
	///   <para>The base class for all vertices present in the Fabric "graph".  Only Vertices are present and traversable via the Traversal Service.</para>
	/// </remarks>
	public class FabVertex : FabElement {
	
		/// <summary>
		///   A unique identifier for this Vertex.
		/// </summary>
		public long Id { get; set; }
		
		/// <summary>
		///   The date/time of creation.
		/// </summary>
		public long Timestamp { get; set; }
		
		/// <summary>
		///   Specifies the Vertex type.
		/// </summary>
		public byte VertexType { get; set; }
		

		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Get the static VertexType data that is associated with this object's VertexType value.
		/// </summary>
		public VertexType GetVertexTypeData() {
			return FabEnumsData.GetVertexType(VertexType);
		}
		
	}

	

}