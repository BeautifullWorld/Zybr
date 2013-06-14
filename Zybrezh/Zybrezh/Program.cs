using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO; // добавил
using System.Xml; // добавил
using System.Text;

namespace WindowsFormsApplication1
{
    
    public static class Global //общий для всего проекта класс 
    {
        public class Question
        {
            public string id;
            public string Text;
            public int Queue_place; // место в очереди
            public string Queue_name; // "A" "B" "C"
            public string ratio; // типа "NNMMY"

            public class SortById : IComparer<Global.Question>
            {
                public int Compare(Global.Question x, Global.Question y)
                {
                    int n = Convert.ToInt32(x.id);
                    int m = Convert.ToInt32(y.id);
                    return n.CompareTo(m);
                }
            }
        }

        ///////////////////////////////////// Глобальные переменные

        public static string QSetName = null;
        public static bool AreYouSure = false; //в FileChoosing Юзаю
        public static List<Question> QSet = new List<Question>();

        //////////////////////////////////////////////////////////////////////////////////
        public static string GetRatio(string ratio) //вычислить рейтинг по строке рейтинга
        {
            if (ratio!=null)
            {
                string s = "Error: Can't Calculate Ratio";
                double Y = 0;
                double M = 0;
                double N = 0;
                for (int i = 0; i < ratio.Length; i++)
                {
                    if (ratio[i] == 'Y') Y = Y + 1;
                    if (ratio[i] == 'M') M = M + 1;
                    if (ratio[i] == 'N') N = N + 1;
                }
                if (Y + N + M == 0) return "0%";
                if (ratio.Length == 1)
                {
                    s = (((Y + M / 2) / (2*(Y + M + N))) * 100).ToString();
                }
                else s = (((Y + M / 2) / (Y + M + N)) * 100).ToString();
                if (s.Length > 4) s = s.Remove(4); //с точностью до 10-ых
                return s + "%";
            }
            else return "0%";
        }
        ////////////////////////////////////////////////////////////////////////////////////////
        public static int LastPlaceInQueue(string Queue_name) //место ПОСЛЕ последнего в очереди
        {
            int a=1;
            for (int k = 0; k < Global.QSet.Count; k++)
            {
                if ((Global.QSet[k].Queue_name == Queue_name) && (Global.QSet[k].Queue_place >= a)) a = Global.QSet[k].Queue_place + 1;
            }
            return a;
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public static void CorrectErrorInQueue(string Queue_name,int Queue_place) //дырку закрыть образовавшуюся после ухода 1
        {
            for (int k = 0; k < Global.QSet.Count; k++)
            {
                if ((Global.QSet[k].Queue_name == Queue_name) && (Global.QSet[k].Queue_place > Queue_place)) Global.QSet[k].Queue_place--;
            }
        }
        /////////////////////////////////////////////////
        public static void CreateXMLDocument(string name)
        {
            string filepath = name + ".xml";
            XmlTextWriter xtw = new XmlTextWriter(filepath, Encoding.UTF32);
            xtw.WriteStartDocument();
            xtw.WriteStartElement("QuestionSet");
            xtw.WriteEndDocument();
            xtw.Close();
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public static void WriteToXMLDocument(string name, string id, string Text, int Queue_place,string Queue_name,string ratio)
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
            Q.AppendChild(QText); //сделал объект 2 частью объекта 1

            XmlElement QQueue_place = xd.CreateElement("Queue_place"); //создад еще объект 3
            XmlText tQQueue_place = xd.CreateTextNode(Queue_place.ToString()); //создал текст 
            QQueue_place.AppendChild(tQQueue_place); //сделал текст частью объекта 3
            Q.AppendChild(QQueue_place); //сделал объект 3 частью объекта 1

            XmlElement QQueue_name = xd.CreateElement("Queue_name"); //создал еще объект 4
            XmlText tQQueue_name = xd.CreateTextNode(Queue_name); //создал текст
            QQueue_name.AppendChild(tQQueue_name); //сделал текст частью объекта 4
            Q.AppendChild(QQueue_name); //сделал объект 4 частью объекта 1
            
            XmlElement Qratio = xd.CreateElement("ratio"); //создал еще объект 5
            XmlText tQratio = xd.CreateTextNode(ratio); //создал текст
            Qratio.AppendChild(tQratio); //сделал текст частью объекта 5
            Q.AppendChild(Qratio); //сделал объект 5 частью объекта 1

            xd.DocumentElement.AppendChild(Q); //добавил в документ объект 1 со всем содержимым

            fs.Close();
            xd.Save(filepath);
        }
        ///////////////////////////////////////////////
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
                New.id = list[i].Attributes[0].Value;
                New.Text = list[i].ChildNodes[0].InnerText; 
                New.Queue_place = Convert.ToInt32(list[i].ChildNodes[1].InnerText);
                New.Queue_name = list[i].ChildNodes[2].InnerText;
                New.ratio = list[i].ChildNodes[3].InnerText;     
                Global.QSet.Add(New); //добавляем
            }

            fs.Close();
            xd.Save(filepath);
        }
        /////////////////////////////////////////////////////////////////////////////////
        public static void SaveCurrentChanges(string name)//слить список из память в файл
        {
            if (Global.QSetName != null)
            {
                File.Delete(name + ".xml");
                Global.CreateXMLDocument(name);
                for (int k = 0; k < Global.QSet.Count; k++)
                {
                    Global.WriteToXMLDocument(name, Global.QSet[k].id, Global.QSet[k].Text, Global.QSet[k].Queue_place, Global.QSet[k].Queue_name, Global.QSet[k].ratio);
                }
            }
        }

    } // конец класса Global

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
            Application.Run(new Main());
        }
    }
}
