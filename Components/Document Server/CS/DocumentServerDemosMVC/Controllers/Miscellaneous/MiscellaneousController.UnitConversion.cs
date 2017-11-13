using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevExpress.UnitConversion;

namespace DevExpress.Web.Demos {
    public partial class MiscellaneousController : DemoController {
        public ActionResult UnitConversion() {
            MiscellaneousUnitConversionModel model = new MiscellaneousUnitConversionModel();
            UpdateUnitConversionMassModel(1234.Grams(), model.MassModel);
            InitializeDistanceAndSquareModel(model.DistanceAndSquareModel);
            InitializeTemperatureAndPressureModel(model.TemperatureAndPressureModel);
            InitializeForceAndPowerModel(model.ForceAndPowerModel);
            return DemoView("UnitConversion", model);
        }
                
        public ActionResult UnitConversionMassForm(UnitConversionMassModel data) {
            QuantityValue<Mass> quantity = new QuantityValue<Mass>();
            switch (data.UnitMassGroupEditorId) {
                case UnitMassGroupEditorId.Gram:
                    quantity = data.Gram.Grams();
                    break;
                case UnitMassGroupEditorId.Kilogram:
                    quantity = data.Kilogram.Kilograms();
                    break;
                case UnitMassGroupEditorId.Ounce:
                    quantity = data.OunceMass.OunceMass();
                    break;
                case UnitMassGroupEditorId.Pound:
                    quantity = data.Pounds.Pounds();
                    break;
            }
            UnitConversionMassModel calculatedModel = new UnitConversionMassModel();
            UpdateUnitConversionMassModel(quantity, calculatedModel);
            return PartialView("UnitConversionMassPartial", calculatedModel);
        }
        public ActionResult UnitConversionDistanceAndSquareForm(UnitConversionDistanceAndSquareModel data) {
            ProcessKilometerStatuteNauticalMileGroup(data);
            ProcessMeterFootYardGroup(data);
            ProcessCentimeterInchFootGroup(data);
            ProcessSquareMeterFeetGroup(data);
            Round(data);
            return PartialView("UnitConversionDistanceAndSquarePartial", data);
        }
        public ActionResult UnitConversionTemperatureAndPressureForm(UnitConversionTemperatureAndPressureModel data) {
            ProcessCelsiusFahrenheitKelvinGroup(data);
            ProcessKilopascalAtmosphereMmOfMercuryGroup(data);
            Round(data);
            return PartialView("UnitConversionTemperatureAndPressurePartial", data);
        }
        public ActionResult UnitConversionForceAndPowerForm(UnitConversionForceAndPowerModel data) {
            ProcessNewtonDynePoundForceGroup(data);
            ProcessHorsepowerWattGroup(data);
            Round(data);
            return PartialView("UnitConversionForceAndPowerPartial", data);
        }
                        
