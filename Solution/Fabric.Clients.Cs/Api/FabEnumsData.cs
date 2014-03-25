// GENERATED CODE
// Changes made to this source file will be overwritten

using System.Collections.Generic;

namespace Fabric.Clients.Cs.Api {

	/*================================================================================================*/
	/// <summary/>
	public static class FabEnumsData {

		/// <summary/>
		public static IDictionary<byte, DescriptorType> DescriptorTypeMap;
	
		/// <summary/>
		public static IDictionary<byte, DirectorAction> DirectorActionMap;
	
		/// <summary/>
		public static IDictionary<byte, DirectorType> DirectorTypeMap;
	
		/// <summary/>
		public static IDictionary<byte, EventorType> EventorTypeMap;
	
		/// <summary/>
		public static IDictionary<byte, FactorAssertion> FactorAssertionMap;
	
		/// <summary/>
		public static IDictionary<byte, IdentorType> IdentorTypeMap;
	
		/// <summary/>
		public static IDictionary<byte, LocatorType> LocatorTypeMap;
	
		/// <summary/>
		public static IDictionary<byte, MemberType> MemberTypeMap;
	
		/// <summary/>
		public static IDictionary<byte, VectorRange> VectorRangeMap;
	
		/// <summary/>
		public static IDictionary<byte, VectorRangeLevel> VectorRangeLevelMap;
	
		/// <summary/>
		public static IDictionary<byte, VectorType> VectorTypeMap;
	
		/// <summary/>
		public static IDictionary<byte, VectorUnit> VectorUnitMap;
	
		/// <summary/>
		public static IDictionary<byte, VectorUnitDerived> VectorUnitDerivedMap;
	
		/// <summary/>
		public static IDictionary<byte, VectorUnitPrefix> VectorUnitPrefixMap;
	
		/// <summary/>
		public static IDictionary<byte, VertexType> VertexTypeMap;
	
		private static bool IsInit = Init();


		////////////////////////////////////////////////////////////////////////////////////////////////
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
			SuggestedPath = 3,
			
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
			///   Earth Coordinate: A coordinate position on Earth.Coordinates use X=Longitude, Y=Latitude, and Z=Elevation (in metres).Coordinates use X=Longitude, Y=Latitude, and Z=Elevation (in metres).
			/// </summary>
			EarthCoord = 1,
			
			/// <summary>
			///   Moon Coordinate: A coordinate position on Earth's Moon.Coordinates use X=Longitude, Y=Latitude, and Z=Elevation (in metres).Coordinates use X=Longitude, Y=Latitude, and Z=Elevation (in metres).
			/// </summary>
			MoonCoord = 2,
			
			/// <summary>
			///   Mars Coordinate: A coordinate position on Mars.Coordinates use X=Longitude, Y=Latitude, and Z=Elevation (in metres).Coordinates use X=Longitude, Y=Latitude, and Z=Elevation (in metres).
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
			DataProv = 8,
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
			///   Byte: B
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
		public enum VertexTypeId {
			
			/// <summary>
			///   Vertex
			/// </summary>
			Vertex = 1,
			
			/// <summary>
			///   App
			/// </summary>
			App = 2,
			
			/// <summary>
			///   Class
			/// </summary>
			Class = 3,
			
			/// <summary>
			///   Instance
			/// </summary>
			Instance = 4,
			
			/// <summary>
			///   Url
			/// </summary>
			Url = 5,
			
			/// <summary>
			///   User
			/// </summary>
			User = 6,
			
			/// <summary>
			///   Member
			/// </summary>
			Member = 7,
			
			/// <summary>
			///   Artifact
			/// </summary>
			Artifact = 8,
			
			/// <summary>
			///   Factor
			/// </summary>
			Factor = 9,
			
			/// <summary>
			///   Email
			/// </summary>
			Email = 10,
			
			/// <summary>
			///   OauthAccess
			/// </summary>
			OauthAccess = 11,
		}

	
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		private static bool Init() {
			BuildDescriptorTypeMap();
			BuildDirectorActionMap();
			BuildDirectorTypeMap();
			BuildEventorTypeMap();
			BuildFactorAssertionMap();
			BuildIdentorTypeMap();
			BuildLocatorTypeMap();
			BuildMemberTypeMap();
			BuildVectorRangeMap();
			BuildVectorRangeLevelMap();
			BuildVectorTypeMap();
			BuildVectorUnitMap();
			BuildVectorUnitDerivedMap();
			BuildVectorUnitPrefixMap();
			BuildVertexTypeMap();
			return true;
		}

		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		private static void BuildDescriptorTypeMap() {
			DescriptorTypeMap = new Dictionary<byte, DescriptorType>();

			DescriptorTypeMap.Add(1, new DescriptorType {
				Id = 1,
				EnumId = "IsRelatedTo",
				Name = "Is Related To",
				Description = "The primary Artifact is related to the related Artifact in some way. This is the default (and least meaningful) DescriptorType.",
			});

			DescriptorTypeMap.Add(2, new DescriptorType {
				Id = 2,
				EnumId = "IsA",
				Name = "Is (A/An)",
				Description = "The primary Artifact is a type of, a subclass of, a subset of, a subordinate of, or in the category defined by the related Artifact.",
			});

			DescriptorTypeMap.Add(3, new DescriptorType {
				Id = 3,
				EnumId = "IsAnInstanceOf",
				Name = "Is An Instance Of",
				Description = "The primary Artifact is an instance, case, example, or representation of the related Artifact.",
			});

			DescriptorTypeMap.Add(4, new DescriptorType {
				Id = 4,
				EnumId = "HasA",
				Name = "Has (A/An)",
				Description = "The primary Artifact has, as a part, piece, feature, attribute, or component, the related Artifact.",
			});

			DescriptorTypeMap.Add(5, new DescriptorType {
				Id = 5,
				EnumId = "IsLike",
				Name = "Is Like",
				Description = "The primary Artifact is like or similar to the related Artifact.",
			});

			DescriptorTypeMap.Add(6, new DescriptorType {
				Id = 6,
				EnumId = "IsNotLike",
				Name = "Is Not Like",
				Description = "The primary Artifact is not like or not similar to the related Artifact",
			});

			DescriptorTypeMap.Add(7, new DescriptorType {
				Id = 7,
				EnumId = "RefersTo",
				Name = "Refers To",
				Description = "The primary Artifact refers to, mentions, discusses, links to, or references the related Artifact.",
			});

			DescriptorTypeMap.Add(8, new DescriptorType {
				Id = 8,
				EnumId = "IsCreatedBy",
				Name = "Is Created By",
				Description = "The primary Artifact is created, built, designed, invented, formed, or performed by the related Artifact.",
			});

			DescriptorTypeMap.Add(9, new DescriptorType {
				Id = 9,
				EnumId = "IsInterestedIn",
				Name = "Is Interested In",
				Description = "The primary Artifact is interested in, fond of, attracted to, enjoys, prefers, or desires the related Artifact.",
			});

			DescriptorTypeMap.Add(10, new DescriptorType {
				Id = 10,
				EnumId = "Receives",
				Name = "Receives",
				Description = "The primary Artifact receives, gets, obtains, or is awarded the related Artifact.",
			});

			DescriptorTypeMap.Add(11, new DescriptorType {
				Id = 11,
				EnumId = "Consumes",
				Name = "Consumes",
				Description = "The primary Artifact consumes, eats, is powered by, uses up, depletes, or destroys the related Artifact.",
			});

			DescriptorTypeMap.Add(12, new DescriptorType {
				Id = 12,
				EnumId = "Produces",
				Name = "Produces",
				Description = "The primary Artifact produces, has a byproduct of, creates, or generates the related Artifact. This is similar to 'Is Created By', but in the opposite direction and meant to be less specific.",
			});

			DescriptorTypeMap.Add(13, new DescriptorType {
				Id = 13,
				EnumId = "ParticipatesIn",
				Name = "Participates In",
				Description = "The primary Artifact participates in, competes in, attends, is a member of, or is involved in the related Artifact.",
			});

			DescriptorTypeMap.Add(14, new DescriptorType {
				Id = 14,
				EnumId = "IsFoundIn",
				Name = "Is Found In",
				Description = "The primary Artifact is found in, located at, lives in, or is contained by the related Artifact.",
			});

			DescriptorTypeMap.Add(15, new DescriptorType {
				Id = 15,
				EnumId = "BelongsTo",
				Name = "Belongs To",
				Description = "The primary Artifact belongs to, is controlled by, or is owned by the related Artifact.",
			});

			DescriptorTypeMap.Add(16, new DescriptorType {
				Id = 16,
				EnumId = "Requires",
				Name = "Requires",
				Description = "The primary Artifact requires, implies, needs, or demands the related Artifact.",
			});

			DescriptorTypeMap.Add(17, new DescriptorType {
				Id = 17,
				EnumId = "InteractsWith",
				Name = "Interacts With",
				Description = "The primary Artifact interacts, associates, combines, meets, or communicates with the related Artifact.",
			});

			DescriptorTypeMap.Add(18, new DescriptorType {
				Id = 18,
				EnumId = "LooksLike",
				Name = "Looks Like",
				Description = "The primary Artifact looks like (has the appearance of) the related Artifact.",
			});

			DescriptorTypeMap.Add(19, new DescriptorType {
				Id = 19,
				EnumId = "SmellsLike",
				Name = "Smells Like",
				Description = "The primary Artifact smells like (has the odor, aroma, or fragrance of) the related Artifact.",
			});

			DescriptorTypeMap.Add(20, new DescriptorType {
				Id = 20,
				EnumId = "TastesLike",
				Name = "Tastes Like",
				Description = "The primary Artifact tastes like (has the flavor of) the related Artifact.",
			});

			DescriptorTypeMap.Add(21, new DescriptorType {
				Id = 21,
				EnumId = "SoundsLike",
				Name = "Sounds Like",
				Description = "The primary Artifact sounds like (has the aural characteristics of) the related Artifact.",
			});

			DescriptorTypeMap.Add(22, new DescriptorType {
				Id = 22,
				EnumId = "FeelsLike",
				Name = "Feels Like",
				Description = "The primary Artifact feels like (has the tactile characteristics of) the related Artifact.",
			});

			DescriptorTypeMap.Add(23, new DescriptorType {
				Id = 23,
				EnumId = "EmotesLike",
				Name = "Emotes Like",
				Description = "The primary Artifact emotes like (causes the emotion of) the related Artifact.",
			});

			DescriptorTypeMap.Add(24, new DescriptorType {
				Id = 24,
				EnumId = "Uses",
				Name = "Uses",
				Description = "The primary Artifact uses, utilizes, controls, employs, or manipulates the related Artifact.",
			});
		}

