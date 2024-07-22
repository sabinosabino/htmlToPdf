

using HtmlToPdf.Classes;

string caminho = @"C:\Projetos\csharp\LibHtmlToPdf\teste\bin\Debug\net7.0\Chrome\Win64-124.0.6367.201\chrome-win64\chrome.exe";
var gera = new GenerateHtmlToPdf(caminho);

var style = new Style(@$"

                        h1{{color:red;}} 
                        .table{{
                            width:100%;
                            border-collapse: collapse;
                            font-size:9px;
                        }}
                            .table th{{
                                    text-align: left;
                                    border: 1px solid black;
                                    border-collapse: collapse;
                                    background-color: green;
                                }}
                            .table tr td{{
                                    border: 1px solid black;
                                    border-collapse: collapse;
                                }}

                            .centralizar{{text-align: center;}}
                            .fontm{{font-size:16px;}}
                            .col-1{{width:15%}}
                            .col-2{{width:65%}}
                            .col-3{{width:20%}}
                            .font-m{{
                                font-size:10px;
                                margin-top:30px;}}
                            
                        ");

var table = new Table("table");

table.AddTr("")
            .AddNewTd("centralizar col-1", "RD ENGENHARIA", rowSpan: 2)
            .AddNewTd("centralizar fontm col-2", "RELATÓRIO DIÁRIO DAS PRINCIPAIS ATIVIDADES EXECULTADAS", rowSpan: 2)
            .AddNewTd("col-3", "FOLHA 1");

table.AddTr("")
    .AddNewTd("", "OBRA: JOÃO PAULO I");

table.AddTr("")
    .AddNewTd("", "CONTRATANTE: ESCOLA JOÃO PAULO I", colSpan: 2)
    .AddNewTd("", "MÊS/ANO: 07/2024");

table.AddTr("")
    .AddNewTd("", "LOCALIDADE: Betim", colSpan: 2)
    .AddNewTd("", $"<p>TEMPO</p><p>Bom( ) CHUVOSO( )</p>", rowSpan: 2);

table.AddTr("")
    .AddNewTd("", "PRAZO CONTRATUAL: 365 dias", colSpan: 2);

table.AddTr("")
    .AddNewTd("", "DESCRICAO", colSpan: 3);

table.AddTr("")
    .AddNewTd("", "DIA")
    .AddNewTd("", "", colSpan: 2);

for (var i = 1; i <= 100; i++)
{
    table.AddTr("")
        .AddNewTd("", DateTime.Now.AddDays(i).ToString("dd/MM/yyyy"))
        .AddNewTd("", "DESCRICAO X +" + i, colSpan: 2);
}

var listDivs = new List<Div>();


listDivs.Add(new Div(new ElementText("", table.ToString())));
listDivs.Add(new Div(new ElementText("font-m", "DPAODPAOSDFIASPDF ASDFHASDFHASDKLFHASKJDFHAKSJDFHAJKSDFASDF")));
listDivs.Add(new Div(new ElementText("", "DDDDDDDDD sabino")));
var ele = new Element(style, listDivs);



await gera.Gerar(ele.ToString(), @"C:\Projetos\csharp\LibHtmlToPdf\file.pdf", true);