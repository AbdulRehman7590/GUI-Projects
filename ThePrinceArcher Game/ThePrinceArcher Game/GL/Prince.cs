using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThePrinceArcher_Game.Enums;

namespace ThePrinceArcher_Game.GL
{
    public class Prince : GameObject
    {
        int health = 100;
        bool fire = true;

        public Prince(Image img, GameCell startCell) : base(GameObjectType.PRINCE, img)
        {
            this.CurrentCell = startCell;
        }

        public int Health { get => health; set => health = value; }

        public bool isFire { get => fire; }

        public void Move(GameCell gameCell)
        {
            CurrentCell = gameCell;
        }

        public void Reload(ref int loadedArrow)
        {
            if (loadedArrow <= 0)
            {
                fire = false;
            }
            if (isFire == false)
            {
                loadedArrow++;
            }
            if (loadedArrow == 9)
            {
                fire = true;
            }
        }
    }
}
