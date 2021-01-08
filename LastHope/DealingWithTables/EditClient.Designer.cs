namespace LastHope.DealingWithTables
{
    partial class EditClient
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
            System.Windows.Forms.Label прізвищеLabel;
            System.Windows.Forms.Label ім_яLabel;
            System.Windows.Forms.Label по_батьковіLabel;
            System.Windows.Forms.Label дата_народженняLabel;
            System.Windows.Forms.Label статьLabel;
            System.Windows.Forms.Label телефонLabel;
            System.Windows.Forms.Label поштаLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SkipButton = new System.Windows.Forms.Button();
            this.mydbDataSet = new LastHope.mydbDataSet();
            this.id_КлієнтаTextBox = new System.Windows.Forms.TextBox();
            this.прізвищеTextBox = new System.Windows.Forms.TextBox();
            this.ім_яTextBox = new System.Windows.Forms.TextBox();
            this.по_батьковіTextBox = new System.Windows.Forms.TextBox();
            this.дата_народженняDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.телефонTextBox = new System.Windows.Forms.TextBox();
            this.поштаTextBox = new System.Windows.Forms.TextBox();
            this.статьUpDown = new System.Windows.Forms.DomainUpDown();
            this.label2 = new System.Windows.Forms.Label();
            прізвищеLabel = new System.Windows.Forms.Label();
            ім_яLabel = new System.Windows.Forms.Label();
            по_батьковіLabel = new System.Windows.Forms.Label();
            дата_народженняLabel = new System.Windows.Forms.Label();
            статьLabel = new System.Windows.Forms.Label();
            телефонLabel = new System.Windows.Forms.Label();
            поштаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // прізвищеLabel
            // 
            прізвищеLabel.AutoSize = true;
            прізвищеLabel.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            прізвищеLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(19)))), ((int)(((byte)(35)))));
            прізвищеLabel.Location = new System.Drawing.Point(77, 190);
            прізвищеLabel.Name = "прізвищеLabel";
            прізвищеLabel.Size = new System.Drawing.Size(100, 24);
            прізвищеLabel.TabIndex = 29;
            прізвищеLabel.Text = "Прізвище:";
            // 
            // ім_яLabel
            // 
            ім_яLabel.AutoSize = true;
            ім_яLabel.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            ім_яLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(19)))), ((int)(((byte)(35)))));
            ім_яLabel.Location = new System.Drawing.Point(77, 218);
            ім_яLabel.Name = "ім_яLabel";
            ім_яLabel.Size = new System.Drawing.Size(49, 24);
            ім_яLabel.TabIndex = 31;
            ім_яLabel.Text = "Ім я:";
            // 
            // по_батьковіLabel
            // 
            по_батьковіLabel.AutoSize = true;
            по_батьковіLabel.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            по_батьковіLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(19)))), ((int)(((byte)(35)))));
            по_батьковіLabel.Location = new System.Drawing.Point(77, 246);
            по_батьковіLabel.Name = "по_батьковіLabel";
            по_батьковіLabel.Size = new System.Drawing.Size(125, 24);
            по_батьковіLabel.TabIndex = 33;
            по_батьковіLabel.Text = "По батькові:";
            // 
            // дата_народженняLabel
            // 
            дата_народженняLabel.AutoSize = true;
            дата_народженняLabel.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            дата_народженняLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(19)))), ((int)(((byte)(35)))));
            дата_народженняLabel.Location = new System.Drawing.Point(77, 275);
            дата_народженняLabel.Name = "дата_народженняLabel";
            дата_народженняLabel.Size = new System.Drawing.Size(183, 24);
            дата_народженняLabel.TabIndex = 35;
            дата_народженняLabel.Text = "Дата народження:";
            // 
            // статьLabel
            // 
            статьLabel.AutoSize = true;
            статьLabel.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            статьLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(19)))), ((int)(((byte)(35)))));
            статьLabel.Location = new System.Drawing.Point(77, 302);
            статьLabel.Name = "статьLabel";
            статьLabel.Size = new System.Drawing.Size(81, 24);
            статьLabel.TabIndex = 37;
            статьLabel.Text = "Стать:";
            // 
            // телефонLabel
            // 
            телефонLabel.AutoSize = true;
            телефонLabel.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            телефонLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(19)))), ((int)(((byte)(35)))));
            телефонLabel.Location = new System.Drawing.Point(77, 330);
            телефонLabel.Name = "телефонLabel";
            телефонLabel.Size = new System.Drawing.Size(92, 24);
            телефонLabel.TabIndex = 39;
            телефонLabel.Text = "Телефон:";
            // 
            // поштаLabel
            // 
            поштаLabel.AutoSize = true;
            поштаLabel.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            поштаLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(19)))), ((int)(((byte)(35)))));
            поштаLabel.Location = new System.Drawing.Point(77, 358);
            поштаLabel.Name = "поштаLabel";
            поштаLabel.Size = new System.Drawing.Size(82, 24);
            поштаLabel.TabIndex = 41;
            поштаLabel.Text = "Пошта:";
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
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(185)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Corbel", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(19)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(19)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Corbel", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(147)))), ((int)(((byte)(126)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(12, 477);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(642, 47);
            this.dataGridView1.TabIndex = 24;
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(147)))), ((int)(((byte)(126)))));
            this.SaveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveButton.FlatAppearance.BorderColor = System.Drawing.Color.SeaShell;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveButton.ForeColor = System.Drawing.Color.SeaShell;
            this.SaveButton.Location = new System.Drawing.Point(58, 542);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(204, 80);
            this.SaveButton.TabIndex = 25;
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
            this.SkipButton.Location = new System.Drawing.Point(370, 542);
            this.SkipButton.Name = "SkipButton";
            this.SkipButton.Size = new System.Drawing.Size(204, 80);
            this.SkipButton.TabIndex = 26;
            this.SkipButton.Text = "Повернутися до таблиць";
            this.SkipButton.UseVisualStyleBackColor = false;
            this.SkipButton.Click += new System.EventHandler(this.SkipButton_Click);
            // 
            // mydbDataSet
            // 
            this.mydbDataSet.DataSetName = "mydbDataSet";
            this.mydbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // id_КлієнтаTextBox
            // 
            this.id_КлієнтаTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.id_КлієнтаTextBox.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.id_КлієнтаTextBox.Location = new System.Drawing.Point(282, 162);
            this.id_КлієнтаTextBox.Name = "id_КлієнтаTextBox";
            this.id_КлієнтаTextBox.ReadOnly = true;
            this.id_КлієнтаTextBox.Size = new System.Drawing.Size(200, 32);
            this.id_КлієнтаTextBox.TabIndex = 28;
            // 
            // прізвищеTextBox
            // 
            this.прізвищеTextBox.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.прізвищеTextBox.Location = new System.Drawing.Point(282, 190);
            this.прізвищеTextBox.MaxLength = 30;
            this.прізвищеTextBox.Name = "прізвищеTextBox";
            this.прізвищеTextBox.Size = new System.Drawing.Size(200, 32);
            this.прізвищеTextBox.TabIndex = 30;
            this.прізвищеTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.прізвищеTextBox_KeyPress);
            // 
            // ім_яTextBox
            // 
            this.ім_яTextBox.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ім_яTextBox.Location = new System.Drawing.Point(282, 218);
            this.ім_яTextBox.MaxLength = 30;
            this.ім_яTextBox.Name = "ім_яTextBox";
            this.ім_яTextBox.Size = new System.Drawing.Size(200, 32);
            this.ім_яTextBox.TabIndex = 32;
            this.ім_яTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.прізвищеTextBox_KeyPress);
            // 
            // по_батьковіTextBox
            // 
            this.по_батьковіTextBox.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.по_батьковіTextBox.Location = new System.Drawing.Point(282, 246);
            this.по_батьковіTextBox.MaxLength = 30;
            this.по_батьковіTextBox.Name = "по_батьковіTextBox";
            this.по_батьковіTextBox.Size = new System.Drawing.Size(200, 32);
            this.по_батьковіTextBox.TabIndex = 34;
            this.по_батьковіTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.прізвищеTextBox_KeyPress);
            // 
            // дата_народженняDateTimePicker
            // 
            this.дата_народженняDateTimePicker.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.дата_народженняDateTimePicker.Location = new System.Drawing.Point(282, 274);
            this.дата_народженняDateTimePicker.Name = "дата_народженняDateTimePicker";
            this.дата_народженняDateTimePicker.Size = new System.Drawing.Size(200, 32);
            this.дата_народженняDateTimePicker.TabIndex = 36;
            this.дата_народженняDateTimePicker.ValueChanged += new System.EventHandler(this.дата_народженняDateTimePicker_ValueChanged);
            // 
            // телефонTextBox
            // 
            this.телефонTextBox.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.телефонTextBox.Location = new System.Drawing.Point(282, 330);
            this.телефонTextBox.MaxLength = 30;
            this.телефонTextBox.Name = "телефонTextBox";
            this.телефонTextBox.Size = new System.Drawing.Size(200, 32);
            this.телефонTextBox.TabIndex = 40;
            this.телефонTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.телефонTextBox_KeyPress);
            // 
            // поштаTextBox
            // 
            this.поштаTextBox.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.поштаTextBox.Location = new System.Drawing.Point(282, 358);
            this.поштаTextBox.MaxLength = 30;
            this.поштаTextBox.Name = "поштаTextBox";
            this.поштаTextBox.Size = new System.Drawing.Size(200, 32);
            this.поштаTextBox.TabIndex = 42;
            this.поштаTextBox.TextChanged += new System.EventHandler(this.поштаTextBox_TextChanged);
            // 
            // статьUpDown
            // 
            this.статьUpDown.Font = new System.Drawing.Font("Corbel", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.статьUpDown.Items.Add("чоловік");
            this.статьUpDown.Items.Add("жінка");
            this.статьUpDown.Items.Add("трансгендер");
            this.статьUpDown.Location = new System.Drawing.Point(282, 302);
            this.статьUpDown.Name = "статьUpDown";
            this.статьUpDown.Size = new System.Drawing.Size(200, 29);
            this.статьUpDown.TabIndex = 43;
            this.статьUpDown.Text = "чоловік";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(19)))), ((int)(((byte)(35)))));
            this.label2.Location = new System.Drawing.Point(77, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 24);
            this.label2.TabIndex = 47;
            this.label2.Text = "Id Клієнта:";
            // 
            // EditClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(684, 703);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.статьUpDown);
            this.Controls.Add(this.id_КлієнтаTextBox);
            this.Controls.Add(прізвищеLabel);
            this.Controls.Add(this.прізвищеTextBox);
            this.Controls.Add(ім_яLabel);
            this.Controls.Add(this.ім_яTextBox);
            this.Controls.Add(по_батьковіLabel);
            this.Controls.Add(this.по_батьковіTextBox);
            this.Controls.Add(дата_народженняLabel);
            this.Controls.Add(this.дата_народженняDateTimePicker);
            this.Controls.Add(статьLabel);
            this.Controls.Add(телефонLabel);
            this.Controls.Add(this.телефонTextBox);
            this.Controls.Add(поштаLabel);
            this.Controls.Add(this.поштаTextBox);
            this.Controls.Add(this.SkipButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditClient";
            this.Text = "EditClient";
            this.Load += new System.EventHandler(this.EditClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button SkipButton;
        private mydbDataSet mydbDataSet;
        private System.Windows.Forms.TextBox id_КлієнтаTextBox;
        private System.Windows.Forms.TextBox прізвищеTextBox;
        private System.Windows.Forms.TextBox ім_яTextBox;
        private System.Windows.Forms.TextBox по_батьковіTextBox;
        private System.Windows.Forms.DateTimePicker дата_народженняDateTimePicker;
        private System.Windows.Forms.TextBox телефонTextBox;
        private System.Windows.Forms.TextBox поштаTextBox;
        private System.Windows.Forms.DomainUpDown статьUpDown;
        private System.Windows.Forms.Label label2;
    }
}