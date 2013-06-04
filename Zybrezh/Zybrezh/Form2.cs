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
            if (Global.QSet.Count == 0) NQ.Text = "Вопрос №1";
            else NQ.Text = "Вопрос №" + ((Convert.ToInt32(Global.QSet[Global.QSet.Count - 1].id) + 1).ToString());
            if (Global.QSet.Count > 0)
            {
                for(int i=0; i<Global.QSet.Count; i++)
                    listBox1.Items.Add(Global.QSet[i].id+") "+ Global.QSet[i].Text);
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
            if (Global.QSet.Count == 0) New.id = "1";
            else New.id = (Convert.ToInt32(Global.QSet[Global.QSet.Count - 1].id) + 1).ToString();
            listBox1.Items.Add(New.id+") "+New.Text);
            Global.QSet.Add(New); //в список его!
            QuestionWrite.Text = null; //обновим
            if (Global.QSet.Count == 0) NQ.Text = "Вопрос №1";
            else NQ.Text = "Вопрос №" + ((Convert.ToInt32(Global.QSet[Global.QSet.Count - 1].id) + 1).ToString());
        }

        private void End_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0) //исправлено 
            {
                Delete.Enabled = true;
                Delete.BackColor = Color.FromArgb(255, 255, 192);
                Change.Enabled = true;
                Change.BackColor = Color.FromArgb(255, 255, 192);
            }
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            Global.QSet.RemoveAt(listBox1.SelectedIndex);
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            if (Global.QSet.Count == 0) NQ.Text = "Вопрос №1";
            else NQ.Text = "Вопрос №" + ((Convert.ToInt32(Global.QSet[Global.QSet.Count - 1].id) + 1).ToString());
        }

        public void Change_Click(object sender, EventArgs e)//изменить
        {
            int ind = listBox1.SelectedIndex;
            QChanging QChanging = new QChanging(this);
            this.Hide();
            QChanging.ShowDialog();
            QChanging.Close();
            listBox1.Items[ind] = QChanging.QuestionWrite.Text;//сохраняем
            Global.QSet[ind].Text = QChanging.QuestionWrite.Text;//измененные значения
            this.Show();
        }
    }
}
