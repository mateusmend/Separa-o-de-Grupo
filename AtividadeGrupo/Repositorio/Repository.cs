using AtividadeGrupo.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeGrupo.Repositorio
{
    public class Repository
    {
        private List<Pessoa> pessoas = new List<Pessoa>();
        public void AdicionarPessoa(Pessoa p)
        {
            pessoas.Add(p);
        }
        public List<Pessoa> ObterPessoas()
        {
            return pessoas;
        }
    }
}
