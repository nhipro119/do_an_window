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


        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btThem_Click(object sender, EventArgs e)
        {

            lbMa.Text = create_mlh();
            bool key = check();
            if(key)
            {
                LoaiHang lh = new LoaiHang();
                lh.MaLH = lbMa.Text;
                lh.TenLH = tbTLH.Text;
                lh.isDelete = false;
                qLCH.LoaiHangs.Add(lh);
                qLCH.SaveChanges();
                MessageBox.Show(" thêm loại hàng thành công");
                load_dgv(qLCH.LoaiHangs.ToList());
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
            string chuoi = tbTLH.Text.ToLower();
            List<LoaiHang> llh = (from lh in qLCH.LoaiHangs where lh.TenLH.ToLower().Equals(chuoi) select lh).ToList();
            if(llh.Count > 0)
            {
                MessageBox.Show(" Loại Hàng đã có không thể thêm");
            }
            return true;
        }
        void load_dgv(List<LoaiHang> llh)
        {
            dgvLH.Rows.Clear();
            foreach (LoaiHang lh in llh)
            {
                if(!lh.isDelete)
                {
                    string[] tt = { lh.MaLH, lh.TenLH };
                    dgvLH.Rows.Add(tt);
                }
                
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

        private void iconButton1_Click(object sender, EventArgs e)
        {
            string chuoi = lbMa.Text;
            LoaiHang lh = qLCH.LoaiHangs.Find(chuoi);
            if(chuoi == null)
            {
                MessageBox.Show(" chưa chọn loại hàng cần xoá");
            }
            else
            {
                List<NhaPhanPhoi> lnpp = (from npp in qLCH.NhaPhanPhois where npp.MaLH == chuoi && !npp.isDelete select npp).ToList();
                if(lnpp.Count() >0)
                {
                    MessageBox.Show("cần phải xoá tất cả nhà phân phối cung cấp loại hàng này thì mới xoá được loại hàng");
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Bạn có muốn xoá loại hàng  này", "thông báo", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        lh.isDelete = true;
                        qLCH.SaveChanges();
                        MessageBox.Show(" Xoá thành công");
                        qLCH.SaveChanges();
                        load_dgv(qLCH.LoaiHangs.ToList());
                    }
                }    
            }
        }

        private void dgvLH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvLH.SelectedRows.Count > 0)
            {
                lbMa.Text = dgvLH.SelectedRows[0].Cells[0].Value.ToString();
            }    
        }
    }
}
