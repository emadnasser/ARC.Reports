﻿Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Web
Imports DevExpress.BarCodes
Imports System.Text

Namespace DevExpress.Docs.Demos
	Public Class BarCodeGenerator
		Private Shared descriptionDictionary As New Dictionary(Of Symbology, String)()

		Shared Sub New()
			descriptionDictionary.Add(Symbology.Codabar, "Codabar was developed in 1972 by Pitney Bowes, Inc. It is a discrete, self-checking symbology that may encode 16 different characters, plus an additional 4 start/stop characters. This symbology is used by U.S. blood banks, photo labs, and on FedEx airbills.")
			descriptionDictionary.Add(Symbology.Code11, "Code 11, also known as USD-8, was developed as a high-density numeric-only symbology. It is used primarily in labeling telecommunications equipment. The symbology is discrete and is able to encode the numbers 0 through 9, the dash symbol (-), and start/stop characters.")
			descriptionDictionary.Add(Symbology.Code128, "Code 128 is a very effective, high-density symbology which permits the encoding of alphanumeric data. The symbology includes a checksum digit for verification, and the barcode may also be verified character-by-character verifying the parity of each data byte. This symbology has been widely implemented in many applications where a relatively large amount of data must be encoded in a relatively small amount of space. It's specific structure also allows numeric data to be encoded at, effectively, double-density.")
			descriptionDictionary.Add(Symbology.Code39, "Code 39, the first alpha-numeric symbology to be developed, is still widely used-especially in non-retail environments. It is the standard bar code used by the United States Department of Defense, and is also used by the Health Industry Bar Code Council (HIBCC). Code 39 is also known as ""3 of 9 Code"" and ""USD-3"".")
			descriptionDictionary.Add(Symbology.Code39Extended, "It is possible, using Code 39's ""Full ASCII Mode"" to encode all 128 ASCII characters. This is accomplished by using the $, /, %, and + symbols as ""shift"" characters. Those characters combined with the single character that follows indicate which Full ASCII character is to be used.")
			descriptionDictionary.Add(Symbology.Code93, "Code 93 was designed to complement and improve upon Code 39. Code 93 is similar in that it, like Code 39, can represent the full ASCII character set by using combinations of 2 characters. It differs in that Code 93 is a continuous symbology and produces denser code. It also encodes 47 characters compared to Code 39's 43 characters.")
			descriptionDictionary.Add(Symbology.Code93Extended, "It is possible, using Code 93's ""Full ASCII Mode"" to encode all 128 ASCII characters. This is accomplished by using the ($), (/), (%), and (+) symbols as ""shift"" characters. Those characters combined with the single character that follows indicate which Full ASCII character is to be used.")
			descriptionDictionary.Add(Symbology.CodeMSI, "MSI was developed by the MSI Data Corporation, based on the original Plessey Code. MSI, also known as Modified Plessey, is used primarily to mark retail shelves for inventory control. MSI is a continuous, non-self-checking symbology. While the length of an MSI barcode can be of any length, a given application usually implements a fixed-length code.")
			descriptionDictionary.Add(Symbology.DataMatrix, "Data Matrix code is a two-dimensional matrix barcode consisting of black and white ""cells"" arranged in a rectangular pattern. The information to be encoded can be text or raw data. Every Data Matrix is composed of two solid adjacent borders in an ""L"" shape (called the ""finder pattern"") and two other borders consisting of alternating dark and light ""cells"" or modules (called the ""timing pattern""). Within these borders are rows and columns of cells that encode information. The finder pattern is used to locate and orient the symbol while the timing pattern provides a count of the number of rows and columns in the symbol.")
			descriptionDictionary.Add(Symbology.DataMatrixGS1, "GS1 DataMatrix uses a special start combination to differentiate the GS1 DataMatrix symbol from the other Data Matrix ECC 200 symbols. This is achieved by using the Function 1 Symbol Character (FNC1) in the first position of the data encoded. It enables scanners to process the information according to the GS1 System Rules.")
			descriptionDictionary.Add(Symbology.EAN128, "UCC/EAN-128 was developed to provide a worldwide format and standard for exchanging common data between companies. While other barcodes simply encode data with no respect for what the data represents, UCC/EAN-128 encodes data and encodes what that data represents.")
			descriptionDictionary.Add(Symbology.EAN13, "EAN-13, based upon the UPC-A standard, was implemented by the International Article Numbering Association (EAN) in Europe.")
			descriptionDictionary.Add(Symbology.EAN8, "EAN-8 is the EAN equivalent of UPC-E in the sense that it provides a ""short"" barcode for small packages.")
			descriptionDictionary.Add(Symbology.Industrial2of5, "Standard 2 of 5 is a low-density numeric symbology that has been with us since the 1960s. It has been used in the photofinishing and warehouse sorting industries, as well as sequentially numbering airline tickets.")
			descriptionDictionary.Add(Symbology.IntelligentMail, "The Intelligent Mail Barcode (IM barcode) is a 65-bar code for use on mail in the United States. This barcode is intended to provide greater information and functionality than its predecessors POSTNET and PLANET. Intelligent Mail barcode has also been referred to as One Code Solution and 4-State Customer Barcode abbreviated 4CB, 4-CB or USPS4CB.")
			descriptionDictionary.Add(Symbology.Interleaved2of5, "Interleaved 2 of 5 is a higher-density numeric symbology based upon the Standard 2 of 5 symbology. It is used primarily in the distribution and warehouse industry.")
			descriptionDictionary.Add(Symbology.Matrix2of5, "Matrix 2 of 5 is a linear 1D barcode. Matrix 2 of 5 is self-checking numeric-only barcode. Unlike Interleaved 2 of 5, all of the information is encoded in the bars; the spaces are of fixed width and used only to separate the bars. Matrix 2 of 5 is used primarily for warehouse sorting, photo finishing, and airline ticket marking.")
			descriptionDictionary.Add(Symbology.PDF417, "PDF417 (Portable Data File) is a stacked linear two-dimensional barcode used in a variety of applications: primarily transport, postal, identification card and inventory management. It was invented by Ynjiun Wang at Symbol Technologies in 1991, and has spawned an Open Source decoder project together with an Open Source encoder. The PDF417 barcode is also called a symbol barcode and usually consists of 3 to 90 rows, each of which is like a small linear bar code.")
			descriptionDictionary.Add(Symbology.PostNet, "POSTNET (Postal Numeric Encoding Technique) is a barcode symbology used by the United States Postal Service to assist in directing mail. The ZIP Code or ZIP+4 code is encoded in half- and full-height bars. Most often, the delivery point is added, usually being the last two digits of the address or PO box number.")
			descriptionDictionary.Add(Symbology.QRCode, "QR (Quick Response) code is a popular two-dimensional matrix barcode that consists of black modules arranged in a square pattern on the white background. The information encoded may be text, URL or other data. This barcode type has a wide area of application including both commercial tracking applications and convenience-oriented applications aimed at mobile phone users.")
			descriptionDictionary.Add(Symbology.UPCA, "The ""UPC-A barcode"" is by far the most common and well-known symbology, at least in the United States. An UPC-A barcode is the barcode you will find on virtually every consumer good on the shelves of your local supermarket, as well as books, magazines, and newspapers. It is commonly called simply a ""UPC barcode"" or ""UPC Symbol.""")
			descriptionDictionary.Add(Symbology.UPCE0, "UPC-E is a variation of UPC-A which allows for a more compact barcode by eliminating ""extra"" zeros. Since the resulting UPC-E barcode is about half the size as an UPC-A barcode, UPC-E is generally used on products with very small packaging where a full UPC-A barcode couldn't reasonably fit.")
			descriptionDictionary.Add(Symbology.UPCE1, "UPC-E is a variation of UPC-A which allows for a more compact barcode by eliminating ""extra"" zeros. Since the resulting UPC-E barcode is about half the size as an UPC-A barcode, UPC-E is generally used on products with very small packaging where a full UPC-A barcode couldn't reasonably fit.")
			descriptionDictionary.Add(Symbology.UPCSupplemental2, "2-digit supplemental barcodes should only be used with magazines, newspapers and other such periodicals. The 2-digit supplement represent the issue number of the magazine. This is useful so that the product code itself (contained in the main barcode) is constant for the magazine such that each issue of the magazine doesn't have to have its own unique barcode. Nevertheless, the 2-digit supplement can be used to track which issue of the magazine is being sold, perhaps for sales analysis or restocking purposes.")
			descriptionDictionary.Add(Symbology.UPCSupplemental5, "5-digit supplemental barcodes are used on books to indicate a suggested retail price.")
		End Sub

		Public Shared Function GetBarCodeDescription(ByVal symbology As Symbology) As String
			If (Not descriptionDictionary.ContainsKey(symbology)) Then
				Return Nothing
			End If
			Return descriptionDictionary(symbology)
		End Function

		Private barCode As BarCode
		Private viewText_Renamed As Boolean
		Private barCodeText As String

		Public Sub New(ByVal symbology As Symbology, ByVal barCodeText As String)
			Me.barCode = New BarCode()
			Me.barCode.Symbology = symbology
			Me.barCodeText = barCodeText
		End Sub
		Public Property ViewText() As Boolean
			Get
				Return viewText_Renamed
			End Get
			Set(ByVal value As Boolean)
				viewText_Renamed = value
			End Set
		End Property
		Public ReadOnly Property Description() As String
			Get
				Return GetBarCodeDescription(Me.barCode.Symbology)
			End Get
		End Property

		Public Function Generate() As BarCode
			Select Case barCode.Symbology
				Case Symbology.Codabar
					InitializeCodabarBarCode()
				Case Symbology.Code11
					InitializeCode11BarCode()
				Case Symbology.Code128
					InitializeCode128BarCode()
				Case Symbology.Code39
					InitializeCode39BarCode()
				Case Symbology.Code39Extended
					InitializeCode39ExtendedBarCode()
				Case Symbology.Code93
					InitializeCode93BarCode()
				Case Symbology.Code93Extended
					InitializeCode93ExtendedBarCode()
				Case Symbology.CodeMSI
					InitializeCodeMSIBarCode()
				Case Symbology.DataMatrix
					InitializeDataMatrixBarCode()
				Case Symbology.DataMatrixGS1
					InitializeDataMatrixGS1BarCode()
				Case Symbology.EAN128
					InitializeEAN128BarCode()
				Case Symbology.EAN13
					InitializeEAN13BarCode()
				Case Symbology.EAN8
					InitializeEAN8BarCode()
				Case Symbology.Industrial2of5
					InitializeIndustrial2of5BarCode()
				Case Symbology.IntelligentMail
					InitializeIntelligentMailBarCode()
				Case Symbology.Interleaved2of5
					InitializeInterleaved2of5BarCode()
				Case Symbology.Matrix2of5
					InitializeMatrix2of5BarCode()
				Case Symbology.PDF417
					InitializePDF417BarCode()
				Case Symbology.PostNet
					InitializePostNetBarCode()
				Case Symbology.QRCode
					InitializeQRCodeBarCode()
				Case Symbology.UPCA
					InitializeUPCABarCode()
				Case Symbology.UPCE0
					InitializeUPCE0BarCode()
				Case Symbology.UPCE1
					InitializeUPCE1BarCode()
				Case Symbology.UPCSupplemental2
					InitializeUPCSupplemental2BarCode()
				Case Symbology.UPCSupplemental5
					InitializeUPCSupplemental5BarCode()
			End Select
			Return barCode
		End Function
		Private Sub InitializeCodabarBarCode()
			InitializeBarcodeText("0123456789+-/:.$")
			barCode.Options.Codabar.ShowCodeText = viewText_Renamed
		End Sub
		Private Sub InitializeCode11BarCode()
			InitializeBarcodeText("0123456")
			barCode.Options.Code11.ShowCodeText = viewText_Renamed
		End Sub
		Private Sub InitializeCode128BarCode()
			InitializeBarcodeText("BarCode 0123456")
			barCode.Options.Code128.ShowCodeText = viewText_Renamed
		End Sub
		Private Sub InitializeCode39BarCode()
			InitializeBarcodeText("BARCODE")
			barCode.Options.Code39.ShowCodeText = viewText_Renamed
		End Sub
		Private Sub InitializeCode39ExtendedBarCode()
			InitializeBarcodeText("BarCODE")
			barCode.Options.Code39Extended.ShowCodeText = viewText_Renamed
		End Sub
		Private Sub InitializeCode93BarCode()
			InitializeBarcodeText("BARCODE")
			barCode.Options.Code93.ShowCodeText = viewText_Renamed
		End Sub
		Private Sub InitializeCode93ExtendedBarCode()
			InitializeBarcodeText("BarCode")
			barCode.Options.Code93Extended.ShowCodeText = viewText_Renamed
		End Sub
		Private Sub InitializeCodeMSIBarCode()
			InitializeBarcodeText("0123456789")
			barCode.Options.CodeMSI.ShowCodeText = viewText_Renamed
		End Sub
		Private Sub InitializeDataMatrixBarCode()
			InitializeBarcodeText("http:\\www.devexpress.com")
			barCode.Options.DataMatrix.ShowCodeText = viewText_Renamed
		End Sub
		Private Sub InitializeDataMatrixGS1BarCode()
			barCode.Options.DataMatrixGS1.ShowCodeText = viewText_Renamed
			InitializeBarcodeText("010031234567890621123456789012#300144")
		End Sub
		Private Sub InitializeEAN128BarCode()
			InitializeBarcodeText("BarCode 0123456")
			barCode.Options.EAN128.ShowCodeText = viewText_Renamed
		End Sub
		Private Sub InitializeEAN13BarCode()
			InitializeBarcodeText("978531800111")
			barCode.Options.EAN13.ShowCodeText = viewText_Renamed
		End Sub
		Private Sub InitializeEAN8BarCode()
			InitializeBarcodeText("0123456")
			barCode.Options.EAN8.ShowCodeText = viewText_Renamed
		End Sub
		Private Sub InitializeIndustrial2of5BarCode()
			InitializeBarcodeText("0123456789")
			barCode.Options.Industrial2of5.ShowCodeText = viewText_Renamed
		End Sub
		Private Sub InitializeIntelligentMailBarCode()
			InitializeBarcodeText("4408200000012345678991203")
			barCode.Options.IntelligentMail.ShowCodeText = viewText_Renamed
		End Sub
		Private Sub InitializeInterleaved2of5BarCode()
			InitializeBarcodeText("0123456789")
			barCode.Options.Interleaved2of5.ShowCodeText = viewText_Renamed
		End Sub
		Private Sub InitializeMatrix2of5BarCode()
			InitializeBarcodeText("0123456789")
			barCode.Options.Matrix2of5.ShowCodeText = viewText_Renamed
		End Sub
		Private Sub InitializePDF417BarCode()
			InitializeBarcodeText("http:\\www.devexpress.com")
			barCode.Options.PDF417.ShowCodeText = viewText_Renamed
		End Sub
		Private Sub InitializePostNetBarCode()
			InitializeBarcodeText("300001")
			barCode.Options.PostNet.ShowCodeText = viewText_Renamed
		End Sub
		Private Sub InitializeQRCodeBarCode()
			InitializeBarcodeText("http:\\www.devexpress.com")
			barCode.CodeBinaryData = Encoding.Default.GetBytes(barCode.CodeText)
			barCode.Options.QRCode.CompactionMode = QRCodeCompactionMode.Byte
			barCode.Options.QRCode.ErrorLevel = QRCodeErrorLevel.Q
			barCode.Options.QRCode.ShowCodeText = viewText_Renamed
		End Sub
		Private Sub InitializeUPCABarCode()
			InitializeBarcodeText("78534235463")
			barCode.Options.UPCA.ShowCodeText = viewText_Renamed
		End Sub
		Private Sub InitializeUPCE0BarCode()
			InitializeBarcodeText("4210000526")
			barCode.Options.UPCE0.ShowCodeText = viewText_Renamed
		End Sub
		Private Sub InitializeUPCE1BarCode()
			InitializeBarcodeText("4210000526")
			barCode.Options.UPCE1.ShowCodeText = viewText_Renamed
		End Sub
		Private Sub InitializeUPCSupplemental2BarCode()
			InitializeBarcodeText("12")
			barCode.Options.UPCSupplemental2.ShowCodeText = viewText_Renamed
		End Sub
		Private Sub InitializeUPCSupplemental5BarCode()
			InitializeBarcodeText("12345")
			barCode.Options.UPCSupplemental5.ShowCodeText = viewText_Renamed
		End Sub
		Private Sub InitializeBarcodeText(ByVal text As String)
			barCode.CodeText = If(String.IsNullOrEmpty(barCodeText), text, barCodeText)
		End Sub
	End Class
End Namespace