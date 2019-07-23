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
    public partial class frmVacunacion : Form
    {
        ControladorVacuna control_vacuna;
        ControladorDog control_perro;
        Controlador control;
       public frmVacunacion()
        {
            InitializeComponent();
            control_vacuna = new ControladorVacuna(this);
            control_vacuna.presentarTablaUsuario();
            control_perro = new ControladorDog(this);
            control_perro.presentarTablaDogInVacunacion();
            control = new Controlador(this);
            control.cargarComboVacunacion();
            if (DatosUsuario.Carg != "Administrador")
            {
                btnAgragarVacuna.Enabled = false;
                txtNomVacuna.Enabled = false;
                BtnDelete.Enabled = false;
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAgragarRaza_Click(object sender, EventArgs e)
        {
            if (txtNomVacuna.Text != "")
            {

                    control_vacuna.crearVacuna();
                TxtNomVacuna.Text = "";
                    control_vacuna = new ControladorVacuna(this);
                    control_vacuna.presentarTablaUsuario();
                control = new Controlador(this);
                control.cargarComboVacunacion();
            }
            else MessageBox.Show("¿Complete todos los campos?", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DATOS.CRUD_Vacuna ou = new DATOS.CRUD_Vacuna();
            if (ou.searchVacuna(txtNomVacuna.Text) != null)
            {
                control_vacuna.DeleteVacuna(txtNomVacuna.Text);
                control_vacuna = new ControladorVacuna(this);
                control_vacuna.presentarTablaUsuario();
                TxtNomVacuna.Text = "";
                control = new Controlador(this);
                control.cargarComboVacunacion();
                MessageBox.Show("Vacuna Eliminada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Nose Elimino Vacuna", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void DgvVacunas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            control_vacuna.obtenerDatosDataGrivView();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if ((TxtPerro.Text != "") && (cmbVacuna.SelectedItem.ToString() != "") )
            {
                    control_vacuna.crearVacuna();
                    control_perro = new ControladorDog(this);
                    control_perro.presentarTablaDogInVacunacion();
                    control_perro.LimpiarCampos();
            }
            else MessageBox.Show("¿Complete todos los campos?", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void DgvPerro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            control_vacuna.obtenerDatosDataGrivViewPerro();
        }
    }
}
