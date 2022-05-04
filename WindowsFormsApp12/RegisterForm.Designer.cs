namespace WindowsFormsApp12
{
    partial class RegisterForm
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
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PhoneIcon = new FontAwesome.Sharp.IconPictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.phoneNumTextBox = new System.Windows.Forms.TextBox();
            this.emailIcon = new FontAwesome.Sharp.IconPictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.passwordIcon = new FontAwesome.Sharp.IconPictureBox();
            this.userIcon = new FontAwesome.Sharp.IconPictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.RegisterButton = new CustomControls.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(171)))), ((int)(((byte)(242)))));
            this.panel6.Location = new System.Drawing.Point(3, 27);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(469, 2);
            this.panel6.TabIndex = 32;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(255)))));
            this.panel5.Location = new System.Drawing.Point(0, -19);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(2, 545);
            this.panel5.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(100, 416);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 18);
            this.label4.TabIndex = 44;
            this.label4.Text = "Phone Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(100, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 18);
            this.label3.TabIndex = 43;
            this.label3.Text = "E-mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(100, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 18);
            this.label2.TabIndex = 42;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(100, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 18);
            this.label1.TabIndex = 41;
            this.label1.Text = "Username";
            // 
            // PhoneIcon
            // 
            this.PhoneIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PhoneIcon.BackColor = System.Drawing.Color.White;
            this.PhoneIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(112)))), ((int)(((byte)(247)))));
            this.PhoneIcon.IconChar = FontAwesome.Sharp.IconChar.Phone;
            this.PhoneIcon.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(112)))), ((int)(((byte)(247)))));
            this.PhoneIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.PhoneIcon.IconSize = 28;
            this.PhoneIcon.Location = new System.Drawing.Point(48, 408);
            this.PhoneIcon.Name = "PhoneIcon";
            this.PhoneIcon.Size = new System.Drawing.Size(35, 28);
            this.PhoneIcon.TabIndex = 40;
            this.PhoneIcon.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(171)))), ((int)(((byte)(242)))));
            this.panel4.Location = new System.Drawing.Point(3, 491);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(469, 2);
            this.panel4.TabIndex = 39;
            // 
            // phoneNumTextBox
            // 
            this.phoneNumTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.phoneNumTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.phoneNumTextBox.Location = new System.Drawing.Point(220, 412);
            this.phoneNumTextBox.Name = "phoneNumTextBox";
            this.phoneNumTextBox.Size = new System.Drawing.Size(174, 22);
            this.phoneNumTextBox.TabIndex = 38;
            // 
            // emailIcon
            // 
            this.emailIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailIcon.BackColor = System.Drawing.Color.White;
            this.emailIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(112)))), ((int)(((byte)(247)))));
            this.emailIcon.IconChar = FontAwesome.Sharp.IconChar.At;
            this.emailIcon.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(112)))), ((int)(((byte)(247)))));
            this.emailIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.emailIcon.IconSize = 28;
            this.emailIcon.Location = new System.Drawing.Point(48, 305);
            this.emailIcon.Name = "emailIcon";
            this.emailIcon.Size = new System.Drawing.Size(35, 28);
            this.emailIcon.TabIndex = 37;
            this.emailIcon.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(171)))), ((int)(((byte)(242)))));
            this.panel3.Location = new System.Drawing.Point(3, 375);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(469, 2);
            this.panel3.TabIndex = 36;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.emailTextBox.Location = new System.Drawing.Point(220, 309);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(174, 22);
            this.emailTextBox.TabIndex = 35;
            // 
            // passwordIcon
            // 
            this.passwordIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordIcon.BackColor = System.Drawing.Color.White;
            this.passwordIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(112)))), ((int)(((byte)(247)))));
            this.passwordIcon.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.passwordIcon.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(112)))), ((int)(((byte)(247)))));
            this.passwordIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.passwordIcon.IconSize = 28;
            this.passwordIcon.Location = new System.Drawing.Point(48, 189);
            this.passwordIcon.Name = "passwordIcon";
            this.passwordIcon.Size = new System.Drawing.Size(35, 28);
            this.passwordIcon.TabIndex = 34;
            this.passwordIcon.TabStop = false;
            // 
            // userIcon
            // 
            this.userIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userIcon.BackColor = System.Drawing.Color.White;
            this.userIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(112)))), ((int)(((byte)(247)))));
            this.userIcon.IconChar = FontAwesome.Sharp.IconChar.User;
            this.userIcon.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(112)))), ((int)(((byte)(247)))));
            this.userIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.userIcon.IconSize = 28;
            this.userIcon.Location = new System.Drawing.Point(48, 75);
            this.userIcon.Name = "userIcon";
            this.userIcon.Size = new System.Drawing.Size(35, 28);
            this.userIcon.TabIndex = 33;
            this.userIcon.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(171)))), ((int)(((byte)(242)))));
            this.panel2.Location = new System.Drawing.Point(3, 259);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(469, 2);
            this.panel2.TabIndex = 31;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(171)))), ((int)(((byte)(242)))));
            this.panel1.Location = new System.Drawing.Point(3, 144);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 2);
            this.panel1.TabIndex = 30;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.passwordTextBox.Location = new System.Drawing.Point(220, 193);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(174, 22);
            this.passwordTextBox.TabIndex = 29;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.usernameTextBox.Location = new System.Drawing.Point(220, 79);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(174, 22);
            this.usernameTextBox.TabIndex = 28;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(255)))));
            this.panel7.Location = new System.Drawing.Point(470, -22);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(2, 545);
            this.panel7.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(517, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 46);
            this.label5.TabIndex = 47;
            this.label5.Text = "By signing up, you agree to our Terms and Data Policy";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bauhaus 93", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.label6.Location = new System.Drawing.Point(507, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(230, 73);
            this.label6.TabIndex = 48;
            this.label6.Text = "Hottell";
            // 
            // RegisterButton
            // 
            this.RegisterButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RegisterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.RegisterButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.RegisterButton.BorderColor = System.Drawing.Color.White;
            this.RegisterButton.BorderRadius = 20;
            this.RegisterButton.BorderSize = 1;
            this.RegisterButton.FlatAppearance.BorderSize = 0;
            this.RegisterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterButton.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterButton.ForeColor = System.Drawing.Color.White;
            this.RegisterButton.Location = new System.Drawing.Point(534, 276);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(150, 40);
            this.RegisterButton.TabIndex = 10;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.TextColor = System.Drawing.Color.White;
            this.RegisterButton.UseVisualStyleBackColor = false;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(755, 506);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PhoneIcon);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.phoneNumTextBox);
            this.Controls.Add(this.emailIcon);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.passwordIcon);
            this.Controls.Add(this.userIcon);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.RegisterButton);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PhoneIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CustomControls.RJControls.RJButton RegisterButton;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox PhoneIcon;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox phoneNumTextBox;
        private FontAwesome.Sharp.IconPictureBox emailIcon;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox emailTextBox;
        private FontAwesome.Sharp.IconPictureBox passwordIcon;
        private FontAwesome.Sharp.IconPictureBox userIcon;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}