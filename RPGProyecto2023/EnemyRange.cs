using System;
using System.Collections.Generic;
using System.Text;

namespace RPGProyecto2023
{
    class EnemyRange : Enemy
    {
        private int bullets;

        public EnemyRange(int life, int damage, int bullets)
        {
            this.life = life;
            this.damage = damage;
            this.bullets = bullets;
        }

        public override int GetDamage()
        {
            if (bullets==0)
            {
                return 0;
            }
            else
            {
                bullets -= 1;
                return damage;
            }
        }
    }
}
