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
    public partial class Form1 : Form
    {
        int i=-100;
        int AndNothis= -100; //пред последний показанный вопрос
        int ButNotThis = -100; //последний показанный вопрос

        ///////////////////////////////////////////////////////
        public int ChooseQuestion() // Выбрать следующий вопрос
        {
            Random rand = new Random();            
            int l;
            do
            {
                string s;
                do
                {
                    s = null;
                    int a = rand.Next(9);
                    if (a < 5) s = "A";
                    else if (a == 8) s = "C";
                    else s = "B";
                } while (Global.LastPlaceInQueue(s) == 1); //вдруг в очереди нет вопросов
                l = 0;
                bool Mi = true;
                for (int k = 0; (k < Global.QSet.Count) && (Mi); k++)
                {
                    if ((Global.QSet[k].Queue_name == s) && (Global.QSet[k].Queue_place == 1))
                    {
                        l = k;
                        Mi = false;
                    }
                }
            } while ((l == ButNotThis)||(l==AndNothis)); //2 последних вопроса не показываем.
            if (Global.QSet.Count > 2)
            {
                ButNotThis = AndNothis;
                AndNothis = l;
            }
            return l;
        }


        public Form1()
        {
            InitializeComponent();
            if (Global.QSet.Count > 0) //еси есть чё показывать
            {
                i = ChooseQuestion();
                QuestionShow.Text = Global.QSet[0].Text + "/" + Global.QSet[i].Queue_name + "-" + Global.QSet[i].Queue_place + "-" + Global.QSet[i].ratio + "-" + Global.GetRatio(Global.QSet[i].ratio);
                NQ.Text = "Вопрос №" + Global.QSet[0].id; //в рамочку наверху
            }
            else 
            {
                NotOkButton.Enabled = false;
                NotOkButton.BackColor = Color.Gray;
                OkButton.Enabled = false;
                OkButton.BackColor = Color.Gray;
                MaybeButton.Enabled = false;
                MaybeButton.BackColor = Color.Gray;
                QuestionShow.Text = null;
                NQ.Text = "Вопроcов Нет";
            }
        }

        private void End_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void OkButton_Click(object sender, EventArgs e) //Знаю
        {
            Global.QSet[i].ratio=string.Concat(Global.QSet[i].ratio, "Y");
            if (Global.QSet[i].ratio.Length > 4) Global.QSet[i].ratio = Global.QSet[i].ratio.Remove(0, 1);
            if (Global.QSet[i].Queue_name == "A")
            {
                Global.CorrectErrorInQueue("A", 1);
                Global.QSet[i].Queue_place = Global.LastPlaceInQueue("B");
                Global.QSet[i].Queue_name = "B";
            }
            else
            {
                Global.CorrectErrorInQueue(Global.QSet[i].Queue_name, 1);
                Global.QSet[i].Queue_name = "Debug";
                Global.QSet[i].Queue_place = Global.LastPlaceInQueue("C");
                Global.QSet[i].Queue_name = "C";
            }
            i = ChooseQuestion();
            QuestionShow.Text = Global.QSet[i].Text + "/" + Global.QSet[i].Queue_name + "-" + Global.QSet[i].Queue_place + "-" + Global.QSet[i].ratio + "-" + Global.GetRatio(Global.QSet[i].ratio);
            NQ.Text = "Вопрос №" + Global.QSet[i].id;
        }

        private void NotOkButton_Click(object sender, EventArgs e) //Не Знаю
        {
            Global.QSet[i].ratio = string.Concat(Global.QSet[i].ratio, "N");
            if (Global.QSet[i].ratio.Length > 4) Global.QSet[i].ratio = Global.QSet[i].ratio.Remove(0, 1);
            if (Global.QSet[i].Queue_name == "C")
            {
                Global.CorrectErrorInQueue("C", 1);
                Global.QSet[i].Queue_place = Global.LastPlaceInQueue("B");
                Global.QSet[i].Queue_name = "B";
            }
            else
            {
                Global.CorrectErrorInQueue(Global.QSet[i].Queue_name, 1);
                Global.QSet[i].Queue_name = "Debug";
                Global.QSet[i].Queue_place = Global.LastPlaceInQueue("A");
                Global.QSet[i].Queue_name = "A";
            }
            i = ChooseQuestion();
            QuestionShow.Text = Global.QSet[i].Text + "/" + Global.QSet[i].Queue_name + "-" + Global.QSet[i].Queue_place + "-" + Global.QSet[i].ratio + "-" + Global.GetRatio(Global.QSet[i].ratio);
             NQ.Text = "Вопрос №" + Global.QSet[i].id;
        }

        private void MaybeButton_Click(object sender, EventArgs e) //Так себе знаю
        {
            Global.QSet[i].ratio = string.Concat(Global.QSet[i].ratio, "M");
            if (Global.QSet[i].ratio.Length > 4) Global.QSet[i].ratio = Global.QSet[i].ratio.Remove(0, 1);
            if (Global.QSet[i].Queue_name == "A")
            {
                Global.CorrectErrorInQueue("A", 1);
                Global.QSet[i].Queue_name = "Debug";
                Global.QSet[i].Queue_place = Global.LastPlaceInQueue("A");
                Global.QSet[i].Queue_name = "A";
            }
            else
            {
                Global.CorrectErrorInQueue(Global.QSet[i].Queue_name, 1);
                Global.QSet[i].Queue_name = "Debug";
                Global.QSet[i].Queue_place = Global.LastPlaceInQueue("B");
                Global.QSet[i].Queue_name = "B";
            }
            i = ChooseQuestion();
            QuestionShow.Text = Global.QSet[i].Text + "/" + Global.QSet[i].Queue_name + "-" + Global.QSet[i].Queue_place + "-" + Global.QSet[i].ratio + "-" + Global.GetRatio(Global.QSet[i].ratio);
            NQ.Text = "Вопрос №" + Global.QSet[i].id;
        }
    }
}
