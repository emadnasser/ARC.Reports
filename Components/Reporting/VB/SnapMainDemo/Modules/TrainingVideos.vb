Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports System.IO
Imports System.Xml.Serialization
Imports DevExpress.Utils
Imports DevExpress.Utils.Controls
Imports DevExpress.Skins
Imports DevExpress.LookAndFeel
Imports System.Reflection

Namespace SnapDemos.Modules
	Public Class VideoList
		Inherits XtraScrollableControl
		Private Const PaddingBetweenItems As Integer = 5
		Private Const VideoItemTextOffset As Integer = 8

		Private vScrollWidth As Integer
		Private hScrollHeight As Integer
		Private viewportBounds_Renamed As Rectangle

		Public Sub New()
			AddHandler UserLookAndFeel.Default.StyleChanged, AddressOf OnStyleChangedHandler

			CreateLinks()
			UpdateLinksLayout()
		End Sub

		Protected ReadOnly Property ViewportBounds() As Rectangle
			Get
				Return viewportBounds_Renamed
			End Get
		End Property

		Protected Overrides Function CreateVScrollBar() As VScrollBarViewInfoWithHandler
			Dim result As VScrollBarViewInfoWithHandler = MyBase.CreateVScrollBar()
			Me.vScrollWidth = result.Width
			Return result
		End Function
		Protected Overrides Function CreateHScrollBar() As HScrollBarViewInfoWithHandler
			Dim result As HScrollBarViewInfoWithHandler = MyBase.CreateHScrollBar()
			Me.hScrollHeight = result.Height
			Return result
		End Function
		Protected Overrides Sub OnClientSizeChanged(ByVal e As EventArgs)
			MyBase.OnClientSizeChanged(e)
			CalculateViewportBounds()
			UpdateLinksWidth()
		End Sub
		Protected Overrides Sub OnPaddingChanged(ByVal e As EventArgs)
			MyBase.OnPaddingChanged(e)
			CalculateViewportBounds()
			UpdateLinksLayout()
		End Sub
		Private Sub OnStyleChangedHandler(ByVal sender As Object, ByVal e As EventArgs)
			UpdateLinksColor()
		End Sub
		Private Sub CalculateViewportBounds()
			Me.viewportBounds_Renamed.X = Padding.Left
			Me.viewportBounds_Renamed.Y = Padding.Top
			Me.viewportBounds_Renamed.Width = Math.Max(ClientRectangle.Width - Me.vScrollWidth - Padding.Left - Padding.Right, 0)
			Me.viewportBounds_Renamed.Height = Math.Max(ClientRectangle.Height - Me.hScrollHeight - Padding.Top - Padding.Bottom, 0)
		End Sub
		Private Sub UpdateLinksColor()
			Dim linkColor As Color = GetLinkColor(LookAndFeel)
			For Each link As LinkLabel In Controls
				link.LinkColor = linkColor
				link.ActiveLinkColor = linkColor
			Next link
		End Sub
		Private Sub UpdateLinksWidth()
			For Each link As LinkLabel In Controls
				link.Width = ViewportBounds.Width
			Next link
		End Sub
		Private Sub CreateLinks()
			If VideoSource.Data Is Nothing Then
				Return
			End If

			For Each video As VideoInfo In VideoSource.Data
				Dim link As LinkLabel = CreateLinkLabel(video.GetImage(), video.Uri, video.Caption)
				Controls.Add(link)
			Next video
			UpdateLinksColor()
		End Sub
		Private Sub UpdateLinksLayout()
			Dim verticalPosition As Integer = ViewportBounds.Y
			Dim horizontalPosition As Integer = ViewportBounds.X
			For Each link As LinkLabel In Controls
				link.Location = New Point(horizontalPosition, verticalPosition)
				Dim height As Integer = Math.Max(link.Image.Height, link.Height)
				link.Height = height
				verticalPosition += height + PaddingBetweenItems
			Next link
			UpdateLinksWidth()
		End Sub
		Private Function CreateLinkLabel(ByVal image As Image, ByVal uri As String, ByVal text As String) As LinkLabel
			Dim link As New LinkLabel()
			link.Image = image
			link.Padding = New Padding(image.Width + VideoItemTextOffset, 0, 0, 0)
			link.TextAlign = ContentAlignment.MiddleLeft
			link.LinkBehavior = LinkBehavior.HoverUnderline
			link.ImageAlign = ContentAlignment.MiddleLeft
			link.Text = text
			link.AutoSize = False
			link.Tag = uri
			AddHandler link.LinkClicked, AddressOf OnLinkClicked
			Return link
		End Function
		Private Sub OnLinkClicked(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs)
			If e.Button <> System.Windows.Forms.MouseButtons.Left Then
				Return
			End If

			Dim link As LinkLabel = TryCast(sender, LinkLabel)
			If link Is Nothing Then
				Return
			End If

			Try
				System.Diagnostics.Process.Start(CStr(link.Tag))
			Catch
			End Try
		End Sub
		Private Function GetLinkColor(ByVal lookAndFeel As UserLookAndFeel) As Color
			Dim color As Color = Color.Empty
			If lookAndFeel.ActiveStyle = DevExpress.LookAndFeel.ActiveLookAndFeelStyle.Skin Then
				Dim skin As Skin = EditorsSkins.GetSkin(lookAndFeel)
				color = skin.Colors.GetColor(EditorsSkins.SkinHyperlinkTextColor)
			End If
			Return If(color.IsEmpty, Color.Blue, color)
		End Function

		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				RemoveHandler UserLookAndFeel.Default.StyleChanged, AddressOf OnStyleChangedHandler
			End If
			MyBase.Dispose(disposing)
		End Sub
	End Class

	Public NotInheritable Class VideoSource
		Private Shared data_Renamed As List(Of VideoInfo)

		Private Sub New()
		End Sub
		Public Shared ReadOnly Property Data() As List(Of VideoInfo)
			Get
				If data_Renamed Is Nothing Then
					data_Renamed = GetDataSource()
				End If
				Return data_Renamed
			End Get
		End Property

		Private Shared Function GetDataSource() As List(Of VideoInfo)
			Dim path As String = GetPathToResource("SnapDemos.Modules", "TrainingVideos.xml")
			Using stream As Stream = System.Reflection.Assembly.GetCallingAssembly().GetManifestResourceStream(path)
				Dim s As New XmlSerializer(GetType(List(Of VideoInfo)), New XmlRootAttribute("Videos"))
				Return CType(s.Deserialize(stream), List(Of VideoInfo))
			End Using
		End Function
		Private Shared Function GetPathToResource(ByVal path As String, ByVal name As String) As String
			If DevExpress.DXperience.Demos.DemoHelper.GetLanguageString(System.Reflection.Assembly.GetCallingAssembly()) = "CS" Then
				Return String.Format("{0}.{1}", path, name)
			Else
				Return name
			End If
		End Function
	End Class
	<XmlType("Video")> _
	Public Class VideoInfo
		<XmlElement("Image")> _
		Public Property ImageData() As Byte()
		Public Property Uri() As String
		Public Property Caption() As String

		Public Function GetImage() As Image
			If ImageData Is Nothing Then
				Return Nothing
			End If
			Try
				Using stream As New MemoryStream(ImageData)
					Return Image.FromStream(stream)
				End Using
			Catch
				Return Nothing
			End Try
		End Function
	End Class
End Namespace