		/*--------------------------------------------------------------------------------------------*/
		private static void BuildDirectorActionMap() {
			DirectorActionMap = new Dictionary<byte, DirectorAction>();

			DirectorActionMap.Add(1, new DirectorAction {
				Id = 1,
				EnumId = "Read",
				Name = "Read",
				Description = "Read the specified Artifact.",
			});

			DirectorActionMap.Add(2, new DirectorAction {
				Id = 2,
				EnumId = "Listen",
				Name = "Listen",
				Description = "Listen to the specified Artifact.",
			});

			DirectorActionMap.Add(3, new DirectorAction {
				Id = 3,
				EnumId = "View",
				Name = "View",
				Description = "View (or watch, observe) the specified Artifact.",
			});

			DirectorActionMap.Add(4, new DirectorAction {
				Id = 4,
				EnumId = "Consume",
				Name = "Consume",
				Description = "Consume (or use, eat, drink, taste, smell) the specified Artifact.",
			});

			DirectorActionMap.Add(5, new DirectorAction {
				Id = 5,
				EnumId = "Perform",
				Name = "Perform",
				Description = "Perform (or act, do, carry out, speak, sing, say, work, write) the specified Artifact.",
			});

			DirectorActionMap.Add(6, new DirectorAction {
				Id = 6,
				EnumId = "Produce",
				Name = "Produce",
				Description = "Produce (or create, build, make, invent) the specified Artifact.",
			});

			DirectorActionMap.Add(7, new DirectorAction {
				Id = 7,
				EnumId = "Destroy",
				Name = "Destroy",
				Description = "Destroy (or remove, delete, kill, erase) the specified Artifact.",
			});

			DirectorActionMap.Add(8, new DirectorAction {
				Id = 8,
				EnumId = "Modify",
				Name = "Modify",
				Description = "Modify (or change) the specified Artifact.",
			});

			DirectorActionMap.Add(9, new DirectorAction {
				Id = 9,
				EnumId = "Obtain",
				Name = "Obtain",
				Description = "Obtain (or get, purchase, acquire, steal) the specified Artifact.",
			});

			DirectorActionMap.Add(10, new DirectorAction {
				Id = 10,
				EnumId = "Locate",
				Name = "Locate",
				Description = "Locate (or find) the specified Artifact.",
			});

			DirectorActionMap.Add(11, new DirectorAction {
				Id = 11,
				EnumId = "Travel",
				Name = "Travel",
				Description = "Travel (or visit, walk, run, fly, ride, drive) the specified Artifact.",
			});

			DirectorActionMap.Add(12, new DirectorAction {
				Id = 12,
				EnumId = "Become",
				Name = "Become",
				Description = "Become the specified Artifact.",
			});

			DirectorActionMap.Add(13, new DirectorAction {
				Id = 13,
				EnumId = "Explain",
				Name = "Explain",
				Description = "Explain (or describe) the specified Artifact.",
			});

			DirectorActionMap.Add(14, new DirectorAction {
				Id = 14,
				EnumId = "Give",
				Name = "Give",
				Description = "Give the specified Artifact.",
			});

			DirectorActionMap.Add(15, new DirectorAction {
				Id = 15,
				EnumId = "Learn",
				Name = "Learn",
				Description = "Learn (or study, understand) the specified Artifact.",
			});

			DirectorActionMap.Add(16, new DirectorAction {
				Id = 16,
				EnumId = "Start",
				Name = "Start",
				Description = "Start (or begin) the specified Artifact.",
			});

			DirectorActionMap.Add(17, new DirectorAction {
				Id = 17,
				EnumId = "Stop",
				Name = "Stop",
				Description = "Stop (or end) the specified Artifact.",
			});
		}

		/*--------------------------------------------------------------------------------------------*/
		private static void BuildDirectorTypeMap() {
			DirectorTypeMap = new Dictionary<byte, DirectorType>();

			DirectorTypeMap.Add(1, new DirectorType {
				Id = 1,
				EnumId = "Hyperlink",
				Name = "Hyperlink",
				Description = "There is a hyperlink from the primary Artifact to the related Artifact.",
			});

			DirectorTypeMap.Add(2, new DirectorType {
				Id = 2,
				EnumId = "DefinedPath",
				Name = "Defined Path",
				Description = "There is an expected, pre-defined path from the primary Artifact to the related Artifact.",
			});

			DirectorTypeMap.Add(3, new DirectorType {
				Id = 3,
				EnumId = "SuggestedPath",
				Name = "Suggested Path",
				Description = "There is a suggested, recommented path from the primary Artifact to the related Artifact.",
			});

			DirectorTypeMap.Add(4, new DirectorType {
				Id = 4,
				EnumId = "AvoidPath",
				Name = "Avoid Path",
				Description = "There is an unsuitable, non-recommented path from the primary Artifact to the related Artifact.",
			});

			DirectorTypeMap.Add(5, new DirectorType {
				Id = 5,
				EnumId = "Causality",
				Name = "Causality",
				Description = "The primary Artifact causes an effect/action to occur upon the related Artifact.",
			});
		}

