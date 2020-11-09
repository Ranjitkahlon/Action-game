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
            btn_spin.Enabled = false;
            Btn_Shoot.Enabled = false;
            btn_ShootAway.Enabled = false;

        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
            btn_spin.Enabled = true;
            btn_Load.Enabled = false;
            ;
        }

        private void btn_spin_Click(object sender, EventArgs e)
        {
            Btn_Shoot.Enabled = true;
            btn_spin.Enabled = false;
        }

        private void btn_PA_Click(object sender, EventArgs e)
        {
            btn_Load.Enabled = true;
            btn_spin.Enabled = false;
            Btn_Shoot.Enabled = false;
            btn_ShootAway.Enabled = false;
        }

        private void btn_ShootAway_Click(object sender, EventArgs e)
        {
            Btn_Shoot.Enabled = false; 
            btn_ShootAway.Enabled = false;
          

        }

        private void Btn_Shoot_Click(object sender, EventArgs e)
        {
            btn_ShootAway.Enabled = true;
            Btn_Shoot.Enabled = false;
        }
    }
}
