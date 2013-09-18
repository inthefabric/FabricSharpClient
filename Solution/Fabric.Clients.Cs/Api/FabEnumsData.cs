// GENERATED CODE
// Changes made to this source file will be overwritten
// Generated on 9/18/2013 5:35:53 PM

using System.Collections.Generic;

namespace Fabric.Clients.Cs.Api {

	/*================================================================================================*/
	/// <summary/>
	public static class FabEnumsData {

		/// <summary/>
		public static IDictionary<byte, MemberType> MemberTypeMap;
	
		/// <summary/>
		public static IDictionary<byte, DescriptorType> DescriptorTypeMap;
	
		/// <summary/>
		public static IDictionary<byte, DirectorType> DirectorTypeMap;
	
		/// <summary/>
		public static IDictionary<byte, DirectorAction> DirectorActionMap;
	
		/// <summary/>
		public static IDictionary<byte, EventorType> EventorTypeMap;
	
		/// <summary/>
		public static IDictionary<byte, FactorAssertion> FactorAssertionMap;
	
		/// <summary/>
		public static IDictionary<byte, IdentorType> IdentorTypeMap;
	
		/// <summary/>
		public static IDictionary<byte, LocatorType> LocatorTypeMap;
	
		/// <summary/>
		public static IDictionary<byte, VectorType> VectorTypeMap;
	
		/// <summary/>
		public static IDictionary<byte, VectorRangeLevel> VectorRangeLevelMap;
	
		/// <summary/>
		public static IDictionary<byte, VectorRange> VectorRangeMap;
	
		/// <summary/>
		public static IDictionary<byte, VectorUnit> VectorUnitMap;
	
		/// <summary/>
		public static IDictionary<byte, VectorUnitPrefix> VectorUnitPrefixMap;
	
		/// <summary/>
		public static IDictionary<byte, VectorUnitDerived> VectorUnitDerivedMap;
	
		private static bool IsInit = Init();


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary/>
		public enum MemberTypeId {
			
			/// <summary>
			///   None: The User is not associated with this App.
			/// </summary>
			None = 1,
			
			/// <summary>
			///   Request: The user would like to become a member of this App.
			/// </summary>
			Request = 2,
			
			/// <summary>
			///   Invite: The User has been invited to become a member of this App.
			/// </summary>
			Invite = 3,
			
			/// <summary>
			///   Member: The User is a member of this App.
			/// </summary>
			Member = 4,
			
			/// <summary>
			///   Staff: The User is a staff member of this App.
			/// </summary>
			Staff = 5,
			
			/// <summary>
			///   Admin: The User is an administrator of this App.
			/// </summary>
			Admin = 6,
			
			/// <summary>
			///   Owner: The User owns this App.
			/// </summary>
			Owner = 7,
			
			/// <summary>
			///   Data Provider: The User has a special membership that allows it to interact with Fabric on behalf of the App.
			/// </summary>
			DataProvider = 8,
		}

		/*--------------------------------------------------------------------------------------------*/
		/// <summary/>
		public enum DescriptorTypeId {
			
			/// <summary>
			///   Is Related To: The primary Artifact is related to the related Artifact in some way. This is the default (and least meaningful) DescriptorType.
			/// </summary>
			IsRelatedTo = 1,
			
			/// <summary>
			///   Is (A/An): The primary Artifact is a type of, a subclass of, a subset of, a subordinate of, or in the category defined by the related Artifact.
			/// </summary>
			IsA = 2,
			
			/// <summary>
			///   Is An Instance Of: The primary Artifact is an instance, case, example, or representation of the related Artifact.
			/// </summary>
			IsAnInstanceOf = 3,
			
			/// <summary>
			///   Has (A/An): The primary Artifact has, as a part, piece, feature, attribute, or component, the related Artifact.
			/// </summary>
			HasA = 4,
			
			/// <summary>
			///   Is Like: The primary Artifact is like or similar to the related Artifact.
			/// </summary>
			IsLike = 5,
			
			/// <summary>
			///   Is Not Like: The primary Artifact is not like or not similar to the related Artifact
			/// </summary>
			IsNotLike = 6,
			
			/// <summary>
			///   Refers To: The primary Artifact refers to, mentions, discusses, links to, or references the related Artifact.
			/// </summary>
			RefersTo = 7,
			
			/// <summary>
			///   Is Created By: The primary Artifact is created, built, designed, invented, formed, or performed by the related Artifact.
			/// </summary>
			IsCreatedBy = 8,
			
			/// <summary>
			///   Is Interested In: The primary Artifact is interested in, fond of, attracted to, enjoys, prefers, or desires the related Artifact.
			/// </summary>
			IsInterestedIn = 9,
			
			/// <summary>
			///   Receives: The primary Artifact receives, gets, obtains, or is awarded the related Artifact.
			/// </summary>
			Receives = 10,
			
			/// <summary>
			///   Consumes: The primary Artifact consumes, eats, is powered by, uses up, depletes, or destroys the related Artifact.
			/// </summary>
			Consumes = 11,
			
			/// <summary>
			///   Produces: The primary Artifact produces, has a byproduct of, creates, or generates the related Artifact. This is similar to 'Is Created By', but in the opposite direction and meant to be less specific.
			/// </summary>
			Produces = 12,
			
			/// <summary>
			///   Participates In: The primary Artifact participates in, competes in, attends, is a member of, or is involved in the related Artifact.
			/// </summary>
			ParticipatesIn = 13,
			
			/// <summary>
			///   Is Found In: The primary Artifact is found in, located at, lives in, or is contained by the related Artifact.
			/// </summary>
			IsFoundIn = 14,
			
			/// <summary>
			///   Belongs To: The primary Artifact belongs to, is controlled by, or is owned by the related Artifact.
			/// </summary>
			BelongsTo = 15,
			
			/// <summary>
			///   Requires: The primary Artifact requires, implies, needs, or demands the related Artifact.
			/// </summary>
			Requires = 16,
			
			/// <summary>
			///   Interacts With: The primary Artifact interacts, associates, combines, meets, or communicates with the related Artifact.
			/// </summary>
			InteractsWith = 17,
			
			/// <summary>
			///   Looks Like: The primary Artifact looks like (has the appearance of) the related Artifact.
			/// </summary>
			LooksLike = 18,
			
			/// <summary>
			///   Smells Like: The primary Artifact smells like (has the odor, aroma, or fragrance of) the related Artifact.
			/// </summary>
			SmellsLike = 19,
			
			/// <summary>
			///   Tastes Like: The primary Artifact tastes like (has the flavor of) the related Artifact.
			/// </summary>
			TastesLike = 20,
			
			/// <summary>
			///   Sounds Like: The primary Artifact sounds like (has the aural characteristics of) the related Artifact.
			/// </summary>
			SoundsLike = 21,
			
			/// <summary>
			///   Feels Like: The primary Artifact feels like (has the tactile characteristics of) the related Artifact.
			/// </summary>
			FeelsLike = 22,
			
			/// <summary>
			///   Emotes Like: The primary Artifact emotes like (causes the emotion of) the related Artifact.
			/// </summary>
			EmotesLike = 23,
			
			/// <summary>
			///   Uses: The primary Artifact uses, utilizes, controls, employs, or manipulates the related Artifact.
			/// </summary>
			Uses = 24,
		}

		/*--------------------------------------------------------------------------------------------*/
		/// <summary/>
		public enum DirectorTypeId {
			
			/// <summary>
			///   Hyperlink: There is a hyperlink from the primary Artifact to the related Artifact.
			/// </summary>
			Hyperlink = 1,
			
			/// <summary>
			///   Defined Path: There is an expected, pre-defined path from the primary Artifact to the related Artifact.
			/// </summary>
			DefinedPath = 2,
			
			/// <summary>
			///   Suggested Path: There is a suggested, recommented path from the primary Artifact to the related Artifact.
			/// </summary>
			SuggestPath = 3,
			
			/// <summary>
			///   Avoid Path: There is an unsuitable, non-recommented path from the primary Artifact to the related Artifact.
			/// </summary>
			AvoidPath = 4,
			
			/// <summary>
			///   Causality: The primary Artifact causes an effect/action to occur upon the related Artifact.
			/// </summary>
			Causality = 5,
		}

		/*--------------------------------------------------------------------------------------------*/
		/// <summary/>
		public enum DirectorActionId {
			
			/// <summary>
			///   Read: Read the specified Artifact.
			/// </summary>
			Read = 1,
			
			/// <summary>
			///   Listen: Listen to the specified Artifact.
			/// </summary>
			Listen = 2,
			
			/// <summary>
			///   View: View (or watch, observe) the specified Artifact.
			/// </summary>
			View = 3,
			
			/// <summary>
			///   Consume: Consume (or use, eat, drink, taste, smell) the specified Artifact.
			/// </summary>
			Consume = 4,
			
			/// <summary>
			///   Perform: Perform (or act, do, carry out, speak, sing, say, work, write) the specified Artifact.
			/// </summary>
			Perform = 5,
			
			/// <summary>
			///   Produce: Produce (or create, build, make, invent) the specified Artifact.
			/// </summary>
			Produce = 6,
			
			/// <summary>
			///   Destroy: Destroy (or remove, delete, kill, erase) the specified Artifact.
			/// </summary>
			Destroy = 7,
			
			/// <summary>
			///   Modify: Modify (or change) the specified Artifact.
			/// </summary>
			Modify = 8,
			
			/// <summary>
			///   Obtain: Obtain (or get, purchase, acquire, steal) the specified Artifact.
			/// </summary>
			Obtain = 9,
			
			/// <summary>
			///   Locate: Locate (or find) the specified Artifact.
			/// </summary>
			Locate = 10,
			
			/// <summary>
			///   Travel: Travel (or visit, walk, run, fly, ride, drive) the specified Artifact.
			/// </summary>
			Travel = 11,
			
			/// <summary>
			///   Become: Become the specified Artifact.
			/// </summary>
			Become = 12,
			
			/// <summary>
			///   Explain: Explain (or describe) the specified Artifact.
			/// </summary>
			Explain = 13,
			
			/// <summary>
			///   Give: Give the specified Artifact.
			/// </summary>
			Give = 14,
			
