using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadePet.Domains
{
    public class Raca : TipoDePet
    {
        public int IdRaca { get; set; }
        public new string Descricao { get; set; }

        public int IdTipoDePet { get; set; }

    }
}
