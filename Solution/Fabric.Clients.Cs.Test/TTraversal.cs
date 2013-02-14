using Fabric.Clients.Cs.Gen;
using NUnit.Framework;

namespace Fabric.Clients.Cs.Test {
	
	/*================================================================================================*/
	[TestFixture]
	public class TTraversal {
	
			
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		[Test]
		public void Basic() {
			var result = Traversal.Root
				.ContainsClassList.HasArtifact.InFactorListUsesPrimary.Get(123);
			Assert.NotNull(result);	
		}
		
		/*--------------------------------------------------------------------------------------------*/
		[Test]
		public void Back() {
			const string asArt = "ART";
			ITraversalStepAlias<IFabArtifactStep> artAlias;
			
			var result = Traversal.Root
				.ContainsClassList.HasArtifact.As(asArt, out artAlias).InFactorListUsesPrimary
				.InMemberCreates.Back(artAlias);

			Assert.NotNull(result);
		}
		
	}

}