Imports System.Reflection
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Blending
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Card
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.LookAndFeel
Imports DevExpress.XtraBars
Imports DevExpress.DXperience.Demos
Imports DevExpress.XtraExport
Imports DevExpress.XtraGrid.Export
Imports DevExpress.XtraBars.Ribbon

Namespace DevExpress.XtraGrid.Demos
    Public Class GridRibbonMenuManager
        Inherits RibbonMenuManager

        Private view As BaseView = Nothing
        Private blending As XtraGridBlending = Nothing
        Private bsiViewOptions, bsiSelectionOptions As BarSubItem
        Private bciAlphaBlendingUsing As BarCheckItem
        Private bbiAlphaBlendingAdjustment As BarButtonItem
        Private xapp As DevExpress.XtraGrid.Design.XAppearances = Nothing
        Public Sub New(ByVal form As RibbonMainForm)
            MyBase.New(form)
            CreateOptionsMenu(form.ReservGroup1, form.Ribbon)
            CreateBlendingMenu(form.ReservGroup2, form.Ribbon)
        End Sub
        Private Sub CreateBlendingMenu(ByVal ribbonPageGroup As RibbonPageGroup, ByVal ribbonControl As RibbonControl)
            ribbonPageGroup.Text = My.Resources.AlphaBlending
            bciAlphaBlendingUsing = New CheckBarItem(Manager, My.Resources.UsingString, New ItemClickEventHandler(AddressOf miUsing_Click))
            bbiAlphaBlendingAdjustment = New ButtonBarItem(Manager, My.Resources.Adjustment, New ItemClickEventHandler(AddressOf miAdjustment_Click))
            bbiAlphaBlendingAdjustment.Glyph = DevExpress.Utils.ResourceImageHelper.CreateImageFromResources("Blending.png", GetType(frmMain).Assembly)
            ribbonPageGroup.ItemLinks.Add(bciAlphaBlendingUsing)
            ribbonPageGroup.ItemLinks.Add(bbiAlphaBlendingAdjustment)
        End Sub
        Private Sub CreateOptionsMenu(ByVal ribbonPageGroup As RibbonPageGroup, ByVal ribbonControl As RibbonControl)
            ribbonPageGroup.Text = My.Resources.Options
            bsiViewOptions = New BarSubItem()
            bsiSelectionOptions = New BarSubItem()
            bsiViewOptions.Caption = My.Resources.ViewOptions
            bsiSelectionOptions.Caption = My.Resources.SelectionOptions
            MainFormHelper.SetBarButtonImage(bsiViewOptions, "View")
            MainFormHelper.SetBarButtonImage(bsiSelectionOptions, "LayoutOptions")
            ribbonControl.Items.Add(bsiViewOptions)
            ribbonControl.Items.Add(bsiSelectionOptions)
            ribbonPageGroup.ItemLinks.Add(bsiViewOptions)
            ribbonPageGroup.ItemLinks.Add(bsiSelectionOptions)
        End Sub
        Public ReadOnly Property XAppearances() As DevExpress.XtraGrid.Design.XAppearances
            Get
                If xapp Is Nothing Then
                    xapp = New DevExpress.XtraGrid.Design.XAppearances("System", True)
                End If
                Return xapp
            End Get
        End Property
        Public Sub RefreshOptionsMenu(ByVal view As BaseView)
            Dim ov As New GridOptionsView()

            ShowReservGroup1(view IsNot Nothing)
            Me.view = view
            LookAndFeelMenu.ClearOptionItems(Manager)
            LookAndFeelMenu.AddOptionsMenu(bsiViewOptions, ViewOptions, New ItemClickEventHandler(AddressOf miViewOptions_Click), Manager)
            LookAndFeelMenu.AddOptionsMenu(bsiSelectionOptions, SelectionOptions, New ItemClickEventHandler(AddressOf miSelectionViewOptions_Click), Manager)
        End Sub
        Private ReadOnly Property ViewOptions() As Object
            Get
                If TypeOf view Is GridView Then
                    Return CType(view, GridView).OptionsView
                End If
                If TypeOf view Is CardView Then
                    Return CType(view, CardView).OptionsView
                End If
                Return Nothing
            End Get
        End Property
        Private ReadOnly Property SelectionOptions() As Object
            Get
                If TypeOf view Is GridView Then
                    Return CType(view, GridView).OptionsSelection
                End If
                Return Nothing
            End Get
        End Property
        Private Sub miViewOptions_Click(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Dim item As OptionBarItem = TryCast(e.Item, OptionBarItem)
            If view IsNot Nothing AndAlso item IsNot Nothing Then
                DevExpress.Utils.SetOptions.SetOptionValueByString(item.Tag.ToString(), ViewOptions, item.Checked)
                LookAndFeelMenu.InitOptionsMenu(bsiViewOptions, ViewOptions)
            End If
        End Sub
        Private Sub miSelectionViewOptions_Click(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Dim item As OptionBarItem = TryCast(e.Item, OptionBarItem)
            If view IsNot Nothing AndAlso item IsNot Nothing Then
                DevExpress.Utils.SetOptions.SetOptionValueByString(item.Tag.ToString(), SelectionOptions, item.Checked)
                LookAndFeelMenu.InitOptionsMenu(bsiSelectionOptions, SelectionOptions)
            End If
        End Sub
        Public Sub InitBlendingMenu(ByVal blending As XtraGridBlending)
            Me.blending = blending
            ShowReservGroup2(blending IsNot Nothing)
            If blending IsNot Nothing Then
                bciAlphaBlendingUsing.Checked = blending.Enabled
                bbiAlphaBlendingAdjustment.Enabled = blending.Enabled
            End If
        End Sub
        Private Sub miUsing_Click(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Application.DoEvents()
            Dim item As CheckBarItem = TryCast(e.Item, CheckBarItem)
            If blending IsNot Nothing AndAlso item IsNot Nothing Then
                blending.Enabled = item.Checked
                bbiAlphaBlendingAdjustment.Enabled = item.Checked
            End If
        End Sub
        Private Sub miAdjustment_Click(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            If blending IsNot Nothing Then
                blending.ShowDialog()
            End If
        End Sub
    End Class
    Public Class TutorialControl
        Inherits DevExpress.DXperience.Demos.TutorialControlBase

        Public ReadOnly Property GridRibbonMenuManager() As GridRibbonMenuManager
            Get
                Return TryCast(RibbonMenuManager, GridRibbonMenuManager)
            End Get
        End Property
        Protected Overrides Sub SetControlManager(ByVal ctrl As Control, ByVal manager As BarManager)
            Dim grid As DevExpress.XtraGrid.GridControl = TryCast(ctrl, DevExpress.XtraGrid.GridControl)
            If grid IsNot Nothing Then
                grid.MenuManager = manager
            End If
            Dim be As BaseEdit = TryCast(ctrl, BaseEdit)
            If be IsNot Nothing Then
                be.MenuManager = manager
            End If
        End Sub
        Protected Overrides Sub AllowExport()
            EnabledPrintExportActions(True, ExportFormats.PDF Or ExportFormats.HTML Or ExportFormats.MHT Or ExportFormats.XLS Or ExportFormats.RTF Or ExportFormats.Text Or ExportFormats.XLSX, False)
        End Sub
        Public Overrides ReadOnly Property AllowPrintOptions() As Boolean
            Get
                Return ExportView IsNot Nothing
            End Get
        End Property
        Public Overridable ReadOnly Property ExportView() As BaseView
            Get
                Return Nothing
            End Get
        End Property
        Public Overridable ReadOnly Property ShowViewOptions() As Boolean
            Get
                Return False
            End Get
        End Property
        Protected Overridable ReadOnly Property PaintViews() As PaintView()
            Get
                Return Nothing
            End Get
        End Property
#Region "InitData"
        Protected Overridable Sub InitNWindData()
            Dim DBFileName As String = String.Empty

            DBFileName = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\nwind.mdb")
            If DBFileName <> String.Empty Then
                InitMDBData("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & DBFileName)
            End If
        End Sub
        Protected Friend Overridable Sub UpdateRibbonItems()
        End Sub
        Protected Overridable Sub InitVehiclesData()
            Dim DBFileName As String = String.Empty

            DBFileName = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\Vehicles.mdb")
            If DBFileName <> String.Empty Then
                InitMDBData("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & DBFileName)
            End If
        End Sub
        Protected Overridable Sub InitMDBData(ByVal connectionString As String)
        End Sub
        Protected Overridable Sub InitXMLData(ByVal dataFileName As String)
        End Sub
        Protected Overridable Function NWindDataSet() As DataSet
            Dim DBFileName As String = String.Empty
            Dim ds As New DataSet()

            DBFileName = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\nwind.mdb")
            If DBFileName <> String.Empty Then
                InitMDBData("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & DBFileName, ds)
            End If
            Return ds
        End Function
        Protected Overridable Sub InitMDBData(ByVal connectionString As String, ByVal ds As DataSet)
        End Sub
        Protected Overridable Sub InitXMLData(ByVal dataFileName As String, ByVal ds As DataSet)
        End Sub
        Protected Overridable Sub InitIssueListData(ByVal ds As dsIssueList)
            Dim DBFileName As String = String.Empty

            DBFileName = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\IssueList.mdb")
            If DBFileName <> String.Empty Then
                Dim con As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & DBFileName
                Dim oleDbDataAdapter As New System.Data.OleDb.OleDbDataAdapter("SELECT * FROM Departments", con)
                SetWaitDialogCaption(My.Resources.LoadingDepartments)
                oleDbDataAdapter.Fill(ds.Departments)
                oleDbDataAdapter = New System.Data.OleDb.OleDbDataAdapter("SELECT * FROM Users", con)
                SetWaitDialogCaption(My.Resources.LoadingUsers)
                oleDbDataAdapter.Fill(ds.Users)
                oleDbDataAdapter = New System.Data.OleDb.OleDbDataAdapter("SELECT * FROM Projects", con)
                SetWaitDialogCaption(My.Resources.LoadingProjects)
                oleDbDataAdapter.Fill(ds.Projects)
                oleDbDataAdapter = New System.Data.OleDb.OleDbDataAdapter("SELECT * FROM Items", con)
                SetWaitDialogCaption(My.Resources.LoadingItems)
                oleDbDataAdapter.Fill(ds.Items)
            End If
        End Sub
        Protected Overridable Sub InitXMLData(ByVal ds As DataSet)
        End Sub
        Protected Overridable Sub InitCustomersPaymentData(ByVal ds As dsContacts)
            Dim DBFileName As String = String.Empty

            DBFileName = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\Contacts.mdb")
            If DBFileName <> String.Empty Then
                Dim con As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & DBFileName
                Dim oleDBAdapter As New System.Data.OleDb.OleDbDataAdapter("SELECT * FROM CustomersPayment", con)

                SetWaitDialogCaption(My.Resources.LoadingCustomerPayment)
                oleDBAdapter.Fill(ds.CustomersPayment)
            End If
        End Sub
#End Region
#Region "Print and Export"
        Protected Overrides Sub ExportToCore(ByVal filename As String, ByVal ext As String)
            If ExportView Is Nothing Then
                Return
            End If
            Dim currentCursor As Cursor = Cursor.Current
            Cursor.Current = Cursors.WaitCursor
            If ext = "rtf" Then
                ExportView.ExportToRtf(filename)
            End If
            If ext = "pdf" Then
                ExportView.ExportToPdf(filename)
            End If
            If ext = "mht" Then
                ExportView.ExportToMht(filename)
            End If
            If ext = "html" Then
                ExportView.ExportToHtml(filename)
            End If
            If ext = "txt" Then
                ExportView.ExportToText(filename)
            End If
            If ext = "xls" Then
                ExportView.ExportToXls(filename)
            End If
            If ext = "xlsx" Then
                ExportView.ExportToXlsx(filename)
            End If
            Cursor.Current = currentCursor
        End Sub
        Protected Overrides Sub ExportToPDF()
            ExportTo("pdf", My.Resources.PDFFilter)
        End Sub
        Protected Overrides Sub ExportToHTML()
            ExportTo("html", My.Resources.HTMLFilter)
        End Sub
        Protected Overrides Sub ExportToMHT()
            ExportTo("mht", My.Resources.MHTFilter)
        End Sub
        Protected Overrides Sub ExportToXLS()
            ExportTo("xls", My.Resources.XLSFilter)
        End Sub
        Protected Overrides Sub ExportToXLSX()
            ExportTo("xlsx", My.Resources.XLSXFilter)
        End Sub
        Protected Overrides Sub ExportToRTF()
            ExportTo("rtf", My.Resources.RTFFilter)
        End Sub
        Protected Overrides Sub ExportToText()
            ExportTo("txt", My.Resources.TextFilter)
        End Sub
        Protected Overrides Sub PrintPreview()
            If Me.ExportView IsNot Nothing AndAlso Me.ExportView.GridControl IsNot Nothing Then
                If RibbonMenuManager.PrintOptions.ShowRibbonPreviewForm Then
                    Me.ExportView.GridControl.ShowRibbonPrintPreview()
                Else
                    Me.ExportView.GridControl.ShowPrintPreview()
                End If
            End If
        End Sub
#End Region
    End Class
    Public Class PaintView
        Private fView As BaseView = Nothing
        Private fAppearanceName As String = ""
        Public Sub New(ByVal fView As BaseView, ByVal fAppearanceName As String)
            Me.fView = fView
            Me.fAppearanceName = fAppearanceName
        End Sub

        Public ReadOnly Property View() As BaseView
            Get
                Return fView
            End Get
        End Property
        Public ReadOnly Property AppearanceName() As String
            Get
                Return fAppearanceName
            End Get
        End Property
    End Class
End Namespace
