// GENERATED CODE
// Changes made to this source file will be overwritten
// Generated on 8/5/2013 8:47:46 PM

namespace Fabric.Clients.Cs.Api {

	// ReSharper disable InconsistentNaming

	/*================================================================================================*/
	/// <summary />
	public interface IFuncAppId : ITraversalStep {}

		
	/*================================================================================================*/
	/// <summary />
	public interface IFuncAppName : ITraversalStep {}

		
	/*================================================================================================*/
	/// <summary />
	public interface IFuncAppNameContains : ITraversalStep {}

		
	/*================================================================================================*/
	/// <summary />
	public interface IFuncArtifactCreated : ITraversalStep {}

		
	/*================================================================================================*/
	/// <summary />
	public interface IFuncArtifactId : ITraversalStep {}

		
	/*================================================================================================*/
	/// <summary />
	public interface IFuncAs : ITraversalStep {}

		
	/*================================================================================================*/
	/// <summary />
	public interface IFuncBack : ITraversalStep {}

		
	/*================================================================================================*/
	/// <summary />
	public interface IFuncClassDisambContains : ITraversalStep {}

		
	/*================================================================================================*/
	/// <summary />
	public interface IFuncClassId : ITraversalStep {}

		
	/*================================================================================================*/
	/// <summary />
	public interface IFuncClassName : ITraversalStep {}

		
	/*================================================================================================*/
	/// <summary />
	public interface IFuncClassNameContains : ITraversalStep {}

		
	/*================================================================================================*/
	/// <summary />
	public interface IFuncFactorCreated : ITraversalStep {}

		
	/*================================================================================================*/
	/// <summary />
	public interface IFuncFactorId : ITraversalStep {}

		
	/*================================================================================================*/
	/// <summary />
	public interface IFuncFactorIdentorValue : ITraversalStep {}

		
	/*================================================================================================*/
	/// <summary />
	public interface IFuncFactorIdentorValueContains : ITraversalStep {}

		
	/*================================================================================================*/
	/// <summary />
	public interface IFuncHasId : ITraversalStep {}

		
	/*================================================================================================*/
	/// <summary />
	public interface IFuncInstanceDisambContains : ITraversalStep {}

		
	/*================================================================================================*/
	/// <summary />
	public interface IFuncInstanceId : ITraversalStep {}

		
	/*================================================================================================*/
	/// <summary />
	public interface IFuncInstanceNameContains : ITraversalStep {}

		
	/*================================================================================================*/
	/// <summary />
	public interface IFuncLimit : ITraversalStep {}

		
	/*================================================================================================*/
	/// <summary />
	public interface IFuncMemberId : ITraversalStep {}

		
	/*================================================================================================*/
	/// <summary />
	public interface IFuncMemberTypeAssignId : ITraversalStep {}

		
	/*================================================================================================*/
	/// <summary />
	public interface IFuncToApp : ITraversalStep {}

		
	/*================================================================================================*/
	/// <summary />
	public interface IFuncToClass : ITraversalStep {}

		
	/*================================================================================================*/
	/// <summary />
	public interface IFuncToInstance : ITraversalStep {}

		
	/*================================================================================================*/
	/// <summary />
	public interface IFuncToUrl : ITraversalStep {}

		
	/*================================================================================================*/
	/// <summary />
	public interface IFuncToUser : ITraversalStep {}

		
	/*================================================================================================*/
	/// <summary />
	public interface IFuncUrlFullPath : ITraversalStep {}

		
	/*================================================================================================*/
	/// <summary />
	public interface IFuncUrlId : ITraversalStep {}

		
	/*================================================================================================*/
	/// <summary />
	public interface IFuncUrlNameContains : ITraversalStep {}

		
	/*================================================================================================*/
	/// <summary />
	public interface IFuncUserId : ITraversalStep {}

		
	/*================================================================================================*/
	/// <summary />
	public interface IFuncUserName : ITraversalStep {}

		
	/*================================================================================================*/
	internal class TraversalFuncs {
	
