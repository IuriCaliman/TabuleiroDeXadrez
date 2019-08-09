using System;

namespace Tabuleiro_de_xadrez
{
    class Program
    {
        static void troca(ref char a, ref char b, out string fez)
        {
            char aux;
            aux = a;
            a = b;
            b = aux;

            fez = "              Aproveite o seu tabuleiro!";
        }
        static void Main(string[] args)
        {
            char start = '|';
            char a = 'X';
            char b = 'O';
            string fez;
            ConsoleKeyInfo tecla;
            char[][] mapa = new char[8][];
            for (int i = 0; i < 8; i++)
            {
                mapa[i] = new char[8];
            }
            
            do
            {
                Console.Clear();
                Console.Write(start);
                for (int i = 0; i < 8; i++)
                {
                    for (int o = 0; o < 8; o++)
                    {
                        if (o % 2 == 0)
                        {
                            mapa[i][o] = a;
                            Console.Write(a);
                        }
                        else
                        {
                            mapa[i][o] = b;
                            Console.Write(b);
                        }
                    }
                    Program.troca(ref a, ref b, out fez);
                    Console.WriteLine();
                }

                
                //tecla = Console.ReadKey();

            } while (true);
        }
    }

}