			/// <summary>
			///   Learn: Learn (or study, understand) the specified Artifact.
			/// </summary>
			Learn = 15,
			
			/// <summary>
			///   Start: Start (or begin) the specified Artifact.
			/// </summary>
			Start = 16,
			
			/// <summary>
			///   Stop: Stop (or end) the specified Artifact.
			/// </summary>
			Stop = 17,
		}

		/*--------------------------------------------------------------------------------------------*/
		/// <summary/>
		public enum EventorTypeId {
			
			/// <summary>
			///   Start: This Factor starts, begins, or commences on the specified date.
			/// </summary>
			Start = 1,
			
			/// <summary>
			///   End: This Factor ends, stops, or terminates on the specified date.
			/// </summary>
			End = 2,
			
			/// <summary>
			///   Pause: This Factor pauses, suspendeds, or waits on the specified date.
			/// </summary>
			Pause = 3,
			
			/// <summary>
			///   Unpause: This Factor unpauses or resumes on the specified date.
			/// </summary>
			Unpause = 4,
			
			/// <summary>
			///   Continue: This Factor continues in its current state on the specified date.
			/// </summary>
			Continue = 5,
			
			/// <summary>
			///   Occur: This Factor occurrs or happens on the specified date.
			/// </summary>
			Occur = 6,
			
			/// <summary>
			///   Expected: This Factor is/was expected, anticipated, or due on the specified date.
			/// </summary>
			Expected = 7,
		}

		/*--------------------------------------------------------------------------------------------*/
		/// <summary/>
		public enum FactorAssertionId {
			
			/// <summary>
			///   Undefined: The Factor's assertion type is not known or not defined.
			/// </summary>
			Undefined = 1,
			
			/// <summary>
			///   Fact: The Factor represents a factual statement.
			/// </summary>
			Fact = 2,
			
			/// <summary>
			///   Opinion: The Factor represents an opinion.
			/// </summary>
			Opinion = 3,
			
			/// <summary>
			///   Guess: The Factor represents a guess.
			/// </summary>
			Guess = 4,
		}

		/*--------------------------------------------------------------------------------------------*/
		/// <summary/>
		public enum IdentorTypeId {
			
			/// <summary>
			///   Text: A value (a string, typically a name).
			/// </summary>
			Text = 1,
			
			/// <summary>
			///   Key: A value (numeric or otherwise) representing a unique key or ID.
			/// </summary>
			Key = 2,
		}

		/*--------------------------------------------------------------------------------------------*/
		/// <summary/>
		public enum LocatorTypeId {
			
			/// <summary>
			///   Earth Coordinate: A coordinate position on Earth.Coordinates use X=Longitude, Y=Latitude, and Z=Elevation (in metres).
			/// </summary>
			EarthCoord = 1,
			
			/// <summary>
			///   Moon Coordinate: A coordinate position on Earth's Moon.Coordinates use X=Longitude, Y=Latitude, and Z=Elevation (in metres).
			/// </summary>
			MoonCoord = 2,
			
			/// <summary>
			///   Mars Coordinate: A coordinate position on Mars.Coordinates use X=Longitude, Y=Latitude, and Z=Elevation (in metres).
			/// </summary>
			MarsCoord = 3,
			
			/// <summary>
			///   Relative Position 1D: A one-dimensional position, using X=Time. A position is relative to the Artifact's dimensions. For example, X=0.25 represents a position (starting from the origin) that is 25% of the distance to the maximum X dimension.
			/// </summary>
			RelPos1D = 4,
			
			/// <summary>
			///   Relative Position 2D: A two-dimensional position, using X=Width and Y=Height. A position is relative to the Artifact's dimensions. For example, X=0.25 represents a position (starting from the origin) that is 25% of the distance to the maximum X dimension.
			/// </summary>
			RelPos2D = 5,
			
			/// <summary>
			///   Relative Position 3D: A three-dimensional position, using X, Y, and Z axes. A position is relative to the Artifact's dimensions. For example, X=0.25 represents a position (starting from the origin) that is 25% of the distance to the maximum X dimension.
			/// </summary>
			RelPos3D = 6,
		}

		/*--------------------------------------------------------------------------------------------*/
		/// <summary/>
		public enum VectorTypeId {
			
			/// <summary>
			///   Full Bounds
			/// </summary>
			FullLong = 1,
			
			/// <summary>
			///   Positive Bounds
			/// </summary>
			PosLong = 2,
			
			/// <summary>
			///   Negative Bounds
			/// </summary>
			NegLong = 3,
			
			/// <summary>
			///   Full Percentage
			/// </summary>
			FullPerc = 4,
			
			/// <summary>
			///   Standard Percentage
			/// </summary>
			StdPerc = 5,
			
			/// <summary>
			///   Opposable Percentage
			/// </summary>
			OppPerc = 6,
			
			/// <summary>
			///   Standard Agreement
			/// </summary>
			StdAgree = 7,
			
			/// <summary>
			///   Opposable Agreement
			/// </summary>
			OppAgree = 8,
			
			/// <summary>
			///   Standard Favorability
			/// </summary>
			StdFavor = 9,
			
			/// <summary>
			///   Opposable Favorability
			/// </summary>
			OppFavor = 10,
		}

		/*--------------------------------------------------------------------------------------------*/
		/// <summary/>
		public enum VectorRangeLevelId {
			
			/// <summary>
			///   Zero
			/// </summary>
			Zero0 = 1,
			
			/// <summary>
			///   Zero
			/// </summary>
			Zero05 = 2,
			
			/// <summary>
			///   Zero
			/// </summary>
			Zero1 = 3,
			
			/// <summary>
			///   Minimum
			/// </summary>
			Min0 = 4,
			
			/// <summary>
			///   Maximum
			/// </summary>
			Max1 = 5,
			
			/// <summary>
			///   Completely Disagree
			/// </summary>
			CompDisagree = 6,
			
			/// <summary>
			///   Mostly Disagree
			/// </summary>
			MostDisagree = 7,
			
			/// <summary>
			///   Somewhat Disagree
			/// </summary>
			SomeDisagree = 8,
			
			/// <summary>
			///   No Opinion
			/// </summary>
			NoOpinion05 = 9,
			
			/// <summary>
			///   Somewhat Agree
			/// </summary>
			SomeAgree = 10,
			
			/// <summary>
			///   Mostly Agree
			/// </summary>
			MostAgree = 11,
			
			/// <summary>
			///   Completely Agree
			/// </summary>
			CompAgree = 12,
			
			/// <summary>
			///   No Opinion
			/// </summary>
			NoOpinion0 = 13,
			
			/// <summary>
			///   Somewhat Agree
			/// </summary>
			SomeAgreePos = 14,
			
			/// <summary>
			///   Mostly Agree
			/// </summary>
			MostAgreePos = 15,
			
			/// <summary>
			///   Completely Agree
			/// </summary>
			CompAgreePos = 16,
			
			/// <summary>
			///   Completely Unfavorable
			/// </summary>
			CompUnfavor = 17,
			
			/// <summary>
			///   Mostly Unfavorable
			/// </summary>
			MostUnfavor = 18,
			
			/// <summary>
			///   Somewhat Unfavorable
			/// </summary>
			SomeUnfavor = 19,
			
			/// <summary>
			///   Somewhat Favorable
			/// </summary>
			SomeFavor = 20,
			
			/// <summary>
			///   Mostly Favorable
			/// </summary>
			MostFavor = 21,
			
			/// <summary>
			///   Completely Favorable
			/// </summary>
			CompFavor = 22,
			
			/// <summary>
			///   Somewhat Favorable
			/// </summary>
			SomeFavorPos = 23,
			
			/// <summary>
			///   Mostly Favorable
			/// </summary>
			MostFavorPos = 24,
			
			/// <summary>
			///   Completely Favorable
			/// </summary>
			CompFavorPos = 25,
		}

		/*--------------------------------------------------------------------------------------------*/
		/// <summary/>
		public enum VectorRangeId {
			
			/// <summary>
			///   Full Numeric
			/// </summary>
			FullNum = 1,
			
			/// <summary>
			///   Positive Numeric
			/// </summary>
			PosNum = 2,
			
			/// <summary>
			///   Negative Numeric
			/// </summary>
			NegNum = 3,
			
			/// <summary>
			///   Full Agreement
			/// </summary>
			FullAgree = 4,
			
			/// <summary>
			///   Positive Agreement
			/// </summary>
			PosAgree = 5,
			
			/// <summary>
			///   Full Favorability
			/// </summary>
			FullFavor = 6,
			
			/// <summary>
			///   Positive Favorability
			/// </summary>
			PosFavor = 7,
		}

		/*--------------------------------------------------------------------------------------------*/
		/// <summary/>
		public enum VectorUnitId {
			
			/// <summary>
			///   None
			/// </summary>
			None = 1,
			
			/// <summary>
			///   Unit
			/// </summary>
			Unit = 2,
			
			/// <summary>
			///   Metre: m
			/// </summary>
			Metre = 3,
			
			/// <summary>
			///   Gram: g
			/// </summary>
			Gram = 4,
			
			/// <summary>
			///   Second: s
			/// </summary>
			Second = 5,
			
			/// <summary>
			///   Ampere: A
			/// </summary>
			Ampere = 6,
			
			/// <summary>
			///   Celsius: C
			/// </summary>
			Celsius = 7,
			
			/// <summary>
			///   Candela: cd
			/// </summary>
			Candela = 8,
			
			/// <summary>
			///   Mole: mol
			/// </summary>
			Mole = 9,
			
			/// <summary>
			///   Bit: b
			/// </summary>
			Bit = 10,
			
			/// <summary>
			///   long: B
			/// </summary>
			Byte = 11,
			
			/// <summary>
			///   Hertz: Hz
			/// </summary>
			Hertz = 12,
			
			/// <summary>
			///   Radian: rad
			/// </summary>
			Radian = 13,
			
			/// <summary>
			///   Newton: N
			/// </summary>
			Newton = 14,
			
			/// <summary>
			///   Pascal: Pa
			/// </summary>
			Pascal = 15,
			
			/// <summary>
			///   Joule: J
			/// </summary>
			Joule = 16,
			
			/// <summary>
			///   Watt: W
			/// </summary>
			Watt = 17,
			
