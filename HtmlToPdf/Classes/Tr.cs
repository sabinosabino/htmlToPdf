using System.Text;
public class Tr : Generic
{
    public Tr()
    {

    }
    public Tr(string className) : base(className) { }
    private List<Td> Td { get; set; } = new();
    public void AddTd(string className, string text, int colSpan = 0, int rowSpan = 0)
    {
        Td.Add(new Td { ClassName = className, Text = text, ColSpan = colSpan, RowSpan = rowSpan });
    }
    public override string ToString()
    {
        var str = new StringBuilder();
        foreach (var td in this.Td)
        {
            str.AppendLine(td.ToString());
        }
        return $"<tr class='{this.ClassName}'>{str.ToString()}</tr>";
    }


}

public static class GenericTable
{
    public static Tr AddNewTd(this Tr tr, string className, string text, int colSpan = 0, int rowSpan = 0)
    {
        tr.AddTd(className, text, colSpan, rowSpan);
        return tr;
    }
}

