Imports Microsoft.VisualBasic
Imports DevExpress.Utils
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.IO
Imports System.Xml.Serialization

Namespace DevExpress.Demos.DataSources
	Public Class Fish
		<DisplayName("ID")> _
		Public Property ID() As Integer
		<DisplayName("Category")> _
		Public Property Category() As String
		<DisplayName("Common Name")> _
		Public Property CommonName() As String
		<DisplayName("Notes")> _
		Public Property Notes() As String
		<DisplayName("Scientific Classification")> _
		Public Property ScientificClassification() As ScientificClassification
	End Class
	Public Class ScientificClassification
		<XmlElement("Reference")> _
		Public Property Hyperlink() As String
		Public Property Kingdom() As String
		Public Property Phylum() As String
		<XmlElement("Class"), DisplayName("Class")> _
		Public Property _Class() As String
		Public Property Order() As String
		Public Property Family() As String
		Public Property Genus() As String
		Public Property Species() As String
	End Class

	Public NotInheritable Class FishesSource
		Private Shared data_Renamed As List(Of Fish)

		Private Sub New()
		End Sub
		Public Shared ReadOnly Property Data() As List(Of Fish)
			Get
				If data_Renamed Is Nothing Then
					data_Renamed = GetDataSource()
				End If
				Return data_Renamed
			End Get
		End Property

		Private Shared Function GetDataSource() As List(Of Fish)
			Return DataSourceHelper.GetDataSouresFromXml(Of Fish)("fishes.xml", "Fishes")
		End Function
	End Class

	Public NotInheritable Class DataSourceHelper
		Private Sub New()
		End Sub
		Public Shared Function GetDataSouresFromXml(Of T As Class)(ByVal fileName As String, ByVal attribute As String) As List(Of T)
			Dim path As String = FilesHelper.FindingFileName(AppDomain.CurrentDomain.BaseDirectory, "Data\" & fileName, False)
			If (Not File.Exists(path)) Then
				Return Nothing
			End If
			Using stream As Stream = File.OpenRead(path)
				Dim s As New XmlSerializer(GetType(List(Of T)), New XmlRootAttribute(attribute))
				Return CType(s.Deserialize(stream), List(Of T))
			End Using
		End Function
	End Class

	'[DisplayName("Fishes")]
	'public class Fishes : List<Fish> {
	'    public Fishes(string filePath) {
	'        if (File.Exists(filePath)) {
	'            using (Stream stream = File.OpenRead(filePath)) {
	'                this.LoadFrom(stream);
	'            }
	'        }
	'    }
	'    public Fishes(Stream stream) {
	'        this.LoadFrom(stream);
	'    }
	'    void LoadFrom(Stream stream) {
	'        TextReader input = new StreamReader(stream);
	'        string line;
	'        int id = 0;
	'        while ((line = input.ReadLine()) != null) {
	'            string[] items = line.Split('|');
	'            if (items.Length == 4) {
	'                Fish fishItem = new Fish(items[0], items[1], items[2], items[3], ++id);
	'                this.Add(fishItem);
	'            }
	'        }
	'        input.Close();
	'    }
	'}
	'public class Fish {
	'    private int id;
	'    private string category = "Undefined";
	'    private string commonName = "Undefined";
	'    private string speciesName = "Undefined";
	'    private string notes = "Undefined";

	'    [DisplayName("Fish Category")]
	'    public string Category {
	'        get { return category; }
	'        set { category = value; }
	'    }
	'    [DisplayName("Fish Common Name")]
	'    public string CommonName {
	'        get { return commonName; }
	'        set { commonName = value; }
	'    }
	'    [DisplayName("Fish Species Name")]
	'    public string SpeciesName {
	'        get { return speciesName; }
	'        set { speciesName = value; }
	'    }
	'    [DisplayName("Fish Notes")]
	'    public string Notes {
	'        get { return notes; }
	'        set { notes = value; }
	'    }
	'    [DisplayName("Fish ID")]
	'    public int ID {
	'        get { return id; }
	'        set { id = value; }
	'    }
	'    public Fish(string category, string commonName, string speciesName, string notes, int id) {
	'        this.category = category;
	'        this.commonName = commonName;
	'        this.speciesName = speciesName;
	'        this.notes = notes;
	'        this.id = id;
	'    }
	'}
End Namespace
