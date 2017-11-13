Imports DevExpress.XtraLayout.Utils
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.Utils.MVVM
Imports DevExpress.Utils
Imports DevExpress.DevAV.ViewModels
Imports DevExpress.DevAV
Imports System.Drawing
Imports System

Namespace DevExpress.DevAV.Modules

    Partial Public Class EmployeeMailMerge
        Inherits BaseModuleControl
        Implements IRibbonModule

        Public Sub New()
            MyBase.New(GetType(EmployeeMailMergeViewModel))
            InitializeComponent()
            BindCommands()
            BindEditors()
            UpdateSelectTemplateUI()
            Dim TempZoomLevelManager As ZoomLevelManager = New ZoomLevelManager(beZoomLevel, bbiZoomDialog, New SnapZoomingModel(snapControl))
            AddHandler ViewModel.MailTemplateChanged, AddressOf ViewModel_MailTemplateChanged
            AddHandler ViewModel.MailTemplateSelectedChanged, AddressOf ViewModel_MailTemplateSelectedChanged
            AddHandler ViewModel.Save, AddressOf ViewModel_Save
            AddHandler snapControl.ModifiedChanged, AddressOf snapControl_ModifiedChanged
        End Sub
        Protected Overrides Sub OnDisposing()
            RemoveHandler ViewModel.Save, AddressOf ViewModel_Save
            RemoveHandler ViewModel.MailTemplateChanged, AddressOf ViewModel_MailTemplateChanged
            RemoveHandler ViewModel.MailTemplateSelectedChanged, AddressOf ViewModel_MailTemplateSelectedChanged
            MyBase.OnDisposing()
        End Sub
        Private Sub ViewModel_Save(ByVal sender As Object, ByVal e As EventArgs)
            snapControl.SaveDocumentAs()
        End Sub
        Private Sub ViewModel_MailTemplateSelectedChanged(ByVal sender As Object, ByVal e As EventArgs)
            UpdateSelectTemplateUI()
        End Sub
        Private Sub ViewModel_MailTemplateChanged(ByVal sender As Object, ByVal e As EventArgs)
            UpdateEditor(ViewModel.MailTemplate.GetValueOrDefault())
        End Sub
        Private Sub UpdateEditor(ByVal mailTemplate As EmployeeMailTemplate)
            ViewModel.Modified = snapControl.Modified
            cbMailTemplate.EditValue = mailTemplate
            LoadTemplate(mailTemplate)
            SynchronizeCurrentRecordWithSnap()
        End Sub
        Private Sub LoadTemplate(ByVal mailTemplate As EmployeeMailTemplate)
            Dim template As String = (mailTemplate.ToFileName() & ".snx")
            Using stream = MailMergeTemplatesHelper.GetTemplateStream(template)
                snapControl.LoadDocumentTemplate(stream, DevExpress.Snap.Core.API.SnapDocumentFormat.Snap)
            End Using
            ribbonControl.ApplicationDocumentCaption = DevExpress.XtraEditors.EnumDisplayTextHelper.GetDisplayText(mailTemplate)
        End Sub
        Private Sub UpdateSelectTemplateUI()
            layoutControlMailMergeSetting.Visibility = If(ViewModel.IsMailTemplateSelected, LayoutVisibility.Never, LayoutVisibility.Always)
            mailMergeRibbonPage1.Visible = Not ViewModel.IsMailTemplateSelected
        End Sub
        Public ReadOnly Overloads Property ViewModel() As EmployeeMailMergeViewModel
            Get
                Return GetViewModel(Of EmployeeMailMergeViewModel)()
            End Get
        End Property
        Public ReadOnly Property CollectionViewModel() As EmployeeCollectionViewModel
            Get
                Return GetParentViewModel(Of EmployeeCollectionViewModel)()
            End Get
        End Property
        Protected Overrides Sub OnLoad(ByVal ea As EventArgs)
            MyBase.OnLoad(ea)
            CollectionViewModel.GetEntities()
            bindingSource.DataSource = CollectionViewModel.SelectedEntity
            employeesList.DataSource = CollectionViewModel.GetEntities()

            gridView.FocusedRowHandle = gridView.LocateByValue("Id", CollectionViewModel.SelectedEntity.Id)
            If snapControl.Document.IsEmpty Then
                LoadTemplate(ViewModel.MailTemplate.GetValueOrDefault())
            End If
            snapControl.DataSource = employeesList.DataSource
            SynchronizeCurrentRecordWithSnap()
            ViewModel.Modified = snapControl.Modified
        End Sub
        Private Sub BindCommands()
            biClose.BindCommand(Sub() ViewModel.Close(), ViewModel)
        End Sub
        Private Sub BindEditors()
            AddHandler employeesList.Load, Sub(s, e) GridHelper.SetFindControlImages(employeesList)
            AddHandler gridView.FocusedRowObjectChanged, AddressOf gridView_FocusedRowObjectChanged

            cbMailTemplate.Properties.Items.AddEnum(Of EmployeeMailTemplate)()
            cbMailTemplate.Properties.SmallImages = CreateImageCollection()
            For Each item As DevExpress.XtraEditors.Controls.ImageComboBoxItem In cbMailTemplate.Properties.Items
                item.ImageIndex = CInt(CType(item.Value, EmployeeMailTemplate))
            Next item
            cbMailTemplate.EditValue = ViewModel.MailTemplate.GetValueOrDefault()
            AddHandler cbMailTemplate.EditValueChanged, AddressOf cbMailTemplate_EditValueChanged
        End Sub
        Private Shared Function CreateImageCollection() As ImageCollection
            Dim ret As New ImageCollection()
            ret.ImageSize = New Size(16, 16)
            ret.AddImage(My.Resources.icon_employee_quick_thank_16)
            ret.AddImage(My.Resources.icon_employee_quick_probation_notice_16)
            ret.AddImage(My.Resources.icon_employee_quick_excellence_16)
            ret.AddImage(My.Resources.icon_employee_quick_award_16)
            ret.AddImage(My.Resources.icon_employee_quick_welcome_16)
            Return ret
        End Function
        Private Sub gridView_FocusedRowObjectChanged(ByVal sender As Object, ByVal e As FocusedRowObjectChangedEventArgs)
            Dim employee As Employee = TryCast(e.Row, Employee)
            If employee IsNot Nothing Then
                bindingSource.DataSource = employee
                SynchronizeCurrentRecordWithSnap()
            End If
        End Sub
        Private Sub SynchronizeCurrentRecordWithSnap()
            snapControl.Options.SnapMailMergeVisualOptions.CurrentRecordIndex = gridView.GetDataSourceRowIndex(gridView.FocusedRowHandle)
        End Sub
        Private Sub cbMailTemplate_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            ViewModel.MailTemplate = CType(cbMailTemplate.EditValue, EmployeeMailTemplate)
        End Sub
        Private Sub snapControl_ModifiedChanged(ByVal sender As Object, ByVal e As EventArgs)
            ViewModel.Modified = snapControl.Modified
        End Sub
        #Region ""
        Private ReadOnly Property IRibbonModule_Ribbon() As XtraBars.Ribbon.RibbonControl Implements IRibbonModule.Ribbon
            Get
                Return ribbonControl
            End Get
        End Property
        #End Region
        #Region "IZoomViewModel Members"
        Private Class SnapZoomingModel
            Implements IZoomViewModel, ISupportZoom

            Private ReadOnly Property IZoomViewModel_ZoomModule() As Object Implements IZoomViewModel.ZoomModule
                Get
                    Return Me
                End Get
            End Property
            Private Custom Event ZoomModuleChanged As EventHandler Implements IZoomViewModel.ZoomModuleChanged
                AddHandler(ByVal value As EventHandler)
                End AddHandler
                RemoveHandler(ByVal value As EventHandler)
                End RemoveHandler
                RaiseEvent(ByVal sender As System.Object, ByVal e As System.EventArgs)
                End RaiseEvent
            End Event
            Private snapControl As DevExpress.Snap.SnapControl
            Public Sub New(ByVal snapControl As DevExpress.Snap.SnapControl)
                Me.snapControl = snapControl
                If snapControl IsNot Nothing Then
                    AddHandler snapControl.ZoomChanged, AddressOf snapControl_ZoomChanged
                End If
            End Sub
            Private Sub snapControl_ZoomChanged(ByVal sender As Object, ByVal e As EventArgs)
                RaiseZoomChanged()
            End Sub
            Private Property ISupportZoom_ZoomLevel() As Integer Implements ISupportZoom.ZoomLevel
                Get
                    Return CInt((System.Math.Ceiling(snapControl.ActiveView.ZoomFactor * 100.0F)))
                End Get
                Set(ByVal value As Integer)
                    snapControl.ActiveView.ZoomFactor = (CSng(value)) / 100.0F
                End Set
            End Property
            Public Event ZoomChanged As EventHandler Implements ISupportZoom.ZoomChanged
            Private Sub RaiseZoomChanged()
                Dim handler As EventHandler = ZoomChangedEvent
                If handler IsNot Nothing Then
                    handler(Me, EventArgs.Empty)
                End If
            End Sub
        End Class
        #End Region
    End Class
End Namespace
