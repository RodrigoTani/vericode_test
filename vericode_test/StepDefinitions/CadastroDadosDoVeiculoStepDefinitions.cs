using System;
using TechTalk.SpecFlow;
using vericode_test.Pages;
using vericode_test.Support;

namespace vericode_test.StepDefinitions
{
    [Binding]
    public class CadastroDadosDoVeiculoStepDefinitions
    {
        VehicleDataPages vehicle = new VehicleDataPages(Hooks.driver);

        [Given(@"que eu esteja logado no site")]
        public void GivenQueEuEstejaLogadoNoSite()
        {
            Hooks.driver.Url = "https://sampleapp.tricentis.com/101/app.php";
        }

        [When(@"estiver no formulário da aba “Enter Vehicle Data”, implementar pelo menos duas validações de campo")]
        public void WhenEstiverNoFormularioDaAbaEnterVehicleDataImplementarPeloMenosDuasValidacoesDeCampo()
        {
            vehicle.validacao_campos();
        }

        [When(@"em seguida preencher os campos faltantes do formulário")]
        public void WhenEmSeguidaPreencherOsCamposFaltantesDoFormulario()
        {
            vehicle.preencher_formulario();
        }

        [Then(@"preencher o formulário da aba “Enter Insurant Data”")]
        public void ThenPreencherOFormularioDaAbaEnterInsurantData()
        {
            vehicle.preencher_formulario_insurance_data();
        }
    }
}
