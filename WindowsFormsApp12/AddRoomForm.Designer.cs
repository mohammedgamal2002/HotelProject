namespace WindowsFormsApp12
{
    partial class AddRoomForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.successLabel = new System.Windows.Forms.Label();
            this.descriptionError = new System.Windows.Forms.Label();
            this.saveButton = new FontAwesome.Sharp.IconButton();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new FontAwesome.Sharp.IconButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.imageIcon = new FontAwesome.Sharp.IconPictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.linkIcon = new FontAwesome.Sharp.IconPictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.priceError = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.priceIcon = new FontAwesome.Sharp.IconPictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nameError = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameIcon = new FontAwesome.Sharp.IconPictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageIcon)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.linkIcon)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceIcon)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nameIcon)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(59, 50);
            this.panel1.Margin = new System.Windows.Forms.Padding(50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 450);
            this.panel1.TabIndex = 1;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.successLabel);
            this.panel9.Controls.Add(this.descriptionError);
            this.panel9.Controls.Add(this.saveButton);
            this.panel9.Controls.Add(this.descriptionTextBox);
            this.panel9.Controls.Add(this.addButton);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(0, 283);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(401, 167);
            this.panel9.TabIndex = 8;
            // 
            // successLabel
            // 
            this.successLabel.AutoSize = true;
            this.successLabel.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.successLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(232)))), ((int)(((byte)(58)))));
            this.successLabel.Location = new System.Drawing.Point(162, 139);
            this.successLabel.Name = "successLabel";
            this.successLabel.Size = new System.Drawing.Size(47, 15);
            this.successLabel.TabIndex = 1;
            this.successLabel.Text = "Added";
            this.successLabel.Visible = false;
            // 
            // descriptionError
            // 
            this.descriptionError.AutoSize = true;
            this.descriptionError.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionError.ForeColor = System.Drawing.Color.Red;
            this.descriptionError.Location = new System.Drawing.Point(335, 4);
            this.descriptionError.Name = "descriptionError";
            this.descriptionError.Size = new System.Drawing.Size(25, 31);
            this.descriptionError.TabIndex = 6;
            this.descriptionError.Text = "*";
            this.descriptionError.Visible = false;
            // 
            // saveButton
            // 
            this.saveButton.AutoSize = true;
            this.saveButton.BackColor = System.Drawing.Color.Transparent;
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(173)))), ((int)(((byte)(63)))));
            this.saveButton.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.saveButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(164)))), ((int)(((byte)(255)))));
            this.saveButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.saveButton.IconSize = 39;
            this.saveButton.Location = new System.Drawing.Point(195, 87);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(49, 49);
            this.saveButton.TabIndex = 5;
            this.saveButton.UseVisualStyleBackColor = false;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.BackColor = System.Drawing.Color.White;
            this.descriptionTextBox.Location = new System.Drawing.Point(107, 16);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(226, 51);
            this.descriptionTextBox.TabIndex = 1;
            // 
            // addButton
            // 
            this.addButton.AutoSize = true;
            this.addButton.BackColor = System.Drawing.Color.Transparent;
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(173)))), ((int)(((byte)(63)))));
            this.addButton.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.addButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(164)))), ((int)(((byte)(255)))));
            this.addButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addButton.IconSize = 39;
            this.addButton.Location = new System.Drawing.Point(124, 87);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(49, 49);
            this.addButton.TabIndex = 3;
            this.addButton.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.comboBox3);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.imageIcon);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 227);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(401, 56);
            this.panel5.TabIndex = 7;
            // 
            // imageIcon
            // 
            this.imageIcon.BackColor = System.Drawing.Color.Transparent;
            this.imageIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(164)))), ((int)(((byte)(255)))));
            this.imageIcon.IconChar = FontAwesome.Sharp.IconChar.Images;
            this.imageIcon.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(164)))), ((int)(((byte)(255)))));
            this.imageIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.imageIcon.Location = new System.Drawing.Point(25, 11);
            this.imageIcon.Name = "imageIcon";
            this.imageIcon.Size = new System.Drawing.Size(32, 32);
            this.imageIcon.TabIndex = 0;
            this.imageIcon.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.comboBox1);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.linkIcon);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 171);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(401, 56);
            this.panel4.TabIndex = 6;
            // 
            // linkIcon
            // 
            this.linkIcon.BackColor = System.Drawing.Color.Transparent;
            this.linkIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(200)))), ((int)(((byte)(139)))));
            this.linkIcon.IconChar = FontAwesome.Sharp.IconChar.Link;
            this.linkIcon.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(200)))), ((int)(((byte)(139)))));
            this.linkIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.linkIcon.Location = new System.Drawing.Point(25, 11);
            this.linkIcon.Name = "linkIcon";
            this.linkIcon.Size = new System.Drawing.Size(32, 32);
            this.linkIcon.TabIndex = 0;
            this.linkIcon.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.priceError);
            this.panel3.Controls.Add(this.priceTextBox);
            this.panel3.Controls.Add(this.priceIcon);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 115);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(401, 56);
            this.panel3.TabIndex = 5;
            // 
            // priceError
            // 
            this.priceError.AutoSize = true;
            this.priceError.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceError.ForeColor = System.Drawing.Color.Red;
            this.priceError.Location = new System.Drawing.Point(335, 7);
            this.priceError.Name = "priceError";
            this.priceError.Size = new System.Drawing.Size(25, 31);
            this.priceError.TabIndex = 3;
            this.priceError.Text = "*";
            this.priceError.Visible = false;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(170, 16);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(163, 20);
            this.priceTextBox.TabIndex = 1;
            // 
            // priceIcon
            // 
            this.priceIcon.BackColor = System.Drawing.Color.Transparent;
            this.priceIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(164)))), ((int)(((byte)(255)))));
            this.priceIcon.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            this.priceIcon.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(164)))), ((int)(((byte)(255)))));
            this.priceIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.priceIcon.Location = new System.Drawing.Point(25, 11);
            this.priceIcon.Name = "priceIcon";
            this.priceIcon.Size = new System.Drawing.Size(32, 32);
            this.priceIcon.TabIndex = 0;
            this.priceIcon.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.nameError);
            this.panel2.Controls.Add(this.nameTextBox);
            this.panel2.Controls.Add(this.nameIcon);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(401, 56);
            this.panel2.TabIndex = 4;
            // 
            // nameError
            // 
            this.nameError.AutoSize = true;
            this.nameError.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameError.ForeColor = System.Drawing.Color.Red;
            this.nameError.Location = new System.Drawing.Point(335, 7);
            this.nameError.Name = "nameError";
            this.nameError.Size = new System.Drawing.Size(25, 31);
            this.nameError.TabIndex = 2;
            this.nameError.Text = "*";
            this.nameError.Visible = false;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(170, 16);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(163, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // nameIcon
            // 
            this.nameIcon.BackColor = System.Drawing.Color.Transparent;
            this.nameIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(164)))), ((int)(((byte)(255)))));
            this.nameIcon.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.nameIcon.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(164)))), ((int)(((byte)(255)))));
            this.nameIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.nameIcon.Location = new System.Drawing.Point(25, 11);
            this.nameIcon.Name = "nameIcon";
            this.nameIcon.Size = new System.Drawing.Size(32, 32);
            this.nameIcon.TabIndex = 0;
            this.nameIcon.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(60, 5, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(401, 59);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Phone Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "....";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Available Rooms";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(170, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(163, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.comboBox2);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.iconPictureBox1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(401, 56);
            this.panel6.TabIndex = 7;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(170, 19);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(163, 21);
            this.comboBox2.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Room Type";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(164)))), ((int)(((byte)(255)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Link;
            this.iconPictureBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(164)))), ((int)(((byte)(255)))));
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.Location = new System.Drawing.Point(25, 11);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(170, 14);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(163, 21);
            this.comboBox3.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(335, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 31);
            this.label6.TabIndex = 5;
            this.label6.Text = "*";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(335, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 31);
            this.label7.TabIndex = 7;
            this.label7.Text = "*";
            this.label7.Visible = false;
            // 
            // AddRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 573);
            this.Controls.Add(this.panel1);
            this.Name = "AddRoomForm";
            this.Text = "AddRoomForm";
            this.panel1.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageIcon)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.linkIcon)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceIcon)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nameIcon)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label successLabel;
        private System.Windows.Forms.Label descriptionError;
        private FontAwesome.Sharp.IconButton saveButton;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private FontAwesome.Sharp.IconButton addButton;
        private System.Windows.Forms.Panel panel5;
        private FontAwesome.Sharp.IconPictureBox imageIcon;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconPictureBox linkIcon;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label priceError;
        private System.Windows.Forms.TextBox priceTextBox;
        private FontAwesome.Sharp.IconPictureBox priceIcon;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label nameError;
        private System.Windows.Forms.TextBox nameTextBox;
        private FontAwesome.Sharp.IconPictureBox nameIcon;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}