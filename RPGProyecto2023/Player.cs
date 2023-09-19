using System;
using System.Collections.Generic;
using System.Text;

namespace RPGProyecto2023
{
    class Player
    {
        private int life;
        private int damage;

        // Constructor que recibe la vida y el daño del jugador
        public Player(int life, int damage)
        {
            this.life = life;
            this.damage = damage;
        }

        // Método para que el jugador reciba daño
        public void TakeDamage(int damage)
        {
            life -= damage;
        }
        public int GetDamage()
        {
            return damage;
        }
        public bool IsAlive()
        {
            return life > 0;
        }
    }
}
