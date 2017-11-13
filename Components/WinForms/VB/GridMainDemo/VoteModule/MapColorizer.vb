Imports DevExpress.Utils.Drawing
Imports DevExpress.XtraMap
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace DevExpress.VoteApp
	Public Class VoteMapColorizer
		Public ReadOnly Property DemColor() As Color
			Get
				Return Color.FromArgb(255, Color.FromArgb(0, 84, 156, 189))
			End Get
		End Property
		Public ReadOnly Property RepColor() As Color
			Get
				Return Color.FromArgb(255, Color.FromArgb(0, 207, 64, 76))
			End Get
		End Property
		Public ReadOnly Property OtherColor() As Color
			Get
				Return Color.FromArgb(255, Color.Orange)
			End Get
		End Property
		Public Function StateFromMapAttribute(ByVal attributes As MapItemAttributeCollection) As StateInfo
			If attributes Is Nothing Then
				Return Nothing
			End If
			Dim postalAttr = attributes("STUSPS")
			If postalAttr IsNot Nothing Then
				Return StateInfo.GetState((If(postalAttr.Value, "")).ToString())
			End If
			Return Nothing
		End Function
		Public Function CountyFromMapAttribute(ByVal attributes As MapItemAttributeCollection) As CountyInfo
			If attributes Is Nothing Then
				Return Nothing
			End If
			Dim countyAttr = attributes("GEOID")
			If countyAttr IsNot Nothing Then
				Return CountyInfo.GetCounty((If(countyAttr.Value, "")).ToString())
			End If
			Return Nothing
		End Function
		Public Sub ColorizeStateItems(ByVal electionData As ElectionData, ByVal mapItems As List(Of MapItem))
			If electionData Is Nothing Then
				Return
			End If
			For Each item In mapItems
				Dim state = StateFromMapAttribute(item.Attributes)
				If state IsNot Nothing Then
					Dim results = electionData.Votes.FirstOrDefault(Function(q) q.State = state.State)
					If results IsNot Nothing Then
						ColorizeStateItem(item, results)
						Continue For
					End If
				End If
				ColorizeItemAsUnknown(item)

			Next item
		End Sub
		Public Sub ColorizeCountyItems(ByVal electionData As ElectionData, ByVal mapItems As List(Of MapItem))
			If electionData Is Nothing Then
				Return
			End If
			For Each item In mapItems
				Dim county = CountyFromMapAttribute(item.Attributes)
				If county IsNot Nothing Then
					Dim results = electionData.Votes.FirstOrDefault(Function(q) q.State = county.State)
					If results IsNot Nothing AndAlso results.HasCountyVotes Then
						Dim countyResults = results.CountyVotes.FirstOrDefault(Function(q) q.FIPS = county.FIPS)
						If countyResults IsNot Nothing Then
							ColorizeCountyItem(item, countyResults)
						End If
						Continue For
					End If
				End If
				ColorizeItemAsUnknown(item)

			Next item
		End Sub
		Public ReadOnly Property IsColorByTotalVotes() As Boolean
			Get
				Return True
			End Get
		End Property
		Private Sub ColorizeCountyItem(ByVal item As MapItem, ByVal results As CountyVote)
			Dim maxVotes = results.Votes.Max(Function(q) q.VotesCount)
            Dim winnerVotes As CandidateVote = If(maxVotes > 0, results.Votes.FirstOrDefault(Function(q) q.VotesCount.Equals(maxVotes)), Nothing)

            If winnerVotes Is Nothing Then
				ColorizeItemAsUnknown(item)
				Return
			End If
			ColorizeItemByWinner(item, results.TotalVotesCount, winnerVotes)
		End Sub

		Private Sub ColorizeStateItem(ByVal item As MapItem, ByVal results As StateVote)
			Dim maxVotes = results.Votes.Max(Function(q) q.VotesCount)
			Dim maxElectoral = results.Votes.Max(Function(q) q.ElectoralVotes)
            Dim winnerElectoral As CandidateVote = If(maxElectoral > 0, results.Votes.FirstOrDefault(Function(q) q.ElectoralVotes.Equals(maxElectoral)), Nothing)
            Dim winnerVotes As CandidateVote = If(maxVotes > 0, results.Votes.FirstOrDefault(Function(q) q.VotesCount.Equals(maxVotes)), Nothing)

            If IsColorByTotalVotes OrElse winnerElectoral Is Nothing Then
				If winnerVotes Is Nothing Then
					ColorizeItemAsUnknown(item)
					Return
				End If
				ColorizeItemByWinner(item, results.TotalVotesCount, winnerVotes)
				Return
			End If
			If winnerElectoral IsNot Nothing Then
				ColorizeItemByWinner(item, results.TotalVotesCount, winnerVotes, True)
			End If
		End Sub

		Private Sub ColorizeItemByWinner(ByVal item As MapItem, ByVal totalVotes As Integer, ByVal winnerVotes As CandidateVote, Optional ByVal ignoreGradient As Boolean = False)
			Dim baseColor As Color = ColorByType(winnerVotes.CandidateType)

			If Not ignoreGradient Then
				Dim percent As Decimal = Helpers.GetPercent(winnerVotes.VotesCount, totalVotes)
				If percent > 0.85D Then
					baseColor = HSLColor.Darken(baseColor, 0.5)
				Else
					If percent > 0.7D Then
						baseColor = HSLColor.Darken(baseColor, 0.8)
					End If
				End If
			End If

			item.Fill = baseColor
			item.HighlightedFill = baseColor
			item.SelectedFill = baseColor
		End Sub
		Private Sub ColorizeItemAsUnknown(ByVal item As MapItem)
			item.Fill = Color.LightGray
			item.HighlightedFill = item.Fill
			item.SelectedFill = item.HighlightedFill
		End Sub
		Public Function ColorByType(ByVal candidateType As CandidateType) As Color
			Select Case candidateType
				Case DevExpress.VoteApp.CandidateType.Republican
					Return RepColor
				Case DevExpress.VoteApp.CandidateType.Democrat
					Return DemColor
			End Select
			Return OtherColor
		End Function
		Friend Function GenerateImage(ByVal candidateType As CandidateType) As Image
			Dim bi As New Bitmap(16, 16)
			Using g As Graphics = Graphics.FromImage(bi)
				g.Clear(ColorByType(candidateType))
			End Using
			Return bi
		End Function
	End Class
End Namespace
