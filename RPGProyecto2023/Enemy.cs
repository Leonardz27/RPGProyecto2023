using System;
using System.Collections.Generic;
using System.Text;

namespace RPGProyecto2023
{
    class Enemy
    {
        protected int life;
        protected int damage;

        public bool IsAlive()
        {
            return life > 0;
        }
        public void TakeDamage(int damage)
        {
            life -= damage;
        }

        public virtual int GetDamage()
        {
            return damage;
        }
    }
}
