using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangTapHoa
{
    public partial class ForgotPassForm : DevExpress.XtraEditors.XtraForm
    {
        QLCH qLCH;
        private string randomCode = "";
        private string to;
        public ForgotPassForm()
        {
            InitializeComponent();
        }

        //form dùng để thay đổi mật khẩu dựa vào gmail đăng kí

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        //ô địa chỉ mail: EmailTB
        //nút gửi: sendBTN

        private void btn_EmailSend_Click(object sender, EventArgs e)
        {
            string from, pass, messagebody;
            Random ran = new Random();
            string randText = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            int Length_randText = randText.Length;
            for (int i = 0; i < 5; i++)
            {
                randomCode += randText[ran.Next(Length_randText)];
            }
            MailMessage message = new MailMessage();
            NhanVien nv = qLCH.NhanViens.Find(EmailTB.Text);
            if(nv != null)
            {
                to = nv.Email;
                from = "cuahangcapeo@gmail.com";
                pass = "capeoshop";
                messagebody = "You have requested to reset your password. Enter this \"" + randomCode + "\" - code to change your password";
                if (!to.Contains("@"))
                {
                    MessageBox.Show("Địa chỉ mail nhập không đúng!", "Lỗi");
                }
                else
                {
                    message.To.Add(to);
                }
                message.From = new MailAddress(from);
                message.Body = messagebody;
                message.Subject = "Password resetting request";
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
                smtpClient.EnableSsl = true;
                smtpClient.Port = 587;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential(from, pass);
                
                //try
                {
                    if (to.Contains("@"))
                    {
                        smtpClient.Send(message);
                        ShowEmailLB.Text = "Một dãy kí tự đã được gửi đến " + to.ToString();
                        CodePN.Visible = true;
                    }
                }
                //catch (Exception ex)
                //{
                //    MessageBox.Show(ex.Message);
                //}
            }
            else
            {
                MessageBox.Show("Mã Nhân viên sai");
            }
            
        }

        //bảng nhập code: CodePN
        //label hiện địa chỉ mail gửi đến: ShowEmailLB
        //ô nhập code: CodeTB
        //nút xác nhận code: confirmCodeBTN

        private void confirmBTN_Click(object sender, EventArgs e)
        {
            if (!randomCode.Equals(CodeTB.Text))
            {
                MessageBox.Show("Dãy kí tự nhập không đúng!", "Lỗi");
            }
            else
            {
                CodePN.Visible = false;
                PassTB.Properties.UseSystemPasswordChar = true;
                PassConfirmTB.Properties.UseSystemPasswordChar = true;
                ChangePassPN.Visible = true;
            }
        }

        //bảng thay đổi mật khẩu: ChangePassPN
        //ô mật khẩu: PassTB
        //ô nhập lại mật khẩu: PassConfirmTB
        //nút xác nhận thay đổi: confirmChangeBTN

        private void confirmChangeBTN_Click(object sender, EventArgs e)
        {
            if (!PassTB.Text.Equals(PassConfirmTB.Text))
            {
                MessageBox.Show("Mật khẩu không trùng khớp!", "Lỗi");
            }
            else
            {
                NhanVien nv = qLCH.NhanViens.Find(EmailTB.Text);
                if (nv != null)
                {
                    nv.MatKhau = PassTB.Text;
                    qLCH.SaveChanges();
                    MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK);
                    this.Close();
                }
                
            }
        }

        private void ForgotPassForm_Load(object sender, EventArgs e)
        {
            qLCH = new QLCH();
        }

        private void hyperlinkLabelControl1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}