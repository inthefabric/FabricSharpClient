namespace Fabric.Clients.Cs.Infrastructure.SpecDto {

	/*================================================================================================*/
	public class FabSpecObjectProp : FabSpecValue {

		public bool? IsCaseInsensitive { get; set; }
		public bool? IsNullable { get; set; }
		public bool? IsPrimaryKey { get; set; }
		public bool? IsTimestamp { get; set; }
		public bool? IsUnique { get; set; }

	}

}