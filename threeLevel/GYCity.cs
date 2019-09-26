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
    public partial class GYCity : Form
    {
        public GYCity()
        {
            InitializeComponent();
        }

        private void button_NanMing_Click(object sender, EventArgs e)
        {
            NanMingQv nmq = new NanMingQv();
            control ctf = new control();
            Program.mw.panelSelectAddForm(nmq);
            Program.mw.panel_ControlAddForm(ctf);
        }
    }
}
