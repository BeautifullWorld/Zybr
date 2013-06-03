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
    public partial class FileChoosing : Form
    {
        int i = 0;
        public FileChoosing()
        {
            InitializeComponent();
            if(Global.QSetName!=null) textBox1.Text = Global.QSetName; //еси чё-то уже открыто
            if (Global.NumberOfQuestions > 0) //еси есть чё показывать
            {
                QuestionShow.Text = Global.QSet[0].Text; //из нашего крутого списка в текстовую форму
                NQ.Text = "Вопрос №" + Global.QSet[0].id; //в рамочку наверху
                button2.Enabled = true;
                button2.BackColor = Color.FromArgb(255, 255, 192);
                button3.Enabled = true;
                button3.BackColor = Color.FromArgb(255, 255, 192);
                button4.Enabled = true;
                button4.BackColor = Color.FromArgb(255, 255, 192);
            }
            else
            {
                QuestionShow.Text = null;
                NQ.Text = "Вопроcов Нет";
            }
            
        }

        private void FileChoosing_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory(); //начать диалог из директории программы
            if (openFileDialog1.ShowDialog() != DialogResult.OK) return; //открыть диалог открытия файла, еси файл не был открыт выйти из процедуры
            if (openFileDialog1.FileName.Remove(openFileDialog1.FileName.Length - openFileDialog1.SafeFileName.Length - 1) != Directory.GetCurrentDirectory()) //FileName - полный путь, ShowFileName - только имя с раширением ( еси файл не из нашей директории )
            {
                if (File.Exists(openFileDialog1.SafeFileName)) // а в нашей директории файл с таким именем существует
                {
                    File.Move(openFileDialog1.FileName, openFileDialog1.SafeFileName.Remove(openFileDialog1.SafeFileName.Length - 4) + "(2).xml"); //добавим к не нашему файлу (2) и переместим к нам в директорию
                    Global.QSetName = openFileDialog1.SafeFileName.Remove(openFileDialog1.SafeFileName.Length - 4) + "(2)"; 
                }
                else
                {
                    File.Move(openFileDialog1.FileName, openFileDialog1.SafeFileName); //или просто переместим
                    Global.QSetName = openFileDialog1.SafeFileName.Remove(openFileDialog1.SafeFileName.Length - 4);
                }
            }
            else Global.QSetName = openFileDialog1.SafeFileName.Remove(openFileDialog1.SafeFileName.Length - 4); //еси наш - просто его имя запоминаем
            textBox1.Text = Global.QSetName; //обновим 
            Global.ReadXMLDocument(Global.QSetName); //прочтём документ который терь 100% в нашей директории
            i = 0; //обновим еси эо уже не 1 раз открытия файла
            button2.Enabled = true; //терь можно редактить
            button2.BackColor = Color.FromArgb(255, 255, 192);
            if (Global.NumberOfQuestions > 0) //еси есть чё показывать
            {
                QuestionShow.Text = Global.QSet[0].Text; //из нашего крутого списка в текстовую форму
                NQ.Text = "Вопрос №" + Global.QSet[0].id; //в рамочку наверху
                
                button3.Enabled = true;
                button3.BackColor = Color.FromArgb(255, 255, 192);
                button4.Enabled = true;
                button4.BackColor = Color.FromArgb(255, 255, 192);
            }
            else
            {
                button3.Enabled = false;
                button3.BackColor = Color.Gray;
                button4.Enabled = false;
                button4.BackColor = Color.Gray;
                QuestionShow.Text = null;
                NQ.Text = "Вопроcов Нет";
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e) //предыдущий
        {
            if (i > 0) i--;
            QuestionShow.Text = Global.QSet[i].Text;
            NQ.Text = "Вопрос №" + Global.QSet[i].id;
        }

        private void button4_Click(object sender, EventArgs e) //следующий
        {
            if (i < Global.NumberOfQuestions-1) i++;
            QuestionShow.Text = Global.QSet[i].Text;
            NQ.Text = "Вопрос №" + Global.QSet[i].id;
        }

        private void button2_Click(object sender, EventArgs e) //Редактить
        {
            Form2 Base = new Form2();
            this.Hide();
            Base.ShowDialog();
            Base.Close();
            this.Show();
            i = 0;
            if (Global.NumberOfQuestions > 0) //еси есть чё показывать (вдруг мы там поудаляем всё)
            {
                QuestionShow.Text = Global.QSet[0].Text; //из нашего крутого списка в текстовую форму
                NQ.Text = "Вопрос №" + Global.QSet[0].id; //в рамочку наверху
                button3.Enabled = true;
                button3.BackColor = Color.FromArgb(255, 255, 192);
                button4.Enabled = true;
                button4.BackColor = Color.FromArgb(255, 255, 192);
            }
            else
            {
                button3.Enabled = false;
                button3.BackColor = Color.Gray;
                button4.Enabled = false;
                button4.BackColor = Color.Gray;
                QuestionShow.Text = null;
                NQ.Text = "Вопроcов Нет";
            }
        }

        private void NewQSetButton_Click(object sender, EventArgs e) //создать
        {
            string Old = Global.QSetName; //чтобы узнать было ли что-то создано
            CreateNewXml New = new CreateNewXml();
            this.Hide();
            New.ShowDialog();
            New.Close();
            this.Show();

            if (Old != Global.QSetName)
            {
                button2.Enabled = true; //тепреь можно редактить раз мы создали
                button2.BackColor = Color.FromArgb(255, 255, 192);
                i = 0;
                textBox1.Text = Global.QSetName; //обновим 
                Global.ReadXMLDocument(Global.QSetName); //откроем вновь созданный файл
                button3.Enabled = false; // ну он 100 пудов пустой
                button3.BackColor = Color.Gray;
                button4.Enabled = false;
                button4.BackColor = Color.Gray;
                QuestionShow.Text = null;
                NQ.Text = "Вопроcов Нет";
            }
        }

        private void QuestionShow_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
