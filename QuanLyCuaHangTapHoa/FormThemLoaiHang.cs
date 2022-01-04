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
    public partial class FormThemLoaiHang : Form
    {
        QLCH qLCH;
        public FormThemLoaiHang()
        {
            InitializeComponent();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            bool key = check();
            if(key)
            {
                LoaiHang lh = new LoaiHang();
                lh.MaLH = tbMLH.Text;
                lh.TenLH = tbTLH.Text;
                qLCH.LoaiHangs.Add(lh);
                qLCH.SaveChanges();
                MessageBox.Show(" thêm loại hàng thành công");

            }
        }
        string create_mlh()
        {
            string ma;
            int count = qLCH.LoaiHangs.Count();
            while(true)
            {
                ma = "LH";
                ma += count.ToString();
                LoaiHang lh = qLCH.LoaiHangs.Find(ma);
                if(lh ==  null)
                {
                    break;
                }
                count++;
            }
            return ma;
        }
        bool check()
        {
            if(tbTLH.Text =="")
            {
                MessageBox.Show("không được để trống ô");
                return false;
            }
            return true;
        }
        void load_dgv(List<LoaiHang> llh)
        {
            dgvLH.Rows.Clear();
            foreach (LoaiHang lh in llh)
            {
                string[] tt = { lh.MaLH, lh.TenLH };
                dgvLH.Rows.Add(tt);
            }
        }
        private void FormThemLoaiHang_Load(object sender, EventArgs e)
        {
            
            qLCH = new QLCH();
            load_dgv(qLCH.LoaiHangs.ToList());
            tbMLH.Text = create_mlh();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string chuoi = tbTimKiem.Text.ToLower();
            if(chuoi == "")
            {
                load_dgv(qLCH.LoaiHangs.ToList());
            }
            else
            {
                List<LoaiHang> llh = (from lh in qLCH.LoaiHangs where lh.TenLH.ToLower().Contains(chuoi) select lh).ToList();
                load_dgv(llh);
            }
        }
    }
}
