using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1
{
    public partial class Form1 : Form
    {
        Conexion conn = new Conexion();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtIngresos_KeyPress(object sender, KeyPressEventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {

            if(txtNombre != null  || txtApellido != null || txtIngresos != null || cmbEdad != null || cmbSexo != null)
            {

                MessageBox.Show("Campos Vacíos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
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
                
            }


        }
    }
}
