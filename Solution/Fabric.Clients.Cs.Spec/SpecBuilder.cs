using System.Text.RegularExpressions;
using Fabric.Clients.Cs.Spec.Data;
using Fabric.Clients.Cs.Spec.SpecDto;
using ServiceStack.Text;

namespace Fabric.Clients.Cs.Spec {
	
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
			return JsonSerializer.DeserializeFromString<FabSpec>(FabricResource.SpecJson);
		}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public static string RemoveMarkup(string pText) {
			if ( pText == null ) {
				return "";
			}

			string s = pText;
			s = Regex.Replace(s, @"\[\[([^\|]+)\|([^\]]+)\|([^\]]+)\]\]", "$1");
			s = Regex.Replace(s, @"\b_([^\s].+?)_\b", "$1");
			s = Regex.Replace(s, @"\[\(EX\|(.+?)\|(.+?)\)\]", "$1: $2", RegexOptions.Singleline);
			return s;
		}

		/*--------------------------------------------------------------------------------------------*/
		public static string ToXmlDoc(string pText, bool pMultiLine) {
			if ( pText == null ) {
				return "";
			}

			string s = RemoveMarkup(pText)
				.Replace("\r\n\r\n", (pMultiLine ? "\r\n" : " "))
				.Replace("\r\n", "</para>\r\n\t///   <para>");

			if ( pMultiLine ) {
				return "<para>"+s+"</para>";
			}

			return s;
		}

		/*--------------------------------------------------------------------------------------------*/
		public static string ToXmlDocSentence(string pText) {
			if ( string.IsNullOrWhiteSpace(pText) ) {
				return "";
			}

			bool found = false;
			int i = 0;

			while ( true ) {
				i = pText.IndexOf(".", i+1);

				if ( i == -1 ) {
					break;
				}

				found = true;

				if ( i+1 >= pText.Length || pText[i+1] == ' ') {
					break;
				}
			}

			string s = (found ? pText.Substring(0, i+1) : pText);
			return ToXmlDoc(s, false);
		}
		
	}
	
}