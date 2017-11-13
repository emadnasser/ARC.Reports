Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Popup
Imports DevExpress.XtraTab
Imports DevExpress.XtraEditors.ColorPick.Picker

Namespace DevExpress.XtraGauges.Demos
    Partial Public Class ColorPickerControl
        Inherits XtraUserControl
        Private item As RepositoryItemColorPickEdit
        Public Sub New()
            Me.item = New RepositoryItemColorPickEdit()
            InitializeComponent()
            TabStop = False
        End Sub
        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            InitColorPicker()
            IniWebList()
            IniSystemList()
        End Sub
        Private Sub InitColorPicker()
            colorPickControl.Selectable = False
            colorPickControl.ThemeColors.AddColorRange(item.ThemeColors.ToList())
            colorPickControl.StandardColors.AddColorRange(item.StandardColors.ToList())
        End Sub
        Private Sub IniSystemList()
            systemColorListControl.Selectable = False
            systemColorListControl.Colors.AddColorRange(ColorListBoxViewInfo.SystemColors)
        End Sub
        Private Sub IniWebList()
            webColorListControl.Selectable = False
            webColorListControl.Colors.AddColorRange(ColorListBoxViewInfo.WebColors)
        End Sub
        Private Sub OnSelectedColorChanged(ByVal sender As Object, ByVal e As InnerColorPickControlSelectedColorChangedEventArgs) Handles webColorListControl.SelectedColorChanged, systemColorListControl.SelectedColorChanged, colorPickControl.SelectedColorChanged
            RaiseEvent ResultColorChanged(Me, e)
        End Sub
        Private color As Color = Color.Empty
        Public Sub SetColor(ByVal color As Color)
            Me.color = color
        End Sub
        Private Sub OnMoreColorClick(ByVal sender As Object, ByVal e As EventArgs) Handles colorPickControl.MoreButtonClick
            Using frm As New FrmColorPicker(item)
                frm.StartPosition = FormStartPosition.CenterScreen
                If Me.color <> color.Empty Then
                    frm.SelectedColor = Me.color
                End If
                If frm.ShowDialog(FindForm()) = DialogResult.OK Then
                    colorPickControl.SelectedColor = frm.SelectedColor
                End If
            End Using
        End Sub
        Public Event ResultColorChanged As EventHandler(Of InnerColorPickControlSelectedColorChangedEventArgs)
    End Class

    <ToolboxItem(False)> _
    Public Class NonFocusableTabControl
        Inherits XtraTabControl
        Protected Overrides ReadOnly Property AllowTabFocus() As Boolean
            Get
                Return False
            End Get
        End Property
    End Class
End Namespace
