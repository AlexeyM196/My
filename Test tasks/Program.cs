using System;

namespace ConsoleAppBase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов в массиве: ");
            int[] numbers = new int[int.Parse(Console.ReadLine())];
            Random r = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = r.Next(10000); //записываем не отрицательное случайное число
            }

            Console.WriteLine("TASK 1");
            CustomPrints.Print(numbers, "Неупорядоченный массив: ");
            CustomPrints.Print(Sort.SortAscending(numbers), "Упорядоченный массив: ");


            Console.WriteLine("TASK 2");
            Console.Write("Введите искомое значение: ");
            int k = int.Parse(Console.ReadLine());
            CustomPrints.Print(Search.BinarySearch(numbers, k), "Индекс найденного значения: ");


            Console.WriteLine("TASK 3");
            string str = "Раз два, раз три четыре три четыре пять шесть, семь! пять. Растения: банан? Капуста! Банан, помидор;";
            CustomPrints.Print(str, "Строка с повторениями: ");
            CustomPrints.Print(WordRemover.RemoveRepeatWords(str), "Строка без повторений: ");


            Console.WriteLine("TASK 4");
            Console.Write("Введите значение для которого нужно найти факториал: ");
            decimal n = decimal.Parse(Console.ReadLine());
            CustomPrints.Print(Factorial.FactN(n), "Факториал: ");


            Console.WriteLine("TASK 5");
            Console.WriteLine("Введите скобочную последовательность: ");
            BracketsChecker checker = new BracketsChecker(); 
            CustomPrints.Print(checker.IsValid(Console.ReadLine()), "Последовательность является");


        }
    }
}
