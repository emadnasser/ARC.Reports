using System.Web.UI.WebControls;

namespace DevExpress.Web.Demos {
    public class CheckListDemoOptions {
        public const RepeatLayout DefaultRepeatLayout = RepeatLayout.Table;
        public const RepeatDirection DefaultRepeatDirection = RepeatDirection.Horizontal;
        public const int DefaultRepeatColumns = 5;

        public CheckListDemoOptions() {
            RepeatLayout = DefaultRepeatLayout;
            RepeatDirection = DefaultRepeatDirection;
            RepeatColumns = DefaultRepeatColumns;
        }

        public RepeatLayout RepeatLayout { get; set; }
        public RepeatDirection RepeatDirection { get; set; }
        public int RepeatColumns { get; set; }
    }
}
