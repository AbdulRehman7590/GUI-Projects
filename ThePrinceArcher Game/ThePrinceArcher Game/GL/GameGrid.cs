using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThePrinceArcher_Game.Enums;

namespace ThePrinceArcher_Game.GL
{
    public class GameGrid
    {
        GameCell[,] cells;
        int rows;
        int cols;

        public GameGrid(int rows, int cols)
        {
            //Numbers of rows and cols should load from the text file
            this.rows = rows;
            this.cols = cols;
            cells = new GameCell[rows, cols];
            this.LoadGrid();
        }
        
        public GameCell GetCell(int x, int y)
        {
            return cells[x, y];
        }

        public int Rows { get => rows; set => rows = value; }
        public int Cols { get => cols; set => cols = value; }

        void LoadGrid()
        {
            StreamReader fp = new StreamReader("maze.txt");
            string record;
            for (int row = 0; row < this.rows; row++)
            {
                record = fp.ReadLine();
                if (record != null)
                {
                    for (int col = 0; col < this.cols; col++)
                    {
                        GameCell cell = new GameCell(row, col, this);
                        char displayCharacter = record[col];
                        GameObjectType type = GameObject.GetGameObjectType(displayCharacter);
                        Image displayIamge = Game.GetGameObjectImage(displayCharacter);
                        GameObject gameObject = new GameObject(type, displayIamge);
                        cell.SetGameObject(gameObject);
                        cells[row, col] = cell;
                    }
                }
            }
            fp.Close();
        }




    }
}
