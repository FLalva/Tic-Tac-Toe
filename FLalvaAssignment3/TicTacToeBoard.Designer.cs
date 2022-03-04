namespace FLalvaAssignment3
{
    partial class TicTacToeBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlBoard = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnlBoard
            // 
            this.pnlBoard.BackColor = System.Drawing.Color.Turquoise;
            this.pnlBoard.Location = new System.Drawing.Point(132, 157);
            this.pnlBoard.Name = "pnlBoard";
            this.pnlBoard.Size = new System.Drawing.Size(450, 463);
            this.pnlBoard.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(469, 96);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tic Tac Toe";
            // 
            // TicTacToeBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(738, 632);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlBoard);
            this.Name = "TicTacToeBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe Board";
            this.Load += new System.EventHandler(this.TicTacToeBoard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBoard;
        private System.Windows.Forms.Label label1;
    }
}

