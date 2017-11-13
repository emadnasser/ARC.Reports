Imports Microsoft.VisualBasic
Imports System

Imports DevExpress.Utils

Imports DevExpress.XtraSpellChecker
Imports System.Globalization
Imports DevExpress.DXperience.Demos
Imports DevExpress.Utils.About


Namespace DevExpress.XtraRichEdit.Demos
	Partial Public Class frmMain
		Inherits DevExpress.DXperience.Demos.RibbonMainForm
		Public Sub New()
			' This call is required by the Windows Form Designer.
			InitializeComponent()

			' TODO: Add any initialization after the InitializeComponent call
		End Sub

#Region "Properties"
		Protected Overrides ReadOnly Property DemoName() As String
			Get
                Return "XtraRichEdit Main Demo (VB code)"
			End Get
		End Property
#End Region

        Protected Overrides Sub ShowAbout()
            RichEditControl.About()
        End Sub
		Protected Overrides Sub SetFormParam()
            Me.Icon = ResourceImageHelper.CreateIconFromResources("AppIcon.ico", GetType(frmMain).Assembly)
		End Sub
		Protected Overrides Function CreateRibbonMenuManager() As RibbonMenuManager
			Return New RichEditRibbonMenuManager(Me)
		End Function
        Protected Overloads Overrides Sub ShowModule(ByVal name As String, ByVal groupControl As DevExpress.XtraEditors.GroupControl, ByVal lookAndFeel As DevExpress.LookAndFeel.DefaultLookAndFeel, ByVal caption As DevExpress.Utils.Frames.ApplicationCaption)
			DemosInfo.ShowModule(name, groupControl, caption, TryCast(RibbonMenuManager, RichEditRibbonMenuManager))
		End Sub

		Private Sub frmMain_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Dim culture As CultureInfo = CultureInfo.InvariantCulture
			sharedDictionaryStorage.Dictionaries.Clear()
			Dim dictionary As New SpellCheckerISpellDictionary(DemoUtils.GetRelativePath("american.xlg"), DemoUtils.GetRelativePath("english.aff"), culture)
			dictionary.AlphabetPath = DemoUtils.GetRelativePath("EnglishAlphabet.txt")
			sharedDictionaryStorage.Dictionaries.Add(dictionary)
			Dim customDictionary As New SpellCheckerCustomDictionary(DemoUtils.GetRelativePath("CustomEnglish.dic"), culture)
			sharedDictionaryStorage.Dictionaries.Add(customDictionary)
		End Sub
	End Class

	Public Class RichEditRibbonMenuManager
		Inherits RibbonMenuManager
		Private fRichEditControl As RichEditControl

		'BarItem miPageSetup;
		'BarItem miLoadPageSetup;
		'BarItem miSavePageSetup;

		'BarItem miPrintPreview;
		'BarItem miPrint;
		'BarSubItem miPrintExport;

		Public Sub New(ByVal form As RibbonMainForm)
			MyBase.New(form)

			'miPageSetup = CreateButtonItem("P&age Setup...", new ItemClickEventHandler(miPageSetup_Click));
			'miLoadPageSetup = CreateButtonItem("&Load page setup...", new ItemClickEventHandler(miLoadPageSetup_Click));
			'miSavePageSetup = CreateButtonItem("&Save page setup...", new ItemClickEventHandler(miSavePageSetup_Click));

			'miPrintPreview = CreateButtonItem("&Print Preview", new ItemClickEventHandler(miPrintPreview_Click));
			'miPrint = CreateButtonItem("P&rint...", new ItemClickEventHandler(miPrint_Click));

			'miPrintExport = new BarSubItem(manager, "&Print and Export");
			'//miPrintExport.ItemLinks.Add(miPageSetup);
			'//miPrintExport.ItemLinks.Add(miLoadPageSetup);
			'//miPrintExport.ItemLinks.Add(miSavePageSetup);


			'miPrintExport.ItemLinks.Add(miPrintPreview).BeginGroup = true;
			'miPrintExport.ItemLinks.Add(miPrint);
			'EnablePrintMenu();


			'miFeatures.Caption = "XtraRichEdit Features";
			'miAboutProduct.Caption = "About &XtraRichEdit";

			'AddItems();
		End Sub

		Public Property RichEditControl() As RichEditControl
			Get
				Return fRichEditControl
			End Get
			Set(ByVal value As RichEditControl)
				fRichEditControl = value
				'EnablePrintMenu();
			End Set
		End Property

		'protected override void AddItems() {
		'    if (miPrintExport == null)
		'        return;

		'    MainMenu.ItemLinks.Add(miLookAndFeel);
		'    MainMenu.ItemLinks.Add(miView);
		'    MainMenu.ItemLinks.Add(miPrintExport);
		'    MainMenu.ItemLinks.Add(miHelp);
		'    InitLookAndFeelMenu();
		'}

		'void EnablePrintMenu() {
		'    if (miPrintExport != null)
		'        miPrintExport.Enabled = (RichEditControl != null);
		'}
		'BarItem CreateButtonItem(string caption, ItemClickEventHandler clickHandler) {
		'    BarButtonItem item = new BarButtonItem(this.manager, caption);
		'    item.ItemClick += clickHandler;
		'    return item;
		'}
		'private void miLoadPageSetup_Click(object sender, ItemClickEventArgs e) {
        '            
        '            OpenFileDialog dlg = new OpenFileDialog();
        '            try {
        '                dlg.CheckPathExists = true;
        '                dlg.Filter = "XML files (*.xml) | *.xml";
        '                DialogResult result = dlg.ShowDialog();
        '                if (result != DialogResult.OK)
        '                    return;
        '                RichEditControl.PrintStyles.FromXml(dlg.FileName, Application.ProductName);
        '            }
        '            catch (Exception ex) {
        '                XtraMessageBox.Show(ex.Message, Application.ProductName);
        '            }
        '
        '            finally {
        '                dlg.Dispose();
        '            }
        '            
		'}

		'private void miSavePageSetup_Click(object sender, ItemClickEventArgs e) {
        '            
        '            SaveFileDialog dlg = new SaveFileDialog();
        '            try {
        '                dlg.Filter = "XML files (*.xml) | *.xml";
        '                DialogResult result = dlg.ShowDialog();
        '                if (result != DialogResult.OK)
        '                    return;
        '                RichEditControl.PrintStyles.ToXml(dlg.FileName, Application.ProductName);
        '            }
        '            catch (Exception ex) {
        '                XtraMessageBox.Show(ex.Message, Application.ProductName);
        '            }
        '            finally {
        '                dlg.Dispose();
        '            }
        '            
		'}

		'private void miPageSetup_Click(object sender, ItemClickEventArgs e) {
        '            
        '            try {
        '                RichEditControl.ShowPrintOptionsForm();
        '            }
        '            catch (Exception ex) {
        '                XtraMessageBox.Show(ex.Message, Application.ProductName);
        '            }
        '            
		'}
		'private void miPrintPreview_Click(object sender, ItemClickEventArgs e) {
		'    try {
		'        RichEditControl.ShowPrintPreview();
		'    }
		'    catch (Exception ex) {
		'        XtraMessageBox.Show(ex.Message, Application.ProductName);
		'    }
		'}
		'private void miPrint_Click(object sender, ItemClickEventArgs e) {
		'    RichEditControl.ShowPrintDialog();
		'}
		'protected override void biProductWebPage_Click(object sender, ItemClickEventArgs e) {
		'    System.Diagnostics.Process.Start("http://www.devexpress.com/Products/NET/WinForms/XtraRichEdit");
		'}
		'protected override void miAboutProduct_Click(object sender, ItemClickEventArgs e) {
		'    DevExpress.Utils.About.AboutForm.Show(typeof(DevExpress.XtraRichEdit.RichEditControl), DevExpress.Utils.About.ProductKind.XtraRichEdit, DevExpress.Utils.About.ProductInfoStage.Registered);
		'}
	End Class
End Namespace
