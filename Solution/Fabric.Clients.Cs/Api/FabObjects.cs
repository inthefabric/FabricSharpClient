// GENERATED CODE
// Changes made to this source file will be overwritten
// Generated on 4/19/2013 5:20:29 PM

namespace Fabric.Clients.Cs.Api {

	// ReSharper disable InconsistentNaming

	/*================================================================================================*/
	/// <summary>
	///   A registered project, application, or business that has direct access to the Fabric API. An App's primary purpose is to facilitate User interaction with Fabric.
	/// </summary>
	/// <remarks>
	///   <para>A registered project, application, or business that has direct access to the Fabric API.</para>
	///   <para>An App's primary purpose is to facilitate User interaction with Fabric. To accomplish this, an App typically creates an interface for its Users. This interface hides the complex details of the Fabric API, and instead provides intuitive features like custom inputs, searches, summaries, and visualizations. </para>
	///   <para>When a User becomes a Member of an App, they are granting that App permission to perform various actions on their behalf (via the App's interface). It is vital for an App to provide each User with a positive experience and do nothing to violate the User's trust.</para>
	///   <para>Every App has a special 'Data Provider' Member, which is typically controlled by that App's administrator. The 'Data Provider' allows the App to interact with Fabric as itself (rather than on behalf of a particular User).</para>
	///   <para>Every item added to Fabric is associated with (via Member) a User and and an App. Thus, Fabric can determine which App is responsible for any particular item, enforce applicable access rights, analyze the data for a particular App or Member, etc.</para>
	/// </remarks>
	public class FabApp : FabArtifact {
	
		/// <summary>
		///   Uniquely identifies this object amongst all other objects of this type.
		/// </summary>
		public long AppId { get; set; }
		
		/// <summary>
		///   A unique title or identifier.
		/// </summary>
		public string Name { get; set; }
		
	}

	
	/*================================================================================================*/
	/// <summary>
	///   An object which is able to (via Factor connections) accumulate meaning, context, user sentiment, and relationships.
	/// </summary>
	/// <remarks>
	///   <para>An object which is able to (via Factor connections) accumulate meaning, context, user sentiment, and relationships.  Artifacts and Factors are the central components of the Fabric architecture.</para>
	///   <para>There are no restrictions on what an Artifact can represent.  Fabric encourages the generous use of Factors to identify and describe each new Artifact. Ideally, the Factor connections will distinguish an Artifact from all others.</para>
	/// </remarks>
	public class FabArtifact : FabNode {
	
		/// <summary>
		///   Uniquely identifies this object amongst all other objects of this type.
		/// </summary>
		public long ArtifactId { get; set; }
		
		/// <summary>
		///   The date/time of creation.
		/// </summary>
		public long Created { get; set; }
		
	}

	
	/*================================================================================================*/
	/// <summary>
	///   Provides input data for batch Class creation.
	/// </summary>
	/// <remarks>
	///   <para>Provides input data for batch Class creation. See the Class and AddClass operation documentation for details and parameter restrictions.</para>
	/// </remarks>
	public class FabBatchNewClass : FabBatchNewObject {
	
