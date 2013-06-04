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
            QSetNameShow.Text = Global.QSetName;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            Global.AreYouSure = true;
            this.Close();
        }

        private void NotOkButton_Click(object sender, EventArgs e)
        {
            Global.AreYouSure = false;
            this.Close();
        }

        private void AreUSurecs_Load(object sender, EventArgs e)
        {

        }
    }
}
