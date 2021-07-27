using MedidoresDAL.DAL;
using MedidoresDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MedidoresWeb
{
    public partial class VerEstaciones : System.Web.UI.Page
    {

        EstacionesDAL dal = new EstacionesDAL();

        private void CargarTabla(List<Estacion> estaciones)
        {
            estacionesGrid.DataSource = estaciones;
            estacionesGrid.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarTabla(dal.GetAll());
            }

        }

        protected void estacionesGrid_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "eliminar")
            {
                string codigoAeliminar = e.CommandArgument.ToString();
                dal.Delete(codigoAeliminar);
                CargarTabla(dal.GetAll());
            }
        }
    }
}