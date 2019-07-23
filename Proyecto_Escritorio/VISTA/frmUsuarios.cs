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
    public partial class frmUsuarios : Form
    {
        ControladoUsuario control_usuario;
        
       ///DBDogDataContext db = new DBDogDataContext();
        public frmUsuarios()
        {
            InitializeComponent();
            control_usuario = new ControladoUsuario(this);
            control_usuario.presentarTablaUsuario();
            cmbRol.SelectedIndex = 0;
            if(DatosUsuario.Carg != "Administrador")
            {
                txtNombre.Text = DatosUsuario.FirstName;
                txtCedula.Text = DatosUsuario.Cedula;
                txtApellido.Text = DatosUsuario.LastName;
                TxtCorreo.Text = DatosUsuario.Correo;
                txtUser.Text = DatosUsuario.User;
                txtPassword.Text = DatosUsuario.Password;
                TxtCedula.Text = DatosUsuario.Cedula;
                if (DatosUsuario.Carg != "Administrador")
                {
                    cmbRol.SelectedIndex = 2;
                }
                else cmbRol.SelectedIndex = 1;
                              
                btnAddUsu.Enabled = false;
                DGVUsuario.Enabled = false;
                btnDelete.Enabled = false;
                txtCedula.Enabled = false;
                txtNombre.Enabled = false;
                TxtApellido.Enabled = false;
                cmbRol.Enabled = false;
                TxtCorreo.Enabled = false;
            }
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
           
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAgragarRaza_Click(object sender, EventArgs e)
        {
            if ((txtCedula.Text != "") && (txtNombre.Text != "") && (txtApellido.Text != "") && (txtUser.Text != "") && (txtPassword.Text != "") && (cmbRol.SelectedIndex > 0))
            {
                if(txtCedula.TextLength > 9 && txtCedula.TextLength < 11)
                {
                        control_usuario.crearUsuario();
                        control_usuario = new ControladoUsuario(this);
                        control_usuario.presentarTablaUsuario();
                }
                else MessageBox.Show("¿Cedula debe contener 10 digitos?", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else MessageBox.Show("¿Complete todos los campos?", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          }

        private void TxtCedula_KeyPress(object sender, KeyPressEventArgs e)
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
        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void TxtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            DATOS.CRUD_Usuario ou = new DATOS.CRUD_Usuario();
            if ((txtCedula.Text != "") && (txtNombre.Text != "") && (txtApellido.Text != "") && (txtUser.Text != "") && (txtPassword.Text != "") && (cmbRol.SelectedIndex > 0))
            {
                if (txtCedula.TextLength >9 && txtCedula.TextLength < 11)
                {
                        if (ou.searchCedula(txtCedula.Text) != null)
                        {
                            control_usuario.EditUsuario(txtCedula.Text, txtNombre.Text, txtApellido.Text, txtUser.Text, txtPassword.Text, txtCorreo.Text, Convert.ToString(cmbRol.SelectedItem));
                            MessageBox.Show("Usuario Editado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else MessageBox.Show("No se Edito el Usuario", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else MessageBox.Show("¿Cedula debe contener 10 digitos?", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else MessageBox.Show("¿Complete todos los campos?", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DATOS.CRUD_Usuario ou = new DATOS.CRUD_Usuario();
            if (ou.searchCedula(txtCedula.Text) != null)
            {
                control_usuario.DeleteUsuario(txtCedula.Text);
                control_usuario = new ControladoUsuario(this);
                control_usuario.presentarTablaUsuario();
                MessageBox.Show("Usuario Eliminado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Nose Elimino Usuario", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void DGVUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            control_usuario.obtenerDatosDataGrivView();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DGVUsuario_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            control_usuario.obtenerDatosDataGrivView();
        }
    }
}
