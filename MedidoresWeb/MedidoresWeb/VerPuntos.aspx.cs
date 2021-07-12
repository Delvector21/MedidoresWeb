using Medidores_DAL.DAL;
using Medidores_DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MedidoresWeb
{
    public partial class VerPuntos : System.Web.UI.Page
    {
        PuntosDAL dal = new PuntosDAL();

        private void CargarTabla(List<Punto> puntos)
        {
            puntosGrid.DataSource = puntos;
            puntosGrid.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarTabla(dal.GetAll());
            }
        }

        protected void puntosGrid_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "eliminar")
            {
                string codigoEliminar = e.CommandArgument.ToString();
                dal.Delete(codigoEliminar);
                CargarTabla(dal.GetAll());
            }

            //if (e.CommandName == "editar")
           
        }

        protected void tipoDdl_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(3000);
            string tipoSel = tipoDdl.SelectedValue;
            List<Punto> filtrada = dal.Filtrar(tipoSel);
            CargarTabla(filtrada);
        }

        protected void todosChx_CheckedChanged(object sender, EventArgs e)
        {
            tipoDdl.Enabled = !todosChx.Checked;
            if (todosChx.Checked)
            {
                CargarTabla(dal.GetAll());
            }
        }

    }
}