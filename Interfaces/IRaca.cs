using AtividadePet.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadePet.Interfaces
{
    interface IRaca
    {
        Raca Cadastrar(Raca r);
        List<Raca> LerTodos();
        Raca BuscarPorId(int id);
        Raca Alterar(int id, Raca r );
        void Excluir(int id);
    }
}
