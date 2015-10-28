using AtividadeGrupo.Classes;
using AtividadeGrupo.Regra_de_negocio;
using AtividadeGrupo.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeGrupo
{
    class Program
    {
        static void Main(string[] args)
        {
            Repository repo = new Repository();
            Regras regra = new Regras();
            regra.Inserir(repo);
            regra.OrganizarGrupos(repo.ObterPessoas(),regra.DividirGrupos());
            Console.ReadKey();
        }
    }
}
