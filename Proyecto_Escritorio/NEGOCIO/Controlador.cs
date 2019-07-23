using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Escritorio.DATOS;
using Proyecto_Escritorio.VISTA;
using System.Windows.Forms;


namespace Proyecto_Escritorio.NEGOCIO
{
    class Controlador
    {
        private CRUD_Usuario datos_usuario;
        private frmRecuperarContraseña formulario_login;
        Usuario usr;

        private CRUD_Raza datos_raza;
        private frmPerros formulario_peerros;

        private CRUD_Vacuna datos_vacuna;
        private frmVacunacion formulario_vacunacion;
        public Controlador( frmRecuperarContraseña formulario_login)
        {
            this.datos_usuario = new CRUD_Usuario();
            this.formulario_login = formulario_login;
        }

        public void cargarComboRaza()
        {
            formulario_peerros.CmbRaza.Items.Clear();
            foreach (Razas us in datos_raza.searchall())
             {
                formulario_peerros.CmbRaza.Items.Add(us.nombre_raza);
               //  MessageBox.Show(us.nombre_raza);
             }
        }

        public void cargarComboVacunacion()
        {
            formulario_vacunacion.CmbVacuna.Items.Clear();
            foreach (Vacunacion us in datos_vacuna.searchall())
            {
                formulario_vacunacion.CmbVacuna.Items.Add(us.descripcion_vacunacion);
                //  MessageBox.Show(us.nombre_raza);
            }
        }

        public Controlador()
        {
            
        }

        public Controlador(frmPerros formulario_peerros)
        {
            this.datos_raza = new CRUD_Raza();
            this.formulario_peerros = formulario_peerros;
        }

        public Controlador(frmVacunacion formulario_vacunacion)
        {
            this.datos_vacuna = new CRUD_Vacuna();
            this.formulario_vacunacion = formulario_vacunacion;
        }

        public Usuario conexUser(String user)
        {
            datos_usuario = new CRUD_Usuario();
            Boolean Resp = false;
            if (datos_usuario.searchUserName(user) != null)
            {
                usr = datos_usuario.searchUserName(user);
            }
            return usr;
        }

        public string recuperarContra(string recuperar)
        {
            string result = datos_usuario.RecuperrarMail(recuperar);
            return result;
        }

      

        
    }
}
