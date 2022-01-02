﻿
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
            this.LvMatHang = new System.Windows.Forms.ListView();
            this.imglMH = new System.Windows.Forms.ImageList(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.tbSDTKH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.lbTamTinh = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTennv = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label10 = new System.Windows.Forms.Label();
            this.tbTienNhan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDTL = new System.Windows.Forms.TextBox();
            this.lbDiem = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvHD);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1203, 847);
            this.panel1.TabIndex = 0;
            // 
            // dgvHD
            // 
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
            this.dgvHD.Location = new System.Drawing.Point(0, 650);
            this.dgvHD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvHD.Name = "dgvHD";
            this.dgvHD.RowHeadersVisible = false;
            this.dgvHD.RowHeadersWidth = 51;
            this.dgvHD.Size = new System.Drawing.Size(578, 197);
            this.dgvHD.TabIndex = 2;
            this.dgvHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHD_CellClick);
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
            // 
            // DG
            // 
            this.DG.HeaderText = "Đơn Giá";
            this.DG.MinimumWidth = 6;
            this.DG.Name = "DG";
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
            // 
            // Xoa
            // 
            this.Xoa.HeaderText = "Xoá";
            this.Xoa.MinimumWidth = 6;
            this.Xoa.Name = "Xoa";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.LvMatHang);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(578, 650);
            this.panel3.TabIndex = 1;
            // 
            // LvMatHang
            // 
            this.LvMatHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LvMatHang.HideSelection = false;
            this.LvMatHang.LargeImageList = this.imglMH;
            this.LvMatHang.Location = new System.Drawing.Point(0, 23);
            this.LvMatHang.Name = "LvMatHang";
            this.LvMatHang.Size = new System.Drawing.Size(578, 627);
            this.LvMatHang.TabIndex = 2;
            this.LvMatHang.UseCompatibleStateImageBehavior = false;
            this.LvMatHang.SelectedIndexChanged += new System.EventHandler(this.ListShowMatHang_SelectedIndexChanged);
            // 
            // imglMH
            // 
            this.imglMH.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imglMH.ImageSize = new System.Drawing.Size(64, 64);
            this.imglMH.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(578, 23);
            this.textBox1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbDiem);
            this.panel2.Controls.Add(this.tbDTL);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.iconButton2);
            this.panel2.Controls.Add(this.tbTienNhan);
            this.panel2.Controls.Add(this.tbSDTKH);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lbTongTien);
            this.panel2.Controls.Add(this.lbTamTinh);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lbTennv);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(578, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(625, 847);
            this.panel2.TabIndex = 0;
            // 
            // iconButton2
            // 
            this.iconButton2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.Location = new System.Drawing.Point(19, 777);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(581, 55);
            this.iconButton2.TabIndex = 3;
            this.iconButton2.Text = "Thanh Toán";
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // tbSDTKH
            // 
            this.tbSDTKH.Location = new System.Drawing.Point(261, 142);
            this.tbSDTKH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbSDTKH.Name = "tbSDTKH";
            this.tbSDTKH.Size = new System.Drawing.Size(242, 23);
            this.tbSDTKH.TabIndex = 1;
            this.tbSDTKH.TextChanged += new System.EventHandler(this.tbSDTKH_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-7, 415);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(643, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "----------------------------------------------------------------------";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(108, 443);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 29);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tổng Tiền:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(108, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Sử dụng điểm:";
            // 
            // lbTongTien
            // 
            this.lbTongTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTongTien.AutoSize = true;
            this.lbTongTien.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongTien.Location = new System.Drawing.Point(373, 443);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(49, 29);
            this.lbTongTien.TabIndex = 0;
            this.lbTongTien.Text = "xxx";
            // 
            // lbTamTinh
            // 
            this.lbTamTinh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTamTinh.AutoSize = true;
            this.lbTamTinh.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTamTinh.Location = new System.Drawing.Point(373, 282);
            this.lbTamTinh.Name = "lbTamTinh";
            this.lbTamTinh.Size = new System.Drawing.Size(49, 29);
            this.lbTamTinh.TabIndex = 0;
            this.lbTamTinh.Text = "xxx";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tạm Tính:";
            // 
            // lbTennv
            // 
            this.lbTennv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTennv.AutoSize = true;
            this.lbTennv.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTennv.Location = new System.Drawing.Point(180, 11);
            this.lbTennv.Name = "lbTennv";
            this.lbTennv.Size = new System.Drawing.Size(282, 48);
            this.lbTennv.TabIndex = 0;
            this.lbTennv.Text = "Time + tên NV";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(196, 147);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 17);
            this.label10.TabIndex = 4;
            this.label10.Text = "SDT:";
            // 
            // tbTienNhan
            // 
            this.tbTienNhan.Location = new System.Drawing.Point(233, 534);
            this.tbTienNhan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbTienNhan.Name = "tbTienNhan";
            this.tbTienNhan.Size = new System.Drawing.Size(242, 23);
            this.tbTienNhan.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 534);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tiền khách đưa:";
            // 
            // tbDTL
            // 
            this.tbDTL.Location = new System.Drawing.Point(341, 331);
            this.tbDTL.Name = "tbDTL";
            this.tbDTL.Size = new System.Drawing.Size(100, 23);
            this.tbDTL.TabIndex = 5;
            this.tbDTL.Text = "0";
            this.tbDTL.TextChanged += new System.EventHandler(this.tbDTL_TextChanged);
            // 
            // lbDiem
            // 
            this.lbDiem.AutoSize = true;
            this.lbDiem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiem.Location = new System.Drawing.Point(466, 330);
            this.lbDiem.Name = "lbDiem";
            this.lbDiem.Size = new System.Drawing.Size(21, 24);
            this.lbDiem.TabIndex = 6;
            this.lbDiem.Text = "0";
            // 
            // FormBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 847);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormBanHang";
            this.Text = "FormBanHang";
            this.Load += new System.EventHandler(this.FormBanHang_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dgvHD;
        private System.Windows.Forms.TextBox tbSDTKH;
        private System.Windows.Forms.Label lbTennv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbTongTien;
        private System.Windows.Forms.Label lbTamTinh;
        private System.Windows.Forms.ListView LvMatHang;
        private System.Windows.Forms.ImageList imglMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG;
        private System.Windows.Forms.DataGridViewButtonColumn Giam;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewButtonColumn Tang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tong;
        private System.Windows.Forms.DataGridViewButtonColumn Xoa;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTienNhan;
        private System.Windows.Forms.TextBox tbDTL;
        private System.Windows.Forms.Label lbDiem;
    }
}