		/*--------------------------------------------------------------------------------------------*/
		private static void BuildEventorTypeMap() {
			EventorTypeMap = new Dictionary<byte, EventorType>();

			EventorTypeMap.Add(1, new EventorType {
				Id = 1,
				EnumId = "Start",
				Name = "Start",
				Description = "This Factor starts, begins, or commences on the specified date.",
			});

			EventorTypeMap.Add(2, new EventorType {
				Id = 2,
				EnumId = "End",
				Name = "End",
				Description = "This Factor ends, stops, or terminates on the specified date.",
			});

			EventorTypeMap.Add(3, new EventorType {
				Id = 3,
				EnumId = "Pause",
				Name = "Pause",
				Description = "This Factor pauses, suspendeds, or waits on the specified date.",
			});

			EventorTypeMap.Add(4, new EventorType {
				Id = 4,
				EnumId = "Unpause",
				Name = "Unpause",
				Description = "This Factor unpauses or resumes on the specified date.",
			});

			EventorTypeMap.Add(5, new EventorType {
				Id = 5,
				EnumId = "Continue",
				Name = "Continue",
				Description = "This Factor continues in its current state on the specified date.",
			});

			EventorTypeMap.Add(6, new EventorType {
				Id = 6,
				EnumId = "Occur",
				Name = "Occur",
				Description = "This Factor occurrs or happens on the specified date.",
			});

			EventorTypeMap.Add(7, new EventorType {
				Id = 7,
				EnumId = "Expected",
				Name = "Expected",
				Description = "This Factor is/was expected, anticipated, or due on the specified date.",
			});
		}

		/*--------------------------------------------------------------------------------------------*/
		private static void BuildFactorAssertionMap() {
			FactorAssertionMap = new Dictionary<byte, FactorAssertion>();

			FactorAssertionMap.Add(1, new FactorAssertion {
				Id = 1,
				EnumId = "Undefined",
				Name = "Undefined",
				Description = "The Factor's assertion type is not known or not defined.",
			});

			FactorAssertionMap.Add(2, new FactorAssertion {
				Id = 2,
				EnumId = "Fact",
				Name = "Fact",
				Description = "The Factor represents a factual statement.",
			});

			FactorAssertionMap.Add(3, new FactorAssertion {
				Id = 3,
				EnumId = "Opinion",
				Name = "Opinion",
				Description = "The Factor represents an opinion.",
			});

			FactorAssertionMap.Add(4, new FactorAssertion {
				Id = 4,
				EnumId = "Guess",
				Name = "Guess",
				Description = "The Factor represents a guess.",
			});
		}

		/*--------------------------------------------------------------------------------------------*/
		private static void BuildIdentorTypeMap() {
			IdentorTypeMap = new Dictionary<byte, IdentorType>();

			IdentorTypeMap.Add(1, new IdentorType {
				Id = 1,
				EnumId = "Text",
				Name = "Text",
				Description = "A value (a string, typically a name).",
			});

			IdentorTypeMap.Add(2, new IdentorType {
				Id = 2,
				EnumId = "Key",
				Name = "Key",
				Description = "A value (numeric or otherwise) representing a unique key or ID.",
			});
		}

		/*--------------------------------------------------------------------------------------------*/
		private static void BuildLocatorTypeMap() {
			LocatorTypeMap = new Dictionary<byte, LocatorType>();

			LocatorTypeMap.Add(1, new LocatorType {
				Id = 1,
				EnumId = "EarthCoord",
				Name = "Earth Coordinate",
				Description = "A coordinate position on Earth.Coordinates use X=Longitude, Y=Latitude, and Z=Elevation (in metres).Coordinates use X=Longitude, Y=Latitude, and Z=Elevation (in metres).",
				MinX = -180,
				MaxX = 180,
				MinY = -90,
				MaxY = 90,
				MinZ = -1.79769313486231e+308,
				MaxZ = 1.79769313486231e+308,
			});

			LocatorTypeMap.Add(2, new LocatorType {
				Id = 2,
				EnumId = "MoonCoord",
				Name = "Moon Coordinate",
				Description = "A coordinate position on Earth's Moon.Coordinates use X=Longitude, Y=Latitude, and Z=Elevation (in metres).Coordinates use X=Longitude, Y=Latitude, and Z=Elevation (in metres).",
				MinX = -180,
				MaxX = 180,
				MinY = -90,
				MaxY = 90,
				MinZ = -1.79769313486231e+308,
				MaxZ = 1.79769313486231e+308,
			});

			LocatorTypeMap.Add(3, new LocatorType {
				Id = 3,
				EnumId = "MarsCoord",
				Name = "Mars Coordinate",
				Description = "A coordinate position on Mars.Coordinates use X=Longitude, Y=Latitude, and Z=Elevation (in metres).Coordinates use X=Longitude, Y=Latitude, and Z=Elevation (in metres).",
				MinX = -180,
				MaxX = 180,
				MinY = -90,
				MaxY = 90,
				MinZ = -1.79769313486231e+308,
				MaxZ = 1.79769313486231e+308,
			});

			LocatorTypeMap.Add(4, new LocatorType {
				Id = 4,
				EnumId = "RelPos1D",
				Name = "Relative Position 1D",
				Description = "A one-dimensional position, using X=Time. A position is relative to the Artifact's dimensions. For example, X=0.25 represents a position (starting from the origin) that is 25% of the distance to the maximum X dimension.",
				MinX = -1.79769313486231e+308,
				MaxX = 1.79769313486231e+308,
				MinY = 0,
				MaxY = 0,
				MinZ = 0,
				MaxZ = 0,
			});

			LocatorTypeMap.Add(5, new LocatorType {
				Id = 5,
				EnumId = "RelPos2D",
				Name = "Relative Position 2D",
				Description = "A two-dimensional position, using X=Width and Y=Height. A position is relative to the Artifact's dimensions. For example, X=0.25 represents a position (starting from the origin) that is 25% of the distance to the maximum X dimension.",
				MinX = -1.79769313486231e+308,
				MaxX = 1.79769313486231e+308,
				MinY = -1.79769313486231e+308,
				MaxY = 1.79769313486231e+308,
				MinZ = 0,
				MaxZ = 0,
			});

			LocatorTypeMap.Add(6, new LocatorType {
				Id = 6,
				EnumId = "RelPos3D",
				Name = "Relative Position 3D",
				Description = "A three-dimensional position, using X, Y, and Z axes. A position is relative to the Artifact's dimensions. For example, X=0.25 represents a position (starting from the origin) that is 25% of the distance to the maximum X dimension.",
				MinX = -1.79769313486231e+308,
				MaxX = 1.79769313486231e+308,
				MinY = -1.79769313486231e+308,
				MaxY = 1.79769313486231e+308,
				MinZ = -1.79769313486231e+308,
				MaxZ = 1.79769313486231e+308,
			});
		}

