using System;
using System.Collections.Generic;

namespace DevExpress.Web.Demos {
    public class MiscellaneousUnitConversionModel {
        public MiscellaneousUnitConversionModel() {
            MassModel = new UnitConversionMassModel();
            DistanceAndSquareModel = new UnitConversionDistanceAndSquareModel();
            TemperatureAndPressureModel = new UnitConversionTemperatureAndPressureModel();
            ForceAndPowerModel = new UnitConversionForceAndPowerModel();
        }

        public UnitConversionMassModel MassModel { get; private set; }
        public UnitConversionDistanceAndSquareModel DistanceAndSquareModel { get; private set; }
        public UnitConversionTemperatureAndPressureModel TemperatureAndPressureModel { get; private set; }
        public UnitConversionForceAndPowerModel ForceAndPowerModel { get; private set; }
    }
    public class UnitConversionMassModel {
        public UnitConversionMassModel() {
            UnitMassGroupEditorId = UnitMassGroupEditorId.Gram;
        }

        public UnitMassGroupEditorId UnitMassGroupEditorId { get; set; }
        public double Gram { get; set; }
        public double Kilogram { get; set; }
        public double Pounds { get; set; }
        public double OunceMass { get; set; }
    }
    public enum UnitMassGroupEditorId {
        Gram, Kilogram, Pound, Ounce
    }

    public class UnitConversionDistanceAndSquareModel {
        public DistanceGroupEditorId DistanceGroupEditorId { get; set; }
        public double Kilometer { get; set; }
        public double Meter { get; set; }
        public double StatuteMile { get; set; }
        public double MeterToFoot { get; set; }
        public double NauticalMile { get; set; }
        public double Yard { get; set; }
        public double Centimeter { get; set; }
        public double SquareMeter { get; set; }
        public double Inch { get; set; }
        public double SquareFeet { get; set; }
        public double CentimeterToFoot { get; set; }
    }
    public enum DistanceGroupEditorId {
        Kilometer, Meter, StatuteMile, MeterToFoot, NauticalMile, Yard, Centimeter, SquareMeter, Inch, SquareFeet, CentimeterToFoot
    }

    public class UnitConversionTemperatureAndPressureModel {
        public TemperatureAndPressureEditorId TemperatureAndPressureEditorId { get; set; }
        public double Celsius { get; set; }
        public double Kilopascal { get; set; }
        public double Fahrenheit { get; set; }
        public double Atmosphere { get; set; }
        public double Kelvin { get; set; }
        public double MmOfMercury { get; set; }
    }
    public enum TemperatureAndPressureEditorId {
        Celsius, Kilopascal, Fahrenheit, Atmosphere, Kelvin, MmOfMercury
    }

    public class UnitConversionForceAndPowerModel {
        public ForceAndPowerEditorId ForceAndPowerEditorId { get; set; }
        public double Newton { get; set; }
        public double Horsepower { get; set; }
        public double Dyne { get; set; }
        public double Watt { get; set; }
        public double PoundForce { get; set; }
    }
    public enum ForceAndPowerEditorId {
        Newton, Horsepower, Dyne, Watt, PoundForce
    }
}
