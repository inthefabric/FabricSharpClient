// GENERATED CODE
// Changes made to this source file will be overwritten

namespace Fabric.Clients.Cs.Api {

	/*================================================================================================*/
	/// <summary>
	///   Provides meaning (via Descriptor) to the relationship between the two Artifacts in a particular Factor.
	/// </summary>
	/// <remarks>
	///   <para>Provides meaning (via Descriptor) to the relationship between the two Artifacts in a particular Factor.</para>
	/// </remarks>
	public class DescriptorType : EnumObject {
	
	}

	
	/*================================================================================================*/
	/// <summary>
	///   Describes an action to be taken (via Director) on one of the two Artifacts in a particular Factor.
	/// </summary>
	/// <remarks>
	///   <para>Describes an action to be taken (via Director) on one of the two Artifacts in a particular Factor.</para>
	/// </remarks>
	public class DirectorAction : EnumObject {
	
	}

	
	/*================================================================================================*/
	/// <summary>
	///   Provides meaning (via Director) to the directional connection between the two Artifacts in a particular Factor.
	/// </summary>
	/// <remarks>
	///   <para>Provides meaning (via Director) to the directional connection between the two Artifacts in a particular Factor.</para>
	/// </remarks>
	public class DirectorType : EnumObject {
	
	}

	
	/*================================================================================================*/
	/// <summary>
	///   The base class for all Fabric enumerations.
	/// </summary>
	/// <remarks>
	///   <para>The base class for all Fabric enumerations.</para>
	/// </remarks>
	public class EnumObject {
	
		/// <summary>
		///   The numeric identifier for this enumeration item.
		/// </summary>
		public byte Id { get; set; }
		
		/// <summary>
		///   A unique string (with no spaces) that can be used by Fabric clients when creating an enumeration.
		/// </summary>
		public string EnumId { get; set; }
		
		/// <summary>
		///   A descriptive name or title.
		/// </summary>
		public string Name { get; set; }
		
		/// <summary>
		///   A summary of this object's 'sintended meaning or purpose.
		/// </summary>
		public string Description { get; set; }
		
	}

	
	/*================================================================================================*/
	/// <summary>
	///   Provides temporal significance (via Eventor) for a particular Factor.
	/// </summary>
	/// <remarks>
	///   <para>Provides temporal significance (via Eventor) for a particular Factor.</para>
	/// </remarks>
	public class EventorType : EnumObject {
	
	}

	
	/*================================================================================================*/
	/// <summary>
	///   Describes the type of information (and/or level of confidence) provided by a particular Factor.
	/// </summary>
	/// <remarks>
	///   <para>Describes the type of information (and/or level of confidence) provided by a particular Factor.</para>
	/// </remarks>
	public class FactorAssertion : EnumObject {
	
	}

	
	/*================================================================================================*/
	/// <summary>
	///   Provides a hint about the text (via Identor) that identifies a particular Factor.
	/// </summary>
	/// <remarks>
	///   <para>Provides a hint about the text (via Identor) that identifies a particular Factor.</para>
	/// </remarks>
	public class IdentorType : EnumObject {
	
	}

	
	/*================================================================================================*/
	/// <summary>
	///   Provides spatial context and boundaries (via Locator) for a particular Factor.
	/// </summary>
	/// <remarks>
	///   <para>Provides spatial context and boundaries (via Locator) for a particular Factor.</para>
	/// </remarks>
	public class LocatorType : EnumObject {
	
		/// <summary>
		///   The minimum Locator X-coordinate value.
		/// </summary>
		public double MinX { get; set; }
		
		/// <summary>
		///   The maximum Locator X-coordinate value.
		/// </summary>
		public double MaxX { get; set; }
		
		/// <summary>
		///   The minimum Locator Y-coordinate value.
		/// </summary>
		public double MinY { get; set; }
		
		/// <summary>
		///   The maximum Locator Y-coordinate value.
		/// </summary>
		public double MaxY { get; set; }
		
		/// <summary>
		///   The minimum Locator Z-coordinate value.
		/// </summary>
		public double MinZ { get; set; }
		
