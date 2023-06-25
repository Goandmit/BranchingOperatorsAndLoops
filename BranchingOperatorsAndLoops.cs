using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingOperatorsAndLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Проверка на четность числа");
            Console.WriteLine("Введите целое число");
            int integerNum = int.Parse(Console.ReadLine());
            if (integerNum % 2 == 0)
            {
                Console.WriteLine("Введенное число является четным");
            }
            else
            {
                Console.WriteLine("Введенное число является НЕчетным");
            }
            Console.ReadKey();


            Console.WriteLine();


            Console.WriteLine("2. Карточная игра \"21\"");
            Console.WriteLine("Доступные номиналы карт: \nВалет = J (10 очков) \nДама = Q (10 очков) \nКороль = K (10 очков) \nТуз = T (11 очков) \n'Числовая карта' = цифра на карте");
            Console.WriteLine("Введите количество карт");
            int cardsNum = int.Parse(Console.ReadLine());
            int cardsSum = 0;
            for (int cardsCount = 0; cardsCount < cardsNum; cardsCount++)
            {
                Console.WriteLine("Введите номинал карты");
                var cardsVal = Console.ReadLine();
                switch (cardsVal)
                {
                    case "J":
                    case "Q":
                    case "K":
                        cardsSum = cardsSum + 10;
                        break;
                    case "T":
                        cardsSum = cardsSum + 11;
                        break;
                    default:
                        cardsSum = cardsSum + int.Parse(cardsVal);
                        break;
                }
            }
            Console.WriteLine("Сумма карт равна {0}", cardsSum);
            if (cardsSum == 21)
            {
                Console.WriteLine("Вы выйграли!");
            }
            else
            {
                Console.WriteLine("Вы проиграли :(");
            }
            Console.ReadKey();


            Console.WriteLine();


            Console.WriteLine("3. Проверка простого числа");
            Console.WriteLine("Введите число");
            int simpleNum = int.Parse(Console.ReadLine());
            int simpleCount = 2;
            var simpleRemains = 0;
            switch (simpleNum)
            {
                case 0:
                case 1:
                    Console.WriteLine("Введенное число НЕ относится к простым числам");
                    break;
                case 2:
                    Console.WriteLine("Введенное число является простым");
                    break;
                default:
                    while (simpleCount < simpleNum)
                    {
                        simpleRemains = simpleNum % simpleCount;
                        simpleCount++;
                        if (simpleRemains == 0)
                        {
                            Console.WriteLine("Введенное число НЕ относится к простым числам");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Введенное число является простым");
                            break;
                        }
                    }
                    break;
            }                
            Console.ReadKey();


            Console.WriteLine();


            Console.WriteLine("4. Найти наименьший элемент в последовательности");
            Console.WriteLine("Введите длину последовательности");
            int sequenceLen = int.Parse(Console.ReadLine());
            int sequenceMinElem = int.MaxValue;
            int sequenceCount = 0;
            int sequenceNum = 0;
            Console.WriteLine("Введите числа последовательности");
            while (sequenceCount < sequenceLen)
            {
                sequenceNum = int.Parse(Console.ReadLine());                       
                sequenceCount++;
                if (sequenceNum < sequenceMinElem)
                {
                    sequenceMinElem = sequenceNum;
                }
            }
            Console.WriteLine("Наименьший элемент последовательности: " + sequenceMinElem);
            Console.ReadKey();


            Console.WriteLine();


            Console.WriteLine("5. Игра \"Угадай число\"");
            Random rand = new Random();
            Console.WriteLine("Введите максимальное положительное число");
            int guessMaxNum = int.Parse(Console.ReadLine());            
            int guessNum = rand.Next(1, guessMaxNum);
            Console.WriteLine("Программа загадала число");
            string guessUserNum;
            int guessCount = 0;            
            while (true)
            {
                Console.WriteLine("Введите число");
                guessUserNum = Console.ReadLine();                
                guessCount++;
                if (guessUserNum == "")
                {
                    Console.WriteLine("Загаданное число равно " + guessNum);
                    break;
                }
                else                {
                   
                    if (int.Parse(guessUserNum) > guessNum)
                    {
                        Console.WriteLine("Введенное число больше загаданного");
                    }
                    else if (int.Parse(guessUserNum) < guessNum)
                    {
                        Console.WriteLine("Введенное число меньше загаданного");                        
                    }
                    else
                    {
                        Console.WriteLine("Вы выйграли! Количество попыток составило: " + guessCount);
                        break;
                    }
                }              
            }
            Console.ReadKey();
        }
    }
}

