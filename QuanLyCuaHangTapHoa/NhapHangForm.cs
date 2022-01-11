using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace QuanLyCuaHangTapHoa
{
    public partial class NhapHangForm : Form
    {
        QLCH qLCH;
        NhanVien nv;
        public NhapHangForm()
        {
            InitializeComponent();
        }
        public NhapHangForm(NhanVien nv)
        {
            InitializeComponent();
            this.nv = nv;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "CSV file | *.csv";
            string path = null;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                path = dlg.FileName;

            }
            if (path != null)
            {
                dgv_PNH.Rows.Clear();
                //List<String> lstr = new List<string>();
                int tongtien = 0;
                using (StreamReader reader = new StreamReader(path)) 
                {
                    string[] lstr ;
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        lstr = line.Split(',');
                        int tt;
                        if(int.TryParse(lstr[3], out tt) && uint.TryParse(lstr[1], out uint a) && uint.TryParse(lstr[2],out uint b))
                        {
                            tongtien += tt;
                        }
                        else
                        {
                            MessageBox.Show("thông tin trong file không đúng định dạng");
                            break;
                        }
                        string chuoi = lstr[0].ToLower();
                        List<HangHoa> lhh = (from hh in qLCH.HangHoas where hh.TenHang.ToLower() == chuoi select hh).ToList();
                        if(lhh.Count() == 0)
                        {
                            string tb = "không tìm tháy mặt hàng " + chuoi + " trong cơ sở dữ liệu";
                            MessageBox.Show(tb);
                            dgv_PNH.Rows.Clear();
                            tt = 0;
                            break;
                        }
                        List<string> TT = new List<string>();
                        for( int i= 0; i < lstr.Count(); i++)
                        {
                            TT.Add(lstr[i]);
                        }
                        TT.Add(lhh[0].MaHang);
                        string[] Tt = { TT[0], TT[1], TT[2], TT[3], TT[4] };
                        dgv_PNH.Rows.Add(Tt);
                    }
                }
                lbtt.Text = tongtien.ToString();
            }

        }

        private void NhapHangForm_Load(object sender, EventArgs e)
        {
            qLCH = new QLCH();
            loadcb();
        }
        void loadcb()
        {
            List<NhaPhanPhoi> lnpp = (from npp in qLCH.NhaPhanPhois where !npp.isDelete select npp).ToList();
            cbNPP.DataSource = lnpp;
            cbNPP.DisplayMember = "TenNPP";
            cbNPP.ValueMember = "MaNPP";
        }
        string create_ma()
        {
            string ma;
            int count = qLCH.PhieuNhapHangs.Count();
            while(true)
            {
                ma = "NPH";
                ma += count.ToString();
                PhieuNhapHang pnh = qLCH.PhieuNhapHangs.Find(ma);
                if(pnh == null)
                {
                    break;
                }
                count++;
            }
            return ma;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if(lbtt.Text != "0")
            {
                PhieuNhapHang pnh = new PhieuNhapHang();
                pnh.MaPN = create_ma();
                pnh.MaNPP = cbNPP.SelectedValue.ToString();
                pnh.NgayNhap = DateTime.Now;
                pnh.TongTien = Int64.Parse(lbtt.Text);
                pnh.MaNV = nv.MaNV;
                qLCH.PhieuNhapHangs.Add(pnh);
                qLCH.SaveChanges();
                for(int i  = 0; i < dgv_PNH.Rows.Count; i++)
                {
                    CTPNH cTPNH= new CTPNH();
                    cTPNH.MaPN = pnh.MaPN;

                    string ma = dgv_PNH.Rows[i].Cells[4].Value.ToString();
                    
                    
                        
                        
                    cTPNH.MaHang = ma;
                    cTPNH.SoLuong = int.Parse(dgv_PNH.Rows[i].Cells[1].Value.ToString());
                    cTPNH.DonGia = Int64.Parse(dgv_PNH.Rows[i].Cells[2].Value.ToString());
                    cTPNH.DVT = null;
                    qLCH.CTPNHs.Add(cTPNH);
                    qLCH.SaveChanges();
                    
                }
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("không thể tạo phiếu nhập hàng rỗng");
            }
            
            

        }
    }
}
