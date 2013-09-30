namespace Fabric.Clients.Cs.Daemon.Data {

	/*================================================================================================*/
	/// <summary />
	public interface IInstanceData : IArtifactData {

		/// <summary />
		string Name { get; set; }

		/// <summary />
		string Disamb { get; set; }

		/// <summary />
		string Note { get; set; }

	}

}
