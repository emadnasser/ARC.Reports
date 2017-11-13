Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.Utils
Imports DevExpress.XtraNavBar

Namespace DevExpress.XtraNavBar.Demos
	Partial Public Class ctrlAlphaBlending
		Inherits DevExpress.XtraEditors.XtraUserControl
		Public Sub New()
			InitializeComponent()
		End Sub

		Private appObject As AppearanceObject
		Private navBar As NavBarControl
		Private group As NavBarGroup

		Private Property backGround() As Image
			Get
				If navBar IsNot Nothing Then
					Return navBar.BackgroundImage
				End If
				Return group.BackgroundImage
			End Get
			Set(ByVal value As Image)
				If navBar IsNot Nothing Then
					navBar.BackgroundImage = value
				Else
					group.BackgroundImage = value
				End If
			End Set
		End Property

		Public Sub StyleInit(ByVal app As AppearanceObject, ByVal s As String, ByVal navBar As NavBarControl)
			StyleInit(app, s, navBar, Nothing)
		End Sub
		Public Sub StyleInit(ByVal app As AppearanceObject, ByVal s As String, ByVal group As NavBarGroup)
			StyleInit(app, s, Nothing, group)
		End Sub
		Private Sub StyleInit(ByVal app As AppearanceObject, ByVal s As String, ByVal navBar As NavBarControl, ByVal group As NavBarGroup)
			appObject = app
			groupBox1.Text = s
			StyleColorChange(app.BackColor.A)
			Me.navBar = navBar
			Me.group = group
			pictureBox1.Image = backGround
		End Sub



		#Region "Component Designer generated code"

		#End Region

		Private Sub StyleColorChange(ByVal v As Integer)
			appObject.BackColor = Color.FromArgb(v, appObject.BackColor)
			numericUpDown1.Value = v
			trackBar1.Value = v
		End Sub

		Private Sub trackBar1_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles trackBar1.ValueChanged
			StyleColorChange(trackBar1.Value)
		End Sub

		Private Sub numericUpDown1_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles numericUpDown1.ValueChanged
			StyleColorChange(CInt(Fix(numericUpDown1.Value)))
		End Sub

		Private Sub pictureBox1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles pictureBox1.Click
			Dim dlg As New OpenFileDialog()
			dlg.Filter = "Bitmap Files (*.bmp)|*.bmp|" & "Graphics Interchange Format (*.gif)|*.gif|" & "JPEG File Interchange Format (*.jpg;*.jpeg)|*.jpg;*.jpeg|" & "Icon Files (*.ico)|*.ico|" & "All Picture Files |*.bmp;*.gif;*.jpg;*.jpeg;*.ico;*.png;*.tif|" & "All Files |*.*"
			dlg.Title = "Open"
			dlg.FilterIndex = 5
			If dlg.ShowDialog() = DialogResult.OK Then
				Try
					pictureBox1.Image = Image.FromFile(dlg.FileName)
					backGround = pictureBox1.Image
				Catch
				End Try
			End If
		End Sub

		Private Sub label2_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles label2.DoubleClick
			pictureBox1.Image = Nothing
			backGround = pictureBox1.Image
		End Sub
	End Class
End Namespace
