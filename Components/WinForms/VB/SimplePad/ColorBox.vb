Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Reflection
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Popup
Imports DevExpress.XtraTab
Imports DevExpress.XtraBars
Imports DevExpress.LookAndFeel

Namespace DevExpress.XtraBars.Demos.SimplePad
	Public Class ColorPopup
		Private tabControl As XtraTabControl
		Private fResultColor As Color
		Private itemFontColor As BarItem
		Private container As PopupControlContainer
		Private rtPad As RichTextBox
		Public Sub New(ByVal container As PopupControlContainer, ByVal item As BarItem, ByVal rtPad As RichTextBox)
			Me.rtPad = rtPad
			Me.container = container
			Me.itemFontColor = item
			Me.fResultColor = Color.Empty
			Me.tabControl = CreateTabControl()
			Me.tabControl.TabStop = False
			Me.tabControl.TabPages.AddRange(New XtraTabPage() { New XtraTabPage(), New XtraTabPage(), New XtraTabPage()})
			Dim i As Integer = 0
			Do While i < tabControl.TabPages.Count
			SetTabPageProperties(i)
				i += 1
			Loop
			tabControl.Dock = DockStyle.Fill
			Me.container.Controls.AddRange(New System.Windows.Forms.Control() {tabControl})
            AddHandler UserLookAndFeel.Default.StyleChanged, AddressOf UserLookAndFeel_Changed
            SetContainerSize()
        End Sub
        Sub UserLookAndFeel_Changed(ByVal sender As Object, ByVal e As System.EventArgs)
            SetContainerSize()
        End Sub
        Sub SetContainerSize()
			Me.container.Size = CalcFormSize()
		End Sub
		Private Function CreateTabControl() As XtraTabControl
			Return New XtraTabControl()
		End Function
		Private Function CreateColorListBox() As ColorListBox
			Return New ColorListBox()
		End Function
		Private Sub SetTabPageProperties(ByVal pageIndex As Integer)
			Dim tabPage As XtraTabPage = Me.tabControl.TabPages(pageIndex)
			Dim colorBox As ColorListBox = Nothing
			Dim control As BaseControl = Nothing
			Select Case pageIndex
				Case 0
                    tabPage.Text = Localizer.Active.GetLocalizedString(StringId.ColorTabCustom)
                    control = New ColorCellsControl(Nothing)
                    Dim rItem As DevExpress.XtraEditors.Repository.RepositoryItemColorEdit = New DevExpress.XtraEditors.Repository.RepositoryItemColorEdit()
                    rItem.ShowColorDialog = False
                    CType(IIf(TypeOf control Is ColorCellsControl, control, Nothing), ColorCellsControl).Properties = rItem
                    AddHandler CType(IIf(TypeOf control Is ColorCellsControl, control, Nothing), ColorCellsControl).EnterColor, AddressOf OnEnterColor
                    control.Size = ColorCellsControlViewInfo.BestSize
				Case 1
					tabPage.Text = Localizer.Active.GetLocalizedString(StringId.ColorTabWeb)
					colorBox = CreateColorListBox()
					colorBox.Items.AddRange(ColorListBoxViewInfo.WebColors)
					AddHandler colorBox.EnterColor, AddressOf OnEnterColor
					control = colorBox
				Case 2
					tabPage.Text = Localizer.Active.GetLocalizedString(StringId.ColorTabSystem)
					colorBox = CreateColorListBox()
					colorBox.Items.AddRange(ColorListBoxViewInfo.SystemColors)
					AddHandler colorBox.EnterColor, AddressOf OnEnterColor
					control = colorBox
			End Select
			control.Dock = DockStyle.Fill
			control.BorderStyle = BorderStyles.NoBorder
			control.LookAndFeel.ParentLookAndFeel = itemFontColor.Manager.GetController().LookAndFeel
			tabPage.Controls.Add(control)
		End Sub
		Private Sub OnEnterColor(ByVal sender As Object, ByVal e As EnterColorEventArgs)
			fResultColor = e.Color
			OnEnterColor(e.Color)
		End Sub
		Private Sub OnEnterColor(ByVal clr As Color)
			container.HidePopup()
			rtPad.SelectionColor = clr
			Dim imIndex As Integer = itemFontColor.ImageIndex
			Dim iml As ImageList = TryCast(itemFontColor.Images, ImageList)
			Dim im As Bitmap = CType(iml.Images(imIndex), Bitmap)
			Dim g As Graphics = Graphics.FromImage(im)
			Dim r As Rectangle = New Rectangle(7, 7, 8, 8)
			g.FillRectangle(New SolidBrush(clr), r)
			If imIndex = iml.Images.Count - 1 Then
				iml.Images.RemoveAt(imIndex)
			End If
            g.Dispose()
			iml.Images.Add(im)
			itemFontColor.ImageIndex = iml.Images.Count - 1

		End Sub
		Private ReadOnly Property CellsControl() As ColorCellsControl
			Get
				Return (CType(tabControl.TabPages(0).Controls(0), ColorCellsControl))
			End Get
		End Property
		Private ReadOnly Property CustomColorsName() As String
			Get
				Return "CustomColors"
			End Get
		End Property
		Public ReadOnly Property ResultColor() As Color
			Get
				Return fResultColor
			End Get
		End Property

		Public Function CalcFormSize() As Size
			Dim size As Size = ColorCellsControlViewInfo.BestSize
            size.Height = 6 * ColorCellsControlViewInfo.CellSize.Height + 7 * ColorCellsControlViewInfo.CellsInterval
			Return tabControl.CalcSizeByPageClient(size)
		End Function
	End Class
End Namespace
