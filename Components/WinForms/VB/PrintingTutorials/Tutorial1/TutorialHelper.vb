Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Reflection
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Data
Imports DevExpress.Utils

Namespace XtraPrintingDemos.Tutorial1
    Public NotInheritable Class TutorialHelper

        Private Sub New()
        End Sub

        Private Shared Function GetRelativePathCore(ByVal name As String) As String
            Return FilesHelper.FindingFileName(Application.StartupPath, "Data\" & name)
        End Function
        Public Shared Function GetRelativePath(ByVal path As String) As String
            If System.Reflection.Assembly.GetEntryAssembly() <> System.Reflection.Assembly.GetExecutingAssembly() Then
                Return path
            End If
            Dim index As Integer = path.LastIndexOf("\") + 1
            Return GetRelativePathCore(path.Substring(index))
        End Function

        Public Shared Function CreateImage(ByVal b() As Byte) As Image
            If b Is Nothing OrElse b.Length = 0 Then
                Return Nothing
            End If
            Using s As New MemoryStream(b)
                Try
                    Return Image.FromStream(s)
                Catch e1 As ArgumentException
                    Return Nothing
                End Try
            End Using
        End Function

        Public NotInheritable Class ProductsHelper

            Private Sub New()
            End Sub

            Private Const NameColumn As String = "ProductName"
            Private Const PriceColumn As String = "UnitPrice"
            Private Const DiscontinuedColumn As String = "Discontinued"
            Private Const IconColumn As String = "Icon_25"
            Private Shared currentData As DataView
            Private Shared columns As New Dictionary(Of ProductColumn, RectangleF)(4)

            Shared Sub New()
                Const Height As Single = 26F
                Dim left As Single = 0F
                For Each column As ProductColumn In System.Enum.GetValues(GetType(ProductColumn))
                    Dim width As Single = 0F
                    Select Case column
                        Case ProductColumn.Name
                            width = 325F

                        Case ProductColumn.Price
                            width = 100F

                        Case ProductColumn.Discontinued
                            width = 123F

                        Case ProductColumn.Icon
                            width = 75F
                    End Select

                    columns(column) = New RectangleF(left, 0F, width, Height)
                    left += width
                Next column
            End Sub

            Private Shared ReadOnly Property Data() As DataView
                Get
                    If currentData Is Nothing Then
                        Using ds As New DataSet()
                            ds.ReadXml(GetRelativePath("..\..\..\Data\ProductsForPrintingLessons.xml"))
                            Using dvm As New DataViewManager(ds)
                                currentData = dvm.CreateDataView(ds.Tables(0))
                            End Using
                        End Using
                    End If

                    Return currentData
                End Get
            End Property

            Private Shared images As New Dictionary(Of Integer, Image)()
            Private Shared Function GetDataIconByIndex(ByVal index As Integer) As Image
                Dim result As Image = Nothing
                If Not images.TryGetValue(index, result) Then
                    Using stream As New MemoryStream(TryCast(Data(index)(IconColumn), Byte()))
                        images.Add(index, Image.FromStream(stream))
                    End Using
                End If
                Return result
            End Function

            Public Shared Function GetProductByIndex(ByVal index As Integer) As Product
                index = index Mod Data.Count
                Dim row As DataRowView = Data(index)
                Return New Product(TryCast(row(NameColumn), String), DirectCast(row(PriceColumn), Decimal), DirectCast(row(DiscontinuedColumn), Boolean), GetDataIconByIndex(index))
            End Function

            Public Enum ProductColumn
                Name
                Price
                Discontinued
                Icon
            End Enum

            Public Shared Function GetBoundsForColumn(ByVal column As ProductColumn) As RectangleF
                Dim result As RectangleF = RectangleF.Empty
                columns.TryGetValue(column, result)
                Return result
            End Function

            Public Structure Product
                Private _name As String
                Private _price As Decimal
                Private _discontinued As Boolean
                Private _icon As Image

                Public Sub New(ByVal name As String, ByVal price As Decimal, ByVal discontinued As Boolean, ByVal icon As Image)
                    _name = name
                    _price = price
                    _discontinued = discontinued
                    _icon = icon
                End Sub

                Public ReadOnly Property Name() As String
                    Get
                        Return _name
                    End Get
                End Property
                Public ReadOnly Property Price() As Decimal
                    Get
                        Return _price
                    End Get
                End Property
                Public ReadOnly Property Discontinued() As Boolean
                    Get
                        Return _discontinued
                    End Get
                End Property
                Public ReadOnly Property Icon() As Image
                    Get
                        Return _icon
                    End Get
                End Property
            End Structure
        End Class
    End Class
End Namespace
