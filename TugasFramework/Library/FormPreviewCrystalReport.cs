using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using CrystalDecisions.CrystalReports;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Shared;

namespace TugasFramework.Library
{
    public partial class FormPreviewCrystalReport : Form
    {
        public FormPreviewCrystalReport()
        {
            InitializeComponent();
        }

        public FormPreviewCrystalReport(string judul, ReportDocument CrystalReportLaporan, DataTable source)
        {
            InitializeComponent();

            this.Text = judul;
            CrystalReportLaporan.SetDataSource(source);
            this.crystalReportViewer1.ReportSource = CrystalReportLaporan;
        }
    }
}
