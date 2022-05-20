namespace WindowsFormsApp12
{
    partial class Form1
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
            this.minimizeButton = new FontAwesome.Sharp.IconButton();
            this.maximizeButton = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.childFormPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.usersButton = new FontAwesome.Sharp.IconButton();
            this.roomButton = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.minimizeButton);
            this.panel1.Controls.Add(this.maximizeButton);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1050, 26);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.minimizeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.minimizeButton.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.minimizeButton.IconColor = System.Drawing.Color.White;
            this.minimizeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.minimizeButton.IconSize = 20;
            this.minimizeButton.Location = new System.Drawing.Point(948, 0);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Padding = new System.Windows.Forms.Padding(10);
            this.minimizeButton.Size = new System.Drawing.Size(34, 26);
            this.minimizeButton.TabIndex = 3;
            this.minimizeButton.UseVisualStyleBackColor = false;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // maximizeButton
            // 
            this.maximizeButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.maximizeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.maximizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximizeButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.maximizeButton.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.maximizeButton.IconColor = System.Drawing.Color.White;
            this.maximizeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.maximizeButton.IconSize = 20;
            this.maximizeButton.Location = new System.Drawing.Point(982, 0);
            this.maximizeButton.Name = "maximizeButton";
            this.maximizeButton.Padding = new System.Windows.Forms.Padding(10);
            this.maximizeButton.Size = new System.Drawing.Size(34, 26);
            this.maximizeButton.TabIndex = 2;
            this.maximizeButton.UseVisualStyleBackColor = false;
            this.maximizeButton.Visible = false;
            this.maximizeButton.Click += new System.EventHandler(this.maximizeButton_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 20;
            this.iconButton1.Location = new System.Drawing.Point(1016, 0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(10);
            this.iconButton1.Rotation = 45D;
            this.iconButton1.Size = new System.Drawing.Size(34, 26);
            this.iconButton1.TabIndex = 1;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.childFormPanel);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1050, 613);
            this.panel2.TabIndex = 1;
            // 
            // childFormPanel
            // 
            this.childFormPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.childFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.childFormPanel.Location = new System.Drawing.Point(119, 0);
            this.childFormPanel.Name = "childFormPanel";
            this.childFormPanel.Size = new System.Drawing.Size(931, 613);
            this.childFormPanel.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(119, 613);
            this.panel3.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.usersButton);
            this.panel6.Controls.Add(this.roomButton);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(5, 30, 5, 5);
            this.panel6.Size = new System.Drawing.Size(119, 613);
            this.panel6.TabIndex = 1;
            // 
            // usersButton
            // 
            this.usersButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.usersButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.usersButton.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(144)))), ((int)(((byte)(212)))));
            this.usersButton.IconChar = FontAwesome.Sharp.IconChar.User;
            this.usersButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.usersButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.usersButton.IconSize = 25;
            this.usersButton.Location = new System.Drawing.Point(5, 69);
            this.usersButton.Name = "usersButton";
            this.usersButton.Size = new System.Drawing.Size(109, 39);
            this.usersButton.TabIndex = 1;
            this.usersButton.Text = "Users";
            this.usersButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.usersButton.UseVisualStyleBackColor = false;
            this.usersButton.Visible = false;
            this.usersButton.Click += new System.EventHandler(this.usersButton_Click);
            // 
            // roomButton
            // 
            this.roomButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.roomButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.roomButton.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(144)))), ((int)(((byte)(212)))));
            this.roomButton.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.roomButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.roomButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.roomButton.IconSize = 25;
            this.roomButton.Location = new System.Drawing.Point(5, 30);
            this.roomButton.Name = "roomButton";
            this.roomButton.Size = new System.Drawing.Size(109, 39);
            this.roomButton.TabIndex = 0;
            this.roomButton.Text = "Rooms";
            this.roomButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.roomButton.UseVisualStyleBackColor = false;
            this.roomButton.Click += new System.EventHandler(this.roomButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 639);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel childFormPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private FontAwesome.Sharp.IconButton usersButton;
        private FontAwesome.Sharp.IconButton roomButton;
        private FontAwesome.Sharp.IconButton minimizeButton;
        private FontAwesome.Sharp.IconButton maximizeButton;
    }
}

