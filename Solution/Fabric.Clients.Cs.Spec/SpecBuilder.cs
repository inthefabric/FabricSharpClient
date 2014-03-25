using System.Collections.Generic;
using System.Text.RegularExpressions;
using Fabric.Clients.Cs.Spec.Data;
using Fabric.Clients.Cs.Spec.SpecDto;
using ServiceStack.Text;

namespace Fabric.Clients.Cs.Spec {
	
	/*================================================================================================*/
	public static class SpecBuilder {
		
		private static FabSpec SpecInstance;
		private static IDictionary<string, IList<SpecStepRuleRow>> StepMap;
		private static HashSet<string> BaseClassMap;
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public static FabSpec Spec {
			get {
				return (SpecInstance ?? Build());
			}
		}
		
		/*--------------------------------------------------------------------------------------------*/
		private static FabSpec Build() {
			SpecInstance = JsonSerializer.DeserializeFromString<FabSpec>(FabricResource.SpecJson);
			StepMap = new Dictionary<string, IList<SpecStepRuleRow>>();
			BaseClassMap = new HashSet<string>();

			foreach ( FabSpecService service in SpecInstance.Services ) {
				if ( service.Steps == null ) {
					continue;
				}

				foreach ( FabSpecServiceStep step in service.Steps ) {
					foreach ( FabSpecServiceStepRule rule in step.Rules ) {
						var row = new SpecStepRuleRow(service, step, rule);

						if ( !StepMap.ContainsKey(row.Rule.Entry) ) {
							StepMap.Add(row.Rule.Entry, new List<SpecStepRuleRow>());
						}

						StepMap[row.Rule.Entry].Add(row);
					}
				}
			}

			foreach ( FabSpecObject obj in SpecInstance.Objects ) {
				if ( obj.Extends != null ) {
					BaseClassMap.Add(obj.Extends);
				}
			}

			return SpecInstance;
		}

		/*--------------------------------------------------------------------------------------------*/
		public static IList<SpecStepRuleRow> GetStepRuleRows(string pType) {
			return (StepMap.ContainsKey(pType) ? StepMap[pType] : null);
		}

		/*--------------------------------------------------------------------------------------------*/
		public static bool IsBaseClass(string pType) {
			return BaseClassMap.Contains(pType);
		}
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public static string CapitalFirst(string pText) {
			return pText.Substring(0, 1)+pText.Substring(1).ToLower();
		}
		
		/*--------------------------------------------------------------------------------------------*/
		public static string RemoveMarkup(string pText) {
			if ( pText == null ) {
				return "";
			}

			string s = pText;
			s = Regex.Replace(s, @"\[\[([^\|]+)\|([^\]]+)\|([^\]]+)\]\]", "$1");
			s = Regex.Replace(s, @"\b_([^\s].+?)_\b", "$1");
			//s = Regex.Replace(s, @"\[\(EX\|(.+?)\|(.+?)\)\]", "$1: $2", RegexOptions.Singleline);
			s = Regex.Replace(s, @"\[\(EX\|(.+?)\|(.+?)\)\]", "", RegexOptions.Singleline);
			return s;
		}

		/*--------------------------------------------------------------------------------------------*/
		public static string ToXmlDoc(string pText, bool pMultiLine) {
			if ( pText == null ) {
				return "";
			}

			string s = RemoveMarkup(pText).Trim(new[] { ' ', '\t', '\n', '\r' });
			s = Regex.Replace(s, @"\n\s*\n", "\r\n\r\n");
			s = Regex.Replace(s, @"[^\r]\n", "\r\n");

			s = s
				//.Replace("\n", "{N}")
				//.Replace("\r", "{R}")
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