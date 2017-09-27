using System;
using BLL;
using Entidades;

namespace ParcialAp2
{
    public partial class Presupuesto : System.Web.UI.Page
    {
       
      protected void Page_Load(object sender, EventArgs e)
        {
        }
        private Presupuesto Llenar()
        {


            var Presupuesto = new Presupuesto();
            Presupuesto.Fecha = Convert.ToDateTime(TextFecha.Text);
            Presupuesto.Descripcion = TextDescripcion.text;
            Presupuesto.Monto = TextMonto.text;

            return Presupuesto;

        }
    protected void ButtonGuardar_Click(object sender, EventArgs e)
        {
            var Presupuesto = new Presupuesto();
            Presupuesto = Llenar();
            PresupuestoBLL.Guardar(Presupuesto);
        }

        
    }
}
