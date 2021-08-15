using System.Text.RegularExpressions;

namespace FVO.Customer.API.Extensions
{
    public static class StringExtensions
    {

        public static bool ValidateRG(string rg)
        {
            var regex = new Regex(@"(^\d{1,2}).?(\d{3}).?(\d{3})-?(\d{1}|X|x$)");
            return regex.IsMatch(rg);
        }

        public static bool ValidateCPF(string cpf)
        {
            var regex = new Regex(@"(^\d{3}\.\d{3}\.\d{3}\-\d{2}$)");
            return regex.IsMatch(cpf);
        }

    }
}
