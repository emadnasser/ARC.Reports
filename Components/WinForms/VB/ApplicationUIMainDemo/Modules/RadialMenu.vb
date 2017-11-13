Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos
Imports DevExpress.XtraBars.Helpers
Imports DevExpress.XtraEditors.Repository

Namespace DevExpress.ApplicationUI.Demos
    Partial Public Class RadialMenu
        Inherits TutorialControlBase
        Public Sub New()
            AutoMergeRibbon = True
            InitializeComponent()
        End Sub
        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            Initialize()
        End Sub
        Private Sub Initialize()
            iSetRadialMenuRadius.EditValue = radialMenu1.MenuRadius
            CType(iSetRadialMenuInnerRadius.Edit, RepositoryItemSpinEdit).MaxValue = 120
            iSetBackColor.EditValue = radialMenu1.BackColor
            iSetBorderColor.EditValue = radialMenu1.BorderColor
            iSetMenuColor.EditValue = radialMenu1.MenuColor
            iSetMenuHoverColor.EditValue = radialMenu1.SubMenuHoverColor
            iCloseOnOuterMouseClick.EditValue = radialMenu1.CloseOnOuterMouseClick
            iCollapseOnOuterMouseClick.EditValue = radialMenu1.CollapseOnOuterMouseClick
            iSetRadialMenuInnerRadius.EditValue = radialMenu1.InnerRadius
        End Sub
#Region "Handlers"
        Private Sub labelControl1_MouseClick(ByVal sender As Object, ByVal e As MouseEventArgs) Handles labelControl1.MouseClick
            If e.Button = MouseButtons.Right Then
                radialMenu1.ShowPopup(Cursor.Position)
            End If
        End Sub
        Private Sub iSetMenuColor_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles iSetMenuColor.EditValueChanged
            radialMenu1.MenuColor = CType(iSetMenuColor.EditValue, Color)
        End Sub
        Private Sub iSetMenuHoverColor_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles iSetMenuHoverColor.EditValueChanged
            radialMenu1.SubMenuHoverColor = CType(iSetMenuHoverColor.EditValue, Color)
        End Sub
        Private Sub iSetBackColor_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles iSetBackColor.EditValueChanged
            radialMenu1.BackColor = CType(iSetBackColor.EditValue, Color)
        End Sub
        Private Sub iSetBorderColor_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles iSetBorderColor.EditValueChanged
            radialMenu1.BorderColor = CType(iSetBorderColor.EditValue, Color)
        End Sub
        Private Sub iSetRadialMenuRadius_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles iSetRadialMenuRadius.EditValueChanged
            radialMenu1.MenuRadius = Convert.ToInt32(iSetRadialMenuRadius.EditValue)
        End Sub
        Private Sub iSetRadialMenuInnerRadius_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles iSetRadialMenuInnerRadius.EditValueChanged
            radialMenu1.InnerRadius = Convert.ToInt32(iSetRadialMenuInnerRadius.EditValue)
        End Sub
        Private Sub iCloseOnOuterMouseClick_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles iCloseOnOuterMouseClick.EditValueChanged
            radialMenu1.CloseOnOuterMouseClick = CBool(iCloseOnOuterMouseClick.EditValue)
        End Sub
        Private Sub iCollapseOnOuterMouseClick_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles iCollapseOnOuterMouseClick.EditValueChanged
            radialMenu1.CollapseOnOuterMouseClick = CBool(iCollapseOnOuterMouseClick.EditValue)
        End Sub
#End Region
    End Class
End Namespace
