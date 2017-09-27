using System.Data.Entity;
using Entidades;

namespace DAL
{
    class SistemaPresupuestoDB: DbContext
    {
       
        public SistemaPresupuestoDB() : base("ConStr")
        {

        }
        public virtual DbSet <Presupuesto> presupuesto{ get; set; }
       

    }
}
    

