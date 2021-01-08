namespace LastHope.DealingWithTables
{
    partial class EditDisease
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
            System.Windows.Forms.Label назва_хворобиLabel;
            System.Windows.Forms.Label короткий_описLabel;
            System.Windows.Forms.Label тяжкість_лікуванняLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mydbDataSet = new LastHope.mydbDataSet();
            this.id_ХворобиTextBox = new System.Windows.Forms.TextBox();
            this.назва_хворобиTextBox = new System.Windows.Forms.TextBox();
            this.короткий_описTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SkipButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.тяжкість_лікуванняUpDown = new System.Windows.Forms.DomainUpDown();
            назва_хворобиLabel = new System.Windows.Forms.Label();
            короткий_описLabel = new System.Windows.Forms.Label();
            тяжкість_лікуванняLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // назва_хворобиLabel
            // 
            назва_хворобиLabel.AutoSize = true;
            назва_хворобиLabel.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            назва_хворобиLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(19)))), ((int)(((byte)(35)))));
            назва_хворобиLabel.Location = new System.Drawing.Point(84, 106);
            назва_хворобиLabel.Name = "назва_хворобиLabel";
            назва_хворобиLabel.Size = new System.Drawing.Size(145, 24);
            назва_хворобиLabel.TabIndex = 3;
            назва_хворобиLabel.Text = "Назва хвороби:";
            // 
            // короткий_описLabel
            // 
            короткий_описLabel.AutoSize = true;
            короткий_описLabel.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            короткий_описLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(19)))), ((int)(((byte)(35)))));
            короткий_описLabel.Location = new System.Drawing.Point(84, 134);
            короткий_описLabel.Name = "короткий_описLabel";
            короткий_описLabel.Size = new System.Drawing.Size(151, 24);
            короткий_описLabel.TabIndex = 5;
            короткий_описLabel.Text = "Короткий опис:";
            // 
            // тяжкість_лікуванняLabel
            // 
            тяжкість_лікуванняLabel.AutoSize = true;
            тяжкість_лікуванняLabel.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            тяжкість_лікуванняLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(19)))), ((int)(((byte)(35)))));
            тяжкість_лікуванняLabel.Location = new System.Drawing.Point(84, 387);
            тяжкість_лікуванняLabel.Name = "тяжкість_лікуванняLabel";
            тяжкість_лікуванняLabel.Size = new System.Drawing.Size(195, 24);
            тяжкість_лікуванняLabel.TabIndex = 7;
            тяжкість_лікуванняLabel.Text = "Тяжкість лікування:";
            // 
            // mydbDataSet
            // 
            this.mydbDataSet.DataSetName = "mydbDataSet";
            this.mydbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // id_ХворобиTextBox
            // 
            this.id_ХворобиTextBox.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.id_ХворобиTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(19)))), ((int)(((byte)(35)))));
            this.id_ХворобиTextBox.Location = new System.Drawing.Point(316, 65);
            this.id_ХворобиTextBox.Name = "id_ХворобиTextBox";
            this.id_ХворобиTextBox.Size = new System.Drawing.Size(327, 32);
            this.id_ХворобиTextBox.TabIndex = 2;
            // 
            // назва_хворобиTextBox
            // 
            this.назва_хворобиTextBox.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.назва_хворобиTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(19)))), ((int)(((byte)(35)))));
            this.назва_хворобиTextBox.Location = new System.Drawing.Point(316, 103);
            this.назва_хворобиTextBox.MaxLength = 30;
            this.назва_хворобиTextBox.Name = "назва_хворобиTextBox";
            this.назва_хворобиTextBox.Size = new System.Drawing.Size(327, 32);
            this.назва_хворобиTextBox.TabIndex = 4;
            this.назва_хворобиTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.назва_хворобиTextBox_KeyPress);
            // 
            // короткий_описTextBox
            // 
            this.короткий_описTextBox.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.короткий_описTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(19)))), ((int)(((byte)(35)))));
            this.короткий_описTextBox.Location = new System.Drawing.Point(255, 139);
            this.короткий_описTextBox.MaxLength = 1000;
            this.короткий_описTextBox.Multiline = true;
            this.короткий_описTextBox.Name = "короткий_описTextBox";
            this.короткий_описTextBox.Size = new System.Drawing.Size(388, 237);
            this.короткий_описTextBox.TabIndex = 6;
            this.короткий_описTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.назва_хворобиTextBox_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(185)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Corbel", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(19)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(19)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Corbel", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(147)))), ((int)(((byte)(126)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(30, 424);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(642, 47);
            this.dataGridView1.TabIndex = 25;
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(147)))), ((int)(((byte)(126)))));
            this.SaveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveButton.FlatAppearance.BorderColor = System.Drawing.Color.SeaShell;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveButton.ForeColor = System.Drawing.Color.SeaShell;
            this.SaveButton.Location = new System.Drawing.Point(75, 532);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(204, 80);
            this.SaveButton.TabIndex = 26;
            this.SaveButton.Text = "Зберегти элемент в базі";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // SkipButton
            // 
            this.SkipButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(19)))), ((int)(((byte)(35)))));
            this.SkipButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SkipButton.FlatAppearance.BorderColor = System.Drawing.Color.SeaShell;
            this.SkipButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SkipButton.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SkipButton.ForeColor = System.Drawing.Color.SeaShell;
            this.SkipButton.Location = new System.Drawing.Point(394, 532);
            this.SkipButton.Name = "SkipButton";
            this.SkipButton.Size = new System.Drawing.Size(204, 80);
            this.SkipButton.TabIndex = 27;
            this.SkipButton.Text = "Повернутися до таблиць";
            this.SkipButton.UseVisualStyleBackColor = false;
            this.SkipButton.Click += new System.EventHandler(this.SkipButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(19)))), ((int)(((byte)(35)))));
            this.label2.Location = new System.Drawing.Point(84, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 24);
            this.label2.TabIndex = 49;
            this.label2.Text = "Id Хвороби:";
            // 
            // тяжкість_лікуванняUpDown
            // 
            this.тяжкість_лікуванняUpDown.Font = new System.Drawing.Font("Corbel", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.тяжкість_лікуванняUpDown.Items.Add("Низька ");
            this.тяжкість_лікуванняUpDown.Items.Add("Середня");
            this.тяжкість_лікуванняUpDown.Items.Add("Висока");
            this.тяжкість_лікуванняUpDown.Location = new System.Drawing.Point(316, 382);
            this.тяжкість_лікуванняUpDown.Name = "тяжкість_лікуванняUpDown";
            this.тяжкість_лікуванняUpDown.Size = new System.Drawing.Size(200, 29);
            this.тяжкість_лікуванняUpDown.TabIndex = 51;
            this.тяжкість_лікуванняUpDown.Text = "Низька ";
            // 
            // EditDisease
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(684, 703);
            this.Controls.Add(this.тяжкість_лікуванняUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SkipButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.id_ХворобиTextBox);
            this.Controls.Add(назва_хворобиLabel);
            this.Controls.Add(this.назва_хворобиTextBox);
            this.Controls.Add(короткий_описLabel);
            this.Controls.Add(this.короткий_описTextBox);
            this.Controls.Add(тяжкість_лікуванняLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditDisease";
            this.Text = "EditDisease";
            this.Load += new System.EventHandler(this.EditDisease_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private mydbDataSet mydbDataSet;
        private System.Windows.Forms.TextBox id_ХворобиTextBox;
        private System.Windows.Forms.TextBox назва_хворобиTextBox;
        private System.Windows.Forms.TextBox короткий_описTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button SkipButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DomainUpDown тяжкість_лікуванняUpDown;
    }
}