using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.DXperience.Demos;
using DevExpress.BarCodes;

namespace DevExpress.Docs.Demos {
    public partial class BarCodeVisualization : TutorialControlBase
    {
        public BarCodeVisualization()
        {
            InitializeComponent();
            this.barCode = new BarCode();
            InitializeComboBoxes();
        }
        void editValueChanged(object sender, EventArgs e)
        {
            RefreshBarcodePicture();
        }

        void InitializeComboBoxes()
        {
            foreach (Symbology symbology in Enum.GetValues(typeof(Symbology)))
                symbologySelectCB.Properties.Items.Add(symbology);
            foreach (StringAlignment alignment in Enum.GetValues(typeof(StringAlignment))) {
                topCaptionAligmentCB.Properties.Items.Add(alignment);
                bottomCaptionAligmentCB.Properties.Items.Add(alignment);
                codeTextHorzAlignmentCB.Properties.Items.Add(alignment);
                codeTextVertAlignmentCB.Properties.Items.Add(alignment);
            }
            ((System.ComponentModel.ISupportInitialize)(this.topCaptionAligmentCB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomCaptionAligmentCB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeTextHorzAlignmentCB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeTextVertAlignmentCB.Properties)).BeginInit();
            topCaptionAligmentCB.SelectedIndex = 1;
            bottomCaptionAligmentCB.SelectedIndex = 1;
            codeTextHorzAlignmentCB.SelectedIndex = 1;
            codeTextVertAlignmentCB.SelectedIndex = 1;
            ((System.ComponentModel.ISupportInitialize)(this.topCaptionAligmentCB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomCaptionAligmentCB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeTextHorzAlignmentCB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeTextVertAlignmentCB.Properties)).EndInit();

            symbologySelectCB.SelectedIndex = 0;
        }

        #region RefreshBarcodePicture

        void RefreshBarcodePicture()
        {
            pictureEdit.Image = null;
            InitializeBarCode();
            try
            {
                errorText.Visible = false;
                pictureEdit.Image = barCode.BarCodeImage;
            }
            catch
            {
                //DevExpress.XtraEditors.XtraMessageBox.Show("BarCode text contains invalid symbol(s)");
                errorText.Visible = true;
            }
            pictureEdit.Refresh();
        }

