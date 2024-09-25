using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Core.Models;
public class LibroSummarizedDto
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public int NumeroPaginas { get; set; }
    public int? AutorId { get; set; }
}
