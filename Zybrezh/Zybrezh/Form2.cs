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
            NQ.Text = "Вопрос №" + (Global.QSet.Count);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void Next_Click(object sender, EventArgs e) //Сохранить
        {
            Global.Question New = new Global.Question(); //новый вопрос создался однако
            New.Text = QuestionWrite.Text;
            New.Attribute = 69; //ибо я пошлый
            New.id = Global.QSet.Count.ToString(); //новый же вопрос сюда пихаем потом надо доработать что новый необязон последний ну или я хз чё
            Global.QSet.Add(New); //в список его!
            Global.WriteToXMLDocument(Global.QSetName, New.id, New.Text, New.Attribute); //и в документик
            QuestionWrite.Text = null; //обновим
            NQ.Text = "Вопрос №" + (Global.QSet.Count);
        }

        private void End_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
