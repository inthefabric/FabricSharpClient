namespace Fabric.Clients.Cs.Gen {

	/*================================================================================================*/
	///<summary>
	///    A registered project, application, or business that has direct access to the Fabric API.  An App's primary purpose is to facilitate User interaction with Fabric.
	///</summary>
	///<remarks>
	///    <para>A registered project, application, or business that has direct access to the Fabric API.</para>
	///    <para>An App's primary purpose is to facilitate User interaction with Fabric. To accomplish this, an App typically creates an interface for its Users. This interface hides the complex details of the Fabric API, and instead provides intuitive features like custom inputs, searches, summaries, and visualizations. </para>
	///    <para>When a User becomes a Member of an App, they are granting that App permission to perform various actions on their behalf (via the App's interface). It is vital for an App to provide each User with a positive experience and do nothing to violate the User's trust.</para>
	///    <para>Every App has a special 'Data Provider' Member, which is typically controlled by that App's administrator. The 'Data Provider' allows the App to interact with Fabric as itself (rather than on behalf of a particular User).</para>
	///    <para>Every item added to Fabric is associated with (via Member) a User and and an App. Thus, Fabric can determine which App is responsible for any particular item, enforce applicable access rights, analyze the data for a particular App or Member, etc.</para>
	///</remarks>
	public class FabApp : FabArtifactOwnerNode {
	
		///<summary>
		///    Uniquely identifies this object amongst all other objects of this type.
		///</summary>
		public long AppId { get; set; }
		
		///<summary>
		///    A unique title or identifier.
		///</summary>
		public string Name { get; set; }
		
	}
	
	
	/*================================================================================================*/
	///<summary>
	///    An object which is able to (via Factor connections) accumulate meaning, context, user sentiment, and relationships.
	///</summary>
	///<remarks>
	///    <para>An object which is able to (via Factor connections) accumulate meaning, context, user sentiment, and relationships.  Artifacts and Factors are the central components of the Fabric architecture.</para>
	///    <para>Every Artifact maps exclusively to one other item in the Fabric architecture (such as an App, Class, Instance, or User). Fabric generates an Artifact automatically each time a new Artifact-enabled item is created.  Technically, each of these items 'has' an associated Artifact. However, due to the item's exclusive ownership, it is conceptually correct to say that each of these items 'is' an Artifact.</para>
	///    <para>There are no restrictions on what an Artifact can represent.  Fabric encourages the generous use of Factors to identify and describe each new Artifact. Ideally, the Factor connections will distinguish an Artifact from all others.</para>
	///    <para>Each Artifact is linked to exactly one ArtifactOwnerNode item, where the type of this item is specified by the ArtifactType.</para>
	///</remarks>
	public class FabArtifact : FabNode {
	
		///<summary>
		///    Uniquely identifies this object amongst all other objects of this type.
		///</summary>
		public long ArtifactId { get; set; }
		
		///<summary>
		///    The date/time of creation.
		///</summary>
		public long Created { get; set; }
		
		///<summary>
		///    Specifies the accessibility level. When true, access is limited to the creating [[User|Object|FabUser]].
		///</summary>
		public bool IsPrivate { get; set; }
		
	}
	
	
	/*================================================================================================*/
	///<summary>
	///    
	///</summary>
	///<remarks>
	///    <para>TODO</para>
	///</remarks>
	public class FabArtifactOwnerNode : FabNode {
	
	}
	
	
	/*================================================================================================*/
	///<summary>
	///    Describes the object type associated with a particular Artifact.
	///</summary>
	///<remarks>
	///    <para>Describes the object type associated with a particular Artifact. Example types include: App, Class, Instance, etc.</para>
	///</remarks>
	public class FabArtifactType : FabNodeForType {
	
		///<summary>
		///    Uniquely identifies this object amongst all other objects of this type.
		///</summary>
		public long ArtifactTypeId { get; set; }
		
	}
	
	
	/*================================================================================================*/
	///<summary>
	///    Represents any item (real, imaginary, virtual, conceptual, or otherwise) that an App or User can define and/or use to generate meaning.
	///</summary>
	///<remarks>
	///    <para>Represents any item (real, imaginary, virtual, conceptual, or otherwise) that an App or User can define and/or use to generate meaning. Classes and Instances are closely related, and are the primary method for generating new Artifacts.</para>
	///    <para>Documentation Note: To explain the Class object more intuitively, this documentation simplifies some concepts of the Fabric architecture. Please be aware of the full complexity:</para>
	///    <para>- A Class receives Factors via its associated Artifact.</para>
	///    <para>- Each Factor references two Artifacts, which creates a relationship between them.</para>
	///    <para>- An 'is a' relationship refers to a Factor that uses an 'Is A' Descriptor.</para>
	///    <para>A Class represents a particular group, type, set, or category of items. Each Class must uniquely identifiable (via name and disambiguation) amonst all other Classes. An Artifact (of any type) can only have 'is a' relationships with Classes.</para>
	///    <para>Ellie's Class Example: Ellie is building an App for dog lovers, but there are not yet animal-related Classes for Ellie to use. She first creates broad Classes (like 'Animal', 'Mammal', and 'Canine') and relationships between them (like 'Canine is a Mammal').</para>
	///    <para>She then creates narrower Classes for each dog grouping (like 'Working Dog') and breed (like 'Great Dane'), adding relevant relationships along the way. A Class named 'Boxer' already exists, but it has a sports-related meaning. She adds a new 'Boxer' Class with a 'Dog Breed' disambiguation value to resolve this conflict.</para>
	///</remarks>
	public class FabClass : FabArtifactOwnerNode {
	
		///<summary>
		///    Uniquely identifies this object amongst all other objects of this type.
		///</summary>
		public long ClassId { get; set; }
		
		///<summary>
		///    A secondary label or identifier, used to resolve unique-name conflicts.
		///</summary>
		public string Disamb { get; set; }
		
		///<summary>
		///    A descriptive name or title.
		///</summary>
		public string Name { get; set; }
		
		///<summary>
		///    A summary of the Class's intended meaning or purpose. This can resolve confusion in cases where a Class has vague or missing [[Factors|Object|FabFactor]].
		///</summary>
		public string Note { get; set; }
		
	}
	
	
	/*================================================================================================*/
	///<summary>
	///    Describes and refines the relationship between the two Artifacts of a particular Factor.  The primary purpose of a Descriptor is to describe the relationship between a Factor's primary Artifact and related Artifact.
	///</summary>
	///<remarks>
	///    <para>Describes and refines the relationship between the two Artifacts of a particular Factor.</para>
	///    <para>The primary purpose of a Descriptor is to describe the relationship between a Factor's primary Artifact and related Artifact. The DescriptorType provides this description, establishing meaningful connections like a A 'is a' B, or C 'sounds like' D.</para>
	///    <para>The Artifact relationship (defined by a Factor) is directional, flowing from the primary Artifact to the related Artifact. The DescriptorType, therefore, must coordinate with the relationship's direction.</para>
	///    <para>Relationship Example: Objective:</para>
	///    <para>Describe that a circle is a shape. </para>
	///    <para>Method:</para>
	///    <para>- The Factor uses 'Circle' as the primary Artifact and 'Shape' as the related Artifact.</para>
	///    <para>- The Descriptor uses the 'Is A' DescriptorType.</para>
	///    <para>Factor Phrase:</para>
	///    <para>Circle ... Is A ... Shape.</para>
	///    <para>Descriptors also offer optional (but powerful) refinement capabilities, which allow a Descriptor to be very specific. Using any available Artifact, a Descriptor may refine the DescriptorType, the Factor's primary Artifact, and/or the Factor's related Artifact.</para>
	///    <para>Refinement Example: Objective:</para>
	///    <para>Describe that car A and car B have headlights with a similar shape.</para>
	///    <para>Method:</para>
	///    <para>- The Factor uses 'Car A' as the primary Artifact and 'Car B' as the related Artifact.</para>
	///    <para>- The Descriptor uses the 'Is Similar To' DescriptorType, uses 'Headlight' to refine both Artifacts, and uses 'Shape' to refine the DescriptorType.</para>
	///    <para>Factor Phrase:</para>
	///    <para>Car A (more specifically, its) Headlight ... Is Similar To (more specifically, by) Shape ... Car B (more specifically, its) Headlight.</para>
	///    <para>Descriptors are the only required Factor Element. If a Factor is completed without a Descriptor, Fabric automatically attaches one. The default Descriptor uses the 'Is Related To' DescriptorType with no refinements.</para>
	///</remarks>
	public class FabDescriptor : FabFactorElementNode {
	
		///<summary>
		///    Uniquely identifies this object amongst all other objects of this type.
		///</summary>
		public long DescriptorId { get; set; }
		
	}
	
	
	/*================================================================================================*/
	///<summary>
	///    Provides meaning (via Descriptor) to the relationship between the two Artifacts in a particular Factor.
	///</summary>
	///<remarks>
	///    <para>Provides meaning (via Descriptor) to the relationship between the two Artifacts in a particular Factor. Example types include: Is A, Refers To, Sounds Like, etc.</para>
	///</remarks>
	public class FabDescriptorType : FabNodeForType {
	
		///<summary>
		///    Uniquely identifies this object amongst all other objects of this type.
		///</summary>
		public long DescriptorTypeId { get; set; }
		
	}
	
	
	/*================================================================================================*/
	///<summary>
	///    Creates a directional, action-based pathway between the two Artifacts of a particular Factor.  The nature of a Director's pathway depends on its DirectorType.
	///</summary>
	///<remarks>
	///    <para>Creates a directional, action-based pathway between the two Artifacts of a particular Factor.</para>
	///    <para>The nature of a Director's pathway depends on its DirectorType. The Director can  represent a factual, well-defined path, a virtual link, a suggested flow, etc.</para>
	///    <para>A Director specifies a DirectorAction for each of the Factor's Artifacts, which give additional meaning to the Director's pathway. The primary action is meant to be performed on the primary Artifact before the pathway begins. The related action is meant to be performed on the related Artifact after the pathway ends.</para>
	///    <para>Defined Pathway Example: Objective:</para>
	///    <para>Direct along the defined pathway of listening to a particular album's third and fourth songs (song C and D) in order.</para>
	///    <para>Method:</para>
	///    <para>- The Factor uses 'Song C' as the primary Artifact and 'Song D' as the related Artifact.</para>
	///    <para>- The Descriptor, by default, uses the 'IsRelatedTo' DescriptorType.</para>
	///    <para>- The Director uses the 'Defined Path' DirectorType and the 'Listen' DirectorAction for each Artifact.</para>
	///    <para>Factor Phrase:</para>
	///    <para>Song C ... Is Related To ... Song D. (Performing the) Listen (action on) ... Song C ... (leads via) Defined Path (toward) ... (performing the) Listen (action on) ... Song D. Suggested Pathway Example: Objective:</para>
	///    <para>Direct along a suggested pathway of listening to song A and then learning about that song's vocalist, singer B.</para>
	///    <para>Method:</para>
	///    <para>- The Factor uses 'Song A' as the primary Artifact and 'Singer B' as the related Artifact.</para>
	///    <para>- The Descriptor, by default, uses the 'IsRelatedTo' DescriptorType.</para>
	///    <para>- The Director uses the 'Suggested Path' DirectorType, the 'Listen' primary DirectorAction, and the 'Learn' related DirectorAction.</para>
	///    <para>Factor Phrase:</para>
	///    <para>Song A ... Is Related To ... Song B.  (Performing the) Listen (action on) ... Song A ... (leads via) Suggested Path (toward) ... (performing the) Learn (action on) ... Singer B.</para>
	///</remarks>
	public class FabDirector : FabFactorElementNode {
	
		///<summary>
		///    Uniquely identifies this object amongst all other objects of this type.
		///</summary>
		public long DirectorId { get; set; }
		
	}
	
	
	/*================================================================================================*/
	///<summary>
	///    Describes an action to be taken (via Director) on one of the two Artifacts in a particular Factor.
	///</summary>
	///<remarks>
	///    <para>Describes an action to be taken (via Director) on one of the two Artifacts in a particular Factor. Example actions include: Read, Learn, Obtain, etc.</para>
	///</remarks>
	public class FabDirectorAction : FabNodeForType {
	
		///<summary>
		///    Uniquely identifies this object amongst all other objects of this type.
		///</summary>
		public long DirectorActionId { get; set; }
		
	}
	
	
	/*================================================================================================*/
	///<summary>
	///    Provides meaning (via Director) to the directional connection between the two Artifacts in a particular Factor.
	///</summary>
	///<remarks>
	///    <para>Provides meaning (via Director) to the directional connection between the two Artifacts in a particular Factor. Example types include: Hyperlink, Suggested Path, Defined Path, etc.</para>
	///</remarks>
	public class FabDirectorType : FabNodeForType {
	
		///<summary>
		///    Uniquely identifies this object amongst all other objects of this type.
		///</summary>
		public long DirectorTypeId { get; set; }
		
	}
	
	
	/*================================================================================================*/
	///<summary>
	///    When a fault or error occurs, a FabError is returned in place of the expected response data.
	///</summary>
	///<remarks>
	///    <para>When a fault or error occurs, a FabError is returned in place of the expected response data. The information it provides should help determine what caused the issue for the given request.</para>
	///</remarks>
	public class FabError : FabObject {
	
		///<summary>
		///    A numeric value which identifies the specific error type.
		///</summary>
		public int Code { get; set; }
		
		///<summary>
		///    A sentence or paragraph providing details about the error.
		///</summary>
		public string Message { get; set; }
		
		///<summary>
		///    A descriptive name that is associated with the error code.
		///</summary>
		public string Name { get; set; }
		
	}
	
	
	/*================================================================================================*/
	///<summary>
	///    Applies the concept of time to a particular Factor.  An Eventor places a Factor at a specific point in time and describes why it is significant to the Factor.
	///</summary>
	///<remarks>
	///    <para>Applies the concept of time to a particular Factor.</para>
	///    <para>An Eventor places a Factor at a specific point in time and describes why it is significant to the Factor. The EventorType provides this significance, establishing that this particular point in time is when the Factor started, occurred, is expected, etc.</para>
	///    <para>Each Eventor represents one particular point in time, however, the precision of that point in time can vary. The EventorPrecision allows a point in time to specify a level of accuracy ranging from one second to one year.</para>
	///    <para>Started Example: Objective:</para>
	///    <para>Specify that Albert Einstein was born (i.e. started his life) on March 14, 1879.</para>
	///    <para>Method:</para>
	///    <para>- The Factor uses 'Albert Einstein' as the primary Artifact and 'Life' as the related Artifact.</para>
	///    <para>- The Descriptor uses the 'Has A' DescriptorType.</para>
	///    <para>- The Eventor uses 'March 14, 1879' as its DateTime value, the 'Started' EventorType, and the 'Day' EventorPrecision.</para>
	///    <para>Factor Phrase:</para>
	///    <para>Albert Einstein ... Has A ... Life, ... (an event which) Started ... (on the) Day ... March 14, 1879. Expected Example: Objective:</para>
	///    <para>Specify that person A plans to attend college B in the year 2024.</para>
	///    <para>Method:</para>
	///    <para>- The Factor uses 'Person A' as the primary Artifact and 'College B' as the related Artifact.</para>
	///    <para>- The Descriptor uses the 'Participates In' DescriptorType and the 'Attend' Artifact to refine it.</para>
	///    <para>- The Eventor uses '2024' as its DateTime value, the 'Is Expected' EventorType, and the 'Year' EventorPrecision.</para>
	///    <para>Factor Phrase:</para>
	///    <para>Person A ... Participates In (more specifically, by) Attend(ing) ... College B, ... (an event which) Is Expected (to occur) ... (in the) Year ... 2024.</para>
	///    <para>Note: every Factor recieves a timestamp upon creation. This timestamp is not related to the Eventor.</para>
	///</remarks>
	public class FabEventor : FabFactorElementNode {
	
		///<summary>
		///    A particular point in time, with a level of accuracy defined by [[EventorPrecision|Object|FabEventorPrecision]].
		///</summary>
		public long DateTime { get; set; }
		
		///<summary>
		///    Uniquely identifies this object amongst all other objects of this type.
		///</summary>
		public long EventorId { get; set; }
		
	}
	
	
	/*================================================================================================*/
	///<summary>
	///    Describes the level of date/time precision (via Eventor) given to a particular Factor.
	///</summary>
	///<remarks>
	///    <para>Describes the level of date/time precision (via Eventor) given to a particular Factor. Example precisions include: Year, Day, Second, etc.</para>
	///</remarks>
	public class FabEventorPrecision : FabNodeForType {
	
		///<summary>
		///    Uniquely identifies this object amongst all other objects of this type.
		///</summary>
		public long EventorPrecisionId { get; set; }
		
	}
	
	
	/*================================================================================================*/
	///<summary>
	///    Provides temporal significance (via Eventor) for a particular Factor.
	///</summary>
	///<remarks>
	///    <para>Provides temporal significance (via Eventor) for a particular Factor.  Example types include: Start, Occur, Expected, etc.</para>
	///</remarks>
	public class FabEventorType : FabNodeForType {
	
		///<summary>
		///    Uniquely identifies this object amongst all other objects of this type.
		///</summary>
		public long EventorTypeId { get; set; }
		
	}
	
	
	/*================================================================================================*/
	///<summary>
	///    Provides a specific piece of information, knowledge, or opinion about a pair of Artifacts.
	///</summary>
	///<remarks>
	///    <para>Provides a specific piece of information, knowledge, or opinion about a pair of Artifacts. Factors and Artifacts are the central components of the Fabric architecture.</para>
	///    <para>A Factor forms a directional relationship from its primary Artifact to its related Artifact. There are various Factor-related components (known as Factor Elements) available. Each has a specific ability to refine, describe, and/or supplement this Artifact relationship in a meaningful way.</para>
	///    <para>The six Factor Elements are called Descriptor, Director, Eventor, Identor, Locator, and Vector. The Descriptor is the only required Element; the rest are optional. A Factor typically uses one or two Elements, but (in very complex cases) could potentially use four or more.</para>
	///    <para>Just as there are no restrictions on what a particular Artifact can represent, there are no restrictions on the type of meaning or information a Factors can provide. The FactorAssertionKey allows a Factor to specify that it represents (among other things) a fact or an opinion. This level of confidence for a particular Factor allows Users and Apps to more effectively find the type of information they desire.</para>
	///    <para>Each Factor has a trio of boolean states. IsComplete states whether the Factor is completed or still under construction. IsDefining states whether the Factor is a vital piece of data, which could be useful in uniquely identifying the primary Artifact. IsPublic states whether the Factor is public (available to all Apps and Users) or not. Non-public Factors are primarily accessible to the App responsible for creating it, but may be accessible by other Apps which have certain access rights.</para>
	///</remarks>
	public class FabFactor : FabNode {
	
		///<summary>
		///    The date/time of completion. This value is null if the Factor is not complete.
		///</summary>
		public long? Completed { get; set; }
		
		///<summary>
		///    The date/time of creation.
		///</summary>
		public long Created { get; set; }
		
		///<summary>
		///    Uniquely identifies this object amongst all other objects of this type.
		///</summary>
		public long FactorId { get; set; }
		
		///<summary>
		///    Specifies whether this Factor helps to uniquely define the primary [[Artifact|Object|FabArtifact]].
		///</summary>
		public bool IsDefining { get; set; }
		
		///<summary>
		///    A summary of the Factor's intended meaning or purpose. This is useful in cases when the Factor is vague, complex, or confusing. It can help resolve issues in cases where the [[Factor|Object|FabFactor]]'s Elements inaccurately model the intended meaning. Typically, this value is not written directly by a [[User|Object|FabUser]]; the [[App|Object|FabApp]] should have enough information about a particular Factor-creating action to form a reasonable sentence or phrase.
		///</summary>
		public string Note { get; set; }
		
	}
	
	
	/*================================================================================================*/
	///<summary>
	///    Describes the type of information (and/or level of confidence) provided by a particular Factor.
	///</summary>
	///<remarks>
	///    <para>Describes the type of information (and/or level of confidence) provided by a particular Factor. Example assertions include: Fact, Opinion, Guess, etc.</para>
	///</remarks>
	public class FabFactorAssertion : FabNodeForType {
	
		///<summary>
		///    Uniquely identifies this object amongst all other objects of this type.
		///</summary>
		public long FactorAssertionId { get; set; }
		
	}
	
	
	/*================================================================================================*/
	///<summary>
	///    
	///</summary>
	///<remarks>
	///    <para>TODO</para>
	///</remarks>
	public class FabFactorElementNode : FabNode {
	
	}
	
	
	/*================================================================================================*/
	///<summary>
	///    
	///</summary>
	///<remarks>
	///    <para>TODO</para>
	///</remarks>
	public class FabHome : FabObject {
	
		///<summary>
		///    TODO
		///</summary>
		public FabService[] Services { get; set; }
		
	}
	
	
	/*================================================================================================*/
	///<summary>
	///    Applies a name or identifier to a particular Factor.  An Identor attaches a text-based value to a Factor.
	///</summary>
	///<remarks>
	///    <para>Applies a name or identifier to a particular Factor.</para>
	///    <para>An Identor attaches a text-based value to a Factor. This value can represent a a full name, a nickname, a globally-unique identifier, a reference key to some other system, etc.</para>
	///    <para>The IdentorType hints at the purpose or intent of the Identor. A 'Text' IdentorType is typically meant to provide enhanced search capabilities (like finding a person by an alternate name) or some other organizational use.  A 'Key' IdentorType is typically meant to associate a Factor with some external system (like a Product ID from an online store) or to provide an App with a 'reverse lookup' for their own internal IDs.</para>
	///    <para>Alternate Name Example: Objective:</para>
	///    <para>Identify that Grand Valley State University is also known as (has the alternate name of) 'Grand Valley'.</para>
	///    <para>Method:</para>
	///    <para>- The Factor uses 'Grand Valley State University' as the primary Artifact and 'Name' as the related Artifact.</para>
	///    <para>- The Descriptor uses the 'Has A' DescriptorType, and an 'Alternative' Artifact to refine the Factor's related Artifact.</para>
	///    <para>- The Identor uses 'Grand Valley' as its text value, and the 'Text' IdentorType.</para>
	///    <para>Factor Phrase:</para>
	///    <para>Grand Valley State University ... Has A ... Name (more specifically, an) Alternative, ... (identified by the) Text ... 'Grand Valley'. Abbreviation Example: Objective:</para>
	///    <para>Identify that Grand Valley State University is also known as (has the abbreviation of) 'GVSU'.</para>
	///    <para>Method:</para>
	///    <para>- The Factor uses 'Grand Valley State University' as the primary Artifact and 'Abbreviation' as the related Artifact.</para>
	///    <para>- The Descriptor uses the 'Has A' DescriptorType.</para>
	///    <para>- The Identor uses 'GVSU' as its text value, and the 'Text' IdentorType.</para>
	///    <para>Factor Phrase:</para>
	///    <para>Grand Valley State University ... Has A(n) ... Abbreviation, ... (identified by the) Text ... 'GVSU'. Identifier Example: Objective:</para>
	///    <para>Identify that game A is accessible in store B via its ID, which is '123a-45678'.</para>
	///    <para>Method:</para>
	///    <para>- The Factor uses 'Game A' as the primary Artifact and 'Store B' as the related Artifact.</para>
	///    <para>- The Descriptor uses the 'Is Found In' DescriptorType.</para>
	///    <para>- The Identor uses '123a-45678' as its text value, and the 'Key' IdentorType.</para>
	///    <para>Factor Phrase:</para>
	///    <para>Game A ... Is Found In ... Store B, ... (identified by the) Key ... '123a-45678'.</para>
	///</remarks>
	public class FabIdentor : FabFactorElementNode {
	
		///<summary>
		///    Uniquely identifies this object amongst all other objects of this type.
		///</summary>
		public long IdentorId { get; set; }
		
		///<summary>
		///    A text-based value that can represent names, numbers, IDs, GUIDs, etc.
		///</summary>
		public string Value { get; set; }
		
	}
	
	
	/*================================================================================================*/
	///<summary>
	///    Provides a hint about the text (via Identor) that identifies a particular Factor.
	///</summary>
	///<remarks>
	///    <para>Provides a hint about the text (via Identor) that identifies a particular Factor. Example types include: Text, Key, etc.</para>
	///</remarks>
	public class FabIdentorType : FabNodeForType {
	
		///<summary>
		///    Uniquely identifies this object amongst all other objects of this type.
		///</summary>
		public long IdentorTypeId { get; set; }
		
	}
	
	
	/*================================================================================================*/
	///<summary>
	///    Represents any item (real, imaginary, virtual, conceptual, or otherwise) that an App or User can define and/or use to generate meaning.
	///</summary>
	///<remarks>
	///    <para>Represents any item (real, imaginary, virtual, conceptual, or otherwise) that an App or User can define and/or use to generate meaning. Classes and Instances are closely related, and are the primary method for generating new Artifacts.</para>
	///    <para>Documentation Note: To explain the Instance object more intuitively, this documentation simplifies some concepts of the Fabric architecture. Please be aware of the full complexity:</para>
	///    <para>- An Instance receives Factors via its associated Artifact.</para>
	///    <para>- Each Factor references two Artifacts, which creates a relationship between them.</para>
	///    <para>- An 'is a' relationship refers to a Factor that uses an 'Is A' Descriptor.</para>
	///    <para>An Instance represents a singular, unique item. It may have a specific name, however, the name is not required to be unique. Instead, the creator should apply Factors to make the Instance as specific and meaningful as possible. Each Instance must have an 'is a' relationship with at least one Class.</para>
	///    <para>Ellie's Instance Example: Continued from Ellie's Class Example...</para>
	///    <para>After completing her new Classes, Ellie would like to add her own dog. She creates an Instance named 'Gulliver', and attaches several Factors to make the Instance as unique as possible. Her Factors define that Gulliver is a Lhasa Apso breed, is owned by Ellie, and was born in September 2007. Zach's Instance Example: Zach built an App that allows users to rate restaurants and individual meals. He created Classes for restaurant chains and meal types. He also created Instances for specific restaurants (with relevant relationships for each).</para>
	///    <para>When Users rate a particular meal, they also specify the restaurant, the day/time the meal was served, and the meal type. Behind the scenes, the App uses this data to construct a new Instance and its relationships. Because Zach's Instances are well-defined, one User could rate the same meal (at the same restaurant) every day, creating a unique and meaningful Instance each time.</para>
	///</remarks>
	public class FabInstance : FabArtifactOwnerNode {
	
		///<summary>
		///    A secondary label or identifier, used to resolve unique-name conflicts.
		///</summary>
		public string Disamb { get; set; }
		
		///<summary>
		///    Uniquely identifies this object amongst all other objects of this type.
		///</summary>
		public long InstanceId { get; set; }
		
		///<summary>
		///    A descriptive name or title.
		///</summary>
		public string Name { get; set; }
		
		///<summary>
		///    A summary of the Instance's intended meaning or purpose. This can resolve confusion in cases where an Instance has vague or missing [[Factors|Object|FabFactor]].
		///</summary>
		public string Note { get; set; }
		
	}
	
	
	/*================================================================================================*/
	///<summary>
	///    Positions a Factor using geographic or relative coordinates.  A Locator attaches a three-dimensional coordinate to a Factor.
	///</summary>
	///<remarks>
	///    <para>Positions a Factor using geographic or relative coordinates.</para>
	///    <para>A Locator attaches a three-dimensional coordinate to a Factor. The LocatorType defines the spatial context of the coordinate, supporting both geographic and relative positioning.</para>
	///    <para>Geographic coordinates represent a position on a sphere, like Earth.  They use X for longitude, Y for latitude, and Z for elevation (in metres above sea level). Use zero for elevation if it is not known or specified.</para>
	///    <para>Geographic Example: Objective:</para>
	///    <para>Specify that person A took photo B from a spot near the Eiffel Tower.</para>
	///    <para>Method:</para>
	///    <para>- The Factor uses 'Photo B' as the primary Artifact and 'Person A' as the related Artifact.</para>
	///    <para>- The Descriptor uses the 'Is Created By' DescriptorType.</para>
	///    <para>- The Locator uses the 'Earth Coordinate' LocatorType, a '2.292977' value for X, a '48.858154' value for Y, and (optionally) a '34.24' value for Z.</para>
	///    <para>Factor Phrase:</para>
	///    <para>Photo B ... Is Created By ... Person A, ... (at an) Earth Coordinate (location of) ... X (longitude) = '2.292977' ... Y (latitude) = '48.858154' ... Z (elevation) = '34.24' (metres above sea level).</para>
	///    <para>Relative coordinates represent a position relative to the origin and size/bounds of the Factor's primary Artifact. There are LocatorTypes for one, two, and three-dimensional relative coordinates. For coordinates which have:</para>
	///    <para>- One dimension, use X for time or progress, and leave Y and Z equal to zero.</para>
	///    <para>- Two dimensions, use X for width, Y for height, and leave Z equal to zero.</para>
	///    <para>- Three dimensions, use X, Y, and Z values which correspond to the Artifact's X, Y, and Z values. If these axes are undefined, use X for width (or breadth), Y for length (or depth), and Z for height (or elevation).</para>
	///    <para>Relative 1D Example: Objective:</para>
	///    <para>Specify that book A refers to painting B on page 148 of 200 (about 74% of the book's length).</para>
	///    <para>Method:</para>
	///    <para>- The Factor uses 'Book A' as the primary Artifact and 'Painting B' as the related Artifact.</para>
	///    <para>- The Descriptor uses the 'Refers To' DescriptorType.</para>
	///    <para>- The Locator uses the 'Related 1D' LocatorType, a '0.74' value for X, a '0.0' value for Y, and a '0.0' value for Z.</para>
	///    <para>Factor Phrase:</para>
	///    <para>Book A ... Refers To ... Painting B, ... (at a) Relative 1D (location of) ... X (position) = 0.74. Relative 2D Example: Objective:</para>
	///    <para>Specify that photo A includes person B near the top-right (25% from the top, 84% from the left) of the image.</para>
	///    <para>Method:</para>
	///    <para>- The Factor uses 'Photo A' as the primary Artifact and 'Person B' as the related Artifact.</para>
	///    <para>- The Descriptor uses the 'Refers To' DescriptorType.</para>
	///    <para>- The Locator uses the 'Relative 2D' LocatorType, a '0.84' value for X, a '0.25' value for Y, and a '0.0' value for Z.</para>
	///    <para>Factor Phrase:</para>
	///    <para>Photo A ... Refers To ... Person B, ... (at a) Relative 2D (location of) ... X (width) = '0.84' ... Y (height) = '0.25'.</para>
	///</remarks>
	public class FabLocator : FabFactorElementNode {
	
		///<summary>
		///    Uniquely identifies this object amongst all other objects of this type.
		///</summary>
		public long LocatorId { get; set; }
		
		///<summary>
		///    A value representing longitude, time/progress, width, or a particular three-dimensional axis.
		///</summary>
		public double ValueX { get; set; }
		
		///<summary>
		///    A value representing latitude, height, or a particular three-dimensional axis.
		///</summary>
		public double ValueY { get; set; }
		
		///<summary>
		///    A value representing elevation or a particular three-dimensional axis.
		///</summary>
		public double ValueZ { get; set; }
		
	}
	
	
	/*================================================================================================*/
	///<summary>
	///    Provides spatial context and boundaries (via Locator) for a particular Factor.
	///</summary>
	///<remarks>
	///    <para>Provides spatial context and boundaries (via Locator) for a particular Factor. Example types include: Earth Coordinate, Mars Coordinate, Relative 3D Position, etc.</para>
	///</remarks>
	public class FabLocatorType : FabNodeForType {
	
		///<summary>
		///    Uniquely identifies this object amongst all other objects of this type.
		///</summary>
		public long LocatorTypeId { get; set; }
		
		///<summary>
		///    The maximum [[Locator|Object|FabLocator]] X-coordinate value.
		///</summary>
		public double MaxX { get; set; }
		
		///<summary>
		///    The maximum [[Locator|Object|FabLocator]] Y-coordinate value.
		///</summary>
		public double MaxY { get; set; }
		
		///<summary>
		///    The maximum [[Locator|Object|FabLocator]] Z-coordinate value.
		///</summary>
		public double MaxZ { get; set; }
		
		///<summary>
		///    The minimum [[Locator|Object|FabLocator]] X-coordinate value.
		///</summary>
		public double MinX { get; set; }
		
		///<summary>
		///    The minimum [[Locator|Object|FabLocator]] Y-coordinate value.
		///</summary>
		public double MinY { get; set; }
		
		///<summary>
		///    The minimum [[Locator|Object|FabLocator]] Z-coordinate value.
		///</summary>
		public double MinZ { get; set; }
		
	}
	
	
	/*================================================================================================*/
	///<summary>
	///    An association between a User and an App.
	///</summary>
	///<remarks>
	///    <para>An association between a User and an App. The App administrator(s) can grant various access privileges to a Member by adjusting its MemberType.</para>
	///    <para>Every item added to Fabric is associated with a particular Member. Thus, Fabric can determine which App or User is responsible for any particular item, enforce applicable access rights, analyze the data for a particular App and/or User, etc.</para>
	///</remarks>
	public class FabMember : FabNode {
	
		///<summary>
		///    Uniquely identifies this object amongst all other objects of this type.
		///</summary>
		public long MemberId { get; set; }
		
	}
	
	
	/*================================================================================================*/
	///<summary>
	///    Describes the level of access and control given to a particular Member.
	///</summary>
	///<remarks>
	///    <para>Describes the level of access and control given to a particular Member.  Example types include: Member, Admin, Data Provider, etc.</para>
	///</remarks>
	public class FabMemberType : FabNodeForType {
	
		///<summary>
		///    Uniquely identifies this object amongst all other objects of this type.
		///</summary>
		public long MemberTypeId { get; set; }
		
	}
	
	
	/*================================================================================================*/
	///<summary>
	///    
	///</summary>
	///<remarks>
	///    <para>TODO</para>
	///</remarks>
	public class FabMemberTypeAssign : FabNodeForAction {
	
		///<summary>
		///    Uniquely identifies this object amongst all other objects of this type.
		///</summary>
		public long MemberTypeAssignId { get; set; }
		
	}
	
	
	/*================================================================================================*/
	///<summary>
	///    
	///</summary>
	///<remarks>
	///    <para>TODO</para>
	///</remarks>
	public class FabNode : FabObject {
	
		///<summary>
		///    TODO
		///</summary>
		public string Uri { get; set; }
		
	}
	
	
	/*================================================================================================*/
	///<summary>
	///    
	///</summary>
	///<remarks>
	///    <para>TODO</para>
	///</remarks>
	public class FabNodeForAction : FabNode {
	
		///<summary>
		///    TODO
		///</summary>
		public string Note { get; set; }
		
		///<summary>
		///    TODO
		///</summary>
		public long Performed { get; set; }
		
	}
	
	
	/*================================================================================================*/
	///<summary>
	///    
	///</summary>
	///<remarks>
	///    <para>TODO</para>
	///</remarks>
	public class FabNodeForType : FabNode {
	
		///<summary>
		///    A summary of this object's intended meaning or purpose.
		///</summary>
		public string Description { get; set; }
		
		///<summary>
		///    A descriptive name or title.
		///</summary>
		public string Name { get; set; }
		
	}
	
	
	/*================================================================================================*/
	///<summary>
	///    Provides an OAuth access token and other related information.
	///</summary>
	///<remarks>
	///    <para>Provides an OAuth access token and other related information. Every Fabric API request requires an access token. To include an OAuth access token with a FabricAPI request, add an "Authorization" header to the HTTP request with a value of "Bearer=[your OAuth access code here]".</para>
	///</remarks>
	public class FabOauthAccess : FabObject {
	
		///<summary>
		///    A code that maps to various authentication information. Notably, it is refers to exactly one [[App|Object|FabApp]] and at most one [[User|Object|FabUser]].
		///</summary>
		public string access_token { get; set; }
		
		///<summary>
		///    The number of seconds until the access token expires.
		///</summary>
		public int expires_in { get; set; }
		
		///<summary>
		///    A code that refreshes the authentication session for an expired OAuth access token. [[App|Object|FabApp]]-only access tokens do not include a refresh token; instead, the [[App|Object|FabApp]] should [[request a new access token|Oper|Oauth.AccessTokenClientCredentials]].
		///</summary>
		public string refresh_token { get; set; }
		
		///<summary>
		///    For the current Fabric OAuth implementation, this value is always equal to "bearer".
		///</summary>
		public string token_type { get; set; }
		
	}
	
	
	/*================================================================================================*/
	///<summary>
	///    
	///</summary>
	///<remarks>
	///    <para>To comply with the OAuth 2.0 specification, all Fabric OAuth requests return a FabOauthError (instead of FabFault or FabError) when errors occur.</para>
	///</remarks>
	public class FabOauthError : FabObject {
	
		///<summary>
		///    An error code as defined by the OAuth 2.0 specification.
		///</summary>
		public string error { get; set; }
		
		///<summary>
		///    Provides specific details about the error. A single error code may have one or more possible error descriptions.
		///</summary>
		public string error_description { get; set; }
		
	}
	
	
	/*================================================================================================*/
	///<summary>
	///    This object is unique -- the API never returns this object directly.
	///</summary>
	///<remarks>
	///    <para>This object is unique -- the API never returns this object directly. Instead, the properties shown below are included as query-string parameters for a redirect URI. This URI is provided by an App, and the App is responsible for accepting (and reacting to) the incoming redirect.</para>
	///    <para>This redirect is used in one particular scenario: the OAuth login process. After the user completes this process, Fabric performs a redirect with success or failure information.  The success redirect includes the 'code' and 'state' parameters. The failure redirect includes the 'error', 'error_description', and 'state' parameters.</para>
	///</remarks>
	public class FabOauthLogin : FabObject {
	
		///<summary>
		///    Use this code (also called the 'authorization code') to generate a new OAuth access token. For security purposes, each code is valid for a single use, and expires 120 seconds after creation.
		///</summary>
		public string code { get; set; }
		
		///<summary>
		///    An error code as defined by the OAuth 2.0 specification.
		///</summary>
		public string error { get; set; }
		
		///<summary>
		///    Provides specific details about the error. A single error code may have one or more possible error descriptions. For use in the redirect URI, this string uses a '+' character in place of each space character.
		///</summary>
		public string error_description { get; set; }
		
		///<summary>
		///    Returns the 'state' value that the [[App|Object|FabApp]] provided in the original Oauth request. For security reasons, the [[App|Object|FabApp]] should reject the response if the original and returned values are not equal.
		///</summary>
		public string state { get; set; }
		
	}
	
	
	/*================================================================================================*/
	///<summary>
	///    
	///</summary>
	///<remarks>
	///    <para>The result of an OAuth logout.</para>
	///</remarks>
	public class FabOauthLogout : FabObject {
	
		///<summary>
		///    Identifies a particular OAuth session.
		///</summary>
		public string access_token { get; set; }
		
		///<summary>
		///    Describes the result of the logout attempt. Successful logout attempts return a value of 1.
		///</summary>
		public int success { get; set; }
		
	}
	
	
	/*================================================================================================*/
	///<summary>
	///    
	///</summary>
	///<remarks>
	///    <para>The base class for all Objects returned by Fabric's services.</para>
	///</remarks>
	public class FabObject {
	
		///<summary>
		///    The data type of this object.
		///</summary>
		public string FabType { get; set; }
		
	}
	
	
	/*================================================================================================*/
	///<summary>
	///    
	///</summary>
	///<remarks>
	///    <para>The API response wrapper; contains the Data payload and other metadata.</para>
	///</remarks>
	public class FabResponse {
	
		///<summary>
		///    TODO
		///</summary>
		public long AppId { get; set; }
		
		///<summary>
		///    TODO
		///</summary>
		public string BaseUri { get; set; }
		
		///<summary>
		///    TODO
		///</summary>
		public int Count { get; set; }
		
		///<summary>
		///    TODO
		///</summary>
		public object Data { get; set; }
		
		///<summary>
		///    TODO
		///</summary>
		public int DataLen { get; set; }
		
		///<summary>
		///    TODO
		///</summary>
		public int DbMs { get; set; }
		
		///<summary>
		///    TODO
		///</summary>
		public string[] Functions { get; set; }
		
		///<summary>
		///    TODO
		///</summary>
		public bool HasMore { get; set; }
		
		///<summary>
		///    TODO
		///</summary>
		public int HttpStatus { get; set; }
		
		///<summary>
		///    TODO
		///</summary>
		public bool IsError { get; set; }
		
		///<summary>
		///    TODO
		///</summary>
		public FabStepLink[] Links { get; set; }
		
		///<summary>
		///    TODO
		///</summary>
		public string RequestUri { get; set; }
		
		///<summary>
		///    TODO
		///</summary>
		public long StartIndex { get; set; }
		
		///<summary>
		///    TODO
		///</summary>
		public long Timestamp { get; set; }
		
		///<summary>
		///    TODO
		///</summary>
		public int TotalMs { get; set; }
		
		///<summary>
		///    TODO
		///</summary>
		public long UserId { get; set; }
		
	}
	
	
	/*================================================================================================*/
	///<summary>
	///    Represents the root, or starting point, of all Traversal Service queries.
	///</summary>
	///<remarks>
	///    <para>Represents the root, or starting point, of all Traversal Service queries. The Root provides traversal links to all other available objects.</para>
	///</remarks>
	public class FabRoot : FabNode {
	
		///<summary>
		///    Uniquely identifies this object amongst all other objects of this type.
		///</summary>
		public int RootId { get; set; }
		
	}
	
	
	/*================================================================================================*/
	///<summary>
	///    
	///</summary>
	///<remarks>
	///    <para>A collection of similar ServiceOperations which all share a similar purpose.</para>
	///</remarks>
	public class FabService : FabObject {
	
		///<summary>
		///    TODO
		///</summary>
		public string Name { get; set; }
		
		///<summary>
		///    TODO
		///</summary>
		public FabServiceOperation[] Operations { get; set; }
		
		///<summary>
		///    TODO
		///</summary>
		public string Uri { get; set; }
		
	}
	
	
	/*================================================================================================*/
	///<summary>
	///    
	///</summary>
	///<remarks>
	///    <para>A task, query, or operation that belongs to a Service.</para>
	///</remarks>
	public class FabServiceOperation : FabObject {
	
		///<summary>
		///    TODO
		///</summary>
		public string Method { get; set; }
		
		///<summary>
		///    TODO
		///</summary>
		public string Name { get; set; }
		
		///<summary>
		///    TODO
		///</summary>
		public string ReturnType { get; set; }
		
		///<summary>
		///    TODO
		///</summary>
		public string Uri { get; set; }
		
	}
	
	
	/*================================================================================================*/
	///<summary>
	///    
	///</summary>
	///<remarks>
	///    <para>TODO</para>
	///</remarks>
	public class FabStepLink : FabObject {
	
		///<summary>
		///    TODO
		///</summary>
		public string Class { get; set; }
		
		///<summary>
		///    TODO
		///</summary>
		public bool IsOut { get; set; }
		
		///<summary>
		///    TODO
		///</summary>
		public string Rel { get; set; }
		
		///<summary>
		///    TODO
		///</summary>
		public string Uri { get; set; }
		
	}
	
	
	/*================================================================================================*/
	///<summary>
	///    A hyperlink or path (uniform resource locator) to some web page, a file, or some other type of content.  While a Url does have an associated Artifact, it should be used with certain constraints.
	///</summary>
	///<remarks>
	///    <para>A hyperlink or path (uniform resource locator) to some web page, a file, or some other type of content.</para>
	///    <para>While a Url does have an associated Artifact, it should be used with certain constraints. Consider an scenario where a Url leads to web page with a news article and a photo. The proper prodedure is to create a new Instance for both the news article and photo. With this method:</para>
	///    <para>- The news article and photo (via their Artifacts) can receive Factors independently.</para>
	///    <para>- The Url (via its Artifact) should only receive Factors related to the actual web page, its design, etc.</para>
	///    <para>- Every Url that displays this particular news article can refer the same news article Instance.</para>
	///</remarks>
	public class FabUrl : FabArtifactOwnerNode {
	
		///<summary>
		///    A unique, valid absolute URL. The string must include the link's protocol (such as 'http://').
		///</summary>
		public string AbsoluteUrl { get; set; }
		
		///<summary>
		///    A descriptive name or title.
		///</summary>
		public string Name { get; set; }
		
		///<summary>
		///    Uniquely identifies this object amongst all other objects of this type.
		///</summary>
		public long UrlId { get; set; }
		
	}
	
	
	/*================================================================================================*/
	///<summary>
	///    A registered Fabric account that has indirect access (via Apps) to the Fabric API.
	///</summary>
	///<remarks>
	///    <para>A registered Fabric account that has indirect access (via Apps) to the Fabric API. A User can become a Member of an App, and then use the App's interface to interact with Fabric. An App's interface hides the complex details of the Fabric API, and instead provides intuitive features like custom inputs, searches, summaries, and visualizations. </para>
	///    <para>Users control their private account data and preferences using the Fabric website.</para>
	///    <para>Every item added to Fabric is associated with (via Member) a User and and an App. Thus, Fabric can determine which User is responsible for any particular item, enforce applicable access rights, analyze the data for a particular User or Member, etc.</para>
	///</remarks>
	public class FabUser : FabArtifactOwnerNode {
	
		///<summary>
		///    A unique username.
		///</summary>
		public string Name { get; set; }
		
		///<summary>
		///    Uniquely identifies this object amongst all other objects of this type.
		///</summary>
		public long UserId { get; set; }
		
	}
	
	
	/*================================================================================================*/
	///<summary>
	///    Applies a meaningful numeric axis and value to a particular Factor.  A Vector attaches a numeric value to a Factor, using an arbitrary Artifact to define its 'axis'.
	///</summary>
	///<remarks>
	///    <para>Applies a meaningful numeric axis and value to a particular Factor.</para>
	///    <para>A Vector attaches a numeric value to a Factor, using an arbitrary Artifact to define its 'axis'. This axis depends entirely upon the Vector's purpose. For example, a factual Vector might use an Artifact like 'Height' or 'Shutter Speed'. A Vector that provides an opinion might use an Artifact like 'Quality' or 'Excitement'. While the choice of an axis Artififact is not restricted, it can be beneficial to use Artifacts which are other Apps or Users are already using as Vector axes.</para>
	///    <para>The VectorType provides boundaries and context for the Vector's value. It can identify the value as a percentage, a level of agreement or disagreement, an opinion-based rating, or simply a plain numeric value. Each VectorType provides additional information, such as a VectorRange, to provide further meaning for the levels within the the allowed value boundaries.</para>
	///    <para>A Vector's numeric value often reflects a measurement or a has a specific unit. Furthermore, a Vector can use VectorUnitPrefix to specify an order of magnitude for the value. A Vector's value is a long integer, so the prefix is especially useful when fractional values are involved, or when the desired number is larger than a long integer.</para>
	///    <para>Small Value Example: Objective:</para>
	///    <para>Specify that image A (which is a photo) has a shutter speed of 1/250 second.</para>
	///    <para>Method:</para>
	///    <para>- The Factor uses 'Image A' as the primary Artifact and 'Photo' as the related Artifact.</para>
	///    <para>- The Descriptor uses the 'Is A' DescriptorType.</para>
	///    <para>- The Vector uses the 'Shutter Speed' Artifact as the axis, the 'Positive Long' VectorType, '4' as the value, the 'Milli' VectorUnitPrefix, and the 'Second' VectorUnit.</para>
	///    <para>Factor Phrase:</para>
	///    <para>Image A ... Is A ... Photo, ... (which, along the) Shutter Speed (axis) ... (with a) Positive Long (numerical range), ... (has a value) '4' ... Milli ... Second(s). Large Value Example: Objective:</para>
	///    <para>Specify that Earth and the Andromeda Galaxy are 2.5 million light years (2.2705 x 10^22 metres) apart.</para>
	///    <para>Method:</para>
	///    <para>- The Factor uses 'Earth' as the primary Artifact and 'Andromeda Galaxy' as the related Artifact.</para>
	///    <para>- The Descriptor uses the 'Is Related To' DescriptorType.</para>
	///    <para>- The Vector uses the 'Distance' Artifact as the axis, the 'Positive Long' VectorType, '22,705' as the value, the 'Exa' VectorUnitPrefix (represents 10^18), and the 'Metre' VectorUnit.</para>
	///    <para>Factor Phrase:</para>
	///    <para>Earth ... Is Related To ... Andromeda Galaxy, ... (which, along the) Distance (axis) ... (with a) Positive Long (numerical range), ... (has a value) '22,705' ... Exa ... Metre(s). Negative Value Example: Objective:</para>
	///    <para>Specify that article A mentions person B in a very unfair manner, about 80% of the maximum unfairness imaginable.</para>
	///    <para>Method:</para>
	///    <para>- The Factor uses 'Article A' as the primary Artifact and 'Person B' as the related Artifact.</para>
	///    <para>- The Descriptor uses the 'Refers To' DescriptorType.</para>
	///    <para>- The Vector uses the 'Fairness' Artifact as the axis, the 'Opposable Favorability' VectorType, '-80' as the value, the default 'Base' VectorUnitPrefix, and the default 'None' VectorUnit. This VectorType has bounds of -100 to +100.</para>
	///    <para>Factor Phrase:</para>
	///    <para>Article A ... Refers To ... Person B, ... (which, along the) Fairness (axis) ... (with a) Opposable Favorabillity (numerical range), ... (has a value) '-80'.</para>
	///</remarks>
	public class FabVector : FabFactorElementNode {
	
		///<summary>
		///    An integral value which is to be plotted along the specified axis. This value must account for the choice of prefix. After being multiplied by the prefix magnitude, the value must fall within the bounds specified by [[VectorType|Object|FabVectorType]]. Before prefix multiplication, this value must be between –9,223,372,036,854,775,808 and 9,223,372,036,854,775,807.
		///</summary>
		public long Value { get; set; }
		
		///<summary>
		///    Uniquely identifies this object amongst all other objects of this type.
		///</summary>
		public long VectorId { get; set; }
		
	}
	
	
	/*================================================================================================*/
	///<summary>
	///    Provides meaning (using relatively-positioned points/labels) across the numerical range of a particular VectorType.
	///</summary>
	///<remarks>
	///    <para>Provides meaning (using relatively-positioned points/labels) across the numerical range of a particular VectorType. Example ranges include: Negative Numeric, Full Agreement, Positive Favorability, etc.</para>
	///</remarks>
	public class FabVectorRange : FabNodeForType {
	
		///<summary>
		///    Uniquely identifies this object amongst all other objects of this type.
		///</summary>
		public long VectorRangeId { get; set; }
		
	}
	
	
	/*================================================================================================*/
	///<summary>
	///    A relatively-positioned point which provides meaning to a numerical range.
	///</summary>
	///<remarks>
	///    <para>A relatively-positioned point which provides meaning to a numerical range. Example levels include: Maximum, Somewhat Disagree, Mostly Favorable, etc.</para>
	///</remarks>
	public class FabVectorRangeLevel : FabNodeForType {
	
		///<summary>
		///    A value (between 0.0 and 1.0) which defines the relative position between a numeric range's minimum and maximum boundaries.
		///</summary>
		public float Position { get; set; }
		
		///<summary>
		///    Uniquely identifies this object amongst all other objects of this type.
		///</summary>
		public long VectorRangeLevelId { get; set; }
		
	}
	
	
	/*================================================================================================*/
	///<summary>
	///    Provides meaning and boundaries (via Vector) for a numeric value given to a particular Factor.
	///</summary>
	///<remarks>
	///    <para>Provides meaning and boundaries (via Vector) for a numeric value given to a particular Factor. Example types include: Full Percentage, Standard Agreement, Opposable Favorability, etc.</para>
	///</remarks>
	public class FabVectorType : FabNodeForType {
	
		///<summary>
		///    The maximum [[Vector|Object|FabVector]] value allowed.
		///</summary>
		public long Max { get; set; }
		
		///<summary>
		///    The minimum [[Vector|Object|FabVector]] value allowed.
		///</summary>
		public long Min { get; set; }
		
		///<summary>
		///    Uniquely identifies this object amongst all other objects of this type.
		///</summary>
		public long VectorTypeId { get; set; }
		
	}
	
	
	/*================================================================================================*/
	///<summary>
	///    Provides a unit of measurement for the numeric value of a particular Vector.
	///</summary>
	///<remarks>
	///    <para>Provides a unit of measurement for the numeric value of a particular Vector. Example units include: Metre, Second, Byte, etc.</para>
	///</remarks>
	public class FabVectorUnit : FabNodeForType {
	
		///<summary>
		///    A unique symbol or abbreviation.
		///</summary>
		public string Symbol { get; set; }
		
		///<summary>
		///    Uniquely identifies this object amongst all other objects of this type.
		///</summary>
		public long VectorUnitId { get; set; }
		
	}
	
	
	/*================================================================================================*/
	///<summary>
	///    
	///</summary>
	///<remarks>
	///    <para>TODO</para>
	///</remarks>
	public class FabVectorUnitDerived : FabNodeForType {
	
		///<summary>
		///    TODO
		///</summary>
		public int Exponent { get; set; }
		
		///<summary>
		///    Uniquely identifies this object amongst all other objects of this type.
		///</summary>
		public long VectorUnitDerivedId { get; set; }
		
	}
	
	
	/*================================================================================================*/
	///<summary>
	///    Provides a level of magnitude for the numeric value of a particular Vector.
	///</summary>
	///<remarks>
	///    <para>Provides a level of magnitude for the numeric value of a particular Vector. Example unit prefixes include: Kilo, Nano, Gibi, etc.</para>
	///</remarks>
	public class FabVectorUnitPrefix : FabNodeForType {
	
		///<summary>
		///    The difference in magnitude (a multipler) relative to the base unit.
		///</summary>
		public double Amount { get; set; }
		
		///<summary>
		///    An abbreviation, which is typically placed directly before the [[VectorUnit|Object|FabVectorUnit]] symbol.
		///</summary>
		public string Symbol { get; set; }
		
		///<summary>
		///    Uniquely identifies this object amongst all other objects of this type.
		///</summary>
		public long VectorUnitPrefixId { get; set; }
		
	}
	
	
}