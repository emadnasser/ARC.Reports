Imports System
Imports System.ComponentModel
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Preview
Imports DevExpress.XtraLayout.Utils
Imports System.Windows.Forms
Imports DevExpress.Printing

Namespace DevExpress.DevAV
    Partial Public Class ReportPrintControl
        Inherits XtraUserControl

        Private imagesContainer As PrinterImagesContainer
        Private printerItemContainer As PrinterItemContainer
        Public Sub New()
            InitializeComponent()
            imagesContainer = New PrinterImagesContainer()
            CreatePrinterItemContainer()

            moduleLayout.BackColor = ColorHelper.GetControlColor(LookAndFeel)
            AddHandler LookAndFeel.StyleChanged, AddressOf LookAndFeel_StyleChanged
        End Sub
        Private Sub CreatePrinterItemContainer()
            Try
                printerItemContainer = New PrinterItemContainer()
            Catch
            End Try
        End Sub
        Private Sub LookAndFeel_StyleChanged(ByVal sender As Object, ByVal e As EventArgs)
            moduleLayout.BackColor = ColorHelper.GetControlColor(LookAndFeel)
        End Sub
        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            cbPrinters.Properties.LargeImages = imagesContainer.LargeImages
            cbPrinters.Properties.SmallImages = imagesContainer.SmallImages
            If printerItemContainer IsNot Nothing Then
                For Each item As PrinterItem In printerItemContainer.Items
                    cbPrinters.Properties.Items.Add(New ImageComboBoxItem(item.DisplayName, item, imagesContainer.GetImageIndex(item)))
                Next item
            End If
        End Sub
        Public WriteOnly Property PrintEnabled() As Boolean
            Set(ByVal value As Boolean)
                btnPrint.Enabled = value
                btnOptions.Enabled = btnPrint.Enabled
            End Set
        End Property
        Public WriteOnly Property SettingsVisible() As Boolean
            Set(ByVal value As Boolean)
                ItemForSettings.Visibility = If(value, LayoutVisibility.Always, LayoutVisibility.Never)
            End Set
        End Property
        Public Sub SetSettings(ByVal control As Control)
            For i As Integer = settingsPanel.Controls.Count - 1 To 0 Step -1
                settingsPanel.Controls(i).Dispose()
            Next i
            If control IsNot Nothing Then
                control.Dock = DockStyle.Fill
                control.Parent = settingsPanel
            End If
        End Sub
        Public Property SelectedPrinterName() As String
            Get
                Dim item As PrinterItem = TryCast(cbPrinters.EditValue, PrinterItem)
                If item IsNot Nothing Then
                    Return item.FullName
                End If
                Return String.Empty
            End Get
            Set(ByVal value As String)
                cbPrinters.EditValue = FindPrinterItem(value)
            End Set
        End Property
        Private Function FindPrinterItem(ByVal value As String) As PrinterItem
            If printerItemContainer IsNot Nothing Then
                For i As Integer = 0 To printerItemContainer.Items.Count - 1
                    If printerItemContainer.Items(i).FullName <> value Then
                        Continue For
                    End If
                    Return printerItemContainer.Items(i)
                Next i
            End If
            Return Nothing
        End Function
        Public Event PrintClick As EventHandler
        Public Event PrintOptionsClick As EventHandler
        Private Sub RaisePrintOptionsClick()
            RaiseEvent PrintOptionsClick(Me, EventArgs.Empty)
        End Sub
        Private Sub RaisePrintClick()
            RaiseEvent PrintClick(Me, EventArgs.Empty)
        End Sub
        Private Sub btnPrint_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrint.Click
            RaisePrintClick()
        End Sub
        Private Sub btnOptions_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnOptions.Click
            RaisePrintOptionsClick()
        End Sub
    End Class
    <ToolboxItem(False), Designer("System.Windows.Forms.Design.ParentControlDesigner, System.Design", GetType(System.ComponentModel.Design.IDesigner))>
    Public Class SettingPanel
        Inherits XtraUserControl

    End Class
End Namespace
