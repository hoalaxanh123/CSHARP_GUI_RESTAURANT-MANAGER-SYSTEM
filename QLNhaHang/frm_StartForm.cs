using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;

namespace QLCaPheProject
{
    public partial class frm_StartForm : SplashScreen
    {
        public frm_StartForm()
        {
            InitializeComponent();
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }
        int waitTime = 0;
        private void frm_StartForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            waitTime++;
            if (waitTime == 3)
            {
                timer1.Stop();
                this.Close();
            }
             
        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}