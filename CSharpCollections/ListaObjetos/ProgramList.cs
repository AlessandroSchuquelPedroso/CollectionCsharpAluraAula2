using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaObjetos
{
    class ProgramList
    {
        static void Main(string[] args)
        {
            var aulaInto = new Aula("Introdução ás Coleções",20);
            var aulaModelando = new Aula( "Modelando a Classe Aula",18);
            var aulasSets = new Aula( "Trabalhando com Conjuntos",16);

            List<Aula> aulas = new List<Aula>();
            aulas.Add(aulaInto);
            aulas.Add(aulaModelando);
            aulas.Add(aulasSets);
            // aulas.Add("Conclusao");

            Imprimir(aulas);

            //aulas.Sort();
            //Imprimir(aulas);

           //var teste = aulas.OrderBy(aula => aula.Tempo);
           // Imprimir(teste);
            aulas.Sort((este, outro) => este.Tempo.CompareTo(outro.Tempo));
            Imprimir(aulas);

            Console.ReadLine();
        }

        private static void Imprimir(List<Aula> aulas)
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

        class Aula: IComparable
        {
            private string titulo;
            private int tempo;

            public Aula(string titulo, int tempo)
            {
                this.titulo = titulo;
                this.tempo = tempo;
            }

            public string Titulo { get => titulo; set => titulo = value; }
            public int Tempo { get => tempo; set => tempo = value; }

            public int CompareTo(object obj)
            {
                // conversão
                var aulas = obj as Aula;

                return this.titulo.CompareTo(aulas.Titulo);
            }

            public override string ToString()
            {
                return $"[título:{titulo}, tempo:{tempo} minutos]";
            }
        }
    }
}
