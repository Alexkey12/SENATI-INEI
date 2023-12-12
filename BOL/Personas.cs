using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITIES;
using System.Data;
using System.Data.SqlClient;
using DAL;
namespace BOL
{
    public class Personas
    {
        DBaccess conexion = new DBaccess();

        public DataTable listar() 
        {
            return conexion.listarDatos("spu_personas_listar");
        }
}
    
}
