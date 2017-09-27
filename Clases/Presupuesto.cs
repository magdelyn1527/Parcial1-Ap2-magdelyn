using System.ComponentModel.DataAnnotations;

namespace Entidades

{
    public class Presupuesto
    {
        [Key]
        public int IdPresupuesto{ get; set; }
        public string Fecha { get; set; }
        public string Descripcion { get; set; }
        public int Monto { get; set; }
        
    }
}
