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
    
    public partial class FormMatHang : DevExpress.XtraEditors.XtraForm
    {
        QLCH qLCH;
        public FormMatHang()
        {
            InitializeComponent();
            
        }

        private Form activeForm = null;     


        private void iconButton2_Click(object sender, EventArgs e)
        {

        }

        private void btnThemMatHang_Click(object sender, EventArgs e)
        {
            FormThemMatHang form = new FormThemMatHang();
            form.ShowDialog();
            if(form.DialogResult == DialogResult.OK)
            {
                TimKiemMH();
            }
        }
        void form_close(object sender, EventArgs e)
        {
            TimKiemMH();
        }
        void load_dgvhh(List<HangHoa> lhh)
        {
            dgvHH.Rows.Clear();
            foreach(HangHoa hh in lhh)
            {
                if(!hh.isDelete)
                {
                    string ma = hh.MaHang;
                    string ten = hh.TenHang;
                    string loai = hh.LoaiHang.TenLH;
                    string npp = qLCH.NhaPhanPhois.Find(hh.MaNPP).TenNPP;
                    string gv = hh.GiaGoc.ToString();
                    string gb = hh.DonGia.ToString();
                    string dvt = hh.DVT;
                    string tl = hh.TrongLuong.ToString();
                    string slt = hh.SLTon.ToString();
                    string[] tt = { ma, ten, loai, npp, gv, gb, dvt, tl, slt };
                    dgvHH.Rows.Add(tt);
                }
            }
            if(dgvHH.Rows.Count> 0)
            {
                lbMH.Text = dgvHH.Rows[0].Cells[0].Value.ToString();
                lbTH.Text = dgvHH.Rows[0].Cells[1].Value.ToString();
                lbLH.Text = dgvHH.Rows[0].Cells[2].Value.ToString();
                lbNCC.Text = dgvHH.Rows[0].Cells[3].Value.ToString();
                tbGG.Text = dgvHH.Rows[0].Cells[4].Value.ToString();
                tbGB.Text = dgvHH.Rows[0].Cells[5].Value.ToString();
                lbDVT.Text = dgvHH.Rows[0].Cells[6].Value.ToString();
                lbTL.Text = dgvHH.Rows[0].Cells[7].Value.ToString();
                tbSLT.Text = dgvHH.Rows[0].Cells[8].Value.ToString();
                string path = Application.StartupPath + "\\images\\imghh\\" + lbMH.Text + ".png";
                Bitmap img = new Bitmap(path);
                img = ResizeBitmap(img, pbHH.Width, pbHH.Height);
                pbHH.Image = img;
            }
            

        }
        private void FormMatHang_Load(object sender, EventArgs e)
        {
            qLCH = new QLCH();
            load_dgvhh(qLCH.HangHoas.ToList());
            load_cbLMH();
            load_cbNPP("0");
        }
        void load_cbLMH()
        {
            List<LoaiHang> llh = (from lh in qLCH.LoaiHangs where lh.isDelete == false select lh).ToList(); 
            LoaiHang tc = new LoaiHang();
            tc.MaLH = "0";
            tc.TenLH = "Tất cả";
            llh.Insert(0, tc);
            cbLH.DataSource = llh;
            cbLH.DisplayMember = "TenLH";
            cbLH.ValueMember = "MaLH";
            cbLH.SelectedIndex = 0;
        }
        void load_cbNPP(string malH)
        {
            List<NhaPhanPhoi> lnpp;
            if(malH == "0")
            {
                lnpp = qLCH.NhaPhanPhois.ToList();
            }
            else
            {
                lnpp = (from npp in qLCH.NhaPhanPhois where npp.MaLH == malH select npp).ToList();
            }
            lnpp = (from npp in lnpp where npp.isDelete == false select npp).ToList();
            NhaPhanPhoi tc = new NhaPhanPhoi();
            tc.MaNPP = "0";
            tc.TenNPP = "Tất cả";
            lnpp.Insert(0, tc);
            cbNPP.DataSource = lnpp;
            cbNPP.DisplayMember = "TenNPP";
            cbNPP.ValueMember = "maNPP";
            cbNPP.SelectedIndex = 0;
        }
        public Bitmap ResizeBitmap(Bitmap img, int width, int height)
        {
            Bitmap newimg = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(newimg))
            {
                g.DrawImage(img, 0, 0, width, height);
            }
            return newimg;
        }
        private void dgvHH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvHH.SelectedRows.Count > 0)
            {
                lbMH.Text = dgvHH.SelectedRows[0].Cells[0].Value.ToString();
                lbTH.Text = dgvHH.SelectedRows[0].Cells[1].Value.ToString();
                lbLH.Text = dgvHH.SelectedRows[0].Cells[2].Value.ToString();
                lbNCC.Text = dgvHH.SelectedRows[0].Cells[3].Value.ToString();
                tbGG.Text = dgvHH.SelectedRows[0].Cells[4].Value.ToString();
                tbGB.Text = dgvHH.SelectedRows[0].Cells[5].Value.ToString();
                lbDVT.Text = dgvHH.SelectedRows[0].Cells[6].Value.ToString();
                lbTL.Text = dgvHH.SelectedRows[0].Cells[7].Value.ToString();
                tbSLT.Text = dgvHH.SelectedRows[0].Cells[8].Value.ToString();
                string path = Application.StartupPath + "\\images\\imghh\\" + lbMH.Text + ".png";
                Bitmap img = new Bitmap(path);
                img = ResizeBitmap(img, pbHH.Width, pbHH.Height);
                pbHH.Image = img;
            }
        }
        
        bool check_int()
        {
            if (!uint.TryParse(tbSLT.Text, out uint a) ||  !UInt64.TryParse(tbGB.Text, out UInt64 c) || !UInt64.TryParse(tbGG.Text, out UInt64 d))
            {
                MessageBox.Show("Giá Bán, Giá Nhập, Trọng lượng, Số Lượng Tồn phải nhập số tự nhiên");
                return false;
            }
            
            return true;
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            bool key = check_int();
            if (key)
            {
                HangHoa hh = qLCH.HangHoas.Find(lbMH.Text);
                hh.DonGia = Int64.Parse(tbGB.Text);
                hh.GiaGoc = Int64.Parse(tbGG.Text);
                hh.SLTon = int.Parse(tbSLT.Text);
                qLCH.SaveChanges();
                MessageBox.Show("chỉnh sửa mặt hàng thành công");
                load_dgvhh(qLCH.HangHoas.ToList());
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            HangHoa hh = qLCH.HangHoas.Find(lbMH.Text);
            if(hh != null)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn xoá mặt hàng Này", "thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    hh.isDelete = true;
                    qLCH.SaveChanges();
                    MessageBox.Show(" Xoá thành công");
                    load_dgvhh(qLCH.HangHoas.ToList());
                }
            }
            else
            {
                MessageBox.Show(" không tìm thấy mặt hàng cần xoá");
            }
            
        }

        private void tbTimKiem_TextChanged(object sender, EventArgs e)
        {
            TimKiemMH();
        }

        private void btThemLH_Click(object sender, EventArgs e)
        {
            FormThemLoaiHang ftlh = new FormThemLoaiHang();
            ftlh.ShowDialog() ;
            if(ftlh.DialogResult == DialogResult.OK)
            {
                load_cbLMH();
            }
        }
        void TimKiemMH()
        {
            List<HangHoa> lhh;
            string mlh = cbLH.SelectedValue.ToString();
            if(mlh == "0")
            {
                lhh = qLCH.HangHoas.ToList();
            }
            else
            {
                lhh = (from hh in qLCH.HangHoas where hh.MaLH == mlh select hh).ToList();
            }
            if( cbNPP.SelectedValue.ToString() != "0")
            {
                lhh = (from hh in lhh where hh.MaNPP == cbNPP.SelectedValue.ToString() select hh).ToList();
            }
            if (tbTimKiem.Text != "")
            {
                string chuoi = tbTimKiem.Text.ToLower();
                lhh = (from hh in lhh where hh.TenHang.ToLower().Contains(chuoi) select hh).ToList();
            }
            load_dgvhh(lhh);
        }
        private void cbLH_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_cbNPP(cbLH.SelectedValue.ToString());
            TimKiemMH();
        }

        private void cbNPP_SelectedIndexChanged(object sender, EventArgs e)
        {
            TimKiemMH();
        }
    }
}