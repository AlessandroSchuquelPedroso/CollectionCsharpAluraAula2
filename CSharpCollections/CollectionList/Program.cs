using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionList
{
    class Program
    {
        static void Main(string[] args)
        {
            string aulaInto = "Introdução ás Coleções";
            string aulaModelando = "Modelando a Classe Aula";
            string aulasSets = "Trabalhando com Conjuntos";

            //List<string> aulas = new List<string>
            //{
            //    aulaInto,
            //    aulaModelando,
            //    aulasSets
            //};

            List<string> aulas = new List<string>();
            aulas.Add(aulaInto);
            aulas.Add(aulaModelando);
            aulas.Add(aulasSets);

            Imprimir(aulas);

            //Console.WriteLine("A primeira aula é " + aulas[0]);

            //busca a primeira aula com o metado First(primeira)
            Console.WriteLine("A primeira aula é (First) " + aulas.First());

            //busca o ultima aula com o metado last
            Console.WriteLine("A última aula é " + aulas.Last());
            //Console.WriteLine("A última aula é " + aulas[aulas.Count - 1]);

            aulas[0] = "Trabalhando com listas";
            Imprimir(aulas);

            //pega a primeira(first) aula do array e busca pela palavra
            Console.WriteLine("A primeira aula 'Trabalhando' é: "
                + aulas.First(aula => aula.Contains("Trabalhando")));

            //pega a última(first) aula do array e busca pela palavra
            Console.WriteLine(" a última aula 'Trabalhando' é: "
                + aulas.Last(aula => aula.Contains("Trabalhando")));

            //pega a primeira(first) aula do array e busca pela palavra
            Console.WriteLine("A primeira aula 'Conclusão' é: "
                + aulas.FirstOrDefault(aula => aula.Contains("Conclusão")));

            aulas.Reverse();
            Imprimir(aulas);

            aulas.Reverse();
            Imprimir(aulas);

            aulas.RemoveAt(aulas.Count - 1);
            Imprimir(aulas);

            aulas.Add("Conclusão");
            Imprimir(aulas);

            aulas.Sort();
            Imprimir(aulas);

            List<string> copia = aulas.GetRange(aulas.Count - 2, 2);
            Imprimir(copia);

            List<string> clone = new List<string>(aulas);
            Imprimir(clone);

            clone.RemoveRange(clone.Count - 2, 2);
            Imprimir(clone);


            Console.ReadLine();
        }

        private static void Imprimir(List<string> aulas)
        {
            //foreach (var aula in aulas)
            //{
            //    Console.WriteLine(aula);
            //}

            //for (int i = 0; i < aulas.Count; i++)
            //{
            //    Console.WriteLine(aulas[i]);
            //}

            // lambda
            aulas.ForEach(aula => 
            {
                Console.WriteLine(aula);
            });

        }
    }
}
