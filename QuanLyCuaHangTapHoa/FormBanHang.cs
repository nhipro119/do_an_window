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
            lbTennv.Text = nhv.TenNV;
        }
        private void ListShowMatHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(LvMatHang.SelectedItems.Count > 0)
            {
                ListViewItem HH = LvMatHang.SelectedItems[0];
                Add_MH_In_HD(HH);
            }
        }
        void Add_MH_In_HD(ListViewItem HH)
        {
            string ma = HH.SubItems[3].Text;
            string ten = HH.Text;
            string SL = "2";
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
            
            for (int i = 0; i < dgvHD.Rows.Count - 1; i++)
            {
                tt += Int32.Parse(dgvHD.Rows[i].Cells[6].Value.ToString());
            }
            lbTamTinh.Text = tt.ToString();
            int diem = int.Parse(tbDTL.Text);
            tt -= (diem * 1000);
            if(tt < 0)
            {
                tt = 0;
                tbDTL.Text = (int.Parse(lbTamTinh.Text) / 1000).ToString();
            }
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
                        string path = Application.StartupPath + "\\images\\imghh\\" + HH.MaHang + ".jpg";
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
            }
            TinhTongTien();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            bool checkSL = check_sl();
            checkSL = check_tbTienNhan();
            if (checkSL)
            {
                if(tbSDTKH.Text == "")
                {
                    Create_HD(null);
                }
                else
                {
                    if (Int64.TryParse(tbSDTKH.Text, out Int64 a ))
                    {
                        if(qLCH.KhachHangs.Find(tbSDTKH.Text) == null)
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
                        MessageBox.Show("Chỉ Được Nhập SDT");
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
                    hD.TienKhuyenMai = Int64.Parse(tbDTL.Text) * 1000;
                    int diem;
                    int.TryParse((hD.TongTien / 20000).ToString(), out diem);
                    kh.DTL += diem;
                }
                kh.DTL -= int.Parse(tbDTL.Text);
                qLCH.SaveChanges();

            }
            qLCH.HoaDons.Add(hD);
            qLCH.SaveChanges();

            for (int i = 0; i < dgvHD.Rows.Count - 1; i++)
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
            for(int i = 0;i < dgvHD.Rows.Count -1; i++)
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
            Int64 so;
            bool check = Int64.TryParse(tbTienNhan.Text, out so);
            if(!check)
            {
                MessageBox.Show(" chỉ được nhập số");
                return false;
            }
            else if(so < Int64.Parse(lbTongTien.Text))
            {
                MessageBox.Show("só tiền nhập nhỏ hơn số tiền thanh toán");
                return false;
            }
            return true;
        }

        private void tbDTL_TextChanged(object sender, EventArgs e)
        {
            if(!int.TryParse(tbDTL.Text, out int a))
            {
                MessageBox.Show("chỉ được nhập số");
                tbDTL.Text = "0";
            }
            else if (int.Parse(tbDTL.Text) < 0)
            {
                MessageBox.Show(" không được nhập số âm");
            }
            else if (int.Parse(tbDTL.Text) > int.Parse(lbDiem.Text))
            {
                MessageBox.Show("điểm nhập lớn hơn tổng điểm hiện có");
            }
            else
            {
                TinhTongTien();
            }    
            

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
    }
}