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
    public partial class FormNhaCungCap : DevExpress.XtraEditors.XtraForm
    {
        QLCH qLCH;
        public FormNhaCungCap()
        {
            InitializeComponent();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        string create_ma()
        {
            string ma;
            int count = qLCH.NhaPhanPhois.Count();
            while(true)
            {
                ma = "NCC";
                ma += count.ToString();
                NhaPhanPhoi npp = qLCH.NhaPhanPhois.Find(ma);
                if(npp == null)
                {
                    break;
                }
                count++;
            }
            return ma;
        }
        bool check()
        {
            if(tbTen.Text =="" || tbSDT.Text == "" || tbEmail.Text == "" || tbDC.Text =="")
            {
                MessageBox.Show("không được bỏ trống ô");
                return false;
            }
            else if(!UInt64.TryParse(tbSDT.Text, out UInt64 a))
            {
                MessageBox.Show(" số điện thoại không đúng định dạng");
                return false;
            }
            else if(tbSDT.Text.Count()  != 10)
            {
                MessageBox.Show(" số điện thoại không đúng độ dài");
                return false;
            }
            string chuoi = tbTen.Text.ToLower();
            List<NhaPhanPhoi> lnpp = (from npp in qLCH.NhaPhanPhois where npp.TenNPP.ToLower().Equals(chuoi) select npp).ToList();
            if(lnpp.Count > 0)
            {
                MessageBox.Show("nhà phần phối đã có, không thể thêm");
                return false;
            }
            return true;
        }
        private void FormNhaCungCap_Load(object sender, EventArgs e)
        {
            qLCH = new QLCH();
            cbLH.DataSource = qLCH.LoaiHangs.ToList();
            cbLH.DisplayMember = "TenLH";
            cbLH.ValueMember = "MaLH";
            tbMa.Text = create_ma();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            bool key_check = check();
            if(key_check)
            {
                NhaPhanPhoi npp = new NhaPhanPhoi();
                npp.MaNPP = tbMa.Text;
                npp.TenNPP = tbTen.Text;
                npp.SDT = tbSDT.Text;
                npp.Email = tbEmail.Text;
                npp.DiaChi = tbDC.Text;
                npp.MaLH = cbLH.SelectedValue.ToString();
                qLCH.NhaPhanPhois.Add(npp);
                qLCH.SaveChanges();
                MessageBox.Show("thêm nhà phân phối thành công");
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}