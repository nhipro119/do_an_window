
namespace QuanLyCuaHangTapHoa
{
    partial class FormTKPNHcs
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
            this.dgvTKPNH = new System.Windows.Forms.DataGridView();
            this.TH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKPNH)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTKPNH
            // 
            this.dgvTKPNH.AllowUserToAddRows = false;
            this.dgvTKPNH.AllowUserToDeleteRows = false;
            this.dgvTKPNH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTKPNH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTKPNH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TH,
            this.SL,
            this.DG,
            this.tt});
            this.dgvTKPNH.Location = new System.Drawing.Point(2, 1);
            this.dgvTKPNH.Name = "dgvTKPNH";
            this.dgvTKPNH.ReadOnly = true;
            this.dgvTKPNH.RowHeadersVisible = false;
            this.dgvTKPNH.RowHeadersWidth = 51;
            this.dgvTKPNH.RowTemplate.Height = 24;
            this.dgvTKPNH.Size = new System.Drawing.Size(757, 626);
            this.dgvTKPNH.TabIndex = 0;
            // 
            // TH
            // 
            this.TH.HeaderText = "Tên Hàng";
            this.TH.MinimumWidth = 6;
            this.TH.Name = "TH";
            this.TH.ReadOnly = true;
            // 
            // SL
            // 
            this.SL.HeaderText = "Số Lượng";
            this.SL.MinimumWidth = 6;
            this.SL.Name = "SL";
            this.SL.ReadOnly = true;
            // 
            // DG
            // 
            this.DG.HeaderText = "Đơn Giá";
            this.DG.MinimumWidth = 6;
            this.DG.Name = "DG";
            this.DG.ReadOnly = true;
            // 
            // tt
            // 
            this.tt.HeaderText = "Tổng Tiền";
            this.tt.MinimumWidth = 6;
            this.tt.Name = "tt";
            this.tt.ReadOnly = true;
            // 
            // FormTKPNHcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 632);
            this.Controls.Add(this.dgvTKPNH);
            this.Name = "FormTKPNHcs";
            this.Text = "FormTKPNHcs";
            this.Load += new System.EventHandler(this.FormTKPNHcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKPNH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTKPNH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG;
        private System.Windows.Forms.DataGridViewTextBoxColumn tt;
    }
}