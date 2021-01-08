namespace LastHope.DealingWithTables
{
    partial class EditPsycho
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
            System.Windows.Forms.Label роки_кваліфікаціїLabel;
            System.Windows.Forms.Label лікарська_ступіньLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mydbDataSet = new LastHope.mydbDataSet();
            this.iD_ПсихологаTextBox = new System.Windows.Forms.TextBox();
            this.прізвищеTextBox = new System.Windows.Forms.TextBox();
            this.ім_яTextBox = new System.Windows.Forms.TextBox();
            this.по_батьковіTextBox = new System.Windows.Forms.TextBox();
            this.дата_народженняDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.телефонTextBox = new System.Windows.Forms.TextBox();
            this.поштаTextBox = new System.Windows.Forms.TextBox();
            this.роки_кваліфікаціїTextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SkipButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.статьUpDown = new System.Windows.Forms.DomainUpDown();
            this.лікарська_ступіньUpDown = new System.Windows.Forms.DomainUpDown();
            прізвищеLabel = new System.Windows.Forms.Label();
            ім_яLabel = new System.Windows.Forms.Label();
            по_батьковіLabel = new System.Windows.Forms.Label();
            дата_народженняLabel = new System.Windows.Forms.Label();
            статьLabel = new System.Windows.Forms.Label();
            телефонLabel = new System.Windows.Forms.Label();
            поштаLabel = new System.Windows.Forms.Label();
            роки_кваліфікаціїLabel = new System.Windows.Forms.Label();
            лікарська_ступіньLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // прізвищеLabel
            // 
            прізвищеLabel.AutoSize = true;
            прізвищеLabel.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            прізвищеLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(19)))), ((int)(((byte)(35)))));
            прізвищеLabel.Location = new System.Drawing.Point(55, 140);
            прізвищеLabel.Name = "прізвищеLabel";
            прізвищеLabel.Size = new System.Drawing.Size(100, 24);
            прізвищеLabel.TabIndex = 3;
            прізвищеLabel.Text = "Прізвище:";
            // 
            // ім_яLabel
            // 
            ім_яLabel.AutoSize = true;
            ім_яLabel.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            ім_яLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(19)))), ((int)(((byte)(35)))));
            ім_яLabel.Location = new System.Drawing.Point(55, 168);
            ім_яLabel.Name = "ім_яLabel";
            ім_яLabel.Size = new System.Drawing.Size(49, 24);
            ім_яLabel.TabIndex = 5;
            ім_яLabel.Text = "Ім я:";
            // 
            // по_батьковіLabel
            // 
            по_батьковіLabel.AutoSize = true;
            по_батьковіLabel.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            по_батьковіLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(19)))), ((int)(((byte)(35)))));
            по_батьковіLabel.Location = new System.Drawing.Point(55, 196);
            по_батьковіLabel.Name = "по_батьковіLabel";
            по_батьковіLabel.Size = new System.Drawing.Size(125, 24);
            по_батьковіLabel.TabIndex = 7;
            по_батьковіLabel.Text = "По батькові:";
            // 
            // дата_народженняLabel
            // 
            дата_народженняLabel.AutoSize = true;
            дата_народженняLabel.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            дата_народженняLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(19)))), ((int)(((byte)(35)))));
            дата_народженняLabel.Location = new System.Drawing.Point(55, 225);
            дата_народженняLabel.Name = "дата_народженняLabel";
            дата_народженняLabel.Size = new System.Drawing.Size(183, 24);
            дата_народженняLabel.TabIndex = 9;
            дата_народженняLabel.Text = "Дата народження:";
            // 
            // статьLabel
            // 
            статьLabel.AutoSize = true;
            статьLabel.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            статьLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(19)))), ((int)(((byte)(35)))));
            статьLabel.Location = new System.Drawing.Point(55, 252);
            статьLabel.Name = "статьLabel";
            статьLabel.Size = new System.Drawing.Size(81, 24);
            статьLabel.TabIndex = 11;
            статьLabel.Text = "Стать:";
            // 
            // телефонLabel
            // 
            телефонLabel.AutoSize = true;
            телефонLabel.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            телефонLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(19)))), ((int)(((byte)(35)))));
            телефонLabel.Location = new System.Drawing.Point(55, 280);
            телефонLabel.Name = "телефонLabel";
            телефонLabel.Size = new System.Drawing.Size(92, 24);
            телефонLabel.TabIndex = 13;
            телефонLabel.Text = "Телефон:";
            // 
            // поштаLabel
            // 
            поштаLabel.AutoSize = true;
            поштаLabel.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            поштаLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(19)))), ((int)(((byte)(35)))));
            поштаLabel.Location = new System.Drawing.Point(55, 308);
            поштаLabel.Name = "поштаLabel";
            поштаLabel.Size = new System.Drawing.Size(82, 24);
            поштаLabel.TabIndex = 15;
            поштаLabel.Text = "Пошта:";
            // 
            // роки_кваліфікаціїLabel
            // 
            роки_кваліфікаціїLabel.AutoSize = true;
            роки_кваліфікаціїLabel.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            роки_кваліфікаціїLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(19)))), ((int)(((byte)(35)))));
            роки_кваліфікаціїLabel.Location = new System.Drawing.Point(55, 336);
            роки_кваліфікаціїLabel.Name = "роки_кваліфікаціїLabel";
            роки_кваліфікаціїLabel.Size = new System.Drawing.Size(172, 24);
            роки_кваліфікаціїLabel.TabIndex = 17;
            роки_кваліфікаціїLabel.Text = "Роки кваліфікації:";
            // 
            // лікарська_ступіньLabel
            // 
            лікарська_ступіньLabel.AutoSize = true;
            лікарська_ступіньLabel.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            лікарська_ступіньLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(19)))), ((int)(((byte)(35)))));
            лікарська_ступіньLabel.Location = new System.Drawing.Point(55, 364);
            лікарська_ступіньLabel.Name = "лікарська_ступіньLabel";
            лікарська_ступіньLabel.Size = new System.Drawing.Size(181, 24);
            лікарська_ступіньLabel.TabIndex = 19;
            лікарська_ступіньLabel.Text = "Лікарська ступінь:";
            // 
            // mydbDataSet
            // 
            this.mydbDataSet.DataSetName = "mydbDataSet";
            this.mydbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iD_ПсихологаTextBox
            // 
            this.iD_ПсихологаTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.iD_ПсихологаTextBox.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iD_ПсихологаTextBox.Location = new System.Drawing.Point(257, 113);
            this.iD_ПсихологаTextBox.Name = "iD_ПсихологаTextBox";
            this.iD_ПсихологаTextBox.ReadOnly = true;
            this.iD_ПсихологаTextBox.Size = new System.Drawing.Size(200, 32);
            this.iD_ПсихологаTextBox.TabIndex = 2;
            // 
            // прізвищеTextBox
            // 
            this.прізвищеTextBox.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.прізвищеTextBox.Location = new System.Drawing.Point(257, 141);
            this.прізвищеTextBox.MaxLength = 30;
            this.прізвищеTextBox.Name = "прізвищеTextBox";
            this.прізвищеTextBox.Size = new System.Drawing.Size(200, 32);
            this.прізвищеTextBox.TabIndex = 4;
            this.прізвищеTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.прізвищеTextBox_KeyPress);
            // 
            // ім_яTextBox
            // 
            this.ім_яTextBox.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ім_яTextBox.Location = new System.Drawing.Point(257, 169);
            this.ім_яTextBox.MaxLength = 30;
            this.ім_яTextBox.Name = "ім_яTextBox";
            this.ім_яTextBox.Size = new System.Drawing.Size(200, 32);
            this.ім_яTextBox.TabIndex = 6;
            this.ім_яTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.прізвищеTextBox_KeyPress);
            // 
            // по_батьковіTextBox
            // 
            this.по_батьковіTextBox.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.по_батьковіTextBox.Location = new System.Drawing.Point(257, 197);
            this.по_батьковіTextBox.MaxLength = 30;
            this.по_батьковіTextBox.Name = "по_батьковіTextBox";
            this.по_батьковіTextBox.Size = new System.Drawing.Size(200, 32);
            this.по_батьковіTextBox.TabIndex = 8;
            this.по_батьковіTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.прізвищеTextBox_KeyPress);
            // 
            // дата_народженняDateTimePicker
            // 
            this.дата_народженняDateTimePicker.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.дата_народженняDateTimePicker.Location = new System.Drawing.Point(257, 225);
            this.дата_народженняDateTimePicker.Name = "дата_народженняDateTimePicker";
            this.дата_народженняDateTimePicker.Size = new System.Drawing.Size(200, 32);
            this.дата_народженняDateTimePicker.TabIndex = 10;
            this.дата_народженняDateTimePicker.ValueChanged += new System.EventHandler(this.дата_народженняDateTimePicker_ValueChanged);
            // 
            // телефонTextBox
            // 
            this.телефонTextBox.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.телефонTextBox.Location = new System.Drawing.Point(257, 281);
            this.телефонTextBox.MaxLength = 30;
            this.телефонTextBox.Name = "телефонTextBox";
            this.телефонTextBox.Size = new System.Drawing.Size(200, 32);
            this.телефонTextBox.TabIndex = 14;
            this.телефонTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.телефонTextBox_KeyPress);
            // 
            // поштаTextBox
            // 
            this.поштаTextBox.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.поштаTextBox.Location = new System.Drawing.Point(257, 309);
            this.поштаTextBox.MaxLength = 30;
            this.поштаTextBox.Name = "поштаTextBox";
            this.поштаTextBox.Size = new System.Drawing.Size(200, 32);
            this.поштаTextBox.TabIndex = 16;
            this.поштаTextBox.TextChanged += new System.EventHandler(this.поштаTextBox_TextChanged);
            // 
            // роки_кваліфікаціїTextBox
            // 
            this.роки_кваліфікаціїTextBox.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.роки_кваліфікаціїTextBox.Location = new System.Drawing.Point(257, 337);
            this.роки_кваліфікаціїTextBox.MaxLength = 2;
            this.роки_кваліфікаціїTextBox.Name = "роки_кваліфікаціїTextBox";
            this.роки_кваліфікаціїTextBox.Size = new System.Drawing.Size(200, 32);
            this.роки_кваліфікаціїTextBox.TabIndex = 18;
            this.роки_кваліфікаціїTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.телефонTextBox_KeyPress);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(147)))), ((int)(((byte)(126)))));
            this.SaveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveButton.FlatAppearance.BorderColor = System.Drawing.Color.SeaShell;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveButton.ForeColor = System.Drawing.Color.SeaShell;
            this.SaveButton.Location = new System.Drawing.Point(79, 542);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(204, 80);
            this.SaveButton.TabIndex = 21;
            this.SaveButton.Text = "Зберегти элемент в базі";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.ResetButt_Click);
            // 
            // SkipButton
            // 
            this.SkipButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(19)))), ((int)(((byte)(35)))));
            this.SkipButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SkipButton.FlatAppearance.BorderColor = System.Drawing.Color.SeaShell;
            this.SkipButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SkipButton.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SkipButton.ForeColor = System.Drawing.Color.SeaShell;
            this.SkipButton.Location = new System.Drawing.Point(390, 542);
            this.SkipButton.Name = "SkipButton";
            this.SkipButton.Size = new System.Drawing.Size(204, 80);
            this.SkipButton.TabIndex = 22;
            this.SkipButton.Text = "Повернутися до таблиць";
            this.SkipButton.UseVisualStyleBackColor = false;
            this.SkipButton.Click += new System.EventHandler(this.button1_Click);
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
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(185)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Corbel", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(19)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(19)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Corbel", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(147)))), ((int)(((byte)(126)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(30, 446);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(642, 47);
            this.dataGridView1.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(19)))), ((int)(((byte)(35)))));
            this.label2.Location = new System.Drawing.Point(55, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 24);
            this.label2.TabIndex = 48;
            this.label2.Text = "Id Психолога:";
            // 
            // статьUpDown
            // 
            this.статьUpDown.Font = new System.Drawing.Font("Corbel", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.статьUpDown.Items.Add("чоловік");
            this.статьUpDown.Items.Add("жінка");
            this.статьUpDown.Items.Add("трансгендер");
            this.статьUpDown.Location = new System.Drawing.Point(257, 252);
            this.статьUpDown.Name = "статьUpDown";
            this.статьUpDown.Size = new System.Drawing.Size(200, 29);
            this.статьUpDown.TabIndex = 49;
            this.статьUpDown.Text = "чоловік";
            // 
            // лікарська_ступіньUpDown
            // 
            this.лікарська_ступіньUpDown.Font = new System.Drawing.Font("Corbel", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.лікарська_ступіньUpDown.Items.Add("Перша");
            this.лікарська_ступіньUpDown.Items.Add("Друга");
            this.лікарська_ступіньUpDown.Items.Add("Третя");
            this.лікарська_ступіньUpDown.Location = new System.Drawing.Point(257, 364);
            this.лікарська_ступіньUpDown.Name = "лікарська_ступіньUpDown";
            this.лікарська_ступіньUpDown.Size = new System.Drawing.Size(200, 29);
            this.лікарська_ступіньUpDown.TabIndex = 50;
            this.лікарська_ступіньUpDown.Text = "Перша";
            // 
            // EditPsycho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(684, 703);
            this.Controls.Add(this.лікарська_ступіньUpDown);
            this.Controls.Add(this.статьUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SkipButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.iD_ПсихологаTextBox);
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
            this.Controls.Add(роки_кваліфікаціїLabel);
            this.Controls.Add(this.роки_кваліфікаціїTextBox);
            this.Controls.Add(лікарська_ступіньLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditPsycho";
            this.Text = "EditPsycho";
            this.Load += new System.EventHandler(this.EditPsycho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private mydbDataSet mydbDataSet;
        private System.Windows.Forms.TextBox iD_ПсихологаTextBox;
        private System.Windows.Forms.TextBox прізвищеTextBox;
        private System.Windows.Forms.TextBox ім_яTextBox;
        private System.Windows.Forms.TextBox по_батьковіTextBox;
        private System.Windows.Forms.DateTimePicker дата_народженняDateTimePicker;
        private System.Windows.Forms.TextBox телефонTextBox;
        private System.Windows.Forms.TextBox поштаTextBox;
        private System.Windows.Forms.TextBox роки_кваліфікаціїTextBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button SkipButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DomainUpDown статьUpDown;
        private System.Windows.Forms.DomainUpDown лікарська_ступіньUpDown;
    }
}