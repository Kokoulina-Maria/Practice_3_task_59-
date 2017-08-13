using System;

namespace Practice_3_task_59е
{
    class Program
    {
        static Double ReadDouble(string msg)
        {// Ввод координаты с проверкой
            Double number; bool ok;// переменная для проверки
            do
            {
                Console.Write("Введите координату "+msg+" с точностью не более 16 знаков после запятой: ");
                ok = Double.TryParse(Console.ReadLine(), out number);
                if (!ok) Console.WriteLine("Неверный ввод!");
            } while (!ok);// конец проверки
            return (number);
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Double x = ReadDouble("x");
                Double y = ReadDouble("y");
                if (((x < 0) & (((y >= 0) & (x / 2 + 1 >=y)) || ((y < 0) & (-x / 2 - 1 <=y)))) || ((x >=0) & (x * x + y * y <= 1)))
                    Console.WriteLine("Принадлежит");
                else Console.WriteLine("Не принадлежит");
                Console.ReadLine();               
            }
        }
    }
}
