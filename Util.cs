using System;
using System.IO;
using System.Text;
using System.Threading;
using OpenQA.Selenium;


namespace aula1
{
    public class Util
    {
        //WebDriver driver = new WebDriver();
        
        public void Tempo(int time)
        {
            Thread.Sleep(time);
        }

        public void ScreenShot(IWebDriver driver)
        {
            var pastaLocal = ("C:\\screenshot_automacao\\");
            if (!System.IO.Directory.Exists(pastaLocal))
            {
                System.IO.Directory.CreateDirectory(pastaLocal);
            }

            var screenShot = ((ITakesScreenshot)driver).GetScreenshot();
            var nomeArquivo = new StringBuilder(pastaLocal);

            nomeArquivo.Append("print");
            nomeArquivo.Append(DateTime.Now.ToString("__MM-dd-yyyy_HH-mm-ss"));
            nomeArquivo.Append(".png");
            screenShot.SaveAsFile(nomeArquivo.ToString(), OpenQA.Selenium.ScreenshotImageFormat.Png);
        }
    }
}
