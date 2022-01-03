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
    public partial class FormNhanVien : DevExpress.XtraEditors.XtraForm
    {
        QLCH qLCH;
        public FormNhanVien()
        {
            InitializeComponent();
        }

        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            FormThemNhanVien ftnv = new FormThemNhanVien();
            ftnv.Show();
            ftnv.FormClosed += form_close;
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            qLCH = new QLCH();
            load_dgv(qLCH.NhanViens.ToList());
        }
        void form_close(object sender, FormClosedEventArgs e)
        {
            load_dgv(qLCH.NhanViens.ToList());
        }
        void load_dgv(List<NhanVien> lnv)
        {
            dgvNhanVien.Rows.Clear();
            foreach(NhanVien nv in lnv)
            {
                if(!nv.isDelete)
                {
                    string ma = nv.MaNV;
                    string ten = nv.TenNV;
                    string cmnd = nv.CMND;
                    string sdt = nv.SDT;
                    string email = nv.Email;
                    string dc = nv.DiaChi;
                    string[] tt = { ma, ten, cmnd, sdt, email, dc };
                    dgvNhanVien.Rows.Add(tt);
                }
                
            }
            dgvNhanVien.AllowUserToAddRows = false;
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
        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvNhanVien.SelectedRows.Count > 0)
            {
                
                
                lbMa.Text = dgvNhanVien.SelectedRows[0].Cells[0].Value.ToString();
                lbTen.Text = dgvNhanVien.SelectedRows[0].Cells[1].Value.ToString();
                lbCMND.Text = dgvNhanVien.SelectedRows[0].Cells[2].Value.ToString();
                tbSDT.Text = dgvNhanVien.SelectedRows[0].Cells[3].Value.ToString();
                tbEmail.Text = dgvNhanVien.SelectedRows[0].Cells[4].Value.ToString();
                tbDiaChi.Text = dgvNhanVien.SelectedRows[0].Cells[5].Value.ToString();
                string path = Application.StartupPath + "\\images\\imgnv\\" + lbMa.Text + ".png";
                Bitmap imgnv = new Bitmap(path);
                imgnv = ResizeBitmap(imgnv, pbNV.Width, pbNV.Height);
                pbNV.Image = imgnv;
                    
                
            }
        }

        private void tbTimKiemNV_TextChanged(object sender, EventArgs e)
        {
            string chuoi = tbTimKiemNV.Text.ToLower();
            if(chuoi == "")
            {
                load_dgv(qLCH.NhanViens.ToList());
            }
            else
            {
                List<NhanVien> lnv = (from nv in qLCH.NhanViens where nv.TenNV.ToLower().Contains(chuoi) || nv.MaNV.Contains(chuoi) select nv).ToList();
                load_dgv(lnv);
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
        bool check_sdt()
        {
            if (!Int64.TryParse(tbSDT.Text, out Int64 a))
            {
                MessageBox.Show("số điện thoại không được chứa kí tự hoặc bỏ trống");
                return false;
            }
            else if (tbSDT.Text.Count() != 10)
            {
                MessageBox.Show(" số điện thoại không đúng độ dài");
                return false;
            }
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bool key_sdt = check_sdt();
            bool key_email = check_space(tbEmail.Text);
            bool key_dc = check_space(tbDiaChi.Text);
            if(key_sdt && key_email && key_dc)
            {
                NhanVien nv = qLCH.NhanViens.Find(lbMa.Text);
                if(nv == null)
                {
                    MessageBox.Show("Nhân viên không tồn tại");
                }
                else
                {
                    nv.DiaChi = tbDiaChi.Text;
                    nv.Email = tbEmail.Text;
                    nv.SDT = tbSDT.Text;
                    qLCH.SaveChanges();
                    MessageBox.Show("Sửa nhân viên thành công");
                    load_dgv(qLCH.NhanViens.ToList());
                }
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            NhanVien nv = qLCH.NhanViens.Find(lbMa.Text);
            if(nv != null)
            {
                if(nv.MaNV == "admin")
                {
                    MessageBox.Show("admin không được xoá");
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Bạn có muốn xoá Nhân Viên Này", "thông báo", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        nv.isDelete = true;
                        qLCH.SaveChanges();
                        MessageBox.Show(" Xoá thành công");
                    }
                    else
                    {

                    }
                }    
                

            }
        }
    }
}