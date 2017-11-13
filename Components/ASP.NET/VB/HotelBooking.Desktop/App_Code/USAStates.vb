Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Collections.ObjectModel

Namespace HotelBookingWebFormApp
    Public Class USAStates


        Private states_Renamed As New List(Of State)()

        Public ReadOnly Property States() As ReadOnlyCollection(Of State)
            Get
                Return states_Renamed.AsReadOnly()
            End Get
        End Property

        Public Sub New()
            PopulateStates()
        End Sub

        Private Sub PopulateStates()
            states_Renamed.Add(New State("AL", "Alabama"))
            states_Renamed.Add(New State("AK", "Alaska"))
            states_Renamed.Add(New State("AZ", "Arizona"))
            states_Renamed.Add(New State("AR", "Arkansas"))
            states_Renamed.Add(New State("CA", "California"))
            states_Renamed.Add(New State("CO", "Colorado"))
            states_Renamed.Add(New State("CT", "Connecticut"))
            states_Renamed.Add(New State("DC", "District of Columbia"))
            states_Renamed.Add(New State("DE", "Delaware"))
            states_Renamed.Add(New State("FL", "Florida"))
            states_Renamed.Add(New State("GA", "Georgia"))
            states_Renamed.Add(New State("HI", "Hawaii"))
            states_Renamed.Add(New State("ID", "Idaho"))
            states_Renamed.Add(New State("IL", "Illinois"))
            states_Renamed.Add(New State("IN", "Indiana"))
            states_Renamed.Add(New State("IA", "Iowa"))
            states_Renamed.Add(New State("KS", "Kansas"))
            states_Renamed.Add(New State("KY", "Kentucky"))
            states_Renamed.Add(New State("LA", "Louisiana"))
            states_Renamed.Add(New State("ME", "Maine"))
            states_Renamed.Add(New State("MD", "Maryland"))
            states_Renamed.Add(New State("MA", "Massachusetts"))
            states_Renamed.Add(New State("MI", "Michigan"))
            states_Renamed.Add(New State("MN", "Minnesota"))
            states_Renamed.Add(New State("MS", "Mississippi"))
            states_Renamed.Add(New State("MO", "Missouri"))
            states_Renamed.Add(New State("MT", "Montana"))
            states_Renamed.Add(New State("NE", "Nebraska"))
            states_Renamed.Add(New State("NV", "Nevada"))
            states_Renamed.Add(New State("NH", "New Hampshire"))
            states_Renamed.Add(New State("NJ", "New Jersey"))
            states_Renamed.Add(New State("NM", "New Mexico"))
            states_Renamed.Add(New State("NY", "New York"))
            states_Renamed.Add(New State("NC", "North Carolina"))
            states_Renamed.Add(New State("ND", "North Dakota"))
            states_Renamed.Add(New State("OH", "Ohio"))
            states_Renamed.Add(New State("OK", "Oklahoma"))
            states_Renamed.Add(New State("OR", "Oregon"))
            states_Renamed.Add(New State("PA", "Pennsylvania"))
            states_Renamed.Add(New State("RI", "Rhode Island"))
            states_Renamed.Add(New State("SC", "South Carolina"))
            states_Renamed.Add(New State("SD", "South Dakota"))
            states_Renamed.Add(New State("TN", "Tennessee"))
            states_Renamed.Add(New State("TX", "Texas"))
            states_Renamed.Add(New State("UT", "Utah"))
            states_Renamed.Add(New State("VT", "Vermont"))
            states_Renamed.Add(New State("VA", "Virginia"))
            states_Renamed.Add(New State("WA", "Washington"))
            states_Renamed.Add(New State("WV", "West Virginia"))
            states_Renamed.Add(New State("WI", "Wisconsin"))
            states_Renamed.Add(New State("WY", "Wyoming"))
        End Sub
        Public Class State
            ' Fields...
            Private _StateAbr As String
            Private _StateName As String

            ''' <summary>
            ''' Initializes a new instance of the State class.
            ''' </summary>
            ''' <param name="stateAbr"></param>
            ''' <param name="stateName"></param>
            Public Sub New(ByVal stateAbr As String, ByVal stateName As String)
                _StateAbr = stateAbr
                _StateName = stateName
            End Sub

            Public Property StateName() As String
                Get
                    Return _StateName
                End Get
                Set(ByVal value As String)
                    _StateName = value
                End Set
            End Property


            Public Property StateAbr() As String
                Get
                    Return _StateAbr
                End Get
                Set(ByVal value As String)
                    _StateAbr = value
                End Set
            End Property


        End Class


    End Class
End Namespace
