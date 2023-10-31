using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace consoleapplication1
{ class Program
    { static void Main(string[] args)
        {
            int fact = 1;
            int num;
            int i;
            Console.Write("enter number:");
            num = Convert.ToInt32(Console.ReadLine());
            for (i =1;i<=num;i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("factorial is : {0}", fact);
            Console.ReadKey();
        }
    }
}
//سورنا کریمی مقدم تمرین 5
