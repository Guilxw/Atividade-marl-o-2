using System;

namespace Atividade_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\n\n   Atividade 02 - Programação Orientada a Objetos\n   Aluno: Guilherme Pereira - Ciência da Computação");
            //Recebe Entrada do Usuário
            Console.WriteLine("\n\n   > [Selecione uma unidade de medida para referenciar a conversão] <\n");
            Console.WriteLine("   [1] - Quilômetros");
            Console.WriteLine("   [2] - Metros");
            Console.WriteLine("   [3] - Centímetros");
            Console.WriteLine("   [4] - Milímetros");
            Console.WriteLine("   [5] - Micrômetros");
            Console.WriteLine("   [6] - Nanômetros");
            Console.WriteLine("   [7] - Milhas");
            Console.WriteLine("   [8] - Jardas");
            Console.WriteLine("   [9] - Pés");
            Console.WriteLine("   [10] - Polegadas");
            Console.WriteLine("   [11] - Milhas Náuticas");
            Console.Write("\n   Digite aqui qual é a unidade de medida para a entrada >: ");
            int Referencia = Convert.ToInt32(Console.ReadLine());
            //Recebe Unidade de Medida Referente ao Valor Digitado
            Console.Write("\n   Digite qualquer valor para ser convertido >: ");
            double Valor = Convert.ToDouble(Console.ReadLine());
            Console.Clear();

            ConversãoMedidas Variável = new ConversãoMedidas(Valor, Referencia);

            //Recebe Unidade de Medida Para Realizar Conversão
            Console.Write("\n\n   Atividade 02 - Programação Orientada a Objetos\n   Aluno: Guilherme Pereira  - Ciência da Computação");
            Console.WriteLine("\n\n   > [Selecione uma unidade de medida para realizar a conversão] <\n");
            Console.WriteLine("   [1] - Quilômetros");
            Console.WriteLine("   [2] - Metros");
            Console.WriteLine("   [3] - Centímetros");
            Console.WriteLine("   [4] - Milímetros");
            Console.WriteLine("   [5] - Micrômetros");
            Console.WriteLine("   [6] - Nanômetros");
            Console.WriteLine("   [7] - Milhas");
            Console.WriteLine("   [8] - Jardas");
            Console.WriteLine("   [9] - Pés");
            Console.WriteLine("   [10] - Polegadas");
            Console.WriteLine("   [11] - Milhas Náuticas");
            Console.Write("\n   Digite aqui >: ");
            int X = Convert.ToInt32(Console.ReadLine());

            switch (X)
            {
                case 1:
                    Console.WriteLine("\n   > Valor Convertido: " + Variável.Quilometro + " Quilômetros");
                    break;
                case 2:
                    Console.WriteLine("\n   > Valor Convertido: " + Variável.Metro + " Metros");
                    break;
                case 3:
                    Console.WriteLine("\n   > Valor Convertido: " + Variável.Centimetro + " Centímetros");
                    break;
                case 4:
                    Console.WriteLine("\n   > Valor Convertido: " + Variável.Milimetro + " Milímetros");
                    break;
                case 5:
                    Console.WriteLine("\n   > Valor Convertido: " + Variável.Micrometro + " Micrômetros");
                    break;
                case 6:
                    Console.WriteLine("\n   > Valor Convertido: " + Variável.Nanometro + " Nanômetros");
                    break;
                case 7:
                    Console.WriteLine("\n   > Valor Convertido: " + Variável.Milha + " Milhas");
                    break;
                case 8:
                    Console.WriteLine("\n   > Valor Convertido: " + Variável.Jarda + " Jardas");
                    break;
                case 9:
                    Console.WriteLine("\n   > Valor Convertido: " + Variável.Pe + " Pés");
                    break;
                case 10:
                    Console.WriteLine("\n   > Valor Convertido: " + Variável.Polegada + " Polegadas");
                    break;
                case 11:
                    Console.WriteLine("\n   > Valor Convertido: " + Variável.Milhanautica + " Milhas Náuticas");
                    break;
            }
            Console.ReadKey();
        }
    }
}
