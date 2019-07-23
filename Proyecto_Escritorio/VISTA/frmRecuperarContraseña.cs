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
    public partial class frmRecuperarContraseña : Form
    {
        Controlador oc;
        public frmRecuperarContraseña()
        {
            InitializeComponent();
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            oc = new Controlador(this);
            var result = oc.recuperarContra(txtsolicitud.Text);
            lblRespuesta.Text = result;
        }

        private void FrmRecuperarContraseña_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }
    }
}
