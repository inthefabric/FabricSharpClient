// GENERATED CODE
// Changes made to this source file will be overwritten
// Generated on 4/19/2013 5:20:29 PM

namespace Fabric.Clients.Cs.Api {
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabAppStep : IFabArtifactStep<FabApp>, IFuncAs, IFuncBack, IFuncLimit, IFuncWhereId {
		

		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links an App to a particular Member. (OutToOneOrMore FabMember)
		/// </summary>
		/// <remarks>
		///   <para>Links an App to a particular Member.</para>
		///   <para>Type: AppDefinesMember</para>
		///   <para>Relation: Defines</para>
		///   <para>Connection: OutToOneOrMore</para>
		/// </remarks>
		IFabMemberStep DefinesMemberList { get; }
	
	}

	/*================================================================================================*/
	internal class FabAppStep : FabArtifactStep<FabApp>, IFabAppStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabAppStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public IFabMemberStep DefinesMemberList {
			get {
				var s = new FabMemberStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/DefinesMemberList");
				return s;
			}
		}
		
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabBatchNewClassStep : IFabBatchNewObjectStep<FabBatchNewClass> {
		

		////////////////////////////////////////////////////////////////////////////////////////////////
	}

	/*================================================================================================*/
	internal class FabBatchNewClassStep : FabBatchNewObjectStep<FabBatchNewClass>, IFabBatchNewClassStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabBatchNewClassStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabBatchNewFactorStep : IFabBatchNewObjectStep<FabBatchNewFactor> {
		

		////////////////////////////////////////////////////////////////////////////////////////////////
	}

	/*================================================================================================*/
	internal class FabBatchNewFactorStep : FabBatchNewObjectStep<FabBatchNewFactor>, IFabBatchNewFactorStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabBatchNewFactorStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabBatchNewFactorDescriptorStep : IFabObjectStep<FabBatchNewFactorDescriptor> {
		

		////////////////////////////////////////////////////////////////////////////////////////////////
	}

	/*================================================================================================*/
	internal class FabBatchNewFactorDescriptorStep : FabObjectStep<FabBatchNewFactorDescriptor>, IFabBatchNewFactorDescriptorStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabBatchNewFactorDescriptorStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabBatchNewFactorDirectorStep : IFabObjectStep<FabBatchNewFactorDirector> {
		

		////////////////////////////////////////////////////////////////////////////////////////////////
	}

	/*================================================================================================*/
	internal class FabBatchNewFactorDirectorStep : FabObjectStep<FabBatchNewFactorDirector>, IFabBatchNewFactorDirectorStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabBatchNewFactorDirectorStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabBatchNewFactorEventorStep : IFabObjectStep<FabBatchNewFactorEventor> {
		

		////////////////////////////////////////////////////////////////////////////////////////////////
	}

	/*================================================================================================*/
	internal class FabBatchNewFactorEventorStep : FabObjectStep<FabBatchNewFactorEventor>, IFabBatchNewFactorEventorStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabBatchNewFactorEventorStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabBatchNewFactorIdentorStep : IFabObjectStep<FabBatchNewFactorIdentor> {
		

		////////////////////////////////////////////////////////////////////////////////////////////////
	}

	/*================================================================================================*/
	internal class FabBatchNewFactorIdentorStep : FabObjectStep<FabBatchNewFactorIdentor>, IFabBatchNewFactorIdentorStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabBatchNewFactorIdentorStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabBatchNewFactorLocatorStep : IFabObjectStep<FabBatchNewFactorLocator> {
		

		////////////////////////////////////////////////////////////////////////////////////////////////
	}

	/*================================================================================================*/
	internal class FabBatchNewFactorLocatorStep : FabObjectStep<FabBatchNewFactorLocator>, IFabBatchNewFactorLocatorStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabBatchNewFactorLocatorStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabBatchNewFactorVectorStep : IFabObjectStep<FabBatchNewFactorVector> {
		

