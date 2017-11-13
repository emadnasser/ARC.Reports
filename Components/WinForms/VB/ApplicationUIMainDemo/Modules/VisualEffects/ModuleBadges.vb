Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.Utils

Namespace DevExpress.ApplicationUI.Demos.VisualEffects
    Partial Public Class ModuleBadges
        Inherits TutorialControl
        Private badge As DevExpress.Utils.VisualEffects.Badge
        Public Sub New()
            InitializeComponent()
            InitControls()
            InitBadge()
        End Sub
        Private Sub InitControls()
            cbTargetElement.EditValue = targetElement1.Name
            cbTargetElement.Properties.Items.AddRange(New Object() {targetElement1.Name, targetElement2.Name})
            ieLocation.EditValue = ContentAlignment.TopRight
            ieLocation.Properties.Items.AddEnum(GetType(ContentAlignment))
        End Sub
        Private Sub InitBadge()
            adornerUIManager1.BeginUpdate()
            badge = New DevExpress.Utils.VisualEffects.Badge()
            SetBadgeTargetElement(cbTargetElement.Text)
            badge.Visible = ceVisible.Checked
            badge.Properties.AllowGlyphSkinning = GetDefaultBoolean(cbAllowGlyphSkinning.Checked)
            badge.Properties.AllowImage = GetDefaultBoolean(cbAllowImage.Checked)
            badge.Properties.StretchImage = GetDefaultBoolean(cbStretchImage.Checked)
            badge.Properties.Location = CType(ieLocation.EditValue, ContentAlignment)
            badge.Properties.Text = teText.Text
            SetBadgeOffset()
            SetBadgeImage()
            badge.Properties.TextMargin = New System.Windows.Forms.Padding(3)
            badge.Properties.ImageStretchMargins = New System.Windows.Forms.Padding(14)
            adornerUIManager1.Elements.Add(badge)
            adornerUIManager1.EndUpdate()
        End Sub
        Private Function GetDefaultBoolean(ByVal value As Boolean) As DefaultBoolean
            Return If(value, DefaultBoolean.True, DefaultBoolean.False)
        End Function
        Private Sub SetBadgeImage()
            If badge IsNot Nothing Then
                If badge.Properties.AllowGlyphSkinning <> DefaultBoolean.False Then
                    badge.Properties.Image = imageList1.Images(ieImage.SelectedIndex)
                Else
                    badge.Properties.Image = imageList2.Images(ieImage.SelectedIndex)
                End If
            End If
        End Sub
        Private Sub ieImage_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ieImage.SelectedIndexChanged
            SetBadgeImage()
        End Sub
        Private Sub SetBadgeTargetElement(ByVal name As String)
            If badge IsNot Nothing Then
                If name = targetElement1.Name Then
                    badge.TargetElement = targetElement1
                End If
                If name = targetElement2.Name Then
                    badge.TargetElement = targetElement2
                End If
            End If
        End Sub
        Private Sub cbTargetElement_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbTargetElement.SelectedIndexChanged
            SetBadgeTargetElement(cbTargetElement.Text)
        End Sub
        Private Sub ceVisible_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceVisible.CheckedChanged
            If badge IsNot Nothing Then
                badge.Visible = ceVisible.Checked
            End If
        End Sub
        Private Sub cbAllowGlyphSkinning_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbAllowGlyphSkinning.CheckedChanged
            If badge IsNot Nothing Then
                badge.Properties.AllowGlyphSkinning = GetDefaultBoolean(cbAllowGlyphSkinning.Checked)
                If badge.Properties.AllowGlyphSkinning = DefaultBoolean.False Then
                    ieImage.Properties.SmallImages = imageList2
                Else
                    ieImage.Properties.SmallImages = imageList1
                End If
                SetBadgeImage()
            End If
        End Sub
        Private Sub cbAllowImage_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbAllowImage.CheckedChanged
            If badge IsNot Nothing Then
                badge.Properties.AllowImage = GetDefaultBoolean(cbAllowImage.Checked)
            End If
        End Sub
        Private Sub cbStretchImage_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbStretchImage.CheckedChanged
            If badge IsNot Nothing Then
                badge.Properties.StretchImage = GetDefaultBoolean(cbStretchImage.Checked)
            End If
        End Sub
        Private Sub SetBadgeOffset()
            If badge IsNot Nothing Then
                badge.Properties.Offset = New Point(Convert.ToInt32(seXOffset.Value), Convert.ToInt32(seYOffset.Value))
            End If
        End Sub
        Private Sub seYOffset_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles seYOffset.EditValueChanged
            SetBadgeOffset()
        End Sub
        Private Sub seXOffset_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles seXOffset.EditValueChanged
            SetBadgeOffset()
        End Sub
        Private Sub teText_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles teText.EditValueChanged
            If badge IsNot Nothing Then
                badge.Properties.Text = teText.Text
            End If
        End Sub
        Private Sub ceTextColor_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceTextColor.EditValueChanged
            If badge IsNot Nothing Then
                badge.Appearance.ForeColor = ceTextColor.Color
            End If
        End Sub
        Private Sub ceImageColor_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceImageColor.EditValueChanged
            If badge IsNot Nothing Then
                badge.Appearance.BackColor = ceImageColor.Color
            End If
        End Sub
        Private Sub ieLocation_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ieLocation.SelectedIndexChanged
            If badge IsNot Nothing Then
                badge.Properties.Location = CType(ieLocation.EditValue, ContentAlignment)
            End If
        End Sub
    End Class
End Namespace
