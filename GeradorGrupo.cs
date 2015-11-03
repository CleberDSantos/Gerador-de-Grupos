using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeradorGrupos
{
    public class GeradorGrupo
    {

        public List<Aluno> Alunos { get; set; }

        /// <summary>
        ///  Misturar a lista de alunos
        /// </summary>
        /// <returns> lista misturada</returns>
        public List<Aluno> RandomizarAlunos()
        {
            var alunosRand = new List<Aluno>();
            Random rand = new Random();

            while (this.Alunos.Count > 0)
            {
                var randNumber = rand.Next(this.Alunos.Count);

                var alunoRand = this.Alunos[randNumber];
                alunosRand.Add(alunoRand);

                this.Alunos.RemoveAt(randNumber);
            }
            

            return alunosRand;
        }

        /// <summary>
        /// Gerar os grupos de alunos de acordo com a quantidade
        /// </summary>
        /// <param name="alunosRand">lista de alunos misturada</param>
        /// <param name="quantidadeGrupos">quantidade de grupos</param>
        /// <returns>lista de grupos de alunos</returns>
        public List<List<Aluno>> Gerar(List<Aluno> alunosRand, int quantidadeGrupos)
        {

            var listaGrupos = InicializarListaGrupo(quantidadeGrupos);

            var i = 0;
            foreach (var aluno in alunosRand)
            {
                if (i == quantidadeGrupos)
                    i = 0;

                listaGrupos[i].Add(aluno);

                i++;
            }

            return listaGrupos;

        }

        /// <summary>
        ///  Inicializador de listas
        /// </summary>
        /// <param name="quantidadeGrupos">Quantidade de listas</param>
        /// <returns>grupos com as listas inicializadas</returns>
        private static List<List<Aluno>> InicializarListaGrupo(int quantidadeGrupos)
        {
            var listaGrupos = new List<List<Aluno>>();
            for (int i = 0; i <= quantidadeGrupos - 1; i++)
            {
                listaGrupos.Add(new List<Aluno>());
            }
            return listaGrupos;

        }

    }
}
