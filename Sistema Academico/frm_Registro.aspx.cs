using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sistema_Academico
{
    public partial class frm_Registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_nuevo_Click(object sender, EventArgs e)
        {

        }

        protected void btn_guardar_Click(object sender, EventArgs e)
        {
            // Instanciamos la clase cls_estudiante
            cls_estudiante objEstudiante = new cls_estudiante();

            // Variables para almacenar valores
            string id = txt_id.Text;
            string nombre = txt_nombre.Text;
            string contacto = txt_contacto.Text;
            string correo = txt_correo.Text;
            string direccion = txt_direccion.Text;
            string acudiente = txt_acudiente.Text;

            // Intentamos convertir los valores de estrato y sexo a enteros
            if (int.TryParse(ddl_estrato.SelectedValue, out int estrato) && int.TryParse(ddl_sexo.SelectedValue, out int sexo))
            {
                string observaciones = txt_observacion.Text;

                // Llamamos al método fnt_agregar con los parámetros correctos
                objEstudiante.fnt_agregar(id, nombre, contacto, correo, direccion, acudiente, estrato, sexo, observaciones);

                // Actualizamos el mensaje de respuesta
                lbl_mensaje.Text = objEstudiante.getMensaje();
            }
            else
            {
                lbl_mensaje.Text = "Error: Los valores de estrato y sexo no son números enteros válidos.";
            }
        }

    }
}