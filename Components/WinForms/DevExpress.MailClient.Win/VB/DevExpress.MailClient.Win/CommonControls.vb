Imports System.Text
Imports DevExpress.XtraEditors

Namespace DevExpress.MailClient.Win
	Public Class PictureEditSimpleZoom
		Inherits PictureEdit

        Protected Overrides Sub OnMouseWheelCore(ByVal e As MouseEventArgs)
            If Control.ModifierKeys <> Keys.None Then Return
            MyBase.OnMouseWheelCore(e)
        End Sub
    End Class
End Namespace
