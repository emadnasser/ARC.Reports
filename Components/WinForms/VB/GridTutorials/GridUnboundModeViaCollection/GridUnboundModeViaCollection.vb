Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Namespace DevExpress.XtraGrid.Demos.Tutorials
    ''' <summary>
    ''' Summary description for GridUnboundModeViaCollection.
    ''' </summary>
    Partial Public Class GridUnboundModeViaCollection
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

        '<gridControl1>
        Private Sub GridUnboundModeViaCollection_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            InitData()
        End Sub

        Private Sub InitData()
            Dim records As GridUnboundModeViaCollectionRecord() = New GridUnboundModeViaCollectionRecord(4) {}
            records(0) = New GridUnboundModeViaCollectionRecord(1, "Chai", "Beverages", True, 18)
            records(1) = New GridUnboundModeViaCollectionRecord(2, "Aniseed Syrup", "Condiments", False, 10)
            records(2) = New GridUnboundModeViaCollectionRecord(3, "Ikura", "Seafood", False, 30.5)
            records(3) = New GridUnboundModeViaCollectionRecord(4, "Queso Cabrales", "Dairy Products", True, 21)
            records(4) = New GridUnboundModeViaCollectionRecord(5, "Carnarvon Tigers", "Seafood", True, 62.5)
            gridControl1.DataSource = records
        End Sub
        '</gridControl1>
        Public Overrides ReadOnly Property SetNewWhatsThisPadding() As Boolean
            Get
                Return True
            End Get
        End Property
    End Class
End Namespace
