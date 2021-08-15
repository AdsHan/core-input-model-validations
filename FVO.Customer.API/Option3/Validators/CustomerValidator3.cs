using FluentValidation;
using FVO.Customer.API.Extensions;
using FVO.Customer.API.Option3.Models;
using System;

namespace FVO.Customer.API.Option3.Validators
{
    public class CustomerValidator3 : AbstractValidator<CustomerInputModelOption3>
    {
        public CustomerValidator3()
        {
            RuleFor(c => c.Name)
                .NotEmpty()
                .WithMessage("O nome do cliente não foi informado.");

            RuleFor(c => c.Name)
                .MaximumLength(200)
                .WithMessage("Tamanho máximo do nome é de 200 caracteres.");

            RuleFor(c => c.DateBirth)
                .Must(p => !(p == DateTime.MinValue))
                .WithMessage("A data de aniversário não foi informada.");

            RuleFor(c => c.Cpf)
                .Must(c => StringExtensions.ValidateCPF(c))
                .WithMessage("O CPF informado não é válido.");

            RuleFor(c => c.Rg)
                .Must(c => StringExtensions.ValidateRG(c))
                .WithMessage("O RG informado não é válido.");
        }
    }
}
