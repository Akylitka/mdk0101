using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skibidi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("муняняя");

            List<int> list_1 = new List<int>() {1,2,3,4,522,911,420,69, -2, -3};


            foreach (int g in list_1)
            {
                Console.WriteLine("список до удаления=" + g);
            }


            for (int i = 0; i < list_1.Count; i++)
            {
    
                
                if (list_1[i] % 2 != 0)
                {
                    list_1.RemoveAt(i);
                }
     
            }

           
            foreach(int g in list_1)
            {
                Console.WriteLine("список после удаления =" + g);
            }
          
            Console.ReadKey();

        }
    }
}
