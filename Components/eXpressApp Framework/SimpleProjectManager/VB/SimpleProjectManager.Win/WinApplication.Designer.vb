Partial Public Class SimpleProjectManagerWindowsFormsApplication
    ''' <summary> 
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary> 
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Component Designer generated code"

    ''' <summary> 
    ''' Required method for Designer support - do not modify 
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.module1 = New DevExpress.ExpressApp.SystemModule.SystemModule()
        Me.module2 = New DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule()
        Me.validationWindowsFormsModule1 = New DevExpress.ExpressApp.Validation.Win.ValidationWindowsFormsModule()
        Me.module3 = New SimpleProjectManager.Module.SimpleProjectManagerModule()
        Me.module4 = New SimpleProjectManager.Module.Win.SimpleProjectManagerWindowsFormsModule()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        ' 
        ' SimpleProjectManagerWindowsFormsApplication
        ' 
        Me.ApplicationName = "SimpleProjectManager"
        Me.Modules.Add(Me.module1)
        Me.Modules.Add(Me.module2)
        Me.Modules.Add(Me.module3)
        Me.Modules.Add(Me.module4)
        Me.Modules.Add(Me.validationWindowsFormsModule1)
        Me.UseOldTemplates = False
        '			Me.DatabaseVersionMismatch += New System.EventHandler(Of DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs)(Me.SimpleProjectManagerWindowsFormsApplication_DatabaseVersionMismatch)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

#End Region

    Private module1 As DevExpress.ExpressApp.SystemModule.SystemModule
    Private module2 As DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule
    Private module3 As SimpleProjectManager.Module.SimpleProjectManagerModule
    Private module4 As SimpleProjectManager.Module.Win.SimpleProjectManagerWindowsFormsModule
    Private validationWindowsFormsModule1 As DevExpress.ExpressApp.Validation.Win.ValidationWindowsFormsModule
End Class
