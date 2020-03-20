using BddDomain.Models;

namespace BddDomain.Services
{
    public class PessoaService
    {
        public bool Add(Pessoa p)
        {
            return ValidateName(p.Name) && ValidateName(p.Email);
        }

        private bool ValidateName(string val)
        {
            return !string.IsNullOrEmpty(val) && val.Length > 3;
        }

        private bool ValidateEmail(string email)
        {
            return !string.IsNullOrEmpty(email) && email.Length > 5 && email.Contains("@");
        }
    }
}
