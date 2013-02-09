using System;
using NUnit.Framework;
using Fabric.Clients.Cs.Infrastructure;

namespace Fabric.Clients.Cs.Test {
	
	[TestFixture]
	public class MyClass {
	
		[Test]
		public void Check() {
			var spec = SpecBuilder.Spec;
			
			Assert.Fail(spec.Objects[0].Description.Replace("\r\n", "$$$"));
		}
	}
}

