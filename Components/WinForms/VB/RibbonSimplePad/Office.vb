Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.LookAndFeel
Imports DevExpress.XtraBars.Utils

Namespace DevExpress.XtraBars.Demos.RibbonSimplePad
    Public Class Office2007PopupControlContainer
        Inherits PopupControlContainer
        Implements ITransparentBackgroundManager
        Private Function GetForeColor(ByVal childObject As Object) As Color Implements ITransparentBackgroundManager.GetForeColor
            Return GetForeColorCore()
        End Function
        Private Function GetForeColor(ByVal childControl As Control) As Color Implements ITransparentBackgroundManager.GetForeColor
            Return GetForeColorCore()
        End Function
        Protected Function GetForeColorCore() As Color
            Return BarUtilites.GetAppMenuLabelForeColor(LookAndFeel.ActiveLookAndFeel)
        End Function
    End Class
End Namespace
