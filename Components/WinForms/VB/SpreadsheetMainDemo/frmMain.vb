Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Utils
Imports System.Globalization
Imports DevExpress.DXperience.Demos
Imports DevExpress.XtraBars
Imports DevExpress.Utils.About


Namespace DevExpress.XtraSpreadsheet.Demos
	Partial Public Class frmMain
		Inherits DevExpress.DXperience.Demos.RibbonMainForm
		Public Sub New()
			InitializeComponent()
		End Sub

		#Region "Properties"
		Protected Overrides ReadOnly Property DemoName() As String
			Get
				Return "XtraSpreadsheet Main Demo (" & DemoUtils.GetLanguageString() & " code)"
			End Get
		End Property
		#End Region

		Protected Overrides Sub ShowAbout()
			SpreadsheetControl.About()
		End Sub
		Protected Overrides ReadOnly Property ProductName() As String
			Get
				Return "XtraSpreadsheet"
			End Get
		End Property
		Protected Overrides Sub SetFormParam()
			Me.Icon = ResourceImageHelper.CreateIconFromResources("AppIcon.ico", GetType(frmMain).Assembly)
		End Sub
		Protected Overrides Function CreateRibbonMenuManager() As RibbonMenuManager
			Return New SpreadsheetRibbonMenuManager(Me)
		End Function
		Protected Overrides Sub ShowModule(ByVal name As String, ByVal groupControl As DevExpress.XtraEditors.GroupControl, ByVal lookAndFeel As DevExpress.LookAndFeel.DefaultLookAndFeel, ByVal caption As DevExpress.Utils.Frames.ApplicationCaption)
			DemosInfo.DoShowModule(name, groupControl, caption, TryCast(RibbonMenuManager, SpreadsheetRibbonMenuManager))
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
	End Class

	Public Class SpreadsheetRibbonMenuManager
		Inherits RibbonMenuManager
		Public Sub New(ByVal form As RibbonMainForm)
			MyBase.New(form)
		End Sub
	End Class
End Namespace
