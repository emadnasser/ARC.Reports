Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos
Imports DevExpress.XtraEditors
Imports DevExpress.XtraTab

Namespace DevExpress.ApplicationUI.Demos
	Public Class DemosInfo
		Inherits ModulesInfo
        Public Shared Sub ShowDemoModule(ByVal name As String, ByVal group As DevExpress.XtraEditors.GroupControl, ByVal caption As DevExpress.Utils.Frames.ApplicationCaption, ByVal manager As RibbonMenuManager)
            Dim item As ModuleInfo = DemosInfo.GetItem(name)
            Dim currentCursor As Cursor = Cursor.Current
            Cursor.Current = Cursors.WaitCursor
            Try
                Dim oldTutorial As Control = Nothing
                If Instance.CurrentModuleBase IsNot Nothing Then
                    If Instance.CurrentModuleBase.Name = name Then
                        Return
                    End If
                    oldTutorial = Instance.CurrentModuleBase.TModule
                End If

                Dim tutorial As TutorialControlBase = TryCast(item.TModule, TutorialControlBase)
                tutorial.Bounds = group.DisplayRectangle
                Instance.CurrentModuleBase = item
                tutorial.Visible = False
                group.Controls.Add(tutorial)
                tutorial.Dock = DockStyle.Fill

                'TutorialControl tc = tutorial as TutorialControl;
                'if(tc != null)
                '    manager.AllowExport(tc.ExportControl);
                'else manager.AllowExport(null);
                tutorial.RibbonMenuManager = manager
                tutorial.TutorialName = name
                tutorial.Caption = caption
                tutorial.Visible = True
                item.WasShown = True
                If oldTutorial IsNot Nothing Then
                    oldTutorial.Visible = False
                End If
            Finally
                Cursor.Current = currentCursor
            End Try
            RaiseModuleChanged()
        End Sub
        Public Shared Function GetLoremIpsumText(ByVal seed As Integer) As String
            Return String.Format("{0} {1}", texts(seed Mod texts.Length), texts((seed + 2) Mod texts.Length))
        End Function
        Private Shared texts() As String = New String() {"Vestibulum sem nunc, cursus sit amet placerat id, scelerisque at tortor. Nullam sit amet felis eros, ac imperdiet quam. Aliquam eu ipsum dui.", "Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Curabitur sit amet sapien metus, eget pharetra velit.", "Duis sagittis iaculis nisl, sit amet ultricies lectus porttitor nec. Suspendisse id venenatis sem. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas.", "Aliquam erat volutpat. Ut sit amet purus. Nullam a lectus. Duis in elit. Ut nonummy est pellentesque eros. Sed ultrices convallis nulla. Phasellus urna lorem, mattis a, luctus congue, dictum in, nunc."}
    End Class
	'
	Public Class TutorialControl
		Inherits TutorialControlBase
		Public Sub New()
			Me.Padding = New Padding(5, 0, 0, 5)
            AddHandler Me.SizeChanged, AddressOf UpdatePosition
        End Sub
		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)
			For Each ctrl As Control In Me.Controls
				Dim tabControl As XtraTabControl = TryCast(ctrl, XtraTabControl)
				If tabControl IsNot Nothing Then
					UpdateTabControlPosition(tabControl)
				End If
			Next ctrl
			UpdatePosition()
		End Sub
		Private centerControls As List(Of Panel) = New List(Of Panel)()
		Private Sub UpdatePosition()
			For Each pnl As Panel In centerControls
                pnl.Location = New Point(CInt(Fix(pnl.Parent.Width - pnl.Width) / 2), CInt(Fix(pnl.Parent.Height - pnl.Height) / 2))
			Next pnl
		End Sub
		Private Sub UpdateTabControlPosition(ByVal tabControl As XtraTabControl)
            AddHandler tabControl.SelectedPageChanged, AddressOf UpdatePosition
			For Each page As XtraTabPage In tabControl.TabPages
				If page IsNot Nothing Then
					UpdatePagePosition(page)
				End If
			Next page
		End Sub
		Private Sub UpdatePagePosition(ByVal page As XtraTabPage)
			Dim pnl As Panel = New Panel()
			Dim left As Integer = 100, right As Integer = 0, top As Integer = 100, bottom As Integer = 0
			For i As Integer = page.Controls.Count - 1 To 0 Step -1
				Dim ctrl As Control = page.Controls(i)
				If TypeOf ctrl Is DevExpress.XtraBars.BarDockControl Then
					Continue For
				End If
				If TypeOf ctrl Is DevExpress.Utils.FlyoutPanel Then
					Continue For
				End If
				If TypeOf ctrl Is PopupContainerControl OrElse TypeOf ctrl Is PopupControlContainer Then
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
