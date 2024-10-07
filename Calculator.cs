using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCalculator
{
    public interface IAdder<in T>
    {
        void Add(T a, T b);
    }
    public interface IResult<out T>
    {
        T GetResult();
    }

    internal class Calculator : IAdder<double>, IResult<double>
    {
        private double _result;
        private Logger _logger;
        public Calculator(Logger logger)
        {
            _logger = logger;
        }
        public void Add(double a, double b)
        {
            _result = a + b;
            _logger.Event($"Выполнено сложение: {a} + {b} = {_result}");
        }

        public double GetResult()
        {
            return _result;
        }
    }
}
