using System;
using System.Collections.Generic;
using System.Globalization;
using DevExpress.Docs.Text;
using DevExpress.DXperience.Demos;
using DevExpress.UnitConversion;
using DevExpress.XtraEditors;

namespace DevExpress.Docs.Demos {
    public partial class UnitConversion : TutorialControlBase {
        const decimal InitialCelsiusValue = 36.6m;
        const decimal InitialKilopascalValue = 101.33m;
        const int InitialGramValue = 1;
        const int InitialKilometerValue = 1;
        const int InitialMeterValue = 1;
        const int InitialSquareMeterValue = 1;
        const int InitialNewtonValue = 1;
        const int InitialHorsepowerValue = 1;
        const decimal InitialCentimeterValue = 2.54m;
        MetricUnitsConverter metricUnitsConverter;

        public UnitConversion() {
            InitializeComponent();
            SubscribeEvents();
            InitializeForm();
        }

        void SubscribeEvents() {
            SubscribeEvents_Temperature();
            SubscribeEvents_Pressure();
            SubscribeEvents_Weigth();
            SubscribeEvents_DistanceFromKilometers();
            SubscribeEvents_DistanceFromMeters();
            SubscribeEvents_DistanceFromCentimeter();
            SubscribeEvents_SquareFromSquareMeter();
            SubscribeEvents_Force();
            SubscribeEvents_Power();
        }
        void InitializeForm() {
            this.metricUnitsConverter = new MetricUnitsConverter();
            seCelsius.Value = InitialCelsiusValue;
            seKilopascal.Value = InitialKilopascalValue;
            seGram.Value = InitialGramValue;
            seKilometer.Value = InitialKilometerValue;
            seMeter.Value = InitialMeterValue;
            seCentimeter.Value = InitialCentimeterValue;
            seSquareMeter.Value = InitialSquareMeterValue;
            seNewton.Value = InitialNewtonValue;
            seHorsepower.Value = InitialHorsepowerValue;
        }
        void ConvertFromCelsius() {
            double value = (double)seCelsius.Value;
            double fahrenheit = Units.Temperature.Convert(value, Temperature.Celsius, Temperature.Fahrenheit);
            double kelvin = Units.Temperature.Convert(value, Temperature.Celsius, Temperature.Kelvin);

            seFahrenheit.Value = Round(fahrenheit, 2);
            seKelvin.Value = Round(kelvin, 2);
        }
        void ConvertFromFahrenheit() {
            double value = (double)seFahrenheit.Value;
            double celsius = value.Fahrenheit().ToCelsius();
            double kelvin = value.Fahrenheit().ToKelvin();

            seCelsius.Value = Round(celsius, 2);
            seKelvin.Value = Round(kelvin, 2);
        }
        void ConvertFromKelvin() {
            double value = (double)seKelvin.Value;
            double celsius = value.Kelvin().ToCelsius();
            double fahrenheit = value.Kelvin().ToFahrenheit();

            seCelsius.Value = Round(celsius, 2);
            seFahrenheit.Value = Round(fahrenheit, 2);
        }
        void ConvertFromKilopascal() {
            double value = (double)seKilopascal.Value;
            double pascal = metricUnitsConverter.Convert(value, MetricPrefix.Kilo, MetricPrefix.None);
            double atmosphere = Units.Pressure.Convert(pascal, Pressure.Pascal, Pressure.Atmosphere);
            double mmOfMercury = Units.Pressure.Convert(pascal, Pressure.Pascal, Pressure.MmHg);

            seAtmosphere.Value = Round(atmosphere, 2);
            seMmOfMercury.Value = Round(mmOfMercury, 2);
        }
        void ConvertFromAtmosphere() {
            double value = (double)seAtmosphere.Value;
            double kilopascal = metricUnitsConverter.Convert(value.Atmospheres().ToPascals(), MetricPrefix.None, MetricPrefix.Kilo);
            double mmOfMercury = value.Atmospheres().ToMmHg();

            seKilopascal.Value = Round(kilopascal, 2);
            seMmOfMercury.Value = Round(mmOfMercury, 2);
        }
        void ConvertFromMmOfMercury() {
            double value = (double)seMmOfMercury.Value;
            double kilopascal = metricUnitsConverter.Convert(value.MmHg().ToPascals(), MetricPrefix.None, MetricPrefix.Kilo);
            double atmosphere = value.MmHg().ToAtmospheres();

            seKilopascal.Value = Round(kilopascal, 2);
            seAtmosphere.Value = Round(atmosphere, 2);
        }
        void ConvertFromGram() {
            double value = (double)seGram.Value;
            double kilograms = value.Grams().ToKilograms();
            double pounds = value.Grams().ToPounds();
            double ounces = value.Grams().ToOunceMass();

            seKilogram.Value = Round(kilograms, 3);
            sePoundMass.Value = Round(pounds, 3);
            seOunceMass.Value = Round(ounces, 3);
        }
        void ConvertFromKilogram() {
            double value = (double)seKilogram.Value;
            double pounds = value.Kilograms().ToPounds();
            double ounces = value.Kilograms().ToOunceMass();
            double grams = value.Kilograms().ToGrams();

            sePoundMass.Value = Round(pounds, 3);
            seOunceMass.Value = Round(ounces, 3);
            seGram.Value = Round(grams, 3);
        }
        void ConvertFromPoundMass() {
            double value = (double)sePoundMass.Value;
            double ounces = value.Pounds().ToOunceMass();
            double grams = value.Pounds().ToGrams();
            double kilograms = value.Pounds().ToKilograms();

            seOunceMass.Value = Round(ounces, 3);
            seGram.Value = Round(grams, 3);
            seKilogram.Value = Round(kilograms, 3);
        }
        void ConvertFromKilometers() {
            double value = metricUnitsConverter.Convert((double)seKilometer.Value, MetricPrefix.Kilo, MetricPrefix.None);
            double statuteMile = value.Meters().ToMilesStatute();
            double nauticalMile = value.Meters().ToMilesNautical();

            seStatuteMile.Value = Round(statuteMile, 3);
            seNauticalMile.Value = Round(nauticalMile, 3);
        }
        void ConvertFromStatuteMile() {
            double value = (double)seStatuteMile.Value;
            double nauticalMile = value.MilesStatute().ToMilesNautical();
            double kilometers = metricUnitsConverter.Convert(value.MilesStatute().ToMeters(), MetricPrefix.None, MetricPrefix.Kilo);

            seNauticalMile.Value = Round(nauticalMile, 3);
            seKilometer.Value = Round(kilometers, 3);
        }
        void ConvertFromNauticalMile() {
            double value = (double)seNauticalMile.Value;
            double kilometers = metricUnitsConverter.Convert(value.MilesNautical().ToMeters(), MetricPrefix.None, MetricPrefix.Kilo);
            double statuteMile = value.MilesNautical().ToMilesStatute();

            seKilometer.Value = Round(kilometers, 3);
            seStatuteMile.Value = Round(statuteMile, 3);
        }
        void ConvertFromMeter() {
            double value = (double)seMeter.Value;
            double yard = value.Meters().ToYards();
            double feet = value.Meters().ToFeet();

            seYard.Value = Round(yard, 3);
            seMeterToFoot.Value = Round(feet, 3);
        }
        void ConvertFromFoot1() {
            double value = (double)seMeterToFoot.Value;
            double yard = value.Feet().ToYards();
            double meters = value.Feet().ToMeters();

            seYard.Value = Round(yard, 3);
            seMeter.Value = Round(meters, 3);
        }
        void ConvertFromYard() {
            double value = (double)seYard.Value;
            double feet = value.Yards().ToFeet();
            double meters = value.Yards().ToMeters();

            seMeterToFoot.Value = Round(feet, 3);
            seMeter.Value = Round(meters, 3);
        }
        void ConvertFromCentimeter() {
            double value = metricUnitsConverter.Convert((double)seCentimeter.Value, MetricPrefix.Centi, MetricPrefix.None);
            double inches = value.Meters().ToInches();
            double feet = value.Meters().ToFeet();

            seInch.Value = Round(inches, 3);
            seCentimeterToFoot.Value = Round(feet, 3);
        }
        void ConvertFromInch() {
            double value = (double)seInch.Value;
            double сentimeters = metricUnitsConverter.Convert(value.Inches().ToMeters(), MetricPrefix.None, MetricPrefix.Centi);
            double feet = value.Inches().ToFeet();

            seCentimeter.Value = Round(сentimeters, 3);
            seCentimeterToFoot.Value = Round(feet, 3);
        }
        void ConvertFromNewton() {
            double value = (double)seNewton.Value;
            double dynes = value.Newtons().ToDynes();
            double force = value.Newtons().ToPoundForce();

            seDyne.Value = Round(dynes, 5);
            sePoundForce.Value = Round(force, 5);
        }
        void ConvertFromDyne() {
            double value = (double)seDyne.Value;
            double newton = value.Dynes().ToNewtons();
            double force = value.Dynes().ToPoundForce();

            seNewton.Value = Round(newton, 5);
            sePoundForce.Value = Round(force, 5);
        }
        void ConvertFromHorsepower() {
            double value = (double)seHorsepower.Value;
            double watts = value.HorsePower().ToWatts();

            seWatt.Value = Round(watts, 2);
        }
        void ConvertFromWatt() {
            double value = (double)seWatt.Value;
            double horsepower = value.Watts().ToHorsePower();

            seHorsepower.Value = Round(horsepower, 2);
        }
        void ConvertFromPoundForce() {
            double value = (double)sePoundForce.Value;
            double newton = value.PoundForce().ToNewtons();
            double dynes = value.PoundForce().ToDynes();

            seNewton.Value = Round(newton, 5);
            seDyne.Value = Round(dynes, 5);
        }
        void ConvertFromFoot2() {
            double value = (double)seCentimeterToFoot.Value;
            double сentimeters = metricUnitsConverter.Convert(value.Feet().ToMeters(), MetricPrefix.None, MetricPrefix.Centi);
            double inches = value.Feet().ToInches();

            seCentimeter.Value = Round(сentimeters, 3);
            seInch.Value = Round(inches, 3);
        }
        void ConvertFromSquareMeter() {
            double squareFeet = ((double)seSquareMeter.Value).SquareMeters().ToSquareFeet();
            seSquareFeet.Value = Round(squareFeet, 3);
        }
        void ConvertFromSquareFeet() {
            double squareMeters = ((double)seSquareFeet.Value).SquareFeet().ToSquareMeters();
            seSquareMeter.Value = Round(squareMeters, 3);
        }
        void ConvertFromOunceMass() {
            double value = (double)seOunceMass.Value;
            double grams = value.OunceMass().ToGrams();
            double kilograms = value.OunceMass().ToKilograms();
            double pounds = value.OunceMass().ToPounds();

            seGram.Value = Round(grams, 3);
            seKilogram.Value = Round(kilograms, 3);
            sePoundMass.Value = Round(pounds, 3);
        }
        decimal Round(double value, int digits) {
            return (decimal)Math.Round(value, digits);
        }
        void seCelsius_ValueChanged(object sender, EventArgs e) {
            UnscribeEvents_Temperature();
            ConvertFromCelsius();
            SubscribeEvents_Temperature();
        }
        void seFahrenheit_ValueChanged(object sender, EventArgs e) {
            UnscribeEvents_Temperature();
            ConvertFromFahrenheit();
            SubscribeEvents_Temperature();
        }
        void seKelvin_ValueChanged(object sender, EventArgs e) {
            UnscribeEvents_Temperature();
            ConvertFromKelvin();
            SubscribeEvents_Temperature();
        }
        void seKilopascal_ValueChanged(object sender, EventArgs e) {
            UnscribeEvents_Pressure();
            ConvertFromKilopascal();
            SubscribeEvents_Pressure();
        }
        void seAtmosphere_ValueChanged(object sender, EventArgs e) {
            UnscribeEvents_Pressure();
            ConvertFromAtmosphere();
            SubscribeEvents_Pressure();
        }
        void seMmOfMercury_ValueChanged(object sender, EventArgs e) {
            UnscribeEvents_Pressure();
            ConvertFromMmOfMercury();
            SubscribeEvents_Pressure();
        }
        void seGram_ValueChanged(object sender, EventArgs e) {
            UnscribeEvents_Weigth();
            ConvertFromGram();
            SubscribeEvents_Weigth();
        }
        void seKilogram_ValueChanged(object sender, EventArgs e) {
            UnscribeEvents_Weigth();
            ConvertFromKilogram();
            SubscribeEvents_Weigth();
        }
        void sePoundMass_ValueChanged(object sender, EventArgs e) {
            UnscribeEvents_Weigth();
            ConvertFromPoundMass();
            SubscribeEvents_Weigth();
        }
        void seOunceMass_ValueChanged(object sender, EventArgs e) {
            UnscribeEvents_Weigth();
            ConvertFromOunceMass();
            SubscribeEvents_Weigth();
        }
        void seKilometer_ValueChanged(object sender, EventArgs e) {
            UnscribeEvents_DistanceFromKilometers();
            ConvertFromKilometers();
            SubscribeEvents_DistanceFromKilometers();
        }
        void seStatuteMile_ValueChanged(object sender, EventArgs e) {
            UnscribeEvents_DistanceFromKilometers();
            ConvertFromStatuteMile();
            SubscribeEvents_DistanceFromKilometers();
        }
        void seNauticalMile_ValueChanged(object sender, EventArgs e) {
            UnscribeEvents_DistanceFromKilometers();
            ConvertFromNauticalMile();
            SubscribeEvents_DistanceFromKilometers();
        }
        void seMeter_ValueChanged(object sender, EventArgs e) {
            UnscribeEvents_DistanceFromMeters();
            ConvertFromMeter();
            SubscribeEvents_DistanceFromMeters();
        }
        void seMeterToFoot_ValueChanged(object sender, EventArgs e) {
            UnscribeEvents_DistanceFromMeters();
            ConvertFromFoot1();
            SubscribeEvents_DistanceFromMeters();
        }
        void seYard_ValueChanged(object sender, EventArgs e) {
            UnscribeEvents_DistanceFromMeters();
            ConvertFromYard();
            SubscribeEvents_DistanceFromMeters();
        }
        void seCentimeter_ValueChanged(object sender, EventArgs e) {
            UnscribeEvents_DistanceFromCentimeter();
            ConvertFromCentimeter();
            SubscribeEvents_DistanceFromCentimeter();
        }
        void seInch_ValueChanged(object sender, EventArgs e) {
            UnscribeEvents_DistanceFromCentimeter();
            ConvertFromInch();
            SubscribeEvents_DistanceFromCentimeter();
        }
        void seCentimeterToFoot_ValueChanged(object sender, EventArgs e) {
            UnscribeEvents_DistanceFromCentimeter();
            ConvertFromFoot2();
            SubscribeEvents_DistanceFromCentimeter();
        }
        void seSquareMeter_ValueChanged(object sender, EventArgs e) {
            UnscribeEvents_SquareFromSquareMeter();
            ConvertFromSquareMeter();
            SubscribeEvents_SquareFromSquareMeter();
        }
        void seNewton_ValueChanged(object sender, EventArgs e) {
            UnscribeEvents_Force();
            ConvertFromNewton();
            SubscribeEvents_Force();
        }
        void seDyne_ValueChanged(object sender, EventArgs e) {
            UnscribeEvents_Force();
            ConvertFromDyne();
            SubscribeEvents_Force();
        }
        void seHorsepower_ValueChanged(object sender, EventArgs e) {
            UnscribeEvents_Power();
            ConvertFromHorsepower();
            SubscribeEvents_Power();
        }
        void seWatt_ValueChanged(object sender, EventArgs e) {
            UnscribeEvents_Power();
            ConvertFromWatt();
            SubscribeEvents_Power();
        }
        void sePoundForce_ValueChanged(object sender, EventArgs e) {
            UnscribeEvents_Force();
            ConvertFromPoundForce();
            SubscribeEvents_Force();
        }
        void seSquareFeet_ValueChanged(object sender, EventArgs e) {
            UnscribeEvents_SquareFromSquareMeter();
            ConvertFromSquareFeet();
            SubscribeEvents_SquareFromSquareMeter();
        }
        void SubscribeEvents_Temperature() {
            seCelsius.ValueChanged += seCelsius_ValueChanged;
            seFahrenheit.ValueChanged += seFahrenheit_ValueChanged;
            seKelvin.ValueChanged += seKelvin_ValueChanged;
        }
        void SubscribeEvents_Pressure() {
            seKilopascal.ValueChanged += seKilopascal_ValueChanged;
            seAtmosphere.ValueChanged += seAtmosphere_ValueChanged;
            seMmOfMercury.ValueChanged += seMmOfMercury_ValueChanged;
        }
        void SubscribeEvents_Weigth() {
            seGram.ValueChanged += seGram_ValueChanged;
            seKilogram.ValueChanged += seKilogram_ValueChanged;
            sePoundMass.ValueChanged += sePoundMass_ValueChanged;
            seOunceMass.ValueChanged += seOunceMass_ValueChanged;
        }
        void SubscribeEvents_DistanceFromKilometers() {
            seKilometer.ValueChanged += seKilometer_ValueChanged;
            seStatuteMile.ValueChanged += seStatuteMile_ValueChanged;
            seNauticalMile.ValueChanged += seNauticalMile_ValueChanged;
        }
        void SubscribeEvents_DistanceFromMeters() {
            seMeter.ValueChanged += seMeter_ValueChanged;
            seMeterToFoot.ValueChanged += seMeterToFoot_ValueChanged;
            seYard.ValueChanged += seYard_ValueChanged;
        }
        void SubscribeEvents_DistanceFromCentimeter() {
            seCentimeter.ValueChanged += seCentimeter_ValueChanged;
            seInch.ValueChanged += seInch_ValueChanged;
            seCentimeterToFoot.ValueChanged += seCentimeterToFoot_ValueChanged;
        }
        void SubscribeEvents_SquareFromSquareMeter() {
            seSquareMeter.ValueChanged += seSquareMeter_ValueChanged;
            seSquareFeet.ValueChanged += seSquareFeet_ValueChanged;
        }
        void SubscribeEvents_Force() {
            seNewton.ValueChanged += seNewton_ValueChanged;
            seDyne.ValueChanged += seDyne_ValueChanged;
            sePoundForce.ValueChanged += sePoundForce_ValueChanged;
        }
        void SubscribeEvents_Power() {
            seHorsepower.ValueChanged += seHorsepower_ValueChanged;
            seWatt.ValueChanged += seWatt_ValueChanged;
        }
        void UnscribeEvents_Power() {
            seHorsepower.ValueChanged -= seHorsepower_ValueChanged;
            seWatt.ValueChanged -= seWatt_ValueChanged;
        }
        void UnscribeEvents_Force() {
            seNewton.ValueChanged -= seNewton_ValueChanged;
            seDyne.ValueChanged -= seDyne_ValueChanged;
            sePoundForce.ValueChanged -= sePoundForce_ValueChanged;
        }
        void UnscribeEvents_DistanceFromCentimeter() {
            seCentimeter.ValueChanged -= seCentimeter_ValueChanged;
            seInch.ValueChanged -= seInch_ValueChanged;
            seCentimeterToFoot.ValueChanged -= seCentimeterToFoot_ValueChanged;
        }
        void UnscribeEvents_SquareFromSquareMeter() {
            seSquareMeter.ValueChanged -= seSquareMeter_ValueChanged;
            seSquareFeet.ValueChanged -= seSquareFeet_ValueChanged;
        }
        void UnscribeEvents_DistanceFromKilometers() {
            seKilometer.ValueChanged -= seKilometer_ValueChanged;
            seStatuteMile.ValueChanged -= seStatuteMile_ValueChanged;
            seNauticalMile.ValueChanged -= seNauticalMile_ValueChanged;
        }
        void UnscribeEvents_DistanceFromMeters() {
            seMeter.ValueChanged -= seMeter_ValueChanged;
            seMeterToFoot.ValueChanged -= seMeterToFoot_ValueChanged;
            seYard.ValueChanged -= seYard_ValueChanged;
        }
        void UnscribeEvents_Temperature() {
            seCelsius.ValueChanged -= seCelsius_ValueChanged;
            seFahrenheit.ValueChanged -= seFahrenheit_ValueChanged;
            seKelvin.ValueChanged -= seKelvin_ValueChanged;
        }
        void UnscribeEvents_Pressure() {
            seKilopascal.ValueChanged -= seKilopascal_ValueChanged;
            seAtmosphere.ValueChanged -= seAtmosphere_ValueChanged;
            seMmOfMercury.ValueChanged -= seMmOfMercury_ValueChanged;
        }
        void UnscribeEvents_Weigth() {
            seGram.ValueChanged -= seGram_ValueChanged;
            seKilogram.ValueChanged -= seKilogram_ValueChanged;
            sePoundMass.ValueChanged -= sePoundMass_ValueChanged;
            seOunceMass.ValueChanged -= seOunceMass_ValueChanged;
        }
    }
}
