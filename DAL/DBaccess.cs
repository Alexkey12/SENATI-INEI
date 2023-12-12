using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
namespace DAL
{
   public  class DBaccess
    {
        
          private SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["AccesoInei"].ConnectionString);

        public SqlConnection getconexion() 
        {
            return this.conexion;
        }
        public void Abirconexion() 
        {
            if (this.conexion.State==ConnectionState.Closed) 
            {
                this.conexion.Open();
            }
        }
        public void Cerraconexion()
        {
            if (this.conexion.State == ConnectionState.Open)
            {
                this.conexion.Close();
            }
        }
        public DataTable listarDatos(string spu)
        {
            DataTable dt = new DataTable();

      
            this.Abirconexion();
            SqlCommand comando = new SqlCommand(spu, getconexion());
            comando.CommandType = CommandType.StoredProcedure;
            dt.Load(comando.ExecuteReader());
            this.Cerraconexion();
            return dt;

        }
        public DataTable listarDatosValor(string spu,string nombrevariable,object valorvariable)
        {
            DataTable dt = new DataTable();


            this.Abirconexion();
            SqlCommand comando = new SqlCommand(spu, getconexion());
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue(nombrevariable,valorvariable);
            dt.Load(comando.ExecuteReader());
            this.Cerraconexion();
            return dt;

        }

    }
}
