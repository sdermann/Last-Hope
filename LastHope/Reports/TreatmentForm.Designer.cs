namespace LastHope
{
    partial class TreatmentForm
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PrintButt = new System.Windows.Forms.Button();
            this.new_view2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mydbDataSet = new LastHope.mydbDataSet();
            this.new_view2TableAdapter = new LastHope.mydbDataSetTableAdapters.new_view2TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.new_view2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.Silver;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.new_view2BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "LastHope.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(684, 703);
            this.reportViewer1.TabIndex = 5;
            // 
            // PrintButt
            // 
            this.PrintButt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PrintButt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(147)))), ((int)(((byte)(126)))));
            this.PrintButt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PrintButt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PrintButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintButt.Font = new System.Drawing.Font("Corbel", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PrintButt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.PrintButt.Location = new System.Drawing.Point(236, 488);
            this.PrintButt.Name = "PrintButt";
            this.PrintButt.Size = new System.Drawing.Size(141, 41);
            this.PrintButt.TabIndex = 6;
            this.PrintButt.Text = "Зберегти в PDF";
            this.PrintButt.UseVisualStyleBackColor = false;
            this.PrintButt.Click += new System.EventHandler(this.PrintButt_Click);
            // 
            // new_view2BindingSource
            // 
            this.new_view2BindingSource.DataMember = "new_view2";
            this.new_view2BindingSource.DataSource = this.mydbDataSet;
            // 
            // mydbDataSet
            // 
            this.mydbDataSet.DataSetName = "mydbDataSet";
            this.mydbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // new_view2TableAdapter
            // 
            this.new_view2TableAdapter.ClearBeforeFill = true;
            // 
            // TreatmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(684, 703);
            this.Controls.Add(this.PrintButt);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TreatmentForm";
            this.Text = "TreatmentForm";
            this.Load += new System.EventHandler(this.TreatmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.new_view2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource new_view2BindingSource;
        private mydbDataSet mydbDataSet;
        private mydbDataSetTableAdapters.new_view2TableAdapter new_view2TableAdapter;
        private System.Windows.Forms.Button PrintButt;
    }
}