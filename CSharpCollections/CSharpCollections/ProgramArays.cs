using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCollections
{
    class ProgramArays
    {
        static void Main(string[] args)
        {
            string aulaInto = "Introdução ás Coleções";
            string aulaModelando = "Modelando a Classe Aula";
            string aulasSets = "Trabalhando com Conjuntos";

            //string[] aulas = new string[]
            //{
            //    aulaInto,
            //    aulaModelando,
            //    aulasSets
            //};

            string[] aulas = new string[3];
            aulas[0] = aulaInto;
            aulas[1] = aulaModelando;
            aulas[2] = aulasSets;

            Imprimir(aulas);
            Console.WriteLine(aulas[0]);
            Console.WriteLine(aulas[aulas.Length - 1]);

            aulas[0] = "Trabalhando com Arrays";
            Imprimir(aulas);

            //procurar o indice
            Console.WriteLine("Aula modelando está no índice " + Array.IndexOf(aulas,aulaModelando));
            Console.WriteLine(Array.LastIndexOf(aulas,aulaModelando));

            Array.Reverse(aulas);
            Imprimir(aulas);

            Array.Reverse(aulas);
            Imprimir(aulas);

            Array.Resize(ref aulas, 2);
            Imprimir(aulas);

            Array.Resize(ref aulas, 3);
            Imprimir(aulas);

            aulas[aulas.Length - 1] = "Conclusão";
            Imprimir(aulas);

            Array.Sort(aulas);
            Imprimir(aulas);

            //pega sempre os dois ultimos do mês
            string[] copia = new string[2];
            Array.Copy(aulas, aulas.Length - 2, copia, 0, 2);
            Imprimir(copia);

            string[] clone = aulas.Clone() as string[];
            Imprimir(clone);

            Array.Clear(aulas, aulas.Length - 2, 2);
            Imprimir(aulas);

            Console.ReadLine();
        }

        private static void Imprimir(string[] aulas)
        {
            //foreach (var aula in aulas)
            //{
            //    Console.WriteLine(aula);

            //}

            for (int i = 0; i < aulas.Length; i++)
            {
                Console.WriteLine(aulas[i]);
            }
        }

    }
}
