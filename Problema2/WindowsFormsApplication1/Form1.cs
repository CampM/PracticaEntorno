using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*********************************
Autor: Moisés Campón García
Fecha creación: 27/03/2016
Última modificación: 2/03/2016
Versión: 1.00
***********************************/

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (tbContraseña.Text == "daw")
            {
                var principal = new Principal();
                principal.Padre = this;
                principal.Show();
                this.Hide();
            }
            else
            {
                lbContrseña.Text = "Contraseña equivocada";
            }
        }

    }
}
