Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Configuration
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure
Imports System.Data.Entity.ModelConfiguration
Imports System.Drawing
Imports System.IO
Imports System.Web
Imports System.Xml
Imports System.Xml.Serialization
Imports DevExpress.Web.Internal

Public Enum HeadphoneFit
	<Description("Over ear")> _
	OverEar
	<Description("On ear")> _
	OnEar
	<Description("In ear")> _
	InEar
End Enum

Public Enum HeadphoneStyle
	<Description("Pro")> _
	Pro
	<Description("Studio")> _
	Studio
	<Description("Sport and exercize")> _
	SportAndExercize
End Enum

Public Class Headphone
	Public Sub New()
	End Sub

	Public Property ID() As Integer
	Public Property Brand() As String
	Public Property Model() As String
	Public Property Fit() As HeadphoneFit
	Public Property Style() As HeadphoneStyle
	Public Property Price() As Decimal
	Public Property Discount() As Decimal
	Public Property Rating() As Decimal
	Public Property ReviewCount() As Integer
	Public Property Warranty() As Integer

	Public Property Wireless() As Boolean
	Public Property Bluetooth() As Boolean
	Public Property WaterResistant() As Boolean
	Public Property PhoneControl() As Boolean
	Public Property InLineVolumeControl() As Boolean
	Public Property SoundIsolating() As Boolean
	Public Property CarryingCase() As Boolean
	Public Property BuiltInMicrophone() As Boolean

	Public Property Color() As String
	Public Property Height() As Double
	Public Property Width() As Double
	Public Property Depth() As Double
	Public Property Weight() As Double
	Public Property ConnectorSize() As String

	Public Property Sensitivity() As Integer
	Public Property MinFrequency() As Integer
	Public Property MaxFrequency() As Integer
	Public Property Power() As Integer
	Public Property Impedance() As Integer

	Public Property Photo() As Byte()
	Public Property PhotoUrl() As String
	Public Property LargePhoto() As Byte()
	Public Property LargePhotoUrl() As String
End Class

Public Class HeadphonesDataProvider
	Private Const ImageWidth As Integer = 180
	Private Const ImageFileNameFormat As String = "{0}_{1}.jpg", DataFileVirtualPath As String = "~/App_Data/Headphones.xml", PhotoDirVirtualPath As String = "~/Content/HeadphonesPhoto"

	Private Shared ReadOnly createLocker As Object = New Object()

	Private Shared headphones_Renamed As List(Of Headphone) = Nothing

	Private Shared Function MapPath(ByVal path As String) As String
		Return HttpContext.Current.Server.MapPath(path)
	End Function
	Private Shared ReadOnly Property DataFilePath() As String
		Get
			Return MapPath(DataFileVirtualPath)
		End Get
	End Property
	Private Shared ReadOnly Property PhotoDirPath() As String
		Get
			Return MapPath(PhotoDirVirtualPath)
		End Get
	End Property
	Private Shared Function PhotoUrl(ByVal id As Integer, ByVal postfix As String) As String
		Return Path.Combine(PhotoDirVirtualPath, String.Format(ImageFileNameFormat, id, postfix))
	End Function

	Public Shared ReadOnly Property Headphones() As List(Of Headphone)
		Get
			If headphones_Renamed Is Nothing Then
				headphones_Renamed = CreateHeadphones()
			End If
			Return headphones_Renamed
		End Get
	End Property
	Public Shared Function SelectHeadphones() As List(Of Headphone)
		Return Headphones
	End Function

	Private Shared Function CreateHeadphones() As List(Of Headphone)
		SyncLock createLocker
			Dim serializer = New XmlSerializer(GetType(List(Of Headphone)))
			Dim fs As FileStream = File.OpenRead(DataFilePath)
			Dim reader As XmlReader = XmlReader.Create(fs)
			Dim list As List(Of Headphone) = CType(serializer.Deserialize(reader), List(Of Headphone))
			fs.Close()
			For Each headphone In list
				headphone.PhotoUrl = GetPhotoUrl(headphone, headphone.Photo, "s")
				headphone.LargePhotoUrl = GetPhotoUrl(headphone, headphone.LargePhoto, "l")
			Next headphone
			Return list
		End SyncLock
	End Function

	Private Shared Function GetPhotoUrl(ByVal item As Headphone, ByVal photo() As Byte, ByVal postfix As String) As String
		Dim url = PhotoUrl(item.ID, postfix)
		Dim serverPath = MapPath(url)

		If (Not File.Exists(serverPath)) Then
			If (Not Directory.Exists(PhotoDirPath)) Then
				Directory.CreateDirectory(PhotoDirPath)
			End If
			SaveImage(photo, serverPath)
		End If
		Return url
	End Function
	Private Shared Sub SaveImage(ByVal imageBytes() As Byte, ByVal path As String)
		Using stream = New MemoryStream(imageBytes)
		Using img = Image.FromStream(stream)
			ImageUtils.SaveImage(img, path)
		End Using
		End Using
	End Sub
End Class
