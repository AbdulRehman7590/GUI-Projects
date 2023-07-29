using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThePrinceArcher_Game.Enums;

namespace ThePrinceArcher_Game.GL
{
    public class Fire : GameObject
    {
        GameDirection dir;
        bool x = false;

        public Fire(Image image, GameCell startCell, GameDirection dir) : base(GameObjectType.FIRE, image)
        {
            this.CurrentCell = startCell;
            this.dir = dir;
        }

        public bool X { get => x; set => x = value; }

        public void Move(GameCell gameCell)
        {
            if (this.CurrentCell != null)
            {
                this.CurrentCell.SetGameObject(Game.GetBlankGameObject());

            }
            this.CurrentCell = gameCell;
        }

        public GameCell NextCell()
        {

            GameCell currentCell = this.CurrentCell;

            GameCell nextCell = this.CurrentCell.NextCell(dir);

            if (nextCell == currentCell || nextCell.CurrentGameObject.GameObjectType == GameObjectType.PRINCE || nextCell.CurrentGameObject.GameObjectType == GameObjectType.ENEMY || nextCell.CurrentGameObject.GameObjectType == GameObjectType.BOMB || nextCell.CurrentGameObject.GameObjectType == GameObjectType.REWARD)
            {
                x = true;
                currentCell = nextCell;
            }
            else
            {
                currentCell = nextCell;
            }
            return currentCell;

        }

    }
}
