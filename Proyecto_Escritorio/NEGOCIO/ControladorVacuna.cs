
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Escritorio.VISTA;
using Proyecto_Escritorio.DATOS;

namespace Proyecto_Escritorio.NEGOCIO
{
    class ControladorVacuna
    {

        private frmVacunacion formulario_vacunacion;
        private CRUD_Vacuna datos_vacuna;
        Vacunacion vacuna;
        public ControladorVacuna(frmVacunacion formulario_vacunacion)
        {
            this.formulario_vacunacion = formulario_vacunacion;
            this.datos_vacuna = new CRUD_Vacuna();
        }

        public void crearVacuna()
        {
            datos_vacuna.Create(getDatosVacuna());
        }

        public Vacunacion getDatosVacuna()
        {
            vacuna = new Vacunacion();
            vacuna.descripcion_vacunacion = formulario_vacunacion.TxtNomVacuna.Text;
            return vacuna;
        }

        public void presentarTablaUsuario()
        {
            formulario_vacunacion.DgvVacunas.DataSource = datos_vacuna.Db.Vacunacion;
            formulario_vacunacion.DgvVacunas.Columns[0].HeaderText = "Codigo";
            formulario_vacunacion.DgvVacunas.Columns[1].HeaderText = "Descripcion Vacuna";
        }

        public void DeleteVacuna(string nom)
        {
            datos_vacuna.Delete(nom);
        }

        public void obtenerDatosDataGrivView()
        {
            try
            {
                int pos;
                pos = formulario_vacunacion.DgvVacunas.CurrentRow.Index;
                formulario_vacunacion.TxtNomVacuna.Text = formulario_vacunacion.DgvVacunas[1, pos].Value.ToString();
            }catch(Exception e)
            {
                Console.Write(e);
            }
        }

        public void obtenerDatosDataGrivViewPerro()
        {
            try
            {
                int pos;
                pos = formulario_vacunacion.DgvPerro.CurrentRow.Index;
                formulario_vacunacion.TxtPerro.Text = formulario_vacunacion.DgvPerro[1, pos].Value.ToString();
            }
            catch (Exception e)
            {
                Console.Write(e);
            }
        }
    }
}
