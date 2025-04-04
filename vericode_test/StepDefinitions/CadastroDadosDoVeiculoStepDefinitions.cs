using System;
using TechTalk.SpecFlow;
using vericode_test.Pages;
using vericode_test.Support;

namespace vericode_test.StepDefinitions
{
    [Binding]
    public class CadastroDadosDoVeiculoStepDefinitions
    {
        [Given(@"que eu esteja logado no site")]
        public void GivenQueEuEstejaLogadoNoSite()
        {
            VehicleDataPages vehicle = new VehicleDataPages(Hooks.driver);
            Hooks.driver.Url = "https://sampleapp.tricentis.com/101/app.php";
            vehicle.preencher_formulario();
        }

        [When(@"estiver no formulário da aba “Enter Vehicle Data”, implementar pelo menos duas validações de campo")]
        public void WhenEstiverNoFormularioDaAbaEnterVehicleDataImplementarPeloMenosDuasValidacoesDeCampo()
        {

        }

        [When(@"em seguida preencher os campos faltantes do formulário")]
        public void WhenEmSeguidaPreencherOsCamposFaltantesDoFormulario()
        {

        }

        [Then(@"preencher o formulário da aba “Enter Insurant Data”")]
        public void ThenPreencherOFormularioDaAbaEnterInsurantData()
        {

        }
    }
}
