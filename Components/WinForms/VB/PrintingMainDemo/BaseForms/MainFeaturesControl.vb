Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos
Imports DevExpress.XtraPrinting.Native


Namespace XtraPrintingDemos
    Public Class MainFeaturesControl
        Inherits TutorialControlBase

        Private xtraTabControl1 As DevExpress.XtraTab.XtraTabControl
        Private xtraTabPage1 As DevExpress.XtraTab.XtraTabPage
        Private WithEvents rtbFeatures As RichTextBox
        Private components As System.ComponentModel.IContainer = Nothing

        Public Sub New()
            ' This call is required by the Windows Form Designer.
            InitializeComponent()

            ' TODO: Add any initialization after the InitializeComponent call
            Dim stream As System.IO.Stream = LoadResource("XtraPrintingDemos.BaseForms.PrintingAbout.rtf")
            rtbFeatures.LoadFile(stream, RichTextBoxStreamType.RichText)
        End Sub
        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If components IsNot Nothing Then
                    components.Dispose()
                End If
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.xtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
            Me.xtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
            Me.rtbFeatures = New System.Windows.Forms.RichTextBox()
            CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.xtraTabControl1.SuspendLayout()
            Me.xtraTabPage1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' xtraTabControl1
            ' 
            Me.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xtraTabControl1.Location = New System.Drawing.Point(0, 0)
            Me.xtraTabControl1.Name = "xtraTabControl1"
            Me.xtraTabControl1.SelectedTabPage = Me.xtraTabPage1
            Me.xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False
            Me.xtraTabControl1.Size = New System.Drawing.Size(184, 124)
            Me.xtraTabControl1.TabIndex = 0
            Me.xtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() { Me.xtraTabPage1})
            Me.xtraTabControl1.Text = "xtraTabControl1"
            ' 
            ' xtraTabPage1
            ' 
            Me.xtraTabPage1.Controls.Add(Me.rtbFeatures)
            Me.xtraTabPage1.Name = "xtraTabPage1"
            Me.xtraTabPage1.Size = New System.Drawing.Size(175, 115)
            Me.xtraTabPage1.Text = "xtraTabPage1"
            ' 
            ' rtbFeatures
            ' 
            Me.rtbFeatures.BackColor = System.Drawing.Color.White
            Me.rtbFeatures.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.rtbFeatures.Dock = System.Windows.Forms.DockStyle.Fill
            Me.rtbFeatures.ForeColor = System.Drawing.Color.Black
            Me.rtbFeatures.Location = New System.Drawing.Point(0, 0)
            Me.rtbFeatures.Name = "rtbFeatures"
            Me.rtbFeatures.ReadOnly = True
            Me.rtbFeatures.Size = New System.Drawing.Size(175, 115)
            Me.rtbFeatures.TabIndex = 1
            Me.rtbFeatures.Text = ""
            ' 
            ' MainFeaturesControl
            ' 
            Me.Controls.Add(Me.xtraTabControl1)
            Me.Name = "MainFeaturesControl"
            Me.Size = New System.Drawing.Size(184, 124)
            CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.xtraTabControl1.ResumeLayout(False)
            Me.xtraTabPage1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        #End Region

        Private Sub rtbFeatures_LinkClicked(ByVal sender As Object, ByVal e As LinkClickedEventArgs) Handles rtbFeatures.LinkClicked
            ProcessLaunchHelper.StartProcess(e.LinkText)
        End Sub

        Private Shared Function LoadResource(ByVal name As String) As System.IO.Stream
            Return FindStream(name, System.Reflection.Assembly.GetExecutingAssembly())
        End Function
        Private Shared Function FindStream(ByVal name As String, ByVal asm As System.Reflection.Assembly) As System.IO.Stream
            Dim stream As System.IO.Stream = asm.GetManifestResourceStream(name)
            If stream Is Nothing Then
                Dim names() As String = name.Split("."c)
                If names.Length >= 2 Then
                    stream = asm.GetManifestResourceStream(String.Format("{0}.{1}", names.GetValue(names.Length - 2), names.GetValue(names.Length - 1)))
                End If
            End If
            Return stream
        End Function
    End Class
End Namespace

