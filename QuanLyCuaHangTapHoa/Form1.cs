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
    }
}
