using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_FireGmae
{
    public partial class Play_here : Form
    {
        gameChanger gChanger = new gameChanger();
       
        public int fire_Count = 0,frstAway_Count=0,frstShoot=0,fireAwayShoot=0;

        public Play_here()
        {
            InitializeComponent();
            disableBtn();
        }
        public void disableBtn() {
            load_game.Enabled = false;
            spin_gun.Enabled = false;
            fire_gun.Enabled = false;
            fire_away.Enabled = false;
            frstShoot = gChanger.getNumber(1, 6);
            fireAwayShoot = gChanger.getNumber(1, 3);
        }

        private void Play_here_Load(object sender, EventArgs e)
        {

        }

        private void First_btn_Click(object sender, EventArgs e)
        {
            //when we click on the start button then this is very important to start the process 
            load_game.Enabled = true;
            
            
        }

        private void load_game_Click(object sender, EventArgs e)
        {
            spin_gun.Enabled = true;
            gChanger.loadBtn(pbFireBox);
        }

        // exit the game 

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // using random function for shooting 

        private void fire_away_Click(object sender, EventArgs e)
        {

            frstAway_Count++;
            gChanger.fireBtn(pbFireBox);
            if (frstAway_Count != 2)
            {
                System.Media.SoundPlayer sund = new System.Media.SoundPlayer(Game_FireGmae.Properties.Resources.Shot);
                sund.Play();

                if (frstAway_Count ==fireAwayShoot)
                {
                    MessageBox.Show("Your are Dead ");
                    exit.Enabled = true;
                    fire_away.Enabled = false;
                }
                else
                {
                    MessageBox.Show("You Still Ailive ");
                }
            }
            else
            {
                fire_away.Enabled = false;
                exit.Enabled = true;
            }

        }

        // spin button enabling and disabling the othering buttons

        private void spin_gun_Click(object sender, EventArgs e)
        {
            fire_gun.Enabled = true;
            fire_away.Enabled = true;
            spin_gun.Enabled = false;

            gChanger.spinBtn(pbFireBox);

        }

        // this button giving another chance to shoot 

        private void fire_gun_Click(object sender, EventArgs e)
        {

            fire_Count++;
            gChanger.fireBtn(pbFireBox);
            if (fire_Count != 4)
            {
                System.Media.SoundPlayer sund = new System.Media.SoundPlayer(Game_FireGmae.Properties.Resources.Shot);
                sund.Play();

                if (frstShoot == fire_Count)
                {
                    MessageBox.Show("Your are Dead ");
                    exit.Enabled = true;
                    fire_gun.Enabled = false;
                }
                else
                {
                    MessageBox.Show("You Still Ailive ");
                }
            }
            else {
                fire_gun.Enabled = false;
                exit.Enabled = true;
            }
            


        }
    }
}
