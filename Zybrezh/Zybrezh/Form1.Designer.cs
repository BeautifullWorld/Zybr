namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.Ok = new System.Windows.Forms.Button();
            this.NotOk = new System.Windows.Forms.Button();
            this.End = new System.Windows.Forms.Button();
            this.QuestionShow = new System.Windows.Forms.RichTextBox();
            this.NQ = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Ok
            // 
            this.Ok.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Ok.BackColor = System.Drawing.Color.Lime;
            this.Ok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Ok.FlatAppearance.BorderSize = 0;
            this.Ok.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ok.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Ok.Location = new System.Drawing.Point(199, 177);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(107, 45);
            this.Ok.TabIndex = 1;
            this.Ok.Text = "Знаю";
            this.Ok.UseVisualStyleBackColor = false;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // NotOk
            // 
            this.NotOk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NotOk.BackColor = System.Drawing.Color.Red;
            this.NotOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NotOk.FlatAppearance.BorderSize = 0;
            this.NotOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NotOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NotOk.ForeColor = System.Drawing.SystemColors.ControlText;
            this.NotOk.Location = new System.Drawing.Point(12, 177);
            this.NotOk.Name = "NotOk";
            this.NotOk.Size = new System.Drawing.Size(107, 45);
            this.NotOk.TabIndex = 2;
            this.NotOk.Text = "Не Знаю";
            this.NotOk.UseVisualStyleBackColor = false;
            this.NotOk.Click += new System.EventHandler(this.NotOk_Click);
            // 
            // End
            // 
            this.End.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.End.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.End.Cursor = System.Windows.Forms.Cursors.Hand;
            this.End.FlatAppearance.BorderSize = 0;
            this.End.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.End.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.End.Location = new System.Drawing.Point(116, 234);
            this.End.Name = "End";
            this.End.Size = new System.Drawing.Size(86, 25);
            this.End.TabIndex = 3;
            this.End.Text = "Закончим";
            this.End.UseVisualStyleBackColor = false;
            this.End.Click += new System.EventHandler(this.End_Click);
            // 
            // QuestionShow
            // 
            this.QuestionShow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.QuestionShow.Location = new System.Drawing.Point(12, 32);
            this.QuestionShow.Name = "QuestionShow";
            this.QuestionShow.ReadOnly = true;
            this.QuestionShow.Size = new System.Drawing.Size(294, 123);
            this.QuestionShow.TabIndex = 4;
            this.QuestionShow.Text = "";
            // 
            // NQ
            // 
            this.NQ.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NQ.AutoSize = true;
            this.NQ.Location = new System.Drawing.Point(12, 16);
            this.NQ.Name = "NQ";
            this.NQ.Size = new System.Drawing.Size(44, 13);
            this.NQ.TabIndex = 5;
            this.NQ.Text = "Вопрос";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.books228577dtg3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(319, 271);
            this.Controls.Add(this.NQ);
            this.Controls.Add(this.QuestionShow);
            this.Controls.Add(this.End);
            this.Controls.Add(this.NotOk);
            this.Controls.Add(this.Ok);
            this.Name = "Form1";
            this.Text = "Зубрим";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.Button NotOk;
        private System.Windows.Forms.Button End;
        private System.Windows.Forms.RichTextBox QuestionShow;
        private System.Windows.Forms.Label NQ;

    }
}

