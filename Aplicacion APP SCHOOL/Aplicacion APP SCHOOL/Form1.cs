using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Aplicacion_APP_SCHOOL
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }
        //-------------------------------------------------------------------------------------------------------------------
        
            //------Metodo para guardar el menu vertical Funcionado----------------------------------
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
        //-------------------Metodo Para abrir las ventanas Funcionando--------------------------------
        private void AbrirVentana(object FormHijo)
        {
            if (this.PanelPrincipal.Controls.Count > 0)
                this.PanelPrincipal.Controls.RemoveAt(0);
            Form fh = FormHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelPrincipal.Controls.Add(fh);
            this.PanelPrincipal.Tag = fh;
            fh.Show();
        }
 
        //-----------------------------Boton Salir Funcionado--------------------------------------------------
        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //----------------------------Boton Controlar Menu Vertical Funcionando-------------------------------------------------
        private void btnControlMenu_Click_1(object sender, EventArgs e)
        {
           GuardarMenuVertical();
        }
        
        //------------------Boton ir a Registro Funcionando----------------------------
        private void btnRegistro_Click(object sender, EventArgs e)
        {
            AbrirVentana(new Registro());
        }


      





    
        private void btnLista_Click(object sender, EventArgs e)
        {
            
        }

        private void btnPrincipal_Click(object sender, EventArgs e)
        {
            
           AbrirVentana(new Inicio());
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            btnPrincipal_Click(null, e);
        }
    }


}
