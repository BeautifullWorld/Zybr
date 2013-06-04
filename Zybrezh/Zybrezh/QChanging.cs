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
    public partial class QChanging : Form
    {
        public QChanging(Form2 f2)//изменил конструктор, чтобы получить значенния из Form2
        {
            InitializeComponent();
            textBox1.Text = f2.dataGridView1.CurrentRow.Cells[0].Value + "";
            QuestionWrite.Text = f2.dataGridView1.CurrentRow.Cells[1].Value + "";
        }

        private void Save_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
