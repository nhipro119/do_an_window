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
    public partial class FormDoiTac : DevExpress.XtraEditors.XtraForm
    {
        QLCH qLCH;
        public FormDoiTac()
        {
            InitializeComponent();
        }

        private void FormDoiTac_Load(object sender, EventArgs e)
        {
            qLCH = new QLCH();
            load_dgvNCC(qLCH.NhaPhanPhois.ToList());
            load_cb();

        }
        void load_cb()
        {
            List<LoaiHang> llh = qLCH.LoaiHangs.ToList();
            llh = (from lh in llh where !lh.isDelete select lh).ToList();
            LoaiHang tc = new LoaiHang();
            tc.MaLH = "0";
            tc.TenLH = "Tất Cả";
            llh.Insert(0, tc);
            cbTKLMH.DataSource = llh;
            cbTKLMH.DisplayMember = "TenLH";
            cbTKLMH.ValueMember = "MaLH";
            
        }
        void load_dgvNCC(List<NhaPhanPhoi> lncc)
        {
            dgvNCC.Rows.Clear();
            foreach(NhaPhanPhoi ncc in lncc)
            {
                if(!ncc.isDelete )
                {
                    string ma = ncc.MaNPP;
                    string ten = ncc.TenNPP;
                    string sdt = ncc.SDT;
                    string email = ncc.Email;
                    string dc = ncc.DiaChi;
                    string lh = qLCH.LoaiHangs.Find(ncc.MaLH).TenLH;
                    string[] tt = { ma, ten, sdt, email, dc, lh };
                    dgvNCC.Rows.Add(tt);
                }
                
            }
            if(dgvNCC.Rows.Count > 0)
            {
                lbMa.Text = dgvNCC.Rows[0].Cells[0].Value.ToString();
                lbTen.Text = dgvNCC.Rows[0].Cells[1].Value.ToString();
                lbLMH.Text = dgvNCC.Rows[0].Cells[5].Value.ToString();
                tbSDT.Text = dgvNCC.Rows[0].Cells[2].Value.ToString();
                tbEmail.Text = dgvNCC.Rows[0].Cells[3].Value.ToString();
                tbDC.Text = dgvNCC.Rows[0].Cells[4].Value.ToString();
            }
            
        }

        private void btnThemMatHang_Click(object sender, EventArgs e)
        {
            FormNhaCungCap fncc = new FormNhaCungCap();
            fncc.Show();
            fncc.FormClosed += form_close;
        }
        void form_close(object sender, EventArgs e)
        {
            load_dgvNCC(qLCH.NhaPhanPhois.ToList());
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dgvNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvNCC.SelectedRows.Count > 0)
            {
                lbMa.Text = dgvNCC.SelectedRows[0].Cells[0].Value.ToString();
                lbTen.Text = dgvNCC.SelectedRows[0].Cells[1].Value.ToString();
                lbLMH.Text = dgvNCC.SelectedRows[0].Cells[5].Value.ToString();
                tbSDT.Text = dgvNCC.SelectedRows[0].Cells[2].Value.ToString();
                tbEmail.Text = dgvNCC.SelectedRows[0].Cells[3].Value.ToString();
                tbDC.Text = dgvNCC.SelectedRows[0].Cells[4].Value.ToString();
            }
        }
        bool check()
        {
            if (tbSDT.Text == "" || tbEmail.Text == "" || tbDC.Text == "")
            {
                MessageBox.Show(" không được bỏ trống ô");
                return false;
            }
            else if( !UInt64.TryParse(tbSDT.Text, out UInt64 a))
            {
                MessageBox.Show(" số điện thoại nhập không đúng định dạng");
                return false;
            }
            else if(tbSDT.Text.Count() != 10)
            {
                MessageBox.Show(" số điện thoại phải là 10 số");
                return false;
            }

            return true;
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if(check())
            {
                NhaPhanPhoi npp = qLCH.NhaPhanPhois.Find(lbMa.Text);
                npp.SDT = tbSDT.Text;
                npp.DiaChi = tbDC.Text;
                npp.Email = tbEmail.Text;
                qLCH.SaveChanges();
                MessageBox.Show(" thay đổi thành công");
                tbTimKiem.Text = "";
                TimKiem();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TimKiem();
        }
        void TimKiem()
        {
            string malh = cbTKLMH.SelectedValue.ToString();
            string chuoi = tbTimKiem.Text.ToLower();
            List<NhaPhanPhoi> lnpp;
            if (malh == "0")
            {
                lnpp = qLCH.NhaPhanPhois.ToList();
            }
            else
            {
                lnpp = (from npp in qLCH.NhaPhanPhois where npp.MaLH == malh select npp).ToList();
            }
            if (chuoi != "")
            {
                lnpp = (from npp in lnpp where npp.TenNPP.ToLower().Contains(chuoi) select npp).ToList();
            }
            load_dgvNCC(lnpp);
        }
        private void cbTKLMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            TimKiem();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            string ma = lbMa.Text;
            List<HangHoa> lhh = (from hh in qLCH.HangHoas where hh.MaNPP == ma && !hh.isDelete select hh).ToList();
            NhaPhanPhoi npp = qLCH.NhaPhanPhois.Find(ma);
            if (npp != null)
            {
                if (lhh.Count() > 0)
                {
                    MessageBox.Show(" nhà phân phối còn đang cung cấp hàng hoá, không xoá được");
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Bạn có muốn xoá mặt hàng Này", "thông báo", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        npp.isDelete = true;
                        qLCH.SaveChanges();
                        MessageBox.Show(" Xoá thành công");
                        qLCH.SaveChanges();
                        tbTimKiem.Text = "";
                        TimKiem();
                    }
                }
            }
            else
            {
                MessageBox.Show(" Không tìm thấy nhà phân phối");
            }
              
        }
    }
}