using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Escritorio.DATOS;
using Proyecto_Escritorio.VISTA;

namespace Proyecto_Escritorio.NEGOCIO
{
    class ControladorCliente
    {
        private CRUD_Cliente datos_cliente;
        private frmPersona formularioPersona;
        Cliente cliente;
        public ControladorCliente(frmPersona fromularioPersona)
        {
            this.datos_cliente = new CRUD_Cliente();
            this.formularioPersona = formularioPersona;
        }

        public void crearCliente()
        {
            datos_cliente.Create(getDatosCliente());
        }

        public Cliente getDatosCliente()
        {
            cliente = new Cliente();
            cliente.cedula_cliente = formularioPersona.TxtCed.Text;
            cliente.nombre_cliente = formularioPersona.TxtNom.Text;
            cliente.apellido_cliente = formularioPersona.TxtApe.Text;
            cliente.direccion_cliente = formularioPersona.TxtDirecc.Text;
            cliente.telefono_cliente = formularioPersona.TxtCelukar.Text;
            cliente.correo_cliente = formularioPersona.TxtCorreo.Text;
            return cliente;
        }

    }
}
