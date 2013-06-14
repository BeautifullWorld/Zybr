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
        string s;
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
            s = f2.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox1.Text = f2.dataGridView1.CurrentRow.Cells[0].Value + "";
            if (textBox1.Text == null)
                textBox1.Text = (Global.QSet.Count + 1).ToString();
            QuestionWrite.Text = f2.dataGridView1.CurrentRow.Cells[1].Value + "";
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if ((!(s == textBox1.Text)) && (IndexExists(textBox1.Text)))
            {
                MessageBox.Show("Вопрос с таким номером уже существует!");
                return;
            }
            int a=-10;
            try
            {
                a = Convert.ToInt32(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Номер вопроса должен быть натуральным, положительным числом!");
                return;
            }
            if(a<=0)
            {
                MessageBox.Show("Номер вопроса должен быть натуральным, положительным числом!");
                return;
            }
            this.Close();
        }

        private void QChanging_Load(object sender, EventArgs e)
        {

        }

        private void QChanging_FormClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if ((!(s == textBox1.Text)) && (IndexExists(textBox1.Text)))
            {
                MessageBox.Show("Вопрос с таким номером уже существует!");
                e.Cancel = true;
            }
            int a = -10 ;
            try
            {
                a = Convert.ToInt32(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Номер вопроса должен быть натуральным, положительным числом!");
                e.Cancel = true;
            }
            if((a<=0)&&(e.Cancel==false))
            {
                MessageBox.Show("Номер вопроса должен быть натуральным, положительным числом!");
                e.Cancel = true;
            }
        }
    }
}
