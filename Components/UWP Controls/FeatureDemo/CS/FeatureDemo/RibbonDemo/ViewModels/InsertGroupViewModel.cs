using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using DevExpress.Mvvm;
using Windows.UI;
using Windows.UI.Text;
using Windows.UI.Xaml.Media;
using DevExpress.Core;
using Windows.UI.Xaml;
using DevExpress.UI.Xaml.Ribbon;
using System.IO;
using Windows.Storage;
using Windows.Storage.Streams;
using DevExpress.Mvvm.Native;
using Windows.Storage.Pickers;
using DevExpress.Mvvm.UI;

namespace RibbonDemo {
    public class InsertGroupViewModel : ViewModelBase {
        public ICommand InsertImageCommand { get; private set; }
        public IRichEditorInsertService RichEditorService { get { return GetService<IRichEditorInsertService>(); } }

        public InsertGroupViewModel() {
            InsertImageCommand = new DelegateCommand(OnInsertImage);
        }
        public InsertGroupViewModel(RibbonViewModel parent) : this() {
            ((ISupportParentViewModel)this).ParentViewModel = parent;
        }

        async void OnInsertImage() {
            FileOpenPicker filePicker = new FileOpenPicker();
            string[] fileExts = { ".jpeg", ".jpg", ".png", ".bmp", ".gif" };
            foreach(string ext in fileExts) {
                filePicker.FileTypeFilter.Add(ext);
            }
            filePicker.ViewMode = PickerViewMode.Thumbnail;
            filePicker.SuggestedStartLocation = PickerLocationId.PicturesLibrary;
            filePicker.SettingsIdentifier = "ImageFilePicker";
            filePicker.CommitButtonText = "Insert";

            StorageFile file = await filePicker.PickSingleFileAsync();
            if(null != file) {
                IRandomAccessStream fileStream = await file.OpenAsync(FileAccessMode.Read);
                RichEditorService.Do(x => x.InsertImage(fileStream as FileRandomAccessStream));
            }
        }
    }
}
