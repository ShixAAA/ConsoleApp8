using System;

namespace nomer1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, z;//Объявление переменных
            Console.WriteLine("Введите x = ");//Ввод и конвертирование переменной
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y = ");//Ввод и конвертирование переменной
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите z = ");//Ввод и конвертирование переменной
            z = Convert.ToDouble(Console.ReadLine());
            if (Math.Pow(z, 2) == Math.Pow(y, 2) + Math.Pow(x, 2))//Условие
                Console.WriteLine("Треугольник прямоугольный");//Условие выполнено
            if (Math.Pow(y, 2) == Math.Pow(z, 2) + Math.Pow(x, 2))
                Console.WriteLine("Треугольник прямоугольный");//Условие выполнено
            if (Math.Pow(x, 2) == Math.Pow(y, 2) + Math.Pow(z, 2))
                Console.WriteLine("Треугольник прямоугольный");//Условие выполнено
            else Console.WriteLine("Треугольник не прямоугольный");//Условие не выполнено
            Console.ReadKey();


        }
    }
}