		protected Traversal Trav { get; private set; }
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public TraversalFuncs(Traversal pTrav) {
			Trav = pTrav;
		}
		

		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Obtains an App by its ArtifactId.
		/// </summary>
		/// <param name="Value">
		///   The ArtifactId of the target App.
		/// </param>
		public void AppId(long Value) {
			Trav.AppendToUri("/AppId("+Value+")");
		}
		
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Obtains an App by its entire (case-insensitive) Name.
		/// </summary>
		/// <param name="Value">
		///   The Name of the target App.
		/// </param>
		public void AppName(string Value) {
			Trav.AppendToUri("/AppName("+Value+")");
		}
		
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Search for Apps using string-delimited, case-insensitive tokens.
		/// </summary>
		/// <param name="Tokens">
		///   The Name search tokens.
		/// </param>
		public void AppNameContains(string Tokens) {
			Trav.AppendToUri("/AppNameContains("+Tokens+")");
		}
		
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Search for Artifacts by their creation date/time.
		/// </summary>
		/// <param name="Operation">
		///   The operator to use for this search.
		/// </param>
		/// <param name="Value">
		///   The date/time to use for this search.
		/// </param>
		public void ArtifactCreated(string Operation, long Value) {
			Trav.AppendToUri("/ArtifactCreated("+"+Operation+"+","+Value+")");
		}
		
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Obtains an Artifact by its ArtifactId.
		/// </summary>
		/// <param name="Value">
		///   The ArtifactId of the target Artifact.
		/// </param>
		public void ArtifactId(long Value) {
			Trav.AppendToUri("/ArtifactId("+Value+")");
		}
		
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Creates a named alias for the current step of the traversal path.
		/// </summary>
		/// <param name="Alias">
		///   A named alias, which represents a particular place in the traversal path. This value must be unique across all other aliases in the traversal path.
		/// </param>
		public void As(string Alias) {
			Trav.AppendToUri("/As("+Alias+")");
		}
		
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Returns the execution of the traversal path to a particular named alias.
		/// </summary>
		/// <param name="Alias">
		///   The target named alias, which was defined by an As function earlier in the traversal path.
		/// </param>
		public void Back(string Alias) {
			Trav.AppendToUri("/Back("+Alias+")");
		}
		
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Search for Classes using string-delimited, case-insensitive tokens.
		/// </summary>
		/// <param name="Tokens">
		///   The Disamb search tokens.
		/// </param>
		public void ClassDisambContains(string Tokens) {
			Trav.AppendToUri("/ClassDisambContains("+Tokens+")");
		}
		
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Obtains a Class by its ArtifactId.
		/// </summary>
		/// <param name="Value">
		///   The ArtifactId of the target Class.
		/// </param>
		public void ClassId(long Value) {
			Trav.AppendToUri("/ClassId("+Value+")");
		}
		
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Obtains a Class by its entire (case-insensitive) Name.
		/// </summary>
		/// <param name="Value">
		///   The Name of the target Class.
		/// </param>
		public void ClassName(string Value) {
			Trav.AppendToUri("/ClassName("+Value+")");
		}
		
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Search for Classes using string-delimited, case-insensitive tokens.
		/// </summary>
		/// <param name="Tokens">
		///   The Name search tokens.
		/// </param>
		public void ClassNameContains(string Tokens) {
			Trav.AppendToUri("/ClassNameContains("+Tokens+")");
		}
		
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Search for Factors by their creation date/time.
		/// </summary>
		/// <param name="Operation">
		///   The operator to use for this search.
		/// </param>
		/// <param name="Value">
		///   The date/time to use for this search.
		/// </param>
		public void FactorCreated(string Operation, long Value) {
			Trav.AppendToUri("/FactorCreated("+"+Operation+"+","+Value+")");
		}
		
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Obtains an Factor by its FactorId
		/// </summary>
		/// <param name="Value">
		///   The FactorId of the target Factor.
		/// </param>
		public void FactorId(long Value) {
			Trav.AppendToUri("/FactorId("+Value+")");
		}
		
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Obtains a Factor by its full (case-insensitive) IdentorValue.
		/// </summary>
		/// <param name="Value">
		///   The IdentorValue of the target Factor.
		/// </param>
		public void FactorIdentorValue(string Value) {
			Trav.AppendToUri("/FactorIdentorValue("+Value+")");
		}
		
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Search for Factors using string-delimited, case-insensitive tokens.
		/// </summary>
		/// <param name="Tokens">
		///   The IdentorValue search tokens.
		/// </param>
		public void FactorIdentorValueContains(string Tokens) {
			Trav.AppendToUri("/FactorIdentorValueContains("+Tokens+")");
		}
		
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Restricts the results to a single Id value.
		/// </summary>
		/// <param name="Id">
		///   The target vertex Id.
		/// </param>
		public void HasId(long Id) {
			Trav.AppendToUri("/HasId("+Id+")");
		}
		
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Search for Instances using string-delimited, case-insensitive tokens.
		/// </summary>
		/// <param name="Tokens">
		///   The Disamb search tokens.
		/// </param>
		public void InstanceDisambContains(string Tokens) {
			Trav.AppendToUri("/InstanceDisambContains("+Tokens+")");
		}
		
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Obtains an Instance by its ArtifactId.
		/// </summary>
		/// <param name="Value">
		///   The ArtifactId of the target Instance.
		/// </param>
		public void InstanceId(long Value) {
			Trav.AppendToUri("/InstanceId("+Value+")");
		}
		
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Search for Instances using string-delimited, case-insensitive tokens.
		/// </summary>
		/// <param name="Tokens">
		///   The Name search tokens.
		/// </param>
		public void InstanceNameContains(string Tokens) {
			Trav.AppendToUri("/InstanceNameContains("+Tokens+")");
		}
		
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Restricts the size and starting index of the vertex list.
		/// </summary>
		/// <param name="Index">
		///   The starting index for the returned list of vertices.
		/// </param>
		/// <param name="Count">
		///   The maximum number of vertices to return.
		/// </param>
		public void Limit(long Index, int Count) {
			Trav.AppendToUri("/Limit("+"+Index+"+","+Count+")");
		}
		
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Obtains a Member by its MemberId.
		/// </summary>
		/// <param name="Value">
		///   The MemberId of the target Member.
		/// </param>
		public void MemberId(long Value) {
			Trav.AppendToUri("/MemberId("+Value+")");
		}
		
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Obtains a MemberTypeAssign by its MemberTypeAssignId.
		/// </summary>
		/// <param name="Value">
		///   The MemberTypeAssignId of the target MemberTypeAssign.
		/// </param>
		public void MemberTypeAssignId(long Value) {
			Trav.AppendToUri("/MemberTypeAssignId("+Value+")");
		}
		
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Restricts the results to include only App vertices.
		/// </summary>
		
