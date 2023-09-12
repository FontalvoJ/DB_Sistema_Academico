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
          
            cls_estudiante objEstudiante = new cls_estudiante();

          
            string id = txt_id.Text;
            string nombre = txt_nombre.Text;
            string contacto = txt_contacto.Text;
            string correo = txt_correo.Text;
            string direccion = txt_direccion.Text;
            string acudiente = txt_acudiente.Text;

          
            if (int.TryParse(ddl_estrato.SelectedValue, out int estrato) && int.TryParse(ddl_sexo.SelectedValue, out int sexo))
            {
                string observaciones = txt_observacion.Text;

                
                objEstudiante.fnt_agregar(id, nombre, contacto, correo, direccion, acudiente, estrato, sexo, observaciones);

                
                lbl_mensaje.Text = objEstudiante.getMensaje();
            }
            else
            {
                lbl_mensaje.Text = "Error: Los valores de estrato y sexo no son números enteros válidos.";
            }
        }

        protected void btn_consultar_Click(object sender, EventArgs e) {

            // Obtener el ID del estudiante desde un control de entrada (por ejemplo, un TextBox)
            string idEstudiante = txt_id.Text;

            // Crear una instancia de la clase cls_estudiante
            cls_estudiante objEstudiante = new cls_estudiante();

            // Llamar al método fnt_consultar para obtener los datos del estudiante
            objEstudiante.fnt_consultar(idEstudiante);


            // Mostrar los datos en los controles de tu formulario
            txt_nombre.Text = objEstudiante.getNombre();
            txt_contacto.Text = objEstudiante.getContacto();
            txt_correo.Text = objEstudiante.getCorreo();
            txt_direccion.Text = objEstudiante.getDireccion();
            txt_acudiente.Text = objEstudiante.getAcudiente();

            // Configurar el valor seleccionado en las listas desplegables
            ddl_sexo.SelectedValue = objEstudiante.getSexo().ToString();
            ddl_estrato.SelectedValue = objEstudiante.getEstrato().ToString();

            txt_observacion.Text = objEstudiante.getObservaciones();

            // Puedes mostrar un mensaje de éxito o error en una etiqueta o MessageBox
            lbl_mensaje.Text = objEstudiante.getMensaje();


        }
    }
}