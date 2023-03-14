
namespace WinFormsServiceStationApp.Views.Forms
{
    partial class ReportJournalForm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource7 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.WorkOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.WorkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.WorkOrderWorkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OwnerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.WorkerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.WorkOrderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkOrderWorkBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OwnerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Journal";
            reportDataSource1.Value = this.WorkOrderBindingSource;
            reportDataSource2.Name = "Work";
            reportDataSource2.Value = this.WorkBindingSource;
            reportDataSource3.Name = "JW";
            reportDataSource3.Value = this.WorkOrderWorkBindingSource;
            reportDataSource4.Name = "Owner";
            reportDataSource4.Value = this.OwnerBindingSource;
            reportDataSource5.Name = "Car";
            reportDataSource5.Value = this.CarBindingSource;
            reportDataSource6.Name = "WorkerAccepter";
            reportDataSource6.Value = this.WorkerBindingSource;
            reportDataSource7.Name = "WorkerMaster";
            reportDataSource7.Value = this.WorkerBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource7);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WinFormsServiceStationApp.Views.Forms.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // WorkOrderBindingSource
            // 
            this.WorkOrderBindingSource.DataSource = typeof(WinFormsServiceStationApp.Models.WorkOrder);
            // 
            // WorkBindingSource
            // 
            this.WorkBindingSource.DataSource = typeof(WinFormsServiceStationApp.Models.Work);
            // 
            // WorkOrderWorkBindingSource
            // 
            this.WorkOrderWorkBindingSource.DataSource = typeof(WinFormsServiceStationApp.Models.WorkOrderWork);
            // 
            // OwnerBindingSource
            // 
            this.OwnerBindingSource.DataSource = typeof(WinFormsServiceStationApp.Models.Owner);
            // 
            // CarBindingSource
            // 
            this.CarBindingSource.DataSource = typeof(WinFormsServiceStationApp.Models.Car);
            // 
            // WorkerBindingSource
            // 
            this.WorkerBindingSource.DataSource = typeof(WinFormsServiceStationApp.Models.Worker);
            // 
            // ErrForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ErrForm1";
            this.Text = "ErrForm1";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WorkOrderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkOrderWorkBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OwnerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource WorkOrderBindingSource;
        private System.Windows.Forms.BindingSource WorkBindingSource;
        private System.Windows.Forms.BindingSource WorkOrderWorkBindingSource;
        private System.Windows.Forms.BindingSource OwnerBindingSource;
        private System.Windows.Forms.BindingSource CarBindingSource;
        private System.Windows.Forms.BindingSource WorkerBindingSource;
    }
}