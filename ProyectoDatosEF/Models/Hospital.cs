using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoDatosEF.Models
{
    // Dedemos indicar que tabla esta asociada a este modelo
    [Table("HOSPITAL")]
    public class Hospital
    {
        // si vamos a realizar consultas de accion  debemos tener un campo como clave
        [Key]
        [Column("HOSPITAL_COD")]
        public int IdHospital { get; set; }
        [Column("NOMBRE")]
        public string Nombre { get; set; }
        [Column("DIRECCION")]
        public string Direccion { get; set; }
        [Column("TELEFONO")]

        public string Telefono { get; set; }
        [Column("NUM_CAMA")]
        public int Camas { get; set; }

    }
}
