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
            this.SuspendLayout();
            // 
            // QuestionWrite
            // 
            this.QuestionWrite.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.QuestionWrite.Location = new System.Drawing.Point(12, 28);
            this.QuestionWrite.Name = "QuestionWrite";
            this.QuestionWrite.Size = new System.Drawing.Size(265, 141);
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
            this.End.Location = new System.Drawing.Point(12, 225);
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
            this.Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Next.Location = new System.Drawing.Point(127, 186);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(148, 63);
            this.Next.TabIndex = 5;
            this.Next.Text = "Сохранить";
            this.Next.UseVisualStyleBackColor = false;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // NQ
            // 
            this.NQ.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NQ.AutoSize = true;
            this.NQ.Location = new System.Drawing.Point(12, 12);
            this.NQ.Name = "NQ";
            this.NQ.Size = new System.Drawing.Size(44, 13);
            this.NQ.TabIndex = 6;
            this.NQ.Text = "Вопрос";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.books228577dtg3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(284, 262);
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

    }
}