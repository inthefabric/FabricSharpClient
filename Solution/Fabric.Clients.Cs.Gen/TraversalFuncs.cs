namespace Fabric.Clients.Cs.Gen {

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
		///    TODO
		///</summary>
		///<param name="Count">
		///    TODO
		///</param>
		public void Back(int pCount) {
			Trav.AppendToUri("/Back("+pCount+")");
		}
		
		/*--------------------------------------------------------------------------------------------*/
		///<summary>
		///    TODO
		///</summary>
		///<param name="Index">
		///    TODO
		///</param>
		///<param name="Count">
		///    TODO
		///</param>
		public void Limit(long pIndex, int pCount) {
			Trav.AppendToUri("/Limit("+pIndex+","+pCount+")");
		}
		
	}
	
}