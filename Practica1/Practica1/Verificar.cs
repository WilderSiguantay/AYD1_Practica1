using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1
{

    public partial class Verificar : Form
    {
        Conexion conn = new Conexion();
        public Verificar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        [ExcludeFromCodeCoverage]
        public void txtIngresos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Introducir solo numeros", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        [ExcludeFromCodeCoverage]
        private void button1_Click(object sender, EventArgs e)
        {

            
                String nombre, apellido, edad, sexo, ingresos;
                nombre = txtNombre.Text;
                apellido = txtApellido.Text;
                ingresos = txtIngresos.Text;
                edad = cmbEdad.Text;
                if (cmbSexo.Text == "Masculino")
                {
                    sexo = "0";
                }
                else
                {
                    sexo = "1";
                }

            if(txtApellido.Text == "" || txtIngresos.Text == "" || txtNombre.Text == "" || cmbSexo.Text == "" || cmbEdad.Text == "")
            {
                MessageBox.Show("No deje campos vacíos", "Precaución", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                if(VerificarMetodo(nombre, apellido, edad, sexo, ingresos))
                {
                    MessageBox.Show(NombreCompleto(nombre, apellido) + " de Sexo " + cmbSexo.Text + " de edad " + edad + " años, SI cumple con los requisitos para obtener el credito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show(NombreCompleto(nombre, apellido) + " de Sexo " + cmbSexo.Text + " de edad " + edad + " años,  NO cumple con los requisitos para obtener el credito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }


            }

        }

        public bool VerificarMetodo(string nombre, string apellido, string edad, string sexo, string ingresos)
        {
            if (conn.Crear("Persona", "Nombre, Apellido, Edad, Sexo, Ingresos", "'" + nombre + "', '" + apellido + "', " + edad + ", " + sexo + ", " + ingresos))
            {
                MessageBox.Show("Valores guardados exitosamente.");
                if (Convert.ToInt32(edad) >= 18 && Convert.ToInt32(ingresos) >= 7000)
                {
                     txtApellido.Text = "";
                    txtNombre.Text = "";
                    txtIngresos.Text = "";
                    cmbEdad.Text = "";
                    cmbSexo.Text = "";
                    return true;
                }
                else
                {
                     return false;
                }
                
            }
            else
            {
                MessageBox.Show("Error al guardar datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }

        public String NombreCompleto(string nombre, string apellido)
        {
            return nombre + " " + apellido;

        }
    }
}
