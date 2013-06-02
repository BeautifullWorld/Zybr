using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class CreateNewXml : Form
    {
        public CreateNewXml()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (File.Exists(textBox1.Text + ".xml")) label1.Text = "База с таким именем уже существует";
            else if (textBox1.Text.Length<1) label1.Text = "Такое значение не допустимо";
            else
            {
                Global.QSetName = textBox1.Text;
                Global.CreateXMLDocument(Global.QSetName);
                this.Close();
            }
        }
    }
}
