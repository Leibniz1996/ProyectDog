using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Escritorio.DATOS;
using Proyecto_Escritorio.VISTA;

namespace Proyecto_Escritorio.NEGOCIO
{
    class ControladorRaza
    {
        private frmGestionarRazas formulario_raza;
        
        private CRUD_Raza datos_raza;

        Razas raza;

        public ControladorRaza(frmGestionarRazas formulario_raza)
        {
            this.formulario_raza = formulario_raza;
            this.datos_raza = new CRUD_Raza();
        }

        public void crearRaza()
        {
            datos_raza.Create(getDatosRaza());
        }

        public Razas getDatosRaza()
        {
            raza = new Razas();
            raza.nombre_raza = formulario_raza.TxtRaza.Text;
            return raza;
        }
    }
}
