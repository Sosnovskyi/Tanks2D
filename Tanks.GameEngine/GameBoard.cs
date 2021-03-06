﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tanks.GameEngine.GameObjects;
using Tanks.GameEngine.GameObjects.UnmovableObjects;
using Tanks.GameEngine.GameObjects.DynamicObjects;

namespace Tanks.GameEngine
{
    public class GameBoard
    {
        private List<IGameObject> gameObjects = new List<IGameObject>();

        public IEnumerable<IGameObject> GameObjects
        {
            get { return gameObjects; }
        }

        public void AddObject(IGameObject gameObject)
        {
            gameObjects.Add(gameObject);
            gameObject.Board = this;
        }

        public bool CanBePlaced(IGameObject gameObject, int newX, int newY)
        {
            if (this.gameObjects.Any(r => r == gameObject) == false)
            {
                return false;
            }
            else
            {
                return IsCorrectPosition(gameObject, newX, newY);
            }
        }

        public bool IsCorrectPosition(IGameObject gameObject, int newX, int newY)
        {
<<<<<<< HEAD
            if (this.gameObjects.Any(r => r.X == newX && r.Y == newY) == true)  // no need  == true
=======
            if (this.gameObjects.Any(r => r.X == newX && r.Y == newY) == true)
>>>>>>> ac1aa47847c5668fb2e809b3a3ae687c984f7a88
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool BulletObjectCollision(Bullet bullet, int newX, int newY)
        {
            for (int i = 0; i < gameObjects.Count; i++)
            {
                if (gameObjects[i].X == newX && gameObjects[i].Y == newY)
                {
                    if ((gameObjects[i] is Player) && (bullet.OfPlayer == false))
                    {
                        gameObjects[i].IsAlive = false;
                    }
                    if (gameObjects[i] is Wall)
                    {
                        gameObjects[i].IsAlive = false;
                        gameObjects.Remove(this.gameObjects[i]);
                    }
                    if (gameObjects[i] is Enemy)
                    {
                        if (bullet.OfPlayer == true)
                        {
                            gameObjects[i].IsAlive = false;
                            gameObjects.Remove(this.gameObjects[i]);
                        }
                    }
                    bullet.IsAlive = false;
                    gameObjects.Remove(bullet);
                    return false;
                }
            }
            return true;
        }
    }
}


