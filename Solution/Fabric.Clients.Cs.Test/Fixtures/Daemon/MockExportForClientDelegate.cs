using System;
using System.Collections.Generic;
using Fabric.Clients.Cs.Api;
using Fabric.Clients.Cs.Daemon;
using Moq;

namespace Fabric.Clients.Cs.Test.Fixtures.Daemon {
	
	/*================================================================================================*/
	public class MockExportForClientDelegate : Mock<IExportForClientDelegate> {

		private IDictionary<string, int> vRemainMap;


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public MockExportForClientDelegate() {
			SetCounts(0, 0, 0, 0);
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public void SetCounts(int pClasses, int pInstances, int pUrls, int pFactors) {
			vRemainMap = new Dictionary<string, int>();
			vRemainMap.Add(typeof(CreateFabClass).Name, pClasses);
			vRemainMap.Add(typeof(CreateFabInstance).Name, pInstances);
			vRemainMap.Add(typeof(CreateFabUrl).Name, pUrls);
			vRemainMap.Add(typeof(CreateFabFactor).Name, pFactors);

			Setup(x => x.GetNewClasses()).Returns(NewList<CreateFabClass>);
			Setup(x => x.GetNewInstances()).Returns(NewList<CreateFabInstance>);
			Setup(x => x.GetNewUrls()).Returns(NewList<CreateFabUrl>);
			Setup(x => x.GetNewFactors()).Returns(NewList<CreateFabFactor>);
		}

		/*--------------------------------------------------------------------------------------------*/
		private IList<T> NewList<T>() where T : class {
			string key = typeof(T).Name;
			int rem = Math.Min(10, vRemainMap[key]);
			vRemainMap[key] -= rem;

			var list = new List<T>();

			for ( int i = 0 ; i < rem ; ++i ) {
				list.Add(new Mock<T>(MockBehavior.Strict).Object);
			}

			return list;
		}

	}

}