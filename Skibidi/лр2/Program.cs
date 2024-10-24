using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace лр2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Tovar> list = new List<Tovar>
            {
             new Tovar("Дробовик", 1500),
             new Tovar("Пистолет", 800),
             new Tovar("Автомат", 2500)
             };
        }
    }
}
