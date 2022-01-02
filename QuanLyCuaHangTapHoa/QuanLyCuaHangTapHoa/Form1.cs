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
        public Form1()
        {
            InitializeComponent();
            Menu();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Menu()
        {
            PanelHangHoaSubMenu.Visible = false;  
        }

        private void HideMenu()
        {
            if (PanelHangHoaSubMenu.Visible = true)
                PanelHangHoaSubMenu.Visible = false;
        }

        private void ShowMenu(Panel SubMenu)
        {
            if (SubMenu.Visible == false)
            {
                HideMenu();
                SubMenu.Visible = true;
            }
            else
                SubMenu.Visible = false;
        }

        private void btnHangHoa_Click(object sender, EventArgs e)
        {
            ShowMenu(PanelHangHoaSubMenu);
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            HideMenu();
        }
    }
}
