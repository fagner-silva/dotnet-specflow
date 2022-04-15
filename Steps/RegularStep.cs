using TechTalk.SpecFlow;
using FrontEnd.Infra.Webdriver;
using FrontEnd.Steps.Context;

namespace FrontEnd.Steps
{
    [Binding]
    public class RegularStep : BaseStep
    {
        public RegularStep(BaseContext baseContext):base(baseContext){}

        [Given(@"que estou na pagina inicial da BugBank")]
        public void DadoQueEstouNaPaginaInicialDaBugBank()
        {
            Browser.WebDriver.Navigate().GoToUrl(baseContext.configuration["BUGBANK:URL"]);
        }
        
    }
}