			/// <summary>
			///   Volt: V
			/// </summary>
			Volt = 18,
			
			/// <summary>
			///   Ohm: Ω
			/// </summary>
			Ohm = 19,
			
			/// <summary>
			///   Area: m^2
			/// </summary>
			Area = 20,
			
			/// <summary>
			///   Volume: m^3
			/// </summary>
			Volume = 21,
			
			/// <summary>
			///   Speed: m/s
			/// </summary>
			Speed = 22,
			
			/// <summary>
			///   Acceleration: m^3/s
			/// </summary>
			Acceleration = 23,
			
			/// <summary>
			///   Point: pt
			/// </summary>
			Point = 24,
			
			/// <summary>
			///   Item: item
			/// </summary>
			Item = 25,
			
			/// <summary>
			///   Person: person
			/// </summary>
			Person = 26,
			
			/// <summary>
			///   Percent: %
			/// </summary>
			Percent = 27,
			
			/// <summary>
			///   Index: index
			/// </summary>
			Index = 28,
			
			/// <summary>
			///   Pixel: pixel
			/// </summary>
			Pixel = 29,
		}

		/*--------------------------------------------------------------------------------------------*/
		/// <summary/>
		public enum VectorUnitPrefixId {
			
			/// <summary>
			///   Base
			/// </summary>
			Base = 1,
			
			/// <summary>
			///   Kilo: k
			/// </summary>
			Kilo = 2,
			
			/// <summary>
			///   Mega: M
			/// </summary>
			Mega = 3,
			
			/// <summary>
			///   Giga: G
			/// </summary>
			Giga = 4,
			
			/// <summary>
			///   Tera: T
			/// </summary>
			Tera = 5,
			
			/// <summary>
			///   Peta: P
			/// </summary>
			Peta = 6,
			
			/// <summary>
			///   Exa: E
			/// </summary>
			Exa = 7,
			
			/// <summary>
			///   Milli: m
			/// </summary>
			Milli = 8,
			
			/// <summary>
			///   Micro: μ
			/// </summary>
			Micro = 9,
			
			/// <summary>
			///   Nano: n
			/// </summary>
			Nano = 10,
			
			/// <summary>
			///   Pico: p
			/// </summary>
			Pico = 11,
			
			/// <summary>
			///   Femto: f
			/// </summary>
			Femto = 12,
			
			/// <summary>
			///   Atto: a
			/// </summary>
			Atto = 13,
			
			/// <summary>
			///   Kibi: Ki
			/// </summary>
			Kibi = 14,
			
			/// <summary>
			///   Mebi: Mi
			/// </summary>
			Mebi = 15,
			
			/// <summary>
			///   Gibi: Gi
			/// </summary>
			Gibi = 16,
			
			/// <summary>
			///   Tebi: Ti
			/// </summary>
			Tebi = 17,
			
			/// <summary>
			///   Pebi: Pi
			/// </summary>
			Pebi = 18,
			
			/// <summary>
			///   Exbi: Ei
			/// </summary>
			Exbi = 19,
		}

		/*--------------------------------------------------------------------------------------------*/
		/// <summary/>
		public enum VectorUnitDerivedId {
			
			/// <summary>
			///   
			/// </summary>
			HertzSec = 1,
			
			/// <summary>
			///   
			/// </summary>
			NewtonGram = 2,
			
			/// <summary>
			///   
			/// </summary>
			NewtonMetre = 3,
			
			/// <summary>
			///   
			/// </summary>
			NewtonSec = 4,
			
			/// <summary>
			///   
			/// </summary>
			PascalGram = 5,
			
			/// <summary>
			///   
			/// </summary>
			PascalMetre = 6,
			
			/// <summary>
			///   
			/// </summary>
			PascalSec = 7,
			
			/// <summary>
			///   
			/// </summary>
			JouleGram = 8,
			
			/// <summary>
			///   
			/// </summary>
			JouleMetre = 9,
			
			/// <summary>
			///   
			/// </summary>
			JouleSec = 10,
			
			/// <summary>
			///   
			/// </summary>
			WattGram = 11,
			
			/// <summary>
			///   
			/// </summary>
			WattMetre = 12,
			
			/// <summary>
			///   
			/// </summary>
			WattSec = 13,
			
			/// <summary>
			///   
			/// </summary>
			VoltGram = 14,
			
			/// <summary>
			///   
			/// </summary>
			VoltMetre = 15,
			
			/// <summary>
			///   
			/// </summary>
			VoltSec = 16,
			
			/// <summary>
			///   
			/// </summary>
			VoltAmp = 17,
			
			/// <summary>
			///   
			/// </summary>
			OhmGram = 18,
			
			/// <summary>
			///   
			/// </summary>
			OhmMetre = 19,
			
			/// <summary>
			///   
			/// </summary>
			OhmSec = 20,
			
			/// <summary>
			///   
			/// </summary>
			OhmAmp = 21,
			
			/// <summary>
			///   
			/// </summary>
			AreaMetre = 22,
			
			/// <summary>
			///   
			/// </summary>
			VolumeMetre = 23,
			
			/// <summary>
			///   
			/// </summary>
			SpeedMetre = 24,
			
			/// <summary>
			///   
			/// </summary>
			SpeedSec = 25,
			
			/// <summary>
			///   
			/// </summary>
			AccelMetre = 26,
			
			/// <summary>
			///   
			/// </summary>
			AccelSec = 27,
		}

	
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		private static bool Init() {
			BuildMemberTypeMap();
			BuildDescriptorTypeMap();
			BuildDirectorTypeMap();
			BuildDirectorActionMap();
			BuildEventorTypeMap();
			BuildFactorAssertionMap();
			BuildIdentorTypeMap();
			BuildLocatorTypeMap();
			BuildVectorTypeMap();
			BuildVectorRangeLevelMap();
			BuildVectorRangeMap();
			BuildVectorUnitMap();
			BuildVectorUnitPrefixMap();
			BuildVectorUnitDerivedMap();
			return true;
		}

		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		private static void BuildMemberTypeMap() {
			MemberTypeMap = new Dictionary<byte, MemberType>();

			MemberTypeMap.Add(1, new MemberType {
				Id = (byte)1,
				EnumId = (string)"None",
				Name = (string)"None",
				Description = (string)"The User is not associated with this App.",
			});

			MemberTypeMap.Add(2, new MemberType {
				Id = (byte)2,
				EnumId = (string)"Request",
				Name = (string)"Request",
				Description = (string)"The user would like to become a member of this App.",
			});

			MemberTypeMap.Add(3, new MemberType {
				Id = (byte)3,
				EnumId = (string)"Invite",
				Name = (string)"Invite",
				Description = (string)"The User has been invited to become a member of this App.",
			});

			MemberTypeMap.Add(4, new MemberType {
				Id = (byte)4,
				EnumId = (string)"Member",
				Name = (string)"Member",
				Description = (string)"The User is a member of this App.",
			});

			MemberTypeMap.Add(5, new MemberType {
				Id = (byte)5,
				EnumId = (string)"Staff",
				Name = (string)"Staff",
				Description = (string)"The User is a staff member of this App.",
			});

			MemberTypeMap.Add(6, new MemberType {
				Id = (byte)6,
				EnumId = (string)"Admin",
				Name = (string)"Admin",
				Description = (string)"The User is an administrator of this App.",
			});

			MemberTypeMap.Add(7, new MemberType {
				Id = (byte)7,
				EnumId = (string)"Owner",
				Name = (string)"Owner",
				Description = (string)"The User owns this App.",
			});

			MemberTypeMap.Add(8, new MemberType {
				Id = (byte)8,
				EnumId = (string)"DataProvider",
				Name = (string)"Data Provider",
				Description = (string)"The User has a special membership that allows it to interact with Fabric on behalf of the App.",
			});
		}

