// GENERATED CODE
// Changes made to this source file will be overwritten
// Generated on 2/14/2013 3:03:35 PM

namespace Fabric.Clients.Cs.Api {

	// ReSharper disable InconsistentNaming

	/*================================================================================================*/
	public interface IFuncAs : ITraversalStep {}

		
	/*================================================================================================*/
	public interface IFuncBack : ITraversalStep {}

		
	/*================================================================================================*/
	public interface IFuncLimit : ITraversalStep {}

		
	/*================================================================================================*/
	public interface IFuncWhereId : ITraversalStep {}

		
	/*================================================================================================*/
	public class TraversalFuncs {
	
		protected Traversal Trav { get; private set; }
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public TraversalFuncs(Traversal pTrav) {
			Trav = pTrav;
		}
		

		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///  TODO
		///</summary>
		///<param name="Alias">
		///  TODO
		///</param>
		public void As(string Alias) {
			Trav.AppendToUri("/As("+Alias+")");
		}
		
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///  TODO
		///</summary>
		///<param name="Alias">
		///  TODO
		///</param>
		public void Back(string Alias) {
			Trav.AppendToUri("/Back("+Alias+")");
		}
		
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///  TODO
		///</summary>
		///<param name="Index">
		///  TODO
		///</param>
		///<param name="Count">
		///  TODO
		///</param>
		public void Limit(long Index, int Count) {
			Trav.AppendToUri("/Limit("+Index+","+Count+")");
		}
		
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///  TODO
		///</summary>
		///<param name="Id">
		///  TODO
		///</param>
		public void WhereId(long Id) {
			Trav.AppendToUri("/WhereId("+Id+")");
		}
		
	}

	// ReSharper restore InconsistentNaming
	
}