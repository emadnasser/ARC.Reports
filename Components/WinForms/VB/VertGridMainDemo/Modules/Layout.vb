Imports System.Collections
Imports System.ComponentModel



Namespace DevExpress.XtraVerticalGrid.Demos
	Partial Public Class Layout
		Inherits DevExpress.XtraVerticalGrid.Demos.PropertiesBase

		Public Sub New()
			' This call is required by the Windows Form Designer.
			InitializeComponent()
			TutorialInfo.WhatsThisCodeFile = "VB\VertGridMainDemo\Modules\Layout.vb;"
			TutorialInfo.WhatsThisXMLFile = "Layout.xml"
			' TODO: Add any initialization after the InitializeComponent call
		End Sub

		Private noteHeight As Integer = 120
		'<groupBox1>
        Private Sub radioButtonLayoutStyle_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles _
            radioButton3.CheckedChanged, radioButton2.CheckedChanged, radioButton1.CheckedChanged
            If radioButton1.Checked Then
                CurrentGrid.LayoutStyle = LayoutViewStyle.BandsView
                If IsLayoutGrid Then
                    checkBox1.Checked = False
                End If
            End If
            If radioButton2.Checked Then
                CurrentGrid.LayoutStyle = LayoutViewStyle.SingleRecordView
            End If
            If radioButton3.Checked Then
                CurrentGrid.LayoutStyle = LayoutViewStyle.MultiRecordView
            End If
        End Sub
        '</groupBox1>
        '<groupBox3>
        Private Sub radioButtonButtonMode_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles _
            radioButton10.CheckedChanged, radioButton9.CheckedChanged, radioButton8.CheckedChanged, radioButton7.CheckedChanged, radioButton6.CheckedChanged
            If radioButton6.Checked Then
                CurrentGrid.ShowButtonMode = ShowButtonModeEnum.ShowAlways
            End If
            If radioButton7.Checked Then
                CurrentGrid.ShowButtonMode = ShowButtonModeEnum.ShowForFocusedRow
            End If
            If radioButton8.Checked Then
                CurrentGrid.ShowButtonMode = ShowButtonModeEnum.ShowForFocusedCell
            End If
            If radioButton9.Checked Then
                CurrentGrid.ShowButtonMode = ShowButtonModeEnum.ShowForFocusedRecord
            End If
            If radioButton10.Checked Then
                CurrentGrid.ShowButtonMode = ShowButtonModeEnum.ShowOnlyInEditor
            End If
        End Sub
        '</groupBox3>
        '<checkBox1>
        Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
            Dim ch As DevExpress.XtraEditors.CheckEdit = TryCast(sender, DevExpress.XtraEditors.CheckEdit)
            If ch.Checked Then
                EditorRowDescription.Properties.RowEdit = repositoryItemMemoExEdit1
                EditorRowAutomaticTransmission.Properties.RowEdit = repositoryItemRadioGroup1
                EditorRowDescription.Height = -1
            Else
                EditorRowDescription.Properties.RowEdit = repositoryItemMemoEdit1
                EditorRowAutomaticTransmission.Properties.RowEdit = repositoryItemImageComboBox2
                EditorRowDescription.Height = noteHeight
            End If
        End Sub
        '</checkBox1>
        '<checkBox2>
        Private Sub checkBox2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox2.CheckedChanged
            Dim ch As DevExpress.XtraEditors.CheckEdit = TryCast(sender, DevExpress.XtraEditors.CheckEdit)
            CurrentGrid.TreeButtonStyle = If(ch.Checked, DevExpress.XtraVerticalGrid.TreeButtonStyle.TreeView, DevExpress.XtraVerticalGrid.TreeButtonStyle.ExplorerBar)
        End Sub
        '</checkBox2>
        Protected Overrides Sub AdjustmentGrid()
            MyBase.AdjustmentGrid()
            Select Case CurrentGrid.LayoutStyle
                Case LayoutViewStyle.BandsView
                    radioButton1.Checked = True
                Case LayoutViewStyle.SingleRecordView
                    radioButton2.Checked = True
                Case LayoutViewStyle.MultiRecordView
                    radioButton3.Checked = True
            End Select
            Select Case CurrentGrid.ShowButtonMode
                Case ShowButtonModeEnum.ShowAlways
                    radioButton6.Checked = True
                Case ShowButtonModeEnum.ShowForFocusedRow
                    radioButton7.Checked = True
                Case ShowButtonModeEnum.ShowForFocusedCell
                    radioButton8.Checked = True
                Case ShowButtonModeEnum.ShowForFocusedRecord
                    radioButton9.Checked = True
                Case ShowButtonModeEnum.ShowOnlyInEditor
                    radioButton10.Checked = True
            End Select
            checkBox1.Enabled = IsLayoutGrid
            checkBox2.Checked = CurrentGrid.TreeButtonStyle = DevExpress.XtraVerticalGrid.TreeButtonStyle.TreeView
        End Sub
    End Class
End Namespace

