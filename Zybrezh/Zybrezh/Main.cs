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
        }

        private void Main_Load(object sender, EventArgs e)
        {
            
        }
    }
}
