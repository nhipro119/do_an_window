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
    public partial class FormThemNhanVien : Form
    {
        QLCH qLCH;
        public FormThemNhanVien()
        {
            InitializeComponent();
        }

        private void FormThemNhanVien_Load(object sender, EventArgs e)
        {
            qLCH = new QLCH();
            tbMaNV.Text = manv();
            tbMaNV.Enabled = false;
        }
        string manv()
        {
            string ma;
            int count = qLCH.NhanViens.Count();
            while(true)
            {
                ma = "NV"+count.ToString();
                if(qLCH.NhanViens.Find(ma) == null)
                {
                    break;
                }
                count++;
            }
            return ma;
        }
        bool check_sdt()
        {
            if(!Int64.TryParse(tbSDT.Text,out Int64 a))
            {
                MessageBox.Show("số điện thoại không được chứa kí tự hoặc bỏ trống");
                return false;
            }
            else if(tbSDT.Text.Count() != 10)
            {
                MessageBox.Show(" số điện thoại không đúng độ dài");
                return false;
            }
            return true;
        }
        bool check_cmnd()
        {
            if(!Int64.TryParse(tbCMND.Text, out Int64 a))
            {
                MessageBox.Show("Chứng minh nhân dân không được chứa kí tự hoặc bỏ trống");
                return false;
            }
            int len_cmnd = tbCMND.Text.Count();
            if(len_cmnd != 9 && len_cmnd != 12)
            {
                MessageBox.Show("Độ dài của chứng minh nhân dân không hợp lệ");
                return false;
            }
            return true;
        }
        bool check_space(string value)
        {
            if(value.Trim() == "")
            {
                MessageBox.Show(" không được bỏ trống ô");
                return false;
            }
            return true;
        }
        bool check_NgaySinh()
        {
            if((DateTime.Today.Year - dpNS.Value.Year) < 16)
            {
                MessageBox.Show(" chưa đủ tuổi lao động");
                return false;
            }
            return true;
        }
        bool check_mk()
        {
            int len_mk = tbMK.Text.Count();
            if(len_mk < 4 && len_mk > 10)
            {
                MessageBox.Show(" độ dài mật khẩu chỉ nằm trong khoảng từ 4 đến 10 kí tự");
                return false;
            }    
            return true;
        }
        bool check_img()
        {
            if(pbHH.Image == null)
            {
                MessageBox.Show("Hình ảnh không được bỏ trống");
                return false;
            }
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bool key_sdt = check_sdt();
            bool key_cmnd = check_cmnd();
            bool key_ten = check_space(tbTenNV.Text);
            bool key_dc = check_space(tbDiaChi.Text);
            bool key_email = check_space(tbEmail.Text);
            bool key_mk = check_mk();
            bool key_ns = check_NgaySinh();
            bool key_img = check_img();
            if(key_cmnd && key_ten && key_sdt && key_dc && key_email && key_mk && key_ns && key_img)
            {
                NhanVien nv = new NhanVien();
                nv.MaNV = tbMaNV.Text;
                nv.TenNV = tbTenNV.Text;
                nv.SDT = tbSDT.Text;
                nv.NgaySinh = dpNS.Value;
                nv.CMND = tbCMND.Text;
                nv.Email = tbEmail.Text;
                nv.DiaChi = tbDiaChi.Text;
                nv.MatKhau = tbMK.Text;
                save_img_nv(nv.MaNV);
                qLCH.NhanViens.Add(nv);
                qLCH.SaveChanges();
                MessageBox.Show(" thêm nhân viên thành công");
                this.Close();
            }
        }
        void save_img_nv( String manv)
        {

            {
                string path = Application.StartupPath + "\\images\\imgnv\\" + manv + ".png";
                Bitmap bmp_save = new Bitmap(pbHH.Image);
                pbHH.Image.Dispose();
                bmp_save.Save(path, System.Drawing.Imaging.ImageFormat.Png);
            }

            {
                //MessageBox.Show(" không lưu được hình ảnh");
            }
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
            Bitmap imgnv = new Bitmap(tbDuongDan.Text);
            imgnv = ResizeBitmap(imgnv, pbHH.Width, pbHH.Height);
            pbHH.Image = imgnv;
        }
    }
}
