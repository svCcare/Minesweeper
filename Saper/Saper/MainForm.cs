using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Saper
{
    public partial class MainForm : Form
    {
        private FieldPanel[,] gameBoard = new FieldPanel[10,10];

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetLabels();
            GenerateBoard();
            SetBombs();
        }

        public void SetLabels()
        {
            lblBombsLeft.Text = $"Bombs left: {Static.StaticMain.BombQuantity}";
            lblFlagsLeft.Text = $"Flags left: {Static.StaticMain.FlagsQuntity}";
        }

        private void GenerateBoard()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    FieldPanel fieldPanel = new FieldPanel(this);
                    fieldPanel.Location = new Point(i*30,j*30);
                    fieldPanel.FieldValue = (int)Static.MinesweeperEnum.FieldStatus.Empty;
                    fieldPanel.Coordinates = new Point(i, j);
                    gameBoard[i,j] = fieldPanel;
                    panel1.Controls.Add(fieldPanel);
                }
            }
        }

        private void SetBombs()
        {
            int x;
            int y;
            for (int i = 0; i < Static.StaticMain.BombQuantity; i++)
            {
                x = Static.StaticMain.RandomNumber(0, 10);
                y = Static.StaticMain.RandomNumber(0, 10);
                if (gameBoard[x, y].FieldValue == (int)Static.MinesweeperEnum.FieldStatus.Mine) { i--; continue; }
                gameBoard[x, y].FieldValue = (int)Static.MinesweeperEnum.FieldStatus.Mine;
            }
            
        }

        public int CheckConnectedFields(Point coordinates)
        {
            int bombsAround = 0;
            for (int i = coordinates.X - 1; i <= coordinates.X + 1; i++)
            {
                for (int j = coordinates.Y - 1; j <= coordinates.Y + 1; j++)
                {
                    if (i < 0 || j < 0 || i > 9 || j > 9) continue;
                    if (gameBoard[i, j] == gameBoard[coordinates.X, coordinates.Y]) continue;
                    if (gameBoard[i, j].FieldValue == (int)Static.MinesweeperEnum.FieldStatus.Mine) bombsAround++;
                    if (gameBoard[i, j].FieldValue == (int)Static.MinesweeperEnum.FieldStatus.Empty) gameBoard[i, j].RevealField();
                }
            }
            return bombsAround;
        }

        public void CheckIfEveryBombIsTagged()
        {
            int bombStartQuantity = 20;
            foreach (FieldPanel field in gameBoard)
            {
                if(field.FieldValue == (int)Static.MinesweeperEnum.FieldStatus.Mine)
                {
                    if (field.FieldStatus != (int)Static.MinesweeperEnum.FieldStatus.Flag)
                    {
                        continue;
                    }
                    else
                    {
                        bombStartQuantity--;
                    }
                }
            }
            if (bombStartQuantity == 0) MessageBox.Show($"Wygrywko");

            
        }
    }
}
