
namespace QuanLyCuaHangTapHoa
{
    partial class FormMatHang
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
            this.dgvHH = new System.Windows.Forms.DataGridView();
            this.mahh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NPP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnThemMatHang = new FontAwesome.Sharp.IconButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tbTimKiem = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbNPP = new System.Windows.Forms.ComboBox();
            this.cbLH = new System.Windows.Forms.ComboBox();
            this.btThemLH = new System.Windows.Forms.Button();
            this.pbHH = new System.Windows.Forms.PictureBox();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.tbSLT = new System.Windows.Forms.TextBox();
            this.tbGB = new System.Windows.Forms.TextBox();
            this.tbGG = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbDVT = new System.Windows.Forms.Label();
            this.lbTL = new System.Windows.Forms.Label();
            this.lbNCC = new System.Windows.Forms.Label();
            this.lbLH = new System.Windows.Forms.Label();
            this.lbTH = new System.Windows.Forms.Label();
            this.lbMH = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHH)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHH)).BeginInit();
            this.SuspendLayout();
            // 
            // panelChildForm
            // 
            this.panelChildForm.Controls.Add(this.dgvHH);
            this.panelChildForm.Controls.Add(this.panel5);
            this.panelChildForm.Controls.Add(this.panel1);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(0, 0);
            this.panelChildForm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1203, 847);
            this.panelChildForm.TabIndex = 8;
            // 
            // dgvHH
            // 
            this.dgvHH.AllowUserToAddRows = false;
            this.dgvHH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mahh,
            this.Ten,
            this.Loai,
            this.NPP,
            this.GV,
            this.GB,
            this.DVT,
            this.TL,
            this.SLT});
            this.dgvHH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHH.Location = new System.Drawing.Point(0, 44);
            this.dgvHH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvHH.Name = "dgvHH";
            this.dgvHH.RowHeadersVisible = false;
            this.dgvHH.RowHeadersWidth = 51;
            this.dgvHH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHH.Size = new System.Drawing.Size(792, 803);
            this.dgvHH.TabIndex = 11;
            this.dgvHH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHH_CellClick);
            // 
            // mahh
            // 
            this.mahh.HeaderText = "mã";
            this.mahh.MinimumWidth = 6;
            this.mahh.Name = "mahh";
            // 
            // Ten
            // 
            this.Ten.HeaderText = "Tên";
            this.Ten.MinimumWidth = 6;
            this.Ten.Name = "Ten";
            // 
            // Loai
            // 
            this.Loai.HeaderText = "Loại";
            this.Loai.MinimumWidth = 6;
            this.Loai.Name = "Loai";
            // 
            // NPP
            // 
            this.NPP.HeaderText = "NPP";
            this.NPP.MinimumWidth = 6;
            this.NPP.Name = "NPP";
            // 
            // GV
            // 
            this.GV.HeaderText = "Giá Vốn";
            this.GV.MinimumWidth = 6;
            this.GV.Name = "GV";
            // 
            // GB
            // 
            this.GB.HeaderText = "Giá Bán";
            this.GB.MinimumWidth = 6;
            this.GB.Name = "GB";
            // 
            // DVT
            // 
            this.DVT.HeaderText = "DVT";
            this.DVT.MinimumWidth = 6;
            this.DVT.Name = "DVT";
            // 
            // TL
            // 
            this.TL.HeaderText = "Trọng Lượng";
            this.TL.MinimumWidth = 6;
            this.TL.Name = "TL";
            // 
            // SLT
            // 
            this.SLT.HeaderText = "Số Lượng Tồn";
            this.SLT.MinimumWidth = 6;
            this.SLT.Name = "SLT";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnThemMatHang);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(792, 44);
            this.panel5.TabIndex = 10;
            // 
            // btnThemMatHang
            // 
            this.btnThemMatHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemMatHang.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnThemMatHang.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnThemMatHang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThemMatHang.IconSize = 18;
            this.btnThemMatHang.Location = new System.Drawing.Point(675, 0);
            this.btnThemMatHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThemMatHang.Name = "btnThemMatHang";
            this.btnThemMatHang.Size = new System.Drawing.Size(117, 44);
            this.btnThemMatHang.TabIndex = 2;
            this.btnThemMatHang.Text = "Thêm Mặt Hàng";
            this.btnThemMatHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemMatHang.UseVisualStyleBackColor = true;
            this.btnThemMatHang.Click += new System.EventHandler(this.btnThemMatHang_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.tbTimKiem);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(647, 44);
            this.panel6.TabIndex = 0;
            // 
            // tbTimKiem
            // 
            this.tbTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTimKiem.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTimKiem.Location = new System.Drawing.Point(0, 0);
            this.tbTimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbTimKiem.Multiline = true;
            this.tbTimKiem.Name = "tbTimKiem";
            this.tbTimKiem.Size = new System.Drawing.Size(647, 44);
            this.tbTimKiem.TabIndex = 1;
            this.tbTimKiem.TextChanged += new System.EventHandler(this.tbTimKiem_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbNPP);
            this.panel1.Controls.Add(this.cbLH);
            this.panel1.Controls.Add(this.btThemLH);
            this.panel1.Controls.Add(this.pbHH);
            this.panel1.Controls.Add(this.btXoa);
            this.panel1.Controls.Add(this.btSua);
            this.panel1.Controls.Add(this.tbSLT);
            this.panel1.Controls.Add(this.tbGB);
            this.panel1.Controls.Add(this.tbGG);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lbDVT);
            this.panel1.Controls.Add(this.lbTL);
            this.panel1.Controls.Add(this.lbNCC);
            this.panel1.Controls.Add(this.lbLH);
            this.panel1.Controls.Add(this.lbTH);
            this.panel1.Controls.Add(this.lbMH);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(792, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.panel1.Size = new System.Drawing.Size(411, 847);
            this.panel1.TabIndex = 7;
            // 
            // cbNPP
            // 
            this.cbNPP.FormattingEnabled = true;
            this.cbNPP.Location = new System.Drawing.Point(278, 88);
            this.cbNPP.Name = "cbNPP";
            this.cbNPP.Size = new System.Drawing.Size(121, 24);
            this.cbNPP.TabIndex = 6;
            this.cbNPP.SelectedIndexChanged += new System.EventHandler(this.cbNPP_SelectedIndexChanged);
            // 
            // cbLH
            // 
            this.cbLH.FormattingEnabled = true;
            this.cbLH.Location = new System.Drawing.Point(169, 58);
            this.cbLH.Name = "cbLH";
            this.cbLH.Size = new System.Drawing.Size(121, 24);
            this.cbLH.TabIndex = 6;
            this.cbLH.SelectedIndexChanged += new System.EventHandler(this.cbLH_SelectedIndexChanged);
            // 
            // btThemLH
            // 
            this.btThemLH.Location = new System.Drawing.Point(29, 70);
            this.btThemLH.Name = "btThemLH";
            this.btThemLH.Size = new System.Drawing.Size(94, 42);
            this.btThemLH.TabIndex = 5;
            this.btThemLH.Text = "Thêm Loại Hàng";
            this.btThemLH.UseVisualStyleBackColor = true;
            this.btThemLH.Click += new System.EventHandler(this.btThemLH_Click);
            // 
            // pbHH
            // 
            this.pbHH.Location = new System.Drawing.Point(92, 614);
            this.pbHH.Name = "pbHH";
            this.pbHH.Size = new System.Drawing.Size(237, 152);
            this.pbHH.TabIndex = 4;
            this.pbHH.TabStop = false;
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(278, 795);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 23);
            this.btXoa.TabIndex = 3;
            this.btXoa.Text = "Xoá";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(165, 795);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(75, 23);
            this.btSua.TabIndex = 3;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // tbSLT
            // 
            this.tbSLT.Location = new System.Drawing.Point(216, 541);
            this.tbSLT.Name = "tbSLT";
            this.tbSLT.Size = new System.Drawing.Size(100, 23);
            this.tbSLT.TabIndex = 2;
            // 
            // tbGB
            // 
            this.tbGB.Location = new System.Drawing.Point(215, 483);
            this.tbGB.Name = "tbGB";
            this.tbGB.Size = new System.Drawing.Size(100, 23);
            this.tbGB.TabIndex = 2;
            // 
            // tbGG
            // 
            this.tbGG.Location = new System.Drawing.Point(215, 442);
            this.tbGG.Name = "tbGG";
            this.tbGG.Size = new System.Drawing.Size(100, 23);
            this.tbGG.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(109, 547);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "SLT";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(109, 498);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Giá Bán";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(109, 448);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Giá Gốc";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(109, 388);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Trọng Lượng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(109, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Đơn Vị Tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(109, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nhà Cung Cấp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Loại Hàng";
            // 
            // lbDVT
            // 
            this.lbDVT.AutoSize = true;
            this.lbDVT.Location = new System.Drawing.Point(212, 318);
            this.lbDVT.Name = "lbDVT";
            this.lbDVT.Size = new System.Drawing.Size(29, 17);
            this.lbDVT.TabIndex = 1;
            this.lbDVT.Text = "dvt";
            // 
            // lbTL
            // 
            this.lbTL.AutoSize = true;
            this.lbTL.Location = new System.Drawing.Point(212, 388);
            this.lbTL.Name = "lbTL";
            this.lbTL.Size = new System.Drawing.Size(15, 17);
            this.lbTL.TabIndex = 1;
            this.lbTL.Text = "tl";
            // 
            // lbNCC
            // 
            this.lbNCC.AutoSize = true;
            this.lbNCC.Location = new System.Drawing.Point(212, 258);
            this.lbNCC.Name = "lbNCC";
            this.lbNCC.Size = new System.Drawing.Size(30, 17);
            this.lbNCC.TabIndex = 1;
            this.lbNCC.Text = "ncc";
            // 
            // lbLH
            // 
            this.lbLH.AutoSize = true;
            this.lbLH.Location = new System.Drawing.Point(212, 206);
            this.lbLH.Name = "lbLH";
            this.lbLH.Size = new System.Drawing.Size(27, 17);
            this.lbLH.TabIndex = 1;
            this.lbLH.Text = "loại";
            // 
            // lbTH
            // 
            this.lbTH.AutoSize = true;
            this.lbTH.Location = new System.Drawing.Point(212, 165);
            this.lbTH.Name = "lbTH";
            this.lbTH.Size = new System.Drawing.Size(28, 17);
            this.lbTH.TabIndex = 1;
            this.lbTH.Text = "tên";
            // 
            // lbMH
            // 
            this.lbMH.AutoSize = true;
            this.lbMH.Location = new System.Drawing.Point(212, 126);
            this.lbMH.Name = "lbMH";
            this.lbMH.Size = new System.Drawing.Size(27, 17);
            this.lbMH.TabIndex = 1;
            this.lbMH.Text = "mã";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên Hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hàng Hóa";
            // 
            // FormMatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 847);
            this.Controls.Add(this.panelChildForm);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMatHang";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FormMatHang_Load);
            this.panelChildForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHH)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbTimKiem;
        private FontAwesome.Sharp.IconButton btnThemMatHang;
        private System.Windows.Forms.DataGridView dgvHH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loai;
        private System.Windows.Forms.DataGridViewTextBoxColumn NPP;
        private System.Windows.Forms.DataGridViewTextBoxColumn GV;
        private System.Windows.Forms.DataGridViewTextBoxColumn GB;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TL;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLT;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbMH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSLT;
        private System.Windows.Forms.TextBox tbGB;
        private System.Windows.Forms.TextBox tbGG;
        private System.Windows.Forms.Label lbDVT;
        private System.Windows.Forms.Label lbTL;
        private System.Windows.Forms.Label lbNCC;
        private System.Windows.Forms.Label lbLH;
        private System.Windows.Forms.Label lbTH;
        private System.Windows.Forms.PictureBox pbHH;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btThemLH;
        private System.Windows.Forms.ComboBox cbNPP;
        private System.Windows.Forms.ComboBox cbLH;
    }
}