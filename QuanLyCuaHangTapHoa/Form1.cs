﻿using System;
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
            customDesing();
        }

        private void customDesing()
        {
            panelThongKeSubMenu.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelThongKeSubMenu.Visible == true)
                panelThongKeSubMenu.Visible = false;
        }

        private void ShowMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            qLCH = new QLCH();
            //nhv = qLCH.NhanViens.Find("admin");
            
            LogInForm lif = new LogInForm();
            while(true)
            {
                if (lif.ShowDialog() == DialogResult.OK)
                {
                    this.nhv = lif.nv;
                    lbTenNV.Text = nhv.TenNV;
                    load_pbNV(nhv.MaNV);
                    break;
                }
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
            OpenChildForm(new FormMatHang());
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

        private void iconButton2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormNhapHang());
        }

        private void BtNPP_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormDoiTac());
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            ShowMenu(panelThongKeSubMenu);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
            label2.Text = DateTime.Now.ToLongDateString();
        }
    }
}
