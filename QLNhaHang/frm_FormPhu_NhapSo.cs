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
    public partial class frm_FormPhu_NhapSo : DevExpress.XtraEditors.XtraForm
    {
        public frm_FormPhu_NhapSo()
        {
            InitializeComponent();
        }
        public int Number  { get; set; }
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_THem_Click(object sender, EventArgs e)
        {
            try
            {
                Number = int.Parse(txt_SoBan.Text);
                this.Close();
            }
            catch 
            {

                MessageBox.Show("Số liệu không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Number = -1;
            }
               
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}