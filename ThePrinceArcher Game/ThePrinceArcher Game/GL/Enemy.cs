﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThePrinceArcher_Game.Enums;

namespace ThePrinceArcher_Game.GL
{
    public class Enemy : GameObject
    {
        GameDirection dir = GameDirection.DOWN;
        bool x = false;
        int health = 100;
        int stepCounter = 0;
        
        public int Health { get => health; set => health = value; }

        
        public Enemy(Image img, GameCell startCell) : base(GameObjectType.ENEMY, img)
        {
            this.CurrentCell = startCell;
        }
        

        public bool X { get => x; set => x = value; }


        public void Move(GameCell gameCell)
        {
            if (this.CurrentCell != null)
            {
                this.CurrentCell.SetGameObject(Game.GetBlankGameObject());
            }
            CurrentCell = gameCell;
            stepCounter++;
        }

        public bool isEnemyFire()
        {
            bool fire = false;

            if (stepCounter == 4)
            {
                fire = true;
                stepCounter = 0;
            }

            return fire;
        }


        public GameCell NextCell()
        {

            GameCell currentCell = this.CurrentCell;

            GameCell nextCell = this.CurrentCell.NextCell(dir);

            if (nextCell == currentCell)
            {
                x = true;
            }
            else
            {
                currentCell = nextCell;
            }
            return currentCell;

        }
    }
}
