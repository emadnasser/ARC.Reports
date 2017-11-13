Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraEditors

Namespace DevExpress.DevAV
    Partial Public Class SortFilterControl
        Inherits UserControl

        Private callback As Action(Of Boolean)
        Private toDate As Action(Of Date), fromDate As Action(Of Date)
        Private defaultFromDate, defaultToDate As Date
        Private defaultValue As Boolean
        Public Sub New()
            InitializeComponent()
        End Sub
        Public Sub New(ByVal callback As Action(Of Boolean), ByVal defaultValue As Boolean, ByVal fromDate As Action(Of Date), ByVal defaultFromDate As Date, ByVal toDate As Action(Of Date), ByVal defaultToDate As Date)
            Me.New()
            Me.callback = callback
            Me.toDate = toDate
            Me.fromDate = fromDate
            Me.defaultValue = defaultValue
            Me.defaultFromDate = defaultFromDate
            Me.defaultToDate = defaultToDate
        End Sub
        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)

            If defaultValue Then
                btnOrderDate.Checked = True
            Else
                btnInvoice.Checked = True
            End If

            dateEdit1.DateTime = defaultFromDate
            dateEdit2.DateTime = defaultToDate
        End Sub
        Private Sub btnOrderDate_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles btnOrderDate.CheckedChanged
            If callback IsNot Nothing Then
                callback(True)
            End If
        End Sub
        Private Sub btnInvoice_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles btnInvoice.CheckedChanged
            If callback IsNot Nothing Then
                callback(False)
            End If
        End Sub
        Private Sub dateEdit1_DateTimeChanged(ByVal sender As Object, ByVal e As EventArgs) Handles dateEdit1.DateTimeChanged
            If fromDate IsNot Nothing Then
                fromDate((TryCast(sender, DateEdit)).DateTime)
            End If
        End Sub
        Private Sub dateEdit2_DateTimeChanged(ByVal sender As Object, ByVal e As EventArgs) Handles dateEdit2.DateTimeChanged
            If toDate IsNot Nothing Then
                toDate((TryCast(sender, DateEdit)).DateTime)
            End If
        End Sub
    End Class
End Namespace
