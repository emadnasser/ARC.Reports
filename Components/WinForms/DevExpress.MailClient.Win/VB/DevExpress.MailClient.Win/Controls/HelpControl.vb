Imports System.ComponentModel
Imports System.Text
Imports DevExpress.Utils
Imports DevExpress.Utils.About

Namespace DevExpress.MailClient.Win.Controls
    Partial Public Class HelpControl
        Inherits RibbonApplicationUserControl

        Private aboutPanel As Form
        Private isLoaded As Boolean

        Public Sub New()
            Me.isLoaded = False
            InitializeComponent()
            AddHandler Load, AddressOf HelpControl_Load
        End Sub

        Private Sub HelpControl_Load(ByVal sender As Object, ByVal e As EventArgs)
            If isLoaded Then
                Return
            End If
            aboutPanel = New AboutForm12(New ProductInfo(ProductKind.DXperienceWin, New ProductStringInfo("WinForms Controls", "Build Your Own Office")))
            aboutPanel.TopLevel = False
            aboutPanel.Parent = splitContainer1.Panel2
            ResizeAbout()
            aboutPanel.Show()
            AddHandler splitContainer1.Panel2.Resize, AddressOf Panel2_Resize
            ResizeAbout()
            Me.isLoaded = True
        End Sub

        Private Sub Panel2_Resize(ByVal sender As Object, ByVal e As EventArgs)
            ResizeAbout()
        End Sub
        Private Sub ResizeAbout()
            Dim pnl As Panel = TryCast(aboutPanel.Parent, Panel)
            aboutPanel.Location = New Point((pnl.Width - aboutPanel.Width) \ 2, (pnl.Height - aboutPanel.Height) \ 2)
        End Sub
        Private Sub galleryControlGallery1_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs) Handles galleryControl1.Gallery.ItemClick
            Dim link As String = String.Format("{0}", e.Item.Tag)
            Select Case link
                Case "LinkHelp"
                    link = AssemblyInfo.DXLinkHelp
                Case "LinkGetSupport"
                    link = AssemblyInfo.DXLinkGetSupport
                Case "LinkGetStarted"
                    link = AssemblyInfo.DXLinkGetStarted
            End Select
            If Not String.IsNullOrEmpty(link) Then
                ObjectHelper.StartProcess(link)
            End If
        End Sub
    End Class
End Namespace
