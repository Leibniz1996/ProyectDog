using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Escritorio.NEGOCIO;
using System.Windows.Forms;

namespace Proyecto_Escritorio.DATOS
{
    class CRUD_vacunarPerro
    {

        private DBDogDataContext db = new DBDogDataContext();

        public DBDogDataContext Db { get => db; set => db = value; }

        public Dog_Vacu d = null;
        public Dogs p = null;
        public Vacunacion v = null;

        public void Create(Dog_Vacu dv)
        {
            try
            {
                bool bandera = false;
                var use = from usu in db.Dog_Vacu
                          where usu.id_vacunacion == dv.id_vacunacion
                          select usu;
                foreach (Dog_Vacu us in use)
                {
                    bandera = true;
                }

                if (bandera != true)
                {
                    db.Dog_Vacu.InsertOnSubmit(dv);
                    db.SubmitChanges();
                    MessageBox.Show("Vacunacion ingresada correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Vacunacion ya registrado, no puede ser ingresado nuevamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public Dogs searchCodPErro(String name)
        {
            p = null;
            try
            {
                p = db.Dogs.Single(p => p.nombre_dog == name);
                return p;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return p;
            }
        }

        public Vacunacion searchCodVacuna(String name)
        {
            v = null;
            try
            {
                v = db.Vacunacion.Single(p => p.descripcion_vacunacion == name);
                return v;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return v;
            }
        }
    }
}
