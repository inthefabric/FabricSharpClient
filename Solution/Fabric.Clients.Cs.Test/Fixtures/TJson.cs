using Fabric.Clients.Cs.Api;
using NUnit.Framework;
using ServiceStack.Text;

namespace Fabric.Clients.Cs.Test.Fixtures {
	
	/*================================================================================================*/
	[TestFixture]
	public class TJson {


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		[Test]
		public void EnumAsInteger_Descriptor() {
			const string expect = "{\"Type\":2}";

			var desc = new CreateFabDescriptor();
			desc.Type = DescriptorTypeId.IsA;

			Assert.AreEqual(expect, desc.ToJson(), "Incorrect JSON.");
		}

		/*--------------------------------------------------------------------------------------------*/
		[Test]
		public void EnumAsInteger_Director() {
			const string expect = "{\"Type\":2,\"PrimaryAction\":1,\"RelatedAction\":5}";

			var dir = new CreateFabDirector();
			dir.Type = DirectorTypeId.DefinedPath;
			dir.PrimaryAction = DirectorActionId.Read;
			dir.RelatedAction = DirectorActionId.Perform;

			Assert.AreEqual(expect, dir.ToJson(), "Incorrect JSON.");
		}

	}

}