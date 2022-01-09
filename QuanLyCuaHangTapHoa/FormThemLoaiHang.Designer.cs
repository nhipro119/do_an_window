
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
            this.tbMLH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTLH = new System.Windows.Forms.TextBox();
            this.btThem = new System.Windows.Forms.Button();
            this.dgvLH = new System.Windows.Forms.DataGridView();
            this.Ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbTimKiem = new System.Windows.Forms.TextBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.lbMa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLH)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(245, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Loại Hàng";
            // 
            // tbMLH
            // 
            this.tbMLH.Enabled = false;
            this.tbMLH.Location = new System.Drawing.Point(328, 43);
            this.tbMLH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbMLH.Name = "tbMLH";
            this.tbMLH.Size = new System.Drawing.Size(76, 20);
            this.tbMLH.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Loại Hàng";
            // 
            // tbTLH
            // 
            this.tbTLH.Location = new System.Drawing.Point(328, 79);
            this.tbTLH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbTLH.Name = "tbTLH";
            this.tbTLH.Size = new System.Drawing.Size(76, 20);
            this.tbTLH.TabIndex = 1;
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(255, 151);
            this.btThem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(84, 37);
            this.btThem.TabIndex = 2;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // dgvLH
            // 
            this.dgvLH.AllowUserToAddRows = false;
            this.dgvLH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma,
            this.Ten});
            this.dgvLH.Location = new System.Drawing.Point(9, 74);
            this.dgvLH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvLH.Name = "dgvLH";
            this.dgvLH.RowHeadersVisible = false;
            this.dgvLH.RowHeadersWidth = 51;
            this.dgvLH.RowTemplate.Height = 24;
            this.dgvLH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLH.Size = new System.Drawing.Size(232, 299);
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
            this.tbTimKiem.Location = new System.Drawing.Point(9, 51);
            this.tbTimKiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbTimKiem.Name = "tbTimKiem";
            this.tbTimKiem.Size = new System.Drawing.Size(233, 20);
            this.tbTimKiem.TabIndex = 4;
            this.tbTimKiem.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(344, 151);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(80, 37);
            this.iconButton1.TabIndex = 5;
            this.iconButton1.Text = "Xoá";
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // lbMa
            // 
            this.lbMa.AutoSize = true;
            this.lbMa.Location = new System.Drawing.Point(245, 112);
            this.lbMa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMa.Name = "lbMa";
            this.lbMa.Size = new System.Drawing.Size(154, 13);
            this.lbMa.TabIndex = 0;
            this.lbMa.Text = "không cần chính sửa label này";
            this.lbMa.Visible = false;
            // 
            // FormThemLoaiHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 383);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.tbTimKiem);
            this.Controls.Add(this.dgvLH);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.tbTLH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbMLH);
            this.Controls.Add(this.lbMa);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.TextBox tbMLH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTLH;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.DataGridView dgvLH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.TextBox tbTimKiem;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label lbMa;
    }
}