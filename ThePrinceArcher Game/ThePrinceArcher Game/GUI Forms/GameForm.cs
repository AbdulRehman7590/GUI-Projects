using EZInput;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using ThePrinceArcher_Game.Enums;
using ThePrinceArcher_Game.GL;

namespace ThePrinceArcher_Game.GUI_Forms
{
    public partial class GameForm : Form
    {
        public event EventHandler IsExitClick;

        public bool isClick { get => isExit; }
        bool isExit = false;

        Game game;
        GameCollisionDetector collider;

        int points = 0;
        int loadedArrow = 9;
        int rightSteps = 0;
        bool enemyPresence = false;
        bool enemyDead = false;

        public GameForm()
        {
            InitializeComponent();
            game = new Game(gameForm_Panel);
            collider = new GameCollisionDetector();
        }

        private void gameLoop_Tick(object sender, EventArgs e)
        {
            ShowScore();
            ShowArrows();
            MoveHeroFire();
            MoveEnemyFire();
            game.RemoveHeroFire();
            game.RemoveEnemyFire();
            game.GenerateFruit(points);
            TakeKeyInput();

            if (enemyPresence)
            {
                MoveEnemy();
                game.CreateBombs();
            }

            if (game.WinGame())
            {
                gameLoop.Stop();
                MessageForm frm = new MessageForm(ThePrinceArcher_Game.Properties.Resources.game_win);
                frm.HideContinueBtn();
                frm.IsReturnBtnClick += ResumeFrm_IsBtnClick;
                frm.ShowDialog();
            }
        }
        
        private void ResumeFrm_IsBtnClick(object sender, EventArgs e)
        {
            isExit = true;
            IsExitClick?.Invoke(this, e);
        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            return true;
        }

        private void TakeKeyInput()
        {
            Prince prince = game.GetPrince();
            GameCell potentialNewCell = prince.CurrentCell;

            if (Keyboard.IsKeyPressed(Key.LeftArrow))
            {
                potentialNewCell = prince.CurrentCell.NextCell(GameDirection.LEFT);
            }

            else if (Keyboard.IsKeyPressed(Key.RightArrow))
            {
                AddRightStep();
                potentialNewCell = prince.CurrentCell.NextCell(GameDirection.RIGHT);
            }

            else if (Keyboard.IsKeyPressed(Key.UpArrow))
            {
                potentialNewCell = prince.CurrentCell.NextCell(GameDirection.UP);
            }

            else if (Keyboard.IsKeyPressed(Key.DownArrow))
            {
                potentialNewCell = prince.CurrentCell.NextCell(GameDirection.DOWN);
            }

            else if (Keyboard.IsKeyPressed(Key.Space))
            {
                if (prince.isFire)
                {
                    GameCell NewCell = prince.CurrentCell.NextCell(GameDirection.RIGHT);
                    Fire f = new Fire(ThePrinceArcher_Game.Properties.Resources.arrow, NewCell, GameDirection.RIGHT);
                    game.AddHeroFire(f);
                    loadedArrow--;
                }
            }

            else if (Keyboard.IsKeyPressed(Key.Escape))
            {
                gameLoop.Stop();
                MessageForm frm = new MessageForm(ThePrinceArcher_Game.Properties.Resources._continue);
                frm.IsContinueBtnClick += ResumeFrm_IsContinueBtnClick;
                frm.IsReturnBtnClick += ResumeFrm_IsBtnClick;
                frm.ShowDialog();
            }

            HeroFunctions(prince);
            game.NextCellFunctions(potentialNewCell, collider, ref points);

            GameCell currentCell = prince.CurrentCell;
            currentCell.SetGameObject(Game.GetBlankGameObject());
            prince.Move(potentialNewCell);
        }

        private void ResumeFrm_IsContinueBtnClick(object sender, EventArgs e)
        {
            gameLoop.Start();
        }


        public void AddRightStep()
        {
            rightSteps++;
            if (rightSteps >= 12)
            {
                rightSteps = 12;
            }
        }

        private void HeroFunctions(Prince prince)
        {
            prince.Reload(ref loadedArrow);

            if (rightSteps == 2)
            {
                AddRightStep();
                game.WallRemove();
            }

            if (rightSteps == 10)
            {
                AddRightStep();
                game.PrintWall();
                enemyPresence = true;
                game.EnemyPresence();
            }

            if (enemyDead)
            {
                enemyPresence = false;
                game.OpenGate();
            }

        }

        private void ShowScore()
        {
            score.Text = points.ToString();
        }

        private void ShowArrows()
        {
            arrows.Text = "X " + loadedArrow.ToString();
        }




        private void MoveHeroFire()
        {
            foreach (Fire f in game.HeroFires)
            {
                if (collider.FireWithEnemy(f))
                {
                    points = points + 5;
                    game.DecreaseEnemyHealth();
                    if (0 < game.GetEnemyHealth())
                    {
                        enemy_Health_Bar.Value = game.GetEnemyHealth();
                    }
                    else if (0 == game.GetEnemyHealth())
                    {
                        enemy_Health_Bar.Value = game.GetEnemyHealth();

                        enemyDead = false;
                    }
                }
                f.Move(f.NextCell());
            }
        }

        private void MoveEnemyFire()
        {
            foreach (Fire f in game.EnemyFires)
            {
                if (collider.FireWithPrince(f))
                {
                    game.DecreaseHeroHealth();
                    if (0 < game.GetPrinceHealth())
                    {
                        prince_Health_Bar.Value = game.GetPrinceHealth();
                    }
                    else if (0 == game.GetPrinceHealth())
                    {
                        prince_Health_Bar.Value = game.GetPrinceHealth();

                        gameLoop.Stop();
                        MessageForm frm = new MessageForm(ThePrinceArcher_Game.Properties.Resources.game_lose);
                        frm.HideContinueBtn();
                        frm.IsReturnBtnClick += ResumeFrm_IsBtnClick;
                        frm.ShowDialog();
                    }
                }

                f.Move(f.NextCell());
            }
        }




        private void MoveEnemy()
        {
            Enemy enemy = game.GetEnemy();
            GameCell potentialNewCell = enemy.CurrentCell;
            GameCell nextCell;

            Random rnd = new Random();
            int num = rnd.Next(2, 5);

            if (num == 2)
            {
                nextCell = enemy.CurrentCell.NextCell(GameDirection.UP);
                if (nextCell != potentialNewCell)
                {
                    GameCell currentCell = enemy.CurrentCell;
                    currentCell.SetGameObject(Game.GetBlankGameObject());
                    enemy.Move(nextCell);
                }
            }

            else if (num == 4)
            {
                nextCell = enemy.CurrentCell.NextCell(GameDirection.DOWN);
                if (nextCell != potentialNewCell)
                {
                    GameCell currentCell = enemy.CurrentCell;
                    currentCell.SetGameObject(Game.GetBlankGameObject());
                    enemy.Move(nextCell);
                }
            }

            EnemyFunctions(enemy);
        }

        private void EnemyFunctions(Enemy enemy)
        {
            if (enemy.isEnemyFire())
            {
                GameCell NewCell = enemy.CurrentCell.NextCell(GameDirection.LEFT);
                Fire f = new Fire(ThePrinceArcher_Game.Properties.Resources.bullet, NewCell, GameDirection.LEFT);
                game.AddEnemyFire(f);
            }

        }

    }
}

