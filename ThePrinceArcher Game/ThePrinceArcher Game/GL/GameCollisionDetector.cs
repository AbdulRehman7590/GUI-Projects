using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThePrinceArcher_Game.Enums;

namespace ThePrinceArcher_Game.GL
{
    public class GameCollisionDetector
    {
        public bool FireWithEnemy(Fire f)
        {
            bool flag = false;

            if(f.NextCell().CurrentGameObject.GameObjectType == GameObjectType.ENEMY)
            {
                flag = true;
            }

            return flag;
        }
        
        public bool FireWithPrince(Fire f)
        {
            bool flag = false;

            if (f.NextCell().CurrentGameObject.GameObjectType == GameObjectType.PRINCE)
            {
                flag = true;
            }

            return flag;
        }

        public bool PrinceWithEnemy(GameCell cell)
        {
            bool flag = false;

            if (cell.CurrentGameObject.GameObjectType == GameObjectType.ENEMY)
            {
                flag = true;
            }

            return flag;
        }

        public bool PrinceWithBomb(GameCell cell)
        {
            bool flag = false;

            if(cell.CurrentGameObject.GameObjectType == GameObjectType.BOMB)
            {
                flag = true;
            }

            return flag;
        }
        
        public bool PrinceWithFruit(GameCell cell)
        {
            bool flag = false;

            if(cell.CurrentGameObject.GameObjectType == GameObjectType.REWARD)
            {
                flag = true;
            }

            return flag;
        }
    }
}
