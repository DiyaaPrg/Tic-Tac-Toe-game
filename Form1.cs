using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToe.Properties;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            lbWhichPlayer.Text = "Player 1";

            foreach (PictureBox PB in panelBoard.Controls.OfType<PictureBox>()) 
            {
                PB.Click += new EventHandler(XO_Handler);
            }

        }

        public bool isXTurn = true;

        public byte counter = 0;       

        public enum enGameResult { enDraw, enWinning};
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            //this.Text = $"X = {e.X} , Y = {e.Y}";

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color white = Color.FromArgb(255, 255, 255);

            Pen pen = new Pen(white);

            pen.Width = 15;

            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            e.Graphics.DrawLine(pen, 488, 110, 488, 443); // عمود عمودي 1
            e.Graphics.DrawLine(pen, 671, 110, 671, 443); // عمود عمودي2

            e.Graphics.DrawLine(pen, 305, 221, 855, 221); // عمود أفقي 1

            e.Graphics.DrawLine(pen, 305, 332, 855, 332); // عمود أفقي2 


        }

        void ColorWinningSymbols(PictureBox pb1, PictureBox pb2, PictureBox pb3)
        {
            pb1.BackColor = Color.Yellow;
            pb2.BackColor = Color.Yellow;
            pb3.BackColor = Color.Yellow;

        }

        void ShowXOPictures(PictureBox pb)
        {
            if (isXTurn)
            {
                pb.Tag = 'X';
                pb.Image = Resources.alphabet_X;
            }
            else
            {
                pb.Tag = 'O';
                pb.Image = Resources.alphabet_O;

            }
        }

        void ManageTurns()
        {
            if (isXTurn)
            {
                lbWhichPlayer.Text = "Player 2";
                isXTurn = false;
            }
            else
            {
                lbWhichPlayer.Text = "Player 1";
                isXTurn = true;
            }
        }

        bool CheckLine(PictureBox a, PictureBox b, PictureBox c)
        {
            char x = Convert.ToChar(a.Tag);
            char y = Convert.ToChar(b.Tag);
            char z = Convert.ToChar(c.Tag);

            if (x == y && x == z)
            {
                ColorWinningSymbols(a, b, c);
                return true;
            }
            return false;
        }

        bool CheckRow1()
        {
            return CheckLine(pb1, pb2, pb3);
        }

        bool CheckRow2()
        {
            return CheckLine(pb4, pb5, pb6);
        }

        bool CheckRow3()
        {
            return CheckLine(pb7, pb8, pb9);
        }

        bool CheckColumn1()
        {
            return CheckLine(pb1, pb4, pb7);
        }

        bool CheckColumn2()
        {
            return CheckLine(pb2, pb5, pb8);
        }

        bool CheckColumn3()
        {
            return CheckLine(pb3, pb6, pb9);
        }

        bool CheckDiagonal1()
        {
            return CheckLine(pb1, pb5, pb9);
        }

        bool CheckDiagonal2()
        {
            return CheckLine(pb3, pb5, pb7);
        }

        bool CheckWinner(byte cell)
        {
            if (counter < 5)
                return false;
            else
            {
                switch(cell)
                {
                    case 1:
                        return CheckRow1() || CheckColumn1() || CheckDiagonal1();
                    case 2:
                        return CheckRow1() || CheckColumn2();
                    case 3:
                        return CheckRow1() || CheckColumn3() || CheckDiagonal2();
                    case 4:
                        return CheckRow2() || CheckColumn1();
                    case 5:
                        return CheckRow2() || CheckColumn2() || CheckDiagonal1() || CheckDiagonal2();
                    case 6:
                        return CheckRow2() || CheckColumn3();
                    case 7:
                        return CheckRow3() || CheckColumn1() || CheckDiagonal2();
                    case 8:
                        return CheckRow3() || CheckColumn2();
                    case 9:
                        return CheckRow3() || CheckColumn3() || CheckDiagonal1();

                    default:
                        return false;
                }
            }
        }

        void ManageGameOver(enGameResult result)
        {

            foreach (PictureBox PB in panelBoard.Controls.OfType<PictureBox>())
            {
                PB.Enabled = false;
            }


            if (result == enGameResult.enDraw)
            {
                lbWhichWinner.Text = "\tDraw";
            }
            else
                lbWhichWinner.Text = lbWhichPlayer.Text;

            lbWhichPlayer.Text = "Game Over";


            MessageBox.Show("Game Over", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);



        }

        void RestGame()
        {
            counter = 0;
            isXTurn = true;

            foreach (PictureBox PB in panelBoard.Controls.OfType<PictureBox>())
            {
                PB.Enabled = true;
                PB.Image = Resources.question_mark_96;
                PB.BackColor = Color.Black;
            }

            pb1.Tag = 1;
            pb2.Tag = 2;
            pb3.Tag = 3;
            pb4.Tag = 4;
            pb5.Tag = 5;
            pb6.Tag = 6;
            pb7.Tag = 7;
            pb8.Tag = 8;
            pb9.Tag = 9;


            // Labels:
            lbWhichPlayer.Text = "Player 1";
            lbWhichWinner.Text = "In Progress";

 }

        void XO_Handler(object sender, EventArgs e)
        {

            PictureBox pb = sender as PictureBox;
            char symbol = Convert.ToChar(pb.Tag);

            if (symbol == 'X' || symbol == 'O') // checking that the cell doesn't choosed before
            {
                MessageBox.Show("Wrong Choice", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ++counter; // it add 1 if the choice isn't choosed before

            byte cell = Convert.ToByte(pb.Tag);

            ShowXOPictures(pb);

            if (CheckWinner(cell))
            {
                ManageGameOver(enGameResult.enWinning);
            }
            else if (counter == 9)
            {
                ManageGameOver(enGameResult.enDraw);
            }
            else
            {
                ManageTurns(); 
            }



        }


        private void btRestarteGame_Click(object sender, EventArgs e)
        {
            RestGame();
        }

    }
}
