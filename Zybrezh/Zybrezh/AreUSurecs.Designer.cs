namespace WindowsFormsApplication1
{
    partial class AreUSurecs
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
            this.TopLabel = new System.Windows.Forms.Label();
            this.SureLabel = new System.Windows.Forms.Label();
            this.QSetNameShow = new System.Windows.Forms.TextBox();
            this.NotOkButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TopLabel
            // 
            this.TopLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TopLabel.AutoSize = true;
            this.TopLabel.ForeColor = System.Drawing.Color.Red;
            this.TopLabel.Location = new System.Drawing.Point(35, 2);
            this.TopLabel.Name = "TopLabel";
            this.TopLabel.Size = new System.Drawing.Size(216, 13);
            this.TopLabel.TabIndex = 0;
            this.TopLabel.Text = "Вы Собираетесть удалить базу вопросов";
            // 
            // SureLabel
            // 
            this.SureLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SureLabel.AutoSize = true;
            this.SureLabel.ForeColor = System.Drawing.Color.Red;
            this.SureLabel.Location = new System.Drawing.Point(101, 41);
            this.SureLabel.Name = "SureLabel";
            this.SureLabel.Size = new System.Drawing.Size(77, 13);
            this.SureLabel.TabIndex = 2;
            this.SureLabel.Text = "Вы Уверены?";
            // 
            // QSetNameShow
            // 
            this.QSetNameShow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.QSetNameShow.BackColor = System.Drawing.SystemColors.Control;
            this.QSetNameShow.Location = new System.Drawing.Point(12, 18);
            this.QSetNameShow.Name = "QSetNameShow";
            this.QSetNameShow.ReadOnly = true;
            this.QSetNameShow.Size = new System.Drawing.Size(260, 20);
            this.QSetNameShow.TabIndex = 3;
            // 
            // NotOkButton
            // 
            this.NotOkButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NotOkButton.BackColor = System.Drawing.Color.Red;
            this.NotOkButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NotOkButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NotOkButton.Location = new System.Drawing.Point(12, 78);
            this.NotOkButton.Name = "NotOkButton";
            this.NotOkButton.Size = new System.Drawing.Size(108, 32);
            this.NotOkButton.TabIndex = 8;
            this.NotOkButton.Text = "Нет, Что я творю?";
            this.NotOkButton.UseVisualStyleBackColor = false;
            this.NotOkButton.Click += new System.EventHandler(this.NotOkButton_Click);
            // 
            // OkButton
            // 
            this.OkButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OkButton.BackColor = System.Drawing.Color.Lime;
            this.OkButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OkButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OkButton.Location = new System.Drawing.Point(164, 78);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(108, 32);
            this.OkButton.TabIndex = 9;
            this.OkButton.Text = "Да, я уверен";
            this.OkButton.UseVisualStyleBackColor = false;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // AreUSurecs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(284, 132);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.NotOkButton);
            this.Controls.Add(this.QSetNameShow);
            this.Controls.Add(this.SureLabel);
            this.Controls.Add(this.TopLabel);
            this.Name = "AreUSurecs";
            this.Text = "Вы Уверены?";
            this.Load += new System.EventHandler(this.AreUSurecs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TopLabel;
        private System.Windows.Forms.Label SureLabel;
        private System.Windows.Forms.TextBox QSetNameShow;
        private System.Windows.Forms.Button NotOkButton;
        private System.Windows.Forms.Button OkButton;
    }
}