using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Validators.Author
{
    public class AuthorIsOver18 : AbstractValidator<Entities.Models.Author>
    {
        public AuthorIsOver18()
        {
            RuleFor(author => author.Age)
    .Must(IsOver18)
    .WithMessage("El autor debe ser mayor a 18 años");
        }

        private bool IsOver18(int Age)
        {
            return Age >= 18;
        }
    }
}
