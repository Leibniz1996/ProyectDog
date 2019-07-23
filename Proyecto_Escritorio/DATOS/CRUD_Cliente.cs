using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Escritorio.NEGOCIO;
using System.Windows.Forms;

namespace Proyecto_Escritorio.DATOS
{
    class CRUD_Cliente
    {
        private  DBDogDataContext db = new DBDogDataContext();
        Cliente DCliente;

        public DBDogDataContext Db { get => db; set => db = value; }

        public Cliente getCLiente(String cedula)
        {
            try
            {
                DCliente = db.Cliente.Single(x => x.cedula_cliente == cedula);
            }
            catch (NullReferenceException)
            {
                DCliente = null;

            }
            return DCliente;
        }
        public void Create(Cliente oc)
        {
            try
            {
                bool bandera = false;
                var cli = from C in db.Cliente
                          where C.cedula_cliente == oc.cedula_cliente
                          select C;

                foreach (Cliente us in cli)
                {
                    bandera = true;
                }

                if (bandera != true)
                {
                    db.Cliente.InsertOnSubmit(oc);
                    db.SubmitChanges();
                    MessageBox.Show("Cliente ingresado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cliente ya registrado, no puede ser ingresado nuevamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Inesperado al ingresar, Contacte con el administrador del Sistema :\n" + ex, "Error insert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
