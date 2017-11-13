Imports DevExpress.Utils
Imports DevExpress.XtraMap
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.IO
Imports System.Linq
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Threading.Tasks
Imports System.Web.Script.Serialization
Imports System.Windows.Forms

Namespace DevExpress.VoteApp
    Public Class Helpers
        Public Const USMap As String = "USAStates.shp"
        Public Const USCountyMap As String = "USACounties.shp"
        Public Const DataFolder As String = "data\voteappdata\"
        Public Shared Function FindFile(ByVal fileName As String) As String
            Return FilesHelper.FindingFileName(Application.StartupPath, DataFolder & fileName)
        End Function
        Private Shared Function GetCandidatePhotoName(ByVal name As String) As String
            Select Case name.ToLower()
                Case "barack obama"
                    Return "BarackObama.jpg"
                Case "mitt romney"
                    Return "MittRomney.jpg"
                Case "donald trump"
                    Return "DonaldTrump.jpg"
                Case "hillary clinton"
                    Return "HillaryClinton.jpg"
            End Select
            Return Nothing
        End Function
        Private Shared Function GetCachedImage(ByVal name As String) As Bitmap
            Return If(cachedImages.ContainsKey(name), cachedImages(name), Nothing)
        End Function
        Private Shared Function UpdateCachedImage(ByVal name As String, ByVal image As Bitmap) As Bitmap
            cachedImages(name) = image
            Return image
        End Function
        Private Shared cachedImages As New Dictionary(Of String, Bitmap)()
        Public Shared Function GetCandidatePhoto(ByVal name As String) As Bitmap
            Dim res = GetCachedImage(name)
            If res IsNot Nothing Then
                Return res
            End If
            Dim file = GetCandidatePhotoName(name)
            If file Is Nothing Then
                Return Nothing
            End If
            file = FindFile(file)
            If Not System.IO.File.Exists(file) Then
                Return Nothing
            End If
            Return UpdateCachedImage(name, CType(Bitmap.FromFile(file), Bitmap))
        End Function
        Public Shared Function GetUSMap(Optional ByVal dbf As Boolean = False) As String
            Dim fileName As String = If(dbf, Path.GetFileNameWithoutExtension(USMap) & ".dbf", USMap)
            Return FindFile(fileName)
        End Function
        Public Shared Function GetUSCountyMap(Optional ByVal dbf As Boolean = False) As String
            Dim fileName As String = If(dbf, Path.GetFileNameWithoutExtension(USCountyMap) & ".dbf", USCountyMap)
            Return FindFile(fileName)
        End Function
        Public Shared Sub SaveToJSON(ByVal data As Object, ByVal fileName As String)
            Dim json = (New JavaScriptSerializer()).Serialize(data)
            Using sw = New StreamWriter(fileName, False)
                sw.WriteLine(json)
            End Using

        End Sub
        Public Shared Function LoadFromJSON(Of T)(ByVal fileName As String) As T
            If Not File.Exists(fileName) Then
                Return Nothing
            End If
            Dim data = ""
            Using sr = New StreamReader(fileName)
                data = sr.ReadToEnd()
            End Using
            Return (New JavaScriptSerializer()).Deserialize(Of T)(data)
        End Function
        Public Shared Function GetPercent(ByVal value As Integer, ByVal total As Integer) As Decimal
            If total = 0 OrElse value = 0 Then
                Return 0
            End If
            Return value / CDec(total)
        End Function
    End Class
    Public Class VoteHelpers
        Public Const US2012Results As String = "US2012Results.json"
        Public Const US2016Results As String = "US2016Results.json"
        Public Shared Function LoadResults2012() As ElectionData
            Dim data As String = Helpers.FindFile(US2012Results)
            If String.IsNullOrEmpty(data) Then
                Return Nothing
            End If
            Return Helpers.LoadFromJSON(Of ElectionData)(data)
        End Function
        Public Shared Function LoadResults2016() As ElectionData
            Dim data As String = Helpers.FindFile(US2016Results)
            If String.IsNullOrEmpty(data) Then
                Return Nothing
            End If
            Return Helpers.LoadFromJSON(Of ElectionData)(data)
        End Function
    End Class
    Public Class LoadedMapInfo
        Public Sub New()
            AllItems = New List(Of MapItem)()
            VisibleItems = New List(Of MapItem)()
        End Sub
        Public Property AllItems() As List(Of MapItem)
        Public Property VisibleItems() As List(Of MapItem)
        Public Property Layer() As VectorItemsLayer
        Public Property VisibleItemsStorage() As MapItemStorage
        Friend Sub SetupVisibleItemsLayerStorage()
            DestroyStorage()
            VisibleItemsStorage = New MapItemStorage()
            VisibleItemsStorage.Items.AddRange(VisibleItems)
            Layer.Data = VisibleItemsStorage
        End Sub

        Friend Sub DestroyStorage()
            If Layer IsNot Nothing Then
                Layer.Data = Nothing
            End If
            If VisibleItemsStorage IsNot Nothing Then
                VisibleItemsStorage.Items.Clear()
                VisibleItemsStorage.Dispose()
                VisibleItemsStorage = Nothing
                FixMapBug(VisibleItems)
                VisibleItems.Clear()
            End If
        End Sub

        Private Sub FixMapBug(ByVal visibleItems As List(Of MapItem))
            For Each item In visibleItems
                Dim fi = GetType(MapShape).GetField("title", System.Reflection.BindingFlags.NonPublic Or System.Reflection.BindingFlags.Instance)
                If fi IsNot Nothing Then
                    fi.SetValue(item, Nothing)
                End If
            Next item
        End Sub

        Friend Sub DestroyLayer()
            If Layer IsNot Nothing Then
                Layer.Dispose()
                Layer = Nothing
            End If
        End Sub
    End Class
    Public Class MouseEventSourceInfo
        Public Enum MouseEventSource
            Mouse
            Touch
            Pen
        End Enum
        <DllImport("user32.dll")>
        Shared Function GetMessageExtraInfo() As UInteger
        End Function
        Public Shared Function GetMouseEventSource() As MouseEventSource
            Dim info As UInteger = GetMessageExtraInfo()
            Dim penOrTouch As Boolean = ((info And SIGNATURE_MASK) = MI_WP_SIGNATURE)
            If Not penOrTouch Then
                Return MouseEventSource.Mouse
            End If
            Return If((info And TOUCH_MASK) = TOUCH_MASK, MouseEventSource.Touch, MouseEventSource.Pen)
        End Function
        Public Shared Function IsTouchEvent() As Boolean
            Return GetMouseEventSource() = MouseEventSource.Touch
        End Function
        Private Const TOUCH_MASK As UInteger = &H80
        Private Const MI_WP_SIGNATURE As UInteger = &HFF515700UI
        Private Const SIGNATURE_MASK As UInteger = &HFFFFFF00UI
    End Class

End Namespace
