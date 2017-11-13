using System;
namespace DevExpress.XtraCharts.Demos {
    enum PolarDiagramFunctions {
        Circles = 0,
        Cardioid = 1,
        Lemniscate = 2
    }

    static class PolarDiagramPointsGenerator {
        const int DefaultPointsCount = 72;

        static SeriesPoint GenerateSeriesPoint(double m, double value, int pointsInSeries) {
            double[] points = new double[pointsInSeries];
            for (int i = 0; i < pointsInSeries; i++) {
                double factor = (i == 0) ? m : 0;
                points[i] = Function(factor, value);
            }
            return new SeriesPoint(value, points);
        }
        static double Function(double m, double angle) {
            double cos = Math.Cos(m * ToRadian(90.0 + angle));
            return Math.Pow(Math.Abs(cos), m);
        }
        static double ToRadian(double angle) {
            return angle * Math.PI / 180.0;
        }
        static SeriesPoint[] GenerateFunctionPoints(double m, int pointCount, int pointsInSeries) {
            int step = 360 / pointCount;
            SeriesPoint[] points = new SeriesPoint[pointCount];
            for (int i = 0; i < pointCount; i++)
                points[i] = GenerateSeriesPoint(m, i * step, pointsInSeries);
            return points;
        }
        static double GetLineFactor(PolarDiagramFunctions functionType) {
            switch (functionType) {
                case PolarDiagramFunctions.Circles:
                    return 1;
                case PolarDiagramFunctions.Cardioid:
                    return 0.5;
                default:
                    return 2;
            }
        }
        public static SeriesPoint[] GenerateFunctionPoints(PolarDiagramFunctions functionType, int pointsInSeries) {
            double lineFactor = GetLineFactor(functionType);
            return GenerateFunctionPoints(lineFactor, DefaultPointsCount, pointsInSeries);
        }
    }
}
