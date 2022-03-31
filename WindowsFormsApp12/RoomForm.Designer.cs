namespace WindowsFormsApp12
{
    partial class RoomForm
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
            this.roomsFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.shadowPanel = new System.Windows.Forms.Panel();
            this.roomsNumLabel = new System.Windows.Forms.Label();
            this.roomsFlowPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // roomsFlowPanel
            // 
            this.roomsFlowPanel.AutoScroll = true;
            this.roomsFlowPanel.AutoSize = true;
            this.roomsFlowPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.roomsFlowPanel.BackColor = System.Drawing.Color.White;
            this.roomsFlowPanel.Controls.Add(this.panel1);
            this.roomsFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roomsFlowPanel.Location = new System.Drawing.Point(0, 0);
            this.roomsFlowPanel.Name = "roomsFlowPanel";
            this.roomsFlowPanel.Size = new System.Drawing.Size(892, 574);
            this.roomsFlowPanel.TabIndex = 0;
            this.roomsFlowPanel.VisibleChanged += new System.EventHandler(this.roomsFlowPanel_VisibleChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.roomsNumLabel);
            this.panel1.Controls.Add(this.shadowPanel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(892, 112);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(141)))), ((int)(((byte)(237)))));
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Available Rooms:";
            // 
            // shadowPanel
            // 
            this.shadowPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(141)))), ((int)(((byte)(245)))));
            this.shadowPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.shadowPanel.Location = new System.Drawing.Point(0, 109);
            this.shadowPanel.Name = "shadowPanel";
            this.shadowPanel.Size = new System.Drawing.Size(892, 3);
            this.shadowPanel.TabIndex = 1;
            // 
            // roomsNumLabel
            // 
            this.roomsNumLabel.AutoSize = true;
            this.roomsNumLabel.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomsNumLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(141)))), ((int)(((byte)(237)))));
            this.roomsNumLabel.Location = new System.Drawing.Point(141, 45);
            this.roomsNumLabel.Name = "roomsNumLabel";
            this.roomsNumLabel.Size = new System.Drawing.Size(0, 27);
            this.roomsNumLabel.TabIndex = 2;
            // 
            // RoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 574);
            this.Controls.Add(this.roomsFlowPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RoomForm";
            this.Text = "RoomForm";
            this.Load += new System.EventHandler(this.RoomForm_Load);
            this.roomsFlowPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel roomsFlowPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel shadowPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label roomsNumLabel;
    }
}