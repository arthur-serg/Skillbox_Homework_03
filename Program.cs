using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_03
{
    class Program
    {
        
        /// <summary>
        /// Main
        /// </summary>
        /// <param name="args"></param>
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
            // значение userTry.

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


            
            string playerOne; //никнейм

            
            int minValue, maxValue; //минимальная и максимальная граница исходного числа.
            int userTryMinValue, userTryMaxValue; //минимальная (по умолчанию 1) и максимальная граница числа, вводимого игроком либо генерируемого ПК.
            int userTry; //число, которое будет вычитаться из исходного.
            bool tryAgain = true; //флаг для запуска игры заново.

            Console.WriteLine("Please enter your name:");
            playerOne = Console.ReadLine();

            while (tryAgain)
            {
                Console.WriteLine("Enter min value of you Game number:");
                minValue = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter max value of your Game number:");
                maxValue = Convert.ToInt32(Console.ReadLine());

                
                userTryMinValue = 1;
                Console.WriteLine("Enter max value of your TryNumber:");
                userTryMaxValue = Convert.ToInt32(Console.ReadLine());

                
                int gameNumber = rnd.Next(minValue, maxValue+1); //генерируем случайное целое число из заданного интервала

                Console.WriteLine($"After your turn Game number is: { gameNumber}"); 


                //До тех пор пока не выполнены условия конца игры (gameNumber != 0)
                while (gameNumber > 0)
                {
                    Console.WriteLine($"Player {playerOne} enter your integer TryNumber in range from {userTryMinValue} to {userTryMaxValue}: ");
                    userTry = Convert.ToInt32(Console.ReadLine());

                    //Проверка на неотрицательность gameNumber после хода.
                    if (userTry >= userTryMinValue && userTry <= userTryMaxValue)
                    {
                        //Обновляем gameNumber
                        gameNumber = gameNumber - userTry;

                        //Конец игры, игрок победил. Спрашиваем о повторной игре.Если условия победы не выполнены, то передаём ход ПК.
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
                    Console.WriteLine($"After AI's turn Game Number is {gameNumber}");

                    //ПК генерирует вычитаемое число из заданного отрезка
                    int pcTry = rnd.Next(userTryMinValue, userTryMaxValue+1);

                    //Проверка на неотрицательность gameNumber после хода ПК.


                    //ПРОБЛЕМА: если ПК генерирует число, заведомо большее чем gameNumber, то его ход пропускается и сразу передается игроку.

                    while (pcTry > 0 && pcTry <= gameNumber)
                    {
                        Console.WriteLine($"AI tries with: {pcTry}");

                        //Обновляем gameNumber
                        gameNumber = gameNumber - pcTry;

                        //Конец игры, игрок проиграл. Спрашиваем о повторной игре.Если условия победы не выполнены, то передаём ход игроку.
                        if (gameNumber == 0)
                        {
                            Console.WriteLine($"Loser! Wanna play again? Y/N");
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
                        else break;

                    }
                    Console.WriteLine($"GameNumber is {gameNumber}");
                }
            }
        }
    }
}
