namespace QLCaPheProject
{
    partial class frm_DoanhThuTheoNgay
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
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblThongKe = new DevComponents.DotNetBar.LabelX();
            this.listViewEx1 = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dateNavigator_Ngay = new DevExpress.XtraScheduler.DateNavigator();
            this.cmdOK = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.rdNgayKhac = new System.Windows.Forms.RadioButton();
            this.rdHomQua = new System.Windows.Forms.RadioButton();
            this.rdHomNay = new System.Windows.Forms.RadioButton();
            this.qatCustomizeItem1 = new DevComponents.DotNetBar.QatCustomizeItem();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.office2007StartButton1 = new DevComponents.DotNetBar.Office2007StartButton();
            this.ribbonControl1 = new DevComponents.DotNetBar.RibbonControl();
            this.groupPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator_Ngay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator_Ngay.CalendarTimeProperties)).BeginInit();
            this.groupPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "STT";
            this.columnHeader7.Width = 39;
            // 
            // lblThongKe
            // 
            this.lblThongKe.BackColor = System.Drawing.Color.Transparent;
            this.lblThongKe.ForeColor = System.Drawing.Color.Red;
            this.lblThongKe.Location = new System.Drawing.Point(3, 370);
            this.lblThongKe.Name = "lblThongKe";
            this.lblThongKe.Size = new System.Drawing.Size(594, 23);
            this.lblThongKe.TabIndex = 1;
            // 
            // listViewEx1
            // 
            // 
            // 
            // 
            this.listViewEx1.Border.Class = "ListViewBorder";
            this.listViewEx1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader4,
            this.columnHeader6,
            this.columnHeader8,
            this.columnHeader9});
            this.listViewEx1.FullRowSelect = true;
            this.listViewEx1.GridLines = true;
            this.listViewEx1.Location = new System.Drawing.Point(16, 12);
            this.listViewEx1.MultiSelect = false;
            this.listViewEx1.Name = "listViewEx1";
            this.listViewEx1.Size = new System.Drawing.Size(663, 361);
            this.listViewEx1.TabIndex = 0;
            this.listViewEx1.UseCompatibleStateImageBehavior = false;
            this.listViewEx1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Mã hóa đơn";
            this.columnHeader4.Width = 149;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Thời gian tạo";
            this.columnHeader6.Width = 169;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Người tạo";
            this.columnHeader8.Width = 118;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Tổng tiền";
            this.columnHeader9.Width = 186;
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.lblThongKe);
            this.groupPanel2.Controls.Add(this.listViewEx1);
            this.groupPanel2.Location = new System.Drawing.Point(260, 51);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(688, 417);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel2.TabIndex = 5;
            this.groupPanel2.Text = "Doanh thu các món";
            // 
            // dateNavigator_Ngay
            // 
            this.dateNavigator_Ngay.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNavigator_Ngay.CellPadding = new System.Windows.Forms.Padding(2);
            this.dateNavigator_Ngay.Cursor = System.Windows.Forms.Cursors.Default;
            this.dateNavigator_Ngay.DateTime = new System.DateTime(2014, 2, 11, 0, 0, 0, 0);
            this.dateNavigator_Ngay.EditValue = new System.DateTime(2014, 2, 11, 0, 0, 0, 0);
            this.dateNavigator_Ngay.FirstDayOfWeek = System.DayOfWeek.Sunday;
            this.dateNavigator_Ngay.Location = new System.Drawing.Point(39, 143);
            this.dateNavigator_Ngay.Name = "dateNavigator_Ngay";
            this.dateNavigator_Ngay.Size = new System.Drawing.Size(186, 167);
            this.dateNavigator_Ngay.TabIndex = 4;
            // 
            // cmdOK
            // 
            this.cmdOK.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cmdOK.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.cmdOK.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdOK.Location = new System.Drawing.Point(39, 336);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(186, 37);
            this.cmdOK.TabIndex = 3;
            this.cmdOK.Text = "Đồng ý";
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.dateNavigator_Ngay);
            this.groupPanel1.Controls.Add(this.cmdOK);
            this.groupPanel1.Controls.Add(this.rdNgayKhac);
            this.groupPanel1.Controls.Add(this.rdHomQua);
            this.groupPanel1.Controls.Add(this.rdHomNay);
            this.groupPanel1.Location = new System.Drawing.Point(7, 51);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(247, 417);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel1.TabIndex = 4;
            this.groupPanel1.Text = "Chọn ngày thống kê";
            // 
            // rdNgayKhac
            // 
            this.rdNgayKhac.AutoSize = true;
            this.rdNgayKhac.BackColor = System.Drawing.Color.Transparent;
            this.rdNgayKhac.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdNgayKhac.Location = new System.Drawing.Point(17, 113);
            this.rdNgayKhac.Name = "rdNgayKhac";
            this.rdNgayKhac.Size = new System.Drawing.Size(85, 24);
            this.rdNgayKhac.TabIndex = 1;
            this.rdNgayKhac.Text = "Ngày khác";
            this.rdNgayKhac.UseVisualStyleBackColor = false;
            // 
            // rdHomQua
            // 
            this.rdHomQua.AutoSize = true;
            this.rdHomQua.BackColor = System.Drawing.Color.Transparent;
            this.rdHomQua.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdHomQua.Location = new System.Drawing.Point(17, 73);
            this.rdHomQua.Name = "rdHomQua";
            this.rdHomQua.Size = new System.Drawing.Size(78, 24);
            this.rdHomQua.TabIndex = 1;
            this.rdHomQua.Text = "Hôm qua";
            this.rdHomQua.UseVisualStyleBackColor = false;
            // 
            // rdHomNay
            // 
            this.rdHomNay.AutoSize = true;
            this.rdHomNay.BackColor = System.Drawing.Color.Transparent;
            this.rdHomNay.Checked = true;
            this.rdHomNay.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdHomNay.Location = new System.Drawing.Point(17, 34);
            this.rdHomNay.Name = "rdHomNay";
            this.rdHomNay.Size = new System.Drawing.Size(76, 24);
            this.rdHomNay.TabIndex = 1;
            this.rdHomNay.TabStop = true;
            this.rdHomNay.Text = "Hôm nay";
            this.rdHomNay.UseVisualStyleBackColor = false;
            // 
            // qatCustomizeItem1
            // 
            this.qatCustomizeItem1.Name = "qatCustomizeItem1";
            // 
            // buttonItem1
            // 
            this.buttonItem1.ImagePaddingHorizontal = 8;
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.Text = "Restaurant manager";
            this.buttonItem1.Click += new System.EventHandler(this.buttonItem1_Click);
            // 
            // office2007StartButton1
            // 
            this.office2007StartButton1.AutoExpandOnClick = true;
            this.office2007StartButton1.CanCustomize = false;
            this.office2007StartButton1.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Image;
            this.office2007StartButton1.ImagePaddingHorizontal = 2;
            this.office2007StartButton1.ImagePaddingVertical = 2;
            this.office2007StartButton1.Name = "office2007StartButton1";
            this.office2007StartButton1.ShowSubItems = false;
            this.office2007StartButton1.Text = "&File";
            this.office2007StartButton1.Click += new System.EventHandler(this.office2007StartButton1_Click);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.CaptionVisible = true;
            this.ribbonControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonControl1.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.ribbonControl1.QuickToolbarItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.office2007StartButton1,
            this.buttonItem1,
            this.qatCustomizeItem1});
            this.ribbonControl1.Size = new System.Drawing.Size(959, 45);
            this.ribbonControl1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonControl1.TabGroupHeight = 14;
            this.ribbonControl1.TabIndex = 3;
            this.ribbonControl1.Text = "ribbonControl1";
            // 
            // frm_DoanhThuTheoNgay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 477);
            this.Controls.Add(this.groupPanel2);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_DoanhThuTheoNgay";
            this.Text = "Thống kê theo ngày";
            this.Load += new System.EventHandler(this.frm_DoanhThuTheoNgay_Load);
            this.groupPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator_Ngay.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator_Ngay)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private DevComponents.DotNetBar.LabelX lblThongKe;
        private DevComponents.DotNetBar.Controls.ListViewEx listViewEx1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevExpress.XtraScheduler.DateNavigator dateNavigator_Ngay;
        private DevComponents.DotNetBar.ButtonX cmdOK;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private System.Windows.Forms.RadioButton rdNgayKhac;
        private System.Windows.Forms.RadioButton rdHomQua;
        private System.Windows.Forms.RadioButton rdHomNay;
        private DevComponents.DotNetBar.QatCustomizeItem qatCustomizeItem1;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.Office2007StartButton office2007StartButton1;
        private DevComponents.DotNetBar.RibbonControl ribbonControl1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
    }
}