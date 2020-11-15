using System
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



            System.Media.SoundPlayer Sound_Object = new System.Media.SoundPlayer(Action_game.Properties.Resources.load.wav);

            Sound_Object.Play();







        }

        private void btn_spin_Click(object sender, EventArgs e)
        {
            Btn_Shoot.Enabled = true;//Enable the shoot buuton//
            btn_spin.Enabled = false;//disable the spin button//


            //code to display image in picture box on button click  

            Assembly myAssembly = Assembly.GetExecutingAssembly();

            Stream myStream = myAssembly.GetManifestResourceStream("Action_game.Resources.giphy.gif");

            Bitmap bmp_Object = new Bitmap(myStream);

            Image_box.Image = bmp_Object;

        }

        private void btn_PA_Click(object sender, EventArgs e)
        {
            btn_Load.Enabled = true; //Enable the Load button//
            btn_spin.Enabled = false;//disable the spin button//
            Btn_Shoot.Enabled = false;//disable the shoot button//
            btn_ShootAway.Enabled = false;//disable the shootaway button//

            //code to display image in picture box on button click  

            Assembly myAssembly = Assembly.GetExecutingAssembly();

            Stream myStream = myAssembly.GetManifestResourceStream("Action_game.Resources.shoot away.gif");

            Bitmap bmp_Object = new Bitmap(myStream);

            Image_box.Image = bmp_Object;



        }

        private void btn_ShootAway_Click(object sender, EventArgs e)
        {
            Btn_Shoot.Enabled = false; //disable the shoot button//
            btn_ShootAway.Enabled = false;//disable the shootaway button//


        }

        private void Btn_Shoot_Click(object sender, EventArgs e)
        {
            btn_ShootAway.Enabled = true;//disable the shootaway button//
            Btn_Shoot.Enabled = false;//disable the shoot button//

            //code to display image in picture box on button click  

            Assembly myAssembly = Assembly.GetExecutingAssembly();

            Stream myStream = myAssembly.GetManifestResourceStream("Action_game.Resources.shoot away.gif");

            Bitmap bmp_Object = new Bitmap(myStream);

            Image_box.Image = bmp_Object;

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
