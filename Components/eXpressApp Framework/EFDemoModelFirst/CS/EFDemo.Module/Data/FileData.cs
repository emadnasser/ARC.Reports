using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.IO;
using System.ComponentModel.DataAnnotations;

using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;

namespace EFDemo.Module.Data {
    [DefaultProperty("FileName")]
    [MetadataType(typeof(FileDataMetadata))]
    public partial class FileData : IFileData, IEmptyCheckable {
        partial void OnContentChanged() {
            if(Content != null) {
                Size = Content.Length;
            }
            else {
                Size = 0;
            }
        }

        [Browsable(false)]
        public Boolean IsEmpty {
            get { return String.IsNullOrEmpty(FileName); }
        }
        public void LoadFromStream(String fileName, Stream stream) {
            FileName = fileName;
            Byte[] bytes = new Byte[stream.Length];
            stream.Read(bytes, 0, bytes.Length);
            Content = bytes;
        }
        public void SaveToStream(Stream stream) {
            if(String.IsNullOrEmpty(FileName)) {
                throw new InvalidOperationException();
            }
            stream.Write(Content, 0, Size);
            stream.Flush();
        }
        public void Clear() {
            Content = null;
            FileName = "";
        }
        public override String ToString() {
            return FileName;
        }
    }

    public class FileDataMetadata {
        [Browsable(false)]
        public Int32 ID { get; set; }
    }
}
