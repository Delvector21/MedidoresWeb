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
    public partial class AgregarPunto : System.Web.UI.Page
    {
        PuntosDAL dal = new PuntosDAL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Calendar1.Visible = false;
            }
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            if (Calendar1.Visible)
            {
                Calendar1.Visible = false;
            }
            else
            {
                Calendar1.Visible = true;
            }
            Calendar1.Attributes.Add("style", "position:absolute");
        }

        private void limpiar()
        {
            codigoTxt.Text = "";
            tipoRbl.SelectedIndex = 0;
            capacidadTxt.Text = "";
            fechaTxt.Text = "";
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            fechaTxt.Text = Calendar1.SelectedDate.ToString("dd/MM/yyyy");
            Calendar1.Visible = false;
        }

        protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
        {
            if (e.Day.IsOtherMonth)
            {
                e.Day.IsSelectable = false;
            }
        }

        protected void ingresarBtn_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                string codigo = codigoTxt.Text.Trim();
                string tipo = tipoRbl.SelectedValue;
                int capacidad = Convert.ToInt32(capacidadTxt.Text.Trim());
                String fecha = fechaTxt.Text.Trim();

                Punto p = new Punto();
                p.codigo = codigo;
                p.tipo = tipo;
                p.capacidad = capacidad;
                p.vidautil = fecha;

                new PuntosDAL().Add(p);

                mensajeLbl.Text = "Punto de carga agregado";
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
                if(dal.GetPunto(codigo) != null)
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
    }
}