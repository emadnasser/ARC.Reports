Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace DevExpress.VoteApp

	Public Class CountyVote
		Public Const EmptyFIPS As String = "-"
		Public Property State() As String
		Public Property FIPS() As String
		Public Property PercentReported() As Decimal
		Public Property TotalVotesCount() As Integer
        '<ScriptIgnoreAttribute>
        Public ReadOnly Property IsAllDataReported() As Boolean
			Get
				Return PercentReported >= 1
			End Get
		End Property
		Public Property Votes() As List(Of CandidateVote)
		Public Overrides Function ToString() As String
			Return String.Format("{0}/{1} FIPS:{2}, total votes: {3}", State, GetCounty(), FIPS, TotalVotesCount)
		End Function
		Public Function GetCounty() As CountyInfo
			Return CountyInfo.Counties2010.FirstOrDefault(Function(q) q.FIPS = FIPS)
		End Function
	End Class
	Public Class StateVote
		Public Property State() As String
		Public Property FIPS() As String
		Public Property TotalVotesCount() As Integer
		Public Property HasCountyVotes() As Boolean
		Public Property Votes() As List(Of CandidateVote)
		Public Property CountyVotes() As List(Of CountyVote)
		Public Overrides Function ToString() As String
			Return String.Format("{0}/{1} - {2}", State, FIPS, TotalVotesCount)
		End Function
	End Class

	Public Class CandidateVote
		Public Property CandidateType() As CandidateType
		Public Property Name() As String
		Public Property VotesCount() As Integer
		Public Property ElectoralVotes() As Integer
		Public Overrides Function ToString() As String
			Return String.Format("{0}/{1} Votes:{2}{3}", Name, CandidateType, VotesCount,If(ElectoralVotes > 0, " Electoral:" & ElectoralVotes.ToString(), ""))
		End Function
	End Class
	Public Class ElectionData
		Public Property Title() As String
		Public Property IsPlayGround() As Boolean
		Public Property Year() As String
		Public Property SnapshotTime() As Date
		Public Property Votes() As List(Of StateVote)
		Public Property Source() As String
	End Class

	Public Enum CandidateType
		Democrat
		Republican
		Other
	End Enum

	Public Class StateInfo
		Friend Sub New(ByVal data As String)
			Dim d = data.Split("|"c)
			If d.Length > 2 Then
				FIPS = d(0).Trim()
				State = d(1).Trim()
				Name = d(2).Trim()
			End If
		End Sub
		Public Property FIPS() As String
		Public Property State() As String
		Public Property Name() As String

        Private Shared states_Renamed As List(Of StateInfo)
        Private Shared stateToInfo As Dictionary(Of String, StateInfo)
		Private Shared Function GetStateToInfo() As Dictionary(Of String, StateInfo)
			If stateToInfo Is Nothing Then
				stateToInfo = New Dictionary(Of String, VoteApp.StateInfo)(StringComparer.InvariantCultureIgnoreCase)
				For Each si In States
					stateToInfo(si.State) = si
				Next si
			End If
			Return stateToInfo
		End Function
		Public Shared Function GetState(ByVal state As String) As StateInfo
            Dim res As New StateInfo(String.Empty)
            If GetStateToInfo().TryGetValue(state, res) Then
                Return res
            End If
            Return Nothing
		End Function
		Public Shared ReadOnly Property States() As List(Of StateInfo)
			Get
				If states_Renamed Is Nothing Then
					states_Renamed = GetStates()
				End If
				Return states_Renamed
			End Get
		End Property
		Private Shared Function GetStates() As List(Of StateInfo)
			Dim res As New List(Of StateInfo)()
            Using stream = GetType(StateInfo).Assembly.GetManifestResourceStream("states.txt")
                Using sr = New StreamReader(stream)
                    Do
                        Dim line = sr.ReadLine()
                        If line Is Nothing Then
                            Exit Do
                        End If
                        res.Add(New StateInfo(line))
                    Loop
                End Using
            End Using
            Return res

		End Function
	End Class
	Public Class CountyInfo
		Public Sub New(ByVal countyLine As String)
			Dim d = countyLine.Split(","c)
			If d.Length > 4 Then
				State = d(0).Trim()
				StateFIPS = d(1).Trim()
				CountyFIPS = d(2).Trim()
				CountyName = d(3).Trim()
				CountyType = d(4).Trim()
			End If
		End Sub
		Public Property State() As String
		Public Property StateFIPS() As String
		Public Property CountyFIPS() As String
		Public ReadOnly Property FIPS() As String
			Get
				Return StateFIPS & CountyFIPS
			End Get
		End Property
		Public Property CountyName() As String
		Public Property CountyType() As String
        Private Shared counties2010_Renamed As List(Of CountyInfo)
        Public Shared ReadOnly Property Counties2010() As List(Of CountyInfo)
			Get
				If counties2010_Renamed Is Nothing Then
					counties2010_Renamed = GetCounties2010()
				End If
				Return counties2010_Renamed
			End Get
		End Property
		Private Shared fipsToCounty2010 As Dictionary(Of String, CountyInfo)
		Private Shared Function GetFipsToCounty2010() As Dictionary(Of String, CountyInfo)
			If fipsToCounty2010 Is Nothing Then
				fipsToCounty2010 = New Dictionary(Of String, CountyInfo)(StringComparer.InvariantCultureIgnoreCase)
				For Each si In Counties2010
					fipsToCounty2010(si.FIPS) = si
				Next si
			End If
			Return fipsToCounty2010
		End Function
		Public Shared Function GetCounty(ByVal fips As String) As CountyInfo
            Dim res As New CountyInfo(String.Empty)
            If GetFipsToCounty2010().TryGetValue(fips, res) Then
				Return res
			End If
			Return Nothing
		End Function

		Public Function IsMatchFIPS(ByVal fips As String) As Boolean
			If fips = Me.FIPS Then
				Return True
			End If
			If Me.FIPS.Chars(0) = "0"c AndAlso Me.FIPS.Substring(1) = fips Then
				Return True
			End If
			Return False
		End Function
		Public Shared Function GetCounties2010() As List(Of CountyInfo)
			Dim res As New List(Of CountyInfo)()
            Using stream = GetType(StateInfo).Assembly.GetManifestResourceStream("counties.txt")
                Using sr = New StreamReader(stream)
                    Do
                        Dim raw = sr.ReadLine()
                        If raw Is Nothing Then
                            Exit Do
                        End If
                        If String.IsNullOrEmpty(raw.Trim()) Then
                            Continue Do
                        End If
                        res.Add(New CountyInfo(raw))
                    Loop
                End Using
            End Using
            Return res
		End Function
		Public Overrides Function ToString() As String
			Return CountyName
		End Function
	End Class

	Public Class ListVoteResults
		Public Property Name() As String
		Public Property State() As String
		Public Property County() As String
		Public Property RepVotes() As Integer
		Public Property DemVotes() As Integer
		Public Property OtherVotes() As Integer
		Public Property RepElectoralVotes() As Integer
		Public Property DemElectoralVotes() As Integer
		Public Property TotalVotes() As Integer

		Public ReadOnly Property DemPercents() As Decimal
			Get
				Return Helpers.GetPercent(DemVotes, TotalVotes)
			End Get
		End Property
		Public ReadOnly Property RepPercents() As Decimal
			Get
				Return Helpers.GetPercent(RepVotes, TotalVotes)
			End Get
		End Property

		Public ReadOnly Property IntDemPercents() As Integer
			Get
				Return CInt(Math.Truncate(Math.Round(DemPercents * 100)))
			End Get
		End Property
		Public ReadOnly Property IntRepPercents() As Integer
			Get
				Return CInt(Math.Truncate(Math.Round(RepPercents * 100)))
			End Get
		End Property
		Public Property CountyFIPS() As String
	End Class
End Namespace
