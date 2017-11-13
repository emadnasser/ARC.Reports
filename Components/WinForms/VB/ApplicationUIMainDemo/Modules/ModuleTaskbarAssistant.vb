Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.Utils.Taskbar
Imports DevExpress.Utils.Taskbar.Core
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.Utils.Drawing.Helpers

Namespace DevExpress.ApplicationUI.Demos
    Partial Public Class ModuleTaskbarAssistant
        Inherits TutorialControl
        Private taskbarAssistant_Renamed As TaskbarAssistant
        Public Sub New()
            InitializeComponent()
            TutorialInfo.TutorialName = "TaskbarAssistant Tutorial"
        End Sub
        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            CreateTaskbarAssistant()
            InitControls()
            UpdateControls(False)
            CreateThumbnailButtons()
        End Sub
        Private Sub CreateThumbnailButtons()
            For i As Integer = 0 To TaskbarAssistant.MaxThumbnailButtonsCount - 1
                Dim thumbButton As ThumbnailButton = CreateThumbnailButton()
                TaskbarAssistant.ThumbnailButtons.Add(thumbButton)
            Next i
        End Sub
        Private Sub CreateTaskbarAssistant()
            Me.taskbarAssistant_Renamed = New TaskbarAssistant()
            TaskbarAssistant.ParentControl = ParentForm
        End Sub
        Private Sub InitControls()
            Dim progressModes = System.Enum.GetValues(GetType(TaskbarButtonProgressMode))
            For Each progressMode As TaskbarButtonProgressMode In progressModes
                cbProgressMode.Properties.Items.Add(progressMode)
            Next progressMode
            If cbProgressMode.Properties.Items.Count > 0 Then
                cbProgressMode.SelectedIndex = 0
            End If
            imgOverlayIcons.Properties.Items.Add(New ImageComboBoxNoneItem())
            For i As Integer = 0 To imgCollection.Images.Count - 1
                Dim description As String = imgCollection.Images.Keys(i)
                imgOverlayIcons.Properties.Items.Add(New ImageComboBoxItem(description, i))
            Next i
            If imgOverlayIcons.Properties.Items.Count > 0 Then
                imgOverlayIcons.SelectedIndex = 0
            End If
        End Sub
        ' <btnAddThumbnailButton>
        Private Sub OnAddThumbnailButtonClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnAddThumbnailButton.Click
            For Each button As ThumbnailButton In TaskbarAssistant.ThumbnailButtons
                If Not button.Visible Then
                    button.Visible = True
                    Exit For
                End If
            Next button
            TaskbarAssistant.Refresh()
            UpdateControls()
        End Sub
        ' </btnAddThumbnailButton>
        ' <btnRemoveThumbnailButton>
        Private Sub OnRemoveThumbnailButtonClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnRemoveThumbnailButton.Click
            For i As Integer = TaskbarAssistant.ThumbnailButtons.Count - 1 To 0 Step -1
                Dim thumbButton As ThumbnailButton = TaskbarAssistant.ThumbnailButtons(i)
                If thumbButton.Visible Then
                    thumbButton.Visible = False
                    Exit For
                End If
            Next i
            TaskbarAssistant.Refresh()
            UpdateControls()
        End Sub
        ' </btnRemoveThumbnailButton>
        ' <cbProgressMode>
        Private Sub OnProgressModeComboBoxEditSelectedValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbProgressMode.SelectedValueChanged
            Dim cb As ComboBoxEdit = CType(sender, ComboBoxEdit)
            taskbarAssistant_Renamed.ProgressMode = CType(cb.EditValue, TaskbarButtonProgressMode)
        End Sub
        ' </cbProgressMode>
        ' <trackBarProgressValue>
        Private Sub OnCurrentProgressValueTrackBarEditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles trackBarProgressValue.EditValueChanged
            Dim trackBar As TrackBarControl = CType(sender, TrackBarControl)
            taskbarAssistant_Renamed.ProgressCurrentValue = trackBar.Value
        End Sub
        ' </trackBarProgressValue>
        ' <imgOverlayIcons>
        Private Sub OnOverlayIconsComboBoxSelectedValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles imgOverlayIcons.SelectedValueChanged
            Dim item As ImageComboBoxItem = CType((CType(sender, ImageComboBoxEdit)).SelectedItem, ImageComboBoxItem)
            Dim img As Image = If(TypeOf item Is ImageComboBoxNoneItem, Nothing, imgCollection.Images(item.ImageIndex))
            taskbarAssistant_Renamed.OverlayIcon = CType(img, Bitmap)
        End Sub
        ' </imgOverlayIcons>
        ' <btnAddItemToTasks>
        Private Sub OnAddItemToTasksButtonClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnAddItemToTasks.Click
            Dim itemCaption As String = String.Format("Task #{0}", (taskbarAssistant_Renamed.JumpListTasksCategory.Count + 1).ToString())
            Dim taskItem As New JumpListItemTask(itemCaption)
            AddHandler taskItem.Click, AddressOf OnJumpListClick
            taskbarAssistant_Renamed.JumpListTasksCategory.Add(taskItem)
            taskbarAssistant_Renamed.Refresh()
            UpdateControls()
        End Sub
        Private Sub OnJumpListClick(ByVal sender As Object, ByVal e As EventArgs)
            XtraMessageBox.Show("Click")
        End Sub
        ' </btnAddItemToTasks>
        ' <btnRemoveItemFromTasks>
        Private Sub OnRemoveItemFromTasksButtonClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnRemoveItemFromTasks.Click
            Dim itemsCount As Integer = taskbarAssistant_Renamed.JumpListTasksCategory.Count
            If itemsCount = 0 Then
                Return
            End If
            taskbarAssistant_Renamed.JumpListTasksCategory.RemoveAt(itemsCount - 1)
            taskbarAssistant_Renamed.Refresh()
            UpdateControls()
        End Sub
        ' </btnRemoveItemFromTasks>
        ' <btnAddCustomCategory>
        Private Sub OnAddCustomCategoryButtonClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnAddCustomCategory.Click
            Dim categoryName As String = String.Format("Custom Category #{0}", (TaskbarAssistant.JumpListCustomCategories.Count + 1).ToString())
            Dim customCategory As New JumpListCategory(categoryName)
            For i As Integer = 0 To 1
                Dim itemCaption As String = String.Format("Task #{0}", (i + 1).ToString())
                Dim item As New JumpListItemTask(itemCaption)
                AddHandler item.Click, AddressOf OnJumpListClick
                customCategory.JumpItems.Add(item)
            Next i
            TaskbarAssistant.JumpListCustomCategories.Add(customCategory)
            TaskbarAssistant.Refresh()
            UpdateControls()
        End Sub
        ' </btnAddCustomCategory>
        ' <btnRemoveCustomCategory>
        Private Sub OnRemoveCustomCategoryButtonClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnRemoveCustomCategory.Click
            Dim categoriesCount As Integer = TaskbarAssistant.JumpListCustomCategories.Count
            If categoriesCount = 0 Then
                Return
            End If
            TaskbarAssistant.JumpListCustomCategories.RemoveAt(categoriesCount - 1)
            TaskbarAssistant.Refresh()
            UpdateControls()
        End Sub
        ' </btnRemoveCustomCategory>
        Private rnd As New Random()
        Private Function CreateThumbnailButton() As ThumbnailButton
            Dim res As New ThumbnailButton()
            If imgCollection.Images.Count > 0 Then
                res.Image = CType(imgCollection.Images(rnd.Next(0, imgCollection.Images.Count)), Bitmap)
            End If
            AddHandler res.Click, Sub(s, ee)
                                      Dim thumbButtonPos As Integer = TaskbarAssistant.ThumbnailButtons.IndexOf(ee.ThumbButton) + 1
                                      XtraMessageBox.Show(ParentForm, String.Format("ThumbnailButton # {0} clicked", thumbButtonPos.ToString()), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                  End Sub
            res.Visible = False
            Return res
        End Function
        Private Sub UpdateControls(Optional ByVal blinkTaskbarItem As Boolean = True)
            btnAddThumbnailButton.Enabled = CalcVisibleThumbnailButtonsCount() < TaskbarAssistant.MaxThumbnailButtonsCount
            btnRemoveThumbnailButton.Enabled = CalcVisibleThumbnailButtonsCount() > 0
            btnRemoveCustomCategory.Enabled = TaskbarAssistant.JumpListCustomCategories.Count > 0
            btnRemoveItemFromTasks.Enabled = TaskbarAssistant.JumpListTasksCategory.Count > 0
            If blinkTaskbarItem Then
                NativeMethods.FlashWindowEx(ParentFormMain.Handle, NativeMethods.FLASHW.FLASHW_TRAY, 7, 250)
            End If
        End Sub
        Private Function CalcVisibleThumbnailButtonsCount() As Integer
            Dim count As Integer = 0
            For Each thumbButton As ThumbnailButton In TaskbarAssistant.ThumbnailButtons
                If thumbButton.Visible Then count = count + 1
            Next
            Return count
        End Function
        Private ReadOnly Property TaskbarAssistant() As TaskbarAssistant
            Get
                Return taskbarAssistant_Renamed
            End Get
        End Property
    End Class

    Friend Class ImageComboBoxNoneItem
        Inherits ImageComboBoxItem
        Public Sub New()
            Me.ImageIndex = -1
            Me.Description = "(none)"
        End Sub
    End Class
End Namespace
