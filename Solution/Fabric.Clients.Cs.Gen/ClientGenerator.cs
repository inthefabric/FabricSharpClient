namespace Fabric.Clients.Cs.Infrastructure {

	/*================================================================================================*/
	public class FabApp {
		public long AppId { get; set; }
		public string Name { get; set; }
	}
	
	/*================================================================================================*/
	public class FabArtifact {
		public long ArtifactId { get; set; }
		public long Created { get; set; }
		public bool IsPrivate { get; set; }
	}
	
	/*================================================================================================*/
	public class FabArtifactOwnerNode {
	}
	
	/*================================================================================================*/
	public class FabArtifactType {
		public long ArtifactTypeId { get; set; }
	}
	
	/*================================================================================================*/
	public class FabClass {
		public long ClassId { get; set; }
		public string Disamb { get; set; }
		public string Name { get; set; }
		public string Note { get; set; }
	}
	
	/*================================================================================================*/
	public class FabDescriptor {
		public long DescriptorId { get; set; }
	}
	
	/*================================================================================================*/
	public class FabDescriptorType {
		public long DescriptorTypeId { get; set; }
	}
	
	/*================================================================================================*/
	public class FabDirector {
		public long DirectorId { get; set; }
	}
	
	/*================================================================================================*/
	public class FabDirectorAction {
		public long DirectorActionId { get; set; }
	}
	
	/*================================================================================================*/
	public class FabDirectorType {
		public long DirectorTypeId { get; set; }
	}
	
	/*================================================================================================*/
	public class FabError {
		public int Code { get; set; }
		public string Message { get; set; }
		public string Name { get; set; }
	}
	
	/*================================================================================================*/
	public class FabEventor {
		public long DateTime { get; set; }
		public long EventorId { get; set; }
	}
	
	/*================================================================================================*/
	public class FabEventorPrecision {
		public long EventorPrecisionId { get; set; }
	}
	
	/*================================================================================================*/
	public class FabEventorType {
		public long EventorTypeId { get; set; }
	}
	
	/*================================================================================================*/
	public class FabFactor {
		public long? Completed { get; set; }
		public long Created { get; set; }
		public long FactorId { get; set; }
		public bool IsDefining { get; set; }
		public string Note { get; set; }
	}
	
	/*================================================================================================*/
	public class FabFactorAssertion {
		public long FactorAssertionId { get; set; }
	}
	
	/*================================================================================================*/
	public class FabFactorElementNode {
	}
	
	/*================================================================================================*/
	public class FabHome {
		public FabService[] Services { get; set; }
	}
	
	/*================================================================================================*/
	public class FabIdentor {
		public long IdentorId { get; set; }
		public string Value { get; set; }
	}
	
	/*================================================================================================*/
	public class FabIdentorType {
		public long IdentorTypeId { get; set; }
	}
	
	/*================================================================================================*/
	public class FabInstance {
		public string Disamb { get; set; }
		public long InstanceId { get; set; }
		public string Name { get; set; }
		public string Note { get; set; }
	}
	
	/*================================================================================================*/
	public class FabLocator {
		public long LocatorId { get; set; }
		public double ValueX { get; set; }
		public double ValueY { get; set; }
		public double ValueZ { get; set; }
	}
	
	/*================================================================================================*/
	public class FabLocatorType {
		public long LocatorTypeId { get; set; }
		public double MaxX { get; set; }
		public double MaxY { get; set; }
		public double MaxZ { get; set; }
		public double MinX { get; set; }
		public double MinY { get; set; }
		public double MinZ { get; set; }
	}
	
	/*================================================================================================*/
	public class FabMember {
		public long MemberId { get; set; }
	}
	
	/*================================================================================================*/
	public class FabMemberType {
		public long MemberTypeId { get; set; }
	}
	
	/*================================================================================================*/
	public class FabMemberTypeAssign {
		public long MemberTypeAssignId { get; set; }
	}
	
	/*================================================================================================*/
	public class FabNode {
		public string Uri { get; set; }
	}
	
	/*================================================================================================*/
	public class FabNodeForAction {
		public string Note { get; set; }
		public long Performed { get; set; }
	}
	
	/*================================================================================================*/
	public class FabNodeForType {
		public string Description { get; set; }
		public string Name { get; set; }
	}
	
	/*================================================================================================*/
	public class FabOauthAccess {
		public string access_token { get; set; }
		public int expires_in { get; set; }
		public string refresh_token { get; set; }
		public string token_type { get; set; }
	}
	
	/*================================================================================================*/
	public class FabOauthError {
		public string error { get; set; }
		public string error_description { get; set; }
	}
	
	/*================================================================================================*/
	public class FabOauthLogin {
		public string code { get; set; }
		public string error { get; set; }
		public string error_description { get; set; }
		public string state { get; set; }
	}
	
	/*================================================================================================*/
	public class FabOauthLogout {
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
	public class FabRoot {
		public int RootId { get; set; }
	}
	
	/*================================================================================================*/
	public class FabService {
		public string Name { get; set; }
		public FabServiceOperation[] Operations { get; set; }
		public string Uri { get; set; }
	}
	
	/*================================================================================================*/
	public class FabServiceOperation {
		public string Method { get; set; }
		public string Name { get; set; }
		public string ReturnType { get; set; }
		public string Uri { get; set; }
	}
	
	/*================================================================================================*/
	public class FabStepLink {
		public string Class { get; set; }
		public bool IsOut { get; set; }
		public string Rel { get; set; }
		public string Uri { get; set; }
	}
	
	/*================================================================================================*/
	public class FabUrl {
		public string AbsoluteUrl { get; set; }
		public string Name { get; set; }
		public long UrlId { get; set; }
	}
	
	/*================================================================================================*/
	public class FabUser {
		public string Name { get; set; }
		public long UserId { get; set; }
	}
	
	/*================================================================================================*/
	public class FabVector {
		public long Value { get; set; }
		public long VectorId { get; set; }
	}
	
	/*================================================================================================*/
	public class FabVectorRange {
		public long VectorRangeId { get; set; }
	}
	
	/*================================================================================================*/
	public class FabVectorRangeLevel {
		public float Position { get; set; }
		public long VectorRangeLevelId { get; set; }
	}
	
	/*================================================================================================*/
	public class FabVectorType {
		public long Max { get; set; }
		public long Min { get; set; }
		public long VectorTypeId { get; set; }
	}
	
	/*================================================================================================*/
	public class FabVectorUnit {
		public string Symbol { get; set; }
		public long VectorUnitId { get; set; }
	}
	
	/*================================================================================================*/
	public class FabVectorUnitDerived {
		public int Exponent { get; set; }
		public long VectorUnitDerivedId { get; set; }
	}
	
	/*================================================================================================*/
	public class FabVectorUnitPrefix {
		public double Amount { get; set; }
		public string Symbol { get; set; }
		public long VectorUnitPrefixId { get; set; }
	}
	
}