using FluentValidation;
using AppFinal.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFinal.Validators
{
    public class GetPersonListValidator : AbstractValidator <GetPersonListRequest>
    {
        public GetPersonListValidator() 
        {
            RuleFor(p => p.FirstName).NotEmpty().NotNull().WithMessage("NOMBRE VACIO O NULO");
        }
    }
}
