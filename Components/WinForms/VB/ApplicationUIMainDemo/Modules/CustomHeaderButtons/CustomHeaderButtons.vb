Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Reflection
Imports DevExpress.XtraBars.Docking2010
Imports DevExpress.XtraEditors
Imports DevExpress.DXperience.Demos


Namespace DevExpress.ApplicationUI.Demos
	Partial Public Class CustomHeaderButtons
		Inherits TutorialControlBase
		Private templatesButtonCore As Dictionary(Of String, BaseButtonProperties)
		Public Sub New()
			InitializeComponent()
			InitButtons()
			rgTemplatesButton.SelectedIndex = 0
		End Sub
		Private ReadOnly Property TemplatesButton() As Dictionary(Of String, BaseButtonProperties)
			Get
				If templatesButtonCore Is Nothing Then
					templatesButtonCore = New Dictionary(Of String, BaseButtonProperties)()
				End If
				Return templatesButtonCore
			End Get
		End Property
		Private Sub InitButtons()
			Dim customSimpleButton As BaseButtonProperties = New CustomPushButtonProperties()
			TemplatesButton.Add("PushButton", customSimpleButton)
			Dim customToggleButton As BaseButtonProperties = New CustomCheckButtonProperties()
			TemplatesButton.Add("CheckButton", customToggleButton)
			Dim customButtonWithImage As BaseButtonProperties = New CustomButtonWithImageProperties(imageList1.Images(5))
			TemplatesButton.Add("ButtonWithImage", customButtonWithImage)
			Dim customButtonWithGlyphs As BaseButtonProperties = New CustomButtonWithGlyphsProperties(imageList1)
			TemplatesButton.Add("ButtonWithGlyphs", customButtonWithGlyphs)
			Dim group As RadioGroup = rgTemplatesButton
			buttonPropertyGrid.SelectObject = actionDockPanel.Button
		End Sub
		Private Sub TemplatesButtonSelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rgTemplatesButton.SelectedIndexChanged
			Dim group As RadioGroup = TryCast(sender, RadioGroup)
			If group Is Nothing Then
				Return
			End If
            Dim buttonProperties As BaseButtonProperties = Nothing
			If TemplatesButton.TryGetValue(group.Properties.Items(group.SelectedIndex).Value.ToString(), buttonProperties) Then
				buttonProperties.AssingProterties(actionDockPanel.Button)
				buttonPropertyGrid.RefreshPropertyGrid()
			End If
		End Sub

		Private Class BaseButtonProperties
			Public Sub New()
				Caption = String.Empty
				Image = Nothing
				Glyphs = Nothing
				Style = ButtonStyle.PushButton
				UseCaption = True
			End Sub
			Private privateCaption As String
			Public Property Caption() As String
				Get
					Return privateCaption
				End Get
				Set(ByVal value As String)
					privateCaption = value
				End Set
			End Property
			Private privateImage As Image
			Public Property Image() As Image
				Get
					Return privateImage
				End Get
				Set(ByVal value As Image)
					privateImage = value
				End Set
			End Property
			Private privateGlyphs As Object
			Public Property Glyphs() As Object
				Get
					Return privateGlyphs
				End Get
				Set(ByVal value As Object)
					privateGlyphs = value
				End Set
			End Property
			Private privateStyle As ButtonStyle
			Public Property Style() As ButtonStyle
				Get
					Return privateStyle
				End Get
				Set(ByVal value As ButtonStyle)
					privateStyle = value
				End Set
			End Property
			Private privateUseCaption As Boolean
			Public Property UseCaption() As Boolean
				Get
					Return privateUseCaption
				End Get
				Set(ByVal value As Boolean)
					privateUseCaption = value
				End Set
			End Property
			Public Sub AssingProterties(ByVal button As IButton)
				button.Properties.Caption = Caption
				button.Properties.Image = Image
				button.Properties.Glyphs = Glyphs
				button.Properties.Style = Style
				button.Properties.UseCaption = UseCaption
			End Sub
		End Class
		Private Class CustomPushButtonProperties
			Inherits BaseButtonProperties
			Public Sub New()
				MyBase.New()
				Caption = "Push button"
			End Sub
		End Class
		Private Class CustomCheckButtonProperties
			Inherits BaseButtonProperties
			Public Sub New()
				MyBase.New()
				Caption = "Check Button"
				Style = ButtonStyle.CheckButton
			End Sub
		End Class
		Private Class CustomButtonWithImageProperties
			Inherits BaseButtonProperties
			Public Sub New(ByVal image As Image)
				MyBase.New()
				Caption = "Image"
				Image = image
			End Sub
		End Class
		Private Class CustomButtonWithGlyphsProperties
			Inherits BaseButtonProperties
			Public Sub New(ByVal glyphs As Object)
				MyBase.New()
				Caption = "Glyphs"
				Style = ButtonStyle.CheckButton
				Glyphs = glyphs
				UseCaption = False
			End Sub
		End Class
	End Class
End Namespace
