using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema1._6_Banco.DOMINIO
{
    public class CLIENTE
    {
        public int id {  get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Dni { get; set; }

        List<Cuenta> cuentas = new List<Cuenta>();    
    }
}
