Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.Skins

Namespace DevExpress.XtraLayout.Demos
    Partial Public Class ImageLayout
        Inherits TutorialControl
        Public Sub New()
            InitializeComponent()
        End Sub
        Private sImage As Image = Nothing
        Private skinColor As Color
        Private sMargings As SkinPaddingEdges
        Protected Sub ModifyActualSkin(ByVal visible As Boolean)
            Dim groupElement As SkinElement = DevExpress.Skins.CommonSkins.GetSkin(layoutControl1.LookAndFeel)(DevExpress.Skins.CommonSkins.SkinGroupPanel)
            Dim itemElement As SkinElement = DevExpress.Skins.CommonSkins.GetSkin(layoutControl1.LookAndFeel)(DevExpress.Skins.CommonSkins.SkinLayoutItemBackground)
            If visible Then
                sImage = groupElement.Image.Image
                groupElement.Image.Image = Nothing
                skinColor = groupElement.Color.BackColor
                groupElement.Color.BackColor = Color.FromArgb(222, 227, 232)
                sMargings = itemElement.ContentMargins
                itemElement.ContentMargins.All = 0
                layoutControl1.Refresh()
            Else
                groupElement.Image.Image = sImage
                groupElement.Color.BackColor = skinColor
                itemElement.ContentMargins.Bottom = sMargings.Bottom
                itemElement.ContentMargins.Left = sMargings.Left
                itemElement.ContentMargins.Right = sMargings.Right
                itemElement.ContentMargins.Top = sMargings.Top
            End If
            Dim form As Form = Me.FindForm()
            form.Invalidate(True)
            form.Update()
        End Sub
        Private Sub pictureEdit2_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles pictureEdit2.MouseUp
            labelControl2.Text = "The design of a Porsche always speaks in a universal language: People everywhere love to drive. But something about a Boxster speaks with a voice like that of a Siren. It calls to you, and resistance seems futile. What its aerodynamically chiseled exterior promises is too enticing. What its aesthetically intelligent interior conveys is too compelling. If driving is your passion, there is no substitute for the sheer inspiration of the Boxster."
            labelControl1.Text = "Boxster"
            pictureEdit5.Image = DevExpress.Utils.ResourceImageHelper.CreateBitmapFromResources("Boxster.jpg", GetType(frmMain).Assembly)

        End Sub

        Private Sub pictureEdit4_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles pictureEdit4.MouseUp
            labelControl2.Text = "Tour the Cayman's front, side and rear surfaces with your eyes, and you immediately sense Porsche's love of curves. The body's muscular, sculpted features are thought by some to be an adaptation of the twists and turns found along our favorite roads. Each meeting of convex and concave surfaces is designed to move the air and the drivers soul with equal ease."
            labelControl1.Text = "Cayman"
            pictureEdit5.Image = DevExpress.Utils.ResourceImageHelper.CreateBitmapFromResources("cayman.jpg", GetType(frmMain).Assembly)
        End Sub

        Private Sub pictureEdit1_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles pictureEdit1.MouseUp
            labelControl2.Text = "In terms of engineering, the 911 offers a simple definition of precision: Improve that which is essential. Remove that which is not. Focus on that which matters most: the driver. This same set of principles is also expressed in the all-new passenger compartment."
            labelControl1.Text = "911"
            pictureEdit5.Image = DevExpress.Utils.ResourceImageHelper.CreateBitmapFromResources("911.jpg", GetType(frmMain).Assembly)

        End Sub

        Private Sub pictureEdit3_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles pictureEdit3.MouseUp
            labelControl2.Text = "The Porsche Cayenne is a mid-size luxury SUV produced by the German automaker Porsche since 2002. It is the first V8 engined vehicle built by Porsche since 1995, when the Porsche 928 was discontinued. Sales of the Cayenne have been strong, with 100,000 sold as of June 2005, becoming Porsche's best-selling vehicle in North America. 40% of Cayenne sales are in North America. Sales slowed by 2006. The Cayenne was skipped for the 2007 model year, but has been redesigned for 2008."
            labelControl1.Text = "Cayenne"
            pictureEdit5.Image = DevExpress.Utils.ResourceImageHelper.CreateBitmapFromResources("Cayenne.jpg", GetType(frmMain).Assembly)

        End Sub
        Public Overrides Property RibbonMenuManager() As DXperience.Demos.RibbonMenuManager
            Get
                Return MyBase.RibbonMenuManager
            End Get
            Set(ByVal value As DXperience.Demos.RibbonMenuManager)
                MyBase.RibbonMenuManager = value
                ModifyActualSkin(Not value Is Nothing)
            End Set
        End Property
        Private Sub ImageLayout_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            pictureEdit2.Focus()
            pictureEdit2_MouseUp(Me, New MouseEventArgs(Windows.Forms.MouseButtons.Left, 0, 0, 0, 0))
        End Sub
    End Class
End Namespace
