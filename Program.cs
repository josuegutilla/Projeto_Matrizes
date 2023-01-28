using System.Runtime.InteropServices;

namespace Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            //double[,] matriz = new double[2, 3];  //criando a matriz com valor

            //Console.WriteLine(matriz.Length); //tamanho total da matriz

            //Console.WriteLine(matriz.Rank); //total de linhas

            //Console.WriteLine(matriz.GetLength(0)); //primeira dimensão (linhas).

            //Console.WriteLine(matriz.GetLength(1)); //segunda dimensão (colunas).

            Console.WriteLine("--------------------------------------");

            Console.Write("Digite um número: ");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            Console.WriteLine();
            Console.WriteLine("Digite " + n + " números " + n +  " vezes: ");

            for(int li = 0; li < n; li++)
            {
                string[] vetor = Console.ReadLine().Split(' ');

                for(int co = 0; co < n; co++)
                {
                    mat[li, co] = int.Parse(vetor[co]);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Main diagonal: ");

            for(int i = 0; i < n; i++)
            {
                Console.Write(mat[i, i] + " ");
            }

            int negativo = 0;
            for(int li = 0; li < n; li++)
            {
                for(int co = 0; co < n; co++)
                {
                    if(mat[li, co] < 0)
                    {
                        negativo++;
                    }
                }
            }

            Console.WriteLine();
            Console.Write("Negative numbers = " + negativo);
        }
    }
}
