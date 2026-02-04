using System;
using System.Collections.Generic;
using System.Runtime;
using System.Text;

namespace JogarDados
{
    public class Display
    {
        public string J1, J2;
        public int P1, P2, R1, R2;

        public void Introduction()
        {
            Console.WriteLine("=========JOGAR DADOS=========\n\n");
            Console.WriteLine("Regras do jogo:\n");
            Console.WriteLine("1 - O jogo suporta apenas dois jogadores.");
            Console.WriteLine("2 - O jogo acaba quando um dos jogadores fizer mais que 3 pontos.");
            Console.WriteLine("3 - Em caso de empate a partida contará como nula e uma nova rodada será iniciada.");
            Console.WriteLine("4 - O jogo será reiniciado caso os dois nomes sejam iguais.");
            Console.WriteLine(@"5 - Em caso de desistencia, na digitação do nome, escreva a palavra ""sair"".");
            Console.WriteLine("\n\nTenha uma boa disputa e que o melhor vença!!");
            Console.ReadKey();
            Console.Clear();

        }
        public void Names()
        {

            do
            {
                Console.Clear();

                Console.Write("Digite o nome do primeiro participante: ");
                J1 = Console.ReadLine();

                if (J1.ToLower() == "sair")
                {
                    Console.WriteLine("Até mais!");
                    Environment.Exit(0);
                }

                Console.Write("Digite o nome do segundo participante: ");
                J2 = Console.ReadLine();

                if (J2.ToLower() == "sair")
                {
                    Console.WriteLine("Até mais!");
                    Environment.Exit(0);
                }

                if (J1.ToLower() == J2.ToLower())
                {
                    Console.WriteLine("Foram digitados nomes iguais, tente novamente!");
                }

            } while (J1.ToLower() == J2.ToLower());
        }
        public void Score()
        {
            Random rng = new Random();

            P1 = 0;
            P2 = 0;
            R1 = 0;
            R2 = 0;

            Console.Clear();

            do
            {
                int roll1 = rng.Next(1, 7);
                int roll2 = rng.Next(1, 7);

                P1 = roll1;
                P2 = roll2;

                if (P1 != P2)
                {
                    if (P1 > P2)
                    {
                        R1 += 1;
                        Console.WriteLine($"{J1} tirou o número {P1} e {J2} o número {P2}. {J1} marcou {R1} pontos.");
                    }
                    else
                    {
                        R2 += 1;
                        Console.WriteLine($"{J1} tirou o número {P1} e {J2} o número {P2}. {J2} marcou {R2} pontos.");

                    }
                }
                else
                {
                    Console.WriteLine("Empate! Jogando novamente...");
                }

                Console.ReadKey();

                if (R1 == 3 || R2 == 3)
                {
                    if (R1 > R2)
                    {
                        Console.WriteLine($"\n{J1} venceu a disputa, meus parabéns!!");
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine($"\n{J2} venceu a disputa, meus parabéns!!");
                        Environment.Exit(0);
                    }
                }
            } while (true);
        }
    }
}