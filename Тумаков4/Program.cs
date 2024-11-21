using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Тумаков4
{

    internal class Program
    {
        static string GetMonthName(ushort month)
        {
            switch (month)
            {
                case 1: return "января";
                case 2: return "февраля";
                case 3: return "марта";
                case 4: return "апреля";
                case 5: return "мая";
                case 6: return "июня";
                case 7: return "июля";
                case 8: return "августа";
                case 9: return "сентября";
                case 10: return "октября";
                case 11: return "ноября";
                case 12: return "декабря";
                default: return "";
            }
        }

        static void Task1()
        {
            /*Написать программу, которая читает с экрана число, переводит это число в месяц и день месяца.*/
            Console.WriteLine("");
            Console.WriteLine("Упражнение 4.1");
            Console.WriteLine("");

            ushort[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            Console.Write("Введите номер дня в году (от 1 до 365): ");
            ushort dayOfYear = ushort.Parse(Console.ReadLine());
            ushort month = 0;
            ushort day = dayOfYear;

            for (ushort i = 0; i < daysInMonth.Length; i++)
            {
                if (day <= daysInMonth[i])
                {
                    month = (ushort)(i + 1);
                    break;
                }
                day -= daysInMonth[i];
            }

            Console.WriteLine($"День {dayOfYear} соответствует {day} {GetMonthName(month)}.");
        }
        static void Task2()
        {
            /*Написать программу, которая читает с экрана число, переводит это число в месяц и день месяца.Если число меньше 1 или больше 365, программа должна вырабатывать
            исключение, и выдавать на экран сообщение.*/
            Console.WriteLine("");
            Console.WriteLine("Упражнение 4.2");
            Console.WriteLine("");

            ushort[] daysMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            Console.Write("Введите номер дня в году (от 1 до 365): ");
            ushort dayYear;


            while (!ushort.TryParse(Console.ReadLine(), out dayYear) || dayYear < 1 || dayYear > 365)
            {
                Console.WriteLine("Пожалуйста, введите корректное число от 1 до 365.");
            }
            ushort month1 = 0;
            ushort day1 = dayYear;

            for (ushort i = 0; i < daysMonth.Length; i++)
            {
                if (day1 <= daysMonth[i])
                {
                    month1 = (ushort)(i + 1);
                    break;
                }
                day1 -= daysMonth[i];
            }
            Console.WriteLine($"День {dayYear} соответствует {day1} {GetMonthName(month1)}.");
        }
        static void Task3()
        {
            /*Написать программу, которая читает с экрана число, переводит это число в месяц и день месяца.Если число меньше 1 или больше 365, программа должна вырабатывать
           исключение, и выдавать на экран сообщение.Программа должна учитывать год
           год (високосный или нет). Год вводится с экрана*/
            Console.WriteLine("");
            Console.WriteLine("Домашнее Задание 4.1");
            Console.WriteLine("");


            ushort[] daysMonthVis = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            ushort[] daysMonthNeVis = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            Console.Write("Введите номер дня в году (от 1 до 365/366): ");
            ushort dayYear1;

            while (!ushort.TryParse(Console.ReadLine(), out dayYear1) || dayYear1 < 1 || dayYear1 > 366)
            {
                Console.WriteLine("Пожалуйста, введите корректное число.");
            }
            Console.Write("Введите год:");
            ushort year = ushort.Parse(Console.ReadLine());
            ushort month2 = 0;
            ushort day2 = dayYear1;

            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {

                for (ushort i = 0; i < daysMonthVis.Length; i++)
                {

                    if (day2 <= daysMonthVis[i])
                    {
                        month2 = (ushort)(i + 1);
                        break;
                    }
                    day2 -= daysMonthVis[i];
                }
            }
            else
            {
                for (ushort i = 0; i < daysMonthNeVis.Length; i++)
                {
                    if (day2 <= daysMonthNeVis[i])
                    {
                        month2 = (ushort)(i + 1);
                        break;
                    }
                    day2 -= daysMonthNeVis[i];
                }
            }


            Console.WriteLine($"День {dayYear1} соответствует {day2} {GetMonthName(month2)}.");

        }
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Console.ReadKey();
        }
    }
}

