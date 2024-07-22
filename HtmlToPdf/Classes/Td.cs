  public class Td : Generic
    {
        public Td()
        {

        }
        public Td(string className) : base(className) { }
        public Td(string className, string text) : base(className)
        {
            this.Text = text;
        }
        public string Text { get; set; } = "";
        public int RowSpan { get; set; } = 0;
        public int ColSpan { get; set; } = 0;
        public override string ToString()
        {
            string rowSpan = this.RowSpan == 0 ? "" : $"rowspan='{this.RowSpan}'";
            {
                string colSpan = this.ColSpan == 0 ? "" : $"colspan='{this.ColSpan}'";
                return $"<td class='{this.ClassName}' {rowSpan} {colSpan}>{this.Text}</td>";
            }
        }
    }