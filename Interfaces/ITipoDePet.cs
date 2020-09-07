using AtividadePet.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadePet.Interfaces
{
    interface ITipoDePet
    {
        TipoDePet Cadastrar(TipoDePet t);
        List<TipoDePet> LerTodos();
        TipoDePet BuscarPorId(int id);
        TipoDePet Alterar(int id, TipoDePet t);
        void Excluir(int id);

    }
}
