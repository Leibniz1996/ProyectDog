using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Escritorio.NEGOCIO;
using System.Windows.Forms;

namespace Proyecto_Escritorio.DATOS
{
    class CRUD_Usuario
    {
        private DBDogDataContext db = new DBDogDataContext();

        public DBDogDataContext Db { get => db; set => db = value; }

        public Usuario u = null;
        public void Create(Usuario user)
        {
            try
            {
                bool bandera = false;
                var use = from usu in db.Usuario
                          where usu.cedula_usuario == user.cedula_usuario
                          select usu;
                foreach (Usuario us in use)
                {
                    bandera = true;
                }

                if (bandera != true)
                {
                    db.Usuario.InsertOnSubmit(user);
                    db.SubmitChanges();
                    MessageBox.Show("Cliente ingresado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cliente ya registrado, no puede ser ingresado nuevamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bandera = false;
                    use = null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                //MessageBox.Show("Error Inesperado al ingresar, Contacte con el administrador del Sistema :\n" + ex, "Error insert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Edit(String ced, String nom, String ape, String userName, String password, String correoE, String rol)
        {
            try
            {
                var tra = from t in db.Usuario
                          where t.cedula_usuario == ced
                          select t;
                foreach (Usuario p in tra)
                {
                    p.cedula_usuario = ced;
                    p.nombre_usuario = nom;
                    p.apellido_usuario = ape;
                    p.user_name = userName;
                    p.password = password;
                    p.correoE = correoE;
                    p.rol = rol;
                }
                db.SubmitChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void Delete(String Cedula)
        {
            try
            {
                Usuario pro = db.Usuario.Single(p => p.cedula_usuario == Cedula);
                db.Usuario.DeleteOnSubmit(pro);
                db.SubmitChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public Usuario searchUserName(String name)
        {
            u = null;
            try
            {
                u =  db.Usuario.Single(p => p.user_name == name);
                return u;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return u;
            }
        }

        public Usuario searchCedula(String ced)
        {
            try
            {
                u = db.Usuario.Single(p => p.cedula_usuario == ced);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return u;
        }

        public String RecuperrarMail(String mail)
        {
            string result = "";
            try
            {
                var tra = from t in db.Usuario
                          where t.correoE == mail
                          select t;
                foreach (Usuario p in tra)
                {
                    string nombre = p.nombre_usuario;
                    string apellido = p.apellido_usuario;
                    string corre = p.correoE;
                    string contra = p.password;

                    var mailservice = new SystemSupportMail();
                    mailservice.sendMail(
                        subject: "SYSTEM: Solicitud contraseña",
                        body: "Hola, " + nombre + "\nUsted solicita recuperar su contraseña.\n" +
                        "Su contraseña es: " + contra + "   User: " + p.user_name +
                        "\nPorfavor una vez ingresado al sistema, cambie la contraseña",
                        recipientMail: new List<string> { corre }
                        );
                    return result = "Hola, " + nombre + "\nUsted solicita recuperar su contraseña.\n" +
                        "Porfavor revise su correo:  " + corre +
                        "\nPorfavor una vez ingresado al sistema, cambie la contraseña";
                }

            }
            catch (Exception)
            {
                return result = "Informacion Erronea del usuario";
            }
            return result = "Informacion Erronea del usuario";
        }
    }
}
