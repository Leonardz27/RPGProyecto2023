using System;
using System.Collections.Generic;
using System.Text;

namespace RPGProyecto2023
{
    class EnemyMelee : Enemy
    {
        public EnemyMelee(int life, int damage, int bullets)
        {
            this.life = life;
            this.damage = damage;
        }
    }
}
