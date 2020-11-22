namespace LastHope.DealingWithTables
{
    partial class DeleteForm
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
            System.Windows.Forms.Button YesButt;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteForm));
            this.NoButtButton = new System.Windows.Forms.Button();
            this.TableLabel = new System.Windows.Forms.Label();
            YesButt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NoButtButton
            // 
            this.NoButtButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(19)))), ((int)(((byte)(35)))));
            this.NoButtButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NoButtButton.FlatAppearance.BorderColor = System.Drawing.Color.SeaShell;
            this.NoButtButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NoButtButton.Font = new System.Drawing.Font("Corbel", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NoButtButton.ForeColor = System.Drawing.Color.SeaShell;
            this.NoButtButton.Location = new System.Drawing.Point(22, 127);
            this.NoButtButton.Name = "NoButtButton";
            this.NoButtButton.Size = new System.Drawing.Size(166, 82);
            this.NoButtButton.TabIndex = 16;
            this.NoButtButton.Text = "Ні";
            this.NoButtButton.UseVisualStyleBackColor = false;
            this.NoButtButton.Click += new System.EventHandler(this.NoButtButton_Click);
            // 
            // YesButt
            // 
            YesButt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(19)))), ((int)(((byte)(35)))));
            YesButt.Cursor = System.Windows.Forms.Cursors.Hand;
            YesButt.FlatAppearance.BorderColor = System.Drawing.Color.SeaShell;
            YesButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            YesButt.Font = new System.Drawing.Font("Corbel", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            YesButt.ForeColor = System.Drawing.Color.SeaShell;
            YesButt.Location = new System.Drawing.Point(240, 127);
            YesButt.Name = "YesButt";
            YesButt.Size = new System.Drawing.Size(166, 82);
            YesButt.TabIndex = 17;
            YesButt.Text = "Так";
            YesButt.UseVisualStyleBackColor = false;
            YesButt.Click += new System.EventHandler(this.YesButt_Click);
            // 
            // TableLabel
            // 
            this.TableLabel.AutoSize = true;
            this.TableLabel.Font = new System.Drawing.Font("Corbel", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TableLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(19)))), ((int)(((byte)(35)))));
            this.TableLabel.Location = new System.Drawing.Point(37, 20);
            this.TableLabel.Name = "TableLabel";
            this.TableLabel.Size = new System.Drawing.Size(369, 58);
            this.TableLabel.TabIndex = 18;
            this.TableLabel.Text = "Чи справді Ви хочете видалити \r\nцей елемент?";
            this.TableLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // DeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(418, 221);
            this.Controls.Add(this.TableLabel);
            this.Controls.Add(YesButt);
            this.Controls.Add(this.NoButtButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeleteForm";
            this.Text = "DeleteForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NoButtButton;
        private System.Windows.Forms.Label TableLabel;
    }
}