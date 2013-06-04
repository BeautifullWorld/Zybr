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
        public Form2()
        {
            InitializeComponent();
            NQ.Text = "Вопрос №" + (Global.QSet.Count+1); //типа следующий же
            if (Global.QSet.Count > 0)
            {
                for (int i = 0; i < Global.QSet.Count; i++)
                {
                    dataGridView1.Rows.Add(Global.QSet[i].id+1, Global.QSet[i].Text);
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void Next_Click(object sender, EventArgs e) //Добавить
        {
            Global.Question New = new Global.Question(); //новый вопрос создался однако
            New.Text = QuestionWrite.Text;
            New.Attribute = 69; //ибо я пошлый
            New.id = Global.QSet.Count.ToString(); //новый же вопрос сюда пихаем потом надо доработать что новый необязон последний ну или я хз чё
            dataGridView1.Rows.Add(New.id, New.Text);
            Global.QSet.Add(New); //в список его!
            QuestionWrite.Text = null; //обновим
            NQ.Text = "Вопрос №" + (Global.QSet.Count + 1);
        }

        private void End_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dataGridView1.SelectedRows)
            {
                int ind = r.Index;
                dataGridView1.Rows.RemoveAt(ind);
                Global.QSet.RemoveAt(ind);
            }
            NQ.Text = "Вопрос №" + (Global.QSet.Count + 1);
        }

        public void Change_Click(object sender, EventArgs e)//изменить
        {
            QChanging QChanging = new QChanging(this);
            this.Hide();
            QChanging.ShowDialog();
            QChanging.Close();
            dataGridView1.CurrentRow.Cells[0].Value = QChanging.textBox1.Text;
            int ind = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            Global.Question New = new Global.Question();
            New.id = ind.ToString();
            New.Text = QChanging.QuestionWrite.Text;
            Global.QSet.Insert(ind, New);
            dataGridView1.CurrentRow.Cells[1].Value = QChanging.QuestionWrite.Text;
            this.Show();
        }
    }
}
