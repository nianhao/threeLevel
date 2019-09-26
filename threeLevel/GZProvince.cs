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
    public partial class GZProvince : Form
    {
        public GZProvince()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 点击贵阳市，加载贵阳市的区县
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GuiYangCity_Click(object sender, EventArgs e)
        {
            GYCity gyc = new GYCity();
            Program.mw.panelSelectAddForm(gyc);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GZZunYi gzzy = new GZZunYi();
            Program.mw.panelSelectAddForm(gzzy);
        }

        private void button_GZBiJie_Click(object sender, EventArgs e)
        {
            Console.WriteLine("毕节市点击了");
            GZBiJie gzbj = new GZBiJie();
            Program.mw.panelSelectAddForm(gzbj);
        }

        private void button_GZLiuPanShui_Click(object sender, EventArgs e)
        {
            GZLiuPanShui gzlps = new GZLiuPanShui();
            Program.mw.panelSelectAddForm(gzlps);
        }
    }
}
