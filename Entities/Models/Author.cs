using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
////Author, Books. En author si es BestWriter (bool), el campo puesto de Best Writer debe ser especificado

//que su Fisrty sea duferebnte a Kastname

//Utilizar una clase por Campo Validado y luego agruparlos en una cklase de ka entidad
namespace Entities.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public bool BestWriter { get; set; }
        public int? PuestoBestWriter { get; set; }

        public Book BestBook { get; set; }
        public List<Book> Books { get; set; }
    }
}