		/*--------------------------------------------------------------------------------------------*/
		private static void BuildMemberTypeMap() {
			MemberTypeMap = new Dictionary<byte, MemberType>();

			MemberTypeMap.Add(1, new MemberType {
				Id = 1,
				EnumId = "None",
				Name = "None",
				Description = "The User is not associated with this App.",
			});

			MemberTypeMap.Add(2, new MemberType {
				Id = 2,
				EnumId = "Request",
				Name = "Request",
				Description = "The user would like to become a member of this App.",
			});

			MemberTypeMap.Add(3, new MemberType {
				Id = 3,
				EnumId = "Invite",
				Name = "Invite",
				Description = "The User has been invited to become a member of this App.",
			});

			MemberTypeMap.Add(4, new MemberType {
				Id = 4,
				EnumId = "Member",
				Name = "Member",
				Description = "The User is a member of this App.",
			});

			MemberTypeMap.Add(5, new MemberType {
				Id = 5,
				EnumId = "Staff",
				Name = "Staff",
				Description = "The User is a staff member of this App.",
			});

			MemberTypeMap.Add(6, new MemberType {
				Id = 6,
				EnumId = "Admin",
				Name = "Admin",
				Description = "The User is an administrator of this App.",
			});

			MemberTypeMap.Add(7, new MemberType {
				Id = 7,
				EnumId = "Owner",
				Name = "Owner",
				Description = "The User owns this App.",
			});

			MemberTypeMap.Add(8, new MemberType {
				Id = 8,
				EnumId = "DataProv",
				Name = "Data Provider",
				Description = "The User has a special membership that allows it to interact with Fabric on behalf of the App.",
			});
		}

		/*--------------------------------------------------------------------------------------------*/
		private static void BuildVectorRangeMap() {
			VectorRangeMap = new Dictionary<byte, VectorRange>();

			VectorRangeMap.Add(1, new VectorRange {
				Id = 1,
				EnumId = "FullNum",
				Name = "Full Numeric",
				Levels = new[] {
					VectorRangeLevelMap[(byte)VectorRangeLevelId.Min0],
					VectorRangeLevelMap[(byte)VectorRangeLevelId.Zero05],
					VectorRangeLevelMap[(byte)VectorRangeLevelId.Max1],
				},
			});

			VectorRangeMap.Add(2, new VectorRange {
				Id = 2,
				EnumId = "PosNum",
				Name = "Positive Numeric",
				Levels = new[] {
					VectorRangeLevelMap[(byte)VectorRangeLevelId.Zero0],
					VectorRangeLevelMap[(byte)VectorRangeLevelId.Max1],
				},
			});

			VectorRangeMap.Add(3, new VectorRange {
				Id = 3,
				EnumId = "NegNum",
				Name = "Negative Numeric",
				Levels = new[] {
					VectorRangeLevelMap[(byte)VectorRangeLevelId.Min0],
					VectorRangeLevelMap[(byte)VectorRangeLevelId.Zero1],
				},
			});

			VectorRangeMap.Add(4, new VectorRange {
				Id = 4,
				EnumId = "FullAgree",
				Name = "Full Agreement",
				Levels = new[] {
					VectorRangeLevelMap[(byte)VectorRangeLevelId.CompDisagree],
					VectorRangeLevelMap[(byte)VectorRangeLevelId.MostDisagree],
					VectorRangeLevelMap[(byte)VectorRangeLevelId.SomeDisagree],
					VectorRangeLevelMap[(byte)VectorRangeLevelId.NoOpinion05],
					VectorRangeLevelMap[(byte)VectorRangeLevelId.SomeAgree],
					VectorRangeLevelMap[(byte)VectorRangeLevelId.MostAgree],
					VectorRangeLevelMap[(byte)VectorRangeLevelId.CompAgree],
				},
			});

			VectorRangeMap.Add(5, new VectorRange {
				Id = 5,
				EnumId = "PosAgree",
				Name = "Positive Agreement",
				Levels = new[] {
					VectorRangeLevelMap[(byte)VectorRangeLevelId.NoOpinion0],
					VectorRangeLevelMap[(byte)VectorRangeLevelId.SomeAgreePos],
					VectorRangeLevelMap[(byte)VectorRangeLevelId.MostAgreePos],
					VectorRangeLevelMap[(byte)VectorRangeLevelId.CompAgreePos],
				},
			});

			VectorRangeMap.Add(6, new VectorRange {
				Id = 6,
				EnumId = "FullFavor",
				Name = "Full Favorability",
				Levels = new[] {
					VectorRangeLevelMap[(byte)VectorRangeLevelId.CompUnfavor],
					VectorRangeLevelMap[(byte)VectorRangeLevelId.MostUnfavor],
					VectorRangeLevelMap[(byte)VectorRangeLevelId.SomeUnfavor],
					VectorRangeLevelMap[(byte)VectorRangeLevelId.NoOpinion05],
					VectorRangeLevelMap[(byte)VectorRangeLevelId.SomeFavor],
					VectorRangeLevelMap[(byte)VectorRangeLevelId.MostFavor],
					VectorRangeLevelMap[(byte)VectorRangeLevelId.CompFavor],
				},
			});

			VectorRangeMap.Add(7, new VectorRange {
				Id = 7,
				EnumId = "PosFavor",
				Name = "Positive Favorability",
				Levels = new[] {
					VectorRangeLevelMap[(byte)VectorRangeLevelId.NoOpinion0],
					VectorRangeLevelMap[(byte)VectorRangeLevelId.SomeFavorPos],
					VectorRangeLevelMap[(byte)VectorRangeLevelId.MostFavorPos],
					VectorRangeLevelMap[(byte)VectorRangeLevelId.CompFavorPos],
				},
			});
		}

