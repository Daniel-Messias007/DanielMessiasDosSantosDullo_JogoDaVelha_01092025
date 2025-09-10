using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string j1, j2, j1m, j2m, j3m, j4m, j5m, j6m, j7m, j8m, j9m, lu, lu1, lu2, lu3, lu4, lu5, lu6, lu7, lu8, lu9, lu10;

            lu1 = "a";
            lu2 = "b";
            lu3 = "c";
            lu4 = "d";
            lu5 = "e";
            lu6 = "f";
            lu7 = "g";
            lu8 = "h";
            lu9 = "i";

            Console.WriteLine("Vamos jogar jogo da velha.");
            Console.WriteLine("a | b | c");
            Console.WriteLine("---------");
            Console.WriteLine("d | e | f");
            Console.WriteLine("---------");
            Console.WriteLine("g | h | i");
            Console.WriteLine("Insira X ou O para começar a jogar.");
            j1 = Console.ReadLine();



            while ((j1 != "X") && (j1 != "O") && (j1 != "x") && (j1 != "o"))
            {
                Console.WriteLine("Apenas X e O, digite novamente");
                j1 = Console.ReadLine();
            }
            Console.WriteLine("Insira a letra (lugar) que deseja jogar.");
            lu10 = Console.ReadLine();

            if (lu10 == "a")
            {
                Console.WriteLine(j1 + " | b | c");
                Console.WriteLine("---------");
                Console.WriteLine("d | e | f");
                Console.WriteLine("---------");
                Console.WriteLine("g | h | i");
            }
            if (lu10 == "b")
            {
                Console.WriteLine("a | " + j1 + " | c");
                Console.WriteLine("---------");
                Console.WriteLine("d | e | f");
                Console.WriteLine("---------");
                Console.WriteLine("g | h | i");
            }
            if (lu10 == "c")
            {
                Console.WriteLine("a | b | " + j1);
                Console.WriteLine("---------");
                Console.WriteLine("d | e | f");
                Console.WriteLine("---------");
                Console.WriteLine("g | h | i");
            }
            if (lu10 == "d")
            {
                Console.WriteLine("a |  b  | c");
                Console.WriteLine("---------");
                Console.WriteLine(j1 + " | e | f");
                Console.WriteLine("---------");
                Console.WriteLine("g | h | i");
            }
            if (lu10 == "e")
            {
                Console.WriteLine("a | b | c");
                Console.WriteLine("---------");
                Console.WriteLine("d | " + j1 + " | f");
                Console.WriteLine("---------");
                Console.WriteLine("g | h | i");
            }
            if (lu10 == "f")
            {
                Console.WriteLine("a | b | c");
                Console.WriteLine("---------");
                Console.WriteLine("d | e | " + j1);
                Console.WriteLine("---------");
                Console.WriteLine("g | h | i");
            }
            if (lu10 == "g")
            {
                Console.WriteLine("a | b | c");
                Console.WriteLine("---------");
                Console.WriteLine("d | e | f");
                Console.WriteLine("---------");
                Console.WriteLine(j1 + " | h | i");
            }
            if (lu10 == "h")
            {
                Console.WriteLine("a | b | c");
                Console.WriteLine("---------");
                Console.WriteLine("d | e | f");
                Console.WriteLine("---------");
                Console.WriteLine("g | " + j1 + " | i");
            }
            if (lu10 == "i")
            {
                Console.WriteLine("a | b | c");
                Console.WriteLine("---------");
                Console.WriteLine("d | e | f");
                Console.WriteLine("---------");
                Console.WriteLine("g | h | " + j1);
            }

            Console.WriteLine("Vez da máquina...");
            Console.WriteLine("Aperte ENTER para ver.");
            Console.ReadKey();


            Random sorteio = new Random();
            int numeroSorteado = sorteio.Next(1, 9);

            // se o número sorteado for "1" (b) e se o lugar que o jogador escolheu for "a"
            if ((numeroSorteado == 1) && (lu10 == "a"))
            {
                // se a jogada que o jogador escolheu for X
                if (j1 == "X")
                {
                    j1m = "O";
                    Console.WriteLine(j1 + " | " + j1m + " | c");
                    Console.WriteLine("---------");
                    Console.WriteLine("d | e | f");
                    Console.WriteLine("---------");
                    Console.WriteLine("g | h | i");
                }

                // se a jogada que o jogador escolheu for O
                else
                {
                    j1m = "X";
                    Console.WriteLine(j1 + " | " + j1m + " | c");
                    Console.WriteLine("---------");
                    Console.WriteLine("d | e | f");
                    Console.WriteLine("---------");
                    Console.WriteLine("g | h | i");
                }
            }

            // se o número sorteado for "2" (c), e se o lugar que o jogador escolheu foi "a"
            if ((numeroSorteado == 2) && (lu10 == "a"))
            {

                // se a jogada que o jogador fez for X
                if (j1 == "X")
                {
                    j1m = "O";
                    Console.WriteLine(j1 + " | b | " + j1m);
                    Console.WriteLine("---------");
                    Console.WriteLine("d | e | f");
                    Console.WriteLine("---------");
                    Console.WriteLine("g | h | i");
                }

                // se o jogador que o jogador escolheu for O
                else
                {
                    j1m = "X";
                    Console.WriteLine(j1 + " | b | " + j1m);
                    Console.WriteLine("---------");
                    Console.WriteLine("d | e | f");
                    Console.WriteLine("---------");
                    Console.WriteLine("g | h | i");
                }
            }

            // se o número sorteado for "3" (d) e o lugar foi "a"
            if ((numeroSorteado == 3) && (lu10 == "a"))
            {
                // se a jogada do jogador for X
                if (j1 == "X")
                {
                    j1m = "O";
                    Console.WriteLine(j1 + " | b | c");
                    Console.WriteLine("---------");
                    Console.WriteLine(j1m + " | e | f");
                    Console.WriteLine("---------");
                    Console.WriteLine("g | h | i");
                }

                // se a jogada do jogador for O
                else
                {
                    j1m = "X";
                    Console.WriteLine(j1 + " | b | c");
                    Console.WriteLine("---------");
                    Console.WriteLine(j1m + " | e | f");
                    Console.WriteLine("---------");
                    Console.WriteLine("g | h | i");
                }
            }

            // se o número sorteado for "4" (e) e o lugar foi "a"
            if ((numeroSorteado == 4) && (lu10 == "a"))
            {

                // se a jogada do jogador for X
                if (j1 == "X")
                {
                    j1m = "O";
                    Console.WriteLine(j1 + " | b | c");
                    Console.WriteLine("---------");
                    Console.WriteLine("d | " + j1m + " | f");
                    Console.WriteLine("---------");
                    Console.WriteLine("g | h | i");
                }

                // se a jogada do jogador for O
                else
                {
                    j1m = "X";
                    Console.WriteLine(j1 + " | b | c");
                    Console.WriteLine("---------");
                    Console.WriteLine("d | " + j1m + " | f");
                    Console.WriteLine("---------");
                    Console.WriteLine("g | h | i");
                }
            }
            // se o número sorteado for "5" (f) e o lugar for "a"
            if ((numeroSorteado == 5) && (lu10 == "a"))
            {

                // se a jogada for X
                if (j1 == "O")
                {
                    j1m = "X";
                    Console.WriteLine(j1 + " | b | c");
                    Console.WriteLine("---------");
                    Console.WriteLine("d | e | " + j1m);
                    Console.WriteLine("---------");
                    Console.WriteLine("g | h | i");
                }

                // se a jogada for O
                else
                {
                    j1m = "O";
                    Console.WriteLine(j1 + " | b | c");
                    Console.WriteLine("---------");
                    Console.WriteLine("d | e | " + j1m);
                    Console.WriteLine("---------");
                    Console.WriteLine("g | h | i");
                }
            }
            // se o número sorteado for "6" (g) e o lugar for "a"
            if ((numeroSorteado == 6) && (lu10 == "a"))
            {

                // se a jogada for X
                if (j1 == "X")
                {
                    j1m = "O";
                    Console.WriteLine(j1 + " | b | c");
                    Console.WriteLine("---------");
                    Console.WriteLine("d | e | f");
                    Console.WriteLine("---------");
                    Console.WriteLine(j1m + " | h | i");
                }
                // se a jogada for O
                else
                {
                    j1m = "X";
                    Console.WriteLine(j1 + " | b | c");
                    Console.WriteLine("---------");
                    Console.WriteLine("d | e | f");
                    Console.WriteLine("---------");
                    Console.WriteLine(j1m + " | h | i");
                }
            }
            // se o número sorteado for "7" (h) e o lugar foi "a"
            if ((numeroSorteado == 7) && (lu10 == "a"))
            {

                // se a jogada for X
                if (j1 == "X")
                {
                    j1m = "O";
                    Console.WriteLine(j1 + " | b | c");
                    Console.WriteLine("---------");
                    Console.WriteLine("d | e | f");
                    Console.WriteLine("---------");
                    Console.WriteLine("g | " + j1m + " i|");
                }

                // se a jogada for O
                else
                {
                    j1m = "X";
                    Console.WriteLine(j1 + " | b | c");
                    Console.WriteLine("---------");
                    Console.WriteLine("d | e | f");
                    Console.WriteLine("---------");
                    Console.WriteLine("g | " + j1m + " i|");
                }
            }

            // se o número sorteado for "8" (i) e o lugar for "a"
            if ((numeroSorteado == 8) && (lu10 == "a"))
            {
                if (j1 == "X")
                {
                    j1m = "O";
                    Console.WriteLine(j1 + " | b | c");
                    Console.WriteLine("---------");
                    Console.WriteLine("d | e | f");
                    Console.WriteLine("---------");
                    Console.WriteLine("g | h | " + j1m);
                }

                else
                {
                    j1m = "X";
                    Console.WriteLine(j1 + " | b | c");
                    Console.WriteLine("---------");
                    Console.WriteLine("d | e | f");
                    Console.WriteLine("---------");
                    Console.WriteLine("g | h | " + j1m);


                }
            }
        }
    }

}
            




           