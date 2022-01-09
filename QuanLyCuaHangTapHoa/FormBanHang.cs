using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace QuanLyCuaHangTapHoa
{
    public partial class FormBanHang : DevExpress.XtraEditors.XtraForm
    {
        QLCH qLCH;
        NhanVien nhv;
        public FormBanHang()
        {
            InitializeComponent();
            qLCH = new QLCH();
        }
        
        public FormBanHang(NhanVien nhv)
        {
            InitializeComponent();
            qLCH = new QLCH();
            this.nhv = nhv;          
        }
        private void ListShowMatHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if(LvMatHang.SelectedItems.Count > 0)
            {
                bool check_hh = true;
                ListViewItem HH = LvMatHang.SelectedItems[0];
                for (int i = 0; i < dgvHD.Rows.Count; i++)
                {
                    
                    if (dgvHD.Rows[i].Cells[0].Value.ToString() == HH.SubItems[3].Text)
                    {
                        int sl = int.Parse(dgvHD.Rows[i].Cells[4].Value.ToString());
                        sl++;
                        dgvHD.Rows[i].Cells[4].Value = sl.ToString();
                        check_hh = false;
                        Int64 tong = 0;
                        tong = Int64.Parse(dgvHD.Rows[i].Cells[2].Value.ToString()) * int.Parse(dgvHD.Rows[i].Cells[4].Value.ToString());
                        dgvHD.Rows[i].Cells[6].Value = tong.ToString();
                        TinhTongTien();
                        
                        break;
                    }
                    
                    
                }
                if(check_hh)
                {
                    Add_MH_In_HD(HH);
                }
                
                
            }
        }
        void Add_MH_In_HD(ListViewItem HH)
        {
            string ma = HH.SubItems[3].Text;
            string ten = HH.Text;
            string SL = "1";
            string DG = HH.SubItems[2].Text;
            string tt = (int.Parse(DG) * int.Parse(SL)).ToString();
            string[] hh = { ma, ten,DG, "-", SL, "+", tt, "delete" };
            dgvHD.Rows.Add(hh);
            TinhTongTien();
        }
        private void FormBanHang_Load(object sender, EventArgs e)
        {

            thread_load_lv(qLCH.HangHoas.ToList());
            //load_listview(qLCH.HangHoas.ToList());
        }
        void thread_load_lv(List<HangHoa> listHH)
        {
            //ThreadStart thS = new ThreadStart(load_listview);
            Thread load_lv = new Thread(()=> { load_listview(listHH);
                
            });
            load_lv.Start();
        }
        void TinhTongTien()
        {
            Int32 tt= 0;
            
            for (int i = 0; i < dgvHD.Rows.Count ; i++)
            {
                tt += Int32.Parse(dgvHD.Rows[i].Cells[6].Value.ToString());
            }
            lbTamTinh.Text = tt.ToString();
            int diem = int.Parse(lbDTLSD.Text);
            tt -= (diem * 1000);
            //if(tt < 0)
            //{
            //    tt = 0;
            //    tbDTL.Text = (int.Parse(lbTamTinh.Text) / 1000).ToString();
            //}
            lbTongTien.Text = tt.ToString();
        }
        public void load_listview(List<HangHoa> listHH)
        {

            if(LvMatHang.InvokeRequired)
            {
                LvMatHang.Invoke(new Action(() => { load_listview(listHH); }));
                return;
            }
            else
            {
                LvMatHang.Items.Clear();
                imglMH.Images.Clear();
                foreach (HangHoa HH in listHH)
                {
                    if (HH.SLTon > 0 && HH.isDelete != true)
                    {
                        string path = Application.StartupPath + "\\images\\imghh\\" + HH.MaHang + ".png";
                        imglMH.Images.Add(new Bitmap(path));


                        ListViewItem item = new ListViewItem();
                        item.Text = HH.TenHang;
                        item.SubItems.Add(HH.SLTon.ToString());
                        item.SubItems.Add(HH.DonGia.ToString());
                        item.SubItems.Add(HH.MaHang.ToString());
                        item.ImageIndex = imglMH.Images.Count - 1;
                        LvMatHang.Items.Add(item);
                    }
                }
            }

            


        }

        private void dgvHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if(dgvHD.SelectedRows.Count > 0)
            {
                int index = e.RowIndex;
                if(e.ColumnIndex == 3)
                {
                    int sl = int.Parse(dgvHD.Rows[index].Cells[4].Value.ToString());
                    if (sl > 0)
                    {
                        sl -= 1;
                        dgvHD.Rows[index].Cells[4].Value = sl;
                        Int32 tt = sl * Int32.Parse(dgvHD.Rows[index].Cells[2].Value.ToString());
                        dgvHD.Rows[index].Cells[6].Value = tt;
                    }
                }
                else if(e.ColumnIndex == 5)
                {
                    int sl = int.Parse(dgvHD.Rows[index].Cells[4].Value.ToString());
                    sl += 1;
                    dgvHD.Rows[index].Cells[4].Value = sl;
                    Int32 tt = sl * Int32.Parse(dgvHD.Rows[index].Cells[2].Value.ToString());
                    dgvHD.Rows[index].Cells[6].Value = tt;
                    
                }
                else if(e.ColumnIndex == 7)
                {
                    dgvHD.Rows.RemoveAt(index);
                }
                //Int64 tong = 0;
                //tong = Int64.Parse(dgvHD.Rows[index].Cells[2].Value.ToString()) * int.Parse(dgvHD.Rows[index].Cells[4].Value.ToString());
                //dgvHD.Rows[index].Cells[6].Value = tong.ToString();
                //TinhTongTien();
            }
            TinhTongTien();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            if(lbTamTinh.Text == "0")
            {
                MessageBox.Show(" không có mặt hàng, không thể tính tiền ");
            }
            else
            {
                bool checkSL = check_sl();
                bool check_tienNhan = check_tbTienNhan();

                if (checkSL && check_tienNhan)
                {
                    if (tbSDTKH.Text == "")
                    {
                        Create_HD(null);
                    }
                    else
                    {
                        if (UInt64.TryParse(tbSDTKH.Text, out UInt64 a))
                        {
                            if (qLCH.KhachHangs.Find(tbSDTKH.Text) == null)
                            {
                                DialogResult dialogResult = MessageBox.Show("khách hàng chưa có, bạn có muốn thêm không", "thông báo", MessageBoxButtons.YesNo);
                                if (dialogResult == DialogResult.Yes)
                                {
                                    FormThemKhachMini ftkmn = new FormThemKhachMini(tbSDTKH.Text);
                                    ftkmn.Show();
                                }
                                else
                                {
                                    Create_HD(null);
                                }
                            }
                            else
                            {
                                Create_HD(tbSDTKH.Text);
                            }
                        }
                        else
                        {
                            MessageBox.Show("số điện thoại chỉ được nhập dãy số 10 số");
                        }
                    }
                }
            }
            
        }
        void Create_HD(string SDT)
        {
            HoaDon hD = new HoaDon();
            hD.MaHD = TaoMa();
            hD.MaNV = nhv.MaNV;
            hD.SDTKH = SDT;
            hD.TongTien = Int64.Parse(lbTongTien.Text);
            hD.NgayLap = DateTime.Today;
            if (SDT != null)
            {
                KhachHang kh = qLCH.KhachHangs.Find(SDT);
                if (Int64.Parse(lbTongTien.Text) > 100000)
                {
                    hD.TienKhuyenMai = Int64.Parse(lbDTLSD.Text) * 1000;
                    int diem;
                    int.TryParse((hD.TongTien / 20000).ToString(), out diem);
                    kh.DTL += diem;
                }
                kh.DTL -= int.Parse(lbDTLSD.Text);
                qLCH.SaveChanges();

            }
            qLCH.HoaDons.Add(hD);
            qLCH.SaveChanges();

            for (int i = 0; i < dgvHD.Rows.Count ; i++)
            {
                CTHD cTHD = new CTHD();
                cTHD.MaHD = hD.MaHD;
                cTHD.MaHH = dgvHD.Rows[i].Cells[0].Value.ToString();
                cTHD.SoLuong = int.Parse(dgvHD.Rows[i].Cells[4].Value.ToString());
                cTHD.DonGIa = int.Parse(dgvHD.Rows[i].Cells[2].Value.ToString());
                qLCH.CTHDs.Add(cTHD);
                qLCH.SaveChanges();
                HangHoa HH = qLCH.HangHoas.Find(cTHD.MaHH);
                HH.SLTon -= cTHD.SoLuong;
                qLCH.SaveChanges();
            }
            
            Int64 tienthoi = Int64.Parse(tbTienNhan.Text) - Int64.Parse(lbTongTien.Text);
            MessageBox.Show("số tiền trả lại khách là: " + tienthoi.ToString() + " vnd");
            thread_load_lv(qLCH.HangHoas.ToList());
        }
        string TaoMa()
        {
            string ma;
            int so = qLCH.HoaDons.Count();
            while (true)
            {
                ma = "HD";
                ma += so.ToString();
                HoaDon check = qLCH.HoaDons.Find(ma);
                if (check == null)
                {
                    break;
                }

                so += 1;

            }
            
            return ma;
        }
        bool check_sl()
        {
            for(int i = 0;i < dgvHD.Rows.Count ; i++)
            {
                string ma = dgvHD.Rows[i].Cells[0].Value.ToString();
                HangHoa hh = qLCH.HangHoas.Find(ma);
                if (hh.SLTon < int.Parse(dgvHD.Rows[i].Cells[4].Value.ToString()))
                {
                    string thongBao = "Số lượng tối đa của " + hh.TenHang + " chỉ còn " + hh.SLTon.ToString();
                    MessageBox.Show(thongBao);
                    return false;
                }
            }
            return true;
        }

        bool check_tbTienNhan()
        {
            UInt64 so;
            bool check = UInt64.TryParse(tbTienNhan.Text, out so);
            if(!check)
            {
                MessageBox.Show(" số tiền chỉ được nhập số");
                return false;
            }
            else if(so < UInt64.Parse(lbTongTien.Text))
            {
                MessageBox.Show("só tiền nhập nhỏ hơn số tiền thanh toán");
                return false;
            }
            return true;
        }
        private void tbSDTKH_TextChanged(object sender, EventArgs e)
        {
            KhachHang kh = qLCH.KhachHangs.Find(tbSDTKH.Text);
            if(kh == null)
            {
                lbDiem.Text = "0";
            }
            else
            {
                lbDiem.Text = kh.DTL.ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string chuoi = tbTimKiem.Text.ToLower();
            if( chuoi == "")
            {
                thread_load_lv(qLCH.HangHoas.ToList());
            }
            else
            {
                List<HangHoa> lhh;
                lhh = (from hh in qLCH.HangHoas where hh.TenHang.ToLower().Contains(chuoi) select hh).ToList();
                thread_load_lv(lhh);
            }
        }

        private void cbSDD_CheckedChanged(object sender, EventArgs e)
        {
            if(cbSDD.Checked)
            {
                int dtd = int.Parse(lbDiem.Text);
                int dcd = int.Parse(lbTamTinh.Text) / 1000;
                if (dtd > dcd)
                {
                    lbDTLSD.Text = dcd.ToString();
                }
                else
                {
                    lbDTLSD.Text = dtd.ToString();
                }
                TinhTongTien();
            }
            else
            {
                lbDTLSD.Text = "0";
                TinhTongTien();
            }
            
            
        }

        private void dgvHD_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            string chuoi = dgvHD.Rows[row].Cells[4].Value.ToString();
            bool check_parse = uint.TryParse(chuoi, out uint a);
            if(!check_parse)
            {
                MessageBox.Show("số lượng chỉ được nhập số tự nhiên");
                dgvHD.Rows[row].Cells[4].Value = "1";
            }
    
            Int64 tong = 0;
            tong = Int64.Parse(dgvHD.Rows[row].Cells[2].Value.ToString()) * int.Parse(dgvHD.Rows[row].Cells[4].Value.ToString());
            dgvHD.Rows[row].Cells[6].Value = tong.ToString();
            TinhTongTien();
        }
    }
}