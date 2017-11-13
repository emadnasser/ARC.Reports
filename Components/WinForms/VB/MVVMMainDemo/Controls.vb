Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos

Namespace DevExpress.MVVM.Demos
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
        Private Shared texts() As String = { "Vestibulum sem nunc, cursus sit amet placerat id, scelerisque at tortor. Nullam sit amet felis eros, ac imperdiet quam. Aliquam eu ipsum dui.", "Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Curabitur sit amet sapien metus, eget pharetra velit.", "Duis sagittis iaculis nisl, sit amet ultricies lectus porttitor nec. Suspendisse id venenatis sem. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas.", "Aliquam erat volutpat. Ut sit amet purus. Nullam a lectus. Duis in elit. Ut nonummy est pellentesque eros. Sed ultrices convallis nulla. Phasellus urna lorem, mattis a, luctus congue, dictum in, nunc." }
    End Class
    '
    Public Class TutorialControl
        Inherits TutorialControlBase

        Public Sub New()
            Me.Padding = New Padding(5, 0, 0, 5)
        End Sub
        Protected Sub LoadSourceCode(ByVal sourceCode As DevExpress.DXperience.Demos.CodeDemo.RichEditUserControl, ByVal methodName As String, Optional ByVal moduleType As System.Type = Nothing, Optional ByVal append As Boolean = False)
            AddHandler sourceCode.richEditControl.InitializeDocument, Sub(s, e) sourceCode.InitializeSyntaxHighlight(DXperience.Demos.CodeDemo.ExampleLanguage.VB)
            Dim code As String = DevExpress.DXperience.Demos.CodeDemo.CodeTutorialControlBase.GetModuleMethodCode(If(moduleType, Me.GetType()), methodName)
            sourceCode.RichText = If(append, sourceCode.RichText & System.Environment.NewLine & code, code)
            sourceCode.richEditControl.ReadOnly = True
        End Sub
    End Class
End Namespace
