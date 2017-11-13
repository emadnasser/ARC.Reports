Imports System
Imports System.Windows.Forms
Imports System.Collections.Generic
Imports System.Data
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraGrid.Demos.Tutorials
    ''' <summary>
    ''' Summary description for GridXMLReader.
    ''' </summary>
    Partial Public Class GridXMLReader
        Inherits TutorialControl

        Public Class File
            Public Property Name() As String
            Public Property FullName() As String
        End Class
        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()

            '
            ' TODO: Add any constructor code after InitializeComponent call
            '
        End Sub
        Private XmlFileNames As List(Of File)
#Region "Finding Xml Files"
        Public Shared Function FindingXmlFiles(ByVal path As String, ByVal path1 As String) As List(Of File)
            Dim s As String = "\"
            Dim xmlFiles As New List(Of File)()
            For i As Integer = 0 To 10
                If System.IO.Directory.Exists(path & s & path1) Then
                    Dim names() As String = System.IO.Directory.GetFiles(path & s & path1)
                    For Each name As String In names
                        Dim fInfo As New System.IO.FileInfo(name)
                        If fInfo.Extension.ToLower() = ".xml" Then
                            xmlFiles.Add(New File With {.Name = fInfo.Name, .FullName = fInfo.FullName})
                        End If
                    Next name
                    Return xmlFiles
                Else
                    s &= "..\"
                End If
            Next i
            Dim current As String = Environment.CurrentDirectory
            If path <> current Then
                Return FindingXmlFiles(current, path1)
            End If
            XtraMessageBox.Show(String.Format("{0} is not found", path1), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return xmlFiles
        End Function
#End Region

        Private Sub GridXMLReader_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            XmlFileNames = FindingXmlFiles(Application.StartupPath, "Data\Xml\")
            For i As Integer = 0 To XmlFileNames.Count - 1
                comboBoxEdit1.Properties.Items.Add(XmlFileNames(i).Name)
            Next i
            If comboBoxEdit1.Properties.Items.Count > 0 Then
                comboBoxEdit1.SelectedIndex = 0
            End If
        End Sub

        '<comboBoxEdit1>
        Private Sub comboBoxEdit1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBoxEdit1.SelectedIndexChanged
            FillGridWithData(XmlFileNames(comboBoxEdit1.SelectedIndex).FullName)
        End Sub
        Private Sub FillGridWithData(ByVal s As String)
            If System.IO.File.Exists(s) Then
                Dim ds As New DataSet()
                ds.ReadXml(s)
                gridControl1.DataSource = ds.Tables(0)
                gridControl1.MainView.PopulateColumns()
            Else
                XtraMessageBox.Show(String.Format("File {0} is not found", s), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Sub
        '</comboBoxEdit1>
    End Class
End Namespace
