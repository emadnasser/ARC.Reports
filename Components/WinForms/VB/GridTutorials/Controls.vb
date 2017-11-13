Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Blending
Imports DevExpress.LookAndFeel
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraBars

Namespace DevExpress.XtraGrid.Demos.Tutorials
    Public Class TutorialControl
        Inherits DevExpress.Tutorials.ModuleBase
        Public Overridable ReadOnly Property ShowLookAndFeel() As Boolean
            Get
                Return True
            End Get
        End Property
        Public Overridable ReadOnly Property SetNewWhatsThisPadding() As Boolean
            Get
                Return False
            End Get
        End Property
        Public Overrides Sub StartWhatsThis()
            TutorialsInfo.CloseCustomizationForm(Me)
            If SetNewWhatsThisPadding Then
                Me.Padding = New Padding(8)
                Me.Refresh()
            End If
        End Sub
        Public Overrides Sub EndWhatsThis()
            If SetNewWhatsThisPadding Then
                Me.Padding = New Padding(0)
            End If
        End Sub
        Protected Overrides Sub SetControlManager(ByVal ctrl As Control, ByVal manager As BarManager)
            Dim grid As DevExpress.XtraGrid.GridControl = TryCast(ctrl, DevExpress.XtraGrid.GridControl)
            If Not grid Is Nothing Then
                grid.MenuManager = manager
            End If
        End Sub
        Public Shared ReadOnly Property Is64BitOS() As Boolean
            Get
                Return False
            End Get
        End Property
#Region "InitData"
        Protected Overridable Sub InitNWindData()
            Dim DBFileName As String = String.Empty
            If Is64BitOS Then
                DBFileName = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\nwind.xml")
                If DBFileName <> String.Empty Then
                    InitXMLData(DBFileName)
                End If
            Else
                DBFileName = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\nwind.mdb")
                If DBFileName <> String.Empty Then
                    InitMDBData("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & DBFileName)
                End If
            End If
        End Sub
        Protected Overridable Sub InitMDBData(ByVal connectionString As String)
        End Sub
        Protected Overridable Sub InitXMLData(ByVal dataFileName As String)
        End Sub
#End Region
    End Class
    Public Class GridTutorialMenu
        Inherits DevExpress.DXperience.Demos.LookAndFeelMenu
        Public Sub New(ByVal manager As BarManager, ByVal lookAndFeel As DefaultLookAndFeel, ByVal about As String)
            MyBase.New(manager, lookAndFeel, about)
        End Sub
        Protected Overrides ReadOnly Property ProductName() As String
            Get
                Return "XtraGrid"
            End Get
        End Property
        Protected Overrides Sub biProductWebPage_Click(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            System.Diagnostics.Process.Start("http://www.devexpress.com/Products/NET/WinForms/XtraGrid/")
        End Sub
        Protected Overrides Sub miAboutProduct_Click(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            GridControl.About()
        End Sub
    End Class
    Public Class InitHelper
        Public Shared Sub InitAdvBandedView(ByVal grid As GridControl)
            InitData(grid)
            InitViewLayout(grid)
        End Sub
        Private Shared Sub InitData(ByVal grid As GridControl)
            Dim DBFileName As String = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\Cars.xml")
            If DBFileName <> "" Then
                Dim dataSet As DataSet = New DataSet()
                dataSet.ReadXml(DBFileName)
                grid.DataSource = dataSet.Tables(0).DefaultView
            End If
        End Sub

        Private Shared Sub InitViewLayout(ByVal grid As GridControl)
            Dim LayoutFileName As String = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\Layouts\cars_AdvBandedView.xml")
            If LayoutFileName <> "" Then
                InitEditors(grid)
                grid.MainView.RestoreLayoutFromXml(LayoutFileName, Nothing)
            End If
        End Sub

        Private Shared Sub InitEditors(ByVal grid As GridControl)
            Dim itemPictureEdit As RepositoryItemPictureEdit = New RepositoryItemPictureEdit()
            Dim itemRadioGroup As RepositoryItemRadioGroup = New RepositoryItemRadioGroup()
            Dim itemSpinEdit As RepositoryItemSpinEdit = New RepositoryItemSpinEdit()
            Dim itemCalcEdit As RepositoryItemCalcEdit = New RepositoryItemCalcEdit()
            Dim itemImageComboBox As RepositoryItemImageComboBox = New RepositoryItemImageComboBox()
            itemPictureEdit.Name = "repositoryItemPictureEdit1"
            itemSpinEdit.Name = "repositoryItemSpinEdit1"
            itemCalcEdit.Name = "repositoryItemCalcEdit1"
            itemRadioGroup.Name = "repositoryItemRadioGroup1"
            itemImageComboBox.Name = "repositoryItemImageComboBox1"
            itemSpinEdit.IsFloatValue = False
            itemPictureEdit.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
            itemImageComboBox.Items.AddRange(New Object() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Sports", "SPORTS", -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Saloon", "SALOON", -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Truck", "TRUCK", -1)})
            itemRadioGroup.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("Yes", "Yes"), New DevExpress.XtraEditors.Controls.RadioGroupItem("No", "No")})
            grid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {itemPictureEdit, itemRadioGroup, itemSpinEdit, itemCalcEdit, itemImageComboBox})
        End Sub
    End Class
End Namespace
