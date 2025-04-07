using Allure.Net.Commons;
using LivingDoc.SpecFlowPlugin;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vericode_test.Support;

namespace vericode_test.Support
{
    public class Helpers
    {
        public string expect_response_code(string obtained, string expect = "OK", string message = null)
        {
            string description;

            switch (obtained)
            {
                case "BadRequest":
                    description = "Requisição com sintaxe inválida\n" + message + ".\n\n\n";
                    break;
                case "Unauthorized":
                    description = "Necessário autenticação para obter resposta\n" + message + ".\n\n\n";
                    break;
                case "InternalServerError":
                    description = "Erro interno do servidor\n" + message + ".\n\n\n";
                    break;
                case "BadGateway":
                    description = "Servidor/Aplicação não encontrada\n" + message + ".\n\n\n";
                    break;
                case "GatewayTimeout":
                    description = "Timeout\n" + message + ".\n\n\n";
                    break;
                case "MethodNotAllowed":
                    description = "MethodNotAllowed\n" + message + ".\n\n\n";
                    break;
                default:
                    description = "Não especificado no método";
                    break;
            }
            return "\n[ERRO] expect código: " + expect + "\nobtained código: " + obtained + " - " + description + "\n" + message + ".\n\n\n";
        }
        public string take_screenshot()
        {
            var screenshot = ((ITakesScreenshot)Hooks.driver).GetScreenshot();
            string directoryPath = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent + "/Report";

            string filePath = Path.Combine(directoryPath, DateTime.Now.ToString("dd-MM-yy_HH-mm-ss") + ".png");
            Thread.Sleep(1000);
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            screenshot.SaveAsFile(filePath);
            AllureApi.AddAttachment(filePath);

            return screenshot.AsBase64EncodedString;
        }
    }
}