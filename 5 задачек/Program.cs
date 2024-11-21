using System;


namespace  _5_задачек
{
    internal class Program
    {
        public enum DayOfWeek
        {
            Понедельник = 1,
            Вторник,
            Среда,
            Четверг,
            Пятница,
            Суббота,
            Воскресенье
        }
        static void Main(string[] args)
        {

            /* Дана последовательность из 10 чисел. Определить, является ли эта последовательность
            упорядоченной по возрастанию. В случае отрицательного ответа определить
            порядковый номер первого числа, которое нарушает данную последовательность.
            Использовать break. */
            Console.WriteLine("");
            Console.WriteLine("Задание 1");
            Console.WriteLine("");

            int[] numbers = new int[10];

            Console.WriteLine("Введите 10 чисел:");
            for (int i = 0; i < 10; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            bool isOrdered = true;
            for (int i = 0; i < 9; i++)
            {
                if (numbers[i] > numbers[i + 1])
                {
                    Console.WriteLine($"Последовательность не упорядочена. Нарушение на позиции: {i + 2}");
                    isOrdered = false;
                    break;
                }
            }

            if (isOrdered)
            {
                Console.WriteLine("Последовательность упорядочена по возрастанию.");
            }


            /*2. Игральным картам условно присвоены следующие порядковые номера в зависимости от
            их достоинства: «валету» — 11, «даме» — 12, «королю» — 13, «тузу» — 14.
            Порядковые номера остальных карт соответствуют их названиям («шестерка»,
            «девятка» и т. п.). По заданному номеру карты k (6 <=k <= 14) определить достоинство
            соответствующей карты. Использовать try-catch-finally.*/
            Console.WriteLine("");
            Console.WriteLine("Задание 2");
            Console.WriteLine("");

            try
            {
                Console.Write("Введите номер карты: ");
                sbyte k = sbyte.Parse(Console.ReadLine());

                if (k < 6 || k > 14)
                {
                    throw new Exception("Номер карты вне допустимого диапазона.");
                }

                string rank;
                switch (k)
                {
                    case 6: rank = "шестерка"; break;
                    case 7: rank = "семерка"; break;
                    case 8: rank = "восьмерка"; break;
                    case 9: rank = "девятка"; break;
                    case 10: rank = "десятка"; break;
                    case 11: rank = "валет"; break;
                    case 12: rank = "дама"; break;
                    case 13: rank = "король"; break;
                    case 14: rank = "туз"; break;
                    default:
                        rank = "";
                        break;
                }

                Console.WriteLine(rank);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Программа завершена");
            }

            /*Напишите программу, которая принимает на входе строку и производит выходные
            данные в соответствии со таблицей*/
            Console.WriteLine("");
            Console.WriteLine("Задание 3");
            Console.WriteLine("");

            Console.Write("Введите кодовое слово: ");
            string job = Console.ReadLine();
            string lower = job.ToLower();
            switch (lower)
            {
                case "jabroni": Console.WriteLine("Patron Tequila"); break;
                case "school counselor": Console.WriteLine("Anything with Alcohol"); break;
                case "programmer": Console.WriteLine("Hipster Craft Beer"); break;
                case "bike gang member": Console.WriteLine("Moonshine"); break;
                case "politician": Console.WriteLine("Your tax dollars"); break;
                case "rapper": Console.WriteLine("Cristal"); break;
                default: Console.WriteLine("Beer"); break;
            }

            /*Составить программу, которая в зависимости от порядкового номера дня недели (1, 2,
            ...,7) выводит на экран его название (понедельник, вторник, ..., воскресенье).
            Использовать enum.*/
            Console.WriteLine("");
            Console.WriteLine("Задание 4");
            Console.WriteLine("");

            Console.WriteLine("Введите порядковый номер дня недели:");
            sbyte dayNumber = sbyte.Parse(Console.ReadLine());

            if (dayNumber >= 1 && dayNumber <= 7)
            {
                DayOfWeek day = (DayOfWeek)dayNumber;
                Console.WriteLine($"День недели: {day}");
            }
            else
            {
                Console.WriteLine("Некорректный номер дня недели.");
            }

            /*Создать массив строк. При помощи foreach обойти весь массив. При встрече элемента
            "Hello Kitty" или "Barbie doll" необходимо положить их в “сумку”, т.е. прибавить к
            результату. Вывести на экран сколько кукол в “сумке”.*/
            Console.WriteLine("");
            Console.WriteLine("Задание 5");
            Console.WriteLine("");

            string[] things = { "Hello Kitty", "Barbie doll", "Tequila", "Marlboro", "Hello Kitty", "Chapman", "lighter" };

            sbyte bagCount = 0;
            foreach (string thing in things)
            {

                if (thing == "Hello Kitty" || thing == "Barbie doll")
                {
                    bagCount++;
                }
            }


            Console.WriteLine($"В сумке {bagCount} кукол.");
        }
    }
}
