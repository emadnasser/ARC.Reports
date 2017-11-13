Imports System
Imports System.Drawing
Imports System.Threading
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.Utils
Imports DevExpress.Utils.Animation
Imports DevExpress.XtraBars.Docking2010
Imports DevExpress.XtraBars.Docking2010.Customization
Imports DevExpress.XtraBars.Docking2010.Views.Tabbed
Imports DevExpress.XtraBars.Docking2010.Views.WindowsUI
Imports DevExpress.XtraEditors
Imports DevExpress.XtraBars.Navigation

Namespace Examples
    <CodeExampleClass("Workspace Manager", "UtilityControls.vb")>
    Public NotInheritable Class WorkspaceManagerSamples

        Private Sub New()
        End Sub

        <CodeExampleSetUp>
        Public Shared Function SetUp(ByVal sampleHost As XtraUserControl) As Object()
            Dim workspaceManagerHost As New XtraUserControl()
            workspaceManagerHost.Parent = sampleHost
            workspaceManagerHost.Dock = DockStyle.Fill
            Dim workspaceManager As New WorkspaceManager()
            Return New Object() {workspaceManager, workspaceManagerHost}
        End Function
        <CodeExampleTearDown>
        Public Shared Sub TearDown(ByVal sampleHost As XtraUserControl)
        End Sub
    End Class
    <CodeExampleClass("Flyout Dialog", "UtilityControls.vb"), CodeExampleHighlightTokens("DockStyle", "FlyoutAction", "FlyoutCommand", "FlyoutDialog", "UserControl", "DialogResult")>
    Public NotInheritable Class FlyoutDialogSamples

        Private Sub New()
        End Sub

        <CodeExampleSetUp>
        Public Shared Function SetUp(ByVal sampleHost As XtraUserControl) As Object()
            Return New Object() {sampleHost}
        End Function
        <CodeExampleTearDown>
        Public Shared Sub TearDown(ByVal sampleHost As XtraUserControl)
        End Sub
        <CodeExampleCase("Show Standard Dialog")>
        Public Shared Sub ShowStandardDialog(ByVal ownerControl As XtraUserControl)
            Dim button As New SimpleButton() With {.Text = "ShowFlyout"}
            button.Dock = DockStyle.Top
            button.Parent = ownerControl
            Dim action As New FlyoutAction()
            action.Caption = "Flyout Action"
            action.Description = "Flyout Action Description"
            action.Commands.Add(FlyoutCommand.OK)
            AddHandler button.Click, Sub(sender, e) FlyoutDialog.Show(ownerControl.FindForm(), action)
        End Sub
        <CodeExampleCase("Show Edit Dialog")>
        Public Shared Sub ShowEditDialog(ByVal ownerControl As XtraUserControl)
            Dim button As New SimpleButton() With {.Text = "ShowFlyout"}
            button.Dock = DockStyle.Top
            button.Parent = ownerControl
            Dim control As New UserControl() With {.Padding = New Padding(0, 30, 0, 20), .Size = New Size(300, 300)}
            Dim textEdit As New TextEdit() With {.Dock = DockStyle.Top}
            textEdit.Parent = control
            Dim okButton As New SimpleButton() With {.Dock = DockStyle.Bottom, .Text = "Ok"}
            okButton.DialogResult = DialogResult.OK
            okButton.Parent = control
            AddHandler button.Click, Sub(sender, e) FlyoutDialog.Show(ownerControl.FindForm(), control)
        End Sub
    End Class
	<CodeExampleClass("Transition Manager", "UtilityControls.vb"), CodeExampleHighlightTokens("Transition", "Color", "SlideFadeTransition", "TransitionManager", "FadeTransition", "LabelControl", "XtraPanel", "SlideFadeTransition", "Thread")>
    Public NotInheritable Class TransitionManagerSamples

        Private Sub New()
        End Sub

        <CodeExampleSetUp>
        Public Shared Function SetUp(ByVal sampleHost As XtraUserControl) As Object()
            Dim transitionManagerHost As New XtraUserControl() With {.Dock = DockStyle.Fill}
            transitionManagerHost.Parent = sampleHost
            Return New Object() {transitionManagerHost}
        End Function
        <CodeExampleTearDown>
        Public Shared Sub TearDown(ByVal sampleHost As XtraUserControl)
        End Sub
		<CodeExampleCase("Show Simple Animation"), CodeExampleUnderlineTokens("Click", "StartTransition", "EndTransition")>
        Public Shared Sub ShowSimpleAnimation(ByVal ownerControl As XtraUserControl)
            Dim transiton As New Transition()
            transiton.Control = ownerControl
            transiton.ShowWaitingIndicator = DefaultBoolean.False
            transiton.TransitionType = New SlideFadeTransition()
            Dim manager As New TransitionManager()
            manager.Transitions.Add(transiton)
            Dim button As New SimpleButton() With {.Text = "Start Transition", .Dock = DockStyle.Top}
            button.Parent = ownerControl
            Dim r As New Random()
            AddHandler button.Click, Sub(sender, e)
                                         manager.StartTransition(ownerControl)
                                         ownerControl.BackColor = Color.FromArgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255))
                                         manager.EndTransition()
                                     End Sub
        End Sub
		<CodeExampleCase("Show Visibility Changed Animation"), CodeExampleUnderlineTokens("Click", "StartTransition", "EndTransition")>
        Public Shared Sub ShowVisibilityChangedAnimation(ByVal ownerControl As XtraUserControl)
            Dim transiton As New Transition()
            transiton.ShowWaitingIndicator = DefaultBoolean.False
            transiton.Control = ownerControl
            transiton.TransitionType = New FadeTransition()
            Dim manager As New TransitionManager()
            manager.Transitions.Add(transiton)
            Dim button As New SimpleButton() With {.Text = "Start Transition", .Dock = DockStyle.Top}
            Dim label As New LabelControl() With {.Text = "Label Control", .Dock = DockStyle.Fill}
            Dim panel As New XtraPanel() With {.Dock = DockStyle.Top, .Size = New Size(100, 50), .Padding = New Padding(10)}
            label.Parent = panel
            panel.Parent = ownerControl
            button.Parent = ownerControl
            Dim r As New Random()
            AddHandler button.Click, Sub(sender, e)
                                         manager.StartTransition(ownerControl)
                                         panel.Visible = Not panel.Visible
                                         manager.EndTransition()
                                     End Sub
        End Sub
		<CodeExampleCase("Show Wait Indicator"), CodeExampleUnderlineTokens("Click", "StartTransition", "EndTransition")>
        Public Shared Sub ShowWaitIndicator(ByVal ownerControl As XtraUserControl)
            Dim transiton As New Transition()
            transiton.Control = ownerControl
            transiton.TransitionType = New SlideFadeTransition()
            Dim manager As New TransitionManager()
            manager.Transitions.Add(transiton)
            Dim button As New SimpleButton() With {.Text = "Start Transition", .Dock = DockStyle.Top}
            button.Parent = ownerControl
            Dim r As New Random()
            AddHandler button.Click, Sub(sender, e)
                                         manager.StartTransition(ownerControl)
                                         ownerControl.BackColor = Color.FromArgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255))
                                         Thread.Sleep(1000)
                                         manager.EndTransition()
                                     End Sub
        End Sub
    End Class
	<CodeExampleClass("NavigationFrame", "UtilityControls.vb"), CodeExampleHighlightTokens("NavigationFrame", "NavigationPage", "NavigationPageContent", "DockStyle", "OfficeNavigationBar", "Color", "SolidBrush", "Pen", "StringFormat", "Font", "StringAlignment", "ControlStyles", "PaintEventArgs", "StringTrimming", "StringFormatFlags","Panel")>
    Public NotInheritable Class NavigationFrameSamples
        Private Sub New()
        End Sub
        <CodeExampleSetUp> _
        Public Shared Function SetUp(ByVal sampleHost As XtraUserControl) As Object()
            Return New Object() {sampleHost}
        End Function
        <CodeExampleTearDown> _
        Public Shared Sub TearDown(ByVal sampleHost As XtraUserControl)
        End Sub
		<CodeExampleCase("Create NavigationFrame", New Type() { GetType(NavigationPageContent) }), CodeExampleUnderlineTokens("SelectNextPage", "SelectPrevPage")>
        Public Shared Sub CreateNavigationFrame(ByVal ownerControl As XtraUserControl)
            Dim nextButton As New SimpleButton() With {.Text = "Select Next Page", .Dock = DockStyle.Top, .Parent = ownerControl}
            Dim prevButton As New SimpleButton() With {.Text = "Select Previous Page", .Dock = DockStyle.Top, .Parent = ownerControl}
            Dim navigationFrame As New NavigationFrame() With {.Dock = DockStyle.Fill, .Parent = ownerControl}
            Dim page1 = New NavigationPage()
            Dim pageContent1 = New NavigationPageContent() With {.Parent = page1, .Dock = DockStyle.Fill, .Text = "Navigation Page 1"}
            Dim page2 = New NavigationPage()
            Dim pageContent2 = New NavigationPageContent() With {.Parent = page2, .Dock = DockStyle.Fill, .Text = "Navigation Page 2"}
            Dim page3 = New NavigationPage()
            Dim pageContent3 = New NavigationPageContent() With {.Parent = page3, .Dock = DockStyle.Fill, .Text = "Navigation Page 3"}
            navigationFrame.Pages.AddRange(New NavigationPage() {page1, page2, page3})
            navigationFrame.BringToFront()
            AddHandler nextButton.Click, Sub(sender, e) navigationFrame.SelectNextPage()
            AddHandler prevButton.Click, Sub(sender, e) navigationFrame.SelectPrevPage()
        End Sub
        <CodeExampleCase("Attach to OfficeNavigationBar", New Type() {GetType(NavigationPageContent)})> _
        Public Shared Sub AttachToOfficeNavigationBar(ByVal ownerControl As XtraUserControl)
            Dim navigationBar As New OfficeNavigationBar() With {.Dock = DockStyle.Bottom, .Parent = ownerControl}
            Dim navigationFrame As New NavigationFrame() With {.Dock = DockStyle.Fill, .Parent = ownerControl}
            Dim page1 = New NavigationPage() With {.Caption = "Page 1"}
            Dim pageContent1 = New NavigationPageContent() With {.Parent = page1, .Dock = DockStyle.Fill, .Text = "Navigation Page 1"}
            Dim page2 = New NavigationPage() With {.Caption = "Page 2"}

            Dim pageContent2 = New NavigationPageContent() With {.Parent = page2, .Dock = DockStyle.Fill, .Text = "Navigation Page 2"}
            Dim page3 = New NavigationPage() With {.Caption = "Page 3"}

            Dim pageContent3 = New NavigationPageContent() With {.Parent = page3, .Dock = DockStyle.Fill, .Text = "Navigation Page 3"}
            navigationFrame.Pages.AddRange(New NavigationPage() {page1, page2, page3})
            navigationFrame.BringToFront()
            navigationBar.NavigationClient = navigationFrame
        End Sub
        <CodeExampleNestedClass> _
        Public Class NavigationPageContent
            Inherits Panel
            Private Shared currentColor As Integer
            Private Shared forecolors() As Color = {Color.Red, Color.Blue, Color.Green}
            Private sb As SolidBrush
            Private pen As Pen
            Private sf As StringFormat
            Private Shared _font As New Font("Segoe UI", 24.0F)
            Public Sub New()
                sf = New StringFormat() With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center, .Trimming = StringTrimming.EllipsisCharacter, .FormatFlags = StringFormatFlags.NoWrap}
                DoubleBuffered = True
                ForeColor = forecolors((currentColor) Mod forecolors.Length)
                currentColor += 1
                SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint, True)
                SetStyle(ControlStyles.ResizeRedraw Or ControlStyles.OptimizedDoubleBuffer, True)
            End Sub
            Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
                If sb Is Nothing Then
                    sb = New SolidBrush(Color.FromArgb(100, ForeColor))
                End If
                If pen Is Nothing Then
                    pen = New Pen(Color.FromArgb(200, 221, 223, 223))
                End If
                e.Graphics.FillRectangle(sb, ClientRectangle)
                e.Graphics.DrawString(Text, _font, sb, ClientRectangle, sf)
            End Sub
        End Class
    End Class
End Namespace
