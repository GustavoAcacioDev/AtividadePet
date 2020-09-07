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
            throw new NotImplementedException();
        }

        public TipoDePet Cadastrar(TipoDePet t)
        {
            throw new NotImplementedException();
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
                        IdTipoDePet = Convert.ToInt32(dados.GetValue(0)),
                        Descricao = dados.GetValue(1).ToString()
                    }
                );
            }

            connection.Desconectar();

            return tipoPets; 
        }
    }
}
