using System;

namespace Tabuleiro_de_xadrez
{
    class Program
    {
        static void inicializaMatriz(ref char[][] mapa)
        {
            char a = 'X';
            char b = 'O';
            for (int i = 0; i < 8; i++)
            {
                for (int o = 0; o < 8; o++)
                {
                    if (o % 2 == 0)
                    {
                        mapa[i][o] = a;
                    }
                    else
                    {
                        mapa[i][o] = b;
                    }
                }
                Program.troca(ref a, ref b);
            }
        }

        //Para montar o tabuleiro, precisa alternar se o X vem primeiro ou o O, para imitar o branco e preto foi utilizado X e O, respectivamente
        static void troca(ref char a, ref char b)
        {
            char aux;
            aux = a;
            a = b;
            b = aux;
        }

        static void Main(string[] args)
        {
            char start = '|'; //Boneco que vai andar
            int posX = 0;//Coordenadas do boneco na matriz
            int posY = 0;

            ConsoleKeyInfo tecla; //Tecla apertada pelo usuário
            char[][] mapa = new char[8][]; //Tabuleiro, criando a primeira coluna
            //Cria as linhas da matriz
            for (int i = 0; i < 8; i++)
            {
                mapa[i] = new char[8];
            }
            //

            Program.inicializaMatriz(ref mapa);

            //Apresenta a matriz até que o usuário aperte backspace
            do
            {

                Console.Clear();
                for (int i = 0; i < 8; i++)
                {
                    Console.Write('\t');
                    for (int o = 0; o < 8; o++)
                    {
                        if (posX == i && posY == o)
                        {
                            Console.Write(start); //Lugar onde o personagem atualmente esta
                        }
                        if (o % 2 == 0)
                        {
                            Console.Write(mapa[i][o]);
                        }
                        else
                        {
                            Console.Write(mapa[i][o]);
                        }
                        Console.Write('\t');
                    }
                    Console.WriteLine();
                }
                tecla = Console.ReadKey();
                if (tecla.Key == ConsoleKey.DownArrow)
                {
                    if (posX+1 <= 7)
                    {
                        posX++;
                    }
                }
            } while (tecla.Key != ConsoleKey.Backspace);
        }
    }

}
