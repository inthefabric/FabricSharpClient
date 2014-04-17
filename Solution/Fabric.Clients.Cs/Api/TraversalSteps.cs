// GENERATED CODE
// Changes made to this source file will be overwritten

namespace Fabric.Clients.Cs.Api {
	
	// ReSharper disable InconsistentNaming

	/*================================================================================================*/
	/// <summary />
	public interface IHasAsStep : ITraversalStep {}


	/*================================================================================================*/
	/// <summary />
	public interface IHasBackStep : ITraversalStep {}


	/*================================================================================================*/
	/// <summary />
	public interface IFabAppStep : ITraversalStep<FabApp>, IHasAsStep, IHasBackStep {
		

		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Finds results where the target property is an exact match to the specified value.
		/// </summary>
		/// <remarks>
		///   <para>Finds results where the target property is an exact match to the specified value.</para>
		/// </remarks>
		/// <param name="Value">
		///   The exact value to match for this search.
		/// </param>
		IFabAppStep WithId(long Value);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Finds results where the target property is an exact match to the specified value.
		/// </summary>
		/// <remarks>
		///   <para>Finds results where the target property is an exact match to the specified value.</para>
		/// </remarks>
		/// <param name="Value">
		///   The exact value to match for this search.
		/// </param>
		IFabAppStep WithVertexType(byte Value);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Finds results where the target property is within the specified range of values.
		/// </summary>
		/// <remarks>
		///   <para>Finds results where the target property is within the specified range of values.</para>
		/// </remarks>
		/// <param name="Operation">
		///   The operator that defines the type of range to use for this search. Options include: "Greater Than", "Less Than or Equal", "Not Equal", etc.
		/// </param>
		/// <param name="Value">
		///   The boundary value for the search range.
		/// </param>
		IFabAppStep WhereTimestamp(string Operation, long Value);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Restricts the number of results at the current traversal step.
		/// </summary>
		/// <remarks>
		///   <para>Restricts the number of results at the current traversal step.</para>
		/// </remarks>
		/// <param name="Count">
		///   The maximum number of elements to return.
		/// </param>
		IFabAppStep Take(int Count);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Creates a named alias for the current step of the traversal path. Execution of the traversal path can return to this alias using the Back step.
		/// </summary>
		/// <remarks>
		///   <para>Creates a named alias for the current step of the traversal path. Execution of the traversal path can return to this alias using the Back step.</para>
		/// </remarks>
		/// <param name="Alias">
		///   A named alias, which represents a particular place in the traversal path. This value must be unique across all other aliases in the traversal path.
		/// </param>
		IFabAppStep As(string Alias);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Traverses along an Edge type (connection) between one Vertex and zero, one, or many others. Links which will produce many results require further filtering (via relevant FabLink item) before arriving at the desired Vertex items. To complete this filtering, use the relevant Take step.
		/// </summary>
		/// <remarks>
		///   <para>Traverses along an Edge type (connection) between one Vertex and zero, one, or many others.</para>
	///   <para>Links which will produce many results require further filtering (via relevant FabLink item) before arriving at the desired Vertex items. To complete this filtering, use the relevant Take step.</para>
		/// </remarks>
		
		IFabAppDefinesMemberStep DefinesMembers();
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Traverses along an Edge type (connection) between one Vertex and zero, one, or many others. Links which will produce many results require further filtering (via relevant FabLink item) before arriving at the desired Vertex items. To complete this filtering, use the relevant Take step.
		/// </summary>
		/// <remarks>
		///   <para>Traverses along an Edge type (connection) between one Vertex and zero, one, or many others.</para>
	///   <para>Links which will produce many results require further filtering (via relevant FabLink item) before arriving at the desired Vertex items. To complete this filtering, use the relevant Take step.</para>
		/// </remarks>
		
		IFabMemberStep CreatedByMember();
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Traverses along an Edge type (connection) between one Vertex and zero, one, or many others. Links which will produce many results require further filtering (via relevant FabLink item) before arriving at the desired Vertex items. To complete this filtering, use the relevant Take step.
		/// </summary>
		/// <remarks>
		///   <para>Traverses along an Edge type (connection) between one Vertex and zero, one, or many others.</para>
	///   <para>Links which will produce many results require further filtering (via relevant FabLink item) before arriving at the desired Vertex items. To complete this filtering, use the relevant Take step.</para>
		/// </remarks>
		
		IFabArtifactUsedAsPrimaryByFactorStep UsedAsPrimaryByFactors();
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Traverses along an Edge type (connection) between one Vertex and zero, one, or many others. Links which will produce many results require further filtering (via relevant FabLink item) before arriving at the desired Vertex items. To complete this filtering, use the relevant Take step.
		/// </summary>
		/// <remarks>
		///   <para>Traverses along an Edge type (connection) between one Vertex and zero, one, or many others.</para>
	///   <para>Links which will produce many results require further filtering (via relevant FabLink item) before arriving at the desired Vertex items. To complete this filtering, use the relevant Take step.</para>
		/// </remarks>
		
		IFabArtifactUsedAsRelatedByFactorStep UsedAsRelatedByFactors();
	
	}


