Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Linq
Imports System.Text

Namespace DevExpress.DemoData.Models
    <Table("Hierarchy")>
    Public Class Hierarchy
        <Key, Column("Countries.Id", Order := 0), DatabaseGenerated(DatabaseGeneratedOption.None)>
        Public Property Countries_Id() As Long

        <StringLength(255)>
        Public Property OfficialName() As String

        <MaxLength(2147483647)>
        Public Property BFlag() As Byte()

        <Key, Column("SubRegions.Id", Order := 1), DatabaseGenerated(DatabaseGeneratedOption.None)>
        Public Property SubRegions_Id() As Long

        <StringLength(50)>
        Public Property SubRegion() As String

        <StringLength(50)>
        Public Property Region() As String

        <Key, Column("Regions.Id", Order := 2), DatabaseGenerated(DatabaseGeneratedOption.None)>
        Public Property Regions_Id() As Long
    End Class
End Namespace
