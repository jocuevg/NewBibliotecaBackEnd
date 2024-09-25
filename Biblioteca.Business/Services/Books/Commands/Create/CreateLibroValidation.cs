using FluentValidation;

namespace Biblioteca.Business.Services.Books.Commands.Create;
public class CreateLibroValidation : AbstractValidator<CreateLibro>
{
    public CreateLibroValidation()
    {
        RuleFor(x => x.Nombre).MaximumLength(100).WithMessage("Maximo nombre de 100 caracteres");
        RuleFor(x => x.NumeroPaginas).GreaterThan(0).WithMessage("El número de páginas debe ser positivo");
    }
}
