using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hachmoud
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TirageAuto tirageauto1 = new TirageAuto();
            tirageauto1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 ff = new Form4();
            ff.Show();
        }
      
    }
}