		public void ToApp() {
			Trav.AppendToUri("/ToApp()");
		}
		
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Restricts the results to include only Class vertices.
		/// </summary>
		
		public void ToClass() {
			Trav.AppendToUri("/ToClass()");
		}
		
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Restricts the results to include only Instance vertices.
		/// </summary>
		
		public void ToInstance() {
			Trav.AppendToUri("/ToInstance()");
		}
		
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Restricts the results to include only Url vertices.
		/// </summary>
		
		public void ToUrl() {
			Trav.AppendToUri("/ToUrl()");
		}
		
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Restricts the results to include only User vertices.
		/// </summary>
		
		public void ToUser() {
			Trav.AppendToUri("/ToUser()");
		}
		
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Obtains a Url by its entire (case-insensitive) FullPath.
		/// </summary>
		/// <param name="Value">
		///   The FullPath of the target Url.
		/// </param>
		public void UrlFullPath(string Value) {
			Trav.AppendToUri("/UrlFullPath("+Value+")");
		}
		
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Obtains a Url by its ArtifactId.
		/// </summary>
		/// <param name="Value">
		///   The UrlId of the target Url.
		/// </param>
		public void UrlId(long Value) {
			Trav.AppendToUri("/UrlId("+Value+")");
		}
		
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Search for Urls using string-delimited, case-insensitive tokens.
		/// </summary>
		/// <param name="Tokens">
		///   The Name search tokens.
		/// </param>
		public void UrlNameContains(string Tokens) {
			Trav.AppendToUri("/UrlNameContains("+Tokens+")");
		}
		
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Obtains a User by its ArtifactId.
		/// </summary>
		/// <param name="Value">
		///   The UserId of the target User.
		/// </param>
		public void UserId(long Value) {
			Trav.AppendToUri("/UserId("+Value+")");
		}
		
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Obtains a User by its entire (case-insensitive) Name.
		/// </summary>
		/// <param name="Value">
		///   The Name of the target User.
		/// </param>
		public void UserName(string Value) {
			Trav.AppendToUri("/UserName("+Value+")");
		}
		
	}

	// ReSharper restore InconsistentNaming
	
}