using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DataAccess;
namespace QLCaPheProject
{
    public partial class frm_Log : DevExpress.XtraEditors.XtraForm
    {
        BaseFunctions<Log> objLog = new BaseFunctions<Log>();
        public frm_Log()
        {
            InitializeComponent();
        }

        private void frm_Log_Load(object sender, EventArgs e)
        {
            btn_Reload.PerformClick();
        }

        private void btn_Reload_Click(object sender, EventArgs e)
        {
            this.listView_Log.Items.Clear();
            foreach ( Log log in objLog.SelectAll())
            {
                this.listView_Log.Items.Add(MakeListViewItem(log));
                this.lbl_Status.Text = ("Tổng số dòng nhật ký : " + this.listView_Log.Items.Count);
            }
        }
        private ListViewItem MakeListViewItem(Log log)
        {
            ListViewItem item = new ListViewItem(log.ID.ToString());
            item.SubItems.Add(log.UserName.Trim());
            item.SubItems.Add(ShortDateTime(log.Date));
            item.SubItems.Add(log.Description.Trim());
            return item;
        }
        private string ShortDateTime(DateTime dateTime)
        {
            return dateTime.ToShortTimeString() + " - " + dateTime.ToShortDateString();
        }
        private void CheckDateTime()
        {
            if(this.dateTimePicker_NgayBatDau.Value>this.dateTimePicker_NgayKetThuc.Value)
            {
                MessageBox.Show("Ngày bắt đầu không thể lớn hơn ngày kết thúc ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.btn_LocTheoMocThoiGian.Enabled = false;
            }
            else
                this.btn_LocTheoMocThoiGian.Enabled = true;

        }
        private void btn_LocTheoMocThoiGian_Click(object sender, EventArgs e)
        {
            this.listView_Log.Items.Clear();
            List<Log> listLog = objLog.SelectAll();
            foreach (Log item in listLog)
            {
                if(item.Date>=this.dateTimePicker_NgayBatDau.Value && item.Date<=dateTimePicker_NgayKetThuc.Value)
                {
                    this.listView_Log.Items.Add(MakeListViewItem(item));
                }
            }
            if (this.listView_Log.Items.Count != 0)
                this.lbl_Status.Text = "Tìm thấy " + this.listView_Log.Items.Count +
                    " mẩu tin thuộc khoảng thời gian từ " + ShortDateTime(this.dateTimePicker_NgayBatDau.Value) + " tới  " +
                    ShortDateTime(this.dateTimePicker_NgayKetThuc.Value);
            else
            {
                MessageBox.Show("Không có dữ liệu nào thuộc thuộc khoảng thời gian từ " + ShortDateTime(this.dateTimePicker_NgayBatDau.Value) + " tới  " +
                    ShortDateTime(this.dateTimePicker_NgayKetThuc.Value));
                btn_Reload.PerformClick();
            }

        }

        private void dateTimePicker_NgayBatDau_ValueChanged(object sender, EventArgs e)
        {
            CheckDateTime();
        }

        private void btn_xoaNhatKyHeThong_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có chắc muốn xóa nhật ký hệ thống, việc này không thể khôi phục ? ", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(ret==DialogResult.Yes)
            {
               if( Log.XoaToanBo()>0)
                {
                    MessageBox.Show("Đã xóa nhật ký hệ thống", "Thông báo");
                    btn_Reload.PerformClick();
                }
               else
                {
                    MessageBox.Show("Đã xảy ra lỗi không xác định", "Lỗi");
                }
            }
        }
    }
}