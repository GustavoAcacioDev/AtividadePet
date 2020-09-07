using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadePet.Context
{
    public class TipoDePetContext
    {
        SqlConnection con = new SqlConnection();

        public TipoDePetContext()
        {
            con.ConnectionString = @"Data Source=DESKTOP-SLKJAFN\SQLEXPRESS;Initial Catalog=PetShop;User ID=sa;Password=sa132";
        }

        public SqlConnection Conectar()
        {
            if(con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        public SqlConnection Desconectar()
        {
            if(con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
            return con;
        }
    }

}
