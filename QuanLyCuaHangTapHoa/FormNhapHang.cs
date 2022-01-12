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
    public partial class FormNhapHang : DevExpress.XtraEditors.XtraForm
    {
        QLCH qLCH;
        NhanVien nv;
        public FormNhapHang()
        {
            InitializeComponent();
        }
        public FormNhapHang(NhanVien nv)
        {
            InitializeComponent();
            this.nv = nv;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormNhapHang_Load(object sender, EventArgs e)
        {
            qLCH = new QLCH();
            load_dgv(qLCH.PhieuNhapHangs.ToList());
        }
        void load_dgv(List<PhieuNhapHang> lpnh)
        {
            dgv_pnh.Rows.Clear();
            foreach(PhieuNhapHang pnh in lpnh)
            {
                string ten = qLCH.NhaPhanPhois.Find(pnh.MaNPP).TenNPP;
                string ngay = pnh.NgayNhap.ToString();
                string TongTien = pnh.TongTien.ToString();
                string TenNV = pnh.NhanVien.TenNV;
                string ma = pnh.MaPN;
                string[] tt = { ten, ngay, TongTien, TenNV, ma };
                dgv_pnh.Rows.Add(tt);
            }
        }
        private void btCSV_Click(object sender, EventArgs e)
        {
            
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            NhapHangForm nhf = new NhapHangForm(nv);
            nhf.ShowDialog();
            if(nhf.DialogResult == DialogResult.OK)
            {
                load_dgv(qLCH.PhieuNhapHangs.ToList());
            }
        }
        void form_close(object sender, EventArgs e)
        {
            load_dgv(qLCH.PhieuNhapHangs.ToList());
        }
        private void dgv_pnh_DoubleClick(object sender, EventArgs e)
        {
            string ma = dgv_pnh.SelectedRows[0].Cells[4].Value.ToString();
            FormTKPNHcs ftk = new FormTKPNHcs(ma);
            ftk.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}