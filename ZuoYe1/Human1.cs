using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZuoYe1
{
    class Human1
    {
        public string name;

        public string sex;

        public int age;

        public Human1 (string var_name, string var_sex, int var_age)
        {

            name = var_name;
            sex = var_sex;
            age = var_age;
            

        }

        public void ChangName(string pNewName)
        {
            name = pNewName;
        }

        public void ChangAge(int pNewAge)
        {
            age = pNewAge;
        }

        public  void ShowProfile()
        {
            Console.WriteLine("战士的姓名{0}，性别{1}，年龄{2}", name, sex, age);
            //Console.ReadKey();

        }
    }
}
