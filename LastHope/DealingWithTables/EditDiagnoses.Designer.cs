﻿namespace LastHope.DealingWithTables
{
    partial class EditDiagnoses
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
            System.Windows.Forms.Label id_Поставленого_діагнозуLabel;
            System.Windows.Forms.Label id_Клієнта2Label;
            System.Windows.Forms.Label id_Хвороби2Label;
            System.Windows.Forms.Label дата_озвучуванняLabel;
            System.Windows.Forms.Label затвердження_нарадоюLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mydbDataSet = new LastHope.mydbDataSet();
            this.id_Поставленого_діагнозуTextBox = new System.Windows.Forms.TextBox();
            this.дата_озвучуванняDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SkipButton = new System.Windows.Forms.Button();
            this.clientUpDown = new System.Windows.Forms.DomainUpDown();
            this.diseaseUpDown = new System.Windows.Forms.DomainUpDown();
            this.stateUpDown = new System.Windows.Forms.DomainUpDown();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            id_Поставленого_діагнозуLabel = new System.Windows.Forms.Label();
            id_Клієнта2Label = new System.Windows.Forms.Label();
            id_Хвороби2Label = new System.Windows.Forms.Label();
            дата_озвучуванняLabel = new System.Windows.Forms.Label();
            затвердження_нарадоюLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // id_Поставленого_діагнозуLabel
            // 
            id_Поставленого_діагнозуLabel.AutoSize = true;
            id_Поставленого_діагнозуLabel.Location = new System.Drawing.Point(95, 133);
            id_Поставленого_діагнозуLabel.Name = "id_Поставленого_діагнозуLabel";
            id_Поставленого_діагнозуLabel.Size = new System.Drawing.Size(177, 17);
            id_Поставленого_діагнозуLabel.TabIndex = 1;
            id_Поставленого_діагнозуLabel.Text = "Id Поставленого діагнозу:";
            // 
            // id_Клієнта2Label
            // 
            id_Клієнта2Label.AutoSize = true;
            id_Клієнта2Label.Location = new System.Drawing.Point(95, 155);
            id_Клієнта2Label.Name = "id_Клієнта2Label";
            id_Клієнта2Label.Size = new System.Drawing.Size(54, 17);
            id_Клієнта2Label.TabIndex = 3;
            id_Клієнта2Label.Text = "Клієнт:";
            // 
            // id_Хвороби2Label
            // 
            id_Хвороби2Label.AutoSize = true;
            id_Хвороби2Label.Location = new System.Drawing.Point(95, 183);
            id_Хвороби2Label.Name = "id_Хвороби2Label";
            id_Хвороби2Label.Size = new System.Drawing.Size(68, 17);
            id_Хвороби2Label.TabIndex = 5;
            id_Хвороби2Label.Text = "Хвороба:";
            // 
            // дата_озвучуванняLabel
            // 
            дата_озвучуванняLabel.AutoSize = true;
            дата_озвучуванняLabel.Location = new System.Drawing.Point(95, 212);
            дата_озвучуванняLabel.Name = "дата_озвучуванняLabel";
            дата_озвучуванняLabel.Size = new System.Drawing.Size(133, 17);
            дата_озвучуванняLabel.TabIndex = 7;
            дата_озвучуванняLabel.Text = "Дата озвучування:";
            // 
            // затвердження_нарадоюLabel
            // 
            затвердження_нарадоюLabel.AutoSize = true;
            затвердження_нарадоюLabel.Location = new System.Drawing.Point(95, 239);
            затвердження_нарадоюLabel.Name = "затвердження_нарадоюLabel";
            затвердження_нарадоюLabel.Size = new System.Drawing.Size(170, 17);
            затвердження_нарадоюLabel.TabIndex = 9;
            затвердження_нарадоюLabel.Text = "Затвердження нарадою:";
            // 
            // mydbDataSet
            // 
            this.mydbDataSet.DataSetName = "mydbDataSet";
            this.mydbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // id_Поставленого_діагнозуTextBox
            // 
            this.id_Поставленого_діагнозуTextBox.Location = new System.Drawing.Point(278, 124);
            this.id_Поставленого_діагнозуTextBox.Name = "id_Поставленого_діагнозуTextBox";
            this.id_Поставленого_діагнозуTextBox.Size = new System.Drawing.Size(200, 22);
            this.id_Поставленого_діагнозуTextBox.TabIndex = 2;
            // 
            // дата_озвучуванняDateTimePicker
            // 
            this.дата_озвучуванняDateTimePicker.Location = new System.Drawing.Point(278, 208);
            this.дата_озвучуванняDateTimePicker.Name = "дата_озвучуванняDateTimePicker";
            this.дата_озвучуванняDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.дата_озвучуванняDateTimePicker.TabIndex = 8;
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(147)))), ((int)(((byte)(126)))));
            this.SaveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveButton.FlatAppearance.BorderColor = System.Drawing.Color.SeaShell;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveButton.ForeColor = System.Drawing.Color.SeaShell;
            this.SaveButton.Location = new System.Drawing.Point(61, 451);
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
            this.SkipButton.Location = new System.Drawing.Point(388, 451);
            this.SkipButton.Name = "SkipButton";
            this.SkipButton.Size = new System.Drawing.Size(204, 80);
            this.SkipButton.TabIndex = 27;
            this.SkipButton.Text = "Повернутися до таблиць";
            this.SkipButton.UseVisualStyleBackColor = false;
            this.SkipButton.Click += new System.EventHandler(this.SkipButton_Click);
            // 
            // clientUpDown
            // 
            this.clientUpDown.Location = new System.Drawing.Point(278, 155);
            this.clientUpDown.Name = "clientUpDown";
            this.clientUpDown.ReadOnly = true;
            this.clientUpDown.Size = new System.Drawing.Size(200, 22);
            this.clientUpDown.TabIndex = 28;
            this.clientUpDown.Text = "Оберіть клієнта";
            // 
            // diseaseUpDown
            // 
            this.diseaseUpDown.Location = new System.Drawing.Point(278, 183);
            this.diseaseUpDown.Name = "diseaseUpDown";
            this.diseaseUpDown.ReadOnly = true;
            this.diseaseUpDown.Size = new System.Drawing.Size(200, 22);
            this.diseaseUpDown.TabIndex = 29;
            this.diseaseUpDown.Text = "Оберіть хворобу";
            // 
            // stateUpDown
            // 
            this.stateUpDown.Items.Add("Згодні всі");
            this.stateUpDown.Items.Add("Не згодні");
            this.stateUpDown.Items.Add("Психолог відп.");
            this.stateUpDown.Location = new System.Drawing.Point(278, 239);
            this.stateUpDown.Name = "stateUpDown";
            this.stateUpDown.ReadOnly = true;
            this.stateUpDown.Size = new System.Drawing.Size(200, 22);
            this.stateUpDown.TabIndex = 30;
            this.stateUpDown.Text = "Оберіть стан";
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView4.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dataGridView4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView4.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(185)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Corbel", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(19)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView4.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView4.ColumnHeadersHeight = 29;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(19)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Corbel", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(147)))), ((int)(((byte)(126)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView4.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView4.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView4.Location = new System.Drawing.Point(21, 330);
            this.dataGridView4.MultiSelect = false;
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView4.Size = new System.Drawing.Size(642, 42);
            this.dataGridView4.TabIndex = 35;
            this.dataGridView4.Visible = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(185)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Corbel", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(19)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.ColumnHeadersHeight = 29;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(19)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Corbel", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(147)))), ((int)(((byte)(126)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView2.Location = new System.Drawing.Point(21, 378);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(642, 41);
            this.dataGridView2.TabIndex = 36;
            this.dataGridView2.Visible = false;
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(185)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Corbel", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(19)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(19)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Corbel", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(147)))), ((int)(((byte)(126)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(21, 283);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(642, 41);
            this.dataGridView1.TabIndex = 37;
            this.dataGridView1.Visible = false;
            // 
            // EditDiagnoses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(684, 703);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.stateUpDown);
            this.Controls.Add(this.diseaseUpDown);
            this.Controls.Add(this.clientUpDown);
            this.Controls.Add(this.SkipButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(id_Поставленого_діагнозуLabel);
            this.Controls.Add(this.id_Поставленого_діагнозуTextBox);
            this.Controls.Add(id_Клієнта2Label);
            this.Controls.Add(id_Хвороби2Label);
            this.Controls.Add(дата_озвучуванняLabel);
            this.Controls.Add(this.дата_озвучуванняDateTimePicker);
            this.Controls.Add(затвердження_нарадоюLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditDiagnoses";
            this.Text = "EditDiagnoses";
            this.Load += new System.EventHandler(this.EditDiagnoses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private mydbDataSet mydbDataSet;
        private System.Windows.Forms.TextBox id_Поставленого_діагнозуTextBox;
        private System.Windows.Forms.DateTimePicker дата_озвучуванняDateTimePicker;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button SkipButton;
        private System.Windows.Forms.DomainUpDown clientUpDown;
        private System.Windows.Forms.DomainUpDown diseaseUpDown;
        private System.Windows.Forms.DomainUpDown stateUpDown;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}