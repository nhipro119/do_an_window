
namespace QuanLyCuaHangTapHoa
{
    partial class LogInForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LoginBtn = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.AccountTB = new DevExpress.XtraEditors.TextEdit();
            this.PassTB = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.PassForgotLLB = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.checkPass = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountTB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PassTB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkPass.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginBtn
            // 
            this.LoginBtn.Appearance.BackColor = System.Drawing.Color.LightGray;
            this.LoginBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.LoginBtn.Appearance.ForeColor = System.Drawing.Color.Black;
            this.LoginBtn.Appearance.Options.UseBackColor = true;
            this.LoginBtn.Appearance.Options.UseFont = true;
            this.LoginBtn.Appearance.Options.UseForeColor = true;
            this.LoginBtn.Location = new System.Drawing.Point(243, 235);
            this.LoginBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(100, 28);
            this.LoginBtn.TabIndex = 1;
            this.LoginBtn.Text = "Đăng nhập";
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(77, 137);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(88, 24);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Tài khoản";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(77, 190);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(82, 24);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Mật khẩu";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(195, 15);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(228, 45);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "ĐĂNG NHẬP";
            // 
            // AccountTB
            // 
            this.AccountTB.Location = new System.Drawing.Point(208, 133);
            this.AccountTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AccountTB.Name = "AccountTB";
            // 
            // 
            // 
            this.AccountTB.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.AccountTB.Properties.Appearance.Options.UseFont = true;
            this.AccountTB.Size = new System.Drawing.Size(293, 28);
            this.AccountTB.TabIndex = 7;
            // 
            // PassTB
            // 
            this.PassTB.Location = new System.Drawing.Point(208, 186);
            this.PassTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PassTB.Name = "PassTB";
            // 
            // 
            // 
            this.PassTB.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.PassTB.Properties.Appearance.Options.UseFont = true;
            this.PassTB.Size = new System.Drawing.Size(211, 28);
            this.PassTB.TabIndex = 8;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(219, 65);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(176, 17);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "Chào mừng bạn quay trở lại!";
            // 
            // PassForgotLLB
            // 
            this.PassForgotLLB.Location = new System.Drawing.Point(243, 302);
            this.PassForgotLLB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PassForgotLLB.Name = "PassForgotLLB";
            this.PassForgotLLB.Size = new System.Drawing.Size(102, 16);
            this.PassForgotLLB.TabIndex = 10;
            this.PassForgotLLB.Text = "Quên mật khẩu?";
            // 
            // checkPass
            // 
            this.checkPass.Location = new System.Drawing.Point(427, 187);
            this.checkPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkPass.Name = "checkPass";
            // 
            // 
            // 
            this.checkPass.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.checkPass.Properties.Appearance.Options.UseFont = true;
            this.checkPass.Properties.Caption = "Hiện mật khẩu";
            this.checkPass.Size = new System.Drawing.Size(127, 25);
            this.checkPass.TabIndex = 11;
            this.checkPass.CheckedChanged += new System.EventHandler(this.checkEdit1_CheckedChanged);
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 350);
            this.Controls.Add(this.checkPass);
            this.Controls.Add(this.PassForgotLLB);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.PassTB);
            this.Controls.Add(this.AccountTB);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.LoginBtn);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "LogInForm";
            this.Text = "LogInForm";
            this.Load += new System.EventHandler(this.LogInForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AccountTB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PassTB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkPass.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton LoginBtn;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit AccountTB;
        private DevExpress.XtraEditors.TextEdit PassTB;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.HyperlinkLabelControl PassForgotLLB;
        private DevExpress.XtraEditors.CheckEdit checkPass;
    }
}