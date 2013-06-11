namespace WindowsFormsApplication1
{
    partial class CreateNewXml
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
            this.QSetNameWrite = new System.Windows.Forms.TextBox();
            this.NotOkButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.TopLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // QSetNameWrite
            // 
            this.QSetNameWrite.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.QSetNameWrite.BackColor = System.Drawing.Color.White;
            this.QSetNameWrite.Location = new System.Drawing.Point(12, 25);
            this.QSetNameWrite.Name = "QSetNameWrite";
            this.QSetNameWrite.Size = new System.Drawing.Size(229, 20);
            this.QSetNameWrite.TabIndex = 2;
            // 
            // NotOkButton
            // 
            this.NotOkButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NotOkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NotOkButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NotOkButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NotOkButton.Location = new System.Drawing.Point(143, 68);
            this.NotOkButton.Name = "NotOkButton";
            this.NotOkButton.Size = new System.Drawing.Size(98, 32);
            this.NotOkButton.TabIndex = 3;
            this.NotOkButton.Text = "Отмена";
            this.NotOkButton.UseVisualStyleBackColor = false;
            this.NotOkButton.Click += new System.EventHandler(this.NotOkButton_Click);
            // 
            // OkButton
            // 
            this.OkButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.OkButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OkButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OkButton.Location = new System.Drawing.Point(12, 68);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(98, 32);
            this.OkButton.TabIndex = 4;
            this.OkButton.Text = "Ок";
            this.OkButton.UseVisualStyleBackColor = false;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // TopLabel
            // 
            this.TopLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TopLabel.AutoSize = true;
            this.TopLabel.Location = new System.Drawing.Point(12, 9);
            this.TopLabel.Name = "TopLabel";
            this.TopLabel.Size = new System.Drawing.Size(185, 13);
            this.TopLabel.TabIndex = 9;
            this.TopLabel.Text = "Введите имя новой базы вопросов";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 10;
            // 
            // CreateNewXml
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 112);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TopLabel);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.NotOkButton);
            this.Controls.Add(this.QSetNameWrite);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "CreateNewXml";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateNewXml";
            this.Load += new System.EventHandler(this.CreateNewXml_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox QSetNameWrite;
        private System.Windows.Forms.Button NotOkButton;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Label TopLabel;
        private System.Windows.Forms.Label label1;
    }
}