		/// <summary>
		///   The maximum Locator Z-coordinate value.
		/// </summary>
		public double MaxZ { get; set; }
		
	}

	
	/*================================================================================================*/
	/// <summary>
	///   Describes the level of access and control given to a particular Member.
	/// </summary>
	/// <remarks>
	///   <para>Describes the level of access and control given to a particular Member.</para>
	/// </remarks>
	public class MemberType : EnumObject {
	
	}

	
	/*================================================================================================*/
	/// <summary>
	///   Provides meaning (using relatively-positioned points/labels) across the numerical range of a particular VectorType.
	/// </summary>
	/// <remarks>
	///   <para>Provides meaning (using relatively-positioned points/labels) across the numerical range of a particular VectorType.</para>
	/// </remarks>
	public class VectorRange : EnumObject {
	
		/// <summary>
		///   The set of points/labels that describe a numerical range.
		/// </summary>
		public VectorRangeLevel[] Levels { get; set; }
		
	}

	
	/*================================================================================================*/
	/// <summary>
	///   A relatively-positioned point which provides meaning to a numerical range.
	/// </summary>
	/// <remarks>
	///   <para>A relatively-positioned point which provides meaning to a numerical range.</para>
	/// </remarks>
	public class VectorRangeLevel : EnumObject {
	
		/// <summary>
		///   A value (between 0.0 and 1.0) which defines the relative position between a numeric range's 'sminimum and maximum boundaries.
		/// </summary>
		public float Position { get; set; }
		
	}

	
	/*================================================================================================*/
	/// <summary>
	///   Provides meaning and boundaries (via Vector) for a numeric value given to a particular Factor.
	/// </summary>
	/// <remarks>
	///   <para>Provides meaning and boundaries (via Vector) for a numeric value given to a particular Factor.</para>
	/// </remarks>
	public class VectorType : EnumObject {
	
		/// <summary>
		///   Specifies a meaningful points/labels mapped to the numerical range.
		/// </summary>
		public VectorRange VectorRange { get; set; }
		
		/// <summary>
		///   The minimum Vector value allowed.
		/// </summary>
		public long Min { get; set; }
		
		/// <summary>
		///   The maximum Vector value allowed.
		/// </summary>
		public long Max { get; set; }
		
	}

	
	/*================================================================================================*/
	/// <summary>
	///   Provides a unit of measurement for the numeric value of a particular Vector.
	/// </summary>
	/// <remarks>
	///   <para>Provides a unit of measurement for the numeric value of a particular Vector.</para>
	/// </remarks>
	public class VectorUnit : EnumObject {
	
	}

	
	/*================================================================================================*/
	/// <summary>
	///   Provides conversion formulas from the "derived" VectorUnit to one or more "raises" VectorUnits.
	/// </summary>
	/// <remarks>
	///   <para>Provides conversion formulas from the "derived" VectorUnit to one or more "raises" VectorUnits. Each "raises" unit receives a VectorUnitPrefix and an exponent value.</para>
	/// </remarks>
	public class VectorUnitDerived : EnumObject {
	
		/// <summary>
		///   One or more VectorUnitDerived items are used to represent a conversion into this particular VectorUnit.
		/// </summary>
		public VectorUnit DefinesVectorUnit { get; set; }
		
		/// <summary>
		///   The VectorUnit for this particular item.
		/// </summary>
		public VectorUnit RaisesVectorUnit { get; set; }
		
		/// <summary>
		///   The exponent that affects the "raises" unit.
		/// </summary>
		public int WithExponent { get; set; }
		
		/// <summary>
		///   The VectorUnitPrefix that affects the "raises" unit.
		/// </summary>
		public VectorUnitPrefix RaisesVectorUnitPrefix { get; set; }
		
	}

	
	/*================================================================================================*/
	/// <summary>
	///   Provides a level of magnitude for the numeric value of a particular Vector.
	/// </summary>
	/// <remarks>
	///   <para>Provides a level of magnitude for the numeric value of a particular Vector.</para>
	/// </remarks>
	public class VectorUnitPrefix : EnumObject {
	
		/// <summary>
		///   The difference in magnitude (a multipler) relative to the base unit.
		/// </summary>
		public double Amount { get; set; }
		
	}

	
	/*================================================================================================*/
	/// <summary>
	///   Provides the specific type of a particular Vertex.
	/// </summary>
	/// <remarks>
	///   <para>Provides the specific type of a particular Vertex.</para>
	/// </remarks>
	public class VertexType : EnumObject {
	
	}

	
}