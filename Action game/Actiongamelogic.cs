using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Action_game
{
    public class Actiongamelogic
    {
        public int Load_data { get; set; }
        public int Spin_data { get; set; }
        public int Shoot_data { get; set; }

        public int shoot_method()
        {
            if (Load_data == Spin_data)
            {
                return 1;
            }
            else if (Spin_data == 6)
            {
                Spin_data = 1;
                return 0;
            }
            else
            {
                Spin_data++;
                return 0;
            }

        }
    }
}
