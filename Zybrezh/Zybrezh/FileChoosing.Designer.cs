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
            this.OpenQSetButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.NewQSetButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.RedactirovatButton = new System.Windows.Forms.Button();
            this.QuestionShow = new System.Windows.Forms.RichTextBox();
            this.PrevQButton = new System.Windows.Forms.Button();
            this.NextQButton = new System.Windows.Forms.Button();
            this.NQ = new System.Windows.Forms.Label();
            this.DeletQSetButton = new System.Windows.Forms.Button();
            this.showRating = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "|*.xml";
            // 
            // OpenQSetButton
            // 
            this.OpenQSetButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OpenQSetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.OpenQSetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenQSetButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OpenQSetButton.Location = new System.Drawing.Point(12, 38);
            this.OpenQSetButton.Name = "OpenQSetButton";
            this.OpenQSetButton.Size = new System.Drawing.Size(63, 32);
            this.OpenQSetButton.TabIndex = 0;
            this.OpenQSetButton.Text = "Открыть";
            this.OpenQSetButton.UseVisualStyleBackColor = false;
            this.OpenQSetButton.Click += new System.EventHandler(this.OpenQSetButton_Click);
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
            // RedactirovatButton
            // 
            this.RedactirovatButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RedactirovatButton.BackColor = System.Drawing.Color.Gray;
            this.RedactirovatButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RedactirovatButton.Enabled = false;
            this.RedactirovatButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RedactirovatButton.Location = new System.Drawing.Point(288, 38);
            this.RedactirovatButton.Name = "RedactirovatButton";
            this.RedactirovatButton.Size = new System.Drawing.Size(95, 32);
            this.RedactirovatButton.TabIndex = 4;
            this.RedactirovatButton.Text = "Редактировать";
            this.RedactirovatButton.UseVisualStyleBackColor = false;
            this.RedactirovatButton.Click += new System.EventHandler(this.RedactirovatButton_Click);
            // 
            // QuestionShow
            // 
            this.QuestionShow.AccessibleDescription = "";
            this.QuestionShow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.QuestionShow.Location = new System.Drawing.Point(12, 93);
            this.QuestionShow.Name = "QuestionShow";
            this.QuestionShow.ReadOnly = true;
            this.QuestionShow.Size = new System.Drawing.Size(371, 170);
            this.QuestionShow.TabIndex = 5;
            this.QuestionShow.Text = "";
            this.QuestionShow.TextChanged += new System.EventHandler(this.QuestionShow_TextChanged);
            // 
            // PrevQButton
            // 
            this.PrevQButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PrevQButton.BackColor = System.Drawing.Color.Gray;
            this.PrevQButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PrevQButton.Enabled = false;
            this.PrevQButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PrevQButton.Location = new System.Drawing.Point(208, 269);
            this.PrevQButton.Name = "PrevQButton";
            this.PrevQButton.Size = new System.Drawing.Size(85, 32);
            this.PrevQButton.TabIndex = 6;
            this.PrevQButton.Text = "Предыдущий";
            this.PrevQButton.UseVisualStyleBackColor = false;
            this.PrevQButton.Click += new System.EventHandler(this.PrevQButton_Click);
            // 
            // NextQButton
            // 
            this.NextQButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NextQButton.BackColor = System.Drawing.Color.Gray;
            this.NextQButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NextQButton.Enabled = false;
            this.NextQButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NextQButton.Location = new System.Drawing.Point(299, 269);
            this.NextQButton.Name = "NextQButton";
            this.NextQButton.Size = new System.Drawing.Size(84, 32);
            this.NextQButton.TabIndex = 7;
            this.NextQButton.Text = "Следующий";
            this.NextQButton.UseVisualStyleBackColor = false;
            this.NextQButton.Click += new System.EventHandler(this.NextQButton_Click);
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
            // showRating
            // 
            this.showRating.AccessibleDescription = "";
            this.showRating.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.showRating.AutoSize = true;
            this.showRating.Cursor = System.Windows.Forms.Cursors.Default;
            this.showRating.Location = new System.Drawing.Point(88, 77);
            this.showRating.Name = "showRating";
            this.showRating.Size = new System.Drawing.Size(0, 13);
            this.showRating.TabIndex = 10;
            // 
            // FileChoosing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.books228577dtg3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(395, 313);
            this.Controls.Add(this.showRating);
            this.Controls.Add(this.DeletQSetButton);
            this.Controls.Add(this.NQ);
            this.Controls.Add(this.NextQButton);
            this.Controls.Add(this.PrevQButton);
            this.Controls.Add(this.QuestionShow);
            this.Controls.Add(this.RedactirovatButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.NewQSetButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.OpenQSetButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FileChoosing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "База Вопросов";
            this.Load += new System.EventHandler(this.FileChoosing_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button OpenQSetButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button NewQSetButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button RedactirovatButton;
        private System.Windows.Forms.RichTextBox QuestionShow;
        private System.Windows.Forms.Button PrevQButton;
        private System.Windows.Forms.Button NextQButton;
        private System.Windows.Forms.Label NQ;
        private System.Windows.Forms.Button DeletQSetButton;
        private System.Windows.Forms.Label showRating;


    }
}