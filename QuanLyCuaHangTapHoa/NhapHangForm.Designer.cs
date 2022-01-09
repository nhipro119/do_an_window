
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
            this.lb1 = new System.Windows.Forms.Label();
            this.cbNPP = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbtt = new System.Windows.Forms.Label();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PNH)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_PNH
            // 
            this.dgv_PNH.AllowUserToAddRows = false;
            this.dgv_PNH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_PNH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PNH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ten,
            this.SL,
            this.Gia,
            this.TT,
            this.lh});
            this.dgv_PNH.Location = new System.Drawing.Point(2, 114);
            this.dgv_PNH.Name = "dgv_PNH";
            this.dgv_PNH.RowHeadersVisible = false;
            this.dgv_PNH.RowHeadersWidth = 51;
            this.dgv_PNH.RowTemplate.Height = 24;
            this.dgv_PNH.Size = new System.Drawing.Size(506, 589);
            this.dgv_PNH.TabIndex = 0;
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(613, 199);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(46, 17);
            this.lb1.TabIndex = 1;
            this.lb1.Text = "label1";
            // 
            // cbNPP
            // 
            this.cbNPP.FormattingEnabled = true;
            this.cbNPP.Location = new System.Drawing.Point(703, 199);
            this.cbNPP.Name = "cbNPP";
            this.cbNPP.Size = new System.Drawing.Size(121, 24);
            this.cbNPP.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(616, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "CSV";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(584, 578);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 43);
            this.button2.TabIndex = 4;
            this.button2.Text = "Thêm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(613, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tổng tiền";
            // 
            // lbtt
            // 
            this.lbtt.AutoSize = true;
            this.lbtt.Location = new System.Drawing.Point(700, 275);
            this.lbtt.Name = "lbtt";
            this.lbtt.Size = new System.Drawing.Size(16, 17);
            this.lbtt.TabIndex = 1;
            this.lbtt.Text = "0";
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
            // NhapHangForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 706);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbNPP);
            this.Controls.Add(this.lbtt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.dgv_PNH);
            this.Name = "NhapHangForm";
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
    }
}