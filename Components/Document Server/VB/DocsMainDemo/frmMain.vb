Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Utils
Imports System.Globalization
Imports DevExpress.DXperience.Demos
Imports DevExpress.XtraBars
Imports DevExpress.Utils.About
Imports DevExpress.DemoData.Model
Imports System.Linq

Namespace DevExpress.Docs.Demos
	Partial Public Class frmMain
		Inherits DevExpress.DXperience.Demos.RibbonMainForm
		Public Sub New()
			InitializeComponent()
		End Sub

		#Region "Properties"
		Protected Overrides ReadOnly Property ProductName() As String
			Get
				Return "DocumentServerForWin"
			End Get
		End Property
		Protected Overrides ReadOnly Property DemoName() As String
			Get
				Return "Docs Main Demo (" & DemoUtils.GetLanguageString() & " code)"
			End Get
		End Property
		Protected Overrides ReadOnly Property ShowPanelDescription() As Boolean
			Get
				Return ModulesInfo.Instance.CurrentModuleBase.Description <> ""
			End Get
		End Property
		#End Region

		Protected Overrides Function GetProduct() As Product
			Return Repository.DocsPlatform.Products.First(Function(p) p.Name = ProductName)
		End Function
		Protected Overrides Sub ShowAbout()
			DevExpress.Utils.About.AboutHelper.Show(ProductKind.DXperienceWin, New ProductStringInfo("DevExpress Universal", ".NET Document Server"))
		End Sub
		Protected Overrides Sub SetFormParam()
			Me.Icon = ResourceImageHelper.CreateIconFromResources("MainDemo.ico", GetType(frmMain).Assembly)
		End Sub
		Protected Overrides Function CreateRibbonMenuManager() As RibbonMenuManager
			Return New DocsRibbonMenuManager(Me)
		End Function
		Protected Overrides Sub ShowModule(ByVal name As String, ByVal groupControl As DevExpress.XtraEditors.GroupControl, ByVal lookAndFeel As DevExpress.LookAndFeel.DefaultLookAndFeel, ByVal caption As DevExpress.Utils.Frames.ApplicationCaption)
			DemosInfo.DoShowModule(name, groupControl, caption, TryCast(RibbonMenuManager, DocsRibbonMenuManager))
		End Sub

		Private Sub frmMain_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			'CultureInfo culture = CultureInfo.InvariantCulture;
			'sharedDictionaryStorage.Dictionaries.Clear();
			'SpellCheckerISpellDictionary dictionary = new SpellCheckerISpellDictionary(DemoUtils.GetRelativePath("american.xlg"), DemoUtils.GetRelativePath("english.aff"), culture);
			'dictionary.AlphabetPath = DemoUtils.GetRelativePath("EnglishAlphabet.txt");
			'sharedDictionaryStorage.Dictionaries.Add(dictionary);
			'SpellCheckerCustomDictionary customDictionary = new SpellCheckerCustomDictionary(DemoUtils.GetRelativePath("CustomEnglish.dic"), culture);
			'sharedDictionaryStorage.Dictionaries.Add(customDictionary);
		End Sub
		Protected Overrides Sub FillNavBar()
			MyBase.FillNavBar()
		End Sub
	End Class

	Public Class DocsRibbonMenuManager
		Inherits RibbonMenuManager
		Public Sub New(ByVal form As RibbonMainForm)
			MyBase.New(form)
		End Sub
	End Class
End Namespace
