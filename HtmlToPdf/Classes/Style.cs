using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Style
{
    private readonly string style="";

    public Style(string style)
    {
        this.style = style;
    }

    public override string ToString()
    {
        return this.style;
    }
}