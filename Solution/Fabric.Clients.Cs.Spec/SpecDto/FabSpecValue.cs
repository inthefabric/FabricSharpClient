namespace Fabric.Clients.Cs.Spec.SpecDto {

	/*================================================================================================*/
	public class FabSpecValue {

		public string Name { get; set; }
		public string Type { get; set; }
		public string Description { get; set; }

		public bool? IsOptional { get; set; }
		public int? Len { get; set; }
		public int? LenMax { get; set; }
		public int? LenMin { get; set; }
		public int? Min { get; set; }
		public int? Max { get; set; }
		public string ValidRegex { get; set; }

	}

}