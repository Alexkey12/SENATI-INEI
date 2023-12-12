using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
namespace BOL
{
    public class Distritos
    {
        DBaccess conexion = new DBaccess();

        public DataTable listar(int IdProvincia) 
        {
            return conexion.listarDatosValor("spu_distritos_listar", "@IdProvincia", IdProvincia);
        }
        
    }
}