		/*--------------------------------------------------------------------------------------------*/
		private static void BuildVectorRangeLevelMap() {
			VectorRangeLevelMap = new Dictionary<byte, VectorRangeLevel>();

			VectorRangeLevelMap.Add(1, new VectorRangeLevel {
				Id = 1,
				EnumId = "Zero0",
				Name = "Zero",
				Position = 0f,
			});

			VectorRangeLevelMap.Add(2, new VectorRangeLevel {
				Id = 2,
				EnumId = "Zero05",
				Name = "Zero",
				Position = 0.5f,
			});

			VectorRangeLevelMap.Add(3, new VectorRangeLevel {
				Id = 3,
				EnumId = "Zero1",
				Name = "Zero",
				Position = 1f,
			});

			VectorRangeLevelMap.Add(4, new VectorRangeLevel {
				Id = 4,
				EnumId = "Min0",
				Name = "Minimum",
				Position = 0f,
			});

			VectorRangeLevelMap.Add(5, new VectorRangeLevel {
				Id = 5,
				EnumId = "Max1",
				Name = "Maximum",
				Position = 1f,
			});

			VectorRangeLevelMap.Add(6, new VectorRangeLevel {
				Id = 6,
				EnumId = "CompDisagree",
				Name = "Completely Disagree",
				Position = 0f,
			});

			VectorRangeLevelMap.Add(7, new VectorRangeLevel {
				Id = 7,
				EnumId = "MostDisagree",
				Name = "Mostly Disagree",
				Position = 0.1666667f,
			});

			VectorRangeLevelMap.Add(8, new VectorRangeLevel {
				Id = 8,
				EnumId = "SomeDisagree",
				Name = "Somewhat Disagree",
				Position = 0.3333333f,
			});

			VectorRangeLevelMap.Add(9, new VectorRangeLevel {
				Id = 9,
				EnumId = "NoOpinion05",
				Name = "No Opinion",
				Position = 0.5f,
			});

			VectorRangeLevelMap.Add(10, new VectorRangeLevel {
				Id = 10,
				EnumId = "SomeAgree",
				Name = "Somewhat Agree",
				Position = 0.6666667f,
			});

			VectorRangeLevelMap.Add(11, new VectorRangeLevel {
				Id = 11,
				EnumId = "MostAgree",
				Name = "Mostly Agree",
				Position = 0.8333333f,
			});

			VectorRangeLevelMap.Add(12, new VectorRangeLevel {
				Id = 12,
				EnumId = "CompAgree",
				Name = "Completely Agree",
				Position = 1f,
			});

			VectorRangeLevelMap.Add(13, new VectorRangeLevel {
				Id = 13,
				EnumId = "NoOpinion0",
				Name = "No Opinion",
				Position = 0f,
			});

			VectorRangeLevelMap.Add(14, new VectorRangeLevel {
				Id = 14,
				EnumId = "SomeAgreePos",
				Name = "Somewhat Agree",
				Position = 0.3333333f,
			});

			VectorRangeLevelMap.Add(15, new VectorRangeLevel {
				Id = 15,
				EnumId = "MostAgreePos",
				Name = "Mostly Agree",
				Position = 0.6666667f,
			});

			VectorRangeLevelMap.Add(16, new VectorRangeLevel {
				Id = 16,
				EnumId = "CompAgreePos",
				Name = "Completely Agree",
				Position = 1f,
			});

			VectorRangeLevelMap.Add(17, new VectorRangeLevel {
				Id = 17,
				EnumId = "CompUnfavor",
				Name = "Completely Unfavorable",
				Position = 0f,
			});

			VectorRangeLevelMap.Add(18, new VectorRangeLevel {
				Id = 18,
				EnumId = "MostUnfavor",
				Name = "Mostly Unfavorable",
				Position = 0.1666667f,
			});

			VectorRangeLevelMap.Add(19, new VectorRangeLevel {
				Id = 19,
				EnumId = "SomeUnfavor",
				Name = "Somewhat Unfavorable",
				Position = 0.3333333f,
			});

			VectorRangeLevelMap.Add(20, new VectorRangeLevel {
				Id = 20,
				EnumId = "SomeFavor",
				Name = "Somewhat Favorable",
				Position = 0.6666667f,
			});

			VectorRangeLevelMap.Add(21, new VectorRangeLevel {
				Id = 21,
				EnumId = "MostFavor",
				Name = "Mostly Favorable",
				Position = 0.8333333f,
			});

			VectorRangeLevelMap.Add(22, new VectorRangeLevel {
				Id = 22,
				EnumId = "CompFavor",
				Name = "Completely Favorable",
				Position = 1f,
			});

			VectorRangeLevelMap.Add(23, new VectorRangeLevel {
				Id = 23,
				EnumId = "SomeFavorPos",
				Name = "Somewhat Favorable",
				Position = 0.3333333f,
			});

			VectorRangeLevelMap.Add(24, new VectorRangeLevel {
				Id = 24,
				EnumId = "MostFavorPos",
				Name = "Mostly Favorable",
				Position = 0.6666667f,
			});

			VectorRangeLevelMap.Add(25, new VectorRangeLevel {
				Id = 25,
				EnumId = "CompFavorPos",
				Name = "Completely Favorable",
				Position = 1f,
			});
		}

		/*--------------------------------------------------------------------------------------------*/
		private static void BuildVectorTypeMap() {
			VectorTypeMap = new Dictionary<byte, VectorType>();

			VectorTypeMap.Add(1, new VectorType {
				Id = 1,
				EnumId = "FullLong",
				Name = "Full Bounds",
				VectorRange = VectorRangeMap[(byte)VectorRangeId.FullNum],
				Min = -9223372036854775808,
				Max = 9223372036854775807,
			});

			VectorTypeMap.Add(2, new VectorType {
				Id = 2,
				EnumId = "PosLong",
				Name = "Positive Bounds",
				VectorRange = VectorRangeMap[(byte)VectorRangeId.PosNum],
				Min = 0,
				Max = 9223372036854775807,
			});

			VectorTypeMap.Add(3, new VectorType {
				Id = 3,
				EnumId = "NegLong",
				Name = "Negative Bounds",
				VectorRange = VectorRangeMap[(byte)VectorRangeId.NegNum],
				Min = -9223372036854775808,
				Max = 0,
			});

			VectorTypeMap.Add(4, new VectorType {
				Id = 4,
				EnumId = "FullPerc",
				Name = "Full Percentage",
				VectorRange = VectorRangeMap[(byte)VectorRangeId.FullNum],
				Min = -9223372036854775808,
				Max = 9223372036854775807,
			});

			VectorTypeMap.Add(5, new VectorType {
				Id = 5,
				EnumId = "StdPerc",
				Name = "Standard Percentage",
				VectorRange = VectorRangeMap[(byte)VectorRangeId.PosNum],
				Min = 0,
				Max = 100,
			});

			VectorTypeMap.Add(6, new VectorType {
				Id = 6,
				EnumId = "OppPerc",
				Name = "Opposable Percentage",
				VectorRange = VectorRangeMap[(byte)VectorRangeId.FullNum],
				Min = -100,
				Max = 100,
			});

			VectorTypeMap.Add(7, new VectorType {
				Id = 7,
				EnumId = "StdAgree",
				Name = "Standard Agreement",
				VectorRange = VectorRangeMap[(byte)VectorRangeId.PosAgree],
				Min = 0,
				Max = 100,
			});

			VectorTypeMap.Add(8, new VectorType {
				Id = 8,
				EnumId = "OppAgree",
				Name = "Opposable Agreement",
				VectorRange = VectorRangeMap[(byte)VectorRangeId.FullAgree],
				Min = -100,
				Max = 100,
			});

			VectorTypeMap.Add(9, new VectorType {
				Id = 9,
				EnumId = "StdFavor",
				Name = "Standard Favorability",
				VectorRange = VectorRangeMap[(byte)VectorRangeId.PosFavor],
				Min = 0,
				Max = 100,
			});

			VectorTypeMap.Add(10, new VectorType {
				Id = 10,
				EnumId = "OppFavor",
				Name = "Opposable Favorability",
				VectorRange = VectorRangeMap[(byte)VectorRangeId.FullFavor],
				Min = -100,
				Max = 100,
			});
		}

