using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangTapHoa
{
    public partial class FormBangThongKe : DevExpress.XtraEditors.XtraForm
    {
        public FormBangThongKe()
        {
            string path = Application.StartupPath + "\\images\\thongke\\thongke.xml";
            
            InitializeComponent();
            this.dashboardViewer1.DashboardSource = new System.Uri(path, System.UriKind.Absolute);
        }

        private void FormBangThongKe_Load(object sender, EventArgs e)
        {
            
        }
    }
}