using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace ShowProgressReflector {
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport {
        public XtraReport1() {
            InitializeComponent();
        }

        int i = 0;

        private void xrLabel2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
            i++;
            ((XRLabel)sender).Text = "Row Number: " + i.ToString();
        }

        private void XtraReport1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
            i = 0;
            this.ReportPrintOptions.DetailCountOnEmptyDataSource = (int)TotalRowCount.Value;
        }

    }
}
