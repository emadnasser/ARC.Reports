Imports DevExpress.XtraSplashScreen
Imports DevExpress.DevAV
Imports System

Namespace DevExpress.DevAV.Services

    Public Interface IWaitingService
        Sub BeginWaiting(ByVal parameter As Object)
        Sub EndWaiting()
    End Interface
    Friend Class WaitingService
        Implements IWaitingService

        Private Sub IWaitingService_BeginWaiting(ByVal parameter As Object) Implements IWaitingService.BeginWaiting
            ShowWaitForm(DevExpress.XtraEditors.EnumDisplayTextHelper.GetDisplayText(parameter))
        End Sub
        Private Sub IWaitingService_EndWaiting() Implements IWaitingService.EndWaiting
            CloseWaitForm()
        End Sub
        Private Shared Sub ShowWaitForm(ByVal caption As String)
            If SplashScreenManager.Default Is Nothing Then
                SplashScreenManager.ShowDefaultWaitForm(AppHelper.MainForm, False, False, False, 250, caption)
            End If
        End Sub
        Private Shared Sub CloseWaitForm()
            Dim ssm = SplashScreenManager.Default
            If ssm IsNot Nothing AndAlso ssm.ActiveSplashFormTypeInfo IsNot Nothing AndAlso ssm.ActiveSplashFormTypeInfo.Mode = Mode.WaitForm Then
                SplashScreenManager.CloseForm(False, 750, AppHelper.MainForm)
            End If
        End Sub
    End Class
    Friend Class LoadingService
        Implements IWaitingService

        Private owner As System.Windows.Forms.UserControl
        Public Sub New(ByVal owner As System.Windows.Forms.UserControl)
            Me.owner = owner
        End Sub
        Private Sub IWaitingService_BeginWaiting(ByVal parameter As Object) Implements IWaitingService.BeginWaiting
            ShowWaitForm(owner, parameter.ToString())
        End Sub
        Private Sub IWaitingService_EndWaiting() Implements IWaitingService.EndWaiting
            CloseWaitForm()
        End Sub
        Private Shared Sub ShowWaitForm(ByVal owner As System.Windows.Forms.UserControl, ByVal caption As String)
            If SplashScreenManager.Default Is Nothing Then
                SplashScreenManager.ShowDefaultWaitForm(If(owner IsNot Nothing, owner.FindForm(), Nothing), False, False, caption)
            End If
        End Sub
        Private Shared Sub CloseWaitForm()
            Dim ssm = SplashScreenManager.Default
            If ssm IsNot Nothing AndAlso ssm.ActiveSplashFormTypeInfo IsNot Nothing AndAlso ssm.ActiveSplashFormTypeInfo.Mode = Mode.WaitForm Then
                SplashScreenManager.CloseForm(False, 250, AppHelper.MainForm)
            End If
        End Sub
    End Class
    Public Module WaitingServiceExtension
        Sub New()
            SplashScreenManager.ActivateParentOnWaitFormClosing = False
        End Sub
        <System.Runtime.CompilerServices.Extension> _
        Public Function Enter(ByVal service As IWaitingService, ByVal parameter As Object, Optional ByVal effective As Boolean = True) As IDisposable
            Return New WaitingBatch(If(effective, service, Nothing), parameter)
        End Function
        Private Class WaitingBatch
            Implements IDisposable

            Private service As IWaitingService
            Public Sub New(ByVal service As IWaitingService, ByVal parameter As Object)
                Me.service = service
                If service IsNot Nothing Then
                    service.BeginWaiting(parameter)
                End If
            End Sub
            Public Sub Dispose() Implements IDisposable.Dispose
                If service IsNot Nothing Then
                    service.EndWaiting()
                End If
            End Sub
        End Class
    End Module
End Namespace
