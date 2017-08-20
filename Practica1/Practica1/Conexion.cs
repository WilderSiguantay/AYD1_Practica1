using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Practica1
{
    public class Conexion
    {
        SqlConnection conexion = new SqlConnection();

        string mostrarError;

        public string MostrarError
        {
            get { return mostrarError; }
            set { mostrarError = value; }
        }


        public bool ConectarServer()
        {
            bool respuesta = false;
            //JARVIS\SQLEXPRESS
            string cadenaConexion = @"Data Source=DESKTOP-MT7QK0C;Initial Catalog=Practica1;Integrated Security=True";        
            //Data Source=DESKTOP-NG22G5J\SQLEXPRESS;Initial Catalog=PROYECT_1;Integrated Security=True
            try
            {

                conexion.ConnectionString = cadenaConexion;
                conexion.Open();
                respuesta = true;


            }
            catch (Exception ex)
            {
                respuesta = false;
                MostrarError = "No se ha podido conectado con el servidor. Mensaje de la excepción: " + ex.Message.ToString();
            }
            return respuesta;
        }

        public bool Crear(string tabla, string campos, string valores)
        {
            bool respuesta = false;

            try
            {
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexion;
                //INSERT INTO DEPARTAMENTO(nombre_depto) VALUES('Guatemala');
                comando.CommandText = "INSERT INTO " + tabla + "(" + campos + ") VALUES(" + valores + ");";
                if (ConectarServer())
                {
                    if (comando.ExecuteNonQuery() == 1)
                        respuesta = true;
                    else
                        respuesta = false;
                }
                else
                {
                    respuesta = false;
                }
            }
            catch (Exception ex)
            {
                respuesta = false;
                MostrarError = "Mensaje de la excepcion: " + ex.Message.ToString();
            }
            finally
            {
                conexion.Close();
            }
            return respuesta;
        }

    }
}
