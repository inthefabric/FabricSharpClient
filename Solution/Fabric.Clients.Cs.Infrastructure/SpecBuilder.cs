using System.Text.RegularExpressions;
using Fabric.Clients.Cs.Infrastructure.Data;
using Fabric.Clients.Cs.Infrastructure.SpecDto;
using ServiceStack.Text;

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
			return JsonSerializer.DeserializeFromString<FabSpec>(FabricResource.FabricJson);
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