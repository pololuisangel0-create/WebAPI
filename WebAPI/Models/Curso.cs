using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models
{
    public class Curso
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string Grado { get; set; }
        [Range(0, 50)]
        public int CantidaddeVagos { get; set; }

        public int? NivelId { get; set; }
        [ForeignKey(nameof(NivelId))]
        public virtual Nivel Nivel { get; set; }
    }
}
