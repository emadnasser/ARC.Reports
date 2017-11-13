Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraBars.Alerter
Imports DevExpress.XtraEditors
Imports DevExpress.XtraBars
Imports DevExpress.XtraGrid.Columns

Namespace DevExpress.XtraGrid.Demos
    ''' <summary>
    ''' Summary description for OutlookStyle.
    ''' </summary>
    Partial Public Class OutlookStyle
        Inherits TutorialControl

        Private currentMessage_Renamed As Message
        Public Sub New()
            ' This call is required by the Windows.Forms Form Designer.
            InitializeComponent()
            TutorialInfo.WhatsThisCodeFile = "VB\GridMainDemo\Modules\OutlookStyle.vb"
            TutorialInfo.WhatsThisXMLFile = "OutlookStyle.xml"
            '<gridControl1>
            '            
            '            ~Note: the following properties are set at design time and listed here only for demonstration purposes.
            '            gridView1.OptionsView.GroupDrawMode = Views.Grid.GroupDrawMode.Office;
            '            gridView1.OptionsView.ShowGroupedColumns = true;
            '            gridView1.OptionsView.ShowGroupPanel = false;
            '            gridView1.OptionsView.ShowVerticalLines = Utils.DefaultBoolean.False;
            '            
            '</gridControl1>

        End Sub

        Private mTimer As MailTimer
        Public Overrides ReadOnly Property ExportView() As DevExpress.XtraGrid.Views.Base.BaseView
            Get
                Return gridView1
            End Get
        End Property
        Private Sub OutlookStyle_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            gridView1.OptionsView.ShowPreview = True
            gridView1.OptionsView.ShowHorizontalLines = Utils.DefaultBoolean.False
            gridControl1.DataSource = DataHelper.Messages
            gridView1.SetRowExpanded(-1, True)
            gridView1.SetRowExpanded(-2, True)
            mTimer = New MailTimer(DataHelper.Messages, alertControl1, Me.FindForm())
            OnStyleChanged()
            SetAlertControlButtonHint()
            CalcPreviewIndent()
        End Sub

        Private Sub SetAlertControlButtonHint()
            alertControl1.Buttons(0).Hint = My.Resources.MarkAsRead
            alertControl1.Buttons(1).Hint = My.Resources.OpenAttachment
            alertControl1.Buttons(2).Hint = My.Resources.DeleteItem
        End Sub
        Private Sub gridView1_CustomDrawGroupRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs)
            Dim info As GridGroupRowInfo = TryCast(e.Info, GridGroupRowInfo)
            If info Is Nothing Then
                Return
            End If
            info.GroupText = info.GroupText.Replace("1 " & My.Resources.Items, "1 " & My.Resources.Item)
        End Sub

        Protected Overrides Sub DoShow()
            MyBase.DoShow()
            gridControl1.Focus()
            mTimer.Start()
        End Sub
        Protected Overrides Sub DoHide()
            mTimer.Stop()
        End Sub

#Region "Alerter"
        Private Sub alertControl1_ButtonDownChanged(ByVal sender As Object, ByVal e As AlertButtonDownChangedEventArgs) Handles alertControl1.ButtonDownChanged
            If e.ButtonName = "Read" Then
                ToggleRead(TryCast(e.Info.Tag, Message))
            End If
        End Sub
        Private Sub RaiseReadMessagesChanged(ByVal rowHandle As Integer)
            Dim current As Message = TryCast(gridView1.GetRow(rowHandle), Message)
            If current Is Nothing Then
                Return
            End If
            current.ToggleRead()
            gridView1.LayoutChanged()
            gridView1.MakeRowVisible(gridView1.FocusedRowHandle)
        End Sub
        Private Sub alertControl1_ButtonClick(ByVal sender As Object, ByVal e As AlertButtonClickEventArgs) Handles alertControl1.ButtonClick
            Dim data As Message = TryCast(e.Info.Tag, Message)
            e.AlertForm.OwnerForm.Activate()
            If e.ButtonName = "Attachment" Then
                e.AlertForm.Close()
                XtraMessageBox.Show(FindForm(), "Open attachment dialog.", String.Format("Mail From: {0}", data.From))
            End If
            If e.ButtonName = "Delete" Then
                DeleteItem(e, data)
            End If
        End Sub
        Private Sub OpenItem(ByVal message As Message)
            Dim rowIndex As Integer = GetMessageRowHandle(message)
            If rowIndex > -1 Then
                gridView1.FocusedRowHandle = rowIndex
                gridView1.MakeRowVisible(rowIndex, True)
            End If
        End Sub
        Private Function GetMessageRowHandle(ByVal message As Message) As Integer
            For i As Integer = 0 To gridView1.RowCount - 1
                If message.Equals(gridView1.GetRow(i)) Then
                    Return i
                End If
            Next i
            Return -1
        End Function
        Private Sub DeleteItem(ByVal args As AlertClickEventArgs, ByVal message As Message)
            args.AlertForm.Close()
            Try
                Dim rowIndex As Integer = GetMessageRowHandle(message)
                If rowIndex > -1 Then
                    gridView1.DeleteRow(rowIndex)
                End If
                gridView1.LayoutChanged()
                UpdateCurrentMessage()
            Catch
            End Try
        End Sub
        Private Sub alertControl1_AlertClick(ByVal sender As Object, ByVal e As AlertClickEventArgs) Handles alertControl1.AlertClick
            Dim data As Message = TryCast(e.Info.Tag, Message)
            OpenItem(data)
        End Sub
#End Region
#Region "AlertPopupMenu"
        Private updatePopupMenu As Boolean = False
        Private Sub popupMenu1_BeforePopup(ByVal sender As Object, ByVal e As CancelEventArgs) Handles popupMenu1.BeforePopup
            Dim args As AlertClickEventArgs = TryCast(popupMenu1.ItemLinks(0).Item.Tag, AlertClickEventArgs)
            If args Is Nothing Then
                Return
            End If
            Dim data As Message = TryCast(args.Info.Tag, Message)
            updatePopupMenu = True
            If 1.Equals(data.Read) Then
                biRead.Caption = My.Resources.UnreadMark
                biRead.ImageIndex = 2
            Else
                biRead.Caption = My.Resources.ReadMark
                biRead.ImageIndex = 1
            End If
            If data.Priority = 0 Then
                bcLow.Checked = True
            End If
            If data.Priority = 1 Then
                bcMedium.Checked = True
            End If
            If data.Priority = 2 Then
                bcHigh.Checked = True
            End If
            updatePopupMenu = False
        End Sub
        Private Sub biOpen_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles biOpen.ItemClick
            Dim args As AlertClickEventArgs = TryCast(e.Item.Tag, AlertClickEventArgs)
            OpenItem(TryCast(args.Info.Tag, Message))
        End Sub
        Private Sub biRead_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles biRead.ItemClick
            Dim args As AlertClickEventArgs = TryCast(e.Item.Tag, AlertClickEventArgs)
            Dim message As Message = TryCast(args.Info.Tag, Message)
            ToggleRead(message)
            args.AlertForm.Buttons("Read").Down = message.Read = 1
        End Sub
        Private Sub biDelete_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles biDelete.ItemClick
            Dim args As AlertClickEventArgs = TryCast(e.Item.Tag, AlertClickEventArgs)
            DeleteItem(args, TryCast(args.Info.Tag, Message))
        End Sub
        Private Sub bc_DownChanged(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles bcLow.DownChanged, bcMedium.DownChanged, bcHigh.DownChanged
            If updatePopupMenu Then
                Return
            End If
            Dim args As AlertClickEventArgs = TryCast(e.Item.Tag, AlertClickEventArgs)
            Dim data As Message = TryCast(args.Info.Tag, Message)
            Dim item As BarCheckItem = TryCast(e.Item, BarCheckItem)
            If Not item.Checked Then
                Return
            End If
            If bcLow.Checked Then
                data.Priority = 0
            End If
            If bcMedium.Checked Then
                data.Priority = 1
            End If
            If bcHigh.Checked Then
                data.Priority = 2
            End If
            gridView1.LayoutChanged()
        End Sub
        Private Sub barManager1_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles barManager1.ItemClick
            Dim args As AlertClickEventArgs = TryCast(e.Item.Tag, AlertClickEventArgs)
            If args Is Nothing Then
                Return
            End If
            args.AlertForm.OwnerForm.Activate()
        End Sub
        Private Sub ToggleRead(ByVal message As Message)
            message.ToggleRead()
            gridView1.LayoutChanged()
        End Sub
#End Region

        Private Sub gridControl1_MouseDoubleClick(ByVal sender As Object, ByVal e As MouseEventArgs) Handles gridControl1.MouseDoubleClick
            Dim hi As GridHitInfo = gridView1.CalcHitInfo(New Point(e.X, e.Y))
            If hi.InRow AndAlso gridView1.FocusedRowHandle > -1 Then
                mTimer.ShowAlert(TryCast(gridView1.GetFocusedRow(), Message))
            End If
        End Sub

        Protected Overrides Sub OnStyleChanged()
            MyBase.OnStyleChanged()
            ColorHelper.UpdateColor(ilColumns, gridControl1.LookAndFeel)
        End Sub

        Private Sub gridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As Views.Base.FocusedRowChangedEventArgs) Handles gridView1.FocusedRowChanged
            UpdateCurrentMessage()
        End Sub

        Private Sub gridView1_ColumnFilterChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gridView1.ColumnFilterChanged
            UpdateCurrentMessage()
        End Sub
        Private Property CurrentMessage() As Message
            Get
                Return currentMessage_Renamed
            End Get
            Set(ByVal value As Message)
                If currentMessage_Renamed Is value Then
                    Return
                End If
                currentMessage_Renamed = value
                ucMailViewer1.ShowMessage(CurrentMessage)
            End Set
        End Property
        Private Sub UpdateCurrentMessage()
            If gridView1.FocusedRowHandle >= 0 Then
                CurrentMessage = TryCast(gridView1.GetFocusedRow(), Message)
            Else
                Dim rows As New List(Of Message)()
                ObjectHelper.GetChildDataRowHandles(gridView1, gridView1.FocusedRowHandle, rows)
                ucMailViewer1.ShowMessagesInfo(rows)
                CurrentMessage = Nothing
            End If
        End Sub

        Private Sub gridView1_RowCellClick(ByVal sender As Object, ByVal e As Views.Grid.RowCellClickEventArgs) Handles gridView1.RowCellClick
            If e.Column Is gridColumn7 AndAlso e.Button = MouseButtons.Left Then
                RaiseReadMessagesChanged(e.RowHandle)
            End If
        End Sub
        Private Sub CalcPreviewIndent()
            Dim indent As Integer = 0
            For Each column As GridColumn In gridView1.VisibleColumns
                If "Priority;Read;Attachment".IndexOf(column.FieldName) > -1 Then
                    indent += column.Width
                Else
                    Exit For
                End If
            Next column
            gridView1.PreviewIndent = indent
        End Sub

        Private Sub gridView1_ColumnPositionChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gridView1.ColumnPositionChanged
            CalcPreviewIndent()
        End Sub
    End Class
End Namespace
