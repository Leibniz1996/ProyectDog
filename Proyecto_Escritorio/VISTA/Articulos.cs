using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Escritorio.VISTA
{
    public partial class frmArticulos : Form
    {
        public frmArticulos()
        {
            InitializeComponent();
        }

        private void Articulos_Load(object sender, EventArgs e)
        {
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var gestion = new frmCategoriaArticulo();
            gestion.ShowDialog();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
