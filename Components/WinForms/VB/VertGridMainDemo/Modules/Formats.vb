Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.Utils

Namespace DevExpress.XtraVerticalGrid.Demos
	Partial Public Class Formats
		Inherits DevExpress.XtraVerticalGrid.Demos.PropertiesBase

		Public Sub New()
			' This call is required by the Windows Form Designer.
			InitializeComponent()
			TutorialInfo.WhatsThisCodeFile = "VB\VertGridMainDemo\Modules\Formats.vb;VB\VertGridMainDemo\Modules\Properties.vb"
			TutorialInfo.WhatsThisXMLFile = "Formats.xml"
			tcProperties.BringToFront()
			' TODO: Add any initialization after the InitializeComponent call
		End Sub

		Private styleNames() As String = { "Pastel#1", "Spring", "Vagabond", "Blue Office" }
		'<lsStyles>
		Private xapp As DevExpress.XtraVerticalGrid.Design.XAppearances
		'</lsStyles>
		Private fLockStylesUpdate As Boolean = False

		Private Sub ceNewStyles_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceNewStyles.CheckedChanged
			If xapp IsNot Nothing Then
				xapp.ShowNewStylesOnly = ceNewStyles.Checked
			End If
			lsStyles.Items.Clear()
			lsStyles.Items.AddRange(xapp.FormatNames)
			SetSelectedStyleItem()
		End Sub

		Private Sub SetSelectedStyleItem()
			lsStyles.SelectedItem = styleNames(SelectedPageIndex)
		End Sub
		'<lsStyles>
		Private Sub ChangeStyle()
			If fLockStylesUpdate Then
				Return
			End If
			If lsStyles.SelectedItem IsNot Nothing Then
				xapp.LoadScheme(lsStyles.SelectedItem.ToString(), CurrentGrid)
				styleNames(SelectedPageIndex) = lsStyles.SelectedItem.ToString()
			End If
		End Sub

		Private Sub lsStyles_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lsStyles.SelectedIndexChanged
			ChangeStyle()
		End Sub
		'</lsStyles>
		'<tabPage10>
		Private Sub lbcAppearances_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbcAppearances.SelectedIndexChanged
			propertyGrid1.SelectedObjects = SelectedObjects
		End Sub

		Private ReadOnly Property SelectedObject() As Object
			Get
				If lbcAppearances.SelectedItem Is Nothing Then
					Return Nothing
				End If
				Return GetAppearanceObjectByName(CurrentGrid, lbcAppearances.GetItem(lbcAppearances.SelectedIndex).ToString())
			End Get
		End Property
		Private ReadOnly Property SelectedObjects() As Object()
			Get
				If lbcAppearances.SelectedItem Is Nothing Then
					Return Nothing
				End If
				Dim ret As New ArrayList()
				For i As Integer = 0 To lbcAppearances.SelectedIndices.Count - 1
					Dim obj As Object = GetAppearanceObjectByName(CurrentGrid, lbcAppearances.GetItem(lbcAppearances.SelectedIndices(i)).ToString())
					ret.Add(obj)
				Next i
				Return ret.ToArray()
			End Get
		End Property
		'</tabPage10>
		Protected Overrides Sub AdjustmentGrid()
			MyBase.AdjustmentGrid()
			fLockStylesUpdate = True
			SetSelectedStyleItem()
			fLockStylesUpdate = False
		End Sub

		Protected Overrides Sub InitStyles()
			MyBase.InitStyles()
			xapp = New DevExpress.XtraVerticalGrid.Design.XAppearances(System.Environment.GetFolderPath(System.Environment.SpecialFolder.System) & "\DevExpress.XtraVerticalGrid.Appearances.xml")
			lsStyles.Items.AddRange(xapp.FormatNames)
			For i As Integer = 0 To 3
				xapp.LoadScheme(styleNames(i), GridByIndex(i))
			Next i
			InitAppearanceList(CurrentGrid)
		End Sub

		Protected Overrides Sub InitAppearanceList(ByVal vg As VGridControl)
			MyBase.InitAppearanceList(vg)
			lbcAppearances.Items.Clear()
			Dim collection As PropertyDescriptorCollection = TypeDescriptor.GetProperties(vg.Appearance)
			For i As Integer = 0 To collection.Count - 1
				If collection(i).PropertyType Is GetType(AppearanceObject) Then
					lbcAppearances.Items.Add(collection(i).Name)
				End If
			Next i
			lbcAppearances.SelectedIndex = 0
		End Sub
	End Class
End Namespace
