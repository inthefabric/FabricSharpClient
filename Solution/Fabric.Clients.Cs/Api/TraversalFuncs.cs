// GENERATED CODE
// Changes made to this source file will be overwritten
// Generated on 4/19/2013 5:20:29 PM

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
	public interface IFuncWhereApp : ITraversalStep {}

		
	/*================================================================================================*/
	/// <summary />
	public interface IFuncWhereClass : ITraversalStep {}

		
	/*================================================================================================*/
	/// <summary />
	public interface IFuncWhereId : ITraversalStep {}

		
	/*================================================================================================*/
	/// <summary />
	public interface IFuncWhereInstance : ITraversalStep {}

		
	/*================================================================================================*/
	/// <summary />
	public interface IFuncWhereUrl : ITraversalStep {}

		
	/*================================================================================================*/
	/// <summary />
	public interface IFuncWhereUser : ITraversalStep {}

		
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
		///   Restricts the size and starting index of the node list.
		/// </summary>
		/// <param name="Index">
		///   The starting index for the returned list of nodes.
		/// </param>
		/// <param name="Count">
		///   The maximum number of nodes to return.
		/// </param>
		public void Limit(long Index, int Count) {
			Trav.AppendToUri("/Limit("+"+Index+"+","+Count+")");
		}
		
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Restricts the results to include only App nodes.
		/// </summary>
		
		public void WhereApp() {
			Trav.AppendToUri("/WhereApp()");
		}
		
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Restricts the results to include only Class nodes.
		/// </summary>
		
		public void WhereClass() {
			Trav.AppendToUri("/WhereClass()");
		}
		
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Restricts the results to a single Id value.
		/// </summary>
		/// <param name="Id">
		///   The target node Id.
		/// </param>
		public void WhereId(long Id) {
			Trav.AppendToUri("/WhereId("+Id+")");
		}
		
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Restricts the results to include only Instance nodes.
		/// </summary>
		
		public void WhereInstance() {
			Trav.AppendToUri("/WhereInstance()");
		}
		
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Restricts the results to include only Url nodes.
		/// </summary>
		
		public void WhereUrl() {
			Trav.AppendToUri("/WhereUrl()");
		}
		
		/*--------------------------------------------------------------------------------------------*/
		/// <summary>
		///   Restricts the results to include only User nodes.
		/// </summary>
		
		public void WhereUser() {
			Trav.AppendToUri("/WhereUser()");
		}
		
	}

	// ReSharper restore InconsistentNaming
	
}