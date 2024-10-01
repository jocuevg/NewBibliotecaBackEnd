using FluentValidation;

namespace Biblioteca.Business.Services.Author.Commands.Update;
public class UpdateAuthorValidation : AbstractValidator<UpdateAuthor>
{
    public UpdateAuthorValidation()
    {
        RuleFor(x => x.Nombre).MaximumLength(100).WithMessage("Maximo nombre de 100 caracteres"); 
        RuleFor(x => x.Apellidos).MaximumLength(200).WithMessage("Maximo apellidos de 200 caracteres"); 
        RuleFor(x => x.Edad).GreaterThan(0).WithMessage("Edad debe ser positiva");
    }
}
