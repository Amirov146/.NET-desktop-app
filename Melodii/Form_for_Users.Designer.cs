namespace Melodii
{
    partial class Form_for_Users
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_for_Users));
            this.MelodiiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.melodiiDataSet1 = new Melodii.melodiiDataSet1();
            this.IntervievatiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.melodiiDataSet2 = new Melodii.melodiiDataSet2();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.MelodiiTableAdapter = new Melodii.melodiiDataSet1TableAdapters.MelodiiTableAdapter();
            this.IntervievatiTableAdapter = new Melodii.melodiiDataSet2TableAdapters.IntervievatiTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.MelodiiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.melodiiDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntervievatiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.melodiiDataSet2)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // MelodiiBindingSource
            // 
            this.MelodiiBindingSource.DataMember = "Melodii";
            this.MelodiiBindingSource.DataSource = this.melodiiDataSet1;
            // 
            // melodiiDataSet1
            // 
            this.melodiiDataSet1.DataSetName = "melodiiDataSet1";
            this.melodiiDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // IntervievatiBindingSource
            // 
            this.IntervievatiBindingSource.DataMember = "Intervievati";
            this.IntervievatiBindingSource.DataSource = this.melodiiDataSet2;
            // 
            // melodiiDataSet2
            // 
            this.melodiiDataSet2.DataSetName = "melodiiDataSet2";
            this.melodiiDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1004, 519);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.reportViewer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(996, 484);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Melodii";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.MelodiiBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Melodii.Melodii_Report.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(993, 475);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.reportViewer2);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(996, 484);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Intervievați";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.reportViewer3);
            this.tabPage3.Location = new System.Drawing.Point(4, 31);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(996, 484);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Intervievați mai mici de 18 ani";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // reportViewer3
            // 
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.IntervievatiBindingSource;
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "Melodii.Report_minori.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(0, 0);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.ServerReport.BearerToken = null;
            this.reportViewer3.Size = new System.Drawing.Size(1000, 481);
            this.reportViewer3.TabIndex = 0;
            // 
            // MelodiiTableAdapter
            // 
            this.MelodiiTableAdapter.ClearBeforeFill = true;
            // 
            // IntervievatiTableAdapter
            // 
            this.IntervievatiTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(815, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "Înapoi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // reportViewer2
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.IntervievatiBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "Melodii.Report_Intervievati.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(3, 0);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(990, 481);
            this.reportViewer2.TabIndex = 2;
            // 
            // Form_for_Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 543);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_for_Users";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_for_Users";
            this.Load += new System.EventHandler(this.Form_for_Users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MelodiiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.melodiiDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntervievatiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.melodiiDataSet2)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.BindingSource MelodiiBindingSource;
        private melodiiDataSet1 melodiiDataSet1;
        private melodiiDataSet1TableAdapters.MelodiiTableAdapter MelodiiTableAdapter;
        private System.Windows.Forms.BindingSource IntervievatiBindingSource;
        private melodiiDataSet2 melodiiDataSet2;
        private melodiiDataSet2TableAdapters.IntervievatiTableAdapter IntervievatiTableAdapter;
        private System.Windows.Forms.TabPage tabPage3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private System.Windows.Forms.Button button1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
    }
}