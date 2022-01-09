
namespace QuanLyCuaHangTapHoa
{
    partial class FormNhapHang
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
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.dgv_pnh = new System.Windows.Forms.DataGridView();
            this.npp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnNhapHang = new FontAwesome.Sharp.IconButton();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pnh)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelChildForm
            // 
            this.panelChildForm.Controls.Add(this.dgv_pnh);
            this.panelChildForm.Controls.Add(this.panel5);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(0, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1031, 688);
            this.panelChildForm.TabIndex = 9;
            // 
            // dgv_pnh
            // 
            this.dgv_pnh.AllowUserToAddRows = false;
            this.dgv_pnh.AllowUserToDeleteRows = false;
            this.dgv_pnh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_pnh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pnh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.npp,
            this.NgayNhap,
            this.TT,
            this.ma});
            this.dgv_pnh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_pnh.Location = new System.Drawing.Point(0, 48);
            this.dgv_pnh.Name = "dgv_pnh";
            this.dgv_pnh.ReadOnly = true;
            this.dgv_pnh.RowHeadersVisible = false;
            this.dgv_pnh.RowHeadersWidth = 51;
            this.dgv_pnh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_pnh.Size = new System.Drawing.Size(1031, 640);
            this.dgv_pnh.TabIndex = 11;
            this.dgv_pnh.DoubleClick += new System.EventHandler(this.dgv_pnh_DoubleClick);
            // 
            // npp
            // 
            this.npp.HeaderText = "Nhà phân phối";
            this.npp.MinimumWidth = 6;
            this.npp.Name = "npp";
            this.npp.ReadOnly = true;
            // 
            // NgayNhap
            // 
            this.NgayNhap.HeaderText = "Ngày Nhập";
            this.NgayNhap.MinimumWidth = 6;
            this.NgayNhap.Name = "NgayNhap";
            this.NgayNhap.ReadOnly = true;
            // 
            // TT
            // 
            this.TT.HeaderText = "Tổng tiền thanh toán";
            this.TT.MinimumWidth = 6;
            this.TT.Name = "TT";
            this.TT.ReadOnly = true;
            // 
            // ma
            // 
            this.ma.HeaderText = "Column1";
            this.ma.MinimumWidth = 6;
            this.ma.Name = "ma";
            this.ma.ReadOnly = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.panel5.Controls.Add(this.textBox1);
            this.panel5.Controls.Add(this.btnNhapHang);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1031, 48);
            this.panel5.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(0, 7);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(555, 35);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Tìm Kiếm";
            // 
            // btnNhapHang
            // 
            this.btnNhapHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNhapHang.BackColor = System.Drawing.Color.White;
            this.btnNhapHang.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNhapHang.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapHang.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnNhapHang.IconColor = System.Drawing.Color.Black;
            this.btnNhapHang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNhapHang.IconSize = 18;
            this.btnNhapHang.Location = new System.Drawing.Point(862, 0);
            this.btnNhapHang.Name = "btnNhapHang";
            this.btnNhapHang.Size = new System.Drawing.Size(110, 48);
            this.btnNhapHang.TabIndex = 2;
            this.btnNhapHang.Text = "Nhập Hàng";
            this.btnNhapHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNhapHang.UseVisualStyleBackColor = false;
            this.btnNhapHang.Click += new System.EventHandler(this.btnNhapHang_Click);
            // 
            // FormNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 688);
            this.Controls.Add(this.panelChildForm);
            this.Name = "FormNhapHang";
            this.Text = "FormNhapHang";
            this.Load += new System.EventHandler(this.FormNhapHang_Load);
            this.panelChildForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pnh)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.DataGridView dgv_pnh;
        private System.Windows.Forms.Panel panel5;
        private FontAwesome.Sharp.IconButton btnNhapHang;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn npp;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma;
    }
}