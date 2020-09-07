﻿using AtividadePet.Context;
using AtividadePet.Domains;
using AtividadePet.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadePet.Repositories
{
    public class RacaRepository : IRaca
    {

        RacaContext connection = new RacaContext();

        SqlCommand cmd = new SqlCommand();

        public Raca Alterar(int id, Raca r)
        {
            throw new NotImplementedException();
        }

        public Raca BuscarPorId(int id)
        {
            cmd.Connection = connection.Conectar();

            cmd.CommandText = "SELECT * FROM Raca WHERE IdRaca = @id ";

            cmd.Parameters.AddWithValue("@id", id);

            SqlDataReader dados = cmd.ExecuteReader();

            Raca r = new Raca();

            while (dados.Read())
            {
                r.IdRaca = Convert.ToInt32(dados.GetValue(0));
                r.Descricao = dados.GetValue(1).ToString();
            }

            cmd.Connection = connection.Desconectar();
            return r;
        }

        public Raca Cadastrar(Raca r)
        {
            throw new NotImplementedException();
        }

        public void Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public List<Raca> LerTodos()
        {

            cmd.Connection = connection.Conectar();

            cmd.CommandText = "SELECT * FROM Raca";

            SqlDataReader dados = cmd.ExecuteReader();

            List<Raca> racas = new List<Raca>();

            while (dados.Read())
            {
                racas.Add(
                    new Raca()
                    {
                        IdRaca = Convert.ToInt32(dados.GetValue(0)),
                        Descricao = dados.GetValue(1).ToString(),
                        IdTipoDePet = Convert.ToInt32(dados.GetValue(2))
                    }
                );
            }

            connection.Desconectar();

            return racas;
        }
    }
}
