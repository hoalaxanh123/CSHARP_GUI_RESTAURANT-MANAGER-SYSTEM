namespace QLCaPheProject
{
    partial class frm_Mains
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Mains));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.lbl_Time = new DevExpress.XtraBars.BarStaticItem();
            this.lb_Display = new DevExpress.XtraBars.BarStaticItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btn_QLMon = new DevExpress.XtraBars.BarButtonItem();
            this.btn_DSLoaiMon = new DevExpress.XtraBars.BarButtonItem();
            this.btn_QLBan = new DevExpress.XtraBars.BarButtonItem();
            this.btn_MayTinh = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Player = new DevExpress.XtraBars.BarButtonItem();
            this.btn_TroGiup = new DevExpress.XtraBars.BarButtonItem();
            this.btn_GioiThieu = new DevExpress.XtraBars.BarButtonItem();
            this.btn_DangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Thoat = new DevExpress.XtraBars.BarButtonItem();
            this.skinRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.btn_ThongKeTheoMH = new DevExpress.XtraBars.BarButtonItem();
            this.btn_ThongKeTheoNgay = new DevExpress.XtraBars.BarButtonItem();
            this.btn_BaoCaoTongHop = new DevExpress.XtraBars.BarButtonItem();
            this.btn_QuanLyNhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.btn_DoiMk = new DevExpress.XtraBars.BarButtonItem();
            this.btn_ThongTinTaiKhoan = new DevExpress.XtraBars.BarButtonItem();
            this.btn_TheoDoiTruyCap = new DevExpress.XtraBars.BarButtonItem();
            this.btn_ThietLap = new DevExpress.XtraBars.BarButtonItem();
            this.btn_SaoLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btn_PhucHoiHeThong = new DevExpress.XtraBars.BarButtonItem();
            this.rbtQuanLy = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbtThongKe = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbtHeThong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup9 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup10 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.applicationMenu1 = new DevExpress.XtraBars.Ribbon.ApplicationMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ApplicationButtonDropDownControl = this.applicationMenu1;
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.lbl_Time,
            this.lb_Display,
            this.barButtonItem1,
            this.btn_QLMon,
            this.btn_DSLoaiMon,
            this.btn_QLBan,
            this.btn_MayTinh,
            this.btn_Player,
            this.btn_TroGiup,
            this.btn_GioiThieu,
            this.btn_DangXuat,
            this.btn_Thoat,
            this.skinRibbonGalleryBarItem1,
            this.btn_ThongKeTheoMH,
            this.btn_ThongKeTheoNgay,
            this.btn_BaoCaoTongHop,
            this.btn_QuanLyNhanVien,
            this.btn_DoiMk,
            this.btn_ThongTinTaiKhoan,
            this.btn_TheoDoiTruyCap,
            this.btn_ThietLap,
            this.btn_SaoLuu,
            this.btn_PhucHoiHeThong});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 27;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rbtQuanLy,
            this.rbtThongKe,
            this.rbtHeThong});
            this.ribbon.Size = new System.Drawing.Size(1244, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // lbl_Time
            // 
            this.lbl_Time.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.lbl_Time.Caption = "barStaticItem1";
            this.lbl_Time.Id = 1;
            this.lbl_Time.Name = "lbl_Time";
            // 
            // lb_Display
            // 
            this.lb_Display.Caption = "Thông tin đăng nhập";
            this.lb_Display.Id = 2;
            this.lb_Display.Name = "lb_Display";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Khuyến mãi";
            this.barButtonItem1.Id = 4;
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.LargeWidth = 100;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // btn_QLMon
            // 
            this.btn_QLMon.Caption = "Quản lý món";
            this.btn_QLMon.Id = 5;
            this.btn_QLMon.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_QLMon.ImageOptions.LargeImage")));
            this.btn_QLMon.LargeWidth = 100;
            this.btn_QLMon.Name = "btn_QLMon";
            this.btn_QLMon.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_QLMon_ItemClick);
            // 
            // btn_DSLoaiMon
            // 
            this.btn_DSLoaiMon.Caption = "Quản lý loại món";
            this.btn_DSLoaiMon.Id = 6;
            this.btn_DSLoaiMon.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_DSLoaiMon.ImageOptions.LargeImage")));
            this.btn_DSLoaiMon.LargeWidth = 100;
            this.btn_DSLoaiMon.Name = "btn_DSLoaiMon";
            this.btn_DSLoaiMon.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_DSLoaiMon_ItemClick);
            // 
            // btn_QLBan
            // 
            this.btn_QLBan.Caption = "Quản lý bàn";
            this.btn_QLBan.Id = 7;
            this.btn_QLBan.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_QLBan.ImageOptions.LargeImage")));
            this.btn_QLBan.LargeWidth = 100;
            this.btn_QLBan.Name = "btn_QLBan";
            this.btn_QLBan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_QLBan_ItemClick);
            // 
            // btn_MayTinh
            // 
            this.btn_MayTinh.Caption = "Máy tính";
            this.btn_MayTinh.Id = 8;
            this.btn_MayTinh.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_MayTinh.ImageOptions.LargeImage")));
            this.btn_MayTinh.LargeWidth = 70;
            this.btn_MayTinh.Name = "btn_MayTinh";
            this.btn_MayTinh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_MayTinh_ItemClick);
            // 
            // btn_Player
            // 
            this.btn_Player.Caption = "Phát nhạc";
            this.btn_Player.Id = 9;
            this.btn_Player.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Player.ImageOptions.LargeImage")));
            this.btn_Player.LargeWidth = 70;
            this.btn_Player.Name = "btn_Player";
            this.btn_Player.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // btn_TroGiup
            // 
            this.btn_TroGiup.Caption = "Trợ giúp";
            this.btn_TroGiup.Id = 11;
            this.btn_TroGiup.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_TroGiup.ImageOptions.LargeImage")));
            this.btn_TroGiup.LargeWidth = 100;
            this.btn_TroGiup.Name = "btn_TroGiup";
            // 
            // btn_GioiThieu
            // 
            this.btn_GioiThieu.Caption = "Giới thiệu";
            this.btn_GioiThieu.Id = 12;
            this.btn_GioiThieu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_GioiThieu.ImageOptions.LargeImage")));
            this.btn_GioiThieu.LargeWidth = 70;
            this.btn_GioiThieu.Name = "btn_GioiThieu";
            this.btn_GioiThieu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_GioiThieu_ItemClick);
            // 
            // btn_DangXuat
            // 
            this.btn_DangXuat.Caption = "Đăng xuất";
            this.btn_DangXuat.Id = 13;
            this.btn_DangXuat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_DangXuat.ImageOptions.LargeImage")));
            this.btn_DangXuat.LargeWidth = 100;
            this.btn_DangXuat.Name = "btn_DangXuat";
            this.btn_DangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_DangXuat_ItemClick);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Caption = "Thoát";
            this.btn_Thoat.Id = 14;
            this.btn_Thoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Thoat.ImageOptions.LargeImage")));
            this.btn_Thoat.LargeWidth = 100;
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Thoat_ItemClick);
            // 
            // skinRibbonGalleryBarItem1
            // 
            this.skinRibbonGalleryBarItem1.Caption = "skinRibbonGalleryBarItem1";
            this.skinRibbonGalleryBarItem1.Id = 16;
            this.skinRibbonGalleryBarItem1.Name = "skinRibbonGalleryBarItem1";
            // 
            // btn_ThongKeTheoMH
            // 
            this.btn_ThongKeTheoMH.Caption = "Thống kê theo mặt hàng";
            this.btn_ThongKeTheoMH.Id = 17;
            this.btn_ThongKeTheoMH.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_ThongKeTheoMH.ImageOptions.LargeImage")));
            this.btn_ThongKeTheoMH.LargeWidth = 200;
            this.btn_ThongKeTheoMH.Name = "btn_ThongKeTheoMH";
            this.btn_ThongKeTheoMH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_ThongKeTheoMH_ItemClick);
            // 
            // btn_ThongKeTheoNgay
            // 
            this.btn_ThongKeTheoNgay.Caption = "Thống kê theo ngày";
            this.btn_ThongKeTheoNgay.Id = 18;
            this.btn_ThongKeTheoNgay.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_ThongKeTheoNgay.ImageOptions.LargeImage")));
            this.btn_ThongKeTheoNgay.LargeWidth = 200;
            this.btn_ThongKeTheoNgay.Name = "btn_ThongKeTheoNgay";
            this.btn_ThongKeTheoNgay.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_ThongKeTheoNgay_ItemClick);
            // 
            // btn_BaoCaoTongHop
            // 
            this.btn_BaoCaoTongHop.Caption = "Báo cáo tổng hợp";
            this.btn_BaoCaoTongHop.Id = 19;
            this.btn_BaoCaoTongHop.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_BaoCaoTongHop.ImageOptions.LargeImage")));
            this.btn_BaoCaoTongHop.LargeWidth = 200;
            this.btn_BaoCaoTongHop.Name = "btn_BaoCaoTongHop";
            this.btn_BaoCaoTongHop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_BaoCaoTongHop_ItemClick);
            // 
            // btn_QuanLyNhanVien
            // 
            this.btn_QuanLyNhanVien.Caption = "Quản lý nhân viên";
            this.btn_QuanLyNhanVien.Id = 20;
            this.btn_QuanLyNhanVien.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_QuanLyNhanVien.ImageOptions.LargeImage")));
            this.btn_QuanLyNhanVien.LargeWidth = 100;
            this.btn_QuanLyNhanVien.Name = "btn_QuanLyNhanVien";
            this.btn_QuanLyNhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_QuanLyNhanVien_ItemClick);
            // 
            // btn_DoiMk
            // 
            this.btn_DoiMk.Caption = "Đổi mật khẩu";
            this.btn_DoiMk.Id = 21;
            this.btn_DoiMk.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_DoiMk.ImageOptions.LargeImage")));
            this.btn_DoiMk.LargeWidth = 100;
            this.btn_DoiMk.Name = "btn_DoiMk";
            this.btn_DoiMk.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_DoiMk_ItemClick);
            // 
            // btn_ThongTinTaiKhoan
            // 
            this.btn_ThongTinTaiKhoan.Caption = "Thông tin tài khoản";
            this.btn_ThongTinTaiKhoan.Id = 22;
            this.btn_ThongTinTaiKhoan.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_ThongTinTaiKhoan.ImageOptions.LargeImage")));
            this.btn_ThongTinTaiKhoan.LargeWidth = 100;
            this.btn_ThongTinTaiKhoan.Name = "btn_ThongTinTaiKhoan";
            this.btn_ThongTinTaiKhoan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_ThongTinTaiKhoan_ItemClick);
            // 
            // btn_TheoDoiTruyCap
            // 
            this.btn_TheoDoiTruyCap.Caption = "Theo dõi truy cập";
            this.btn_TheoDoiTruyCap.Id = 23;
            this.btn_TheoDoiTruyCap.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_TheoDoiTruyCap.ImageOptions.LargeImage")));
            this.btn_TheoDoiTruyCap.LargeWidth = 100;
            this.btn_TheoDoiTruyCap.Name = "btn_TheoDoiTruyCap";
            this.btn_TheoDoiTruyCap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_TheoDoiTruyCap_ItemClick);
            // 
            // btn_ThietLap
            // 
            this.btn_ThietLap.Caption = "Thiết lập";
            this.btn_ThietLap.Id = 24;
            this.btn_ThietLap.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_ThietLap.ImageOptions.LargeImage")));
            this.btn_ThietLap.LargeWidth = 100;
            this.btn_ThietLap.Name = "btn_ThietLap";
            this.btn_ThietLap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_ThietLap_ItemClick);
            // 
            // btn_SaoLuu
            // 
            this.btn_SaoLuu.Caption = "Sao lưu ";
            this.btn_SaoLuu.Id = 25;
            this.btn_SaoLuu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_SaoLuu.ImageOptions.LargeImage")));
            this.btn_SaoLuu.LargeWidth = 100;
            this.btn_SaoLuu.Name = "btn_SaoLuu";
            this.btn_SaoLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_SaoLuu_ItemClick);
            // 
            // btn_PhucHoiHeThong
            // 
            this.btn_PhucHoiHeThong.Caption = "Phục hồi ";
            this.btn_PhucHoiHeThong.Id = 26;
            this.btn_PhucHoiHeThong.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_PhucHoiHeThong.ImageOptions.LargeImage")));
            this.btn_PhucHoiHeThong.Name = "btn_PhucHoiHeThong";
            this.btn_PhucHoiHeThong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_PhucHoiHeThong_ItemClick);
            // 
            // rbtQuanLy
            // 
            this.rbtQuanLy.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3,
            this.ribbonPageGroup4,
            this.ribbonPageGroup5,
            this.ribbonPageGroup6,
            this.ribbonPageGroup7,
            this.ribbonPageGroup8});
            this.rbtQuanLy.Name = "rbtQuanLy";
            this.rbtQuanLy.Text = "Quản lý";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "QL Khuyến mãi";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btn_QLMon);
            this.ribbonPageGroup4.ItemLinks.Add(this.btn_DSLoaiMon);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Quản lý thực đơn";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btn_QLBan);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Quản lý bàn";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.btn_MayTinh);
            this.ribbonPageGroup6.ItemLinks.Add(this.btn_Player);
            this.ribbonPageGroup6.ItemLinks.Add(this.btn_TroGiup);
            this.ribbonPageGroup6.ItemLinks.Add(this.btn_GioiThieu);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "Quản lý tiện ích";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.btn_DangXuat);
            this.ribbonPageGroup7.ItemLinks.Add(this.btn_Thoat);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            this.ribbonPageGroup7.Text = "Phiên làm việc";
            // 
            // ribbonPageGroup8
            // 
            this.ribbonPageGroup8.ItemLinks.Add(this.skinRibbonGalleryBarItem1);
            this.ribbonPageGroup8.Name = "ribbonPageGroup8";
            this.ribbonPageGroup8.Text = "Giao diện";
            // 
            // rbtThongKe
            // 
            this.rbtThongKe.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.rbtThongKe.Name = "rbtThongKe";
            this.rbtThongKe.Text = "Thống kê";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_ThongKeTheoNgay);
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_ThongKeTheoMH);
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_BaoCaoTongHop);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Thống kê- Báo cáo";
            // 
            // rbtHeThong
            // 
            this.rbtHeThong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup9,
            this.ribbonPageGroup10});
            this.rbtHeThong.Name = "rbtHeThong";
            this.rbtHeThong.Text = "Hệ thống";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_QuanLyNhanVien);
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_DoiMk);
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_ThongTinTaiKhoan);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Quản lý tài khoản";
            // 
            // ribbonPageGroup9
            // 
            this.ribbonPageGroup9.ItemLinks.Add(this.btn_TheoDoiTruyCap);
            this.ribbonPageGroup9.ItemLinks.Add(this.btn_ThietLap);
            this.ribbonPageGroup9.Name = "ribbonPageGroup9";
            this.ribbonPageGroup9.Text = "Tiện ích";
            // 
            // ribbonPageGroup10
            // 
            this.ribbonPageGroup10.ItemLinks.Add(this.btn_SaoLuu);
            this.ribbonPageGroup10.ItemLinks.Add(this.btn_PhucHoiHeThong);
            this.ribbonPageGroup10.Name = "ribbonPageGroup10";
            this.ribbonPageGroup10.Text = "Sao lưu - phục hồi hệ thống";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.lbl_Time);
            this.ribbonStatusBar.ItemLinks.Add(this.lb_Display);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 503);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1244, 31);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 143);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1244, 360);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // applicationMenu1
            // 
            this.applicationMenu1.MenuBarWidth = 50;
            this.applicationMenu1.Name = "applicationMenu1";
            this.applicationMenu1.Ribbon = this.ribbon;
            // 
            // frm_Mains
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 534);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Mains";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Hệ thống quản lý nhà hàng 2.0 Beta version";
            this.Load += new System.EventHandler(this.frm_Mains_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbtThongKe;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarStaticItem lbl_Time;
        private DevExpress.XtraBars.BarStaticItem lb_Display;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btn_QLMon;
        private DevExpress.XtraBars.BarButtonItem btn_DSLoaiMon;
        private DevExpress.XtraBars.BarButtonItem btn_QLBan;
        private DevExpress.XtraBars.BarButtonItem btn_MayTinh;
        private DevExpress.XtraBars.BarButtonItem btn_Player;
        private DevExpress.XtraBars.BarButtonItem btn_TroGiup;
        private DevExpress.XtraBars.BarButtonItem btn_GioiThieu;
        private DevExpress.XtraBars.BarButtonItem btn_DangXuat;
        private DevExpress.XtraBars.BarButtonItem btn_Thoat;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbtHeThong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbtQuanLy;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraBars.BarButtonItem btn_ThongKeTheoMH;
        private DevExpress.XtraBars.BarButtonItem btn_ThongKeTheoNgay;
        private DevExpress.XtraBars.BarButtonItem btn_BaoCaoTongHop;
        private DevExpress.XtraBars.BarButtonItem btn_QuanLyNhanVien;
        private DevExpress.XtraBars.BarButtonItem btn_DoiMk;
        private DevExpress.XtraBars.BarButtonItem btn_ThongTinTaiKhoan;
        private DevExpress.XtraBars.BarButtonItem btn_TheoDoiTruyCap;
        private DevExpress.XtraBars.BarButtonItem btn_ThietLap;
        private DevExpress.XtraBars.BarButtonItem btn_SaoLuu;
        private DevExpress.XtraBars.BarButtonItem btn_PhucHoiHeThong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup9;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup10;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        internal System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraBars.Ribbon.ApplicationMenu applicationMenu1;
    }
}