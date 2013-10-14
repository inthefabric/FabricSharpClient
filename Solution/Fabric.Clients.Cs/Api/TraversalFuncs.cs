// GENERATED CODE
// Changes made to this source file will be overwritten
// Generated on 10/14/2013 1:13:20 PM

namespace Fabric.Clients.Cs.Api {

	// ReSharper disable InconsistentNaming

	/*================================================================================================*/
	/// <summary />
	public interface IHasFuncAppId : ITraversalStep {}

		
	/*================================================================================================*/
	/// <summary />
	public interface IHasFuncAppName : ITraversalStep {}

		
	/*================================================================================================*/
	/// <summary />
	public interface IHasFuncAppNameContains : ITraversalStep {}

		
	/*================================================================================================*/
	/// <summary />
	public interface IHasFuncArtifactCreated : ITraversalStep {}

		
	/*================================================================================================*/
	/// <summary />
	public interface IHasFuncArtifactId : ITraversalStep {}

		
	/*================================================================================================*/
	/// <summary />
	public interface IHasFuncAs : ITraversalStep {}

		
	/*================================================================================================*/
	/// <summary />
	public interface IHasFuncBack : ITraversalStep {}

		
	/*================================================================================================*/
	/// <summary />
	public interface IHasFuncClassDisambContains : ITraversalStep {}

		
	/*================================================================================================*/
	/// <summary />
	public interface IHasFuncClassId : ITraversalStep {}

		
	/*================================================================================================*/
	/// <summary />
	public interface IHasFuncClassName : ITraversalStep {}

		
	/*================================================================================================*/
	/// <summary />
	public interface IHasFuncClassNameContains : ITraversalStep {}

		
	/*================================================================================================*/
	/// <summary />
	public interface IHasFuncFactorCreated : ITraversalStep {}

		
	/*================================================================================================*/
	/// <summary />
	public interface IHasFuncFactorId : ITraversalStep {}

		
	/*================================================================================================*/
	/// <summary />
	public interface IHasFuncFactorIdentorValue : ITraversalStep {}

		
	/*================================================================================================*/
	/// <summary />
	public interface IHasFuncFactorIdentorValueContains : ITraversalStep {}

		
	/*================================================================================================*/
	/// <summary />
	public interface IHasFuncHasId : ITraversalStep {}

		
	/*================================================================================================*/
	/// <summary />
	public interface IHasFuncInstanceDisambContains : ITraversalStep {}

		
	/*================================================================================================*/
	/// <summary />
	public interface IHasFuncInstanceId : ITraversalStep {}

		
	/*================================================================================================*/
	/// <summary />
	public interface IHasFuncInstanceNameContains : ITraversalStep {}

		
	/*================================================================================================*/
	/// <summary />
	public interface IHasFuncLimit : ITraversalStep {}

		
	/*================================================================================================*/
	/// <summary />
	public interface IHasFuncMemberId : ITraversalStep {}

		
	/*================================================================================================*/
	/// <summary />
	public interface IHasFuncMemberTypeAssignId : ITraversalStep {}

		
	/*================================================================================================*/
	/// <summary />
	public interface IHasFuncToApp : ITraversalStep {}

		
	/*================================================================================================*/
	/// <summary />
	public interface IHasFuncToClass : ITraversalStep {}

		
	/*================================================================================================*/
	/// <summary />
	public interface IHasFuncToInstance : ITraversalStep {}

		
	/*================================================================================================*/
	/// <summary />
	public interface IHasFuncToUrl : ITraversalStep {}

		
	/*================================================================================================*/
	/// <summary />
	public interface IHasFuncToUser : ITraversalStep {}

		
	/*================================================================================================*/
	/// <summary />
	public interface IHasFuncUrlFullPath : ITraversalStep {}

		
	/*================================================================================================*/
	/// <summary />
	public interface IHasFuncUrlId : ITraversalStep {}

		
	/*================================================================================================*/
	/// <summary />
	public interface IHasFuncUrlNameContains : ITraversalStep {}

		
	/*================================================================================================*/
	/// <summary />
	public interface IHasFuncUserId : ITraversalStep {}

		
	/*================================================================================================*/
	/// <summary />
	public interface IHasFuncUserName : ITraversalStep {}

		
	/*================================================================================================*/
	public static partial class TraversalFuncs {


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Obtains an App by its ArtifactId.
		/// </summary>
		/// <param name="PrevStep"></param>
		/// <param name="Value">
		///   The ArtifactId of the target App.
		/// </param>
		public static IFabAppStep AppId<T>(this T PrevStep, long Value) where T : IHasFuncAppId {
			PrevStep.Trav.AppendToUri("/AppId("+Value+")");
			return new FabAppStep(PrevStep.Trav);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Obtains an App by its entire (case-insensitive) Name.
		/// </summary>
		/// <param name="PrevStep"></param>
		/// <param name="Value">
		///   The Name of the target App.
		/// </param>
		public static IFabAppStep AppName<T>(this T PrevStep, string Value) where T : IHasFuncAppName {
			PrevStep.Trav.AppendToUri("/AppName("+Value+")");
			return new FabAppStep(PrevStep.Trav);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Search for Apps using string-delimited, case-insensitive tokens.
		/// </summary>
		/// <param name="PrevStep"></param>
		/// <param name="Tokens">
		///   The Name search tokens.
		/// </param>
		public static IFabAppStep AppNameContains<T>(this T PrevStep, string Tokens) where T : IHasFuncAppNameContains {
			PrevStep.Trav.AppendToUri("/AppNameContains("+Tokens+")");
			return new FabAppStep(PrevStep.Trav);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Search for Artifacts by their creation date/time.
		/// </summary>
		/// <param name="PrevStep"></param>
		/// <param name="Operation">
		///   The operator to use for this search.
		/// </param>
		/// <param name="Value">
		///   The date/time to use for this search.
		/// </param>
		public static IFabArtifactStep ArtifactCreated<T>(this T PrevStep, string Operation, long Value) where T : IHasFuncArtifactCreated {
			PrevStep.Trav.AppendToUri("/ArtifactCreated("+Operation+","+Value+")");
			return new FabArtifactStep(PrevStep.Trav);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Obtains an Artifact by its ArtifactId.
		/// </summary>
		/// <param name="PrevStep"></param>
		/// <param name="Value">
		///   The ArtifactId of the target Artifact.
		/// </param>
		public static IFabArtifactStep ArtifactId<T>(this T PrevStep, long Value) where T : IHasFuncArtifactId {
			PrevStep.Trav.AppendToUri("/ArtifactId("+Value+")");
			return new FabArtifactStep(PrevStep.Trav);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Creates a named alias for the current step of the traversal path.
		/// </summary>
		/// <param name="PrevStep"></param>
		/// <param name="Alias">
		///   A named alias, which represents a particular place in the traversal path. This value must be unique across all other aliases in the traversal path.
		/// </param>
		internal static T As<T>(this T PrevStep, string Alias) where T : IHasFuncAs {
			PrevStep.Trav.AppendToUri("/As("+Alias+")");
			return PrevStep;
		}
		
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Returns the execution of the traversal path to a particular named alias.
		/// </summary>
		/// <param name="PrevStep"></param>
		/// <param name="Alias">
		///   The target named alias, which was defined by an As function earlier in the traversal path.
		/// </param>
		internal static T Back<T>(this T PrevStep, string Alias) where T : IHasFuncBack {
			PrevStep.Trav.AppendToUri("/Back("+Alias+")");
			return PrevStep;
		}
		
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Search for Classes using string-delimited, case-insensitive tokens.
		/// </summary>
		/// <param name="PrevStep"></param>
		/// <param name="Tokens">
		///   The Disamb search tokens.
		/// </param>
		public static IFabClassStep ClassDisambContains<T>(this T PrevStep, string Tokens) where T : IHasFuncClassDisambContains {
			PrevStep.Trav.AppendToUri("/ClassDisambContains("+Tokens+")");
			return new FabClassStep(PrevStep.Trav);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Obtains a Class by its ArtifactId.
		/// </summary>
		/// <param name="PrevStep"></param>
		/// <param name="Value">
		///   The ArtifactId of the target Class.
		/// </param>
		public static IFabClassStep ClassId<T>(this T PrevStep, long Value) where T : IHasFuncClassId {
			PrevStep.Trav.AppendToUri("/ClassId("+Value+")");
			return new FabClassStep(PrevStep.Trav);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Obtains a Class by its entire (case-insensitive) Name.
		/// </summary>
		/// <param name="PrevStep"></param>
		/// <param name="Value">
		///   The Name of the target Class.
		/// </param>
		public static IFabClassStep ClassName<T>(this T PrevStep, string Value) where T : IHasFuncClassName {
			PrevStep.Trav.AppendToUri("/ClassName("+Value+")");
			return new FabClassStep(PrevStep.Trav);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Search for Classes using string-delimited, case-insensitive tokens.
		/// </summary>
		/// <param name="PrevStep"></param>
		/// <param name="Tokens">
		///   The Name search tokens.
		/// </param>
		public static IFabClassStep ClassNameContains<T>(this T PrevStep, string Tokens) where T : IHasFuncClassNameContains {
			PrevStep.Trav.AppendToUri("/ClassNameContains("+Tokens+")");
			return new FabClassStep(PrevStep.Trav);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Search for Factors by their creation date/time.
		/// </summary>
		/// <param name="PrevStep"></param>
		/// <param name="Operation">
		///   The operator to use for this search.
		/// </param>
		/// <param name="Value">
		///   The date/time to use for this search.
		/// </param>
		public static IFabFactorStep FactorCreated<T>(this T PrevStep, string Operation, long Value) where T : IHasFuncFactorCreated {
			PrevStep.Trav.AppendToUri("/FactorCreated("+Operation+","+Value+")");
			return new FabFactorStep(PrevStep.Trav);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Obtains an Factor by its FactorId
		/// </summary>
		/// <param name="PrevStep"></param>
		/// <param name="Value">
		///   The FactorId of the target Factor.
		/// </param>
		public static IFabFactorStep FactorId<T>(this T PrevStep, long Value) where T : IHasFuncFactorId {
			PrevStep.Trav.AppendToUri("/FactorId("+Value+")");
			return new FabFactorStep(PrevStep.Trav);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Obtains a Factor by its full (case-insensitive) IdentorValue.
		/// </summary>
		/// <param name="PrevStep"></param>
		/// <param name="Value">
		///   The IdentorValue of the target Factor.
		/// </param>
		public static IFabFactorStep FactorIdentorValue<T>(this T PrevStep, string Value) where T : IHasFuncFactorIdentorValue {
			PrevStep.Trav.AppendToUri("/FactorIdentorValue("+Value+")");
			return new FabFactorStep(PrevStep.Trav);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Search for Factors using string-delimited, case-insensitive tokens.
		/// </summary>
		/// <param name="PrevStep"></param>
		/// <param name="Tokens">
		///   The IdentorValue search tokens.
		/// </param>
		public static IFabFactorStep FactorIdentorValueContains<T>(this T PrevStep, string Tokens) where T : IHasFuncFactorIdentorValueContains {
			PrevStep.Trav.AppendToUri("/FactorIdentorValueContains("+Tokens+")");
			return new FabFactorStep(PrevStep.Trav);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Restricts the results to a single Id value.
		/// </summary>
		/// <param name="PrevStep"></param>
		/// <param name="Id">
		///   The target vertex Id.
		/// </param>
		public static T HasId<T>(this T PrevStep, long Id) where T : IHasFuncHasId {
			PrevStep.Trav.AppendToUri("/HasId("+Id+")");
			return PrevStep;
		}
		
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Search for Instances using string-delimited, case-insensitive tokens.
		/// </summary>
		/// <param name="PrevStep"></param>
		/// <param name="Tokens">
		///   The Disamb search tokens.
		/// </param>
		public static IFabInstanceStep InstanceDisambContains<T>(this T PrevStep, string Tokens) where T : IHasFuncInstanceDisambContains {
			PrevStep.Trav.AppendToUri("/InstanceDisambContains("+Tokens+")");
			return new FabInstanceStep(PrevStep.Trav);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Obtains an Instance by its ArtifactId.
		/// </summary>
		/// <param name="PrevStep"></param>
		/// <param name="Value">
		///   The ArtifactId of the target Instance.
		/// </param>
		public static IFabInstanceStep InstanceId<T>(this T PrevStep, long Value) where T : IHasFuncInstanceId {
			PrevStep.Trav.AppendToUri("/InstanceId("+Value+")");
			return new FabInstanceStep(PrevStep.Trav);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Search for Instances using string-delimited, case-insensitive tokens.
		/// </summary>
		/// <param name="PrevStep"></param>
		/// <param name="Tokens">
		///   The Name search tokens.
		/// </param>
		public static IFabInstanceStep InstanceNameContains<T>(this T PrevStep, string Tokens) where T : IHasFuncInstanceNameContains {
			PrevStep.Trav.AppendToUri("/InstanceNameContains("+Tokens+")");
			return new FabInstanceStep(PrevStep.Trav);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Restricts the size and starting index of the vertex list.
		/// </summary>
		/// <param name="PrevStep"></param>
		/// <param name="Index">
		///   The starting index for the returned list of vertices.
		/// </param>
		/// <param name="Count">
		///   The maximum number of vertices to return.
		/// </param>
		public static T Limit<T>(this T PrevStep, long Index, int Count) where T : IHasFuncLimit {
			PrevStep.Trav.AppendToUri("/Limit("+Index+","+Count+")");
			return PrevStep;
		}
		
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Obtains a Member by its MemberId.
		/// </summary>
		/// <param name="PrevStep"></param>
		/// <param name="Value">
		///   The MemberId of the target Member.
		/// </param>
		public static IFabMemberStep MemberId<T>(this T PrevStep, long Value) where T : IHasFuncMemberId {
			PrevStep.Trav.AppendToUri("/MemberId("+Value+")");
			return new FabMemberStep(PrevStep.Trav);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Obtains a MemberTypeAssign by its MemberTypeAssignId.
		/// </summary>
		/// <param name="PrevStep"></param>
		/// <param name="Value">
		///   The MemberTypeAssignId of the target MemberTypeAssign.
		/// </param>
		public static IFabMemberTypeAssignStep MemberTypeAssignId<T>(this T PrevStep, long Value) where T : IHasFuncMemberTypeAssignId {
			PrevStep.Trav.AppendToUri("/MemberTypeAssignId("+Value+")");
			return new FabMemberTypeAssignStep(PrevStep.Trav);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Restricts the results to include only App vertices.
		/// </summary>
		/// <param name="PrevStep"></param>
		public static IFabAppStep ToApp<T>(this T PrevStep) where T : IHasFuncToApp {
			PrevStep.Trav.AppendToUri("/ToApp()");
			return new FabAppStep(PrevStep.Trav);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Restricts the results to include only Class vertices.
		/// </summary>
		/// <param name="PrevStep"></param>
		public static IFabClassStep ToClass<T>(this T PrevStep) where T : IHasFuncToClass {
			PrevStep.Trav.AppendToUri("/ToClass()");
			return new FabClassStep(PrevStep.Trav);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Restricts the results to include only Instance vertices.
		/// </summary>
		/// <param name="PrevStep"></param>
		public static IFabInstanceStep ToInstance<T>(this T PrevStep) where T : IHasFuncToInstance {
			PrevStep.Trav.AppendToUri("/ToInstance()");
			return new FabInstanceStep(PrevStep.Trav);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Restricts the results to include only Url vertices.
		/// </summary>
		/// <param name="PrevStep"></param>
		public static IFabUrlStep ToUrl<T>(this T PrevStep) where T : IHasFuncToUrl {
			PrevStep.Trav.AppendToUri("/ToUrl()");
			return new FabUrlStep(PrevStep.Trav);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Restricts the results to include only User vertices.
		/// </summary>
		/// <param name="PrevStep"></param>
		public static IFabUserStep ToUser<T>(this T PrevStep) where T : IHasFuncToUser {
			PrevStep.Trav.AppendToUri("/ToUser()");
			return new FabUserStep(PrevStep.Trav);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Obtains a Url by its entire (case-insensitive) FullPath.
		/// </summary>
		/// <param name="PrevStep"></param>
		/// <param name="Value">
		///   The FullPath of the target Url.
		/// </param>
		public static IFabUrlStep UrlFullPath<T>(this T PrevStep, string Value) where T : IHasFuncUrlFullPath {
			PrevStep.Trav.AppendToUri("/UrlFullPath("+Value+")");
			return new FabUrlStep(PrevStep.Trav);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Obtains a Url by its ArtifactId.
		/// </summary>
		/// <param name="PrevStep"></param>
		/// <param name="Value">
		///   The UrlId of the target Url.
		/// </param>
		public static IFabUrlStep UrlId<T>(this T PrevStep, long Value) where T : IHasFuncUrlId {
			PrevStep.Trav.AppendToUri("/UrlId("+Value+")");
			return new FabUrlStep(PrevStep.Trav);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Search for Urls using string-delimited, case-insensitive tokens.
		/// </summary>
		/// <param name="PrevStep"></param>
		/// <param name="Tokens">
		///   The Name search tokens.
		/// </param>
		public static IFabUrlStep UrlNameContains<T>(this T PrevStep, string Tokens) where T : IHasFuncUrlNameContains {
			PrevStep.Trav.AppendToUri("/UrlNameContains("+Tokens+")");
			return new FabUrlStep(PrevStep.Trav);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Obtains a User by its ArtifactId.
		/// </summary>
		/// <param name="PrevStep"></param>
		/// <param name="Value">
		///   The UserId of the target User.
		/// </param>
		public static IFabUserStep UserId<T>(this T PrevStep, long Value) where T : IHasFuncUserId {
			PrevStep.Trav.AppendToUri("/UserId("+Value+")");
			return new FabUserStep(PrevStep.Trav);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Obtains a User by its entire (case-insensitive) Name.
		/// </summary>
		/// <param name="PrevStep"></param>
		/// <param name="Value">
		///   The Name of the target User.
		/// </param>
		public static IFabUserStep UserName<T>(this T PrevStep, string Value) where T : IHasFuncUserName {
			PrevStep.Trav.AppendToUri("/UserName("+Value+")");
			return new FabUserStep(PrevStep.Trav);
		}
		
	}

	// ReSharper restore InconsistentNaming
	
}