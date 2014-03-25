namespace Fabric.Clients.Cs.Spec.SpecDto {

	/*================================================================================================*/
	public class FabSpecValue {

		public string Name { get; set; }
		public string Type { get; set; }
		public string Description { get; set; }

		public bool? IsOptional { get; set; }
		public long? Min { get; set; }
		public long? Max { get; set; }
		public int? LenMin { get; set; }
		public int? LenMax { get; set; }
		public string ValidRegex { get; set; }

	}

}