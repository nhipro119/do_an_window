using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyCuaHangTapHoa
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        NhanVien nhv;
        QLCH qLCH;
        public Form1()
        {
            InitializeComponent();          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            qLCH = new QLCH();
            nhv = qLCH.NhanViens.Find("admin");
            lbTenNV.Text = nhv.TenNV;
            load_pbNV(nhv.MaNV);
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
        
        
        void load_pbNV(string manv)
        {
            string path = Application.StartupPath + "\\images\\imgnv\\" + manv + ".png";
            //try
            {
                Bitmap img = new Bitmap(path);
                img = ResizeBitmap(img, pbNV.Width, pbNV.Height);
                pbNV.Image = img;
            }
            //catch
            {

            }

        }
        private void btnHangHoa_Click(object sender, EventArgs e)
        {
            
        }

        private Form activeForm = null;
        private void OpenChildForm (Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormBanHang(nhv));
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormNhanVien());
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormKhachHang());
        }
    }
}
