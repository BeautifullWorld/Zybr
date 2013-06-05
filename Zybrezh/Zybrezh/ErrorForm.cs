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
    public partial class ErrorForm : Form
    {
        public ErrorForm()
        {
            InitializeComponent();
            textBox1.Text = "Этот файл не подходит или повреждён";
        }

        public ErrorForm(Form2 f2)//думаю перегрузка лучше, чем новая форма
        {
            InitializeComponent();
            textBox1.Text = "Неверное значение индекса";
        }
            
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
