﻿using System;
using System.Collections.Generic;
using System.Reflection;

namespace Fabric.Clients.Cs.Mvc.Models {
	
	/*================================================================================================*/
	public class FabricDataGrid {
		
		private readonly IEnumerable<Object> vData;
		private readonly string vHtml;


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public FabricDataGrid(IEnumerable<Object> pData) {
			vData = pData;
			vHtml = "";
			if ( vData != null ) { vHtml += BuildTableHtml(vData); }
		}

		/*--------------------------------------------------------------------------------------------*/
		public FabricDataGrid(Object pData) {
			IList<Object> list = new List<Object>();
			list.Add(pData);
			vData = list;
			vHtml = "";
			if ( vData != null ) { vHtml += BuildTableHtml(vData); }
		}
		
		/*--------------------------------------------------------------------------------------------*/
		protected string BuildTableHtml(IEnumerable<Object> pTableData, int pDepth=0) {
			string html = "";

			IEnumerator<Object> enu = pTableData.GetEnumerator();
			if ( !enu.MoveNext() ) { return html; }

			Object obj = enu.Current;
			Type innerType = obj.GetType();

			PropertyInfo[] props = innerType.GetProperties();
			PropertyInfo prop;
			Object val;

			html += "<table class='FabricDataGridTable"+
				(pDepth > 0 ? " FabricDataGridTableInner" : "")+"'><tr>";
			
			if ( pDepth == 0 ) { html += "<td class='FabricDataGridHeader'>DataType</td>"; }
			
			foreach ( PropertyInfo t in props ) {
				prop = t;
				html += "<td class='FabricDataGridHeader'>"+prop.Name+(hasSubObj(prop) ?
					"<br/><span class='FabricDataGridHeaderType'>"+prop.PropertyType.Name+"</span>" :
					"")+"</td>";
			}

			html += "</tr>";
			int index = 0;

			while ( enu.Current != null ) {
				obj = enu.Current;
				string cellClass = "FabricDataGridCell";
				if ( index % 2 == 1 ) { cellClass += " "+cellClass+"Alt"; }

				if ( pDepth == 0 ) {
					html += "<tr><td class='"+cellClass+" FabricDataGridCellType'>"+innerType.Name+"</td>";
				}

				foreach ( PropertyInfo t in props ) {
					prop = t;
					val = prop.GetValue(obj, null);

					if ( val != null && hasSubObj(prop) ) {
						IList<Object> subList = new List<Object>();
						subList.Add(val);
						html += "<td class='"+cellClass+"'>"+BuildTableHtml(subList, pDepth+1)+"</td>";
						continue;
					}

					html += "<td class='"+cellClass+"'>"+val+"</td>";
				}
				
				html += "</tr>";
				enu.MoveNext();
				++index;
			}

			html += "</table>";
			return html;
		}

		/*--------------------------------------------------------------------------------------------*/
		private bool hasSubObj(PropertyInfo pProp) {
			if ( pProp.PropertyType.FullName == null ) {
				return false;
			}

			return (pProp.PropertyType.FullName.IndexOf(".Fab") > 0);
		}

		/*--------------------------------------------------------------------------------------------*/
		public string GetHtml() {
			return vHtml;
		}

	}

}