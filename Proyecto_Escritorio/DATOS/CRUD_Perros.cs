using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Escritorio.DATOS
{
    class CRUD_Perros
    {
        private DBDogDataContext db = new DBDogDataContext();

        public DBDogDataContext Db { get => db; set => db = value; }

        public Dogs d;
        public Razas r;

        public void Create(Dogs dog)
        {
            try
            {
                bool bandera = false;
                var use = from dogs in db.Dogs
                          where dogs.nombre_dog == dog.nombre_dog
                          select dogs;
                foreach (Dogs us in use)
                {
                    bandera = true;
                }

                if (bandera != true)
                {
                    db.Dogs.InsertOnSubmit(dog);
                    db.SubmitChanges();
                    MessageBox.Show("PErro ingresado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Perro ya registrado con el actual nombre, no puede ser ingresado nuevamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bandera = false;
                    use = null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                // MessageBox.Show("Error Inesperado al ingresar, Contacte con el administrador del Sistema :\n" + ex, "Error insert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Delete(String nombre)
        {
            try
            {
                Dogs dog = db.Dogs.Single(p => p.nombre_dog == nombre);
                db.Dogs.DeleteOnSubmit(dog);
                db.SubmitChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public Razas searchRaza(String name)
        {
            r = null;
          //  d = null;
            try
            {
                r = db.Razas.Single(p => p.nombre_raza == name);
                return r;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return r;
            }
        }
    }
}
