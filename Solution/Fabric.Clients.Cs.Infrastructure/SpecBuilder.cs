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
			return JsonSerializer.DeserializeFromString<FabSpec>(json);
		}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public static string RemoveMarkup(string pText) {
			string s = pText;
			s = Regex.Replace(s, @"\[\[([^\|]+)\|([^\]]+)\|([^\]]+)\]\]", "$1");
			s = Regex.Replace(s, @"\b_([^\s].+?)_\b", "$1");
			s = Regex.Replace(s, @"\[\(EX\|(.+?)\|(.+?)\)\]", "$1: $2", RegexOptions.Singleline);
			return s;
		}
		
	}
	
}