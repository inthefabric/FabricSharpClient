namespace Fabric.Clients.Cs.Daemon.Data {
	
	/*================================================================================================*/
	/// <summary />
	public interface IClassData : IArtifactData {

		/// <summary />
		string Name { get; set; }

		/// <summary />
		string Disamb { get; set; }

		/// <summary />
		string Note { get; set; }

    }

}
