Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.IO
Imports System.Web
Imports System.Web.Caching
Imports System.Web.UI
Imports DevExpress.Web
Imports DevExpress.Web.Internal

Public Class CommonUtils
    Private Const DelayedActionKeyPrefix As String = "AppTask_"
    Private Shared ReadOnly SizeSuffixes() As String = { "B", "KB", "MB", "GB", "TB", "PB" }

    Public Shared Sub ExecuteActionWithDelay(ByVal action As Action, ByVal delay As TimeSpan)
        Dim cacheKey As String = DelayedActionKeyPrefix & Guid.NewGuid().ToString()
        Dim callback As CacheItemRemovedCallback = Sub(key, value, reason)
            If reason = CacheItemRemovedReason.Expired Then
                action()
            End If
        End Sub
        HttpRuntime.Cache.Insert(cacheKey, String.Empty, Nothing, Date.UtcNow.Add(delay), Cache.NoSlidingExpiration, CacheItemPriority.NotRemovable, callback)
    End Sub

    Public Shared Function ReadAllBytes(ByVal stream As Stream) As Byte()
        Dim buffer((16 * 1024) - 1) As Byte
        Dim readCount As Integer
        Using ms As New MemoryStream()
            readCount = stream.Read(buffer, 0, buffer.Length)
            Do While readCount > 0
                ms.Write(buffer, 0, readCount)
                readCount = stream.Read(buffer, 0, buffer.Length)
            Loop
            Return ms.ToArray()
        End Using
    End Function

    Public Shared Function MapPath(ByVal virtPath As String) As String
        If HttpContext.Current IsNot Nothing Then
            Return HttpContext.Current.Server.MapPath(virtPath)
        End If
        Return UrlUtils.ResolvePhysicalPath(virtPath)
    End Function

    Public Shared Function ConvertVirtPathToUrl(ByVal virtPath As String) As String
        Return virtPath.Replace("~\", "").Replace("\"c, "/"c)
    End Function

    Public Shared Function FindControl(Of TControl As Control)(ByVal container As Control, ByVal id As String) As TControl
        Dim result As Control = container.FindControl(id)
        If result IsNot Nothing Then
            Return CType(result, TControl)
        End If
        For Each childControl As Control In container.Controls
            result = FindControl(Of TControl)(childControl, id)
            If result IsNot Nothing Then
                Return CType(result, TControl)
            End If
        Next childControl
        Return Nothing
    End Function

    Public Shared Function GetSizeString(ByVal value As Long) As String
        If value = 0 Then
            Return "0 B"
        End If

        Dim maxRank As Integer = SizeSuffixes.Length - 1
        Dim rank As Integer = CInt((Math.Log(value, 1024)))
        If rank > maxRank Then
            rank = maxRank
        End If
        Dim adjustedSize As Decimal = CDec(value) / (1L << (rank * 10))

        Return String.Format("{0:n0} {1}", adjustedSize, SizeSuffixes(rank))
    End Function
End Class
