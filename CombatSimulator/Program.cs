using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace CombatSimulator
{
    class Program
    {

        static Random rng = new Random();
        static int FinnAndJakeHP = 100;
        static int IceKingHP = 200;

        /// <summary>
        /// play the game
        /// </summary>
        /// <param name="args">while player is alive</param>
        static void Main(string[] args)
        {

            while (FinnAndJakeHP > 0 && IceKingHP > 0)
            {
                Console.Clear();
                Welcome();
            }
            GameOver();
            Console.ReadKey();
        }

        /// <summary>
        /// presents the HP of player and Ice King
        /// </summary>
        static void Stats()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"
                                                Finn & Jake HP: " + FinnAndJakeHP +
                                @"
                                                Ice King HP: " + IceKingHP + " ");
            Console.ResetColor();
        }
        /// <summary>
        /// welcomes the user
        /// </summary>
        static void Welcome()
        {
            Typewriter(@" 

        Adventure Time! C'mon and grab your friends 
        We'll go to very distant lands! ♫
        With Jake the Dog and Finn the Human ♫♫
        The adventures'll never end
");

            Typewriter(@"
            it's...
");
            System.Threading.Thread.Sleep(600);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"
  █████╗ ██████╗ ██╗   ██╗███████╗███╗   ██╗████████╗██╗   ██╗██████╗ ███████╗ 
 ██╔══██╗██╔══██╗██║   ██║██╔════╝████╗  ██║╚══██╔══╝██║   ██║██╔══██╗██╔════╝
 ███████║██║  ██║██║   ██║█████╗  ██╔██╗ ██║   ██║   ██║   ██║██████╔╝█████╗  
 ██╔══██║██║  ██║╚██╗ ██╔╝██╔══╝  ██║╚██╗██║   ██║   ██║   ██║██╔══██╗██╔══╝  
 ██║  ██║██████╔╝ ╚████╔╝ ███████╗██║ ╚████║   ██║   ╚██████╔╝██║  ██║███████╗
 ╚═╝  ╚═╝╚═════╝   ╚═══╝  ╚══════╝╚═╝  ╚═══╝   ╚═╝    ╚═════╝ ╚═╝  ╚═╝╚══════╝");
            System.Threading.Thread.Sleep(400);
            Console.WriteLine(@"
            ████████╗██╗███╗   ███╗███████╗    ██╗
            ╚══██╔══╝██║████╗ ████║██╔════╝    ██║
               ██║   ██║██╔████╔██║█████╗      ██║
               ██║   ██║██║╚██╔╝██║██╔══╝      ╚═╝
               ██║   ██║██║ ╚═╝ ██║███████╗    ██╗
               ╚═╝   ╚═╝╚═╝     ╚═╝╚══════╝    ╚═╝
");

            System.Threading.Thread.Sleep(1200);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("                               What is your name?? ");
            string playerName = Console.ReadLine();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Typewriter(@"
     Great " + playerName + @"! Finn and Jake need your help. The evil Ice King has 
     kidnapped Princess Bubblegum in hopes to make her his bride.");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine(@"
     
     Ice King can draw magical powers from his crown. However, without it, 
     he is POWERLESS. In order to set Princess Bubblegum free you must find 
     a way to defeat Ice King and remove his crown.");
            Console.Write("\n\n     Are you ready?? ");
            bool playing = true;

            while (playing)
            {
                string answer = Console.ReadLine();
                if (answer.ToLower() == "yes" || answer.ToLower() == "yes ")
                {
                    Typewriter("\n     That's what I like to hear!! Let's go!! \n");
                    System.Threading.Thread.Sleep(2000);
                    playing = false;
                    Play();
                }
                else
                {
                    Console.Write(@"
   Wrong answer!! Try again. Are you ready? ");
                    System.Threading.Thread.Sleep(600);
                    playing = true;
                }
            }


        }

        /// <summary>
        /// Storyline
        /// </summary>
        static void Play()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Stats();
            Console.WriteLine(@"
        From the land of Ooo, Finn and Jake travel through snow-capped 
        mountains and snowy hills. They finally arrive at Ice King's castle 
        where Princess Bubblegum is locked up behind ice bars. Jake manages
        to turn into a key hand and enters the castle. Enter the 
        number to choose what they should do next.");
            userTurn();
        }

        /// <summary>
        /// Player enteres weapon of choice
        /// </summary>
        static void userTurn()
        {
            bool invalid = true;

            while (invalid)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n       1. Finn's sword     2. Jake's stretchy powers    3. Summon Beemo \n");
                string playerChoice = Console.ReadLine();
                Console.WriteLine("\n");
                Stats();
                if (playerChoice == "1")
                {
                    Sword();
                    invalid = false;
                }
                else if (playerChoice == "2")
                {
                    StretchyPowers();
                    invalid = false;
                }
                else if (playerChoice == "3")
                {
                    Beemo
                        ();
                    invalid = false;
                }
                else
                {
                    Typewriter("\nInvalid input. Try again. \n");
                    invalid = true;
                }
            }
        }

        /// <summary>
        /// Jake's stretchy but powerful attacks
        /// </summary>
        static void StretchyPowers()
        {
            List<string> jakesStretchyPowers = new List<string>() { "\nJake stretches into a Slingshot and Jake is catapulted into Ice King's chest!", "\nJake shape shifts into a spiral around Ice King until he is dizzy!\n" };
            string jakesAttack = jakesStretchyPowers[rng.Next(0, jakesStretchyPowers.Count)];
            int stretchyDamage = rng.Next(20, 36);
            int StretchyAttack = rng.Next(1, 11);
            if (StretchyAttack < 8)
            {
                IceKingHP -= stretchyDamage;
                Stats();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(@"
        ░░░░░░▄▄▄▀▀▀▀█▄▄▄░░░░░░░░░░░█▄░░░░
        ░░░▄█▀▀░░░░░░░░░▀▀█▄▄▄▄▄▄▄░░█▀▄░░░
        ░▄██▄░░░░░░░░░░░░░░░▀▄░░░▀▀██▄█░░░
        ▄▀▀░▀▀█▄░░░░░▄█▀▀█▄▄░▀█░░░░░░▀█▄░░
        █░░░░░▄█▄▄▄▄█▀░░░░░█░░█▄░░░░░░░▀▄░
        █▄░░▄▀▀░░░░▀▀▄▄░░░░█▄░░█░░░░░░░░█▄
        ████▀░░▄▄▄▄░░░▀▄▄▄██░░░█░░░░░░░░░█     
        ░██░░░░█▀▀▀█░░░░█░░░▀▀▀░░░░░░░░░▄█
        ░▀█▀▄▄█▀░░░▀█░░█▀░░░░░░░░░░░░░▄█░░
        ░░▀█░░░░░░░░░▀▀░░░░░░░░░░░░▄██░█░░
        ░░░░██▄░░░░░░░░░░░░░░░░▄▄█▀░██░█░░
        ░░░░█░▀█▀▀█▄▄▄▄▄▄▄▄██▀▀█░░░░██░█░░
        ░░░░█░░█░░░░░█░░█░░░█░░█░░░░██░█░░
        ░▄▄▄█░░█░░▄▄▄█░░█░▄▀▀░░█░░░▄██░█░░
        ▀█▄▄▄▄▄█░░█▄▄▄▄▄█░░▀▀▀▀░░░░█▄▄▄█░░");
                Console.WriteLine(jakesAttack);
                System.Threading.Thread.Sleep(1600);
                Console.WriteLine("\"OOOMPHHH!!!,\" Ice King cries. That did " + stretchyDamage + " HP of damage!!");
                System.Threading.Thread.Sleep(1000);
                if (IceKingHP > 0)
                {
                    Typewriter("Ice King will now attack...");
                    System.Threading.Thread.Sleep(1000);
                    iceKing();
                }
                else
                {
                    GameOver();
                }

            }
            else
            {
                Stats();
                Typewriter("\nYou missed... sorry..\n");
                Typewriter("\n Ice King will now attack...\n");
                System.Threading.Thread.Sleep(1300);
                iceKing();

            }
        }
        /// <summary>
        /// Jake attacks with a sword
        /// </summary>
        static void Sword()
        {
            Console.ForegroundColor = ConsoleColor.White;
            int swordAttack = rng.Next(10, 16);
            IceKingHP -= swordAttack;

            Stats();
            Console.WriteLine(@"
        ──▄▄▄─────────▄▄▄
        ▄▀───▀▄─────▄▀───▀▄    
        █─────▀▀▀▀▀▀▀─────█                /\
        █────▄▄▄▄▄▄▄▄▄────█      _         )( ______________________
        █──▄▀─────────▀▄──█     (_)///////(**)______________________>
        █──█──▀─────▀──█──█                )(
        █──█───▄───▄───█──█     
        █──█────▀▀▀────█──█
        █───▀▄▄▄▄▄▄▄▄▄▀───█

");
            Console.WriteLine("Jake's sword lights on fire and it does " + swordAttack + " HP of damage!!\n");
            System.Threading.Thread.Sleep(1200);
            if (IceKingHP > 0)
            {
                Typewriter("\n Ice King will now attack...\n");
                System.Threading.Thread.Sleep(1300);
                iceKing();
            }
            else
            {
                GameOver();
            }
        }
        /// <summary>
        /// Beemo heals Finn and Jake
        /// </summary>
        static void Beemo()
        {
            int Heals = rng.Next(10, 21);
            FinnAndJakeHP += Heals;

            Stats();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"
        ________________________
    ░░░░█░____________________░█░░░░
    ░░░░█░█░░░░░░░░░░░░░░░░░░█░█░░░░
    ░░░░█░█░░█░░░░░░░░░░░░█░░█░█░░░░
    ░░░░█░█░░░░░▄▄▄▄▄▄▄▄░░░░░█░█░░░░       Beemo appears and heals Finn
    ░░░░█░█░░░░░▀▄░░░░▄▀░░░░░█░█░░░░       and Jake with " + Heals + @" HP
    ░░░░█░█░░░░░░░▀▀▀▀░░░░░░░█░█░░░░       
    ░█▌░█░▀__________________▀░█░▐█░
    ░█░░█░░░░░░░░░░░░░░░░░░░░░░█░░█░
    ░█░░█░████████████░░░░░██░░█░░█░
    ░█░░█░░░░░░░░░░░░░░░▄░░░░░░█░░█░
    ░▀█▄█░░░▐█▌░░░░░░░▄███▄░██░█▄█▀░
    ░░░▀█░░█████░░░░░░░░░░░░░░░█▀░░░
    ░░░░█░░░▐█▌░░░░░░░░░▄██▄░░░█░░░░
    ░░░░█░▄▄▄░▄▄▄░░░░░░░▀██▀░░░█░░░░
    ░░░░▀______________________▀░░░░
    ░░░░░░░░██░░░░░░░░░░░░██░░░░░░░░
    ░░░░░░░░██░░░░░░░░░░░░██░░░░░░░░
    ░░░░░░░▐██░░░░░░░░░░░░██▌░░░░░░░");
            System.Threading.Thread.Sleep(2400);
            Typewriter("\nIce King will now attack...");
            System.Threading.Thread.Sleep(1800);
            iceKing();

        }
        /// <summary>
        /// Ice King attacks
        /// </summary>
        static void iceKing()
        {
            while (FinnAndJakeHP > 0 && IceKingHP > 0)
            {
                List<string> iceKingattack = new List<string>() {@"
      \__    __/
      /_/ /\ \_\
     __ \ \/ / __
     \_\_\/\/_/_/
 __/\___\_\/_/___/\__
   \/ __/_/\_\__ \/
     /_/ /\/\ \_\
      __/ /\ \__
      \_\ \/ /_/
      /        \
Ice King uses his magical crown and casts an avalaunche of ice and snow. It freezes Jake and Finn!", @"
  _       _              _
_{v}_    (v)     ('>    ( )
 /-\    //-\\    /V\   // \\
(\_/)   (\_/)   <(_)   (\=/)
 ^ ^     ^ ^      ~~    ~ ~
Ice King summons Gunter to distract Finn and Jake with a penguin dance. 
Meanwhile, Ice King pokes and prods Finn & Jake."};
                string iceKingRandom = iceKingattack[rng.Next(0, iceKingattack.Count)];
                int dragonsTurn = rng.Next(1, 11);
                int iceKingAttack = rng.Next(5, 16);
                if (dragonsTurn < 9)
                {
                    FinnAndJakeHP -= iceKingAttack;
                    Stats();
                    Console.WriteLine(iceKingRandom);
                    System.Threading.Thread.Sleep(1700);
                    Console.WriteLine("\nIt causes " + iceKingAttack + " HP of damage :( \n");
                    System.Threading.Thread.Sleep(1500);
                    Typewriter("It is now your turn to attack.\n");
                    System.Threading.Thread.Sleep(1500);
                    userTurn();
                }
                else
                {
                    Stats();
                    Typewriter("\nThe Ice King missed. It is now your turn.\n");
                    System.Threading.Thread.Sleep(1200);
                    userTurn();
                }

            }
            GameOver();
        }

        /// <summary>
        /// Ends the game
        /// </summary>
        static void GameOver()
        {
            if (IceKingHP < 1 && FinnAndJakeHP > 0)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(@"
                      | 
|_  _  _  __ _  \/    | 
| |(_)(_) | (_| /     o 

");
                System.Threading.Thread.Sleep(600);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(@"
                      |                       | 
|_  _  _  __ _  \/    |    |_  _  _  __ _  \/ | 
| |(_)(_) | (_| /     o    | |(_)(_) | (_| /  o 
");
                System.Threading.Thread.Sleep(600);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(@"
                      |                       |                       |
|_  _  _  __ _  \/    |    |_  _  _  __ _  \/ | |_  _  _  __ _  \/    |
| |(_)(_) | (_| /     o    | |(_)(_) | (_| /  o | |(_)(_) | (_| /     o
");
                System.Threading.Thread.Sleep(600);
                Stats();
                Typewriter("\n You defeated Ice King! You have set Princess Bubblegum free!\n");
                Console.WriteLine("\n Would you like to play again? \n  Type 'yes' otherwise hit any key to exit.");
                string playAgain = Console.ReadLine();
                if (playAgain.ToLower() == "yes")
                {
                    FinnAndJakeHP = 100;
                    IceKingHP = 200;
                    Play();
                }
                else
                {
                    System.Environment.Exit(-1);
                }

            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Stats();
                Console.WriteLine("\nSorry... you lost... Ice King has defeated you. Princess Bubblegum will be forced to marry Ice King! \n");
                Console.WriteLine("\n Would you like to play again? Type 'yes' otherwise hit any key to exit.");
                string answer = Console.ReadLine();
                if (answer.ToLower() == "yes")
                {
                    FinnAndJakeHP = 100;
                    IceKingHP = 200;
                    Play();
                }
                else
                {
                    System.Environment.Exit(-1);
                }
            }
        }
        /// <summary>
        /// prints word letter by letter
        /// </summary>
        /// <param name="input">input</param>
        static void Typewriter(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(input[i]);
                System.Threading.Thread.Sleep(25);
            }
        }



    }
}
