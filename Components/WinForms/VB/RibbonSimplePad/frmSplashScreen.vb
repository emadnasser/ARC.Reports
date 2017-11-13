Imports DevExpress.XtraSplashScreen

Public Class frmSplashScreen
    Sub New()
        InitializeComponent()
        Me.pictureEdit2.Image = DevExpress.Utils.ResourceImageHelper.CreateImageFromResources("DevExpress.XtraEditors.SplashScreen.DemoSplashScreen.png", GetType(DemoSplashScreen).Assembly)
        Me.labelControl1.Text = AssemblyInfo.AssemblyCopyright
    End Sub
    Public Overrides Sub ProcessCommand(ByVal cmd As System.Enum, ByVal arg As Object)
        MyBase.ProcessCommand(cmd, arg)
    End Sub
    Public Enum SplashScreenCommand
        SomeCommandId
    End Enum
End Class
