using System;
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
			IFabFactorStep result = Traversal.Root
				.ContainsClassList.HasArtifact.InFactorListUsesPrimary;

			Console.WriteLine(result.Trav.GetTraversalUri());
			Console.WriteLine(result.GetReturnType());
		}
		
		/*--------------------------------------------------------------------------------------------*/
		[Test]
		public void Back() {
			const string asArt = "ART";
			ITraversalStepAlias<IFabArtifactStep> artAlias;
			
			IFabArtifactStep result = Traversal.Root
				.ContainsClassList.HasArtifact.As(asArt, out artAlias).InFactorListUsesPrimary
				.InMemberCreates.Back(artAlias);

			Console.WriteLine(result.Trav.GetTraversalUri());
			Console.WriteLine(result.GetReturnType());
		}
		
	}

}