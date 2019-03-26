using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjecRelation
{
    class Monster
    {
        public int hp;

        public int atk;

        public int posX;
        public int posY;

        public Monster(int var_hp,int var_atk)
        {
            hp = var_hp;
            atk = var_atk;


        }



        //怪物满足某个条件了就会攻击人，必须要选择一个目标，这个目标要作为一个参数放到括号里
        //攻击这个行为（方法）它要接收的一个参数和对象应该是人，首先我们把我们要做的事情描述出来，
        //然后把主谓宾要分出来，谁做什么，对什么做什么事情，先把它分解好。做的事情就是你的方法，然后你对谁做这个事情就是你做的参数。或者说你怎么做就是这个方法的参数
        //先要想好你要做什么，然后再按照不同的类型，按照他们的职能，给他们分布属性和方法
        public void TryAttack(Human target)

        {

             //判断目标是否在攻击范围内。这个变量没有值，需要在别的地方去把这个值计算出来，然后再把这个值放到这个变量里
            //我们可以看一个方法的调用，是一个返回值的赋值
            if(IsTargetInRang(target)) //如果在攻击范围内，才采取攻击，
          
            {

                //让这个目标扣血，对它做什么事情.改变它的属性。
                //通过这对象的名字，找到它下面的属性或者方法——Hp，属性可以读取它，修改它。方法可以调用它。
                target.Hp = target.Hp - atk;

            }
            else
            {

                Console.WriteLine("太远了，吃不了");

            }


        }


        public bool IsTargetInRang(Human target)
        {

            int rangX = posX - target.posX;

            int rangY = posY - target.posY;
            if ((rangX == -1 || rangX ==1))
            {
                if(rangY==0)
                {
                    return true;
                }


            }
            if ((rangY == -1 || rangY == 1))
            {
                if (rangX== 0)
                {
                    return true;
                }


            }

            return false;
        }

        public void Hurt(int atk)
        {
            hp = hp - atk;

            if (hp<= 0)
            {

            }

        }










    }
}
