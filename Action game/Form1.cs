﻿using System
    ;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Action_game
{
    public partial class Actiongame : Form
    {
        Actiongamelogic game_object = new Actiongamelogic();
        public Actiongame()
        {
            InitializeComponent();
        }

     

        private void Actiongame_Load(object sender, EventArgs e)
        {
            btn_spin.Enabled = false;//disable the spin button//
            Btn_Shoot.Enabled = false;//disable the shoot button//
            btn_ShootAway.Enabled = false; //disable the shootaway//

        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
            btn_spin.Enabled = true;//Enable the spin button//
            btn_Load.Enabled = false;//disable the Load button//


            //code to display image in picture box on button click  

            Assembly myAssembly = Assembly.GetExecutingAssembly();

            Stream myStream = myAssembly.GetManifestResourceStream("Action_game.Resources.load.gif");

            Bitmap bmp_Object = new Bitmap(myStream);

            Image_box.Image = bmp_Object;


            // code for sound//
            System.Media.SoundPlayer Sound_Object = new System.Media.SoundPlayer(Action_game.Properties.Resources.load1);

            Sound_Object.Play();



                //code for logic//
                game_object.Load_data = 1;


            }

        private void btn_spin_Click(object sender, EventArgs e)
        {
            Btn_Shoot.Enabled = true;//Enable the shoot buuton//
            btn_ShootAway.Enabled = true;//Enable the shootaway  buuton//
             btn_spin.Enabled = false;//disable the spin button//


            //code to display image in picture box on button click  

            Assembly myAssembly = Assembly.GetExecutingAssembly();

            Stream myStream = myAssembly.GetManifestResourceStream("Action_game.Resources.giphy.gif");

            Bitmap bmp_Object = new Bitmap(myStream);

            Image_box.Image = bmp_Object;

                    //logic//
                Random Rnd_obj = new Random();
                game_object.Spin_data = Rnd_obj.Next(1, 7);

                MessageBox.Show("Bullet Position after spining the chamber is " + game_object.Spin_data.ToString());

            }

        private void btn_PA_Click(object sender, EventArgs e)
        {
            btn_Load.Enabled = true; //Enable the Load button//
            btn_spin.Enabled = false;//disable the spin button//
            Btn_Shoot.Enabled = false;//disable the shoot button//
            btn_ShootAway.Enabled = false;//disable the shootaway button//

            //code to display image in picture box on button click  

            Assembly myAssembly = Assembly.GetExecutingAssembly();

            Stream myStream = myAssembly.GetManifestResourceStream("Action_game.Resources.playagin.jpg");

            Bitmap bmp_Object = new Bitmap(myStream);

            Image_box.Image = bmp_Object;



        }

        private void btn_ShootAway_Click(object sender, EventArgs e)
        {
            if (game_object.chances <= 2)
            {
                game_object.Shoot_data = game_object.shoot_method();
                if (game_object.Shoot_data == 1)
                {
                    // Sound code
                    System.Media.SoundPlayer Sound_Object = new System.Media.SoundPlayer(Action_game.Properties.Resources.sound1);

                    Sound_Object.Play();
                    MessageBox.Show("Wow!! you are safe. you win the game");
                    Btn_Shoot.Enabled = false;
                    btn_ShootAway.Enabled = false;
                }
                else
                {
                    game_object.chances++;
                    if (game_object.chances == 2)
                    {
                        MessageBox.Show("Your 2 chances are finished. you lose the game");
                    }
                    else
                    {
                        MessageBox.Show("emply shoot");
                    }
                }

            }
        }





        private void Btn_Shoot_Click(object sender, EventArgs e)
        {
            btn_ShootAway.Enabled = true;//disable the shootaway button//
            Btn_Shoot.Enabled = true;//disable the shoot button//

            //code to display image in picture box on button click  

            Assembly myAssembly = Assembly.GetExecutingAssembly();

            Stream myStream = myAssembly.GetManifestResourceStream("Action_game.Resources.shoot.gif");

            Bitmap bmp_Object = new Bitmap(myStream);

            Image_box.Image = bmp_Object;




                       // code for sound//
  System.Media.SoundPlayer Sound_Object = new System.Media.SoundPlayer(Action_game.Properties.Resources.sound1);

            Sound_Object.Play();
            //logic 
            game_object.Shoot_data = game_object.shoot_method();
            if (game_object.Shoot_data == 1)
            {
                
                MessageBox.Show("Bullet shot on your head. You are dead");
            }
            else
            {
                MessageBox.Show("emply shoot");
            }


        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_rule_Click(object sender, EventArgs e)
        {
            rules rules_obj = new rules();
            rules_obj.Show();
            this.Hide();
        }
    }
}
