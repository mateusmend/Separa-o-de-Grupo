using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AtividadeGrupo.Repositorio;
using AtividadeGrupo.Classes;

namespace AtividadeGrupo.Regra_de_negocio
{
    public class Regras
    {
        /// <summary>
        /// Método que irá defenir qual grupo o aluno estará.
        /// </summary>
        /// <param name="p"> Lista de alunos a ser passada</param>
        /// <param name="TamanhoDoGrupo"> Tamanho do grupo para dividir a lista </param>
        public void OrganizarGrupos(List<Pessoa> p, int TamanhoDoGrupo){
            int aux = 0;
            int indexGrupo = 1;

            foreach (var item in p)
            {
               if (aux == TamanhoDoGrupo)
                {
                    aux = 0;
                    indexGrupo++;
                }
               aux++;
               Console.WriteLine("Aluno: " + item.Nome +" No Grupo "+ indexGrupo);
            }
        }
        /// <summary>
        /// Método que irá inserir os alunos no repositorio
        /// </summary>
        /// <param name="repo">Argumento onde passará get do repositorio.</param>
        public void Inserir(Repository repo)
        {
            Console.WriteLine("Digite a quantidade de alunos a serem inserido: ");
            int quant = int.Parse(Console.ReadLine());
            for (int i = 0; i < quant; i++)
            {
                Console.WriteLine("Digite o Nome do Aluno: ");
                repo.AdicionarPessoa(new Pessoa(Console.ReadLine()));
            }

        }
        /// <summary>
        /// Método que irá perguntar a quantidade de alunos por grupo.
        /// </summary>
        /// <returns></returns>
        public int DividirGrupos()
        {
            Console.WriteLine("Digite a quantidade de pessoas em cada Grupo :");
            int quant = int.Parse(Console.ReadLine());
            return quant;
        }
    }
}
