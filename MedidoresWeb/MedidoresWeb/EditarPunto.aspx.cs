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
    public partial class EditarPunto : System.Web.UI.Page

    {
        PuntosDAL dal = new PuntosDAL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Calendar1.Visible = false;
                String codigo = Request.QueryString["Codigo"];
                codigoTxt.Text = codigo;
                Punto p = dal.GetPunto(codigo);
                capacidadTxt.Text = p.Capacidad.ToString();
                fechaTxt.Text = p.Vidautil;
                tipoRbl.SelectedValue = p.Tipo.ToString();


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
                p.Codigo = codigo;
                p.Tipo = tipo;
                p.Capacidad = capacidad;
                p.Vidautil = fecha;

                new PuntosDAL().Editar(p);
               
               
                Response.Redirect("VerPuntos.aspx");
               

            }
        }

        
    }
}