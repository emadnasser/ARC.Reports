Imports System
Imports System.Collections.Generic
Imports System.Collections.Specialized
Imports System.Linq
Imports System.Web
Imports System.Web.UI

Public Interface IPageUserControl
    Sub LoadState(ByVal state As SearchState)
End Interface
