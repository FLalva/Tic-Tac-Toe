using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FLalvaAssignment3
{
    enum TileCategory
    {
        None,
        X,
        O
    }

    /// <summary>
    /// Tile class inherited from PictureBox class
    /// </summary>
    class Tile : PictureBox
    {
        int row;
        int col;
        public TileCategory Category { get; set; }

        const int PICTUREBOX_SIZE = 100;

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="row"></param>
        /// <param name="col"></param>
        public Tile(int row, int col)
        {
            this.row = row;
            this.col = col;
            Category = TileCategory.None;

            this.Size = new Size(PICTUREBOX_SIZE, PICTUREBOX_SIZE);

            int x = (row * PICTUREBOX_SIZE);
            int y = (col * PICTUREBOX_SIZE);

            this.Location = new Point(x, y);
        }

        /// <summary>
        /// Method to return row
        /// </summary>
        /// <returns></returns>
        public int GetRow()
        {
            return row;
        }

        /// <summary>
        /// method to return column
        /// </summary>
        /// <returns></returns>
        public int GetCol()
        {
            return col;
        }
    }
}
