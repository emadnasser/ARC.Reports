Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraLayout
Imports DevExpress.XtraGrid.Columns
Imports System.Collections
Imports DevExpress.XtraEditors.Controls

Namespace DevExpress.XtraGrid.Demos
    Partial Public Class FindFilter
        Inherits TutorialControl

        Public Sub New()
            CreateWaitDialog()
            InitializeComponent()
            TutorialInfo.WhatsThisCodeFile = "VB\GridMainDemo\Modules\FindFilter.vb;VB\GridMainDemo\Modules\ucFindOptions.vb"
            TutorialInfo.WhatsThisXMLFile = "FindFilter.xml"
            InitNWindData()
            ucFindOptions1.InitData(gridView1, GetColumn(gridView1.VisibleColumns))
        End Sub

        Private Function GetColumn(ByVal gridColumnReadOnlyCollection As DevExpress.XtraGrid.Columns.GridColumnReadOnlyCollection) As List(Of ImageComboBoxItem)
            Dim ret As New List(Of ImageComboBoxItem)()
            ret.Add(New ImageComboBoxItem("*", "*"))
            For i As Integer = 0 To gridColumnReadOnlyCollection.Count - 1
                Dim columns As String = gridColumnReadOnlyCollection(i).GetCaption()
                Dim fields As String = gridColumnReadOnlyCollection(i).FieldName
                For j As Integer = i To gridColumnReadOnlyCollection.Count - 1
                    If j <> i Then
                        columns &= String.Format(";{0}", gridColumnReadOnlyCollection(j).GetCaption())
                        fields &= String.Format(";{0}", gridColumnReadOnlyCollection(j).FieldName)
                    End If
                    ret.Add(New ImageComboBoxItem(columns, fields, -1))
                Next j
            Next i
            Return ret
        End Function
        Protected Overrides Sub InitMDBData(ByVal connectionString As String)
            Dim dataSet As New DataSet()
            Dim oleDBAdapter As New System.Data.OleDb.OleDbDataAdapter("SELECT * FROM Customers", connectionString)

            SetWaitDialogCaption(My.Resources.LoadingCustomers)
            oleDBAdapter.Fill(dataSet, "Customers")
            gridControl1.DataSource = dataSet.Tables("Customers")
        End Sub

        Private Sub gridView1_FilterEditorCreated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FilterControlEventArgs) Handles gridView1.FilterEditorCreated
            e.FilterControl.MaxOperandsCount = 5
        End Sub
    End Class
End Namespace
