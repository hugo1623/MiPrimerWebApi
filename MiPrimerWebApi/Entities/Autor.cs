using MiPrimerWebApi.Migrations.Validaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MiPrimerWebApi.Entities
{
    public class Autor: IValidatableObject
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="EL campo nombre es requerido")]
        [StringLength(maximumLength: 4, ErrorMessage ="El campo {0} no debe tener más de {1} carácteres")]
        //[PrimeraLetraMayuscula]
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

        public int Menor { get; set; }
        public int Mayor { get; set; }
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if(!string.IsNullOrEmpty(Nombre))
            {
                var primeraLetra = Nombre[0].ToString();
                if (primeraLetra != Nombre[0].ToString())
                {
                    yield return new ValidationResult("La primera Letra debe ser Mayuscula",
                        new string[] {nameof(Nombre)});
                }
            }
            if(Menor>Mayor)
            {
                yield return new ValidationResult("Este valor no puede ser más grande que el campo Mayor",
                    new string[] { nameof(Menor)});
            }
        }
    }
}
