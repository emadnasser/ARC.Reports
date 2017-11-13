Imports System
Imports System.Windows
Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.UI
Imports DevExpress.Xpf.Core
Imports DevExpress.Xpf.PdfViewer
Imports DevExpress.Internal

Namespace ProductsDemo
    Partial Public Class App
        Inherits Application

        Public Sub New()
            ExceptionHelper.Initialize()
            DevExpress.Images.ImagesAssemblyLoader.Load()
            PdfViewerLocalizer.Active = New CustomPdfViewerLocalizer()
            ApplicationThemeHelper.ApplicationThemeName = Theme.Office2013Name
        End Sub
        Public Shared Sub Start(ByVal baseStart As Action, ByVal application As Application)
            ServiceContainer.Default.RegisterService(New ApplicationJumpListService())
        End Sub
        Protected Overrides Sub OnStartup(ByVal e As StartupEventArgs)
            Start(Sub() MyBase.OnStartup(e), Me)
        End Sub
    End Class
    Public Class CustomPdfViewerLocalizer
        Inherits PdfViewerLocalizer

        Public Overrides Function GetLocalizedString(ByVal id As PdfViewerStringId) As String
            Select Case id
                Case PdfViewerStringId.BarCaption
                    Return "PDF VIEWER"
                Case Else
                    Return MyBase.GetLocalizedString(id)
            End Select
        End Function
    End Class
End Namespace
#If CLICKONCE Then
    Namespace DevExpress.Internal.DemoLauncher
        Public NotInheritable Class ClickOnceEntryPoint

            Private Sub New()
            End Sub

            Public Shared Function CreateMainWindow() As Window
                ViewLocator.Default = New ViewLocator( { GetType(ProductsDemo.App).Assembly })
                Dim app As Application = Application.Current
                ApplicationThemeHelper.ApplicationThemeName = Theme.Office2013Name
                DevExpress.Images.ImagesAssemblyLoader.Load()
                PdfViewerLocalizer.Active = New ProductsDemo.CustomPdfViewerLocalizer()
                ProductsDemo.App.Start(Sub()
                End Sub, app)
                Return New ProductsDemo.MainWindow()
            End Function
        End Class
    End Namespace
#End If
