Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.Utils
Imports DevExpress.Data
Imports DevExpress.XtraGrid.Menu
Imports DevExpress.XtraCharts
Imports DevExpress.XtraEditors.Controls

Namespace DevExpress.RealtorWorld.Win
	Partial Public Class ucLoanCalculator
		Inherits BaseModule
		Private ReadOnly Property InterestSeries() As Series
			Get
				Return chartControl1.Series(interestString)
			End Get
		End Property
		Private ReadOnly Property PrincipalSeries() As Series
			Get
				Return chartControl1.Series(principalString)
			End Get
		End Property

		Public Overrides ReadOnly Property ModuleCaption() As String
			Get
				Return "Loan Calculator"
			End Get
		End Property
		Private interestBrush As Brush, principalBrush As Brush, interestForeBrush As Brush = Brushes.White, principalForeBrush As Brush = Brushes.Black
		Private paymentPen As Pen
		Private interestString As String = "Interest", principalString As String = "Principal"
		Private cellFont As New Font(AppearanceObject.DefaultFont, FontStyle.Regular)
		Private monthlyPayment As Double = 0
		Public Sub New()
			InitializeComponent()
			LoanPayment.InitInterestRateData(editInterestRate)
			LoanPayment.InitTermOfLoan(editTermOfLoan)
			LoanPayment.InitStartMonth(editStart)
			editLoanAmount.Value = 250000
			lciInfo.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, lciCalc.Height)
		End Sub
		Friend Overrides Sub HideModule()
			MyBase.HideModule()
			gridView1.HideCustomization()
		End Sub
		Private ReadOnly Property StartMonth() As DateTime
			Get
				Return CDate(editStart.EditValue)
			End Get
		End Property
		Private ReadOnly Property LoanAmount() As Double
			Get
				Return Convert.ToDouble(editLoanAmount.EditValue)
			End Get
		End Property
		Private ReadOnly Property InterestRate() As Double
			Get
				Return Convert.ToDouble(editInterestRate.EditValue) / 1200
			End Get
		End Property
		Private ReadOnly Property Months() As Double
			Get
				Return CInt(Fix(editTermOfLoan.EditValue)) * 12
			End Get
		End Property
		Private Sub Calc()
			Dim data As List(Of LoanPayment) = LoanPayment.Calculate(LoanAmount, InterestRate, Months, StartMonth, monthlyPayment)
			gridControl1.DataSource = data
			lcInfo.Text = String.Format("<size=+3>Your Monthly Payment<br><size=+4>{0:c}", monthlyPayment)
			BeginInvoke(New MethodInvoker(Function() AnonymousMethod1()))
			InterestSeries.DataSource = data
			InterestSeries.SummaryFunction = "SUM([Interest])"
			PrincipalSeries.DataSource = data
			PrincipalSeries.SummaryFunction = "SUM([Principal])"
		End Sub
		
		Private Function AnonymousMethod1() As Boolean
			gcBalance.BestFit()
			Return True
		End Function
		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)
			gridControl1.ForceInitialize()
			Calc()
		End Sub
		Private Sub sbCalc_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sbCalc.Click
			Calc()
		End Sub

		Private Sub gridView1_CustomDrawCell(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles gridView1.CustomDrawCell
			Dim payment As LoanPayment = TryCast(gridView1.GetRow(e.RowHandle), LoanPayment)
			If payment Is Nothing Then
				Return
			End If
			If e.Column Is gcMonth Then
				e.DisplayText = payment.MonthString
			End If
			If e.Column Is gcPayment Then
				Dim r As Rectangle = e.Bounds
				r.Inflate(-3, -3)
				Dim interestWidth As Integer = CInt(Fix(r.Width * payment.Interest / payment.MonthlyPayment))
				Dim principalWidth As Integer = CInt(Fix(r.Width * payment.Principal / payment.MonthlyPayment))
				Dim interestRect As New Rectangle(r.X, r.Y, interestWidth, r.Height)
				Dim principalRect As New Rectangle(r.X + interestWidth, r.Y, principalWidth, r.Height)
				e.Graphics.FillRectangle(interestBrush, interestRect)
				e.Graphics.FillRectangle(principalBrush, principalRect)
				Using sf As New StringFormat()
					sf.Alignment = StringAlignment.Near
					sf.LineAlignment = StringAlignment.Center
					If e.Graphics.MeasureString(String.Format(GetCellFormat(payment.Interest), payment.Interest), cellFont).Width < interestRect.Width Then
						e.Graphics.DrawString(String.Format(GetCellFormat(payment.Interest), payment.Interest), cellFont, interestForeBrush, interestRect, sf)
					Else
						e.Graphics.DrawString(String.Format(GetCellFormat(payment.Interest), payment.Interest), cellFont, principalForeBrush, principalRect, sf)
					End If
					sf.Alignment = StringAlignment.Far
					If e.Graphics.MeasureString(String.Format(GetCellFormat(payment.Principal), payment.Principal), cellFont).Width < principalRect.Width Then
						e.Graphics.DrawString(String.Format(GetCellFormat(payment.Principal), payment.Principal), cellFont, principalForeBrush, principalRect, sf)
					Else
						e.Graphics.DrawString(String.Format(GetCellFormat(payment.Principal), payment.Principal), cellFont, interestForeBrush, interestRect, sf)
					End If
				End Using
				e.Graphics.DrawRectangle(paymentPen, New Rectangle(interestRect.X, interestRect.Y - 1, (interestRect.Width + principalRect.Width), interestRect.Height + 1))
				e.Handled = True
			End If
		End Sub
		Private Function GetCellFormat(ByVal value As Double) As String
			If value < 1 Then
				Return "{0:c2}"
			End If
			Return "{0:c0}"
		End Function
		Private Sub gridView1_CustomDrawColumnHeader(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.ColumnHeaderCustomDrawEventArgs) Handles gridView1.CustomDrawColumnHeader
			If e.Column Is gcPayment Then
				Dim indent As Integer = 5
				e.Info.Caption = String.Empty
				e.Painter.DrawObject(e.Info)
				Dim rectHeight As Integer = e.Info.Bounds.Height - indent * 2
				Dim rectWidth As Integer = CInt(Fix(rectHeight * 1.3))
				Dim interestRect As New Rectangle(e.Bounds.X + e.Appearance.CalcTextSizeInt(e.Cache, interestString, e.Info.Bounds.Width).Width + indent * 2, e.Info.Bounds.Y + Convert.ToInt32((e.Info.Bounds.Height - rectHeight) / 2) - 1, rectWidth, rectHeight)
				Dim principalRect As New Rectangle(e.Bounds.X + e.Bounds.Width - indent * 2 - e.Appearance.CalcTextSizeInt(e.Cache, principalString, e.Info.Bounds.Width).Width - rectWidth, e.Info.Bounds.Y + Convert.ToInt32((e.Info.Bounds.Height - rectHeight) / 2) - 1, rectWidth, rectHeight)
				Dim r As Rectangle = e.Info.Bounds
				r.Inflate(-indent, 0)
				r.Height -= 1
				Using sf As New StringFormat()
					sf.Alignment = StringAlignment.Near
					sf.LineAlignment = StringAlignment.Center
					e.Appearance.DrawString(e.Cache, interestString, r, sf)
					sf.Alignment = StringAlignment.Far
					e.Appearance.DrawString(e.Cache, principalString, r, sf)
				End Using
				e.Graphics.FillRectangle(interestBrush, interestRect)
				e.Graphics.FillRectangle(principalBrush, principalRect)
				e.Graphics.DrawRectangle(paymentPen, interestRect)
				e.Graphics.DrawRectangle(paymentPen, principalRect)
				e.Handled = True
			End If
		End Sub
		Private Sub gridView1_CustomDrawFooterCell(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.FooterCellCustomDrawEventArgs) Handles gridView1.CustomDrawFooterCell
			If e.Column Is gcPayment Then
				Dim indent As Integer = 5
				e.Info.DisplayText = String.Empty
				e.Painter.DrawObject(e.Info)
				Dim r As Rectangle = e.Info.Bounds
				r.Inflate(-indent, 0)
				Using sf As New StringFormat()
					sf.Alignment = StringAlignment.Near
					sf.LineAlignment = StringAlignment.Center
					e.Appearance.DrawString(e.Cache, String.Format("{0:c2}", customSum.InterestSum), r, sf)
					sf.Alignment = StringAlignment.Far
					e.Appearance.DrawString(e.Cache, String.Format("{0:c2}", customSum.PrincipalSum), r, sf)
				End Using
				e.Handled = True
			End If
		End Sub
		Private customSum As PaymentTypeSum
		Private Sub gridView1_CustomSummaryCalculate(ByVal sender As Object, ByVal e As DevExpress.Data.CustomSummaryEventArgs) Handles gridView1.CustomSummaryCalculate
			If e.SummaryProcess = CustomSummaryProcess.Start Then
				customSum = New PaymentTypeSum()
			End If
			If e.SummaryProcess = CustomSummaryProcess.Calculate Then
				Dim payment As LoanPayment = TryCast(gridView1.GetRow(e.RowHandle), LoanPayment)
				If payment IsNot Nothing AndAlso e.IsTotalSummary Then
					customSum.AddToSum(payment.Interest, payment.Principal)
				End If
			End If
			If e.SummaryProcess = CustomSummaryProcess.Finalize Then
				If e.IsTotalSummary Then
					e.TotalValue = customSum
				End If
			End If
		End Sub
		Private Sub gridView1_PopupMenuShowing(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs) Handles gridView1.PopupMenuShowing
			Dim menu As GridViewFooterMenu = TryCast(e.Menu, GridViewFooterMenu)
			If menu IsNot Nothing AndAlso menu.Column IsNot Nothing Then
				If menu.Column.SummaryItem.SummaryType = SummaryItemType.Custom Then
					e.Menu.Items.Clear()
				End If
			End If
		End Sub
		Private Sub chartControl1_CustomDrawSeries(ByVal sender As Object, ByVal e As CustomDrawSeriesEventArgs) Handles chartControl1.CustomDrawSeries
			If e.Series Is InterestSeries Then
				If interestBrush Is Nothing Then
					interestBrush = New SolidBrush(e.SeriesDrawOptions.ActualColor2)
				End If
				If paymentPen Is Nothing Then
					paymentPen = New Pen(interestBrush)
				End If
			ElseIf e.Series Is PrincipalSeries Then
				If principalBrush Is Nothing Then
					principalBrush = New SolidBrush(e.SeriesDrawOptions.Color)
				End If
			End If
		End Sub

		Private Sub gridView1_ShowFilterPopupCheckedListBox(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.FilterPopupCheckedListBoxEventArgs) Handles gridView1.ShowFilterPopupCheckedListBox
			If e.Column.FieldName = gcMonth.FieldName Then
				For Each item As CheckedListBoxItem In e.CheckedComboBox.Items
					item.Description = LoanPayment.GetMonthString(Convert.ToInt32((CType(item.Value, DevExpress.XtraGrid.Views.Grid.FilterItem)).Value), TryCast(gridControl1.DataSource, List(Of LoanPayment)))
				Next item
			End If
		End Sub
	End Class
End Namespace
