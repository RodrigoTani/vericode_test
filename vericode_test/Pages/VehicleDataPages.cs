using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        public void preencher_formulario()
        {
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

            SelectElement select_make = new SelectElement(driver.FindElement(By.Id("make")));
            select_make.SelectByText(make);
            
            SelectElement select_model = new SelectElement(driver.FindElement(By.Id("model")));
            select_model.SelectByText(model);
            
            driver.FindElement(By.Id("cylindercapacity")).SendKeys(cylinder_Capacity);
            driver.FindElement(By.Id("engineperformance")).SendKeys(engine_Performance);
            driver.FindElement(By.Id("dateofmanufacture")).SendKeys(date_of_Manufacture);

            SelectElement select_numberofseats = new SelectElement(driver.FindElement(By.Id("numberofseatsmotorcycle")));
            select_numberofseats.SelectByText(number_of_Seats);

            //if (right_Hand_Drive == "Yes")
            //{
            //    driver.FindElement(By.Id("righthanddriveyes")).Click();
            //}
            //else if (right_Hand_Drive == "No")
            //{
            //    driver.FindElement(By.Id("righthanddriveno")).Click();
            //}
            //else
            //{

            //}
            
            SelectElement select_fuel = new SelectElement(driver.FindElement(By.Id("fuel")));
            select_fuel.SelectByText(fuel_Type);
            
            driver.FindElement(By.Id("payload")).SendKeys(payload);
            driver.FindElement(By.Id("totalweight")).SendKeys(total_Weight);
            driver.FindElement(By.Id("listprice")).SendKeys(list_Price);
            driver.FindElement(By.Id("licenseplatenumber")).SendKeys(license_Plate_Number);
            driver.FindElement(By.Id("annual_Mileage")).SendKeys(annual_Mileage);

            driver.FindElement(By.Id("nextenterinsurantdata")).Click();
        }
    }
}
