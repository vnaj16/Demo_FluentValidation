using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Validators.Author
{
    public class LastNameIsNotInBlackList : AbstractValidator<Entities.Models.Author>
    {
        public LastNameIsNotInBlackList()
        {
            List<string> blackListWords = new List<string>() { "Valladares", "Nole" };
            RuleFor(a => a.LastName).Must(name => !blackListWords.Contains(name));
        }
    }
}
