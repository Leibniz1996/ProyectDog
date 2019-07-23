using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Escritorio.DATOS
{
    class CRUD_Raza
    {
        private DBDogDataContext db = new DBDogDataContext();

        public DBDogDataContext Db { get => db; set => db = value; }

        public Razas r = null;

        public void Create(Razas raza)
        {
            try
            {
                bool bandera = false;
                var ra = from raz in db.Razas
                          where raz.nombre_raza == raza.nombre_raza
                          select raz;
                foreach (Razas or in ra)
                {
                    bandera = true;
                }

                if (bandera != true)
                {
                    db.Razas.InsertOnSubmit(raza);
                    db.SubmitChanges();
                    MessageBox.Show("Raza ingresado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Raza ya registrada, no puede ser ingresado nuevamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bandera = false;
                    ra = null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
               // MessageBox.Show("Error Inesperado al ingresar, Contacte con el administrador del Sistema :\n" + ex, "Error insert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public dynamic searchall()
        {
                var ra = from raz in db.Razas
                         select raz;
            return ra;
        }



    }
}
