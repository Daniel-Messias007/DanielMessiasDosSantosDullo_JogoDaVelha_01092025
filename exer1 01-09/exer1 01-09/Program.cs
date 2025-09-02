using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x1, x2, x3, x4, x5, x6, x7, x8, x9;
            string j1, j2, j3, j4, j5, j6, j7, j8, j9, j1m, j2m, j3m, j4m, j5m, j6m, j7m, j8m, j9m, lu, lu1, lu2, lu3, lu4, lu5, lu6, lu7, lu8, lu9, lu10, lu11;

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


            Random sorteio = new Random();
            int numeroSorteado = sorteio.Next(1, 3);
            Console.WriteLine("O número sorteado foi: " + numeroSorteado);

            if ((numeroSorteado == 1) && (lu10 == "a"))
            {
                Console.WriteLine("A máquina írá escolher outro número, pois, o escolhido já está ocupado.");
            }
            Random sorteio1 = new Random();

            int numeroSorteado1 = sorteio.Next(1, 3);
            Console.WriteLine("O número sorteado foi: " + numeroSorteado1);


            if ((numeroSorteado1 == 2) && (lu10 == "a"))
            {
                j1m = "O";
                Console.WriteLine(j1 + " |" + j1m + " | c");
                Console.WriteLine("---------");
                Console.WriteLine("d | e | f");
                Console.WriteLine("---------");
                Console.WriteLine("g | h | i");
            }
            if ((numeroSorteado1 == 3) && (lu10 == "a"))
            {
                j2m = "O";
                Console.WriteLine(j1 + " | b | " + j2m);
                Console.WriteLine("---------");
                Console.WriteLine("d | e | f");
                Console.WriteLine("---------");
                Console.WriteLine("g | h | i");


            }
        }
    }
}
            




           