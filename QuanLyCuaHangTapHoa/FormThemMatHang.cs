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
    public partial class FormThemMatHang : DevExpress.XtraEditors.XtraForm
    {
        QLCH qLCH;
        public FormThemMatHang()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        string tao_ma()
        {
            string ma ;
            int count = qLCH.HangHoas.Count();
            while (true)
            {
                
                ma = "HH";
                
                ma += count.ToString();
                HangHoa hh = qLCH.HangHoas.Find(ma);
                if( hh == null)
                {
                    break;
                }
                else
                {
                    count++;
                }
            }
            return ma;
        }
        private void FormThemMatHang_Load(object sender, EventArgs e)
        {
            qLCH = new QLCH();
            cbLH.DataSource = qLCH.LoaiHangs.ToList();
            cbLH.DisplayMember = "TenLH";
            cbLH.ValueMember = "MaLH";
            lnpp(cbLH.SelectedValue.ToString());
            tbMaHH.Text = tao_ma();
        }
        void lnpp(string ma)
        {
            List<NhaPhanPhoi> lnpp = (from npp in qLCH.NhaPhanPhois where npp.MaLH == ma select npp).ToList();
            cbNPP.DataSource = lnpp;
            cbNPP.DisplayMember = "TenNPP";
            cbNPP.ValueMember = "MaNPP";
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //tbMaHH.Text = tao_ma();
        }

        private void cbLH_SelectedIndexChanged(object sender, EventArgs e)
        {
            lnpp(cbLH.SelectedValue.ToString());
            //tbMaHH.Text = tao_ma();
        }

        private void btDuongDan_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                tbDuongDan.Text = dlg.FileName;

            }
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

        private void tbDuongDan_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Bitmap imgnv = new Bitmap(tbDuongDan.Text);
                imgnv = ResizeBitmap(imgnv, pbHH.Width, pbHH.Height);
                pbHH.Image = imgnv;
            }
            catch
            {
                MessageBox.Show(" không đọc được ảnh");
            }
            
        }
        bool check_space()
        {
            if(tbTenHang.Text =="" || tbGiaVon.Text =="" ||tbGiaBan.Text == "" || tbDVT.Text =="" ||tbTL.Text==""|| tbSLT.Text == "" || pbHH.Image == null)
            {
                MessageBox.Show("không được bỏ trống ô");
                return false;
            }
            return true;
        }
        bool check_int()
        {
            if(!uint.TryParse(tbSLT.Text, out uint a) || !uint.TryParse(tbTL.Text, out uint b) || !UInt64.TryParse(tbGiaBan.Text, out UInt64 c) || !UInt64.TryParse(tbGiaVon.Text, out UInt64 d))
            {
                MessageBox.Show("Giá Bán, Giá Nhập, Trọng lượng, Số Lượng Tồn phải nhập số tự nhiên");
                return false;
            }
            else if(Int64.Parse(tbGiaVon.Text) > Int64.Parse(tbGiaBan.Text))
            {
                MessageBox.Show("Giá bán phải lớn hơn giá gốc");
                return false;
            }
            else if (uint.Parse(tbTL.Text) <= 0)
            {
                MessageBox.Show("Trọng lượng phải lớn hơn 0");
                return false;
            }
            else if(Int64.Parse(tbGiaVon.Text) <= 0)
            {
                MessageBox.Show("giá vốn phải lớn hơn 0");
                return false;
            }
            return true;
        }
        
        private void btThem_Click(object sender, EventArgs e)
        {
            bool key_space = check_space();
            bool key_int = check_int();
            if(key_int && key_space)
            {
                HangHoa hh = new HangHoa();
                hh.MaHang = tbMaHH.Text;
                hh.TenHang = tbTenHang.Text;
                hh.MaLH = cbLH.SelectedValue.ToString();
                hh.MaNPP = cbNPP.SelectedValue.ToString();
                hh.GiaGoc = Int64.Parse(tbGiaVon.Text);
                hh.DonGia = Int64.Parse(tbGiaBan.Text);
                hh.DVT = tbDVT.Text;
                hh.TrongLuong = int.Parse(tbTL.Text);
                hh.SLTon = int.Parse(tbSLT.Text);
                hh.isDelete = false;
                qLCH.HangHoas.Add(hh);
                qLCH.SaveChanges();
                save_img_hh(hh.MaHang);
                MessageBox.Show("Thêm mặt hàng thành công");
            }
            this.Close();
        }
        void save_img_hh(String mahh)
        {

            {
                string path = Application.StartupPath + "\\images\\imghh\\" + mahh + ".png";
                Bitmap bmp_save = new Bitmap(pbHH.Image);
                pbHH.Image.Dispose();
                bmp_save.Save(path, System.Drawing.Imaging.ImageFormat.Png);
            }

            {
                //MessageBox.Show(" không lưu được hình ảnh");
            }
        }
    }
}