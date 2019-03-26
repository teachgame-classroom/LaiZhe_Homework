using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjecRelation
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建一个新的Human对象，然后设置一个构造函数
            Human human = new Human(100);

            human.posX = 5;
            human.posX = 5;

            Monster monster = new Monster(75,200);
            monster.posX = 6;
            monster.posY = 5;



            monster.TryAttack(human);

        }
    }
}
