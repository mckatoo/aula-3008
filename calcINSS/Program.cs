using System;

namespace calcINSS
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double salarioBruto, salarioLiquido, INSS, IRRF, deducaoIR;

            Console.WriteLine("Nome:");
            nome = Console.ReadLine();

            Console.WriteLine("Informe o salário bruto:");
            salarioBruto = float.Parse(Console.ReadLine());

            // CALC INSS
            INSS = (salarioBruto * 0.11);
            if (salarioBruto < 1693.73)
                INSS = salarioBruto * 0.08;
            if ((salarioBruto > 1693.72) && (salarioBruto < 2822.91))
                INSS = (salarioBruto * 0.09);

            // CALC IRRF
            IRRF = 0;
            deducaoIR = 0;
            if ((salarioBruto > 1903.98) && (salarioBruto < 2826.66))
                IRRF = salarioBruto * 0.075 - 142.80;
            if ((salarioBruto > 2826.65) && (salarioBruto < 3751.06))
                IRRF = salarioBruto * 0.15 - 354.80;
            if ((salarioBruto > 3751.05) && (salarioBruto < 4664.69))
                IRRF = salarioBruto * 0.225 - 636.13;
            if (salarioBruto > 4664.68)
                IRRF = salarioBruto * 0.275 - 869.36;

            // CALC GERAL
            salarioLiquido = salarioBruto - INSS - IRRF;
            Console.WriteLine($"INSS: {INSS}");
            Console.WriteLine($"Imposto de renda: {IRRF}");
            Console.WriteLine($"Salário líquido é: {salarioLiquido}");
        }
    }
}
