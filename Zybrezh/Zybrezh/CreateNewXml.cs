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

        private void NotOkButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (File.Exists(QSetNameWrite.Text + ".xml")) label1.Text = "База с таким именем уже существует";
            else if (QSetNameWrite.Text.Length<1) label1.Text = "Такое значение не допустимо";
            else
            {
                Global.QSetName = QSetNameWrite.Text;
                Global.CreateXMLDocument(Global.QSetName);
                this.Close();
            }
        }

        private void CreateNewXml_Load(object sender, EventArgs e)
        {

        }
    }
}
