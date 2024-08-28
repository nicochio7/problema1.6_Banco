using problema1._6_Banco.DOMINIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema1._6_Banco.IMPLEMENTACIONES
{
    internal interface ICuenta
    {

        List<CUENTA> getall();
        int getById();
        int save ();
        int delete();

    }
}
