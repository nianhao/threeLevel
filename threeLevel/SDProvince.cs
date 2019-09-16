using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace threeLevel
{
    public partial class SDProvince : Form
    {
        public SDProvince()
        {
            InitializeComponent();
        }

        private void button_JiNanCity_Click(object sender, EventArgs e)
        {
            SDJiNan sdjn = new SDJiNan();
            Program.mw.panelSelectAddForm(sdjn);
        }

        private void button_QingDaoCity_Click(object sender, EventArgs e)
        {
            SDQingDao sdqd = new SDQingDao();
            Program.mw.panelSelectAddForm(sdqd);
        }

        private void button_ZiBoCity_Click(object sender, EventArgs e)
        {
            SDZiBo sdzb = new SDZiBo();
            Program.mw.panelSelectAddForm(sdzb);
        }

        private void button_YanTaiCity_Click(object sender, EventArgs e)
        {
            SDYanTai sdyt = new SDYanTai();
            Program.mw.panelSelectAddForm(sdyt);
        }
    }
}
