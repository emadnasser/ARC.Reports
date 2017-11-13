Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.UnitConversion
Imports DevExpress.Web

Partial Public Class Miscellaneous_UnitConversion
	Inherits System.Web.UI.Page
	Private Const InitialCelsiusValue As Decimal = 36.6D
	Private Const InitialKilopascalValue As Decimal = 101.33D
	Private Const InitialGrammValue As Integer = 1
	Private Const InitialKilometerValue As Integer = 1
	Private Const InitialMeterValue As Integer = 1
	Private Const InitialSquareMeterValue As Integer = 1
	Private Const InitialNewtonValue As Integer = 1
	Private Const InitialHorsepowerValue As Integer = 1
	Private Const InitialCentimeterValue As Decimal = 2.54D
	Private metricUnitsConverter As New MetricUnitsConverter()

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			InitializeData()
			Calculate()
		End If
	End Sub
	Private Sub Calculate()
		ConvertFromGramm()
		ConvertFromKilometers()
		ConvertFromCentimeter()
		ConvertFromMeter()
		ConvertFromSquareMeter()
		ConvertFromCelsius()
		ConvertFromKilopascal()
		ConvertFromNewton()
		ConvertFromHorsepower()
	End Sub
	Private Sub InitializeData()
		seCelsius.Number = InitialCelsiusValue
		seKilopascal.Number = InitialKilopascalValue
		seGramm.Number = InitialGrammValue
		seKilometer.Number = InitialKilometerValue
		seMeter.Number = InitialMeterValue
		seCentimeter.Number = InitialCentimeterValue
		seSquareMeter.Number = InitialSquareMeterValue
		seNewton.Number = InitialNewtonValue
		seHorsepower.Number = InitialHorsepowerValue
	End Sub
	Private Function Round(ByVal value As Double, ByVal digits As Integer) As Decimal
		Return CDec(Math.Round(value, digits))
	End Function
	Private Sub ConvertFromCelsius()
		Dim value As Double = CDbl(seCelsius.Number)
		Dim fahrenheit As Double = Units.Temperature.Convert(value, Temperature.Celsius, Temperature.Fahrenheit)
		Dim kelvin As Double = Units.Temperature.Convert(value, Temperature.Celsius, Temperature.Kelvin)

		seFahrenheit.Number = Round(fahrenheit, 2)
		seKelvin.Number = Round(kelvin, 2)
	End Sub
	Private Sub ConvertFromFahrenheit()
		Dim value As Double = CDbl(seFahrenheit.Number)
		Dim celsius As Double = value.Fahrenheit().ToCelsius()
		Dim kelvin As Double = value.Fahrenheit().ToKelvin()

		seCelsius.Number = Round(celsius, 2)
		seKelvin.Number = Round(kelvin, 2)
	End Sub
	Private Sub ConvertFromKelvin()
		Dim value As Double = CDbl(seKelvin.Number)
		Dim celsius As Double = value.Kelvin().ToCelsius()
		Dim fahrenheit As Double = value.Kelvin().ToFahrenheit()

		seCelsius.Number = Round(celsius, 2)
		seFahrenheit.Number = Round(fahrenheit, 2)
	End Sub
	Private Sub ConvertFromKilopascal()
		Dim value As Double = CDbl(seKilopascal.Number)
		Dim pascal As Double = metricUnitsConverter.Convert(value, MetricPrefix.Kilo, MetricPrefix.None)
		Dim atmosphere As Double = Units.Pressure.Convert(pascal, Pressure.Pascal, Pressure.Atmosphere)
		Dim mmOfMercury As Double = Units.Pressure.Convert(pascal, Pressure.Pascal, Pressure.MmHg)

		seAtmosphere.Number = Round(atmosphere, 2)
		seMmOfMercury.Number = Round(mmOfMercury, 2)
	End Sub
	Private Sub ConvertFromAtmosphere()
		Dim value As Double = CDbl(seAtmosphere.Number)
		Dim kilopascal As Double = metricUnitsConverter.Convert(value.Atmospheres().ToPascals(), MetricPrefix.None, MetricPrefix.Kilo)
		Dim mmOfMercury As Double = value.Atmospheres().ToMmHg()

		seKilopascal.Number = Round(kilopascal, 2)
		seMmOfMercury.Number = Round(mmOfMercury, 2)
	End Sub
	Private Sub ConvertFromMmOfMercury()
		Dim value As Double = CDbl(seMmOfMercury.Number)
		Dim kilopascal As Double = metricUnitsConverter.Convert(value.MmHg().ToPascals(), MetricPrefix.None, MetricPrefix.Kilo)
		Dim atmosphere As Double = value.MmHg().ToAtmospheres()

		seKilopascal.Number = Round(kilopascal, 2)
		seAtmosphere.Number = Round(atmosphere, 2)
	End Sub
	Private Sub ConvertFromGramm()
		Dim value As Double = CDbl(seGramm.Number)
		Dim kilograms As Double = value.Grams().ToKilograms()
		Dim pounds As Double = value.Grams().ToPounds()
		Dim ounces As Double = value.Grams().ToOunceMass()

		seKilogramm.Number = Round(kilograms, 3)
		sePoundMass.Number = Round(pounds, 3)
		seOunceMass.Number = Round(ounces, 3)
	End Sub
	Private Sub ConvertFromKilogramm()
		Dim value As Double = CDbl(seKilogramm.Number)
		Dim pounds As Double = value.Kilograms().ToPounds()
		Dim ounces As Double = value.Kilograms().ToOunceMass()
		Dim grams As Double = value.Kilograms().ToGrams()

		sePoundMass.Number = Round(pounds, 3)
		seOunceMass.Number = Round(ounces, 3)
		seGramm.Number = Round(grams, 3)
	End Sub
	Private Sub ConvertFromPoundMass()
		Dim value As Double = CDbl(sePoundMass.Number)
		Dim ounces As Double = value.Pounds().ToOunceMass()
		Dim grams As Double = value.Pounds().ToGrams()
		Dim kilograms As Double = value.Pounds().ToKilograms()

		seOunceMass.Number = Round(ounces, 3)
		seGramm.Number = Round(grams, 3)
		seKilogramm.Number = Round(kilograms, 3)
	End Sub
	Private Sub ConvertFromKilometers()
		Dim value As Double = metricUnitsConverter.Convert(CDbl(seKilometer.Number), MetricPrefix.Kilo, MetricPrefix.None)
		Dim statuteMile As Double = value.Meters().ToMilesStatute()
		Dim nauticalMile As Double = value.Meters().ToMilesNautical()

		seStatuteMile.Number = Round(statuteMile, 3)
		seNauticalMile.Number = Round(nauticalMile, 3)
	End Sub
	Private Sub ConvertFromStatuteMile()
		Dim value As Double = CDbl(seStatuteMile.Number)
		Dim nauticalMile As Double = value.MilesStatute().ToMilesNautical()
		Dim kilometers As Double = metricUnitsConverter.Convert(value.MilesStatute().ToMeters(), MetricPrefix.None, MetricPrefix.Kilo)

		seNauticalMile.Number = Round(nauticalMile, 3)
		seKilometer.Number = Round(kilometers, 3)
	End Sub
	Private Sub ConvertFromNauticalMile()
		Dim value As Double = CDbl(seNauticalMile.Number)
		Dim kilometers As Double = metricUnitsConverter.Convert(value.MilesNautical().ToMeters(), MetricPrefix.None, MetricPrefix.Kilo)
		Dim statuteMile As Double = value.MilesNautical().ToMilesStatute()

		seKilometer.Number = Round(kilometers, 3)
		seStatuteMile.Number = Round(statuteMile, 3)
	End Sub
	Private Sub ConvertFromMeter()
		Dim value As Double = CDbl(seMeter.Number)
		Dim yard As Double = value.Meters().ToYards()
		Dim feet As Double = value.Meters().ToFeet()

		seYard.Number = Round(yard, 3)
		seMeterToFoot.Number = Round(feet, 3)
	End Sub
	Private Sub ConvertFromFoot1()
		Dim value As Double = CDbl(seMeterToFoot.Number)
		Dim yard As Double = value.Feet().ToYards()
		Dim meters As Double = value.Feet().ToMeters()

		seYard.Number = Round(yard, 3)
		seMeter.Number = Round(meters, 3)
	End Sub
	Private Sub ConvertFromYard()
		Dim value As Double = CDbl(seYard.Number)
		Dim feet As Double = value.Yards().ToFeet()
		Dim meters As Double = value.Yards().ToMeters()

		seMeterToFoot.Number = Round(feet, 3)
		seMeter.Number = Round(meters, 3)
	End Sub
	Private Sub ConvertFromCentimeter()
		Dim value As Double = metricUnitsConverter.Convert(CDbl(seCentimeter.Number), MetricPrefix.Centi, MetricPrefix.None)
		Dim inches As Double = value.Meters().ToInches()
		Dim feet As Double = value.Meters().ToFeet()

		seInch.Number = Round(inches, 3)
		seCentimeterToFoot.Number = Round(feet, 3)
	End Sub
	Private Sub ConvertFromInch()
		Dim value As Double = CDbl(seInch.Number)
		Dim сentimeters As Double = metricUnitsConverter.Convert(value.Inches().ToMeters(), MetricPrefix.None, MetricPrefix.Centi)
		Dim feet As Double = value.Inches().ToFeet()

		seCentimeter.Number = Round(сentimeters, 3)
		seCentimeterToFoot.Number = Round(feet, 3)
	End Sub
	Private Sub ConvertFromNewton()
		Dim value As Double = CDbl(seNewton.Number)
		Dim dynes As Double = value.Newtons().ToDynes()
		Dim force As Double = value.Newtons().ToPoundForce()

		seDyne.Number = Round(dynes, 5)
		sePoundForce.Number = Round(force, 5)
	End Sub
	Private Sub ConvertFromDyne()
		Dim value As Double = CDbl(seDyne.Number)
		Dim newton As Double = value.Dynes().ToNewtons()
		Dim force As Double = value.Dynes().ToPoundForce()

		seNewton.Number = Round(newton, 5)
		sePoundForce.Number = Round(force, 5)
	End Sub
	Private Sub ConvertFromHorsepower()
		Dim value As Double = CDbl(seHorsepower.Number)
		Dim watts As Double = value.HorsePower().ToWatts()

		seWatt.Number = Round(watts, 2)
	End Sub
	Private Sub ConvertFromWatt()
		Dim value As Double = CDbl(seWatt.Number)
		Dim horsepower As Double = value.Watts().ToHorsePower()

		seHorsepower.Number = Round(horsepower, 2)
	End Sub
	Private Sub ConvertFromPoundForce()
		Dim value As Double = CDbl(sePoundForce.Number)
		Dim newton As Double = value.PoundForce().ToNewtons()
		Dim dynes As Double = value.PoundForce().ToDynes()

		seNewton.Number = Round(newton, 5)
		seDyne.Number = Round(dynes, 5)
	End Sub
	Private Sub ConvertFromFoot2()
		Dim value As Double = CDbl(seCentimeterToFoot.Number)
		Dim сentimeters As Double = metricUnitsConverter.Convert(value.Feet().ToMeters(), MetricPrefix.None, MetricPrefix.Centi)
		Dim inches As Double = value.Feet().ToInches()

		seCentimeter.Number = Round(сentimeters, 3)
		seInch.Number = Round(inches, 3)
	End Sub
	Private Sub ConvertFromSquareMeter()
		Dim squareFeet As Double = (CDbl(seSquareMeter.Number)).SquareMeters().ToSquareFeet()
		seSquareFeet.Number = Round(squareFeet, 3)
	End Sub
	Private Sub ConvertFromSquareFeet()
		Dim squareMeters As Double = (CDbl(seSquareFeet.Number)).SquareFeet().ToSquareMeters()
		seSquareMeter.Number = Round(squareMeters, 3)
	End Sub
	Private Sub ConvertFromOunceMass()
		Dim value As Double = CDbl(seOunceMass.Number)
		Dim grams As Double = value.OunceMass().ToGrams()
		Dim kilograms As Double = value.OunceMass().ToKilograms()
		Dim pounds As Double = value.OunceMass().ToPounds()

		seGramm.Number = Round(grams, 3)
		seKilogramm.Number = Round(kilograms, 3)
		sePoundMass.Number = Round(pounds, 3)
	End Sub
	Public Sub hf_CustomCallback(ByVal sender As Object, ByVal e As CallbackEventArgsBase)
		Dim hf As ASPxHiddenField = CType(sender, ASPxHiddenField)

		RefreshData(e.Parameter)
		hf.Set("data", GetData())
	End Sub
	Private Function GetData() As Dictionary(Of String, Double)
		Dim data As New Dictionary(Of String, Double)()
		data.Add("seGramm", CDbl(seGramm.Number))
		data.Add("seKilogramm", CDbl(seKilogramm.Number))
		data.Add("sePoundMass", CDbl(sePoundMass.Number))
		data.Add("seOunceMass", CDbl(seOunceMass.Number))

		data.Add("seKilometer", CDbl(seKilometer.Number))
		data.Add("seStatuteMile", CDbl(seStatuteMile.Number))
		data.Add("seNauticalMile", CDbl(seNauticalMile.Number))
		data.Add("seMeter", CDbl(seMeter.Number))
		data.Add("seMeterToFoot", CDbl(seMeterToFoot.Number))
		data.Add("seYard", CDbl(seYard.Number))
		data.Add("seCentimeter", CDbl(seCentimeter.Number))
		data.Add("seInch", CDbl(seInch.Number))
		data.Add("seCentimeterToFoot", CDbl(seCentimeterToFoot.Number))
		data.Add("seSquareMeter", CDbl(seSquareMeter.Number))
		data.Add("seSquareFeet", CDbl(seSquareFeet.Number))


		data.Add("seCelsius", CDbl(seCelsius.Number))
		data.Add("seFahrenheit", CDbl(seFahrenheit.Number))
		data.Add("seKelvin", CDbl(seKelvin.Number))
		data.Add("seKilopascal", CDbl(seKilopascal.Number))
		data.Add("seAtmosphere", CDbl(seAtmosphere.Number))
		data.Add("seMmOfMercury", CDbl(seMmOfMercury.Number))

		data.Add("seNewton", CDbl(seNewton.Number))
		data.Add("seDyne", CDbl(seDyne.Number))
		data.Add("sePoundForce", CDbl(sePoundForce.Number))
		data.Add("seHorsepower", CDbl(seHorsepower.Number))
		data.Add("seWatt", CDbl(seWatt.Number))

		Return data
	End Function
	Private Sub RefreshData(ByVal name As String)
		Select Case name
			Case "seGramm"
				ConvertFromGramm()
			Case "seKilogramm"
				ConvertFromKilogramm()
			Case "sePoundMass"
				ConvertFromPoundMass()
			Case "seOunceMass"
				ConvertFromOunceMass()

			Case "seKilometer"
				ConvertFromKilometers()
			Case "seStatuteMile"
				ConvertFromStatuteMile()
			Case "seNauticalMile"
				ConvertFromNauticalMile()
			Case "seMeter"
				ConvertFromMeter()
			Case "seMeterToFoot"
				ConvertFromFoot1()
			Case "seYard"
				ConvertFromYard()
			Case "seCentimeter"
				ConvertFromCentimeter()
			Case "seInch"
				ConvertFromInch()
			Case "seCentimeterToFoot"
				ConvertFromFoot2()
			Case "seSquareMeter"
				ConvertFromSquareMeter()
			Case "seSquareFeet"
				ConvertFromSquareFeet()

			Case "seCelsius"
				ConvertFromCelsius()
			Case "seFahrenheit"
				ConvertFromFahrenheit()
			Case "seKelvin"
				ConvertFromKelvin()
			Case "seKilopascal"
				ConvertFromKilopascal()
			Case "seAtmosphere"
				ConvertFromAtmosphere()
			Case "seMmOfMercury"
				ConvertFromMmOfMercury()

			Case "seNewton"
				ConvertFromNewton()
			Case "seDyne"
				ConvertFromDyne()
			Case "sePoundForce"
				ConvertFromPoundForce()
			Case "seHorsepower"
				ConvertFromHorsepower()
			Case "seWatt"
				ConvertFromWatt()
		End Select
	End Sub
End Class
