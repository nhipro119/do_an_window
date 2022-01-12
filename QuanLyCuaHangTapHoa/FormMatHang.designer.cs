
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbGB = new System.Windows.Forms.TextBox();
            this.tbGG = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pbHH = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbNCC = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbSLT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbTL = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbTH = new System.Windows.Forms.Label();
            this.lbMH = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbLH = new System.Windows.Forms.Label();
            this.lbDVT = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnThemMatHang = new FontAwesome.Sharp.IconButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tbTimKiem = new System.Windows.Forms.TextBox();
            this.btThemLH = new System.Windows.Forms.Button();
            this.cbNPP = new System.Windows.Forms.ComboBox();
            this.cbLH = new System.Windows.Forms.ComboBox();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHH)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHH)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelChildForm
            // 
            this.panelChildForm.Controls.Add(this.dgvHH);
            this.panelChildForm.Controls.Add(this.panel1);
            this.panelChildForm.Controls.Add(this.panel5);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(0, 0);
            this.panelChildForm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1378, 1062);
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
            this.dgvHH.Location = new System.Drawing.Point(0, 59);
            this.dgvHH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvHH.Name = "dgvHH";
            this.dgvHH.RowHeadersVisible = false;
            this.dgvHH.RowHeadersWidth = 51;
            this.dgvHH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHH.Size = new System.Drawing.Size(992, 1003);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.tbGB);
            this.panel1.Controls.Add(this.tbGG);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btXoa);
            this.panel1.Controls.Add(this.btSua);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pbHH);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lbNCC);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.tbSLT);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lbTL);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.lbTH);
            this.panel1.Controls.Add(this.lbMH);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lbLH);
            this.panel1.Controls.Add(this.lbDVT);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(992, 59);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 1003);
            this.panel1.TabIndex = 12;
            // 
            // tbGB
            // 
            this.tbGB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbGB.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGB.Location = new System.Drawing.Point(189, 438);
            this.tbGB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbGB.Name = "tbGB";
            this.tbGB.Size = new System.Drawing.Size(101, 23);
            this.tbGB.TabIndex = 2;
            // 
            // tbGG
            // 
            this.tbGG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbGG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbGG.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGG.Location = new System.Drawing.Point(190, 389);
            this.tbGG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbGG.Name = "tbGG";
            this.tbGG.Size = new System.Drawing.Size(101, 23);
            this.tbGG.TabIndex = 2;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.DarkGray;
            this.label18.Location = new System.Drawing.Point(36, 460);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(344, 17);
            this.label18.TabIndex = 5;
            this.label18.Text = "__________________________________________";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.DarkGray;
            this.label17.Location = new System.Drawing.Point(36, 411);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(344, 17);
            this.label17.TabIndex = 5;
            this.label17.Text = "__________________________________________";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.DarkGray;
            this.label16.Location = new System.Drawing.Point(36, 362);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(344, 17);
            this.label16.TabIndex = 5;
            this.label16.Text = "__________________________________________";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.DarkGray;
            this.label15.Location = new System.Drawing.Point(36, 313);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(344, 17);
            this.label15.TabIndex = 5;
            this.label15.Text = "__________________________________________";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.DarkGray;
            this.label14.Location = new System.Drawing.Point(36, 263);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(344, 17);
            this.label14.TabIndex = 5;
            this.label14.Text = "__________________________________________";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.DarkGray;
            this.label13.Location = new System.Drawing.Point(37, 214);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(344, 17);
            this.label13.TabIndex = 5;
            this.label13.Text = "__________________________________________";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.DarkGray;
            this.label12.Location = new System.Drawing.Point(36, 165);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(344, 17);
            this.label12.TabIndex = 5;
            this.label12.Text = "__________________________________________";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.DarkGray;
            this.label11.Location = new System.Drawing.Point(37, 114);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(344, 17);
            this.label11.TabIndex = 5;
            this.label11.Text = "__________________________________________";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hàng Hóa";
            // 
            // btXoa
            // 
            this.btXoa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.btXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btXoa.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.ForeColor = System.Drawing.Color.White;
            this.btXoa.Location = new System.Drawing.Point(210, 920);
            this.btXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(156, 69);
            this.btXoa.TabIndex = 3;
            this.btXoa.Text = "Xoá";
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btSua
            // 
            this.btSua.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.btSua.FlatAppearance.BorderSize = 0;
            this.btSua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSua.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.ForeColor = System.Drawing.Color.White;
            this.btSua.Location = new System.Drawing.Point(30, 920);
            this.btSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(156, 69);
            this.btSua.TabIndex = 3;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = false;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên Hàng";
            // 
            // pbHH
            // 
            this.pbHH.Location = new System.Drawing.Point(17, 561);
            this.pbHH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbHH.Name = "pbHH";
            this.pbHH.Size = new System.Drawing.Size(355, 246);
            this.pbHH.TabIndex = 4;
            this.pbHH.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nhà Cung Cấp";
            // 
            // lbNCC
            // 
            this.lbNCC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNCC.AutoSize = true;
            this.lbNCC.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNCC.Location = new System.Drawing.Point(189, 241);
            this.lbNCC.Name = "lbNCC";
            this.lbNCC.Size = new System.Drawing.Size(39, 23);
            this.lbNCC.TabIndex = 1;
            this.lbNCC.Text = "ncc";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(37, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 23);
            this.label6.TabIndex = 1;
            this.label6.Text = "Đơn Vị Tính";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(37, 438);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 23);
            this.label9.TabIndex = 1;
            this.label9.Text = "Giá Bán";
            // 
            // tbSLT
            // 
            this.tbSLT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSLT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSLT.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSLT.Location = new System.Drawing.Point(189, 486);
            this.tbSLT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSLT.Name = "tbSLT";
            this.tbSLT.Size = new System.Drawing.Size(100, 23);
            this.tbSLT.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Loại Hàng";
            // 
            // lbTL
            // 
            this.lbTL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTL.AutoSize = true;
            this.lbTL.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTL.Location = new System.Drawing.Point(189, 340);
            this.lbTL.Name = "lbTL";
            this.lbTL.Size = new System.Drawing.Size(20, 23);
            this.lbTL.TabIndex = 1;
            this.lbTL.Text = "tl";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(37, 487);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 23);
            this.label10.TabIndex = 1;
            this.label10.Text = "SLT";
            // 
            // lbTH
            // 
            this.lbTH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTH.AutoSize = true;
            this.lbTH.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTH.Location = new System.Drawing.Point(188, 143);
            this.lbTH.Name = "lbTH";
            this.lbTH.Size = new System.Drawing.Size(37, 23);
            this.lbTH.TabIndex = 1;
            this.lbTH.Text = "tên";
            // 
            // lbMH
            // 
            this.lbMH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbMH.AutoSize = true;
            this.lbMH.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMH.Location = new System.Drawing.Point(187, 91);
            this.lbMH.Name = "lbMH";
            this.lbMH.Size = new System.Drawing.Size(36, 23);
            this.lbMH.TabIndex = 1;
            this.lbMH.Text = "mã";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(37, 340);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 23);
            this.label7.TabIndex = 1;
            this.label7.Text = "Trọng Lượng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(37, 389);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 23);
            this.label8.TabIndex = 1;
            this.label8.Text = "Giá Gốc";
            // 
            // lbLH
            // 
            this.lbLH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbLH.AutoSize = true;
            this.lbLH.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLH.Location = new System.Drawing.Point(189, 192);
            this.lbLH.Name = "lbLH";
            this.lbLH.Size = new System.Drawing.Size(38, 23);
            this.lbLH.TabIndex = 1;
            this.lbLH.Text = "loại";
            // 
            // lbDVT
            // 
            this.lbDVT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDVT.AutoSize = true;
            this.lbDVT.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDVT.Location = new System.Drawing.Point(189, 290);
            this.lbDVT.Name = "lbDVT";
            this.lbDVT.Size = new System.Drawing.Size(36, 23);
            this.lbDVT.TabIndex = 1;
            this.lbDVT.Text = "dvt";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.panel5.Controls.Add(this.btnThemMatHang);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.btThemLH);
            this.panel5.Controls.Add(this.cbNPP);
            this.panel5.Controls.Add(this.cbLH);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1378, 59);
            this.panel5.TabIndex = 10;
            // 
            // btnThemMatHang
            // 
            this.btnThemMatHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemMatHang.BackColor = System.Drawing.Color.White;
            this.btnThemMatHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemMatHang.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMatHang.ForeColor = System.Drawing.Color.Black;
            this.btnThemMatHang.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnThemMatHang.IconColor = System.Drawing.Color.Black;
            this.btnThemMatHang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThemMatHang.IconSize = 18;
            this.btnThemMatHang.Location = new System.Drawing.Point(1174, 0);
            this.btnThemMatHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThemMatHang.Name = "btnThemMatHang";
            this.btnThemMatHang.Size = new System.Drawing.Size(128, 59);
            this.btnThemMatHang.TabIndex = 2;
            this.btnThemMatHang.Text = "Thêm Mặt Hàng";
            this.btnThemMatHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemMatHang.UseVisualStyleBackColor = false;
            this.btnThemMatHang.Click += new System.EventHandler(this.btnThemMatHang_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.tbTimKiem);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(647, 59);
            this.panel6.TabIndex = 0;
            // 
            // tbTimKiem
            // 
            this.tbTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTimKiem.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTimKiem.Location = new System.Drawing.Point(0, 9);
            this.tbTimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbTimKiem.Multiline = true;
            this.tbTimKiem.Name = "tbTimKiem";
            this.tbTimKiem.Size = new System.Drawing.Size(647, 43);
            this.tbTimKiem.TabIndex = 1;
            this.tbTimKiem.TextChanged += new System.EventHandler(this.tbTimKiem_TextChanged);
            // 
            // btThemLH
            // 
            this.btThemLH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btThemLH.BackColor = System.Drawing.Color.White;
            this.btThemLH.FlatAppearance.BorderSize = 0;
            this.btThemLH.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btThemLH.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThemLH.Location = new System.Drawing.Point(992, 0);
            this.btThemLH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btThemLH.Name = "btThemLH";
            this.btThemLH.Size = new System.Drawing.Size(128, 59);
            this.btThemLH.TabIndex = 5;
            this.btThemLH.Text = "Thêm Loại Hàng";
            this.btThemLH.UseVisualStyleBackColor = false;
            this.btThemLH.Click += new System.EventHandler(this.btThemLH_Click);
            // 
            // cbNPP
            // 
            this.cbNPP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNPP.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNPP.FormattingEnabled = true;
            this.cbNPP.Location = new System.Drawing.Point(783, 15);
            this.cbNPP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbNPP.Name = "cbNPP";
            this.cbNPP.Size = new System.Drawing.Size(121, 31);
            this.cbNPP.TabIndex = 6;
            this.cbNPP.SelectedIndexChanged += new System.EventHandler(this.cbNPP_SelectedIndexChanged);
            // 
            // cbLH
            // 
            this.cbLH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLH.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLH.FormattingEnabled = true;
            this.cbLH.Location = new System.Drawing.Point(654, 14);
            this.cbLH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbLH.Name = "cbLH";
            this.cbLH.Size = new System.Drawing.Size(121, 31);
            this.cbLH.TabIndex = 6;
            this.cbLH.SelectedIndexChanged += new System.EventHandler(this.cbLH_SelectedIndexChanged);
            // 
            // FormMatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 1062);
            this.Controls.Add(this.panelChildForm);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMatHang";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FormMatHang_Load);
            this.panelChildForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHH)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHH)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbGG;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbGB;
        private System.Windows.Forms.Label label18;
    }
}