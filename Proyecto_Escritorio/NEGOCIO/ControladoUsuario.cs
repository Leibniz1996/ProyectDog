using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Escritorio.VISTA;
using Proyecto_Escritorio.DATOS;

namespace Proyecto_Escritorio.NEGOCIO
{
    class ControladoUsuario
    {
        private frmUsuarios formulario_usuario;
        private CRUD_Usuario datos_usuario;
        Usuario usuario;
        public ControladoUsuario(frmUsuarios formularioUsuarioss)
        {
            this.datos_usuario = new CRUD_Usuario();
            this.formulario_usuario = formularioUsuarioss;
        }

        public void crearUsuario()
        {
            datos_usuario.Create(getDatosUsuario());
        }

        public void EditUsuario(String ced, String nom, String ape, String userName, String password, String correoE, String rol)
        {
            datos_usuario.Edit(ced, nom, ape, userName, password, correoE, rol);
        }

        public void DeleteUsuario(string ced)
        {
            datos_usuario.Delete(ced);
        }

        public void presentarTablaUsuario()
        {
            formulario_usuario.DGVUsuario.DataSource = datos_usuario.Db.Usuario;
            formulario_usuario.DGVUsuario.Columns[0].HeaderText = "Codigo";
            formulario_usuario.DGVUsuario.Columns[1].HeaderText = "Cedula";
            formulario_usuario.DGVUsuario.Columns[2].HeaderText = "Nombre";
            formulario_usuario.DGVUsuario.Columns[3].HeaderText = "Apellido";
            formulario_usuario.DGVUsuario.Columns[4].HeaderText = "Nombre Usuario";
            // formulario_usuario.DGVUsuario.Columns[5].HeaderText = "Contraseña";
            formulario_usuario.DGVUsuario.Columns[5].Visible = false;
            formulario_usuario.DGVUsuario.Columns[6].HeaderText = "Correo Electronico";
            formulario_usuario.DGVUsuario.Columns[7].HeaderText = "Rol Usuario";
        }

        public Usuario getDatosUsuario()
        {
            usuario = new Usuario();
            usuario.cedula_usuario = formulario_usuario.TxtCedula.Text;
            usuario.nombre_usuario = formulario_usuario.TxtNombre.Text;
            usuario.apellido_usuario = formulario_usuario.TxtApellido.Text;
            usuario.user_name = formulario_usuario.TxtUser.Text;
            usuario.password = formulario_usuario.TxtPassword.Text;
            usuario.correoE = formulario_usuario.TxtCorreo.Text;
            usuario.rol = formulario_usuario.CmbRol.SelectedItem.ToString();
            return usuario;
        }

        public void obtenerDatosDataGrivView()
        {
            try
            {
            int pos;
            pos = formulario_usuario.DGVUsuario.CurrentRow.Index;
            formulario_usuario.TxtApellido.Text = formulario_usuario.DGVUsuario[3, pos].Value.ToString();
            formulario_usuario.TxtCedula.Text = formulario_usuario.DGVUsuario[1, pos].Value.ToString();
            formulario_usuario.TxtNombre.Text = formulario_usuario.DGVUsuario[2, pos].Value.ToString();
            formulario_usuario.TxtCorreo.Text = formulario_usuario.DGVUsuario[6, pos].Value.ToString();
            formulario_usuario.TxtUser.Text = formulario_usuario.DGVUsuario[4, pos].Value.ToString();
            formulario_usuario.TxtPassword.Text = formulario_usuario.DGVUsuario[5, pos].Value.ToString();
            if (formulario_usuario.DGVUsuario[7, pos].Value.ToString() == "Administrador")
            {
                formulario_usuario.CmbRol.SelectedIndex = 1;
            }
            else formulario_usuario.CmbRol.SelectedIndex = 2;
            }catch(Exception e)
            {
                Console.Write(e);
            }
        }
    }
}