		/*--------------------------------------------------------------------------------------------*/
		private static void BuildDescriptorTypeMap() {
			DescriptorTypeMap = new Dictionary<byte, DescriptorType>();

			DescriptorTypeMap.Add(1, new DescriptorType {
				Id = (byte)1,
				EnumId = (string)"IsRelatedTo",
				Name = (string)"Is Related To",
				Description = (string)"The primary Artifact is related to the related Artifact in some way. This is the default (and least meaningful) DescriptorType.",
			});

			DescriptorTypeMap.Add(2, new DescriptorType {
				Id = (byte)2,
				EnumId = (string)"IsA",
				Name = (string)"Is (A/An)",
				Description = (string)"The primary Artifact is a type of, a subclass of, a subset of, a subordinate of, or in the category defined by the related Artifact.",
			});

			DescriptorTypeMap.Add(3, new DescriptorType {
				Id = (byte)3,
				EnumId = (string)"IsAnInstanceOf",
				Name = (string)"Is An Instance Of",
				Description = (string)"The primary Artifact is an instance, case, example, or representation of the related Artifact.",
			});

			DescriptorTypeMap.Add(4, new DescriptorType {
				Id = (byte)4,
				EnumId = (string)"HasA",
				Name = (string)"Has (A/An)",
				Description = (string)"The primary Artifact has, as a part, piece, feature, attribute, or component, the related Artifact.",
			});

			DescriptorTypeMap.Add(5, new DescriptorType {
				Id = (byte)5,
				EnumId = (string)"IsLike",
				Name = (string)"Is Like",
				Description = (string)"The primary Artifact is like or similar to the related Artifact.",
			});

			DescriptorTypeMap.Add(6, new DescriptorType {
				Id = (byte)6,
				EnumId = (string)"IsNotLike",
				Name = (string)"Is Not Like",
				Description = (string)"The primary Artifact is not like or not similar to the related Artifact",
			});

			DescriptorTypeMap.Add(7, new DescriptorType {
				Id = (byte)7,
				EnumId = (string)"RefersTo",
				Name = (string)"Refers To",
				Description = (string)"The primary Artifact refers to, mentions, discusses, links to, or references the related Artifact.",
			});

			DescriptorTypeMap.Add(8, new DescriptorType {
				Id = (byte)8,
				EnumId = (string)"IsCreatedBy",
				Name = (string)"Is Created By",
				Description = (string)"The primary Artifact is created, built, designed, invented, formed, or performed by the related Artifact.",
			});

			DescriptorTypeMap.Add(9, new DescriptorType {
				Id = (byte)9,
				EnumId = (string)"IsInterestedIn",
				Name = (string)"Is Interested In",
				Description = (string)"The primary Artifact is interested in, fond of, attracted to, enjoys, prefers, or desires the related Artifact.",
			});

			DescriptorTypeMap.Add(10, new DescriptorType {
				Id = (byte)10,
				EnumId = (string)"Receives",
				Name = (string)"Receives",
				Description = (string)"The primary Artifact receives, gets, obtains, or is awarded the related Artifact.",
			});

			DescriptorTypeMap.Add(11, new DescriptorType {
				Id = (byte)11,
				EnumId = (string)"Consumes",
				Name = (string)"Consumes",
				Description = (string)"The primary Artifact consumes, eats, is powered by, uses up, depletes, or destroys the related Artifact.",
			});

			DescriptorTypeMap.Add(12, new DescriptorType {
				Id = (byte)12,
				EnumId = (string)"Produces",
				Name = (string)"Produces",
				Description = (string)"The primary Artifact produces, has a byproduct of, creates, or generates the related Artifact. This is similar to 'Is Created By', but in the opposite direction and meant to be less specific.",
			});

			DescriptorTypeMap.Add(13, new DescriptorType {
				Id = (byte)13,
				EnumId = (string)"ParticipatesIn",
				Name = (string)"Participates In",
				Description = (string)"The primary Artifact participates in, competes in, attends, is a member of, or is involved in the related Artifact.",
			});

			DescriptorTypeMap.Add(14, new DescriptorType {
				Id = (byte)14,
				EnumId = (string)"IsFoundIn",
				Name = (string)"Is Found In",
				Description = (string)"The primary Artifact is found in, located at, lives in, or is contained by the related Artifact.",
			});

			DescriptorTypeMap.Add(15, new DescriptorType {
				Id = (byte)15,
				EnumId = (string)"BelongsTo",
				Name = (string)"Belongs To",
				Description = (string)"The primary Artifact belongs to, is controlled by, or is owned by the related Artifact.",
			});

			DescriptorTypeMap.Add(16, new DescriptorType {
				Id = (byte)16,
				EnumId = (string)"Requires",
				Name = (string)"Requires",
				Description = (string)"The primary Artifact requires, implies, needs, or demands the related Artifact.",
			});

			DescriptorTypeMap.Add(17, new DescriptorType {
				Id = (byte)17,
				EnumId = (string)"InteractsWith",
				Name = (string)"Interacts With",
				Description = (string)"The primary Artifact interacts, associates, combines, meets, or communicates with the related Artifact.",
			});

			DescriptorTypeMap.Add(18, new DescriptorType {
				Id = (byte)18,
				EnumId = (string)"LooksLike",
				Name = (string)"Looks Like",
				Description = (string)"The primary Artifact looks like (has the appearance of) the related Artifact.",
			});

			DescriptorTypeMap.Add(19, new DescriptorType {
				Id = (byte)19,
				EnumId = (string)"SmellsLike",
				Name = (string)"Smells Like",
				Description = (string)"The primary Artifact smells like (has the odor, aroma, or fragrance of) the related Artifact.",
			});

			DescriptorTypeMap.Add(20, new DescriptorType {
				Id = (byte)20,
				EnumId = (string)"TastesLike",
				Name = (string)"Tastes Like",
				Description = (string)"The primary Artifact tastes like (has the flavor of) the related Artifact.",
			});

			DescriptorTypeMap.Add(21, new DescriptorType {
				Id = (byte)21,
				EnumId = (string)"SoundsLike",
				Name = (string)"Sounds Like",
				Description = (string)"The primary Artifact sounds like (has the aural characteristics of) the related Artifact.",
			});

			DescriptorTypeMap.Add(22, new DescriptorType {
				Id = (byte)22,
				EnumId = (string)"FeelsLike",
				Name = (string)"Feels Like",
				Description = (string)"The primary Artifact feels like (has the tactile characteristics of) the related Artifact.",
			});

			DescriptorTypeMap.Add(23, new DescriptorType {
				Id = (byte)23,
				EnumId = (string)"EmotesLike",
				Name = (string)"Emotes Like",
				Description = (string)"The primary Artifact emotes like (causes the emotion of) the related Artifact.",
			});

			DescriptorTypeMap.Add(24, new DescriptorType {
				Id = (byte)24,
				EnumId = (string)"Uses",
				Name = (string)"Uses",
				Description = (string)"The primary Artifact uses, utilizes, controls, employs, or manipulates the related Artifact.",
			});
		}

		/*--------------------------------------------------------------------------------------------*/
		private static void BuildDirectorTypeMap() {
			DirectorTypeMap = new Dictionary<byte, DirectorType>();

			DirectorTypeMap.Add(1, new DirectorType {
				Id = (byte)1,
				EnumId = (string)"Hyperlink",
				Name = (string)"Hyperlink",
				Description = (string)"There is a hyperlink from the primary Artifact to the related Artifact.",
			});

			DirectorTypeMap.Add(2, new DirectorType {
				Id = (byte)2,
				EnumId = (string)"DefinedPath",
				Name = (string)"Defined Path",
				Description = (string)"There is an expected, pre-defined path from the primary Artifact to the related Artifact.",
			});

			DirectorTypeMap.Add(3, new DirectorType {
				Id = (byte)3,
				EnumId = (string)"SuggestPath",
				Name = (string)"Suggested Path",
				Description = (string)"There is a suggested, recommented path from the primary Artifact to the related Artifact.",
			});

			DirectorTypeMap.Add(4, new DirectorType {
				Id = (byte)4,
				EnumId = (string)"AvoidPath",
				Name = (string)"Avoid Path",
				Description = (string)"There is an unsuitable, non-recommented path from the primary Artifact to the related Artifact.",
			});

			DirectorTypeMap.Add(5, new DirectorType {
				Id = (byte)5,
				EnumId = (string)"Causality",
				Name = (string)"Causality",
				Description = (string)"The primary Artifact causes an effect/action to occur upon the related Artifact.",
			});
		}

		/*--------------------------------------------------------------------------------------------*/
		private static void BuildDirectorActionMap() {
			DirectorActionMap = new Dictionary<byte, DirectorAction>();

			DirectorActionMap.Add(1, new DirectorAction {
				Id = (byte)1,
				EnumId = (string)"Read",
				Name = (string)"Read",
				Description = (string)"Read the specified Artifact.",
			});

			DirectorActionMap.Add(2, new DirectorAction {
				Id = (byte)2,
				EnumId = (string)"Listen",
				Name = (string)"Listen",
				Description = (string)"Listen to the specified Artifact.",
			});

			DirectorActionMap.Add(3, new DirectorAction {
				Id = (byte)3,
				EnumId = (string)"View",
				Name = (string)"View",
				Description = (string)"View (or watch, observe) the specified Artifact.",
			});

			DirectorActionMap.Add(4, new DirectorAction {
				Id = (byte)4,
				EnumId = (string)"Consume",
				Name = (string)"Consume",
				Description = (string)"Consume (or use, eat, drink, taste, smell) the specified Artifact.",
			});

			DirectorActionMap.Add(5, new DirectorAction {
				Id = (byte)5,
				EnumId = (string)"Perform",
				Name = (string)"Perform",
				Description = (string)"Perform (or act, do, carry out, speak, sing, say, work, write) the specified Artifact.",
			});

			DirectorActionMap.Add(6, new DirectorAction {
				Id = (byte)6,
				EnumId = (string)"Produce",
				Name = (string)"Produce",
				Description = (string)"Produce (or create, build, make, invent) the specified Artifact.",
			});

			DirectorActionMap.Add(7, new DirectorAction {
				Id = (byte)7,
				EnumId = (string)"Destroy",
				Name = (string)"Destroy",
				Description = (string)"Destroy (or remove, delete, kill, erase) the specified Artifact.",
			});

			DirectorActionMap.Add(8, new DirectorAction {
				Id = (byte)8,
				EnumId = (string)"Modify",
				Name = (string)"Modify",
				Description = (string)"Modify (or change) the specified Artifact.",
			});

			DirectorActionMap.Add(9, new DirectorAction {
				Id = (byte)9,
				EnumId = (string)"Obtain",
				Name = (string)"Obtain",
				Description = (string)"Obtain (or get, purchase, acquire, steal) the specified Artifact.",
			});

			DirectorActionMap.Add(10, new DirectorAction {
				Id = (byte)10,
				EnumId = (string)"Locate",
				Name = (string)"Locate",
				Description = (string)"Locate (or find) the specified Artifact.",
			});

			DirectorActionMap.Add(11, new DirectorAction {
				Id = (byte)11,
				EnumId = (string)"Travel",
				Name = (string)"Travel",
				Description = (string)"Travel (or visit, walk, run, fly, ride, drive) the specified Artifact.",
			});

			DirectorActionMap.Add(12, new DirectorAction {
				Id = (byte)12,
				EnumId = (string)"Become",
				Name = (string)"Become",
				Description = (string)"Become the specified Artifact.",
			});

			DirectorActionMap.Add(13, new DirectorAction {
				Id = (byte)13,
				EnumId = (string)"Explain",
				Name = (string)"Explain",
				Description = (string)"Explain (or describe) the specified Artifact.",
			});

			DirectorActionMap.Add(14, new DirectorAction {
				Id = (byte)14,
				EnumId = (string)"Give",
				Name = (string)"Give",
				Description = (string)"Give the specified Artifact.",
			});

			DirectorActionMap.Add(15, new DirectorAction {
				Id = (byte)15,
				EnumId = (string)"Learn",
				Name = (string)"Learn",
				Description = (string)"Learn (or study, understand) the specified Artifact.",
			});

			DirectorActionMap.Add(16, new DirectorAction {
				Id = (byte)16,
				EnumId = (string)"Start",
				Name = (string)"Start",
				Description = (string)"Start (or begin) the specified Artifact.",
			});

			DirectorActionMap.Add(17, new DirectorAction {
				Id = (byte)17,
				EnumId = (string)"Stop",
				Name = (string)"Stop",
				Description = (string)"Stop (or end) the specified Artifact.",
			});
		}

