using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCalculator
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Logger logger = new Logger();

            try
            {
                Console.WriteLine("Введите первое число:");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите второе число:");
                double num2 = Convert.ToDouble(Console.ReadLine());

                IAdder<double> adder = new Calculator(logger);
                adder.Add(num1, num2);

                IResult<double> result = (IResult<double>)adder;
                Console.WriteLine($"Результат сложения: {result.GetResult()}");
            }
            catch (FormatException)
            {
                logger.Error("Введено некорректное значение.");
            }
            finally
            {
                logger.Event("Программа завершена");
                Console.ReadKey();
            }
        }
    }
}
