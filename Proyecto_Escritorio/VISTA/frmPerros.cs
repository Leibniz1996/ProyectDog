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
    public partial class frmPerros : Form
    {
        ControladorDog control_Dog;
        Controlador control;
        public frmPerros()
        {
            InitializeComponent();
            dtpFechaNacDog.MaxDate = DateTime.Now;
            dtpFechaNacDog.MinDate = DateTime.Today.AddYears(-16);
            control_Dog = new ControladorDog(this);
            control_Dog.presentarTablaDog();
            control = new Controlador(this);
            control.cargarComboRaza();
            cmbSexo.SelectedIndex = 0;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAddDog_Click(object sender, EventArgs e)
        {
            if ((TxtNombreP.Text != "") && (cmbRaza.SelectedItem.ToString() != "") && (txtColor.Text != "") && (TxtPrecio.Text != "") && (TxtOrigen.Text != "") && (rbSi.Checked != false || rbNo.Checked != false))
            {
                    control_Dog.crearPerro();
                    control_Dog = new ControladorDog(this);
                    control_Dog.presentarTablaDog();
                    control_Dog.LimpiarCampos();
            }
            else MessageBox.Show("¿Complete todos los campos?", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void BtnAddRaza_Click(object sender, EventArgs e)
        {
            this.Close();
            frmGestionarRazas or = new frmGestionarRazas();
            or.Show();
            
        }

        private void TxtColor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void TxtOrigen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void TxtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57)

            {

                e.Handled = false;

            }

            else if (e.KeyChar == 8)

            {

                e.Handled = false;

            }

            else if (e.KeyChar == 13)

            {

                e.Handled = false;

            }

            else

            {

                MessageBox.Show("Solo se Aceptan Numeros", "Mensaje del Sistema");

                e.Handled = true;

            }
        }

        private void FrmPerros_Load(object sender, EventArgs e)
        {

        }
    }
}
