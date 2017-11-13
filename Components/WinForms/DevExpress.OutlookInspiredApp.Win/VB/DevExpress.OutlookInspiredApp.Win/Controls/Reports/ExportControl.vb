Imports System
Imports System.Windows.Forms
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraEditors
Imports DevExpress.XtraLayout.Utils
Imports DevExpress.XtraPrinting

Namespace DevExpress.DevAV
    Partial Public Class ReportExportControl
        Inherits XtraUserControl

        Private menuExport As DXPopupMenu
        Public Sub New()
            InitializeComponent()
            SelectedExport = ExportTarget.Pdf
            menuExport = New DXPopupMenu()
            AddExportTarget(ExportTarget.Pdf)
            AddExportTarget(ExportTarget.Html)
            AddExportTarget(ExportTarget.Mht)
            AddExportTarget(ExportTarget.Rtf)
            AddExportTarget(ExportTarget.Xls)
            AddExportTarget(ExportTarget.Xlsx)
            AddExportTarget(ExportTarget.Csv)
            AddExportTarget(ExportTarget.Text)
            AddExportTarget(ExportTarget.Image)
            btnExport.DropDownControl = menuExport
            AddHandler menuExport.BeforePopup, AddressOf menuExport_BeforePopup
            moduleLayout.BackColor = ColorHelper.GetControlColor(LookAndFeel)
            AddHandler LookAndFeel.StyleChanged, AddressOf LookAndFeel_StyleChanged
        End Sub
        Private Sub LookAndFeel_StyleChanged(ByVal sender As Object, ByVal e As EventArgs)
            moduleLayout.BackColor = ColorHelper.GetControlColor(LookAndFeel)
        End Sub
        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            btnExport.MenuManager = MenuManagerHelper.FindMenuManager(AppHelper.MainForm)
        End Sub
        Private Sub menuExport_BeforePopup(ByVal sender As Object, ByVal e As EventArgs)
            For Each item As DXMenuCheckItem In menuExport.Items
                item.Checked = Object.Equals(item.Tag, SelectedExport)
            Next item
        End Sub
        Private Sub AddExportTarget(ByVal target As ExportTarget)
            Dim exportItem = New DXMenuCheckItem() With {.Caption = target.ToString(), .Tag = target}
            menuExport.Items.Add(exportItem)
            AddHandler exportItem.Click, AddressOf exportItem_Click
        End Sub
        Private Sub exportItem_Click(ByVal sender As Object, ByVal e As EventArgs)
            SelectedExport = CType(DirectCast(sender, DXMenuItem).Tag, ExportTarget)
        End Sub
        Public Sub SetSettings(ByVal control As Control)
            For i As Integer = settingsPanel.Controls.Count - 1 To 0 Step -1
                settingsPanel.Controls(i).Dispose()
            Next i
            If control IsNot Nothing Then
                control.Dock = DockStyle.Fill
                control.Parent = settingsPanel
            End If
        End Sub
        Public WriteOnly Property ExportEnabled() As Boolean
            Set(ByVal value As Boolean)
                btnExport.Enabled = value
            End Set
        End Property
        Public Property SelectedExport() As ExportTarget
        Public Event ExportClick As EventHandler
        Private Sub RaiseExportClick()
            RaiseEvent ExportClick(Me, EventArgs.Empty)
        End Sub
        Private Sub btnExport_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExport.Click
            RaiseExportClick()
        End Sub
    End Class
End Namespace
