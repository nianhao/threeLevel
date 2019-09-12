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
    public partial class JLProvince : Form
    {
        public JLProvince()
        {
            InitializeComponent();
        }

        private void button_GuiYangCity_Click(object sender, EventArgs e)
        {
            JLChangChun jlcc = new JLChangChun();
            Program.mw.panelSelectAddForm(jlcc);
        }

        private void button_JLJiLin_Click(object sender, EventArgs e)
        {
            JLJiLin jljl = new JLJiLin();
            Program.mw.panelSelectAddForm(jljl);
        }

        private void button_JLSiPing_Click(object sender, EventArgs e)
        {
            JLSiPing jlsp = new JLSiPing();
            Program.mw.panelSelectAddForm(jlsp);
        }

        private void button_JLLiaoYuan_Click(object sender, EventArgs e)
        {
            JLLiaoYuan jlly = new JLLiaoYuan();
            Program.mw.panelSelectAddForm(jlly);
        }
    }
}
