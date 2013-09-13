// GENERATED CODE
// Changes made to this source file will be overwritten
// Generated on 9/13/2013 4:41:05 PM

namespace Fabric.Clients.Cs.Api {

	/*================================================================================================*/
	/// <summary>
	///   The base class for all Fabric enumerations.
	/// </summary>
	/// <remarks>
	///   <para>The base class for all Fabric enumerations.</para>
	/// </remarks>
	public class BaseEnum {
	
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
		///   A summary of this object's intended meaning or purpose.
		/// </summary>
		public string Description { get; set; }
		
	}

	
	/*================================================================================================*/
	/// <summary>
	///   Describes the level of access and control given to a particular Member.
	/// </summary>
	/// <remarks>
	///   <para>Describes the level of access and control given to a particular Member.</para>
	/// </remarks>
	public class MemberType : BaseEnum {
	
	}

	
	/*================================================================================================*/
	/// <summary>
	///   Provides meaning (via Descriptor) to the relationship between the two Artifacts in a particular Factor.
	/// </summary>
	/// <remarks>
	///   <para>Provides meaning (via Descriptor) to the relationship between the two Artifacts in a particular Factor.</para>
	/// </remarks>
	public class DescriptorType : BaseEnum {
	
	}

	
	/*================================================================================================*/
	/// <summary>
	///   Provides meaning (via Director) to the directional connection between the two Artifacts in a particular Factor.
	/// </summary>
	/// <remarks>
	///   <para>Provides meaning (via Director) to the directional connection between the two Artifacts in a particular Factor.</para>
	/// </remarks>
	public class DirectorType : BaseEnum {
	
	}

	
	/*================================================================================================*/
	/// <summary>
	///   Describes an action to be taken (via Director) on one of the two Artifacts in a particular Factor.
	/// </summary>
	/// <remarks>
	///   <para>Describes an action to be taken (via Director) on one of the two Artifacts in a particular Factor.</para>
	/// </remarks>
	public class DirectorAction : BaseEnum {
	
	}

	
	/*================================================================================================*/
	/// <summary>
	///   Describes the level of date/time precision (via Eventor) given to a particular Factor.
	/// </summary>
	/// <remarks>
	///   <para>Describes the level of date/time precision (via Eventor) given to a particular Factor.</para>
	/// </remarks>
	public class EventorPrecision : BaseEnum {
	
	}

	
	/*================================================================================================*/
	/// <summary>
	///   Provides temporal significance (via Eventor) for a particular Factor.
	/// </summary>
	/// <remarks>
	///   <para>Provides temporal significance (via Eventor) for a particular Factor.</para>
	/// </remarks>
	public class EventorType : BaseEnum {
	
	}

	
	/*================================================================================================*/
	/// <summary>
	///   Describes the type of information (and/or level of confidence) provided by a particular Factor.
	/// </summary>
	/// <remarks>
	///   <para>Describes the type of information (and/or level of confidence) provided by a particular Factor.</para>
	/// </remarks>
	public class FactorAssertion : BaseEnum {
	
	}

	
	/*================================================================================================*/
	/// <summary>
	///   Provides a hint about the text (via Identor) that identifies a particular Factor.
	/// </summary>
	/// <remarks>
	///   <para>Provides a hint about the text (via Identor) that identifies a particular Factor.</para>
	/// </remarks>
	public class IdentorType : BaseEnum {
	
	}

	
	/*================================================================================================*/
	/// <summary>
	///   Provides spatial context and boundaries (via Locator) for a particular Factor.
	/// </summary>
	/// <remarks>
	///   <para>Provides spatial context and boundaries (via Locator) for a particular Factor.</para>
	/// </remarks>
	public class LocatorType : BaseEnum {
	
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
	///   Provides meaning and boundaries (via Vector) for a numeric value given to a particular Factor.
	/// </summary>
	/// <remarks>
	///   <para>Provides meaning and boundaries (via Vector) for a numeric value given to a particular Factor.</para>
	/// </remarks>
	public class VectorType : BaseEnum {
	
		/// <summary>
		///   Specifies a meaningful points/labels mapped to the numerical range.
		/// </summary>
		public byte VectorRangeId { get; set; }
		
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
	///   A relatively-positioned point which provides meaning to a numerical range.
	/// </summary>
	/// <remarks>
	///   <para>A relatively-positioned point which provides meaning to a numerical range.</para>
	/// </remarks>
	public class VectorRangeLevel : BaseEnum {
	
		/// <summary>
		///   A value (between 0.0 and 1.0) which defines the relative position between a numeric range's minimum and maximum boundaries.
		/// </summary>
		public float Position { get; set; }
		
	}

	
	/*================================================================================================*/
	/// <summary>
	///   Provides meaning (using relatively-positioned points/labels) across the numerical range of a particular VectorType.
	/// </summary>
	/// <remarks>
	///   <para>Provides meaning (using relatively-positioned points/labels) across the numerical range of a particular VectorType.</para>
	/// </remarks>
	public class VectorRange : BaseEnum {
	
		/// <summary>
		///   The set of points/labels that describe a numerical range.
		/// </summary>
		public byte[] VectorRangeLevelIds { get; set; }
		
	}

	
	/*================================================================================================*/
	/// <summary>
	///   Provides a unit of measurement for the numeric value of a particular Vector.
	/// </summary>
	/// <remarks>
	///   <para>Provides a unit of measurement for the numeric value of a particular Vector.</para>
	/// </remarks>
	public class VectorUnit : BaseEnum {
	
	}

	
	/*================================================================================================*/
	/// <summary>
	///   Provides a level of magnitude for the numeric value of a particular Vector.
	/// </summary>
	/// <remarks>
	///   <para>Provides a level of magnitude for the numeric value of a particular Vector.</para>
	/// </remarks>
	public class VectorUnitPrefix : BaseEnum {
	
		/// <summary>
		///   The difference in magnitude (a multipler) relative to the base unit.
		/// </summary>
		public double Amount { get; set; }
		
	}

	
	/*================================================================================================*/
	/// <summary>
	///   Provides conversion formulas from the "derived" unit to one or more "raises" units.
	/// </summary>
	/// <remarks>
	///   <para>Provides conversion formulas from the "derived" unit to one or more "raises" units. Each "raises" unit receives a unit prefix and an exponent value.</para>
	///   <para>Watt Example: Description</para>
	///   <para>The Watt unit conversion is defined with three seperate VectorUnitDerived items:</para>
	///   <para>- WattGram</para>
	///   <para>- WattMetre</para>
	///   <para>- WattSec</para>
	///   <para>Equation</para>
	///   <para>Those three items represent the Watt conversion equation:</para>
	///   <para>1 Watt = 1 (Kg)*(m^2)/(s^3)</para>
	/// </remarks>
	public class VectorUnitDerived : BaseEnum {
	
		/// <summary>
		///   One or more VectorUnitDerived items are used to represent a conversion into this particular unit.
		/// </summary>
		public byte DefinesVectorUnitId { get; set; }
		
		/// <summary>
		///   The unit for this particular item.
		/// </summary>
		public byte RaisesVectorUnitId { get; set; }
		
		/// <summary>
		///   The exponent that affects the "raises" unit.
		/// </summary>
		public int WithExponent { get; set; }
		
		/// <summary>
		///   The unit prefix that affects the "raises" unit.
		/// </summary>
		public byte RaisesVectorUnitPrefixId { get; set; }
		
	}

	
}