        void InitializeBarCode() {
            if(barCode == null)
                return;
            barCode.Symbology = (Symbology)symbologySelectCB.SelectedItem;
            barCode.BackColor = backColorE.Color;
            barCode.ForeColor = foreColorE.Color;
            barCode.RotationAngle = (float)angleSE.Value;
            if(codeTextFE.SelectedItem != null)
                barCode.CodeTextFont = new Font((string)codeTextFE.SelectedItem, barCode.CodeTextFont.Size);
            barCode.CodeTextHorizontalAlignment = (StringAlignment)codeTextHorzAlignmentCB.SelectedItem;
            barCode.CodeTextVerticalAlignment = (StringAlignment)codeTextVertAlignmentCB.SelectedItem;

            barCode.TopCaption.Text = topCaptionCE.Checked ? topCaptionTE.Text : string.Empty;
            barCode.TopCaption.HorizontalAlignment = (StringAlignment)topCaptionAligmentCB.SelectedItem;
            barCode.TopCaption.ForeColor = topCaptionForeCE.Color;
            if(topCaptionFE.SelectedItem != null)
                barCode.TopCaption.Font = new Font((string)topCaptionFE.SelectedItem, barCode.TopCaption.Font.Size);

            barCode.BottomCaption.Text = bottomCaptionCE.Checked ? bottomCaptionTE.Text: string.Empty;
            barCode.BottomCaption.HorizontalAlignment = (StringAlignment)bottomCaptionAligmentCB.SelectedItem;
            barCode.BottomCaption.ForeColor = bottomCaptionForeCE.Color;
            if (bottomCaptionFE.SelectedItem != null)
                barCode.BottomCaption.Font = new Font((string)bottomCaptionFE.SelectedItem, barCode.BottomCaption.Font.Size);


            switch (barCode.Symbology) {
                case Symbology.Codabar: InitializeCodabarBarCode(); break;
                case Symbology.Code11: InitializeCode11BarCode(); break;
                case Symbology.Code128: InitializeCode128BarCode(); break;
                case Symbology.Code39: InitializeCode39BarCode(); break;
                case Symbology.Code39Extended: InitializeCode39ExtendedBarCode(); break;
                case Symbology.Code93: InitializeCode93BarCode(); break;
                case Symbology.Code93Extended: InitializeCode93ExtendedBarCode(); break;
                case Symbology.CodeMSI: InitializeCodeMSIBarCode(); break;
                case Symbology.DataMatrix: InitializeDataMatrixBarCode(); break;
                case Symbology.DataMatrixGS1: InitializeDataMatrixGS1BarCode(); break;
                case Symbology.EAN128: InitializeEAN128BarCode(); break;
                case Symbology.EAN13: InitializeEAN13BarCode(); break;
                case Symbology.EAN8: InitializeEAN8BarCode(); break;
                case Symbology.Industrial2of5: InitializeIndustrial2of5BarCode(); break;
                case Symbology.IntelligentMail: InitializeIntelligentMailBarCode(); break;
                case Symbology.Interleaved2of5: InitializeInterleaved2of5BarCode(); break;
                case Symbology.Matrix2of5: InitializeMatrix2of5BarCode(); break;
                case Symbology.PDF417: InitializePDF417BarCode(); break;
                case Symbology.PostNet: InitializePostNetBarCode(); break;
                case Symbology.QRCode: InitializeQRCodeBarCode(); break;
                case Symbology.UPCA: InitializeUPCABarCode(); break;
                case Symbology.UPCE0: InitializeUPCE0BarCode(); break;
                case Symbology.UPCE1: InitializeUPCE1BarCode(); break;
                case Symbology.UPCSupplemental2: InitializeUPCSupplemental2BarCode(); break;
                case Symbology.UPCSupplemental5: InitializeUPCSupplemental5BarCode(); break;
                case Symbology.DataBar: InitializeDataBarBarCode(); break;
                case Symbology.ITF14: InitializeITF14BarCode(); break;
            }
        }

