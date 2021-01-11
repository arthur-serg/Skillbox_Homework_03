using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Написать игру, в которою могут играть два игрока.
            // При старте, игрокам предлагается ввести свои никнеймы.
            // Никнеймы хранятся до конца игры.
            // Программа загадывает случайное число gameNumber от minValue до maxValue сообщая это число игрокам.
            // Игроки ходят по очереди(игра сообщает о ходе текущего игрока)
            // Игрок, ход которого указан вводит число userTry, которое может принимать значения 1, 2, 3 или 4,
            // введенное число вычитается из gameNumber
            // Новое значение gameNumber показывается игрокам на экране.
            // Выигрывает тот игрок, после чьего хода gameNumber обратилась в ноль.
            // Игра поздравляет победителя, предлагая сыграть реванш
            // 


            // * Бонус:
            // Подумать над возможностью реализации разных уровней сложности.
            // В качестве уровней сложности может выступать настраиваемое, в начале игры,
            // значение userTry или указание большего количества игроков (3, 4, 5...)

            // *** Сложный бонус
            // Подумать над возможностью реализации однопользовательской игры
            // т е игрок должен играть с компьютером


            // Демонстрация
            // Число: 12,
            // Ход User1: 3
            //
            // Число: 9
            // Ход User2: 4
            //
            // Число: 5
            // Ход User1: 2
            //
            // Число: 3
            // Ход User2: 3
            //
            // User2 победил!

            Random rnd = new Random();
            string playerOne, playerTwo;
            int minValue, maxValue;
            int userTry;
            bool tryAgain = true;

            Console.WriteLine("Player 1, enter your name:");
            playerOne = Console.ReadLine();
            Console.WriteLine("Player 2, enter your name: ");
            playerTwo = Console.ReadLine();
            


            while (tryAgain)
            {
                Console.WriteLine("Enter min value of you Game number:");
                minValue = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter max value of your Game number:");
                maxValue = Convert.ToInt32(Console.ReadLine());

                int gameNumber = rnd.Next(minValue, maxValue);

                Console.WriteLine($"Game number is: { gameNumber}");

                while (gameNumber > 0)
                {
                    Console.WriteLine($"Player {playerOne} enter your TryNumber (in range 1 to 4): ");
                    userTry = Convert.ToInt32(Console.ReadLine());
                    if (userTry == 1 || userTry == 2 || userTry == 3 || userTry == 4)
                    {
                        gameNumber = gameNumber - userTry;
                        if (gameNumber == 0)
                        {
                            Console.WriteLine($"{playerOne} is a winner! Wanna play again? Y/N");
                            {
                                string revengeAnswer = Console.ReadLine();
                                if (revengeAnswer == "Y" || revengeAnswer == "y")
                                {
                                    tryAgain = true;
                                }
                                if (revengeAnswer == "N" || revengeAnswer == "n")
                                {
                                    tryAgain = false;
                                }
                            }
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Incorrect number");
                    }
                    Console.WriteLine($"gameNumber is {gameNumber}");

                    Console.WriteLine($"Player {playerTwo} enter your TryNumber (in range 1 to 4): ");
                    userTry = Convert.ToInt32(Console.ReadLine());
                    if (userTry == 1 || userTry == 2 || userTry == 3 || userTry == 4)
                    {
                        gameNumber = gameNumber - userTry;
                        if (gameNumber == 0)
                        {
                            Console.WriteLine($"{playerTwo} is a winner! Wanna play again? Y/N");
                            {
                                string revengeAnswer = Console.ReadLine();
                                if (revengeAnswer == "Y" || revengeAnswer =="y")
                                {
                                    tryAgain = true;
                                }
                                if (revengeAnswer == "N" || revengeAnswer == "n")
                                {
                                    tryAgain = false;
                                }
                            }
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Incorrect number");
                    }
                    Console.WriteLine($"gameNumber is {gameNumber}");

                }
            }
        }
    }
}