		/*--------------------------------------------------------------------------------------------*/
		private static void BuildEventorTypeMap() {
			EventorTypeMap = new Dictionary<byte, EventorType>();

			EventorTypeMap.Add(1, new EventorType {
				Id = (byte)1,
				EnumId = (string)"Start",
				Name = (string)"Start",
				Description = (string)"This Factor starts, begins, or commences on the specified date.",
			});

			EventorTypeMap.Add(2, new EventorType {
				Id = (byte)2,
				EnumId = (string)"End",
				Name = (string)"End",
				Description = (string)"This Factor ends, stops, or terminates on the specified date.",
			});

			EventorTypeMap.Add(3, new EventorType {
				Id = (byte)3,
				EnumId = (string)"Pause",
				Name = (string)"Pause",
				Description = (string)"This Factor pauses, suspendeds, or waits on the specified date.",
			});

			EventorTypeMap.Add(4, new EventorType {
				Id = (byte)4,
				EnumId = (string)"Unpause",
				Name = (string)"Unpause",
				Description = (string)"This Factor unpauses or resumes on the specified date.",
			});

			EventorTypeMap.Add(5, new EventorType {
				Id = (byte)5,
				EnumId = (string)"Continue",
				Name = (string)"Continue",
				Description = (string)"This Factor continues in its current state on the specified date.",
			});

			EventorTypeMap.Add(6, new EventorType {
				Id = (byte)6,
				EnumId = (string)"Occur",
				Name = (string)"Occur",
				Description = (string)"This Factor occurrs or happens on the specified date.",
			});

			EventorTypeMap.Add(7, new EventorType {
				Id = (byte)7,
				EnumId = (string)"Expected",
				Name = (string)"Expected",
				Description = (string)"This Factor is/was expected, anticipated, or due on the specified date.",
			});
		}

		/*--------------------------------------------------------------------------------------------*/
		private static void BuildFactorAssertionMap() {
			FactorAssertionMap = new Dictionary<byte, FactorAssertion>();

			FactorAssertionMap.Add(1, new FactorAssertion {
				Id = (byte)1,
				EnumId = (string)"Undefined",
				Name = (string)"Undefined",
				Description = (string)"The Factor's assertion type is not known or not defined.",
			});

			FactorAssertionMap.Add(2, new FactorAssertion {
				Id = (byte)2,
				EnumId = (string)"Fact",
				Name = (string)"Fact",
				Description = (string)"The Factor represents a factual statement.",
			});

			FactorAssertionMap.Add(3, new FactorAssertion {
				Id = (byte)3,
				EnumId = (string)"Opinion",
				Name = (string)"Opinion",
				Description = (string)"The Factor represents an opinion.",
			});

			FactorAssertionMap.Add(4, new FactorAssertion {
				Id = (byte)4,
				EnumId = (string)"Guess",
				Name = (string)"Guess",
				Description = (string)"The Factor represents a guess.",
			});
		}

		/*--------------------------------------------------------------------------------------------*/
		private static void BuildIdentorTypeMap() {
			IdentorTypeMap = new Dictionary<byte, IdentorType>();

			IdentorTypeMap.Add(1, new IdentorType {
				Id = (byte)1,
				EnumId = (string)"Text",
				Name = (string)"Text",
				Description = (string)"A value (a string, typically a name).",
			});

			IdentorTypeMap.Add(2, new IdentorType {
				Id = (byte)2,
				EnumId = (string)"Key",
				Name = (string)"Key",
				Description = (string)"A value (numeric or otherwise) representing a unique key or ID.",
			});
		}

		/*--------------------------------------------------------------------------------------------*/
		private static void BuildLocatorTypeMap() {
			LocatorTypeMap = new Dictionary<byte, LocatorType>();

			LocatorTypeMap.Add(1, new LocatorType {
				Id = (byte)1,
				EnumId = (string)"EarthCoord",
				Name = (string)"Earth Coordinate",
				Description = (string)"A coordinate position on Earth.Coordinates use X=Longitude, Y=Latitude, and Z=Elevation (in metres).",
				MinX = (double)-180,
				MaxX = (double)180,
				MinY = (double)-90,
				MaxY = (double)90,
				MinZ = (double)-1.79769313486231e+308,
				MaxZ = (double)1.79769313486231e+308,
			});

			LocatorTypeMap.Add(2, new LocatorType {
				Id = (byte)2,
				EnumId = (string)"MoonCoord",
				Name = (string)"Moon Coordinate",
				Description = (string)"A coordinate position on Earth's Moon.Coordinates use X=Longitude, Y=Latitude, and Z=Elevation (in metres).",
				MinX = (double)-180,
				MaxX = (double)180,
				MinY = (double)-90,
				MaxY = (double)90,
				MinZ = (double)-1.79769313486231e+308,
				MaxZ = (double)1.79769313486231e+308,
			});

			LocatorTypeMap.Add(3, new LocatorType {
				Id = (byte)3,
				EnumId = (string)"MarsCoord",
				Name = (string)"Mars Coordinate",
				Description = (string)"A coordinate position on Mars.Coordinates use X=Longitude, Y=Latitude, and Z=Elevation (in metres).",
				MinX = (double)-180,
				MaxX = (double)180,
				MinY = (double)-90,
				MaxY = (double)90,
				MinZ = (double)-1.79769313486231e+308,
				MaxZ = (double)1.79769313486231e+308,
			});

			LocatorTypeMap.Add(4, new LocatorType {
				Id = (byte)4,
				EnumId = (string)"RelPos1D",
				Name = (string)"Relative Position 1D",
				Description = (string)"A one-dimensional position, using X=Time. A position is relative to the Artifact's dimensions. For example, X=0.25 represents a position (starting from the origin) that is 25% of the distance to the maximum X dimension.",
				MinX = (double)-1.79769313486231e+308,
				MaxX = (double)1.79769313486231e+308,
				MinY = (double)0,
				MaxY = (double)0,
				MinZ = (double)0,
				MaxZ = (double)0,
			});

			LocatorTypeMap.Add(5, new LocatorType {
				Id = (byte)5,
				EnumId = (string)"RelPos2D",
				Name = (string)"Relative Position 2D",
				Description = (string)"A two-dimensional position, using X=Width and Y=Height. A position is relative to the Artifact's dimensions. For example, X=0.25 represents a position (starting from the origin) that is 25% of the distance to the maximum X dimension.",
				MinX = (double)-1.79769313486231e+308,
				MaxX = (double)1.79769313486231e+308,
				MinY = (double)-1.79769313486231e+308,
				MaxY = (double)1.79769313486231e+308,
				MinZ = (double)0,
				MaxZ = (double)0,
			});

			LocatorTypeMap.Add(6, new LocatorType {
				Id = (byte)6,
				EnumId = (string)"RelPos3D",
				Name = (string)"Relative Position 3D",
				Description = (string)"A three-dimensional position, using X, Y, and Z axes. A position is relative to the Artifact's dimensions. For example, X=0.25 represents a position (starting from the origin) that is 25% of the distance to the maximum X dimension.",
				MinX = (double)-1.79769313486231e+308,
				MaxX = (double)1.79769313486231e+308,
				MinY = (double)-1.79769313486231e+308,
				MaxY = (double)1.79769313486231e+308,
				MinZ = (double)-1.79769313486231e+308,
				MaxZ = (double)1.79769313486231e+308,
			});
		}

		/*--------------------------------------------------------------------------------------------*/
		private static void BuildVectorTypeMap() {
			VectorTypeMap = new Dictionary<byte, VectorType>();

			VectorTypeMap.Add(1, new VectorType {
				Id = (byte)1,
				EnumId = (string)"FullLong",
				Name = (string)"Full Bounds",
				Description = (string)"",
				VectorRangeId = (byte)1,
				Min = (long)-9223372036854775808,
				Max = (long)9223372036854775807,
			});

			VectorTypeMap.Add(2, new VectorType {
				Id = (byte)2,
				EnumId = (string)"PosLong",
				Name = (string)"Positive Bounds",
				Description = (string)"",
				VectorRangeId = (byte)2,
				Min = (long)0,
				Max = (long)9223372036854775807,
			});

			VectorTypeMap.Add(3, new VectorType {
				Id = (byte)3,
				EnumId = (string)"NegLong",
				Name = (string)"Negative Bounds",
				Description = (string)"",
				VectorRangeId = (byte)3,
				Min = (long)-9223372036854775808,
				Max = (long)0,
			});

			VectorTypeMap.Add(4, new VectorType {
				Id = (byte)4,
				EnumId = (string)"FullPerc",
				Name = (string)"Full Percentage",
				Description = (string)"",
				VectorRangeId = (byte)1,
				Min = (long)-9223372036854775808,
				Max = (long)9223372036854775807,
			});

			VectorTypeMap.Add(5, new VectorType {
				Id = (byte)5,
				EnumId = (string)"StdPerc",
				Name = (string)"Standard Percentage",
				Description = (string)"",
				VectorRangeId = (byte)2,
				Min = (long)0,
				Max = (long)100,
			});

			VectorTypeMap.Add(6, new VectorType {
				Id = (byte)6,
				EnumId = (string)"OppPerc",
				Name = (string)"Opposable Percentage",
				Description = (string)"",
				VectorRangeId = (byte)1,
				Min = (long)-100,
				Max = (long)100,
			});

			VectorTypeMap.Add(7, new VectorType {
				Id = (byte)7,
				EnumId = (string)"StdAgree",
				Name = (string)"Standard Agreement",
				Description = (string)"",
				VectorRangeId = (byte)5,
				Min = (long)0,
				Max = (long)100,
			});

			VectorTypeMap.Add(8, new VectorType {
				Id = (byte)8,
				EnumId = (string)"OppAgree",
				Name = (string)"Opposable Agreement",
				Description = (string)"",
				VectorRangeId = (byte)4,
				Min = (long)-100,
				Max = (long)100,
			});

			VectorTypeMap.Add(9, new VectorType {
				Id = (byte)9,
				EnumId = (string)"StdFavor",
				Name = (string)"Standard Favorability",
				Description = (string)"",
				VectorRangeId = (byte)7,
				Min = (long)0,
				Max = (long)100,
			});

			VectorTypeMap.Add(10, new VectorType {
				Id = (byte)10,
				EnumId = (string)"OppFavor",
				Name = (string)"Opposable Favorability",
				Description = (string)"",
				VectorRangeId = (byte)6,
				Min = (long)-100,
				Max = (long)100,
			});
		}

