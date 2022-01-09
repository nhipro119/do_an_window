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
            if(sdt.Count() == 10)
            {
                return true;

            }
            else
            {
                return false;
            }    
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
                if (qLCH.KhachHangs.Find(tbSDT.Text) != null)
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
            else
            {
                MessageBox.Show("nhập sdt không đúng", "cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void FormThemKhachMini_Load(object sender, EventArgs e)
        {
            tbSDT.Text = this.sdt;
        }
    }
}
