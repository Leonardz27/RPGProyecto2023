using System;
using System.Collections.Generic;
using System.Text;

namespace RPGProyecto2023
{
    class GameMenu
    {
        public void CreatePlayerMenu(Game game)
        {
            bool ContinueFlag = true;
            while(ContinueFlag)
            { 
            Console.WriteLine("Introducir la vida del jugador: ");
            int life = int.Parse(Console.ReadLine());
            Console.WriteLine("Introducir el daño del jugador: ");
            int damage = int.Parse(Console.ReadLine());
            if(life+damage<=100)
            {
                game.CreatePlayer(life, damage);
                ContinueFlag = false;
            }
            else
            {
                Console.WriteLine("La vida y el daño no deben superar 100");
            }
            }
        }
    }
}
