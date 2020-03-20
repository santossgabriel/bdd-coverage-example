using BddDomain.Models;
using BddDomain.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace BddDomainTests
{
    [Binding]
    public class PessoaTests
    {
        private PessoaService pessoaService;
        
        [Given("que eu esteja cadastrando um usuário")]
        public void CadastrandoPessoa()
        {
            pessoaService = new PessoaService();
        }        

        [When("eu enviar o nome (.*) e email (.*)")]
        public void EnviarNomeEmail(string name, string email)
        {
            ScenarioContext.Current["Name"] = name; 
            ScenarioContext.Current["Email"] = email;
        }

        [Then(@"vou receber o retorno (.*)")]
        public void Receber(bool check)
        {
            string name = (string)ScenarioContext.Current["Name"];
            string email = (string)ScenarioContext.Current["Email"];
            var sucesso = pessoaService.Add(new Pessoa() { Name = name, Email = email });

            Assert.AreEqual(check, sucesso);
        }
    }
}