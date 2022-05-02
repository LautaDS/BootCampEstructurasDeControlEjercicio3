using System;
using System.Collections.Generic;

namespace BootCampEstructurasDeControlEjercicio3
{
    class Program
    {
       
        static void Main(string[] args)
        {
            List<int> numbersToAdd = new List<int>();
            int summatoryOfTheList = 0;
            int i = 0;
            int median;
            
            while(summatoryOfTheList < 150)
            { 
                Console.WriteLine("Let's add numbers up to 150");
            
                numbersToAdd.Add(Convert.ToInt32(Console.ReadLine()));
                i++;
            
            }

            foreach(int number in numbersToAdd)
            {
                summatoryOfTheList += number;

            }

            median = summatoryOfTheList / i;

            
        }
    }
}
