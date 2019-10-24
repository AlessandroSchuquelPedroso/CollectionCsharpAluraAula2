using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListSomenteLeitura
{
    class ProgramListSomenteLeitura
    {
        static void Main(string[] args)
        {
            Curso csharpColecoes = new Curso("C# Collection","Marcelo Oliveira");

            csharpColecoes.Adiciona(new Aula("Trabalhando com Listas", 21));

            Imprimir(csharpColecoes.Aulas);

            csharpColecoes.Adiciona(new Aula("Criando uma Aula", 20));
            csharpColecoes.Adiciona(new Aula("Modelando com Coleções", 19));

            Imprimir(csharpColecoes.Aulas);

            //ordenar lista de aulas
            //copiar a lista para outra lista

            List<Aula> aulasCopiadas = new List<Aula>(csharpColecoes.Aulas);

            //ordenar a copia
            aulasCopiadas.Sort();

            Imprimir(aulasCopiadas);

            //totalizar o tempo do curso
            Console.WriteLine(csharpColecoes.TempoTotal);

            Console.WriteLine(csharpColecoes);

            //imprir detalhes do curso???


            Console.ReadLine();

        }

        private static void Imprimir(IList<Aula> aulas)
        {
            Console.Clear();

            foreach (var aula in aulas)
            {
                Console.WriteLine(aula);
            }

            //aulas.ForEach(aula => 
            //{
            //    Console.WriteLine(aulas);
            //});
        }
    }
}
