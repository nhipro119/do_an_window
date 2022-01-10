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
    public partial class FormTKPNHcs : Form
    {
        string mapnh;
        
        public FormTKPNHcs()
        {
            InitializeComponent();
        }
        public FormTKPNHcs(string mapnh)
        {
            this.mapnh = mapnh;
            InitializeComponent();
        }
        
        private void FormTKPNHcs_Load(object sender, EventArgs e)
        {
            QLCH qLCH = new QLCH();
            List<CTPNH> lpnh = (from pnh in qLCH.CTPNHs where pnh.MaPN == this.mapnh select pnh).ToList();
            foreach(CTPNH ct in lpnh)
            {
                string ten = ct.HangHoa.TenHang;
                string dongia = ct.DonGia.ToString();
                string sl = ct.SoLuong.ToString();
                string[] tt = { ten, dongia, sl };
                dgvTKPNH.Rows.Add(tt);
            }
        }
    }
}
