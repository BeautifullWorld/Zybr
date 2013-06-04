namespace WindowsFormsApplication1
{
    partial class Form2
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
            this.QuestionWrite = new System.Windows.Forms.RichTextBox();
            this.End = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.NQ = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Delete = new System.Windows.Forms.Button();
            this.Change = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // QuestionWrite
            // 
            this.QuestionWrite.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.QuestionWrite.Location = new System.Drawing.Point(16, 25);
            this.QuestionWrite.Name = "QuestionWrite";
            this.QuestionWrite.Size = new System.Drawing.Size(431, 180);
            this.QuestionWrite.TabIndex = 0;
            this.QuestionWrite.Text = "";
            // 
            // End
            // 
            this.End.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.End.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.End.Cursor = System.Windows.Forms.Cursors.Hand;
            this.End.FlatAppearance.BorderSize = 0;
            this.End.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.End.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.End.Location = new System.Drawing.Point(16, 340);
            this.End.Name = "End";
            this.End.Size = new System.Drawing.Size(86, 25);
            this.End.TabIndex = 4;
            this.End.Text = "Закончим";
            this.End.UseVisualStyleBackColor = false;
            this.End.Click += new System.EventHandler(this.End_Click);
            // 
            // Next
            // 
            this.Next.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Next.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Next.Location = new System.Drawing.Point(204, 76);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(116, 30);
            this.Next.TabIndex = 5;
            this.Next.Text = "Добавить";
            this.Next.UseVisualStyleBackColor = false;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // NQ
            // 
            this.NQ.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NQ.AutoSize = true;
            this.NQ.Location = new System.Drawing.Point(13, 9);
            this.NQ.Name = "NQ";
            this.NQ.Size = new System.Drawing.Size(44, 13);
            this.NQ.TabIndex = 6;
            this.NQ.Text = "Вопрос";
            // 
            // listBox1
            // 
            this.listBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(16, 112);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(304, 212);
            this.listBox1.TabIndex = 7;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Delete
            // 
            this.Delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Delete.BackColor = System.Drawing.Color.Gray;
            this.Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Delete.Enabled = false;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delete.Location = new System.Drawing.Point(234, 340);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(86, 25);
            this.Delete.TabIndex = 8;
            this.Delete.Text = "Удалить";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Change
            // 
            this.Change.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Change.BackColor = System.Drawing.Color.Gray;
            this.Change.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Change.Enabled = false;
            this.Change.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Change.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Change.Location = new System.Drawing.Point(142, 340);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(86, 25);
            this.Change.TabIndex = 9;
            this.Change.Text = "Изменить";
            this.Change.UseVisualStyleBackColor = false;
            this.Change.Click += new System.EventHandler(this.Change_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.books228577dtg3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(332, 377);
            this.Controls.Add(this.Change);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.NQ);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.End);
            this.Controls.Add(this.QuestionWrite);
            this.Name = "Form2";
            this.Text = "Что будем Зубрить?";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox QuestionWrite;
        private System.Windows.Forms.Button End;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Label NQ;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Change;
        public System.Windows.Forms.ListBox listBox1;

    }
}