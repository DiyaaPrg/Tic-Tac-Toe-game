namespace TicTacToe
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btRestarteGame = new System.Windows.Forms.Button();
            this.lbWhichPlayer = new System.Windows.Forms.Label();
            this.lbWhichWinner = new System.Windows.Forms.Label();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.pb4 = new System.Windows.Forms.PictureBox();
            this.pb5 = new System.Windows.Forms.PictureBox();
            this.pb6 = new System.Windows.Forms.PictureBox();
            this.pb7 = new System.Windows.Forms.PictureBox();
            this.pb8 = new System.Windows.Forms.PictureBox();
            this.pb9 = new System.Windows.Forms.PictureBox();
            this.panelBoard = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb9)).BeginInit();
            this.panelBoard.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(360, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(303, 45);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tic-Tac-Toe Game";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(100, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "Turn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(82, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 45);
            this.label3.TabIndex = 3;
            this.label3.Text = "Winner";
            // 
            // btRestarteGame
            // 
            this.btRestarteGame.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btRestarteGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btRestarteGame.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRestarteGame.ForeColor = System.Drawing.Color.White;
            this.btRestarteGame.Location = new System.Drawing.Point(54, 375);
            this.btRestarteGame.Name = "btRestarteGame";
            this.btRestarteGame.Size = new System.Drawing.Size(213, 45);
            this.btRestarteGame.TabIndex = 4;
            this.btRestarteGame.Text = "Restart Game";
            this.btRestarteGame.UseVisualStyleBackColor = false;
            this.btRestarteGame.Click += new System.EventHandler(this.btRestarteGame_Click);
            // 
            // lbWhichPlayer
            // 
            this.lbWhichPlayer.AutoSize = true;
            this.lbWhichPlayer.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWhichPlayer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbWhichPlayer.Location = new System.Drawing.Point(82, 143);
            this.lbWhichPlayer.Name = "lbWhichPlayer";
            this.lbWhichPlayer.Size = new System.Drawing.Size(161, 45);
            this.lbWhichPlayer.TabIndex = 5;
            this.lbWhichPlayer.Text = "Player 1";
            // 
            // lbWhichWinner
            // 
            this.lbWhichWinner.AutoSize = true;
            this.lbWhichWinner.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWhichWinner.ForeColor = System.Drawing.Color.Lime;
            this.lbWhichWinner.Location = new System.Drawing.Point(59, 282);
            this.lbWhichWinner.Name = "lbWhichWinner";
            this.lbWhichWinner.Size = new System.Drawing.Size(221, 45);
            this.lbWhichWinner.TabIndex = 6;
            this.lbWhichWinner.Text = "In Progress";
            // 
            // pb1
            // 
            this.pb1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb1.Image = global::TicTacToe.Properties.Resources.question_mark_9796625;
            this.pb1.Location = new System.Drawing.Point(36, 22);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(49, 50);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb1.TabIndex = 7;
            this.pb1.TabStop = false;
            this.pb1.Tag = "1";
            this.pb1.Click += new System.EventHandler(this.pb1_Click);
            this.pb1.MouseEnter += new System.EventHandler(this.pb1_MouseEnter);
            // 
            // pb2
            // 
            this.pb2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb2.Image = ((System.Drawing.Image)(resources.GetObject("pb2.Image")));
            this.pb2.Location = new System.Drawing.Point(221, 22);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(49, 50);
            this.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb2.TabIndex = 16;
            this.pb2.TabStop = false;
            this.pb2.Tag = "2";
            // 
            // pb3
            // 
            this.pb3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb3.Image = ((System.Drawing.Image)(resources.GetObject("pb3.Image")));
            this.pb3.Location = new System.Drawing.Point(405, 22);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(49, 50);
            this.pb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb3.TabIndex = 17;
            this.pb3.TabStop = false;
            this.pb3.Tag = "3";
            // 
            // pb4
            // 
            this.pb4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb4.Image = ((System.Drawing.Image)(resources.GetObject("pb4.Image")));
            this.pb4.Location = new System.Drawing.Point(36, 135);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(49, 50);
            this.pb4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb4.TabIndex = 18;
            this.pb4.TabStop = false;
            this.pb4.Tag = "4";
            // 
            // pb5
            // 
            this.pb5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb5.Image = ((System.Drawing.Image)(resources.GetObject("pb5.Image")));
            this.pb5.Location = new System.Drawing.Point(221, 135);
            this.pb5.Name = "pb5";
            this.pb5.Size = new System.Drawing.Size(49, 50);
            this.pb5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb5.TabIndex = 19;
            this.pb5.TabStop = false;
            this.pb5.Tag = "5";
            // 
            // pb6
            // 
            this.pb6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb6.Image = ((System.Drawing.Image)(resources.GetObject("pb6.Image")));
            this.pb6.Location = new System.Drawing.Point(405, 135);
            this.pb6.Name = "pb6";
            this.pb6.Size = new System.Drawing.Size(49, 50);
            this.pb6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb6.TabIndex = 20;
            this.pb6.TabStop = false;
            this.pb6.Tag = "6";
            // 
            // pb7
            // 
            this.pb7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb7.Image = ((System.Drawing.Image)(resources.GetObject("pb7.Image")));
            this.pb7.Location = new System.Drawing.Point(36, 254);
            this.pb7.Name = "pb7";
            this.pb7.Size = new System.Drawing.Size(49, 50);
            this.pb7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb7.TabIndex = 21;
            this.pb7.TabStop = false;
            this.pb7.Tag = "7";
            // 
            // pb8
            // 
            this.pb8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb8.Image = ((System.Drawing.Image)(resources.GetObject("pb8.Image")));
            this.pb8.Location = new System.Drawing.Point(221, 254);
            this.pb8.Name = "pb8";
            this.pb8.Size = new System.Drawing.Size(49, 50);
            this.pb8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb8.TabIndex = 22;
            this.pb8.TabStop = false;
            this.pb8.Tag = "8";
            // 
            // pb9
            // 
            this.pb9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb9.Image = ((System.Drawing.Image)(resources.GetObject("pb9.Image")));
            this.pb9.Location = new System.Drawing.Point(405, 254);
            this.pb9.Name = "pb9";
            this.pb9.Size = new System.Drawing.Size(49, 50);
            this.pb9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb9.TabIndex = 23;
            this.pb9.TabStop = false;
            this.pb9.Tag = "9";
            // 
            // panelBoard
            // 
            this.panelBoard.BackColor = System.Drawing.Color.Transparent;
            this.panelBoard.Controls.Add(this.pb9);
            this.panelBoard.Controls.Add(this.pb8);
            this.panelBoard.Controls.Add(this.pb7);
            this.panelBoard.Controls.Add(this.pb6);
            this.panelBoard.Controls.Add(this.pb5);
            this.panelBoard.Controls.Add(this.pb4);
            this.panelBoard.Controls.Add(this.pb3);
            this.panelBoard.Controls.Add(this.pb2);
            this.panelBoard.Controls.Add(this.pb1);
            this.panelBoard.Location = new System.Drawing.Point(334, 121);
            this.panelBoard.Name = "panelBoard";
            this.panelBoard.Size = new System.Drawing.Size(496, 321);
            this.panelBoard.TabIndex = 24;
            this.panelBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBoard_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(939, 625);
            this.Controls.Add(this.panelBoard);
            this.Controls.Add(this.lbWhichWinner);
            this.Controls.Add(this.lbWhichPlayer);
            this.Controls.Add(this.btRestarteGame);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Tic-Tac-Toe Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb9)).EndInit();
            this.panelBoard.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btRestarteGame;
        private System.Windows.Forms.Label lbWhichPlayer;
        private System.Windows.Forms.Label lbWhichWinner;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.PictureBox pb4;
        private System.Windows.Forms.PictureBox pb5;
        private System.Windows.Forms.PictureBox pb6;
        private System.Windows.Forms.PictureBox pb7;
        private System.Windows.Forms.PictureBox pb8;
        private System.Windows.Forms.PictureBox pb9;
        private System.Windows.Forms.Panel panelBoard;
    }
}

