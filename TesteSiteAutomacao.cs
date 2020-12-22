using aula1;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Reflection;
using System.Threading;

namespace aula2

{
    [TestFixture]
    public class TesteSiteAutomacao : WebDriver
     {
        Util util = new Util();

        [SetUp()]
        public void Inicializar()
        {
            AbrirNavegador();
        }

        [TearDown()]
        public void CleanUP()
        {
            util.ScreenShot(driver);
            driver.Close();
        }

        [Test]
        public void TesteSiteAutomacaocadastro()

        {
            
            //1.Informar URL que deseja acessar
            AbrirURL("https://medium.com/@reiload_88128/top-10-sites-para-praticar-automa%C3%A7%C3%A3o-de-testes-web-1f2f4e54ff80/");

            util.Tempo(1500);

            //2.Clicar na URL no topico 7

            driver.FindElement(By.Id("adc3")).Click();

            Thread.Sleep(1500);

            //2.na Site para Automação cicar em começar automação web

            driver.FindElement(By.CssSelector("[class='btn waves-light orange']")).Click();

            Thread.Sleep(1500);

            //3.Na tela dados cadastrais, clicar em formulario, preencher em ordem, nome (william), ultimo nome (gomes)

            //email (woliveirag86@gmail.com), endereço (centro), universidade (Estacio de Sá), profissão (QA), Genero (Masculino) e idade (33)

            //4.Clicar em Formularios

            driver.FindElement(By.XPath("/html/body/div[2]/div[1]/ul/li[1]/a")).Click();

            Thread.Sleep(500);
            
            //5.Clicar em Criar Usuários

            driver.FindElement(By.XPath("/html/body/div[2]/div[1]/ul/li[1]/div/ul/li[1]/a")).Click();

            Thread.Sleep(500);

            //6.Inserir nome

            driver.FindElement(By.Id("user_name")).SendKeys("William");

            Thread.Sleep(500);

            //7.Inserir Ultimo nome

            driver.FindElement(By.Id("user_lastname")).SendKeys("Gomes");

            Thread.Sleep(500);

            //8.Inserir E-mail

            driver.FindElement(By.Id("user_email")).SendKeys("woliveirag86@gmail.com");

            Thread.Sleep(500);

            //9.inserir Endereço

            driver.FindElement(By.Id("user_address")).SendKeys("CENTRO");

            Thread.Sleep(500);

            //10.Inserir Faculdade

            driver.FindElement(By.Id("user_university")).SendKeys("Estacio de Sá");

            Thread.Sleep(500);

            //11.Inserir Profissão

            driver.FindElement(By.Id("user_profile")).SendKeys("QA");

            Thread.Sleep(500);

            //12.Inserir Genero

            driver.FindElement(By.Id("user_gender")).SendKeys("Masculino");

            Thread.Sleep(500);

            //13.Inserir Idade
            
            driver.FindElement(By.Id("user_age")).SendKeys("33");

            Thread.Sleep(500);

            //14.Clicar em Criar

            driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[3]/div[2]/form/div[5]/div/div/input")).Click();

            Thread.Sleep(3500);

            //15.Clicar em Ediatr para alteração de dados

            driver.FindElement(By.CssSelector("[class='btn waves-light blue']")).Click();

            Thread.Sleep(500);

            //Limpar campo endereço

            driver.FindElement(By.Id("user_address")).Clear();

            Thread.Sleep(2500);

            //Editar campo endereço

            driver.FindElement(By.Id("user_address")).SendKeys("Rio de Janeiro");

            Thread.Sleep(1500);
            
            //Limpar campo profissão

            driver.FindElement(By.Id("user_profile")).Clear();

            Thread.Sleep(2500);

            //Editar Profissão

            driver.FindElement(By.Id("user_profile")).SendKeys("Quality Assurance (QA)");

            Thread.Sleep(2000);

            //Clicar em Criar

            driver.FindElement(By.CssSelector("[class='actions btn waves-effect green']")).Click();

            Thread.Sleep(5000);
            
        }


        /*[Test]
        public void AbrirGoogle()
        {
            
            AbrirURL("https://www.google.com.br"); 
                
        }*/

    }



}