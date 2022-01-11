
namespace QuanLyCuaHangTapHoa
{
    partial class FormBangThongKe
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
            this.components = new System.ComponentModel.Container();
            this.formAssistant1 = new DevExpress.XtraBars.FormAssistant();
            this.dashboardViewer1 = new DevExpress.DashboardWin.DashboardViewer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dashboardViewer1)).BeginInit();
            this.SuspendLayout();
            // 
            // dashboardViewer1
            // 
            this.dashboardViewer1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.dashboardViewer1.Appearance.Options.UseBackColor = true;
            //this.dashboardViewer1.DashboardSource = new System.Uri("C:\\Users\\PraKo\\Desktop\\New folder\\thongke.xml", System.UriKind.Absolute);
            this.dashboardViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboardViewer1.Location = new System.Drawing.Point(0, 0);
            this.dashboardViewer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dashboardViewer1.Name = "dashboardViewer1";
            this.dashboardViewer1.Size = new System.Drawing.Size(1203, 847);
            this.dashboardViewer1.TabIndex = 0;
            // 
            // FormBangThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 847);
            this.Controls.Add(this.dashboardViewer1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormBangThongKe";
            this.Text = "FormBangThongKe";
            this.Load += new System.EventHandler(this.FormBangThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dashboardViewer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.FormAssistant formAssistant1;
        private DevExpress.DashboardWin.DashboardViewer dashboardViewer1;
    }
}