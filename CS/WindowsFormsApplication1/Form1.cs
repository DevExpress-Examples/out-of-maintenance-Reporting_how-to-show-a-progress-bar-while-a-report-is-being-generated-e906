using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting.Native;
// ...

namespace WindowsFormsApplication1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private XtraReport1 report;

        private void Form1_Load(object sender, EventArgs e) {
            // Create a report and make it
            // a document source of the document viewer.
            report = new XtraReport1();
            documentViewer1.DocumentSource = report;
            
            // Create a form to show a progress bar,
            // and adjust its properties.
            Form form = new Form() {
                FormBorderStyle = FormBorderStyle.None,
                Size = new System.Drawing.Size(300, 25),
                ShowInTaskbar = false,
                StartPosition = FormStartPosition.CenterScreen,
                TopMost = true
            };

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
                report.PrintingSystem.ProgressReflector = reflectorBar;
                report.CreateDocument();
            }
            finally {
                // Unregister the reflector bar, so that it no longer
                // reflects the state of a ProgressReflector.
                report.PrintingSystem.ResetProgressReflector();
                form.Close();
                form.Dispose();
            }
        }
    }
}
