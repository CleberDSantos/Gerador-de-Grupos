using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GeradorGrupos
{
    class Program
    {
        public static void Main(string[] args)
        {
            var quantidadeGrupos = 0;
            var quantidadeAlunos = 0;
            var contador = 0;

            var alunos = new List<Aluno>();


            Console.WriteLine("Digite a quantidade de Alunos");
            quantidadeAlunos = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de grupos");
            quantidadeGrupos = int.Parse(Console.ReadLine());

            string alunosString = @" Cleber
                                    ,João
                                    ,Andressa
                                    ,Artur
                                    ,Bruno
                                    ,Caio 
                                    ,Carlos 
                                    ,Dener  
                                    ,Denis  
                                    ,Eduardo  
                                    ,Eduardo  
                                    ,Erik  
                                    ,Felipe 
                                    ,Gabriel 
                                    ";


            var arrAlunos = alunosString.Split(',');

            while (contador < arrAlunos.Length)
            {
                alunos.Add(new Aluno { Nome = arrAlunos[contador] });
                contador++;
            }


            var geradorGrupo = new GeradorGrupo();
            geradorGrupo.Alunos = alunos;
            var alunosRand = geradorGrupo.RandomizarAlunos();


            List<List<Aluno>> gruposRandomizados = geradorGrupo.Gerar(alunosRand, quantidadeGrupos);

            ImprimirResultado(gruposRandomizados);

        }


        /// <summary>
        /// Imprime o resultado na tela
        /// </summary>
        /// <param name="gruposRandomizados">grupos de alunos</param>
        private static void ImprimirResultado(List<List<Aluno>> gruposRandomizados)
        {

            int nGrupo = 1;
            foreach (var grupo in gruposRandomizados)
            {
                Console.WriteLine("o grupo {0}", nGrupo);
                Console.WriteLine("");
                nGrupo++;



                foreach (var aluno in grupo)
                {

                    Thread.Sleep(4000);

                    Console.WriteLine(" {0}", aluno.Nome);
                }
            }

            Console.ReadKey();
        }
    }
}
