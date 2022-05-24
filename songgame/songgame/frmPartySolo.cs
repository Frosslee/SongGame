using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace songgame
{
    public partial class frmPartySolo : Form
    {
        int scorePlayerOne;
        int scorePlayerTwo;
        string playerAmount;
        public frmPartySolo(int x)
        {
            playerAmount = "One";
            scorePlayerOne = x;
            InitializeComponent();
        }
        public frmPartySolo(int x,int y )
        {
            playerAmount = "Two";
            scorePlayerOne = x;
            scorePlayerTwo = y;
            InitializeComponent();
        }

        private void frmPartySolo_Load(object sender, EventArgs e)
        {

            if (playerAmount=="One")
            {
                if(scorePlayerOne >5)
                {
                    lblCongrats.Text = "Well played, YOU did AwEsOmElY!!!!";
                    lblPlayerTwos.Text = "";
                    label2.Text = "";
                }
                else
                {
                    lblCongrats.Text = "Better luck next time, my yster";
                     lblPlayerTwos.Text = "";
                    label2.Text = "";
                }
                lblscore.Text = scorePlayerOne.ToString();
            }
            else
            {
                lblscore.Text = scorePlayerOne.ToString();
                lblPlayerTwos.Text = scorePlayerTwo.ToString();

                lblCongrats.Text = Winner(scorePlayerOne, scorePlayerTwo);

            }
            
        }
        public string Winner(int p1, int p2)
        {
            if (p1 > p2)
            {
                return "Well played player one you won!!!!";
            }
            else if (p1 == p2)
            {
                return "Looks like we came to a Stalemate";
            }
            else
            {
                return "Well played player two you won!!!!"; 
            }
        }

        private void btnRetun_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            menu.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
