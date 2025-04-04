using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using vericode_test.Support;

namespace vericode_test.Pages
{
    public class VehicleDataPages
    {
        public IWebDriver driver;
        public VehicleDataPages(IWebDriver obj)
        {
            driver = obj;
        }

        public void validacao_campos()
        {
            var cylinder_Capacity = "1833";

            //Teste de limite - menor
            var list_Price = "499";
            driver.FindElement(By.Id("listprice")).SendKeys(list_Price);

            list_Price = "200000";
            driver.FindElement(By.Id("listprice")).SendKeys(list_Price);
        }

        public void preencher_formulario()
        {
        //Dados do veículo
            var make = "Honda";
            var model = "Motorcycle";
            var cylinder_Capacity = "1833";
            var engine_Performance = "126";
            var date_of_Manufacture = "01/01/2018";
            var number_of_Seats = "2";
            var right_Hand_Drive = "Yes";
            var fuel_Type = "Petrol";
            var payload = "603";
            var total_Weight = "369";
            var list_Price = "29000";
            var license_Plate_Number = "TEST123";
            var annual_Mileage = "20000";

        //Elementos
            SelectElement select_make = new SelectElement(driver.FindElement(By.Id("make")));
            select_make.SelectByText(make);
            
            SelectElement select_model = new SelectElement(driver.FindElement(By.Id("model")));
            select_model.SelectByText(model);
            
            driver.FindElement(By.Id("cylindercapacity")).SendKeys(cylinder_Capacity);
            driver.FindElement(By.Id("engineperformance")).SendKeys(engine_Performance);
            driver.FindElement(By.Id("dateofmanufacture")).SendKeys(date_of_Manufacture);

            SelectElement select_numberofseats = new SelectElement(driver.FindElement(By.Id("numberofseats")));
            select_numberofseats.SelectByText(number_of_Seats);

            if (right_Hand_Drive == "Yes")
            {
                driver.FindElements(By.ClassName("ideal-radiocheck-label"))[0].Click();
            }
            else if (right_Hand_Drive == "No")
            {
                driver.FindElements(By.ClassName("ideal-radiocheck-label"))[1].Click();
            }
            else
            {
                throw new Exception("Opção de Hand Drive inválida. Somente 'Yes' ou 'No'");
            }

            SelectElement select_numberofseatsmotorcycle = new SelectElement(driver.FindElement(By.Id("numberofseatsmotorcycle")));
            select_numberofseatsmotorcycle.SelectByText(number_of_Seats);

            SelectElement select_fuel = new SelectElement(driver.FindElement(By.Id("fuel")));
            select_fuel.SelectByText(fuel_Type);
            
            driver.FindElement(By.Id("payload")).SendKeys(payload);
            driver.FindElement(By.Id("totalweight")).SendKeys(total_Weight);
            driver.FindElement(By.Id("listprice")).SendKeys(list_Price);
            driver.FindElement(By.Id("licenseplatenumber")).SendKeys(license_Plate_Number);
            driver.FindElement(By.Id("annualmileage")).SendKeys(annual_Mileage);

            driver.FindElement(By.Id("nextenterinsurantdata")).Click();
        }

        public void preencher_formulario_insurance_data() 
        {
        //Dados do Solicitante
            var FirstName = "Rodrigo";
            var LastName = "Tani";
            var DateofBirth = "02/08/1997";
            var Gender = "Male";
            var StreetAddress = "Avenida Paulista";
            var Country = "Brazil";
            var ZipCode = "01310100";
            var City = "São Paulo";
            var Occupation = "Employee";
            string[] hobbies = {"Speeding","Bungee Jumping", "Cliff Diving", "Skydiving", "Other"};
            var hobbies_selecionado = hobbies[Hooks.random.Next(0, hobbies.Length)];
            var Website = "Google.com";
            var Picture = "c:/temp/imagem.png";

            driver.FindElement(By.Id("firstname")).SendKeys(FirstName);
            driver.FindElement(By.Id("lastname")).SendKeys(LastName);
            driver.FindElement(By.Id("birthdate")).SendKeys(DateofBirth);

            switch (Gender)
            {
                case "Male":
                    driver.FindElement(By.XPath("//*[@id=\"insurance-form\"]/div/section[2]/div[4]/p/label[1]")).Click();
                    break;
                case "Female":
                    driver.FindElement(By.XPath("//*[@id=\"insurance-form\"]/div/section[2]/div[4]/p/label[2]")).Click();
                    break;
                default:
                    throw new Exception("Opção Gender inválida");
            }

            driver.FindElement(By.Id("streetaddress")).SendKeys(StreetAddress);

            SelectElement select_country = new SelectElement(driver.FindElement(By.Id("country")));
            select_country.SelectByText(Country);

            driver.FindElement(By.Id("zipcode")).SendKeys(ZipCode);
            driver.FindElement(By.Id("city")).SendKeys(City);

            SelectElement select_occupation = new SelectElement(driver.FindElement(By.Id("occupation")));
            select_occupation.SelectByText(Occupation);

            foreach (var hobbie in driver.FindElement(By.CssSelector("div[class='field idealforms-field idealforms-field-checkbox']")).FindElements(By.CssSelector("label")))
            {
                if (hobbie.Text == hobbies_selecionado)
                {
                    hobbie.Click();
                }
            }

            driver.FindElement(By.Id("website")).SendKeys(Website);

            driver.FindElement(By.Id("nextenterinsurantdata")).Click();
        }
    }
}
