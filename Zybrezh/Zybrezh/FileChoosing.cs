using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FileChoosing : Form
    {
        int i = 0;
        public FileChoosing()
        {
            InitializeComponent();
            if (Global.QSetName != null) //еси чё-то уже открыто
            {
                textBox1.Text = Global.QSetName;
                DeletQSetButton.Enabled = true;
                DeletQSetButton.BackColor = Color.FromArgb(255, 255, 192);
                RedactirovatButton.Enabled = true;
                RedactirovatButton.BackColor = Color.FromArgb(255, 255, 192);
            }
            if (Global.QSet.Count > 0) //еси есть чё показывать
            {
                QuestionShow.Text = Global.QSet[0].Text; //из нашего крутого списка в текстовую форму
                NQ.Text = "Вопрос №" + Global.QSet[0].id; //в рамочку наверху 
                showRating.Text = "Выучен на: " + Global.GetRatio(Global.QSet[0].ratio);
                PrevQButton.Enabled = true;
                PrevQButton.BackColor = Color.FromArgb(255, 255, 192);
                NextQButton.Enabled = true;
                NextQButton.BackColor = Color.FromArgb(255, 255, 192);
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

        private void OpenQSetButton_Click(object sender, EventArgs e) //Открыть
        {
            Global.SaveCurrentChanges(Global.QSetName); //сохраним изменения
            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory(); //начать диалог из директории программы
            if (openFileDialog1.ShowDialog() != DialogResult.OK) return; //открыть диалог открытия файла, еси файл не был открыт выйти из процедуры

            FileStream fu = new FileStream(openFileDialog1.FileName, FileMode.Open); //проверим нужный ли это нам файл
            XmlDocument xu = new XmlDocument();
            bool bugfix = false;
            try
            {
                xu.Load(fu);
            }
            catch
            {
                ErrorForm Ups = new ErrorForm();
                this.Hide();
                Ups.ShowDialog();
                Ups.Close();
                this.Show();

                fu.Close();
                bugfix = true;
            }
            if (bugfix) return;
            if(xu.GetElementsByTagName("QuestionSet").Count == 0) 
            {
                ErrorForm Ups2 = new ErrorForm();
                this.Hide();
                Ups2.ShowDialog();
                Ups2.Close();
                this.Show();

                fu.Close();
                xu.Save(openFileDialog1.FileName);
                return;
            }
            fu.Close();
            xu.Save(openFileDialog1.FileName);
            bugfix=false;

            try
            {
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
            }
            catch //а я хз может чё нить случится
            {
                ErrorForm Ups = new ErrorForm();
                this.Hide();
                Ups.ShowDialog();
                Ups.Close();
                this.Show();

                bugfix = true;
            }
            if (bugfix) return;

            Global.ReadXMLDocument(Global.QSetName); //прочтём документ который терь 100% в нашей директории
            i = 0; //обновим если это уже не 1 раз открытия файла
            DeletQSetButton.Enabled = true;
            DeletQSetButton.BackColor = Color.FromArgb(255, 255, 192);
            RedactirovatButton.Enabled = true; //терь можно редактить
            RedactirovatButton.BackColor = Color.FromArgb(255, 255, 192);
            if (Global.QSet.Count > 0) //еси есть чё показывать
            {
                QuestionShow.Text = Global.QSet[0].Text; //из нашего крутого списка в текстовую форму
                NQ.Text = "Вопрос №" + Global.QSet[0].id; //в рамочку наверху 
                showRating.Text = "Выучен на: " + Global.GetRatio(Global.QSet[0].ratio);
                PrevQButton.Enabled = true;
                PrevQButton.BackColor = Color.FromArgb(255, 255, 192);
                NextQButton.Enabled = true;
                NextQButton.BackColor = Color.FromArgb(255, 255, 192);
            }
            else
            {
                PrevQButton.Enabled = false;
                PrevQButton.BackColor = Color.Gray;
                NextQButton.Enabled = false;
                NextQButton.BackColor = Color.Gray;
                QuestionShow.Text = null;
                NQ.Text = "Вопроcов Нет";
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PrevQButton_Click(object sender, EventArgs e) //предыдущий
        {
            if (i > 0) i--;
            QuestionShow.Text = Global.QSet[i].Text;
            NQ.Text = "Вопрос №" + Global.QSet[i].id;
            showRating.Text = "Выучен на: " + Global.GetRatio(Global.QSet[i].ratio);
        }

        private void NextQButton_Click(object sender, EventArgs e) //следующий
        {
            if (i < Global.QSet.Count-1) i++;
            QuestionShow.Text = Global.QSet[i].Text;
            NQ.Text = "Вопрос №" + Global.QSet[i].id;
            showRating.Text = "Выучен на: " + Global.GetRatio(Global.QSet[i].ratio);
        }

        private void RedactirovatButton_Click(object sender, EventArgs e) //Редактить
        {
            Form2 Base = new Form2();
            this.Hide();
            Base.ShowDialog();
            Base.Close();
            this.Show();
            i = 0;
            if (Global.QSet.Count > 0) //еси есть чё показывать (вдруг мы там поудаляем всё)
            {
                QuestionShow.Text = Global.QSet[0].Text; //из нашего крутого списка в текстовую форму
                NQ.Text = "Вопрос №" + Global.QSet[0].id; //в рамочку наверху
                showRating.Text = "Выучен на: " + Global.GetRatio(Global.QSet[0].ratio);
                PrevQButton.Enabled = true;
                PrevQButton.BackColor = Color.FromArgb(255, 255, 192);
                NextQButton.Enabled = true;
                NextQButton.BackColor = Color.FromArgb(255, 255, 192);
            }
            else
            {
                PrevQButton.Enabled = false;
                PrevQButton.BackColor = Color.Gray;
                NextQButton.Enabled = false;
                NextQButton.BackColor = Color.Gray;
                QuestionShow.Text = null;
                NQ.Text = "Вопроcов Нет";
            }
        }

        private void NewQSetButton_Click(object sender, EventArgs e) //Создать
        {
            Global.SaveCurrentChanges(Global.QSetName); //сохраним изменения
            string Old = Global.QSetName; //чтобы узнать было ли что-то создано
            CreateNewXml New = new CreateNewXml();
            this.Hide();
            New.ShowDialog();
            New.Close();
            this.Show();

            if (Old != Global.QSetName)
            {
                DeletQSetButton.Enabled = true;
                DeletQSetButton.BackColor = Color.FromArgb(255, 255, 192);
                RedactirovatButton.Enabled = true; //тепреь можно редактить раз мы создали
                RedactirovatButton.BackColor = Color.FromArgb(255, 255, 192);
                i = 0;
                textBox1.Text = Global.QSetName; //обновим 
                Global.ReadXMLDocument(Global.QSetName); //откроем вновь созданный файл
                PrevQButton.Enabled = false; // ну он 100 пудов пустой
                PrevQButton.BackColor = Color.Gray;
                NextQButton.Enabled = false;
                NextQButton.BackColor = Color.Gray;
                QuestionShow.Text = null;
                NQ.Text = "Вопроcов Нет";
            }
        }

        private void QuestionShow_TextChanged(object sender, EventArgs e)
        {

        }

        private void DeletQSetButton_Click(object sender, EventArgs e)
        {
            Global.AreYouSure = false;

            AreUSurecs Sureless = new AreUSurecs();
            this.Hide();
            Sureless.ShowDialog();
            Sureless.Close();
            this.Show();

            if (Global.AreYouSure)
            {
                File.Delete(Global.QSetName + ".xml");
                Global.QSetName = null;
                Global.QSet.Clear();
                textBox1.Text = Global.QSetName;
                DeletQSetButton.Enabled = false;
                DeletQSetButton.BackColor = Color.Gray;
                RedactirovatButton.Enabled = false;
                RedactirovatButton.BackColor = Color.Gray;
                PrevQButton.Enabled = false;
                PrevQButton.BackColor = Color.Gray;
                NextQButton.Enabled = false;
                NextQButton.BackColor = Color.Gray;
                QuestionShow.Text = null;
                NQ.Text = "Вопроcов Нет";
            }
            Global.AreYouSure = false;
        }
    }
}
