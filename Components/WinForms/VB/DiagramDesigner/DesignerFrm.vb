Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports DevExpress.Diagram.Core
Imports DevExpress.Utils
Imports DevExpress.Utils.About
Imports DevExpress.XtraDiagram
Imports DevExpress.XtraDiagram.Designer

Namespace DevExpress.XtraDiagram.Demos
    Partial Public Class DesignerFrm
        Inherits DiagramDesignerForm

        Public Sub New()
            UAlgo.Default.DoEventObject(UAlgo.kDemo, UAlgo.pWinForms, Me) 'DEMO_REMOVE
            InitializeComponent()
            Me.Diagram.AttachToForm()
        End Sub
        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            InitializeForm()
        End Sub

        Protected Sub InitializeForm()
            Icon = LoadDefaultIcon()
            WindowState = FormWindowState.Maximized
            AddSingleShape()
        End Sub

        Protected Sub AddSingleShape()
            Dim [single] As New DiagramShape(BasicShapes.Rectangle, 20, 20, 200, 100)
            Diagram.Items.Add([single])
            Diagram.SelectItem([single])
        End Sub
        Protected Overrides Function LoadDefaultIcon() As Icon
            Dim assembly = GetType(DesignerFrm).Assembly
            Return ResourceImageHelper.CreateIconFromResources(assembly.GetManifestResourceNames().First(Function(x) x.Contains("DemoIcon.ico")), assembly)
        End Function
    End Class
End Namespace
