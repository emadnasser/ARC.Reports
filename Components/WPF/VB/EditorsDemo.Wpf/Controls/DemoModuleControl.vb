﻿Imports System
Imports System.Windows
Imports DevExpress.Xpf.DemoBase
Imports DevExpress.Xpf.Utils.Themes

Namespace EditorsDemo
 Public Class EditorsDemoModule
     Inherits DemoModule

  Shared Sub New()
            Dim ownerType As Type = GetType(EditorsDemoModule)
  End Sub
  Protected Overridable ReadOnly Property NeedChangeEditorsTheme() As Boolean
      Get
          Return False
      End Get
  End Property
 End Class
End Namespace
Namespace CommonDemo
    Public Class CommonDemoModule
        Inherits EditorsDemo.EditorsDemoModule

    End Class
End Namespace