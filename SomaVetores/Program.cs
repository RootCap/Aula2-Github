using System.Globalization;

namespace SomaVetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            int N, i;
            double soma, media, mult;

            Console.Write("Quantos números vai digitar? ");
            N = int.Parse(Console.ReadLine());

            double[] vet = new double[N];

            for (i = 0; i < N; i++)
            {
                Console.Write("Digite um número: ");
                vet[i] = double.Parse(Console.ReadLine(), CI);
            }
            Console.WriteLine();

            Console.Write("VETORES = ");
            for (i = 0; i < N; i++) 
            {
                Console.Write(vet[i].ToString("F2", CI) + " ");
            }
            Console.WriteLine();

            soma = 0;
            for (i = 0; i < N; i++)
            {
                soma = soma + vet[i];
            }
            
            for (i = 0; i < N; i++)
            {
                mult = soma * vet[i];
            }


            Console.WriteLine("SOMA = " + soma.ToString("F2", CI));

            media = soma / N;
            Console.WriteLine("MEDIA = " + media.ToString("F2", CI));


        }
    }
}
