Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraBars.Alerter
Imports DevExpress.XtraBars

Namespace DevExpress.ApplicationUI.Demos
    Partial Public Class AlertControlProperties
        Inherits XtraUserControl

        Private aControl As AlertControl
        Private menu As PopupMenu
        Public Event AllowHtmlTextChanged As EventHandler
        Private initValues_Renamed As Boolean = True
        Public Sub New()
            InitializeComponent()
            InitProperties()
        End Sub

        Private Sub InitProperties()
            icbControlBoxPosition.Properties.Items.AddEnum(GetType(AlertFormControlBoxPosition))
            icbFormDisplaySpeed.Properties.Items.AddEnum(GetType(AlertFormDisplaySpeed))
            icbFormLocation.Properties.Items.AddEnum(GetType(AlertFormLocation))
            icbShowingEffect.Properties.Items.AddEnum(GetType(AlertFormShowingEffect))
        End Sub
        Public Sub InitValues(ByVal control As AlertControl)
            initValues_Renamed = True
            Me.aControl = control
            Me.menu = control.PopupMenu
            seAutoFormDelay.EditValue = aControl.AutoFormDelay
            icbControlBoxPosition.EditValue = aControl.ControlBoxPosition
            icbFormDisplaySpeed.EditValue = aControl.FormDisplaySpeed
            icbFormLocation.EditValue = aControl.FormLocation
            icbShowingEffect.EditValue = aControl.FormShowingEffect
            ceAllowHtmlText.Checked = aControl.AllowHtmlText
            ceShowCloseButton.Checked = aControl.ShowCloseButton
            ceShowPinButton.Checked = aControl.ShowPinButton
            ceShowTooltips.Checked = aControl.ShowToolTips
            ceShowPopupMenu.Checked = menu IsNot Nothing
            ceAutoHeight.Checked = aControl.AutoHeight
            seFormMaxCount.Value = aControl.FormMaxCount
            For Each btn As AlertButton In aControl.Buttons
                ccbeButtons.Properties.Items.Add(btn.Name, btn.Name,If(btn.Visible, CheckState.Checked, CheckState.Unchecked), True)
            Next btn
            initValues_Renamed = False
            RaiseAllowHtmlTextChanged()
        End Sub

        '<seAutoFormDelay>
        Private Sub seAutoFormDelay_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles seAutoFormDelay.EditValueChanged
            If initValues_Renamed Then
                Return
            End If
            aControl.AutoFormDelay = Convert.ToInt32(seAutoFormDelay.Value)
        End Sub
        '</seAutoFormDelay>

        '<icbControlBoxPosition>
        Private Sub icbControlBoxPosition_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles icbControlBoxPosition.SelectedIndexChanged
            If initValues_Renamed Then
                Return
            End If
            aControl.ControlBoxPosition = CType(icbControlBoxPosition.EditValue, AlertFormControlBoxPosition)
        End Sub
        '</icbControlBoxPosition>

        '<icbFormDisplaySpeed>
        Private Sub icbFormDisplaySpeed_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles icbFormDisplaySpeed.SelectedIndexChanged
            If initValues_Renamed Then
                Return
            End If
            aControl.FormDisplaySpeed = CType(icbFormDisplaySpeed.EditValue, AlertFormDisplaySpeed)
        End Sub
        '</icbFormDisplaySpeed>

        '<icbFormLocation>
        Private Sub icbFormLocation_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles icbFormLocation.SelectedIndexChanged
            If initValues_Renamed Then
                Return
            End If
            aControl.FormLocation = CType(icbFormLocation.EditValue, AlertFormLocation)
        End Sub
        '</icbFormLocation>

        '<ceAllowHtmlText>
        Private Sub ceAllowHtmlText_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceAllowHtmlText.CheckedChanged
            If initValues_Renamed Then
                Return
            End If
            aControl.AllowHtmlText = ceAllowHtmlText.Checked
            RaiseAllowHtmlTextChanged()
        End Sub
        '</ceAllowHtmlText>

        Private Sub RaiseAllowHtmlTextChanged()
            RaiseEvent AllowHtmlTextChanged(Me, EventArgs.Empty)
        End Sub

        '<ceShowCloseButton>
        Private Sub ceShowCloseButton_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceShowCloseButton.CheckedChanged
            If initValues_Renamed Then
                Return
            End If
            aControl.ShowCloseButton = ceShowCloseButton.Checked
        End Sub
        '</ceShowCloseButton>

        '<ceShowPinButton>
        Private Sub ceShowPinButton_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceShowPinButton.CheckedChanged
            If initValues_Renamed Then
                Return
            End If
            aControl.ShowPinButton = ceShowPinButton.Checked
        End Sub
        '</ceShowPinButton>

        '<ceShowPopupMenu>
        Private Sub ceShowPopupMenu_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceShowPopupMenu.CheckedChanged
            If initValues_Renamed Then
                Return
            End If
            If ceShowPopupMenu.Checked Then
                aControl.PopupMenu = menu
            Else
                aControl.PopupMenu = Nothing
            End If
        End Sub
        '</ceShowPopupMenu>

        '<ceShowTooltips>
        Private Sub ceShowTooltips_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceShowTooltips.CheckedChanged
            If initValues_Renamed Then
                Return
            End If
            aControl.ShowToolTips = ceShowTooltips.Checked
        End Sub
        '</ceShowTooltips>

        '<ccbeButtons>
        Private Sub ccbeButtons_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ccbeButtons.EditValueChanged
            If initValues_Renamed OrElse aControl Is Nothing Then
                Return
            End If
            For Each btn As AlertButton In aControl.Buttons
                btn.Visible = ccbeButtons.Text.IndexOf(btn.Name) >= 0
            Next btn
        End Sub
        '</ccbeButtons>
        Private Sub ceAutoHeight_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceAutoHeight.CheckedChanged
            If initValues_Renamed Then
                Return
            End If
            aControl.AutoHeight = ceAutoHeight.Checked
        End Sub

        Private Sub icbShowingEffect_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles icbShowingEffect.SelectedIndexChanged
            If initValues_Renamed Then
                Return
            End If
            aControl.FormShowingEffect = CType(icbShowingEffect.EditValue, AlertFormShowingEffect)
        End Sub

        Private Sub seFormMaxCount_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles seFormMaxCount.EditValueChanged
            If initValues_Renamed Then
                Return
            End If
            aControl.FormMaxCount = CInt(Fix(seFormMaxCount.Value))
        End Sub
        Public ReadOnly Property AutoCloseFormOnClick() As Boolean
            Get
                Return ceAutoClose.Checked
            End Get
        End Property
    End Class
End Namespace
