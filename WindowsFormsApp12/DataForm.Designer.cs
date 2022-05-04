namespace WindowsFormsApp12
{
    partial class DataForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteButton = new System.Windows.Forms.Button();
            this.compactButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameCol,
            this.PhoneCol,
            this.roomType,
            this.roomNum,
            this.emailCol});
            this.dataGridView1.Location = new System.Drawing.Point(43, 26);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Size = new System.Drawing.Size(753, 447);
            this.dataGridView1.TabIndex = 0;
            // 
            // NameCol
            // 
            this.NameCol.HeaderText = "Name";
            this.NameCol.Name = "NameCol";
            // 
            // PhoneCol
            // 
            this.PhoneCol.HeaderText = "Phone Number";
            this.PhoneCol.Name = "PhoneCol";
            // 
            // roomType
            // 
            this.roomType.HeaderText = "Room Type";
            this.roomType.Name = "roomType";
            // 
            // roomNum
            // 
            this.roomNum.HeaderText = "Room Number";
            this.roomNum.Name = "roomNum";
            // 
            // emailCol
            // 
            this.emailCol.HeaderText = "Email";
            this.emailCol.Name = "emailCol";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(135, 498);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(177, 55);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // compactButton
            // 
            this.compactButton.Location = new System.Drawing.Point(418, 498);
            this.compactButton.Name = "compactButton";
            this.compactButton.Size = new System.Drawing.Size(177, 55);
            this.compactButton.TabIndex = 2;
            this.compactButton.Text = "Compact";
            this.compactButton.UseVisualStyleBackColor = true;
            this.compactButton.Click += new System.EventHandler(this.compactButton_Click);
            // 
            // DataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 574);
            this.Controls.Add(this.compactButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DataForm";
            this.Text = "DataForm";
            this.Load += new System.EventHandler(this.DataForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomType;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNum;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button compactButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailCol;
    }
}