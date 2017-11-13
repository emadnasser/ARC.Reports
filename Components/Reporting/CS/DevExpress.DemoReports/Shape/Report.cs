using System;

namespace XtraReportsDemos.Shape
{
	public class Report : DevExpress.XtraReports.UI.XtraReport
	{
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRShape xrShape28;
        private DevExpress.XtraReports.UI.XRShape xrShape27;
        private DevExpress.XtraReports.UI.XRShape xrShape26;
        private DevExpress.XtraReports.UI.XRShape xrShape25;
        private DevExpress.XtraReports.UI.XRShape xrShape24;
        private DevExpress.XtraReports.UI.XRShape xrShape23;
        private DevExpress.XtraReports.UI.XRShape xrShape22;
        private DevExpress.XtraReports.UI.XRShape xrShape21;
        private DevExpress.XtraReports.UI.XRShape xrShape20;
        private DevExpress.XtraReports.UI.XRShape xrShape19;
        private DevExpress.XtraReports.UI.XRShape xrShape18;
        private DevExpress.XtraReports.UI.XRShape xrShape17;
        private DevExpress.XtraReports.UI.XRShape xrShape16;
        private DevExpress.XtraReports.UI.XRShape xrShape15;
        private DevExpress.XtraReports.UI.XRShape xrShape14;
        private DevExpress.XtraReports.UI.XRShape xrShape13;
        private DevExpress.XtraReports.UI.XRShape xrShape12;
        private DevExpress.XtraReports.UI.XRShape xrShape11;
        private DevExpress.XtraReports.UI.XRShape xrShape10;
        private DevExpress.XtraReports.UI.XRShape xrShape9;
        private DevExpress.XtraReports.UI.XRShape xrShape8;
        private DevExpress.XtraReports.UI.XRShape xrShape7;
        private DevExpress.XtraReports.UI.XRShape xrShape6;
        private DevExpress.XtraReports.UI.XRShape xrShape5;
        private DevExpress.XtraReports.UI.XRShape xrShape4;
        private DevExpress.XtraReports.UI.XRShape xrShape3;
        private DevExpress.XtraReports.UI.XRShape xrShape2;
        private DevExpress.XtraReports.UI.XRShape xrShape1;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.TopMarginBand topMarginBand1;
        private DevExpress.XtraReports.UI.BottomMarginBand bottomMarginBand1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;

		public Report() 
		{
			InitializeComponent();
			Name = ReportNames.Shapes;
            DisplayName = ReportNames.Shapes;
		}

