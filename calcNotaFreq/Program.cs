using System;

namespace calcNotaFreq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o nome do aluno: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Informe a quantidade de aulas dadas: ");
            int aulasDadas = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quantidade de falta: ");
            int falta = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a nota da NP1: ");
            float np1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Informe a nota da NP2: ");
            float np2 = float.Parse(Console.ReadLine());
            float mediaExame = 0;
            float media = (np1 + np2) / 2;
            bool reprovouPorFalta = false;
            bool ficouExame = false;

            if ((falta * 100) / aulasDadas > 25)
            {
                reprovouPorFalta = true;
                Console.WriteLine($"O aluno {nome} reprovou por falta.");
            }
            // if ((media > 7) && (reprovouPorFalta == false))
            // {
            //     Console.WriteLine("Passou!");
            // }
            if ((media < 7) && (reprovouPorFalta == false))
            {
                Console.WriteLine($"O aluno {nome} ficou de exame. Informe a nota do exame");
                float notaExame = float.Parse(Console.ReadLine());
                mediaExame = (np1 + np2 + notaExame) / 3;
                if (mediaExame < 5)
                    ficouExame = true;
            }
            if ((ficouExame == false) && (reprovouPorFalta == false))
            {
                Console.WriteLine("Passou mardito.");
            }
            else
            {
                Console.WriteLine($"Reprovado com media de exame {Math.Round(mediaExame,2)}");
            }
        }
    }
}
