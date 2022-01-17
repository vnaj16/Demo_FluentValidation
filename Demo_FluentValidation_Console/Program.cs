// See https://aka.ms/new-console-template for more information

using Entities.Models;
using Entities.Validators.Author;
using FluentValidation;
using FluentValidation.Results;

Author Author = new Author()
{
    Age = 10,
    BestBook = new()
    {

    }
};
AuthorValidator AuthorValidator = new AuthorValidator();
//ValidationResult result = AuthorValidator.Validate(Author);//VALIDA TODAS LAS REGLAS, SI HAY RULE SETS, EVALUA LOS QUE NO ESTÁN EN UNO
ValidationResult result = AuthorValidator.Validate(Author, options => options.IncludeAllRuleSets());//VALIDA TODOS, EST'EN O NO EN UN RULESET
//ValidationResult result = AuthorValidator.Validate(Author, options => options.IncludeRuleSets("FirstName")); //VALIDA SOLO LAS REGLAS DEL RULE SET FirstName
if (!result.IsValid)
{
    foreach (var item in result.Errors)
    {
        Console.WriteLine($"Error: {item.ErrorMessage}");
    }
}

Console.ReadKey();
