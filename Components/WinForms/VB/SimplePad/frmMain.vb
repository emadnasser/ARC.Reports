Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.IO
Imports System.Diagnostics
Imports DevExpress.LookAndFeel
Imports DevExpress.Utils.Frames
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraBars.Demos.SimplePad
    Partial Public Class frmMain
        Inherits DevExpress.XtraEditors.XtraForm
        Private dlgFind As frmFind
        Private dlgReplace As frmReplace
        Private modified_Renamed As Boolean
        Private open_Renamed As Boolean
        Private Const docNameDefault As String = "document1.rtf"
        Private docName_Renamed As String
        Private currentCursor As Cursor
        Private cp As ColorPopup
        Private skinMask As String = "Skin: "
        Private skinProcessing As Boolean = False

        Public Sub New()
            DevExpress.Utils.About.UAlgo.Default.DoEventObject(DevExpress.Utils.About.UAlgo.kDemo, DevExpress.Utils.About.UAlgo.pWinForms, Me) 'DEMO_REMOVE
            InitializeComponent()
            InitOpen()
            AddHandler rtPad.SelectionChanged, AddressOf rtPad_SelectionChanged
            rtPadClear()
            iSave.Enabled = False
            Modified = False
            AddHandler barManager1.GetController().Changed, AddressOf ChangedController

            CreateColorPopup(popupControlContainer1)
            barManager1.GetController().AppearancesBar.SubMenu.Menu.Image = pictureBox1.Image
            barManager1.GetController().AppearancesBar.SubMenu.SideStrip.BackColor = Color.FromArgb(90, SystemColors.Control)
            SetMenuBackColor()
            iNew_ItemClick(iNew, Nothing)
            ips_Init()
            InitSkins()
            AddHandler UserLookAndFeel.Default.StyleChanged, AddressOf UserLookAndFeel_StyleChanged
            Icon = DevExpress.Utils.ResourceImageHelper.CreateIconFromResourcesEx("AppIcon.ico", GetType(frmMain).Assembly)
        End Sub
        Private Sub UserLookAndFeel_StyleChanged(ByVal sender As Object, ByVal e As System.EventArgs)
            SetMenuBackColor()
        End Sub
        Sub SetMenuBackColor()
            If FrameHelper.IsDarkSkin(UserLookAndFeel.Default) Then
                barManager1.GetController().AppearancesBar.SubMenu.Menu.BackColor = Color.FromArgb(150, Color.Black)
            Else
                barManager1.GetController().AppearancesBar.SubMenu.Menu.BackColor = Color.FromArgb(50, Color.White)
            End If
        End Sub
        Private Sub CreateColorPopup(ByVal container As PopupControlContainer)
            cp = New ColorPopup(container, iFontColor, rtPad)
        End Sub
#Region "Skins"

        Private Sub InitSkins()
            barManager1.ForceInitialize()
            If barManager1.GetController().PaintStyleName = "Skin" Then
                iPaintStyle.Caption = skinMask & DevExpress.LookAndFeel.UserLookAndFeel.Default.ActiveSkinName
            End If
            For Each cnt As DevExpress.Skins.SkinContainer In DevExpress.Skins.SkinManager.Default.Skins
                Dim item As BarButtonItem = New BarButtonItem(barManager1, skinMask & cnt.SkinName)
                iPaintStyle.AddItem(item)
                AddHandler item.ItemClick, AddressOf OnSkinClick
            Next cnt
        End Sub
        Private Sub OnSkinClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Dim skinName As String = e.Item.Caption.Replace(skinMask, "")
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(skinName)
            barManager1.GetController().PaintStyleName = "Skin"
            iPaintStyle.Caption = e.Item.Caption
            iPaintStyle.Hint = iPaintStyle.Caption
            iPaintStyle.ImageIndex = -1
        End Sub
