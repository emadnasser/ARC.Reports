Imports System
Imports System.Web.UI
Imports MenuItem = DevExpress.Web.MenuItem

Partial Public Class HeaderMenu
    Inherits UserControl

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        mainMenu.DataBind()
        If mainMenu.SelectedItem IsNot Nothing AndAlso mainMenu.SelectedItem.Parent IsNot mainMenu.RootItem Then
            mainMenu.SelectedItem.Parent.Text = String.Format("{0}: {1}", mainMenu.SelectedItem.Parent, mainMenu.SelectedItem.Text)
        End If

        Dim helpMenuItem As MenuItem = mainMenu.Items.Add("?", "helpMenuItem")
        helpMenuItem.ItemStyle.CssClass = "helpMenuItem"
    End Sub
End Class
