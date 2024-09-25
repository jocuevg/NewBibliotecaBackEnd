using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Business.Services.Books.Commands.Update;
public class UpdateLibroValidation  :AbstractValidator<UpdateLibro>
{
    public UpdateLibroValidation() {
        RuleFor(x => x.Nombre).MaximumLength(100).WithMessage("Maximo nombre de 100 caracteres");
        RuleFor(x => x.NumeroPaginas).GreaterThan(0).WithMessage("El número de páginas debe ser positivo");
    }
}
