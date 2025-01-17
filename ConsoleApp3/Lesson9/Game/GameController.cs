﻿
using ConsoleApp3.Lesson9.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Lesson9.Game
{
    class GameController
    {
        public void StartGame()
        {
            GameScreen gameScreen = new GameScreen(200, 40);
            gameScreen.SetHero(new Hero("Rand al'Thor", 5, 5));

            int uniqueId = 0;
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                gameScreen.AddEnemy(new Enemy(uniqueId, "EnemyNr" + uniqueId, rnd.Next(0, 10), rnd.Next(0, 100)));
                uniqueId++;
            }

            gameScreen.Render();

            gameScreen.MoveHeroLeft();
            gameScreen.MoveAllEnemiesDown();

            gameScreen.GetEnemyById(2).MoveDown();

            gameScreen.Render();
        }
    }
}