		/*--------------------------------------------------------------------------------------------*/
		private static void BuildVectorRangeLevelMap() {
			VectorRangeLevelMap = new Dictionary<byte, VectorRangeLevel>();

			VectorRangeLevelMap.Add(1, new VectorRangeLevel {
				Id = (byte)1,
				EnumId = (string)"Zero0",
				Name = (string)"Zero",
				Description = (string)"",
				Position = (float)0,
			});

			VectorRangeLevelMap.Add(2, new VectorRangeLevel {
				Id = (byte)2,
				EnumId = (string)"Zero05",
				Name = (string)"Zero",
				Description = (string)"",
				Position = (float)0.5,
			});

			VectorRangeLevelMap.Add(3, new VectorRangeLevel {
				Id = (byte)3,
				EnumId = (string)"Zero1",
				Name = (string)"Zero",
				Description = (string)"",
				Position = (float)1,
			});

			VectorRangeLevelMap.Add(4, new VectorRangeLevel {
				Id = (byte)4,
				EnumId = (string)"Min0",
				Name = (string)"Minimum",
				Description = (string)"",
				Position = (float)0,
			});

			VectorRangeLevelMap.Add(5, new VectorRangeLevel {
				Id = (byte)5,
				EnumId = (string)"Max1",
				Name = (string)"Maximum",
				Description = (string)"",
				Position = (float)1,
			});

			VectorRangeLevelMap.Add(6, new VectorRangeLevel {
				Id = (byte)6,
				EnumId = (string)"CompDisagree",
				Name = (string)"Completely Disagree",
				Description = (string)"",
				Position = (float)0,
			});

			VectorRangeLevelMap.Add(7, new VectorRangeLevel {
				Id = (byte)7,
				EnumId = (string)"MostDisagree",
				Name = (string)"Mostly Disagree",
				Description = (string)"",
				Position = (float)0.1666667,
			});

			VectorRangeLevelMap.Add(8, new VectorRangeLevel {
				Id = (byte)8,
				EnumId = (string)"SomeDisagree",
				Name = (string)"Somewhat Disagree",
				Description = (string)"",
				Position = (float)0.3333333,
			});

			VectorRangeLevelMap.Add(9, new VectorRangeLevel {
				Id = (byte)9,
				EnumId = (string)"NoOpinion05",
				Name = (string)"No Opinion",
				Description = (string)"",
				Position = (float)0.5,
			});

			VectorRangeLevelMap.Add(10, new VectorRangeLevel {
				Id = (byte)10,
				EnumId = (string)"SomeAgree",
				Name = (string)"Somewhat Agree",
				Description = (string)"",
				Position = (float)0.6666667,
			});

			VectorRangeLevelMap.Add(11, new VectorRangeLevel {
				Id = (byte)11,
				EnumId = (string)"MostAgree",
				Name = (string)"Mostly Agree",
				Description = (string)"",
				Position = (float)0.8333333,
			});

			VectorRangeLevelMap.Add(12, new VectorRangeLevel {
				Id = (byte)12,
				EnumId = (string)"CompAgree",
				Name = (string)"Completely Agree",
				Description = (string)"",
				Position = (float)1,
			});

			VectorRangeLevelMap.Add(13, new VectorRangeLevel {
				Id = (byte)13,
				EnumId = (string)"NoOpinion0",
				Name = (string)"No Opinion",
				Description = (string)"",
				Position = (float)0,
			});

			VectorRangeLevelMap.Add(14, new VectorRangeLevel {
				Id = (byte)14,
				EnumId = (string)"SomeAgreePos",
				Name = (string)"Somewhat Agree",
				Description = (string)"",
				Position = (float)0.3333333,
			});

			VectorRangeLevelMap.Add(15, new VectorRangeLevel {
				Id = (byte)15,
				EnumId = (string)"MostAgreePos",
				Name = (string)"Mostly Agree",
				Description = (string)"",
				Position = (float)0.6666667,
			});

			VectorRangeLevelMap.Add(16, new VectorRangeLevel {
				Id = (byte)16,
				EnumId = (string)"CompAgreePos",
				Name = (string)"Completely Agree",
				Description = (string)"",
				Position = (float)1,
			});

			VectorRangeLevelMap.Add(17, new VectorRangeLevel {
				Id = (byte)17,
				EnumId = (string)"CompUnfavor",
				Name = (string)"Completely Unfavorable",
				Description = (string)"",
				Position = (float)0,
			});

			VectorRangeLevelMap.Add(18, new VectorRangeLevel {
				Id = (byte)18,
				EnumId = (string)"MostUnfavor",
				Name = (string)"Mostly Unfavorable",
				Description = (string)"",
				Position = (float)0.1666667,
			});

			VectorRangeLevelMap.Add(19, new VectorRangeLevel {
				Id = (byte)19,
				EnumId = (string)"SomeUnfavor",
				Name = (string)"Somewhat Unfavorable",
				Description = (string)"",
				Position = (float)0.3333333,
			});

			VectorRangeLevelMap.Add(20, new VectorRangeLevel {
				Id = (byte)20,
				EnumId = (string)"SomeFavor",
				Name = (string)"Somewhat Favorable",
				Description = (string)"",
				Position = (float)0.6666667,
			});

			VectorRangeLevelMap.Add(21, new VectorRangeLevel {
				Id = (byte)21,
				EnumId = (string)"MostFavor",
				Name = (string)"Mostly Favorable",
				Description = (string)"",
				Position = (float)0.8333333,
			});

			VectorRangeLevelMap.Add(22, new VectorRangeLevel {
				Id = (byte)22,
				EnumId = (string)"CompFavor",
				Name = (string)"Completely Favorable",
				Description = (string)"",
				Position = (float)1,
			});

			VectorRangeLevelMap.Add(23, new VectorRangeLevel {
				Id = (byte)23,
				EnumId = (string)"SomeFavorPos",
				Name = (string)"Somewhat Favorable",
				Description = (string)"",
				Position = (float)0.3333333,
			});

			VectorRangeLevelMap.Add(24, new VectorRangeLevel {
				Id = (byte)24,
				EnumId = (string)"MostFavorPos",
				Name = (string)"Mostly Favorable",
				Description = (string)"",
				Position = (float)0.6666667,
			});

			VectorRangeLevelMap.Add(25, new VectorRangeLevel {
				Id = (byte)25,
				EnumId = (string)"CompFavorPos",
				Name = (string)"Completely Favorable",
				Description = (string)"",
				Position = (float)1,
			});
		}

		/*--------------------------------------------------------------------------------------------*/
		private static void BuildVectorRangeMap() {
			VectorRangeMap = new Dictionary<byte, VectorRange>();

			VectorRangeMap.Add(1, new VectorRange {
				Id = (byte)1,
				EnumId = (string)"FullNum",
				Name = (string)"Full Numeric",
				Description = (string)"",
				VectorRangeLevelIds = (byte[])new byte[] { 4, 2, 5 },
			});

			VectorRangeMap.Add(2, new VectorRange {
				Id = (byte)2,
				EnumId = (string)"PosNum",
				Name = (string)"Positive Numeric",
				Description = (string)"",
				VectorRangeLevelIds = (byte[])new byte[] { 1, 5 },
			});

			VectorRangeMap.Add(3, new VectorRange {
				Id = (byte)3,
				EnumId = (string)"NegNum",
				Name = (string)"Negative Numeric",
				Description = (string)"",
				VectorRangeLevelIds = (byte[])new byte[] { 4, 3 },
			});

			VectorRangeMap.Add(4, new VectorRange {
				Id = (byte)4,
				EnumId = (string)"FullAgree",
				Name = (string)"Full Agreement",
				Description = (string)"",
				VectorRangeLevelIds = (byte[])new byte[] { 6, 7, 8, 9, 10, 11, 12 },
			});

			VectorRangeMap.Add(5, new VectorRange {
				Id = (byte)5,
				EnumId = (string)"PosAgree",
				Name = (string)"Positive Agreement",
				Description = (string)"",
				VectorRangeLevelIds = (byte[])new byte[] { 13, 14, 15, 16 },
			});

			VectorRangeMap.Add(6, new VectorRange {
				Id = (byte)6,
				EnumId = (string)"FullFavor",
				Name = (string)"Full Favorability",
				Description = (string)"",
				VectorRangeLevelIds = (byte[])new byte[] { 17, 18, 19, 9, 20, 21, 22 },
			});

			VectorRangeMap.Add(7, new VectorRange {
				Id = (byte)7,
				EnumId = (string)"PosFavor",
				Name = (string)"Positive Favorability",
				Description = (string)"",
				VectorRangeLevelIds = (byte[])new byte[] { 13, 23, 24, 25 },
			});
		}

