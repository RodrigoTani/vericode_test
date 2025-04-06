using Allure.Net.Commons;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public void take_screenshot()
        {
            //Screenshot screenshot = ((ITakesScreenshot)Hooks.driver).GetScreenshot();
            //screenshot.SaveAsFile("C:\\Users\\rodrigo.tani\\Documents\\WorkSpace\\vericode_test\\vericode_test\\Report\\" + "{0}.png");

            //AllureApi.AddAttachment("Screenshot", "image/png", "/Report/Screenshot.png");
        }
    }
}
