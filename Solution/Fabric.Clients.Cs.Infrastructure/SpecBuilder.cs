using System.Collections.Generic;
using System.IO;
using System.Web;
using ServiceStack.Text;
using Fabric.Clients.Cs.Infrastructure.SpecDto;
using System.Text.RegularExpressions;

namespace Fabric.Clients.Cs.Infrastructure {
	
	/*================================================================================================*/
	public static class SpecBuilder {
		
		private static FabSpec SpecInstance;
		private static Dictionary<string, FabSpecService> ServiceMap;
		private static Dictionary<string, FabSpecObject> ObjectMap;
		private static Dictionary<string, FabSpecTravFunc> FuncMap;
		//private static Dictionary<string, FabSpecServiceOperation> OperationMap;
		private static List<FabSpecTravFunc> FuncList;
		//private static List<FabSpecServiceOperation> OperationList;
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public static FabSpec Spec {
			get { return (SpecInstance ?? (SpecInstance = Build())); }
		}
		
		/*--------------------------------------------------------------------------------------------*/
		private static FabSpec Build() {
			string path = typeof(SpecBuilder).Assembly.Location;
			path = path.Substring(0, path.LastIndexOf('/'));
			string json = File.ReadAllText(path+"/Data/Fabric.1.0.2.json");
						
			FabSpec spec = JsonSerializer.DeserializeFromString<FabSpec>(json);
			ServiceMap = new Dictionary<string, FabSpecService>();
			ObjectMap = new Dictionary<string, FabSpecObject>();
			FuncMap = new Dictionary<string, FabSpecTravFunc>();
			//OperationMap = new Dictionary<string, FabSpecServiceOperation>();
			FuncList = new List<FabSpecTravFunc>();
			//OperationList = new List<FabSpecServiceOperation>();
			
			foreach ( FabSpecObject o in spec.Objects ) {
				ObjectMap.Add(o.Name, o);
			}
			
			foreach ( FabSpecService s in spec.Services ) {
				ServiceMap.Add(s.Name.ToLower(), s);
				//OperationList.AddRange(s.Operations);
				
				if ( s.TraversalFunctions != null ) {
					FuncList.AddRange(s.TraversalFunctions);
				}
				
				/*foreach ( FabSpecServiceOperation so in s.Operations ) {
					OperationMap.Add(s.Name.ToLower()+"."+so.Name.ToLower(), so);
				}*/
			}
			
			foreach ( FabSpecTravFunc f in FuncList ) {
				FuncMap.Add(f.Name.ToLower(), f);
			}
			
			FuncList.Sort((a,b) => string.Compare(a.Name, b.Name));
			//OperationList.Sort((a,b) => string.Compare(a.Name, b.Name));*/
			return spec;
		}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public static FabSpecService GetService(string pName) {
			FabSpecService s;
			ServiceMap.TryGetValue(pName.ToLower(), out s);
			return s;
		}
		
		/*--------------------------------------------------------------------------------------------* /
		public static FabSpecServiceOperationFull GetOperation(string pServiceDotOperation) {
			FabSpecServiceOperation so;
			OperationMap.TryGetValue(pServiceDotOperation.ToLower(), out so);
			
			string serviceName = pServiceDotOperation.Substring(0, pServiceDotOperation.IndexOf('.'));
			return new FabSpecServiceOperationFull(GetService(serviceName), so);
		}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------* /
		public static FabSpecObjectFull GetObject(string pName) {
			var full = new FabSpecObjectFull();
			
			FabSpecObject o = ObjectMap[pName];
			FabSpecObjectFull ext = null;
			
			if ( o.Extends != null ) {
				ext = GetObject(o.Extends);
			}
			
			full.Build(o, ext);
			return full;
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public static IList<FabSpecObject> GetObjects() {
			return ObjectMap.Values.ToArray();
		}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public static FabSpecTravFunc GetFunc(string pName) {
			FabSpecTravFunc f;
			FuncMap.TryGetValue(pName.ToLower(), out f);
			return f;
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public static List<FabSpecTravFunc> GetFuncs() {
			return FuncList;
		}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public static string RemoveMarkup(string pText) {
			string s = pText;
			s = Regex.Replace(s, @"\[\[([^\|]+)\|([^\]]+)\|([^\]]+)\]\]", "$1");
			s = Regex.Replace(s, @"\b_([^\s].+?)_\b", "$1");
			//s = Regex.Replace(s, @"\n- (.+?)(?=\n|$)", "\n&nbsp;&bull; $1");
			s = Regex.Replace(s, @"\[\(EX\|(.+?)\|(.+?)\)\]", "$1: $2", RegexOptions.Singleline);
			return s;
		}
		
	}
	
}