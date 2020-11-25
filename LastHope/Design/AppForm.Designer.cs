namespace LastHope
{
    partial class AppForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppForm));
            this.SidePanel = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SQLButton = new System.Windows.Forms.Button();
            this.NewClientButton = new System.Windows.Forms.Button();
            this.StatisticsPanel = new System.Windows.Forms.Panel();
            this.AverageButton = new System.Windows.Forms.Button();
            this.AttendanceButton = new System.Windows.Forms.Button();
            this.FrequencyButton = new System.Windows.Forms.Button();
            this.RiskButton = new System.Windows.Forms.Button();
            this.StatisticsName = new System.Windows.Forms.Button();
            this.ReportsPanel = new System.Windows.Forms.Panel();
            this.TreatmentButton = new System.Windows.Forms.Button();
            this.AmbulanceButton = new System.Windows.Forms.Button();
            this.ReportsButton = new System.Windows.Forms.Button();
            this.MainButton = new System.Windows.Forms.Button();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ChildFormPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.SidePanel.SuspendLayout();
            this.StatisticsPanel.SuspendLayout();
            this.ReportsPanel.SuspendLayout();
            this.LogoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ChildFormPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SidePanel
            // 
            this.SidePanel.AutoScroll = true;
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(19)))), ((int)(((byte)(35)))));
            this.SidePanel.Controls.Add(this.ExitButton);
            this.SidePanel.Controls.Add(this.SQLButton);
            this.SidePanel.Controls.Add(this.NewClientButton);
            this.SidePanel.Controls.Add(this.StatisticsPanel);
            this.SidePanel.Controls.Add(this.StatisticsName);
            this.SidePanel.Controls.Add(this.ReportsPanel);
            this.SidePanel.Controls.Add(this.ReportsButton);
            this.SidePanel.Controls.Add(this.MainButton);
            this.SidePanel.Controls.Add(this.LogoPanel);
            this.SidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePanel.Location = new System.Drawing.Point(0, 0);
            this.SidePanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(298, 703);
            this.SidePanel.TabIndex = 0;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(19)))), ((int)(((byte)(35)))));
            this.ExitButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Location = new System.Drawing.Point(0, 750);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.ExitButton.Size = new System.Drawing.Size(277, 60);
            this.ExitButton.TabIndex = 7;
            this.ExitButton.Text = "Вихід";
            this.ExitButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // SQLButton
            // 
            this.SQLButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(19)))), ((int)(((byte)(35)))));
            this.SQLButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.SQLButton.FlatAppearance.BorderSize = 0;
            this.SQLButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SQLButton.Location = new System.Drawing.Point(0, 690);
            this.SQLButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SQLButton.Name = "SQLButton";
            this.SQLButton.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.SQLButton.Size = new System.Drawing.Size(277, 60);
            this.SQLButton.TabIndex = 6;
            this.SQLButton.Text = "SQL";
            this.SQLButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SQLButton.UseVisualStyleBackColor = false;
            this.SQLButton.Click += new System.EventHandler(this.SQLButton_Click);
            // 
            // NewClientButton
            // 
            this.NewClientButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(19)))), ((int)(((byte)(35)))));
            this.NewClientButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.NewClientButton.FlatAppearance.BorderSize = 0;
            this.NewClientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewClientButton.Location = new System.Drawing.Point(0, 630);
            this.NewClientButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NewClientButton.Name = "NewClientButton";
            this.NewClientButton.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.NewClientButton.Size = new System.Drawing.Size(277, 60);
            this.NewClientButton.TabIndex = 5;
            this.NewClientButton.Text = "Новий клієнт";
            this.NewClientButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NewClientButton.UseVisualStyleBackColor = false;
            this.NewClientButton.Click += new System.EventHandler(this.NewClientButton_Click);
            // 
            // StatisticsPanel
            // 
            this.StatisticsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(46)))), ((int)(((byte)(72)))));
            this.StatisticsPanel.Controls.Add(this.AverageButton);
            this.StatisticsPanel.Controls.Add(this.AttendanceButton);
            this.StatisticsPanel.Controls.Add(this.FrequencyButton);
            this.StatisticsPanel.Controls.Add(this.RiskButton);
            this.StatisticsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.StatisticsPanel.Location = new System.Drawing.Point(0, 422);
            this.StatisticsPanel.Name = "StatisticsPanel";
            this.StatisticsPanel.Size = new System.Drawing.Size(277, 208);
            this.StatisticsPanel.TabIndex = 4;
            // 
            // AverageButton
            // 
            this.AverageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(46)))), ((int)(((byte)(72)))));
            this.AverageButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AverageButton.FlatAppearance.BorderSize = 0;
            this.AverageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AverageButton.Location = new System.Drawing.Point(0, 150);
            this.AverageButton.Name = "AverageButton";
            this.AverageButton.Padding = new System.Windows.Forms.Padding(44, 0, 0, 0);
            this.AverageButton.Size = new System.Drawing.Size(277, 50);
            this.AverageButton.TabIndex = 5;
            this.AverageButton.Text = "Середня довжина сесій";
            this.AverageButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AverageButton.UseVisualStyleBackColor = false;
            this.AverageButton.Click += new System.EventHandler(this.AverageButton_Click);
            // 
            // AttendanceButton
            // 
            this.AttendanceButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(46)))), ((int)(((byte)(72)))));
            this.AttendanceButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AttendanceButton.FlatAppearance.BorderSize = 0;
            this.AttendanceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AttendanceButton.Location = new System.Drawing.Point(0, 100);
            this.AttendanceButton.Name = "AttendanceButton";
            this.AttendanceButton.Padding = new System.Windows.Forms.Padding(44, 0, 0, 0);
            this.AttendanceButton.Size = new System.Drawing.Size(277, 50);
            this.AttendanceButton.TabIndex = 4;
            this.AttendanceButton.Text = "Відвідування клієнта";
            this.AttendanceButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AttendanceButton.UseVisualStyleBackColor = false;
            this.AttendanceButton.Click += new System.EventHandler(this.AttendanceButton_Click);
            // 
            // FrequencyButton
            // 
            this.FrequencyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(46)))), ((int)(((byte)(72)))));
            this.FrequencyButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.FrequencyButton.FlatAppearance.BorderSize = 0;
            this.FrequencyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FrequencyButton.Location = new System.Drawing.Point(0, 50);
            this.FrequencyButton.Name = "FrequencyButton";
            this.FrequencyButton.Padding = new System.Windows.Forms.Padding(44, 0, 0, 0);
            this.FrequencyButton.Size = new System.Drawing.Size(277, 50);
            this.FrequencyButton.TabIndex = 3;
            this.FrequencyButton.Text = "Частота роботи психолога";
            this.FrequencyButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FrequencyButton.UseVisualStyleBackColor = false;
            this.FrequencyButton.Click += new System.EventHandler(this.FrequencyButton_Click);
            // 
            // RiskButton
            // 
            this.RiskButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(46)))), ((int)(((byte)(72)))));
            this.RiskButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.RiskButton.FlatAppearance.BorderSize = 0;
            this.RiskButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RiskButton.Location = new System.Drawing.Point(0, 0);
            this.RiskButton.Name = "RiskButton";
            this.RiskButton.Padding = new System.Windows.Forms.Padding(44, 0, 0, 0);
            this.RiskButton.Size = new System.Drawing.Size(277, 50);
            this.RiskButton.TabIndex = 1;
            this.RiskButton.Text = "Ризик захворюванності";
            this.RiskButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RiskButton.UseVisualStyleBackColor = false;
            this.RiskButton.Click += new System.EventHandler(this.RiskButton_Click);
            // 
            // StatisticsName
            // 
            this.StatisticsName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(19)))), ((int)(((byte)(35)))));
            this.StatisticsName.Dock = System.Windows.Forms.DockStyle.Top;
            this.StatisticsName.FlatAppearance.BorderSize = 0;
            this.StatisticsName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StatisticsName.Location = new System.Drawing.Point(0, 362);
            this.StatisticsName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.StatisticsName.Name = "StatisticsName";
            this.StatisticsName.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.StatisticsName.Size = new System.Drawing.Size(277, 60);
            this.StatisticsName.TabIndex = 3;
            this.StatisticsName.Text = "Статистика ↓";
            this.StatisticsName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StatisticsName.UseVisualStyleBackColor = false;
            this.StatisticsName.Click += new System.EventHandler(this.StatisticsName_Click);
            // 
            // ReportsPanel
            // 
            this.ReportsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(46)))), ((int)(((byte)(72)))));
            this.ReportsPanel.Controls.Add(this.TreatmentButton);
            this.ReportsPanel.Controls.Add(this.AmbulanceButton);
            this.ReportsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ReportsPanel.Location = new System.Drawing.Point(0, 253);
            this.ReportsPanel.Name = "ReportsPanel";
            this.ReportsPanel.Size = new System.Drawing.Size(277, 109);
            this.ReportsPanel.TabIndex = 1;
            // 
            // TreatmentButton
            // 
            this.TreatmentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(46)))), ((int)(((byte)(72)))));
            this.TreatmentButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.TreatmentButton.FlatAppearance.BorderSize = 0;
            this.TreatmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TreatmentButton.Location = new System.Drawing.Point(0, 50);
            this.TreatmentButton.Name = "TreatmentButton";
            this.TreatmentButton.Padding = new System.Windows.Forms.Padding(44, 0, 0, 0);
            this.TreatmentButton.Size = new System.Drawing.Size(277, 50);
            this.TreatmentButton.TabIndex = 2;
            this.TreatmentButton.Text = "Ефективність лікування";
            this.TreatmentButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TreatmentButton.UseVisualStyleBackColor = false;
            this.TreatmentButton.Click += new System.EventHandler(this.TreatmentButton_Click);
            // 
            // AmbulanceButton
            // 
            this.AmbulanceButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(46)))), ((int)(((byte)(72)))));
            this.AmbulanceButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AmbulanceButton.FlatAppearance.BorderSize = 0;
            this.AmbulanceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AmbulanceButton.Location = new System.Drawing.Point(0, 0);
            this.AmbulanceButton.Name = "AmbulanceButton";
            this.AmbulanceButton.Padding = new System.Windows.Forms.Padding(44, 0, 0, 0);
            this.AmbulanceButton.Size = new System.Drawing.Size(277, 50);
            this.AmbulanceButton.TabIndex = 1;
            this.AmbulanceButton.Text = "Амбулаторна карта клієнта";
            this.AmbulanceButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AmbulanceButton.UseVisualStyleBackColor = false;
            this.AmbulanceButton.Click += new System.EventHandler(this.AmbulanceButton_Click);
            // 
            // ReportsButton
            // 
            this.ReportsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(19)))), ((int)(((byte)(35)))));
            this.ReportsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ReportsButton.FlatAppearance.BorderSize = 0;
            this.ReportsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReportsButton.Location = new System.Drawing.Point(0, 193);
            this.ReportsButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ReportsButton.Name = "ReportsButton";
            this.ReportsButton.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.ReportsButton.Size = new System.Drawing.Size(277, 60);
            this.ReportsButton.TabIndex = 2;
            this.ReportsButton.Text = "Звіти ↓";
            this.ReportsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReportsButton.UseVisualStyleBackColor = false;
            this.ReportsButton.Click += new System.EventHandler(this.ReportsButton_Click);
            // 
            // MainButton
            // 
            this.MainButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(19)))), ((int)(((byte)(35)))));
            this.MainButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainButton.FlatAppearance.BorderSize = 0;
            this.MainButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainButton.Location = new System.Drawing.Point(0, 123);
            this.MainButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MainButton.Name = "MainButton";
            this.MainButton.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.MainButton.Size = new System.Drawing.Size(277, 70);
            this.MainButton.TabIndex = 1;
            this.MainButton.Text = "Головна сторінка";
            this.MainButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MainButton.UseVisualStyleBackColor = false;
            this.MainButton.Click += new System.EventHandler(this.MainButton_Click);
            // 
            // LogoPanel
            // 
            this.LogoPanel.Controls.Add(this.pictureBox1);
            this.LogoPanel.Controls.Add(this.label1);
            this.LogoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoPanel.Location = new System.Drawing.Point(0, 0);
            this.LogoPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(277, 123);
            this.LogoPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(204, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 74);
            this.label1.TabIndex = 0;
            this.label1.Text = "Приватна клініка\r\n\"Last Hope\"";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ChildFormPanel
            // 
            this.ChildFormPanel.Controls.Add(this.label2);
            this.ChildFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChildFormPanel.Location = new System.Drawing.Point(298, 0);
            this.ChildFormPanel.Name = "ChildFormPanel";
            this.ChildFormPanel.Size = new System.Drawing.Size(684, 703);
            this.ChildFormPanel.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            this.label2.TextChanged += new System.EventHandler(this.label2_TextChanged);
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(185)))), ((int)(((byte)(146)))));
            this.ClientSize = new System.Drawing.Size(982, 703);
            this.Controls.Add(this.ChildFormPanel);
            this.Controls.Add(this.SidePanel);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "AppForm";
            this.Text = "LastHope";
            this.SidePanel.ResumeLayout(false);
            this.StatisticsPanel.ResumeLayout(false);
            this.ReportsPanel.ResumeLayout(false);
            this.LogoPanel.ResumeLayout(false);
            this.LogoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ChildFormPanel.ResumeLayout(false);
            this.ChildFormPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Panel StatisticsPanel;
        private System.Windows.Forms.Button RiskButton;
        private System.Windows.Forms.Button StatisticsName;
        private System.Windows.Forms.Panel ReportsPanel;
        private System.Windows.Forms.Button AmbulanceButton;
        private System.Windows.Forms.Button ReportsButton;
        private System.Windows.Forms.Button MainButton;
        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SQLButton;
        private System.Windows.Forms.Button NewClientButton;
        private System.Windows.Forms.Button FrequencyButton;
        private System.Windows.Forms.Button TreatmentButton;
        private System.Windows.Forms.Button AverageButton;
        private System.Windows.Forms.Button AttendanceButton;
        private System.Windows.Forms.Panel ChildFormPanel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label label2;
    }
}

