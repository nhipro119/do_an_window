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
    public partial class FormThemKhachMini : Form
    {
        string sdt;
        public FormThemKhachMini()
        {
            InitializeComponent();
        }
        public FormThemKhachMini(string sdt)
        {
            this.sdt = sdt;
            InitializeComponent();
        }
        string check(string value)
        {
            if(value == "")
            {
                return null;
            }
            return value;
        }
        bool check_SDT(string sdt)
        {
            if(!UInt64.TryParse(sdt, out UInt64 a))
            {
                MessageBox.Show("nhập sdt không đúng", "cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }
            if (sdt.Count() != 10)
            {
                MessageBox.Show("độ dài số điện thoại không đúng", "cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;

            }
            else
            {
                return true;
            }    
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btThem_Click(object sender, EventArgs e)
        {
            QLCH qLCH = new QLCH();
            KhachHang kh = new KhachHang();
            kh.TenKH = check(tbTen.Text);
            kh.Email = check(tbEmail.Text);
            kh.DiaChi = check(tbDiaChi.Text);
            kh.DTL = 0;
            if(check_SDT(tbSDT.Text) )
            {
                if (qLCH.KhachHangs.Find(tbSDT.Text) == null)
                {
                    kh.SDTKH = tbSDT.Text;
                    qLCH.KhachHangs.Add(kh);
                    qLCH.SaveChanges();
                    MessageBox.Show("Thêm khách hàng thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Khách Hàng Đã Có");
                }
                
            }
            
        }

        private void FormThemKhachMini_Load(object sender, EventArgs e)
        {
            tbSDT.Text = this.sdt;
        }
    }
}
