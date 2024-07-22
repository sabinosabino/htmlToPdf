using PuppeteerSharp;
using PuppeteerSharp.Media;

public class GenerateHtmlToPdf
{
    private string path = string.Empty;
    public GenerateHtmlToPdf(string path)
    {
        this.path = path;
    }   
    public async Task Gerar(string html, string saida, bool landscape=false)
    {
        //Console.WriteLine(html);
        //, ExecutablePath = path
        var browserFetcher = new  BrowserFetcher();
        await browserFetcher.DownloadAsync(BrowserTag.Canary);
        using (var browser = await Puppeteer.LaunchAsync(new LaunchOptions { Headless = true}))
        using (var page = await browser.NewPageAsync()){
            await page.SetContentAsync(html);
             var pdfOptions = new PdfOptions { DisplayHeaderFooter = false, Landscape = landscape, PrintBackground = true, Format = PaperFormat.A4, MarginOptions = new MarginOptions { Top = "1cm", Bottom = "1cm", Left = "1cm", Right = "1cm" }, Scale = 1.5m, };
             await page.PdfAsync(saida, pdfOptions);
        }

    }
}