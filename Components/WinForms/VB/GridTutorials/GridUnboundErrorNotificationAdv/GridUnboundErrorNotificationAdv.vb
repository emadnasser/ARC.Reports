Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms

Namespace DevExpress.XtraGrid.Demos.Tutorials
    Partial Public Class GridUnboudErrorNotificationNew
        Inherits TutorialControl
        Public Sub New()
            InitializeComponent()
            InitData()
        End Sub
        Private Sub InitData()
            Dim persons As Persons = New Persons()
            persons.Add(New Person("John", "", "123 Home Lane, Homesville", "(555) 956-1547", "none"))
            persons.Add(New Person("Henry", "McAllister", "436 1st Ave, Cleveland", "(555) 941-2432", "@hotbox.com"))
            persons.Add(New Person("Frank", "Frankson", "349 Graphic Design L, Newman", "(555) 155-0502", "none"))
            persons.Add(New Person("Leticia", "Ford", "93900 Carter Lane, Cartersville", "(555) 776-1566", "none"))
            persons.Add(New Person("Karen", "Holmes", "", "(555) 342-2574", "none"))
            persons.Add(New Person("Roger", "Michelson", "3920 Michelson Dr., Bridgeford", "(555) 954-5188", "none"))
            gridControl1.DataSource = persons
        End Sub
        Public Overrides ReadOnly Property SetNewWhatsThisPadding() As Boolean
            Get
                Return True
            End Get
        End Property
    End Class
End Namespace