        void ProcessNewtonDynePoundForceGroup(UnitConversionForceAndPowerModel data) {
            if (data.ForceAndPowerEditorId == ForceAndPowerEditorId.Newton) { 
                data.Dyne = data.Newton.Newtons().ToDynes();
                data.PoundForce = data.Newton.Newtons().ToPoundForce();
                return;
            }
            if (data.ForceAndPowerEditorId == ForceAndPowerEditorId.Dyne) { 
                data.Newton = data.Dyne.Dynes().ToNewtons();
                data.PoundForce = data.Dyne.Dynes().ToPoundForce();
                return;
            }
            if (data.ForceAndPowerEditorId == ForceAndPowerEditorId.PoundForce) { 
                data.Dyne = data.PoundForce.PoundForce().ToDynes();
                data.Newton = data.PoundForce.PoundForce().ToNewtons();
            }
        }
        void ProcessHorsepowerWattGroup(UnitConversionForceAndPowerModel data) {
            if (data.ForceAndPowerEditorId == ForceAndPowerEditorId.Horsepower) { 
                data.Watt = data.Horsepower.HorsePower().ToWatts();
                return;
            }
            if (data.ForceAndPowerEditorId == ForceAndPowerEditorId.Watt) 
                data.Horsepower = data.Watt.Watts().ToHorsePower();
        }
        void ProcessCelsiusFahrenheitKelvinGroup(UnitConversionTemperatureAndPressureModel data) {
            if (data.TemperatureAndPressureEditorId == TemperatureAndPressureEditorId.Celsius) {
                data.Fahrenheit = data.Celsius.Celsius().ToFahrenheit();
                data.Kelvin = data.Celsius.Celsius().ToKelvin();
                return;
            }
            if (data.TemperatureAndPressureEditorId == TemperatureAndPressureEditorId.Fahrenheit) { 
                data.Celsius = data.Fahrenheit.Fahrenheit().ToCelsius();
                data.Kelvin = data.Fahrenheit.Fahrenheit().ToKelvin();
                return;
            }
            if (data.TemperatureAndPressureEditorId == TemperatureAndPressureEditorId.Kelvin) { 
                data.Celsius = data.Kelvin.Kelvin().ToCelsius();
                data.Fahrenheit = data.Kelvin.Kelvin().ToFahrenheit();
            }
        }
        void ProcessKilopascalAtmosphereMmOfMercuryGroup(UnitConversionTemperatureAndPressureModel data) {
            MetricUnitsConverter metricUnitsConverter = new MetricUnitsConverter();
            if (data.TemperatureAndPressureEditorId == TemperatureAndPressureEditorId.Kilopascal) { 
                double pascal = metricUnitsConverter.Convert(data.Kilopascal, MetricPrefix.Kilo, MetricPrefix.None);
                data.Atmosphere = pascal.Pascals().ToAtmospheres();
                data.MmOfMercury = pascal.Pascals().ToMmHg();
                return;
            }
            if (data.TemperatureAndPressureEditorId == TemperatureAndPressureEditorId.Atmosphere) { 
                double pascal = data.Atmosphere.Atmospheres().ToPascals();
                data.Kilopascal = metricUnitsConverter.Convert(pascal, MetricPrefix.None, MetricPrefix.Kilo);
                data.MmOfMercury = data.Atmosphere.Atmospheres().ToMmHg();
                return;
            }
            if (data.TemperatureAndPressureEditorId == TemperatureAndPressureEditorId.MmOfMercury) { 
                double pascal = data.MmOfMercury.MmHg().ToPascals();
                data.Kilopascal = metricUnitsConverter.Convert(pascal, MetricPrefix.None, MetricPrefix.Kilo);
                data.Atmosphere = data.MmOfMercury.MmHg().ToAtmospheres();
            }
        }
        void UpdateUnitConversionMassModel(QuantityValue<Mass> quantity, UnitConversionMassModel model) {
            model.Gram = quantity.ToGrams();
            model.Kilogram = quantity.ToKilograms();
            model.OunceMass = quantity.ToOunceMass();
            model.Pounds = quantity.ToPounds();
            Round(model);
        }
        void ProcessSquareMeterFeetGroup(UnitConversionDistanceAndSquareModel data) {
            DistanceGroupEditorId activeEditor = data.DistanceGroupEditorId;
            MetricUnitsConverter metricUnitsConverter = new MetricUnitsConverter();
            if (activeEditor == DistanceGroupEditorId.SquareMeter) {
                data.SquareFeet = data.SquareMeter.SquareMeters().ToSquareFeet();
                return;
            }
            if (activeEditor == DistanceGroupEditorId.SquareFeet) {
                data.SquareMeter = data.SquareFeet.SquareFeet().ToSquareMeters();
            }
        }
        void ProcessCentimeterInchFootGroup(UnitConversionDistanceAndSquareModel data) {
            DistanceGroupEditorId activeEditor = data.DistanceGroupEditorId;
            MetricUnitsConverter metricUnitsConverter = new MetricUnitsConverter();
            if (activeEditor == DistanceGroupEditorId.Centimeter) {
                double value = metricUnitsConverter.Convert(data.Centimeter, MetricPrefix.Centi, MetricPrefix.None);
                QuantityValue<Distance> distanceInMeters = value.Meters();
                data.Inch = distanceInMeters.ToInches();
                data.CentimeterToFoot = distanceInMeters.ToFeet();
                return;
            }
            if (activeEditor == DistanceGroupEditorId.Inch) {
                QuantityValue<Distance> distanceInMeters = data.Inch.Inches().ToMeters();
                data.Centimeter = metricUnitsConverter.Convert(distanceInMeters, MetricPrefix.None, MetricPrefix.Centi);
                data.CentimeterToFoot = data.Inch.Inches().ToFeet();
                return;
            }
            if (activeEditor == DistanceGroupEditorId.CentimeterToFoot) {
                QuantityValue<Distance> distanceInMeters = data.CentimeterToFoot.Feet().ToMeters();
                data.Centimeter = metricUnitsConverter.Convert(distanceInMeters, MetricPrefix.None, MetricPrefix.Centi);
                data.Inch = data.CentimeterToFoot.Feet().ToInches();
            }
        }
        void ProcessMeterFootYardGroup(UnitConversionDistanceAndSquareModel data) {
            DistanceGroupEditorId activeEditor = data.DistanceGroupEditorId;
            MetricUnitsConverter metricUnitsConverter = new MetricUnitsConverter();
            if (activeEditor == DistanceGroupEditorId.Meter) {
                data.Yard = data.Meter.Meters().ToYards();
                data.MeterToFoot = data.Meter.Meters().ToFeet();
                return;
            }
            if (activeEditor == DistanceGroupEditorId.MeterToFoot) {
                data.Meter = data.MeterToFoot.Feet().ToMeters();
                data.Yard = data.MeterToFoot.Feet().ToYards();
                return;
            }
            if (activeEditor == DistanceGroupEditorId.Yard) {
                data.Meter = data.Yard.Yards().ToMeters();
                data.MeterToFoot = data.Yard.Yards().ToFeet();
            }
        }
        void ProcessKilometerStatuteNauticalMileGroup(UnitConversionDistanceAndSquareModel data) {
            DistanceGroupEditorId activeEditor = data.DistanceGroupEditorId;
            MetricUnitsConverter metricUnitsConverter = new MetricUnitsConverter();

            if (activeEditor == DistanceGroupEditorId.Kilometer) {
                double value = metricUnitsConverter.Convert(data.Kilometer, MetricPrefix.Kilo, MetricPrefix.None);
                QuantityValue<Distance> distanceInMeters = value.Meters();
                data.StatuteMile = distanceInMeters.ToMilesStatute();
                data.NauticalMile = distanceInMeters.ToMilesNautical();
                return;
            }
            if (activeEditor == DistanceGroupEditorId.StatuteMile) {
                QuantityValue<Distance> distanceInMeters = data.StatuteMile.MilesStatute().ToMeters();
                data.Kilometer = metricUnitsConverter.Convert(distanceInMeters, MetricPrefix.None, MetricPrefix.Kilo);
                data.NauticalMile = data.StatuteMile.MilesStatute().ToMilesNautical();
                return;
            }
            if (activeEditor == DistanceGroupEditorId.NauticalMile) {
                QuantityValue<Distance> distanceInMeters = data.NauticalMile.MilesNautical().ToMeters();
                data.Kilometer = metricUnitsConverter.Convert(distanceInMeters, MetricPrefix.None, MetricPrefix.Kilo);
                data.StatuteMile = data.NauticalMile.MilesNautical().ToMilesStatute();
            }
        }

