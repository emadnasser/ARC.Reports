Namespace DevExpress.DevAV
    Partial Public Class DetailForm
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

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(DetailForm))
            Me.ribbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
            Me.biGetStarted = New DevExpress.XtraBars.BarButtonItem()
            Me.biGetSupport = New DevExpress.XtraBars.BarButtonItem()
            Me.biBuyNow = New DevExpress.XtraBars.BarButtonItem()
            Me.biAbout = New DevExpress.XtraBars.BarButtonItem()
            Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
            CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.ribbonControl.ExpandCollapseItem.Id = 0
            Me.ribbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.ribbonControl.ExpandCollapseItem, Me.biGetStarted, Me.biGetSupport, Me.biBuyNow, Me.biAbout})
            Me.ribbonControl.Location = New System.Drawing.Point(0, 0)
            Me.ribbonControl.MaxItemId = 5
            Me.ribbonControl.Name = "ribbonControl"
            Me.ribbonControl.OptionsTouch.ShowTouchUISelectorInQAT = True
            Me.ribbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.ribbonPage1})
            Me.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013
            Me.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False
            Me.ribbonControl.Size = New System.Drawing.Size(1004, 143)
            Me.ribbonControl.StatusBar = Me.ribbonStatusBar1
            Me.ribbonControl.TransparentEditors = True
            Me.biGetStarted.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.biGetStarted.Caption = "Getting Started"
            Me.biGetStarted.Id = 1
            Me.biGetStarted.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biGetStarted.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.GettingStarted.svg"
            Me.biGetStarted.Name = "biGetStarted"
            Me.biGetSupport.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.biGetSupport.Caption = "Get Free Support"
            Me.biGetSupport.Id = 2
            Me.biGetSupport.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biGetSupport.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Support.svg"
            Me.biGetSupport.Name = "biGetSupport"
            Me.biBuyNow.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.biBuyNow.Caption = "Buy Now"
            Me.biBuyNow.Id = 3
            Me.biBuyNow.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biBuyNow.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Buy.svg"
            Me.biBuyNow.Name = "biBuyNow"
            Me.biAbout.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.biAbout.Caption = "About"
            Me.biAbout.Id = 4
            Me.biAbout.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biAbout.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.About.svg"
            Me.biAbout.Name = "biAbout"
            Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.ribbonPageGroup1})
            Me.ribbonPage1.Name = "ribbonPage1"
            Me.ribbonPage1.Text = "DX"
            Me.ribbonPageGroup1.AllowTextClipping = False
            Me.ribbonPageGroup1.ItemLinks.Add(Me.biGetStarted)
            Me.ribbonPageGroup1.ItemLinks.Add(Me.biGetSupport)
            Me.ribbonPageGroup1.ItemLinks.Add(Me.biBuyNow)
            Me.ribbonPageGroup1.ItemLinks.Add(Me.biAbout)
            Me.ribbonPageGroup1.MergeOrder = 1
            Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
            Me.ribbonPageGroup1.ShowCaptionButton = False
            Me.ribbonPageGroup1.Text = "DevExpress"
            Me.ribbonStatusBar1.Location = New System.Drawing.Point(0, 767)
            Me.ribbonStatusBar1.Name = "ribbonStatusBar1"
            Me.ribbonStatusBar1.Ribbon = Me.ribbonControl
            Me.ribbonStatusBar1.Size = New System.Drawing.Size(1004, 31)
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1004, 798)
            Me.Controls.Add(Me.ribbonStatusBar1)
            Me.Controls.Add(Me.ribbonControl)
            Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow
            Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
            Me.Name = "DetailForm"
            Me.Ribbon = Me.ribbonControl
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.StatusBar = Me.ribbonStatusBar1
            Me.Text = "DevAV"
            CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        #End Region

        Private ribbonControl As XtraBars.Ribbon.RibbonControl
        Private ribbonStatusBar1 As XtraBars.Ribbon.RibbonStatusBar
        Private ribbonPage1 As XtraBars.Ribbon.RibbonPage
        Private ribbonPageGroup1 As XtraBars.Ribbon.RibbonPageGroup
        Private biGetStarted As XtraBars.BarButtonItem
        Private biGetSupport As XtraBars.BarButtonItem
        Private biBuyNow As XtraBars.BarButtonItem
        Private biAbout As XtraBars.BarButtonItem
    End Class
End Namespace
