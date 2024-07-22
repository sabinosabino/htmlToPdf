using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Table : Generic
{
    public Table()
    {

    }
    public Table(string className) : base(className)
    {

    }
    public Table(string className, List<Th> th, List<Tr> tr) : base(className)
    {
        Th = th;
        Tr = tr;
    }

    private List<Th> Th { get; set; } = new();
    private List<Tr> Tr { get; set; } = new();

    public Th AddTh(string className)
    {
        var th = new Th(className);
        this.Th.Add(th);
        return th;
    }
    public Tr AddTr(string className)
    {
        var tr = new Tr(className);
        this.Tr.Add(tr);
        return tr;
    }
    private string GetTh()
    {
        var str = new StringBuilder();
        foreach (var h in this.Th)
        {
            str.AppendLine(h.ToString());
        }
        return str.ToString();
    }
    private string GetTr()
    {
        var str = new StringBuilder();
        foreach (var r in this.Tr)
        {
            str.AppendLine(r.ToString());
        }
        return str.ToString();
    }
    public override string ToString()
    {
        return $@"<table class='{this.ClassName}'>
                <thead>
                    <tr>
                        {this.GetTh()}
                    </tr>
                </thead>
                <tbody>
                    {this.GetTr()}
                </tbody>
            </table>";

    }
}
