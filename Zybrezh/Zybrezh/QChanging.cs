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
        /////////////////////////////////
        public bool IndexExists(string a)
        {
            bool b = false;
            for (int i = 0; i < Global.QSet.Count; i++)
            {
                if (Global.QSet[i].id == a) b = true;
            }
            return b;
        }

        public QChanging(Form2 f2)//изменил конструктор, чтобы получить значенния из Form2
        {
            InitializeComponent();
            textBox1.Text = f2.dataGridView1.CurrentRow.Cells[0].Value + "";
            if (textBox1.Text == null)
                textBox1.Text = (Global.QSet.Count + 1).ToString();
            QuestionWrite.Text = f2.dataGridView1.CurrentRow.Cells[1].Value + "";
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (IndexExists(textBox1.Text))
            {
                MessageBox.Show("Вопрос с таким номером уже существует!");
                return;
            }
            this.Close();
        }
    }
}