		////////////////////////////////////////////////////////////////////////////////////////////////
	}

	/*================================================================================================*/
	internal class FabBatchNewFactorVectorStep : FabObjectStep<FabBatchNewFactorVector>, IFabBatchNewFactorVectorStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabBatchNewFactorVectorStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabBatchResultStep : IFabObjectStep<FabBatchResult> {
		

		////////////////////////////////////////////////////////////////////////////////////////////////
	}

	/*================================================================================================*/
	internal class FabBatchResultStep : FabObjectStep<FabBatchResult>, IFabBatchResultStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabBatchResultStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabClassStep : IFabArtifactStep<FabClass>, IFuncAs, IFuncBack, IFuncLimit, IFuncWhereId {
		

		////////////////////////////////////////////////////////////////////////////////////////////////
	}

	/*================================================================================================*/
	internal class FabClassStep : FabArtifactStep<FabClass>, IFabClassStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabClassStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabDescriptorStep : IFabObjectStep<FabDescriptor> {
		

		////////////////////////////////////////////////////////////////////////////////////////////////
	}

	/*================================================================================================*/
	internal class FabDescriptorStep : FabObjectStep<FabDescriptor>, IFabDescriptorStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabDescriptorStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabDirectorStep : IFabObjectStep<FabDirector> {
		

		////////////////////////////////////////////////////////////////////////////////////////////////
	}

	/*================================================================================================*/
	internal class FabDirectorStep : FabObjectStep<FabDirector>, IFabDirectorStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabDirectorStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabErrorStep : IFabObjectStep<FabError> {
		

		////////////////////////////////////////////////////////////////////////////////////////////////
	}

	/*================================================================================================*/
	internal class FabErrorStep : FabObjectStep<FabError>, IFabErrorStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabErrorStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabEventorStep : IFabObjectStep<FabEventor> {
		

		////////////////////////////////////////////////////////////////////////////////////////////////
	}

