using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BOL
{
   public class Provincias
    { DBaccess conexion = new DBaccess();
        public DataTable listar(int IdDepartamento) 
        {
            return conexion.listarDatosValor("spu_provincias_listar ", "@IdDepartamento", IdDepartamento);
        
        }
    }
}
