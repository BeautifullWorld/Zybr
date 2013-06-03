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
<<<<<<< HEAD
            NQ.Text = "Вопрос №" + (Global.QSet.Count+1); //типа следующий же
            if (Global.QSet.Count > 0)
            {
                for(int i=0; i<Global.QSet.Count; i++)
                    listBox1.Items.Add(Global.QSet[i].Text);
            }
=======
            NQ.Text = "Вопрос №" + (Global.QSet.Count);
>>>>>>> 0a616eb2bd351e86c689f33e0c4e4c679e0e4de1
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
<<<<<<< HEAD
            listBox1.Items.Add(New.Text);
=======
>>>>>>> 0a616eb2bd351e86c689f33e0c4e4c679e0e4de1
            Global.QSet.Add(New); //в список его!
            QuestionWrite.Text = null; //обновим
<<<<<<< HEAD
            NQ.Text = "Вопрос №" + (Global.QSet.Count + 1);
=======
            NQ.Text = "Вопрос №" + (Global.QSet.Count);
>>>>>>> 0a616eb2bd351e86c689f33e0c4e4c679e0e4de1
        }

        private void End_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > 0)
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
            NQ.Text = "Вопрос №" + (Global.QSet.Count + 1);
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
