using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThePrinceArcher_Game.Enums;

namespace ThePrinceArcher_Game.GL
{
    public class GameCell
    {
        int row;
        int col;
        GameObject currentGameObject;
        GameGrid grid;
        PictureBox pictureBox;
        const int width = 20;
        const int height = 22;


        public int X { get => row; set => row = value; }
        public int Y { get => col; set => col = value; }
        public GameObject CurrentGameObject { get => currentGameObject; }
        public PictureBox PictureBox { get => pictureBox; set => pictureBox = value; }
        public GameGrid Grid { get => grid; set => grid = value; }

        
        public GameCell(int row, int col, GameGrid grid)
        {
            this.row = row;
            this.col = col;
            pictureBox = new PictureBox();
            pictureBox.Left = col * width;
            pictureBox.Top = row * height;
            pictureBox.Size = new Size(width, height);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.BackColor = Color.Transparent;
            this.Grid = grid;
        }

        public void SetGameObject(GameObject gameObject)
        {
            currentGameObject = gameObject;
            pictureBox.Image = gameObject.Image;

        }

        public GameCell NextCell(GameDirection direction)
        {

            if (direction == GameDirection.LEFT)
            {
                if (this.col > 0)
                {
                    GameCell ncell = Grid.GetCell(row, col - 1);
                    if (CheckNextCell(ncell))
                    {
                        return ncell;
                    }
                }
            }

            if (direction == GameDirection.RIGHT)
            {
                if (this.col < Grid.Cols - 1)
                {
                    GameCell ncell = Grid.GetCell(this.row, this.col + 1);
                    if (CheckNextCell(ncell))
                    {
                        return ncell;
                    }
                }
            }

            if (direction == GameDirection.UP)
            {
                if (this.row > 0)
                {
                    GameCell ncell = Grid.GetCell(this.row - 1, this.col);
                    if (CheckNextCell(ncell))
                    {
                        return ncell;
                    }
                }
            }

            if (direction == GameDirection.DOWN)
            {
                if (this.row < Grid.Rows - 1)
                {
                    GameCell ncell = Grid.GetCell(this.row + 1, this.col);
                    if (CheckNextCell(ncell))
                    {
                        return ncell;
                    }

                }
            }
            return this; // if can not return next cell return its own reference
        }

        private bool CheckNextCell(GameCell ncell)
        {
            bool flag = false;
            if(ncell.CurrentGameObject.GameObjectType != GameObjectType.WALL && ncell.CurrentGameObject.GameObjectType != GameObjectType.GATE && ncell.currentGameObject.GameObjectType != GameObjectType.GRID)
            {
                flag = true; 
            }
            return flag;
        }

    }
}
