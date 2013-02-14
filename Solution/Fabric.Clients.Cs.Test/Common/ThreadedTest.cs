using System.Collections.Generic;
using System.Threading;
using Fabric.Clients.Cs.Session;
using Moq;
using NUnit.Framework;

namespace Fabric.Clients.Cs.Test.Common {
	
	/*================================================================================================*/
	public class ThreadedTest {

		private readonly Dictionary<int, IFabricSessionContainer> vSessContainMap;
		private int vEntry;

		private ThreadTest vThreadTest;


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public ThreadedTest() {
			vSessContainMap = new Dictionary<int, IFabricSessionContainer>();
			vEntry = 0;
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public IFabricSessionContainer GetSessionContainer() {
			return vSessContainMap[Thread.CurrentThread.ManagedThreadId];
		}

		/*--------------------------------------------------------------------------------------------*/
		public void RunTest(ParameterizedThreadStart pDelegate) {
			var mockPerA = new Mock<PersonSession>(null, null);
			mockPerA.SetupGet(x => x.SessionId).Returns("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");
			var sessContainA = new FabricSessionContainer { Person = mockPerA.Object };

			var mockPerB = new Mock<PersonSession>(null, null);
			mockPerB.SetupGet(x => x.SessionId).Returns("BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBB");
			var sessContainB = new FabricSessionContainer { Person = mockPerB.Object };

			var threadA = new Thread(pDelegate);
			var threadB = new Thread(pDelegate);

			var testA = new ThreadTest();
			var testB = new ThreadTest();

			vSessContainMap.Add(threadA.ManagedThreadId, sessContainA);
			vSessContainMap.Add(threadB.ManagedThreadId, sessContainB);

			threadA.Start(testA);
			threadB.Start(testB);

			threadA.Join();
			threadB.Join();

			if ( testA.Failure != null ) {
				Assert.Fail("Thread A: "+testA.Failure);
			}

			if ( testB.Failure != null ) {
				Assert.Fail("Thread B: "+testB.Failure);
			}
		}

		/*--------------------------------------------------------------------------------------------*/
		public void MockEntryCallback() {
			if ( ++vEntry != 1 ) {
				vThreadTest.Failure = "Simultaneous request failure; not thread-safe.";
			}

			Thread.Sleep(200);
			vEntry--;
		}

		/*--------------------------------------------------------------------------------------------*/
		public void SetThreadTest(object pTest) {
			vThreadTest = (ThreadTest)pTest;
		}

	}
	

	/*================================================================================================*/
	internal class ThreadTest {

		public string Failure { get; set; }

	}

}