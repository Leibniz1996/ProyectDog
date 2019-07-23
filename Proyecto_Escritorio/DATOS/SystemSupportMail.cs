using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Escritorio.DATOS
{
    class SystemSupportMail:ServidorDeCorreo
    {
        public SystemSupportMail()
        {
            senderMail = "soportesystemaDog@gmail.com";
            password = "@admin123";
            host = "smtp.gmail.com";
            port = 587;
            ssl = true;
            inicilizarClientSmtp();
        }
    }
}
