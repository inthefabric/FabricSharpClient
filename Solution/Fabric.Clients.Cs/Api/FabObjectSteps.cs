﻿// GENERATED CODE
// Changes made to this source file will be overwritten
// Generated on 9/13/2013 4:41:06 PM

namespace Fabric.Clients.Cs.Api {
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabAppStep : IFabArtifactStep<FabApp>, IHasFuncAs, IHasFuncBack, IHasFuncHasId, IHasFuncLimit {
		

		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links an App to a particular Member. (OutOneOrMore FabMember)
		/// </summary>
		/// <remarks>
		///   <para>Links an App to a particular Member.</para>
		///   <para>Type: AppDefinesMember</para>
		///   <para>Relation: Defines</para>
		///   <para>Connection: OutOneOrMore</para>
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
	public interface IFabClassStep : IFabArtifactStep<FabClass>, IHasFuncAs, IHasFuncBack, IHasFuncHasId, IHasFuncLimit {
		

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
	public interface IFabFactorStep : IFabVertexStep<FabFactor>, IHasFuncAs, IHasFuncBack, IHasFuncHasId, IHasFuncLimit {
		

		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a Member to the Factor that it created. (InOne FabMember)
		/// </summary>
		/// <remarks>
		///   <para>Links a Member to the Factor that it created.</para>
		///   <para>Type: MemberCreatesFactor</para>
		///   <para>Relation: Creates</para>
		///   <para>Connection: InOne</para>
		/// </remarks>
		IFabMemberStep InMemberCreates { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a Factor to its primary Artifact, which represents the starting point of the Factor's directional Artifact relationship. (OutOne FabArtifact)
		/// </summary>
		/// <remarks>
		///   <para>Links a Factor to its primary Artifact, which represents the starting point of the Factor's directional Artifact relationship.</para>
		///   <para>Type: FactorUsesPrimaryArtifact</para>
		///   <para>Relation: UsesPrimary</para>
		///   <para>Connection: OutOne</para>
		/// </remarks>
		IFabArtifactStep UsesPrimaryArtifact { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a Factor to its related Artifact, which represents the ending point of the Factor's directional Artifact relationship. (OutOne FabArtifact)
		/// </summary>
		/// <remarks>
		///   <para>Links a Factor to its related Artifact, which represents the ending point of the Factor's directional Artifact relationship.</para>
		///   <para>Type: FactorUsesRelatedArtifact</para>
		///   <para>Relation: UsesRelated</para>
		///   <para>Connection: OutOne</para>
		/// </remarks>
		IFabArtifactStep UsesRelatedArtifact { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a Descriptor to an Artifact that specifies or clarifies a particular aspect of the Factor's primary Artifact. (OutZeroOrOne FabArtifact)
		/// </summary>
		/// <remarks>
		///   <para>Links a Descriptor to an Artifact that specifies or clarifies a particular aspect of the Factor's primary Artifact.</para>
		///   <para>Type: FactorDescriptorRefinesPrimaryWithArtifact</para>
		///   <para>Relation: DescriptorRefinesPrimaryWith</para>
		///   <para>Connection: OutZeroOrOne</para>
		/// </remarks>
		IFabArtifactStep DescriptorRefinesPrimaryWithArtifact { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a Descriptor to an Artifact that specifies or clarifies a particular aspect of the Factor's related Artifact. (OutZeroOrOne FabArtifact)
		/// </summary>
		/// <remarks>
		///   <para>Links a Descriptor to an Artifact that specifies or clarifies a particular aspect of the Factor's related Artifact.</para>
		///   <para>Type: FactorDescriptorRefinesRelatedWithArtifact</para>
		///   <para>Relation: DescriptorRefinesRelatedWith</para>
		///   <para>Connection: OutZeroOrOne</para>
		/// </remarks>
		IFabArtifactStep DescriptorRefinesRelatedWithArtifact { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a Descriptor to an Artifact that specifies or clarifies a particular aspect of the DescriptorType's meaning or purpose. (OutZeroOrOne FabArtifact)
		/// </summary>
		/// <remarks>
		///   <para>Links a Descriptor to an Artifact that specifies or clarifies a particular aspect of the DescriptorType's meaning or purpose.</para>
		///   <para>Type: FactorDescriptorRefinesTypeWithArtifact</para>
		///   <para>Relation: DescriptorRefinesTypeWith</para>
		///   <para>Connection: OutZeroOrOne</para>
		/// </remarks>
		IFabArtifactStep DescriptorRefinesTypeWithArtifact { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a Vector to an Artifact that 'labels' its value's axis. (OutZeroOrOne FabArtifact)
		/// </summary>
		/// <remarks>
		///   <para>Links a Vector to an Artifact that 'labels' its value's axis.</para>
		///   <para>Type: FactorVectorUsesAxisArtifact</para>
		///   <para>Relation: VectorUsesAxis</para>
		///   <para>Connection: OutZeroOrOne</para>
		/// </remarks>
		IFabArtifactStep VectorUsesAxisArtifact { get; }
	
	}

	/*================================================================================================*/
	internal class FabFactorStep : FabVertexStep<FabFactor>, IFabFactorStep {
		
		
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
	public interface IFabInstanceStep : IFabArtifactStep<FabInstance>, IHasFuncAs, IHasFuncBack, IHasFuncHasId, IHasFuncLimit {
		

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
	public interface IFabMemberStep : IFabVertexStep<FabMember>, IHasFuncAs, IHasFuncBack, IHasFuncHasId, IHasFuncLimit {
		

		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links an App to a particular Member. (InOne FabApp)
		/// </summary>
		/// <remarks>
		///   <para>Links an App to a particular Member.</para>
		///   <para>Type: AppDefinesMember</para>
		///   <para>Relation: Defines</para>
		///   <para>Connection: InOne</para>
		/// </remarks>
		IFabAppStep InAppDefines { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a Member to its active MemberTypeAssign. (OutOne FabMemberTypeAssign)
		/// </summary>
		/// <remarks>
		///   <para>Links a Member to its active MemberTypeAssign.</para>
		///   <para>Type: MemberHasMemberTypeAssign</para>
		///   <para>Relation: Has</para>
		///   <para>Connection: OutOne</para>
		/// </remarks>
		IFabMemberTypeAssignStep HasMemberTypeAssign { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a Member to a historical MemberTypeAssign. (OutZeroOrMore FabMemberTypeAssign)
		/// </summary>
		/// <remarks>
		///   <para>Links a Member to a historical MemberTypeAssign.</para>
		///   <para>Type: MemberHasHistoricMemberTypeAssign</para>
		///   <para>Relation: HasHistoric</para>
		///   <para>Connection: OutZeroOrMore</para>
		/// </remarks>
		IFabMemberTypeAssignStep HasHistoricMemberTypeAssignList { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a Member to the Artifact that it created. (OutZeroOrMore FabArtifact)
		/// </summary>
		/// <remarks>
		///   <para>Links a Member to the Artifact that it created.</para>
		///   <para>Type: MemberCreatesArtifact</para>
		///   <para>Relation: Creates</para>
		///   <para>Connection: OutZeroOrMore</para>
		/// </remarks>
		IFabArtifactStep CreatesArtifactList { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a Member to the MemberTypeAssign that it created. (OutZeroOrMore FabMemberTypeAssign)
		/// </summary>
		/// <remarks>
		///   <para>Links a Member to the MemberTypeAssign that it created.</para>
		///   <para>Type: MemberCreatesMemberTypeAssign</para>
		///   <para>Relation: Creates</para>
		///   <para>Connection: OutZeroOrMore</para>
		/// </remarks>
		IFabMemberTypeAssignStep CreatesMemberTypeAssignList { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a Member to the Factor that it created. (OutZeroOrMore FabFactor)
		/// </summary>
		/// <remarks>
		///   <para>Links a Member to the Factor that it created.</para>
		///   <para>Type: MemberCreatesFactor</para>
		///   <para>Relation: Creates</para>
		///   <para>Connection: OutZeroOrMore</para>
		/// </remarks>
		IFabFactorStep CreatesFactorList { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a User to a particular Member. (InOne FabUser)
		/// </summary>
		/// <remarks>
		///   <para>Links a User to a particular Member.</para>
		///   <para>Type: UserDefinesMember</para>
		///   <para>Relation: Defines</para>
		///   <para>Connection: InOne</para>
		/// </remarks>
		IFabUserStep InUserDefines { get; }
	
	}

	/*================================================================================================*/
	internal class FabMemberStep : FabVertexStep<FabMember>, IFabMemberStep {
		
		
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
	public interface IFabMemberTypeAssignStep : IFabVertexForActionStep<FabMemberTypeAssign>, IHasFuncAs, IHasFuncBack, IHasFuncHasId, IHasFuncLimit {
		

		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a Member to its active MemberTypeAssign. (InOne FabMember)
		/// </summary>
		/// <remarks>
		///   <para>Links a Member to its active MemberTypeAssign.</para>
		///   <para>Type: MemberHasMemberTypeAssign</para>
		///   <para>Relation: Has</para>
		///   <para>Connection: InOne</para>
		/// </remarks>
		IFabMemberStep InMemberHas { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a Member to a historical MemberTypeAssign. (InOne FabMember)
		/// </summary>
		/// <remarks>
		///   <para>Links a Member to a historical MemberTypeAssign.</para>
		///   <para>Type: MemberHasHistoricMemberTypeAssign</para>
		///   <para>Relation: HasHistoric</para>
		///   <para>Connection: InOne</para>
		/// </remarks>
		IFabMemberStep InMemberHasHistoric { get; }
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a Member to the MemberTypeAssign that it created. (InOne FabMember)
		/// </summary>
		/// <remarks>
		///   <para>Links a Member to the MemberTypeAssign that it created.</para>
		///   <para>Type: MemberCreatesMemberTypeAssign</para>
		///   <para>Relation: Creates</para>
		///   <para>Connection: InOne</para>
		/// </remarks>
		IFabMemberStep InMemberCreates { get; }
	
	}

	/*================================================================================================*/
	internal class FabMemberTypeAssignStep : FabVertexForActionStep<FabMemberTypeAssign>, IFabMemberTypeAssignStep {
		
		
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
	public interface IFabRootStep : IFabVertexStep<FabRoot>, IHasFuncAppId, IHasFuncAppName, IHasFuncAppNameContains, IHasFuncArtifactCreated, IHasFuncArtifactId, IHasFuncClassDisambContains, IHasFuncClassId, IHasFuncClassName, IHasFuncClassNameContains, IHasFuncFactorCreated, IHasFuncFactorId, IHasFuncFactorIdentorValue, IHasFuncFactorIdentorValueContains, IHasFuncInstanceDisambContains, IHasFuncInstanceId, IHasFuncInstanceNameContains, IHasFuncMemberId, IHasFuncMemberTypeAssignId, IHasFuncUrlFullPath, IHasFuncUrlId, IHasFuncUrlNameContains, IHasFuncUserId, IHasFuncUserName {
		

		////////////////////////////////////////////////////////////////////////////////////////////////
	}

	/*================================================================================================*/
	internal class FabRootStep : FabVertexStep<FabRoot>, IFabRootStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabRootStep(Traversal pTrav) : base(pTrav) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
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
	public interface IFabUrlStep : IFabArtifactStep<FabUrl>, IHasFuncAs, IHasFuncBack, IHasFuncHasId, IHasFuncLimit {
		

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
	public interface IFabUserStep : IFabArtifactStep<FabUser>, IHasFuncAs, IHasFuncBack, IHasFuncHasId, IHasFuncLimit {
		

		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Links a User to a particular Member. (OutOneOrMore FabMember)
		/// </summary>
		/// <remarks>
		///   <para>Links a User to a particular Member.</para>
		///   <para>Type: UserDefinesMember</para>
		///   <para>Relation: Defines</para>
		///   <para>Connection: OutOneOrMore</para>
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
