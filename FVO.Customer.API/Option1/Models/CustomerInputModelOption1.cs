using FluentValidation;
using FVO.Customer.API.Extensions;
using System;

namespace FVO.Customer.API.Option1.Models
{
    public class CustomerInputModelOption1 : BaseInputModel
    {
        public string Name { get; set; }
        public DateTime DateBirth { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }

        public override bool Validate()
        {
            ValidationResult = new CustomerInputModelOption1Validation().Validate(this);
            return ValidationResult.IsValid;
        }

        public class CustomerInputModelOption1Validation : AbstractValidator<CustomerInputModelOption1>
        {
            public CustomerInputModelOption1Validation()
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
}
