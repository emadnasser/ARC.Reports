using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using DevExpress.Persistent.Base;

namespace EFDemo.Module.Data {
	[ImageName("BO_FileAttachment")]
	[MetadataType(typeof(PortfolioFileDataMetadata))]
	public partial class PortfolioFileData {
		public PortfolioFileData()
			: base() {
			DocumentType = DocumentType.Unknown;
		}
		public DocumentType DocumentType {
			get { return (DocumentType)DocumentType_Int; }
			set { DocumentType_Int = (Int32)value; }
		}
	}

	public class PortfolioFileDataMetadata {
	}
}
