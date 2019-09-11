using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QLCaPheProject
{
    public partial class frm_GioiThieu : DevExpress.XtraEditors.XtraForm
    {
        public frm_GioiThieu()
        {
            InitializeComponent();
        }

        private void frm_info_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string line = "Nếu cần trợ giúp xin hãy liên hệ cho đội ngũ kỹ thuật viên chúng tôi : \n  " +
                "Email :\n\t-nguyenvanvuong972@gmail.com \n" +
                "\t-cao.khanh.1997@gmail.com\n" +
                "\t-thoaixuan97@gmail.com\n" +
                "\t-nguyenhuuson1997it@gmail.com\n\n" +
                "Hotline: 0123.456.7789\n" +
                "Xin trân trọng cảm ơn\n" +
                "D.E.V Team";
            MessageBox.Show(line, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }
    }
}