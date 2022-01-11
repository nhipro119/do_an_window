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
    public partial class LogInForm : DevExpress.XtraEditors.XtraForm
    {
        QLCH qLCH;
        public NhanVien nv;
        public LogInForm()
        {
            InitializeComponent();
        }

        //ô tài khoản: AccountTB
        //ô mật khẩu: PassTB
        //Nút đăng nhập: LoginBTN
        //LinkLabel quên mật khẩu : PassForgotLLB

        private void LogInForm_Load(object sender, EventArgs e)
        {
            PassTB.Properties.UseSystemPasswordChar = true;
            qLCH = new QLCH();
            
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPass.Checked)
            {
                PassTB.Properties.UseSystemPasswordChar = false;
            }
            else
            {
                PassTB.Properties.UseSystemPasswordChar = true;
            }
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            NhanVien nv = qLCH.NhanViens.Find(AccountTB.Text);
            if(nv != null)
            {
                if(nv.MatKhau.Equals(PassTB.Text))
                {
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    
                    this.nv = nv;
                }
                else
                {
                    MessageBox.Show("sai mật khẩu");
                }
            }
            else
            {
                MessageBox.Show("sai tài khoản");
            }
        }

        private void PassForgotLLB_Click(object sender, EventArgs e)
        {
            ForgotPassForm fpf = new ForgotPassForm();
            fpf.ShowDialog();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
           DialogResult rs =  MessageBox.Show("bạn có muốn thoát ứng dụng", "thông báo", MessageBoxButtons.YesNo);
            if(rs == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
                
            }
        }
    }
}