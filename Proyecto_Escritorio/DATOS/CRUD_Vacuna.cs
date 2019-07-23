using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Escritorio.DATOS
{
    class CRUD_Vacuna
    {
        private DBDogDataContext db = new DBDogDataContext();

        public DBDogDataContext Db { get => db; set => db = value; }

        public Vacunacion v = null;

        public void Create(Vacunacion vac)
        {
            try
            {
                bool bandera = false;
                var cr = from v in db.Vacunacion
                          where v.descripcion_vacunacion == vac.descripcion_vacunacion
                          select v;
                foreach (Vacunacion c in cr)
                {
                    bandera = true;
                }

                if (bandera != true)
                {
                    db.Vacunacion.InsertOnSubmit(vac);
                    db.SubmitChanges();
                    MessageBox.Show("Vacuna ingresada correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Vacuna ya registrado, no puede ser ingresado nuevamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bandera = false;
                    cr = null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                //MessageBox.Show("Error Inesperado al ingresar, Contacte con el administrador del Sistema :\n" + ex, "Error insert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Delete(String nombre)
        {
            try
            {
                Vacunacion va = db.Vacunacion.Single(p => p.descripcion_vacunacion == nombre);
                db.Vacunacion.DeleteOnSubmit(va);
                db.SubmitChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public Vacunacion searchVacuna(String nom)
        {
            try
            {
                v = db.Vacunacion.Single(p => p.descripcion_vacunacion == nom);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return v;
        }

        public dynamic searchall()
        {
            var va = from raz in db.Vacunacion
                     select raz;
            return va;
        }
    }
}
