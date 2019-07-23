using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Escritorio.NEGOCIO;

namespace Proyecto_Escritorio.VISTA
{
    public partial class frmGestionarRazas : Form
    {
        ControladorRaza control_raza;
        Controlador control;
        public frmGestionarRazas()
        {
            InitializeComponent();
            control_raza = new ControladorRaza(this);
            frmPerros x = new frmPerros();
            control = new Controlador(x);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmGestionarRazas_Load(object sender, EventArgs e)
        {

        }

        private void BtnAgragarRaza_Click(object sender, EventArgs e)
        {
            if (txtRaza.Text != "" )
            {
                control_raza.crearRaza();
                txtRaza.Text = "";
            }
            else MessageBox.Show("¿Complete todos los campos?", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void TxtRaza_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }
    }
}
