// GENERATED CODE
// Changes made to this source file will be overwritten
// Generated on 2/15/2013 4:50:06 PM

namespace Fabric.Clients.Cs.Api {

	// ReSharper disable InconsistentNaming

	/*================================================================================================*/
	/// <summary />
	public interface IFuncAs : ITraversalStep {}

		
	/*================================================================================================*/
	/// <summary />
	public interface IFuncBack : ITraversalStep {}

		
	/*================================================================================================*/
	/// <summary />
	public interface IFuncLimit : ITraversalStep {}

		
	/*================================================================================================*/
	/// <summary />
	public interface IFuncWhereId : ITraversalStep {}

		
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
		///   TODO
		/// </summary>
		/// <param name="Alias">
		///   TODO
		/// </param>
		public void As(string Alias) {
			Trav.AppendToUri("/As("+Alias+")");
		}
		
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   TODO
		/// </summary>
		/// <param name="Alias">
		///   TODO
		/// </param>
		public void Back(string Alias) {
			Trav.AppendToUri("/Back("+Alias+")");
		}
		
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   TODO
		/// </summary>
		/// <param name="Index">
		///   TODO
		/// </param>
		/// <param name="Count">
		///   TODO
		/// </param>
		public void Limit(long Index, int Count) {
			Trav.AppendToUri("/Limit("+Index+","+Count+")");
		}
		
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   TODO
		/// </summary>
		/// <param name="Id">
		///   TODO
		/// </param>
		public void WhereId(long Id) {
			Trav.AppendToUri("/WhereId("+Id+")");
		}
		
	}

	// ReSharper restore InconsistentNaming
	
}