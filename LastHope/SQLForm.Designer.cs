namespace LastHope
{
    partial class SQLForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TestInput = new System.Windows.Forms.RichTextBox();
            this.DoSQLButt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ClearSQLButt = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TestInput
            // 
            this.TestInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TestInput.BackColor = System.Drawing.Color.SeaShell;
            this.TestInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TestInput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TestInput.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TestInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(19)))), ((int)(((byte)(35)))));
            this.TestInput.Location = new System.Drawing.Point(40, 78);
            this.TestInput.Name = "TestInput";
            this.TestInput.Size = new System.Drawing.Size(511, 104);
            this.TestInput.TabIndex = 0;
            this.TestInput.Text = "SELECT *  FROM Психологи";
            // 
            // DoSQLButt
            // 
            this.DoSQLButt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DoSQLButt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(147)))), ((int)(((byte)(126)))));
            this.DoSQLButt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoSQLButt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DoSQLButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoSQLButt.Font = new System.Drawing.Font("Corbel", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DoSQLButt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DoSQLButt.Location = new System.Drawing.Point(574, 78);
            this.DoSQLButt.Name = "DoSQLButt";
            this.DoSQLButt.Size = new System.Drawing.Size(74, 29);
            this.DoSQLButt.TabIndex = 2;
            this.DoSQLButt.Text = "Do SQL";
            this.DoSQLButt.UseVisualStyleBackColor = false;
            this.DoSQLButt.Click += new System.EventHandler(this.DoSQLButt_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(19)))), ((int)(((byte)(35)))));
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(688, 46);
            this.label1.TabIndex = 5;
            this.label1.Text = "Редактор SQL - запитів до Бази Даних ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ClearSQLButt
            // 
            this.ClearSQLButt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearSQLButt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(147)))), ((int)(((byte)(126)))));
            this.ClearSQLButt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearSQLButt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClearSQLButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearSQLButt.Font = new System.Drawing.Font("Corbel", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearSQLButt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ClearSQLButt.Location = new System.Drawing.Point(574, 154);
            this.ClearSQLButt.Name = "ClearSQLButt";
            this.ClearSQLButt.Size = new System.Drawing.Size(74, 28);
            this.ClearSQLButt.TabIndex = 6;
            this.ClearSQLButt.Text = "Clear";
            this.ClearSQLButt.UseVisualStyleBackColor = false;
            this.ClearSQLButt.Click += new System.EventHandler(this.ClearSQLButt_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(185)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Corbel", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(19)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(19)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Corbel", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(147)))), ((int)(((byte)(126)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(40, 294);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(608, 223);
            this.dataGridView1.TabIndex = 7;
            // 
            // SQLForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(684, 703);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ClearSQLButt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DoSQLButt);
            this.Controls.Add(this.TestInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SQLForm";
            this.Text = "SQLForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox TestInput;
        private System.Windows.Forms.Button DoSQLButt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ClearSQLButt;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}