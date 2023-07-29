using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using ThePrinceArcher_Game.Enums;

namespace ThePrinceArcher_Game.GL
{
    public class Game
    {
        GameGrid grid;
        Panel game_Panel;
        Prince prince;
        Enemy enemy;
        List<Fire> prince_Fires;
        List<Fire> enemy_Fires;

        public Enemy Villian { get => enemy; set => enemy = value; }
        public GameGrid Grid { get => grid; set => grid = value; }
        public List<Fire> HeroFires { get => prince_Fires; set => prince_Fires = value; }
        public List<Fire> EnemyFires { get => enemy_Fires; set => enemy_Fires = value; }


        public Game(Panel panel)
        {
            this.game_Panel = panel;
            Grid = new GameGrid(13, 35);
            prince = new Prince(ThePrinceArcher_Game.Properties.Resources.archer, Grid.GetCell(5, 1));
            prince_Fires = new List<Fire>();
            enemy_Fires = new List<Fire>();
            PrintMaze(Grid);
        }

        public void EnemyPresence()
        {
            enemy = new Enemy(ThePrinceArcher_Game.Properties.Resources.enemy, Grid.GetCell(5, 25));
        }

        public void RemoveHeroFire()
        {
            for (int i = 0; i < prince_Fires.Count; i++)
            {
                if (prince_Fires[i].X)
                {
                    prince_Fires[i].CurrentCell.SetGameObject(GetBlankGameObject());
                    prince_Fires.RemoveAt(i);
                }
            }
        }

        public void RemoveEnemyFire()
        {
            for (int i = 0; i < enemy_Fires.Count; i++)
            {
                if (enemy_Fires[i].X)
                {
                    enemy_Fires[i].CurrentCell.SetGameObject(GetBlankGameObject());
                    enemy_Fires.RemoveAt(i);
                }
            }
        }

        public int GetHealth()
        {
            return prince.Health;
        }

        public GameCell GetCell(int x, int y)
        {
            return Grid.GetCell(x, y);
        }

        public Prince GetPrince()
        {
            return this.prince;
        }

        public Enemy GetEnemy()
        {
            return this.enemy;
        }

        public void AddHeroFire(Fire f)
        {
            prince_Fires.Add(f);
        }

        public void AddEnemyFire(Fire s)
        {
            enemy_Fires.Add(s);
        }

        public void DecreaseHeroHealth()
        {
            prince.Health -= 10;
        }

        public void RestoreHeroHealth()
        {
            prince.Health += 20;
        }

        public int GetPrinceHealth()
        {
            return prince.Health;
        }

        public void DecreaseEnemyHealth()
        {
            enemy.Health -= 10;
        }

        public int GetEnemyHealth()
        {
            return enemy.Health;
        }



        void PrintMaze(GameGrid grid)
        {
            for (int x = 0; x < grid.Rows; x++)
            {
                for (int y = 0; y < grid.Cols; y++)
                {
                    GameCell cell = grid.GetCell(x, y);
                    game_Panel.Controls.Add(cell.PictureBox);
                }
            }
        }



        public static GameObject GetBlankGameObject()
        {
            return new GameObject(GameObjectType.NONE, ThePrinceArcher_Game.Properties.Resources.simplebox);
        }

        public GameObject GetWallGameObject()
        {
            return new GameObject(GameObjectType.WALL, ThePrinceArcher_Game.Properties.Resources.gate);
        }

        public GameObject GetBombGameObject()
        {
            return new GameObject(GameObjectType.BOMB, ThePrinceArcher_Game.Properties.Resources.bomb);
        }

        public GameObject GetFruitGameObject()
        {
            return new GameObject(GameObjectType.REWARD, ThePrinceArcher_Game.Properties.Resources.fruit);
        }

        public static Image GetGameObjectImage(char displayCharacter)
        {
            Image img = ThePrinceArcher_Game.Properties.Resources.simplebox;
            if (displayCharacter == '#')
            {
                img = ThePrinceArcher_Game.Properties.Resources.bricks;
            }
            else if (displayCharacter == '|')
            {
                img = ThePrinceArcher_Game.Properties.Resources.gate;
            }
            else if (displayCharacter == '_')
            {
                img = ThePrinceArcher_Game.Properties.Resources.steel_gate;
            }
            return img;
        }



        int bombs = 0;
        public void CreateBombs()
        {
            if (enemy.Health <= 60 && bombs < 5)
            {
                Random rnd = new Random();
                int x, y;
                x = 5 + rnd.Next(1, 17);
                y = 3 + rnd.Next(1, 7);
                GameCell cell = grid.GetCell(y, x);
                cell.SetGameObject(GetBombGameObject());
                bombs++;
            }
        }

        int fruits = 0;
        public void GenerateFruit(int points)
        {
            if(prince.Health <= 30 && points == 25 && fruits < 2)
            {
                Random rnd = new Random();
                int x, y;
                x = 5 + rnd.Next(1, 17);
                y = 3 + rnd.Next(1, 7);
                GameCell cell = grid.GetCell(y, x);
                cell.SetGameObject(GetFruitGameObject());
                fruits++;
            }
        }


        public void NextCellFunctions(GameCell ncell, GameCollisionDetector collider, ref int points)
        {
            if (collider.PrinceWithBomb(ncell))
            {
                DecreaseHeroHealth();
                points -= 5;
                bombs--;
            }

            if (collider.PrinceWithEnemy(ncell))
            {
                DecreaseHeroHealth();
                points -= 5;
            }

            if(collider.PrinceWithFruit(ncell))
            {
                RestoreHeroHealth();
                points += 5;
            }
        }

        
        public bool WinGame()
        {
            bool flag = false;

            GameCell cell1 = grid.GetCell(5, 32);
            GameCell cell2 = grid.GetCell(6, 32);

            if (prince.CurrentCell == cell1 || prince.CurrentCell == cell2)
            {
                flag = true;
            }

            return flag;
        }

        public void WallRemove()
        {
            GameCell cell1 = GetCell(5, 4);
            GameCell cell2 = GetCell(6, 4);

            cell1.SetGameObject(GetBlankGameObject());
            cell2.SetGameObject(GetBlankGameObject());
        }

        public void PrintWall()
        {
            GameCell cell1 = GetCell(5, 4);
            GameCell cell2 = GetCell(6, 4);

            cell1.SetGameObject(GetWallGameObject());
            cell2.SetGameObject(GetWallGameObject());
        }

        public void OpenGate()
        {
            GameCell cell1 = GetCell(5, 30);
            GameCell cell2 = GetCell(6, 30);

            cell1.SetGameObject(GetBlankGameObject());
            cell2.SetGameObject(GetBlankGameObject());
        }

    }
}
