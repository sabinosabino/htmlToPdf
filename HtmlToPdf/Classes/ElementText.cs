using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class ElementText : Generic
{
    public ElementText(string className) : base(className) { }
    public ElementText(string className, string text) : base(className)
    {
        this.Text = text;
    }
    public string Text { get; set; } = "";

    
    public override string ToString()
    {
        return $"<div class='{this.ClassName}'><span>{this.Text}</span></div>";
    }
}