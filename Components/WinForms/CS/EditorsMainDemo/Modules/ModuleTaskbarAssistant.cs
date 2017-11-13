using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Utils.Taskbar;
using DevExpress.Utils.Taskbar.Core;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

namespace DevExpress.XtraEditors.Demos {
    public partial class ModuleTaskbarAssistant : TutorialControl  {
        TaskbarAssistant taskbarAssistant;
        public ModuleTaskbarAssistant() {
            InitializeComponent();
            TutorialInfo.TutorialName = "TaskbarAssistant Tutorial";
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            CreateTaskbarAssistant();
            InitControls();
            UpdateControls();
            CreateThumbnailButtons();
        }
        void CreateThumbnailButtons() {
            for(int i = 0; i < TaskbarAssistant.MaxThumbnailButtonsCount; i++) {
                ThumbnailButton thumbButton = CreateThumbnailButton();
                TaskbarAssistant.ThumbnailButtons.Add(thumbButton);
            }
        }
        void CreateTaskbarAssistant() {
            this.taskbarAssistant = new TaskbarAssistant();
            TaskbarAssistant.ParentControl = ParentForm;
        }
        void InitControls() {
            var progressModes = Enum.GetValues(typeof(TaskbarButtonProgressMode));
            foreach(TaskbarButtonProgressMode progressMode in progressModes) {
                cbProgressMode.Properties.Items.Add(progressMode);
            }
            if(cbProgressMode.Properties.Items.Count > 0) {
                cbProgressMode.SelectedIndex = 0;
            }
            imgOverlayIcons.Properties.Items.Add(new ImageComboBoxNoneItem());
            for(int i = 0; i < imgCollection.Images.Count; i++) {
                string description = imgCollection.Images.Keys[i];
                imgOverlayIcons.Properties.Items.Add(new ImageComboBoxItem(description, i));
            }
            if(imgOverlayIcons.Properties.Items.Count > 0) {
                imgOverlayIcons.SelectedIndex = 0;
            }
        }
        // <btnAddThumbnailButton>
        void OnAddThumbnailButtonClick(object sender, EventArgs e) {
            foreach(ThumbnailButton button in TaskbarAssistant.ThumbnailButtons) {
                if(!button.Visible) {
                    button.Visible = true;
                    break;
                }
            }
            TaskbarAssistant.Refresh();
            UpdateControls();
        }
        // </btnAddThumbnailButton>
        // <btnRemoveThumbnailButton>
        void OnRemoveThumbnailButtonClick(object sender, EventArgs e) {
            for(int i = TaskbarAssistant.ThumbnailButtons.Count - 1; i >= 0; i--) {
                ThumbnailButton thumbButton = TaskbarAssistant.ThumbnailButtons[i];
                if(thumbButton.Visible) {
                    thumbButton.Visible = false;
                    break;
                }
            }
            TaskbarAssistant.Refresh();
            UpdateControls();
        }
        // </btnRemoveThumbnailButton>
        // <cbProgressMode>
        void OnProgressModeComboBoxEditSelectedValueChanged(object sender, EventArgs e) {
            ComboBoxEdit cb = (ComboBoxEdit)sender;
            taskbarAssistant.ProgressMode = (TaskbarButtonProgressMode)cb.EditValue;
        }
        // </cbProgressMode>
        // <trackBarProgressValue>
        void OnCurrentProgressValueTrackBarEditValueChanged(object sender, EventArgs e) {
            TrackBarControl trackBar = (TrackBarControl)sender;
            taskbarAssistant.ProgressCurrentValue = trackBar.Value;
        }
        // </trackBarProgressValue>
        // <imgOverlayIcons>
        void OnOverlayIconsComboBoxSelectedValueChanged(object sender, EventArgs e) {
            ImageComboBoxItem item = (ImageComboBoxItem)((ImageComboBoxEdit)sender).SelectedItem;
            Image img = item is ImageComboBoxNoneItem ? null : imgCollection.Images[item.ImageIndex];
            taskbarAssistant.OverlayIcon = (Bitmap)img;
        }
        // </imgOverlayIcons>
        // <btnAddItemToTasks>
        void OnAddItemToTasksButtonClick(object sender, EventArgs e) {
            string itemCaption = string.Format("Task #{0}", (taskbarAssistant.JumpListTasksCategory.Count + 1).ToString());
            JumpListItemTask taskItem = new JumpListItemTask(itemCaption);
            taskbarAssistant.JumpListTasksCategory.Add(taskItem);
            taskbarAssistant.Refresh();
            UpdateControls();
        }
        // </btnAddItemToTasks>
        // <btnRemoveItemFromTasks>
        void OnRemoveItemFromTasksButtonClick(object sender, EventArgs e) {
            int itemsCount = taskbarAssistant.JumpListTasksCategory.Count;
            if(itemsCount == 0)
                return;
            taskbarAssistant.JumpListTasksCategory.RemoveAt(itemsCount - 1);
            taskbarAssistant.Refresh();
            UpdateControls();
        }
        // </btnRemoveItemFromTasks>
        // <btnAddCustomCategory>
        void OnAddCustomCategoryButtonClick(object sender, EventArgs e) {
            string categoryName = string.Format("Custom Category #{0}", (TaskbarAssistant.JumpListCustomCategories.Count + 1).ToString());
            JumpListCategory customCategory = new JumpListCategory(categoryName);
            for(int i = 0; i < 2; i++) {
                string itemCaption = string.Format("Task #{0}", (i + 1).ToString());
                JumpListItemTask item = new JumpListItemTask(itemCaption);
                customCategory.JumpItems.Add(item);
            }
            TaskbarAssistant.JumpListCustomCategories.Add(customCategory);
            TaskbarAssistant.Refresh();
            UpdateControls();
        }
        // </btnAddCustomCategory>
        // <btnRemoveCustomCategory>
        void OnRemoveCustomCategoryButtonClick(object sender, EventArgs e) {
            int categoriesCount = TaskbarAssistant.JumpListCustomCategories.Count;
            if(categoriesCount == 0)
                return;
            TaskbarAssistant.JumpListCustomCategories.RemoveAt(categoriesCount - 1);
            TaskbarAssistant.Refresh();
            UpdateControls();
        }
        // </btnRemoveCustomCategory>
        Random rnd = new Random();
        ThumbnailButton CreateThumbnailButton() {
            ThumbnailButton res = new ThumbnailButton();
            if(imgCollection.Images.Count > 0) {
                res.Image = (Bitmap)imgCollection.Images[rnd.Next(0, imgCollection.Images.Count)];
            }
            res.Click += (s, ee) => {
                int thumbButtonPos = TaskbarAssistant.ThumbnailButtons.IndexOf(ee.ThumbButton) + 1;
                XtraMessageBox.Show(ParentForm, string.Format("ThumbnailButton # {0} clicked", thumbButtonPos.ToString()), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            };
            res.Visible = false;
            return res;
        }
        void UpdateControls() {
            btnAddThumbnailButton.Enabled = CalcVisibleThumbnailButtonsCount() < TaskbarAssistant.MaxThumbnailButtonsCount;
            btnRemoveThumbnailButton.Enabled = CalcVisibleThumbnailButtonsCount() > 0;
            btnRemoveCustomCategory.Enabled = TaskbarAssistant.JumpListCustomCategories.Count > 0;
            btnRemoveItemFromTasks.Enabled = TaskbarAssistant.JumpListTasksCategory.Count > 0;
        }
        int CalcVisibleThumbnailButtonsCount() {
            return TaskbarAssistant.ThumbnailButtons.Count(thumbButton => thumbButton.Visible);
        }
        TaskbarAssistant TaskbarAssistant { get { return taskbarAssistant; } }
    }

    internal class ImageComboBoxNoneItem : ImageComboBoxItem {
        public ImageComboBoxNoneItem() {
            this.ImageIndex = -1;
            this.Description = "(none)";
        }
    }
}
