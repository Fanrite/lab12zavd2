using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace Inputdata
{
    
    class Input
    {
        public static bool Indouble(ref double p, string buk)
        {
            string inp;
            dynamic dyno;

        vvod:
            inp = Interaction.InputBox(buk, "vvedenia", $"{p}");
            try
            {
                p = Convert.ToDouble(inp);
            }
            catch (System.FormatException)
            {
                if (MessageBox.Show("vi vveli ne 4islo" + "\npovtorit?", "uvaga", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    goto vvod;
                else
                    return false;
            }
            return true;
        }
        public static bool Inint(ref int p, string buk)
        {
            string inp;

        vvod:
            inp = Interaction.InputBox(buk, "vvedenia", $"{p}");
            try
            {
                p = Convert.ToInt32(inp);
            }
            catch (System.FormatException)
            {
                if (MessageBox.Show("vi vveli ne 4islo" + "\npovtorit?", "uvaga", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    goto vvod;
                else
                    return false;
            }
            return true;
        }
        public static bool In1in2(ref string p, string buk)
        {
            string inp;

        vvod:
            inp = Interaction.InputBox(buk, "vvedenia", $"{p}");
            if (inp == "a" || inp == "A")
                p = "a";

            else if (inp == "b" || inp == "B")
                p = "b";

            else
            {
                if (MessageBox.Show("vi vveli ne pravelni danni, povtorit" + "\npovtorit?", "uvaga", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    goto vvod;
                else
                    return false;
            }

            return true;
        }
    }
}
