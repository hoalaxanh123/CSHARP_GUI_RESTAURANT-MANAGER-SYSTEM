using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using System.Data.SqlClient;
using DataAccess;

namespace QLCaPheProject
{
    public partial class frm_Mains : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frm_Mains()
        {
            InitializeComponent();
        }
        private string UserNameLogged = "";
        private void btn_QLMon_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_MonAn f = new frm_MonAn();
            f.ShowDialog();
        }

        private void btn_DSLoaiMon_ItemClick(object sender, ItemClickEventArgs e)
        {
            from_LoaiMon f = new from_LoaiMon();
            f.ShowDialog();
        }

        private void btn_QLBan_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_QuanLyBan f = new frm_QuanLyBan();
            f.SetUserName(UserNameLogged);
            f.ShowDialog();
        }

        private void btn_MayTinh_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("CALC.exe");
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(@"C:\Media_player\MediaPlayer\Media Player V2.exe");
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btn_GioiThieu_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_GioiThieu f = new frm_GioiThieu();
            f.ShowDialog();
        }

        private void btn_DangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Enabled = false;
            DangNhap();
        }
        private void DangNhap()
        {
            frm_Login f = new frm_Login();
            f.ShowDialog();
            if (f.Logged)
            {
                PhanQuyen(f.User.Administrators);
                this.lb_Display.Caption = "Xin chào : " + f.User.RealName;
                UserNameLogged = f.User.UserName.Trim();
                this.Enabled = true;
            }
            else
                Application.Exit();

        }
        private void PhanQuyen(int quyenHan)
        {
            this.rbtQuanLy.Visible = false;
            this.rbtThongKe.Visible = false;
            this.rbtHeThong.Visible = false;
            // this.rbtNhanVien.Enabled = false;
            switch (quyenHan)
            {
                //admin
                case 0:
                    this.rbtQuanLy.Visible = true;
                    //this.rbtNhanVien.Enabled = true;
                    this.rbtThongKe.Visible = true;
                    this.rbtHeThong.Visible = true;

                    //Logged = true;
                    break;
                //Manager
                case 1:

                    this.rbtThongKe.Visible = false;
                    this.rbtHeThong.Visible = false;
                    //this.rbtNhanVien.Enabled = true;
                    this.rbtQuanLy.Visible = true;
                    //Logged = true;
                    break;
                //Assitant
                case 2:
                    this.rbtQuanLy.Visible = false;
                    this.rbtThongKe.Visible = false;
                    this.rbtHeThong.Visible = false;
                    //this.rbtNhanVien.Enabled = true;
                    //Logged = false;
                    break;

            }
        }
        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void btn_Thoat_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn chắc muốn thoát chứ ? ", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
                Application.Exit();
        }

        private void btn_ThongKeTheoNgay_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_DoanhThuTheoNgay f = new frm_DoanhThuTheoNgay();
            f.ShowDialog();
        }

        private void btn_ThongKeTheoMH_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_DoanhThuTheoSanPham f = new frm_DoanhThuTheoSanPham();
            f.ShowDialog();
        }

        private void btn_BaoCaoTongHop_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_BaoCaoTongHop f = new frm_BaoCaoTongHop();
            f.ShowDialog();
        }

        private void btn_QuanLyNhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_QuanLyNhanSu f = new frm_QuanLyNhanSu();
            f.UserNameLogged = UserNameLogged;
            f.ShowDialog();
        }

        private void btn_DoiMk_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_DoiMatKhau f = new frm_DoiMatKhau();
            f.UserName = UserNameLogged;
            f.ShowDialog();
        }

        private void btn_ThongTinTaiKhoan_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_ThongTinNguoiDung f = new frm_ThongTinNguoiDung();
            f.LoadForm(UserNameLogged);
            f.UserNameLogged = UserNameLogged;
            f.ShowDialog();
        }

        private void btn_TheoDoiTruyCap_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_Log f = new frm_Log();
            f.ShowDialog();
        }

        private void btn_ThietLap_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btn_SaoLuu_ItemClick(object sender, ItemClickEventArgs e)
        {

            string path = Application.StartupPath + "\\Backup\\";
            string fileName = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString()
                + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + ".bak";
            string link = path + fileName;
            saveFileDialog1.InitialDirectory = path;
            saveFileDialog1.Title = "Chọn nơi lưu file";
            saveFileDialog1.Filter = "Backup files (*.bak)|*.bak|All files (*.*)|*.*";
            DialogResult ret = saveFileDialog1.ShowDialog();

            if (ret == DialogResult.OK)
            {
                SqlConnection CNS = new SqlConnection(Link.ConnectionString);
                SqlCommand cmd = CNS.CreateCommand();
                cmd.CommandText = "BACKUP DATABASE QuanLyCaPhe TO DISK = '" + (saveFileDialog1.FileName + fileName) + "'";
                CNS.Open();
                cmd.ExecuteNonQuery();
                CNS.Close();
                MessageBox.Show("Sao lưu CSDL thành công");
            }

        }

        private void btn_PhucHoiHeThong_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult ret2 = MessageBox.Show("Đây là thao tác một chiều ảnh hưởng tới cơ sở dữ liệu , thao  tác không thể khôi phục , bạn có muốn sao lưu dữ liệu trước không ? ", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (ret2 == DialogResult.Yes)
            {
                btn_SaoLuu.PerformClick();
            }
            openFileDialog1.Filter = "Backup files (*.bak)|*.bak|All files (*.*)|*.*";
            openFileDialog1.Title = "Chọn file phục hồi";
            DialogResult ret = openFileDialog1.ShowDialog();
            if (ret == DialogResult.OK)
            {
                SqlConnection CNS = new SqlConnection(Link.ConnectionString);
                SqlCommand cmd = CNS.CreateCommand();
                cmd.CommandText = "RESTORE DATABASE QuanLyCaPhe FROM DISK = '" + (openFileDialog1.FileName) + "'";
                CNS.Open();
                cmd.ExecuteNonQuery();
                CNS.Close();
                MessageBox.Show("Khôi phục lưu CSDL thành công");
            }
        }

        private void frm_Mains_Load(object sender, EventArgs e)
        {
            timer1.Start();
            DangNhap();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.lbl_Time.Caption = DateTime.Now.ToLongTimeString() + "\t\t" + DateTime.Now.ToShortDateString();
        }


    }
}