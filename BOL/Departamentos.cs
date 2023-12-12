using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using ENTITIES;
using System.Data;
namespace BOL
{
    public class Departamentos
    {
        DBaccess conexion = new DBaccess();
        public DataTable listar() 
        {
            return conexion.listarDatos("spu_departamentos_listar ");
        }
    }
}
