using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Escritorio.VISTA;
using Proyecto_Escritorio.DATOS;

namespace Proyecto_Escritorio.NEGOCIO
{
    class ControladorDogVacunado
    {
        private frmVacunacion formulario_vacunacion;
        private CRUD_vacunarPerro datos_vacunacion;
        Dog_Vacu vacunacion;

        public ControladorDogVacunado(frmVacunacion formulario_vacunacion)
        {
            this.formulario_vacunacion = formulario_vacunacion;
            this.datos_vacunacion = new CRUD_vacunarPerro();
        }

        public void crearvacunacion()
        {
            datos_vacunacion.Create(getDatosVacunacion());
        }

        public Dog_Vacu getDatosVacunacion()
        {
            vacunacion = new Dog_Vacu();
           
            vacunacion.cod_dog = datos_vacunacion.searchCodPErro(formulario_vacunacion.TxtPerro.Text).cod_dog;
            vacunacion.id_vacunacion = datos_vacunacion.searchCodVacuna(formulario_vacunacion.CmbVacuna.SelectedItem.ToString()).id_vacunacion;
            vacunacion.fecha = Convert.ToDateTime(formulario_vacunacion.DtpFechaV.Value.Date.ToString());
            return vacunacion;
        }

        public void obtenerDatosDataGrivView()
        {
            int pos;
            pos = formulario_vacunacion.DgvPerro.CurrentRow.Index;
            formulario_vacunacion.TxtPerro.Text = formulario_vacunacion.DgvPerro[1, pos].Value.ToString();
        }

        public void limpiarCampos()
        {
            formulario_vacunacion.TxtPerro.Text = "";
            formulario_vacunacion.CmbVacuna.SelectedItem = "";
        }
    }
}
