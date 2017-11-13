using System;
using System.Drawing;
using System.Web.UI;
using DevExpress.Web.ASPxTreeList;

public partial class Appearance_ConditionalFormatting : Page {

	protected void treeList_HtmlRowPrepared(object sender, TreeListHtmlRowEventArgs e) {
		if(Object.Equals(e.GetValue("Location"), "Monterey"))
			e.Row.BackColor = Color.FromArgb(211, 235, 183);
	}

	protected void treeList_HtmlDataCellPrepared(object sender, TreeListHtmlDataCellEventArgs e) {
		if(e.Column.Name == "budget") {
			decimal value = (decimal)e.CellValue;
			e.Cell.BackColor = GetBudgetColor(value);
			if(value > 1000000M)
				e.Cell.Font.Bold = true;
		}
	}

	Color GetBudgetColor(decimal value) {
		decimal coeff = value / 1000 - 22;
		int a = (int)(0.02165M * coeff);
		int b = (int)(0.09066M * coeff);
		return Color.FromArgb(255, 235 - a, 177 - b);
	}
}