		/*--------------------------------------------------------------------------------------------*/
		private static void BuildVectorUnitMap() {
			VectorUnitMap = new Dictionary<byte, VectorUnit>();

			VectorUnitMap.Add(1, new VectorUnit {
				Id = (byte)1,
				EnumId = (string)"None",
				Name = (string)"None",
				Description = (string)"",
			});

			VectorUnitMap.Add(2, new VectorUnit {
				Id = (byte)2,
				EnumId = (string)"Unit",
				Name = (string)"Unit",
				Description = (string)"",
			});

			VectorUnitMap.Add(3, new VectorUnit {
				Id = (byte)3,
				EnumId = (string)"Metre",
				Name = (string)"Metre",
				Description = (string)"m",
			});

			VectorUnitMap.Add(4, new VectorUnit {
				Id = (byte)4,
				EnumId = (string)"Gram",
				Name = (string)"Gram",
				Description = (string)"g",
			});

			VectorUnitMap.Add(5, new VectorUnit {
				Id = (byte)5,
				EnumId = (string)"Second",
				Name = (string)"Second",
				Description = (string)"s",
			});

			VectorUnitMap.Add(6, new VectorUnit {
				Id = (byte)6,
				EnumId = (string)"Ampere",
				Name = (string)"Ampere",
				Description = (string)"A",
			});

			VectorUnitMap.Add(7, new VectorUnit {
				Id = (byte)7,
				EnumId = (string)"Celsius",
				Name = (string)"Celsius",
				Description = (string)"C",
			});

			VectorUnitMap.Add(8, new VectorUnit {
				Id = (byte)8,
				EnumId = (string)"Candela",
				Name = (string)"Candela",
				Description = (string)"cd",
			});

			VectorUnitMap.Add(9, new VectorUnit {
				Id = (byte)9,
				EnumId = (string)"Mole",
				Name = (string)"Mole",
				Description = (string)"mol",
			});

			VectorUnitMap.Add(10, new VectorUnit {
				Id = (byte)10,
				EnumId = (string)"Bit",
				Name = (string)"Bit",
				Description = (string)"b",
			});

			VectorUnitMap.Add(11, new VectorUnit {
				Id = (byte)11,
				EnumId = (string)"Byte",
				Name = (string)"long",
				Description = (string)"B",
			});

			VectorUnitMap.Add(12, new VectorUnit {
				Id = (byte)12,
				EnumId = (string)"Hertz",
				Name = (string)"Hertz",
				Description = (string)"Hz",
			});

			VectorUnitMap.Add(13, new VectorUnit {
				Id = (byte)13,
				EnumId = (string)"Radian",
				Name = (string)"Radian",
				Description = (string)"rad",
			});

			VectorUnitMap.Add(14, new VectorUnit {
				Id = (byte)14,
				EnumId = (string)"Newton",
				Name = (string)"Newton",
				Description = (string)"N",
			});

			VectorUnitMap.Add(15, new VectorUnit {
				Id = (byte)15,
				EnumId = (string)"Pascal",
				Name = (string)"Pascal",
				Description = (string)"Pa",
			});

			VectorUnitMap.Add(16, new VectorUnit {
				Id = (byte)16,
				EnumId = (string)"Joule",
				Name = (string)"Joule",
				Description = (string)"J",
			});

			VectorUnitMap.Add(17, new VectorUnit {
				Id = (byte)17,
				EnumId = (string)"Watt",
				Name = (string)"Watt",
				Description = (string)"W",
			});

			VectorUnitMap.Add(18, new VectorUnit {
				Id = (byte)18,
				EnumId = (string)"Volt",
				Name = (string)"Volt",
				Description = (string)"V",
			});

			VectorUnitMap.Add(19, new VectorUnit {
				Id = (byte)19,
				EnumId = (string)"Ohm",
				Name = (string)"Ohm",
				Description = (string)"Ω",
			});

			VectorUnitMap.Add(20, new VectorUnit {
				Id = (byte)20,
				EnumId = (string)"Area",
				Name = (string)"Area",
				Description = (string)"m^2",
			});

			VectorUnitMap.Add(21, new VectorUnit {
				Id = (byte)21,
				EnumId = (string)"Volume",
				Name = (string)"Volume",
				Description = (string)"m^3",
			});

			VectorUnitMap.Add(22, new VectorUnit {
				Id = (byte)22,
				EnumId = (string)"Speed",
				Name = (string)"Speed",
				Description = (string)"m/s",
			});

			VectorUnitMap.Add(23, new VectorUnit {
				Id = (byte)23,
				EnumId = (string)"Acceleration",
				Name = (string)"Acceleration",
				Description = (string)"m^3/s",
			});

			VectorUnitMap.Add(24, new VectorUnit {
				Id = (byte)24,
				EnumId = (string)"Point",
				Name = (string)"Point",
				Description = (string)"pt",
			});

			VectorUnitMap.Add(25, new VectorUnit {
				Id = (byte)25,
				EnumId = (string)"Item",
				Name = (string)"Item",
				Description = (string)"item",
			});

			VectorUnitMap.Add(26, new VectorUnit {
				Id = (byte)26,
				EnumId = (string)"Person",
				Name = (string)"Person",
				Description = (string)"person",
			});

			VectorUnitMap.Add(27, new VectorUnit {
				Id = (byte)27,
				EnumId = (string)"Percent",
				Name = (string)"Percent",
				Description = (string)"%",
			});

			VectorUnitMap.Add(28, new VectorUnit {
				Id = (byte)28,
				EnumId = (string)"Index",
				Name = (string)"Index",
				Description = (string)"index",
			});

			VectorUnitMap.Add(29, new VectorUnit {
				Id = (byte)29,
				EnumId = (string)"Pixel",
				Name = (string)"Pixel",
				Description = (string)"pixel",
			});
		}

		/*--------------------------------------------------------------------------------------------*/
		private static void BuildVectorUnitPrefixMap() {
			VectorUnitPrefixMap = new Dictionary<byte, VectorUnitPrefix>();

			VectorUnitPrefixMap.Add(1, new VectorUnitPrefix {
				Id = (byte)1,
				EnumId = (string)"Base",
				Name = (string)"Base",
				Description = (string)"",
				Amount = (double)1,
			});

			VectorUnitPrefixMap.Add(2, new VectorUnitPrefix {
				Id = (byte)2,
				EnumId = (string)"Kilo",
				Name = (string)"Kilo",
				Description = (string)"k",
				Amount = (double)1000,
			});

			VectorUnitPrefixMap.Add(3, new VectorUnitPrefix {
				Id = (byte)3,
				EnumId = (string)"Mega",
				Name = (string)"Mega",
				Description = (string)"M",
				Amount = (double)1000000,
			});

			VectorUnitPrefixMap.Add(4, new VectorUnitPrefix {
				Id = (byte)4,
				EnumId = (string)"Giga",
				Name = (string)"Giga",
				Description = (string)"G",
				Amount = (double)1000000000,
			});

			VectorUnitPrefixMap.Add(5, new VectorUnitPrefix {
				Id = (byte)5,
				EnumId = (string)"Tera",
				Name = (string)"Tera",
				Description = (string)"T",
				Amount = (double)1000000000000,
			});

			VectorUnitPrefixMap.Add(6, new VectorUnitPrefix {
				Id = (byte)6,
				EnumId = (string)"Peta",
				Name = (string)"Peta",
				Description = (string)"P",
				Amount = (double)1000000000000000,
			});

			VectorUnitPrefixMap.Add(7, new VectorUnitPrefix {
				Id = (byte)7,
				EnumId = (string)"Exa",
				Name = (string)"Exa",
				Description = (string)"E",
				Amount = (double)1000000000000000000,
			});

			VectorUnitPrefixMap.Add(8, new VectorUnitPrefix {
				Id = (byte)8,
				EnumId = (string)"Milli",
				Name = (string)"Milli",
				Description = (string)"m",
				Amount = (double)0.001,
			});

			VectorUnitPrefixMap.Add(9, new VectorUnitPrefix {
				Id = (byte)9,
				EnumId = (string)"Micro",
				Name = (string)"Micro",
				Description = (string)"μ",
				Amount = (double)0.000001,
			});

			VectorUnitPrefixMap.Add(10, new VectorUnitPrefix {
				Id = (byte)10,
				EnumId = (string)"Nano",
				Name = (string)"Nano",
				Description = (string)"n",
				Amount = (double)1e-9,
			});

			VectorUnitPrefixMap.Add(11, new VectorUnitPrefix {
				Id = (byte)11,
				EnumId = (string)"Pico",
				Name = (string)"Pico",
				Description = (string)"p",
				Amount = (double)1e-12,
			});

			VectorUnitPrefixMap.Add(12, new VectorUnitPrefix {
				Id = (byte)12,
				EnumId = (string)"Femto",
				Name = (string)"Femto",
				Description = (string)"f",
				Amount = (double)1e-15,
			});

			VectorUnitPrefixMap.Add(13, new VectorUnitPrefix {
				Id = (byte)13,
				EnumId = (string)"Atto",
				Name = (string)"Atto",
				Description = (string)"a",
				Amount = (double)1e-18,
			});

			VectorUnitPrefixMap.Add(14, new VectorUnitPrefix {
				Id = (byte)14,
				EnumId = (string)"Kibi",
				Name = (string)"Kibi",
				Description = (string)"Ki",
				Amount = (double)1024,
			});

			VectorUnitPrefixMap.Add(15, new VectorUnitPrefix {
				Id = (byte)15,
				EnumId = (string)"Mebi",
				Name = (string)"Mebi",
				Description = (string)"Mi",
				Amount = (double)1048576,
			});

			VectorUnitPrefixMap.Add(16, new VectorUnitPrefix {
				Id = (byte)16,
				EnumId = (string)"Gibi",
				Name = (string)"Gibi",
				Description = (string)"Gi",
				Amount = (double)1073741824,
			});

			VectorUnitPrefixMap.Add(17, new VectorUnitPrefix {
				Id = (byte)17,
				EnumId = (string)"Tebi",
				Name = (string)"Tebi",
				Description = (string)"Ti",
				Amount = (double)1099511627776,
			});

			VectorUnitPrefixMap.Add(18, new VectorUnitPrefix {
				Id = (byte)18,
				EnumId = (string)"Pebi",
				Name = (string)"Pebi",
				Description = (string)"Pi",
				Amount = (double)1125899906842620,
			});

			VectorUnitPrefixMap.Add(19, new VectorUnitPrefix {
				Id = (byte)19,
				EnumId = (string)"Exbi",
				Name = (string)"Exbi",
				Description = (string)"Ei",
				Amount = (double)1152921504606850000,
			});
		}

