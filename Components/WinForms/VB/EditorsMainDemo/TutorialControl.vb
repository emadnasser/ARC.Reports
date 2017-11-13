Imports System.Drawing.Imaging
Imports DevExpress.DXperience.Demos
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraBars
Imports DevExpress.XtraTab
Imports DevExpress.XtraGrid
Imports DevExpress.XtraVerticalGrid
Imports DevExpress.Utils

Namespace DevExpress.XtraEditors.Demos
    Public Class TutorialControl
        Inherits TutorialControlBase

        Private centerControls As New List(Of Panel)()
        Protected Overridable ReadOnly Property AllowCenterControls() As Boolean
            Get
                Return True
            End Get
        End Property
        Public Sub New()
            Me.Padding = New Padding(5, 0, 0, 5)
            AddHandler Me.SizeChanged, AddressOf ControlSizeChanged
        End Sub
        Sub ControlSizeChanged(sender As Object, e As EventArgs)
            UpdatePosition()
        End Sub
        Private Sub UpdatePosition()
            For Each pnl As Panel In centerControls
                If (pnl.Parent Is Nothing) Then
                    Continue For
                End If
                pnl.Location = New Point((pnl.Parent.Width - pnl.Width) \ 2, (pnl.Parent.Height - pnl.Height) \ 2)
            Next pnl
        End Sub
        Protected Overrides Sub SetControlManager(ByVal ctrl As Control, ByVal manager As BarManager)
            Dim grid As GridControl = TryCast(ctrl, GridControl)
            If grid IsNot Nothing Then
                grid.MenuManager = manager
            End If
            Dim pGrid As PropertyGridControl = TryCast(ctrl, PropertyGridControl)
            If pGrid IsNot Nothing Then
                pGrid.MenuManager = manager
            End If
            Dim be As BaseEdit = TryCast(ctrl, BaseEdit)
            If be IsNot Nothing Then
                be.MenuManager = manager
            End If
        End Sub
        Public Overrides ReadOnly Property AllowPrintOptions() As Boolean
            Get
                Return False
            End Get
        End Property
        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            If AllowCenterControls Then
                For Each ctrl As Control In Me.Controls
                    Dim tabControl As XtraTabControl = TryCast(ctrl, XtraTabControl)
                    If tabControl IsNot Nothing Then
                        UpdateTabControlPosition(tabControl)
                    End If
                Next ctrl
                UpdatePosition()
            End If
        End Sub

        Private Sub UpdateTabControlPosition(ByVal tabControl As XtraTabControl)
            AddHandler tabControl.SelectedPageChanged, AddressOf ControlSizeChanged
            For Each page As XtraTabPage In tabControl.TabPages
                If page IsNot Nothing Then
                    UpdatePagePosition(page)
                End If
            Next page
        End Sub
        Private Sub UpdatePagePosition(ByVal page As XtraTabPage)
            Dim pnl As New Panel()
            Dim left As Integer = 100, right As Integer = 0, top As Integer = 100, bottom As Integer = 0
            For i As Integer = page.Controls.Count - 1 To 0 Step -1
                Dim ctrl As Control = page.Controls(i)
                If TypeOf ctrl Is PopupContainerControl OrElse TypeOf ctrl Is PopupControlContainer OrElse TypeOf ctrl Is FlyoutPanel Then
                    Continue For
                End If
                If left > ctrl.Left Then
                    left = ctrl.Left
                End If
                If right < ctrl.Right Then
                    right = ctrl.Right
                End If
                If top > ctrl.Top Then
                    top = ctrl.Top
                End If
                If bottom < ctrl.Bottom Then
                    bottom = ctrl.Bottom
                End If
                ctrl.Parent = pnl
            Next i
            pnl.Parent = page
            pnl.Size = New Size(right + left, bottom + top)
            centerControls.Add(pnl)
        End Sub
    End Class
End Namespace