		/*--------------------------------------------------------------------------------------------*/
		private static void BuildVectorUnitMap() {
			VectorUnitMap = new Dictionary<byte, VectorUnit>();

			VectorUnitMap.Add(1, new VectorUnit {
				Id = 1,
				EnumId = "None",
				Name = "None",
			});

			VectorUnitMap.Add(2, new VectorUnit {
				Id = 2,
				EnumId = "Unit",
				Name = "Unit",
			});

			VectorUnitMap.Add(3, new VectorUnit {
				Id = 3,
				EnumId = "Metre",
				Name = "Metre",
				Description = "m",
			});

			VectorUnitMap.Add(4, new VectorUnit {
				Id = 4,
				EnumId = "Gram",
				Name = "Gram",
				Description = "g",
			});

			VectorUnitMap.Add(5, new VectorUnit {
				Id = 5,
				EnumId = "Second",
				Name = "Second",
				Description = "s",
			});

			VectorUnitMap.Add(6, new VectorUnit {
				Id = 6,
				EnumId = "Ampere",
				Name = "Ampere",
				Description = "A",
			});

			VectorUnitMap.Add(7, new VectorUnit {
				Id = 7,
				EnumId = "Celsius",
				Name = "Celsius",
				Description = "C",
			});

			VectorUnitMap.Add(8, new VectorUnit {
				Id = 8,
				EnumId = "Candela",
				Name = "Candela",
				Description = "cd",
			});

			VectorUnitMap.Add(9, new VectorUnit {
				Id = 9,
				EnumId = "Mole",
				Name = "Mole",
				Description = "mol",
			});

			VectorUnitMap.Add(10, new VectorUnit {
				Id = 10,
				EnumId = "Bit",
				Name = "Bit",
				Description = "b",
			});

			VectorUnitMap.Add(11, new VectorUnit {
				Id = 11,
				EnumId = "Byte",
				Name = "Byte",
				Description = "B",
			});

			VectorUnitMap.Add(12, new VectorUnit {
				Id = 12,
				EnumId = "Hertz",
				Name = "Hertz",
				Description = "Hz",
			});

			VectorUnitMap.Add(13, new VectorUnit {
				Id = 13,
				EnumId = "Radian",
				Name = "Radian",
				Description = "rad",
			});

			VectorUnitMap.Add(14, new VectorUnit {
				Id = 14,
				EnumId = "Newton",
				Name = "Newton",
				Description = "N",
			});

			VectorUnitMap.Add(15, new VectorUnit {
				Id = 15,
				EnumId = "Pascal",
				Name = "Pascal",
				Description = "Pa",
			});

			VectorUnitMap.Add(16, new VectorUnit {
				Id = 16,
				EnumId = "Joule",
				Name = "Joule",
				Description = "J",
			});

			VectorUnitMap.Add(17, new VectorUnit {
				Id = 17,
				EnumId = "Watt",
				Name = "Watt",
				Description = "W",
			});

			VectorUnitMap.Add(18, new VectorUnit {
				Id = 18,
				EnumId = "Volt",
				Name = "Volt",
				Description = "V",
			});

			VectorUnitMap.Add(19, new VectorUnit {
				Id = 19,
				EnumId = "Ohm",
				Name = "Ohm",
				Description = "Ω",
			});

			VectorUnitMap.Add(20, new VectorUnit {
				Id = 20,
				EnumId = "Area",
				Name = "Area",
				Description = "m^2",
			});

			VectorUnitMap.Add(21, new VectorUnit {
				Id = 21,
				EnumId = "Volume",
				Name = "Volume",
				Description = "m^3",
			});

			VectorUnitMap.Add(22, new VectorUnit {
				Id = 22,
				EnumId = "Speed",
				Name = "Speed",
				Description = "m/s",
			});

			VectorUnitMap.Add(23, new VectorUnit {
				Id = 23,
				EnumId = "Acceleration",
				Name = "Acceleration",
				Description = "m^3/s",
			});

			VectorUnitMap.Add(24, new VectorUnit {
				Id = 24,
				EnumId = "Point",
				Name = "Point",
				Description = "pt",
			});

			VectorUnitMap.Add(25, new VectorUnit {
				Id = 25,
				EnumId = "Item",
				Name = "Item",
				Description = "item",
			});

			VectorUnitMap.Add(26, new VectorUnit {
				Id = 26,
				EnumId = "Person",
				Name = "Person",
				Description = "person",
			});

			VectorUnitMap.Add(27, new VectorUnit {
				Id = 27,
				EnumId = "Percent",
				Name = "Percent",
				Description = "%",
			});

			VectorUnitMap.Add(28, new VectorUnit {
				Id = 28,
				EnumId = "Index",
				Name = "Index",
				Description = "index",
			});

			VectorUnitMap.Add(29, new VectorUnit {
				Id = 29,
				EnumId = "Pixel",
				Name = "Pixel",
				Description = "pixel",
			});
		}

