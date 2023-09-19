using System;
using System.Collections.Generic;
using System.Text;

namespace RPGProyecto2023
{
    class Game
    {
        private Player player;
        private List<Enemy> enemyList;
        private GameMenu gameMenu;

        public Game()
        {
            enemyList = new List<Enemy>();
            enemyList.Add(new EnemyMelee(30, 5));
            enemyList.Add(new EnemyRange(20, 10, 5));
        }

        public void Start()
        {
            gameMenu.CreatePlayerMenu(this);
            int i = 0;
            while(!IfFinished())
            {
                PlayerTurn();
                EnemyTurn(i);
                i++;
            }
        }
        private void PlayerTurn()
        {

        }
        private void EnemyTurn()
        {

        }
        public void CreatePlayer(int life, int damage)
        {
            player = new Player(life, damage);
        }

        private bool CheckIfFinished()
        {
            if(!player.IsAlive())
            {
                return true;
            }
            else
            {
                bool allEnemiesDead = true;

                foreach(Enemy enemy in enemyList)
                {
                    if(enemy.IsAlive())
                    {
                        return false;
                    }    
                }

                return true;
            }
        }
    }
}
