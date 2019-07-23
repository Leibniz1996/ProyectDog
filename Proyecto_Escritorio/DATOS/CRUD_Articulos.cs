using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Escritorio.NEGOCIO;
using System.Windows.Forms;

namespace Proyecto_Escritorio.DATOS
{
    class CRUD_Articulos
    {
        private DBDogDataContext db = new DBDogDataContext();

        public DBDogDataContext Db { get => db; set => db = value; }

        public Articulos a = null;

        public void Create(Articulos art)
        {
            try
            {
                bool bandera = false;
                var use = from usu in db.Articulos
                          where usu.descripcion_articulo == art.descripcion_articulo
                          select usu;
                foreach (Articulos us in use)
                {
                    bandera = true;
                }

                if (bandera != true)
                {
                    db.Articulos.InsertOnSubmit(art);
                    db.SubmitChanges();
                    MessageBox.Show("Articulo ingresado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Articulo ya registrado, no puede ser ingresado nuevamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public void Edit(Articulos art)
        {
            try
            {
                var tra = from t in db.Articulos
                          where t.descripcion_articulo == art.descripcion_articulo
                          select t;
                foreach (Articulos p in tra)
                {
                    p.cod_articulo = art.cod_articulo;
                    p.descripcion_articulo= art.descripcion_articulo;
                    p.cantidad_articulo = art.cantidad_articulo;
                    p.precio_articulo = art.precio_articulo;
                    p.id_categoria = art.id_categoria;
                }
                db.SubmitChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
