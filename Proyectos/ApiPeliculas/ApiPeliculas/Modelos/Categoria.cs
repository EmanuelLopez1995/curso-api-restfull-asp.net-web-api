using System.ComponentModel.DataAnnotations;

namespace ApiPeliculas.Modelos
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; } // hay que ponerle Id para que sea incremental

        [Required]
        public string Nombre { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