	/*================================================================================================*/
	internal class FabAppStep : TraversalStep<FabApp>, IFabAppStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabAppStep(TraversalPath pTravPath) : base(pTravPath) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public IFabAppStep WithId(long Value) {
			TravPath.AppendToUri("/WithId("+Value+")");
			return new FabAppStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabAppStep WithVertexType(byte Value) {
			TravPath.AppendToUri("/WithVertexType("+Value+")");
			return new FabAppStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabAppStep WhereTimestamp(string Operation, long Value) {
			TravPath.AppendToUri("/WhereTimestamp("+Operation+","+Value+")");
			return new FabAppStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabAppStep Take(int Count) {
			TravPath.AppendToUri("/Take("+Count+")");
			return new FabAppStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabAppStep As(string Alias) {
			TravPath.AppendToUri("/As("+Alias+")");
			return new FabAppStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabAppDefinesMemberStep DefinesMembers() {
			TravPath.AppendToUri("/DefinesMembers()");
			return new FabAppDefinesMemberStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabMemberStep CreatedByMember() {
			TravPath.AppendToUri("/CreatedByMember()");
			return new FabMemberStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabArtifactUsedAsPrimaryByFactorStep UsedAsPrimaryByFactors() {
			TravPath.AppendToUri("/UsedAsPrimaryByFactors()");
			return new FabArtifactUsedAsPrimaryByFactorStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabArtifactUsedAsRelatedByFactorStep UsedAsRelatedByFactors() {
			TravPath.AppendToUri("/UsedAsRelatedByFactors()");
			return new FabArtifactUsedAsRelatedByFactorStep(TravPath);
		}
		
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabAppDefinesMemberStep : ITraversalStep<FabAppDefinesMember>, IHasAsStep, IHasBackStep {
		

		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Finds results where the target property is an exact match to the specified value.
		/// </summary>
		/// <remarks>
		///   <para>Finds results where the target property is an exact match to the specified value.</para>
		/// </remarks>
		/// <param name="Value">
		///   The exact value to match for this search.
		/// </param>
		IFabAppDefinesMemberStep WithMemberType(byte Value);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Finds results where the target property is an exact match to the specified value.
		/// </summary>
		/// <remarks>
		///   <para>Finds results where the target property is an exact match to the specified value.</para>
		/// </remarks>
		/// <param name="Value">
		///   The exact value to match for this search.
		/// </param>
		IFabAppDefinesMemberStep WithUserId(long Value);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Finds results where the target property is within the specified range of values.
		/// </summary>
		/// <remarks>
		///   <para>Finds results where the target property is within the specified range of values.</para>
		/// </remarks>
		/// <param name="Operation">
		///   The operator that defines the type of range to use for this search. Options include: "Greater Than", "Less Than or Equal", "Not Equal", etc.
		/// </param>
		/// <param name="Value">
		///   The boundary value for the search range.
		/// </param>
		IFabAppDefinesMemberStep WhereTimestamp(string Operation, long Value);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Restricts the number of results at the current traversal step.
		/// </summary>
		/// <remarks>
		///   <para>Restricts the number of results at the current traversal step.</para>
		/// </remarks>
		/// <param name="Count">
		///   The maximum number of elements to return.
		/// </param>
		IFabMemberStep TakeMembers(int Count);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Restricts the number of results at the current traversal step.
		/// </summary>
		/// <remarks>
		///   <para>Restricts the number of results at the current traversal step.</para>
		/// </remarks>
		/// <param name="Count">
		///   The maximum number of elements to return.
		/// </param>
		IFabAppDefinesMemberStep Take(int Count);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Creates a named alias for the current step of the traversal path. Execution of the traversal path can return to this alias using the Back step.
		/// </summary>
		/// <remarks>
		///   <para>Creates a named alias for the current step of the traversal path. Execution of the traversal path can return to this alias using the Back step.</para>
		/// </remarks>
		/// <param name="Alias">
		///   A named alias, which represents a particular place in the traversal path. This value must be unique across all other aliases in the traversal path.
		/// </param>
		IFabAppDefinesMemberStep As(string Alias);
	
	}


	/*================================================================================================*/
	internal class FabAppDefinesMemberStep : TraversalStep<FabAppDefinesMember>, IFabAppDefinesMemberStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabAppDefinesMemberStep(TraversalPath pTravPath) : base(pTravPath) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public IFabAppDefinesMemberStep WithMemberType(byte Value) {
			TravPath.AppendToUri("/WithMemberType("+Value+")");
			return new FabAppDefinesMemberStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabAppDefinesMemberStep WithUserId(long Value) {
			TravPath.AppendToUri("/WithUserId("+Value+")");
			return new FabAppDefinesMemberStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabAppDefinesMemberStep WhereTimestamp(string Operation, long Value) {
			TravPath.AppendToUri("/WhereTimestamp("+Operation+","+Value+")");
			return new FabAppDefinesMemberStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabMemberStep TakeMembers(int Count) {
			TravPath.AppendToUri("/TakeMembers("+Count+")");
			return new FabMemberStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabAppDefinesMemberStep Take(int Count) {
			TravPath.AppendToUri("/Take("+Count+")");
			return new FabAppDefinesMemberStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabAppDefinesMemberStep As(string Alias) {
			TravPath.AppendToUri("/As("+Alias+")");
			return new FabAppDefinesMemberStep(TravPath);
		}
		
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabArtifactStep : ITraversalStep<FabArtifact>, IHasAsStep, IHasBackStep {
		

		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Finds results where the target property is an exact match to the specified value.
		/// </summary>
		/// <remarks>
		///   <para>Finds results where the target property is an exact match to the specified value.</para>
		/// </remarks>
		/// <param name="Value">
		///   The exact value to match for this search.
		/// </param>
		IFabArtifactStep WithId(long Value);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Finds results where the target property is an exact match to the specified value.
		/// </summary>
		/// <remarks>
		///   <para>Finds results where the target property is an exact match to the specified value.</para>
		/// </remarks>
		/// <param name="Value">
		///   The exact value to match for this search.
		/// </param>
		IFabArtifactStep WithVertexType(byte Value);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Finds results where the target property is within the specified range of values.
		/// </summary>
		/// <remarks>
		///   <para>Finds results where the target property is within the specified range of values.</para>
		/// </remarks>
		/// <param name="Operation">
		///   The operator that defines the type of range to use for this search. Options include: "Greater Than", "Less Than or Equal", "Not Equal", etc.
		/// </param>
		/// <param name="Value">
		///   The boundary value for the search range.
		/// </param>
		IFabArtifactStep WhereTimestamp(string Operation, long Value);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Restricts the number of results at the current traversal step.
		/// </summary>
		/// <remarks>
		///   <para>Restricts the number of results at the current traversal step.</para>
		/// </remarks>
		/// <param name="Count">
		///   The maximum number of elements to return.
		/// </param>
		IFabArtifactStep Take(int Count);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Creates a named alias for the current step of the traversal path. Execution of the traversal path can return to this alias using the Back step.
		/// </summary>
		/// <remarks>
		///   <para>Creates a named alias for the current step of the traversal path. Execution of the traversal path can return to this alias using the Back step.</para>
		/// </remarks>
		/// <param name="Alias">
		///   A named alias, which represents a particular place in the traversal path. This value must be unique across all other aliases in the traversal path.
		/// </param>
		IFabArtifactStep As(string Alias);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Casts the results to the specified vertex type, and filters out any results that are incompatible.
		/// </summary>
		/// <remarks>
		///   <para>Casts the results to the specified vertex type, and filters out any results that are incompatible.</para>
		/// </remarks>
		
		IFabAppStep ToApp();
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Casts the results to the specified vertex type, and filters out any results that are incompatible.
		/// </summary>
		/// <remarks>
		///   <para>Casts the results to the specified vertex type, and filters out any results that are incompatible.</para>
		/// </remarks>
		
		IFabClassStep ToClass();
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Casts the results to the specified vertex type, and filters out any results that are incompatible.
		/// </summary>
		/// <remarks>
		///   <para>Casts the results to the specified vertex type, and filters out any results that are incompatible.</para>
		/// </remarks>
		
		IFabInstanceStep ToInstance();
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Casts the results to the specified vertex type, and filters out any results that are incompatible.
		/// </summary>
		/// <remarks>
		///   <para>Casts the results to the specified vertex type, and filters out any results that are incompatible.</para>
		/// </remarks>
		
		IFabUrlStep ToUrl();
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Casts the results to the specified vertex type, and filters out any results that are incompatible.
		/// </summary>
		/// <remarks>
		///   <para>Casts the results to the specified vertex type, and filters out any results that are incompatible.</para>
		/// </remarks>
		
		IFabUserStep ToUser();
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Traverses along an Edge type (connection) between one Vertex and zero, one, or many others. Links which will produce many results require further filtering (via relevant FabLink item) before arriving at the desired Vertex items. To complete this filtering, use the relevant Take step.
		/// </summary>
		/// <remarks>
		///   <para>Traverses along an Edge type (connection) between one Vertex and zero, one, or many others.</para>
	///   <para>Links which will produce many results require further filtering (via relevant FabLink item) before arriving at the desired Vertex items. To complete this filtering, use the relevant Take step.</para>
		/// </remarks>
		
		IFabMemberStep CreatedByMember();
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Traverses along an Edge type (connection) between one Vertex and zero, one, or many others. Links which will produce many results require further filtering (via relevant FabLink item) before arriving at the desired Vertex items. To complete this filtering, use the relevant Take step.
		/// </summary>
		/// <remarks>
		///   <para>Traverses along an Edge type (connection) between one Vertex and zero, one, or many others.</para>
	///   <para>Links which will produce many results require further filtering (via relevant FabLink item) before arriving at the desired Vertex items. To complete this filtering, use the relevant Take step.</para>
		/// </remarks>
		
		IFabArtifactUsedAsPrimaryByFactorStep UsedAsPrimaryByFactors();
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Traverses along an Edge type (connection) between one Vertex and zero, one, or many others. Links which will produce many results require further filtering (via relevant FabLink item) before arriving at the desired Vertex items. To complete this filtering, use the relevant Take step.
		/// </summary>
		/// <remarks>
		///   <para>Traverses along an Edge type (connection) between one Vertex and zero, one, or many others.</para>
	///   <para>Links which will produce many results require further filtering (via relevant FabLink item) before arriving at the desired Vertex items. To complete this filtering, use the relevant Take step.</para>
		/// </remarks>
		
		IFabArtifactUsedAsRelatedByFactorStep UsedAsRelatedByFactors();
	
	}


	/*================================================================================================*/
	internal class FabArtifactStep : TraversalStep<FabArtifact>, IFabArtifactStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabArtifactStep(TraversalPath pTravPath) : base(pTravPath) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public IFabArtifactStep WithId(long Value) {
			TravPath.AppendToUri("/WithId("+Value+")");
			return new FabArtifactStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabArtifactStep WithVertexType(byte Value) {
			TravPath.AppendToUri("/WithVertexType("+Value+")");
			return new FabArtifactStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabArtifactStep WhereTimestamp(string Operation, long Value) {
			TravPath.AppendToUri("/WhereTimestamp("+Operation+","+Value+")");
			return new FabArtifactStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabArtifactStep Take(int Count) {
			TravPath.AppendToUri("/Take("+Count+")");
			return new FabArtifactStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabArtifactStep As(string Alias) {
			TravPath.AppendToUri("/As("+Alias+")");
			return new FabArtifactStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabAppStep ToApp() {
			TravPath.AppendToUri("/ToApp()");
			return new FabAppStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabClassStep ToClass() {
			TravPath.AppendToUri("/ToClass()");
			return new FabClassStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabInstanceStep ToInstance() {
			TravPath.AppendToUri("/ToInstance()");
			return new FabInstanceStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabUrlStep ToUrl() {
			TravPath.AppendToUri("/ToUrl()");
			return new FabUrlStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabUserStep ToUser() {
			TravPath.AppendToUri("/ToUser()");
			return new FabUserStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabMemberStep CreatedByMember() {
			TravPath.AppendToUri("/CreatedByMember()");
			return new FabMemberStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabArtifactUsedAsPrimaryByFactorStep UsedAsPrimaryByFactors() {
			TravPath.AppendToUri("/UsedAsPrimaryByFactors()");
			return new FabArtifactUsedAsPrimaryByFactorStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabArtifactUsedAsRelatedByFactorStep UsedAsRelatedByFactors() {
			TravPath.AppendToUri("/UsedAsRelatedByFactors()");
			return new FabArtifactUsedAsRelatedByFactorStep(TravPath);
		}
		
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabArtifactUsedAsPrimaryByFactorStep : ITraversalStep<FabArtifactUsedAsPrimaryByFactor>, IHasAsStep, IHasBackStep {
		

		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Finds results where the target property is an exact match to the specified value.
		/// </summary>
		/// <remarks>
		///   <para>Finds results where the target property is an exact match to the specified value.</para>
		/// </remarks>
		/// <param name="Value">
		///   The exact value to match for this search.
		/// </param>
		IFabArtifactUsedAsPrimaryByFactorStep WithDescriptorType(byte Value);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Finds results where the target property is an exact match to the specified value.
		/// </summary>
		/// <remarks>
		///   <para>Finds results where the target property is an exact match to the specified value.</para>
		/// </remarks>
		/// <param name="Value">
		///   The exact value to match for this search.
		/// </param>
		IFabArtifactUsedAsPrimaryByFactorStep WithRelatedArtifactId(long Value);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Finds results where the target property is within the specified range of values.
		/// </summary>
		/// <remarks>
		///   <para>Finds results where the target property is within the specified range of values.</para>
		/// </remarks>
		/// <param name="Operation">
		///   The operator that defines the type of range to use for this search. Options include: "Greater Than", "Less Than or Equal", "Not Equal", etc.
		/// </param>
		/// <param name="Value">
		///   The boundary value for the search range.
		/// </param>
		IFabArtifactUsedAsPrimaryByFactorStep WhereTimestamp(string Operation, long Value);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Restricts the number of results at the current traversal step.
		/// </summary>
		/// <remarks>
		///   <para>Restricts the number of results at the current traversal step.</para>
		/// </remarks>
		/// <param name="Count">
		///   The maximum number of elements to return.
		/// </param>
		IFabFactorStep TakeFactors(int Count);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Restricts the number of results at the current traversal step.
		/// </summary>
		/// <remarks>
		///   <para>Restricts the number of results at the current traversal step.</para>
		/// </remarks>
		/// <param name="Count">
		///   The maximum number of elements to return.
		/// </param>
		IFabArtifactUsedAsPrimaryByFactorStep Take(int Count);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Creates a named alias for the current step of the traversal path. Execution of the traversal path can return to this alias using the Back step.
		/// </summary>
		/// <remarks>
		///   <para>Creates a named alias for the current step of the traversal path. Execution of the traversal path can return to this alias using the Back step.</para>
		/// </remarks>
		/// <param name="Alias">
		///   A named alias, which represents a particular place in the traversal path. This value must be unique across all other aliases in the traversal path.
		/// </param>
		IFabArtifactUsedAsPrimaryByFactorStep As(string Alias);
	
	}


	/*================================================================================================*/
	internal class FabArtifactUsedAsPrimaryByFactorStep : TraversalStep<FabArtifactUsedAsPrimaryByFactor>, IFabArtifactUsedAsPrimaryByFactorStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabArtifactUsedAsPrimaryByFactorStep(TraversalPath pTravPath) : base(pTravPath) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public IFabArtifactUsedAsPrimaryByFactorStep WithDescriptorType(byte Value) {
			TravPath.AppendToUri("/WithDescriptorType("+Value+")");
			return new FabArtifactUsedAsPrimaryByFactorStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabArtifactUsedAsPrimaryByFactorStep WithRelatedArtifactId(long Value) {
			TravPath.AppendToUri("/WithRelatedArtifactId("+Value+")");
			return new FabArtifactUsedAsPrimaryByFactorStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabArtifactUsedAsPrimaryByFactorStep WhereTimestamp(string Operation, long Value) {
			TravPath.AppendToUri("/WhereTimestamp("+Operation+","+Value+")");
			return new FabArtifactUsedAsPrimaryByFactorStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabFactorStep TakeFactors(int Count) {
			TravPath.AppendToUri("/TakeFactors("+Count+")");
			return new FabFactorStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabArtifactUsedAsPrimaryByFactorStep Take(int Count) {
			TravPath.AppendToUri("/Take("+Count+")");
			return new FabArtifactUsedAsPrimaryByFactorStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabArtifactUsedAsPrimaryByFactorStep As(string Alias) {
			TravPath.AppendToUri("/As("+Alias+")");
			return new FabArtifactUsedAsPrimaryByFactorStep(TravPath);
		}
		
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabArtifactUsedAsRelatedByFactorStep : ITraversalStep<FabArtifactUsedAsRelatedByFactor>, IHasAsStep, IHasBackStep {
		

		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Finds results where the target property is an exact match to the specified value.
		/// </summary>
		/// <remarks>
		///   <para>Finds results where the target property is an exact match to the specified value.</para>
		/// </remarks>
		/// <param name="Value">
		///   The exact value to match for this search.
		/// </param>
		IFabArtifactUsedAsRelatedByFactorStep WithDescriptorType(byte Value);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Finds results where the target property is an exact match to the specified value.
		/// </summary>
		/// <remarks>
		///   <para>Finds results where the target property is an exact match to the specified value.</para>
		/// </remarks>
		/// <param name="Value">
		///   The exact value to match for this search.
		/// </param>
		IFabArtifactUsedAsRelatedByFactorStep WithPrimaryArtifactId(long Value);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Finds results where the target property is within the specified range of values.
		/// </summary>
		/// <remarks>
		///   <para>Finds results where the target property is within the specified range of values.</para>
		/// </remarks>
		/// <param name="Operation">
		///   The operator that defines the type of range to use for this search. Options include: "Greater Than", "Less Than or Equal", "Not Equal", etc.
		/// </param>
		/// <param name="Value">
		///   The boundary value for the search range.
		/// </param>
		IFabArtifactUsedAsRelatedByFactorStep WhereTimestamp(string Operation, long Value);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Restricts the number of results at the current traversal step.
		/// </summary>
		/// <remarks>
		///   <para>Restricts the number of results at the current traversal step.</para>
		/// </remarks>
		/// <param name="Count">
		///   The maximum number of elements to return.
		/// </param>
		IFabFactorStep TakeFactors(int Count);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Restricts the number of results at the current traversal step.
		/// </summary>
		/// <remarks>
		///   <para>Restricts the number of results at the current traversal step.</para>
		/// </remarks>
		/// <param name="Count">
		///   The maximum number of elements to return.
		/// </param>
		IFabArtifactUsedAsRelatedByFactorStep Take(int Count);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Creates a named alias for the current step of the traversal path. Execution of the traversal path can return to this alias using the Back step.
		/// </summary>
		/// <remarks>
		///   <para>Creates a named alias for the current step of the traversal path. Execution of the traversal path can return to this alias using the Back step.</para>
		/// </remarks>
		/// <param name="Alias">
		///   A named alias, which represents a particular place in the traversal path. This value must be unique across all other aliases in the traversal path.
		/// </param>
		IFabArtifactUsedAsRelatedByFactorStep As(string Alias);
	
	}


	/*================================================================================================*/
	internal class FabArtifactUsedAsRelatedByFactorStep : TraversalStep<FabArtifactUsedAsRelatedByFactor>, IFabArtifactUsedAsRelatedByFactorStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabArtifactUsedAsRelatedByFactorStep(TraversalPath pTravPath) : base(pTravPath) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public IFabArtifactUsedAsRelatedByFactorStep WithDescriptorType(byte Value) {
			TravPath.AppendToUri("/WithDescriptorType("+Value+")");
			return new FabArtifactUsedAsRelatedByFactorStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabArtifactUsedAsRelatedByFactorStep WithPrimaryArtifactId(long Value) {
			TravPath.AppendToUri("/WithPrimaryArtifactId("+Value+")");
			return new FabArtifactUsedAsRelatedByFactorStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabArtifactUsedAsRelatedByFactorStep WhereTimestamp(string Operation, long Value) {
			TravPath.AppendToUri("/WhereTimestamp("+Operation+","+Value+")");
			return new FabArtifactUsedAsRelatedByFactorStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabFactorStep TakeFactors(int Count) {
			TravPath.AppendToUri("/TakeFactors("+Count+")");
			return new FabFactorStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabArtifactUsedAsRelatedByFactorStep Take(int Count) {
			TravPath.AppendToUri("/Take("+Count+")");
			return new FabArtifactUsedAsRelatedByFactorStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabArtifactUsedAsRelatedByFactorStep As(string Alias) {
			TravPath.AppendToUri("/As("+Alias+")");
			return new FabArtifactUsedAsRelatedByFactorStep(TravPath);
		}
		
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabClassStep : ITraversalStep<FabClass>, IHasAsStep, IHasBackStep {
		

		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Finds results where the target property is an exact match to the specified value.
		/// </summary>
		/// <remarks>
		///   <para>Finds results where the target property is an exact match to the specified value.</para>
		/// </remarks>
		/// <param name="Value">
		///   The exact value to match for this search.
		/// </param>
		IFabClassStep WithId(long Value);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Finds results where the target property is an exact match to the specified value.
		/// </summary>
		/// <remarks>
		///   <para>Finds results where the target property is an exact match to the specified value.</para>
		/// </remarks>
		/// <param name="Value">
		///   The exact value to match for this search.
		/// </param>
		IFabClassStep WithVertexType(byte Value);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Finds results where the target property is within the specified range of values.
		/// </summary>
		/// <remarks>
		///   <para>Finds results where the target property is within the specified range of values.</para>
		/// </remarks>
		/// <param name="Operation">
		///   The operator that defines the type of range to use for this search. Options include: "Greater Than", "Less Than or Equal", "Not Equal", etc.
		/// </param>
		/// <param name="Value">
		///   The boundary value for the search range.
		/// </param>
		IFabClassStep WhereTimestamp(string Operation, long Value);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Restricts the number of results at the current traversal step.
		/// </summary>
		/// <remarks>
		///   <para>Restricts the number of results at the current traversal step.</para>
		/// </remarks>
		/// <param name="Count">
		///   The maximum number of elements to return.
		/// </param>
		IFabClassStep Take(int Count);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Creates a named alias for the current step of the traversal path. Execution of the traversal path can return to this alias using the Back step.
		/// </summary>
		/// <remarks>
		///   <para>Creates a named alias for the current step of the traversal path. Execution of the traversal path can return to this alias using the Back step.</para>
		/// </remarks>
		/// <param name="Alias">
		///   A named alias, which represents a particular place in the traversal path. This value must be unique across all other aliases in the traversal path.
		/// </param>
		IFabClassStep As(string Alias);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Traverses along an Edge type (connection) between one Vertex and zero, one, or many others. Links which will produce many results require further filtering (via relevant FabLink item) before arriving at the desired Vertex items. To complete this filtering, use the relevant Take step.
		/// </summary>
		/// <remarks>
		///   <para>Traverses along an Edge type (connection) between one Vertex and zero, one, or many others.</para>
	///   <para>Links which will produce many results require further filtering (via relevant FabLink item) before arriving at the desired Vertex items. To complete this filtering, use the relevant Take step.</para>
		/// </remarks>
		
		IFabMemberStep CreatedByMember();
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Traverses along an Edge type (connection) between one Vertex and zero, one, or many others. Links which will produce many results require further filtering (via relevant FabLink item) before arriving at the desired Vertex items. To complete this filtering, use the relevant Take step.
		/// </summary>
		/// <remarks>
		///   <para>Traverses along an Edge type (connection) between one Vertex and zero, one, or many others.</para>
	///   <para>Links which will produce many results require further filtering (via relevant FabLink item) before arriving at the desired Vertex items. To complete this filtering, use the relevant Take step.</para>
		/// </remarks>
		
		IFabArtifactUsedAsPrimaryByFactorStep UsedAsPrimaryByFactors();
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Traverses along an Edge type (connection) between one Vertex and zero, one, or many others. Links which will produce many results require further filtering (via relevant FabLink item) before arriving at the desired Vertex items. To complete this filtering, use the relevant Take step.
		/// </summary>
		/// <remarks>
		///   <para>Traverses along an Edge type (connection) between one Vertex and zero, one, or many others.</para>
	///   <para>Links which will produce many results require further filtering (via relevant FabLink item) before arriving at the desired Vertex items. To complete this filtering, use the relevant Take step.</para>
		/// </remarks>
		
		IFabArtifactUsedAsRelatedByFactorStep UsedAsRelatedByFactors();
	
	}


	/*================================================================================================*/
	internal class FabClassStep : TraversalStep<FabClass>, IFabClassStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabClassStep(TraversalPath pTravPath) : base(pTravPath) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public IFabClassStep WithId(long Value) {
			TravPath.AppendToUri("/WithId("+Value+")");
			return new FabClassStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabClassStep WithVertexType(byte Value) {
			TravPath.AppendToUri("/WithVertexType("+Value+")");
			return new FabClassStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabClassStep WhereTimestamp(string Operation, long Value) {
			TravPath.AppendToUri("/WhereTimestamp("+Operation+","+Value+")");
			return new FabClassStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabClassStep Take(int Count) {
			TravPath.AppendToUri("/Take("+Count+")");
			return new FabClassStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabClassStep As(string Alias) {
			TravPath.AppendToUri("/As("+Alias+")");
			return new FabClassStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabMemberStep CreatedByMember() {
			TravPath.AppendToUri("/CreatedByMember()");
			return new FabMemberStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabArtifactUsedAsPrimaryByFactorStep UsedAsPrimaryByFactors() {
			TravPath.AppendToUri("/UsedAsPrimaryByFactors()");
			return new FabArtifactUsedAsPrimaryByFactorStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabArtifactUsedAsRelatedByFactorStep UsedAsRelatedByFactors() {
			TravPath.AppendToUri("/UsedAsRelatedByFactors()");
			return new FabArtifactUsedAsRelatedByFactorStep(TravPath);
		}
		
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabElementStep : ITraversalStep<FabElement>, IHasAsStep, IHasBackStep {
		

		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Restricts the number of results at the current traversal step.
		/// </summary>
		/// <remarks>
		///   <para>Restricts the number of results at the current traversal step.</para>
		/// </remarks>
		/// <param name="Count">
		///   The maximum number of elements to return.
		/// </param>
		IFabElementStep Take(int Count);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Creates a named alias for the current step of the traversal path. Execution of the traversal path can return to this alias using the Back step.
		/// </summary>
		/// <remarks>
		///   <para>Creates a named alias for the current step of the traversal path. Execution of the traversal path can return to this alias using the Back step.</para>
		/// </remarks>
		/// <param name="Alias">
		///   A named alias, which represents a particular place in the traversal path. This value must be unique across all other aliases in the traversal path.
		/// </param>
		IFabElementStep As(string Alias);
	
	}


	/*================================================================================================*/
	internal class FabElementStep : TraversalStep<FabElement>, IFabElementStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabElementStep(TraversalPath pTravPath) : base(pTravPath) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public IFabElementStep Take(int Count) {
			TravPath.AppendToUri("/Take("+Count+")");
			return new FabElementStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabElementStep As(string Alias) {
			TravPath.AppendToUri("/As("+Alias+")");
			return new FabElementStep(TravPath);
		}
		
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabFactorStep : ITraversalStep<FabFactor>, IHasAsStep, IHasBackStep {
		

		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Finds results where the target property is an exact match to the specified value.
		/// </summary>
		/// <remarks>
		///   <para>Finds results where the target property is an exact match to the specified value.</para>
		/// </remarks>
		/// <param name="Value">
		///   The exact value to match for this search.
		/// </param>
		IFabFactorStep WithAssertionType(byte Value);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Finds results where the target property is an exact match to the specified value.
		/// </summary>
		/// <remarks>
		///   <para>Finds results where the target property is an exact match to the specified value.</para>
		/// </remarks>
		/// <param name="Value">
		///   The exact value to match for this search.
		/// </param>
		IFabFactorStep WithIsDefining(bool Value);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Finds results where the target property is an exact match to the specified value.
		/// </summary>
		/// <remarks>
		///   <para>Finds results where the target property is an exact match to the specified value.</para>
		/// </remarks>
		/// <param name="Value">
		///   The exact value to match for this search.
		/// </param>
		IFabFactorStep WithDescriptorType(byte Value);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Finds results where the target property is an exact match to the specified value.
		/// </summary>
		/// <remarks>
		///   <para>Finds results where the target property is an exact match to the specified value.</para>
		/// </remarks>
		/// <param name="Value">
		///   The exact value to match for this search.
		/// </param>
		IFabFactorStep WithDirectorType(byte Value);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Finds results where the target property is an exact match to the specified value.
		/// </summary>
		/// <remarks>
		///   <para>Finds results where the target property is an exact match to the specified value.</para>
		/// </remarks>
		/// <param name="Value">
		///   The exact value to match for this search.
		/// </param>
		IFabFactorStep WithDirectorPrimaryAction(byte Value);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Finds results where the target property is an exact match to the specified value.
		/// </summary>
		/// <remarks>
		///   <para>Finds results where the target property is an exact match to the specified value.</para>
		/// </remarks>
		/// <param name="Value">
		///   The exact value to match for this search.
		/// </param>
		IFabFactorStep WithDirectorRelatedAction(byte Value);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Finds results where the target property is an exact match to the specified value.
		/// </summary>
		/// <remarks>
		///   <para>Finds results where the target property is an exact match to the specified value.</para>
		/// </remarks>
		/// <param name="Value">
		///   The exact value to match for this search.
		/// </param>
		IFabFactorStep WithEventorType(byte Value);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Finds results where the target property is an exact match to the specified value.
		/// </summary>
		/// <remarks>
		///   <para>Finds results where the target property is an exact match to the specified value.</para>
		/// </remarks>
		/// <param name="Value">
		///   The exact value to match for this search.
		/// </param>
		IFabFactorStep WithIdentorType(byte Value);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Finds results where the target property is an exact match to the specified value.
		/// </summary>
		/// <remarks>
		///   <para>Finds results where the target property is an exact match to the specified value.</para>
		/// </remarks>
		/// <param name="Value">
		///   The exact value to match for this search.
		/// </param>
		IFabFactorStep WithIdentorValue(string Value);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Finds results where the target property is an exact match to the specified value.
		/// </summary>
		/// <remarks>
		///   <para>Finds results where the target property is an exact match to the specified value.</para>
		/// </remarks>
		/// <param name="Value">
		///   The exact value to match for this search.
		/// </param>
		IFabFactorStep WithLocatorType(byte Value);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Finds results where the target property is an exact match to the specified value.
		/// </summary>
		/// <remarks>
		///   <para>Finds results where the target property is an exact match to the specified value.</para>
		/// </remarks>
		/// <param name="Value">
		///   The exact value to match for this search.
		/// </param>
		IFabFactorStep WithVectorType(byte Value);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Finds results where the target property is an exact match to the specified value.
		/// </summary>
		/// <remarks>
		///   <para>Finds results where the target property is an exact match to the specified value.</para>
		/// </remarks>
		/// <param name="Value">
		///   The exact value to match for this search.
		/// </param>
		IFabFactorStep WithVectorUnit(byte Value);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Finds results where the target property is an exact match to the specified value.
		/// </summary>
		/// <remarks>
		///   <para>Finds results where the target property is an exact match to the specified value.</para>
		/// </remarks>
		/// <param name="Value">
		///   The exact value to match for this search.
		/// </param>
		IFabFactorStep WithVectorUnitPrefix(byte Value);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Finds results where the target property is an exact match to the specified value.
		/// </summary>
		/// <remarks>
		///   <para>Finds results where the target property is an exact match to the specified value.</para>
		/// </remarks>
		/// <param name="Value">
		///   The exact value to match for this search.
		/// </param>
		IFabFactorStep WithId(long Value);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Finds results where the target property is an exact match to the specified value.
		/// </summary>
		/// <remarks>
		///   <para>Finds results where the target property is an exact match to the specified value.</para>
		/// </remarks>
		/// <param name="Value">
		///   The exact value to match for this search.
		/// </param>
		IFabFactorStep WithVertexType(byte Value);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Finds results where the target property is within the specified range of values.
		/// </summary>
		/// <remarks>
		///   <para>Finds results where the target property is within the specified range of values.</para>
		/// </remarks>
		/// <param name="Operation">
		///   The operator that defines the type of range to use for this search. Options include: "Greater Than", "Less Than or Equal", "Not Equal", etc.
		/// </param>
		/// <param name="Value">
		///   The boundary value for the search range.
		/// </param>
		IFabFactorStep WhereLocatorValueX(string Operation, double Value);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Finds results where the target property is within the specified range of values.
		/// </summary>
		/// <remarks>
		///   <para>Finds results where the target property is within the specified range of values.</para>
		/// </remarks>
		/// <param name="Operation">
		///   The operator that defines the type of range to use for this search. Options include: "Greater Than", "Less Than or Equal", "Not Equal", etc.
		/// </param>
		/// <param name="Value">
		///   The boundary value for the search range.
		/// </param>
		IFabFactorStep WhereLocatorValueY(string Operation, double Value);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Finds results where the target property is within the specified range of values.
		/// </summary>
		/// <remarks>
		///   <para>Finds results where the target property is within the specified range of values.</para>
		/// </remarks>
		/// <param name="Operation">
		///   The operator that defines the type of range to use for this search. Options include: "Greater Than", "Less Than or Equal", "Not Equal", etc.
		/// </param>
		/// <param name="Value">
		///   The boundary value for the search range.
		/// </param>
		IFabFactorStep WhereLocatorValueZ(string Operation, double Value);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Finds results where the target property is within the specified range of values.
		/// </summary>
		/// <remarks>
		///   <para>Finds results where the target property is within the specified range of values.</para>
		/// </remarks>
		/// <param name="Operation">
		///   The operator that defines the type of range to use for this search. Options include: "Greater Than", "Less Than or Equal", "Not Equal", etc.
		/// </param>
		/// <param name="Value">
		///   The boundary value for the search range.
		/// </param>
		IFabFactorStep WhereVectorValue(string Operation, long Value);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Finds results where the target property is within the specified range of values.
		/// </summary>
		/// <remarks>
		///   <para>Finds results where the target property is within the specified range of values.</para>
		/// </remarks>
		/// <param name="Operation">
		///   The operator that defines the type of range to use for this search. Options include: "Greater Than", "Less Than or Equal", "Not Equal", etc.
		/// </param>
		/// <param name="Value">
		///   The boundary value for the search range.
		/// </param>
		IFabFactorStep WhereTimestamp(string Operation, long Value);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Restricts the number of results at the current traversal step.
		/// </summary>
		/// <remarks>
		///   <para>Restricts the number of results at the current traversal step.</para>
		/// </remarks>
		/// <param name="Count">
		///   The maximum number of elements to return.
		/// </param>
		IFabFactorStep Take(int Count);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Creates a named alias for the current step of the traversal path. Execution of the traversal path can return to this alias using the Back step.
		/// </summary>
		/// <remarks>
		///   <para>Creates a named alias for the current step of the traversal path. Execution of the traversal path can return to this alias using the Back step.</para>
		/// </remarks>
		/// <param name="Alias">
		///   A named alias, which represents a particular place in the traversal path. This value must be unique across all other aliases in the traversal path.
		/// </param>
		IFabFactorStep As(string Alias);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Traverses along an Edge type (connection) between one Vertex and zero, one, or many others. Links which will produce many results require further filtering (via relevant FabLink item) before arriving at the desired Vertex items. To complete this filtering, use the relevant Take step.
		/// </summary>
		/// <remarks>
		///   <para>Traverses along an Edge type (connection) between one Vertex and zero, one, or many others.</para>
	///   <para>Links which will produce many results require further filtering (via relevant FabLink item) before arriving at the desired Vertex items. To complete this filtering, use the relevant Take step.</para>
		/// </remarks>
		
		IFabMemberStep CreatedByMember();
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Traverses along an Edge type (connection) between one Vertex and zero, one, or many others. Links which will produce many results require further filtering (via relevant FabLink item) before arriving at the desired Vertex items. To complete this filtering, use the relevant Take step.
		/// </summary>
		/// <remarks>
		///   <para>Traverses along an Edge type (connection) between one Vertex and zero, one, or many others.</para>
	///   <para>Links which will produce many results require further filtering (via relevant FabLink item) before arriving at the desired Vertex items. To complete this filtering, use the relevant Take step.</para>
		/// </remarks>
		
		IFabArtifactStep RefinesPrimaryWithArtifact();
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Traverses along an Edge type (connection) between one Vertex and zero, one, or many others. Links which will produce many results require further filtering (via relevant FabLink item) before arriving at the desired Vertex items. To complete this filtering, use the relevant Take step.
		/// </summary>
		/// <remarks>
		///   <para>Traverses along an Edge type (connection) between one Vertex and zero, one, or many others.</para>
	///   <para>Links which will produce many results require further filtering (via relevant FabLink item) before arriving at the desired Vertex items. To complete this filtering, use the relevant Take step.</para>
		/// </remarks>
		
		IFabArtifactStep RefinesRelatedWithArtifact();
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Traverses along an Edge type (connection) between one Vertex and zero, one, or many others. Links which will produce many results require further filtering (via relevant FabLink item) before arriving at the desired Vertex items. To complete this filtering, use the relevant Take step.
		/// </summary>
		/// <remarks>
		///   <para>Traverses along an Edge type (connection) between one Vertex and zero, one, or many others.</para>
	///   <para>Links which will produce many results require further filtering (via relevant FabLink item) before arriving at the desired Vertex items. To complete this filtering, use the relevant Take step.</para>
		/// </remarks>
		
		IFabArtifactStep RefinesTypeWithArtifact();
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Traverses along an Edge type (connection) between one Vertex and zero, one, or many others. Links which will produce many results require further filtering (via relevant FabLink item) before arriving at the desired Vertex items. To complete this filtering, use the relevant Take step.
		/// </summary>
		/// <remarks>
		///   <para>Traverses along an Edge type (connection) between one Vertex and zero, one, or many others.</para>
	///   <para>Links which will produce many results require further filtering (via relevant FabLink item) before arriving at the desired Vertex items. To complete this filtering, use the relevant Take step.</para>
		/// </remarks>
		
		IFabArtifactStep UsesPrimaryArtifact();
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Traverses along an Edge type (connection) between one Vertex and zero, one, or many others. Links which will produce many results require further filtering (via relevant FabLink item) before arriving at the desired Vertex items. To complete this filtering, use the relevant Take step.
		/// </summary>
		/// <remarks>
		///   <para>Traverses along an Edge type (connection) between one Vertex and zero, one, or many others.</para>
	///   <para>Links which will produce many results require further filtering (via relevant FabLink item) before arriving at the desired Vertex items. To complete this filtering, use the relevant Take step.</para>
		/// </remarks>
		
		IFabArtifactStep UsesRelatedArtifact();
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Traverses along an Edge type (connection) between one Vertex and zero, one, or many others. Links which will produce many results require further filtering (via relevant FabLink item) before arriving at the desired Vertex items. To complete this filtering, use the relevant Take step.
		/// </summary>
		/// <remarks>
		///   <para>Traverses along an Edge type (connection) between one Vertex and zero, one, or many others.</para>
	///   <para>Links which will produce many results require further filtering (via relevant FabLink item) before arriving at the desired Vertex items. To complete this filtering, use the relevant Take step.</para>
		/// </remarks>
		
		IFabArtifactStep UsesAxisArtifact();
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   TODO
		/// </summary>
		/// <remarks>
		///   <para>TODO</para>
		/// </remarks>
		/// <param name="Operation">
		///   TODO
		/// </param>
		/// <param name="Year">
		///   TODO
		/// </param>
		/// <param name="Month">
		///   TODO
		/// </param>
		/// <param name="Day">
		///   TODO
		/// </param>
		/// <param name="Hour">
		///   TODO
		/// </param>
		/// <param name="Minute">
		///   TODO
		/// </param>
		/// <param name="Second">
		///   TODO
		/// </param>
		IFabFactorStep WhereEventorDateTime(string Operation, long Year, byte Month, byte Day, byte Hour, byte Minute, byte Second);
	
	}


	/*================================================================================================*/
	internal class FabFactorStep : TraversalStep<FabFactor>, IFabFactorStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabFactorStep(TraversalPath pTravPath) : base(pTravPath) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public IFabFactorStep WithAssertionType(byte Value) {
			TravPath.AppendToUri("/WithAssertionType("+Value+")");
			return new FabFactorStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabFactorStep WithIsDefining(bool Value) {
			TravPath.AppendToUri("/WithIsDefining("+Value+")");
			return new FabFactorStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabFactorStep WithDescriptorType(byte Value) {
			TravPath.AppendToUri("/WithDescriptorType("+Value+")");
			return new FabFactorStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabFactorStep WithDirectorType(byte Value) {
			TravPath.AppendToUri("/WithDirectorType("+Value+")");
			return new FabFactorStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabFactorStep WithDirectorPrimaryAction(byte Value) {
			TravPath.AppendToUri("/WithDirectorPrimaryAction("+Value+")");
			return new FabFactorStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabFactorStep WithDirectorRelatedAction(byte Value) {
			TravPath.AppendToUri("/WithDirectorRelatedAction("+Value+")");
			return new FabFactorStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabFactorStep WithEventorType(byte Value) {
			TravPath.AppendToUri("/WithEventorType("+Value+")");
			return new FabFactorStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabFactorStep WithIdentorType(byte Value) {
			TravPath.AppendToUri("/WithIdentorType("+Value+")");
			return new FabFactorStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabFactorStep WithIdentorValue(string Value) {
			TravPath.AppendToUri("/WithIdentorValue("+Value+")");
			return new FabFactorStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabFactorStep WithLocatorType(byte Value) {
			TravPath.AppendToUri("/WithLocatorType("+Value+")");
			return new FabFactorStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabFactorStep WithVectorType(byte Value) {
			TravPath.AppendToUri("/WithVectorType("+Value+")");
			return new FabFactorStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabFactorStep WithVectorUnit(byte Value) {
			TravPath.AppendToUri("/WithVectorUnit("+Value+")");
			return new FabFactorStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabFactorStep WithVectorUnitPrefix(byte Value) {
			TravPath.AppendToUri("/WithVectorUnitPrefix("+Value+")");
			return new FabFactorStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabFactorStep WithId(long Value) {
			TravPath.AppendToUri("/WithId("+Value+")");
			return new FabFactorStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabFactorStep WithVertexType(byte Value) {
			TravPath.AppendToUri("/WithVertexType("+Value+")");
			return new FabFactorStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabFactorStep WhereLocatorValueX(string Operation, double Value) {
			TravPath.AppendToUri("/WhereLocatorValueX("+Operation+","+Value+")");
			return new FabFactorStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabFactorStep WhereLocatorValueY(string Operation, double Value) {
			TravPath.AppendToUri("/WhereLocatorValueY("+Operation+","+Value+")");
			return new FabFactorStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabFactorStep WhereLocatorValueZ(string Operation, double Value) {
			TravPath.AppendToUri("/WhereLocatorValueZ("+Operation+","+Value+")");
			return new FabFactorStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabFactorStep WhereVectorValue(string Operation, long Value) {
			TravPath.AppendToUri("/WhereVectorValue("+Operation+","+Value+")");
			return new FabFactorStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabFactorStep WhereTimestamp(string Operation, long Value) {
			TravPath.AppendToUri("/WhereTimestamp("+Operation+","+Value+")");
			return new FabFactorStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabFactorStep Take(int Count) {
			TravPath.AppendToUri("/Take("+Count+")");
			return new FabFactorStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabFactorStep As(string Alias) {
			TravPath.AppendToUri("/As("+Alias+")");
			return new FabFactorStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabMemberStep CreatedByMember() {
			TravPath.AppendToUri("/CreatedByMember()");
			return new FabMemberStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabArtifactStep RefinesPrimaryWithArtifact() {
			TravPath.AppendToUri("/RefinesPrimaryWithArtifact()");
			return new FabArtifactStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabArtifactStep RefinesRelatedWithArtifact() {
			TravPath.AppendToUri("/RefinesRelatedWithArtifact()");
			return new FabArtifactStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabArtifactStep RefinesTypeWithArtifact() {
			TravPath.AppendToUri("/RefinesTypeWithArtifact()");
			return new FabArtifactStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabArtifactStep UsesPrimaryArtifact() {
			TravPath.AppendToUri("/UsesPrimaryArtifact()");
			return new FabArtifactStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabArtifactStep UsesRelatedArtifact() {
			TravPath.AppendToUri("/UsesRelatedArtifact()");
			return new FabArtifactStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabArtifactStep UsesAxisArtifact() {
			TravPath.AppendToUri("/UsesAxisArtifact()");
			return new FabArtifactStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabFactorStep WhereEventorDateTime(string Operation, long Year, byte Month, byte Day, byte Hour, byte Minute, byte Second) {
			TravPath.AppendToUri("/WhereEventorDateTime("+Operation+","+Year+","+Month+","+Day+","+Hour+","+Minute+","+Second+")");
			return new FabFactorStep(TravPath);
		}
		
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabInstanceStep : ITraversalStep<FabInstance>, IHasAsStep, IHasBackStep {
		

		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Finds results where the target property is an exact match to the specified value.
		/// </summary>
		/// <remarks>
		///   <para>Finds results where the target property is an exact match to the specified value.</para>
		/// </remarks>
		/// <param name="Value">
		///   The exact value to match for this search.
		/// </param>
		IFabInstanceStep WithId(long Value);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Finds results where the target property is an exact match to the specified value.
		/// </summary>
		/// <remarks>
		///   <para>Finds results where the target property is an exact match to the specified value.</para>
		/// </remarks>
		/// <param name="Value">
		///   The exact value to match for this search.
		/// </param>
		IFabInstanceStep WithVertexType(byte Value);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Finds results where the target property is within the specified range of values.
		/// </summary>
		/// <remarks>
		///   <para>Finds results where the target property is within the specified range of values.</para>
		/// </remarks>
		/// <param name="Operation">
		///   The operator that defines the type of range to use for this search. Options include: "Greater Than", "Less Than or Equal", "Not Equal", etc.
		/// </param>
		/// <param name="Value">
		///   The boundary value for the search range.
		/// </param>
		IFabInstanceStep WhereTimestamp(string Operation, long Value);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Restricts the number of results at the current traversal step.
		/// </summary>
		/// <remarks>
		///   <para>Restricts the number of results at the current traversal step.</para>
		/// </remarks>
		/// <param name="Count">
		///   The maximum number of elements to return.
		/// </param>
		IFabInstanceStep Take(int Count);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Creates a named alias for the current step of the traversal path. Execution of the traversal path can return to this alias using the Back step.
		/// </summary>
		/// <remarks>
		///   <para>Creates a named alias for the current step of the traversal path. Execution of the traversal path can return to this alias using the Back step.</para>
		/// </remarks>
		/// <param name="Alias">
		///   A named alias, which represents a particular place in the traversal path. This value must be unique across all other aliases in the traversal path.
		/// </param>
		IFabInstanceStep As(string Alias);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Traverses along an Edge type (connection) between one Vertex and zero, one, or many others. Links which will produce many results require further filtering (via relevant FabLink item) before arriving at the desired Vertex items. To complete this filtering, use the relevant Take step.
		/// </summary>
		/// <remarks>
		///   <para>Traverses along an Edge type (connection) between one Vertex and zero, one, or many others.</para>
	///   <para>Links which will produce many results require further filtering (via relevant FabLink item) before arriving at the desired Vertex items. To complete this filtering, use the relevant Take step.</para>
		/// </remarks>
		
		IFabMemberStep CreatedByMember();
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Traverses along an Edge type (connection) between one Vertex and zero, one, or many others. Links which will produce many results require further filtering (via relevant FabLink item) before arriving at the desired Vertex items. To complete this filtering, use the relevant Take step.
		/// </summary>
		/// <remarks>
		///   <para>Traverses along an Edge type (connection) between one Vertex and zero, one, or many others.</para>
	///   <para>Links which will produce many results require further filtering (via relevant FabLink item) before arriving at the desired Vertex items. To complete this filtering, use the relevant Take step.</para>
		/// </remarks>
		
		IFabArtifactUsedAsPrimaryByFactorStep UsedAsPrimaryByFactors();
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Traverses along an Edge type (connection) between one Vertex and zero, one, or many others. Links which will produce many results require further filtering (via relevant FabLink item) before arriving at the desired Vertex items. To complete this filtering, use the relevant Take step.
		/// </summary>
		/// <remarks>
		///   <para>Traverses along an Edge type (connection) between one Vertex and zero, one, or many others.</para>
	///   <para>Links which will produce many results require further filtering (via relevant FabLink item) before arriving at the desired Vertex items. To complete this filtering, use the relevant Take step.</para>
		/// </remarks>
		
		IFabArtifactUsedAsRelatedByFactorStep UsedAsRelatedByFactors();
	
	}


	/*================================================================================================*/
	internal class FabInstanceStep : TraversalStep<FabInstance>, IFabInstanceStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabInstanceStep(TraversalPath pTravPath) : base(pTravPath) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public IFabInstanceStep WithId(long Value) {
			TravPath.AppendToUri("/WithId("+Value+")");
			return new FabInstanceStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabInstanceStep WithVertexType(byte Value) {
			TravPath.AppendToUri("/WithVertexType("+Value+")");
			return new FabInstanceStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabInstanceStep WhereTimestamp(string Operation, long Value) {
			TravPath.AppendToUri("/WhereTimestamp("+Operation+","+Value+")");
			return new FabInstanceStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabInstanceStep Take(int Count) {
			TravPath.AppendToUri("/Take("+Count+")");
			return new FabInstanceStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabInstanceStep As(string Alias) {
			TravPath.AppendToUri("/As("+Alias+")");
			return new FabInstanceStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabMemberStep CreatedByMember() {
			TravPath.AppendToUri("/CreatedByMember()");
			return new FabMemberStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabArtifactUsedAsPrimaryByFactorStep UsedAsPrimaryByFactors() {
			TravPath.AppendToUri("/UsedAsPrimaryByFactors()");
			return new FabArtifactUsedAsPrimaryByFactorStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabArtifactUsedAsRelatedByFactorStep UsedAsRelatedByFactors() {
			TravPath.AppendToUri("/UsedAsRelatedByFactors()");
			return new FabArtifactUsedAsRelatedByFactorStep(TravPath);
		}
		
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabLinkStep : ITraversalStep<FabLink>, IHasAsStep, IHasBackStep {
		

		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Restricts the number of results at the current traversal step.
		/// </summary>
		/// <remarks>
		///   <para>Restricts the number of results at the current traversal step.</para>
		/// </remarks>
		/// <param name="Count">
		///   The maximum number of elements to return.
		/// </param>
		IFabLinkStep Take(int Count);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Creates a named alias for the current step of the traversal path. Execution of the traversal path can return to this alias using the Back step.
		/// </summary>
		/// <remarks>
		///   <para>Creates a named alias for the current step of the traversal path. Execution of the traversal path can return to this alias using the Back step.</para>
		/// </remarks>
		/// <param name="Alias">
		///   A named alias, which represents a particular place in the traversal path. This value must be unique across all other aliases in the traversal path.
		/// </param>
		IFabLinkStep As(string Alias);
	
	}


	/*================================================================================================*/
	internal class FabLinkStep : TraversalStep<FabLink>, IFabLinkStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabLinkStep(TraversalPath pTravPath) : base(pTravPath) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public IFabLinkStep Take(int Count) {
			TravPath.AppendToUri("/Take("+Count+")");
			return new FabLinkStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabLinkStep As(string Alias) {
			TravPath.AppendToUri("/As("+Alias+")");
			return new FabLinkStep(TravPath);
		}
		
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabMemberStep : ITraversalStep<FabMember>, IHasAsStep, IHasBackStep {
		

		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Finds results where the target property is an exact match to the specified value.
		/// </summary>
		/// <remarks>
		///   <para>Finds results where the target property is an exact match to the specified value.</para>
		/// </remarks>
		/// <param name="Value">
		///   The exact value to match for this search.
		/// </param>
		IFabMemberStep WithType(byte Value);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Finds results where the target property is an exact match to the specified value.
		/// </summary>
		/// <remarks>
		///   <para>Finds results where the target property is an exact match to the specified value.</para>
		/// </remarks>
		/// <param name="Value">
		///   The exact value to match for this search.
		/// </param>
		IFabMemberStep WithId(long Value);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Finds results where the target property is an exact match to the specified value.
		/// </summary>
		/// <remarks>
		///   <para>Finds results where the target property is an exact match to the specified value.</para>
		/// </remarks>
		/// <param name="Value">
		///   The exact value to match for this search.
		/// </param>
		IFabMemberStep WithVertexType(byte Value);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Finds results where the target property is within the specified range of values.
		/// </summary>
		/// <remarks>
		///   <para>Finds results where the target property is within the specified range of values.</para>
		/// </remarks>
		/// <param name="Operation">
		///   The operator that defines the type of range to use for this search. Options include: "Greater Than", "Less Than or Equal", "Not Equal", etc.
		/// </param>
		/// <param name="Value">
		///   The boundary value for the search range.
		/// </param>
		IFabMemberStep WhereTimestamp(string Operation, long Value);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Restricts the number of results at the current traversal step.
		/// </summary>
		/// <remarks>
		///   <para>Restricts the number of results at the current traversal step.</para>
		/// </remarks>
		/// <param name="Count">
		///   The maximum number of elements to return.
		/// </param>
		IFabMemberStep Take(int Count);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Creates a named alias for the current step of the traversal path. Execution of the traversal path can return to this alias using the Back step.
		/// </summary>
		/// <remarks>
		///   <para>Creates a named alias for the current step of the traversal path. Execution of the traversal path can return to this alias using the Back step.</para>
		/// </remarks>
		/// <param name="Alias">
		///   A named alias, which represents a particular place in the traversal path. This value must be unique across all other aliases in the traversal path.
		/// </param>
		IFabMemberStep As(string Alias);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Traverses along an Edge type (connection) between one Vertex and zero, one, or many others. Links which will produce many results require further filtering (via relevant FabLink item) before arriving at the desired Vertex items. To complete this filtering, use the relevant Take step.
		/// </summary>
		/// <remarks>
		///   <para>Traverses along an Edge type (connection) between one Vertex and zero, one, or many others.</para>
	///   <para>Links which will produce many results require further filtering (via relevant FabLink item) before arriving at the desired Vertex items. To complete this filtering, use the relevant Take step.</para>
		/// </remarks>
		
		IFabMemberCreatesArtifactStep CreatesArtifacts();
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Traverses along an Edge type (connection) between one Vertex and zero, one, or many others. Links which will produce many results require further filtering (via relevant FabLink item) before arriving at the desired Vertex items. To complete this filtering, use the relevant Take step.
		/// </summary>
		/// <remarks>
		///   <para>Traverses along an Edge type (connection) between one Vertex and zero, one, or many others.</para>
	///   <para>Links which will produce many results require further filtering (via relevant FabLink item) before arriving at the desired Vertex items. To complete this filtering, use the relevant Take step.</para>
		/// </remarks>
		
		IFabMemberCreatesFactorStep CreatesFactors();
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Traverses along an Edge type (connection) between one Vertex and zero, one, or many others. Links which will produce many results require further filtering (via relevant FabLink item) before arriving at the desired Vertex items. To complete this filtering, use the relevant Take step.
		/// </summary>
		/// <remarks>
		///   <para>Traverses along an Edge type (connection) between one Vertex and zero, one, or many others.</para>
	///   <para>Links which will produce many results require further filtering (via relevant FabLink item) before arriving at the desired Vertex items. To complete this filtering, use the relevant Take step.</para>
		/// </remarks>
		
		IFabAppStep DefinedByApp();
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Traverses along an Edge type (connection) between one Vertex and zero, one, or many others. Links which will produce many results require further filtering (via relevant FabLink item) before arriving at the desired Vertex items. To complete this filtering, use the relevant Take step.
		/// </summary>
		/// <remarks>
		///   <para>Traverses along an Edge type (connection) between one Vertex and zero, one, or many others.</para>
	///   <para>Links which will produce many results require further filtering (via relevant FabLink item) before arriving at the desired Vertex items. To complete this filtering, use the relevant Take step.</para>
		/// </remarks>
		
		IFabUserStep DefinedByUser();
	
	}


	/*================================================================================================*/
	internal class FabMemberStep : TraversalStep<FabMember>, IFabMemberStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabMemberStep(TraversalPath pTravPath) : base(pTravPath) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public IFabMemberStep WithType(byte Value) {
			TravPath.AppendToUri("/WithType("+Value+")");
			return new FabMemberStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabMemberStep WithId(long Value) {
			TravPath.AppendToUri("/WithId("+Value+")");
			return new FabMemberStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabMemberStep WithVertexType(byte Value) {
			TravPath.AppendToUri("/WithVertexType("+Value+")");
			return new FabMemberStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabMemberStep WhereTimestamp(string Operation, long Value) {
			TravPath.AppendToUri("/WhereTimestamp("+Operation+","+Value+")");
			return new FabMemberStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabMemberStep Take(int Count) {
			TravPath.AppendToUri("/Take("+Count+")");
			return new FabMemberStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabMemberStep As(string Alias) {
			TravPath.AppendToUri("/As("+Alias+")");
			return new FabMemberStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabMemberCreatesArtifactStep CreatesArtifacts() {
			TravPath.AppendToUri("/CreatesArtifacts()");
			return new FabMemberCreatesArtifactStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabMemberCreatesFactorStep CreatesFactors() {
			TravPath.AppendToUri("/CreatesFactors()");
			return new FabMemberCreatesFactorStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabAppStep DefinedByApp() {
			TravPath.AppendToUri("/DefinedByApp()");
			return new FabAppStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabUserStep DefinedByUser() {
			TravPath.AppendToUri("/DefinedByUser()");
			return new FabUserStep(TravPath);
		}
		
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabMemberCreatesArtifactStep : ITraversalStep<FabMemberCreatesArtifact>, IHasAsStep, IHasBackStep {
		

		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Finds results where the target property is an exact match to the specified value.
		/// </summary>
		/// <remarks>
		///   <para>Finds results where the target property is an exact match to the specified value.</para>
		/// </remarks>
		/// <param name="Value">
		///   The exact value to match for this search.
		/// </param>
		IFabMemberCreatesArtifactStep WithVertexType(byte Value);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Finds results where the target property is within the specified range of values.
		/// </summary>
		/// <remarks>
		///   <para>Finds results where the target property is within the specified range of values.</para>
		/// </remarks>
		/// <param name="Operation">
		///   The operator that defines the type of range to use for this search. Options include: "Greater Than", "Less Than or Equal", "Not Equal", etc.
		/// </param>
		/// <param name="Value">
		///   The boundary value for the search range.
		/// </param>
		IFabMemberCreatesArtifactStep WhereTimestamp(string Operation, long Value);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Restricts the number of results at the current traversal step.
		/// </summary>
		/// <remarks>
		///   <para>Restricts the number of results at the current traversal step.</para>
		/// </remarks>
		/// <param name="Count">
		///   The maximum number of elements to return.
		/// </param>
		IFabArtifactStep TakeArtifacts(int Count);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Restricts the number of results at the current traversal step.
		/// </summary>
		/// <remarks>
		///   <para>Restricts the number of results at the current traversal step.</para>
		/// </remarks>
		/// <param name="Count">
		///   The maximum number of elements to return.
		/// </param>
		IFabMemberCreatesArtifactStep Take(int Count);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Creates a named alias for the current step of the traversal path. Execution of the traversal path can return to this alias using the Back step.
		/// </summary>
		/// <remarks>
		///   <para>Creates a named alias for the current step of the traversal path. Execution of the traversal path can return to this alias using the Back step.</para>
		/// </remarks>
		/// <param name="Alias">
		///   A named alias, which represents a particular place in the traversal path. This value must be unique across all other aliases in the traversal path.
		/// </param>
		IFabMemberCreatesArtifactStep As(string Alias);
	
	}


	/*================================================================================================*/
	internal class FabMemberCreatesArtifactStep : TraversalStep<FabMemberCreatesArtifact>, IFabMemberCreatesArtifactStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabMemberCreatesArtifactStep(TraversalPath pTravPath) : base(pTravPath) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public IFabMemberCreatesArtifactStep WithVertexType(byte Value) {
			TravPath.AppendToUri("/WithVertexType("+Value+")");
			return new FabMemberCreatesArtifactStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabMemberCreatesArtifactStep WhereTimestamp(string Operation, long Value) {
			TravPath.AppendToUri("/WhereTimestamp("+Operation+","+Value+")");
			return new FabMemberCreatesArtifactStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabArtifactStep TakeArtifacts(int Count) {
			TravPath.AppendToUri("/TakeArtifacts("+Count+")");
			return new FabArtifactStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabMemberCreatesArtifactStep Take(int Count) {
			TravPath.AppendToUri("/Take("+Count+")");
			return new FabMemberCreatesArtifactStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabMemberCreatesArtifactStep As(string Alias) {
			TravPath.AppendToUri("/As("+Alias+")");
			return new FabMemberCreatesArtifactStep(TravPath);
		}
		
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabMemberCreatesFactorStep : ITraversalStep<FabMemberCreatesFactor>, IHasAsStep, IHasBackStep {
		

		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Finds results where the target property is an exact match to the specified value.
		/// </summary>
		/// <remarks>
		///   <para>Finds results where the target property is an exact match to the specified value.</para>
		/// </remarks>
		/// <param name="Value">
		///   The exact value to match for this search.
		/// </param>
		IFabMemberCreatesFactorStep WithDescriptorType(byte Value);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Finds results where the target property is an exact match to the specified value.
		/// </summary>
		/// <remarks>
		///   <para>Finds results where the target property is an exact match to the specified value.</para>
		/// </remarks>
		/// <param name="Value">
		///   The exact value to match for this search.
		/// </param>
		IFabMemberCreatesFactorStep WithPrimaryArtifactId(long Value);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Finds results where the target property is an exact match to the specified value.
		/// </summary>
		/// <remarks>
		///   <para>Finds results where the target property is an exact match to the specified value.</para>
		/// </remarks>
		/// <param name="Value">
		///   The exact value to match for this search.
		/// </param>
		IFabMemberCreatesFactorStep WithRelatedArtifactId(long Value);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Finds results where the target property is within the specified range of values.
		/// </summary>
		/// <remarks>
		///   <para>Finds results where the target property is within the specified range of values.</para>
		/// </remarks>
		/// <param name="Operation">
		///   The operator that defines the type of range to use for this search. Options include: "Greater Than", "Less Than or Equal", "Not Equal", etc.
		/// </param>
		/// <param name="Value">
		///   The boundary value for the search range.
		/// </param>
		IFabMemberCreatesFactorStep WhereTimestamp(string Operation, long Value);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Restricts the number of results at the current traversal step.
		/// </summary>
		/// <remarks>
		///   <para>Restricts the number of results at the current traversal step.</para>
		/// </remarks>
		/// <param name="Count">
		///   The maximum number of elements to return.
		/// </param>
		IFabFactorStep TakeFactors(int Count);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Restricts the number of results at the current traversal step.
		/// </summary>
		/// <remarks>
		///   <para>Restricts the number of results at the current traversal step.</para>
		/// </remarks>
		/// <param name="Count">
		///   The maximum number of elements to return.
		/// </param>
		IFabMemberCreatesFactorStep Take(int Count);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Creates a named alias for the current step of the traversal path. Execution of the traversal path can return to this alias using the Back step.
		/// </summary>
		/// <remarks>
		///   <para>Creates a named alias for the current step of the traversal path. Execution of the traversal path can return to this alias using the Back step.</para>
		/// </remarks>
		/// <param name="Alias">
		///   A named alias, which represents a particular place in the traversal path. This value must be unique across all other aliases in the traversal path.
		/// </param>
		IFabMemberCreatesFactorStep As(string Alias);
	
	}


	/*================================================================================================*/
	internal class FabMemberCreatesFactorStep : TraversalStep<FabMemberCreatesFactor>, IFabMemberCreatesFactorStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabMemberCreatesFactorStep(TraversalPath pTravPath) : base(pTravPath) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public IFabMemberCreatesFactorStep WithDescriptorType(byte Value) {
			TravPath.AppendToUri("/WithDescriptorType("+Value+")");
			return new FabMemberCreatesFactorStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabMemberCreatesFactorStep WithPrimaryArtifactId(long Value) {
			TravPath.AppendToUri("/WithPrimaryArtifactId("+Value+")");
			return new FabMemberCreatesFactorStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabMemberCreatesFactorStep WithRelatedArtifactId(long Value) {
			TravPath.AppendToUri("/WithRelatedArtifactId("+Value+")");
			return new FabMemberCreatesFactorStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabMemberCreatesFactorStep WhereTimestamp(string Operation, long Value) {
			TravPath.AppendToUri("/WhereTimestamp("+Operation+","+Value+")");
			return new FabMemberCreatesFactorStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabFactorStep TakeFactors(int Count) {
			TravPath.AppendToUri("/TakeFactors("+Count+")");
			return new FabFactorStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabMemberCreatesFactorStep Take(int Count) {
			TravPath.AppendToUri("/Take("+Count+")");
			return new FabMemberCreatesFactorStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabMemberCreatesFactorStep As(string Alias) {
			TravPath.AppendToUri("/As("+Alias+")");
			return new FabMemberCreatesFactorStep(TravPath);
		}
		
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabTravAppRootStep : ITraversalStep<FabTravAppRoot> {
		

		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Finds results where the target property is an exact match to the specified value.
		/// </summary>
		/// <remarks>
		///   <para>Finds results where the target property is an exact match to the specified value.</para>
		/// </remarks>
		/// <param name="Value">
		///   The exact value to match for this search.
		/// </param>
		IFabAppStep WithName(string Value);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Finds results where the target property is an exact match to the specified value.
		/// </summary>
		/// <remarks>
		///   <para>Finds results where the target property is an exact match to the specified value.</para>
		/// </remarks>
		/// <param name="Value">
		///   The exact value to match for this search.
		/// </param>
		IFabAppStep WithId(long Value);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Finds results where the target property is within the specified range of values.
		/// </summary>
		/// <remarks>
		///   <para>Finds results where the target property is within the specified range of values.</para>
		/// </remarks>
		/// <param name="Operation">
		///   The operator that defines the type of range to use for this search. Options include: "Greater Than", "Less Than or Equal", "Not Equal", etc.
		/// </param>
		/// <param name="Value">
		///   The boundary value for the search range.
		/// </param>
		IFabAppStep WhereTimestamp(string Operation, long Value);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Finds results where the target property contains one or more of the specified tokens.
		/// </summary>
		/// <remarks>
		///   <para>Finds results where the target property contains one or more of the specified tokens.</para>
		/// </remarks>
		/// <param name="Tokens">
		///   The space-delimited, case-insensitive search tokens.
		/// </param>
		IFabAppStep WhereNameContains(string Tokens);
	
	}


	/*================================================================================================*/
	internal class FabTravAppRootStep : TraversalStep<FabTravAppRoot>, IFabTravAppRootStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabTravAppRootStep(TraversalPath pTravPath) : base(pTravPath) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public IFabAppStep WithName(string Value) {
			TravPath.AppendToUri("/WithName("+Value+")");
			return new FabAppStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabAppStep WithId(long Value) {
			TravPath.AppendToUri("/WithId("+Value+")");
			return new FabAppStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabAppStep WhereTimestamp(string Operation, long Value) {
			TravPath.AppendToUri("/WhereTimestamp("+Operation+","+Value+")");
			return new FabAppStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabAppStep WhereNameContains(string Tokens) {
			TravPath.AppendToUri("/WhereNameContains("+Tokens+")");
			return new FabAppStep(TravPath);
		}
		
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabTravArtifactRootStep : ITraversalStep<FabTravArtifactRoot> {
		

		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Finds results where the target property is an exact match to the specified value.
		/// </summary>
		/// <remarks>
		///   <para>Finds results where the target property is an exact match to the specified value.</para>
		/// </remarks>
		/// <param name="Value">
		///   The exact value to match for this search.
		/// </param>
		IFabArtifactStep WithId(long Value);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Finds results where the target property is within the specified range of values.
		/// </summary>
		/// <remarks>
		///   <para>Finds results where the target property is within the specified range of values.</para>
		/// </remarks>
		/// <param name="Operation">
		///   The operator that defines the type of range to use for this search. Options include: "Greater Than", "Less Than or Equal", "Not Equal", etc.
		/// </param>
		/// <param name="Value">
		///   The boundary value for the search range.
		/// </param>
		IFabArtifactStep WhereTimestamp(string Operation, long Value);
	
	}


	/*================================================================================================*/
	internal class FabTravArtifactRootStep : TraversalStep<FabTravArtifactRoot>, IFabTravArtifactRootStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabTravArtifactRootStep(TraversalPath pTravPath) : base(pTravPath) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public IFabArtifactStep WithId(long Value) {
			TravPath.AppendToUri("/WithId("+Value+")");
			return new FabArtifactStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabArtifactStep WhereTimestamp(string Operation, long Value) {
			TravPath.AppendToUri("/WhereTimestamp("+Operation+","+Value+")");
			return new FabArtifactStep(TravPath);
		}
		
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabTravClassRootStep : ITraversalStep<FabTravClassRoot> {
		

		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Finds results where the target property is an exact match to the specified value.
		/// </summary>
		/// <remarks>
		///   <para>Finds results where the target property is an exact match to the specified value.</para>
		/// </remarks>
		/// <param name="Value">
		///   The exact value to match for this search.
		/// </param>
		IFabClassStep WithName(string Value);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Finds results where the target property is an exact match to the specified value.
		/// </summary>
		/// <remarks>
		///   <para>Finds results where the target property is an exact match to the specified value.</para>
		/// </remarks>
		/// <param name="Value">
		///   The exact value to match for this search.
		/// </param>
		IFabClassStep WithId(long Value);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Finds results where the target property is within the specified range of values.
		/// </summary>
		/// <remarks>
		///   <para>Finds results where the target property is within the specified range of values.</para>
		/// </remarks>
		/// <param name="Operation">
		///   The operator that defines the type of range to use for this search. Options include: "Greater Than", "Less Than or Equal", "Not Equal", etc.
		/// </param>
		/// <param name="Value">
		///   The boundary value for the search range.
		/// </param>
		IFabClassStep WhereTimestamp(string Operation, long Value);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Finds results where the target property contains one or more of the specified tokens.
		/// </summary>
		/// <remarks>
		///   <para>Finds results where the target property contains one or more of the specified tokens.</para>
		/// </remarks>
		/// <param name="Tokens">
		///   The space-delimited, case-insensitive search tokens.
		/// </param>
		IFabClassStep WhereNameContains(string Tokens);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Finds results where the target property contains one or more of the specified tokens.
		/// </summary>
		/// <remarks>
		///   <para>Finds results where the target property contains one or more of the specified tokens.</para>
		/// </remarks>
		/// <param name="Tokens">
		///   The space-delimited, case-insensitive search tokens.
		/// </param>
		IFabClassStep WhereDisambContains(string Tokens);
	
	}


	/*================================================================================================*/
	internal class FabTravClassRootStep : TraversalStep<FabTravClassRoot>, IFabTravClassRootStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabTravClassRootStep(TraversalPath pTravPath) : base(pTravPath) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public IFabClassStep WithName(string Value) {
			TravPath.AppendToUri("/WithName("+Value+")");
			return new FabClassStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabClassStep WithId(long Value) {
			TravPath.AppendToUri("/WithId("+Value+")");
			return new FabClassStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabClassStep WhereTimestamp(string Operation, long Value) {
			TravPath.AppendToUri("/WhereTimestamp("+Operation+","+Value+")");
			return new FabClassStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabClassStep WhereNameContains(string Tokens) {
			TravPath.AppendToUri("/WhereNameContains("+Tokens+")");
			return new FabClassStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabClassStep WhereDisambContains(string Tokens) {
			TravPath.AppendToUri("/WhereDisambContains("+Tokens+")");
			return new FabClassStep(TravPath);
		}
		
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabTravFactorRootStep : ITraversalStep<FabTravFactorRoot> {
		

		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Finds results where the target property is an exact match to the specified value.
		/// </summary>
		/// <remarks>
		///   <para>Finds results where the target property is an exact match to the specified value.</para>
		/// </remarks>
		/// <param name="Value">
		///   The exact value to match for this search.
		/// </param>
		IFabFactorStep WithIdentorValue(string Value);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Finds results where the target property is an exact match to the specified value.
		/// </summary>
		/// <remarks>
		///   <para>Finds results where the target property is an exact match to the specified value.</para>
		/// </remarks>
		/// <param name="Value">
		///   The exact value to match for this search.
		/// </param>
		IFabFactorStep WithId(long Value);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Finds results where the target property is within the specified range of values.
		/// </summary>
		/// <remarks>
		///   <para>Finds results where the target property is within the specified range of values.</para>
		/// </remarks>
		/// <param name="Operation">
		///   The operator that defines the type of range to use for this search. Options include: "Greater Than", "Less Than or Equal", "Not Equal", etc.
		/// </param>
		/// <param name="Value">
		///   The boundary value for the search range.
		/// </param>
		IFabFactorStep WhereTimestamp(string Operation, long Value);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Finds results where the target property contains one or more of the specified tokens.
		/// </summary>
		/// <remarks>
		///   <para>Finds results where the target property contains one or more of the specified tokens.</para>
		/// </remarks>
		/// <param name="Tokens">
		///   The space-delimited, case-insensitive search tokens.
		/// </param>
		IFabFactorStep WhereIdentorValueContains(string Tokens);
	
	}


	/*================================================================================================*/
	internal class FabTravFactorRootStep : TraversalStep<FabTravFactorRoot>, IFabTravFactorRootStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabTravFactorRootStep(TraversalPath pTravPath) : base(pTravPath) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public IFabFactorStep WithIdentorValue(string Value) {
			TravPath.AppendToUri("/WithIdentorValue("+Value+")");
			return new FabFactorStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabFactorStep WithId(long Value) {
			TravPath.AppendToUri("/WithId("+Value+")");
			return new FabFactorStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabFactorStep WhereTimestamp(string Operation, long Value) {
			TravPath.AppendToUri("/WhereTimestamp("+Operation+","+Value+")");
			return new FabFactorStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabFactorStep WhereIdentorValueContains(string Tokens) {
			TravPath.AppendToUri("/WhereIdentorValueContains("+Tokens+")");
			return new FabFactorStep(TravPath);
		}
		
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabTravInstanceRootStep : ITraversalStep<FabTravInstanceRoot> {
		

		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Finds results where the target property is an exact match to the specified value.
		/// </summary>
		/// <remarks>
		///   <para>Finds results where the target property is an exact match to the specified value.</para>
		/// </remarks>
		/// <param name="Value">
		///   The exact value to match for this search.
		/// </param>
		IFabInstanceStep WithId(long Value);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Finds results where the target property is within the specified range of values.
		/// </summary>
		/// <remarks>
		///   <para>Finds results where the target property is within the specified range of values.</para>
		/// </remarks>
		/// <param name="Operation">
		///   The operator that defines the type of range to use for this search. Options include: "Greater Than", "Less Than or Equal", "Not Equal", etc.
		/// </param>
		/// <param name="Value">
		///   The boundary value for the search range.
		/// </param>
		IFabInstanceStep WhereTimestamp(string Operation, long Value);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Finds results where the target property contains one or more of the specified tokens.
		/// </summary>
		/// <remarks>
		///   <para>Finds results where the target property contains one or more of the specified tokens.</para>
		/// </remarks>
		/// <param name="Tokens">
		///   The space-delimited, case-insensitive search tokens.
		/// </param>
		IFabInstanceStep WhereNameContains(string Tokens);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Finds results where the target property contains one or more of the specified tokens.
		/// </summary>
		/// <remarks>
		///   <para>Finds results where the target property contains one or more of the specified tokens.</para>
		/// </remarks>
		/// <param name="Tokens">
		///   The space-delimited, case-insensitive search tokens.
		/// </param>
		IFabInstanceStep WhereDisambContains(string Tokens);
	
	}


	/*================================================================================================*/
	internal class FabTravInstanceRootStep : TraversalStep<FabTravInstanceRoot>, IFabTravInstanceRootStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabTravInstanceRootStep(TraversalPath pTravPath) : base(pTravPath) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public IFabInstanceStep WithId(long Value) {
			TravPath.AppendToUri("/WithId("+Value+")");
			return new FabInstanceStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabInstanceStep WhereTimestamp(string Operation, long Value) {
			TravPath.AppendToUri("/WhereTimestamp("+Operation+","+Value+")");
			return new FabInstanceStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabInstanceStep WhereNameContains(string Tokens) {
			TravPath.AppendToUri("/WhereNameContains("+Tokens+")");
			return new FabInstanceStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabInstanceStep WhereDisambContains(string Tokens) {
			TravPath.AppendToUri("/WhereDisambContains("+Tokens+")");
			return new FabInstanceStep(TravPath);
		}
		
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabTravMemberRootStep : ITraversalStep<FabTravMemberRoot> {
		

		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Finds results where the target property is an exact match to the specified value.
		/// </summary>
		/// <remarks>
		///   <para>Finds results where the target property is an exact match to the specified value.</para>
		/// </remarks>
		/// <param name="Value">
		///   The exact value to match for this search.
		/// </param>
		IFabMemberStep WithId(long Value);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Finds results where the target property is within the specified range of values.
		/// </summary>
		/// <remarks>
		///   <para>Finds results where the target property is within the specified range of values.</para>
		/// </remarks>
		/// <param name="Operation">
		///   The operator that defines the type of range to use for this search. Options include: "Greater Than", "Less Than or Equal", "Not Equal", etc.
		/// </param>
		/// <param name="Value">
		///   The boundary value for the search range.
		/// </param>
		IFabMemberStep WhereTimestamp(string Operation, long Value);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Finds results based on the authenticated state of this traversal request.
		/// </summary>
		/// <remarks>
		///   <para>Finds results based on the authenticated state of this traversal request.</para>
		/// </remarks>
		
		IFabMemberStep Active();
	
	}


	/*================================================================================================*/
	internal class FabTravMemberRootStep : TraversalStep<FabTravMemberRoot>, IFabTravMemberRootStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabTravMemberRootStep(TraversalPath pTravPath) : base(pTravPath) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public IFabMemberStep WithId(long Value) {
			TravPath.AppendToUri("/WithId("+Value+")");
			return new FabMemberStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabMemberStep WhereTimestamp(string Operation, long Value) {
			TravPath.AppendToUri("/WhereTimestamp("+Operation+","+Value+")");
			return new FabMemberStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabMemberStep Active() {
			TravPath.AppendToUri("/Active()");
			return new FabMemberStep(TravPath);
		}
		
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabTravUrlRootStep : ITraversalStep<FabTravUrlRoot> {
		

		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Finds results where the target property is an exact match to the specified value.
		/// </summary>
		/// <remarks>
		///   <para>Finds results where the target property is an exact match to the specified value.</para>
		/// </remarks>
		/// <param name="Value">
		///   The exact value to match for this search.
		/// </param>
		IFabUrlStep WithFullPath(string Value);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Finds results where the target property is an exact match to the specified value.
		/// </summary>
		/// <remarks>
		///   <para>Finds results where the target property is an exact match to the specified value.</para>
		/// </remarks>
		/// <param name="Value">
		///   The exact value to match for this search.
		/// </param>
		IFabUrlStep WithId(long Value);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Finds results where the target property is within the specified range of values.
		/// </summary>
		/// <remarks>
		///   <para>Finds results where the target property is within the specified range of values.</para>
		/// </remarks>
		/// <param name="Operation">
		///   The operator that defines the type of range to use for this search. Options include: "Greater Than", "Less Than or Equal", "Not Equal", etc.
		/// </param>
		/// <param name="Value">
		///   The boundary value for the search range.
		/// </param>
		IFabUrlStep WhereTimestamp(string Operation, long Value);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Finds results where the target property contains one or more of the specified tokens.
		/// </summary>
		/// <remarks>
		///   <para>Finds results where the target property contains one or more of the specified tokens.</para>
		/// </remarks>
		/// <param name="Tokens">
		///   The space-delimited, case-insensitive search tokens.
		/// </param>
		IFabUrlStep WhereNameContains(string Tokens);
	
	}


	/*================================================================================================*/
	internal class FabTravUrlRootStep : TraversalStep<FabTravUrlRoot>, IFabTravUrlRootStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabTravUrlRootStep(TraversalPath pTravPath) : base(pTravPath) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public IFabUrlStep WithFullPath(string Value) {
			TravPath.AppendToUri("/WithFullPath("+Value+")");
			return new FabUrlStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabUrlStep WithId(long Value) {
			TravPath.AppendToUri("/WithId("+Value+")");
			return new FabUrlStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabUrlStep WhereTimestamp(string Operation, long Value) {
			TravPath.AppendToUri("/WhereTimestamp("+Operation+","+Value+")");
			return new FabUrlStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabUrlStep WhereNameContains(string Tokens) {
			TravPath.AppendToUri("/WhereNameContains("+Tokens+")");
			return new FabUrlStep(TravPath);
		}
		
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabTravUserRootStep : ITraversalStep<FabTravUserRoot> {
		

		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Finds results where the target property is an exact match to the specified value.
		/// </summary>
		/// <remarks>
		///   <para>Finds results where the target property is an exact match to the specified value.</para>
		/// </remarks>
		/// <param name="Value">
		///   The exact value to match for this search.
		/// </param>
		IFabUserStep WithName(string Value);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Finds results where the target property is an exact match to the specified value.
		/// </summary>
		/// <remarks>
		///   <para>Finds results where the target property is an exact match to the specified value.</para>
		/// </remarks>
		/// <param name="Value">
		///   The exact value to match for this search.
		/// </param>
		IFabUserStep WithId(long Value);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Finds results where the target property is within the specified range of values.
		/// </summary>
		/// <remarks>
		///   <para>Finds results where the target property is within the specified range of values.</para>
		/// </remarks>
		/// <param name="Operation">
		///   The operator that defines the type of range to use for this search. Options include: "Greater Than", "Less Than or Equal", "Not Equal", etc.
		/// </param>
		/// <param name="Value">
		///   The boundary value for the search range.
		/// </param>
		IFabUserStep WhereTimestamp(string Operation, long Value);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Finds results where the target property contains one or more of the specified tokens.
		/// </summary>
		/// <remarks>
		///   <para>Finds results where the target property contains one or more of the specified tokens.</para>
		/// </remarks>
		/// <param name="Tokens">
		///   The space-delimited, case-insensitive search tokens.
		/// </param>
		IFabUserStep WhereNameContains(string Tokens);
	
	}


	/*================================================================================================*/
	internal class FabTravUserRootStep : TraversalStep<FabTravUserRoot>, IFabTravUserRootStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabTravUserRootStep(TraversalPath pTravPath) : base(pTravPath) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public IFabUserStep WithName(string Value) {
			TravPath.AppendToUri("/WithName("+Value+")");
			return new FabUserStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabUserStep WithId(long Value) {
			TravPath.AppendToUri("/WithId("+Value+")");
			return new FabUserStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabUserStep WhereTimestamp(string Operation, long Value) {
			TravPath.AppendToUri("/WhereTimestamp("+Operation+","+Value+")");
			return new FabUserStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabUserStep WhereNameContains(string Tokens) {
			TravPath.AppendToUri("/WhereNameContains("+Tokens+")");
			return new FabUserStep(TravPath);
		}
		
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabTravVertexRootStep : ITraversalStep<FabTravVertexRoot> {
		

		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Finds results where the target property is an exact match to the specified value.
		/// </summary>
		/// <remarks>
		///   <para>Finds results where the target property is an exact match to the specified value.</para>
		/// </remarks>
		/// <param name="Value">
		///   The exact value to match for this search.
		/// </param>
		IFabVertexStep WithId(long Value);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Finds results where the target property is within the specified range of values.
		/// </summary>
		/// <remarks>
		///   <para>Finds results where the target property is within the specified range of values.</para>
		/// </remarks>
		/// <param name="Operation">
		///   The operator that defines the type of range to use for this search. Options include: "Greater Than", "Less Than or Equal", "Not Equal", etc.
		/// </param>
		/// <param name="Value">
		///   The boundary value for the search range.
		/// </param>
		IFabVertexStep WhereTimestamp(string Operation, long Value);
	
	}


	/*================================================================================================*/
	internal class FabTravVertexRootStep : TraversalStep<FabTravVertexRoot>, IFabTravVertexRootStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabTravVertexRootStep(TraversalPath pTravPath) : base(pTravPath) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public IFabVertexStep WithId(long Value) {
			TravPath.AppendToUri("/WithId("+Value+")");
			return new FabVertexStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabVertexStep WhereTimestamp(string Operation, long Value) {
			TravPath.AppendToUri("/WhereTimestamp("+Operation+","+Value+")");
			return new FabVertexStep(TravPath);
		}
		
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabUrlStep : ITraversalStep<FabUrl>, IHasAsStep, IHasBackStep {
		

		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Finds results where the target property is an exact match to the specified value.
		/// </summary>
		/// <remarks>
		///   <para>Finds results where the target property is an exact match to the specified value.</para>
		/// </remarks>
		/// <param name="Value">
		///   The exact value to match for this search.
		/// </param>
		IFabUrlStep WithId(long Value);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Finds results where the target property is an exact match to the specified value.
		/// </summary>
		/// <remarks>
		///   <para>Finds results where the target property is an exact match to the specified value.</para>
		/// </remarks>
		/// <param name="Value">
		///   The exact value to match for this search.
		/// </param>
		IFabUrlStep WithVertexType(byte Value);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Finds results where the target property is within the specified range of values.
		/// </summary>
		/// <remarks>
		///   <para>Finds results where the target property is within the specified range of values.</para>
		/// </remarks>
		/// <param name="Operation">
		///   The operator that defines the type of range to use for this search. Options include: "Greater Than", "Less Than or Equal", "Not Equal", etc.
		/// </param>
		/// <param name="Value">
		///   The boundary value for the search range.
		/// </param>
		IFabUrlStep WhereTimestamp(string Operation, long Value);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Restricts the number of results at the current traversal step.
		/// </summary>
		/// <remarks>
		///   <para>Restricts the number of results at the current traversal step.</para>
		/// </remarks>
		/// <param name="Count">
		///   The maximum number of elements to return.
		/// </param>
		IFabUrlStep Take(int Count);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Creates a named alias for the current step of the traversal path. Execution of the traversal path can return to this alias using the Back step.
		/// </summary>
		/// <remarks>
		///   <para>Creates a named alias for the current step of the traversal path. Execution of the traversal path can return to this alias using the Back step.</para>
		/// </remarks>
		/// <param name="Alias">
		///   A named alias, which represents a particular place in the traversal path. This value must be unique across all other aliases in the traversal path.
		/// </param>
		IFabUrlStep As(string Alias);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Traverses along an Edge type (connection) between one Vertex and zero, one, or many others. Links which will produce many results require further filtering (via relevant FabLink item) before arriving at the desired Vertex items. To complete this filtering, use the relevant Take step.
		/// </summary>
		/// <remarks>
		///   <para>Traverses along an Edge type (connection) between one Vertex and zero, one, or many others.</para>
	///   <para>Links which will produce many results require further filtering (via relevant FabLink item) before arriving at the desired Vertex items. To complete this filtering, use the relevant Take step.</para>
		/// </remarks>
		
		IFabMemberStep CreatedByMember();
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Traverses along an Edge type (connection) between one Vertex and zero, one, or many others. Links which will produce many results require further filtering (via relevant FabLink item) before arriving at the desired Vertex items. To complete this filtering, use the relevant Take step.
		/// </summary>
		/// <remarks>
		///   <para>Traverses along an Edge type (connection) between one Vertex and zero, one, or many others.</para>
	///   <para>Links which will produce many results require further filtering (via relevant FabLink item) before arriving at the desired Vertex items. To complete this filtering, use the relevant Take step.</para>
		/// </remarks>
		
		IFabArtifactUsedAsPrimaryByFactorStep UsedAsPrimaryByFactors();
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Traverses along an Edge type (connection) between one Vertex and zero, one, or many others. Links which will produce many results require further filtering (via relevant FabLink item) before arriving at the desired Vertex items. To complete this filtering, use the relevant Take step.
		/// </summary>
		/// <remarks>
		///   <para>Traverses along an Edge type (connection) between one Vertex and zero, one, or many others.</para>
	///   <para>Links which will produce many results require further filtering (via relevant FabLink item) before arriving at the desired Vertex items. To complete this filtering, use the relevant Take step.</para>
		/// </remarks>
		
		IFabArtifactUsedAsRelatedByFactorStep UsedAsRelatedByFactors();
	
	}


	/*================================================================================================*/
	internal class FabUrlStep : TraversalStep<FabUrl>, IFabUrlStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabUrlStep(TraversalPath pTravPath) : base(pTravPath) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public IFabUrlStep WithId(long Value) {
			TravPath.AppendToUri("/WithId("+Value+")");
			return new FabUrlStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabUrlStep WithVertexType(byte Value) {
			TravPath.AppendToUri("/WithVertexType("+Value+")");
			return new FabUrlStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabUrlStep WhereTimestamp(string Operation, long Value) {
			TravPath.AppendToUri("/WhereTimestamp("+Operation+","+Value+")");
			return new FabUrlStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabUrlStep Take(int Count) {
			TravPath.AppendToUri("/Take("+Count+")");
			return new FabUrlStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabUrlStep As(string Alias) {
			TravPath.AppendToUri("/As("+Alias+")");
			return new FabUrlStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabMemberStep CreatedByMember() {
			TravPath.AppendToUri("/CreatedByMember()");
			return new FabMemberStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabArtifactUsedAsPrimaryByFactorStep UsedAsPrimaryByFactors() {
			TravPath.AppendToUri("/UsedAsPrimaryByFactors()");
			return new FabArtifactUsedAsPrimaryByFactorStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabArtifactUsedAsRelatedByFactorStep UsedAsRelatedByFactors() {
			TravPath.AppendToUri("/UsedAsRelatedByFactors()");
			return new FabArtifactUsedAsRelatedByFactorStep(TravPath);
		}
		
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabUserStep : ITraversalStep<FabUser>, IHasAsStep, IHasBackStep {
		

		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Finds results where the target property is an exact match to the specified value.
		/// </summary>
		/// <remarks>
		///   <para>Finds results where the target property is an exact match to the specified value.</para>
		/// </remarks>
		/// <param name="Value">
		///   The exact value to match for this search.
		/// </param>
		IFabUserStep WithId(long Value);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Finds results where the target property is an exact match to the specified value.
		/// </summary>
		/// <remarks>
		///   <para>Finds results where the target property is an exact match to the specified value.</para>
		/// </remarks>
		/// <param name="Value">
		///   The exact value to match for this search.
		/// </param>
		IFabUserStep WithVertexType(byte Value);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Finds results where the target property is within the specified range of values.
		/// </summary>
		/// <remarks>
		///   <para>Finds results where the target property is within the specified range of values.</para>
		/// </remarks>
		/// <param name="Operation">
		///   The operator that defines the type of range to use for this search. Options include: "Greater Than", "Less Than or Equal", "Not Equal", etc.
		/// </param>
		/// <param name="Value">
		///   The boundary value for the search range.
		/// </param>
		IFabUserStep WhereTimestamp(string Operation, long Value);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Restricts the number of results at the current traversal step.
		/// </summary>
		/// <remarks>
		///   <para>Restricts the number of results at the current traversal step.</para>
		/// </remarks>
		/// <param name="Count">
		///   The maximum number of elements to return.
		/// </param>
		IFabUserStep Take(int Count);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Creates a named alias for the current step of the traversal path. Execution of the traversal path can return to this alias using the Back step.
		/// </summary>
		/// <remarks>
		///   <para>Creates a named alias for the current step of the traversal path. Execution of the traversal path can return to this alias using the Back step.</para>
		/// </remarks>
		/// <param name="Alias">
		///   A named alias, which represents a particular place in the traversal path. This value must be unique across all other aliases in the traversal path.
		/// </param>
		IFabUserStep As(string Alias);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Traverses along an Edge type (connection) between one Vertex and zero, one, or many others. Links which will produce many results require further filtering (via relevant FabLink item) before arriving at the desired Vertex items. To complete this filtering, use the relevant Take step.
		/// </summary>
		/// <remarks>
		///   <para>Traverses along an Edge type (connection) between one Vertex and zero, one, or many others.</para>
	///   <para>Links which will produce many results require further filtering (via relevant FabLink item) before arriving at the desired Vertex items. To complete this filtering, use the relevant Take step.</para>
		/// </remarks>
		
		IFabMemberStep CreatedByMember();
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Traverses along an Edge type (connection) between one Vertex and zero, one, or many others. Links which will produce many results require further filtering (via relevant FabLink item) before arriving at the desired Vertex items. To complete this filtering, use the relevant Take step.
		/// </summary>
		/// <remarks>
		///   <para>Traverses along an Edge type (connection) between one Vertex and zero, one, or many others.</para>
	///   <para>Links which will produce many results require further filtering (via relevant FabLink item) before arriving at the desired Vertex items. To complete this filtering, use the relevant Take step.</para>
		/// </remarks>
		
		IFabArtifactUsedAsPrimaryByFactorStep UsedAsPrimaryByFactors();
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Traverses along an Edge type (connection) between one Vertex and zero, one, or many others. Links which will produce many results require further filtering (via relevant FabLink item) before arriving at the desired Vertex items. To complete this filtering, use the relevant Take step.
		/// </summary>
		/// <remarks>
		///   <para>Traverses along an Edge type (connection) between one Vertex and zero, one, or many others.</para>
	///   <para>Links which will produce many results require further filtering (via relevant FabLink item) before arriving at the desired Vertex items. To complete this filtering, use the relevant Take step.</para>
		/// </remarks>
		
		IFabArtifactUsedAsRelatedByFactorStep UsedAsRelatedByFactors();
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Traverses along an Edge type (connection) between one Vertex and zero, one, or many others. Links which will produce many results require further filtering (via relevant FabLink item) before arriving at the desired Vertex items. To complete this filtering, use the relevant Take step.
		/// </summary>
		/// <remarks>
		///   <para>Traverses along an Edge type (connection) between one Vertex and zero, one, or many others.</para>
	///   <para>Links which will produce many results require further filtering (via relevant FabLink item) before arriving at the desired Vertex items. To complete this filtering, use the relevant Take step.</para>
		/// </remarks>
		
		IFabUserDefinesMemberStep DefinesMembers();
	
	}


	/*================================================================================================*/
	internal class FabUserStep : TraversalStep<FabUser>, IFabUserStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabUserStep(TraversalPath pTravPath) : base(pTravPath) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public IFabUserStep WithId(long Value) {
			TravPath.AppendToUri("/WithId("+Value+")");
			return new FabUserStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabUserStep WithVertexType(byte Value) {
			TravPath.AppendToUri("/WithVertexType("+Value+")");
			return new FabUserStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabUserStep WhereTimestamp(string Operation, long Value) {
			TravPath.AppendToUri("/WhereTimestamp("+Operation+","+Value+")");
			return new FabUserStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabUserStep Take(int Count) {
			TravPath.AppendToUri("/Take("+Count+")");
			return new FabUserStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabUserStep As(string Alias) {
			TravPath.AppendToUri("/As("+Alias+")");
			return new FabUserStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabMemberStep CreatedByMember() {
			TravPath.AppendToUri("/CreatedByMember()");
			return new FabMemberStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabArtifactUsedAsPrimaryByFactorStep UsedAsPrimaryByFactors() {
			TravPath.AppendToUri("/UsedAsPrimaryByFactors()");
			return new FabArtifactUsedAsPrimaryByFactorStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabArtifactUsedAsRelatedByFactorStep UsedAsRelatedByFactors() {
			TravPath.AppendToUri("/UsedAsRelatedByFactors()");
			return new FabArtifactUsedAsRelatedByFactorStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabUserDefinesMemberStep DefinesMembers() {
			TravPath.AppendToUri("/DefinesMembers()");
			return new FabUserDefinesMemberStep(TravPath);
		}
		
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabUserDefinesMemberStep : ITraversalStep<FabUserDefinesMember>, IHasAsStep, IHasBackStep {
		

		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Finds results where the target property is an exact match to the specified value.
		/// </summary>
		/// <remarks>
		///   <para>Finds results where the target property is an exact match to the specified value.</para>
		/// </remarks>
		/// <param name="Value">
		///   The exact value to match for this search.
		/// </param>
		IFabUserDefinesMemberStep WithMemberType(byte Value);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Finds results where the target property is an exact match to the specified value.
		/// </summary>
		/// <remarks>
		///   <para>Finds results where the target property is an exact match to the specified value.</para>
		/// </remarks>
		/// <param name="Value">
		///   The exact value to match for this search.
		/// </param>
		IFabUserDefinesMemberStep WithAppId(long Value);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Finds results where the target property is within the specified range of values.
		/// </summary>
		/// <remarks>
		///   <para>Finds results where the target property is within the specified range of values.</para>
		/// </remarks>
		/// <param name="Operation">
		///   The operator that defines the type of range to use for this search. Options include: "Greater Than", "Less Than or Equal", "Not Equal", etc.
		/// </param>
		/// <param name="Value">
		///   The boundary value for the search range.
		/// </param>
		IFabUserDefinesMemberStep WhereTimestamp(string Operation, long Value);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Restricts the number of results at the current traversal step.
		/// </summary>
		/// <remarks>
		///   <para>Restricts the number of results at the current traversal step.</para>
		/// </remarks>
		/// <param name="Count">
		///   The maximum number of elements to return.
		/// </param>
		IFabMemberStep TakeMembers(int Count);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Restricts the number of results at the current traversal step.
		/// </summary>
		/// <remarks>
		///   <para>Restricts the number of results at the current traversal step.</para>
		/// </remarks>
		/// <param name="Count">
		///   The maximum number of elements to return.
		/// </param>
		IFabUserDefinesMemberStep Take(int Count);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Creates a named alias for the current step of the traversal path. Execution of the traversal path can return to this alias using the Back step.
		/// </summary>
		/// <remarks>
		///   <para>Creates a named alias for the current step of the traversal path. Execution of the traversal path can return to this alias using the Back step.</para>
		/// </remarks>
		/// <param name="Alias">
		///   A named alias, which represents a particular place in the traversal path. This value must be unique across all other aliases in the traversal path.
		/// </param>
		IFabUserDefinesMemberStep As(string Alias);
	
	}


	/*================================================================================================*/
	internal class FabUserDefinesMemberStep : TraversalStep<FabUserDefinesMember>, IFabUserDefinesMemberStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabUserDefinesMemberStep(TraversalPath pTravPath) : base(pTravPath) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public IFabUserDefinesMemberStep WithMemberType(byte Value) {
			TravPath.AppendToUri("/WithMemberType("+Value+")");
			return new FabUserDefinesMemberStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabUserDefinesMemberStep WithAppId(long Value) {
			TravPath.AppendToUri("/WithAppId("+Value+")");
			return new FabUserDefinesMemberStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabUserDefinesMemberStep WhereTimestamp(string Operation, long Value) {
			TravPath.AppendToUri("/WhereTimestamp("+Operation+","+Value+")");
			return new FabUserDefinesMemberStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabMemberStep TakeMembers(int Count) {
			TravPath.AppendToUri("/TakeMembers("+Count+")");
			return new FabMemberStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabUserDefinesMemberStep Take(int Count) {
			TravPath.AppendToUri("/Take("+Count+")");
			return new FabUserDefinesMemberStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabUserDefinesMemberStep As(string Alias) {
			TravPath.AppendToUri("/As("+Alias+")");
			return new FabUserDefinesMemberStep(TravPath);
		}
		
	}
	
	
	/*================================================================================================*/
	/// <summary />
	public interface IFabVertexStep : ITraversalStep<FabVertex>, IHasAsStep, IHasBackStep {
		

		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Finds results where the target property is an exact match to the specified value.
		/// </summary>
		/// <remarks>
		///   <para>Finds results where the target property is an exact match to the specified value.</para>
		/// </remarks>
		/// <param name="Value">
		///   The exact value to match for this search.
		/// </param>
		IFabVertexStep WithId(long Value);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Finds results where the target property is an exact match to the specified value.
		/// </summary>
		/// <remarks>
		///   <para>Finds results where the target property is an exact match to the specified value.</para>
		/// </remarks>
		/// <param name="Value">
		///   The exact value to match for this search.
		/// </param>
		IFabVertexStep WithVertexType(byte Value);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Finds results where the target property is within the specified range of values.
		/// </summary>
		/// <remarks>
		///   <para>Finds results where the target property is within the specified range of values.</para>
		/// </remarks>
		/// <param name="Operation">
		///   The operator that defines the type of range to use for this search. Options include: "Greater Than", "Less Than or Equal", "Not Equal", etc.
		/// </param>
		/// <param name="Value">
		///   The boundary value for the search range.
		/// </param>
		IFabVertexStep WhereTimestamp(string Operation, long Value);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Restricts the number of results at the current traversal step.
		/// </summary>
		/// <remarks>
		///   <para>Restricts the number of results at the current traversal step.</para>
		/// </remarks>
		/// <param name="Count">
		///   The maximum number of elements to return.
		/// </param>
		IFabVertexStep Take(int Count);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Creates a named alias for the current step of the traversal path. Execution of the traversal path can return to this alias using the Back step.
		/// </summary>
		/// <remarks>
		///   <para>Creates a named alias for the current step of the traversal path. Execution of the traversal path can return to this alias using the Back step.</para>
		/// </remarks>
		/// <param name="Alias">
		///   A named alias, which represents a particular place in the traversal path. This value must be unique across all other aliases in the traversal path.
		/// </param>
		IFabVertexStep As(string Alias);
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Casts the results to the specified vertex type, and filters out any results that are incompatible.
		/// </summary>
		/// <remarks>
		///   <para>Casts the results to the specified vertex type, and filters out any results that are incompatible.</para>
		/// </remarks>
		
		IFabAppStep ToApp();
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Casts the results to the specified vertex type, and filters out any results that are incompatible.
		/// </summary>
		/// <remarks>
		///   <para>Casts the results to the specified vertex type, and filters out any results that are incompatible.</para>
		/// </remarks>
		
		IFabArtifactStep ToArtifact();
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Casts the results to the specified vertex type, and filters out any results that are incompatible.
		/// </summary>
		/// <remarks>
		///   <para>Casts the results to the specified vertex type, and filters out any results that are incompatible.</para>
		/// </remarks>
		
		IFabClassStep ToClass();
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Casts the results to the specified vertex type, and filters out any results that are incompatible.
		/// </summary>
		/// <remarks>
		///   <para>Casts the results to the specified vertex type, and filters out any results that are incompatible.</para>
		/// </remarks>
		
		IFabFactorStep ToFactor();
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Casts the results to the specified vertex type, and filters out any results that are incompatible.
		/// </summary>
		/// <remarks>
		///   <para>Casts the results to the specified vertex type, and filters out any results that are incompatible.</para>
		/// </remarks>
		
		IFabInstanceStep ToInstance();
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Casts the results to the specified vertex type, and filters out any results that are incompatible.
		/// </summary>
		/// <remarks>
		///   <para>Casts the results to the specified vertex type, and filters out any results that are incompatible.</para>
		/// </remarks>
		
		IFabMemberStep ToMember();
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Casts the results to the specified vertex type, and filters out any results that are incompatible.
		/// </summary>
		/// <remarks>
		///   <para>Casts the results to the specified vertex type, and filters out any results that are incompatible.</para>
		/// </remarks>
		
		IFabUrlStep ToUrl();
	
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Casts the results to the specified vertex type, and filters out any results that are incompatible.
		/// </summary>
		/// <remarks>
		///   <para>Casts the results to the specified vertex type, and filters out any results that are incompatible.</para>
		/// </remarks>
		
		IFabUserStep ToUser();
	
	}


	/*================================================================================================*/
	internal class FabVertexStep : TraversalStep<FabVertex>, IFabVertexStep {
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabVertexStep(TraversalPath pTravPath) : base(pTravPath) {}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public IFabVertexStep WithId(long Value) {
			TravPath.AppendToUri("/WithId("+Value+")");
			return new FabVertexStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabVertexStep WithVertexType(byte Value) {
			TravPath.AppendToUri("/WithVertexType("+Value+")");
			return new FabVertexStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabVertexStep WhereTimestamp(string Operation, long Value) {
			TravPath.AppendToUri("/WhereTimestamp("+Operation+","+Value+")");
			return new FabVertexStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabVertexStep Take(int Count) {
			TravPath.AppendToUri("/Take("+Count+")");
			return new FabVertexStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabVertexStep As(string Alias) {
			TravPath.AppendToUri("/As("+Alias+")");
			return new FabVertexStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabAppStep ToApp() {
			TravPath.AppendToUri("/ToApp()");
			return new FabAppStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabArtifactStep ToArtifact() {
			TravPath.AppendToUri("/ToArtifact()");
			return new FabArtifactStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabClassStep ToClass() {
			TravPath.AppendToUri("/ToClass()");
			return new FabClassStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabFactorStep ToFactor() {
			TravPath.AppendToUri("/ToFactor()");
			return new FabFactorStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabInstanceStep ToInstance() {
			TravPath.AppendToUri("/ToInstance()");
			return new FabInstanceStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabMemberStep ToMember() {
			TravPath.AppendToUri("/ToMember()");
			return new FabMemberStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabUrlStep ToUrl() {
			TravPath.AppendToUri("/ToUrl()");
			return new FabUrlStep(TravPath);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabUserStep ToUser() {
			TravPath.AppendToUri("/ToUser()");
			return new FabUserStep(TravPath);
		}
		
	}
	
	
	// ReSharper restore InconsistentNaming

}
