using System;
using Fabric.Clients.Cs.Spec;
using Fabric.Clients.Cs.Spec.SpecDto;
using NUnit.Framework;

namespace Fabric.Clients.Cs.Test.Fixtures {
	
	/*================================================================================================*/
	[TestFixture]
	public class TSpec {

		private FabSpec vSpec;


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		[SetUp]
		public void SetUp() {
			vSpec = SpecBuilder.Spec;
		}

		/*--------------------------------------------------------------------------------------------*/
		[TearDown]
		public void TearDown() {
		}


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		[Test]
		public void CheckRoot() {
			foreach ( FabSpecObject so in vSpec.Objects ) {
				Console.WriteLine(so.Name+" / "+so.TraversalFunctions);
			}
		}

	}

}