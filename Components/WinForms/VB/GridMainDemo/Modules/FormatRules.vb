Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraGrid.Menu

Namespace DevExpress.XtraGrid.Demos
    Partial Public Class FormatRules
        Inherits TutorialControl
        Dim formatRulesMenu As DXPopupMenu = New DXPopupMenu()
        Public Overrides ReadOnly Property ExportView() As BaseView
            Get
                Return gridView1
            End Get
        End Property
        Public Sub New()
            InitializeComponent()
            gridControl1.DataSource = SaleOverviewDataGenerator.GenerateSales()
        End Sub

        Private Sub gridView1_RowCellClick(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles gridView1.RowCellClick
            If e.Button = System.Windows.Forms.MouseButtons.Right Then
                Dim items As GridFormatRuleMenuItems = New GridFormatRuleMenuItems(gridView1, e.Column, formatRulesMenu.Items)
                If items.Count > 0 Then
                    MenuManagerHelper.ShowMenu(formatRulesMenu, gridControl1.LookAndFeel, gridControl1.MenuManager, gridControl1, New Point(e.X, e.Y))
                End If
            End If
        End Sub
    End Class
End Namespace