		private void InitializeComponent() 
		{
            DevExpress.XtraPrinting.Shape.ShapeBracket shapeBracket1 = new DevExpress.XtraPrinting.Shape.ShapeBracket();
            DevExpress.XtraPrinting.Shape.ShapePolygon shapePolygon1 = new DevExpress.XtraPrinting.Shape.ShapePolygon();
            DevExpress.XtraPrinting.Shape.ShapeCross shapeCross1 = new DevExpress.XtraPrinting.Shape.ShapeCross();
            DevExpress.XtraPrinting.Shape.ShapeRectangle shapeRectangle1 = new DevExpress.XtraPrinting.Shape.ShapeRectangle();
            DevExpress.XtraPrinting.Shape.ShapeBrace shapeBrace1 = new DevExpress.XtraPrinting.Shape.ShapeBrace();
            DevExpress.XtraPrinting.Shape.ShapeBrace shapeBrace2 = new DevExpress.XtraPrinting.Shape.ShapeBrace();
            DevExpress.XtraPrinting.Shape.ShapeBracket shapeBracket2 = new DevExpress.XtraPrinting.Shape.ShapeBracket();
            DevExpress.XtraPrinting.Shape.ShapeCross shapeCross2 = new DevExpress.XtraPrinting.Shape.ShapeCross();
            DevExpress.XtraPrinting.Shape.ShapeLine shapeLine1 = new DevExpress.XtraPrinting.Shape.ShapeLine();
            DevExpress.XtraPrinting.Shape.ShapeLine shapeLine2 = new DevExpress.XtraPrinting.Shape.ShapeLine();
            DevExpress.XtraPrinting.Shape.ShapeLine shapeLine3 = new DevExpress.XtraPrinting.Shape.ShapeLine();
            DevExpress.XtraPrinting.Shape.ShapeLine shapeLine4 = new DevExpress.XtraPrinting.Shape.ShapeLine();
            DevExpress.XtraPrinting.Shape.ShapeStar shapeStar1 = new DevExpress.XtraPrinting.Shape.ShapeStar();
            DevExpress.XtraPrinting.Shape.ShapeStar shapeStar2 = new DevExpress.XtraPrinting.Shape.ShapeStar();
            DevExpress.XtraPrinting.Shape.ShapeStar shapeStar3 = new DevExpress.XtraPrinting.Shape.ShapeStar();
            DevExpress.XtraPrinting.Shape.ShapeStar shapeStar4 = new DevExpress.XtraPrinting.Shape.ShapeStar();
            DevExpress.XtraPrinting.Shape.ShapeStar shapeStar5 = new DevExpress.XtraPrinting.Shape.ShapeStar();
            DevExpress.XtraPrinting.Shape.ShapePolygon shapePolygon2 = new DevExpress.XtraPrinting.Shape.ShapePolygon();
            DevExpress.XtraPrinting.Shape.ShapePolygon shapePolygon3 = new DevExpress.XtraPrinting.Shape.ShapePolygon();
            DevExpress.XtraPrinting.Shape.ShapePolygon shapePolygon4 = new DevExpress.XtraPrinting.Shape.ShapePolygon();
            DevExpress.XtraPrinting.Shape.ShapePolygon shapePolygon5 = new DevExpress.XtraPrinting.Shape.ShapePolygon();
            DevExpress.XtraPrinting.Shape.ShapeArrow shapeArrow1 = new DevExpress.XtraPrinting.Shape.ShapeArrow();
            DevExpress.XtraPrinting.Shape.ShapePolygon shapePolygon6 = new DevExpress.XtraPrinting.Shape.ShapePolygon();
            DevExpress.XtraPrinting.Shape.ShapeArrow shapeArrow2 = new DevExpress.XtraPrinting.Shape.ShapeArrow();
            DevExpress.XtraPrinting.Shape.ShapeArrow shapeArrow3 = new DevExpress.XtraPrinting.Shape.ShapeArrow();
            DevExpress.XtraPrinting.Shape.ShapeArrow shapeArrow4 = new DevExpress.XtraPrinting.Shape.ShapeArrow();
            DevExpress.XtraPrinting.Shape.ShapeRectangle shapeRectangle2 = new DevExpress.XtraPrinting.Shape.ShapeRectangle();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrShape28 = new DevExpress.XtraReports.UI.XRShape();
            this.xrShape27 = new DevExpress.XtraReports.UI.XRShape();
            this.xrShape26 = new DevExpress.XtraReports.UI.XRShape();
            this.xrShape25 = new DevExpress.XtraReports.UI.XRShape();
            this.xrShape24 = new DevExpress.XtraReports.UI.XRShape();
            this.xrShape23 = new DevExpress.XtraReports.UI.XRShape();
            this.xrShape22 = new DevExpress.XtraReports.UI.XRShape();
            this.xrShape21 = new DevExpress.XtraReports.UI.XRShape();
            this.xrShape20 = new DevExpress.XtraReports.UI.XRShape();
            this.xrShape19 = new DevExpress.XtraReports.UI.XRShape();
            this.xrShape18 = new DevExpress.XtraReports.UI.XRShape();
            this.xrShape17 = new DevExpress.XtraReports.UI.XRShape();
            this.xrShape16 = new DevExpress.XtraReports.UI.XRShape();
            this.xrShape15 = new DevExpress.XtraReports.UI.XRShape();
            this.xrShape14 = new DevExpress.XtraReports.UI.XRShape();
            this.xrShape13 = new DevExpress.XtraReports.UI.XRShape();
            this.xrShape12 = new DevExpress.XtraReports.UI.XRShape();
            this.xrShape11 = new DevExpress.XtraReports.UI.XRShape();
            this.xrShape10 = new DevExpress.XtraReports.UI.XRShape();
            this.xrShape9 = new DevExpress.XtraReports.UI.XRShape();
            this.xrShape8 = new DevExpress.XtraReports.UI.XRShape();
            this.xrShape7 = new DevExpress.XtraReports.UI.XRShape();
            this.xrShape6 = new DevExpress.XtraReports.UI.XRShape();
            this.xrShape5 = new DevExpress.XtraReports.UI.XRShape();
            this.xrShape4 = new DevExpress.XtraReports.UI.XRShape();
            this.xrShape3 = new DevExpress.XtraReports.UI.XRShape();
            this.xrShape2 = new DevExpress.XtraReports.UI.XRShape();
            this.xrShape1 = new DevExpress.XtraReports.UI.XRShape();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.bottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrShape28,
            this.xrShape27,
            this.xrShape26,
            this.xrShape25,
            this.xrShape24,
            this.xrShape23,
            this.xrShape22,
            this.xrShape21,
            this.xrShape20,
            this.xrShape19,
            this.xrShape18,
            this.xrShape17,
            this.xrShape16,
            this.xrShape15,
            this.xrShape14,
            this.xrShape13,
            this.xrShape12,
            this.xrShape11,
            this.xrShape10,
            this.xrShape9,
            this.xrShape8,
            this.xrShape7,
            this.xrShape6,
            this.xrShape5,
            this.xrShape4,
            this.xrShape3,
            this.xrShape2,
            this.xrShape1});
            this.Detail.HeightF = 708F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrShape28
            // 
            this.xrShape28.Angle = 180;
            this.xrShape28.BorderWidth = 1;
            this.xrShape28.FillColor = System.Drawing.Color.Red;
            this.xrShape28.LineWidth = 2;
            this.xrShape28.LocationFloat = new DevExpress.Utils.PointFloat(175F, 600F);
            this.xrShape28.Name = "xrShape28";
            this.xrShape28.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrShape28.Shape = shapeBracket1;
            this.xrShape28.SizeF = new System.Drawing.SizeF(133F, 83F);
            this.xrShape28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrShape27
            // 
            this.xrShape27.Angle = 45;
            this.xrShape27.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(197)))), ((int)(((byte)(238)))));
            this.xrShape27.LineWidth = 0;
            this.xrShape27.LocationFloat = new DevExpress.Utils.PointFloat(492F, 408F);
            this.xrShape27.Name = "xrShape27";
            this.xrShape27.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            shapePolygon1.Fillet = 75;
            shapePolygon1.NumberOfSides = 4;
            this.xrShape27.Shape = shapePolygon1;
            this.xrShape27.SizeF = new System.Drawing.SizeF(133F, 92F);
            this.xrShape27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrShape26
            // 
            this.xrShape26.Angle = 45;
            this.xrShape26.FillColor = System.Drawing.Color.Silver;
            this.xrShape26.LineWidth = 0;
            this.xrShape26.LocationFloat = new DevExpress.Utils.PointFloat(200F, 417F);
            this.xrShape26.Name = "xrShape26";
            this.xrShape26.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            shapeCross1.Fillet = 100;
            shapeCross1.HorizontalLineWidth = 30;
            shapeCross1.VerticalLineWidth = 30;
            this.xrShape26.Shape = shapeCross1;
            this.xrShape26.SizeF = new System.Drawing.SizeF(83F, 84F);
            this.xrShape26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrShape25
            // 
            this.xrShape25.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(197)))), ((int)(((byte)(33)))));
            this.xrShape25.LineWidth = 0;
            this.xrShape25.LocationFloat = new DevExpress.Utils.PointFloat(175F, 8F);
            this.xrShape25.Name = "xrShape25";
            this.xrShape25.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            shapeRectangle1.Fillet = 20;
            this.xrShape25.Shape = shapeRectangle1;
            this.xrShape25.SizeF = new System.Drawing.SizeF(133F, 92F);
            this.xrShape25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrShape24
            // 
            this.xrShape24.Angle = 180;
            this.xrShape24.BorderWidth = 1;
            this.xrShape24.LineWidth = 2;
            this.xrShape24.LocationFloat = new DevExpress.Utils.PointFloat(492F, 600F);
            this.xrShape24.Name = "xrShape24";
            this.xrShape24.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrShape24.Shape = shapeBrace1;
            this.xrShape24.SizeF = new System.Drawing.SizeF(133F, 83F);
            this.xrShape24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrShape23
            // 
            this.xrShape23.BorderWidth = 1;
            this.xrShape23.LineWidth = 2;
            this.xrShape23.LocationFloat = new DevExpress.Utils.PointFloat(333F, 600F);
            this.xrShape23.Name = "xrShape23";
            this.xrShape23.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrShape23.Shape = shapeBrace2;
            this.xrShape23.SizeF = new System.Drawing.SizeF(133F, 83F);
            this.xrShape23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrShape22
            // 
            this.xrShape22.BorderWidth = 1;
            this.xrShape22.FillColor = System.Drawing.Color.Red;
            this.xrShape22.LineWidth = 2;
            this.xrShape22.LocationFloat = new DevExpress.Utils.PointFloat(17F, 600F);
            this.xrShape22.Name = "xrShape22";
            this.xrShape22.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrShape22.Shape = shapeBracket2;
            this.xrShape22.SizeF = new System.Drawing.SizeF(133F, 83F);
            this.xrShape22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrShape21
            // 
            this.xrShape21.FillColor = System.Drawing.Color.DodgerBlue;
            this.xrShape21.LineWidth = 0;
            this.xrShape21.LocationFloat = new DevExpress.Utils.PointFloat(17F, 408F);
            this.xrShape21.Name = "xrShape21";
            this.xrShape21.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            shapeCross2.HorizontalLineWidth = 40;
            shapeCross2.VerticalLineWidth = 40;
            this.xrShape21.Shape = shapeCross2;
            this.xrShape21.SizeF = new System.Drawing.SizeF(133F, 92F);
            this.xrShape21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrShape20
            // 
            this.xrShape20.Angle = 315;
            this.xrShape20.BorderWidth = 1;
            this.xrShape20.LineWidth = 2;
            this.xrShape20.LocationFloat = new DevExpress.Utils.PointFloat(492F, 508F);
            this.xrShape20.Name = "xrShape20";
            this.xrShape20.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrShape20.Shape = shapeLine1;
            this.xrShape20.SizeF = new System.Drawing.SizeF(133F, 83F);
            this.xrShape20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrShape19
            // 
            this.xrShape19.Angle = 45;
            this.xrShape19.BorderWidth = 1;
            this.xrShape19.LineWidth = 2;
            this.xrShape19.LocationFloat = new DevExpress.Utils.PointFloat(333F, 508F);
            this.xrShape19.Name = "xrShape19";
            this.xrShape19.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrShape19.Shape = shapeLine2;
            this.xrShape19.SizeF = new System.Drawing.SizeF(133F, 83F);
            this.xrShape19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrShape18
            // 
            this.xrShape18.Angle = 90;
            this.xrShape18.BorderWidth = 1;
            this.xrShape18.FillColor = System.Drawing.Color.Red;
            this.xrShape18.LineWidth = 2;
            this.xrShape18.LocationFloat = new DevExpress.Utils.PointFloat(175F, 508F);
            this.xrShape18.Name = "xrShape18";
            this.xrShape18.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrShape18.Shape = shapeLine3;
            this.xrShape18.SizeF = new System.Drawing.SizeF(134F, 83F);
            this.xrShape18.Stretch = true;
            this.xrShape18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrShape17
            // 
            this.xrShape17.BorderWidth = 1;
            this.xrShape17.LineWidth = 2;
            this.xrShape17.LocationFloat = new DevExpress.Utils.PointFloat(17F, 508F);
            this.xrShape17.Name = "xrShape17";
            this.xrShape17.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrShape17.Shape = shapeLine4;
            this.xrShape17.SizeF = new System.Drawing.SizeF(133F, 83F);
            this.xrShape17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrShape16
            // 
            this.xrShape16.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(84)))), ((int)(((byte)(172)))));
            this.xrShape16.LineWidth = 0;
            this.xrShape16.LocationFloat = new DevExpress.Utils.PointFloat(492F, 308F);
            this.xrShape16.Name = "xrShape16";
            this.xrShape16.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            shapeStar1.StarPointCount = 8;
            this.xrShape16.Shape = shapeStar1;
            this.xrShape16.SizeF = new System.Drawing.SizeF(133F, 92F);
            this.xrShape16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrShape15
            // 
            this.xrShape15.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.xrShape15.LineWidth = 0;
            this.xrShape15.LocationFloat = new DevExpress.Utils.PointFloat(175F, 308F);
            this.xrShape15.Name = "xrShape15";
            this.xrShape15.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            shapeStar2.StarPointCount = 5;
            this.xrShape15.Shape = shapeStar2;
            this.xrShape15.SizeF = new System.Drawing.SizeF(134F, 92F);
            this.xrShape15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrShape14
            // 
            this.xrShape14.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.xrShape14.LineWidth = 0;
            this.xrShape14.LocationFloat = new DevExpress.Utils.PointFloat(333F, 308F);
            this.xrShape14.Name = "xrShape14";
            this.xrShape14.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            shapeStar3.Concavity = 35;
            shapeStar3.StarPointCount = 6;
            this.xrShape14.Shape = shapeStar3;
            this.xrShape14.SizeF = new System.Drawing.SizeF(133F, 92F);
            this.xrShape14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrShape13
            // 
            this.xrShape13.Angle = 45;
            this.xrShape13.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(202)))), ((int)(((byte)(149)))));
            this.xrShape13.LineWidth = 0;
            this.xrShape13.LocationFloat = new DevExpress.Utils.PointFloat(17F, 308F);
            this.xrShape13.Name = "xrShape13";
            this.xrShape13.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            shapeStar4.Concavity = 60;
            shapeStar4.Fillet = 20;
            shapeStar4.StarPointCount = 4;
            this.xrShape13.Shape = shapeStar4;
            this.xrShape13.SizeF = new System.Drawing.SizeF(133F, 92F);
            this.xrShape13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrShape12
            // 
            this.xrShape12.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(189)))), ((int)(((byte)(113)))));
            this.xrShape12.LineWidth = 0;
            this.xrShape12.LocationFloat = new DevExpress.Utils.PointFloat(492F, 208F);
            this.xrShape12.Name = "xrShape12";
            this.xrShape12.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrShape12.Shape = shapeStar5;
            this.xrShape12.SizeF = new System.Drawing.SizeF(133F, 91F);
            this.xrShape12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrShape11
            // 
            this.xrShape11.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(200)))), ((int)(((byte)(89)))));
            this.xrShape11.LineWidth = 0;
            this.xrShape11.LocationFloat = new DevExpress.Utils.PointFloat(175F, 208F);
            this.xrShape11.Name = "xrShape11";
            this.xrShape11.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            shapePolygon2.NumberOfSides = 6;
            this.xrShape11.Shape = shapePolygon2;
            this.xrShape11.SizeF = new System.Drawing.SizeF(134F, 91F);
            this.xrShape11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrShape10
            // 
            this.xrShape10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(111)))), ((int)(((byte)(191)))));
            this.xrShape10.LineWidth = 0;
            this.xrShape10.LocationFloat = new DevExpress.Utils.PointFloat(333F, 208F);
            this.xrShape10.Name = "xrShape10";
            this.xrShape10.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            shapePolygon3.NumberOfSides = 8;
            this.xrShape10.Shape = shapePolygon3;
            this.xrShape10.SizeF = new System.Drawing.SizeF(133F, 91F);
            this.xrShape10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrShape9
            // 
            this.xrShape9.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(190)))), ((int)(((byte)(141)))));
            this.xrShape9.LineWidth = 0;
            this.xrShape9.LocationFloat = new DevExpress.Utils.PointFloat(17F, 208F);
            this.xrShape9.Name = "xrShape9";
            this.xrShape9.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            shapePolygon4.Fillet = 20;
            shapePolygon4.NumberOfSides = 5;
            this.xrShape9.Shape = shapePolygon4;
            this.xrShape9.SizeF = new System.Drawing.SizeF(133F, 91F);
            this.xrShape9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrShape8
            // 
            this.xrShape8.FillColor = System.Drawing.Color.Gray;
            this.xrShape8.LineWidth = 0;
            this.xrShape8.LocationFloat = new DevExpress.Utils.PointFloat(333F, 408F);
            this.xrShape8.Name = "xrShape8";
            this.xrShape8.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            shapePolygon5.NumberOfSides = 4;
            this.xrShape8.Shape = shapePolygon5;
            this.xrShape8.SizeF = new System.Drawing.SizeF(133F, 92F);
            this.xrShape8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrShape7
            // 
            this.xrShape7.Angle = 270;
            this.xrShape7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(173)))));
            this.xrShape7.LineWidth = 0;
            this.xrShape7.LocationFloat = new DevExpress.Utils.PointFloat(492F, 108F);
            this.xrShape7.Name = "xrShape7";
            this.xrShape7.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            shapeArrow1.ArrowHeight = 40;
            shapeArrow1.ArrowWidth = 40;
            shapeArrow1.Fillet = 30;
            this.xrShape7.Shape = shapeArrow1;
            this.xrShape7.SizeF = new System.Drawing.SizeF(134F, 92F);
            this.xrShape7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrShape6
            // 
            this.xrShape6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(106)))), ((int)(((byte)(14)))));
            this.xrShape6.LineWidth = 0;
            this.xrShape6.LocationFloat = new DevExpress.Utils.PointFloat(492F, 8F);
            this.xrShape6.Name = "xrShape6";
            this.xrShape6.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            shapePolygon6.Fillet = 30;
            this.xrShape6.Shape = shapePolygon6;
            this.xrShape6.SizeF = new System.Drawing.SizeF(133F, 92F);
            this.xrShape6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrShape5
            // 
            this.xrShape5.Angle = 180;
            this.xrShape5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(199)))), ((int)(((byte)(213)))));
            this.xrShape5.LineWidth = 0;
            this.xrShape5.LocationFloat = new DevExpress.Utils.PointFloat(333F, 108F);
            this.xrShape5.Name = "xrShape5";
            this.xrShape5.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            shapeArrow2.ArrowHeight = 30;
            shapeArrow2.Fillet = 30;
            this.xrShape5.Shape = shapeArrow2;
            this.xrShape5.SizeF = new System.Drawing.SizeF(133F, 92F);
            this.xrShape5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrShape4
            // 
            this.xrShape4.Angle = 90;
            this.xrShape4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(91)))), ((int)(((byte)(217)))));
            this.xrShape4.LineWidth = 0;
            this.xrShape4.LocationFloat = new DevExpress.Utils.PointFloat(175F, 108F);
            this.xrShape4.Name = "xrShape4";
            this.xrShape4.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            shapeArrow3.ArrowWidth = 30;
            shapeArrow3.Fillet = 30;
            this.xrShape4.Shape = shapeArrow3;
            this.xrShape4.SizeF = new System.Drawing.SizeF(133F, 92F);
            this.xrShape4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrShape3
            // 
            this.xrShape3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(107)))), ((int)(((byte)(10)))));
            this.xrShape3.LineWidth = 0;
            this.xrShape3.LocationFloat = new DevExpress.Utils.PointFloat(17F, 108F);
            this.xrShape3.Name = "xrShape3";
            this.xrShape3.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            shapeArrow4.Fillet = 30;
            this.xrShape3.Shape = shapeArrow4;
            this.xrShape3.SizeF = new System.Drawing.SizeF(133F, 92F);
            this.xrShape3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrShape2
            // 
            this.xrShape2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(205)))), ((int)(((byte)(28)))));
            this.xrShape2.LineWidth = 0;
            this.xrShape2.LocationFloat = new DevExpress.Utils.PointFloat(333F, 8F);
            this.xrShape2.Name = "xrShape2";
            this.xrShape2.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrShape2.SizeF = new System.Drawing.SizeF(134F, 92F);
            this.xrShape2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrShape1
            // 
            this.xrShape1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(143)))), ((int)(((byte)(215)))));
            this.xrShape1.LineWidth = 0;
            this.xrShape1.LocationFloat = new DevExpress.Utils.PointFloat(17F, 8F);
            this.xrShape1.Name = "xrShape1";
            this.xrShape1.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrShape1.Shape = shapeRectangle2;
            this.xrShape1.SizeF = new System.Drawing.SizeF(133F, 92F);
            this.xrShape1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1});
            this.ReportHeader.HeightF = 91F;
            this.ReportHeader.Name = "ReportHeader";
            this.ReportHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.ReportHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel1
            // 
            this.xrLabel1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold);
            this.xrLabel1.ForeColor = System.Drawing.Color.Maroon;
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(50F, 25F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(567F, 50F);
            this.xrLabel1.Text = "Shapes supported by XtraReports:";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // topMarginBand1
            // 
            this.topMarginBand1.Name = "topMarginBand1";
            // 
            // bottomMarginBand1
            // 
            this.bottomMarginBand1.Name = "bottomMarginBand1";
            // 
            // Report
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.ReportHeader,
            this.topMarginBand1,
            this.bottomMarginBand1});
            this.Version = "10.1";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

		}
	}
}
