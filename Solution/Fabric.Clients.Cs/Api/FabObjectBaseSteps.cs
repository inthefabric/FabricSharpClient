// GENERATED CODE
// Changes made to this source file will be overwritten
// Generated on 8/6/2013 3:11:12 PM

namespace Fabric.Clients.Cs.Api {
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabArtifactStep<T> : IFabVertexStep<T>, IHasFuncAs, IHasFuncBack, IHasFuncHasId, IHasFuncLimit, IHasFuncToApp, IHasFuncToClass, IHasFuncToInstance, IHasFuncToUrl, IHasFuncToUser where T : FabObject {
		

		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a Member to the Artifact that it created. (InOne FabMember)
		/// </summary>
		/// <remarks>
		///   <para>Links a Member to the Artifact that it created.</para>
		///   <para>Type: MemberCreatesArtifact</para>
		///   <para>Relation: Creates</para>
		///   <para>Connection: InOne</para>
		/// </remarks>
		IFabMemberStep InMemberCreates { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a Factor to its primary Artifact, which represents the starting point of the Factor's directional Artifact relationship. (InZeroOrMore FabFactor)
		/// </summary>
		/// <remarks>
		///   <para>Links a Factor to its primary Artifact, which represents the starting point of the Factor's directional Artifact relationship.</para>
		///   <para>Type: FactorUsesPrimaryArtifact</para>
		///   <para>Relation: UsesPrimary</para>
		///   <para>Connection: InZeroOrMore</para>
		/// </remarks>
		IFabFactorStep InFactorListUsesPrimary { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a Factor to its related Artifact, which represents the ending point of the Factor's directional Artifact relationship. (InZeroOrMore FabFactor)
		/// </summary>
		/// <remarks>
		///   <para>Links a Factor to its related Artifact, which represents the ending point of the Factor's directional Artifact relationship.</para>
		///   <para>Type: FactorUsesRelatedArtifact</para>
		///   <para>Relation: UsesRelated</para>
		///   <para>Connection: InZeroOrMore</para>
		/// </remarks>
		IFabFactorStep InFactorListUsesRelated { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a Descriptor to an Artifact that specifies or clarifies a particular aspect of the Factor's primary Artifact. (InZeroOrMore FabFactor)
		/// </summary>
		/// <remarks>
		///   <para>Links a Descriptor to an Artifact that specifies or clarifies a particular aspect of the Factor's primary Artifact.</para>
		///   <para>Type: FactorDescriptorRefinesPrimaryWithArtifact</para>
		///   <para>Relation: DescriptorRefinesPrimaryWith</para>
		///   <para>Connection: InZeroOrMore</para>
		/// </remarks>
		IFabFactorStep InFactorListDescriptorRefinesPrimaryWith { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a Descriptor to an Artifact that specifies or clarifies a particular aspect of the Factor's related Artifact. (InZeroOrMore FabFactor)
		/// </summary>
		/// <remarks>
		///   <para>Links a Descriptor to an Artifact that specifies or clarifies a particular aspect of the Factor's related Artifact.</para>
		///   <para>Type: FactorDescriptorRefinesRelatedWithArtifact</para>
		///   <para>Relation: DescriptorRefinesRelatedWith</para>
		///   <para>Connection: InZeroOrMore</para>
		/// </remarks>
		IFabFactorStep InFactorListDescriptorRefinesRelatedWith { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a Descriptor to an Artifact that specifies or clarifies a particular aspect of the DescriptorType's meaning or purpose. (InZeroOrMore FabFactor)
		/// </summary>
		/// <remarks>
		///   <para>Links a Descriptor to an Artifact that specifies or clarifies a particular aspect of the DescriptorType's meaning or purpose.</para>
		///   <para>Type: FactorDescriptorRefinesTypeWithArtifact</para>
		///   <para>Relation: DescriptorRefinesTypeWith</para>
		///   <para>Connection: InZeroOrMore</para>
		/// </remarks>
		IFabFactorStep InFactorListDescriptorRefinesTypeWith { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a Vector to an Artifact that 'labels' its value's axis. (InZeroOrMore FabFactor)
		/// </summary>
		/// <remarks>
		///   <para>Links a Vector to an Artifact that 'labels' its value's axis.</para>
		///   <para>Type: FactorVectorUsesAxisArtifact</para>
		///   <para>Relation: VectorUsesAxis</para>
		///   <para>Connection: InZeroOrMore</para>
		/// </remarks>
		IFabFactorStep InFactorListVectorUsesAxis { get; }
	
	}
	

	/*================================================================================================*/
	internal class FabArtifactStep<T> : FabVertexStep<T>, IFabArtifactStep<T> where T : FabObject {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabArtifactStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public IFabMemberStep InMemberCreates {
			get {
				var s = new FabMemberStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/InMemberCreates");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabFactorStep InFactorListUsesPrimary {
			get {
				var s = new FabFactorStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/InFactorListUsesPrimary");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabFactorStep InFactorListUsesRelated {
			get {
				var s = new FabFactorStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/InFactorListUsesRelated");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabFactorStep InFactorListDescriptorRefinesPrimaryWith {
			get {
				var s = new FabFactorStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/InFactorListDescriptorRefinesPrimaryWith");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabFactorStep InFactorListDescriptorRefinesRelatedWith {
			get {
				var s = new FabFactorStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/InFactorListDescriptorRefinesRelatedWith");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabFactorStep InFactorListDescriptorRefinesTypeWith {
			get {
				var s = new FabFactorStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/InFactorListDescriptorRefinesTypeWith");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabFactorStep InFactorListVectorUsesAxis {
			get {
				var s = new FabFactorStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/InFactorListVectorUsesAxis");
				return s;
			}
		}
		
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabArtifactStep : IFabArtifactStep<FabArtifact> {

	}

	
	/*================================================================================================*/
	internal class FabArtifactStep : FabArtifactStep<FabArtifact>, IFabArtifactStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabArtifactStep(Traversal pTrav) : base(pTrav) {}

	}
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabBatchNewObjectStep<T> : IFabObjectStep<T> where T : FabObject {
		

		////////////////////////////////////////////////////////////////////////////////////////////////
	}
	

	/*================================================================================================*/
	internal class FabBatchNewObjectStep<T> : FabObjectStep<T>, IFabBatchNewObjectStep<T> where T : FabObject {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabBatchNewObjectStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabBatchNewObjectStep : IFabBatchNewObjectStep<FabBatchNewObject> {

	}

	
	/*================================================================================================*/
	internal class FabBatchNewObjectStep : FabBatchNewObjectStep<FabBatchNewObject>, IFabBatchNewObjectStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabBatchNewObjectStep(Traversal pTrav) : base(pTrav) {}

	}
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabObjectStep<T> : ITraversalStep<T> where T : FabObject {
		

		////////////////////////////////////////////////////////////////////////////////////////////////
	}
	

	/*================================================================================================*/
	internal class FabObjectStep<T> : TraversalStep<T>, IFabObjectStep<T> where T : FabObject {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabObjectStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabObjectStep : IFabObjectStep<FabObject> {

	}

	
	/*================================================================================================*/
	internal class FabObjectStep : FabObjectStep<FabObject>, IFabObjectStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabObjectStep(Traversal pTrav) : base(pTrav) {}

	}
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabVertexStep<T> : IFabObjectStep<T> where T : FabObject {
		

		////////////////////////////////////////////////////////////////////////////////////////////////
	}
	

	/*================================================================================================*/
	internal class FabVertexStep<T> : FabObjectStep<T>, IFabVertexStep<T> where T : FabObject {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabVertexStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabVertexStep : IFabVertexStep<FabVertex> {

	}

	
	/*================================================================================================*/
	internal class FabVertexStep : FabVertexStep<FabVertex>, IFabVertexStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabVertexStep(Traversal pTrav) : base(pTrav) {}

	}
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabVertexForActionStep<T> : IFabVertexStep<T>, IHasFuncAs, IHasFuncBack, IHasFuncHasId, IHasFuncLimit where T : FabObject {
		

		////////////////////////////////////////////////////////////////////////////////////////////////
	}
	

	/*================================================================================================*/
	internal class FabVertexForActionStep<T> : FabVertexStep<T>, IFabVertexForActionStep<T> where T : FabObject {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabVertexForActionStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabVertexForActionStep : IFabVertexForActionStep<FabVertexForAction> {

	}

	
	/*================================================================================================*/
	internal class FabVertexForActionStep : FabVertexForActionStep<FabVertexForAction>, IFabVertexForActionStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabVertexForActionStep(Traversal pTrav) : base(pTrav) {}

	}
	
}
