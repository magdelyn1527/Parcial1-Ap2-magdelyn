using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace ParcialAp2.Consultas
{
    public partial class ConsultaPresupuestoWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ConsultaPresupuestoGridView.DataSource = PresupuestoBLL.ListarTodo();
            ConsultaPresupuestoGridView.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}