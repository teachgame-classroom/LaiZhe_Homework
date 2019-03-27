using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laiZhe3._19
{
    class Student
    {
        public string name;

        public string sex;

        public int age;

        public int yuwen;

        public int math;

        public int english;

       

        public Student(string var_name, string var_sex, int var_age, int var_yuwen, int var_math, int var_english)
        {
            name = var_name;

            sex = var_sex;

            age = var_age;

            yuwen = var_yuwen;

            math = var_math;

            english = var_english;

        }

        public void SayHello()
        {
            Console.WriteLine("大家好我叫{0}，今年{1}岁，我是{2}", name, age, sex);
        }
        public int Total()
        {
            return yuwen + math + english;
        }

        public int  Average()
        {
            return  Total() / 3;
        }

        public string Grade()
        {
            int avg = Average();

            string grade;

                if(avg>=90)
            {
                grade = "优秀";

            }
            else if (avg >= 80)
            {
                grade = "良好";

            }
            else if (avg >= 70)
            {
                grade = "中等";

            }

            else if (avg >= 60)
            {
                grade = "及格";

            }
            else 

            {
                grade = "不及格";
            }

            return grade;

        }
        public void PrintScore()
        {
            Console.WriteLine("大家好我叫{0}，此次总分是{1}，评价成绩为{2}，评价为{3}",name,Total(),Average(),Grade());

        }


    }
}
