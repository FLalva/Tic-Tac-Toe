//FLalvaAssignment3.slm
//Assignment 3 Tic Tac Toe

//Created by: Fatima Lalva
    //2019/11/14

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FLalvaAssignment3
{
    public partial class TicTacToeBoard : Form
    {
        Image o = Properties.Resources.o;
        Image x = Properties.Resources.x;

        bool player1Turn = true;

        Tile[,] tileArray;

        public TicTacToeBoard()
        {
            InitializeComponent();
        }

        private void TicTacToeBoard_Load(object sender, EventArgs e)
        {
            GenerateBoard();
        }

        /// <summary>
        /// Method to generate new board
        /// </summary>
        private void GenerateBoard()
        {
            tileArray = new Tile[3, 3];

            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Tile tile = new Tile(row, col);
                    tile.Click += Tile_Click;
                    tile.BorderStyle = BorderStyle.FixedSingle;
                    tileArray[row, col] = tile;

                    pnlBoard.Controls.Add(tile);
                }
            }
        }

        /// <summary>
        /// for every click on picturebox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tile_Click (object sender, EventArgs e)
        {
            Tile tile = sender as Tile;

            if (player1Turn)
            {
                tile.Image = x;
                tile.SizeMode = PictureBoxSizeMode.StretchImage;
                tile.Category = TileCategory.X;
                tile.Enabled = false;

                int row = tile.GetRow();
                int col = tile.GetCol();
                tileArray[row, col].Category = TileCategory.X;
                player1Turn = !player1Turn;
            }
            else if (!player1Turn)
            {
                tile.Image = o;
                tile.SizeMode = PictureBoxSizeMode.StretchImage;
                tile.Category = TileCategory.O;
                tile.Enabled = false;

                int row = tile.GetRow();
                int col = tile.GetCol();
                tileArray[row, col].Category = TileCategory.O;

                player1Turn = !player1Turn;
            }

            CheckGameEnd();
        }

        /// <summary>
        /// Method to check if game is finished
        /// </summary>
        private void CheckGameEnd()
        {
            //check if O won
            if ((tileArray[0, 0].Category == TileCategory.O &&
                tileArray[1, 0].Category == TileCategory.O &&
                tileArray[2, 0].Category == TileCategory.O) ||
                (tileArray[0, 1].Category == TileCategory.O &&
                tileArray[1, 1].Category == TileCategory.O &&
                tileArray[2, 1].Category == TileCategory.O) ||
                (tileArray[0, 2].Category == TileCategory.O &&
                tileArray[1, 2].Category == TileCategory.O &&
                tileArray[2, 2].Category == TileCategory.O) ||

                (tileArray[0, 0].Category == TileCategory.O &&
                tileArray[0, 1].Category == TileCategory.O &&
                tileArray[0, 2].Category == TileCategory.O) ||
                (tileArray[1, 0].Category == TileCategory.O &&
                tileArray[1, 1].Category == TileCategory.O &&
                tileArray[1, 2].Category == TileCategory.O) ||
                (tileArray[2, 0].Category == TileCategory.O &&
                tileArray[2, 1].Category == TileCategory.O &&
                tileArray[2, 2].Category == TileCategory.O) ||

                (tileArray[0, 0].Category == TileCategory.O &&
                tileArray[1, 1].Category == TileCategory.O &&
                tileArray[2, 2].Category == TileCategory.O) ||
                (tileArray[2, 0].Category == TileCategory.O &&
                tileArray[1, 1].Category == TileCategory.O &&
                tileArray[0, 2].Category == TileCategory.O))
            {
                MessageBox.Show("O WINS!");
                pnlBoard.Controls.Clear();
                player1Turn = true;
                GenerateBoard();
            }

            //check if X won
            if ((tileArray[0, 0].Category == TileCategory.X &&
                tileArray[1, 0].Category == TileCategory.X &&
                tileArray[2, 0].Category == TileCategory.X) ||
                (tileArray[0, 1].Category == TileCategory.X &&
                tileArray[1, 1].Category == TileCategory.X &&
                tileArray[2, 1].Category == TileCategory.X) ||
                (tileArray[0, 2].Category == TileCategory.X &&
                tileArray[1, 2].Category == TileCategory.X &&
                tileArray[2, 2].Category == TileCategory.X) ||

                (tileArray[0, 0].Category == TileCategory.X &&
                tileArray[0, 1].Category == TileCategory.X &&
                tileArray[0, 2].Category == TileCategory.X) ||
                (tileArray[1, 0].Category == TileCategory.X &&
                tileArray[1, 1].Category == TileCategory.X &&
                tileArray[1, 2].Category == TileCategory.X) ||
                (tileArray[2, 0].Category == TileCategory.X &&
                tileArray[2, 1].Category == TileCategory.X &&
                tileArray[2, 2].Category == TileCategory.X) ||

                (tileArray[0, 0].Category == TileCategory.X &&
                tileArray[1, 1].Category == TileCategory.X &&
                tileArray[2, 2].Category == TileCategory.X) ||
                (tileArray[2, 0].Category == TileCategory.X &&
                tileArray[1, 1].Category == TileCategory.X &&
                tileArray[0, 2].Category == TileCategory.X))
            {
                MessageBox.Show("X WINS!");
                pnlBoard.Controls.Clear();
                player1Turn = true;
                GenerateBoard();
            }

            //check for draw
            if (tileArray[0, 0].Category != TileCategory.None && tileArray[0, 1].Category != TileCategory.None &&
                tileArray[0, 2].Category != TileCategory.None && tileArray[1, 0].Category != TileCategory.None &&
                tileArray[1, 1].Category != TileCategory.None && tileArray[1, 2].Category != TileCategory.None &&
                tileArray[2, 0].Category != TileCategory.None && tileArray[2, 1].Category != TileCategory.None &&
                tileArray[2, 2].Category != TileCategory.None)
            {
                MessageBox.Show("DRAW!");
                pnlBoard.Controls.Clear();
                player1Turn = true;
                GenerateBoard();
            }
        }
    }
}
