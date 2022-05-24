using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace songgame
{
    public partial class frmMenu : Form
    {
        private SoundPlayer _soundPlayer;
        public frmMenu()
        {
            InitializeComponent();
            _soundPlayer = new SoundPlayer("buttonclicksound.wav");

            txtHome.Text = "Welcome to Rockology.\nThe aim of this game is to test your knowledge about Rock & Roll. \nThe game is played either by yourself or with an opponent. You and your opponent will battle to guess the correct answer.\nThe rock off will consist of two question based categories. In the Genres category you will be presented with artist and you will have to guess, out of four possible answers, the correct genre that artist performs in. In the song category, you will be given the title of a song and players will have to guess the correct artist that performed that song.\n\nAfter an intense 20 round rock off, a winner will be declared!";
        }

       

        

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void imgDuo_Click(object sender, EventArgs e)
        {
            _soundPlayer.Play();
            frmDuoStage duostage = new frmDuoStage();
            duostage.Show();
            this.Hide();
        }

        private void imgsolo_Click(object sender, EventArgs e)
        {
            _soundPlayer.Play();
            frmStage stage = new frmStage();
            stage.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmLobby login = new frmLobby();
            login.Show();
            this.Hide();
        }
    }
}
