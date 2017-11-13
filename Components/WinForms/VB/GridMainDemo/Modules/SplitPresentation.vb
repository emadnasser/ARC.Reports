Imports System.ComponentModel
Imports System.Text
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Utils
Imports DevExpress.Data
Imports DevExpress.XtraGrid.Menu
Imports DevExpress.XtraEditors.Controls

Namespace DevExpress.XtraGrid.Demos
	Partial Public Class SplitPresentation
		Inherits TutorialControl

		Private interestBrush As Brush = Brushes.Green, principalBrush As Brush = Brushes.LightGreen, interestForeBrush As Brush = Brushes.White, principalForeBrush As Brush = Brushes.Black
		Private paymentPen As Pen = Pens.Green
		Private customSum As PaymentTypeSum
		Private interestString As String = My.Resources.Interest, principalString As String = My.Resources.Principal
		Private cellFont As New Font(AppearanceObject.DefaultFont, FontStyle.Regular)
		Private monthlyPayment As Double = 0
		Public Sub New()
			InitializeComponent()

            TutorialInfo.WhatsThisCodeFile = "VB\GridMainDemo\Modules\SplitPresentation.vb"
            TutorialInfo.WhatsThisXMLFile = "SplitPresentation.xml"
			LoanPayment.InitInterestRateData(editInterestRate)
			LoanPayment.InitTermOfLoan(editTermOfLoan)
			LoanPayment.InitStartMonth(editStart)
			editLoanAmount.Value = 250000
		End Sub
		Private ReadOnly Property StartMonth() As Date
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
		'<sbCalc>
		Private Sub Calc()
			Dim data As List(Of LoanPayment) = LoanPayment.Calculate(LoanAmount, InterestRate, Months, StartMonth, monthlyPayment)
			gridControl1.DataSource = data
			lcInfo.Text = String.Format("<size=+4>{1}<br><size=+4>{0:c}", monthlyPayment, My.Resources.YourMonthlyPayment)
			CType(gridSplitContainer1.SplitChildGrid.MainView, GridView).TopRowIndex = data.Count
		End Sub
		'</sbCalc>
		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)
			gridControl1.ForceInitialize()
			gridControl2.ForceInitialize()
			gridSplitContainer1.ShowSplitView()
			gridSplitContainer2.ShowSplitView()
			Calc()
			InitHomesData()
		End Sub
		Private Sub InitHomesData()
			gridControl2.DataSource = Home.Homes
			AddHandler gridSplitContainer2.SplitChildGrid.HandleCreated, AddressOf SplitChildGrid_HandleCreated
		End Sub
		Private Sub SplitChildGrid_HandleCreated(ByVal sender As Object, ByVal e As EventArgs)
			gridSplitContainer2.HideSplitView()
			gridSplitContainer2.ShowSplitView()
			CType(gridSplitContainer2.SplitChildGrid.MainView, GridView).LeftCoord = 415
		End Sub
		'<sbCalc>
		Private Sub sbCalc_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sbCalc.Click
			Calc()
		End Sub
		'</sbCalc>
		#Region "Horizontal split grid events"
		Private Function GetCellFormat(ByVal value As Double) As String
			If value < 1 Then
				Return "{0:c2}"
			End If
			Return "{0:c0}"
		End Function
		Private Sub gridView1_CustomDrawCell(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles gridView1.CustomDrawCell
			Dim view As GridView = TryCast(sender, GridView)
			Dim payment As LoanPayment = TryCast(view.GetRow(e.RowHandle), LoanPayment)
			If payment Is Nothing Then
				Return
			End If
			If e.Column.FieldName = gcMonth.FieldName Then
				e.DisplayText = payment.MonthString
			End If
			If e.Column.FieldName = gcPayment.FieldName Then
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

        Private Sub gridView1_CustomDrawColumnHeader(ByVal sender As Object, ByVal e As ColumnHeaderCustomDrawEventArgs) Handles gridView1.CustomDrawColumnHeader
            If e.Column Is Nothing Then Return
            If e.Column.FieldName = gcPayment.FieldName Then
                Dim indent As Integer = 5
                e.Info.Caption = String.Empty
                e.Painter.DrawObject(e.Info)
                Dim rectHeight As Integer = e.Info.Bounds.Height - indent * 2
                Dim rectWidth As Integer = CInt(Fix(rectHeight * 1.3))
                Dim interestRect As New Rectangle(e.Bounds.X + e.Appearance.CalcTextSizeInt(e.Cache, interestString, e.Info.Bounds.Width).Width + indent * 2, e.Info.Bounds.Y + (e.Info.Bounds.Height - rectHeight) \ 2 - 1, rectWidth, rectHeight)
                Dim principalRect As New Rectangle(e.Bounds.X + e.Bounds.Width - indent * 2 - e.Appearance.CalcTextSizeInt(e.Cache, principalString, e.Info.Bounds.Width).Width - rectWidth, e.Info.Bounds.Y + (e.Info.Bounds.Height - rectHeight) \ 2 - 1, rectWidth, rectHeight)
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
		Private Sub gridView1_CustomDrawFooterCell(ByVal sender As Object, ByVal e As FooterCellCustomDrawEventArgs) Handles gridView1.CustomDrawFooterCell
			If e.Column.FieldName = gcPayment.FieldName Then
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
		Private Sub gridView1_CustomSummaryCalculate(ByVal sender As Object, ByVal e As DevExpress.Data.CustomSummaryEventArgs) Handles gridView1.CustomSummaryCalculate
			If Not Object.ReferenceEquals(sender, gridView1) Then
				Return
			End If
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
		Private Sub gridView1_PopupMenuShowing(ByVal sender As Object, ByVal e As PopupMenuShowingEventArgs) Handles gridView1.PopupMenuShowing
			Dim menu As GridViewFooterMenu = TryCast(e.Menu, GridViewFooterMenu)
			If menu IsNot Nothing AndAlso menu.Column IsNot Nothing Then
				If menu.Column.SummaryItem.SummaryType = SummaryItemType.Custom Then
					e.Menu.Items.Clear()
				End If
			End If
		End Sub
		#End Region
		'<sbSplit>
		Private Sub sbSplit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sbSplit.Click
			gridSplitContainer2.ShowSplitView()
		End Sub
		'</sbSplit>
		'<sbRemoveSplit>
		Private Sub sbRemoveSplit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sbRemoveSplit.Click
			gridSplitContainer2.HideSplitView()
		End Sub
		'</sbRemoveSplit>
		Private Sub UpdateButtons()
			sbSplit.Enabled = Not gridSplitContainer2.IsSplitViewVisible
			sbRemoveSplit.Enabled = gridSplitContainer2.IsSplitViewVisible
		End Sub

		Private Sub gridSplitContainer2_SplitViewShown(ByVal sender As Object, ByVal e As EventArgs) Handles gridSplitContainer2.SplitViewShown
			UpdateButtons()
		End Sub

		Private Sub gridSplitContainer2_SplitViewHidden(ByVal sender As Object, ByVal e As EventArgs) Handles gridSplitContainer2.SplitViewHidden
			UpdateButtons()
		End Sub

		Private Sub gridView1_ShowFilterPopupCheckedListBox(ByVal sender As Object, ByVal e As FilterPopupCheckedListBoxEventArgs) Handles gridView1.ShowFilterPopupCheckedListBox
			If e.Column.FieldName = gcMonth.FieldName Then
				For Each item As CheckedListBoxItem In e.CheckedComboBox.Items
					item.Description = LoanPayment.GetMonthString(Convert.ToInt32(CType(item.Value, DevExpress.XtraGrid.Views.Grid.FilterItem).Value), TryCast(gridControl1.DataSource, List(Of LoanPayment)))
				Next item
			End If
		End Sub
	End Class
End Namespace