#End Region

        Private Function rtPadFontStyle() As FontStyle
            Dim fs As FontStyle = New FontStyle()
            If iBold.Down Then
                fs = fs Or FontStyle.Bold
            End If
            If iItalic.Down Then
                fs = fs Or FontStyle.Italic
            End If
            If iUnderline.Down Then
                fs = fs Or FontStyle.Underline
            End If
            Return fs
        End Function

        Private Sub barManager1_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barManager1.ItemClick
            If e.Item.Category Is barManager1.Categories("Format") Then
                iUndo.Enabled = Modified
            End If
        End Sub

        Private Sub iBullets_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iBullets.ItemClick
            rtPad.SelectionBullet = iBullets.Down
        End Sub

        Protected Property DocName() As String
            Get
                Return docName_Renamed
            End Get
            Set(value As String)
                If value <> docName_Renamed Then
                    docName_Renamed = value
                    If Open Then
                        sDocName.Caption = docName_Renamed
                    Else
                        sDocName.Caption = ""
                    End If
                End If
            End Set
        End Property

        Protected Property Open() As Boolean
            Get
                Return open_Renamed
            End Get
            Set(value As Boolean)
                If value <> open_Renamed Then
                    open_Renamed = value
                    InitOpen()
                    rtPad.HideSelection = Not open_Renamed
                End If
            End Set
        End Property

        Protected Property Modified() As Boolean
            Get
                Return modified_Renamed
            End Get
            Set(value As Boolean)
                If value <> modified_Renamed Then
                    modified_Renamed = value
                    iSave.Enabled = modified_Renamed
                    If modified_Renamed Then
                        sModifier.Caption = "Modified"
                    Else
                        sModifier.Caption = " "
                        iUndo.Enabled = False
                    End If
                End If
            End Set
        End Property

        Protected Sub InitOpen()
            iPrint.Enabled = Open
            iClose.Enabled = iPrint.Enabled
            iSaveAs.Enabled = iClose.Enabled
            mFormat.Enabled = iSaveAs.Enabled
            mEdit.Enabled = mFormat.Enabled
            Dim cat As BarManagerCategory = barManager1.Categories("Edit")
            For Each item As BarItem In barManager1.Items
                If item.Category Is cat Then
                    item.Enabled = Open
                End If
            Next item
            cat = barManager1.Categories("Format")
            For Each item As BarItem In barManager1.Items
                If item.Category Is cat Then
                    item.Enabled = Open
                End If
            Next item
            rtPad.Enabled = Open
            iEdit.Enabled = rtPad.Enabled
            InitPaste()
        End Sub

        Protected Sub InitFormat()
            iBold.Down = SelectFont.Bold
            iItalic.Down = SelectFont.Italic
            iUnderline.Down = SelectFont.Underline
            iProtected.Down = rtPad.SelectionProtected
            iBullets.Down = rtPad.SelectionBullet
            Select Case rtPad.SelectionAlignment
                Case HorizontalAlignment.Left
                    iAlignLeft.Down = True
                Case HorizontalAlignment.Center
                    iCenter.Down = True
                Case HorizontalAlignment.Right
                    iAlignRight.Down = True
            End Select
        End Sub

        Protected Sub InitPaste()
            iPaste.Enabled = rtPad.CanPaste(DataFormats.GetFormat(0)) AndAlso Open
        End Sub

        Protected Sub InitEdit(ByVal b As Boolean)
            iCut.Enabled = b
            iCopy.Enabled = b
            iClear.Enabled = b
            iUndo.Enabled = rtPad.CanUndo
            iSelectAll.Enabled = rtPad.CanSelect
        End Sub

        Private Sub rtPad_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs)
            InitFormat()
            InitEdit(rtPad.SelectionLength > 0)
            Dim line As Integer = rtPad.GetLineFromCharIndex(rtPad.SelectionStart) + 1
            Dim col As Integer = rtPad.SelectionStart + 1

            sPosition.Caption = "Line: " & line.ToString() & "  Position: " & col.ToString()
        End Sub

        Private Sub iFontStyle_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iBold.ItemClick, iItalic.ItemClick, iUnderline.ItemClick
            rtPad.SelectionFont = New Font(SelectFont.FontFamily.Name, SelectFont.Size, rtPadFontStyle())
        End Sub

        Private Sub iProtected_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iProtected.ItemClick
            rtPad.SelectionProtected = iProtected.Down
        End Sub

        Private Sub iAlign_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iCenter.ItemClick, iAlignLeft.ItemClick, iAlignRight.ItemClick
            If iAlignLeft.Down Then
                rtPad.SelectionAlignment = HorizontalAlignment.Left
            End If
            If iCenter.Down Then
                rtPad.SelectionAlignment = HorizontalAlignment.Center
            End If
            If iAlignRight.Down Then
                rtPad.SelectionAlignment = HorizontalAlignment.Right
            End If
        End Sub

        Private Sub iNew_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iNew.ItemClick
            If SaveQuestion() Then
                Open = True
                DocName = docNameDefault
                rtPadClear()
                Modified = False
                rtPad.SelectionLength = 0
            End If
        End Sub

        Private Sub iClose_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iClose.ItemClick
            If SaveQuestion() Then
                DocName = " "
                rtPadClear()
                Open = False
                Modified = False
            End If
        End Sub

        Protected Sub rtPadClear()
            RefreshForm(True)
            rtPad.SelectionBullet = False
            rtPad.SelectionProtected = False
            rtPad.Clear()
            rtPad.ClearUndo()
            iUndo.Enabled = False
            rtPad.Focus()
            rtPad_SelectionChanged(Nothing, Nothing)
            RefreshForm(False)
        End Sub

        Protected ReadOnly Property SelectFont() As Font
            Get
                If Not rtPad.SelectionFont Is Nothing Then
                    Return rtPad.SelectionFont
                End If
                Return rtPad.Font
            End Get
        End Property
        Protected Sub RefreshForm(ByVal b As Boolean)
            If b Then
                currentCursor = Windows.Forms.Cursor.Current
                Windows.Forms.Cursor.Current = Cursors.WaitCursor
                Refresh()
            Else
                Windows.Forms.Cursor.Current = currentCursor
            End If
        End Sub
        Private Sub iOpen_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iOpen.ItemClick
            If SaveQuestion() Then
                Dim dlg As OpenFileDialog = New OpenFileDialog()
                dlg.Filter = "Rich Text Files (*.rtf)|*.rtf"
                dlg.Title = "Open"
                If dlg.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                    Open = True
                    RefreshForm(True)
                    Try
                        rtPad.LoadFile(dlg.FileName)
                    Catch
                        XtraMessageBox.Show("Sorry, this file cannot be opened.", "Simple Pad")
                        Return
                    End Try
                    DocName = dlg.FileName
                    Modified = False
                    RefreshForm(False)
                End If
            End If
        End Sub

        Private Sub iPrint_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iPrint.ItemClick
            DevExpress.XtraEditors.XtraMessageBox.Show(Me, "Note that you can use the XtraPrinting Library to print the contents of the standard RichTextBox control." + vbNewLine + "For more information, see the main XtraPrinting demo.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Sub

        Private Sub rtPad_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rtPad.TextChanged
            Modified = True
        End Sub

        Private Sub iSave_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iSave.ItemClick
            If DocName = docNameDefault Then
                iSaveAs_ItemClick(Me, e)
            Else
                If Modified Then
                    RefreshForm(True)
                    rtPad.SaveFile(DocName, RichTextBoxStreamType.RichText)
                    Modified = False
                    RefreshForm(False)
                End If
            End If
        End Sub
        Private Sub iSaveAs_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iSaveAs.ItemClick
            Dim dlg As SaveFileDialog = New SaveFileDialog()
            dlg.Filter = "Rich Text Files (*.rtf)|*.rtf"
            dlg.Title = "Save As"
            If dlg.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                RefreshForm(True)
                rtPad.SaveFile(dlg.FileName, RichTextBoxStreamType.RichText)
                DocName = dlg.FileName
                Modified = False
                RefreshForm(False)
            End If
        End Sub

        Private Sub iExit_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iExit.ItemClick
            Close()
        End Sub

        Private Sub iUndo_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iUndo.ItemClick
            rtPad.Undo()
            Modified = rtPad.CanUndo
            iUndo.Enabled = rtPad.CanUndo
            InitFormat()
        End Sub

        Private Sub iCut_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iCut.ItemClick
            rtPad.Cut()
            InitPaste()
        End Sub

        Private Sub iCopy_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iCopy.ItemClick
            rtPad.Copy()
            InitPaste()
        End Sub

        Private Sub iPaste_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iPaste.ItemClick
            rtPad.Paste()
        End Sub

        Private Sub iClear_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iClear.ItemClick
            rtPad.SelectedRtf = ""
        End Sub

        Private Sub iSelectAll_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iSelectAll.ItemClick
            rtPad.SelectAll()
        End Sub

        Private Sub iFind_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iFind.ItemClick
            If Not dlgReplace Is Nothing Then
                dlgReplace.Close()
            End If
            If Not dlgFind Is Nothing Then
                dlgFind.Close()
            End If
            dlgFind = New frmFind(rtPad, Bounds)
            AddOwnedForm(dlgFind)
            dlgFind.Show()
        End Sub

        Private Sub iReplace_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iReplace.ItemClick
            If Not dlgReplace Is Nothing Then
                dlgReplace.Close()
            End If
            If Not dlgFind Is Nothing Then
                dlgFind.Close()
            End If
            dlgReplace = New frmReplace(rtPad, Bounds)
            AddOwnedForm(dlgReplace)
            dlgReplace.Show()
        End Sub

        Private Sub iWeb_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iWeb.ItemClick
            Dim process As Process = New Process()
            process.StartInfo.FileName = "http://www.devexpress.com"
            process.StartInfo.Verb = "Open"
            process.StartInfo.WindowStyle = ProcessWindowStyle.Normal
            process.Start()
        End Sub

        Private Sub iAbout_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iAbout.ItemClick
            BarManager.About()
        End Sub

        Private Sub iFont_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iFont.ItemClick
            Dim dlg As FontDialog = New FontDialog()
            dlg.Font = CType(SelectFont.Clone(), Font)
            dlg.ShowColor = True
            dlg.Color = rtPad.SelectionColor
            If dlg.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                rtPad.SelectionFont = CType(dlg.Font.Clone(), Font)
                rtPad.SelectionColor = dlg.Color
            End If
        End Sub

        Protected Function SaveQuestion() As Boolean
            If Modified Then
                Select Case DevExpress.XtraEditors.XtraMessageBox.Show("Do you want to save the changes you made to " & DocName & "?", "SimplePad Question", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                    Case Windows.Forms.DialogResult.Cancel
                        Return False
                    Case Windows.Forms.DialogResult.Yes
                        iSaveAs_ItemClick(Nothing, Nothing)
                End Select
            End If
            Return True
        End Function

        Private Sub rtPad_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles rtPad.MouseUp
            If (e.Button And Windows.Forms.MouseButtons.Right) <> 0 AndAlso rtPad.ClientRectangle.Contains(e.X, e.Y) Then
                popupMenu1.ShowPopup(Control.MousePosition)
            End If
        End Sub

        Private Sub iFontColor_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iFontColor.ItemClick
            rtPad.SelectionColor = cp.ResultColor
        End Sub

        Private Sub frmMain_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
            e.Cancel = Not SaveQuestion()
        End Sub

        Private Sub frmMain_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
            InitPaste()
        End Sub

        Private Sub ips_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles ipsDefault.ItemClick, ipsWXP.ItemClick, ipsOXP.ItemClick, ipsO2K.ItemClick, ipsO3.ItemClick
            barManager1.GetController().PaintStyleName = e.Item.Description
            InitPaintStyle(e.Item)
            barManager1.GetController().ResetStyleDefaults()
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetDefaultStyle()
        End Sub

        Private Sub InitPaintStyle(ByVal item As BarItem)
            If item Is Nothing Then
                Return
            End If
            iPaintStyle.ImageIndex = item.ImageIndex
            iPaintStyle.Caption = item.Caption
            iPaintStyle.Hint = item.Description
        End Sub

        Private Sub ips_Init()
            Dim item As BarItem = Nothing
            For i As Integer = 0 To barManager1.Items.Count - 1
                If barManager1.Items(i).Description = barManager1.GetController().PaintStyleName Then
                    item = barManager1.Items(i)
                End If
            Next i
            InitPaintStyle(item)
        End Sub


        Private Sub ChangedController(ByVal sender As Object, ByVal e As EventArgs)
            If skinProcessing Then
                Return
            End If
            Dim paintStyleName As String = barManager1.GetController().PaintStyleName
            If "Office2000OfficeXPWindowsXP".IndexOf(paintStyleName) >= 0 Then
                barManager1.Images = imageList2
            Else
                barManager1.Images = imageList1
            End If
            If "DefaultSkin".IndexOf(paintStyleName) >= 0 Then
                DevExpress.Skins.SkinManager.EnableFormSkins()
            Else
                DevExpress.Skins.SkinManager.DisableFormSkins()
            End If
            skinProcessing = True
            DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged()
            skinProcessing = False
        End Sub

        Private Function CaptionTransform(ByVal g As Graphics, ByVal r As Rectangle) As Rectangle
            g.RotateTransform(-90)
            r.X = r.X - r.Height + 5
            r.Width = r.Height
            Return r
        End Function

        Private Sub item_PaintMenuBar(ByVal sender As Object, ByVal e As DevExpress.XtraBars.BarCustomDrawEventArgs) Handles popupMenu1.PaintMenuBar, mFile.PaintMenuBar
            Dim r As Rectangle = e.Bounds
            r.Inflate(1, 1)
            Dim brush As System.Drawing.Drawing2D.LinearGradientBrush = New System.Drawing.Drawing2D.LinearGradientBrush(r, Color.DarkBlue, Color.White, -90)
            e.Graphics.FillRectangle(brush, e.Bounds)
            r = CaptionTransform(e.Graphics, e.Bounds)
            Dim f As Font = New Font("Arial", 11, FontStyle.Bold)
            Dim caption As String = "XtraBars"
            e.Graphics.DrawString(caption, f, Brushes.Black, r)
            r.X -= 1
            r.Y -= 1
            e.Graphics.DrawString(caption, f, Brushes.White, r)
            e.Graphics.ResetTransform()
            e.Handled = True
        End Sub
    End Class
End Namespace
