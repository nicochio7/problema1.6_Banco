using problema1._6_Banco.DOMINIO;
using problema1._6_Banco.IMPLEMENTACIONES;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema1._6_Banco.DATA
{
    internal class IClienteRepository:ICliente
    {
        public int delete()
        {
            throw new NotImplementedException();
        }

        public CLIENTE getClienteId(int id)
        {
            CLIENTE c = new CLIENTE();
            var sp = DataHelper.GetInstance().ExecuteSPQuery("OBTENER_CLIENTES_ID " + id);

            foreach (DataRow dr in sp.Rows)
            {
                c.id = Convert.ToInt32(dr[0]);
                c.Nombre = dr[1].ToString();
                c.Apellido = dr[2].ToString();
                c.Dni = dr[3].ToString();
            }
            return c;

        }

        public int save(CLIENTE c)
        {
            SqlCommand command = new SqlCommand("crear_cliente");
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@nombre", c.Nombre));
            var sp = DataHelper.GetInstance().ExecuteSPQuery($"crear_cliente '{c.Nombre}','{c.Apellido}','{c.Dni}' ");
            return 
        }

        
        

        List<CLIENTE> ICliente.getAll()
        {
            List<CLIENTE> list = new List<CLIENTE>();
            var sp = DataHelper.GetInstance().ExecuteSPQuery("OBTENER_CLIENTES");

            foreach (DataRow dr in sp.Rows)
            {
                CLIENTE c = new CLIENTE();
                c.id = Convert.ToInt32(dr[0]);
                c.Nombre = dr[1].ToString();
                c.Apellido = dr[2].ToString();
                c.Dni = dr[3].ToString();
                list.Add(c);

            }
            return list;
        }
    }
}
