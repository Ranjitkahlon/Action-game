using System;
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
    public partial class rules : Form
    {
        public rules()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Actiongame game_obj = new Actiongame();
            game_obj.Show();
            this.Close();
        }

        private void rules_Load(object sender, EventArgs e)
        {

        }
    }
}
