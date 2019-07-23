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
    public partial class frmPersona : Form
    {
        ControladorCliente oc;
        public frmPersona()
        {
            InitializeComponent();
        }

        private void BtnAgragarRaza_Click(object sender, EventArgs e)
        {
            if ((TxtCed.Text != "") && (TxtNom.Text != "") && (TxtApe.Text != "") && (TxtDirecc.Text != "") && (TxtCelukar.Text != "") && (TxtCorreo.Text != ""))
            {
                if (TxtCed.TextLength > 9 && TxtCed.TextLength < 11)
                {
                    oc.crearCliente();
                }
                else MessageBox.Show("¿Cedula debe contener 10 digitos?", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else MessageBox.Show("¿Complete todos los campos?", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void TxtCed_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
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

        private void TxtNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void TxtApe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void TxtCelukar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
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

        //private void BtnCerrar_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}
    }
}
