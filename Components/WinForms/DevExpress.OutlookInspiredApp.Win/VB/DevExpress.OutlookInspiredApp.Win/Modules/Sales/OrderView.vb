Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraBars.Docking2010
Imports DevExpress.DevAV.ViewModels
Imports DevExpress.DevAV
Imports System

Namespace DevExpress.DevAV.Modules

    Partial Public Class OrderView
        Inherits BaseModuleControl

        Public Sub New()
            MyBase.New(GetType(SynchronizedOrderViewModel))
            InitializeComponent()
            BindCommands()
            TitleLabel.Appearance.ForeColor = ColorHelper.DisabledTextColor
            ItemForTitle.AppearanceItemCaption.ForeColor = ColorHelper.DisabledTextColor
            ItemForTitle.AppearanceItemCaption.Options.UseForeColor = True
            modueLayout.Visible = False
            snapControl.BackColor = ColorHelper.GetControlColor(LookAndFeel)
            AddHandler LookAndFeel.StyleChanged, AddressOf LookAndFeel_StyleChanged

            AddHandler ViewModel.EntityChanged, AddressOf ViewModel_EntityChanged
            AddHandler ViewModel.CustomizeFilter, AddressOf ViewModel_CustomizeFilter
            AddHandler snapControl.ZoomChanged, AddressOf snapControl_ZoomChanged
            UpdateDocumentUI()
        End Sub
        Private Sub LookAndFeel_StyleChanged(ByVal sender As Object, ByVal e As EventArgs)
            snapControl.BackColor = ColorHelper.GetControlColor(LookAndFeel)
        End Sub
        Protected Overrides Sub OnDisposing()
            RemoveHandler ViewModel.CustomizeFilter, AddressOf ViewModel_CustomizeFilter
            RemoveHandler ViewModel.EntityChanged, AddressOf ViewModel_EntityChanged
            MyBase.OnDisposing()
        End Sub
        Public ReadOnly Overloads Property ViewModel() As OrderViewModel
            Get
                Return GetViewModel(Of OrderViewModel)()
            End Get
        End Property
        Private Sub BindCommands()
            CType(buttons.Buttons(0), WindowsUIButton).BindCommand(Sub() ViewModel.Customize(), ViewModel)
        End Sub
        Private Sub ViewModel_EntityChanged(ByVal sender As Object, ByVal e As System.EventArgs)
            QueueUIUpdate()
        End Sub
        Private Sub ViewModel_CustomizeFilter(ByVal sender As Object, ByVal e As EventArgs)
            Me.snapControl.ReadOnly = Not Me.snapControl.ReadOnly
            UpdateDocumentUI()
        End Sub
        Private Sub UpdateDocumentUI()
            CType(buttons.Buttons(0), WindowsUIButton).Image = If(snapControl.ReadOnly, My.Resources.icon_edit_16, My.Resources.icon_close_16)
        End Sub
        Protected Overrides Function GetUIUpdateDelay() As Integer
            Return 500
        End Function
        Protected Overrides Sub OnDelayedUIUpdate()
            MyBase.OnDelayedUIUpdate()
            UpdateUI(ViewModel.Entity)
        End Sub
        Protected Overrides Sub OnLoad(ByVal e As System.EventArgs)
            MyBase.OnLoad(e)
            LoadOrderTemplate()
            UpdateUI(ViewModel.Entity)
        End Sub
        Private Sub LoadOrderTemplate()
            If Not snapControl.Document.IsEmpty Then
                Return
            End If
            Using stream = MailMergeTemplatesHelper.GetTemplateStream("Order.snx")
                snapControl.LoadDocumentTemplate(stream, DevExpress.Snap.Core.API.SnapDocumentFormat.Snap)
            End Using
            AddHandler snapControl.Paint, AddressOf snapControl_Paint
        End Sub
        Private Sub snapControl_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs)
            RemoveHandler snapControl.Paint, AddressOf snapControl_Paint
            Dim view As PrintLayoutView = TryCast(snapControl.ActiveView, PrintLayoutView)
            If view IsNot Nothing Then
                view.FitToPage()
            End If
        End Sub
        Private Sub snapControl_ZoomChanged(ByVal sender As Object, ByVal e As EventArgs)
            RaiseZoomLevelChanged()
        End Sub
        Private Sub UpdateUI(ByVal order As Order)
            If order IsNot Nothing Then
                If Not Object.Equals(bindingSource.DataSource, order) Then
                    bindingSource.DataSource = order
                Else
                    bindingSource.ResetBindings(False)
                End If
                snapControl.Document.Fields.Update()
            End If
            modueLayout.Visible = (order IsNot Nothing)
        End Sub
        Public Property ZoomLevel() As Integer
            Get
                Return CInt((System.Math.Ceiling(snapControl.ActiveView.ZoomFactor * 100.0F)))
            End Get
            Set(ByVal value As Integer)
                If ZoomLevel = value Then
                    Return
                End If
                snapControl.ActiveView.ZoomFactor = (CSng(value)) / 100.0F
            End Set
        End Property
        Public Event ZoomLevelChanged As EventHandler
        Private Sub RaiseZoomLevelChanged()
            Dim handler As EventHandler = ZoomLevelChangedEvent
            If handler IsNot Nothing Then
                handler(Me, EventArgs.Empty)
            End If
        End Sub
    End Class
End Namespace
