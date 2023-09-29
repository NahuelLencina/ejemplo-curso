using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploPractica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Persona p1 = new Persona();

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {     
          //  p1.Nombre = txtNombre.Text;
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
           // p1.Telefono = txtTelefono.Text;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            p1.nombre = txtNombre.Text;
            p1.telefono = txtTelefono.Text;
            lwDatos.Items.Add(p1.nombre);
            lwDatos.Items.Add(p1.telefono);

            List<Persona> listaDatos = new List<Persona>();
            listaDatos.Add(p1);

            foreach (Persona persona in listaDatos)
            {
                MessageBox.Show("Nombresss: " + persona.nombre + " CELLLL: " + persona.telefono);
            }

        }
    }
}
