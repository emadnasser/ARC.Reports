Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Drawing
Imports DevExpress.BarCodes
Imports System.Net
Imports DevExpress.Docs.Demos
Imports System.Drawing.Imaging

Partial Public Class BarCode_BarCodeVisualization
	Inherits System.Web.UI.Page
	Private FontFamilyNames() As String = { "Arial", "Arial Black", "Comic Sans MS", "Courier New", "Georgia", "Lucida Sans Unicode", "Times New Roman", "Trebuchet MS", "Verdana", "MS Mincho", "MS PMincho", "SimSun", "SimSun-ExtB", "Calibri" }

	Private barCode As BarCode

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) AndAlso Request.QueryString.Count = 0 Then
			GenerateContent()
		End If

		If Request.QueryString.Count < 1 Then
			Return
		End If
		If Request.QueryString(0).StartsWith("description") Then
			GenerateBarCodeDescription()
			Return
		End If
		If (Not Request.QueryString(0).StartsWith("image")) Then
			Return
		End If

		If Request.QueryString.Count > 1 Then
			Dim barCodeParams As BarCodeParams = FillBarCodeParams()
			UpdateBarCodeState(barCodeParams)
		End If

		Dim converter As New ImageConverter()
		Dim image() As Byte = Nothing
		If Session("BarCodeImage") Is Nothing Then
			Dim emptyImage As New Bitmap(1, 1)
			image = CType(converter.ConvertTo(emptyImage, GetType(Byte())), Byte())
		Else
			image = CType(converter.ConvertTo(Session("BarCodeImage"), GetType(Byte())), Byte())
		End If

		Response.StatusCode = CInt(Fix(HttpStatusCode.OK))
		Response.ContentType = "image/png"
		Response.BinaryWrite(image)
		Response.End()
	End Sub
	Private Sub GenerateBarCodeDescription()
		Dim cbBarCode As String = Request.Params("cbBarCode")
		Dim symbology As Symbology = If(String.IsNullOrEmpty(cbBarCode), Symbology.Codabar, StringToSymology(cbBarCode))
		Dim barCodeGenerator As New BarCodeGenerator(symbology, "")
		barCode = barCodeGenerator.Generate()
		Dim descriptionHTML As String = "<span style=""font:13px Tahoma, Geneva, sans-serif;"">" & barCodeGenerator.Description & "</span>"
		Response.StatusCode = CInt(Fix(HttpStatusCode.OK))
		Response.ContentType = "text/html"
		Response.Write(descriptionHTML)
		Response.End()
	End Sub
	Private Sub GenerateContent()
		GenerateBarCodeList()
		GenerateFontNamesLists()
		clrBarCodeForeColor.Color = Color.Black
		clrBarCodeBackColor.Color = Color.White
		clrBottomCaptionForeColor.Color = Color.Black
		clrTopCaptionForeColor.Color = Color.Black
		UpdateBarCodeState()
	End Sub
	Private Sub GenerateBarCodeList()
		Dim symbologyList() As String = System.Enum.GetNames(GetType(Symbology))
		For Each barCodeType As String In symbologyList
			ComboBoxBarCode.Items.Add(barCodeType)
		Next barCodeType
		ComboBoxBarCode.SelectedIndex = 0
	End Sub
	Private Sub GenerateFontNamesLists()
		For Each fontName As String In FontFamilyNames
			cbFontName.Items.Add(fontName)
			cbTopCaptionFontName.Items.Add(fontName)
			cbBottomCaptionFontName.Items.Add(fontName)
		Next fontName
	End Sub
	Private Function FillBarCodeParams() As BarCodeParams
		Dim barCodeParams As New BarCodeParams()
		Dim cbBarCode As String = Request.Params("cbBarCode")
		Dim chkViewTextValue As String = Request.Params("chkViewText")
		Dim txtBarCodeTextValue As String = Request.Params("txtBarCodeText")
		Dim cbTextVertAlignValue As String = Request.Params("cbTextVertAlign")
		Dim cbTextHorzAlignValue As String = Request.Params("cbTextHorzAlign")
		Dim cbFontNameValue As String = Request.Params("cbFontName")
		Dim spnBarCodeAngleValue As String = Request.Params("spnBarCodeAngle")
		Dim clrBarCodeForeColorValue As String = Request.Params("clrBarCodeForeColor")
		Dim clrBarCodeBackColorValue As String = Request.Params("clrBarCodeBackColor")

		Dim chkTopCaptionValue As String = Request.Params("chkTopCaption")
		Dim txtTopCaptionTextValue As String = Request.Params("txtTopCaptionText")
		Dim cbTopCaptionAlignmentValue As String = Request.Params("cbTopCaptionAlignment")
		Dim clrTopCaptionForeColorValue As String = Request.Params("clrTopCaptionForeColor")
		Dim cbTopCaptionFontNameValue As String = Request.Params("cbTopCaptionFontName")

		Dim chkBottomCaptionValue As String = Request.Params("chkBottomCaption")
		Dim txtBottomCaptionTextValue As String = Request.Params("txtBottomCaptionText")
		Dim cbBottomCaptionAlignmentValue As String = Request.Params("cbBottomCaptionAlignment")
		Dim clrBottomCaptionForeColorValue As String = Request.Params("clrBottomCaptionForeColor")
		Dim cbBottomCaptionFontNameValue As String = Request.Params("cbBottomCaptionFontName")

		barCodeParams.Symbology = cbBarCode
		barCodeParams.Text = If((txtBarCodeTextValue = "null"), "", txtBarCodeTextValue)
		barCodeParams.ShowText = If((String.IsNullOrEmpty(chkViewTextValue)), False, Convert.ToBoolean(chkViewTextValue))
		barCodeParams.VertAlign = cbTextVertAlignValue
		barCodeParams.HorzAlign = cbTextHorzAlignValue
		barCodeParams.TextFont = cbFontNameValue
		barCodeParams.BarCodeAngle = Convert.ToInt32(spnBarCodeAngleValue)
		barCodeParams.ForeColor = clrBarCodeForeColorValue
		barCodeParams.BackColor = clrBarCodeBackColorValue

		barCodeParams.ShowTopCaption = If((String.IsNullOrEmpty(chkTopCaptionValue)), False, Convert.ToBoolean(chkTopCaptionValue))
		barCodeParams.TopCaptionText = txtTopCaptionTextValue
		barCodeParams.TopCaptionAlignment = cbTopCaptionAlignmentValue
		barCodeParams.TopCaptionForeColor = clrTopCaptionForeColorValue
		barCodeParams.TopCaptionFont = cbTopCaptionFontNameValue

		barCodeParams.ShowBottomCaption = If((String.IsNullOrEmpty(chkBottomCaptionValue)), False, Convert.ToBoolean(chkBottomCaptionValue))
		barCodeParams.BottomCaptionText = txtBottomCaptionTextValue
		barCodeParams.BottomCaptionAlignment = cbBottomCaptionAlignmentValue
		barCodeParams.BottomCaptionForeColor = clrBottomCaptionForeColorValue
		barCodeParams.BottomCaptionFont = cbBottomCaptionFontNameValue

		Return barCodeParams
	End Function
	Private Function StringToSymology(ByVal symbologyName As String) As Symbology
		Return CType(System.Enum.Parse(GetType(Symbology), symbologyName), Symbology)
	End Function
	Private Sub UpdateBarCodeState(ByVal barCodeParams As BarCodeParams)
		Dim symbology As Symbology = StringToSymology(barCodeParams.Symbology)
		Dim barCodeGenerator As New BarCodeGenerator(symbology, barCodeParams.Text)
		barCodeGenerator.ViewText = barCodeParams.ShowText
		barCode = barCodeGenerator.Generate()

		If barCodeParams.ShowText Then
			UpdateBarCodeText(barCodeParams)
		End If
		UpdateBarCode(barCodeParams)
		If barCodeParams.ShowTopCaption Then
			UpdateTopCaption(barCodeParams)
		End If
		If barCodeParams.ShowBottomCaption Then
			UpdateBottomCaption(barCodeParams)
		End If

		Try
			Dim img As Bitmap = barCode.BarCodeImage
			Session("BarCodeImage") = CreateThumbnailImage(img)
		Catch ex As Exception
			ShowErrorMessage(ex.Message)
		End Try
	End Sub
	Private Sub UpdateBarCodeState()
		Dim symbology As Symbology = StringToSymology(TryCast(ComboBoxBarCode.Value, String))
		Dim barCodeGenerator As New BarCodeGenerator(symbology, "")
		barCode = barCodeGenerator.Generate()

		Using img As Bitmap = barCode.BarCodeImage
			Session("BarCodeImage") = CreateThumbnailImage(img)
		End Using
	End Sub
	Private Function CreateThumbnailImage(ByVal img As Bitmap) As Object
		Const maxWidth As Integer = 600
		If img.Width < maxWidth Then
			Return img
		End If
		Dim myCallback As New System.Drawing.Image.GetThumbnailImageAbort(AddressOf ThumbnailCallback)
		Dim height As Integer = CInt(Fix(img.Height * ((1.0 * maxWidth) / img.Width)))
		Return img.GetThumbnailImage(maxWidth, height, myCallback, IntPtr.Zero)
	End Function
	Public Function ThumbnailCallback() As Boolean
		Return False
	End Function
	Private Sub ShowErrorMessage(ByVal message As String)
		Dim img As System.Drawing.Image = New Bitmap(100, 100)
		Dim drawing As Graphics = Graphics.FromImage(img)
		Dim font As New Font("Tahoma", 10)
		Dim textSize As Size = drawing.MeasureString(message, font).ToSize()
		Dim textRect As New Rectangle(New Point(), textSize)
		img.Dispose()
		drawing.Dispose()
		img = New Bitmap(textSize.Width, textSize.Height)
		drawing = Graphics.FromImage(img)
		drawing.Clear(Color.White)
		drawing.DrawString(message, font, Brushes.Red, 0, 0)
		Session("BarCodeImage") = img
	End Sub
	Private Sub UpdateBarCodeText(ByVal barCodeParams As BarCodeParams)
		barCode.CodeTextHorizontalAlignment = CType(System.Enum.Parse(GetType(StringAlignment), barCodeParams.HorzAlign), StringAlignment)
		barCode.CodeTextVerticalAlignment = CType(System.Enum.Parse(GetType(StringAlignment), barCodeParams.VertAlign), StringAlignment)
		barCode.CodeTextFont = New Font(barCodeParams.TextFont, 12)
	End Sub
	Private Sub UpdateBarCode(ByVal barCodeParams As BarCodeParams)
		barCode.RotationAngle = barCodeParams.BarCodeAngle
		barCode.ForeColor = ColorTranslator.FromHtml(barCodeParams.ForeColor)
		barCode.BackColor = ColorTranslator.FromHtml(barCodeParams.BackColor)
	End Sub
	Private Sub UpdateTopCaption(ByVal barCodeParams As BarCodeParams)
		barCode.TopCaption.Text = barCodeParams.TopCaptionText
		barCode.TopCaption.HorizontalAlignment = CType(System.Enum.Parse(GetType(StringAlignment), barCodeParams.TopCaptionAlignment), StringAlignment)
		barCode.TopCaption.ForeColor = ColorTranslator.FromHtml(barCodeParams.TopCaptionForeColor)
		barCode.TopCaption.Font = New Font(barCodeParams.TopCaptionFont, 12)
	End Sub
	Private Sub UpdateBottomCaption(ByVal barCodeParams As BarCodeParams)
		barCode.BottomCaption.Text = barCodeParams.BottomCaptionText
		barCode.BottomCaption.HorizontalAlignment = CType(System.Enum.Parse(GetType(StringAlignment), barCodeParams.BottomCaptionAlignment), StringAlignment)
		barCode.BottomCaption.ForeColor = ColorTranslator.FromHtml(barCodeParams.BottomCaptionForeColor)
		barCode.BottomCaption.Font = New Font(barCodeParams.BottomCaptionFont, 12)
	End Sub
End Class
Public Class BarCodeParams
	Public Property Symbology() As String
	Public Property ShowText() As Boolean
	Public Property Text() As String
	Public Property VertAlign() As String
	Public Property HorzAlign() As String
	Public Property TextFont() As String
	Public Property BarCodeAngle() As Integer
	Public Property ForeColor() As String
	Public Property BackColor() As String

	Public Property ShowTopCaption() As Boolean
	Public Property TopCaptionText() As String
	Public Property TopCaptionAlignment() As String
	Public Property TopCaptionFont() As String
	Public Property TopCaptionForeColor() As String

	Public Property ShowBottomCaption() As Boolean
	Public Property BottomCaptionText() As String
	Public Property BottomCaptionAlignment() As String
	Public Property BottomCaptionFont() As String
	Public Property BottomCaptionForeColor() As String
End Class
