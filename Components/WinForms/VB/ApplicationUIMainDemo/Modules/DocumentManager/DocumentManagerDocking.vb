Imports DevExpress.DXperience.Demos
Imports DevExpress.Skins
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Docking
Imports DevExpress.XtraBars.Docking2010.Views.Tabbed
Imports DevExpress.XtraEditors

Namespace DevExpress.ApplicationUI.Demos
    Partial Public Class DocumentManagerDocking
        Inherits TutorialControlBase
        Public Sub New()
            InitializeComponent()
        End Sub
        Private Sub ScaleElements(Optional ByVal panel As DockPanel = Nothing)
            If panel Is Nothing Then
                For Each rootPanel As DockPanel In dockManager1.RootPanels
                    ScaleElements(rootPanel)
                Next rootPanel
                Return
            End If
            panel.Width = CInt(Math.Truncate(Math.Round(panel.Width * DpiProvider.Default.DpiScaleFactor)))
            panel.Height = CInt(Math.Truncate(Math.Round(panel.Height * DpiProvider.Default.DpiScaleFactor)))
            For Each child As Control In panel.Controls
                If TypeOf child Is DockPanel Then
                    ScaleElements(CType(child, DockPanel))
                End If
            Next child
        End Sub
        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            AddDocument()
            AddDocument()
            AddDocument()
            ScaleElements()
        End Sub
        Private Sub biAddDocumentClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            AddDocument()
        End Sub
        Private i As Integer = 0
        Private Sub AddDocument()
            Dim child As XtraUserControl = New XtraUserControl()
            Dim settings As DocumentSettings = New DocumentSettings()
            settings.Caption = "Document" & (i).ToString()
            i += 1
            settings.Image = imageList1.Images(i Mod (imageList1.Images.Count - 1))
            DocumentSettings.Attach(child, settings)
            child.Padding = New Padding(16)
            Dim label As LabelControl = New LabelControl()
            label.Text = DemosInfo.GetLoremIpsumText(i)
            label.AutoSizeMode = LabelAutoSizeMode.Vertical
            label.Parent = child
            label.Dock = DockStyle.Fill
            tabbedView.AddDocument(child)
        End Sub
    End Class
End Namespace
