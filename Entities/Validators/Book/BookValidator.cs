using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Validators.Book
{
    public class BookValidator : AbstractValidator<Entities.Models.Book>
    {
        public BookValidator()
        {
            RuleFor(b=>b.Title).NotEmpty().Length(3,20);

            RuleSet("Collection", () =>
            {
                RuleFor(b => b.Title).NotEmpty().Length(3, 10);
            });
        }
    }
}
