Imports Microsoft.VisualBasic
Imports System

Namespace DevExpress.XtraVerticalGrid.Demos.Tutorials
	Public Class RowFormatRecord
		Private payment_Renamed As Double
		Private length_Renamed As Long
		Private purchaseDate_Renamed As DateTime
		Private number_Renamed As Integer

		Public Sub New(ByVal payment_Renamed As Double, ByVal length_Renamed As Long, ByVal purchaseDate_Renamed As DateTime, ByVal number_Renamed As Integer)
			Me.payment_Renamed = payment_Renamed
			Me.length_Renamed = length_Renamed
			Me.purchaseDate_Renamed = purchaseDate_Renamed
			Me.number_Renamed = number_Renamed
		End Sub

		Public Property Payment() As Double
			Get
				Return payment_Renamed
			End Get
			Set
				payment_Renamed = Value
			End Set
		End Property

		Public Property Length() As Long
			Get
				Return length_Renamed
			End Get
			Set
				length_Renamed = Value
			End Set
		End Property

		Public Property PurchaseDate() As DateTime
			Get
				Return purchaseDate_Renamed
			End Get
			Set
				purchaseDate_Renamed = Value
			End Set
		End Property

		Public Property Number() As Integer
			Get
				Return number_Renamed
			End Get
			Set
				number_Renamed = Value
			End Set
		End Property
	End Class
	Public Class BaseFormatter
		Implements IFormatProvider, ICustomFormatter

		Public Function GetFormat(ByVal format As Type) As Object Implements IFormatProvider.GetFormat
			If format Is GetType(ICustomFormatter) Then
			Return Me
			Else
				Return Nothing
			End If
		End Function

        Public Function Format(ByVal format_Renamed As String, ByVal arg As Object, ByVal provider As IFormatProvider) As String Implements ICustomFormatter.Format
            If format_Renamed Is Nothing Then
                If TypeOf arg Is IFormattable Then
                    Return (CType(arg, IFormattable)).ToString(format_Renamed, provider)
                Else
                    Return arg.ToString()
                End If
            End If


            If (Not format_Renamed.StartsWith("B")) Then
                If TypeOf arg Is IFormattable Then
                    Return (CType(arg, IFormattable)).ToString(format_Renamed, provider)
                Else
                    Return arg.ToString()
                End If
            End If

            format_Renamed = format_Renamed.Trim(New Char() {"B"c})
            Dim b As Integer = Convert.ToInt32(format_Renamed)
            Return Convert.ToString(CInt(Fix(arg)), b)
        End Function
	End Class
End Namespace

