Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.Utils.VisualEffects

Namespace DevExpress.ApplicationUI.Demos.VisualEffects
    Partial Public Class GuideFlyoutPanel
        Inherits UserControl
        Private curentLessonIdCore As Integer
        Private [module] As ModuleGuides
        Public Sub New(ByVal moduleGuide As ModuleGuides, ByVal lessonCount As Integer)
            InitializeComponent()
            [module] = moduleGuide
            curentLessonIdCore = 0
            InitializeNavigator(lessonCount)
        End Sub
        Private Sub InitializeNavigator(ByVal count As Integer)
            For i As Integer = 0 To count - 1
                Me.navigator.Buttons.Add(New DevExpress.XtraBars.Docking2010.WindowsUIButton("Button", GetResourceImage(), 0, DevExpress.XtraBars.Docking2010.ImageLocation.Default, DevExpress.XtraBars.Docking2010.ButtonStyle.CheckButton, "", False, -1, True, Nothing, True, i = curentLessonIdCore, True, Nothing, Nothing, 1, False, False))
            Next i
        End Sub
        Public Property LabelText() As String
            Get
                Return label.Text
            End Get
            Set(ByVal value As String)
                label.Text = value
            End Set
        End Property
        Public ReadOnly Property CurrentLessonIndex() As Integer
            Get
                Return curentLessonIdCore
            End Get
        End Property
        Private Function GetResourceImage() As Image
            Return TryCast(DevExpress.Utils.ResourceImageHelper.CreateImageFromResourcesEx("DevExpress.ApplicationUI.Demos.Images.navigationButton.png", GetType(GuideFlyoutPanel).Assembly), Image)
        End Function
        Private Sub OnNavigatorButtonChecked(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Docking2010.ButtonEventArgs) Handles navigator.ButtonChecked
            curentLessonIdCore = navigator.Buttons.IndexOf(e.Button)
            [module].SetLesson(curentLessonIdCore)
        End Sub
        Private Sub OnSkipButtonClick(ByVal sender As Object, ByVal e As EventArgs) Handles skipButton.Click
            [module].EndTutorial()
        End Sub
        Private Sub OnBackButtonClick(ByVal sender As Object, ByVal e As EventArgs) Handles backButton.Click
            curentLessonIdCore -= 1
            If curentLessonIdCore < 0 Then
                curentLessonIdCore = navigator.Buttons.Count - 1
            End If
            navigator.Buttons(curentLessonIdCore).Properties.Checked = True
        End Sub
        Private Sub OnNextButtonClick(ByVal sender As Object, ByVal e As EventArgs) Handles nextButton.Click
            curentLessonIdCore += 1
            If curentLessonIdCore > navigator.Buttons.Count - 1 Then
                curentLessonIdCore = 0
            End If
            navigator.Buttons(curentLessonIdCore).Properties.Checked = True
        End Sub
    End Class
End Namespace
