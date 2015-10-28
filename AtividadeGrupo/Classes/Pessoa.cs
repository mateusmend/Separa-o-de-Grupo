using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeGrupo.Classes
{
    public class Pessoa
    {
        public string Nome{ get; set; }
        public Pessoa(string novoNome)
        {
            Nome = novoNome;
        }
    }
}
