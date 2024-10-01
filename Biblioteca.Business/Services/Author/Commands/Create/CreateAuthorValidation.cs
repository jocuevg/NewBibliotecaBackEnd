using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Business.Services.Author.Commands.Create;
public class CreateAuthorValidation : AbstractValidator<CreateAuthor>
{
    public CreateAuthorValidation() {
        RuleFor(x => x.Nombre).MaximumLength(100).WithMessage("Maximo nombre de 100 caracteres"); 
        RuleFor(x => x.Apellidos).MaximumLength(200).WithMessage("Maximo apellidos de 200 caracteres"); 
        RuleFor(x => x.Edad).GreaterThan(0).WithMessage("Edad debe ser positiva");
    }
}
