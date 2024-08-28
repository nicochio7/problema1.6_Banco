using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema1._6_Banco.DOMINIO
{
    public class CUENTA
    {
         public int Id_cuenta { get; set; }
        public double Saldo { get; set; }   
        public DateTime Ultimo_movimiento {  get; set; }

        public TipoCuenta TipoCuenta { get; set; }

        public int tipoCuentaId { get; set; }
        public CLIENTE Cliente { get; set; }

        public int ClienteId { get; set; }
           
    }
}
