
namespace QuanLyCuaHangTapHoa
{
    partial class NhapHangForm
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
            this.dgv_PNH = new System.Windows.Forms.DataGridView();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lb1 = new System.Windows.Forms.Label();
            this.cbNPP = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbtt = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PNH)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_PNH
            // 
            this.dgv_PNH.AllowUserToAddRows = false;
            this.dgv_PNH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_PNH.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgv_PNH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PNH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ten,
            this.SL,
            this.Gia,
            this.TT,
            this.lh});
            this.dgv_PNH.Location = new System.Drawing.Point(11, 11);
            this.dgv_PNH.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_PNH.Name = "dgv_PNH";
            this.dgv_PNH.RowHeadersVisible = false;
            this.dgv_PNH.RowHeadersWidth = 51;
            this.dgv_PNH.RowTemplate.Height = 24;
            this.dgv_PNH.Size = new System.Drawing.Size(380, 428);
            this.dgv_PNH.TabIndex = 0;
            // 
            // Ten
            // 
            this.Ten.HeaderText = "Tên";
            this.Ten.MinimumWidth = 6;
            this.Ten.Name = "Ten";
            // 
            // SL
            // 
            this.SL.HeaderText = "Số Lượng";
            this.SL.MinimumWidth = 6;
            this.SL.Name = "SL";
            // 
            // Gia
            // 
            this.Gia.HeaderText = "Đơn Giá";
            this.Gia.MinimumWidth = 6;
            this.Gia.Name = "Gia";
            // 
            // TT
            // 
            this.TT.HeaderText = "tổng tièn";
            this.TT.MinimumWidth = 6;
            this.TT.Name = "TT";
            // 
            // lh
            // 
            this.lh.HeaderText = "mahang";
            this.lh.MinimumWidth = 6;
            this.lh.Name = "lh";
            this.lh.Visible = false;
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.Location = new System.Drawing.Point(394, 93);
            this.lb1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(105, 18);
            this.lb1.TabIndex = 1;
            this.lb1.Text = "Nhà Cung Cấp";
            // 
            // cbNPP
            // 
            this.cbNPP.FormattingEnabled = true;
            this.cbNPP.Location = new System.Drawing.Point(503, 93);
            this.cbNPP.Margin = new System.Windows.Forms.Padding(2);
            this.cbNPP.Name = "cbNPP";
            this.cbNPP.Size = new System.Drawing.Size(177, 21);
            this.cbNPP.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(461, 191);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 54);
            this.button1.TabIndex = 3;
            this.button1.Text = "Thêm sản phẩm từ file excel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(503, 282);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 35);
            this.button2.TabIndex = 4;
            this.button2.Text = "Thêm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(413, 141);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tổng tiền";
            // 
            // lbtt
            // 
            this.lbtt.AutoSize = true;
            this.lbtt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtt.Location = new System.Drawing.Point(509, 141);
            this.lbtt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbtt.Name = "lbtt";
            this.lbtt.Size = new System.Drawing.Size(16, 18);
            this.lbtt.TabIndex = 1;
            this.lbtt.Text = "0";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(596, 403);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(84, 35);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // NhapHangForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(691, 449);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbNPP);
            this.Controls.Add(this.lbtt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.dgv_PNH);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NhapHangForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NhapHangForm";
            this.Load += new System.EventHandler(this.NhapHangForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PNH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_PNH;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.ComboBox cbNPP;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbtt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TT;
        private System.Windows.Forms.DataGridViewTextBoxColumn lh;
        private System.Windows.Forms.Button btnThoat;
    }
}