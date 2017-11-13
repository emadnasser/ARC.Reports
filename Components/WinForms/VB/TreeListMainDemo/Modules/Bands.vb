Namespace DevExpress.XtraTreeList.Demos
    Public Class Bands
        Inherits TutorialControl
        Public Sub New()
            InitializeComponent()
            InitSpaceObjectsData()
            InitEditors()
        End Sub
        Private spaceObjectsTable As DataTable
        Private Sub InitSpaceObjectsData()
            Dim DBFileName As String = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\SpaceObjects.xml")
            If DBFileName <> "" Then
                Dim dataSet As New DataSet()
                dataSet.ReadXml(DBFileName)
                spaceObjectsTable = dataSet.Tables(0)
                spaceObjectsTable.PrimaryKey = New DataColumn() {spaceObjectsTable.Columns("ObjectId")}
                treeList.DataSource = spaceObjectsTable
                treeList.KeyFieldName = "ObjectId"
                treeList.ParentFieldName = "ParentId"
                treeList.ExpandAll()
            End If
        End Sub
        Private Sub InitEditors()
            ceShowBandPanel.Checked = treeList.OptionsView.ShowBandsMode = Utils.DefaultBoolean.True
            ceAllowBandMoving.Checked = treeList.OptionsCustomization.AllowBandMoving
            ceAllowBandResizing.Checked = treeList.OptionsCustomization.AllowBandResizing
            ceAllowChangeBandParent.Checked = treeList.OptionsCustomization.AllowChangeBandParent
            ceAllowChangeColumnParent.Checked = treeList.OptionsCustomization.AllowChangeColumnParent
            ceShowBandInCustomizationForm.Checked = treeList.OptionsCustomization.ShowBandsInCustomizationForm
        End Sub
        Private Sub ceShowBandPanel_CheckedChanged(sender As Object, e As EventArgs) Handles ceShowBandPanel.CheckedChanged
            If ceShowBandPanel.Checked Then
                treeList.OptionsView.ShowBandsMode = Utils.DefaultBoolean.True
            Else
                treeList.OptionsView.ShowBandsMode = Utils.DefaultBoolean.False
            End If

        End Sub

        Private Sub ceAllowChangeBandParent_CheckedChanged(sender As Object, e As EventArgs) Handles ceAllowChangeBandParent.CheckedChanged
            treeList.OptionsCustomization.AllowChangeBandParent = ceAllowChangeBandParent.Checked
        End Sub

        Private Sub ceAllowChangeColumnParent_CheckedChanged(sender As Object, e As EventArgs) Handles ceAllowChangeColumnParent.CheckedChanged
            treeList.OptionsCustomization.AllowChangeColumnParent = ceAllowChangeColumnParent.Checked
        End Sub

        Private Sub ceAllowBandMoving_CheckedChanged(sender As Object, e As EventArgs) Handles ceAllowBandMoving.CheckedChanged
            treeList.OptionsCustomization.AllowBandMoving = ceAllowBandMoving.Checked
        End Sub

        Private Sub ceAllowBandResizing_CheckedChanged(sender As Object, e As EventArgs) Handles ceAllowBandResizing.CheckedChanged
            treeList.OptionsCustomization.AllowBandResizing = ceAllowBandResizing.Checked
        End Sub

        Private Sub ceShowBandInCustomizationForm_CheckedChanged(sender As Object, e As EventArgs) Handles ceShowBandInCustomizationForm.CheckedChanged
            treeList.OptionsCustomization.ShowBandsInCustomizationForm = ceShowBandInCustomizationForm.Checked
        End Sub
    End Class
End Namespace