		/*--------------------------------------------------------------------------------------------*/
		private static void BuildVectorUnitDerivedMap() {
			VectorUnitDerivedMap = new Dictionary<byte, VectorUnitDerived>();

			VectorUnitDerivedMap.Add(1, new VectorUnitDerived {
				Id = 1,
				EnumId = "HertzSec",
				DefinesVectorUnit = VectorUnitMap[(byte)VectorUnitId.Hertz],
				RaisesVectorUnit = VectorUnitMap[(byte)VectorUnitId.Second],
				WithExponent = -1,
				RaisesVectorUnitPrefix = VectorUnitPrefixMap[(byte)VectorUnitPrefixId.Base],
			});

			VectorUnitDerivedMap.Add(2, new VectorUnitDerived {
				Id = 2,
				EnumId = "NewtonGram",
				DefinesVectorUnit = VectorUnitMap[(byte)VectorUnitId.Newton],
				RaisesVectorUnit = VectorUnitMap[(byte)VectorUnitId.Gram],
				WithExponent = 1,
				RaisesVectorUnitPrefix = VectorUnitPrefixMap[(byte)VectorUnitPrefixId.Kilo],
			});

			VectorUnitDerivedMap.Add(3, new VectorUnitDerived {
				Id = 3,
				EnumId = "NewtonMetre",
				DefinesVectorUnit = VectorUnitMap[(byte)VectorUnitId.Newton],
				RaisesVectorUnit = VectorUnitMap[(byte)VectorUnitId.Metre],
				WithExponent = 1,
				RaisesVectorUnitPrefix = VectorUnitPrefixMap[(byte)VectorUnitPrefixId.Base],
			});

			VectorUnitDerivedMap.Add(4, new VectorUnitDerived {
				Id = 4,
				EnumId = "NewtonSec",
				DefinesVectorUnit = VectorUnitMap[(byte)VectorUnitId.Newton],
				RaisesVectorUnit = VectorUnitMap[(byte)VectorUnitId.Second],
				WithExponent = -2,
				RaisesVectorUnitPrefix = VectorUnitPrefixMap[(byte)VectorUnitPrefixId.Base],
			});

			VectorUnitDerivedMap.Add(5, new VectorUnitDerived {
				Id = 5,
				EnumId = "PascalGram",
				DefinesVectorUnit = VectorUnitMap[(byte)VectorUnitId.Pascal],
				RaisesVectorUnit = VectorUnitMap[(byte)VectorUnitId.Gram],
				WithExponent = 1,
				RaisesVectorUnitPrefix = VectorUnitPrefixMap[(byte)VectorUnitPrefixId.Kilo],
			});

			VectorUnitDerivedMap.Add(6, new VectorUnitDerived {
				Id = 6,
				EnumId = "PascalMetre",
				DefinesVectorUnit = VectorUnitMap[(byte)VectorUnitId.Pascal],
				RaisesVectorUnit = VectorUnitMap[(byte)VectorUnitId.Metre],
				WithExponent = -1,
				RaisesVectorUnitPrefix = VectorUnitPrefixMap[(byte)VectorUnitPrefixId.Base],
			});

			VectorUnitDerivedMap.Add(7, new VectorUnitDerived {
				Id = 7,
				EnumId = "PascalSec",
				DefinesVectorUnit = VectorUnitMap[(byte)VectorUnitId.Pascal],
				RaisesVectorUnit = VectorUnitMap[(byte)VectorUnitId.Second],
				WithExponent = -2,
				RaisesVectorUnitPrefix = VectorUnitPrefixMap[(byte)VectorUnitPrefixId.Base],
			});

			VectorUnitDerivedMap.Add(8, new VectorUnitDerived {
				Id = 8,
				EnumId = "JouleGram",
				DefinesVectorUnit = VectorUnitMap[(byte)VectorUnitId.Joule],
				RaisesVectorUnit = VectorUnitMap[(byte)VectorUnitId.Gram],
				WithExponent = 1,
				RaisesVectorUnitPrefix = VectorUnitPrefixMap[(byte)VectorUnitPrefixId.Kilo],
			});

			VectorUnitDerivedMap.Add(9, new VectorUnitDerived {
				Id = 9,
				EnumId = "JouleMetre",
				DefinesVectorUnit = VectorUnitMap[(byte)VectorUnitId.Joule],
				RaisesVectorUnit = VectorUnitMap[(byte)VectorUnitId.Metre],
				WithExponent = 2,
				RaisesVectorUnitPrefix = VectorUnitPrefixMap[(byte)VectorUnitPrefixId.Base],
			});

			VectorUnitDerivedMap.Add(10, new VectorUnitDerived {
				Id = 10,
				EnumId = "JouleSec",
				DefinesVectorUnit = VectorUnitMap[(byte)VectorUnitId.Joule],
				RaisesVectorUnit = VectorUnitMap[(byte)VectorUnitId.Second],
				WithExponent = -2,
				RaisesVectorUnitPrefix = VectorUnitPrefixMap[(byte)VectorUnitPrefixId.Base],
			});

			VectorUnitDerivedMap.Add(11, new VectorUnitDerived {
				Id = 11,
				EnumId = "WattGram",
				DefinesVectorUnit = VectorUnitMap[(byte)VectorUnitId.Watt],
				RaisesVectorUnit = VectorUnitMap[(byte)VectorUnitId.Gram],
				WithExponent = 1,
				RaisesVectorUnitPrefix = VectorUnitPrefixMap[(byte)VectorUnitPrefixId.Kilo],
			});

			VectorUnitDerivedMap.Add(12, new VectorUnitDerived {
				Id = 12,
				EnumId = "WattMetre",
				DefinesVectorUnit = VectorUnitMap[(byte)VectorUnitId.Watt],
				RaisesVectorUnit = VectorUnitMap[(byte)VectorUnitId.Metre],
				WithExponent = 2,
				RaisesVectorUnitPrefix = VectorUnitPrefixMap[(byte)VectorUnitPrefixId.Base],
			});

			VectorUnitDerivedMap.Add(13, new VectorUnitDerived {
				Id = 13,
				EnumId = "WattSec",
				DefinesVectorUnit = VectorUnitMap[(byte)VectorUnitId.Watt],
				RaisesVectorUnit = VectorUnitMap[(byte)VectorUnitId.Second],
				WithExponent = -3,
				RaisesVectorUnitPrefix = VectorUnitPrefixMap[(byte)VectorUnitPrefixId.Base],
			});

			VectorUnitDerivedMap.Add(14, new VectorUnitDerived {
				Id = 14,
				EnumId = "VoltGram",
				DefinesVectorUnit = VectorUnitMap[(byte)VectorUnitId.Volt],
				RaisesVectorUnit = VectorUnitMap[(byte)VectorUnitId.Gram],
				WithExponent = 1,
				RaisesVectorUnitPrefix = VectorUnitPrefixMap[(byte)VectorUnitPrefixId.Kilo],
			});

			VectorUnitDerivedMap.Add(15, new VectorUnitDerived {
				Id = 15,
				EnumId = "VoltMetre",
				DefinesVectorUnit = VectorUnitMap[(byte)VectorUnitId.Volt],
				RaisesVectorUnit = VectorUnitMap[(byte)VectorUnitId.Metre],
				WithExponent = 2,
				RaisesVectorUnitPrefix = VectorUnitPrefixMap[(byte)VectorUnitPrefixId.Base],
			});

			VectorUnitDerivedMap.Add(16, new VectorUnitDerived {
				Id = 16,
				EnumId = "VoltSec",
				DefinesVectorUnit = VectorUnitMap[(byte)VectorUnitId.Volt],
				RaisesVectorUnit = VectorUnitMap[(byte)VectorUnitId.Second],
				WithExponent = -3,
				RaisesVectorUnitPrefix = VectorUnitPrefixMap[(byte)VectorUnitPrefixId.Base],
			});

			VectorUnitDerivedMap.Add(17, new VectorUnitDerived {
				Id = 17,
				EnumId = "VoltAmp",
				DefinesVectorUnit = VectorUnitMap[(byte)VectorUnitId.Volt],
				RaisesVectorUnit = VectorUnitMap[(byte)VectorUnitId.Ampere],
				WithExponent = -1,
				RaisesVectorUnitPrefix = VectorUnitPrefixMap[(byte)VectorUnitPrefixId.Base],
			});

			VectorUnitDerivedMap.Add(18, new VectorUnitDerived {
				Id = 18,
				EnumId = "OhmGram",
				DefinesVectorUnit = VectorUnitMap[(byte)VectorUnitId.Ohm],
				RaisesVectorUnit = VectorUnitMap[(byte)VectorUnitId.Gram],
				WithExponent = 1,
				RaisesVectorUnitPrefix = VectorUnitPrefixMap[(byte)VectorUnitPrefixId.Kilo],
			});

			VectorUnitDerivedMap.Add(19, new VectorUnitDerived {
				Id = 19,
				EnumId = "OhmMetre",
				DefinesVectorUnit = VectorUnitMap[(byte)VectorUnitId.Ohm],
				RaisesVectorUnit = VectorUnitMap[(byte)VectorUnitId.Metre],
				WithExponent = 2,
				RaisesVectorUnitPrefix = VectorUnitPrefixMap[(byte)VectorUnitPrefixId.Base],
			});

			VectorUnitDerivedMap.Add(20, new VectorUnitDerived {
				Id = 20,
				EnumId = "OhmSec",
				DefinesVectorUnit = VectorUnitMap[(byte)VectorUnitId.Ohm],
				RaisesVectorUnit = VectorUnitMap[(byte)VectorUnitId.Second],
				WithExponent = -3,
				RaisesVectorUnitPrefix = VectorUnitPrefixMap[(byte)VectorUnitPrefixId.Base],
			});

			VectorUnitDerivedMap.Add(21, new VectorUnitDerived {
				Id = 21,
				EnumId = "OhmAmp",
				DefinesVectorUnit = VectorUnitMap[(byte)VectorUnitId.Ohm],
				RaisesVectorUnit = VectorUnitMap[(byte)VectorUnitId.Ampere],
				WithExponent = -2,
				RaisesVectorUnitPrefix = VectorUnitPrefixMap[(byte)VectorUnitPrefixId.Base],
			});

			VectorUnitDerivedMap.Add(22, new VectorUnitDerived {
				Id = 22,
				EnumId = "AreaMetre",
				DefinesVectorUnit = VectorUnitMap[(byte)VectorUnitId.Area],
				RaisesVectorUnit = VectorUnitMap[(byte)VectorUnitId.Metre],
				WithExponent = 2,
				RaisesVectorUnitPrefix = VectorUnitPrefixMap[(byte)VectorUnitPrefixId.Base],
			});

			VectorUnitDerivedMap.Add(23, new VectorUnitDerived {
				Id = 23,
				EnumId = "VolumeMetre",
				DefinesVectorUnit = VectorUnitMap[(byte)VectorUnitId.Volume],
				RaisesVectorUnit = VectorUnitMap[(byte)VectorUnitId.Metre],
				WithExponent = 3,
				RaisesVectorUnitPrefix = VectorUnitPrefixMap[(byte)VectorUnitPrefixId.Base],
			});

			VectorUnitDerivedMap.Add(24, new VectorUnitDerived {
				Id = 24,
				EnumId = "SpeedMetre",
				DefinesVectorUnit = VectorUnitMap[(byte)VectorUnitId.Speed],
				RaisesVectorUnit = VectorUnitMap[(byte)VectorUnitId.Metre],
				WithExponent = 1,
				RaisesVectorUnitPrefix = VectorUnitPrefixMap[(byte)VectorUnitPrefixId.Base],
			});

			VectorUnitDerivedMap.Add(25, new VectorUnitDerived {
				Id = 25,
				EnumId = "SpeedSec",
				DefinesVectorUnit = VectorUnitMap[(byte)VectorUnitId.Speed],
				RaisesVectorUnit = VectorUnitMap[(byte)VectorUnitId.Second],
				WithExponent = -1,
				RaisesVectorUnitPrefix = VectorUnitPrefixMap[(byte)VectorUnitPrefixId.Base],
			});

			VectorUnitDerivedMap.Add(26, new VectorUnitDerived {
				Id = 26,
				EnumId = "AccelMetre",
				DefinesVectorUnit = VectorUnitMap[(byte)VectorUnitId.Acceleration],
				RaisesVectorUnit = VectorUnitMap[(byte)VectorUnitId.Metre],
				WithExponent = 1,
				RaisesVectorUnitPrefix = VectorUnitPrefixMap[(byte)VectorUnitPrefixId.Base],
			});

			VectorUnitDerivedMap.Add(27, new VectorUnitDerived {
				Id = 27,
				EnumId = "AccelSec",
				DefinesVectorUnit = VectorUnitMap[(byte)VectorUnitId.Acceleration],
				RaisesVectorUnit = VectorUnitMap[(byte)VectorUnitId.Second],
				WithExponent = -2,
				RaisesVectorUnitPrefix = VectorUnitPrefixMap[(byte)VectorUnitPrefixId.Base],
			});
		}

