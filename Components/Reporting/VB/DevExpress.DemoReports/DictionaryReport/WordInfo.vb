Namespace XtraReportsDemos.DictionaryReport
    Public Class WordInfo

        Private ReadOnly word_Renamed As String

        Public ReadOnly Property Word() As String
            Get
                Return word_Renamed
            End Get
        End Property
        Public ReadOnly Property FirstLetter() As String
            Get
                Return Word.Chars(0).ToString().ToUpperInvariant()
            End Get
        End Property

        Public Sub New(ByVal word As String)
            Me.word_Renamed = word
        End Sub
    End Class
End Namespace
