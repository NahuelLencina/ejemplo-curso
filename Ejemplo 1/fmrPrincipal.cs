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
    public partial class fmrPrincipal : Form
    {
        public fmrPrincipal()
        {
            InitializeComponent();
        }

        private void perfilPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //EVALUAR SI YA HAY VENTANAS ABIERTAS

            foreach (var item in Application.OpenForms)
            { 
                if(item.GetType () == typeof(Form1))
                {
                    return;
                }
            }
            
            Form1 ventana = new Form1();
            ventana.MdiParent = this;
            ventana.Show(); // Este Permite que podamos abrir mucha veces la misma ventana. 
         // ventana.ShowDialog();       
        }
    }
}
