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
        public void FillDataGridView(List<Global.Question> Q) //заполняет таблицу-список
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < Q.Count; i++)
            {
                int n = Convert.ToInt32(Q[i].id) + 1;
                dataGridView1.Rows.Add( n.ToString(), Q[i].Text);
            }
        }

        public int MaxIndex(List<Global.Question> Q)
        {
            int max = 0, num;
            if (Q.Count > 0)
            {
                max = Convert.ToInt32(Q[0].id);
                for (int i = 1; i < Q.Count; i++)
                {
                    num = Convert.ToInt32(Q[i].id);
                    if (max < num)
                        max = num;
                }
            }
            else max--;
            return max+1;
        }

        public Form2()
        {
            InitializeComponent();
            textBox1.Text = (MaxIndex(Global.QSet)+1) + ""; //типа следующий же
            if (Global.QSet.Count > 0)
            {
                FillDataGridView(Global.QSet);
                Delete.BackColor = Color.FromArgb(255, 255, 192);
                Delete.Enabled = true;
                Change.BackColor = Color.FromArgb(255, 255, 192);
                Change.Enabled = true;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void Next_Click(object sender, EventArgs e) //Добавить
        {
            Global.Question New = new Global.Question(); //новый вопрос создался однако
            New.Text = QuestionWrite.Text;
            New.Attribute = 69; //ибо я пошлый
            New.id = (Convert.ToInt32(textBox1.Text)-1).ToString();//вот такие конструкции приходится строить из-за того, что id - это string
            int n = Convert.ToInt32(New.id);
            dataGridView1.Rows.Add( (n+1).ToString(), New.Text);
            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
            try         //тут индекс постоянно за пределы выходил
            {
                Global.QSet.Insert(n, New); //в список его!
            }
            catch
            {
                ErrorForm Ups = new ErrorForm(this);
                Ups.ShowDialog();
                Ups.Close();
                string que = New.Text;
                dataGridView1.Rows.RemoveAt(dataGridView1.Rows.GetLastRow(DataGridViewElementStates.Displayed));
                this.Show();
            }
            QuestionWrite.Text = null; //обновим
            textBox1.Text = (MaxIndex(Global.QSet) + 1) + "";
        }

        private void End_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dataGridView1.SelectedRows)
            {
                int ind = r.Index;
                dataGridView1.Rows.RemoveAt(ind);
                Global.QSet.RemoveAt(ind);
            }
            textBox1.Text = (MaxIndex(Global.QSet) + 1) + "";
        }

        public void Change_Click(object sender, EventArgs e)//изменить
        {
            QChanging QChanging = new QChanging(this);
            this.Hide();
            int index = dataGridView1.CurrentRow.Index;
            QChanging.ShowDialog();
            QChanging.Close();
            Global.Question New = new Global.Question();
            try    //аналогично
            {
                int ind = Convert.ToInt32(QChanging.textBox1.Text);
                New.id = (ind-1).ToString();
                New.Text = QChanging.QuestionWrite.Text;
                dataGridView1.Rows.RemoveAt(index);
                Global.QSet.RemoveAt(index);
                dataGridView1.Rows.Add(ind.ToString(), New.Text);
                Global.QSet.Insert(ind - 1, New);
            }
            catch
            {
                ErrorForm Ups = new ErrorForm(this);
                Ups.ShowDialog();
                Ups.Close();
                string que = New.Text;
                Change_Click(que, EventArgs.Empty);
            }
            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
            textBox1.Text = (MaxIndex(Global.QSet) + 1) + "";
            this.Show();
        }
    }
}
