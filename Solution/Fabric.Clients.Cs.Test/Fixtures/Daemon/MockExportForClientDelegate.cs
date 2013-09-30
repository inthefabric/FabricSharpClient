using System;
using System.Collections.Generic;
using Fabric.Clients.Cs.Api;
using Fabric.Clients.Cs.Daemon;
using Fabric.Clients.Cs.Daemon.Data;
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
			vRemainMap.Add(typeof(IClassData).Name, pClasses);
			vRemainMap.Add(typeof(IInstanceData).Name, pInstances);
			vRemainMap.Add(typeof(IUrlData).Name, pUrls);
			vRemainMap.Add(typeof(FabBatchNewFactor).Name, pFactors);

			Setup(x => x.GetNewClasses()).Returns(NewList<IClassData>);
			Setup(x => x.GetNewInstances()).Returns(NewList<IInstanceData>);
			Setup(x => x.GetNewUrls()).Returns(NewList<IUrlData>);
			Setup(x => x.GetNewFactors()).Returns(NewList<FabBatchNewFactor>);
		}

		/*--------------------------------------------------------------------------------------------*/
		private IList<T> NewList<T>() where T : class {
			string key = typeof(T).Name;
			int rem = Math.Min(10, vRemainMap[key]);
			vRemainMap[key] -= rem;

			var list = new List<T>();

			for ( int i = 0 ; i < rem ; ++i ) {
				list.Add(new Mock<T>().Object);
			}

			return list;
		}

	}

}