using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjecRelation
{
    class Human
    {
        public int Hp;

        public int posX;
        public int posY;

        public  Human(int var_hp)
        {
            Hp = var_hp;

        }

        //想要移动到哪个位置
        public void  Move(int targetX, int targetY)
        {
            posX = targetX;
            posY = targetY;

        }





    }
}
