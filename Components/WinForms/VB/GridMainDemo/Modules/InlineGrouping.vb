Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraGrid.Demos
    Partial Public Class InlineGrouping
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
            InitVehiclesData()
            InitEditors()
        End Sub

        Private Sub InitEditors()
            icbGroupDrawMode.Properties.Items.AddEnum(GetType(Views.Grid.GroupDrawMode))
            ceAllowPartialGroups.Checked = gridView1.OptionsBehavior.AllowPartialGroups = Utils.DefaultBoolean.True
            icbGroupDrawMode.EditValue = gridView1.OptionsView.GroupDrawMode
            ceShowExpandCollapseButtons.Checked = gridView1.OptionsView.ShowGroupExpandCollapseButtons
            ceAutoExpandAllGroups.Checked = gridView1.OptionsBehavior.AutoExpandAllGroups
            ceGroupExpandedOnSorting.Checked = gridView1.OptionsBehavior.KeepGroupExpandedOnSorting
        End Sub
        Protected Overrides Sub InitMDBData(ByVal connectionString As String)
            VehiclesData.InitMDBData(connectionString, gridControl1, 50)
            VehiclesData.InitColumnViewEditors(gridView1)
            gridView1.Columns("DeliveryDate").GroupInterval = ColumnGroupInterval.Date
            gridView1.GroupSummary.Clear()
            gridView1.GroupSummary.Add(Data.SummaryItemType.Count, "Name", gridView1.Columns("Name"))
        End Sub

        Private Sub ceAllowPartialGroups_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceAllowPartialGroups.CheckedChanged
            Dim ce As CheckEdit = TryCast(sender, CheckEdit)
            gridView1.OptionsBehavior.AllowPartialGroups = If(ce.Checked, Utils.DefaultBoolean.True, Utils.DefaultBoolean.False)
        End Sub

        Private Sub icbGroupDrawMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles icbGroupDrawMode.SelectedIndexChanged
            gridView1.OptionsView.GroupDrawMode = CType(icbGroupDrawMode.EditValue, Views.Grid.GroupDrawMode)
        End Sub

        Private Sub ceShowExpandCollapsButtons_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceShowExpandCollapseButtons.CheckedChanged
            Dim ce As CheckEdit = TryCast(sender, CheckEdit)
            gridView1.OptionsView.ShowGroupExpandCollapseButtons = ce.Checked
        End Sub

        Private Sub ceAutoExpandAllGroups_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceAutoExpandAllGroups.CheckedChanged
            Dim ce As CheckEdit = TryCast(sender, CheckEdit)
            gridView1.OptionsBehavior.AutoExpandAllGroups = ce.Checked
            ceGroupExpandedOnSorting.Enabled = Not ce.Checked
        End Sub

        Private Sub ceGroupExpandedOnSorting_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceGroupExpandedOnSorting.CheckedChanged
            Dim ce As CheckEdit = TryCast(sender, CheckEdit)
            gridView1.OptionsBehavior.KeepGroupExpandedOnSorting = ce.Checked
        End Sub
    End Class
End Namespace
