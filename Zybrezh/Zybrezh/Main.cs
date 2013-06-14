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
    public partial class Main : Form
    {
        
        public Main() //что происходит када форма появлется
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e) //начали опрос
        {  
            Form1 Quiz = new Form1(); //создадим новую форму типа Form 1
            this.Hide(); //спрячем Main
            Quiz.ShowDialog(); //тут выполняется код Form 1 до её закрытия (Form1.cs)
            Quiz.Close(); //из-за ShowDialog форма не закрывается а лишь сворачивается. Закроем её нах.
            this.Show(); //покажем Main
        }

        private void BaseButton_Click(object sender, EventArgs e) //пошли в формы с файлами
        {
            FileChoosing FChoosing = new FileChoosing();
            this.Hide();
            FChoosing.ShowDialog();
            FChoosing.Close();
            this.Show();
            if (Global.QSetName == null)
            {
                button1.Enabled = false;
                button1.BackColor = Color.Gray;
            }
            else
            {
                button1.Enabled = true;
                button1.BackColor = Color.FromArgb(255, 255, 192);
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Global.SaveCurrentChanges(Global.QSetName); //сохраним изменения
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AreUSure Sure = new AreUSure();
            this.Hide();
            Sure.ShowDialog();
            Sure.Close();
            this.Show();
        }

        private void Main_Shown(object sender, EventArgs e)
        {

        }
    }
}
