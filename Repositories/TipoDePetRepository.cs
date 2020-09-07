using AtividadePet.Context;
using AtividadePet.Domains;
using AtividadePet.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadePet.Repositories
{
    public class TipoDePetRepository : ITipoDePet
    {

        TipoDePetContext connection = new TipoDePetContext();

        SqlCommand cmd = new SqlCommand();
        public TipoDePet Alterar(int id, TipoDePet t)
        {
            throw new NotImplementedException();
        }

        public TipoDePet BuscarPorId(int id)
        {
            cmd.Connection = connection.Conectar();

            cmd.CommandText = "SELECT * FROM TipoDePet WHERE IdTipoDePet = @id ";

            cmd.Parameters.AddWithValue("@id", id);

            SqlDataReader dados = cmd.ExecuteReader();

            TipoDePet t = new TipoDePet();

            while (dados.Read())
            {
                t.IdTipoDePet   = Convert.ToInt32(dados.GetValue(0));
                t.Descricao     = dados.GetValue(1).ToString();
            }

            cmd.Connection = connection.Desconectar();
            return t;
        }

        public TipoDePet Cadastrar(TipoDePet t)
        {
            cmd.Connection = connection.Conectar();

            cmd.CommandText =
                "INSERT INTO TipoDePEt (Descricao) " +
                "VALUES" +
                "(@descricao)";
            cmd.Parameters.AddWithValue("@descricao", t.Descricao);

            cmd.ExecuteNonQuery();

            cmd.Connection = connection.Desconectar();

            return t;
        }

        public void Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public List<TipoDePet> LerTodos()
        {
            cmd.Connection = connection.Conectar();

            cmd.CommandText = "SELECT * FROM TipoDePet";

            SqlDataReader dados = cmd.ExecuteReader();

            List<TipoDePet> tipoPets = new List<TipoDePet>();

            while (dados.Read())
            {
                tipoPets.Add(
                    new TipoDePet()
                    {
                        IdTipoDePet     = Convert.ToInt32(dados.GetValue(0)),
                        Descricao       = dados.GetValue(1).ToString()
                    }
                );
            }

            connection.Desconectar();

            return tipoPets; 
        }
    }
}
