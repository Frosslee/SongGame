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
   
    public partial class frmLobby : Form
    {
        private SoundPlayer _soundPlayer;
        public frmLobby()
        {
            InitializeComponent();
            _soundPlayer = new SoundPlayer("String_Bend_7_120.wav");
        }

      

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //login 
            try
            {
                if ( txtUsername.Text!=""||txtPassword.Text!="")//confirms that the txtboxes are not empty
                {
                    string username = txtUsername.Text;
                    string password = txtPassword.Text;
                    Users userdetail = new Users(username, password);//creates user object 
                    if (userdetail.validateuser())//does the validation and returns true or false
                    {
                        _soundPlayer.Play();//plays the login guitar riff
                        frmMenu MENU = new frmMenu();//used for displaying other forms
                        MENU.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("wrong Username or password have been entered");
                    }
                    
                }
                else
                {
                    throw new EmptyTextBookException("Please ensure that you have entered your username and password");//thorws custom exception
                }
            }
            catch(EmptyTextBookException et)
            {
                MessageBox.Show(et.Message);
            }
            
            
        }

        private void frmLobby_Load(object sender, EventArgs e)
        {
           
           
        }
    }
}
