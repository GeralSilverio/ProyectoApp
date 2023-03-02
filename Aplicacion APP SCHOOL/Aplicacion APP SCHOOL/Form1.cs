using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion_APP_SCHOOL
{
    public partial class FormPrincipal : Form
    {
        //------Metodo para guardar el menu vertical----------------------------------
        public void GuardarMenuVertical()
        {

            if (MenuVertical.Width == 164)
            {
                MenuVertical.Width = 50;
            }
            else
            {
                MenuVertical.Width = 164;
            }
        }
        public FormPrincipal()
        {
            InitializeComponent();
        }
        //-----------------------------Boton Salir--------------------------------------------------
        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //----------------------------Boton Controlar Menu Vertical-------------------------------------------------
        private void btnControlMenu_Click_1(object sender, EventArgs e)
        {
            GuardarMenuVertical();
        }

        private void btnLista_Click(object sender, EventArgs e)
        {

        }
    }

   
}
