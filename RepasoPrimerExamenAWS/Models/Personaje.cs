using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RepasoPrimerExamenAWS.Models
{
    [Table("PERSONAJES")]
    public class Personaje
    {
        [Key]
        [Column("IDPERSONAJE")]
        public int IdPersonajes { get; set; }
        [Column("PERSONAJE")]
        public string Nombre { get; set; }
        [Column("IMAGEN")]
        public string Imagen { get; set; }
    }
}
