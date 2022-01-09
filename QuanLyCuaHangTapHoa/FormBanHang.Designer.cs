
namespace QuanLyCuaHangTapHoa
{
    partial class FormBanHang
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.LvMatHang = new System.Windows.Forms.ListView();
            this.imglMH = new System.Windows.Forms.ImageList(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvHD = new System.Windows.Forms.DataGridView();
            this.ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Giam = new System.Windows.Forms.DataGridViewButtonColumn();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tang = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Tong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Xoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbSDD = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbDTLSD = new System.Windows.Forms.Label();
            this.lbTamTinh = new System.Windows.Forms.Label();
            this.lbDiem = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbTimKiem = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSDTKH = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbTienNhan = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LvMatHang);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1031, 688);
            this.panel1.TabIndex = 0;
            // 
            // LvMatHang
            // 
            this.LvMatHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LvMatHang.HideSelection = false;
            this.LvMatHang.LargeImageList = this.imglMH;
            this.LvMatHang.Location = new System.Drawing.Point(0, 48);
            this.LvMatHang.Name = "LvMatHang";
            this.LvMatHang.Size = new System.Drawing.Size(700, 219);
            this.LvMatHang.TabIndex = 11;
            this.LvMatHang.UseCompatibleStateImageBehavior = false;
            this.LvMatHang.DoubleClick += new System.EventHandler(this.ListShowMatHang_SelectedIndexChanged);
            // 
            // imglMH
            // 
            this.imglMH.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imglMH.ImageSize = new System.Drawing.Size(64, 64);
            this.imglMH.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvHD);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 267);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(700, 421);
            this.panel4.TabIndex = 10;
            // 
            // dgvHD
            // 
            this.dgvHD.AllowUserToAddRows = false;
            this.dgvHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHD.ColumnHeadersVisible = false;
            this.dgvHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ma,
            this.ten,
            this.DG,
            this.Giam,
            this.SL,
            this.Tang,
            this.Tong,
            this.Xoa});
            this.dgvHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHD.Location = new System.Drawing.Point(0, 0);
            this.dgvHD.Name = "dgvHD";
            this.dgvHD.RowHeadersVisible = false;
            this.dgvHD.RowHeadersWidth = 51;
            this.dgvHD.Size = new System.Drawing.Size(700, 421);
            this.dgvHD.TabIndex = 2;
            this.dgvHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHD_CellClick);
            this.dgvHD.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHD_CellEndEdit);
            // 
            // ma
            // 
            this.ma.HeaderText = "Column1";
            this.ma.MinimumWidth = 6;
            this.ma.Name = "ma";
            this.ma.Visible = false;
            // 
            // ten
            // 
            this.ten.HeaderText = "Tên Hàng";
            this.ten.MinimumWidth = 6;
            this.ten.Name = "ten";
            this.ten.ReadOnly = true;
            // 
            // DG
            // 
            this.DG.HeaderText = "Đơn Giá";
            this.DG.MinimumWidth = 6;
            this.DG.Name = "DG";
            this.DG.ReadOnly = true;
            // 
            // Giam
            // 
            this.Giam.FillWeight = 15F;
            this.Giam.HeaderText = "Giảm";
            this.Giam.MinimumWidth = 6;
            this.Giam.Name = "Giam";
            // 
            // SL
            // 
            this.SL.HeaderText = "Số Lượng";
            this.SL.MinimumWidth = 6;
            this.SL.Name = "SL";
            // 
            // Tang
            // 
            this.Tang.FillWeight = 15F;
            this.Tang.HeaderText = "Tăng";
            this.Tang.MinimumWidth = 6;
            this.Tang.Name = "Tang";
            // 
            // Tong
            // 
            this.Tong.HeaderText = "Tổng Tiền";
            this.Tong.MinimumWidth = 6;
            this.Tong.Name = "Tong";
            this.Tong.ReadOnly = true;
            // 
            // Xoa
            // 
            this.Xoa.HeaderText = "Xoá";
            this.Xoa.MinimumWidth = 6;
            this.Xoa.Name = "Xoa";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.tbTienNhan);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.tbSDTKH);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.iconButton2);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.cbSDD);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.lbTongTien);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.lbDTLSD);
            this.panel3.Controls.Add(this.lbTamTinh);
            this.panel3.Controls.Add(this.lbDiem);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(700, 48);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(331, 640);
            this.panel3.TabIndex = 9;
            // 
            // iconButton2
            // 
            this.iconButton2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.Location = new System.Drawing.Point(10, 546);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(309, 82);
            this.iconButton2.TabIndex = 16;
            this.iconButton2.Text = "Thanh Toán";
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tiền khách đưa:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 19);
            this.label10.TabIndex = 4;
            this.label10.Text = "SDT:";
            // 
            // cbSDD
            // 
            this.cbSDD.AutoSize = true;
            this.cbSDD.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSDD.Location = new System.Drawing.Point(10, 152);
            this.cbSDD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSDD.Name = "cbSDD";
            this.cbSDD.Size = new System.Drawing.Size(143, 23);
            this.cbSDD.TabIndex = 7;
            this.cbSDD.Text = "Sử Dụng Điểm";
            this.cbSDD.UseVisualStyleBackColor = true;
            this.cbSDD.CheckedChanged += new System.EventHandler(this.cbSDD_CheckedChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tổng Tiền:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(325, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "---------------------------------------------";
            // 
            // lbTongTien
            // 
            this.lbTongTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTongTien.AutoSize = true;
            this.lbTongTien.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongTien.Location = new System.Drawing.Point(255, 200);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(20, 23);
            this.lbTongTien.TabIndex = 0;
            this.lbTongTien.Text = "0";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tạm Tính:";
            // 
            // lbDTLSD
            // 
            this.lbDTLSD.AutoSize = true;
            this.lbDTLSD.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDTLSD.Location = new System.Drawing.Point(239, 153);
            this.lbDTLSD.Name = "lbDTLSD";
            this.lbDTLSD.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbDTLSD.Size = new System.Drawing.Size(18, 19);
            this.lbDTLSD.TabIndex = 6;
            this.lbDTLSD.Text = "0";
            // 
            // lbTamTinh
            // 
            this.lbTamTinh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTamTinh.AutoSize = true;
            this.lbTamTinh.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTamTinh.Location = new System.Drawing.Point(255, 122);
            this.lbTamTinh.Name = "lbTamTinh";
            this.lbTamTinh.Size = new System.Drawing.Size(20, 23);
            this.lbTamTinh.TabIndex = 0;
            this.lbTamTinh.Text = "0";
            // 
            // lbDiem
            // 
            this.lbDiem.AutoSize = true;
            this.lbDiem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiem.Location = new System.Drawing.Point(284, 153);
            this.lbDiem.Name = "lbDiem";
            this.lbDiem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbDiem.Size = new System.Drawing.Size(18, 19);
            this.lbDiem.TabIndex = 6;
            this.lbDiem.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(263, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "/";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.tbTimKiem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1031, 48);
            this.panel2.TabIndex = 8;
            // 
            // tbTimKiem
            // 
            this.tbTimKiem.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTimKiem.Location = new System.Drawing.Point(0, 7);
            this.tbTimKiem.Multiline = true;
            this.tbTimKiem.Name = "tbTimKiem";
            this.tbTimKiem.Size = new System.Drawing.Size(555, 35);
            this.tbTimKiem.TabIndex = 1;
            this.tbTimKiem.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(241, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "_______________________________________";
            // 
            // tbSDTKH
            // 
            this.tbSDTKH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSDTKH.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSDTKH.Location = new System.Drawing.Point(60, 69);
            this.tbSDTKH.Name = "tbSDTKH";
            this.tbSDTKH.Size = new System.Drawing.Size(236, 20);
            this.tbSDTKH.TabIndex = 18;
            this.tbSDTKH.TextChanged += new System.EventHandler(this.tbSDTKH_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(142, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "______________________";
            // 
            // tbTienNhan
            // 
            this.tbTienNhan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTienNhan.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTienNhan.Location = new System.Drawing.Point(145, 256);
            this.tbTienNhan.Name = "tbTienNhan";
            this.tbTienNhan.Size = new System.Drawing.Size(133, 20);
            this.tbTienNhan.TabIndex = 20;
            this.tbTienNhan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FormBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 688);
            this.Controls.Add(this.panel1);
            this.Name = "FormBanHang";
            this.Text = "FormBanHang";
            this.Load += new System.EventHandler(this.FormBanHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ImageList imglMH;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbTimKiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbSDD;
        private System.Windows.Forms.Label lbDTLSD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbTongTien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG;
        private System.Windows.Forms.DataGridViewButtonColumn Giam;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewButtonColumn Tang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tong;
        private System.Windows.Forms.DataGridViewButtonColumn Xoa;
        private System.Windows.Forms.Label lbDiem;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTamTinh;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListView LvMatHang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSDTKH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbTienNhan;
    }
}