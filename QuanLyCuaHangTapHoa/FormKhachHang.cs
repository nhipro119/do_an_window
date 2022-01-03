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
    public partial class FormKhachHang : DevExpress.XtraEditors.XtraForm
    {
        QLCH qLCH;
        public FormKhachHang()
        {
            InitializeComponent();
        }
        void load_dgv(List<KhachHang> lkh)
        {
            foreach(KhachHang kh in lkh)
            {
                string sdt = kh.SDTKH;
                string ten = kh.TenKH;
                string email = kh.Email;
                string dc = kh.DiaChi;
                int? dtl = kh.DTL;
                string[] tt = { sdt, ten, email, dc, dtl.ToString() };
                dgvKH.Rows.Add(tt);
            }
        }
        private void btnThemKhachHang_Click(object sender, EventArgs e)
        {
            FormThemKhachMini ftk = new FormThemKhachMini();
            ftk.Show();
            ftk.FormClosed += form_close;
        }
        void form_close(object sender, FormClosedEventArgs e)
        {
            load_dgv(qLCH.KhachHangs.ToList());
        }

        private void dgvKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvKH.SelectedRows.Count > 0)
            {
                lbSDT.Text = dgvKH.SelectedRows[0].Cells[0].Value.ToString();
                lbTen.Text = dgvKH.SelectedRows[0].Cells[1].Value.ToString();
                tbEmail.Text = dgvKH.SelectedRows[0].Cells[2].Value.ToString(); 
                tbDC.Text = dgvKH.SelectedRows[0].Cells[3].Value.ToString();
                lbDTL.Text = dgvKH.SelectedRows[0].Cells[4].Value.ToString(); 
            }
        }
        bool check_space(string value)
        {
            if (value.Trim() == "")
            {
                MessageBox.Show(" không được bỏ trống ô");
                return false;
            }
            return true;
        }
        private void btSua_Click(object sender, EventArgs e)
        {
            KhachHang kh = qLCH.KhachHangs.Find(lbSDT);
            if(kh != null)
            {
                bool key_email = check_space(tbEmail.Text);
                bool key_dc = check_space(tbDC.Text);
                if (key_email && key_dc)
                {
                    kh.DiaChi = tbDC.Text;
                    kh.Email = tbEmail.Text;
                    qLCH.SaveChanges();
                    MessageBox.Show("sửa thành công");
                    load_dgv(qLCH.KhachHangs.ToList());
                }
            }
            
        }

        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            qLCH = new QLCH();
            load_dgv(qLCH.KhachHangs.ToList());
        }
    }
}