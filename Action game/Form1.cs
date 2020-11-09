using System
    ;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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







            ;
        }

        private void btn_spin_Click(object sender, EventArgs e)
        {
            Btn_Shoot.Enabled = true;//Enable the shoot buuton//
            btn_spin.Enabled = false;//disable the spin button//

        }

        private void btn_PA_Click(object sender, EventArgs e)
        {
            btn_Load.Enabled = true; //Enable the Load button//
            btn_spin.Enabled = false;//disable the spin button//
            Btn_Shoot.Enabled = false;//disable the shoot button//
            btn_ShootAway.Enabled = false;//disable the shootaway button//
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