	/*================================================================================================*/
	internal class FabEventorStep : FabObjectStep<FabEventor>, IFabEventorStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabEventorStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabFactorStep : IFabNodeStep<FabFactor>, IFuncAs, IFuncBack, IFuncLimit, IFuncWhereId {
		

		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a Member to the Factor that it created. (InFromOne FabMember)
		/// </summary>
		/// <remarks>
		///   <para>Links a Member to the Factor that it created.</para>
		///   <para>Type: MemberCreatesFactor</para>
		///   <para>Relation: Creates</para>
		///   <para>Connection: InFromOne</para>
		/// </remarks>
		IFabMemberStep InMemberCreates { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a Factor to its primary Artifact, which represents the starting point of the Factor's directional Artifact relationship. (OutToOne FabArtifact)
		/// </summary>
		/// <remarks>
		///   <para>Links a Factor to its primary Artifact, which represents the starting point of the Factor's directional Artifact relationship.</para>
		///   <para>Type: FactorUsesPrimaryArtifact</para>
		///   <para>Relation: UsesPrimary</para>
		///   <para>Connection: OutToOne</para>
		/// </remarks>
		IFabArtifactStep UsesPrimaryArtifact { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a Factor to its related Artifact, which represents the ending point of the Factor's directional Artifact relationship. (OutToOne FabArtifact)
		/// </summary>
		/// <remarks>
		///   <para>Links a Factor to its related Artifact, which represents the ending point of the Factor's directional Artifact relationship.</para>
		///   <para>Type: FactorUsesRelatedArtifact</para>
		///   <para>Relation: UsesRelated</para>
		///   <para>Connection: OutToOne</para>
		/// </remarks>
		IFabArtifactStep UsesRelatedArtifact { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a Descriptor to an Artifact that specifies or clarifies a particular aspect of the Factor's primary Artifact. (OutToZeroOrOne FabArtifact)
		/// </summary>
		/// <remarks>
		///   <para>Links a Descriptor to an Artifact that specifies or clarifies a particular aspect of the Factor's primary Artifact.</para>
		///   <para>Type: FactorDescriptorRefinesPrimaryWithArtifact</para>
		///   <para>Relation: DescriptorRefinesPrimaryWith</para>
		///   <para>Connection: OutToZeroOrOne</para>
		/// </remarks>
		IFabArtifactStep DescriptorRefinesPrimaryWithArtifact { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a Descriptor to an Artifact that specifies or clarifies a particular aspect of the Factor's related Artifact. (OutToZeroOrOne FabArtifact)
		/// </summary>
		/// <remarks>
		///   <para>Links a Descriptor to an Artifact that specifies or clarifies a particular aspect of the Factor's related Artifact.</para>
		///   <para>Type: FactorDescriptorRefinesRelatedWithArtifact</para>
		///   <para>Relation: DescriptorRefinesRelatedWith</para>
		///   <para>Connection: OutToZeroOrOne</para>
		/// </remarks>
		IFabArtifactStep DescriptorRefinesRelatedWithArtifact { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a Descriptor to an Artifact that specifies or clarifies a particular aspect of the DescriptorType's meaning or purpose. (OutToZeroOrOne FabArtifact)
		/// </summary>
		/// <remarks>
		///   <para>Links a Descriptor to an Artifact that specifies or clarifies a particular aspect of the DescriptorType's meaning or purpose.</para>
		///   <para>Type: FactorDescriptorRefinesTypeWithArtifact</para>
		///   <para>Relation: DescriptorRefinesTypeWith</para>
		///   <para>Connection: OutToZeroOrOne</para>
		/// </remarks>
		IFabArtifactStep DescriptorRefinesTypeWithArtifact { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a Vector to an Artifact that 'labels' its value's axis. (OutToZeroOrOne FabArtifact)
		/// </summary>
		/// <remarks>
		///   <para>Links a Vector to an Artifact that 'labels' its value's axis.</para>
		///   <para>Type: FactorVectorUsesAxisArtifact</para>
		///   <para>Relation: VectorUsesAxis</para>
		///   <para>Connection: OutToZeroOrOne</para>
		/// </remarks>
		IFabArtifactStep VectorUsesAxisArtifact { get; }
	
	}

	/*================================================================================================*/
	internal class FabFactorStep : FabNodeStep<FabFactor>, IFabFactorStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabFactorStep(Traversal pTrav) : base(pTrav) {}
		
		
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
		public IFabArtifactStep UsesPrimaryArtifact {
			get {
				var s = new FabArtifactStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/UsesPrimaryArtifact");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabArtifactStep UsesRelatedArtifact {
			get {
				var s = new FabArtifactStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/UsesRelatedArtifact");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabArtifactStep DescriptorRefinesPrimaryWithArtifact {
			get {
				var s = new FabArtifactStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/DescriptorRefinesPrimaryWithArtifact");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabArtifactStep DescriptorRefinesRelatedWithArtifact {
			get {
				var s = new FabArtifactStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/DescriptorRefinesRelatedWithArtifact");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabArtifactStep DescriptorRefinesTypeWithArtifact {
			get {
				var s = new FabArtifactStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/DescriptorRefinesTypeWithArtifact");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabArtifactStep VectorUsesAxisArtifact {
			get {
				var s = new FabArtifactStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/VectorUsesAxisArtifact");
				return s;
			}
		}
		
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabHomeStep : IFabObjectStep<FabHome> {
		

		////////////////////////////////////////////////////////////////////////////////////////////////
	}

	/*================================================================================================*/
	internal class FabHomeStep : FabObjectStep<FabHome>, IFabHomeStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabHomeStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabIdentorStep : IFabObjectStep<FabIdentor> {
		

		////////////////////////////////////////////////////////////////////////////////////////////////
	}

	/*================================================================================================*/
	internal class FabIdentorStep : FabObjectStep<FabIdentor>, IFabIdentorStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabIdentorStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabInstanceStep : IFabArtifactStep<FabInstance>, IFuncAs, IFuncBack, IFuncLimit, IFuncWhereId {
		

		////////////////////////////////////////////////////////////////////////////////////////////////
	}

	/*================================================================================================*/
	internal class FabInstanceStep : FabArtifactStep<FabInstance>, IFabInstanceStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabInstanceStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabLocatorStep : IFabObjectStep<FabLocator> {
		

		////////////////////////////////////////////////////////////////////////////////////////////////
	}

	/*================================================================================================*/
	internal class FabLocatorStep : FabObjectStep<FabLocator>, IFabLocatorStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabLocatorStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabMemberStep : IFabNodeStep<FabMember>, IFuncAs, IFuncBack, IFuncLimit, IFuncWhereId {
		

		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links an App to a particular Member. (InFromOne FabApp)
		/// </summary>
		/// <remarks>
		///   <para>Links an App to a particular Member.</para>
		///   <para>Type: AppDefinesMember</para>
		///   <para>Relation: Defines</para>
		///   <para>Connection: InFromOne</para>
		/// </remarks>
		IFabAppStep InAppDefines { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a Member to its active MemberTypeAssign. (OutToOne FabMemberTypeAssign)
		/// </summary>
		/// <remarks>
		///   <para>Links a Member to its active MemberTypeAssign.</para>
		///   <para>Type: MemberHasMemberTypeAssign</para>
		///   <para>Relation: Has</para>
		///   <para>Connection: OutToOne</para>
		/// </remarks>
		IFabMemberTypeAssignStep HasMemberTypeAssign { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a Member to a historical MemberTypeAssign. (OutToZeroOrMore FabMemberTypeAssign)
		/// </summary>
		/// <remarks>
		///   <para>Links a Member to a historical MemberTypeAssign.</para>
		///   <para>Type: MemberHasHistoricMemberTypeAssign</para>
		///   <para>Relation: HasHistoric</para>
		///   <para>Connection: OutToZeroOrMore</para>
		/// </remarks>
		IFabMemberTypeAssignStep HasHistoricMemberTypeAssignList { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a Member to the Artifact that it created. (OutToZeroOrMore FabArtifact)
		/// </summary>
		/// <remarks>
		///   <para>Links a Member to the Artifact that it created.</para>
		///   <para>Type: MemberCreatesArtifact</para>
		///   <para>Relation: Creates</para>
		///   <para>Connection: OutToZeroOrMore</para>
		/// </remarks>
		IFabArtifactStep CreatesArtifactList { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a Member to the MemberTypeAssign that it created. (OutToZeroOrMore FabMemberTypeAssign)
		/// </summary>
		/// <remarks>
		///   <para>Links a Member to the MemberTypeAssign that it created.</para>
		///   <para>Type: MemberCreatesMemberTypeAssign</para>
		///   <para>Relation: Creates</para>
		///   <para>Connection: OutToZeroOrMore</para>
		/// </remarks>
		IFabMemberTypeAssignStep CreatesMemberTypeAssignList { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a Member to the Factor that it created. (OutToZeroOrMore FabFactor)
		/// </summary>
		/// <remarks>
		///   <para>Links a Member to the Factor that it created.</para>
		///   <para>Type: MemberCreatesFactor</para>
		///   <para>Relation: Creates</para>
		///   <para>Connection: OutToZeroOrMore</para>
		/// </remarks>
		IFabFactorStep CreatesFactorList { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a User to a particular Member. (InFromOne FabUser)
		/// </summary>
		/// <remarks>
		///   <para>Links a User to a particular Member.</para>
		///   <para>Type: UserDefinesMember</para>
		///   <para>Relation: Defines</para>
		///   <para>Connection: InFromOne</para>
		/// </remarks>
		IFabUserStep InUserDefines { get; }
	
	}

	/*================================================================================================*/
	internal class FabMemberStep : FabNodeStep<FabMember>, IFabMemberStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabMemberStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public IFabAppStep InAppDefines {
			get {
				var s = new FabAppStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/InAppDefines");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabMemberTypeAssignStep HasMemberTypeAssign {
			get {
				var s = new FabMemberTypeAssignStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/HasMemberTypeAssign");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabMemberTypeAssignStep HasHistoricMemberTypeAssignList {
			get {
				var s = new FabMemberTypeAssignStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/HasHistoricMemberTypeAssignList");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabArtifactStep CreatesArtifactList {
			get {
				var s = new FabArtifactStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/CreatesArtifactList");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabMemberTypeAssignStep CreatesMemberTypeAssignList {
			get {
				var s = new FabMemberTypeAssignStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/CreatesMemberTypeAssignList");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabFactorStep CreatesFactorList {
			get {
				var s = new FabFactorStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/CreatesFactorList");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabUserStep InUserDefines {
			get {
				var s = new FabUserStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/InUserDefines");
				return s;
			}
		}
		
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabMemberTypeAssignStep : IFabNodeForActionStep<FabMemberTypeAssign>, IFuncAs, IFuncBack, IFuncLimit, IFuncWhereId {
		

		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a Member to its active MemberTypeAssign. (InFromOne FabMember)
		/// </summary>
		/// <remarks>
		///   <para>Links a Member to its active MemberTypeAssign.</para>
		///   <para>Type: MemberHasMemberTypeAssign</para>
		///   <para>Relation: Has</para>
		///   <para>Connection: InFromOne</para>
		/// </remarks>
		IFabMemberStep InMemberHas { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a Member to a historical MemberTypeAssign. (InFromOne FabMember)
		/// </summary>
		/// <remarks>
		///   <para>Links a Member to a historical MemberTypeAssign.</para>
		///   <para>Type: MemberHasHistoricMemberTypeAssign</para>
		///   <para>Relation: HasHistoric</para>
		///   <para>Connection: InFromOne</para>
		/// </remarks>
		IFabMemberStep InMemberHasHistoric { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a Member to the MemberTypeAssign that it created. (InFromOne FabMember)
		/// </summary>
		/// <remarks>
		///   <para>Links a Member to the MemberTypeAssign that it created.</para>
		///   <para>Type: MemberCreatesMemberTypeAssign</para>
		///   <para>Relation: Creates</para>
		///   <para>Connection: InFromOne</para>
		/// </remarks>
		IFabMemberStep InMemberCreates { get; }
	
	}

	/*================================================================================================*/
	internal class FabMemberTypeAssignStep : FabNodeForActionStep<FabMemberTypeAssign>, IFabMemberTypeAssignStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabMemberTypeAssignStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public IFabMemberStep InMemberHas {
			get {
				var s = new FabMemberStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/InMemberHas");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabMemberStep InMemberHasHistoric {
			get {
				var s = new FabMemberStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/InMemberHasHistoric");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabMemberStep InMemberCreates {
			get {
				var s = new FabMemberStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/InMemberCreates");
				return s;
			}
		}
		
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabMetaTimeStep : IFabObjectStep<FabMetaTime> {
		

		////////////////////////////////////////////////////////////////////////////////////////////////
	}

	/*================================================================================================*/
	internal class FabMetaTimeStep : FabObjectStep<FabMetaTime>, IFabMetaTimeStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabMetaTimeStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabMetaVersionStep : IFabObjectStep<FabMetaVersion> {
		

		////////////////////////////////////////////////////////////////////////////////////////////////
	}

	/*================================================================================================*/
	internal class FabMetaVersionStep : FabObjectStep<FabMetaVersion>, IFabMetaVersionStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabMetaVersionStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabOauthAccessStep : IFabObjectStep<FabOauthAccess> {
		

		////////////////////////////////////////////////////////////////////////////////////////////////
	}

	/*================================================================================================*/
	internal class FabOauthAccessStep : FabObjectStep<FabOauthAccess>, IFabOauthAccessStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabOauthAccessStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabOauthErrorStep : IFabObjectStep<FabOauthError> {
		

		////////////////////////////////////////////////////////////////////////////////////////////////
	}

	/*================================================================================================*/
	internal class FabOauthErrorStep : FabObjectStep<FabOauthError>, IFabOauthErrorStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabOauthErrorStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabOauthLoginStep : IFabObjectStep<FabOauthLogin> {
		

		////////////////////////////////////////////////////////////////////////////////////////////////
	}

	/*================================================================================================*/
	internal class FabOauthLoginStep : FabObjectStep<FabOauthLogin>, IFabOauthLoginStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabOauthLoginStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabOauthLogoutStep : IFabObjectStep<FabOauthLogout> {
		

		////////////////////////////////////////////////////////////////////////////////////////////////
	}

	/*================================================================================================*/
	internal class FabOauthLogoutStep : FabObjectStep<FabOauthLogout>, IFabOauthLogoutStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabOauthLogoutStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabRootStep : IFabNodeStep<FabRoot> {
		

		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links the Root node to an App. (InFromOne FabApp)
		/// </summary>
		/// <remarks>
		///   <para>Links the Root node to an App.</para>
		///   <para>Type: RootContainsApp</para>
		///   <para>Relation: Contains</para>
		///   <para>Connection: InFromOne</para>
		/// </remarks>
		IFabAppStep ContainsAppList { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links the Root node to a Class. (InFromOne FabClass)
		/// </summary>
		/// <remarks>
		///   <para>Links the Root node to a Class.</para>
		///   <para>Type: RootContainsClass</para>
		///   <para>Relation: Contains</para>
		///   <para>Connection: InFromOne</para>
		/// </remarks>
		IFabClassStep ContainsClassList { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links the Root node to an Instance. (InFromOne FabInstance)
		/// </summary>
		/// <remarks>
		///   <para>Links the Root node to an Instance.</para>
		///   <para>Type: RootContainsInstance</para>
		///   <para>Relation: Contains</para>
		///   <para>Connection: InFromOne</para>
		/// </remarks>
		IFabInstanceStep ContainsInstanceList { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links the Root node to a Member. (InFromOne FabMember)
		/// </summary>
		/// <remarks>
		///   <para>Links the Root node to a Member.</para>
		///   <para>Type: RootContainsMember</para>
		///   <para>Relation: Contains</para>
		///   <para>Connection: InFromOne</para>
		/// </remarks>
		IFabMemberStep ContainsMemberList { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links the Root node to a MemberTypeAssign. (InFromOne FabMemberTypeAssign)
		/// </summary>
		/// <remarks>
		///   <para>Links the Root node to a MemberTypeAssign.</para>
		///   <para>Type: RootContainsMemberTypeAssign</para>
		///   <para>Relation: Contains</para>
		///   <para>Connection: InFromOne</para>
		/// </remarks>
		IFabMemberTypeAssignStep ContainsMemberTypeAssignList { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links the Root node to a Url. (InFromOne FabUrl)
		/// </summary>
		/// <remarks>
		///   <para>Links the Root node to a Url.</para>
		///   <para>Type: RootContainsUrl</para>
		///   <para>Relation: Contains</para>
		///   <para>Connection: InFromOne</para>
		/// </remarks>
		IFabUrlStep ContainsUrlList { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links the Root node to a User. (InFromOne FabUser)
		/// </summary>
		/// <remarks>
		///   <para>Links the Root node to a User.</para>
		///   <para>Type: RootContainsUser</para>
		///   <para>Relation: Contains</para>
		///   <para>Connection: InFromOne</para>
		/// </remarks>
		IFabUserStep ContainsUserList { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links the Root node to a Factor. (InFromOne FabFactor)
		/// </summary>
		/// <remarks>
		///   <para>Links the Root node to a Factor.</para>
		///   <para>Type: RootContainsFactor</para>
		///   <para>Relation: Contains</para>
		///   <para>Connection: InFromOne</para>
		/// </remarks>
		IFabFactorStep ContainsFactorList { get; }
	
	}

	/*================================================================================================*/
	internal class FabRootStep : FabNodeStep<FabRoot>, IFabRootStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabRootStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public IFabAppStep ContainsAppList {
			get {
				var s = new FabAppStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/ContainsAppList");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabClassStep ContainsClassList {
			get {
				var s = new FabClassStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/ContainsClassList");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabInstanceStep ContainsInstanceList {
			get {
				var s = new FabInstanceStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/ContainsInstanceList");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabMemberStep ContainsMemberList {
			get {
				var s = new FabMemberStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/ContainsMemberList");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabMemberTypeAssignStep ContainsMemberTypeAssignList {
			get {
				var s = new FabMemberTypeAssignStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/ContainsMemberTypeAssignList");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabUrlStep ContainsUrlList {
			get {
				var s = new FabUrlStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/ContainsUrlList");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabUserStep ContainsUserList {
			get {
				var s = new FabUserStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/ContainsUserList");
				return s;
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabFactorStep ContainsFactorList {
			get {
				var s = new FabFactorStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/ContainsFactorList");
				return s;
			}
		}
		
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabServiceStep : IFabObjectStep<FabService> {
		

		////////////////////////////////////////////////////////////////////////////////////////////////
	}

	/*================================================================================================*/
	internal class FabServiceStep : FabObjectStep<FabService>, IFabServiceStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabServiceStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabServiceOperationStep : IFabObjectStep<FabServiceOperation> {
		

		////////////////////////////////////////////////////////////////////////////////////////////////
	}

	/*================================================================================================*/
	internal class FabServiceOperationStep : FabObjectStep<FabServiceOperation>, IFabServiceOperationStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabServiceOperationStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabStepLinkStep : IFabObjectStep<FabStepLink> {
		

		////////////////////////////////////////////////////////////////////////////////////////////////
	}

	/*================================================================================================*/
	internal class FabStepLinkStep : FabObjectStep<FabStepLink>, IFabStepLinkStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabStepLinkStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabUrlStep : IFabArtifactStep<FabUrl>, IFuncAs, IFuncBack, IFuncLimit, IFuncWhereId {
		

		////////////////////////////////////////////////////////////////////////////////////////////////
	}

	/*================================================================================================*/
	internal class FabUrlStep : FabArtifactStep<FabUrl>, IFabUrlStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabUrlStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabUserStep : IFabArtifactStep<FabUser>, IFuncAs, IFuncBack, IFuncLimit, IFuncWhereId {
		

		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a User to a particular Member. (OutToOneOrMore FabMember)
		/// </summary>
		/// <remarks>
		///   <para>Links a User to a particular Member.</para>
		///   <para>Type: UserDefinesMember</para>
		///   <para>Relation: Defines</para>
		///   <para>Connection: OutToOneOrMore</para>
		/// </remarks>
		IFabMemberStep DefinesMemberList { get; }
	
	}

	/*================================================================================================*/
	internal class FabUserStep : FabArtifactStep<FabUser>, IFabUserStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabUserStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public IFabMemberStep DefinesMemberList {
			get {
				var s = new FabMemberStep(Trav);
				Trav.AddStep(s);
				Trav.AppendToUri("/DefinesMemberList");
				return s;
			}
		}
		
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabVectorStep : IFabObjectStep<FabVector> {
		

		////////////////////////////////////////////////////////////////////////////////////////////////
	}

	/*================================================================================================*/
	internal class FabVectorStep : FabObjectStep<FabVector>, IFabVectorStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabVectorStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
	}
	
	
}
