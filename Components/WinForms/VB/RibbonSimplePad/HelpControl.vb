Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms

Namespace DevExpress.XtraBars.Demos.RibbonSimplePad
	Partial Public Class HelpControl
		Inherits RibbonApplicationUserControl
		Public Sub New()
			InitializeComponent()
			Me.versionLabel.Text = AssemblyInfo.Version
			Me.copyrightLabel.Text = AssemblyInfo.AssemblyCopyright
            Me.serialNumberLabel.Text = DevExpress.Utils.About.Utility.GetSerial(DevExpress.Utils.About.ProductKind.DXperienceWin, DevExpress.Utils.About.ProductInfoStage.Registered)
		End Sub
	End Class
End Namespace
