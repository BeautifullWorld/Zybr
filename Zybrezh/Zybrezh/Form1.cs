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
        int i=0;
        public Form1()
        {
            InitializeComponent();
            if (Global.QSet.Count > 0) //еси есть чё показывать
            {
                QuestionShow.Text = Global.QSet[0].Text; //из нашего крутого списка в текстовую форму
                NQ.Text = "Вопрос №" + Global.QSet[0].id; //в рамочку наверху
            }
            else 
            {
                NotOk.Enabled = false;
                NotOk.BackColor = Color.Gray;
                Ok.Enabled = false;
                Ok.BackColor = Color.Gray;
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

        private void Ok_Click(object sender, EventArgs e) //Знаю
        {
             if (Global.QSet.Count - 1 <= i) i = 0; //еси добрались до конца вопросов
             else i++; //раньше то 0 было (он изначально показывается)
             QuestionShow.Text = Global.QSet[i].Text;
             NQ.Text = "Вопрос №" + Global.QSet[i].id;
        }

        private void NotOk_Click(object sender, EventArgs e) //Не Знаю  - тоже самое пока Знаешь не знаешь какая разница!
        {
            if (Global.QSet.Count - 1 <= i) i = 0;
             else i++;
             QuestionShow.Text = Global.QSet[i].Text;
             NQ.Text = "Вопрос №" + Global.QSet[i].id;
        }
    }
}
