namespace WindowsFormsApplication1
{
    partial class QChanging
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.QuestionWrite = new System.Windows.Forms.TextBox();
            this.NQ = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // QuestionWrite
            // 
            this.QuestionWrite.Location = new System.Drawing.Point(12, 32);
            this.QuestionWrite.Multiline = true;
            this.QuestionWrite.Name = "QuestionWrite";
            this.QuestionWrite.Size = new System.Drawing.Size(345, 65);
            this.QuestionWrite.TabIndex = 0;
            // 
            // NQ
            // 
            this.NQ.AutoSize = true;
            this.NQ.Location = new System.Drawing.Point(12, 9);
            this.NQ.Name = "NQ";
            this.NQ.Size = new System.Drawing.Size(58, 13);
            this.NQ.TabIndex = 1;
            this.NQ.Text = "Вопрос №";
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Save.Location = new System.Drawing.Point(269, 103);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(85, 33);
            this.Save.TabIndex = 2;
            this.Save.Text = "Сохранить";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(67, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(37, 20);
            this.textBox1.TabIndex = 3;
            // 
            // QChanging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.books228577dtg3;
            this.ClientSize = new System.Drawing.Size(366, 141);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.NQ);
            this.Controls.Add(this.QuestionWrite);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "QChanging";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменить вопрос";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QChanging_FormClosing);
            this.Load += new System.EventHandler(this.QChanging_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NQ;
        private System.Windows.Forms.Button Save;
        public System.Windows.Forms.TextBox QuestionWrite;
        public System.Windows.Forms.TextBox textBox1;
    }
}