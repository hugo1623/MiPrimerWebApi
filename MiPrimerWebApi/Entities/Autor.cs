using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MiPrimerWebApi.Entities
{
    public class Autor
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="EL campo nombre es requerido")]
        [StringLength(maximumLength: 4, ErrorMessage ="El campo {0} no debe tener más de {1} carácteres")]
        public string Nombre { get; set; }
        [Range(18,120)] 
        [NotMapped]
        public int Edad { get; set; }
        [CreditCard]
        [NotMapped]
        public string TarjetDeCredito { get; set; }
        [Url]
        [NotMapped]
        public string  URL { get; set; }
        public List<Libro> Libros { get; set; }
    }
}
