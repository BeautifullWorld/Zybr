using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class AreUSurecs : Form
    {
        public AreUSurecs()
        {
            InitializeComponent();
            textBox1.Text = Global.QSetName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Global.AreYouSure = true;
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Global.AreYouSure = false;
            this.Close();
        }
    }
}
