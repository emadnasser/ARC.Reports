Imports System.ComponentModel
Imports System.Text
Imports DevExpress.XtraEditors

Namespace DevExpress.ProductsDemo.Win
	Public Class PivotTileControl
		Inherits TileControl

		<DefaultValue(-1)> _
		Public Property LargeItemWidth() As Integer
			Get
				Return CType(Me, ITileControlProperties).LargeItemWidth
			End Get
			Set(ByVal value As Integer)
				CType(Me, ITileControlProperties).LargeItemWidth = value
			End Set
		End Property
	End Class
End Namespace
