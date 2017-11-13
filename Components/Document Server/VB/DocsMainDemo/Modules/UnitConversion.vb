Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Globalization
Imports DevExpress.Docs.Text
Imports DevExpress.DXperience.Demos
Imports DevExpress.UnitConversion
Imports DevExpress.XtraEditors

Namespace DevExpress.Docs.Demos
	Partial Public Class UnitConversion
		Inherits TutorialControlBase
		Private Const InitialCelsiusValue As Decimal = 36.6D
		Private Const InitialKilopascalValue As Decimal = 101.33D
		Private Const InitialGramValue As Integer = 1
		Private Const InitialKilometerValue As Integer = 1
		Private Const InitialMeterValue As Integer = 1
		Private Const InitialSquareMeterValue As Integer = 1
		Private Const InitialNewtonValue As Integer = 1
		Private Const InitialHorsepowerValue As Integer = 1
		Private Const InitialCentimeterValue As Decimal = 2.54D
		Private metricUnitsConverter As MetricUnitsConverter

		Public Sub New()
			InitializeComponent()
			SubscribeEvents()
			InitializeForm()
		End Sub

		Private Sub SubscribeEvents()
			SubscribeEvents_Temperature()
			SubscribeEvents_Pressure()
			SubscribeEvents_Weigth()
			SubscribeEvents_DistanceFromKilometers()
			SubscribeEvents_DistanceFromMeters()
			SubscribeEvents_DistanceFromCentimeter()
			SubscribeEvents_SquareFromSquareMeter()
			SubscribeEvents_Force()
			SubscribeEvents_Power()
		End Sub
		Private Sub InitializeForm()
			Me.metricUnitsConverter = New MetricUnitsConverter()
			seCelsius.Value = InitialCelsiusValue
			seKilopascal.Value = InitialKilopascalValue
			seGram.Value = InitialGramValue
			seKilometer.Value = InitialKilometerValue
			seMeter.Value = InitialMeterValue
			seCentimeter.Value = InitialCentimeterValue
			seSquareMeter.Value = InitialSquareMeterValue
			seNewton.Value = InitialNewtonValue
			seHorsepower.Value = InitialHorsepowerValue
		End Sub
		Private Sub ConvertFromCelsius()
			Dim value As Double = CDbl(seCelsius.Value)
			Dim fahrenheit As Double = Units.Temperature.Convert(value, Temperature.Celsius, Temperature.Fahrenheit)
			Dim kelvin As Double = Units.Temperature.Convert(value, Temperature.Celsius, Temperature.Kelvin)

			seFahrenheit.Value = Round(fahrenheit, 2)
			seKelvin.Value = Round(kelvin, 2)
		End Sub
		Private Sub ConvertFromFahrenheit()
			Dim value As Double = CDbl(seFahrenheit.Value)
			Dim celsius As Double = value.Fahrenheit().ToCelsius()
			Dim kelvin As Double = value.Fahrenheit().ToKelvin()

			seCelsius.Value = Round(celsius, 2)
			seKelvin.Value = Round(kelvin, 2)
		End Sub
		Private Sub ConvertFromKelvin()
			Dim value As Double = CDbl(seKelvin.Value)
			Dim celsius As Double = value.Kelvin().ToCelsius()
			Dim fahrenheit As Double = value.Kelvin().ToFahrenheit()

			seCelsius.Value = Round(celsius, 2)
			seFahrenheit.Value = Round(fahrenheit, 2)
		End Sub
		Private Sub ConvertFromKilopascal()
			Dim value As Double = CDbl(seKilopascal.Value)
			Dim pascal As Double = metricUnitsConverter.Convert(value, MetricPrefix.Kilo, MetricPrefix.None)
			Dim atmosphere As Double = Units.Pressure.Convert(pascal, Pressure.Pascal, Pressure.Atmosphere)
			Dim mmOfMercury As Double = Units.Pressure.Convert(pascal, Pressure.Pascal, Pressure.MmHg)

			seAtmosphere.Value = Round(atmosphere, 2)
			seMmOfMercury.Value = Round(mmOfMercury, 2)
		End Sub
		Private Sub ConvertFromAtmosphere()
			Dim value As Double = CDbl(seAtmosphere.Value)
			Dim kilopascal As Double = metricUnitsConverter.Convert(value.Atmospheres().ToPascals(), MetricPrefix.None, MetricPrefix.Kilo)
			Dim mmOfMercury As Double = value.Atmospheres().ToMmHg()

			seKilopascal.Value = Round(kilopascal, 2)
			seMmOfMercury.Value = Round(mmOfMercury, 2)
		End Sub
		Private Sub ConvertFromMmOfMercury()
			Dim value As Double = CDbl(seMmOfMercury.Value)
			Dim kilopascal As Double = metricUnitsConverter.Convert(value.MmHg().ToPascals(), MetricPrefix.None, MetricPrefix.Kilo)
			Dim atmosphere As Double = value.MmHg().ToAtmospheres()

			seKilopascal.Value = Round(kilopascal, 2)
			seAtmosphere.Value = Round(atmosphere, 2)
		End Sub
		Private Sub ConvertFromGram()
			Dim value As Double = CDbl(seGram.Value)
			Dim kilograms As Double = value.Grams().ToKilograms()
			Dim pounds As Double = value.Grams().ToPounds()
			Dim ounces As Double = value.Grams().ToOunceMass()

			seKilogram.Value = Round(kilograms, 3)
			sePoundMass.Value = Round(pounds, 3)
			seOunceMass.Value = Round(ounces, 3)
		End Sub
		Private Sub ConvertFromKilogram()
			Dim value As Double = CDbl(seKilogram.Value)
			Dim pounds As Double = value.Kilograms().ToPounds()
			Dim ounces As Double = value.Kilograms().ToOunceMass()
			Dim grams As Double = value.Kilograms().ToGrams()

			sePoundMass.Value = Round(pounds, 3)
			seOunceMass.Value = Round(ounces, 3)
			seGram.Value = Round(grams, 3)
		End Sub
		Private Sub ConvertFromPoundMass()
			Dim value As Double = CDbl(sePoundMass.Value)
			Dim ounces As Double = value.Pounds().ToOunceMass()
			Dim grams As Double = value.Pounds().ToGrams()
			Dim kilograms As Double = value.Pounds().ToKilograms()

			seOunceMass.Value = Round(ounces, 3)
			seGram.Value = Round(grams, 3)
			seKilogram.Value = Round(kilograms, 3)
		End Sub
		Private Sub ConvertFromKilometers()
			Dim value As Double = metricUnitsConverter.Convert(CDbl(seKilometer.Value), MetricPrefix.Kilo, MetricPrefix.None)
			Dim statuteMile As Double = value.Meters().ToMilesStatute()
			Dim nauticalMile As Double = value.Meters().ToMilesNautical()

			seStatuteMile.Value = Round(statuteMile, 3)
			seNauticalMile.Value = Round(nauticalMile, 3)
		End Sub
		Private Sub ConvertFromStatuteMile()
			Dim value As Double = CDbl(seStatuteMile.Value)
			Dim nauticalMile As Double = value.MilesStatute().ToMilesNautical()
			Dim kilometers As Double = metricUnitsConverter.Convert(value.MilesStatute().ToMeters(), MetricPrefix.None, MetricPrefix.Kilo)

			seNauticalMile.Value = Round(nauticalMile, 3)
			seKilometer.Value = Round(kilometers, 3)
		End Sub
		Private Sub ConvertFromNauticalMile()
			Dim value As Double = CDbl(seNauticalMile.Value)
			Dim kilometers As Double = metricUnitsConverter.Convert(value.MilesNautical().ToMeters(), MetricPrefix.None, MetricPrefix.Kilo)
			Dim statuteMile As Double = value.MilesNautical().ToMilesStatute()

			seKilometer.Value = Round(kilometers, 3)
			seStatuteMile.Value = Round(statuteMile, 3)
		End Sub
		Private Sub ConvertFromMeter()
			Dim value As Double = CDbl(seMeter.Value)
			Dim yard As Double = value.Meters().ToYards()
			Dim feet As Double = value.Meters().ToFeet()

			seYard.Value = Round(yard, 3)
			seMeterToFoot.Value = Round(feet, 3)
		End Sub
		Private Sub ConvertFromFoot1()
			Dim value As Double = CDbl(seMeterToFoot.Value)
			Dim yard As Double = value.Feet().ToYards()
			Dim meters As Double = value.Feet().ToMeters()

			seYard.Value = Round(yard, 3)
			seMeter.Value = Round(meters, 3)
		End Sub
		Private Sub ConvertFromYard()
			Dim value As Double = CDbl(seYard.Value)
			Dim feet As Double = value.Yards().ToFeet()
			Dim meters As Double = value.Yards().ToMeters()

			seMeterToFoot.Value = Round(feet, 3)
			seMeter.Value = Round(meters, 3)
		End Sub
		Private Sub ConvertFromCentimeter()
			Dim value As Double = metricUnitsConverter.Convert(CDbl(seCentimeter.Value), MetricPrefix.Centi, MetricPrefix.None)
			Dim inches As Double = value.Meters().ToInches()
			Dim feet As Double = value.Meters().ToFeet()

			seInch.Value = Round(inches, 3)
			seCentimeterToFoot.Value = Round(feet, 3)
		End Sub
		Private Sub ConvertFromInch()
			Dim value As Double = CDbl(seInch.Value)
			Dim сentimeters As Double = metricUnitsConverter.Convert(value.Inches().ToMeters(), MetricPrefix.None, MetricPrefix.Centi)
			Dim feet As Double = value.Inches().ToFeet()

			seCentimeter.Value = Round(сentimeters, 3)
			seCentimeterToFoot.Value = Round(feet, 3)
		End Sub
		Private Sub ConvertFromNewton()
			Dim value As Double = CDbl(seNewton.Value)
			Dim dynes As Double = value.Newtons().ToDynes()
			Dim force As Double = value.Newtons().ToPoundForce()

			seDyne.Value = Round(dynes, 5)
			sePoundForce.Value = Round(force, 5)
		End Sub
		Private Sub ConvertFromDyne()
			Dim value As Double = CDbl(seDyne.Value)
			Dim newton As Double = value.Dynes().ToNewtons()
			Dim force As Double = value.Dynes().ToPoundForce()

			seNewton.Value = Round(newton, 5)
			sePoundForce.Value = Round(force, 5)
		End Sub
		Private Sub ConvertFromHorsepower()
			Dim value As Double = CDbl(seHorsepower.Value)
			Dim watts As Double = value.HorsePower().ToWatts()

			seWatt.Value = Round(watts, 2)
		End Sub
		Private Sub ConvertFromWatt()
			Dim value As Double = CDbl(seWatt.Value)
			Dim horsepower As Double = value.Watts().ToHorsePower()

			seHorsepower.Value = Round(horsepower, 2)
		End Sub
		Private Sub ConvertFromPoundForce()
			Dim value As Double = CDbl(sePoundForce.Value)
			Dim newton As Double = value.PoundForce().ToNewtons()
			Dim dynes As Double = value.PoundForce().ToDynes()

			seNewton.Value = Round(newton, 5)
			seDyne.Value = Round(dynes, 5)
		End Sub
		Private Sub ConvertFromFoot2()
			Dim value As Double = CDbl(seCentimeterToFoot.Value)
			Dim сentimeters As Double = metricUnitsConverter.Convert(value.Feet().ToMeters(), MetricPrefix.None, MetricPrefix.Centi)
			Dim inches As Double = value.Feet().ToInches()

			seCentimeter.Value = Round(сentimeters, 3)
			seInch.Value = Round(inches, 3)
		End Sub
		Private Sub ConvertFromSquareMeter()
			Dim squareFeet As Double = (CDbl(seSquareMeter.Value)).SquareMeters().ToSquareFeet()
			seSquareFeet.Value = Round(squareFeet, 3)
		End Sub
		Private Sub ConvertFromSquareFeet()
			Dim squareMeters As Double = (CDbl(seSquareFeet.Value)).SquareFeet().ToSquareMeters()
			seSquareMeter.Value = Round(squareMeters, 3)
		End Sub
		Private Sub ConvertFromOunceMass()
			Dim value As Double = CDbl(seOunceMass.Value)
			Dim grams As Double = value.OunceMass().ToGrams()
			Dim kilograms As Double = value.OunceMass().ToKilograms()
			Dim pounds As Double = value.OunceMass().ToPounds()

			seGram.Value = Round(grams, 3)
			seKilogram.Value = Round(kilograms, 3)
			sePoundMass.Value = Round(pounds, 3)
		End Sub
		Private Function Round(ByVal value As Double, ByVal digits As Integer) As Decimal
			Return CDec(Math.Round(value, digits))
		End Function
		Private Sub seCelsius_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			UnscribeEvents_Temperature()
			ConvertFromCelsius()
			SubscribeEvents_Temperature()
		End Sub
		Private Sub seFahrenheit_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			UnscribeEvents_Temperature()
			ConvertFromFahrenheit()
			SubscribeEvents_Temperature()
		End Sub
		Private Sub seKelvin_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			UnscribeEvents_Temperature()
			ConvertFromKelvin()
			SubscribeEvents_Temperature()
		End Sub
		Private Sub seKilopascal_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			UnscribeEvents_Pressure()
			ConvertFromKilopascal()
			SubscribeEvents_Pressure()
		End Sub
		Private Sub seAtmosphere_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			UnscribeEvents_Pressure()
			ConvertFromAtmosphere()
			SubscribeEvents_Pressure()
		End Sub
		Private Sub seMmOfMercury_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			UnscribeEvents_Pressure()
			ConvertFromMmOfMercury()
			SubscribeEvents_Pressure()
		End Sub
		Private Sub seGram_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			UnscribeEvents_Weigth()
			ConvertFromGram()
			SubscribeEvents_Weigth()
		End Sub
		Private Sub seKilogram_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			UnscribeEvents_Weigth()
			ConvertFromKilogram()
			SubscribeEvents_Weigth()
		End Sub
		Private Sub sePoundMass_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			UnscribeEvents_Weigth()
			ConvertFromPoundMass()
			SubscribeEvents_Weigth()
		End Sub
		Private Sub seOunceMass_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			UnscribeEvents_Weigth()
			ConvertFromOunceMass()
			SubscribeEvents_Weigth()
		End Sub
		Private Sub seKilometer_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			UnscribeEvents_DistanceFromKilometers()
			ConvertFromKilometers()
			SubscribeEvents_DistanceFromKilometers()
		End Sub
		Private Sub seStatuteMile_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			UnscribeEvents_DistanceFromKilometers()
			ConvertFromStatuteMile()
			SubscribeEvents_DistanceFromKilometers()
		End Sub
		Private Sub seNauticalMile_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			UnscribeEvents_DistanceFromKilometers()
			ConvertFromNauticalMile()
			SubscribeEvents_DistanceFromKilometers()
		End Sub
		Private Sub seMeter_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			UnscribeEvents_DistanceFromMeters()
			ConvertFromMeter()
			SubscribeEvents_DistanceFromMeters()
		End Sub
		Private Sub seMeterToFoot_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			UnscribeEvents_DistanceFromMeters()
			ConvertFromFoot1()
			SubscribeEvents_DistanceFromMeters()
		End Sub
		Private Sub seYard_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			UnscribeEvents_DistanceFromMeters()
			ConvertFromYard()
			SubscribeEvents_DistanceFromMeters()
		End Sub
		Private Sub seCentimeter_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			UnscribeEvents_DistanceFromCentimeter()
			ConvertFromCentimeter()
			SubscribeEvents_DistanceFromCentimeter()
		End Sub
		Private Sub seInch_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			UnscribeEvents_DistanceFromCentimeter()
			ConvertFromInch()
			SubscribeEvents_DistanceFromCentimeter()
		End Sub
		Private Sub seCentimeterToFoot_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			UnscribeEvents_DistanceFromCentimeter()
			ConvertFromFoot2()
			SubscribeEvents_DistanceFromCentimeter()
		End Sub
		Private Sub seSquareMeter_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			UnscribeEvents_SquareFromSquareMeter()
			ConvertFromSquareMeter()
			SubscribeEvents_SquareFromSquareMeter()
		End Sub
		Private Sub seNewton_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			UnscribeEvents_Force()
			ConvertFromNewton()
			SubscribeEvents_Force()
		End Sub
		Private Sub seDyne_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			UnscribeEvents_Force()
			ConvertFromDyne()
			SubscribeEvents_Force()
		End Sub
		Private Sub seHorsepower_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			UnscribeEvents_Power()
			ConvertFromHorsepower()
			SubscribeEvents_Power()
		End Sub
		Private Sub seWatt_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			UnscribeEvents_Power()
			ConvertFromWatt()
			SubscribeEvents_Power()
		End Sub
		Private Sub sePoundForce_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			UnscribeEvents_Force()
			ConvertFromPoundForce()
			SubscribeEvents_Force()
		End Sub
		Private Sub seSquareFeet_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			UnscribeEvents_SquareFromSquareMeter()
			ConvertFromSquareFeet()
			SubscribeEvents_SquareFromSquareMeter()
		End Sub
		Private Sub SubscribeEvents_Temperature()
			AddHandler seCelsius.ValueChanged, AddressOf seCelsius_ValueChanged
			AddHandler seFahrenheit.ValueChanged, AddressOf seFahrenheit_ValueChanged
			AddHandler seKelvin.ValueChanged, AddressOf seKelvin_ValueChanged
		End Sub
		Private Sub SubscribeEvents_Pressure()
			AddHandler seKilopascal.ValueChanged, AddressOf seKilopascal_ValueChanged
			AddHandler seAtmosphere.ValueChanged, AddressOf seAtmosphere_ValueChanged
			AddHandler seMmOfMercury.ValueChanged, AddressOf seMmOfMercury_ValueChanged
		End Sub
		Private Sub SubscribeEvents_Weigth()
			AddHandler seGram.ValueChanged, AddressOf seGram_ValueChanged
			AddHandler seKilogram.ValueChanged, AddressOf seKilogram_ValueChanged
			AddHandler sePoundMass.ValueChanged, AddressOf sePoundMass_ValueChanged
			AddHandler seOunceMass.ValueChanged, AddressOf seOunceMass_ValueChanged
		End Sub
		Private Sub SubscribeEvents_DistanceFromKilometers()
			AddHandler seKilometer.ValueChanged, AddressOf seKilometer_ValueChanged
			AddHandler seStatuteMile.ValueChanged, AddressOf seStatuteMile_ValueChanged
			AddHandler seNauticalMile.ValueChanged, AddressOf seNauticalMile_ValueChanged
		End Sub
		Private Sub SubscribeEvents_DistanceFromMeters()
			AddHandler seMeter.ValueChanged, AddressOf seMeter_ValueChanged
			AddHandler seMeterToFoot.ValueChanged, AddressOf seMeterToFoot_ValueChanged
			AddHandler seYard.ValueChanged, AddressOf seYard_ValueChanged
		End Sub
		Private Sub SubscribeEvents_DistanceFromCentimeter()
			AddHandler seCentimeter.ValueChanged, AddressOf seCentimeter_ValueChanged
			AddHandler seInch.ValueChanged, AddressOf seInch_ValueChanged
			AddHandler seCentimeterToFoot.ValueChanged, AddressOf seCentimeterToFoot_ValueChanged
		End Sub
		Private Sub SubscribeEvents_SquareFromSquareMeter()
			AddHandler seSquareMeter.ValueChanged, AddressOf seSquareMeter_ValueChanged
			AddHandler seSquareFeet.ValueChanged, AddressOf seSquareFeet_ValueChanged
		End Sub
		Private Sub SubscribeEvents_Force()
			AddHandler seNewton.ValueChanged, AddressOf seNewton_ValueChanged
			AddHandler seDyne.ValueChanged, AddressOf seDyne_ValueChanged
			AddHandler sePoundForce.ValueChanged, AddressOf sePoundForce_ValueChanged
		End Sub
		Private Sub SubscribeEvents_Power()
			AddHandler seHorsepower.ValueChanged, AddressOf seHorsepower_ValueChanged
			AddHandler seWatt.ValueChanged, AddressOf seWatt_ValueChanged
		End Sub
		Private Sub UnscribeEvents_Power()
			RemoveHandler seHorsepower.ValueChanged, AddressOf seHorsepower_ValueChanged
			RemoveHandler seWatt.ValueChanged, AddressOf seWatt_ValueChanged
		End Sub
		Private Sub UnscribeEvents_Force()
			RemoveHandler seNewton.ValueChanged, AddressOf seNewton_ValueChanged
			RemoveHandler seDyne.ValueChanged, AddressOf seDyne_ValueChanged
			RemoveHandler sePoundForce.ValueChanged, AddressOf sePoundForce_ValueChanged
		End Sub
		Private Sub UnscribeEvents_DistanceFromCentimeter()
			RemoveHandler seCentimeter.ValueChanged, AddressOf seCentimeter_ValueChanged
			RemoveHandler seInch.ValueChanged, AddressOf seInch_ValueChanged
			RemoveHandler seCentimeterToFoot.ValueChanged, AddressOf seCentimeterToFoot_ValueChanged
		End Sub
		Private Sub UnscribeEvents_SquareFromSquareMeter()
			RemoveHandler seSquareMeter.ValueChanged, AddressOf seSquareMeter_ValueChanged
			RemoveHandler seSquareFeet.ValueChanged, AddressOf seSquareFeet_ValueChanged
		End Sub
		Private Sub UnscribeEvents_DistanceFromKilometers()
			RemoveHandler seKilometer.ValueChanged, AddressOf seKilometer_ValueChanged
			RemoveHandler seStatuteMile.ValueChanged, AddressOf seStatuteMile_ValueChanged
			RemoveHandler seNauticalMile.ValueChanged, AddressOf seNauticalMile_ValueChanged
		End Sub
		Private Sub UnscribeEvents_DistanceFromMeters()
			RemoveHandler seMeter.ValueChanged, AddressOf seMeter_ValueChanged
			RemoveHandler seMeterToFoot.ValueChanged, AddressOf seMeterToFoot_ValueChanged
			RemoveHandler seYard.ValueChanged, AddressOf seYard_ValueChanged
		End Sub
		Private Sub UnscribeEvents_Temperature()
			RemoveHandler seCelsius.ValueChanged, AddressOf seCelsius_ValueChanged
			RemoveHandler seFahrenheit.ValueChanged, AddressOf seFahrenheit_ValueChanged
			RemoveHandler seKelvin.ValueChanged, AddressOf seKelvin_ValueChanged
		End Sub
		Private Sub UnscribeEvents_Pressure()
			RemoveHandler seKilopascal.ValueChanged, AddressOf seKilopascal_ValueChanged
			RemoveHandler seAtmosphere.ValueChanged, AddressOf seAtmosphere_ValueChanged
			RemoveHandler seMmOfMercury.ValueChanged, AddressOf seMmOfMercury_ValueChanged
		End Sub
		Private Sub UnscribeEvents_Weigth()
			RemoveHandler seGram.ValueChanged, AddressOf seGram_ValueChanged
			RemoveHandler seKilogram.ValueChanged, AddressOf seKilogram_ValueChanged
			RemoveHandler sePoundMass.ValueChanged, AddressOf sePoundMass_ValueChanged
			RemoveHandler seOunceMass.ValueChanged, AddressOf seOunceMass_ValueChanged
		End Sub
	End Class
End Namespace
