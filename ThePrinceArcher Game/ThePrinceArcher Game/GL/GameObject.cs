using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThePrinceArcher_Game.Enums;

namespace ThePrinceArcher_Game.GL
{
    public class GameObject
    {
        GameObjectType gameObjectType;
        GameCell currentCell;
        Image image;
        
        public GameObjectType GameObjectType { get => gameObjectType; set => gameObjectType = value; }
        
        public Image Image { get => image; set => image = value; }
        
        public GameCell CurrentCell
        {
            get => currentCell;
            set
            {
                currentCell = value;
                currentCell.SetGameObject(this);
            }
        }
        

        public GameObject(GameObjectType type, Image image)
        {
            this.gameObjectType = type;
            this.Image = image;
        }
       
        public static GameObjectType GetGameObjectType(char displayCharacter)
        {
            GameObjectType type = GameObjectType.NONE;

            if (displayCharacter == '#' )
            {
                type = GameObjectType.WALL;
            }

            else if (displayCharacter == '|')
            {
                type = GameObjectType.GATE;
            }

            else if (displayCharacter == '_')
            {
                type = GameObjectType.GRID;
            }

            return type;
        }

        

    }
}
