using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace QuanLyCuaHangTapHoa
{
    public partial class HDReport : DevExpress.XtraReports.UI.XtraReport
    {
        public HDReport()
        {
            InitializeComponent();
        }
        public HDReport(string nv, List<CTHD> data)
        {
            InitializeComponent();
            if (data != null)
            {
                objectDataSource1.DataSource = data;
                pNV.Value = nv;
            }
        }
    }
}
