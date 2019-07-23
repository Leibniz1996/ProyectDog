using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Escritorio.VISTA;
using Proyecto_Escritorio.DATOS;

namespace Proyecto_Escritorio.NEGOCIO
{
    class ControladorDog
    {
        private frmPerros formulario_perros;
        private CRUD_Perros datos_perros;
        Dogs dog;

        private frmVacunacion formulario_vacunacion;
        
        public ControladorDog(frmPerros formulario_perros)
        {
            this.formulario_perros = formulario_perros;
            this.datos_perros = new CRUD_Perros();
        }

        public ControladorDog(frmVacunacion formulario_vacunacion)
        {
            this.formulario_vacunacion = formulario_vacunacion;
            this.datos_perros = new CRUD_Perros();
        }

        public void crearPerro()
        {
            datos_perros.Create(getDatosPerro());
        }

        public Dogs getDatosPerro()
        {
            dog = new Dogs();
            dog.nombre_dog = formulario_perros.TxtNombreP.Text;
            dog.cod_raza = datos_perros.searchRaza(formulario_perros.CmbRaza.SelectedItem.ToString()).cod_raza;
            dog.color_dog = formulario_perros.TxtColor.Text;
            dog.precio_dog = Convert.ToDecimal(formulario_perros.TxtPrecio.Text);
            dog.origen_dog = formulario_perros.TxtOrigen.Text;
            dog.sexo_dog = formulario_perros.CmbSexo.SelectedItem.ToString();
            if(formulario_perros.RbSi.Checked == true)
            {
                dog.pedigree = "SI";
            } 
            else dog.pedigree = "NO";
            dog.fecha_nacimiento = Convert.ToDateTime(formulario_perros.DtpFechaNacDog.Value.Date.ToString());
            return dog;
        }

        public void Delete_Dogs(string nom)
        {
            datos_perros.Delete(nom);
        }

        public void presentarTablaDog()
        {
            formulario_perros.DataGridView1.DataSource = datos_perros.Db.Dogs;
            formulario_perros.DataGridView1.Columns[0].HeaderText = "Codigo";
            formulario_perros.DataGridView1.Columns[1].HeaderText = "Nombre";
            formulario_perros.DataGridView1.Columns[2].HeaderText = "Raza";
            formulario_perros.DataGridView1.Columns[3].HeaderText = "Color";
            formulario_perros.DataGridView1.Columns[4].HeaderText = "Precio";
            // formulario_usuario.DGVUsuario.Columns[5].HeaderText = "Contraseña";
         //   formulario_perros.DataGridView1.Columns[5].Visible = false;
            formulario_perros.DataGridView1.Columns[5].HeaderText = "Origen";
            formulario_perros.DataGridView1.Columns[6].HeaderText = "Sexo";
            formulario_perros.DataGridView1.Columns[7].HeaderText = "Pedigree";
            formulario_perros.DataGridView1.Columns[8].HeaderText = "Fecha de Nacimiento";
            formulario_perros.DataGridView1.Columns[9].Visible = false;
        }

        public void presentarTablaDogInVacunacion()
        {
            
            formulario_vacunacion.DgvPerro.DataSource = datos_perros.Db.Dogs;
            formulario_vacunacion.DgvPerro.Columns[0].HeaderText = "Codigo";
            formulario_vacunacion.DgvPerro.Columns[1].HeaderText = "Nombre";
            formulario_vacunacion.DgvPerro.Columns[2].HeaderText = "Raza";
            formulario_vacunacion.DgvPerro.Columns[3].HeaderText = "Color";
            formulario_vacunacion.DgvPerro.Columns[4].HeaderText = "Precio";
            // formulario_usuario.DGVUsuario.Columns[5].HeaderText = "Contraseña";
            //   formulario_perros.DataGridView1.Columns[5].Visible = false;
            formulario_vacunacion.DgvPerro.Columns[5].HeaderText = "Origen";
            formulario_vacunacion.DgvPerro.Columns[6].HeaderText = "Sexo";
            formulario_vacunacion.DgvPerro.Columns[7].HeaderText = "Pedigree";
            formulario_vacunacion.DgvPerro.Columns[8].HeaderText = "Fecha de Nacimiento";
            formulario_vacunacion.DgvPerro.Columns[9].Visible = false;
        }

        public void LimpiarCampos()
        {
            formulario_perros.TxtNombreP.Text = "";
            formulario_perros.CmbRaza.SelectedItem = "";
            formulario_perros.TxtColor.Text ="";
            formulario_perros.TxtPrecio.Text= "";
            formulario_perros.TxtOrigen.Text = "";
            formulario_perros.CmbSexo.SelectedItem = "";
            formulario_perros.RbSi.Checked =false;
            formulario_perros.RbNo.Checked =false;
        }
    }
}
