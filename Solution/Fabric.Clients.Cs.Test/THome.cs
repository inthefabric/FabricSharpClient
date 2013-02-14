using System;
using Fabric.Clients.Cs.Gen;
using NUnit.Framework;

namespace Fabric.Clients.Cs.Test {
	
	/*================================================================================================*/
	[TestFixture]
	public class THome {
	
			
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		[Test]
		public void Basic() {
			var api = new FabricServices();
			api.Modify.AttachDescriptorToFactor.ToUri(123, null, 123, null, null);

			//Console.WriteLine(result.Trav.GetTraversalUri());
			//Console.WriteLine(result.GetReturnType());
		}
		
	}

}