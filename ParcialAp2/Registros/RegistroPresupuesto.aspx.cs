using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Entidades;
using Ap2Parcial;

namespace ParcialAp2
{
    public partial class RegistroPresupuesto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.TextFecha.Text = string.Format("{0:G}", DateTime.Now);
        }
        private Presupuesto Llenar()
        {

            Presupuesto presupuesto = new Presupuesto();
            presupuesto.Fecha = Convert.ToDateTime(TextFecha.Text);
            presupuesto.Descripcion = TextDescripcion.Text;
            presupuesto.Monto = Convert.ToInt16(TextMonto.Text);

            return presupuesto;
        }


        protected void ButtonGuardar_Click(object sender, EventArgs e)
        {
            var Presupuesto = new Presupuesto();
            Presupuesto = Llenar();
            PresupuestoBLL.Guardar(Presupuesto);
        }

        protected void ButtonEliminar_Click(object sender, EventArgs e)
        {
            int id = Utilidades.ToInt(TextId.Text);
            Presupuesto presupuesto = PresupuestoBLL.Buscar(p => p.IdPresupuesto == id);

            if (presupuesto != null)
            {

              if (presupuesto.IdPresupuesto != 1)
                {
                    PresupuestoBLL.Eliminar(presupuesto);

                }
            }
        }

        protected void ButtonNuevo_Click(object sender, EventArgs e)
        {
            int id = Utilidades.ToInt(TextId.Text);
            Presupuesto presupuesto = PresupuestoBLL.Buscar(p => p.IdPresupuesto == id);

            if (presupuesto != null)
            {
                TextDescripcion.Text = presupuesto.Descripcion;
                TextMonto.Text = presupuesto.Monto.ToString();
            }
        }

        protected void ButtonCrear_Click(object sender, EventArgs e)
        {
            TextId.Text = "";
            TextDescripcion.Text = "";
            TextMonto.Text = "";
        }
    }
}