		/// <summary>
		///   
		/// </summary>
		public string Disamb { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public string Name { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public string Note { get; set; }
		
	}

	
	/*================================================================================================*/
	/// <summary>
	///   Provides input data for batch Factor creation.
	/// </summary>
	/// <remarks>
	///   <para>Provides input data for batch Factor creation. See the Factor and AddFactor operation documentation for details and parameter restrictions.</para>
	/// </remarks>
	public class FabBatchNewFactor : FabBatchNewObject {
	
		/// <summary>
		///   
		/// </summary>
		public FabBatchNewFactorDescriptor Descriptor { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public FabBatchNewFactorDirector Director { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public FabBatchNewFactorEventor Eventor { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public byte FactorAssertionId { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public FabBatchNewFactorIdentor Identor { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public bool IsDefining { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public FabBatchNewFactorLocator Locator { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public string Note { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public long PrimaryArtifactId { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public long RelatedArtifactId { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public FabBatchNewFactorVector Vector { get; set; }
		
	}

	
	/*================================================================================================*/
	/// <summary>
	///   Provides Descriptor input data for batch Factor creation.
	/// </summary>
	/// <remarks>
	///   <para>Provides Descriptor input data for batch Factor creation. See the Descriptor and AttachDescriptor operation documentation for details and parameter restrictions.</para>
	/// </remarks>
	public class FabBatchNewFactorDescriptor : FabObject {
	
		/// <summary>
		///   
		/// </summary>
		public long? PrimaryArtifactRefineId { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public long? RelatedArtifactRefineId { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public byte TypeId { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public long? TypeRefineId { get; set; }
		
	}

	
	/*================================================================================================*/
	/// <summary>
	///   Provides Director input data for batch Factor creation.
	/// </summary>
	/// <remarks>
	///   <para>Provides Director input data for batch Factor creation. See the Director and AttachDirector  operation documentation for details and parameter restrictions.</para>
	/// </remarks>
	public class FabBatchNewFactorDirector : FabObject {
	
		/// <summary>
		///   
		/// </summary>
		public byte PrimaryActionId { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public byte RelatedActionId { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public byte TypeId { get; set; }
		
	}

	
	/*================================================================================================*/
	/// <summary>
	///   Provides Eventor input data for batch Factor creation.
	/// </summary>
	/// <remarks>
	///   <para>Provides Eventor input data for batch Factor creation. See the Eventor and AttachEventor operation documentation for details and parameter restrictions.</para>
	/// </remarks>
	public class FabBatchNewFactorEventor : FabObject {
	
		/// <summary>
		///   
		/// </summary>
		public long DateTime { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public byte PrecisionId { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public byte TypeId { get; set; }
		
	}

	
	/*================================================================================================*/
	/// <summary>
	///   Provides Identor input data for batch Factor creation.
	/// </summary>
	/// <remarks>
	///   <para>Provides Identor input data for batch Factor creation. See the Identor and AttachIdentor operation documentation for details and parameter restrictions.</para>
	/// </remarks>
	public class FabBatchNewFactorIdentor : FabObject {
	
		/// <summary>
		///   
		/// </summary>
		public byte TypeId { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public string Value { get; set; }
		
	}

	
	/*================================================================================================*/
	/// <summary>
	///   Provides Locator input data for batch Factor creation.
	/// </summary>
	/// <remarks>
	///   <para>Provides Locator input data for batch Factor creation. See the Locator and AttachLocator operation documentation for details and parameter restrictions.</para>
	/// </remarks>
	public class FabBatchNewFactorLocator : FabObject {
	
		/// <summary>
		///   
		/// </summary>
		public byte TypeId { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public double ValueX { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public double ValueY { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public double ValueZ { get; set; }
		
	}

	
	/*================================================================================================*/
	/// <summary>
	///   Provides Vector input data for batch Factor creation.
	/// </summary>
	/// <remarks>
	///   <para>Provides Vector input data for batch Factor creation. See the Vector and AttachVector operation documentation for details and parameter restrictions.</para>
	/// </remarks>
	public class FabBatchNewFactorVector : FabObject {
	
		/// <summary>
		///   
		/// </summary>
		public long AxisArtifactId { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public byte TypeId { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public byte UnitId { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public byte UnitPrefixId { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public long Value { get; set; }
		
	}

	
	/*================================================================================================*/
	/// <summary>
	///   TODO
	/// </summary>
	/// <remarks>
	///   <para>TODO</para>
	/// </remarks>
	public class FabBatchNewObject : FabObject {
	
		/// <summary>
		///   TODO
		/// </summary>
		public long BatchId { get; set; }
		
	}

	
	/*================================================================================================*/
	/// <summary>
	///   TODO
	/// </summary>
	/// <remarks>
	///   <para>TODO</para>
	/// </remarks>
	public class FabBatchResult : FabObject {
	
		/// <summary>
		///   TODO
		/// </summary>
		public long BatchId { get; set; }
		
		/// <summary>
		///   TODO
		/// </summary>
		public FabError Error { get; set; }
		
		/// <summary>
		///   TODO
		/// </summary>
		public long ResultId { get; set; }
		
	}

	
	/*================================================================================================*/
	/// <summary>
	///   Represents any item (real, imaginary, virtual, conceptual, or otherwise) that an App or User can define and/or use to generate meaning.
	/// </summary>
	/// <remarks>
	///   <para>Represents any item (real, imaginary, virtual, conceptual, or otherwise) that an App or User can define and/or use to generate meaning. Classes and Instances are closely related, and are the primary method for generating new Artifacts.</para>
	///   <para>A Class represents a particular group, type, set, or category of items. Each Class must uniquely identifiable (via name and disambiguation) amonst all other Classes.</para>
	///   <para>Ellie's Class Example: Ellie is building an App for dog lovers, but there are not yet animal-related Classes for Ellie to use. She first creates broad Classes (like 'Animal', 'Mammal', and 'Canine') and relationships between them (like 'Canine is a Mammal').</para>
	///   <para>She then creates narrower Classes for each dog grouping (like 'Working Dog') and breed (like 'Great Dane'), adding relevant relationships along the way. A Class named 'Boxer' already exists, but it has a sports-related meaning. She adds a new 'Boxer' Class with a 'Dog Breed' disambiguation value to resolve this conflict.</para>
	/// </remarks>
	public class FabClass : FabArtifact {
	
		/// <summary>
		///   Uniquely identifies this object amongst all other objects of this type.
		/// </summary>
		public long ClassId { get; set; }
		
		/// <summary>
		///   A secondary label or identifier, used to resolve unique-name conflicts.
		/// </summary>
		public string Disamb { get; set; }
		
		/// <summary>
		///   A descriptive name or title.
		/// </summary>
		public string Name { get; set; }
		
		/// <summary>
		///   A summary of the Class's intended meaning or purpose.
		/// </summary>
		public string Note { get; set; }
		
	}

	
	/*================================================================================================*/
	/// <summary>
	///   A Factor Element that describes and refines the relationship between the Factor's two Artifacts.
	/// </summary>
	/// <remarks>
	///   <para>A Factor Element that describes and refines the relationship between the Factor's two Artifacts. Descriptors are the only required Factor Element.</para>
	///   <para>First, the DescriptorType provides semantic meaning to the relationship, such as: a A "is a" B, or C "sounds like" D. Since this relationship is directional (flowing from the Factor's primary Artifact and to the related Artifact), the DescriptorType must coordinate correctly with the relationship's direction.</para>
	///   <para>Relationship Example: Objective:</para>
	///   <para>Describe that a circle is a shape. </para>
	///   <para>Method:</para>
	///   <para>- The Factor uses 'Circle' as the primary Artifact and 'Shape' as the related Artifact.</para>
	///   <para>- The Descriptor uses the 'Is A' DescriptorType.</para>
	///   <para>Factor Phrase:</para>
	///   <para>Circle ... Is A ... Shape.</para>
	///   <para>Descriptors also offer optional (but powerful) refinement capabilities, which allow a Descriptor to be very specific. Using any Artifact, a Descriptor may refine the DescriptorType, the Factor's primary Artifact, and/or the Factor's related Artifact. Note: while these Artifact links are discussed here in the context of a Descriptor, the actual traversal links exist with the Factor.</para>
	///   <para>Refinement Example: Objective:</para>
	///   <para>Describe that car A and car B have headlights with a similar shape.</para>
	///   <para>Method:</para>
	///   <para>- The Factor uses 'Car A' as the primary Artifact and 'Car B' as the related Artifact.</para>
	///   <para>- The Descriptor uses the 'Is Similar To' DescriptorType, uses 'Headlight' to refine both Artifacts, and uses 'Shape' to refine the DescriptorType.</para>
	///   <para>Factor Phrase:</para>
	///   <para>Car A (more specifically, its) Headlight ... Is Similar To (more specifically, by) Shape ... Car B (more specifically, its) Headlight.</para>
	/// </remarks>
	public class FabDescriptor : FabObject {
	
		/// <summary>
		///   Specifies the type of relationship or connection.
		/// </summary>
		public byte TypeId { get; set; }
		
	}

	
	/*================================================================================================*/
	/// <summary>
	///   A Factor Element that creates a directional, action-based flow between the Factor's two Artifacts. The nature of a Director's pathway depends on its DirectorType.
	/// </summary>
	/// <remarks>
	///   <para>A Factor Element that creates a directional, action-based flow between the Factor's two Artifacts.</para>
	///   <para>The nature of a Director's pathway depends on its DirectorType. The Director can  represent a factual, well-defined path, a virtual link, a suggested flow, etc.</para>
	///   <para>A Director specifies a DirectorAction for each of the Factor's Artifacts, which give additional meaning to the Director's pathway. The primary action is meant to be performed on the primary Artifact before the pathway begins. The related action is meant to be performed on the related Artifact after the pathway ends.</para>
	///   <para>Defined Pathway Example: Objective:</para>
	///   <para>Direct along the defined pathway of listening to a particular album's third and fourth songs (song C and D) in order.</para>
	///   <para>Method:</para>
	///   <para>- The Factor uses 'Song C' as the primary Artifact and 'Song D' as the related Artifact.</para>
	///   <para>- The Descriptor uses the 'IsRelatedTo' DescriptorType.</para>
	///   <para>- The Director uses the 'Defined Path' DirectorType and the 'Listen' DirectorAction for each Artifact.</para>
	///   <para>Factor Phrase:</para>
	///   <para>Song C ... Is Related To ... Song D. (The) Listen (action on) ... Song C ...  (leads to the) Listen (action on) ... Song D ... (via) Defined Path. Suggested Pathway Example: Objective:</para>
	///   <para>Direct along a suggested pathway of listening to song A and then learning about that song's vocalist, singer B.</para>
	///   <para>Method:</para>
	///   <para>- The Factor uses 'Song A' as the primary Artifact and 'Singer B' as the related Artifact.</para>
	///   <para>- The Descriptor uses the 'IsRelatedTo' DescriptorType.</para>
	///   <para>- The Director uses the 'Suggested Path' DirectorType, the 'Listen' primary DirectorAction, and the 'Learn' related DirectorAction.</para>
	///   <para>Factor Phrase:</para>
	///   <para>Song A ... Is Related To ... Song B. (The) Listen (action on) ... Song A ... (leads to the) Learn (action on) ... Singer B ... (via) Suggested Path.</para>
	/// </remarks>
	public class FabDirector : FabObject {
	
		/// <summary>
		///   Specifies the action to be performed on the Factor's primary Artifact.
		/// </summary>
		public byte PrimaryActionId { get; set; }
		
		/// <summary>
		///   Specifies the action to be performed on the Factor's related Artifact.
		/// </summary>
		public byte RelatedActionId { get; set; }
		
		/// <summary>
		///   Specifies the type and reason for the pathway.
		/// </summary>
		public byte TypeId { get; set; }
		
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
		///   A sentence or paragraph providing details about the error.
		/// </summary>
		public string Message { get; set; }
		
		/// <summary>
		///   A descriptive name that is associated with the error code.
		/// </summary>
		public string Name { get; set; }
		
	}

	
	/*================================================================================================*/
	/// <summary>
	///   A Factor Element that applies the concept of time to a particular Factor. An Eventor places a Factor at a specific point in time and describes why it is significant to the Factor.
	/// </summary>
	/// <remarks>
	///   <para>A Factor Element that applies the concept of time to a particular Factor.</para>
	///   <para>An Eventor places a Factor at a specific point in time and describes why it is significant to the Factor. The EventorType provides this significance, establishing that this particular point in time is when the Factor started, occurred, is expected, etc.</para>
	///   <para>Each Eventor represents one particular point in time, however, the precision of that point in time can vary. The EventorPrecision allows a point in time to specify a level of accuracy ranging from one second to one year.</para>
	///   <para>Started Example: Objective:</para>
	///   <para>Specify that Albert Einstein was born (i.e. started his life) on March 14, 1879.</para>
	///   <para>Method:</para>
	///   <para>- The Factor uses 'Albert Einstein' as the primary Artifact and 'Life' as the related Artifact.</para>
	///   <para>- The Descriptor uses the 'Has A' DescriptorType. </para>
	///   <para>- The Eventor uses 'March 14, 1879' as its DateTime value, the 'Started' EventorType, and the 'Day' EventorPrecision.</para>
	///   <para>Factor Phrase:</para>
	///   <para>Albert Einstein ... Has A ... Life, ... (an event which) Started ... (on the) Day ... March 14, 1879. Expected Example: Objective:</para>
	///   <para>Specify that person A plans to attend college B in the year 2024.</para>
	///   <para>Method:</para>
	///   <para>- The Factor uses 'Person A' as the primary Artifact and 'College B' as the related Artifact.</para>
	///   <para>- The Descriptor uses the 'Participates In' DescriptorType and the 'Attend' Artifact to refine it.</para>
	///   <para>- The Eventor uses '2024' as its DateTime value, the 'Is Expected' EventorType, and the 'Year' EventorPrecision.</para>
	///   <para>Factor Phrase:</para>
	///   <para>Person A ... Participates In (more specifically, by) Attend(ing) ... College B, ... (an event which) Is Expected (to occur) ... (in the) Year ... 2024.</para>
	///   <para>Note: every Factor recieves a timestamp upon creation. This timestamp is not related to the Eventor.</para>
	/// </remarks>
	public class FabEventor : FabObject {
	
		/// <summary>
		///   A particular point in time, with a level of accuracy defined by EventorPrecision.
		/// </summary>
		public long DateTime { get; set; }
		
		/// <summary>
		///   Specifies the level of accuracy given to this point in time.
		/// </summary>
		public byte PrecisionId { get; set; }
		
		/// <summary>
		///   Specifies the significance of this point in time.
		/// </summary>
		public byte TypeId { get; set; }
		
	}

	
	/*================================================================================================*/
	/// <summary>
	///   Provides a specific piece of information, knowledge, or opinion about a pair of Artifacts.
	/// </summary>
	/// <remarks>
	///   <para>Provides a specific piece of information, knowledge, or opinion about a pair of Artifacts. Factors and Artifacts are the central components of the Fabric architecture.</para>
	///   <para>A Factor forms a directional relationship from its primary Artifact to its related Artifact. It contains one or more components, called Factor Elements. Each Element has a specific ability to refine, describe, and/or supplement this Artifact relationship in a meaningful way.</para>
	///   <para>There are six Factor Elements: Descriptor, Director, Eventor, Identor, Locator, and Vector. The Descriptor is the only required Element; the rest are optional. A Factor typically uses one or two Elements, but (in very complex cases) could potentially use four or more.</para>
	///   <para>Just as there are no restrictions on what a particular Artifact can represent, there are no restrictions on the type of meaning or information a Factors can provide. A FactorAssertion allows a Factor to specify that it represents (among other things) a fact or an opinion. This level of confidence for a particular Factor allows Users and Apps to more effectively find the type of information they desire.</para>
	/// </remarks>
	public class FabFactor : FabNode {
	
		/// <summary>
		///   The date/time of completion.
		/// </summary>
		public long? Completed { get; set; }
		
		/// <summary>
		///   The date/time of creation.
		/// </summary>
		public long Created { get; set; }
		
		/// <summary>
		///   This element defines the relationship between the primary and related Artifact.
		/// </summary>
		public FabDescriptor Descriptor { get; set; }
		
		/// <summary>
		///   This element creates a directional pathway between the primary and related Artifacts.
		/// </summary>
		public FabDirector Director { get; set; }
		
		/// <summary>
		///   This element applies the concept of time.
		/// </summary>
		public FabEventor Eventor { get; set; }
		
		/// <summary>
		///   Specifies the type of information and/or level of confidence.
		/// </summary>
		public byte FactorAssertionId { get; set; }
		
		/// <summary>
		///   Uniquely identifies this object amongst all other objects of this type.
		/// </summary>
		public long FactorId { get; set; }
		
		/// <summary>
		///   This element applies a name or identifier.
		/// </summary>
		public FabIdentor Identor { get; set; }
		
		/// <summary>
		///   Specifies whether this Factor helps to directly and uniquely define the primary Artifact.
		/// </summary>
		public bool IsDefining { get; set; }
		
		/// <summary>
		///   This element provides a geographical or relative position.
		/// </summary>
		public FabLocator Locator { get; set; }
		
		/// <summary>
		///   A summary of the Factor's intended meaning or purpose.
		/// </summary>
		public string Note { get; set; }
		
		/// <summary>
		///   This element applies a numeric axis and value.
		/// </summary>
		public FabVector Vector { get; set; }
		
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
		///   The complete list of services.
		/// </summary>
		public FabService[] Services { get; set; }
		
	}

	
	/*================================================================================================*/
	/// <summary>
	///   A Factor Element that applies a name or identifier to a particular Factor. An Identor attaches a text-based value to a Factor.
	/// </summary>
	/// <remarks>
	///   <para>A Factor Element that applies a name or identifier to a particular Factor.</para>
	///   <para>An Identor attaches a text-based value to a Factor. This value can represent a a full name, a nickname, a globally-unique identifier, a reference key to some other system, etc.</para>
	///   <para>The IdentorType hints at the purpose or intent of the Identor. A "Text" IdentorType is typically meant to provide enhanced search capabilities (like finding a person by an alternate name) or some other organizational use.  A "Key" IdentorType is typically meant to associate a Factor with some external system (like a Product ID from an online store) or to provide an App with a "reverse lookup" for their own internal IDs.</para>
	///   <para>Alternate Name Example: Objective:</para>
	///   <para>Identify that Grand Valley State University is also known as (has the alternate name of) 'Grand Valley'.</para>
	///   <para>Method:</para>
	///   <para>- The Factor uses 'Grand Valley State University' as the primary Artifact and 'Name' as the related Artifact.</para>
	///   <para>- The Descriptor uses the 'Has A' DescriptorType, and an 'Alternative' Artifact to refine the Factor's related Artifact.</para>
	///   <para>- The Identor uses 'Grand Valley' as its text value, and the 'Text' IdentorType.</para>
	///   <para>Factor Phrase:</para>
	///   <para>Grand Valley State University ... Has A ... Name (more specifically, an) Alternative, ... (identified by the) Text ... 'Grand Valley'. Abbreviation Example: Objective:</para>
	///   <para>Identify that Grand Valley State University is also known as (has the abbreviation of) 'GVSU'.</para>
	///   <para>Method:</para>
	///   <para>- The Factor uses 'Grand Valley State University' as the primary Artifact and 'Abbreviation' as the related Artifact.</para>
	///   <para>- The Descriptor uses the 'Has A' DescriptorType. </para>
	///   <para>- The Identor uses 'GVSU' as its text value, and the 'Text' IdentorType.</para>
	///   <para>Factor Phrase:</para>
	///   <para>Grand Valley State University ... Has A(n) ... Abbreviation, ... (identified by the) Text ... 'GVSU'. Identifier Example: Objective:</para>
	///   <para>Identify that game A is accessible in store B via its ID, which is '123a-45678'.</para>
	///   <para>Method:</para>
	///   <para>- The Factor uses 'Game A' as the primary Artifact and 'Store B' as the related Artifact.</para>
	///   <para>- The Descriptor uses the 'Is Found In' DescriptorType. </para>
	///   <para>- The Identor uses '123a-45678' as its text value, and the 'Key' IdentorType.</para>
	///   <para>Factor Phrase:</para>
	///   <para>Game A ... Is Found In ... Store B, ... (identified by the) Key ... '123a-45678'.</para>
	/// </remarks>
	public class FabIdentor : FabObject {
	
		/// <summary>
		///   Specifies the value's purpose or intent.
		/// </summary>
		public byte TypeId { get; set; }
		
		/// <summary>
		///   A text-based value that can represent names, numbers, IDs, GUIDs, etc.
		/// </summary>
		public string Value { get; set; }
		
	}

	
	/*================================================================================================*/
	/// <summary>
	///   Represents any item (real, imaginary, virtual, conceptual, or otherwise) that an App or User can define and/or use to generate meaning.
	/// </summary>
	/// <remarks>
	///   <para>Represents any item (real, imaginary, virtual, conceptual, or otherwise) that an App or User can define and/or use to generate meaning. Classes and Instances are closely related, and are the primary method for generating new Artifacts.</para>
	///   <para>An Instance represents a singular, unique item. It may have a specific name, however, the name is not required to be unique. Instead, the creator should apply Factors to make the Instance as specific and meaningful as possible.</para>
	///   <para>Ellie's Instance Example: Continued from Ellie's Class Example...</para>
	///   <para>After completing her new Classes, Ellie would like to add her own dog. She creates an Instance named 'Gulliver', and attaches several Factors to make the Instance as unique as possible. Her Factors define that Gulliver is a Lhasa Apso breed, is owned by Ellie, and was born in September 2007. Zach's Instance Example: Zach built an App that allows users to rate restaurants and individual meals. He created Classes for restaurant chains and meal types. He also created Instances for specific restaurants (with relevant relationships for each).</para>
	///   <para>When Users rate a particular meal, they also specify the restaurant, the day/time the meal was served, and the meal type. Behind the scenes, the App uses this data to construct a new Instance and its relationships. Because Zach's Instances are well-defined, one User could rate the same meal (at the same restaurant) every day, creating a unique and meaningful Instance each time.</para>
	/// </remarks>
	public class FabInstance : FabArtifact {
	
		/// <summary>
		///   A secondary label or identifier, used to resolve unique-name conflicts.
		/// </summary>
		public string Disamb { get; set; }
		
		/// <summary>
		///   Uniquely identifies this object amongst all other objects of this type.
		/// </summary>
		public long InstanceId { get; set; }
		
		/// <summary>
		///   A descriptive name or title.
		/// </summary>
		public string Name { get; set; }
		
		/// <summary>
		///   A summary of the Instance's intended meaning or purpose.
		/// </summary>
		public string Note { get; set; }
		
	}

	
	/*================================================================================================*/
	/// <summary>
	///   A Factor Element that positions a Factor using geographic or relative coordinates. A Locator attaches a three-dimensional coordinate to a Factor.
	/// </summary>
	/// <remarks>
	///   <para>A Factor Element that positions a Factor using geographic or relative coordinates.</para>
	///   <para>A Locator attaches a three-dimensional coordinate to a Factor. The LocatorType defines the spatial context of the coordinate, supporting both geographic and relative positioning.</para>
	///   <para>Geographic coordinates represent a position on a sphere, like Earth.  They use X for longitude, Y for latitude, and Z for elevation (in metres above sea level). Use zero for elevation if it is not known or specified.</para>
	///   <para>Geographic Example: Objective:</para>
	///   <para>Specify that person A took photo B from a spot near the Eiffel Tower.</para>
	///   <para>Method:</para>
	///   <para>- The Factor uses 'Photo B' as the primary Artifact and 'Person A' as the related Artifact.</para>
	///   <para>- The Descriptor uses the 'Is Created By' DescriptorType. </para>
	///   <para>- The Locator uses the 'Earth Coordinate' LocatorType, a '2.292977' value for X, a '48.858154' value for Y, and (optionally) a '34.24' value for Z.</para>
	///   <para>Factor Phrase:</para>
	///   <para>Photo B ... Is Created By ... Person A, ... (at an) Earth Coordinate (location of) ... X (longitude) = '2.292977' ... Y (latitude) = '48.858154' ... Z (elevation) = '34.24' (metres above sea level).</para>
	///   <para>Relative coordinates represent a position relative to the origin and size/bounds of the Factor's primary Artifact. There are LocatorTypes for one, two, and three-dimensional relative coordinates. For coordinates which have:</para>
	///   <para>- One dimension, use X for time or progress, and leave Y and Z equal to zero.</para>
	///   <para>- Two dimensions, use X for width, Y for height, and leave Z equal to zero.</para>
	///   <para>- Three dimensions, use X, Y, and Z values which correspond to the Artifact's X, Y, and Z values. If these axes are undefined, use X for width (or breadth), Y for length (or depth), and Z for height (or elevation).</para>
	///   <para>Relative 1D Example: Objective:</para>
	///   <para>Specify that book A refers to painting B on page 148 of 200 (about 74% of the book's length).</para>
	///   <para>Method:</para>
	///   <para>- The Factor uses 'Book A' as the primary Artifact and 'Painting B' as the related Artifact.</para>
	///   <para>- The Descriptor uses the 'Refers To' DescriptorType. </para>
	///   <para>- The Locator uses the 'Related 1D' LocatorType, a '0.74' value for X, a '0.0' value for Y, and a '0.0' value for Z.</para>
	///   <para>Factor Phrase:</para>
	///   <para>Book A ... Refers To ... Painting B, ... (at a) Relative 1D (location of) ... X (position) = 0.74. Relative 2D Example: Objective:</para>
	///   <para>Specify that photo A includes person B near the top-right (25% from the top, 84% from the left) of the image.</para>
	///   <para>Method:</para>
	///   <para>- The Factor uses 'Photo A' as the primary Artifact and 'Person B' as the related Artifact.</para>
	///   <para>- The Descriptor uses the 'Refers To' DescriptorType. </para>
	///   <para>- The Locator uses the 'Relative 2D' LocatorType, a '0.84' value for X, a '0.25' value for Y, and a '0.0' value for Z.</para>
	///   <para>Factor Phrase:</para>
	///   <para>Photo A ... Refers To ... Person B, ... (at a) Relative 2D (location of) ... X (width) = '0.84' ... Y (height) = '0.25'.</para>
	/// </remarks>
	public class FabLocator : FabObject {
	
		/// <summary>
		///   Specifies the spatial context of the coordinate.
		/// </summary>
		public byte TypeId { get; set; }
		
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
		
	}

	
	/*================================================================================================*/
	/// <summary>
	///   An association between a User and an App.
	/// </summary>
	/// <remarks>
	///   <para>An association between a User and an App. The App administrator(s) can grant various access privileges to a Member by creating a MemberTypeAssign that uses a different MemberType.</para>
	///   <para>Every item added to Fabric is associated with a particular Member. This enables Fabric to determine which App or User is responsible for any particular item, enforce applicable access rights, analyze the data for a particular App and/or User, etc.</para>
	/// </remarks>
	public class FabMember : FabNode {
	
		/// <summary>
		///   Uniquely identifies this object amongst all other objects of this type.
		/// </summary>
		public long MemberId { get; set; }
		
	}

	
	/*================================================================================================*/
	/// <summary>
	///   An assignment of a MemberType to a target Member.
	/// </summary>
	/// <remarks>
	///   <para>An assignment of a MemberType to a target Member. This action is performed by some Member, which is usually (but not always) different from the target Member. Each Member maintains one active MemberTypeAssign and a list of historical MemberTypeAssigns.</para>
	/// </remarks>
	public class FabMemberTypeAssign : FabNodeForAction {
	
		/// <summary>
		///   Uniquely identifies this object amongst all other objects of this type.
		/// </summary>
		public long MemberTypeAssignId { get; set; }
		
		/// <summary>
		///   Specifies the Member's state and/or access privileges.
		/// </summary>
		public byte MemberTypeId { get; set; }
		
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
		///   The current day of the month.
		/// </summary>
		public int Day { get; set; }
		
		/// <summary>
		///   The current hour (using 24-hour time).
		/// </summary>
		public int Hour { get; set; }
		
		/// <summary>
		///   The current millisecond.
		/// </summary>
		public double Millisecond { get; set; }
		
		/// <summary>
		///   The current minute.
		/// </summary>
		public int Minute { get; set; }
		
		/// <summary>
		///   The current month.
		/// </summary>
		public int Month { get; set; }
		
		/// <summary>
		///   The current second.
		/// </summary>
		public int Second { get; set; }
		
		/// <summary>
		///   The current number of Ticks since January 1, 0001.
		/// </summary>
		public long Ticks { get; set; }
		
		/// <summary>
		///   A Unix timestamp value, derived from the Ticks value.
		/// </summary>
		public long Unix { get; set; }
		
		/// <summary>
		///   The current year.
		/// </summary>
		public int Year { get; set; }
		
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
		///   The day of the month that this build was released.
		/// </summary>
		public int Day { get; set; }
		
		/// <summary>
		///   The major revision number for this build.
		/// </summary>
		public int Major { get; set; }
		
		/// <summary>
		///   The minor revision number for this build.
		/// </summary>
		public int Minor { get; set; }
		
		/// <summary>
		///   The month that this build was released.
		/// </summary>
		public int Month { get; set; }
		
		/// <summary>
		///   The patch revision number for this build.
		/// </summary>
		public int Patch { get; set; }
		
		/// <summary>
		///   The revision text is derived from internal build information.
		/// </summary>
		public string Revision { get; set; }
		
		/// <summary>
		///   This build's full version string, in the format: "Major.Minor.Patch.Revision".
		/// </summary>
		public string Version { get; set; }
		
		/// <summary>
		///   The year that this build was released.
		/// </summary>
		public int Year { get; set; }
		
	}

	
	/*================================================================================================*/
	/// <summary>
	///   The base class for all nodes present in the Fabric "graph".
	/// </summary>
	/// <remarks>
	///   <para>The base class for all nodes present in the Fabric "graph".  Only Nodes are present and traversable via the Traversal Service.</para>
	/// </remarks>
	public class FabNode : FabObject {
	
		/// <summary>
		///   Append this value to the current URI to filter down to this specific Node in current traversal path.
		/// </summary>
		public string Uri { get; set; }
		
	}

	
	/*================================================================================================*/
	/// <summary>
	///   The base class for various "actions" that can occur.
	/// </summary>
	/// <remarks>
	///   <para>The base class for various "actions" that can occur.</para>
	/// </remarks>
	public class FabNodeForAction : FabNode {
	
		/// <summary>
		///   A brief note describing this action.
		/// </summary>
		public string Note { get; set; }
		
		/// <summary>
		///   The date/time this action was performed.
		/// </summary>
		public long Performed { get; set; }
		
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
		///   The number of seconds until the access token expires.
		/// </summary>
		public int expires_in { get; set; }
		
		/// <summary>
		///   A code that refreshes the authentication session for an expired OAuth access token.
		/// </summary>
		public string refresh_token { get; set; }
		
		/// <summary>
		///   For the current Fabric OAuth implementation, this value is always equal to "bearer".
		/// </summary>
		public string token_type { get; set; }
		
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
		///   An error code as defined by the OAuth 2.0 specification.
		/// </summary>
		public string error { get; set; }
		
		/// <summary>
		///   Provides specific details about the error.
		/// </summary>
		public string error_description { get; set; }
		
		/// <summary>
		///   Returns the 'state' value that the App provided in the original Oauth request.
		/// </summary>
		public string state { get; set; }
		
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
		///   Identifies a particular OAuth session.
		/// </summary>
		public string access_token { get; set; }
		
		/// <summary>
		///   Describes the result of the logout attempt.
		/// </summary>
		public int success { get; set; }
		
	}

	
	/*================================================================================================*/
	/// <summary>
	///   The base class for all Objects returned by Fabric's services.
	/// </summary>
	/// <remarks>
	///   <para>The base class for all Objects returned by Fabric's services.</para>
	/// </remarks>
	public class FabObject {
	
		/// <summary>
		///   The data type of this object.
		/// </summary>
		public string FabType { get; set; }
		
	}

	
	/*================================================================================================*/
	/// <summary>
	///   The response wrapper for all API requests.
	/// </summary>
	/// <remarks>
	///   <para>The response wrapper for all API requests. It contains a data payload, error information, and/or other metadata.</para>
	/// </remarks>
	public partial class FabResponse {
	
		/// <summary>
		///   If an authenticated Member made this request, this identifies the App associated with that Member.
		/// </summary>
		public long AppId { get; set; }
		
		/// <summary>
		///   The base URI for the Fabric API.
		/// </summary>
		public string BaseUri { get; set; }
		
		/// <summary>
		///   The number of results in the returned Data list.
		/// </summary>
		public int Count { get; set; }
		
		/// <summary>
		///   Contains the result of the request as a list of zero or more Objects.
		/// </summary>
		public virtual object DataString { get; set; }
		
		/// <summary>
		///   The number of characters in the JSON representation of the Data list.
		/// </summary>
		public int DataLen { get; set; }
		
		/// <summary>
		///   The time (in milliseconds) that it took the database server(s) to complete all data requests.
		/// </summary>
		public int DbMs { get; set; }
		
		/// <summary>
		///   If an error occurred, this contains information about the problem.
		/// </summary>
		public FabError Error { get; set; }
		
		/// <summary>
		///   The traversal functions available for the current node list.
		/// </summary>
		public string[] Functions { get; set; }
		
		/// <summary>
		///   Indicates whether there are more nodes available beyond the returned node list.
		/// </summary>
		public bool HasMore { get; set; }
		
		/// <summary>
		///   The HTTP status returned by this request.
		/// </summary>
		public int HttpStatus { get; set; }
		
		/// <summary>
		///   The traversal links available for the current node list.
		/// </summary>
		public FabStepLink[] Links { get; set; }
		
		/// <summary>
		///   The URI of the current request.
		/// </summary>
		public string RequestUri { get; set; }
		
		/// <summary>
		///   The starting index of the returned node list.
		/// </summary>
		public long StartIndex { get; set; }
		
		/// <summary>
		///   The date/time of the current request.
		/// </summary>
		public long Timestamp { get; set; }
		
		/// <summary>
		///   The time (in milliseconds) that it took the server(s) to complete this request.
		/// </summary>
		public int TotalMs { get; set; }
		
		/// <summary>
		///   If an authenticated Member made this request, this identifies the User associated with that Member.
		/// </summary>
		public long UserId { get; set; }
		
	}

	
	/*================================================================================================*/
	/// <summary>
	///   Represents the root, or starting point, of all Traversal Service queries.
	/// </summary>
	/// <remarks>
	///   <para>Represents the root, or starting point, of all Traversal Service queries. The Root provides traversal links to all other available objects.</para>
	/// </remarks>
	public class FabRoot : FabNode {
	
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
		///   The complete list of operations for this service.
		/// </summary>
		public FabServiceOperation[] Operations { get; set; }
		
		/// <summary>
		///   Append this path to the current URI to obtain details about this service.
		/// </summary>
		public string Uri { get; set; }
		
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
		///   The required HTTP method.
		/// </summary>
		public string Method { get; set; }
		
		/// <summary>
		///   A descriptive name for this operation.
		/// </summary>
		public string Name { get; set; }
		
		/// <summary>
		///   The type of Object returned by this operation.
		/// </summary>
		public string ReturnType { get; set; }
		
		/// <summary>
		///   Append this value to the current URI (and use the correct HTTP method) to invoke this operation.
		/// </summary>
		public string Uri { get; set; }
		
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
		public int BuildDay { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public int BuildMonth { get; set; }
		
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
		public FabSpecEnum[] Enums { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public FabSpecObject[] Objects { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public FabSpecService[] Services { get; set; }
		
	}

	
	/*================================================================================================*/
	/// <summary>
	///   
	/// </summary>
	/// <remarks>
	///   
	/// </remarks>
	public class FabSpecEnum : FabSpecObject {
	
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
		public string Description { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public string Extends { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public bool IsBaseClass { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public string Name { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public FabSpecObjectProp[] Properties { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public string[] TraversalFunctions { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public FabSpecTravLink[] TraversalLinks { get; set; }
		
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
		public bool? IsCaseInsensitive { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public bool? IsNullable { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public bool? IsPrimaryKey { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public bool? IsTimestamp { get; set; }
		
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
		public string Abstract { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public string Description { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public string Name { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public FabSpecServiceOperation[] Operations { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public string ResponseWrapper { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public FabSpecTravFunc[] TraversalFunctions { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public string Uri { get; set; }
		
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
		public string AuthMemberOwns { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public string Description { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public string Method { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public string Name { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public FabSpecServiceOperationParam[] Parameters { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public string RequiredAuth { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public string ReturnType { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public string Uri { get; set; }
		
	}

	
	/*================================================================================================*/
	/// <summary>
	///   
	/// </summary>
	/// <remarks>
	///   
	/// </remarks>
	public class FabSpecServiceOperationParam : FabSpecValue {
	
		/// <summary>
		///   
		/// </summary>
		public int Index { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public string ParamType { get; set; }
		
	}

	
	/*================================================================================================*/
	/// <summary>
	///   
	/// </summary>
	/// <remarks>
	///   
	/// </remarks>
	public class FabSpecTravFunc : FabObject {
	
		/// <summary>
		///   
		/// </summary>
		public string Description { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public string Name { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public FabSpecTravFuncParam[] Parameters { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public string Uri { get; set; }
		
	}

	
	/*================================================================================================*/
	/// <summary>
	///   
	/// </summary>
	/// <remarks>
	///   
	/// </remarks>
	public class FabSpecTravFuncParam : FabSpecValue {
	
		/// <summary>
		///   
		/// </summary>
		public int Index { get; set; }
		
	}

	
	/*================================================================================================*/
	/// <summary>
	///   
	/// </summary>
	/// <remarks>
	///   
	/// </remarks>
	public class FabSpecTravLink : FabObject {
	
		/// <summary>
		///   
		/// </summary>
		public string Description { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public string From { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public string FromConn { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public bool IsOutgoing { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public string Name { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public string Relation { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public string To { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public string ToConn { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public string Type { get; set; }
		
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
		public string Description { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public bool? IsOptional { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public int? Len { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public int? LenMax { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public int? LenMin { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public int? Max { get; set; }
		
		/// <summary>
		///   
		/// </summary>
		public int? Min { get; set; }
		
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
		public string ValidRegex { get; set; }
		
	}

	
	/*================================================================================================*/
	/// <summary>
	///   Contains all the relevant information about a Node's traversal link.
	/// </summary>
	/// <remarks>
	///   <para>Contains all the relevant information about a Node's traversal link.</para>
	/// </remarks>
	public class FabStepLink : FabObject {
	
		/// <summary>
		///   The Node type returned by the opposite end of this link.
		/// </summary>
		public string Class { get; set; }
		
		/// <summary>
		///   Indicates whether this link is outgoing (starting from the current Node) or incoming (starting from another Node).
		/// </summary>
		public bool IsOut { get; set; }
		
		/// <summary>
		///   The relation type of this link.
		/// </summary>
		public string Rel { get; set; }
		
		/// <summary>
		///   Append this value to the current URI to add this link to the traversal path.
		/// </summary>
		public string Uri { get; set; }
		
	}

	
	/*================================================================================================*/
	/// <summary>
	///   A hyperlink or path (uniform resource locator) to some web page, a file, or some other type of content. While a Url is a type of Artifact, it should be used with certain constraints.
	/// </summary>
	/// <remarks>
	///   <para>A hyperlink or path (uniform resource locator) to some web page, a file, or some other type of content.</para>
	///   <para>While a Url is a type of Artifact, it should be used with certain constraints. Consider an scenario where a Url leads to web page with a news article and a photo. The proper prodedure is to create a new Instance for both the news article and photo. With this method:</para>
	///   <para>- The news article and photo Instances can receive Factors independently.</para>
	///   <para>- The Url should only receive Factors related to the actual web page, its design, etc.</para>
	///   <para>- Every Url that displays this particular news article can refer the same news article Instance.</para>
	/// </remarks>
	public class FabUrl : FabArtifact {
	
		/// <summary>
		///   A unique, valid absolute URL.
		/// </summary>
		public string AbsoluteUrl { get; set; }
		
		/// <summary>
		///   A descriptive name or title.
		/// </summary>
		public string Name { get; set; }
		
		/// <summary>
		///   Uniquely identifies this object amongst all other objects of this type.
		/// </summary>
		public long UrlId { get; set; }
		
	}

	
	/*================================================================================================*/
	/// <summary>
	///   A registered Fabric account that has indirect access (via Apps) to the Fabric API.
	/// </summary>
	/// <remarks>
	///   <para>A registered Fabric account that has indirect access (via Apps) to the Fabric API. A User can become a Member of an App, and then use the App's interface to interact with Fabric. An App's interface hides the complex details of the Fabric API, and instead provides intuitive features like custom inputs, searches, summaries, and visualizations. </para>
	///   <para>Users control their private account data and preferences using the Fabric website.</para>
	///   <para>Every item added to Fabric is associated with (via Member) a User and and an App. Thus, Fabric can determine which User is responsible for any particular item, enforce applicable access rights, analyze the data for a particular User or Member, etc.</para>
	/// </remarks>
	public class FabUser : FabArtifact {
	
		/// <summary>
		///   A unique username.
		/// </summary>
		public string Name { get; set; }
		
		/// <summary>
		///   Uniquely identifies this object amongst all other objects of this type.
		/// </summary>
		public long UserId { get; set; }
		
	}

	
	/*================================================================================================*/
	/// <summary>
	///   A Factor Element that applies a meaningful numeric axis and value to a particular Factor. A Vector attaches a numeric value to a Factor, using an arbitrary Artifact to define its "axis".
	/// </summary>
	/// <remarks>
	///   <para>A Factor Element that applies a meaningful numeric axis and value to a particular Factor.</para>
	///   <para>A Vector attaches a numeric value to a Factor, using an arbitrary Artifact to define its "axis". This axis depends entirely upon the Vector's purpose. For example, a factual Vector might use an Artifact like "Height" or "Shutter Speed". A Vector that provides an opinion might use an Artifact like "Quality" or "Excitement". While the choice of an axis Artififact is not restricted, it can be beneficial to use Artifacts which are other Apps or Users are already using as Vector axes. Note: while the axis Artifact link is discussed here in the context of a Vector, the actual traversal link exists with the Factor.</para>
	///   <para>The VectorType provides boundaries and context for the Vector's value. It can identify the value as a percentage, a level of agreement or disagreement, an opinion-based rating, or simply a plain numeric value. Each VectorType provides additional information, such as a VectorRange, to provide further meaning for the levels within the the allowed value boundaries.</para>
	///   <para>A Vector's numeric value often reflects a measurement or a has a specific unit. Furthermore, a Vector can use VectorUnitPrefix to specify an order of magnitude for the value. A Vector's value is a long integer, so the prefix is especially useful when fractional values are involved, or when the desired number is larger than a long integer.</para>
	///   <para>Small Value Example: Objective:</para>
	///   <para>Specify that image A (which is a photo) has a shutter speed of 1/250 second.</para>
	///   <para>Method:</para>
	///   <para>- The Factor uses 'Image A' as the primary Artifact and 'Photo' as the related Artifact.</para>
	///   <para>- The Descriptor uses the 'Is A' DescriptorType. </para>
	///   <para>- The Vector uses the 'Shutter Speed' Artifact as the axis, the 'Positive Long' VectorType, '4' as the value, the 'Milli' VectorUnitPrefix, and the 'Second' VectorUnit.</para>
	///   <para>Factor Phrase:</para>
	///   <para>Image A ... Is A ... Photo, ... (which, along the) Shutter Speed (axis) ... (with a) Positive Long (numerical range), ... (has a value) '4' ... Milli ... Second(s). Large Value Example: Objective:</para>
	///   <para>Specify that Earth and the Andromeda Galaxy are 2.5 million light years (2.2705 x 10^22 metres) apart.</para>
	///   <para>Method:</para>
	///   <para>- The Factor uses 'Earth' as the primary Artifact and 'Andromeda Galaxy' as the related Artifact.</para>
	///   <para>- The Descriptor uses the 'Is Related To' DescriptorType. </para>
	///   <para>- The Vector uses the 'Distance' Artifact as the axis, the 'Positive Long' VectorType, '22,705' as the value, the 'Exa' VectorUnitPrefix (represents 10^18), and the 'Metre' VectorUnit.</para>
	///   <para>Factor Phrase:</para>
	///   <para>Earth ... Is Related To ... Andromeda Galaxy, ... (which, along the) Distance (axis) ... (with a) Positive Long (numerical range), ... (has a value) '22,705' ... Exa ... Metre(s). Negative Value Example: Objective:</para>
	///   <para>Specify that article A mentions person B in a very unfair manner, about 80% of the maximum unfairness imaginable.</para>
	///   <para>Method:</para>
	///   <para>- The Factor uses 'Article A' as the primary Artifact and 'Person B' as the related Artifact.</para>
	///   <para>- The Descriptor uses the 'Refers To' DescriptorType. </para>
	///   <para>- The Vector uses the 'Fairness' Artifact as the axis, the 'Opposable Favorability' VectorType, '-80' as the value, the default 'Base' VectorUnitPrefix, and the default 'None' VectorUnit. This VectorType has bounds of -100 to +100.</para>
	///   <para>Factor Phrase:</para>
	///   <para>Article A ... Refers To ... Person B, ... (which, along the) Fairness (axis) ... (with a) Opposable Favorabillity (numerical range), ... (has a value) '-80'.</para>
	/// </remarks>
	public class FabVector : FabObject {
	
		/// <summary>
		///   Specifies its value's boundaries and context.
		/// </summary>
		public byte TypeId { get; set; }
		
		/// <summary>
		///   Specifies its value's unit of measurement.
		/// </summary>
		public byte UnitId { get; set; }
		
		/// <summary>
		///   Specifies its value's order of magnitude.
		/// </summary>
		public byte UnitPrefixId { get; set; }
		
		/// <summary>
		///   An integral value which is to be plotted along the specified axis.
		/// </summary>
		public long Value { get; set; }
		
	}

	
	// ReSharper resume InconsistentNaming

}