using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
public class Calculor
        {
            public int x;
            public int y;
            public Calculor(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
            public Calculor()
            {
                this.x = 0;
                this.y = 0;
            }
            public int Plus()
            {
                return x + y;
            }
            public double Delenie()
            {
                return Convert.ToDouble(x / y);
            }
        }


    class Program
    {

        static void Main(string[] args)
        {
  
        Console.WriteLine("Введите первое число:  ");
            int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\nВведите первое число:  ");
            int y = Convert.ToInt32(Console.ReadLine());
            Calculor calc = new Calculor(x, y);
          Console.WriteLine("Результат" + calc.Delenie());
    }
    }
}


