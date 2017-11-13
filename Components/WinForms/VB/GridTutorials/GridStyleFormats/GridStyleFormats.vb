Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.XtraEditors.Repository

Namespace DevExpress.XtraGrid.Demos.Tutorials
    ''' <summary>
    ''' Summary description for GridStyleFormats.
    ''' </summary>
    Partial Public Class GridStyleFormats
        Inherits TutorialControl
        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()

            '
            ' TODO: Add any constructor code after InitializeComponent call
            '
        End Sub

        Private Sub GridStyleFormats_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            InitHelper.InitAdvBandedView(gridControl1)
            InitStyles()
        End Sub

        '<listBoxControl1>
        Private xapp As DevExpress.XtraGrid.Design.XAppearances = New DevExpress.XtraGrid.Design.XAppearances(System.Environment.GetFolderPath(System.Environment.SpecialFolder.System) & "\DevExpress.XtraGrid.Appearances.xml")
        '</listBoxControl1>
        Private Sub InitStyles()
            listBoxControl1.Items.Clear()
            listBoxControl1.Items.AddRange(xapp.FormatNames)
            If listBoxControl1.Items.Count > 1 Then
                listBoxControl1.SelectedIndex = 1
            End If
        End Sub

        '<listBoxControl1>
        Private Sub listBoxControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles listBoxControl1.SelectedIndexChanged
            If Not listBoxControl1.SelectedValue Is Nothing Then
                xapp.LoadScheme(listBoxControl1.SelectedValue.ToString(), gridControl1.MainView)
            End If
        End Sub
        '</listBoxControl1>

        Public Overrides ReadOnly Property ShowLookAndFeel() As Boolean
            Get
                Return False
            End Get
        End Property
        Public Overrides ReadOnly Property SetNewWhatsThisPadding() As Boolean
            Get
                Return True
            End Get
        End Property
    End Class
End Namespace
