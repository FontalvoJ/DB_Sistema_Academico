using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sistema_Academico
{
    public partial class frm_Matricula : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_guardar_Click(object sender, EventArgs e)
        {
            cls_matricula objMatricula = new cls_matricula();

            string idEstudiante = txt_idestudiante.Text; 
            DateTime fecha = DateTime.Parse(txt_fecha.Text); 
            float subtotal = float.Parse(txt_subtotal.Text); 
            float iva = float.Parse(txt_iva.Text); 
            float total = float.Parse(txt_total.Text); 

           
            objMatricula.fnt_agregar(idEstudiante, fecha, subtotal, iva, total);

            lbl_mensaje.Text = objMatricula.getMensaje();
        }

        protected void btn_guardar_Click1(object sender, EventArgs e)
        {
            cls_matricula objMatricula = new cls_matricula();

            string idEstudiante = txt_idestudiante.Text;
            DateTime fecha = DateTime.Parse(txt_fecha.Text);
            float subtotal = float.Parse(txt_subtotal.Text);
            float iva = float.Parse(txt_iva.Text);
            float total = float.Parse(txt_total.Text);


            objMatricula.fnt_agregar(idEstudiante, fecha, subtotal, iva, total);

            lbl_mensaje.Text = objMatricula.getMensaje();
        }
    }
}