namespace SQLApp
{
    partial class LoginForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainPanel = new System.Windows.Forms.Panel();
            this.button_sign = new System.Windows.Forms.Button();
            this.PassField = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.LoginField = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Label();
            this.TopLabel = new System.Windows.Forms.Label();
            this.button_tryConnection = new System.Windows.Forms.Button();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(35)))), ((int)(((byte)(19)))));
            this.MainPanel.Controls.Add(this.button_tryConnection);
            this.MainPanel.Controls.Add(this.button_sign);
            this.MainPanel.Controls.Add(this.PassField);
            this.MainPanel.Controls.Add(this.pictureBox2);
            this.MainPanel.Controls.Add(this.LoginField);
            this.MainPanel.Controls.Add(this.pictureBox1);
            this.MainPanel.Controls.Add(this.TopPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(2);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(364, 409);
            this.MainPanel.TabIndex = 0;
            this.MainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseDown);
            this.MainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseMove);
            // 
            // button_sign
            // 
            this.button_sign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(146)))), ((int)(((byte)(152)))));
            this.button_sign.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_sign.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(228)))));
            this.button_sign.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_sign.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(228)))));
            this.button_sign.Location = new System.Drawing.Point(128, 320);
            this.button_sign.Margin = new System.Windows.Forms.Padding(2);
            this.button_sign.Name = "button_sign";
            this.button_sign.Size = new System.Drawing.Size(110, 46);
            this.button_sign.TabIndex = 5;
            this.button_sign.Text = "Войти";
            this.button_sign.UseVisualStyleBackColor = false;
            this.button_sign.Click += new System.EventHandler(this.button_sign_Click);
            // 
            // PassField
            // 
            this.PassField.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassField.Location = new System.Drawing.Point(128, 233);
            this.PassField.Margin = new System.Windows.Forms.Padding(2);
            this.PassField.Name = "PassField";
            this.PassField.Size = new System.Drawing.Size(147, 26);
            this.PassField.TabIndex = 4;
            this.PassField.UseSystemPasswordChar = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SQLApp.Properties.Resources._lock;
            this.pictureBox2.Location = new System.Drawing.Point(40, 206);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 52);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // LoginField
            // 
            this.LoginField.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginField.Location = new System.Drawing.Point(128, 153);
            this.LoginField.Margin = new System.Windows.Forms.Padding(2);
            this.LoginField.Name = "LoginField";
            this.LoginField.Size = new System.Drawing.Size(147, 26);
            this.LoginField.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SQLApp.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(40, 125);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(146)))), ((int)(((byte)(152)))));
            this.TopPanel.Controls.Add(this.CloseButton);
            this.TopPanel.Controls.Add(this.TopLabel);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Margin = new System.Windows.Forms.Padding(2);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(364, 91);
            this.TopPanel.TabIndex = 0;
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(337, 7);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(21, 20);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "X";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseButton.MouseEnter += new System.EventHandler(this.CloseButton_MouseEnter);
            this.CloseButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            // 
            // TopLabel
            // 
            this.TopLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TopLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(228)))));
            this.TopLabel.Location = new System.Drawing.Point(0, 0);
            this.TopLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TopLabel.Name = "TopLabel";
            this.TopLabel.Size = new System.Drawing.Size(364, 91);
            this.TopLabel.TabIndex = 0;
            this.TopLabel.Text = "Авторизация";
            this.TopLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TopLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopLabel_MouseDown);
            this.TopLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopLabel_MouseMove);
            // 
            // button_tryConnection
            // 
            this.button_tryConnection.Location = new System.Drawing.Point(277, 108);
            this.button_tryConnection.Name = "button_tryConnection";
            this.button_tryConnection.Size = new System.Drawing.Size(75, 23);
            this.button_tryConnection.TabIndex = 6;
            this.button_tryConnection.Text = "Соединение";
            this.button_tryConnection.UseVisualStyleBackColor = true;
            this.button_tryConnection.Click += new System.EventHandler(this.button_tryConnection_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 409);
            this.Controls.Add(this.MainPanel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(35)))), ((int)(((byte)(19)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LoginForm";
            this.Text = "Form1";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.TextBox PassField;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox LoginField;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label TopLabel;
        private System.Windows.Forms.Button button_sign;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Button button_tryConnection;
    }
}

