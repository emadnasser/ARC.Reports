Imports System.Data.Common
Imports System.Data.Entity
Imports DevExpress.ExpressApp.EF.Updating

' Business Model Design with Entity Framework - https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113462.aspx
' Use the Entity Framework Code First in XAF - https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113466.aspx
Public Class SimpleProjectManagerDbContext
    Inherits DbContext
    Public Sub New(ByVal connectionString As String)
        MyBase.New(connectionString)
    End Sub
    Public Sub New(ByVal connection As DbConnection)
        MyBase.New(connection, True)
    End Sub
    Public Property Customer() As DbSet(Of Customer)
    Public Property Testimonial() As DbSet(Of Testimonial)
    Public Property ModuleInfo() As DbSet(Of ModuleInfo)
End Class
