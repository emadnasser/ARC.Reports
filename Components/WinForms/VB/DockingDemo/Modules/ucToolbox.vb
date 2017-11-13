Imports Microsoft.VisualBasic
Imports System.Windows.Forms
Imports DevExpress.XtraNavBar

Namespace DevExpress.XtraBars.Demos.DockingDemo
	Partial Public Class ucToolbox
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
			Dim standardGroup As NavBarGroup = navBar.Groups.Add()
            standardGroup.Caption = "Standard"
            standardGroup.Name = "Standard"
			Dim devexpressGroup As NavBarGroup = navBar.Groups.Add()
            devexpressGroup.Caption = "DevExpress"
            devexpressGroup.Name = "DevExpress"
			devexpressGroup.Expanded = True
			For Each key As String In toolboxImages.Images.Keys
                Dim item As NavBarItem = New NavBarItem()
                Dim caption As String = GetCaption(key)
                item.Caption = caption
                item.Name = caption
				item.SmallImageIndex = toolboxImages.Images.IndexOfKey(key)
				navBar.Items.Add(item)
				If (Not key.Contains("DX")) Then
					standardGroup.ItemLinks.Add(item)
				Else
					devexpressGroup.ItemLinks.Add(item)
				End If
			Next key
		End Sub
		Private Function GetCaption(ByVal key As String) As String
			Return key.Substring(0, key.IndexOf("_"c))
		End Function
	End Class
End Namespace
