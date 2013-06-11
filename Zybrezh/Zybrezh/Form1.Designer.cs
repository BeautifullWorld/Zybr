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
            this.OkButton = new System.Windows.Forms.Button();
            this.NotOkButton = new System.Windows.Forms.Button();
            this.End = new System.Windows.Forms.Button();
            this.QuestionShow = new System.Windows.Forms.RichTextBox();
            this.NQ = new System.Windows.Forms.Label();
            this.MaybeButton = new System.Windows.Forms.Button();
            this.showRating = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OkButton
            // 
            this.OkButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OkButton.BackColor = System.Drawing.Color.Lime;
            this.OkButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OkButton.FlatAppearance.BorderSize = 0;
            this.OkButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OkButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OkButton.Location = new System.Drawing.Point(221, 35);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(68, 45);
            this.OkButton.TabIndex = 1;
            this.OkButton.Text = "Да";
            this.OkButton.UseVisualStyleBackColor = false;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // NotOkButton
            // 
            this.NotOkButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NotOkButton.BackColor = System.Drawing.Color.Red;
            this.NotOkButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NotOkButton.FlatAppearance.BorderSize = 0;
            this.NotOkButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NotOkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NotOkButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.NotOkButton.Location = new System.Drawing.Point(16, 35);
            this.NotOkButton.Name = "NotOkButton";
            this.NotOkButton.Size = new System.Drawing.Size(67, 45);
            this.NotOkButton.TabIndex = 2;
            this.NotOkButton.Text = "Нет";
            this.NotOkButton.UseVisualStyleBackColor = false;
            this.NotOkButton.Click += new System.EventHandler(this.NotOkButton_Click);
            // 
            // End
            // 
            this.End.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.End.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.End.Cursor = System.Windows.Forms.Cursors.Hand;
            this.End.FlatAppearance.BorderSize = 0;
            this.End.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.End.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.End.Location = new System.Drawing.Point(119, 265);
            this.End.Name = "End";
            this.End.Size = new System.Drawing.Size(93, 25);
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
            this.QuestionShow.Size = new System.Drawing.Size(298, 110);
            this.QuestionShow.TabIndex = 4;
            this.QuestionShow.Text = "";
            // 
            // NQ
            // 
            this.NQ.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NQ.AutoSize = true;
            this.NQ.Location = new System.Drawing.Point(13, 16);
            this.NQ.Name = "NQ";
            this.NQ.Size = new System.Drawing.Size(44, 13);
            this.NQ.TabIndex = 5;
            this.NQ.Text = "Вопрос";
            // 
            // MaybeButton
            // 
            this.MaybeButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MaybeButton.BackColor = System.Drawing.Color.Gold;
            this.MaybeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MaybeButton.FlatAppearance.BorderSize = 0;
            this.MaybeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MaybeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaybeButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaybeButton.Location = new System.Drawing.Point(114, 35);
            this.MaybeButton.Name = "MaybeButton";
            this.MaybeButton.Size = new System.Drawing.Size(80, 45);
            this.MaybeButton.TabIndex = 6;
            this.MaybeButton.Text = "Почти";
            this.MaybeButton.UseVisualStyleBackColor = false;
            this.MaybeButton.Click += new System.EventHandler(this.MaybeButton_Click);
            // 
            // showRating
            // 
            this.showRating.AutoSize = true;
            this.showRating.Location = new System.Drawing.Point(83, 16);
            this.showRating.Name = "showRating";
            this.showRating.Size = new System.Drawing.Size(0, 13);
            this.showRating.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.NotOkButton);
            this.groupBox1.Controls.Add(this.MaybeButton);
            this.groupBox1.Controls.Add(this.OkButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 163);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 96);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выучили?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.books228577dtg3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(326, 319);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.showRating);
            this.Controls.Add(this.NQ);
            this.Controls.Add(this.QuestionShow);
            this.Controls.Add(this.End);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Зубрим";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button NotOkButton;
        private System.Windows.Forms.Button End;
        private System.Windows.Forms.RichTextBox QuestionShow;
        private System.Windows.Forms.Label NQ;
        private System.Windows.Forms.Button MaybeButton;
        private System.Windows.Forms.Label showRating;
        private System.Windows.Forms.GroupBox groupBox1;

    }
}

