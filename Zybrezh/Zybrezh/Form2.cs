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
    public partial class Form2 : Form
    {
        ////////////////////////////////////////////////////////////////////////////////
        public void FillDataGridView(List<Global.Question> Q) //заполняет таблицу-список
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < Q.Count; i++)
            {
                dataGridView1.Rows.Add(Q[i].id, Q[i].Text, Global.GetRatio(Q[i].ratio));
            }
        }
        ////////////////////////////////////////////
        public int MaxIndex(List<Global.Question> Q)
        {
            int max = 0, num1, num2;
            if (Q.Count > 0)
            {
                max = Convert.ToInt32(Q[0].id);
                if (max != 1) return 0;
                num2 = max;
                for (int i = 1; i < Q.Count; i++)
                {
                    num1 = Convert.ToInt32(Q[i].id);
                    if (num2 == num1) num2--;
                    if (num1 != num2 + 1) return num2;
                    if (max < num1)
                        max = num1;
                    num2 = num1;
                }
            }
            return max;
        }

        public Form2()
        {
            InitializeComponent();
            textBox1.Text = (MaxIndex(Global.QSet)+1) + "";
            if (Global.QSet.Count > 0)
            {
                FillDataGridView(Global.QSet);
                Delete.BackColor = Color.FromArgb(255, 255, 192);
                Delete.Enabled = true;
                Change.BackColor = Color.FromArgb(255, 255, 192);
                Change.Enabled = true;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void Next_Click(object sender, EventArgs e) //Добавить
        {
            Global.Question New = new Global.Question();
            New.Text = QuestionWrite.Text;
            New.Queue_place = Global.LastPlaceInQueue("A");
            New.id = textBox1.Text;
            New.Queue_name = "A";
            New.ratio = null;
            Global.QSet.Add(New);
            Global.QSet.Sort(new Global.Question.SortById());
            FillDataGridView(Global.QSet);
            QuestionWrite.Text = null; //обновим
            textBox1.Text = (MaxIndex(Global.QSet) + 1) + "";
            if (Global.QSet.Count > 0)
            {
                Delete.BackColor = Color.FromArgb(255, 255, 192);
                Delete.Enabled = true;
                Change.BackColor = Color.FromArgb(255, 255, 192);
                Change.Enabled = true;
            }
            QuestionWrite.Focus();
        }

        private void End_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dataGridView1.SelectedRows)
            {

                string ind = r.Cells[0].Value.ToString();
                Global.Question New = new Global.Question();
                New = Global.QSet.Find(p => p.id == ind);
                dataGridView1.Rows.Remove(r);
                Global.CorrectErrorInQueue(New.Queue_name, New.Queue_place);
                Global.QSet.Remove(New);
                
            }
            textBox1.Text = (MaxIndex(Global.QSet) + 1) + "";
            if (Global.QSet.Count == 0)
            {
                Delete.BackColor = Color.Gray;
                Delete.Enabled = false;
                Change.BackColor = Color.Gray;
                Change.Enabled = false;
            }
        }

        public void Change_Click(object sender, EventArgs e)//ТУТ НАДО ПРОВЕРИТЬ НЕ ПОРТЯТСЯ ЛИ НОВЫЕ АТРИБУТЫ!!!  вроде, нет
        {
            QChanging QChanging = new QChanging(this);
            this.Hide();
            int index = dataGridView1.CurrentRow.Index;
            string ind = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            QChanging.ShowDialog();
            QChanging.Close();
            Global.Question New = new Global.Question();
            New = Global.QSet.Find(p => p.id == ind);
            New.id = QChanging.textBox1.Text;
            New.Text = QChanging.QuestionWrite.Text;
            Global.QSet.Sort(new Global.Question.SortById());
            FillDataGridView(Global.QSet);
            textBox1.Text = (MaxIndex(Global.QSet) + 1) + "";
            this.Show();
        }
    }
}