        void InitializeDistanceAndSquareModel(UnitConversionDistanceAndSquareModel data) {
            data.DistanceGroupEditorId = DistanceGroupEditorId.Kilometer;
            data.Kilometer = 1;
            ProcessKilometerStatuteNauticalMileGroup(data);

            data.DistanceGroupEditorId = DistanceGroupEditorId.Meter;
            data.Meter = 1;
            ProcessMeterFootYardGroup(data);

            data.DistanceGroupEditorId = DistanceGroupEditorId.Inch;
            data.Inch = 1;
            ProcessCentimeterInchFootGroup(data);

            data.DistanceGroupEditorId = DistanceGroupEditorId.SquareMeter;
            data.SquareMeter = 1;
            ProcessSquareMeterFeetGroup(data);
            Round(data);
        }
        void InitializeTemperatureAndPressureModel(UnitConversionTemperatureAndPressureModel data) {
            data.TemperatureAndPressureEditorId = TemperatureAndPressureEditorId.Celsius;
            data.Celsius = 36.6;
            ProcessCelsiusFahrenheitKelvinGroup(data);
            data.TemperatureAndPressureEditorId = TemperatureAndPressureEditorId.Atmosphere;
            data.Atmosphere = 1;
            ProcessKilopascalAtmosphereMmOfMercuryGroup(data);
            Round(data);
        }
        void InitializeForceAndPowerModel(UnitConversionForceAndPowerModel data) {
            data.ForceAndPowerEditorId = ForceAndPowerEditorId.Newton;
            data.Newton = 1;
            ProcessNewtonDynePoundForceGroup(data);
            data.ForceAndPowerEditorId = ForceAndPowerEditorId.Horsepower;
            data.Horsepower = 1;
            ProcessHorsepowerWattGroup(data);
            Round(data);
        }
        void Round(UnitConversionMassModel data) {
            data.Gram = Round(data.Gram, 3);
            data.Kilogram = Round(data.Kilogram, 3);
            data.OunceMass = Round(data.OunceMass, 3);
            data.Pounds = Round(data.Pounds, 3);
        }
        void Round(UnitConversionTemperatureAndPressureModel data) {
            data.Atmosphere = Round(data.Atmosphere, 2);
            data.Celsius = Round(data.Celsius, 2);
            data.Fahrenheit = Round(data.Fahrenheit, 2);
            data.Kelvin = Round(data.Kelvin, 2);
            data.Kilopascal = Round(data.Kilopascal, 2);
            data.MmOfMercury = Round(data.MmOfMercury, 2);
        }
        void Round(UnitConversionDistanceAndSquareModel data) {
            data.Meter = Round(data.Meter, 3);
            data.Centimeter = Round(data.Centimeter, 3);
            data.CentimeterToFoot = Round(data.CentimeterToFoot, 3);
            data.Inch = Round(data.Inch, 3);
            data.Kilometer = Round(data.Kilometer, 3);
            data.MeterToFoot = Round(data.MeterToFoot, 3);
            data.NauticalMile = Round(data.NauticalMile, 3);
            data.SquareFeet = Round(data.SquareFeet, 3);
            data.SquareMeter = Round(data.SquareMeter, 3);
            data.StatuteMile = Round(data.StatuteMile, 3);
            data.Yard = Round(data.Yard, 3);
        }
        void Round(UnitConversionForceAndPowerModel data) {
            data.Dyne = Round(data.Dyne, 5);
            data.Horsepower = Round(data.Horsepower, 1);
            data.Newton = Round(data.Newton, 5);
            data.PoundForce = Round(data.PoundForce, 5);
            data.Watt = Round(data.Watt, 1);
        }

        double Round(double value, int digits) {
            return Math.Round(value, digits);
        }
    }
}
