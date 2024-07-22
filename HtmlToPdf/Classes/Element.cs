using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlToPdf.Classes
{
    public class Element
    {
        private readonly Style _style;
        private readonly IEnumerable<Div> _divs;
        public Element(Style style, IEnumerable<Div> divs)
        {
            _style = style;
            _divs= divs;
        }

        private string getDivs(){
            var str = new StringBuilder();

            foreach (var item in _divs)
            {
                str.AppendLine(item.ToString());
            }
            return str.ToString();
        }
        public override string ToString()
        {
            return @$"
                <!DOCTYPE html>
                <html lang='en'>
                <head>
                    <meta charset='UTF-8'>
                    <meta name='viewport' content='width=device-width, initial-scale=1.0'>
                    <title>Document</title>
                </head>
                <style>
                    {_style.ToString()}
                </style>
                <body>
                    {this.getDivs()}
                </body>
                </html>
                ";
        }
    }
}