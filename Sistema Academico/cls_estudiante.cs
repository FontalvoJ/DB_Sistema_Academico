using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Drawing;

namespace Sistema_Academico
{
    public class cls_estudiante
    {
        private string str_mensaje;
        private string str_nombre;
        private string str_contacto;
        private string str_correo;
        private string str_direccion;
        private string str_acudiente;
        private int int_estrato;
        private int int_sexo;
        private string str_observaciones;

        public void fnt_agregar(string id, string nombre, string contacto, string correo, string direccion, string acudiente, int estrato, int sexo, string observaciones)
        {
            try
            {
                cls_conexion objConecta = new cls_conexion();
                SqlCommand con = new SqlCommand("sp_registrarestudiante", objConecta.connection);
                con.CommandType = CommandType.StoredProcedure;
                con.Parameters.AddWithValue("@id", id);
                con.Parameters.AddWithValue("@nombre", nombre);
                con.Parameters.AddWithValue("@contacto", contacto);
                con.Parameters.AddWithValue("@correo", correo);
                con.Parameters.AddWithValue("@direccion", direccion);
                con.Parameters.AddWithValue("@acudiente", acudiente);
                con.Parameters.AddWithValue("@fkcodigo_estrato", estrato);
                con.Parameters.AddWithValue("@fkcodigo_sexo", sexo);
                con.Parameters.AddWithValue("@observaciones", observaciones);
                objConecta.connection.Open();
                con.ExecuteNonQuery();
                objConecta.connection.Close();
                str_mensaje = "Registro exitoso";
            }
            catch (Exception ex)
            {
                str_mensaje = "Error: " + ex.Message;
            }


        }


        public void fnt_consultar(string id)
        {
            try
            {
                cls_conexion objConecta = new cls_conexion();
                SqlCommand cmd = new SqlCommand("sp_consultarestudiante", objConecta.connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                objConecta.connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    // Llena los campos de la instancia con los datos obtenidos
                    this.str_nombre = reader["nombre"].ToString();
                    this.str_contacto = reader["contacto"].ToString();
                    this.str_correo = reader["correo"].ToString();
                    this.str_direccion = reader["direccion"].ToString();
                    this.str_acudiente = reader["acudiente"].ToString();
                    this.int_estrato = Convert.ToInt32(reader["fkcodigo_estrato"]);
                    this.int_sexo = Convert.ToInt32(reader["fkcodigo_sexo"]);
                    this.str_observaciones = reader["observaciones"].ToString();
                    str_mensaje = "Consulta exitosa";
                }
                else
                {
                    str_mensaje = "Estudiante no encontrado";
                }

                reader.Close();
                objConecta.connection.Close();
            }
            catch (Exception ex)
            {
                str_mensaje = "Error: " + ex.Message;
            }
        }




        public string getMensaje() { return this.str_mensaje;}
        public string getNombre() { return this.str_nombre; }
        public string getContacto() { return this.str_contacto; }
        public string getCorreo() { return this.str_correo; }
        public string getDireccion() { return this.str_direccion; }
        public string getAcudiente() { return this.str_acudiente; }
        public int getEstrato() { return this.int_estrato; }
        public int getSexo() { return this.int_sexo;}
        public string getObservaciones() { return this.str_observaciones; }
    }
}