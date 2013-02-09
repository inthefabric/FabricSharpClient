using System;
using NUnit.Framework;
using Fabric.Clients.Cs.Infrastructure;
using Fabric.Clients.Cs.Gen;
using System.Collections.Generic;

namespace Fabric.Clients.Cs.Test {
	
	/*================================================================================================*/
	[TestFixture]
	public class MyClass {
	
			
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		[Test]
		public void Basic() {
			var result = Traversal.Root
				.ContainsClassList.HasArtifact.InFactorListUsesPrimary.Get(123);
			Assert.NotNull(result);	
		}
		
	}
}

