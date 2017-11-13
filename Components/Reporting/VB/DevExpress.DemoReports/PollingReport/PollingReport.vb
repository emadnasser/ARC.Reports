Imports System
Imports System.Linq
Imports System.ComponentModel
Imports System.Collections
Imports System.Diagnostics
Imports DevExpress.XtraReports.UI
Imports System.IO
Imports DevExpress.XtraPrinting
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.DataAccess.Excel

Namespace XtraReportsDemos.PollingReport
    Partial Public Class PollingReport
        Inherits DevExpress.XtraReports.UI.XtraReport

        Public Sub New()
            InitializeComponent()

            Name = ReportNames.PollingReport
            DisplayName = ReportNames.PollingReport
        End Sub
        Public Sub UpdateData(ByVal data As IList(Of ResultingData))
            Dim adapter As New ResultingDataAdapter(TryCast(Me.DataSource, ExcelDataSource))
            If data.Count = 0 Then
                adapter.InitializeData(data)
            End If
            Dim newData As IList(Of ResultingData) = adapter.GetData(PrintingSystem.EditingFields)
            For Each item As ResultingData In newData
                Dim item2 As ResultingData = data.FirstOrDefault(Function(item3) item3.Question = item.Question AndAlso item3.Answer = item.Answer)
                If item2 IsNot Nothing Then
                    item2.AnswerCount += item.AnswerCount
                Else
                    data.Add(item)
                End If
            Next item
        End Sub
        Private Sub detailBand1_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles detailBand1.BeforePrint
            Dim id As String = Report.GetCurrentColumnValue("AnswerID").ToString()
            xrLabel3.EditOptions.ID = id
            xrLabel2.EditOptions.ID = xrLabel3.EditOptions.ID
            xrCheckBox1.EditOptions.ID = xrLabel2.EditOptions.ID

            If Report.GetCurrentColumnValue("AnswerType").ToString().Contains("Radio") Then
                Dim id2 As String = Report.GetCurrentColumnValue("QuestionID").ToString()
                xrCheckBox1.EditOptions.GroupID = id2
            End If
            If Report.GetCurrentColumnValue("AnswerType").ToString() = "Number" Then
                xrLabel3.EditOptions.EditorName = EditingFieldEditorNames.IntegerPositive
            End If
        End Sub
        Private Sub detailBand1_AfterPrint(ByVal sender As Object, ByVal e As EventArgs) Handles detailBand1.AfterPrint
            xrLabel3.EditOptions.ID = String.Empty
            xrLabel2.EditOptions.ID = xrLabel3.EditOptions.ID
            xrCheckBox1.EditOptions.ID = xrLabel2.EditOptions.ID
            xrCheckBox1.EditOptions.GroupID = String.Empty
            xrLabel3.EditOptions.EditorName = String.Empty
        End Sub
        Private Sub PollingReport_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles MyBase.BeforePrint
            RemoveHandler PrintingSystem.EditingFieldChanged, AddressOf PrintingSystem_EditingFieldChanged
            AddHandler PrintingSystem.EditingFieldChanged, AddressOf PrintingSystem_EditingFieldChanged
        End Sub

        Private Sub PrintingSystem_EditingFieldChanged(ByVal sender As Object, ByVal e As DevExpress.XtraPrinting.EditingFieldEventArgs)
            If Equals("RadioText", e.EditingField.Brick.Value) Then
                Dim EditingFields As IEnumerable(Of EditingField) = PrintingSystem.EditingFields.Where(Function(item) item.ID = e.EditingField.ID)
                For Each item As EditingField In EditingFields
                    If Not ReferenceEquals(item, e.EditingField) Then
                        item.ReadOnly = e.EditingField.EditValue.Equals(CheckState.Unchecked)
                        CType(item.Brick, TextBrick).ForeColor = If(item.ReadOnly, System.Drawing.Color.LightGray, System.Drawing.Color.Black)
                    End If
                Next item
            End If
        End Sub
    End Class
End Namespace
