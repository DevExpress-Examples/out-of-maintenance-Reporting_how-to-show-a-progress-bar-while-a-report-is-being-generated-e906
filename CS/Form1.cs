using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrinting.Native;
using DevExpress.XtraReports.UI;


namespace ShowProgressReflector {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            XtraReport1 report = new XtraReport1();
            report.TotalRowCount.Value = 100000;
            ShowPreview(report);
        }

        static void ShowPreview(XtraReport report) {
            // Create a form to show a progress bar,
            // and adjust its properties.
            Form form = new Form();
            form.FormBorderStyle = FormBorderStyle.None;
            form.Size = new System.Drawing.Size(300, 25);
            form.ShowInTaskbar = false;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.TopMost = true;

            // Create a ProgressBar along with its ReflectorBar.
            ProgressBarControl progressBar = new ProgressBarControl();
            ReflectorBar reflectorBar = new ReflectorBar(progressBar);

            // Add a progress bar to a form and show it.
            form.Controls.Add(progressBar);
            progressBar.Dock = DockStyle.Fill;
            form.Show();

            try {
                // Register the reflector bar, so that it reflects
                // the state of a ProgressReflector.
                ProgressReflector.RegisterReflector(reflectorBar);
                report.CreateDocument();
            }
            finally {
                // Unregister the reflector bar, so that it no longer
                // reflects the state of a ProgressReflector.
                ProgressReflector.UnregisterReflector(reflectorBar);
                form.Close();
                form.Dispose();
            }

            // Show the preview of the created document.
            report.ShowPreviewDialog();
        }

    }
}