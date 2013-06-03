using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO; // добавил
using System.Xml; // добавил
using System.Text;

namespace WindowsFormsApplication1
{
    
    public static class Global //общий для всего проекта класс Global.бла-бла писать надо.
    {
        public class Question
        {
            public string id; //string ибо так проще
            public string Text;
            public int Attribute; //хз-зачем пока
        }
        public static string QSetName = null;
        public static bool AreYouSure = false;
        public static List<Question> QSet = new List<Question>(); //походу удобный список ибо обращаться можно как к массиву


        public static void CreateXMLDocument(string name)
        {
            string filepath = name + ".xml";
            XmlTextWriter xtw = new XmlTextWriter(filepath, Encoding.UTF32);
            xtw.WriteStartDocument();
            xtw.WriteStartElement("QuestionSet");
            xtw.WriteEndDocument();
            xtw.Close();
        }

        public static void WriteToXMLDocument(string name, string id, string Text, int Attribute)
        {
            string filepath = name + ".xml";
            FileStream fs = new FileStream(filepath, FileMode.Open); //типа открыл файл
            XmlDocument xd = new XmlDocument(); //типа сказал ему что это xml файл
            xd.Load(fs);

            XmlElement Q = xd.CreateElement("Question"); //создал объект 1
            Q.SetAttribute("id", id); //дал ему аттрибут
            XmlElement QText = xd.CreateElement("Text"); //создал еще объект 2
            XmlText tQText = xd.CreateTextNode(Text); //создал текст
            QText.AppendChild(tQText); //сделал текст частью объекта 2
            XmlElement QAttribute = xd.CreateElement("Attribute"); //создад еще объект 3
            XmlText tQAttribute = xd.CreateTextNode(Attribute.ToString()); //создал текст 
            QAttribute.AppendChild(tQAttribute); //сделал текст частью объекта 3
            Q.AppendChild(QText); //сделал объект 2 частью объекта 1
            Q.AppendChild(QAttribute); //сделал объект 3 частью объекта 1
            xd.DocumentElement.AppendChild(Q); //добавил в документ объект 1 со всем содержимым

            fs.Close();
            xd.Save(filepath);

        }
        public static void ReadXMLDocument(string name)
        {
            string filepath = name + ".xml";
            FileStream fs = new FileStream(filepath, FileMode.Open);
            XmlDocument xd = new XmlDocument();
            xd.Load(fs);

            XmlNodeList list = xd.GetElementsByTagName("Question"); //сделал тот крутой список из всех объектов xml документа наз-ся Question [тип 1]
            Global.QSet.Clear(); //старое очистим

            for (int i = 0; i < list.Count; i++) //запонляю свой список вопросами из файла
            {
                Global.Question New = new Global.Question(); //новый вопрос
                New.Text = list[i].ChildNodes[0].InnerText; //ChildNodes - крутой список дочерних объектов
                New.Attribute = Convert.ToInt32(list[i].ChildNodes[1].InnerText);
                New.id = list[i].Attributes[0].Value;
                Global.QSet.Add(New); //добавляем
            }

            fs.Close();
            xd.Save(filepath);
        }

    }
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main()); //запускаем форму Main - далее идём Main.cs
        }
    }
}
