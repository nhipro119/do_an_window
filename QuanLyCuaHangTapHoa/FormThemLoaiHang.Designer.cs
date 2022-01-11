
namespace QuanLyCuaHangTapHoa
{
    partial class FormThemLoaiHang
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btThem = new System.Windows.Forms.Button();
            this.dgvLH = new System.Windows.Forms.DataGridView();
            this.Ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbTimKiem = new System.Windows.Forms.TextBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTLH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMLH = new System.Windows.Forms.TextBox();
            this.lbMa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLH)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(329, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Loại Hàng";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(329, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Loại Hàng";
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(333, 181);
            this.btThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(112, 46);
            this.btThem.TabIndex = 2;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // dgvLH
            // 
            this.dgvLH.AllowUserToAddRows = false;
            this.dgvLH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLH.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvLH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma,
            this.Ten});
            this.dgvLH.Location = new System.Drawing.Point(15, 39);
            this.dgvLH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvLH.Name = "dgvLH";
            this.dgvLH.RowHeadersVisible = false;
            this.dgvLH.RowHeadersWidth = 51;
            this.dgvLH.RowTemplate.Height = 24;
            this.dgvLH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLH.Size = new System.Drawing.Size(309, 418);
            this.dgvLH.TabIndex = 3;
            this.dgvLH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLH_CellClick);
            // 
            // Ma
            // 
            this.Ma.HeaderText = "Mã";
            this.Ma.MinimumWidth = 6;
            this.Ma.Name = "Ma";
            // 
            // Ten
            // 
            this.Ten.HeaderText = "Tên";
            this.Ten.MinimumWidth = 6;
            this.Ten.Name = "Ten";
            // 
            // tbTimKiem
            // 
            this.tbTimKiem.Location = new System.Drawing.Point(15, 11);
            this.tbTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTimKiem.Name = "tbTimKiem";
            this.tbTimKiem.Size = new System.Drawing.Size(309, 22);
            this.tbTimKiem.TabIndex = 4;
            this.tbTimKiem.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(457, 181);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(107, 46);
            this.iconButton1.TabIndex = 5;
            this.iconButton1.Text = "Xoá";
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(437, 412);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(124, 46);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(436, 59);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "________________";
            // 
            // tbTLH
            // 
            this.tbTLH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTLH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTLH.Location = new System.Drawing.Point(440, 54);
            this.tbTLH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbTLH.Name = "tbTLH";
            this.tbTLH.Size = new System.Drawing.Size(133, 19);
            this.tbTLH.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(436, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "________________";
            this.label4.Visible = false;
            // 
            // tbMLH
            // 
            this.tbMLH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMLH.Enabled = false;
            this.tbMLH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMLH.Location = new System.Drawing.Point(440, 20);
            this.tbMLH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbMLH.Name = "tbMLH";
            this.tbMLH.Size = new System.Drawing.Size(133, 19);
            this.tbMLH.TabIndex = 7;
            this.tbMLH.Visible = false;
            // 
            // lbMa
            // 
            this.lbMa.AutoSize = true;
            this.lbMa.Location = new System.Drawing.Point(349, 289);
            this.lbMa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMa.Name = "lbMa";
            this.lbMa.Size = new System.Drawing.Size(46, 17);
            this.lbMa.TabIndex = 8;
            this.lbMa.Text = "label5";
            this.lbMa.Visible = false;
            // 
            // FormThemLoaiHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(576, 471);
            this.Controls.Add(this.lbMa);
            this.Controls.Add(this.tbMLH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbTLH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.tbTimKiem);
            this.Controls.Add(this.dgvLH);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormThemLoaiHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormThemLoaiHang";
            this.Load += new System.EventHandler(this.FormThemLoaiHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.DataGridView dgvLH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.TextBox tbTimKiem;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTLH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMLH;
        private System.Windows.Forms.Label lbMa;
    }
}