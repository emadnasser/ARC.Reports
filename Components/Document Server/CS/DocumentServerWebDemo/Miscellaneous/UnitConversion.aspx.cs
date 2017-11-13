using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.UnitConversion;
using DevExpress.Web;

public partial class Miscellaneous_UnitConversion : System.Web.UI.Page {
    const decimal InitialCelsiusValue = 36.6m;
    const decimal InitialKilopascalValue = 101.33m;
    const int InitialGrammValue = 1;
    const int InitialKilometerValue = 1;
    const int InitialMeterValue = 1;
    const int InitialSquareMeterValue = 1;
    const int InitialNewtonValue = 1;
    const int InitialHorsepowerValue = 1;
    const decimal InitialCentimeterValue = 2.54m;
    MetricUnitsConverter metricUnitsConverter = new MetricUnitsConverter();

    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack) {
            InitializeData();
            Calculate();
        }
    }
    void Calculate() {
        ConvertFromGramm();
        ConvertFromKilometers();
        ConvertFromCentimeter();
        ConvertFromMeter();
        ConvertFromSquareMeter();
        ConvertFromCelsius();
        ConvertFromKilopascal();
        ConvertFromNewton();
        ConvertFromHorsepower();
    }
    void InitializeData() {
        seCelsius.Number = InitialCelsiusValue;
        seKilopascal.Number = InitialKilopascalValue;
        seGramm.Number = InitialGrammValue;
        seKilometer.Number = InitialKilometerValue;
        seMeter.Number = InitialMeterValue;
        seCentimeter.Number = InitialCentimeterValue;
        seSquareMeter.Number = InitialSquareMeterValue;
        seNewton.Number = InitialNewtonValue;
        seHorsepower.Number = InitialHorsepowerValue;
    }
    decimal Round(double value, int digits) {
        return (decimal)Math.Round(value, digits);
    }
    void ConvertFromCelsius() {
        double value = (double)seCelsius.Number;
        double fahrenheit = Units.Temperature.Convert(value, Temperature.Celsius, Temperature.Fahrenheit);
        double kelvin = Units.Temperature.Convert(value, Temperature.Celsius, Temperature.Kelvin);

        seFahrenheit.Number = Round(fahrenheit, 2);
        seKelvin.Number = Round(kelvin, 2);
    }
    void ConvertFromFahrenheit() {
        double value = (double)seFahrenheit.Number;
        double celsius = value.Fahrenheit().ToCelsius();
        double kelvin = value.Fahrenheit().ToKelvin();

        seCelsius.Number = Round(celsius, 2);
        seKelvin.Number = Round(kelvin, 2);
    }
    void ConvertFromKelvin() {
        double value = (double)seKelvin.Number;
        double celsius = value.Kelvin().ToCelsius();
        double fahrenheit = value.Kelvin().ToFahrenheit();

        seCelsius.Number = Round(celsius, 2);
        seFahrenheit.Number = Round(fahrenheit, 2);
    }
    void ConvertFromKilopascal() {
        double value = (double)seKilopascal.Number;
        double pascal = metricUnitsConverter.Convert(value, MetricPrefix.Kilo, MetricPrefix.None);
        double atmosphere = Units.Pressure.Convert(pascal, Pressure.Pascal, Pressure.Atmosphere);
        double mmOfMercury = Units.Pressure.Convert(pascal, Pressure.Pascal, Pressure.MmHg);

        seAtmosphere.Number = Round(atmosphere, 2);
        seMmOfMercury.Number = Round(mmOfMercury, 2);
    }
    void ConvertFromAtmosphere() {
        double value = (double)seAtmosphere.Number;
        double kilopascal = metricUnitsConverter.Convert(value.Atmospheres().ToPascals(), MetricPrefix.None, MetricPrefix.Kilo);
        double mmOfMercury = value.Atmospheres().ToMmHg();

        seKilopascal.Number = Round(kilopascal, 2);
        seMmOfMercury.Number = Round(mmOfMercury, 2);
    }
    void ConvertFromMmOfMercury() {
        double value = (double)seMmOfMercury.Number;
        double kilopascal = metricUnitsConverter.Convert(value.MmHg().ToPascals(), MetricPrefix.None, MetricPrefix.Kilo);
        double atmosphere = value.MmHg().ToAtmospheres();

        seKilopascal.Number = Round(kilopascal, 2);
        seAtmosphere.Number = Round(atmosphere, 2);
    }
    void ConvertFromGramm() {
        double value = (double)seGramm.Number;
        double kilograms = value.Grams().ToKilograms();
        double pounds = value.Grams().ToPounds();
        double ounces = value.Grams().ToOunceMass();

        seKilogramm.Number = Round(kilograms, 3);
        sePoundMass.Number = Round(pounds, 3);
        seOunceMass.Number = Round(ounces, 3);
    }
    void ConvertFromKilogramm() {
        double value = (double)seKilogramm.Number;
        double pounds = value.Kilograms().ToPounds();
        double ounces = value.Kilograms().ToOunceMass();
        double grams = value.Kilograms().ToGrams();

        sePoundMass.Number = Round(pounds, 3);
        seOunceMass.Number = Round(ounces, 3);
        seGramm.Number = Round(grams, 3);
    }
    void ConvertFromPoundMass() {
        double value = (double)sePoundMass.Number;
        double ounces = value.Pounds().ToOunceMass();
        double grams = value.Pounds().ToGrams();
        double kilograms = value.Pounds().ToKilograms();

        seOunceMass.Number = Round(ounces, 3);
        seGramm.Number = Round(grams, 3);
        seKilogramm.Number = Round(kilograms, 3);
    }
    void ConvertFromKilometers() {
        double value = metricUnitsConverter.Convert((double)seKilometer.Number, MetricPrefix.Kilo, MetricPrefix.None);
        double statuteMile = value.Meters().ToMilesStatute();
        double nauticalMile = value.Meters().ToMilesNautical();

        seStatuteMile.Number = Round(statuteMile, 3);
        seNauticalMile.Number = Round(nauticalMile, 3);
    }
    void ConvertFromStatuteMile() {
        double value = (double)seStatuteMile.Number;
        double nauticalMile = value.MilesStatute().ToMilesNautical();
        double kilometers = metricUnitsConverter.Convert(value.MilesStatute().ToMeters(), MetricPrefix.None, MetricPrefix.Kilo);

        seNauticalMile.Number = Round(nauticalMile, 3);
        seKilometer.Number = Round(kilometers, 3);
    }
    void ConvertFromNauticalMile() {
        double value = (double)seNauticalMile.Number;
        double kilometers = metricUnitsConverter.Convert(value.MilesNautical().ToMeters(), MetricPrefix.None, MetricPrefix.Kilo);
        double statuteMile = value.MilesNautical().ToMilesStatute();

        seKilometer.Number = Round(kilometers, 3);
        seStatuteMile.Number = Round(statuteMile, 3);
    }
    void ConvertFromMeter() {
        double value = (double)seMeter.Number;
        double yard = value.Meters().ToYards();
        double feet = value.Meters().ToFeet();

        seYard.Number = Round(yard, 3);
        seMeterToFoot.Number = Round(feet, 3);
    }
    void ConvertFromFoot1() {
        double value = (double)seMeterToFoot.Number;
        double yard = value.Feet().ToYards();
        double meters = value.Feet().ToMeters();

        seYard.Number = Round(yard, 3);
        seMeter.Number = Round(meters, 3);
    }
    void ConvertFromYard() {
        double value = (double)seYard.Number;
        double feet = value.Yards().ToFeet();
        double meters = value.Yards().ToMeters();

        seMeterToFoot.Number = Round(feet, 3);
        seMeter.Number = Round(meters, 3);
    }
    void ConvertFromCentimeter() {
        double value = metricUnitsConverter.Convert((double)seCentimeter.Number, MetricPrefix.Centi, MetricPrefix.None);
        double inches = value.Meters().ToInches();
        double feet = value.Meters().ToFeet();

        seInch.Number = Round(inches, 3);
        seCentimeterToFoot.Number = Round(feet, 3);
    }
    void ConvertFromInch() {
        double value = (double)seInch.Number;
        double сentimeters = metricUnitsConverter.Convert(value.Inches().ToMeters(), MetricPrefix.None, MetricPrefix.Centi);
        double feet = value.Inches().ToFeet();

        seCentimeter.Number = Round(сentimeters, 3);
        seCentimeterToFoot.Number = Round(feet, 3);
    }
    void ConvertFromNewton() {
        double value = (double)seNewton.Number;
        double dynes = value.Newtons().ToDynes();
        double force = value.Newtons().ToPoundForce();

        seDyne.Number = Round(dynes, 5);
        sePoundForce.Number = Round(force, 5);
    }
    void ConvertFromDyne() {
        double value = (double)seDyne.Number;
        double newton = value.Dynes().ToNewtons();
        double force = value.Dynes().ToPoundForce();

        seNewton.Number = Round(newton, 5);
        sePoundForce.Number = Round(force, 5);
    }
    void ConvertFromHorsepower() {
        double value = (double)seHorsepower.Number;
        double watts = value.HorsePower().ToWatts();

        seWatt.Number = Round(watts, 2);
    }
    void ConvertFromWatt() {
        double value = (double)seWatt.Number;
        double horsepower = value.Watts().ToHorsePower();

        seHorsepower.Number = Round(horsepower, 2);
    }
    void ConvertFromPoundForce() {
        double value = (double)sePoundForce.Number;
        double newton = value.PoundForce().ToNewtons();
        double dynes = value.PoundForce().ToDynes();

        seNewton.Number = Round(newton, 5);
        seDyne.Number = Round(dynes, 5);
    }
    void ConvertFromFoot2() {
        double value = (double)seCentimeterToFoot.Number;
        double сentimeters = metricUnitsConverter.Convert(value.Feet().ToMeters(), MetricPrefix.None, MetricPrefix.Centi);
        double inches = value.Feet().ToInches();

        seCentimeter.Number = Round(сentimeters, 3);
        seInch.Number = Round(inches, 3);
    }
    void ConvertFromSquareMeter() {
        double squareFeet = ((double)seSquareMeter.Number).SquareMeters().ToSquareFeet();
        seSquareFeet.Number = Round(squareFeet, 3);
    }
    void ConvertFromSquareFeet() {
        double squareMeters = ((double)seSquareFeet.Number).SquareFeet().ToSquareMeters();
        seSquareMeter.Number = Round(squareMeters, 3);
    }
    void ConvertFromOunceMass() {
        double value = (double)seOunceMass.Number;
        double grams = value.OunceMass().ToGrams();
        double kilograms = value.OunceMass().ToKilograms();
        double pounds = value.OunceMass().ToPounds();

        seGramm.Number = Round(grams, 3);
        seKilogramm.Number = Round(kilograms, 3);
        sePoundMass.Number = Round(pounds, 3);
    }
    public void hf_CustomCallback(object sender, CallbackEventArgsBase e) {
        ASPxHiddenField hf = (ASPxHiddenField)sender;

        RefreshData(e.Parameter);
        hf.Set("data", GetData());
    }
    Dictionary<string, double> GetData() {
        Dictionary<string, double> data = new Dictionary<string, double>();
        data.Add("seGramm", (double)seGramm.Number);
        data.Add("seKilogramm", (double)seKilogramm.Number);
        data.Add("sePoundMass", (double)sePoundMass.Number);
        data.Add("seOunceMass", (double)seOunceMass.Number);

        data.Add("seKilometer", (double)seKilometer.Number);
        data.Add("seStatuteMile", (double)seStatuteMile.Number);
        data.Add("seNauticalMile", (double)seNauticalMile.Number);
        data.Add("seMeter", (double)seMeter.Number);
        data.Add("seMeterToFoot", (double)seMeterToFoot.Number);
        data.Add("seYard", (double)seYard.Number);
        data.Add("seCentimeter", (double)seCentimeter.Number);
        data.Add("seInch", (double)seInch.Number);
        data.Add("seCentimeterToFoot", (double)seCentimeterToFoot.Number);
        data.Add("seSquareMeter", (double)seSquareMeter.Number);
        data.Add("seSquareFeet", (double)seSquareFeet.Number);
        

        data.Add("seCelsius", (double)seCelsius.Number);
        data.Add("seFahrenheit", (double)seFahrenheit.Number);
        data.Add("seKelvin", (double)seKelvin.Number);
        data.Add("seKilopascal", (double)seKilopascal.Number);
        data.Add("seAtmosphere", (double)seAtmosphere.Number);
        data.Add("seMmOfMercury", (double)seMmOfMercury.Number);

        data.Add("seNewton", (double)seNewton.Number);
        data.Add("seDyne", (double)seDyne.Number);
        data.Add("sePoundForce", (double)sePoundForce.Number);
        data.Add("seHorsepower", (double)seHorsepower.Number);
        data.Add("seWatt", (double)seWatt.Number);

        return data;
    }
    void RefreshData(string name) {
        switch(name) {
            case "seGramm":
                ConvertFromGramm();
                break;
            case "seKilogramm":
                ConvertFromKilogramm();
                break;
            case "sePoundMass":
                ConvertFromPoundMass();
                break;
            case "seOunceMass":
                ConvertFromOunceMass();
                break;

            case "seKilometer":
                ConvertFromKilometers();
                break;
            case "seStatuteMile":
                ConvertFromStatuteMile();
                break;
            case "seNauticalMile":
                ConvertFromNauticalMile();
                break;
            case "seMeter":
                ConvertFromMeter();
                break;
            case "seMeterToFoot":
                ConvertFromFoot1();
                break;
            case "seYard":
                ConvertFromYard();
                break;
            case "seCentimeter":
                ConvertFromCentimeter();
                break;
            case "seInch":
                ConvertFromInch();
                break;
            case "seCentimeterToFoot":
                ConvertFromFoot2();
                break;
            case "seSquareMeter":
                ConvertFromSquareMeter();
                break;
            case "seSquareFeet":
                ConvertFromSquareFeet();
                break;

            case "seCelsius":
                ConvertFromCelsius();
                break;
            case "seFahrenheit":
                ConvertFromFahrenheit();
                break;
            case "seKelvin":
                ConvertFromKelvin();
                break;
            case "seKilopascal":
                ConvertFromKilopascal();
                break;
            case "seAtmosphere":
                ConvertFromAtmosphere();
                break;
            case "seMmOfMercury":
                ConvertFromMmOfMercury();
                break;

            case "seNewton":
                ConvertFromNewton();
                break;
            case "seDyne":
                ConvertFromDyne();
                break;
            case "sePoundForce":
                ConvertFromPoundForce();
                break;
            case "seHorsepower":
                ConvertFromHorsepower();
                break;
            case "seWatt":
                ConvertFromWatt();
                break;
        }
    }
}
