Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.DataAccess.Excel
Imports DevExpress.XtraPrinting


Namespace XtraReportsDemos.PollingReport
    Public Class ResultingData
        Public Property QuestionID() As Integer
        Public Property Question() As String
        Public Property Answer() As String
        Public Property AnswerCount() As Integer

    End Class
    Friend Class ResultingDataAdapter
        Private dataSource As ExcelDataSource

        Public Sub New(ByVal dataSource As ExcelDataSource)
            Me.dataSource = dataSource
        End Sub
        Public Sub InitializeData(ByVal data As IList(Of ResultingData))
            data.Add(CreateResultingData(0, GetAnswer(0), 1))
            data.Add(CreateResultingData(1, GetAnswer(1), 2))
            data.Add(CreateResultingData(4, GetAnswer(4), 2))
            data.Add(CreateResultingData(5, GetAnswer(5), 1))
            data.Add(CreateResultingData(9, "NBC", 1))
            data.Add(CreateResultingData(9, "HBO", 2))
            data.Add(CreateResultingData(10, "2", 2))
            data.Add(CreateResultingData(10, "3", 1))
            data.Add(CreateResultingData(11, GetAnswer(11), 1))
            data.Add(CreateResultingData(12, GetAnswer(12), 2))
        End Sub
        Public Function GetData(ByVal EditingFields As IList(Of EditingField)) As IList(Of ResultingData)
            Dim data As New List(Of ResultingData)()

            For i As Integer = 0 To EditingFields.Count - 1
                Dim field As EditingField = EditingFields(i)
                Dim rowIndex As Integer = Convert.ToInt32(field.ID) - 1

                If TypeOf field.EditValue Is CheckState Then
                    If Equals(field.Brick.Value, "RadioText") Then
                        Continue For
                    End If
                    Dim state As CheckState = field.GetEditValue(Of CheckState)()
                    Dim item As ResultingData = CreateResultingData(rowIndex, GetAnswer(rowIndex),If(state = CheckState.Checked, 1, 0))
                    data.Add(item)
                ElseIf TypeOf field.EditValue Is String AndAlso (Not field.ReadOnly) AndAlso (Not String.IsNullOrWhiteSpace(field.GetEditValue(Of String)())) Then
                    Dim item As ResultingData = CreateResultingData(rowIndex, field.GetEditValue(Of String)(), 1)
                    data.Add(item)
                End If
            Next i
            Return data
        End Function
        Private Function GetAnswer(ByVal rowIndex As Integer) As String
            Return GetColumnValue(Of String)(rowIndex, "Answer")
        End Function
        Private Function CreateResultingData(ByVal rowIndex As Integer, ByVal answer As String, ByVal answerCount As Integer) As ResultingData
            Dim question As String = GetColumnValue(Of String)(rowIndex, "Question")
            Dim questionID As Integer = GetColumnValue(Of Integer)(rowIndex, "QuestionID")
            Return New ResultingData() With {.Question = GetColumnValue(Of String)(rowIndex, "Question"), .QuestionID = questionID, .Answer = answer, .AnswerCount = answerCount}
        End Function
        Private Function GetColumnValue(Of T)(ByVal rowIndex As Integer, ByVal columnName As String) As T
            Dim list As IList = DirectCast(dataSource, IListSource).GetList()
            Dim row As Object = list(rowIndex)

            Dim column As DevExpress.DataAccess.Native.Excel.ViewColumn = GetColumn(columnName)
            If column IsNot Nothing Then
                Return CType(column.GetValue(row), T)
            End If
            Return Nothing
        End Function
        Private Function GetColumn(ByVal name As String) As DevExpress.DataAccess.Native.Excel.ViewColumn
            Dim dv As DevExpress.DataAccess.Native.Excel.DataView = TryCast(DirectCast(dataSource, IListSource).GetList(), DevExpress.DataAccess.Native.Excel.DataView)
            For i As Integer = 0 To dataSource.Schema.Count - 1
                If dataSource.Schema(i).Name = name Then
                    Return dv.Columns(i)
                End If
            Next i
            Return Nothing
        End Function
    End Class
End Namespace
