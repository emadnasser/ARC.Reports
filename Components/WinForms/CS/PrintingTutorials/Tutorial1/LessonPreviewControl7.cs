using System;
using System.Collections.Generic;
using System.Drawing;
using DevExpress.XtraPrinting;
using DevExpress.Utils;

namespace XtraPrintingDemos.Tutorial1 {
    public class LessonPreviewControl7 : LessonPreviewControl6 {
        static Dictionary<TutorialHelper.ProductsHelper.ProductColumn, string> columnsNames; 

        static LessonPreviewControl7() {
            columnsNames = new Dictionary<TutorialHelper.ProductsHelper.ProductColumn, string>();
            columnsNames[TutorialHelper.ProductsHelper.ProductColumn.Name] = "Name";
            columnsNames[TutorialHelper.ProductsHelper.ProductColumn.Price] = "Price";
            columnsNames[TutorialHelper.ProductsHelper.ProductColumn.Discontinued] = "Discontinued";
            columnsNames[TutorialHelper.ProductsHelper.ProductColumn.Icon] = "Type";
        }

        public LessonPreviewControl7() {
            link.CreateDetailHeaderArea += CreateDetailHeaderArea;
        }

        static readonly Color headerBackColor = Color.FromArgb(224, 214, 211);

        void CreateDetailHeaderArea(object sender, CreateAreaEventArgs e) {
            e.Graph.Font = new Font("Arial", 10f, FontStyle.Bold);
            e.Graph.BorderWidth = 1f;
            e.Graph.BorderColor = borderColor;
            e.Graph.BackColor = headerBackColor;

            foreach(TutorialHelper.ProductsHelper.ProductColumn column in Enum.GetValues(typeof(TutorialHelper.ProductsHelper.ProductColumn))) {
                string columnName = columnsNames[column];
                RectangleF bounds = TutorialHelper.ProductsHelper.GetBoundsForColumn(column);
                TextBrick brick = e.Graph.DrawString(columnName, bounds);
                brick.HorzAlignment = HorzAlignment.Center;
            }
        }
    }
}
