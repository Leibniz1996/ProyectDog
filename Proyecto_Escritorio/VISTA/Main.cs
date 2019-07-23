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
using Proyecto_Escritorio.VISTA;
using Proyecto_Escritorio.NEGOCIO;

namespace Proyecto_Escritorio
{
    public partial class frmMain : Form
    {


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public frmMain()
        {
           InitializeComponent();
            if (DatosUsuario.Carg != "Administrador")
            {
                btnDog.Enabled = false;
            }
            else btnDog.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir del Sistema?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            Application.Exit();
        }

        private void BtnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
            
        }

        private void Panel_Titulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void AbrirFormEnPanel<Forms>() where Forms : Form, new()
        {
            Form formulario;
            formulario = panelContenedor.Controls.OfType<Forms>().FirstOrDefault();

            //si el formulario/instancia no existe, creamos nueva instancia y mostramos
            if (formulario == null)
            {
                formulario = new Forms();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelContenedor.Controls.Add(formulario);
                panelContenedor.Tag = formulario;
                formulario.Show();

                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(CloseForms);               
            }
            else
            {
                formulario.BringToFront();                 //si la Formulario/instancia existe, lo traemos a frente
                if (formulario.WindowState == FormWindowState.Minimized)  //Si la instancia esta minimizada mostramos
                {
                    formulario.WindowState = FormWindowState.Normal;
                }
            }
        }

        private void PanelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CloseForms(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["frmArticulos"] == null)
                btnArticulo.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["frmUsuarios"] == null)
                btnUsuario.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["Facturacion"] == null)
                btnFactura.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["frmVacunacion"] == null)
                btnVacunacion.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["frmPerros"] == null)
                btnDog.BackColor = Color.FromArgb(4, 41, 68);
        }
        private void PanelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnLogo_Click(object sender, EventArgs e)
        {
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel<VISTA.frmArticulos>();
            btnArticulo.BackColor = Color.FromArgb(12, 61, 92);
        }

        private void BtnFactura_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel<VISTA.Facturacion>();
            btnFactura.BackColor = Color.FromArgb(12, 61, 92); 
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar Sesión?", "Advertencia", MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            this.Close();
        }

        public void cargarUser(String Rol, String name, String correo)
        {
            lblRol.Text = Rol;
            lbluser.Text = name ;
            lblCorreo.Text = correo;
        }
        private void Timer1_Tick_1(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToLongTimeString();
            lblfecha.Text = DateTime.Now.ToLongDateString();
        }

        private void BtnUsuario_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel<VISTA.frmUsuarios>();
            btnUsuario.BackColor = Color.FromArgb(12, 61, 92);
        }

        private void BtnDog_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel<frmPerros>();
            btnDog.BackColor = Color.FromArgb(12, 61, 92);
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            AbrirFormEnPanel<frmVacunacion>();
            btnVacunacion.BackColor = Color.FromArgb(12, 61, 92);
        }

        private void PanelContenedor_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
