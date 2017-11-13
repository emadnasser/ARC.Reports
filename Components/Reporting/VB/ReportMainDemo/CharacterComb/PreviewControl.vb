Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraPrinting.Preview
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Mask

Namespace XtraReportsDemos.CharacterComb
    Partial Public Class PreviewControl
        Inherits XtraReportsDemos.PreviewControl

        Protected Overrides Function CreateReport() As XtraReport
            Return New Report()
        End Function
        Shared Sub New()
            EditingFieldExtensionsWin.Instance.RegisterMaskEditor("Name", "Name", "Custom", MaskType.RegEx, "[A-Z -.]+")
            EditingFieldExtensionsWin.Instance.RegisterMaskEditor("NumbersAndUppercaseLetters", "Numbers and Uppercase letters", "Custom", MaskType.RegEx, "[A-Z0-9]+")
            EditingFieldExtensionsWin.Instance.RegisterMaskEditor("UppercaseText", "Uppercase Text", "Custom", MaskType.RegEx, "[A-Z0-9 ,-/]+")
        End Sub
    End Class
End Namespace
