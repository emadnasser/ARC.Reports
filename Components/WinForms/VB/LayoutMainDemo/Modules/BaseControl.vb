Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.Controls

Namespace DevExpress.XtraLayout.Demos
    Partial Public Class BaseTutorialControl
        Inherits DevExpress.XtraLayout.Demos.TutorialControl

        Private layoutName As String = "Default.xml"
        Private fCustomization As Boolean = False
        Public Sub New()
            InitializeComponent()
            DisableLoadButton()
            If Skins.DpiProvider.Default.DpiScaleFactor > 1.4 Then
                Me.navigationPage1.ImageUri.Uri = "Properties;Size32x32;Office2013"
            End If
            Customization = False
            AddHandler cbFiles.EditValueChanged, AddressOf cbFiles_EditValueChanged
            AddHandler cbFiles.Properties.ButtonClick, AddressOf cbFiles_Properties_ButtonClick
        End Sub
        Public Overrides ReadOnly Property ExportControl() As LayoutControl
            Get
                Return BaseLayout
            End Get
        End Property
        Public Overridable ReadOnly Property BaseLayout() As LayoutControl
            Get
                Return Nothing
            End Get
        End Property
        Protected Overridable ReadOnly Property FileMask() As String
            Get
                Return "xtra"
            End Get
        End Property
        Private Sub cbFiles_Properties_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs)
            If e.Button.Index = 1 Then
                If BaseLayout Is Nothing Then
                    Return
                End If
                BaseLayout.RestoreLayoutFromXml(CurrentXMLFileName)
                layoutName = ""
            End If
        End Sub
        Private Sub cbFiles_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
            DisableLoadButton()
        End Sub
        Private Sub DisableLoadButton()
            Dim btn As XtraEditors.Controls.EditorButton = cbFiles.Properties.Buttons.Item(1)
            btn.Enabled = Not String.IsNullOrEmpty(cbFiles.Text) And Not cbFiles.Text.Equals(layoutName)
        End Sub
        Protected Sub InitPanels()
            navigationPage1.Visible = BaseLayout IsNot Nothing
            If BaseLayout IsNot Nothing Then
                Dim XmlFileNames As ArrayList = FindingXmlFiles(Application.StartupPath, "Data\FormLayouts\", FileMask)
                If XmlFileNames.Count = 0 Then
                    navigationPage1.Visible = False
                End If
                cbFiles.Properties.Items.Clear()
                For Each obj As Object In XmlFileNames
                    cbFiles.Properties.Items.Add(obj)
                Next obj
                AddHandler BaseLayout.ShowCustomization, AddressOf ShowCustomization
                AddHandler BaseLayout.HideCustomization, AddressOf HideCustomization
                BaseLayout.OptionsView.AllowExpandAnimation = DevExpress.Utils.DefaultBoolean.True
                BaseLayout.OptionsCustomizationForm.ShowPropertyGrid = True
                BaseLayout.OptionsCustomizationForm.SnapMode = DevExpress.Utils.Controls.SnapMode.All
            End If
        End Sub
        Public Property Customization() As Boolean
            Get
                Return fCustomization
            End Get
            Set(ByVal value As Boolean)
                fCustomization = value
                sbCustomize.Text = If(fCustomization, "Hide Customization Form", "Show Customization Form")
            End Set
        End Property
        Private Sub ShowCustomization(ByVal sender As Object, ByVal e As EventArgs)
            Customization = True
        End Sub
        Private Sub HideCustomization(ByVal sender As Object, ByVal e As EventArgs)
            Customization = False
        End Sub
        Private Sub BaseTutorialControl_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        End Sub

        Private ReadOnly Property CurrentXMLFileName() As String
            Get
                Dim file As XMLFileName = TryCast(cbFiles.SelectedItem, XMLFileName)
                If file Is Nothing Then
                    Return ""
                End If
                Return file.FullName
            End Get
        End Property
        Private Sub Restore()
            If BaseLayout Is Nothing Or String.IsNullOrEmpty(CurrentXMLFileName) Then
                Return
            End If
            BaseLayout.RestoreLayoutFromXml(CurrentXMLFileName)
            tabTransitionAnimation_CheckedChanged(Nothing, Nothing)
            layoutName = ""
        End Sub
        Private Sub Store()
            If BaseLayout Is Nothing Then
                Return
            End If
            BaseLayout.SaveLayoutToXml("Temp.xml")
        End Sub
#Region "Finding Xml Files"
        Public Shared Function FindingXmlFiles(ByVal path As String, ByVal path1 As String, ByVal mask As String) As ArrayList
            Dim s As String = "\"
            Dim xmlFiles As New ArrayList()
            For i As Integer = 0 To 10
                If System.IO.Directory.Exists(path & s & path1) Then
                    Dim names() As String = System.IO.Directory.GetFiles(path & s & path1, mask & "*.xml")
                    'INSTANT VB NOTE: The variable name was renamed since Visual Basic does not handle local variables named the same as class members well:
                    For Each name_Renamed As String In names
                        Dim fInfo As New System.IO.FileInfo(name_Renamed)
                        Dim fName As String = fInfo.Name
                        fName = fName.Replace(mask, "")
                        xmlFiles.Add(New XMLFileName(fName, fInfo.FullName))
                    Next name_Renamed
                    Return xmlFiles
                Else
                    s &= "..\"
                End If
            Next i
            Return xmlFiles
        End Function

        Private Class XMLFileName
            Private fName, fFullName As String
            Public Sub New(ByVal name As String, ByVal fullName As String)
                Me.fName = name
                Me.fFullName = fullName
            End Sub
            Public ReadOnly Property Name() As String
                Get
                    Return fName
                End Get
            End Property
            Public ReadOnly Property FullName() As String
                Get
                    Return fFullName
                End Get
            End Property
            Public Overrides Function ToString() As String
                Return Name
            End Function
        End Class
#End Region

        Protected Overrides Sub DoHide()
            If BaseLayout IsNot Nothing Then
                BaseLayout.HideCustomizationForm()
            End If
            lcTitle.HideCustomizationForm()
        End Sub

        Private Sub sbCustomize_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbCustomize.Click
            If BaseLayout Is Nothing Then
                Return
            End If
            If Customization Then
                BaseLayout.HideCustomizationForm()
            Else
                BaseLayout.ShowCustomizationForm()
            End If
        End Sub


        Private Sub allowItemSkinningCheckEdit_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles allowItemSkinningCheckEdit.CheckedChanged
            If BaseLayout Is Nothing Then
                Return
            End If
            BaseLayout.OptionsView.AllowItemSkinning = allowItemSkinningCheckEdit.Checked
            highlightFocusedItemCheckEdit.Enabled = allowItemSkinningCheckEdit.Checked
        End Sub

        Private Sub highlightFocusedItemCheckEdit_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles highlightFocusedItemCheckEdit.CheckedChanged
            If BaseLayout Is Nothing Then
                Return
            End If
            BaseLayout.OptionsView.HighlightFocusedItem = highlightFocusedItemCheckEdit.Checked
        End Sub

        Private Sub checkEdit5_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles quickCustomizationCheckEdit.CheckedChanged
            If BaseLayout Is Nothing Then
                Return
            End If
            If quickCustomizationCheckEdit.Checked = True Then
                BaseLayout.CustomizationMode = CustomizationModes.Quick
            Else
                BaseLayout.CustomizationMode = CustomizationModes.Default
            End If
        End Sub

        Private Sub checkEdit6_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles showAdornerLayerCheckEdit.CheckedChanged
            BaseLayout.OptionsView.DrawAdornerLayer = If(showAdornerLayerCheckEdit.Checked, DevExpress.Utils.DefaultBoolean.True, DevExpress.Utils.DefaultBoolean.False)
        End Sub

        Private Sub allowExpandAnimationCheckEdit_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles allowExpandAnimationCheckEdit.CheckedChanged
            BaseLayout.OptionsView.AllowExpandAnimation = If(allowExpandAnimationCheckEdit.Checked, DevExpress.Utils.DefaultBoolean.True, DevExpress.Utils.DefaultBoolean.False)
        End Sub

        Private Sub showPropertyGridCheckEdit_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles showPropertyGridCheckEdit.CheckedChanged
            BaseLayout.OptionsCustomizationForm.ShowPropertyGrid = showPropertyGridCheckEdit.Checked
        End Sub

        Private Sub snapModeCheckEdit_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles snapModeCheckEdit.CheckedChanged
            If snapModeCheckEdit.Checked Then
                BaseLayout.OptionsCustomizationForm.SnapMode = DevExpress.Utils.Controls.SnapMode.All
            Else
                BaseLayout.OptionsCustomizationForm.SnapMode = DevExpress.Utils.Controls.SnapMode.None
            End If
        End Sub

        Private Sub tabTransitionAnimation_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles tabTransitionAnimationCheckEdit.CheckedChanged
            SetTransition(tabTransitionAnimationCheckEdit.Checked)
        End Sub

        Private Sub SetTransition(ByVal value As Boolean)
            For Each item As BaseLayoutItem In BaseLayout.Items
                Dim tcg As TabbedControlGroup = TryCast(item, TabbedControlGroup)
                If tcg Is Nothing Then
                    Continue For
                End If
                tcg.Transition.AllowTransition = If(value, DevExpress.Utils.DefaultBoolean.True, DevExpress.Utils.DefaultBoolean.False)
            Next item
        End Sub
    End Class
End Namespace

