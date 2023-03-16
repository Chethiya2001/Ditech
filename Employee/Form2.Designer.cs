namespace Employee
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonlLogin = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonCENCEL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(21, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "USER NAME :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(21, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "PASSWORD :";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.Location = new System.Drawing.Point(218, 179);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(429, 34);
            this.textBoxUsername.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(218, 281);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(429, 34);
            this.textBoxPassword.TabIndex = 3;
            // 
            // buttonlLogin
            // 
            this.buttonlLogin.BackColor = System.Drawing.SystemColors.Control;
            this.buttonlLogin.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonlLogin.Font = new System.Drawing.Font("Century Schoolbook", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonlLogin.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonlLogin.Location = new System.Drawing.Point(454, 390);
            this.buttonlLogin.Name = "buttonlLogin";
            this.buttonlLogin.Size = new System.Drawing.Size(193, 47);
            this.buttonlLogin.TabIndex = 4;
            this.buttonlLogin.Text = "LOGIN";
            this.buttonlLogin.UseVisualStyleBackColor = false;
            this.buttonlLogin.Click += new System.EventHandler(this.buttonlLogin_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(219, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(377, 44);
            this.label4.TabIndex = 6;
            this.label4.Text = "KANDY SPORT CLUB";
            // 
            // buttonCENCEL
            // 
            this.buttonCENCEL.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCENCEL.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCENCEL.Font = new System.Drawing.Font("Century Schoolbook", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCENCEL.ForeColor = System.Drawing.Color.Red;
            this.buttonCENCEL.Location = new System.Drawing.Point(218, 390);
            this.buttonCENCEL.Name = "buttonCENCEL";
            this.buttonCENCEL.Size = new System.Drawing.Size(193, 47);
            this.buttonCENCEL.TabIndex = 7;
            this.buttonCENCEL.Text = "CENCEL";
            this.buttonCENCEL.UseVisualStyleBackColor = false;
            this.buttonCENCEL.Click += new System.EventHandler(this.buttonCENCEL_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CancelButton = this.buttonlLogin;
            this.ClientSize = new System.Drawing.Size(778, 635);
            this.Controls.Add(this.buttonCENCEL);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonlLogin);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form2";
            this.Text = "Kandy sport Club";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonlLogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonCENCEL;
    }
}