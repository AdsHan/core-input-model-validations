using FluentValidation.Results;
using System;

namespace FVO.Customer.API.Option1.Models
{
    public class BaseInputModel
    {
        public ValidationResult ValidationResult { get; set; }

        protected BaseInputModel()
        {
            ValidationResult = new ValidationResult();
        }

        public virtual bool Validate()
        {
            throw new NotImplementedException();
        }
    }
}
