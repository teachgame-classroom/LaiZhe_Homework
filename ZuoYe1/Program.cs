using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZuoYe1
{
    class Program
    {
        static void Main(string[] args)
        {
            Human1 human1 = new Human1("李四","女", 19);
            human1.ShowProfile();
            human1.ChangName("张三");
            human1.ChangAge(18);
            human1.ShowProfile();
            Console.ReadKey();
            Console.WriteLine("做了一点作业");
        }




        
        
    }


   


}