		/*--------------------------------------------------------------------------------------------*/
		private static void BuildVectorUnitPrefixMap() {
			VectorUnitPrefixMap = new Dictionary<byte, VectorUnitPrefix>();

			VectorUnitPrefixMap.Add(1, new VectorUnitPrefix {
				Id = 1,
				EnumId = "Base",
				Name = "Base",
				Amount = 1,
			});

			VectorUnitPrefixMap.Add(2, new VectorUnitPrefix {
				Id = 2,
				EnumId = "Kilo",
				Name = "Kilo",
				Description = "k",
				Amount = 1000,
			});

			VectorUnitPrefixMap.Add(3, new VectorUnitPrefix {
				Id = 3,
				EnumId = "Mega",
				Name = "Mega",
				Description = "M",
				Amount = 1000000,
			});

			VectorUnitPrefixMap.Add(4, new VectorUnitPrefix {
				Id = 4,
				EnumId = "Giga",
				Name = "Giga",
				Description = "G",
				Amount = 1000000000,
			});

			VectorUnitPrefixMap.Add(5, new VectorUnitPrefix {
				Id = 5,
				EnumId = "Tera",
				Name = "Tera",
				Description = "T",
				Amount = 1000000000000,
			});

			VectorUnitPrefixMap.Add(6, new VectorUnitPrefix {
				Id = 6,
				EnumId = "Peta",
				Name = "Peta",
				Description = "P",
				Amount = 1000000000000000,
			});

			VectorUnitPrefixMap.Add(7, new VectorUnitPrefix {
				Id = 7,
				EnumId = "Exa",
				Name = "Exa",
				Description = "E",
				Amount = 1000000000000000000,
			});

			VectorUnitPrefixMap.Add(8, new VectorUnitPrefix {
				Id = 8,
				EnumId = "Milli",
				Name = "Milli",
				Description = "m",
				Amount = 0.001,
			});

			VectorUnitPrefixMap.Add(9, new VectorUnitPrefix {
				Id = 9,
				EnumId = "Micro",
				Name = "Micro",
				Description = "μ",
				Amount = 0.000001,
			});

			VectorUnitPrefixMap.Add(10, new VectorUnitPrefix {
				Id = 10,
				EnumId = "Nano",
				Name = "Nano",
				Description = "n",
				Amount = 1e-9,
			});

			VectorUnitPrefixMap.Add(11, new VectorUnitPrefix {
				Id = 11,
				EnumId = "Pico",
				Name = "Pico",
				Description = "p",
				Amount = 1e-12,
			});

			VectorUnitPrefixMap.Add(12, new VectorUnitPrefix {
				Id = 12,
				EnumId = "Femto",
				Name = "Femto",
				Description = "f",
				Amount = 1e-15,
			});

			VectorUnitPrefixMap.Add(13, new VectorUnitPrefix {
				Id = 13,
				EnumId = "Atto",
				Name = "Atto",
				Description = "a",
				Amount = 1e-18,
			});

			VectorUnitPrefixMap.Add(14, new VectorUnitPrefix {
				Id = 14,
				EnumId = "Kibi",
				Name = "Kibi",
				Description = "Ki",
				Amount = 1024,
			});

			VectorUnitPrefixMap.Add(15, new VectorUnitPrefix {
				Id = 15,
				EnumId = "Mebi",
				Name = "Mebi",
				Description = "Mi",
				Amount = 1048576,
			});

			VectorUnitPrefixMap.Add(16, new VectorUnitPrefix {
				Id = 16,
				EnumId = "Gibi",
				Name = "Gibi",
				Description = "Gi",
				Amount = 1073741824,
			});

			VectorUnitPrefixMap.Add(17, new VectorUnitPrefix {
				Id = 17,
				EnumId = "Tebi",
				Name = "Tebi",
				Description = "Ti",
				Amount = 1099511627776,
			});

			VectorUnitPrefixMap.Add(18, new VectorUnitPrefix {
				Id = 18,
				EnumId = "Pebi",
				Name = "Pebi",
				Description = "Pi",
				Amount = 1125899906842620,
			});

			VectorUnitPrefixMap.Add(19, new VectorUnitPrefix {
				Id = 19,
				EnumId = "Exbi",
				Name = "Exbi",
				Description = "Ei",
				Amount = 1152921504606850000,
			});
		}

		/*--------------------------------------------------------------------------------------------*/
		private static void BuildVertexTypeMap() {
			VertexTypeMap = new Dictionary<byte, VertexType>();

			VertexTypeMap.Add(1, new VertexType {
				Id = 1,
				EnumId = "Vertex",
				Name = "Vertex",
			});

			VertexTypeMap.Add(2, new VertexType {
				Id = 2,
				EnumId = "App",
				Name = "App",
			});

			VertexTypeMap.Add(3, new VertexType {
				Id = 3,
				EnumId = "Class",
				Name = "Class",
			});

			VertexTypeMap.Add(4, new VertexType {
				Id = 4,
				EnumId = "Instance",
				Name = "Instance",
			});

			VertexTypeMap.Add(5, new VertexType {
				Id = 5,
				EnumId = "Url",
				Name = "Url",
			});

			VertexTypeMap.Add(6, new VertexType {
				Id = 6,
				EnumId = "User",
				Name = "User",
			});

			VertexTypeMap.Add(7, new VertexType {
				Id = 7,
				EnumId = "Member",
				Name = "Member",
			});

			VertexTypeMap.Add(8, new VertexType {
				Id = 8,
				EnumId = "Artifact",
				Name = "Artifact",
			});

			VertexTypeMap.Add(9, new VertexType {
				Id = 9,
				EnumId = "Factor",
				Name = "Factor",
			});

			VertexTypeMap.Add(10, new VertexType {
				Id = 10,
				EnumId = "Email",
				Name = "Email",
			});

			VertexTypeMap.Add(11, new VertexType {
				Id = 11,
				EnumId = "OauthAccess",
				Name = "OauthAccess",
			});
		}


	}

}