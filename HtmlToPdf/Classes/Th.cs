
public class Th : Generic
{
    public Th() { }
    public Th(string className) : base(className) { }
    public Th(string className, string text) : base(className)
    {
        this.Text = text;
    }
    public string Text { get; set; } = "";
    public override string ToString()
    {
        return $"<th class='{this.ClassName}'>{this.Text}</th>";
    }
}