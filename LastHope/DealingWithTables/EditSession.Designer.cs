namespace LastHope.DealingWithTables
{
    partial class EditSession
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
            System.Windows.Forms.Label iD_Психолога2Label;
            System.Windows.Forms.Label iD_Клієнта2Label;
            System.Windows.Forms.Label датаLabel;
            System.Windows.Forms.Label початок_сесіїLabel;
            System.Windows.Forms.Label кінець_сесіїLabel;
            System.Windows.Forms.Label результатLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.датаDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.mydbDataSet = new LastHope.mydbDataSet();
            this.PsychoUpDown = new System.Windows.Forms.DomainUpDown();
            this.clientUpDown = new System.Windows.Forms.DomainUpDown();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SkipButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.begSessionUpDown = new System.Windows.Forms.DomainUpDown();
            this.EndSessionUpDown = new System.Windows.Forms.DomainUpDown();
            this.ResultUpDown = new System.Windows.Forms.DomainUpDown();
            this.id_СесіїTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.psText = new System.Windows.Forms.TextBox();
            this.clText = new System.Windows.Forms.TextBox();
            this.dateText = new System.Windows.Forms.TextBox();
            iD_Психолога2Label = new System.Windows.Forms.Label();
            iD_Клієнта2Label = new System.Windows.Forms.Label();
            датаLabel = new System.Windows.Forms.Label();
            початок_сесіїLabel = new System.Windows.Forms.Label();
            кінець_сесіїLabel = new System.Windows.Forms.Label();
            результатLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_Психолога2Label
            // 
            iD_Психолога2Label.AutoSize = true;
            iD_Психолога2Label.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            iD_Психолога2Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(19)))), ((int)(((byte)(35)))));
            iD_Психолога2Label.Location = new System.Drawing.Point(101, 164);
            iD_Психолога2Label.Name = "iD_Психолога2Label";
            iD_Психолога2Label.Size = new System.Drawing.Size(99, 24);
            iD_Психолога2Label.TabIndex = 3;
            iD_Психолога2Label.Text = "Психолог:";
            // 
            // iD_Клієнта2Label
            // 
            iD_Клієнта2Label.AutoSize = true;
            iD_Клієнта2Label.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            iD_Клієнта2Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(19)))), ((int)(((byte)(35)))));
            iD_Клієнта2Label.Location = new System.Drawing.Point(101, 192);
            iD_Клієнта2Label.Name = "iD_Клієнта2Label";
            iD_Клієнта2Label.Size = new System.Drawing.Size(80, 24);
            iD_Клієнта2Label.TabIndex = 5;
            iD_Клієнта2Label.Text = "Клієнт:";
            // 
            // датаLabel
            // 
            датаLabel.AutoSize = true;
            датаLabel.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            датаLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(19)))), ((int)(((byte)(35)))));
            датаLabel.Location = new System.Drawing.Point(101, 221);
            датаLabel.Name = "датаLabel";
            датаLabel.Size = new System.Drawing.Size(69, 24);
            датаLabel.TabIndex = 7;
            датаLabel.Text = "Дата:";
            // 
            // початок_сесіїLabel
            // 
            початок_сесіїLabel.AutoSize = true;
            початок_сесіїLabel.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            початок_сесіїLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(19)))), ((int)(((byte)(35)))));
            початок_сесіїLabel.Location = new System.Drawing.Point(101, 248);
            початок_сесіїLabel.Name = "початок_сесіїLabel";
            початок_сесіїLabel.Size = new System.Drawing.Size(138, 24);
            початок_сесіїLabel.TabIndex = 9;
            початок_сесіїLabel.Text = "Початок сесії:";
            // 
            // кінець_сесіїLabel
            // 
            кінець_сесіїLabel.AutoSize = true;
            кінець_сесіїLabel.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            кінець_сесіїLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(19)))), ((int)(((byte)(35)))));
            кінець_сесіїLabel.Location = new System.Drawing.Point(101, 276);
            кінець_сесіїLabel.Name = "кінець_сесіїLabel";
            кінець_сесіїLabel.Size = new System.Drawing.Size(118, 24);
            кінець_сесіїLabel.TabIndex = 11;
            кінець_сесіїLabel.Text = "Кінець сесії:";
            // 
            // результатLabel
            // 
            результатLabel.AutoSize = true;
            результатLabel.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            результатLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(19)))), ((int)(((byte)(35)))));
            результатLabel.Location = new System.Drawing.Point(101, 304);
            результатLabel.Name = "результатLabel";
            результатLabel.Size = new System.Drawing.Size(120, 24);
            результатLabel.TabIndex = 13;
            результатLabel.Text = "Результат:";
            // 
            // датаDateTimePicker
            // 
            this.датаDateTimePicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.датаDateTimePicker.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.датаDateTimePicker.Location = new System.Drawing.Point(293, 212);
            this.датаDateTimePicker.Name = "датаDateTimePicker";
            this.датаDateTimePicker.Size = new System.Drawing.Size(241, 32);
            this.датаDateTimePicker.TabIndex = 8;
            this.датаDateTimePicker.ValueChanged += new System.EventHandler(this.датаDateTimePicker_ValueChanged);
            // 
            // mydbDataSet
            // 
            this.mydbDataSet.DataSetName = "mydbDataSet";
            this.mydbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PsychoUpDown
            // 
            this.PsychoUpDown.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.PsychoUpDown.Location = new System.Drawing.Point(293, 156);
            this.PsychoUpDown.Name = "PsychoUpDown";
            this.PsychoUpDown.ReadOnly = true;
            this.PsychoUpDown.Size = new System.Drawing.Size(241, 32);
            this.PsychoUpDown.TabIndex = 15;
            this.PsychoUpDown.Text = "Оберіть психолога";
            // 
            // clientUpDown
            // 
            this.clientUpDown.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.clientUpDown.Location = new System.Drawing.Point(293, 187);
            this.clientUpDown.Name = "clientUpDown";
            this.clientUpDown.ReadOnly = true;
            this.clientUpDown.Size = new System.Drawing.Size(241, 32);
            this.clientUpDown.TabIndex = 16;
            this.clientUpDown.Text = "Оберіть клієнта";
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(147)))), ((int)(((byte)(126)))));
            this.SaveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveButton.FlatAppearance.BorderColor = System.Drawing.Color.SeaShell;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveButton.ForeColor = System.Drawing.Color.SeaShell;
            this.SaveButton.Location = new System.Drawing.Point(73, 579);
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
            this.SkipButton.Location = new System.Drawing.Point(398, 579);
            this.SkipButton.Name = "SkipButton";
            this.SkipButton.Size = new System.Drawing.Size(204, 80);
            this.SkipButton.TabIndex = 27;
            this.SkipButton.Text = "Повернутися до таблиць";
            this.SkipButton.UseVisualStyleBackColor = false;
            this.SkipButton.Click += new System.EventHandler(this.SkipButton_Click);
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
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(147)))), ((int)(((byte)(126)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(30, 381);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(642, 43);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.Visible = false;
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
            this.dataGridView2.Location = new System.Drawing.Point(30, 430);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(642, 41);
            this.dataGridView2.TabIndex = 29;
            this.dataGridView2.Visible = false;
            // 
            // begSessionUpDown
            // 
            this.begSessionUpDown.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.begSessionUpDown.Items.Add("09:00:00");
            this.begSessionUpDown.Items.Add("10:00:00");
            this.begSessionUpDown.Items.Add("11:00:00");
            this.begSessionUpDown.Items.Add("12:00:00");
            this.begSessionUpDown.Items.Add("13:00:00");
            this.begSessionUpDown.Items.Add("14:00:00");
            this.begSessionUpDown.Items.Add("15:00:00");
            this.begSessionUpDown.Items.Add("16:00:00");
            this.begSessionUpDown.Items.Add("17:00:00");
            this.begSessionUpDown.Items.Add("18:00:00");
            this.begSessionUpDown.Location = new System.Drawing.Point(293, 238);
            this.begSessionUpDown.Name = "begSessionUpDown";
            this.begSessionUpDown.ReadOnly = true;
            this.begSessionUpDown.Size = new System.Drawing.Size(241, 32);
            this.begSessionUpDown.TabIndex = 30;
            this.begSessionUpDown.Text = "Оберіть час";
            // 
            // EndSessionUpDown
            // 
            this.EndSessionUpDown.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.EndSessionUpDown.Items.Add("10:00:00");
            this.EndSessionUpDown.Items.Add("11:00:00");
            this.EndSessionUpDown.Items.Add("12:00:00");
            this.EndSessionUpDown.Items.Add("13:00:00");
            this.EndSessionUpDown.Items.Add("14:00:00");
            this.EndSessionUpDown.Items.Add("15:00:00");
            this.EndSessionUpDown.Items.Add("16:00:00");
            this.EndSessionUpDown.Items.Add("17:00:00");
            this.EndSessionUpDown.Items.Add("18:00:00");
            this.EndSessionUpDown.Items.Add("19:00:00");
            this.EndSessionUpDown.Location = new System.Drawing.Point(293, 266);
            this.EndSessionUpDown.Name = "EndSessionUpDown";
            this.EndSessionUpDown.ReadOnly = true;
            this.EndSessionUpDown.Size = new System.Drawing.Size(241, 32);
            this.EndSessionUpDown.TabIndex = 31;
            this.EndSessionUpDown.Text = "Оберіть час";
            // 
            // ResultUpDown
            // 
            this.ResultUpDown.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ResultUpDown.Location = new System.Drawing.Point(293, 294);
            this.ResultUpDown.Name = "ResultUpDown";
            this.ResultUpDown.ReadOnly = true;
            this.ResultUpDown.Size = new System.Drawing.Size(241, 32);
            this.ResultUpDown.TabIndex = 32;
            this.ResultUpDown.Text = "Вкажіть результат ";
            // 
            // id_СесіїTextBox
            // 
            this.id_СесіїTextBox.BackColor = System.Drawing.Color.Silver;
            this.id_СесіїTextBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.id_СесіїTextBox.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.id_СесіїTextBox.Location = new System.Drawing.Point(293, 128);
            this.id_СесіїTextBox.Name = "id_СесіїTextBox";
            this.id_СесіїTextBox.ReadOnly = true;
            this.id_СесіїTextBox.Size = new System.Drawing.Size(241, 32);
            this.id_СесіїTextBox.TabIndex = 2;
            this.id_СесіїTextBox.WordWrap = false;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView3.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(185)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Corbel", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(19)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView3.ColumnHeadersHeight = 29;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(19)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Corbel", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(147)))), ((int)(((byte)(126)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView3.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView3.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView3.Location = new System.Drawing.Point(30, 477);
            this.dataGridView3.MultiSelect = false;
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(642, 42);
            this.dataGridView3.TabIndex = 33;
            this.dataGridView3.Visible = false;
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(185)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Corbel", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(19)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView4.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView4.ColumnHeadersHeight = 29;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(19)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Corbel", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(147)))), ((int)(((byte)(126)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView4.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView4.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView4.Location = new System.Drawing.Point(30, 525);
            this.dataGridView4.MultiSelect = false;
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView4.Size = new System.Drawing.Size(642, 42);
            this.dataGridView4.TabIndex = 34;
            this.dataGridView4.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(19)))), ((int)(((byte)(35)))));
            this.label2.Location = new System.Drawing.Point(101, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 24);
            this.label2.TabIndex = 49;
            this.label2.Text = "Id Сесії::";
            // 
            // psText
            // 
            this.psText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.psText.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.psText.Location = new System.Drawing.Point(293, 158);
            this.psText.MaxLength = 30;
            this.psText.Name = "psText";
            this.psText.ReadOnly = true;
            this.psText.Size = new System.Drawing.Size(241, 32);
            this.psText.TabIndex = 50;
            // 
            // clText
            // 
            this.clText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clText.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clText.Location = new System.Drawing.Point(293, 187);
            this.clText.MaxLength = 30;
            this.clText.Name = "clText";
            this.clText.ReadOnly = true;
            this.clText.Size = new System.Drawing.Size(241, 32);
            this.clText.TabIndex = 51;
            // 
            // dateText
            // 
            this.dateText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateText.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateText.Location = new System.Drawing.Point(293, 214);
            this.dateText.MaxLength = 30;
            this.dateText.Name = "dateText";
            this.dateText.ReadOnly = true;
            this.dateText.Size = new System.Drawing.Size(241, 32);
            this.dateText.TabIndex = 52;
            // 
            // EditSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(684, 703);
            this.Controls.Add(this.psText);
            this.Controls.Add(this.clText);
            this.Controls.Add(this.dateText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.ResultUpDown);
            this.Controls.Add(this.EndSessionUpDown);
            this.Controls.Add(this.begSessionUpDown);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SkipButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.clientUpDown);
            this.Controls.Add(this.PsychoUpDown);
            this.Controls.Add(this.id_СесіїTextBox);
            this.Controls.Add(iD_Психолога2Label);
            this.Controls.Add(iD_Клієнта2Label);
            this.Controls.Add(датаLabel);
            this.Controls.Add(this.датаDateTimePicker);
            this.Controls.Add(початок_сесіїLabel);
            this.Controls.Add(кінець_сесіїLabel);
            this.Controls.Add(результатLabel);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditSession";
            this.Text = "EditSchedule";
            this.Load += new System.EventHandler(this.EditSession_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker датаDateTimePicker;
        private mydbDataSet mydbDataSet;
        private System.Windows.Forms.DomainUpDown PsychoUpDown;
        private System.Windows.Forms.DomainUpDown clientUpDown;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button SkipButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DomainUpDown begSessionUpDown;
        private System.Windows.Forms.DomainUpDown EndSessionUpDown;
        private System.Windows.Forms.DomainUpDown ResultUpDown;
        private System.Windows.Forms.TextBox id_СесіїTextBox;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox psText;
        private System.Windows.Forms.TextBox clText;
        private System.Windows.Forms.TextBox dateText;
    }
}