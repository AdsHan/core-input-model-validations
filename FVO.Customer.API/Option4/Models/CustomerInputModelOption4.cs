using System;
using System.ComponentModel.DataAnnotations;

namespace FVO.Customer.API.Option4.Models
{
    public class CustomerInputModelOption4
    {
        [Required(ErrorMessage = "O nome do cliente não foi informado.")]
        [StringLength(200, ErrorMessage = "Tamanho máximo do nome é de {1} caracteres.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "A data de aniversário não foi informada.")]
        public DateTime DateBirth { get; set; }

        [RegularExpression(@"(^\d{1,2}).?(\d{3}).?(\d{3})-?(\d{1}|X|x$)", ErrorMessage = "O RG informado não é válido.")]
        public string Rg { get; set; }

        [RegularExpression(@"(^\d{3}\.\d{3}\.\d{3}\-\d{2}$)", ErrorMessage = "O CPF informado não é válido.")]
        public string Cpf { get; set; }
    }
}