        void InitializeCodabarBarCode()
        {
            descriptionME.Text = "Codabar was developed in 1972 by Pitney Bowes, Inc. It is a discrete, self-checking symbology that may encode 16 different characters, plus an additional 4 start/stop characters. This symbology is used by U.S. blood banks, photo labs, and on FedEx airbills.";
            InitializeBarcodeText("0123456789+-/:.$");
            barCode.Options.Codabar.ShowCodeText = showTextCE.Checked;
        }
        void InitializeCode11BarCode()
        {
            descriptionME.Text = "Code 11, also known as USD-8, was developed as a high-density numeric-only symbology. It is used primarily in labeling telecommunications equipment. The symbology is discrete and is able to encode the numbers 0 through 9, the dash symbol (-), and start/stop characters.";
            InitializeBarcodeText("0123456");
            barCode.Options.Code11.ShowCodeText = showTextCE.Checked;
        }
        void InitializeCode128BarCode()
        {
            descriptionME.Text = "Code 128 is a very effective, high-density symbology which permits the encoding of alphanumeric data. The symbology includes a checksum digit for verification, and the barcode may also be verified character-by-character verifying the parity of each data byte. This symbology has been widely implemented in many applications where a relatively large amount of data must be encoded in a relatively small amount of space. It's specific structure also allows numeric data to be encoded at, effectively, double-density.";
            InitializeBarcodeText("BarCode 0123456");
            barCode.Options.Code128.ShowCodeText = showTextCE.Checked;
        }
        void InitializeCode39BarCode()
        {
            descriptionME.Text = @"Code 39, the first alpha-numeric symbology to be developed, is still widely used-especially in non-retail environments. It is the standard bar code used by the United States Department of Defense, and is also used by the Health Industry Bar Code Council (HIBCC). Code 39 is also known as ""3 of 9 Code"" and ""USD-3"".";
            InitializeBarcodeText("BARCODE");
            barCode.Options.Code39.ShowCodeText = showTextCE.Checked;
        }
        void InitializeCode39ExtendedBarCode()
        {
            descriptionME.Text = @"It is possible, using Code 39's ""Full ASCII Mode"" to encode all 128 ASCII characters. This is accomplished by using the $, /, %, and + symbols as ""shift"" characters. Those characters combined with the single character that follows indicate which Full ASCII character is to be used.";
            InitializeBarcodeText("BarCODE");
            barCode.Options.Code39Extended.ShowCodeText = showTextCE.Checked;
        }
        void InitializeCode93BarCode()
        {
            descriptionME.Text = "Code 93 was designed to complement and improve upon Code 39. Code 93 is similar in that it, like Code 39, can represent the full ASCII character set by using combinations of 2 characters. It differs in that Code 93 is a continuous symbology and produces denser code. It also encodes 47 characters compared to Code 39's 43 characters.";
            InitializeBarcodeText("BARCODE");
            barCode.Options.Code93.ShowCodeText = showTextCE.Checked;
        }
        void InitializeCode93ExtendedBarCode()
        {
            descriptionME.Text = @"It is possible, using Code 93's ""Full ASCII Mode"" to encode all 128 ASCII characters. This is accomplished by using the ($), (/), (%), and (+) symbols as ""shift"" characters. Those characters combined with the single character that follows indicate which Full ASCII character is to be used.";
            InitializeBarcodeText("BarCode");
            barCode.Options.Code93Extended.ShowCodeText = showTextCE.Checked;
        }
        void InitializeCodeMSIBarCode()
        {
            descriptionME.Text = "MSI was developed by the MSI Data Corporation, based on the original Plessey Code. MSI, also known as Modified Plessey, is used primarily to mark retail shelves for inventory control. MSI is a continuous, non-self-checking symbology. While the length of an MSI barcode can be of any length, a given application usually implements a fixed-length code.";
            InitializeBarcodeText("0123456789");
            barCode.Options.CodeMSI.ShowCodeText = showTextCE.Checked;
        }
        void InitializeDataMatrixBarCode()
        {
            InitializeBarcodeText(@"http:\\www.devexpress.com");
            descriptionME.Text = @"Data Matrix code is a two-dimensional matrix barcode consisting of black and white ""cells"" arranged in a rectangular pattern. The information to be encoded can be text or raw data. Every Data Matrix is composed of two solid adjacent borders in an ""L"" shape (called the ""finder pattern"") and two other borders consisting of alternating dark and light ""cells"" or modules (called the ""timing pattern""). Within these borders are rows and columns of cells that encode information. The finder pattern is used to locate and orient the symbol while the timing pattern provides a count of the number of rows and columns in the symbol.";
            barCode.Options.DataMatrix.ShowCodeText = showTextCE.Checked;
        }
        void InitializeDataMatrixGS1BarCode()
        {
            barCode.Options.DataMatrixGS1.ShowCodeText = showTextCE.Checked;
            InitializeBarcodeText("010031234567890621123456789012#300144");
            descriptionME.Text = "GS1 DataMatrix uses a special start combination to differentiate the GS1 DataMatrix symbol from the other Data Matrix ECC 200 symbols. This is achieved by using the Function 1 Symbol Character (FNC1) in the first position of the data encoded. It enables scanners to process the information according to the GS1 System Rules.";
        }
        void InitializeEAN128BarCode()
        {
            descriptionME.Text = "UCC/EAN-128 was developed to provide a worldwide format and standard for exchanging common data between companies. While other barcodes simply encode data with no respect for what the data represents, UCC/EAN-128 encodes data and encodes what that data represents.";
            InitializeBarcodeText("BarCode 0123456");
            barCode.Options.EAN128.ShowCodeText = showTextCE.Checked;
        }
        void InitializeEAN13BarCode()
        {
            descriptionME.Text = "EAN-13, based upon the UPC-A standard, was implemented by the International Article Numbering Association (EAN) in Europe.";
            InitializeBarcodeText("978531800111");
            barCode.Options.EAN13.ShowCodeText = showTextCE.Checked;
        }
        void InitializeEAN8BarCode()
        {
            descriptionME.Text = @"EAN-8 is the EAN equivalent of UPC-E in the sense that it provides a ""short"" barcode for small packages.";
            InitializeBarcodeText("0123456");
            barCode.Options.EAN8.ShowCodeText = showTextCE.Checked;
        }
        void InitializeIndustrial2of5BarCode()
        {
            descriptionME.Text = "Standard 2 of 5 is a low-density numeric symbology that has been with us since the 1960s. It has been used in the photofinishing and warehouse sorting industries, as well as sequentially numbering airline tickets.";
            InitializeBarcodeText("0123456789");
            barCode.Options.Industrial2of5.ShowCodeText = showTextCE.Checked;
        }
        void InitializeIntelligentMailBarCode()
        {
            descriptionME.Text = "The Intelligent Mail Barcode (IM barcode) is a 65-bar code for use on mail in the United States. This barcode is intended to provide greater information and functionality than its predecessors POSTNET and PLANET. Intelligent Mail barcode has also been referred to as One Code Solution and 4-State Customer Barcode abbreviated 4CB, 4-CB or USPS4CB.";
            InitializeBarcodeText("4408200000012345678991203");
            barCode.Options.IntelligentMail.ShowCodeText = showTextCE.Checked;
        }
        void InitializeInterleaved2of5BarCode()
        {
            descriptionME.Text = "Interleaved 2 of 5 is a higher-density numeric symbology based upon the Standard 2 of 5 symbology. It is used primarily in the distribution and warehouse industry.";
            InitializeBarcodeText("0123456789");
            barCode.Options.Interleaved2of5.ShowCodeText = showTextCE.Checked;
        }
        void InitializeMatrix2of5BarCode()
        {
            descriptionME.Text = "Matrix 2 of 5 is a linear 1D barcode. Matrix 2 of 5 is self-checking numeric-only barcode. Unlike Interleaved 2 of 5, all of the information is encoded in the bars; the spaces are of fixed width and used only to separate the bars. Matrix 2 of 5 is used primarily for warehouse sorting, photo finishing, and airline ticket marking.";
            InitializeBarcodeText("0123456789");
            barCode.Options.Matrix2of5.ShowCodeText = showTextCE.Checked;
        }
        void InitializePDF417BarCode() {
            InitializeBarcodeText(@"http:\\www.devexpress.com");
            this.descriptionME.Text = "PDF417 (Portable Data File) is a stacked linear two-dimensional barcode used in a variety of applications: primarily transport, postal, identification card and inventory management. It was invented by Ynjiun Wang at Symbol Technologies in 1991, and has spawned an Open Source decoder project together with an Open Source encoder. The PDF417 barcode is also called a symbol barcode and usually consists of 3 to 90 rows, each of which is like a small linear bar code.";
            barCode.Options.PDF417.ShowCodeText = showTextCE.Checked;
        }
        void InitializePostNetBarCode()
        {
            descriptionME.Text = "POSTNET (Postal Numeric Encoding Technique) is a barcode symbology used by the United States Postal Service to assist in directing mail. The ZIP Code or ZIP+4 code is encoded in half- and full-height bars. Most often, the delivery point is added, usually being the last two digits of the address or PO box number.";
            InitializeBarcodeText("300001");
            barCode.Options.PostNet.ShowCodeText = showTextCE.Checked;
        }
        void InitializeQRCodeBarCode()
        {
            descriptionME.Text = "QR (Quick Response) code is a popular two-dimensional matrix barcode that consists of black modules arranged in a square pattern on the white background. The information encoded may be text, URL or other data. This barcode type has a wide area of application including both commercial tracking applications and convenience-oriented applications aimed at mobile phone users.";
            InitializeBarcodeText(@"http:\\www.devexpress.com");
            barCode.CodeBinaryData = Encoding.Default.GetBytes(barCode.CodeText);
            barCode.Options.QRCode.CompactionMode = QRCodeCompactionMode.Byte;
            barCode.Options.QRCode.ErrorLevel = QRCodeErrorLevel.Q;
            barCode.Options.QRCode.ShowCodeText = showTextCE.Checked;
        }
        void InitializeUPCABarCode()
        {
            descriptionME.Text = @"The ""UPC-A barcode"" is by far the most common and well-known symbology, at least in the United States. An UPC-A barcode is the barcode you will find on virtually every consumer good on the shelves of your local supermarket, as well as books, magazines, and newspapers. It is commonly called simply a ""UPC barcode"" or ""UPC Symbol.""";
            InitializeBarcodeText("78534235463");
            barCode.Options.UPCA.ShowCodeText = showTextCE.Checked;
        }
        void InitializeUPCE0BarCode()
        {
            descriptionME.Text = @"UPC-E is a variation of UPC-A which allows for a more compact barcode by eliminating ""extra"" zeros. Since the resulting UPC-E barcode is about half the size as an UPC-A barcode, UPC-E is generally used on products with very small packaging where a full UPC-A barcode couldn't reasonably fit.";
            InitializeBarcodeText("4210000526");
            barCode.Options.UPCE0.ShowCodeText = showTextCE.Checked;
        }
        void InitializeUPCE1BarCode()
        {
            descriptionME.Text = @"UPC-E is a variation of UPC-A which allows for a more compact barcode by eliminating ""extra"" zeros. Since the resulting UPC-E barcode is about half the size as an UPC-A barcode, UPC-E is generally used on products with very small packaging where a full UPC-A barcode couldn't reasonably fit.";
            InitializeBarcodeText("4210000526");
            barCode.Options.UPCE1.ShowCodeText = showTextCE.Checked;
        }
        void InitializeUPCSupplemental2BarCode()
        {
            descriptionME.Text = "2-digit supplemental barcodes should only be used with magazines, newspapers and other such periodicals. The 2-digit supplement represent the issue number of the magazine. This is useful so that the product code itself (contained in the main barcode) is constant for the magazine such that each issue of the magazine doesn't have to have its own unique barcode. Nevertheless, the 2-digit supplement can be used to track which issue of the magazine is being sold, perhaps for sales analysis or restocking purposes.";
            InitializeBarcodeText("12");
            barCode.Options.UPCSupplemental2.ShowCodeText = showTextCE.Checked;
        }
        void InitializeUPCSupplemental5BarCode()
        {
            descriptionME.Text = "5-digit supplemental barcodes are used on books to indicate a suggested retail price.";
            InitializeBarcodeText("12345");
            barCode.Options.UPCSupplemental5.ShowCodeText = showTextCE.Checked;
        }
        void InitializeDataBarBarCode() {
            descriptionME.Text = "GS1 DataBar bar code is based on a family of symbols most commonly seen in the GS1 DataBar Coupon.\r\nIn addition to encoding Application Identifier (01) GTIN, GS1 DataBar Expanded and GS1 DataBar Expanded Stacked can encode additional GS1 Application Identifiers (such as sell-by date, weight, and lot number). Each symbol has a capacity of up to 74 characters. These attributes can help in controlling shrinkage, optimizing product replenishment, and improving the traceability of a product at the point of sale.\r\nThis demo illustrates the Expanded Stacked variant of the GS1 DataBar bar code.";
            InitializeBarcodeText("01906141410000153202000150");
            barCode.Options.DataBar.ShowCodeText = showTextCE.Checked;
            barCode.Options.DataBar.Type = DataBarType.ExpandedStacked;
            barCode.Options.DataBar.FNC1Substitute = "#";
            barCode.Options.DataBar.SegmentsInRow = 4;
        }
        void InitializeITF14BarCode() {
            descriptionME.Text = "This bar code is used to mark packaging materials that contain products labeled with a UPC or EAN product identification number. This bar code provides a GS1 implementation of an Interleaved 2 of 5 bar code for encoding a Global Trade Item Number (an identifier for trade items developed by GS1).\r\nThis bar code always uses a total of 14 digits. The thick black border around the symbol (the Bearer Bar) is intended to enhance the bar code reading reliability.";
            InitializeBarcodeText("1234567890123");
            barCode.Options.ITF14.ShowCodeText = showTextCE.Checked;
        }
        void InitializeBarcodeText(string text)
        {
            barCode.CodeText = string.IsNullOrEmpty(barCodeText.Text) ? text : barCodeText.Text;
        }
        #endregion
    }
}
