﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZuoYe1
{
    class Warrior
    {
        public string name;

        public int hp;

        public int atk;

        Warrior(string var_name, int  var_hp, int var_atk)
        {

            name = var_name;
            hp = var_hp;
            atk = var_atk;
        }

       public void ChangeName(string pNewName)
        {

            name = pNewName;

        }

        public void Hurt(int pAtk)
        {
            hp = hp - pAtk;

        }

        public void AtkUp(int pAmount)
        {
            if(pAmount > 0)
            {
                atk = atk + pAmount;
            }
            
        }

        public void HpUp(int pAmount)
        {
            if(pAmount>0)
            {
                hp = hp + pAmount;
            }
            
        }

        public void LevelUp(int pHpUp, int pAtkUp)
        {
            // hp = hp + pHpUp;
            //atk =atk + pAtkUp;

            HpUp(pHpUp);
            AtkUp(pAtkUp);

        }
        public  void ShowProfile()
        {
            Console.WriteLine("姓名"+name+"生命值:"+hp+"攻击力:"+atk);
        }


    }
}
