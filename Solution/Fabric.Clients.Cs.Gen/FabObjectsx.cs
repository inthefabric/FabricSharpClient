namespace Fabric.Clients.Cs.Infrastructure {

	/*================================================================================================*/
	public class FabApp : FabArtifactOwnerNode {
		public long AppId { get; set; }
		public string Name { get; set; }
	}
	
	/*================================================================================================*/
	public class FabArtifact : FabNode {
		public long ArtifactId { get; set; }
		public long Created { get; set; }
		public bool IsPrivate { get; set; }
	}
	
	/*================================================================================================*/
	public class FabArtifactOwnerNode : FabNode {
	}
	
	/*================================================================================================*/
	public class FabArtifactType : FabNodeForType {
		public long ArtifactTypeId { get; set; }
	}
	
	/*================================================================================================*/
	public class FabClass : FabArtifactOwnerNode {
		public long ClassId { get; set; }
		public string Disamb { get; set; }
		public string Name { get; set; }
		public string Note { get; set; }
	}
	
	/*================================================================================================*/
	public class FabDescriptor : FabFactorElementNode {
		public long DescriptorId { get; set; }
	}
	
	/*================================================================================================*/
	public class FabDescriptorType : FabNodeForType {
		public long DescriptorTypeId { get; set; }
	}
	
	/*================================================================================================*/
	public class FabDirector : FabFactorElementNode {
		public long DirectorId { get; set; }
	}
	
	/*================================================================================================*/
	public class FabDirectorAction : FabNodeForType {
		public long DirectorActionId { get; set; }
	}
	
	/*================================================================================================*/
	public class FabDirectorType : FabNodeForType {
		public long DirectorTypeId { get; set; }
	}
	
	/*================================================================================================*/
	public class FabError : FabObject {
		public int Code { get; set; }
		public string Message { get; set; }
		public string Name { get; set; }
	}
	
	/*================================================================================================*/
	public class FabEventor : FabFactorElementNode {
		public long DateTime { get; set; }
		public long EventorId { get; set; }
	}
	
	/*================================================================================================*/
	public class FabEventorPrecision : FabNodeForType {
		public long EventorPrecisionId { get; set; }
	}
	
	/*================================================================================================*/
	public class FabEventorType : FabNodeForType {
		public long EventorTypeId { get; set; }
	}
	
	/*================================================================================================*/
	public class FabFactor : FabNode {
		public long? Completed { get; set; }
		public long Created { get; set; }
		public long FactorId { get; set; }
		public bool IsDefining { get; set; }
		public string Note { get; set; }
	}
	
	/*================================================================================================*/
	public class FabFactorAssertion : FabNodeForType {
		public long FactorAssertionId { get; set; }
	}
	
	/*================================================================================================*/
	public class FabFactorElementNode : FabNode {
	}
	
	/*================================================================================================*/
	public class FabHome : FabObject {
		public FabService[] Services { get; set; }
	}
	
	/*================================================================================================*/
	public class FabIdentor : FabFactorElementNode {
		public long IdentorId { get; set; }
		public string Value { get; set; }
	}
	
	/*================================================================================================*/
	public class FabIdentorType : FabNodeForType {
		public long IdentorTypeId { get; set; }
	}
	
	/*================================================================================================*/
	public class FabInstance : FabArtifactOwnerNode {
		public string Disamb { get; set; }
		public long InstanceId { get; set; }
		public string Name { get; set; }
		public string Note { get; set; }
	}
	
	/*================================================================================================*/
	public class FabLocator : FabFactorElementNode {
		public long LocatorId { get; set; }
		public double ValueX { get; set; }
		public double ValueY { get; set; }
		public double ValueZ { get; set; }
	}
	
	/*================================================================================================*/
	public class FabLocatorType : FabNodeForType {
		public long LocatorTypeId { get; set; }
		public double MaxX { get; set; }
		public double MaxY { get; set; }
		public double MaxZ { get; set; }
		public double MinX { get; set; }
		public double MinY { get; set; }
		public double MinZ { get; set; }
	}
	
	/*================================================================================================*/
	public class FabMember : FabNode {
		public long MemberId { get; set; }
	}
	
	/*================================================================================================*/
	public class FabMemberType : FabNodeForType {
		public long MemberTypeId { get; set; }
	}
	
	/*================================================================================================*/
	public class FabMemberTypeAssign : FabNodeForAction {
		public long MemberTypeAssignId { get; set; }
	}
	
	/*================================================================================================*/
	public class FabNode : FabObject {
		public string Uri { get; set; }
	}
	
	/*================================================================================================*/
	public class FabNodeForAction : FabNode {
		public string Note { get; set; }
		public long Performed { get; set; }
	}
	
	/*================================================================================================*/
	public class FabNodeForType : FabNode {
		public string Description { get; set; }
		public string Name { get; set; }
	}
	
	/*================================================================================================*/
	public class FabOauthAccess : FabObject {
		public string access_token { get; set; }
		public int expires_in { get; set; }
		public string refresh_token { get; set; }
		public string token_type { get; set; }
	}
	
	/*================================================================================================*/
	public class FabOauthError : FabObject {
		public string error { get; set; }
		public string error_description { get; set; }
	}
	
	/*================================================================================================*/
	public class FabOauthLogin : FabObject {
		public string code { get; set; }
		public string error { get; set; }
		public string error_description { get; set; }
		public string state { get; set; }
	}
	
	/*================================================================================================*/
	public class FabOauthLogout : FabObject {
		public string access_token { get; set; }
		public int success { get; set; }
	}
	
	/*================================================================================================*/
	public class FabObject {
		public string FabType { get; set; }
	}
	
	/*================================================================================================*/
	public class FabResponse {
		public long AppId { get; set; }
		public string BaseUri { get; set; }
		public int Count { get; set; }
		public object Data { get; set; }
		public int DataLen { get; set; }
		public int DbMs { get; set; }
		public string[] Functions { get; set; }
		public bool HasMore { get; set; }
		public int HttpStatus { get; set; }
		public bool IsError { get; set; }
		public FabStepLink[] Links { get; set; }
		public string RequestUri { get; set; }
		public long StartIndex { get; set; }
		public long Timestamp { get; set; }
		public int TotalMs { get; set; }
		public long UserId { get; set; }
	}
	
	/*================================================================================================*/
	public class FabRoot : FabNode {
		public int RootId { get; set; }
	}
	
	/*================================================================================================*/
	public class FabService : FabObject {
		public string Name { get; set; }
		public FabServiceOperation[] Operations { get; set; }
		public string Uri { get; set; }
	}
	
	/*================================================================================================*/
	public class FabServiceOperation : FabObject {
		public string Method { get; set; }
		public string Name { get; set; }
		public string ReturnType { get; set; }
		public string Uri { get; set; }
	}
	
	/*================================================================================================*/
	public class FabStepLink : FabObject {
		public string Class { get; set; }
		public bool IsOut { get; set; }
		public string Rel { get; set; }
		public string Uri { get; set; }
	}
	
	/*================================================================================================*/
	public class FabUrl : FabArtifactOwnerNode {
		public string AbsoluteUrl { get; set; }
		public string Name { get; set; }
		public long UrlId { get; set; }
	}
	
	/*================================================================================================*/
	public class FabUser : FabArtifactOwnerNode {
		public string Name { get; set; }
		public long UserId { get; set; }
	}
	
	/*================================================================================================*/
	public class FabVector : FabFactorElementNode {
		public long Value { get; set; }
		public long VectorId { get; set; }
	}
	
	/*================================================================================================*/
	public class FabVectorRange : FabNodeForType {
		public long VectorRangeId { get; set; }
	}
	
	/*================================================================================================*/
	public class FabVectorRangeLevel : FabNodeForType {
		public float Position { get; set; }
		public long VectorRangeLevelId { get; set; }
	}
	
	/*================================================================================================*/
	public class FabVectorType : FabNodeForType {
		public long Max { get; set; }
		public long Min { get; set; }
		public long VectorTypeId { get; set; }
	}
	
	/*================================================================================================*/
	public class FabVectorUnit : FabNodeForType {
		public string Symbol { get; set; }
		public long VectorUnitId { get; set; }
	}
	
	/*================================================================================================*/
	public class FabVectorUnitDerived : FabNodeForType {
		public int Exponent { get; set; }
		public long VectorUnitDerivedId { get; set; }
	}
	
	/*================================================================================================*/
	public class FabVectorUnitPrefix : FabNodeForType {
		public double Amount { get; set; }
		public string Symbol { get; set; }
		public long VectorUnitPrefixId { get; set; }
	}
	
}