		/*--------------------------------------------------------------------------------------------*/
		private static void BuildVectorUnitDerivedMap() {
			VectorUnitDerivedMap = new Dictionary<byte, VectorUnitDerived>();

			VectorUnitDerivedMap.Add(1, new VectorUnitDerived {
				Id = (byte)1,
				EnumId = (string)"HertzSec",
				Name = (string)"",
				Description = (string)"",
				DefinesVectorUnitId = (byte)12,
				RaisesVectorUnitId = (byte)5,
				WithExponent = (int)-1,
				RaisesVectorUnitPrefixId = (byte)1,
			});

			VectorUnitDerivedMap.Add(2, new VectorUnitDerived {
				Id = (byte)2,
				EnumId = (string)"NewtonGram",
				Name = (string)"",
				Description = (string)"",
				DefinesVectorUnitId = (byte)14,
				RaisesVectorUnitId = (byte)4,
				WithExponent = (int)1,
				RaisesVectorUnitPrefixId = (byte)2,
			});

			VectorUnitDerivedMap.Add(3, new VectorUnitDerived {
				Id = (byte)3,
				EnumId = (string)"NewtonMetre",
				Name = (string)"",
				Description = (string)"",
				DefinesVectorUnitId = (byte)14,
				RaisesVectorUnitId = (byte)3,
				WithExponent = (int)1,
				RaisesVectorUnitPrefixId = (byte)1,
			});

			VectorUnitDerivedMap.Add(4, new VectorUnitDerived {
				Id = (byte)4,
				EnumId = (string)"NewtonSec",
				Name = (string)"",
				Description = (string)"",
				DefinesVectorUnitId = (byte)14,
				RaisesVectorUnitId = (byte)5,
				WithExponent = (int)-2,
				RaisesVectorUnitPrefixId = (byte)1,
			});

			VectorUnitDerivedMap.Add(5, new VectorUnitDerived {
				Id = (byte)5,
				EnumId = (string)"PascalGram",
				Name = (string)"",
				Description = (string)"",
				DefinesVectorUnitId = (byte)15,
				RaisesVectorUnitId = (byte)4,
				WithExponent = (int)1,
				RaisesVectorUnitPrefixId = (byte)2,
			});

			VectorUnitDerivedMap.Add(6, new VectorUnitDerived {
				Id = (byte)6,
				EnumId = (string)"PascalMetre",
				Name = (string)"",
				Description = (string)"",
				DefinesVectorUnitId = (byte)15,
				RaisesVectorUnitId = (byte)3,
				WithExponent = (int)-1,
				RaisesVectorUnitPrefixId = (byte)1,
			});

			VectorUnitDerivedMap.Add(7, new VectorUnitDerived {
				Id = (byte)7,
				EnumId = (string)"PascalSec",
				Name = (string)"",
				Description = (string)"",
				DefinesVectorUnitId = (byte)15,
				RaisesVectorUnitId = (byte)5,
				WithExponent = (int)-2,
				RaisesVectorUnitPrefixId = (byte)1,
			});

			VectorUnitDerivedMap.Add(8, new VectorUnitDerived {
				Id = (byte)8,
				EnumId = (string)"JouleGram",
				Name = (string)"",
				Description = (string)"",
				DefinesVectorUnitId = (byte)16,
				RaisesVectorUnitId = (byte)4,
				WithExponent = (int)1,
				RaisesVectorUnitPrefixId = (byte)2,
			});

			VectorUnitDerivedMap.Add(9, new VectorUnitDerived {
				Id = (byte)9,
				EnumId = (string)"JouleMetre",
				Name = (string)"",
				Description = (string)"",
				DefinesVectorUnitId = (byte)16,
				RaisesVectorUnitId = (byte)3,
				WithExponent = (int)2,
				RaisesVectorUnitPrefixId = (byte)1,
			});

			VectorUnitDerivedMap.Add(10, new VectorUnitDerived {
				Id = (byte)10,
				EnumId = (string)"JouleSec",
				Name = (string)"",
				Description = (string)"",
				DefinesVectorUnitId = (byte)16,
				RaisesVectorUnitId = (byte)5,
				WithExponent = (int)-2,
				RaisesVectorUnitPrefixId = (byte)1,
			});

			VectorUnitDerivedMap.Add(11, new VectorUnitDerived {
				Id = (byte)11,
				EnumId = (string)"WattGram",
				Name = (string)"",
				Description = (string)"",
				DefinesVectorUnitId = (byte)17,
				RaisesVectorUnitId = (byte)4,
				WithExponent = (int)1,
				RaisesVectorUnitPrefixId = (byte)2,
			});

			VectorUnitDerivedMap.Add(12, new VectorUnitDerived {
				Id = (byte)12,
				EnumId = (string)"WattMetre",
				Name = (string)"",
				Description = (string)"",
				DefinesVectorUnitId = (byte)17,
				RaisesVectorUnitId = (byte)3,
				WithExponent = (int)2,
				RaisesVectorUnitPrefixId = (byte)1,
			});

			VectorUnitDerivedMap.Add(13, new VectorUnitDerived {
				Id = (byte)13,
				EnumId = (string)"WattSec",
				Name = (string)"",
				Description = (string)"",
				DefinesVectorUnitId = (byte)17,
				RaisesVectorUnitId = (byte)5,
				WithExponent = (int)-3,
				RaisesVectorUnitPrefixId = (byte)1,
			});

			VectorUnitDerivedMap.Add(14, new VectorUnitDerived {
				Id = (byte)14,
				EnumId = (string)"VoltGram",
				Name = (string)"",
				Description = (string)"",
				DefinesVectorUnitId = (byte)18,
				RaisesVectorUnitId = (byte)4,
				WithExponent = (int)1,
				RaisesVectorUnitPrefixId = (byte)2,
			});

			VectorUnitDerivedMap.Add(15, new VectorUnitDerived {
				Id = (byte)15,
				EnumId = (string)"VoltMetre",
				Name = (string)"",
				Description = (string)"",
				DefinesVectorUnitId = (byte)18,
				RaisesVectorUnitId = (byte)3,
				WithExponent = (int)2,
				RaisesVectorUnitPrefixId = (byte)1,
			});

			VectorUnitDerivedMap.Add(16, new VectorUnitDerived {
				Id = (byte)16,
				EnumId = (string)"VoltSec",
				Name = (string)"",
				Description = (string)"",
				DefinesVectorUnitId = (byte)18,
				RaisesVectorUnitId = (byte)5,
				WithExponent = (int)-3,
				RaisesVectorUnitPrefixId = (byte)1,
			});

			VectorUnitDerivedMap.Add(17, new VectorUnitDerived {
				Id = (byte)17,
				EnumId = (string)"VoltAmp",
				Name = (string)"",
				Description = (string)"",
				DefinesVectorUnitId = (byte)18,
				RaisesVectorUnitId = (byte)6,
				WithExponent = (int)-1,
				RaisesVectorUnitPrefixId = (byte)1,
			});

			VectorUnitDerivedMap.Add(18, new VectorUnitDerived {
				Id = (byte)18,
				EnumId = (string)"OhmGram",
				Name = (string)"",
				Description = (string)"",
				DefinesVectorUnitId = (byte)19,
				RaisesVectorUnitId = (byte)4,
				WithExponent = (int)1,
				RaisesVectorUnitPrefixId = (byte)2,
			});

			VectorUnitDerivedMap.Add(19, new VectorUnitDerived {
				Id = (byte)19,
				EnumId = (string)"OhmMetre",
				Name = (string)"",
				Description = (string)"",
				DefinesVectorUnitId = (byte)19,
				RaisesVectorUnitId = (byte)3,
				WithExponent = (int)2,
				RaisesVectorUnitPrefixId = (byte)1,
			});

			VectorUnitDerivedMap.Add(20, new VectorUnitDerived {
				Id = (byte)20,
				EnumId = (string)"OhmSec",
				Name = (string)"",
				Description = (string)"",
				DefinesVectorUnitId = (byte)19,
				RaisesVectorUnitId = (byte)5,
				WithExponent = (int)-3,
				RaisesVectorUnitPrefixId = (byte)1,
			});

			VectorUnitDerivedMap.Add(21, new VectorUnitDerived {
				Id = (byte)21,
				EnumId = (string)"OhmAmp",
				Name = (string)"",
				Description = (string)"",
				DefinesVectorUnitId = (byte)19,
				RaisesVectorUnitId = (byte)6,
				WithExponent = (int)-2,
				RaisesVectorUnitPrefixId = (byte)1,
			});

			VectorUnitDerivedMap.Add(22, new VectorUnitDerived {
				Id = (byte)22,
				EnumId = (string)"AreaMetre",
				Name = (string)"",
				Description = (string)"",
				DefinesVectorUnitId = (byte)20,
				RaisesVectorUnitId = (byte)3,
				WithExponent = (int)2,
				RaisesVectorUnitPrefixId = (byte)1,
			});

			VectorUnitDerivedMap.Add(23, new VectorUnitDerived {
				Id = (byte)23,
				EnumId = (string)"VolumeMetre",
				Name = (string)"",
				Description = (string)"",
				DefinesVectorUnitId = (byte)21,
				RaisesVectorUnitId = (byte)3,
				WithExponent = (int)3,
				RaisesVectorUnitPrefixId = (byte)1,
			});

			VectorUnitDerivedMap.Add(24, new VectorUnitDerived {
				Id = (byte)24,
				EnumId = (string)"SpeedMetre",
				Name = (string)"",
				Description = (string)"",
				DefinesVectorUnitId = (byte)22,
				RaisesVectorUnitId = (byte)3,
				WithExponent = (int)1,
				RaisesVectorUnitPrefixId = (byte)1,
			});

			VectorUnitDerivedMap.Add(25, new VectorUnitDerived {
				Id = (byte)25,
				EnumId = (string)"SpeedSec",
				Name = (string)"",
				Description = (string)"",
				DefinesVectorUnitId = (byte)22,
				RaisesVectorUnitId = (byte)5,
				WithExponent = (int)-1,
				RaisesVectorUnitPrefixId = (byte)1,
			});

			VectorUnitDerivedMap.Add(26, new VectorUnitDerived {
				Id = (byte)26,
				EnumId = (string)"AccelMetre",
				Name = (string)"",
				Description = (string)"",
				DefinesVectorUnitId = (byte)23,
				RaisesVectorUnitId = (byte)3,
				WithExponent = (int)1,
				RaisesVectorUnitPrefixId = (byte)1,
			});

			VectorUnitDerivedMap.Add(27, new VectorUnitDerived {
				Id = (byte)27,
				EnumId = (string)"AccelSec",
				Name = (string)"",
				Description = (string)"",
				DefinesVectorUnitId = (byte)23,
				RaisesVectorUnitId = (byte)5,
				WithExponent = (int)-2,
				RaisesVectorUnitPrefixId = (byte)1,
			});
		}


	}

}