using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;
using MedidoresDAL;
using MedidoresDAL.DAL;

namespace MedidoresWeb
{
    public partial class AgregarEstacion : System.Web.UI.Page
    {
        EstacionesDAL dal = new EstacionesDAL();
       

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) //no viene de una petición POST
            {
                List<Region> regiones = new RegionesDAL().GetRegiones();
                regionesDdl.DataSource = regiones;
                regionesDdl.DataTextField = "Nombre";
                regionesDdl.DataValueField = "Codigo";
                regionesDdl.DataBind();


            }
        }

        protected void ingresarBtn_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                string codigo = codigoTxt.Text.Trim();
                string direccion = direccionTxt.Text.Trim();
                string ciudad = ciudadTxt.Text.Trim();
                int capacidad = Convert.ToInt32(capacidadTxt.Text.Trim());
                string region = regionesDdl.SelectedValue;

                Estacion esta = new Estacion();
                esta.codigo = codigo;
                esta.direccion = direccion;
                esta.ciudad = ciudad;
                esta.capacidad = capacidad;
                esta.region = region;

                new EstacionesDAL().Add(esta);

                mensajeLbl.Text = "Estacion Ingresada";
                limpiar();
    }
        }

        protected void codigoCV_ServerValidate(object source, ServerValidateEventArgs args)
        {
            string codigo = codigoTxt.Text.Trim();

            if (codigo == string.Empty)
            {
                codigoCV.ErrorMessage = "Debe ingresar un Codigo";
                args.IsValid = false;
            }
            else
            {
                if (dal.GetEstacion(codigo) != null)
                {
                    codigoCV.ErrorMessage = "El Codigo ya esta en uso";
                    args.IsValid = false;
                }
                else
                {
                    args.IsValid = true;
                }
            }
        }

        private void limpiar()
        {
            codigoTxt.Text = "";
            direccionTxt.Text = "";
            ciudadTxt.Text = "";
            capacidadTxt.Text = "";

        }
    }
}