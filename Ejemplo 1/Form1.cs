using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string elem = txtNombre.Text;
            lwElemetos.Items.Add(elem);        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbColorFav.Items.Add("Rojo");
            cbColorFav.Items.Add("Verde");
            cbColorFav.Items.Add("Negro");
        }

        private void btnVerPerfil_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            DateTime fecha = dtnFechaNac.Value;
            //========== OPERADOR TERNIARIO =====================
            string chocolate = chetBoxchocolate.Checked == true ? " Le Gusta el Chocolate" : " Me cae mal...";

            string tipo;
            if (rbtMuggle.Checked)
                tipo = "Muggle ";
            else if (rbtWizard.Checked)
                tipo = "Wizard ";
            else 
                tipo = "squibs ";

            string colorfavorito = cbColorFav.SelectedItem.ToString();
            string numfavorito = lbNumFav.Value.ToString();

            string mesaje = chocolate + " ,es " + tipo + " , su color es " + colorfavorito + " , su numero es: " + numfavorito;
            MessageBox.Show("Nombre: " + nombre + " Fecha: " + fecha + " , " + mesaje);
            
        }
    }
}
