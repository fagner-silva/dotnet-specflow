using TechTalk.SpecFlow;
using FrontEnd.Infra.Webdriver;
using FrontEnd.Steps.Context;
using FrontEnd.Infra.PageObject;
using TechTalk.SpecFlow.Infrastructure;
namespace FrontEnd.Steps.BugBank
{
    [Binding]
    public class LoginStep 
    {
        private readonly ISpecFlowOutputHelper _specFlowOutputHelper;
        LoginPageObject Login = new LoginPageObject();

         [When(@"inserir ""(.*)"" e ""(.*)""")]
         public void QuandoInserirE(string email, string senha)
         {
            Login.UserPassword(email, senha);
         }

         [Then(@"login realizado com sucesso")]
         public void EntaoLoginRealizadoComSucesso()
         {
             Login.BemVindo();
         }
    }
}