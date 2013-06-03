namespace WindowsFormsApplication1
{
    partial class FileChoosing
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.NewQSetButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.QuestionShow = new System.Windows.Forms.RichTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.NQ = new System.Windows.Forms.Label();
            this.DeletQSetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "|*.xml";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(12, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Открыть";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(371, 20);
            this.textBox1.TabIndex = 1;
            // 
            // NewQSetButton
            // 
            this.NewQSetButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NewQSetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NewQSetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewQSetButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NewQSetButton.Location = new System.Drawing.Point(81, 38);
            this.NewQSetButton.Name = "NewQSetButton";
            this.NewQSetButton.Size = new System.Drawing.Size(63, 32);
            this.NewQSetButton.TabIndex = 2;
            this.NewQSetButton.Text = "Создать";
            this.NewQSetButton.UseVisualStyleBackColor = false;
            this.NewQSetButton.Click += new System.EventHandler(this.NewQSetButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BackButton.Location = new System.Drawing.Point(12, 269);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(63, 32);
            this.BackButton.TabIndex = 3;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Enabled = false;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(288, 38);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 32);
            this.button2.TabIndex = 4;
            this.button2.Text = "Редактировать";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // QuestionShow
            // 
            this.QuestionShow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.QuestionShow.Location = new System.Drawing.Point(12, 93);
            this.QuestionShow.Name = "QuestionShow";
            this.QuestionShow.ReadOnly = true;
            this.QuestionShow.Size = new System.Drawing.Size(371, 170);
            this.QuestionShow.TabIndex = 5;
            this.QuestionShow.Text = "";
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.BackColor = System.Drawing.Color.Gray;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Enabled = false;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(208, 269);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 32);
            this.button3.TabIndex = 6;
            this.button3.Text = "Предыдущий";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4.BackColor = System.Drawing.Color.Gray;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Enabled = false;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(299, 269);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(84, 32);
            this.button4.TabIndex = 7;
            this.button4.Text = "Следующий";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // NQ
            // 
            this.NQ.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NQ.AutoSize = true;
            this.NQ.Location = new System.Drawing.Point(12, 77);
            this.NQ.Name = "NQ";
            this.NQ.Size = new System.Drawing.Size(44, 13);
            this.NQ.TabIndex = 8;
            this.NQ.Text = "Вопрос";
            // 
            // DeletQSetButton
            // 
            this.DeletQSetButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DeletQSetButton.BackColor = System.Drawing.Color.Gray;
            this.DeletQSetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeletQSetButton.Enabled = false;
            this.DeletQSetButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeletQSetButton.Location = new System.Drawing.Point(187, 38);
            this.DeletQSetButton.Name = "DeletQSetButton";
            this.DeletQSetButton.Size = new System.Drawing.Size(95, 32);
            this.DeletQSetButton.TabIndex = 9;
            this.DeletQSetButton.Text = "Удалить";
            this.DeletQSetButton.UseVisualStyleBackColor = false;
            this.DeletQSetButton.Click += new System.EventHandler(this.DeletQSetButton_Click);
            // 
            // FileChoosing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.books228577dtg3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(395, 313);
            this.Controls.Add(this.DeletQSetButton);
            this.Controls.Add(this.NQ);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.QuestionShow);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.NewQSetButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "FileChoosing";
            this.Text = "База Вопросов";
            this.Load += new System.EventHandler(this.FileChoosing_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button NewQSetButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox QuestionShow;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label NQ;
        private System.Windows.Forms.Button DeletQSetButton;


    }
}