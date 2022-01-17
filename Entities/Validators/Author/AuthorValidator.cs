using Entities.Validators.Book;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Validators.Author
{
    public class AuthorValidator : AbstractValidator<Entities.Models.Author>
    {
        public AuthorValidator()
        {
            //Validaciones del Campo Author cada uno en una clase
            Include(new AuthorIsOver18());
            Include(new LastNameIsNotInBlackList());

            //Util cuando tenemos objetos complejos (mucho campos) y no queremos validar todos
            RuleSet("FirstName", () =>
            {
                RuleFor(a => a.FirstName).NotEqual(a => a.LastName);
                RuleFor(a => a.FirstName).Length(2, 15);
            });

            //Validar una regla cuando se cumpla cierta condición
            RuleFor(a => a.PuestoBestWriter).GreaterThan(3).When(a => a.BestWriter);


            //Validar objetos Complejos Author.Book
            RuleFor(a => a.BestBook).SetValidator(new BookValidator());
            //Another way, without other class
            //RuleFor(a => a.BestBook.Title).NotEmpty().Length(3, 20);

            //Validate Collection
            RuleForEach(a=>a.Books).SetValidator(new BookValidator());
            //RuleForEach(a => a.Books).ChildRules(b =>
            //{
            //    b.RuleFor(b => b.Title).NotEmpty().Length(3, 10);
            //});
        }
    }
}
