using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laiZhe3._19
{
    class Program
    {
        static void Main(string[] args)
        {
            Student XiaoZhang = new Student("小张", "男", 14, 86, 92, 73);

            XiaoZhang.SayHello();
            XiaoZhang.PrintScore();


        }
    }
}
