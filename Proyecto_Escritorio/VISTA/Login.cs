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


namespace Proyecto_Escritorio.VISTA
{
    public partial class frmLogin : Form
    {
        NEGOCIO.Controlador control = new NEGOCIO.Controlador();
        public frmLogin()
        {
            InitializeComponent();
            lblError.Visible = false;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wwmsg,
            int wparam, int lparam);

        private void Login_Load(object sender, EventArgs e)
        {
          
        }
        
        private void Button1_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "USUARIO")
            {
                if (txtPassword.Text != "CONTRASEÑA")
                {
                    if (control.conexUser(txtUsuario.Text) != null)
                    {
                        if (control.conexUser(txtUsuario.Text).user_name == txtUsuario.Text && control.conexUser(txtUsuario.Text).password == txtPassword.Text)
                        {
                            AsignarValores();
                            frmMain main = new frmMain();
                            main.Show();
                            this.Hide();
                            main.FormClosed += Logout;
                            main.cargarUser(NEGOCIO.DatosUsuario.Carg, NEGOCIO.DatosUsuario.FirstName + " " + NEGOCIO.DatosUsuario.LastName, NEGOCIO.DatosUsuario.Correo);
                        }
                        else
                            MessageError("Datos Erroneos");
                    }
                    else MessageError("Datos Erroneos");
                }
                else MessageError("Porfavor Ingrese Contraseña");
            }
            else MessageError("Porfavor Ingrese Nombre de Usuario");
        }

        public void AsignarValores()
        {
            NEGOCIO.DatosUsuario.IdUser = control.conexUser(txtUsuario.Text).user_Id;
            NEGOCIO.DatosUsuario.FirstName = control.conexUser(txtUsuario.Text).nombre_usuario;
            NEGOCIO.DatosUsuario.LastName = control.conexUser(txtUsuario.Text).apellido_usuario;
            NEGOCIO.DatosUsuario.Carg = control.conexUser(txtUsuario.Text).rol;
            NEGOCIO.DatosUsuario.Correo = control.conexUser(txtUsuario.Text).correoE;
            NEGOCIO.DatosUsuario.User = control.conexUser(txtUsuario.Text).user_name;
            NEGOCIO.DatosUsuario.Cedula = control.conexUser(txtUsuario.Text).cedula_usuario;
            NEGOCIO.DatosUsuario.Password = control.conexUser(txtUsuario.Text).password;
        }

        public void MessageError(String message)
        {
            lblError.Text = "      " + message;
            lblError.Visible = true;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void TxtUsuario_Enter(object sender, EventArgs e)
        {
           if( txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.LightGray;
                
            }
            lblError.Visible = false;
        }

        private void TxtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.DimGray;
                
            }
            lblError.Visible = false;
        }

        private void TxtPassword_Enter(object sender, EventArgs e)
        {
            if(txtPassword.Text == "CONTRASEÑA")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.LightGray;
                txtPassword.UseSystemPasswordChar = true;
                
            }
            lblError.Visible = false;
        }

        private void TxtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "CONTRASEÑA";
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.ForeColor = Color.DimGray;   
            }
            lblError.Visible = false;
        }

        private void FrmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public void Logout(object sender, FormClosedEventArgs e)
        {
            txtUsuario.Text = "USUARIO";
            txtPassword.UseSystemPasswordChar = false;
            txtUsuario.ForeColor = Color.DimGray;
            txtPassword.Text = "CONTRASEÑA";
            txtPassword.ForeColor = Color.DimGray;
            lblError.Visible = false;
            this.Show();
        }

        private void LinkPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var recuperar = new frmRecuperarContraseña();
            recuperar.ShowDialog();
            
        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
